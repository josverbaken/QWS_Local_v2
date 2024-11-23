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
             if (ParseWeight() == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Weight is zero!");
            }
        }

        private bool ParseWeight()
        {
            try
            {
                bool WeightOK = Decimal.TryParse(mtxtWeight.Text, out myWeight);
                return WeightOK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;   
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
            mtxtWeight.ReadOnly = true;
            if (Properties.Settings.Default.AutoWeigh == true)
            {
                rbAuto.Checked = true;
                rbManual.Checked = false;
            }
            else
            {
                rbAuto.Checked= false;
                rbManual.Checked = true;
            }
        }

         private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            SetWeighButtons();
        }

        private void SetWeighButtons()
        {
            if (rbAuto.Checked)
            {
                mtxtWeight.ReadOnly = true;
                btnAccept.Focus();
            }
            else
            {
                mtxtWeight.ReadOnly = false;
                mtxtWeight.Focus();
            }
        }

        private void WBn_CheckChanged(object sender, EventArgs e)
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
            SetWeighButtons();
        }
    }
}
