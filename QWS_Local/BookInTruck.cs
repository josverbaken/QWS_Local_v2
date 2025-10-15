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
        private static string myWBO = "Barney.Rubble";
        private static int mySiteID;
        private static dsTIQ2.TIQRow _TIQRow;


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
        public BookInTruck(dsTIQ2.TIQRow TIQRow, bool Resume)
        {
            InitializeComponent();

            dgvConfiguredTrucks.DefaultCellStyle.SelectionBackColor = Color.LightSalmon; //.LightBlue;
            dgvConfiguredTrucks.DefaultCellStyle.SelectionForeColor = Color.Black;

            CallingMessage = "";
            dsTIQ2.TIQ.Clear();
            dsTIQ2.TIQ.ImportRow(TIQRow);
            _TIQRow = (dsTIQ2.TIQRow)dsTIQ2.TIQ.Rows[0]; // bind to dataset
            txtTruckRego.Text = _TIQRow.Rego;

            if (_TIQRow.Rego.Length > 0)
            { 
                FindTruckConfig(_TIQRow.Rego.Trim(), Resume); // somehow short rego gets padded out in TIQ
                SelectTruckConfig(_TIQRow.TruckConfigID);
                if (_TIQRow.DriverID > 0)
                {
                GetTruckDriver(_TIQRow.DriverID);
                }
                // CheckConfigOK2Proceed() may set to disabled is not ok to proceed
                if (btnGetDriver.Enabled == false)
                {
                    btnGetDriver.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Resume booking in failed!");
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
            TIQID = NewTIQ(TIQType.EnterRego, myParentTIQID, TrailerConfig);
            _TIQRow = (dsTIQ2.TIQRow)dsTIQ2.TIQ.Rows[0]; // bind to dataset // 20250712
            //check rego and axle conditions
            CheckConfigOK2Proceed();
        }

        private void btnFindTruck_Click(object sender, EventArgs e)
        {
            FindTruckConfig(txtTruckRego.Text.Trim(), false);
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
                if (iCount > 0) // Configured Truck found
                {
                    EntryDTTM = DateTime.Now;
                    if (IsBookedIn(Rego) == true) // && Resume == false)
                    {
                        if (Resume == false)
                        {
                            MessageBox.Show("Cannot proceed! \r\nTruck already in queue!", "Already Booked In!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            // Resume == True
                            UpdateOwnerGUI();
                            if (_TIQRow != null)
                            {
                                string msg = "TIQ Row was passed with Rego = ";
                                msg += _TIQRow.Rego + " TruckconfigID = ";
                                msg += _TIQRow.TruckConfigID.ToString();
                                DGVLoaded = true;
                            }
                        }
                    }
                    else
                    {
                        if (Resume == false)
                        {
                            UpdateOwnerGUI();
                            TIQID = NewTIQ(TIQType.EnterRego, 0, "tba");
                            dgvConfiguredTrucks.ClearSelection();
                            DGVLoaded = true;
                        }
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
                case 117: // these are for the owner
                    chkACCDelivery.Checked = true;
                    chkACCPickUp.Checked = false;
                    break;
                case 123:
                    chkACCDelivery.Checked=false;
                    chkACCPickUp.Checked = true;
                    break;
                case 124:
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
            try
            {
                int index = bsConfiguredTrucks.Find("TruckConfigID", TruckConfigID);
            if (index >= 0)
            {
                bsConfiguredTrucks.Position = index;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SelectTruckConfig");
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
            myWBO = myUserName;
            if (CallingMessage.Length > 0)
            {
                MessageBox.Show(CallingMessage, "Follow on book in.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck(); // zero rows on resume 20250828
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
                    // btnImportedPickUp.Enabled = true leave as is after truck selection
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
                    if (chkACCDelivery.Checked == true && blInduction == true && btnDelivery.Enabled == true)
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
                    btnImported.Enabled = true; //these arrive fully loaded, so get tare after unloading
                    btnImportedPickUp.Enabled = false;
                }
                btnRetare.Enabled = true;
                // UpdateTIQ 20250418, is done in UpdateTIQDriver
                UpdateTIQDriver();
            }
        }

        private void UpdateTIQDriver()
        {
            try
            {
                if (_TIQRow != null)
                {
                    bsTIQ.EndEdit();
                    bsTruckDriver.EndEdit();
                    dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck();
                    dsQWSLocal2024.TruckDriverRow myTruckDriver = CurrentTruckDriver();
                    string myTruckOwner;
                    if (myConfigTruck.TruckOwner.Length > 50)
                    {
                        myTruckOwner = myConfigTruck.TruckOwner.Substring(0, 50);
                    }
                    else
                    {
                        myTruckOwner  =myConfigTruck.TruckOwner;
                    }
                    _TIQRow.Operator = myWBO;//myUsername;
                    _TIQRow.DriverID = myTruckDriver.CntctCode;
                    _TIQRow.Driver = myTruckDriver.Person;
                    _TIQRow.AllocateDTTM = DateTime.Now;
                    _TIQRow.Rego = myConfigTruck.RegoTk;
                    _TIQRow.RegoTr1 = myConfigTruck.RegoTr1;
                    _TIQRow.RegoTr2 = myConfigTruck.RegoTr2;
                    _TIQRow.RegoTr3 = myConfigTruck.RegoTr3;
                    _TIQRow.RegoTrailers = myConfigTruck.RegoTrailer;
                    //myTIQ.TruckConfig = TruckTrailerConfig; //myConfigTruck.VehicleType;
                    _TIQRow.TruckConfigID = myConfigTruck.TruckConfigID;
                    _TIQRow.AxleConfiguration = myConfigTruck.AxleConfiguration;
                    _TIQRow.FeeCode = myConfigTruck.FeeCode;
                    _TIQRow.TruckOwnerCode = myConfigTruck.CardCode;
                    _TIQRow.TruckOwner = myTruckOwner;
                    _TIQRow.AgrNo = 0;
                    _TIQRow.AgrLine = 0;
                    int iRow = taTIQ.Update(dsTIQ2.TIQ);
                    iRow += 1;
                }
                else
                {
                    MessageBox.Show("Current TIQ row is NULL!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpdateTIQDriver Error");
                throw;
            }
        }

        private void UpdateTIQ(TIQType myTIQType) //, string TruckTrailerConfig)
        {
            bsTIQ.EndEdit();
            bsTruckDriver.EndEdit();
            dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck();
            dsQWSLocal2024.TruckDriverRow myTruckDriver = CurrentTruckDriver();
            if (myTruckDriver != null)
            {
                _TIQRow.DriverID = myTruckDriver.CntctCode;
                _TIQRow.Driver = myTruckDriver.Person;
            }
            else
            {
                _TIQRow.DriverID = 0;
                _TIQRow.Driver = "tba";
            }
            _TIQRow.Operator = myWBO;//myUsername;
            _TIQRow.AllocateDTTM = DateTime.Now;
            _TIQRow.Rego = myConfigTruck.RegoTk;
            _TIQRow.RegoTr1 = myConfigTruck.RegoTr1;
            _TIQRow.RegoTr2 = myConfigTruck.RegoTr2;
            _TIQRow.RegoTr3 = myConfigTruck.RegoTr3;
            _TIQRow.RegoTrailers = myConfigTruck.RegoTrailer;
            //_TIQRow.TruckConfig // set elsewhere, don't overwrite!
            _TIQRow.TruckConfigID = myConfigTruck.TruckConfigID;
            _TIQRow.AxleConfiguration = myConfigTruck.AxleConfiguration;
            _TIQRow.FeeCode = myConfigTruck.FeeCode;
            _TIQRow.TruckOwnerCode = myConfigTruck.CardCode;
            _TIQRow.TruckOwner = myConfigTruck.TruckOwner;
            _TIQRow.AgrNo = 0;
            _TIQRow.AgrLine = 0;
            switch (myTIQType)
            {
                case TIQType.EnterRego:
                    _TIQRow.QueueStatus = "P";
                    _TIQRow.Material = "Truck Rego";
                    _TIQRow.MaterialDesc = "Book in started";
                    break;
                case TIQType.Retare:
                    _TIQRow.QueueStatus = "T";
                    _TIQRow.Material = "Retare";
                    _TIQRow.MaterialDesc = "Retare Vehicle";
                    break;
                case TIQType.OnHold:
                    _TIQRow.QueueStatus = "H";
                    _TIQRow.Material = "Queue KPI Exceeded";
                    _TIQRow.MaterialDesc = "Park up in holding bay.";
                    break;
                case TIQType.ParkUp:
                    _TIQRow.QueueStatus = "K";
                    _TIQRow.Material = "Proceed to office";
                    _TIQRow.MaterialDesc = "Park up in holding bay.";
                    break;
                case TIQType.ExBin:
                    if (_TIQRow.QueueStatus.Equals("X") == false)
                    {
                        _TIQRow.QueueStatus = "P";
                    }
                    _TIQRow.Material = "ExBin";
                    _TIQRow.MaterialDesc = "tba";
                    break;
                case TIQType.Delivery:
                    if (_TIQRow.QueueStatus.Equals("X") == false)
                    {
                        _TIQRow.QueueStatus = "P";
                    }
                    _TIQRow.Material = "Delivery";
                    _TIQRow.MaterialDesc = "tba";
                    break;
                case TIQType.Imported:
                    _TIQRow.QueueStatus = "I";
                    _TIQRow.Material = "Imported";
                    _TIQRow.MaterialDesc = "tba";
                    break;
                case TIQType.ImportedPickUp:
                    _TIQRow.QueueStatus = "I";
                    _TIQRow.Material = "Imported PickUp";
                    _TIQRow.MaterialDesc = "tba";
                    break;
                default:
                    MessageBox.Show("Unhandled TIQ Type : " + myTIQType, "Add TIQ ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            //bsTIQ.EndEdit();
            int iRow = taTIQ.Update(dsTIQ2.TIQ);
            iRow += 1;
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
            BusinessSearch frmBusinessSearch = new BusinessSearch(true);
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
            GoToBookInMaterial();
        }

        private void GoToBookInMaterial()
        {
            if (_TIQRow.TruckConfig == "TT")
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
            {
                if (BookInTIQType == TIQType.ExBin || BookInTIQType == TIQType.Imported)
                {
                    if (SetExBinCustomer() == true)
                    {
                        _TIQRow.CustomerCode = CustCardCode;
                        _TIQRow.Customer = ExBinCustomer;
                        bsTIQ.EndEdit();
                    }
                }
                UpdateTIQ(BookInTIQType); //, _TIQRow.TruckConfig);
                BookInMaterial frmExBin = new BookInMaterial(_TIQRow, BookInTIQType.ToString(), IsPrefCust, CurrentTruckDriver());
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
                UpdateTIQ(TIQType.Retare); //, _TIQRow.TruckConfig);
                TIQID = 0;
                ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();
                this.Close();
            }
        }

        private int NewTIQ(TIQType myTIQType, int myParentTIQID, string TruckOrTrailerConfig)
        {
            try
            {
                int iTIQID = 0;
                bool Okay2Proceed = true;
                dsTruckConfig.ConfiguredTrucksRow myConfigTruck = CurrentConfigTruck();
                int myTruckConfigID;
                if (bsConfiguredTrucks.Count == 1)
                {
                    myTruckConfigID = myConfigTruck.TruckConfigID;
                }
                else
                {
                    myTruckConfigID = 0;
                }
                    string myQStatus = "P";
                if (myTIQType == TIQType.ParkUp)
                {
                    myQStatus = "K";
                }
                if (TruckOrTrailerConfig == "TRs")
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
                cmd.Parameters.AddWithValue("@SiteID", mySiteID);
                cmd.Parameters.AddWithValue("@Operator", myWBO);
                cmd.Parameters.AddWithValue("@Rego", myConfigTruck.RegoTk);
                cmd.Parameters.AddWithValue("@RegoTr1", "RegoTr1"); // myConfigTruck.RegoTr1);
                cmd.Parameters.AddWithValue("@RegoTr2", "RegoTr2"); // myConfigTruck.RegoTr2);
                cmd.Parameters.AddWithValue("@RegoTr3", "RegoTr3"); // myConfigTruck.RegoTr3);
                cmd.Parameters.AddWithValue("@RegoTrailers", "RegoTrailers"); // myConfigTruck.RegoTrailer);
                cmd.Parameters.AddWithValue("@TruckConfig", TruckOrTrailerConfig); // myConfigTruck.VehicleType);
                cmd.Parameters.AddWithValue("@TruckConfigID", myTruckConfigID); //myConfigTruck.TruckConfigID);
                cmd.Parameters.AddWithValue("@AxleConfiguration", myConfigTruck.AxleConfiguration);
                cmd.Parameters.AddWithValue("@FeeCode", myConfigTruck.FeeCode);
                cmd.Parameters.AddWithValue("@ConfigSource", "n/a");
                cmd.Parameters.AddWithValue("@SchemeCode", "n/a");
                cmd.Parameters.AddWithValue("@RoadAccess", "n/a");
                cmd.Parameters.AddWithValue("@WeighbridgeID", 1);
                cmd.Parameters.AddWithValue("@WBConnected", false);
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
                cmd.Parameters.AddWithValue("AgrNo", 0);
                cmd.Parameters.AddWithValue("AgrLine", 0);
                if (Okay2Proceed == true)
                {
                    sqlConnection.Open();
                    iTIQID = System.Convert.ToInt32(cmd.ExecuteScalar());
                    sqlConnection.Close();
                    TIQGet(mySiteID, iTIQID);
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

        private int TIQGet(int mySiteID, int myTIQID)
        {
            try
            {
                dsTIQ2.Clear();
                int iRow = taTIQ.FillBy(dsTIQ2.TIQ, mySiteID, myTIQID); // 1 row only!
                if (iRow == 1)
                {
                    _TIQRow = (dsTIQ2.TIQRow)dsTIQ2.TIQ.Rows[0];
                }
                else
                {
                    MessageBox.Show("Error retrieving new TIQ!");
                }
                    return iRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -9;
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
            GoToBookInMaterial();
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
                if (_TIQRow == null)
                {
                    // create record with just rego to capture entry time for KPI
                    NewTIQ(TIQType.ParkUp, 0, "tba");
                }
                else
                {
                    UpdateTIQ(TIQType.ParkUp); //, CurrentConfigTruck().VehicleType);
                }
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
            dgvConfiguredTrucks.ClearSelection();
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
            UpdateTIQ(TIQType.EnterRego); //, CurrentConfigTruck().VehicleType);
            CheckConfigOK2Proceed();
        }

        private void btnImportedPickUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.","Imported Pickup Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            BookInTIQType = TIQType.ImportedPickUp;
                GoToBookInMaterial();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVLoaded == true) // && bsTIQ.Count == 0) // TIQ created on initialise when called with trailer config and parent tiq
            {
                        ProceedAfterRegoSelection();
            }
        }

        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTnT.Checked == true)
            {
                btnContinue.Enabled = true;
                _TIQRow.TruckConfig = "TT";
                _TIQRow.QueueStatus = "Q";
                bsTIQ.EndEdit();
            }
        }

        private void rbSplitLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSplitLoad.Checked == true)
            {
                btnContinue.Enabled = true;
                _TIQRow.TruckConfig = "TKs";
                //IQRow.QueueStatus = "Q";
                bsTIQ.EndEdit();
            }
        }

        private void rbTruckOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruckOnly.Checked == true)
            {
                btnContinue.Enabled = true;
                _TIQRow.TruckConfig = "TKs";
                _TIQRow.QueueStatus = "X";
                //bsTIQ.EndEdit();
            }
        }

        private void rbTrailerOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrailerOnly.Checked == true)
            {
                btnContinue.Enabled = true;
                _TIQRow.TruckConfig = "TRs";
                _TIQRow.QueueStatus = "X";
                //bsTIQ.EndEdit();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            BookInMaterial();
        }

        private void btnSessionID_Click(object sender, EventArgs e)
        {
            int ProcessID = System.Diagnostics.Process.GetCurrentProcess().Id;
            MessageBox.Show("Process ID = " + ProcessID.ToString());
        }
       
        private void btnSetTruckConfig_Click(object sender, EventArgs e)
        {
            dsTruckConfig.ConfiguredTrucksRow myConfiguredTrucksRow = CurrentConfigTruck();
            _TIQRow.TruckConfig = myConfiguredTrucksRow.VehicleType.ToString(); // CurrentConfigTruck().VehicleType.ToString();
            if (myConfiguredTrucksRow.ACCDelivery == true)
            {
                btnDelivery.Enabled = true;
            }
            if (myConfiguredTrucksRow.ACCPickup == true)
            {
                btnImportedPickUp.Enabled = true;
            }
            UpdateTIQ(TIQType.EnterRego);
            CheckConfigOK2Proceed();
        }
    }
}
