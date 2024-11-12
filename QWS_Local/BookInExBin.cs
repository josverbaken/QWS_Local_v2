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
        private bool IsPrefCust = false;

        private int TruckConfigID;
        private int TIQID;
        private string CardCode;
        private string CustomerName;
        private dsQWSLocal2024.TruckDriverRow DriverRow;

        private enum TIQType
        {
            Retare,
            ExBin,
            Imported,
            ImportedPickUp,
            Delivery
        }

        private TIQType FormTIQType;

        public BookInExBin()
        {
            InitializeComponent();
        }

        public BookInExBin(int myTIQID,string myTIQType,int myTruckConfigID, string myCardCode, string myCustomerName, bool myIsPrefCust , dsQWSLocal2024.TruckDriverRow driverRow)
        {
            InitializeComponent();
            TIQID = myTIQID;
            TruckConfigID = myTruckConfigID;
            CardCode = myCardCode;
            CustomerName = myCustomerName;
            IsPrefCust = myIsPrefCust;
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

        private void BookInExBin_Load(object sender, EventArgs e)
        {
            LoadTIQ();
            LoadConfiguredTruckGVM(TruckConfigID);
            LoadDriver();
            ExBinOrdersLoad(CardCode);
            SetExBinNoOrderCustomer();
            FormLoaded = true;
            dataGridView4.ClearSelection();
        }

        private void LoadTIQ()
        {
            int SiteID = Properties.Settings.Default.SiteID;
            dsTIQ2.Clear();
            int iRow = taTIQ2.FillBy(dsTIQ2.TIQ, SiteID, TIQID);
            if (iRow != 1)
            {
                MessageBox.Show("Error loading TIQ row!","Form BookInExBin LoadTIQ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
            string myDriver = myTIQRow.Driver;
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
            }
            else
            {
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
                MessageBox.Show(ex.Message,"CurrentTruckGVM",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
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
                switch (myTIQRow.TruckConfig)
                {
                    case "TT":
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = true;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = true;
                        txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    case "TKs":
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = true;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = false;
                        txtPayloadSplit.Text = myPayloadTk.ToString();
                        //+ " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    case "TRs":
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = false;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = true;
                        txtPayloadSplit.Text = myPayloadTr.ToString();
                        //txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    default:
                        txtPayloadSplit.Text = string.Empty; // value to write to TIQ determined later
                        nudPayloadTk.Enabled = false;
                        nudPayloadTr.Enabled = false;
                        btnUpdatePayloadSplit.Enabled = false;
                        break;
                }
                //if (myTruckConfigGVM.Compartments > 1 && myTruckConfigGVM.AxleConfiguration.IndexOf("R") > 0)
                //    // TODO how to handle B-double
                ////if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
                //{
                //    myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM  .TareTk;
                //    myPayloadTr = myPayload - myPayloadTk;
                //    nudPayloadTk.Value = myPayloadTk;
                //    nudPayloadTk.Enabled = true;
                //    nudPayloadTr.Value = myPayloadTr;
                //    nudPayloadTr.Enabled = true;
                //    txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                //    //+ " (" + myPayload.ToString() + ")";
                //    btnUpdatePayloadSplit.Enabled = true;
                //}
                //else
                //{
                //    txtPayloadSplit.Text = string.Empty; // value to write to TIQ determined later
                //    nudPayloadTk.Enabled = false;
                //    nudPayloadTr.Enabled = false;
                //    btnUpdatePayloadSplit.Enabled = false;
                //}
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
                MessageBox.Show(ex.Message, "SetTIQOrderDetails");
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
                MessageBox.Show(ex.Message, "CurrentTIQ");
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
            dsTruckConfig.ConfiguredTruckGVMRow myTruckGVM = CurrentTruckGVM();
            decimal myGCM = myTruckGVM.GCM;
            decimal myMaxGVM = myTruckGVM.MaxGVM;
            if (myGCM > myMaxGVM && myMaxGVM > 0)
            {
                myGCM = myMaxGVM;
            }
            myTIQRow.GCM = myGCM;
            myTIQRow.GVMTruck = myTruckGVM.GVMTruck;
            bsTIQ2.EndEdit();
            tabControl2.SelectedTab = tpPayload;        
            CalcPayload();
            SetSplitLoadGUI(myTIQRow.TruckConfig);
        }



        private void SetSplitLoadGUI(string LoadType)
        {
            switch (LoadType)
            {
                case "TK":
                    txtGVMTruck.Visible = false;
                    txtTareTruck.Visible = false;
                    txtPayloadSplit.Visible = false;
                    nudPayloadTk.Visible = false;
                    nudPayloadTr.Visible = false;
                    break;
                case "BD":
                    txtGVMTruck.Visible = false;
                    txtTareTruck.Visible = false;
                    txtPayloadSplit.Visible = false;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = false;
                    nudPayloadTr.Visible = false;
                    break;
                case "TT":
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = true;
                    break;
                case "TKs":
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = false;
                    break;
                case "TRs":
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = true;
                    break;
                default:
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = true;
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
                if (FormTIQType == TIQType.Imported || FormTIQType == TIQType.ImportedPickUp)
                {
                    myTIQRow.QueueStatus = "I";
                }
                else
                { 
                    if (IsPrefCust == true)
                    {
                        switch (myTIQRow.TruckConfig)
                        {
                            case "TRs":
                            case "BDb":
                                myTIQRow.QueueStatus = "S";
                                break;
                            default:
                                myTIQRow.QueueStatus="Q";
                                break;
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
                    if (myTIQRow.TruckConfig == "TKs")
                    {
                        GoBack2BookIn(myTIQRow.Rego, myTIQRow.TruckConfigID, myTIQRow.DriverID, myTIQRow.TIQID, "TRs");
                    }
                    else if (myTIQRow.TruckConfig == "Bda")
                    {
                        // TODO handle split load for B-double
                        MessageBox.Show("","Split B-double",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                myTIQRow.PayloadSplit = nudPayload.Value.ToString();
            }
            else
            {
                myTIQRow.PayloadSplit = txtPayloadSplit.Text;
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
                    }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SetExBinNoOrderItem");
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

        private void GoBack2BookIn(string Rego, int TruckConfigID, int DriverID, int myParentTIQID, string TrailerConfig)
        {
            // call to book in trailer for split load
            BookInTruckStep1 frmBookInStep1 = new BookInTruckStep1(Rego, TruckConfigID, DriverID, myParentTIQID,CurrentTIQ().TruckConfig, "Called after book in TKs", TrailerConfig);
            frmBookInStep1.MdiParent = this.MdiParent;
            frmBookInStep1.Show();
        }

        private void btnUpdatePayloadSplit_Click(object sender, EventArgs e)
        {
            PayloadSplitRefreshGUI();
        }

        private void PayloadSplitRefreshGUI()
        {            
            decimal myPayloadTk = nudPayloadTk.Value;
            decimal myPayloadTr = nudPayloadTr.Value;
            decimal myPayload = myPayloadTk + myPayloadTr;
            if (myPayload <= nudPayload.Value)
            {
                txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString() + " (" + myPayload.ToString() + ")";
            }
            else
            {
                MessageBox.Show("Invalid weights!");
                CalcPayload();
            }
        }
    }
}
