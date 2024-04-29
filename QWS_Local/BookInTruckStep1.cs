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
        private static string CustCardCode;
        private static string ExBinCustomer;

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
                SetTruckConfigRadioButtons(1);
                btnRetare.Enabled = false;
                btnRetare.BackColor = SystemColors.Control;
                dsQWSLocal.TruckDriver.Clear();
                dsTruckConfig.ConfiguredTrucks.Clear();
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
                    int myTruckConfigID = CurrentConfigTruck().TruckConfigID;
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
            GetConfiguredTrucksGVM();
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

            if (CheckFeeCode() == false)
            {
                OK2Proceed = false;
                MessageBox.Show("Unable to proceed, due to Fee Code axle restriction!");
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
            SetTruckConfigRadioButtons(1);
        }

        private void bsConfiguredTrucks_CurrentChanged(object sender, EventArgs e)
        {
            if (FormLoaded && bsConfiguredTrucks.Count > 0)
            {
                SetTruckConfigRadioButtons(CurrentConfigTruck().Compartments);
                // TODO check GVM vs MaxGVM once config chosen
            }
        }

        private bool CheckFeeCode()
        {
            int myAxles = CurrentConfigTruck().Axles;
            int myMaxAxles = CurrentConfigTruck().MaxAxles;
            if (myMaxAxles > 0 && myAxles > myMaxAxles)
            {
                return false;
            }
            return true;
        }

        private void btnGetDriver_Click(object sender, EventArgs e)
        {
            GotoGetTruckDriver();
        }

        private dsTruckConfig.ConfiguredTruckGVMRow CurrentTruckGVM()
        {
            try
            {
                if (bsConfiguredTruckGVM.Count > 0)
                {
                    DataRow myRow = ((DataRowView)bsConfiguredTruckGVM.Current).Row;
                    dsTruckConfig.ConfiguredTruckGVMRow configuredTruckGVMRow = (dsTruckConfig.ConfiguredTruckGVMRow)myRow;
                    return configuredTruckGVMRow;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private dsQWSLocal.TruckDriverRow CurrentTruckDriver()
        {
            if (bsTruckDriver.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTruckDriver.Current).Row;
                dsQWSLocal.TruckDriverRow myTruckDriverRow = (dsQWSLocal.TruckDriverRow)myRow;
                return myTruckDriverRow;
            }
            return null;
        }

        private void GotoGetTruckDriver()
        {
            bool OK2Proceed = false;
            if(CurrentConfigTruck().RegoCheck == true)
            {
                OK2Proceed = true;
            }
            else
            {
                MessageBox.Show("Rego expired - unable to proceed!");
            }
            int myAxles = CurrentConfigTruck().Axles;
            int myMaxAxles = CurrentConfigTruck().MaxAxles;
            if (myMaxAxles > 0 && myAxles > myMaxAxles)
            {
                OK2Proceed = false;
                MessageBox.Show("Unable to proceed, due to Fee Code axle restriction!");
            }
            if (OK2Proceed)
            {
                GetTruckDriver();
            }
        }

        private bool CheckRetareDue()
        {
            double TareInterval = Properties.Settings.Default.RetareInterval;
            DateTime RetareDT = CurrentConfigTruck().TareDT.AddDays(TareInterval);
            if (RetareDT < DateTime.Today)
            {
                btnRetare.BackColor = Color.Orange;
                return true;
            }
            else
            {
                btnRetare.BackColor = SystemColors.Control;
                return false;
            }
        }

        private void GetTruckDriver()
        {
            bool blOkay2Cart = true;
            bool RetareDue = CheckRetareDue();
            TruckDriverSearch frmTruckDriverSearch = new TruckDriverSearch(CurrentConfigTruck().CardCode);
            DialogResult dr = frmTruckDriverSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dsQWSLocal.TruckDriver.Clear();
                dsQWSLocal.TruckDriver.ImportRow(frmTruckDriverSearch.TruckDriverRow);
                bsTruckDriver.Position = 0;
                DataRow myRow = ((DataRowView)bsTruckDriver.Current).Row;
                dsQWSLocal.TruckDriverRow myTruckDriverRow = (dsQWSLocal.TruckDriverRow)myRow;
                if (myTruckDriverRow.LicenseExp < DateTime.Now)
                {
                    txtLicenseExp.BackColor = Color.Salmon;
                    blOkay2Cart = false;
                }
                else
                {
                    txtLicenseExp.BackColor = Color.PaleGreen;
                }
                if (myTruckDriverRow.InductionExp < DateTime.Now)
                {
                    txtInductionExp.BackColor = Color.Salmon;
                    blOkay2Cart = false;
                }
                else
                {
                    txtInductionExp.BackColor = Color.PaleGreen;
                }
                if (myTruckDriverRow.Active == "Y")
                {
                    txtActive.BackColor = Color.PaleGreen;
                }
                else
                {
                    txtActive.BackColor = Color.Salmon;
                    blOkay2Cart = false;
                }
                if (blOkay2Cart)
                {
                    txtOkay2Cart.Text = "Y";
                    txtOkay2Cart.BackColor = Color.PaleGreen;
                    btnExBin.Enabled = true;
                }
                else
                {
                    txtOkay2Cart.Text = "N";
                    txtOkay2Cart.BackColor = Color.Salmon;
                    btnExBin.Enabled = false;
                }
                if (myTruckDriverRow.Position == "Authorised Cartage Contractor")
                {
                    chkDriverACC.Checked = true;
                    if (chkACC.Checked == true)
                    {
                        btnDelivery.Enabled = true;
                    }
                }
                else
                {
                    chkDriverACC.Checked = false;
                    btnDelivery.Enabled = false;
                }
                if(RetareDue)
                {
                    btnExBin.Enabled = false;
                    btnDelivery.Enabled = false;
                }
                btnRetare.Enabled = true;
            }
        }

        private bool SetExBinCustomer()
        {
            int iCust = taPrefCustomers.FillBy(dsQWSLocal.VehiclePrefCustomers, CurrentConfigTruck().RegoTk);
            if (iCust > 0)
            {
                if (GetPrefCustomer() == true)
                {
                    // CardCode has been set
                    return true;
                }
                else
                {
                    // Search customers
                    bool CustomerFound = GetExBinCustomer();
                    return CustomerFound;
                }            
            }
            else
            {
                // Search customers
                bool CustomerFound = GetExBinCustomer();
                return CustomerFound;
            }
        }

        private bool GetPrefCustomer()
        {
            string myRego = CurrentConfigTruck().RegoTk;
            PreferredCustomers frmPrefCust = new PreferredCustomers(myRego);
            DialogResult dr = frmPrefCust.ShowDialog();
            if (dr == DialogResult.OK)
            {
                CustCardCode = frmPrefCust.customersRow.CardCode;
                ExBinCustomer = frmPrefCust.customersRow.PrefCustomer;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool GetExBinCustomer()
        {
            BusinessSearch frmBusinessSearch = new BusinessSearch();
            DialogResult dr = frmBusinessSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                CustCardCode = frmBusinessSearch.SAPCode;
                ExBinCustomer = frmBusinessSearch.BusinessName;
                return true;
            }
            else
            {
                MessageBox.Show("Customer not found/set. Cannot proceed!");
                return false;
            }
        }

        private void btnExBin_Click(object sender, EventArgs e)
        {
            GoToBookInExBin();
        }

        private void GoToBookInExBin()
        {
            if (SetExBinCustomer() == true)
            {
                int CompartmentCount = CurrentConfigTruck().Compartments;
                switch (CompartmentCount)
                {
                    case 1:
                        {
                            BookInExBin();
                        }
                        break;
                    case 2:
                        if (TruckConfigRBSet())
                        {
                            BookInExBin();
                        }
                        else
                        {
                            MessageBox.Show("Please set truck config!");
                        }
                        break;
                }
            }            
        }

        private void BookInExBin()
        {
            BookInExBin frmExBin = new BookInExBin(CurrentConfigTruck().TruckConfigID, CustCardCode, ExBinCustomer, CurrentTruckDriver());
            frmExBin.MdiParent = this.MdiParent;
            frmExBin.Show();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            BookInDeliveryOrder();
        }

        private void BookInDeliveryOrder()
        {
            BookInDelivery frmDelivery = new BookInDelivery(CurrentConfigTruck().TruckConfigID, CurrentTruckDriver());
            frmDelivery.MdiParent = this.MdiParent;
            frmDelivery.Show();
        }

        private void SetTruckConfigRadioButtons(int Compartments)
        {
            switch (Compartments)
            {
                case 2:
                    rbTnT.Enabled = true;
                    rbSplitLoad.Enabled = true;
                    rbTrailerOnly.Enabled = true;
                    break;
                case 1:
                    rbTnT.Enabled = false;
                    rbSplitLoad.Enabled = false;
                    rbTrailerOnly.Enabled = false;
                    rbTnT.Checked = false;
                    rbSplitLoad.Checked = false;
                    rbTrailerOnly.Checked = false;
                    break;
                default:
                    MessageBox.Show("Unexpected number of compartments: " + Compartments.ToString());
                    break;

            }
        }

        private bool TruckConfigRBSet()
        {
            if (rbTnT.Enabled && rbTnT.Checked)
            {
                return true;
            }
            if(rbSplitLoad.Enabled && rbSplitLoad.Checked)
            {
                return true;
            }
            if (rbTrailerOnly.Enabled && rbTrailerOnly.Checked)
            { 
                return true;
            }
            return false;
        }

        private void btnRetare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO implement retare and add to trucks in quarry queue.");
            BookInRetare();
        }


        private void BookInRetare()
        {
            try
            {
                DataRow dr = dsQWSLocal.TrucksInQuarry.NewRow();
                dsQWSLocal.TrucksInQuarryRow rowTIQ = (dsQWSLocal.TrucksInQuarryRow)dr;
                rowTIQ.TIQID = -1;
                rowTIQ.ParentTIQID = 0;
                rowTIQ.TIQOpen = true;
                rowTIQ.SiteID = Properties.Settings.Default.SiteID;
                rowTIQ.Rego = CurrentConfigTruck().RegoTk;
                rowTIQ.TruckConfig = "TK"; //TODO  TruckConfig;
                rowTIQ.TruckConfigID = CurrentConfigTruck().TruckConfigID;
                rowTIQ.AxleConfiguration = CurrentConfigTruck().AxleConfiguration;
                rowTIQ.FeeCode = CurrentConfigTruck().FeeCode;
                rowTIQ.ConfigSource = "n/a";// CurrentConfigTruck().ConfigSource;
                rowTIQ.SchemeCode = "n/a";// CurrentConfigTruck().SchemeCode;
                rowTIQ.RoadAccess = "n/a";// CurrentConfigTruck().RoadAccess;
                rowTIQ.QueueStatus = "T";
                rowTIQ.WeighbridgeID = 1;
                rowTIQ.SAPOrder = -9;
                rowTIQ.Material = "Retare";
                rowTIQ.MaterialDesc = "Retare Vehicle";
                rowTIQ.TruckOwnerCode = CurrentConfigTruck().CardCode;
                rowTIQ.TruckOwner = CurrentConfigTruck().TruckOwner;
                rowTIQ.DriverID = CurrentTruckDriver().CntctCode; 
                rowTIQ.Driver = CurrentTruckDriver().Person;
                rowTIQ.Payload = 0;
                rowTIQ.GCM = 0; // CurrentConfigTruck().GCM;
                rowTIQ.GVMTruck = 0; // CurrentConfigTruck().GVMTruck;
                rowTIQ.Tare = CurrentConfigTruck().Tare;
                rowTIQ.TareTk = 0; // CurrentConfigTruck().TareTk;
                rowTIQ.EntryDTTM = EntryDTTM;
                rowTIQ.AllocateDTTM = DateTime.Now;
                rowTIQ.ReleaseDTTM = DateTime.Now;
                dsQWSLocal.TrucksInQuarry.AddTrucksInQuarryRow(rowTIQ);
                int iRow = this.taTIQ.Update(dsQWSLocal.TrucksInQuarry);
                if (iRow == 1)
                {
                    TrucksInQuarry frmTIQ = new TrucksInQuarry();
                    frmTIQ.MdiParent = this.MdiParent;
                    frmTIQ.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
