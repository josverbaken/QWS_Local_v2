using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static QWS_Local.dsBookIn;
using static QWS_Local.dsTIQ2;

namespace QWS_Local
{
    public partial class HandwrittenDocket : Form
    {
        private static int mySiteID;
        private static int myDocNum = 0;
        private static int mySAPOrderDocNum = 0;
        private static decimal myGross;
        private static decimal myTare;
        private static decimal myNett;

        private static bool IsPORequired = false;

        private static dsTIQ2.WBDocketsRow docketsRow;
        private static dsTIQ2.WBDocketLinesRow linesRow;

        public HandwrittenDocket()
        {
            InitializeComponent();
        }

        private string QWS_WBO
        {
            get
            {
                var parent = this.MdiParent as QWS_MDIParent;
                return parent.UserName;
            }
        }

        private void HandwrittenDocket_Load(object sender, EventArgs e)
        {
            var parent = this.MdiParent as QWS_MDIParent;
            mySiteID = parent.SiteID;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckDocketNumber();
        }

        private void CheckDocketNumber()
        {
            try
            {
                string myMessage = "Doc Num : " + txtDocNum.Text;
                myMessage += "\r\n\r\nPress Yes to create new docket based on SAP Order.";
                myMessage += "\r\nPress No to create Ex-Bin No-Order docket.";
                myMessage += "\r\nPress cancel to abort creating new docket.";
                string myTopic = "Docket Number Check";
                dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets = new dsTIQ2TableAdapters.WBDocketsTableAdapter();
                taWBDockets.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                myDocNum = System.Convert.ToInt32(txtDocNum.Text);
                int iCount = taWBDockets.FillBy(dsTIQ2.WBDockets,myDocNum);
                if (iCount == 0)
                {
                    btnSaveDocket.Enabled = true;
                    DialogResult dr1 = MessageBox.Show(myMessage,myTopic,MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (dr1)
                    {
                        case DialogResult.Cancel:
                            myMessage = "New docket cancelled.";
                            myTopic = "Cancelled by WBO";
                            break;
                        case DialogResult.Yes:
                            rbSAPOrder.Checked = true;
                            //CreateNewDocket(myDocNum);
                            mtxtSAPOrderDocNum.Focus();
                            break;
                        case DialogResult.No:
                            rbExBinNoOrder.Checked = true;
                            CreateNewDocket(myDocNum);
                            break;
                    }
                }
                else
                {
                    dsTIQ2.WBDockets.Clear();
                    dsTIQ2.WBDocketLines.Clear();
                    myMessage = "Docket already exists.";
                    myTopic = "Docket Number Check";
                    btnSaveDocket.Enabled = false;
                    MessageBox.Show(myMessage, myTopic, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CheckDocketNumber Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveDocket_Click(object sender, EventArgs e)
        {
            SaveHandwrittenDocket();
        }

        private void SaveHandwrittenDocket()
        {
            try
            {
                bsWBDockets.EndEdit();  
                dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets = new dsTIQ2TableAdapters.WBDocketsTableAdapter();
                taWBDockets.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                taWBDockets.Update(dsTIQ2.WBDockets);
                bsWBDocketLines.EndEdit();
                dsTIQ2TableAdapters.WBDocketLinesTableAdapter taWBDocketLines = new dsTIQ2TableAdapters.WBDocketLinesTableAdapter();
                taWBDocketLines.Connection.ConnectionString= QWSConfig.cnQWSLocal;
                taWBDocketLines.Update(dsTIQ2.WBDocketLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Docket Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewDocket(int DocNum)
        {
            try
            {
                dsTIQ2.WBDockets.Clear();
                dsTIQ2.WBDocketLines.Clear();
                string myContactName = string.Empty;
                string myContactMobile = string.Empty;
                int myCntCode = -9;
                string myDeliveryAddress = string.Empty;
                int myDistance = 0;

                if(decimal.TryParse(mtxtGross.Text, out decimal myGross)==false)
                {
                    myGross = 0.0M;
                }

                if (decimal.TryParse(mtxtTare.Text, out decimal myTare)==false)
                {
                    myTare = 0.0M;
                }

                if (decimal.TryParse(mtxtNett.Text, out decimal myNett)==false)
                {
                    myNett = 0.0M;
                }

                if (mySAPOrderDocNum > 0)
                {
                    dsBookInTableAdapters.QuarryOrdersTableAdapter taQuarryOrders = new dsBookInTableAdapters.QuarryOrdersTableAdapter();
                    taQuarryOrders.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                    int iRows = taQuarryOrders.FillBy(dsBookIn.QuarryOrders, mySAPOrderDocNum);
                    if (iRows > 0)
                    {
                        dsBookIn.QuarryOrdersRow myOrderRow = (dsBookIn.QuarryOrdersRow)dsBookIn.QuarryOrders.Rows[0];
                        myContactName = myOrderRow.ContactName;
                        myContactMobile = myOrderRow.ContactMobile;
                        myCntCode = myOrderRow.CntctCode;
                        myDeliveryAddress = myOrderRow.DeliveryAddress;
                        myDistance = myOrderRow.Distance;
                    }
                }
                DataRow dr = dsTIQ2.WBDockets.NewRow();
                docketsRow = (dsTIQ2.WBDocketsRow)dr;
                docketsRow.DocNum = DocNum;
                docketsRow.DocDate = DateTime.Now;
                docketsRow.CardCode = string.Empty;
                docketsRow.CardName = string.Empty;
                docketsRow.PurchaseOrder = string.Empty;
                docketsRow.SAPOrderDocNum = 0;
                docketsRow.CntCode = myCntCode;
                docketsRow.ContactName = myContactName;
                docketsRow.ContactMobile = myContactMobile;
                docketsRow.DeliveryDate = DateTime.Now;
                docketsRow.DeliveryAddress = myDeliveryAddress;
                docketsRow.MapRef = string.Empty;
                docketsRow.Distance = myDistance;
                docketsRow.TruckRego = string.Empty;
                docketsRow.RegA = string.Empty;
                docketsRow.RegB = string.Empty;
                docketsRow.TruckOwnerCode = string.Empty;
                docketsRow.TruckOwner = string.Empty;
                docketsRow.TruckConfig = string.Empty;
                docketsRow.TruckConfigID = 1;
                docketsRow.GrossLegal = 43.50M;
                docketsRow.Gross = myGross;
                docketsRow.Tare = myTare;
                docketsRow.Nett = myNett;
                docketsRow.OverloadPoints = 0;
                docketsRow.OverloadDesc = string.Empty;
                docketsRow.WBMode = "Manual";
                docketsRow.TruckDriverID = 1;
                docketsRow.TruckDriver = string.Empty;
                docketsRow.SalesPersonCode = -1;
                docketsRow.SalesPerson = "";//"Weighbridge Operator";
                docketsRow.EnteredBy = QWS_WBO;
                docketsRow.Comments = "";
                docketsRow.CreatedDTTM = DateTime.Now;
                docketsRow.TIQID = 0; // TODO check what issues this may cause
                dsTIQ2.WBDockets.AddWBDocketsRow(docketsRow);
                bsWBDockets.EndEdit();
                DocketLineAdd("tba", "Item Description", false, 128, "Items", 0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Docket Error!");
            }
        }

        private void DocketLineAdd(string ItemCode, string ItemDescription, bool ItemQA, int ItmsGrpCod, string SWW, int SPLot, int BaseEntry, int lineNum)
        {
            try
            {
                DataRow myDR = ((DataRowView)bsWBDockets.Current).Row;
                dsTIQ2.WBDocketsRow docketsRow = (dsTIQ2.WBDocketsRow)myDR;

                int iLines = bsWBDocketLines.Count; // is zero based, will increment as lines added

                DataRow dr = dsTIQ2.WBDocketLines.NewRow();
                //dsTIQ2.WBDocketLinesRow linesRow = (dsTIQ2.WBDocketLinesRow)dr;
                linesRow = (dsTIQ2.WBDocketLinesRow)dr;
                linesRow.DocNum = docketsRow.DocNum;
                linesRow.BaseEntry = BaseEntry;
                linesRow.DocketLine = lineNum;
                linesRow.WarehouseCode = mySiteID.ToString();
                linesRow.ItemCode = ItemCode;
                linesRow.ItemDescription = ItemDescription;
                linesRow.ItemQA = ItemQA;
                linesRow.ItmsGrpCod = ItmsGrpCod;
                linesRow.SWW = SWW;
                linesRow.StockpileLot = SPLot;
                linesRow.AgrNo = 0; // CurrentTIQ().AgrNo;
                linesRow.AgrLine = 0; // CurrentTIQ().AgrLine;
                string UOM = ItemCode.Substring(ItemCode.Length - 1, 1);
                if (UOM == "1")
                {
                    linesRow.Quantity = 1.0M;
                }
                else
                {
                    decimal myMinimumCart = QWSConfig.MinimumCart;
                    if (SWW == "Freight" && myNett < myMinimumCart)
                    {
                        decimal myPayload = docketsRow.GrossLegal - docketsRow.Tare;
                        if (myPayload < myMinimumCart)
                        {
                            linesRow.Quantity = myPayload;
                        }
                        else
                        {
                            linesRow.Quantity = myMinimumCart;
                        }
                    }
                    else
                    {
                        linesRow.Quantity = myNett;
                    }
                }
                linesRow.CreatedDTTM = DateTime.Now;
                dsTIQ2.WBDocketLines.AddWBDocketLinesRow(linesRow);
                bsWBDocketLines.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DocketLineAdd Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetItem_Click(object sender, EventArgs e)
        {
            LookUpItem();
        }

        private void LookUpItem()
        {
            try
            {
                ItemSearch frmItemSearch = new ItemSearch(true, mySiteID);
                DialogResult dr = frmItemSearch.ShowDialog();
                if (dr == DialogResult.OK)
                {//get details
                    dsBookIn.Item.Clear(); // to allow multiple look ups
                    dsBookIn.Item.ImportRow(frmItemSearch.myItem);
                    SetExBinNoOrderItem();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lookup Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetExBinNoOrderItem()
        {
            try
            {
                bool ItemOK = true;
                if (bsItem.Count > 0)
                {
                    // Check blanket agreement
                    int myAgrNo = 0;
                    int myAgrLine = 0;
                    dsBookIn.BlanketAgreementCheckRow myBlanketRow = (dsBookIn.BlanketAgreementCheckRow)CheckBlanketAgreement(txtCardCode.Text, linesRow.ItemCode);
                    if (myBlanketRow != null)
                    {
                        switch (myBlanketRow.AgrStatus)
                        {
                            case "D":
                                MessageBox.Show("Unable to continue! Please resolve Agreement no : " + myBlanketRow.Number.ToString());
                                ItemOK = false;
                                break;
                            case "F":
                                MessageBox.Show("Unable to continue because Agreement is on hold : " + myBlanketRow.Number.ToString());
                                ItemOK = false;
                                break;
                            case "A":
                                MessageBox.Show("Blanket Agreement is approved!");
                                myAgrNo = myBlanketRow.AgrNo;
                                myAgrLine = myBlanketRow.AgrLineNum;
                                break;
                            default:
                                MessageBox.Show("Invalid BA Status : " + myBlanketRow.AgrStatus.ToString());
                                break;
                        }
                    }
                    DataRow myRow = ((DataRowView)bsItem.Current).Row;
                    if (IsPORequired == true && txtCustON.TextLength == 0)
                    {
                        //PO Required cannot proceed
                        MessageBox.Show("Customer PO is required \r\nplease enter.", "PO Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ItemOK = false;
                    }
                    if (myRow != null && ItemOK == true)
                    {
                        dsBookIn.ItemRow itemRow = (dsBookIn.ItemRow)myRow;
                        linesRow.BaseEntry = 0;
                        //docketsRow.CardCode = txtCardCode.Text;
                        //docketsRow.CardName = txtCustomer.Text;
                        //docketsRow.PurchaseOrder = txtCustON.Text;
                        //docketsRow.CartageCode = "Ex-Bin";
                        //docketsRow.DeliveryAddress = "Ex-Bin";
                        linesRow.ItemCode = itemRow.ItemCode;
                        linesRow.ItemDescription = itemRow.ItemName;
                        linesRow.Quantity = docketsRow.Nett;
                        linesRow.AgrNo = myAgrNo;
                        linesRow.AgrLine = myAgrLine;
                        //if (ACStatus != "A")
                        //{
                        //    _TIQRow.QueueStatus = "C";
                        //}
                        //bsTIQ2.EndEdit();
                        //tabControl2.SelectedTab = tpTruckconfig;
                    }
                }
                //dgvTruckConfig.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SetExBinNoOrderItem");
            }
        }

        private BlanketAgreementCheckRow CheckBlanketAgreement(string CardCode, string ItemCode)
        {
            try
            {
                dsBookInTableAdapters.BlanketAgreementCheckTableAdapter taBlanketAgreement = new dsBookInTableAdapters.BlanketAgreementCheckTableAdapter();
                taBlanketAgreement.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                int iCount = taBlanketAgreement.Fill(this.dsBookIn.BlanketAgreementCheck, CardCode, ItemCode);
                if (iCount == 1)
                {
                    BlanketAgreementCheckRow myRow = (BlanketAgreementCheckRow)dsBookIn.BlanketAgreementCheck.Rows[0];
                    return myRow;
                }
                else if (iCount > 1)
                {
                    MessageBox.Show("Multiple Blanket Agreements - cannot proceed!");
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CheckBlanketAgreement Error!");
                return null;
            }
        }

        private void btnSetExBinItem_Click(object sender, EventArgs e)
        {
            SetExBinNoOrderItem();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            GetCustomer();
        }

        private void GetCustomer()
        {
            try
            {
                BusinessSearch frmBusinessSearch = new BusinessSearch(true);
                DialogResult dr = frmBusinessSearch.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    docketsRow.CardCode = frmBusinessSearch.SAPCode;
                    docketsRow.CardName = frmBusinessSearch.BusinessName;
                    IsPORequired = CheckPORequired(frmBusinessSearch.SAPCode);
                }
                else
                {
                    MessageBox.Show("Customer not found/set. Cannot proceed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetCustomer Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }

        private bool CheckPORequired(string CardCode)
        {
            SqlConnection sqlConnection = new SqlConnection(QWSConfig.cnQWSLocal);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PORequired";
            cmd.Parameters.AddWithValue("@CardCode", CardCode);
            sqlConnection.Open();
            string myPOReq = (string)cmd.ExecuteScalar();
            sqlConnection.Close();
            if (myPOReq == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dsTIQ2.WBDockets.Clear();
            dsTIQ2.WBDocketLines.Clear();
        }

        private void btnGetContact_Click(object sender, EventArgs e)
        {
            GetContact();
        }

        private void GetContact()
        {
            // this is for ex bin no order, not currently implemented
            // SAP orders normally supply a contact
            MessageBox.Show("TODO write code to get order details from SAP_OCPR");
        }

        private void btnCalculateNett_Click(object sender, EventArgs e)
        {
            CalculateNett();
        }

        private void CalculateNett()
        {
            if (bsWBDockets.Count > 0)
            {
                decimal myQty = docketsRow.Gross - docketsRow.Tare;
                docketsRow.Nett = myQty;
                // TODO check tare against that on file
                // TODO update line quantity value
                bsWBDockets.EndEdit();
                foreach (dsTIQ2.WBDocketLinesRow linesRow in dsTIQ2.WBDocketLines)
                {
                    linesRow.Quantity = myQty;
                }
                bsWBDocketLines.EndEdit();
            }
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            GetOrder();
        }

        private void GetOrder()
        {
            //MessageBox.Show("TODO write code to get order details from SAP_ORDR");
            if (int.TryParse(mtxtSAPOrderDocNum.Text, out int result))
            {
                mySAPOrderDocNum = result;
                CreateNewDocket(myDocNum);
            }
            else
            {
                MessageBox.Show("mtxtSAPOrderDocNum = " + mtxtSAPOrderDocNum.Text ,"SAP Order DocNum Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnGetDriver_Click(object sender, EventArgs e)
        {
            GetTruckDriver();
        }

        private void GetTruckDriver()
        {
            string TruckOwnerCode = CurrentTruckConfig().CardCode;
            TruckDriverSearch frmTruckDriver = new TruckDriverSearch(TruckOwnerCode);
            DialogResult dr = frmTruckDriver.ShowDialog();
            if (dr == DialogResult.OK)
            {
                docketsRow.TruckDriverID = frmTruckDriver.TruckDriverID;
                docketsRow.TruckDriver = frmTruckDriver.TruckDriver;
                bsWBDockets.EndEdit();
                mtxtGross.Focus();
            }
            else
            {
                MessageBox.Show("Truck Driver NOT Found!","Truck Driver",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void FindTruckConfig(string Rego, bool Resume)
        {
            try
            {
                dsTruckConfig.ConfiguredTrucks.Clear();
                dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter taConfiguredTrucks = new dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
                taConfiguredTrucks.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                int iCount = taConfiguredTrucks.FillByRego(dsTruckConfig.ConfiguredTrucks, Rego);
                if (iCount == 0) // Configured Truck NOT found
                {
                    MessageBox.Show("Unknown truck/configuration.", "Find Truck", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindTruck_Click(object sender, EventArgs e)
        {
            FindTruckConfig(txtTruckRego.Text, false);
        }

        private void btnSetTruckConfig_Click(object sender, EventArgs e)
        {
            SetTruckConfig();
        }

        private void SetTruckConfig()
        {
            dsTruckConfig.ConfiguredTrucksRow myTruckConfigRow = CurrentTruckConfig();
            docketsRow.TruckConfig = myTruckConfigRow.VehicleType;
            docketsRow.TruckOwnerCode = myTruckConfigRow.CardCode;
            docketsRow.TruckOwner = myTruckConfigRow.TruckOwner;
            bsWBDockets.EndEdit();
        }

        private dsTruckConfig.ConfiguredTrucksRow CurrentTruckConfig()
        {
            DataRow myRow = ((DataRowView)bsConfiguredTrucks.Current).Row;
            dsTruckConfig.ConfiguredTrucksRow myTruckConfigRow = (dsTruckConfig.ConfiguredTrucksRow)myRow;
            return myTruckConfigRow;
        }

        private void rbExBinNoOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExBinNoOrder.Checked)
            {
                btnGetCustomer.Enabled=true;
                btnGetOrder.Enabled = false;
                btnGetItem.Enabled = true;
                mtxtSAPOrderDocNum.ReadOnly = true;
                btnGetCustomer.Focus();
            }
        }

        private void rbSAPOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSAPOrder.Checked)
            {
                btnGetCustomer.Enabled=false;
                btnGetOrder.Enabled = true;
                btnGetItem.Enabled = false;
                mtxtSAPOrderDocNum.ReadOnly = false;
                btnGetOrder.Focus();
            }
        }

        private void nudGross_SelectAll(object sender, EventArgs e)
        {
            // Safely cast the sender back to a NumericUpDown control
            NumericUpDown numBox = sender as NumericUpDown;

            if (numBox != null)
            {
                // Select all text from position 0 up to the maximum string length
                numBox.Select(0, numBox.Text.Length);
            }
        }

        private void nudTare_MouseUp(object sender, MouseEventArgs e)
        {
            // Safely cast the sender back to a NumericUpDown control
            NumericUpDown numBox = sender as NumericUpDown;

            if (numBox != null)
            {
                // Select all text from position 0 up to the maximum string length
                numBox.Select(0, numBox.Text.Length);
            }
        }
    }
}
