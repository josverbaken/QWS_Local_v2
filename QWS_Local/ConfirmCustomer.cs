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
    public partial class ConfirmCustomer : Form
    {
        private string Rego;

        public ConfirmCustomer()
        {
            InitializeComponent();
        }

        public ConfirmCustomer(string myRego)
        {
            Rego = myRego;
            // TODO show customer info
            InitializeComponent();
        }
        private void btnNotOkay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }

        private void btnOkayOnce_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();   
        }

        private void btnOkayAlways_Click(object sender, EventArgs e)
        {
            // TODO enter preferred customer using stored procedure
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ConfirmCustomer_Load(object sender, EventArgs e)
        {
            txtRego.Text = Rego;
        }
    }
}
