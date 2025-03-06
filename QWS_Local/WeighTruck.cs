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
             if (ParseWeight() == true && myWeight > 0.0M)
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
            int mySiteID = Properties.Settings.Default.SiteID;
            int iWBCount = taWBConfig4Site.Fill(dsTIQ2.WBConfig4Site, mySiteID);

            switch (iWBCount)
            {
                case 1:
                    rbWB1.Visible = true;
                    rbWB2.Visible = false;
                    rbWB3.Visible = false;
                    Instruction += "Single Weighbridge Site.";
                    // Check if WB Connected
                    dsTIQ2.WBConfig4SiteRow myWBConfigRow = dsTIQ2.WBConfig4Site[0];
                    bool WBConnected = myWBConfigRow.Connected;
                    if (WBConnected == true)
                    {
                        rbAuto.Checked = true;
                    }
                    else
                    {
                        rbManual.Checked = true;
                    }
                        break;
                case 2:
                    // TODO
                    break;
                case 3:
                    rbWB1.Visible = true;
                    rbWB2.Visible = true;
                    rbWB3.Visible = true;
                    Instruction += "\r\nSelect Weighbridge.";
                    // TODO Check if WB Connected after WB selected
                    break;
                default:
                    MessageBox.Show("Invalid weighbridge configuration.");
                    break;
            }
            txtInstruction.Text = Instruction;
            mtxtWeight.ReadOnly = true;
            // TODO check if WBConfig is Auto or Manual after WBn selected
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
                // TODO read WBConfig to see if WB is connected, toggle Auto/Manual accordingly
            }
            else if (rbWB2.Checked == true)
            {

            }
            else if (rbWB3.Checked == true)
            {

            }
        }

        private void CaptureSingleWeight()
        {
            decimal myWeight = 99.99M;
            // revise when to set buttons
            SetWeighButtons();
            int iWBCount = dsTIQ2.WBConfig4Site.Count();
            if (iWBCount == 1)
            {
                rbWB1.Checked = true;
            }
            if (rbWB1.Checked == true && rbAuto.Checked == true)
            //Properties.Settings.Default.AutoWeigh == true) // use button rather than [properties
            {
                txtWBInfo.Text = "Getting weight from WB1";
                WeighbridgeRead weighbridgeRead = new WeighbridgeRead();
                weighbridgeRead.ReadWeighbridge("NQWB1");
                MessageBox.Show("Fudge a pause to get weight");
                myWeight = weighbridgeRead.getCurrentWeight();
                weighbridgeRead.StopMonitoring();
                mtxtWeight.Text = myWeight.ToString();
            }
            else if (rbWB2.Checked == true && rbAuto.Checked == true)
            //Properties.Settings.Default.AutoWeigh == true)
            {
                txtWBInfo.Text = "Getting weight from WB2";
            }
            else if (rbWB3.Checked == true && rbAuto.Checked == true)
            {
                txtWBInfo.Text = "Getting weight from WB3";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Get new weight for selected WB, check if WB is selected if n > 1
            CaptureSingleWeight();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            // Monitor weight for 60 seconds then time out
        }
    }
}
