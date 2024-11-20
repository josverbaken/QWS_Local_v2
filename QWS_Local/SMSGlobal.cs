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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
