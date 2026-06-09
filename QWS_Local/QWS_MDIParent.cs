using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class QWS_MDIParent : Form
    {
        private string myUserName = "";
        private int mySiteID = 99;
        private bool myTestMode = false;
        private string myConnectionString = "";
        private TrucksInQuarry frmTIQ;

        public int SiteID
        {
            get { return mySiteID; }
        }

        public string UserName
        {
            get { return myUserName; }
        }

        public bool TestMode
        {
            get { return myTestMode; }
        }

        private string myDomainName;
        public string DomainName
        {
            get { return myDomainName; }
        }

        private string myComputerName;
        public string ComputerName
        {
            get { return myComputerName; }
        }

        private string myLoginStatus; // W = Windows, G = Generic, O = signed out
        public string LoginStatus
        {
            get { return myLoginStatus; }
        }

        public QWS_MDIParent()
        {
            InitializeComponent();
        }

        private void QWS_MDIParent_Load(object sender, EventArgs e)
        {
            bool OK2Continue = true;

            string msg = string.Empty;
            string SiteLabel = string.Empty;

            licensePlatesToolStripMenuItem.Visible = false;
            licensePlatesToolStripMenuItem.Enabled = false;

            QWSLogin frmQWSLogin = new QWSLogin();
            DialogResult dr = frmQWSLogin.ShowDialog();
            if(dr == DialogResult.OK)
            {
                mySiteID = frmQWSLogin.SiteID;
                myTestMode = frmQWSLogin.TestMode;
                myConnectionString = frmQWSLogin.cnQWSLocal;
            }
            else
            {
                msg = "Unable to continue!";
                MessageBox.Show(msg, "Login to QWS failed.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Close();
            }
                //menuItemHome.ShortcutKeys = Keys.Home; // fails on compile and also if try to set in properties GUI
                //menuitemMenu.ShortcutKeys = Keys.F10; // this is controlled by Windows!@#

                //myConnectionString = QWSConfig.cnQWSLocal;            

            if (mySiteID == 7 && myTestMode == false)
            {
                SiteLabel = "Northern Quarries"; // SiteID 07";
                tspSite.BackColor = Color.LightSkyBlue;
            }
            else if (mySiteID == 7 && myTestMode == true)
            {
                SiteLabel = "NQ TEST"; // SiteID 07";
                tspSite.BackColor = Color.LightSkyBlue;
            }
            else if (mySiteID == 2 && myTestMode == false)
            {
                SiteLabel = "Stawell Quarry"; // SiteID 02";
                tspSite.BackColor = Color.LightGreen;
            }
            else if (mySiteID == 2 && myTestMode == true)
            {
                SiteLabel = "SQ TEST"; // SiteID 02";
                tspSite.BackColor = Color.LightGreen;
            }
            else
            {
                OK2Continue = false;
            }
            if (OK2Continue == true)
            {
                msg += SiteLabel;
                tspSite.Text = msg;
                myDomainName = Environment.UserDomainName;
                string ComputerUsername = Environment.UserName;
                myComputerName = Environment.MachineName;
                GetUsername(ComputerUsername);
                if (myUserName.Length == 0)
                {
                    tspUserName.Text = "Please login!";
                }
                this.Size = new Size(1400, 800);
                this.KeyPreview = true;
                frmTIQ = new TrucksInQuarry();
                frmTIQ.MdiParent = this;
                frmTIQ.Show();
            }
        }

        private void GetUsername(string ComputerUsername)
        {
            try
            {
                int iCount = taOperator.FillBy(dsAdmin.Operator, ComputerUsername);
                if (iCount == 1)
                {
                    dsAdmin.OperatorRow row = (dsAdmin.OperatorRow)dsAdmin.Operator.Rows[0];
                    if (row.Generic == false) // Windows User
                    {
                        myLoginStatus = "W";
                        myUserName = ComputerUsername;
                        CheckIfAdmin(row.OperatorID);
                        tspUserName.Text = "WBO = " + myUserName;
                        tspSignInOut.Visible = false;
                        if (CheckRole(row.OperatorID, 8))
                        {
                            licensePlatesToolStripMenuItem.Visible = true;
                            licensePlatesToolStripMenuItem.Enabled = true;
                        }
                    }
                    else // Generic
                    {
                        GenericUserLogin();
                    }
                }
                else // user not in database
                {
                    GenericUserLogin();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetUserName Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenericUserLogin()
        {
            try
            {
                GenericLogin frmGenericLogin = new GenericLogin();
                DialogResult dr = frmGenericLogin.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    myLoginStatus = "G";
                    menuitemMenu.Enabled = true;
                    menuitemQuality.Enabled = true;
                    myUserName = frmGenericLogin.UserName;
                    int gCount = taOperator.FillBy(dsAdmin.Operator, myUserName);
                    if (gCount == 1)
                    {
                        dsAdmin.OperatorRow gRow = (dsAdmin.OperatorRow)dsAdmin.Operator.Rows[0];
                        CheckIfAdmin(gRow.OperatorID);
                        if (gRow.LastName.Length > 0)
                        {
                            myUserName = gRow.FirstName + "." + gRow.LastName;
                        }
                        else
                        {
                            myUserName = gRow.FirstName;
                        }
                        if (CheckRole(gRow.OperatorID, 8))
                        {
                            licensePlatesToolStripMenuItem.Visible = true;
                            licensePlatesToolStripMenuItem.Enabled = true;
                        }
                        tspUserName.Text = "WBO = " + myUserName;
                        tspSignInOut.Visible = true;
                    }
                    else
                    {
                        CheckIfAdmin(0);
                        menuitemQuality.Enabled = false;
                        tspUserName.Text = "WBO = " + myUserName + " ..";
                    }
                }
                else
                {
                    myLoginStatus = "O";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckIfAdmin(int myOperatorID)
        {
            if (myOperatorID == 0)
            {
                adminToolStripMenuItem.Visible = false;
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection();

                myConnectionString = QWSConfig.cnQWSLocal;


                sqlConnection = new SqlConnection(myConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from OperatorRoles where OperatorID = " + myOperatorID + " and RoleID = 6";
                cmd.Connection.Open();
                int iCount = (int)Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                if (iCount == 0)
                {
                    //disable and hide Admin menu
                    adminToolStripMenuItem.Enabled = false;
                    adminToolStripMenuItem.Visible = false;
                }
            }
        }

        private bool CheckRole(int myOperatorID, int RoleID)
        {
            string CommandText = "select count(*) from OperatorRoles where OperatorID = ";
            CommandText += myOperatorID + " and RoleID = ";
            CommandText += RoleID.ToString();
            SqlConnection sqlConnection = new SqlConnection();
            myConnectionString = QWSConfig.cnQWSLocal;
            sqlConnection = new SqlConnection(myConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = CommandText;
            cmd.Connection.Open();
            int iCount = (int)Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Connection.Close();
            if (iCount > 0)
            {
                return true;
            }
            return false;
        }

        private void bookInTruckStep1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInTruck frmBookIn1 = new BookInTruck();
            frmBookIn1.MdiParent = this;
            frmBookIn1.Show();
        }

        private void deliveryOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void BringTIQ2Front()
        {
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                if (tempChild.Name == "TrucksInQuarry")
                {
                    ((TrucksInQuarry)this.MdiChildren[x]).RefreshQueue();
                    this.MdiChildren[x].BringToFront();
                }
            }
        }

        private void tIQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BringTIQ2Front(); //20250730
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMDIChildren();
        }

        private void CloseMDIChildren()
        {
            // except home page = TrucksInQuarry
            while (this.MdiChildren.Length > 1)
            {
                for (int x = 0; x < 2; x++)
                {
                    Form tempChild = (Form)this.MdiChildren[x];
                    if (tempChild.Name != "TrucksInQuarry")
                    {
                        this.MdiChildren[x].Close();
                    }
                }
            }
        }

        public void PrintDocket()
        {
            bool formFound = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "PrintDocket")
                {
                    formFound = true;
                    item.BringToFront();
                    break;
                }
            }
            if (formFound == false)
            {
                PrintDocket frmPrintDocket = new PrintDocket(mySiteID);
                frmPrintDocket.MdiParent = this;
                frmPrintDocket.WindowState = FormWindowState.Maximized;
                frmPrintDocket.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutQWSLocal frmAbout = new AboutQWSLocal();
            frmAbout.MdiParent = this;
            //frmAbout.WindowState = FormWindowState.Normal;
            //frmAbout.Size = new Size(500, 350);
            frmAbout.Show();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Read the supplied documentation first. Online help is being created soon...");
        }

        private void deliveryOrdersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool formFound = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "DeliveryOrders")
                {
                    formFound = true;
                    item.BringToFront();
                    break;
                }
            }
            if (formFound == false)
            {
                DeliveryOrders frmDeliveryOrders = new DeliveryOrders();
                frmDeliveryOrders.MdiParent = this;
                frmDeliveryOrders.WindowState = FormWindowState.Maximized;
                frmDeliveryOrders.Show();
            }
        }

        private void pBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBSManagement frmPBSManagement = new PBSManagement();
            frmPBSManagement.MdiParent = this;
            frmPBSManagement.WindowState = FormWindowState.Maximized;
            frmPBSManagement.Show();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleMaintenance frmVehicle = new VehicleMaintenance();
            frmVehicle.MdiParent = this;
            frmVehicle.WindowState = FormWindowState.Maximized;
            frmVehicle.Show();
        }

        private void trucktrailerConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruckConfigMaintenance frmTruckConfigMaintenance = new TruckConfigMaintenance();
            frmTruckConfigMaintenance.MdiParent = this;
            frmTruckConfigMaintenance.WindowState = FormWindowState.Maximized;
            frmTruckConfigMaintenance.Show();
        }

        private void axleConfigurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AxleConfiguration frmAxle = new AxleConfiguration();
            frmAxle.MdiParent = this;
            frmAxle.Show();
        }

        private void feeCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleRegFeeCodes frmFeeCodes = new VehicleRegFeeCodes();
            frmFeeCodes.MdiParent = this;
            frmFeeCodes.Show();
        }

        private void nHVRGVMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NHVR_GVM frmGVM = new NHVR_GVM();
            frmGVM.MdiParent = this;
            frmGVM.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSearch frmItemSearch = new ItemSearch();
            frmItemSearch.MdiParent = this;
            frmItemSearch.Show();

        }

        private void lotNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formFound = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "SPLotMaintenance")
                {
                    formFound = true;
                    item.BringToFront();
                    break;
                }
            }
            if (formFound == false)
            {
                SPLotMaintenance frmSPLotMaintenance = new SPLotMaintenance();
                frmSPLotMaintenance.MdiParent = this;
                frmSPLotMaintenance.WindowState = FormWindowState.Maximized;
                frmSPLotMaintenance.Show();
            }
        }

        private void operatorRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorRoles frmOperatorRoles = new OperatorRoles();
            frmOperatorRoles.MdiParent = this;
            frmOperatorRoles.WindowState = FormWindowState.Maximized;
            frmOperatorRoles.Show();
        }

        private void tspSignInOut_Click(object sender, EventArgs e)
        {
            switch (myLoginStatus)
            {
                case "G":
                    myLoginStatus = "O";
                    tspUserName.Text = "logged out"; // not showing
                    menuitemMenu.Enabled = false;
                    break;
                case "O":
                    GenericUserLogin();
                    break;
                case "W":
                    // nothing
                    break;
                default:
                    // invalid
                    MessageBox.Show("Unable to continue! Invalid login status = " + myLoginStatus);
                    break;
            }

        }

        private void operatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsOperator.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAdmin);

        }

        private void QWS_MDIParent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                frmTIQ.BringToFront();
            }
        }

        private void printDocketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocket();
        }

        private void pBSVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBSVehicles frmPBSVehicles = new PBSVehicles();
            frmPBSVehicles.MdiParent = this;
            frmPBSVehicles.WindowState = FormWindowState.Maximized;
            frmPBSVehicles.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCustomer();
        }

        private void CheckCustomer()
        {
            string msg = "SAP BP Search - Check Sync";
            BusinessSearch businessSearch = new BusinessSearch(false, msg);
            businessSearch.ShowDialog();
        }

        private void weightLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckWeightLog();
        }

        private void CheckWeightLog()
        {
            bool formFound = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "TrucksInQuarryAudit")
                {
                    formFound = true;
                    item.BringToFront();
                    break;
                }
            }
            if (formFound == false)
            {
                TrucksInQuarryAudit frmTIQAudit = new TrucksInQuarryAudit();
                frmTIQAudit.MdiParent = this;
                frmTIQAudit.WindowState = FormWindowState.Maximized;
                frmTIQAudit.Show();
            }
        }

        private void checkTruckDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckTruckDriver();
        }

        private void CheckTruckDriver()
        {
            bool formFound = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "CheckTruckDriver")
                {
                    formFound = true;
                    item.BringToFront();
                    break;
                }
            }
            if (formFound == false)
            {
                CheckTruckDriver frmTruckDriver = new QWS_Local.CheckTruckDriver();
                frmTruckDriver.MdiParent = this;
                frmTruckDriver.WindowState = FormWindowState.Maximized;
                frmTruckDriver.Show();
            }

        }

        private void verkadaLPRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerkadaLPR();
        }

        private void VerkadaLPR()
        {
            bool formFound = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "VerkadaLPR")
                {
                    formFound = true;
                    item.BringToFront();
                    break;
                }
            }
            if (formFound == false)
            {
                VerkadaLPR frmVerkadaLPR = new VerkadaLPR();
                frmVerkadaLPR.MdiParent = this;
                frmVerkadaLPR.WindowState = FormWindowState.Maximized;
                frmVerkadaLPR.Show();
            }
        }

        private void licensePlatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerkadaLPR();
        }
    }

}
