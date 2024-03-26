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
    public partial class BookInTruckStep1 : Form
    {
        private static bool FormLoaded = false;
        private static DateTime EntryDTTM;

        public BookInTruckStep1()
        {
            InitializeComponent();
        }

        private void btnFindTruck_Click(object sender, EventArgs e)
        {
            FindTruckConfig(txtTruckRego.Text);
        }

        private void FindTruckConfig(string Rego)
        {
            try
            {
                dsTruckConfig.ConfiguredTruckGVM.Clear();
                int iCount = taConfiguredTrucks.FillByRego(dsTruckConfig.ConfiguredTrucks, Rego);
                if (iCount > 0)
                {
                    EntryDTTM = DateTime.Now;
                    UpdateOwnerGUI();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Configuration not found! Press Okay to go to vehicle search.","Configuration not found.",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        VehicleMaintenance vehicle = new VehicleMaintenance();
                        vehicle.FindVehicleByCallingRego(Rego);
                        vehicle.MdiParent = this.MdiParent;
                        vehicle.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateOwnerGUI()
        {
            if ( CurrentConfigTruck().CardStatus != "A")
            {
                txtCardStatus.BackColor = Color.Salmon;
            }
            else
            {
                txtCardStatus.BackColor = Color.PaleGreen;
            }

            if (CurrentConfigTruck().GroupCode == 117 )
            {
                chkACC.Checked = true;
            }
            else
            {
                chkACC.Checked = false;
            }
        }  

        private dsTruckConfig.ConfiguredTrucksRow CurrentConfigTruck()
        {
            if (bsConfiguredTrucks.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsConfiguredTrucks.Current).Row;
                dsTruckConfig.ConfiguredTrucksRow configuredTruckRow = (dsTruckConfig.ConfiguredTrucksRow)myRow;
                return configuredTruckRow;
            }
            else
            {
                return null;
            }
        }

        private void GetConfiguredTrucksGVM()
        {
            try
            {
                if (FormLoaded == true && bsConfiguredTrucks.Count > 0)
                {
                    int myTruckConfigID = 26;
                    myTruckConfigID = CurrentConfigTruck().TruckConfigID;
                    taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", myTruckConfigID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            bool OK2Proceed = true;
            DataRow myDR = ((DataRowView)bsConfiguredTruckGVM.Current).Row;
            dsTruckConfig.ConfiguredTruckGVMRow truckConfigRow = (dsTruckConfig.ConfiguredTruckGVMRow)myDR;
            // Check if SR conditon applies and handle GVM before proceeding

            if (truckConfigRow.MaxGVM > 0 && truckConfigRow.GCM > truckConfigRow.MaxGVM)
            {
                MessageBox.Show("GCM will be reduced to " + truckConfigRow.MaxGVM.ToString() + " due to Fee Code conditions");
            }

            if (truckConfigRow.RegoCheck == false)
            {
                OK2Proceed = false;
                MessageBox.Show("Registration has expired, cannot proceed!");
            }

            if (truckConfigRow.CardStatus != "A")
            {
                OK2Proceed = false;
                MessageBox.Show("Account NOT Active, cannot proceed!");
            }

            if (OK2Proceed)
            {
                BookInTruck frmBookInTruck = new BookInTruck(truckConfigRow, EntryDTTM);
                frmBookInTruck.MdiParent = this.MdiParent;
                frmBookInTruck.Show();
            }
        }

        private void BookInTruckStep1_Load(object sender, EventArgs e)
        {
            FormLoaded = true;
        }

        private void bsConfiguredTrucks_CurrentChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                bool OKAY2Proceed = true;
                // test if SR conditions might apply
                if (CurrentConfigTruck().Axles > CurrentConfigTruck().MaxAxles)
                {
                    OKAY2Proceed = false;
                    MessageBox.Show("Unable to proceed, due to Fee Code axle restriction!");
                }
                if (OKAY2Proceed)
                {
                    GetConfiguredTrucksGVM();
                    // TODO check GVM vs MaxGVM once config chosen
                }
            }
        }

        private void btnSelectCombinaton_Click(object sender, EventArgs e)
        {
            try
            {
                dsTruckConfig.ConfiguredTruckGVM.Clear();
                bool OKAY2Proceed = true;
                // test if SR conditions might apply
                int myAxles = CurrentConfigTruck().Axles;
                int myMaxAxles = CurrentConfigTruck().MaxAxles;
                if (myMaxAxles > 0 && myAxles > myMaxAxles )
                {
                    OKAY2Proceed = false;
                    MessageBox.Show("Unable to proceed, due to Fee Code axle restriction!");
                }
                if (OKAY2Proceed)
                {
                    GetConfiguredTrucksGVM();
                    // TODO check GVM vs MaxGVM once config chosen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
