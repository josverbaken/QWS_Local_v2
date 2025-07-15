using Azure.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class SMTP2GO : Form
    {
        public SMTP2GO()
        {
            InitializeComponent();
        }


        private async Task SendSMSAsync(string message)
        {
            // Key api-E167F974C30E4DC1B7F1CF18A5BC43BB
            var options = new RestClientOptions("https://api.smtp2go.com/v3/sms/send");
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("X-Smtp2go-Api-Key", "api-E167F974C30E4DC1B7F1CF18A5BC43BB");
            request.AddJsonBody("{\"destination\":[\"+61409163869\"],\"sender\":\"+614\",\"content\":\"hello from qws version 2\"}", false);
            var response = await client.PostAsync(request);

            txtResult.Text = response.Content;
            //Console.WriteLine("{0}", response.Content);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO handle async nicely!
                SendSMSAsync(txtMessage.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            txtMessage.SelectAll();
        }

        private void txtMessage_Click(object sender, EventArgs e)
        {
            txtMessage.SelectAll();
        }
    }
}
