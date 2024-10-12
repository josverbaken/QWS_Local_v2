using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Data.SqlClient;

namespace QWS_Local
{
    public partial class BookInTruckStep1 : Form
    {
        private static DateTime EntryDTTM;
        private static string CustCardCode;
        private static string ExBinCustomer;
        private static bool IsPrefCust = false;
        private static bool IsAlreadyBookedIn = false;
        private static string CallingMessage = "";
        private static int DriverID = 0;
        private static string SplitTruckConfig = "Single";

        private enum TIQType
        {
            Retare,
            OnHold,
            ExBin,
            Imported,
            Delivery,
            Split,
            ParkUp
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

        public BookInTruckStep1(string Rego, int TruckConfigID, int myDriverID, string mySplitTruckConfig, string Message)
        {
            InitializeComponent();
            CallingMessage = Message;
            FindTruckConfig(Rego);
            SelectTruckConfig(TruckConfigID);
            DriverID = myDriverID;
            SplitTruckConfig = mySplitTruckConfig;
        }

        private void btnFindTruck_Click(object sender, EventArgs e)
        {
            FindTruckConfig(txtTruckRego.Text);
        }

        private void FindTruckConfig(string Rego)
        {
            try
            {
                btnRetare.Enabled = false;
                btnRetare.BackColor = SystemColors.Control;
                dsQWSLocal2024.TruckDriver.Clear();
                dsTruckConfig.ConfiguredTrucks.Clear();
                int iCount = taConfiguredTrucks.FillByRego(dsTruckConfig.ConfiguredTrucks, Rego);
                if (iCount > 0)
                {
                    EntryDTTM = DateTime.Now;
                    UpdateOwnerGUI();
                    //TODO check if already booked in
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Configuration not found! Press Okay to go to vehicle search.", "Configuration not found.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
            if (CurrentConfigTruck().CardStatus != "A")
            {
                txtCardStatus.BackColor = Color.Salmon;
            }
            else
            {
                txtCardStatus.BackColor = Color.PaleGreen;
            }

            if (CurrentConfigTruck().GroupCode == 117)
            {
                chkACC.Checked = true;
            }
            else
            {
                chkACC.Checked = false;
            }

        }

        private void SelectTruckConfig(int TruckConfigID)
        {
            int index = bsConfiguredTrucks.Find("TruckConfigID", TruckConfigID);
            if (index >= 0)
            {
                bsConfiguredTrucks.Position = index;
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

        private void BookInTruckStep1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            if (CallingMessage.Length > 0)
            {
                MessageBox.Show(CallingMessage);
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
            GetTruckDriver();
        }

        private dsQWSLocal2024.TruckDriverRow CurrentTruckDriver()
        {
            if (bsTruckDriver.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTruckDriver.Current).Row;
                dsQWSLocal2024.TruckDriverRow myTruckDriverRow = (dsQWSLocal2024.TruckDriverRow)myRow;
                return myTruckDriverRow;
            }
            return null;
        }

        private void CheckConfigOK2Proceed()
        {
            btnGetDriver.Enabled = false;
            bool OK2Proceed = false;
            if (CurrentConfigTruck().RegoCheck == true)
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
                btnGetDriver.Enabled = true;
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
            bool blOK4ExBin = true;
            bool blInduction = false;
            bool RetareDue = CheckRetareDue();
            bool blOkay2Proceed = false;
            if (DriverID > 0) // driver pre-selected on prior iteration
            {
                taTruckDriver1.FillByCardCode(dsQWSLocal2024.TruckDriver, CurrentConfigTruck().CardCode);
                int index = bsTruckDriver.Find("CntctCode", DriverID);
                if (index > 0)
                {
                    bsTruckDriver.Position = index;
                }
                blOkay2Proceed = true;
            }
            else
            {
                TruckDriverSearch frmTruckDriverSearch = new TruckDriverSearch(CurrentConfigTruck().CardCode);
                DialogResult dr = frmTruckDriverSearch.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    dsQWSLocal2024.TruckDriver.Clear();
                    dsQWSLocal2024.TruckDriver.ImportRow(frmTruckDriverSearch.TruckDriverRow);
                    bsTruckDriver.Position = 0;
                    blOkay2Proceed = true;
                }
            }

            if (blOkay2Proceed == true)
            {
                DataRow myRow = ((DataRowView)bsTruckDriver.Current).Row;
                dsQWSLocal2024.TruckDriverRow myTruckDriverRow = (dsQWSLocal2024.TruckDriverRow)myRow;
                if (myTruckDriverRow.LicenseExp < DateTime.Now)
                {
                    txtLicenseExp.BackColor = Color.Salmon;
                    blOkay2Cart = false;
                    blOK4ExBin = false;
                }
                else
                {
                    txtLicenseExp.BackColor = Color.PaleGreen;
                }
                if (myTruckDriverRow.InductionExp < DateTime.Now)
                {
                    txtInductionExp.BackColor = Color.Orange;
                    blOkay2Cart = false;
                }
                else
                {
                    blInduction = true;
                    txtInductionExp.BackColor = Color.PaleGreen;
                }
                if (blOkay2Cart)
                {
                    btnExBin.Enabled = true;
                    btnImported.Enabled = true;
                }
                else
                {
                    if (blOK4ExBin == true)
                    {
                        btnExBin.Enabled = true;
                    }
                    else
                    {
                        btnExBin.Enabled = false;
                    }
                    btnImported.Enabled = false;
                }
                if (myTruckDriverRow.Position == "Authorised Cartage Contractor")
                {
                    if (chkACC.Checked == true && blInduction == true)
                    {
                        btnDelivery.Enabled = true;
                    }
                }
                else
                {
                    btnDelivery.Enabled = false;
                }
                if (RetareDue)
                {
                    btnExBin.Enabled = false;
                    btnDelivery.Enabled = false;
                    btnImported.Enabled = false;
                }
                btnRetare.Enabled = true;
            }
        }

        private bool SetExBinCustomer()
        {
            int iCust = taPrefCustomers2.FillBy(dsQWSLocal2024.VehiclePrefCustomers, CurrentConfigTruck().RegoTk);
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
            frmPrefCust.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = frmPrefCust.ShowDialog();
            if (dr == DialogResult.OK)
            {
                CustCardCode = frmPrefCust.customersRow.CardCode;
                ExBinCustomer = frmPrefCust.customersRow.PrefCustomer;
                IsPrefCust = true;
                return true;
            }
            else
            {
                IsPrefCust = false;
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
            GoToBookInExBin(TIQType.ExBin);
        }

        private void GoToBookInExBin(TIQType myTIQType)
        {
            if (SetExBinCustomer() == true)
            {
                BookInExBin(myTIQType);
            }
        }

        private void BookInExBin(TIQType myTIQType)
        {
            int iTIQID = NewTIQ(myTIQType);
            if (iTIQID > 0)
            {
                BookInExBin frmExBin = new BookInExBin(iTIQID, myTIQType.ToString(), SplitTruckConfig, CurrentConfigTruck().TruckConfigID, CustCardCode, ExBinCustomer, IsPrefCust, CurrentTruckDriver());
                frmExBin.MdiParent = this.MdiParent;
                frmExBin.Show();
                this.Close();
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
            if (iTIQID > 0)
            {
                BookInDelivery frmDelivery = new BookInDelivery(iTIQID, CurrentConfigTruck().TruckConfigID, CurrentTruckDriver());
                frmDelivery.MdiParent = this.MdiParent;
                frmDelivery.Show();
                this.Close();
            }
        }

        private void btnRetare_Click(object sender, EventArgs e)
        {
            txtTruckConfig.Text = LoadType.BD.ToString(); // TODO why?
            int iTIQID = NewTIQ(TIQType.Retare);
            if (iTIQID > 0)
            {
                ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();
                this.Close();
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
                    case TIQType.OnHold:
                        cmd.Parameters.AddWithValue("@QueueStatus", "H");
                        cmd.Parameters.AddWithValue("@Material", "Queue KPI Exceeded");
                        cmd.Parameters.AddWithValue("@MaterialDesc", "Park up in holding bay.");
                        break;
                    case TIQType.ParkUp:
                        cmd.Parameters.AddWithValue("@QueueStatus", "K");
                        cmd.Parameters.AddWithValue("@Material", "Proceed to office");
                        cmd.Parameters.AddWithValue("@MaterialDesc", "Park up in holding bay.");
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
                    case TIQType.Imported:
                        cmd.Parameters.AddWithValue("@QueueStatus", "I");
                        cmd.Parameters.AddWithValue("@Material", "Imported");
                        cmd.Parameters.AddWithValue("@MaterialDesc", "tba");
                        break;
                    default:
                        MessageBox.Show("Unhandled TIQ Type : " + myTIQType, "Add TIQ ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.Parameters.AddWithValue("OverloadPoints", 0);
                cmd.Parameters.AddWithValue("OverloadDesc", "");
                cmd.Parameters.AddWithValue("Comment", "");
                sqlConnection.Open();
                iTIQID = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                return iTIQID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NewTIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -9;
            }
        }

        private bool IsBookedIn(string Rego)
        {
            try
            {
                //int iTIQID = 0;
                //SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = sqlConnection;
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "IsInQueue";
                //cmd.Parameters.AddWithValue("@Rego", Rego);
                //cmd.Parameters.AddWithValue("@SiteID", Properties.Settings.Default.SiteID);
                //sqlConnection.Open();
                //iTIQID = System.Convert.ToInt32(cmd.ExecuteScalar());
                //sqlConnection.Close();
                return false;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IsBookedIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
}
    private void btnImported_Click(object sender, EventArgs e)
        {
            GoToBookInExBin(TIQType.Imported);
        }
    
        private void btnHold_Click(object sender, EventArgs e)
        {
            PutOnHold();
        }

        private void PutOnHold()
        {
            try
            {
                string msg = "Put on hold, direct to park in holding bay and proceed to office to resolve driver issue.";
                NewTIQ(TIQType.ParkUp);
                MessageBox.Show(msg,"Put on hold.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void BookInTruckStep1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                FindTruckConfig(txtTruckRego.Text);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CheckConfigOK2Proceed();
        }

    }
}
