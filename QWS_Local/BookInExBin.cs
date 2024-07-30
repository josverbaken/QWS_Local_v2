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
        private string LoadType = "TK";
        private bool IsPrefCust = false;

        private enum TIQType
        {
            Retare,
            ExBin,
            Imported,
            Delivery
        }

        private TIQType FormTIQType;

        public BookInExBin()
        {
            InitializeComponent();
        }

        public BookInExBin(int myTIQID,string myTIQType,int myTruckConfigID, string myCardCode, string myCustomerName, bool myIsPrefCust , dsQWSLocal.TruckDriverRow driverRow)
        {
            InitializeComponent();
            TIQID = myTIQID;
            TruckConfigID = myTruckConfigID;
            CardCode = myCardCode;
            CustomerName = myCustomerName;
            IsPrefCust = myIsPrefCust;
            DriverRow = driverRow;
            if (myTIQType == "Imported")
            {
                this.Text = "Book In Imported";
                bsExBinOrders.Filter = "ItmsGrpCod = 138";
                FormTIQType = TIQType.Imported;
            }
            else
            {
                this.Text = "Book In ExBin";
                bsExBinOrders.Filter = "ItmsGrpCod <> 138"; 
                FormTIQType = TIQType.ExBin;
            }
        }

        private int TruckConfigID;
        private int TIQID;
        private string CardCode;
        private string CustomerName;
        private dsQWSLocal.TruckDriverRow DriverRow;

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
            int iRow = taTIQ2.FillBy(dsTIQ2.TIQ, 7, TIQID);
            if (iRow != 1)
            {
                MessageBox.Show("Error loading TIQ row!");
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
            dsQWSLocal.TruckDriver.Clear();
            dsQWSLocal.TruckDriver.ImportRow(DriverRow);
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
            decimal myPayload = 0.0M;
            decimal myPayloadTk = 0.0M;
            decimal myPayloadTr = 0.0M;

            decimal PayloadLimit;
            if (CurrentTruckGVM().GCM > CurrentTruckGVM().MaxGVM && CurrentTruckGVM().MaxGVM > 0)
            {
                PayloadLimit = CurrentTruckGVM().MaxGVM - CurrentTruckGVM().Tare;
            }
            else
            {
                PayloadLimit = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
            }

            myPayload = PayloadLimit;
            nudPayload.Value = myPayload;
            if (CurrentTruckGVM().Compartments > 1)
            //if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
            {
                myPayloadTk = CurrentTruckGVM().GVMTruck - CurrentTruckGVM().TareTk;
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
                btnSplitLoadType.Enabled = true;
            }
            else
            {
                btnSplitLoadType.Enabled = false;
            }
            CalcPayload();
            SetSplitLoadGUI(txtTruckConfig.Text);
        }

        private void btnSplitLoadType_Click(object sender, EventArgs e)
        {
            SetSplitLoadType();
        }

        private void SetSplitLoadType()
        {
            SplitLoadType frmLoadType = new SplitLoadType();
            DialogResult dr = frmLoadType.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtTruckConfig.Text = frmLoadType.LoadType;
                bsTIQ2.EndEdit();
                SetSplitLoadGUI(frmLoadType.LoadType);
            }
            else
            {
                txtTruckConfig.Text = "Cancelled!";
            }
        }

        private void SetSplitLoadGUI(string LoadType)
        {
            if (LoadType == "TK")
            {
                txtGVMTruck.Visible = false;
                txtTareTruck.Visible = false;
                txtPayloadSplit.Visible = false;
                nudPayloadTk.Visible = false;
                nudPayloadTr.Visible = false;
                //lblPayloadSplit.Visible = false;
                // issue with databound labels
                label7.Visible = false;
            }
            else
            {
                txtGVMTruck.Visible = true;
                txtTareTruck.Visible = true;
                txtPayloadSplit.Visible = true;
                nudPayloadTk.Visible = true;
                nudPayloadTr.Visible = true;
                //lblPayloadSplit.Visible = true;
                label7.Visible = true;
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
                if (FormTIQType == TIQType.Imported)
                {
                    myTIQRow.QueueStatus = "I";
                }
                else
                { 
                    if (IsPrefCust == true)
                    {
                        myTIQRow.QueueStatus = "Q";
                    }
                    else
                    {
                        myTIQRow.QueueStatus = "U";
                    }
                }
                bsTIQ2.EndEdit();
                int iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1)
                {
                    ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();
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
            if (LoadType.Length == 3)
            {
                myTIQRow.TruckConfig = LoadType;
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

        //private dsQWSLocal.BusinessRow ChangeCustomer()
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
    }
}
