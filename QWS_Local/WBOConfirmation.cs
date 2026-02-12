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
    public partial class WBOConfirmation : Form
    {
        public WBOConfirmation()
        {
            InitializeComponent();
        }

        public WBOConfirmation(string Message)
        {
            InitializeComponent();
            myMessage = Message;
        }

        private string myMessage;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (txtUnlockPIN.Text == txtPIN.Text)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter matching PIN","Invalid PIN",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void WBOConfirmation_Load(object sender, EventArgs e)
        {
            txtMessage.Text = myMessage;
            txtUnlockPIN.Text = GenerateUnlockPIN();
            // txtPIN.Focus(); does not work, so set tab index and tabstop = false for message text box
        }

        private string GenerateUnlockPIN()
        {
            // It is important to reuse a single instance of Random for repeated calls, 
            // rather than creating a new one each time, to avoid generating the same number repeatedly.
            Random random = new Random();
            int pin = random.Next(0, 10000); // Generates a number between 0 and 9999
            return pin.ToString("D4"); // Formats the number to ensure 4 digits, padding with leading zeros if necessary
        }
    }
}
