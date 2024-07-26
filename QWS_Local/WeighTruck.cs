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
        private string Instruction;

        public decimal Weight
        {
            get { return myWeight; }
        }

        public WeighTruck()
        {
            InitializeComponent();
        }

        public WeighTruck(string myInstruction)
        {
            InitializeComponent();
            Instruction = myInstruction;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            ParseWeight();
            this.DialogResult= DialogResult.OK;
            this.Close();   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void WeighTruck_Load(object sender, EventArgs e)
        {
            txtInstruction.Text = Instruction;  
        }


        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAuto.Checked)
            {
                mtxtWeight.ReadOnly = true;
                btnAccept.Focus();
            }
            else
            {
                WeightFocus();
            }
        }

        private void WeightFocus()
        {
            mtxtWeight.ReadOnly = false;
            mtxtWeight.Focus();
        }
 
    }
}
