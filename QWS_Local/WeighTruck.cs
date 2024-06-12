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
    public partial class WeighTruck : Form
    {
        private decimal myWeight;

        public decimal Weight
        {
            get { return myWeight; }
        }

        public WeighTruck()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CancellationReason();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ParseWeight();
            this.DialogResult= DialogResult.OK;
            this.Close();   
        }

        private void ParseWeight()
        {
            try
            {
                myWeight = System.Convert.ToDecimal(mtxtWeight.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancellationReason()
        {
            txtMessage.ReadOnly=false;
            txtMessage.Text = "Enter cancellation reason :";
            txtMessage.SelectAll();
            txtMessage.Focus();
        }

        private void txtMessage_Validated(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
