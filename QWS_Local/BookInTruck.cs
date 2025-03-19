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
using static QWS_Local.dsQWSLocal2024;
//using Microsoft.Data.SqlClient;

namespace QWS_Local
{
    public partial class BookInTruck : Form
    {
        private static DateTime EntryDTTM;
        private static string CustCardCode = "xxx";
        private static string ExBinCustomer = "tba";
        private static bool IsPrefCust = false;
        private static bool DGVLoaded = false;
        private static string CallingMessage = "";
        private static int TIQID = 0;
        private string myUserName;
        private static string WBO = "Barney.Rubble";
        private static int mySiteID;


        private enum TIQType
        {
            EnterRego,
            Retare,
            OnHold,
            ExBin,
            Imported,
            ImportedPickUp,
            Delivery,
            Split,
            ParkUp
        }
        private enum LoadType
        {
            TK,
            TT,
            TKs,
            TKx,
            TRs,
            TRx,
            ST,
            BD,
            BDa,
            BDb,
            AD,
            ADa,
            ADb
        }

        private TIQType BookInTIQType;

        public BookInTruck()
        {
            InitializeComponent();
            CallingMessage = "";
        }

        // Resume in progress TIQ
        public BookInTruck(int myTIQID, string Rego, int TruckConfigID, int myDriverID, bool Resume)
        {
            InitializeComponent();
            CallingMessage = "";
            txtTruckRego.Text = Rego;
            TIQID = myTIQID; //Do first before calling FindTruckConfig
            TIQGet(myTIQID);
            FindTruckConfig(Rego, Resume);
            SelectTruckConfig(TruckConfigID);
            if (myDriverID > 0)
            {
                GetTruckDriver(myDriverID);
            }
        }

        // Book in after updating Tare or Split-load
        public BookInTruck(string Rego, int TruckConfigID, int myDriverID, int myParentTIQID, string mySplitTruckConfig, string Message, string TrailerConfig)
        {
            InitializeComponent();
            txtTruckRego.Text = Rego;
            CallingMessage = Message;
            // Retrieve Truck and Driver
            FindTruckConfig(Rego, true); // Resume = true b/c split load
            SelectTruckConfig(TruckConfigID);
            if (myDriverID > 0)
            {
                GetTruckDriver(myDriverID);
            }
            // Create new TIQ
            if (TIQID == 0) 
            {
                TIQID = NewTIQ(TIQType.EnterRego, myParentTIQID, TrailerConfig);
            }
            //check rego and axle conditions
            CheckConfigOK2Proceed();
        }

        private void btnFindTruck_Click(object sender, EventArgs e)
        {
            FindTruckConfig(txtTruckRego.Text, false);
        }

        private void FindTruckConfig(string Rego, bool Resume)
        {
            try
            {
                DGVLoaded = false;
                btnHold.Enabled = false;
                btnRetare.Enabled = false;
                btnRetare.BackColor = SystemColors.Control;
                dsQWSLocal2024.TruckDriver.Clear();
                dsTruckConfig.ConfiguredTrucks.Clear();
                int iCount = taConfiguredTrucks.FillByRego(dsTruckConfig.ConfiguredTrucks, Rego);
                if (iCount > 0)
                {
                    EntryDTTM = DateTime.Now;
                    if (IsBookedIn(Rego) == true && Resume == false)
                    {
                        MessageBox.Show("Cannot proceed! \r\nTruck already in queue!", "Already Booked In!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        UpdateOwnerGUI();
                        dataGridView1.ClearSelection();
                        DGVLoaded = true;
                    }
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
            dsTruckConfig.ConfiguredTrucksRow myConfigTruckRow = CurrentConfigTruck();
            if (myConfigTruckRow.CardStatus != "A")
            {
                txtCardStatus.BackColor = Color.Salmon;
            }
            else
            {
                txtCardStatus.BackColor = Color.PaleGreen;
            }

            switch (myConfigTruckRow.GroupCode)
            {
                case 117:
                    chkACCDelivery.Checked = true;
                    chkACCPickUp.Checked = false;
                    break;
                case 118:
                    chkACCDelivery.Checked=false;
                    chkACCPickUp.Checked = true;
                    break;
                case 119:
                    chkACCDelivery.Checked = true;
                    chkACCPickUp.Checked=true;
                    break;
                default:
                    chkACCDelivery.Checked=false;
                    chkACCPickUp .Checked = false;
                    break;
            }       
            btnHold.Enabled = true;
        }

        private void SelectTruckConfig(int TruckConfigID)
        {
            int index = bsConfiguredTrucks.Find("TruckConfigID", TruckConfigID);
            if (index >= 0)
            {
                bsConfiguredTrucks.Position = index;
            }
        }

        private dsTIQ2.TIQRow CurrentTIQ()
        {
            if (bsTIQ.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTIQ.Current).Row;
                if (myRow != null)
                {
                    dsTIQ2.TIQRow myTIQ = (dsTIQ2.TIQRow)myRow;
                    return myTIQ;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
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
                MessageBox.Show("CurrentConfigTruck Zero Rows!");
                return null;
            }
        }

        private dsQWSLocal2024.TruckDriverRow CurrentTruckDriver()
        {
            if (bsTruckDriver.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTruckDriver.Current).Row;
                dsQWSLocal2024.TruckDriverRow truckDriverRow = (dsQWSLocal2024.TruckDriverRow)myRow;
                return truckDriverRow;
            }
            else
            {
                return null;
            }
        }

        private void BookInTruck_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            var parent = this.MdiParent as QWS_MDIParent;
            myUserName = parent.UserName;
            mySiteID = parent.SiteID;
            WBO = myUserName;
            if (CallingMessage.Length > 0)
            {
                MessageBox.Show(CallingMessage, "Follow on book in.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CheckFeeCode() // TODO check why unused!
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
            GetTruckDriver(0);
        }
  
        private void CheckConfigOK2Proceed()
        {
            btnGetDriver.Enabled = false;
            bool OK2Proceed = false;
            dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck();
            if (myConfigTruck.RegoCheck == true)
            {
                OK2Proceed = true;
            }
            else
            {
                MessageBox.Show("Rego expired - unable to proceed!");
            }
            int myAxles = myConfigTruck.Axles;
            int myMaxAxles = myConfigTruck.MaxAxles;
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
            // 20241023 also check if Tare = Zero
            double TareInterval = Properties.Settings.Default.RetareInterval;
            dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck();
            DateTime RetareDT = myConfigTruck.TareDT.AddDays(TareInterval);
            Decimal TareTruck = myConfigTruck.Tare;
            if (RetareDT < DateTime.Today || TareTruck == 0.0M)
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

        private void GetTruckDriver(int DriverID)
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
                dsQWSLocal2024.TruckDriverRow myTruckDriverRow = CurrentTruckDriver();
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
                if (blOkay2Cart) // i.e. license and induction ok
                {
                    btnExBin.Enabled = true;
                    btnImported.Enabled = true;
                    btnImportedPickUp.Enabled = true;
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
                    btnImportedPickUp.Enabled = false;
                }
                if (myTruckDriverRow.Position == "Authorised Cartage Contractor"|| myTruckDriverRow.Position.Contains("ACC") == true)
                {
                    if (chkACCDelivery.Checked == true && blInduction == true)
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
                    //btnImported.Enabled = false;
                    btnImported.Enabled = true; //these arrive fully loaded, so get tare after unloading
                    btnImportedPickUp.Enabled = false;
                }
                btnRetare.Enabled = true;
            }
        }

        private void UpdateTIQ(TIQType myTIQType, string TruckTrailerConfig)
        {
            bsTIQ.EndEdit();
            bsTruckDriver.EndEdit();
            
            dsTIQ2.TIQRow myTIQ = CurrentTIQ();
            dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck();
            dsQWSLocal2024.TruckDriverRow myTruckDriver = CurrentTruckDriver();
            myTIQ.Operator = WBO;//myUsername;
            myTIQ.DriverID = myTruckDriver.CntctCode;
            myTIQ.Driver = myTruckDriver.Person;
            myTIQ.AllocateDTTM = DateTime.Now;
            myTIQ.Rego = myConfigTruck.RegoTk;
            myTIQ.RegoTr1 = myConfigTruck.RegoTr1;
            myTIQ.RegoTr2 = myConfigTruck.RegoTr2;
            myTIQ.RegoTr3 = myConfigTruck.RegoTr3;
            myTIQ.RegoTrailers = myConfigTruck.RegoTrailer;
            myTIQ.TruckConfig = TruckTrailerConfig; //myConfigTruck.VehicleType;
            myTIQ.TruckConfigID = myConfigTruck.TruckConfigID;
            myTIQ.AxleConfiguration = myConfigTruck.AxleConfiguration;
            myTIQ.FeeCode = myConfigTruck.FeeCode;
            myTIQ.TruckOwnerCode = myConfigTruck.CardCode;
            myTIQ.TruckOwner = myConfigTruck.TruckOwner;
            switch (myTIQType)
            {
                case TIQType.Retare:
                    myTIQ.QueueStatus = "T";
                    myTIQ.Material = "Retare";
                    myTIQ.MaterialDesc = "Retare Vehicle";
                    break;
                case TIQType.OnHold:
                    myTIQ.QueueStatus = "H";
                    myTIQ.Material = "Queue KPI Exceeded";
                    myTIQ.MaterialDesc = "Park up in holding bay.";
                    break;
                case TIQType.ParkUp:
                    myTIQ.QueueStatus = "K";
                    myTIQ.Material = "Proceed to office";
                    myTIQ.MaterialDesc = "Park up in holding bay.";
                    break;
                case TIQType.ExBin:
                    if (myTIQ.QueueStatus.Equals("X") == false)
                    {
                        myTIQ.QueueStatus = "P";
                    }
                    myTIQ.Material = "ExBin";
                    myTIQ.MaterialDesc = "tba";
                    break;
                case TIQType.Delivery:
                    if (myTIQ.QueueStatus.Equals("X") == false)
                    {
                        myTIQ.QueueStatus = "P";
                    }
                    myTIQ.Material = "Delivery";
                    myTIQ.MaterialDesc = "tba";
                    break;
                case TIQType.Imported:
                    myTIQ.QueueStatus = "I";
                    myTIQ.Material = "Imported";
                    myTIQ.MaterialDesc = "tba";
                    break;
                case TIQType.ImportedPickUp:
                    myTIQ.QueueStatus = "I";
                    myTIQ.Material = "Imported PickUp";
                    myTIQ.MaterialDesc = "tba";
                    break;
                default:
                    MessageBox.Show("Unhandled TIQ Type : " + myTIQType, "Add TIQ ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            bsTIQ.EndEdit();
            taTIQ.Update(dsTIQ2.TIQ);
        }

        private bool SetExBinCustomer()
        {
            int iCust = taPrefCustomers2.FillBy(dsQWSLocal2024.VehiclePrefCustomers, CurrentConfigTruck().RegoTk);
            if (iCust > 0)
            {
                if (GetPrefCustomer() == true)
                {
                    // CardCode has been set
                    IsPrefCust = true;
                    return true;
                }
                else
                {
                    IsPrefCust = false;
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
                //IsPrefCust = true;
                return true;
            }
            else
            {
                //IsPrefCust = false;
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
            BookInTIQType = TIQType.ExBin;
            if (SetExBinCustomer() == true)
            {
                GoToBookInMaterial();
            }
        }

        private void GoToBookInMaterial()
        {
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                if (myTIQRow.TruckConfig == "TT")
                {
                    gbSplitLoad.Enabled = true;
                }
                else
                {
                    gbSplitLoad.Enabled = false;
                    BookInMaterial();
                }
        }

        private void BookInMaterial()
        {
            if (TIQID > 0)
            {
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                UpdateTIQ(BookInTIQType, myTIQRow.TruckConfig);
                BookInMaterial frmExBin = new BookInMaterial(TIQID,mySiteID, BookInTIQType.ToString(), CurrentConfigTruck().TruckConfigID, CustCardCode, ExBinCustomer, IsPrefCust, CurrentTruckDriver());
                TIQID = 0;
                frmExBin.MdiParent = this.MdiParent;
                frmExBin.Show();
                this.Close();
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            BookInTIQType = TIQType.Delivery;
            GoToBookInMaterial();
        }

        private void btnRetare_Click(object sender, EventArgs e)
        {
            if (TIQID > 0)
            {
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                UpdateTIQ(TIQType.Retare, myTIQRow.TruckConfig);
                TIQID = 0;
                ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();
                this.Close();
            }
        }

        private int NewTIQ(TIQType myTIQType, int myParentTIQID, string TruckOrTrailerConfig)
        {
            try
            {
                var parent = this.MdiParent as QWS_MDIParent;
                int SiteID = parent.SiteID;
                int iTIQID = 0;
                bool Okay2Proceed = true;
                dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck();
                string myQStatus = "P";
                if (TruckOrTrailerConfig == "TRs") // TODO differentiate b/n split and trailer only
                {
                    if (IsBookedIn(CurrentConfigTruck().RegoTk) == true)
                    {
                        myQStatus = "S";
                    }
                    else
                    {
                        myQStatus = "X";
                    }
                }
                int myDriverID = -9;
                string myDriver = "Truck Driver TBA";
                if (bsTruckDriver.Count == 1)
                {
                    dsQWSLocal2024.TruckDriverRow myTruckDriver = CurrentTruckDriver();
                    myDriverID = myTruckDriver.CntctCode;
                    myDriver = myTruckDriver.Person;
                }
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQAdd";
                cmd.Parameters.AddWithValue("@ParentTIQID", myParentTIQID);
                cmd.Parameters.AddWithValue("@TIQOpen", true);
                cmd.Parameters.AddWithValue("@SiteID", SiteID);
                cmd.Parameters.AddWithValue("@Operator", WBO); //myUsername);
                cmd.Parameters.AddWithValue("@Rego", myConfigTruck.RegoTk);
                cmd.Parameters.AddWithValue("@RegoTr1", myConfigTruck.RegoTr1);
                cmd.Parameters.AddWithValue("@RegoTr2", myConfigTruck.RegoTr2);
                cmd.Parameters.AddWithValue("@RegoTr3", myConfigTruck.RegoTr3);
                cmd.Parameters.AddWithValue("@RegoTrailers", myConfigTruck.RegoTrailer);
                cmd.Parameters.AddWithValue("@TruckConfig", TruckOrTrailerConfig); // myConfigTruck.VehicleType);
                cmd.Parameters.AddWithValue("@TruckConfigID", myConfigTruck.TruckConfigID);
                cmd.Parameters.AddWithValue("@AxleConfiguration", myConfigTruck.AxleConfiguration);
                cmd.Parameters.AddWithValue("@FeeCode", myConfigTruck.FeeCode);
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
                cmd.Parameters.AddWithValue("@QueueStatus", myQStatus);
                cmd.Parameters.AddWithValue("@Material", "Enter Rego");
                cmd.Parameters.AddWithValue("@MaterialDesc", "Lead Vehicle Rego Entered");
                cmd.Parameters.AddWithValue("@StockpileLotNo", 0);
                cmd.Parameters.AddWithValue("@TruckOwnerCode", myConfigTruck.CardCode);
                cmd.Parameters.AddWithValue("@TruckOwner", myConfigTruck.TruckOwner);
                cmd.Parameters.AddWithValue("@DriverID", myDriverID);
                cmd.Parameters.AddWithValue("@Driver", myDriver);
                cmd.Parameters.AddWithValue("@Payload", 0);
                cmd.Parameters.AddWithValue("@PayloadSplit", ""); // text 12.5/20.5
                cmd.Parameters.AddWithValue("@GCM", 0);
                cmd.Parameters.AddWithValue("@GVMTruck", 0);
                cmd.Parameters.AddWithValue("@Gross", 0.0M);
                cmd.Parameters.AddWithValue("@Tare", myConfigTruck.Tare);
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
                if (Okay2Proceed == true)
                {
                    sqlConnection.Open();
                    iTIQID = System.Convert.ToInt32(cmd.ExecuteScalar());
                    sqlConnection.Close();
                    TIQGet(iTIQID);
                    return iTIQID;
                }
                else
                {
                    return -9;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NewTIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -9;
            }
        }

        private void TIQGet(int iTIQID)
        {
            try
            {
                dsTIQ2.Clear();
                // TODO get SiteID
                int iRow = taTIQ.FillBy(dsTIQ2.TIQ, mySiteID, iTIQID); // 1 row only!
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsBookedIn(string Rego)
        {
            try
            {
                //var parent = this.MdiParent as QWS_MDIParent;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsInQueue";
                cmd.Parameters.AddWithValue("@Rego", Rego);
                cmd.Parameters.AddWithValue("@SiteID", mySiteID);
                sqlConnection.Open();
                int iTrucks = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                if (iTrucks > 0) 
                {
                    return true;
                }
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
            BookInTIQType = TIQType.Imported;
            if (SetExBinCustomer() == true)
            {
                GoToBookInMaterial();
            }
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
                UpdateTIQ(TIQType.ParkUp, CurrentConfigTruck().VehicleType);
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

        private void BookInTruck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                FindTruckConfig(txtTruckRego.Text, false);
            }
        }
    
        private void ProceedAfterRegoSelection()
        {
            TIQID = NewTIQ(TIQType.EnterRego, 0, CurrentConfigTruck().VehicleType);
            CheckConfigOK2Proceed();
        }

        private void btnImportedPickUp_Click(object sender, EventArgs e)
        {
            BookInTIQType = TIQType.ImportedPickUp;
            if (SetExBinCustomer() == true)
            {
                GoToBookInMaterial();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVLoaded == true && bsTIQ.Count == 0) // TIQ created on initialise when called with trailer config and parent tiq
            {
                        ProceedAfterRegoSelection();
            }
        }

        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            btnContinue.Enabled = true;
        }

        private void rbSplitLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSplitLoad.Checked == true)
            {
                // TODO set TIQ.TruckConfig to TKs if first load
                btnContinue.Enabled = true;
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                myTIQRow.TruckConfig = "TKs";
                bsTIQ.EndEdit();
            }
        }

        private void rbTruckOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruckOnly.Checked == true)
            {
                // TODO set TIQ.TruckConfig to TKx if first load
                btnContinue.Enabled = true;
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                myTIQRow.TruckConfig = "TKs";
                myTIQRow.QueueStatus = "X";
                bsTIQ.EndEdit();
            }
        }

        private void rbTrailerOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrailerOnly.Checked == true)
            {
                // TODO set TIQ.TruckConfig to TRx if first load
                btnContinue.Enabled = true;
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                myTIQRow.TruckConfig = "TRs";
                myTIQRow.QueueStatus = "X";
                bsTIQ.EndEdit();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            BookInMaterial();
        }
    }
}
