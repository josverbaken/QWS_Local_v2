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
        private int mySiteID;
        private int myWBID;
        private bool myWBConnected;

        public bool WBConnected
        {
            get { return myWBConnected; }
        }

        public int WBID
        {
            get { return myWBID; }
        }

        public decimal Weight
        {
            get { return myWeight; }
        }

        public WeighTruck()
        {
            InitializeComponent();
        }

        public WeighTruck(string myInstruction, int mySiteID)
        {
            InitializeComponent();
            Instruction = myInstruction;
            this.mySiteID = mySiteID;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
             if (ParseWeight() == true && myWeight > 0.0M)
            {
                if (rbManual.Checked)
                {
                    myWBConnected = false;
                }
                else
                {
                    myWBConnected = true;
                }
                if (rbWB1.Checked)
                {
                    myWBID = 1;
                }
                else if (rbWB2.Checked)
                {
                    myWBID = 2;
                }
                else if (rbWB3.Checked)
                {
                    myWBID = 3;
                }
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
                    // handle when site requires it
                    // currently NQ x3 WB and SQ x1 WB
                    break;
                case 3:
                    rbWB1.Visible = true;
                    rbWB2.Visible = true;
                    rbWB3.Visible = true;
                    Instruction += "\r\nSelect Weighbridge.";
                    // ToConsider Check if WB Connected after WB selected, maybe ping and if no answer switch to manual but this might confuse WBO
                    break;
                default:
                    MessageBox.Show("Invalid weighbridge configuration.");
                    break;
            }
            txtInstruction.Text = Instruction;
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
                btnCapture.Visible = true;
                btnCapture.Focus();
                //btnAccept.Focus();
            }
            else
            {
                mtxtWeight.ReadOnly = false;
                btnCapture.Visible = false;
                mtxtWeight.Focus();
            }
        }

        private void WBn_CheckChanged(object sender, EventArgs e)
        {
            if (rbWB1.Checked == true)
            {
                foreach (dsTIQ2.WBConfig4SiteRow configRow in dsTIQ2.WBConfig4Site)
                {
                    if (configRow.WeighbridgeID == 1)
                    {
                        if(configRow.Connected == true)
                        {
                            rbAuto.Checked = true;
                        }
                        else
                        {
                            rbManual.Checked = true;
                        }
                    }
               
                }
            }
            else if (rbWB2.Checked == true)
            {
                foreach (dsTIQ2.WBConfig4SiteRow configRow in dsTIQ2.WBConfig4Site)
                {
                    if (configRow.WeighbridgeID == 2)
                    {
                        if (configRow.Connected == true)
                        {
                            rbAuto.Checked = true;
                        }
                        else
                        {
                            rbManual.Checked = true;
                        }
                    }
                }
            }
            else if (rbWB3.Checked == true)
            {
                foreach (dsTIQ2.WBConfig4SiteRow configRow in dsTIQ2.WBConfig4Site)
                {
                    if (configRow.WeighbridgeID == 3 )
                    {
                        if (configRow.Connected == true)
                        {
                            rbAuto.Checked = true;
                        }
                        else
                        {
                            rbManual.Checked = true;
                        }
                    }
                }
            }
        }

        private void CaptureSingleWeight()
        {
            CaptureSingleWeightAsync();
        }
        private async Task CaptureSingleWeightAsync()
        {
            // get weight from appropriate site and weighbridge id
            // and change how to call GetSingleWeight, might need to add ScaleFactor to Properties
            // also check what other differences in process logic
            decimal myWeight = 99.99M;
            int iWBCount = dsTIQ2.WBConfig4Site.Count();
            if (iWBCount == 1)
            {
                rbWB1.Checked = true;
            }
            if (rbWB1.Checked == true && rbAuto.Checked == true)
            {
                WeighbridgeRead weighbridgeRead = new WeighbridgeRead();
                if (mySiteID == 7)
                {
                    myWeight = await weighbridgeRead.GetSingleWeight("NQWB1");
                }
                else if (mySiteID == 2)
                {
                    myWeight = await weighbridgeRead.GetSingleWeight("SQWB1");
                }
                mtxtWeight.Text = myWeight.ToString();
            }
            else if (rbWB2.Checked == true && rbAuto.Checked == true)
            {
                WeighbridgeRead weighbridgeRead = new WeighbridgeRead();
                myWeight = await weighbridgeRead.GetSingleWeight("NQWB2");
                mtxtWeight.Text = myWeight.ToString();
            }
            else if (rbWB3.Checked == true && rbAuto.Checked == true)
            {
                WeighbridgeRead weighbridgeRead = new WeighbridgeRead();
                myWeight = await weighbridgeRead.GetSingleWeight("NQWB3");
                mtxtWeight.Text = myWeight.ToString();
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
