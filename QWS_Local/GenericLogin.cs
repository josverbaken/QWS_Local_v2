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
    public partial class GenericLogin : Form
    {
        private string myUserName;
        public string UserName
        {
            get { return myUserName; }
        }

        public GenericLogin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myUserName = txtFirstName.Text + "." + txtLastName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
