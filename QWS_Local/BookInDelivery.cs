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
    public partial class BookInDelivery : Form
    {
        private static int TruckConfigID;
        private static int TIQID;
        private string LoadType = "TK";
        private dsQWSLocal.TruckDriverRow DriverRow;

        public BookInDelivery()
        {
            InitializeComponent();
        }

        public BookInDelivery(int myTIQID, int myTruckConfigID, dsQWSLocal.TruckDriverRow driverRow)
        {
            InitializeComponent();
            TIQID = myTIQID;
            TruckConfigID = myTruckConfigID;
            DriverRow = driverRow;
        }

        private void BookInDelivery_Load(object sender, EventArgs e)
        {
            taConfiguredTruckGVM.Fill(this.dsTruckConfig.ConfiguredTruckGVM, "", TruckConfigID);
            LoadTIQ();
            DeliveryOrdersLoad();
            LoadDriver();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DeliveryOrdersLoad();
            // TODO: add parameter for cartage type n6 or n7
        }

        private void LoadTIQ()
        {
            int iRow = taTIQ2.FillBy(dsTIQ2.TIQ, 7, TIQID);
            if (iRow != 1)
            {
                MessageBox.Show("Error loading TIQ row!");
            }
        }

        private void DeliveryOrdersLoad()
        {
            this.taDeliveryOrders.FillByOpenQty(this.dsBookIn.DeliveryOrdersAll);
        }

        private void LoadDriver()
        {
            dsQWSLocal.TruckDriver.Clear();
            dsQWSLocal.TruckDriver.ImportRow(DriverRow);
            //bsDriver.Position = 0;
            //DataRow myRow = ((DataRowView)bsDriver.Current).Row;
            //dsQWSLocal.TruckDriverRow myDriverRow = (dsQWSLocal.TruckDriverRow)myRow;
        }

        private void btnBookIn_Click(object sender, EventArgs e)
        {
            AddDelivery2TIQ();
        }

        private void AddDelivery2TIQ()
        {
            try
            {                
                DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
                myTIQRow.AllocateDTTM = DateTime.Now;
                //myTIQRow.SAPOrder = CurrentDeliveryOrder().DocNum;
                if (CurrentDeliveryOrder().ItemQA == "Y")
                {
                    myTIQRow.StockpileLotNo = -9;
                }
                else
                {
                    myTIQRow.StockpileLotNo = 0;
                }
                //myTIQRow.CustON = CurrentDeliveryOrder().PurchaseOrder;
                //myTIQRow.Material = CurrentDeliveryOrder().MaterialCode;
                //myTIQRow.MaterialDesc = CurrentDeliveryOrder().Material;
                //myTIQRow.CartageCode = CurrentDeliveryOrder().CartageCode;
                //myTIQRow.Payload = nudPayload.Value;
                myTIQRow.QueueStatus = "Q";
                bsTIQ2.EndEdit();
                int iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1)
                {
                    TrucksInQuarry frmTIQ = new TrucksInQuarry();
                    frmTIQ.MdiParent = this.MdiParent;
                    frmTIQ.RefreshQueue();
                    frmTIQ.Show();
                    frmTIQ.ClearTIQ(); // sequence is important
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddDelivery2TIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private dsBookIn.DeliveryOrdersAllRow CurrentDeliveryOrder()
        {
            if (bsDeliveryOrders.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsDeliveryOrders.Current).Row;
                dsBookIn.DeliveryOrdersAllRow deliveryRow = (dsBookIn.DeliveryOrdersAllRow)myRow;
                return deliveryRow;
            }
            else
            {
                return null;
            }
        }

        private void btnPayload_Click(object sender, EventArgs e)
        {
            CalcPayload();
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
            if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
            {
                myPayloadTk = CurrentTruckGVM().GVMTruck - CurrentTruckGVM().TareTk;
                myPayloadTr = myPayload - myPayloadTk;
                nudPayloadTk.Value = myPayloadTk;
                nudPayloadTk.Enabled = true;
                nudPayloadTr.Value = myPayloadTr;
                nudPayloadTr.Enabled= true;
                txtPayloadSplit.Text = myPayloadTk.ToString() + "/" + myPayloadTr.ToString() + "(" + myPayload.ToString() + ")";
            }
            else
            {
                txtPayloadSplit.Text = string.Empty;
                nudPayloadTk.Enabled = false;
                nudPayloadTr.Enabled = false;
            }
        }

        private void PayloadNUDLimit()
        {
            decimal PayloadLimit;
            if (CurrentTruckGVM().GCM > CurrentTruckGVM().MaxGVM && CurrentTruckGVM().MaxGVM > 0 )
            {
                PayloadLimit = CurrentTruckGVM().MaxGVM - CurrentTruckGVM().Tare;
            }
            else
            {
                PayloadLimit = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
            }

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

        private void btnPayloadValidate_Click(object sender, EventArgs e)
        {
            PayloadValidate();
        }

        private void btnPayload_Click_1(object sender, EventArgs e)
        {
            CalcPayload();
        }

        private void btnPayloadValidate_Click_1(object sender, EventArgs e)
        {
            PayloadValidate();
        }

        private void nudPayload_ValueChanged(object sender, EventArgs e)
        {
            PayloadNUDLimit();
        }

        private void bsConfiguredTruckGVM_CurrentChanged(object sender, EventArgs e)
        {
            if (bsConfiguredTruckGVM != null)
            {
                CalcPayload();
            }
        }

        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            SetTIQOrderDetails();
        }

        private void SetTIQOrderDetails()
        {
            try
            {
                DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
                myTIQRow.SAPOrder = CurrentDeliveryOrder().DocNum;
                myTIQRow.CustomerCode = CurrentDeliveryOrder().CardCode;
                myTIQRow.Customer = CurrentDeliveryOrder().Customer;
                myTIQRow.CustON = CurrentDeliveryOrder().PurchaseOrder;
                myTIQRow.Material = CurrentDeliveryOrder().MaterialCode;
                myTIQRow.MaterialDesc = CurrentDeliveryOrder().Material;
                myTIQRow.CartageCode = CurrentDeliveryOrder().CartageCode;
                bsTIQ2.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetTruckConfig_Click(object sender, EventArgs e)
        {
            SetTIQTruckconfig();
        }

        private void SetTIQTruckconfig()
        {
            DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
            dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
            decimal myGCM = CurrentTruckGVM().GCM;
            decimal myMaxGVM = CurrentTruckGVM().MaxGVM;
            if (myGCM > myMaxGVM)
            {
                myGCM = myMaxGVM;
            }
            myTIQRow.GCM = myGCM;
            myTIQRow.GVMTruck =  CurrentTruckGVM().GVMTruck;
            bsTIQ2.EndEdit();
        }

        private void btnSetPayload_Click(object sender, EventArgs e)
        {
            SetTIQPayload();
        }

        private void SetTIQPayload()
        {
            DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
            dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
            myTIQRow.Payload = nudPayload.Value;
            myTIQRow.PayloadSplit = txtPayloadSplit.Text;
            if(LoadType.Length == 3)
            {
                myTIQRow.TruckConfig = LoadType;
            }
            bsTIQ2.EndEdit();
        }

         private void button1_Click(object sender, EventArgs e)
        {
            CalcPayload();
        }
     
        private void button2_Click(object sender, EventArgs e)
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
            }
            else
            {
                txtTruckConfig.Text = "Cancelled!";
            }
        }
    }
}
