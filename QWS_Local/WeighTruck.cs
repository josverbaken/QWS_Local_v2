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
            if (Properties.Settings.Default.WBCount > 1)
            {
                rbWB1.Visible = true;
                rbWB2.Visible = true;
                rbWB3.Visible = true;
                Instruction += "\r\nSelect Weighbridge.";
            }
            else
            {
                rbWB1.Visible= false;
                rbWB2.Visible= false;
                rbWB3.Visible= false;
            }
            txtInstruction.Text = Instruction;
            if (Properties.Settings.Default.AutoWeigh == true)
            {
                rbAuto.Checked = true;
            }
            else
            { 
                rbAuto.Checked= false; 
            }
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

        private void WBn_CheckChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoWeigh == true)
            {
                if (rbWB1.Checked == true)
                {
                    txtWBInfo.Text = "Getting weight from WB1";
                }
                else if (rbWB2.Checked == true)
                {
                    txtWBInfo.Text = "Getting weight from WB2";
                }
                else if (rbWB3.Checked ==true)
                {
                    txtWBInfo.Text = "Getting weight from WB3";
                }
            }
        }
    }
}
