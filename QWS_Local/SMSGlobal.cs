using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformSMS
{
    public partial class SMSGlobal : Form
    {
 
        const string method = "POST";
        const string uri = "/v2/sms/";
        const string host = "api.smsglobal.com";
        const string port = "443";

        const string apiKey = "290ca44ec8ab926c392468fcbab3d8ac";
        const string apiSecret = "7465713937d2e2189d0a11e9a5be0f4b";

        public SMSGlobal()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            PrepareSMS();
        }

        private void PrepareSMS()
        {
            // This method can be used to prepare the SMS message before sending
            // For example, you can validate the mobile number and message content here
            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                MessageBox.Show("Please enter a valid mobile number.");
                return;
            }
            else if (txtMobile.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid mobile number with at least 10 digits.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Please enter a message to send.");
                return;
            }
            // Additional preparation logic can be added here
            txtResponse.Text = ShowJSON();
            BeforeSendScript();
            PostMessage();
        }

        private void BeforeSendScript()
        {
            // Inform user to set environment variables for API Key and Secret
            //MessageBox.Show("Before sending the SMS, ensure you have set your API Key and Secret in the environment variables.");

            // Example usage (debug): build auth header if env vars exist
            //var apiKey = "290ca44ec8ab926c392468fcbab3d8ac";//Environment.GetEnvironmentVariable("smsglobal_api_key");
            //var apiSecret = "7465713937d2e2189d0a11e9a5be0f4b";// Environment.GetEnvironmentVariable("smsglobal_api_secret");

            if (!string.IsNullOrWhiteSpace(apiKey) && !string.IsNullOrWhiteSpace(apiSecret))
            {
                // Values for SMSGlobal (example)
               

                var authHeader = BuildMacAuthHeader(apiKey, apiSecret, method, uri, host, port);

                // Show header in response textbox for debugging (do not log secrets in production)
                txtResponse.Text += "\r\nAuthorization: " + authHeader;
            }
            else
            {
                txtResponse.Text += "\r\nEnvironment variables 'smsglobal_api_key' or 'smsglobal_api_secret' are not set.";
            }
        }

        private async void PostMessage()
        {
            //MessageBox.Show("This method will handle the actual sending of the SMS message using the SMSGlobal API.");

            //var apiKey = Environment.GetEnvironmentVariable("smsglobal_api_key");
            //var apiSecret = Environment.GetEnvironmentVariable("smsglobal_api_secret");

            string authHeader = null;
            if (!string.IsNullOrWhiteSpace(apiKey) && !string.IsNullOrWhiteSpace(apiSecret))
            {
                authHeader = BuildMacAuthHeader(apiKey, apiSecret, method, uri, host, port);
            }

            await SendJsonPostAsync(authHeader);
        }

        private string ShowJSON()
        {
            // 1. Create a quick, anonymous object
            var user = new
            {
                destination = txtMobile.Text,
                message = txtMessage.Text
            };

            // 2. Serialize it to a JSON string
            string jsonString = JsonSerializer.Serialize(user);
            return jsonString;
        }

        private static string ComputeHmacSha256Base64(string secret, string data)
        {
            if (secret == null) throw new ArgumentNullException(nameof(secret));
            if (data == null) throw new ArgumentNullException(nameof(data));

            var keyBytes = Encoding.UTF8.GetBytes(secret);
            var dataBytes = Encoding.UTF8.GetBytes(data);

            using (var hmac = new HMACSHA256(keyBytes))
            {
                var hash = hmac.ComputeHash(dataBytes);
                return Convert.ToBase64String(hash);
            }
        }

        private static string BuildMacAuthHeader(string apiKey, string apiSecret, string method, string uri, string host, string port)
        {
            if (apiKey == null) throw new ArgumentNullException(nameof(apiKey));
            if (apiSecret == null) throw new ArgumentNullException(nameof(apiSecret));
            if (method == null) throw new ArgumentNullException(nameof(method));
            if (uri == null) throw new ArgumentNullException(nameof(uri));
            if (host == null) throw new ArgumentNullException(nameof(host));
            if (port == null) throw new ArgumentNullException(nameof(port));

            // Timestamp in seconds
            var ts = ((int)DateTimeOffset.UtcNow.ToUnixTimeSeconds()).ToString();

            // Secure nonce (16 hex chars)
            var nonceBytes = new byte[8];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(nonceBytes);
            }
            var nonce = BitConverter.ToString(nonceBytes).Replace("-", "").ToLowerInvariant();

            // MAC string to sign: ts + "\n" + nonce + "\n" + method + "\n" + uri + "\n" + host + "\n" + port + "\n\n"
            var macStringBuilder = new StringBuilder();
            macStringBuilder.Append(ts).Append('\n');
            macStringBuilder.Append(nonce).Append('\n');
            macStringBuilder.Append(method.ToUpperInvariant()).Append('\n');
            macStringBuilder.Append(uri).Append('\n');
            macStringBuilder.Append(host).Append('\n');
            macStringBuilder.Append(port).Append("\n\n");

            var macString = macStringBuilder.ToString();

            // Compute HMAC-SHA256 and Base64 encode
            var mac = ComputeHmacSha256Base64(apiSecret, macString);

            // Build Authorization header value
            var authHeader = string.Format("MAC id=\"{0}\", ts=\"{1}\", nonce=\"{2}\", mac=\"{3}\"",
                apiKey, ts, nonce, mac);

            return authHeader;
        }

        public async Task SendJsonPostAsync(string authHeader = null)
        {
            // It is best practice to reuse HttpClient instances rather than instantiating them per-request,
            // but for this sample we'll create one per call and dispose it (suitable for demos).
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (!string.IsNullOrWhiteSpace(authHeader))
                {
                    // Authorization header contains the whole MAC header string; use TryAddWithoutValidation
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authHeader);
                }

                var jsonPayload = ShowJSON();
                using (var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json"))
                {
                    try
                    {
                        // Replace with the real SMSGlobal endpoint when ready
                        string endpoint = "https://api.smsglobal.com/v2/sms/";
                        var requestUri = endpoint; // "https://httpbin.org/post";

                        var response = await client.PostAsync(requestUri, content);

                        var responseBody = await response.Content.ReadAsStringAsync();

                        txtResponse.Text += "\r\nStatus: " + response.StatusCode;
                        txtResponse.Text += "\r\nResponse: " + responseBody;
                    }
                    catch (Exception ex)
                    {
                        txtResponse.Text += "\r\nException sending request: " + ex.Message;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
