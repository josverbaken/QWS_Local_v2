using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QWS_Local
{
    public partial class BookInTruckStep1 : Form
    {
        private static bool FormLoaded = false;
        private static DateTime EntryDTTM;
        private static string CustCardCode;
        private static string ExBinCustomer;
        private enum TIQType
        {
            Retare,
            ExBin,
            Delivery
        }
        private enum LoadType
        {
            TK,
            TT,
            TKs,
            TRs,
            ST,
            BD,
            BDa,
            BDb,
            AD,
            ADa,
            ADb
        }

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
                //SetTruckConfigRadioButtons(1);
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
                BookInExBin();
            }            
        }

        private void BookInExBin()
        {
            int iTIQID = NewTIQ(TIQType.ExBin);
            if (iTIQID > 0)
            {
                BookInExBin frmExBin = new BookInExBin(iTIQID,CurrentConfigTruck().TruckConfigID, CustCardCode, ExBinCustomer, CurrentTruckDriver());
                frmExBin.MdiParent = this.MdiParent;
                frmExBin.Show();
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            GoToBookInDelivery();
        }

        private void GoToBookInDelivery()
        {
            BookInDeliveryOrder();
        }
        private void BookInDeliveryOrder()
        {
            int iTIQID = NewTIQ(TIQType.Delivery);
            if ( iTIQID > 0)
            {
                BookInDelivery frmDelivery = new BookInDelivery(iTIQID, CurrentConfigTruck().TruckConfigID, CurrentTruckDriver());
                frmDelivery.MdiParent = this.MdiParent;
                frmDelivery.Show();
            }
        }

          private void btnRetare_Click(object sender, EventArgs e)
        {
            txtTruckConfig.Text = LoadType.BD.ToString();
            int iTIQID = NewTIQ(TIQType.Retare);
            if (iTIQID > 0)
            {
                TrucksInQuarry frmTIQ = new TrucksInQuarry();
                frmTIQ.MdiParent = this.MdiParent;
                frmTIQ.RefreshQueue();
                frmTIQ.Show();
            }
        }

        private int NewTIQ(TIQType myTIQType)
        {
            try
            {                
                int iTIQID = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQAdd";
                cmd.Parameters.AddWithValue("@ParentTIQID", 0);
                cmd.Parameters.AddWithValue("@TIQOpen", true);
                cmd.Parameters.AddWithValue("@SiteID", Properties.Settings.Default.SiteID);
                cmd.Parameters.AddWithValue("@Rego", CurrentConfigTruck().RegoTk);
                cmd.Parameters.AddWithValue("@RegoTr1", CurrentConfigTruck().RegoTr1);
                cmd.Parameters.AddWithValue("@RegoTr2", CurrentConfigTruck().RegoTr2);
                cmd.Parameters.AddWithValue("@RegoTr3", CurrentConfigTruck().RegoTr3);
                cmd.Parameters.AddWithValue("@RegoTrailers", CurrentConfigTruck().RegoTrailer);
                cmd.Parameters.AddWithValue("@TruckConfig", CurrentConfigTruck().VehicleType);
                cmd.Parameters.AddWithValue("@TruckConfigID", CurrentConfigTruck().TruckConfigID);
                cmd.Parameters.AddWithValue("@AxleConfiguration", CurrentConfigTruck().AxleConfiguration);
                cmd.Parameters.AddWithValue("@FeeCode", CurrentConfigTruck().FeeCode);
                cmd.Parameters.AddWithValue("@ConfigSource", "n/a");
                cmd.Parameters.AddWithValue("@SchemeCode", "n/a");
                cmd.Parameters.AddWithValue("@RoadAccess", "n/a");
                cmd.Parameters.AddWithValue("@WeighbridgeID", 1);
                cmd.Parameters.AddWithValue("@CustomerCode", "tba");
                cmd.Parameters.AddWithValue("@Customer", "tba");
                cmd.Parameters.AddWithValue("@SAPOrder", -9);
                cmd.Parameters.AddWithValue("@DeliveryAddress", "tba");
                cmd.Parameters.AddWithValue("@CustON", "tba");
                cmd.Parameters.AddWithValue("@CartageCode", "tba");
                switch (myTIQType)
                {
                    case TIQType.Retare:
                        cmd.Parameters.AddWithValue("@QueueStatus", "T");
                        cmd.Parameters.AddWithValue("@Material", "Retare");
                        cmd.Parameters.AddWithValue("@MaterialDesc", "Retare Vehicle");
                        break;
                    case TIQType.ExBin:
                        cmd.Parameters.AddWithValue("@QueueStatus", "P");
 
                         cmd.Parameters.AddWithValue("@Material", "ExBin");
 
                         cmd.Parameters.AddWithValue("@MaterialDesc", "tba");
                        break;
                    case TIQType.Delivery:
                        cmd.Parameters.AddWithValue("@QueueStatus", "P");
                        cmd.Parameters.AddWithValue("@Material", "Delivery");
                        cmd.Parameters.AddWithValue("@MaterialDesc", "tba");
                        break;
                    default:
                        break;
                }
                cmd.Parameters.AddWithValue("@StockpileLotNo", 0);
                cmd.Parameters.AddWithValue("@TruckOwnerCode", CurrentConfigTruck().CardCode);
                cmd.Parameters.AddWithValue("@TruckOwner", CurrentConfigTruck().TruckOwner);
                cmd.Parameters.AddWithValue("@DriverID", CurrentTruckDriver().CntctCode);
                cmd.Parameters.AddWithValue("@Driver", CurrentTruckDriver().Person);
                cmd.Parameters.AddWithValue("@Payload", 0);
                cmd.Parameters.AddWithValue("@PayloadSplit", ""); // text 12.5/20.5
                cmd.Parameters.AddWithValue("@GCM", 0);
                cmd.Parameters.AddWithValue("@GVMTruck", 0);
                cmd.Parameters.AddWithValue("@Gross", 0.0M);
                cmd.Parameters.AddWithValue("@Tare", CurrentConfigTruck().Tare);
                cmd.Parameters.AddWithValue("@TareTk", 0);
                cmd.Parameters.AddWithValue("@Nett", 0.0M);
                cmd.Parameters.AddWithValue("@EntryDTTM", EntryDTTM);
                cmd.Parameters.AddWithValue("@TruckConfigDTTM", DateTime.Now);
                cmd.Parameters.AddWithValue("@AllocateDTTM", EntryDTTM);
                cmd.Parameters.AddWithValue("@ReleaseDTTM", EntryDTTM);
                cmd.Parameters.AddWithValue("@WeightDTTM", EntryDTTM);
                cmd.Parameters.AddWithValue("@AcceptanceDTTM", EntryDTTM);
                cmd.Parameters.AddWithValue("@ExitDTTM", EntryDTTM);
                sqlConnection.Open();
                iTIQID = System.Convert.ToInt32( cmd.ExecuteScalar());
                sqlConnection.Close();
                return iTIQID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -9;
            }
        }    
    }
}
