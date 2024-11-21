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
    public partial class SMSGlobal : Form
    {
        public SMSGlobal()
        {
            InitializeComponent();
        }

        // Name Quarry2	
        // Key  290ca44ec8ab926c392468fcbab3d8ac
        // Secret   7465713937d2e2189d0a11e9a5be0f4b
        // Date Dec 30, 2016 1:02:12 PM

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMessage.TextLength > 160)
                {
                    MessageBox.Show("SMS message length limit (160) exceeded!\r\nSplit into multiple messages?");
                }
                else
                {
                    MessageBox.Show(txtMessage.Text + "\r\nTo send to " + txtMobilePhone.Text);

                    // SMSGlobal API not compatible!@#
                    //var client = new Client(new Credentials("SMSGLOBAL-API-KEY", "SMSGLOBAL-SECRET-KEY"));

                    //var response = await client.SMS.SMSSend(new
                    //{
                    //    origin = "Test",
                    //    destination = "DESTINATION-NUMBER",
                    //    message = "This is a test message"
                    //});

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
