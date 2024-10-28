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
    public partial class BookInExBin : Form
    {
        private bool FormLoaded = false;
        //private string LoadType = "TK";
        private bool IsPrefCust = false;
        private string SplitTruckConfig;

        private enum TIQType
        {
            Retare,
            ExBin,
            Imported,
            ImportedPickUp,
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

        private TIQType FormTIQType;

        private LoadType FormLoadType;

        public BookInExBin()
        {
            InitializeComponent();
        }

        public BookInExBin(int myTIQID,string myTIQType,string mySplitTruckConfig,int myTruckConfigID, string myCardCode, string myCustomerName, bool myIsPrefCust , dsQWSLocal2024.TruckDriverRow driverRow)
        {
            InitializeComponent();
            TIQID = myTIQID;
            TruckConfigID = myTruckConfigID;
            CardCode = myCardCode;
            CustomerName = myCustomerName;
            IsPrefCust = myIsPrefCust;
            SplitTruckConfig = mySplitTruckConfig;
            DriverRow = driverRow;
            int ImportedGrpCode = Properties.Settings.Default.ImportedGrpCode;
            int ImportedPickUpGrpCode = Properties.Settings.Default.ImportedPickUpGrpCode;
            string ImportGrpCod = ImportedGrpCode.ToString();
            string ImportPUGrpCod = ImportedPickUpGrpCode.ToString();   
            switch (myTIQType) 
            {
                case "Imported":
                    this.Text = "Book In Imported";
                    bsExBinOrders.Filter = "ItmsGrpCod = " + ImportGrpCod;
                    FormTIQType = TIQType.Imported;
                    break;
                case "ImportedPickUp":
                    this.Text = "Book In Imported PickUp";
                    bsExBinOrders.Filter = "ItmsGrpCod = " + ImportPUGrpCod;
                    FormTIQType = TIQType.ImportedPickUp;
                    break;
                default:
                    this.Text = "Book In ExBin";
                    bsExBinOrders.Filter = "ItmsGrpCod <> " + ImportGrpCod + " AND " + "ItmsGrpCod <> " + ImportPUGrpCod;
                    FormTIQType = TIQType.ExBin;
                    break;
            }
        }

        private int TruckConfigID;
        private int TIQID;
        private string CardCode;
        private string CustomerName;
        private dsQWSLocal2024.TruckDriverRow DriverRow;

        private void BookInExBin_Load(object sender, EventArgs e)
        {
            LoadTIQ();
            LoadConfiguredTruckGVM(TruckConfigID);
            LoadDriver();
            ExBinOrdersLoad(CardCode);
            SetExBinNoOrderCustomer();
            FormLoaded = true;
            dataGridView4.ClearSelection();
            FormLoadType = LoadType.TK;
            label13.Text = SplitTruckConfig.ToString();
        }

        private void LoadTIQ()
        {
            int iRow = taTIQ2.FillBy(dsTIQ2.TIQ, 7, TIQID);
            if (iRow != 1)
            {
                MessageBox.Show("Error loading TIQ row!","Form BookInExBin LoadTIQ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SetExBinNoOrderCustomer()
        {
            txtCardCode.Text = CardCode;
            txtCustomer.Text = CustomerName;
        }

        private void ExBinOrdersLoad(string CardCode)
        {
            int iOrders = this.taExBinOrders.FillBy(this.dsBookIn.ExBinOrders,CardCode);
            if (iOrders == 0) 
            { 
                this.tabControl2.SelectedTab = tpExBinNoOrder; 
                rbExBinNoOrder.Checked = true;
            }
            else
            {
                rbExBinSAPOrder.Checked = true;
                if (iOrders == 1) 
                { 
                    tabControl2.SelectedTab = tpOrderDetails; 
                }
            }
        }

          private void LoadConfiguredTruckGVM(int myTruckConfigID)
        {
            taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", myTruckConfigID);
        }

        private void LoadDriver()
        {
            dsQWSLocal2024.TruckDriver.Clear();
            dsQWSLocal2024.TruckDriver.ImportRow(DriverRow);
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

        private void CalcPayload()
        {
            try
            {
                decimal myPayload = 0.0M;
                decimal myPayloadTk = 0.0M;
                decimal myPayloadTr = 0.0M;
                decimal PayloadLimit;
                dsTruckConfig.ConfiguredTruckGVMRow myTruckConfigGVM = CurrentTruckGVM();
                if (myTruckConfigGVM.GCM > myTruckConfigGVM.MaxGVM && myTruckConfigGVM.MaxGVM > 0)
                {
                    PayloadLimit = myTruckConfigGVM.MaxGVM - myTruckConfigGVM.Tare;
                }
                else
                {
                    PayloadLimit = myTruckConfigGVM.GCM - myTruckConfigGVM.Tare;
                }

                myPayload = PayloadLimit;
                nudPayload.Value = myPayload;
                if (myTruckConfigGVM.Compartments > 1 && myTruckConfigGVM.AxleConfiguration.IndexOf("R") > 0)
                    // TODO how to handle B-double
                //if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
                {
                    myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM  .TareTk;
                    myPayloadTr = myPayload - myPayloadTk;
                    nudPayloadTk.Value = myPayloadTk;
                    nudPayloadTk.Enabled = true;
                    nudPayloadTr.Value = myPayloadTr;
                    nudPayloadTr.Enabled = true;
                    txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString() + " (" + myPayload.ToString() + ")";
                }
                else
                {
                    txtPayloadSplit.Text = myPayload.ToString(); //string.Empty;
                    nudPayloadTk.Enabled = false;
                    nudPayloadTr.Enabled = false;
                }
                bsTIQ2.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CalcPayload ERROR");
                throw;
            }
        }

        private void PayloadNUDLimit()
        {
            decimal PayloadLimit = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;

            if (nudPayload.Value > PayloadLimit)
            {
                nudPayload.Value = PayloadLimit;
                MessageBox.Show("Sorry - can only reduce payload!");
            }
        }

        private void PayloadValidate()
        {
            if ((nudPayloadTk.Value + nudPayloadTr.Value) > nudPayload.Value)
            {
                MessageBox.Show("Payload split > total Payload!");
            }
        }

        private void btnPayload_Click(object sender, EventArgs e)
        {
            CalcPayload();
        }

        private void nudPayload_ValueChanged(object sender, EventArgs e)
        {
            PayloadNUDLimit();
        }

        private void btnPayloadValidate_Click(object sender, EventArgs e)
        {
            PayloadValidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddExBinOrder2TIQ();
            // TODO add order details to TIQ, data source depends on if from Order
        }

        private void AddExBinOrder2TIQ()
        {
            try
            {
                int iRow = taTIQ2.FillBy(dsTIQ2.TIQ, 7, TIQID);
                DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
                myTIQRow.AllocateDTTM = DateTime.Now;
                myTIQRow.SAPOrder = CurrentExBinOrder().DocNum;
                if (CurrentExBinOrder().ItemQA == "Y")
                {
                    myTIQRow.StockpileLotNo = -9;
                }
                else
                {
                    myTIQRow.StockpileLotNo = 0;
                }
                myTIQRow.CustON = CurrentExBinOrder().PurchaseOrder;
                myTIQRow.Material = CurrentExBinOrder().MaterialCode;
                myTIQRow.MaterialDesc = CurrentExBinOrder().Material;
                myTIQRow.DeliveryAddress = "Ex-Bin";
                myTIQRow.CartageCode = "";
                myTIQRow.QueueStatus = "Q";
                bsTIQ2.EndEdit();
                iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1)
                {
                    ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();                   
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddDelivery2TIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private dsBookIn.ExBinOrdersRow CurrentExBinOrder()
        {
            if (bsExBinOrders.Count >0)
            {
                DataRow myRow = ((DataRowView)bsExBinOrders.Current).Row;
                dsBookIn.ExBinOrdersRow ExBinRow = (dsBookIn.ExBinOrdersRow)myRow;
                return ExBinRow;
            }
            else
            {
                return null;
            }
        }

        private void bsConfiguredTruckGVM_CurrentChanged(object sender, EventArgs e)
        {
            CalcPayload();
        }

        private void btnExBinItems_Click(object sender, EventArgs e)
        {
            ItemSearch frmItemSearch = new ItemSearch(true);
            DialogResult dr = frmItemSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {//get details
                dsBookIn.Item.ImportRow(frmItemSearch.myItem);
            }
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            ExBinOrdersLoad(CardCode);
        }

        private void btnSetExBinOrder_Click(object sender, EventArgs e)
        {
            SetTIQOrderDetails();
        }

        private void SetTIQOrderDetails()
        {
            try
            {
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                myTIQRow.SAPOrder = CurrentExBinOrder().DocNum;
                myTIQRow.CustomerCode = CurrentExBinOrder().CardCode;
                myTIQRow.Customer = CurrentExBinOrder().Customer;
                myTIQRow.CustON = CurrentExBinOrder().PurchaseOrder;
                myTIQRow.Material = CurrentExBinOrder().MaterialCode;
                myTIQRow.MaterialDesc = CurrentExBinOrder().Material;
                myTIQRow.DeliveryAddress = CurrentExBinOrder().DeliveryAddress;
                //myTIQRow.CartageCode = CurrentExBinOrder().CartageCode;  // ex bin so no cartage
                bsTIQ2.EndEdit();
                tabControl2.SelectedTab = tpTruckconfig;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsTIQ2.TIQRow CurrentTIQ()
        {
            try
            {
                if (bsTIQ2.Count > 0)
                {
                    DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                    dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
                    return myTIQRow;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void TextBoxFormatDecimal()
        {
            if (bsExBinOrders.Count > 0)
            {
                txtQuantity.Text = CurrentExBinOrder().Quantity.ToString("#.00");
                txtSupplied.Text = CurrentExBinOrder().Supplied.ToString("#.00");
                txtOpenQty.Text = CurrentExBinOrder().OpenQty.ToString("#.00");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bsExBinOrders.Count > 0 && FormLoaded == true && dataGridView4.SelectedRows.Count == 1)
            {
                // TODO jut go to details if only 1 order!
                DialogResult dr = MessageBox.Show("Move to details ?", "Choose Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    tabControl2.SelectedTab = tpOrderDetails;
                }
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tpOrderDetails)
            {
                TextBoxFormatDecimal();
            }
        }

        private void btnSetTruckConfig_Click(object sender, EventArgs e)
        {
            SetTIQTruckconfig();
        }

        private void SetTIQTruckconfig()
        {
            dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
            decimal myGCM = CurrentTruckGVM().GCM;
            decimal myMaxGVM = CurrentTruckGVM().MaxGVM;
            if (myGCM > myMaxGVM && myMaxGVM > 0)
            {
                myGCM = myMaxGVM;
            }
            myTIQRow.GCM = myGCM;
            myTIQRow.GVMTruck = CurrentTruckGVM().GVMTruck;
            bsTIQ2.EndEdit();
            tabControl2.SelectedTab = tpPayload;
            if (CurrentTruckGVM().Compartments > 1)
            {
                // check if split
                switch (SplitTruckConfig)
                {
                    case "TKs":
                        txtTruckConfig.Text = "TRs";
                        //CurrentTIQ().QueueStatus = "S";
                        btnSplitLoadType.Enabled = false;
                        //FormLoadType = LoadType.TRs; //??
                        bsTIQ2.EndEdit();
                        break;
                    case "BDa":
                        txtTruckConfig.Text = "BDb";
                        btnSplitLoadType.Enabled = false;
                        //CurrentTIQ().QueueStatus = "S";
                        bsTIQ2.EndEdit();
                        break;
                    default:
                        btnSplitLoadType.Enabled = true;
                        break;
                }
            }
            else
            {
                btnSplitLoadType.Enabled = false;
            }
            CalcPayload();
            SetSplitLoadGUI(FormLoadType.ToString());
        }

        private void btnSplitLoadType_Click(object sender, EventArgs e)
        {
            SetSplitLoadType();
        }

        private void SetSplitLoadType()
        {
            string AxleConfig = CurrentTruckGVM().AxleConfiguration;
            SplitLoadType frmLoadType = new SplitLoadType(AxleConfig);
            DialogResult dr = frmLoadType.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtTruckConfig.Text = frmLoadType.strSplitLoadType;
                bsTIQ2.EndEdit();
                SetSplitLoadGUI(frmLoadType.strSplitLoadType);
            }
            else
            {
                txtTruckConfig.Text = "Cancelled!";
            }
        }

        private void SetSplitLoadGUI(string LoadType)
        {
            switch (LoadType)
            {
                case "TK":
                case "BD":
                    txtGVMTruck.Visible = false;
                    txtTareTruck.Visible = false;
                    txtPayloadSplit.Visible = false;
                    nudPayloadTk.Visible = false;
                    nudPayloadTr.Visible = false;
                    //lblPayloadSplit.Visible = false;
                    // issue with databound labels
                    label7.Visible = false;
                    break;
                default:
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = true;
                    //lblPayloadSplit.Visible = true;
                    label7.Visible = true;
                    break;            
            }
        }

        private void btnBookIn_Click(object sender, EventArgs e)
        {
            AddExBin2TIQ();
        }

        private void AddExBin2TIQ()
        {
            try
            {
                SetTIQPayload();
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                myTIQRow.AllocateDTTM = DateTime.Now;
                myTIQRow.CartageCode = "";
                myTIQRow.Payload = nudPayload.Value;
                if (FormTIQType == TIQType.Imported || FormTIQType == TIQType.ImportedPickUp)
                {
                    myTIQRow.QueueStatus = "I";
                }
                else
                { 
                    if (IsPrefCust == true)
                    {
                        if (SplitTruckConfig == "TKs" || SplitTruckConfig == "BDa")
                        {
                            myTIQRow.QueueStatus = "S";
                        }
                        else
                        {
                            myTIQRow.QueueStatus = "Q";
                        }
                    }
                    else
                    {
                        myTIQRow.QueueStatus = "U";
                    }
                }
                bsTIQ2.EndEdit();
                int iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1) // TODO test if split load
                {
                    if (txtTruckConfig.Text == "TKs")
                    {
                        MessageBox.Show("To book in TRs","Split Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GoBack2BookIn(CurrentTIQ().Rego, CurrentTIQ().TIQID, CurrentTIQ().TruckConfigID, CurrentTIQ().DriverID);
                    }
                    else
                    {
                        ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddExBin2TIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTIQPayload()
        {
            dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
            myTIQRow.Payload = nudPayload.Value;
            if (txtPayloadSplit.Text.Length == 0)
            {
                txtPayloadSplit.Text = nudPayload.Value.ToString();
            }
            else
            {
                myTIQRow.PayloadSplit = txtPayloadSplit.Text;
            }
            if (FormLoadType.ToString().Length == 3)
            {
                myTIQRow.TruckConfig = FormLoadType.ToString();
            }
            bsTIQ2.EndEdit();
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (bsExBinOrders.Count > 0 && FormLoaded == true && dataGridView4.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Move to details ?", "Choose Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    tabControl2.SelectedTab = tpOrderDetails;
                }
            }
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            SetExBinNoOrderItem();
        }

        private void SetExBinNoOrderItem()
        {
            try
            { 
            if (bsItem.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsItem.Current).Row;
                if (myRow != null)
                {
                    dsBookIn.ItemRow itemRow = (dsBookIn.ItemRow)myRow;
                    dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                    myTIQRow.SAPOrder = 0;
                    myTIQRow.CustomerCode = txtCardCode.Text;
                    myTIQRow.Customer = txtCustomer.Text;
                    myTIQRow.CustON = txtCustON.Text;
                    myTIQRow.Material = itemRow.ItemCode;
                    myTIQRow.MaterialDesc = itemRow.ItemName;
                    bsTIQ2.EndEdit();
                    tabControl2.SelectedTab = tpTruckconfig;
                    rbExBinNoOrder.Checked = true;  
                    }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeCustomer();
        }

        private void ChangeCustomer()
        {
            BusinessSearch frmBusinessSearch = new BusinessSearch();
            DialogResult dr = frmBusinessSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtCardCode.Text = frmBusinessSearch.SAPCode;
                txtCustomer.Text = frmBusinessSearch.BusinessName;
                //return 
            }
            else
            {
                //return null;
                txtCardCode.Text = "n/a";
                txtCustomer.Text = "n/a";
            }
        }

        private void GoBack2BookIn(string Rego, int TruckConfigID, int DriverID, int myParentTIQID)
        {
            //called after retare successful //TODO modify for split load
            BookInTruckStep1 frmBookInStep1 = new BookInTruckStep1(Rego, TruckConfigID, DriverID, myParentTIQID,CurrentTIQ().TruckConfig, "Called after book in TKs");
            frmBookInStep1.MdiParent = this.MdiParent;
            frmBookInStep1.Show();
        }


    }
}
