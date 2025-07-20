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
using static QWS_Local.dsTIQ2;

namespace QWS_Local
{
    public partial class SMTP2GO : Form
    {
        private int myDocNum;
        private string myRecipient;
        private string myMessage;

        public SMTP2GO()
        {
            InitializeComponent();
        }

        public SMTP2GO(string Recipient, string Message)
        {
            InitializeComponent();
            myRecipient = Recipient;
            myMessage = Message;    
        }

        public SMTP2GO(int DocNum)
        {
            InitializeComponent();
            myDocNum = DocNum;
        }

        private void SetSMSVariables()
        {
            int iRow = taWBDockets.FillBy(dsTIQ2.WBDockets, myDocNum);
            if (iRow == 1)
            {
                WBDocketsRow myDocket = (WBDocketsRow)dsTIQ2.WBDockets.Rows[0];
                if (myDocket.ContactMobile.StartsWith("04") == true)
                {
                    string mobile = "+614";
                    mobile += myDocket.ContactMobile.Substring(2).Replace(" ", "");
                    txtRecipient.Text = mobile;
                    txtMessage.Text = "Dear " + myDocket.ContactName;
                    txtMessage.Text += ", your load has left the quarry aboard ";
                    txtMessage.Text += myDocket.TruckRego + " with payload of " + myDocket.Nett.ToString();
                    txtMessage.Text += "t"; // of " + myDocket.
                    // need DocketLine for Material
                    bsWBDockets.EndEdit();
                }
                else
                {
                    MessageBox.Show("Can't semd SMS, invalid phone number : " + myDocket.ContactMobile.ToString());
                }
            }
        }

        private async Task SendSMSAsync(string message, bool test)
        {
            // Key api-E167F974C30E4DC1B7F1CF18A5BC43BB
            // message length set to 549 = 3 units
            var options = new RestClientOptions("https://api.smtp2go.com/v3/sms/send");
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("X-Smtp2go-Api-Key", "api-E167F974C30E4DC1B7F1CF18A5BC43BB");
            // construct json body
            string jsonbody = "{\"destination\":[\""; //
            jsonbody += txtRecipient.Text + "\"],\"sender\":\"+614\",\"content\":\"";
            jsonbody += txtMessage.Text + "\"}";
            //"{\"destination\":[\"+61409163869\"],\"sender\":\"+614\",\"content\":\"hello from qws version 2\"}"
            // note each name:value pair is wrapped individually in quotes with colon as separator
            if (test == true)
            {
                txtResult.Text =   jsonbody;
                txtMsgLength.Text = jsonbody.Length.ToString();
            }
            else
            {
                request.AddJsonBody(jsonbody, false);
                var response = await client.PostAsync(request);
                txtResult.Text = response.Content;
            }
            //Console.WriteLine("{0}", response.Content);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO handle async nicely!
                SendSMSAsync(txtMessage.Text, false);
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            SendSMSAsync(txtMessage.Text,true);
        }

        private void wBDocketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsWBDockets.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsTIQ2);

        }

        private void SMTP2GO_Load(object sender, EventArgs e)
        {
            if (myDocNum > 0)
            {
                SetSMSVariables();
            }
        }

        private void btnCloseSuccessful_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
