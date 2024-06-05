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
        public BookInExBin()
        {
            InitializeComponent();
        }

        public BookInExBin(int myTIQID,int myTruckConfigID, string myCardCode, string myCustomerName, dsQWSLocal.TruckDriverRow driverRow)
        {
            InitializeComponent();
            //EntryDTTM = _EntryDTTM;
            TIQID = myTIQID;
            TruckConfigID = myTruckConfigID;
            CardCode = myCardCode;
            CustomerName = myCustomerName;
            DriverRow = driverRow;
        }

        private int TruckConfigID;
        private int TIQID;
        private string CardCode;
        private string CustomerName;
        private dsQWSLocal.TruckDriverRow DriverRow;

        private void BookInExBin_Load(object sender, EventArgs e)
        {
            LoadExBinItems();
            LoadConfiguredTruckGVM(TruckConfigID);
            LoadDriver();
            ExBinOrdersLoad(CardCode);
            label1.Text = "Customer  = " + CardCode + " " + CustomerName;
        }

        private void ExBinOrdersLoad(string CardCode)
        {
            int iOrders = this.taExBinOrders.FillBy(this.dsBookIn.ExBinOrders,CardCode);
            if (iOrders == 0) { 
                this.tabControl2.SelectedTab = tpExBinNoOrder; 
                rbExBinNoOrder.Checked = true;
            }
            else
            {
                rbExBinSAPOrder.Checked = true;
            }
        }

        private void LoadExBinItems()
        {
            string mySiteCode = Properties.Settings.Default.SiteCode;
            taItem.Fill(dsBookIn.Item, mySiteCode);
        }

        private void LoadConfiguredTruckGVM(int myTruckConfigID)
        {
            taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", myTruckConfigID);
        }

        private void LoadDriver()
        {
            dsQWSLocal.TruckDriver.Clear();
            dsQWSLocal.TruckDriver.ImportRow(DriverRow);
            //bsDriver.Position = 0;
            //DataRow myRow = ((DataRowView)bsDriver.Current).Row;
            //dsQWSLocal.TruckDriverRow myDriverRow = (dsQWSLocal.TruckDriverRow)myRow;
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
            myPayload = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
            nudPayload.Value = myPayload;
            if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
            {
                myPayloadTk = CurrentTruckGVM().GVMTruck - CurrentTruckGVM().TareTk;
                myPayloadTr = myPayload - myPayloadTk;
                nudPayloadTk.Value = myPayloadTk;
                nudPayloadTr.Value = myPayloadTr;
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
                    //TrucksInQuarry frmTIQ = new TrucksInQuarry();
                    //frmTIQ.MdiParent = this.MdiParent;
                    //frmTIQ.Show();
                    MessageBox.Show("TODO - swap to TrucksInQuarry form");
                    //foreach 
                    //if (TrucksInQuarry)
                    //this.MdiParent.BringTIQ2Front();
                    
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

            }
        }
    }
}
