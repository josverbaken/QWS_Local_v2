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
            DeliveryOrdersLoad();
            LoadDriver();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DeliveryOrdersLoad();
            // TODO: add parameter for cartage type n6 or n7
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
                int iRow =taTIQ2.FillBy(dsTIQ2.TIQ, 7, TIQID);
                DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
                myTIQRow.AllocateDTTM = DateTime.Now;
                myTIQRow.SAPOrder = CurrentDeliveryOrder().DocNum;
                if (CurrentDeliveryOrder().ItemQA == "Y")
                {
                    myTIQRow.StockpileLotNo = -9;
                }
                else
                {
                    myTIQRow.StockpileLotNo = 0;
                }
                myTIQRow.CustON = CurrentDeliveryOrder().PurchaseOrder;
                myTIQRow.Material = CurrentDeliveryOrder().MaterialCode;
                myTIQRow.MaterialDesc = CurrentDeliveryOrder().Material;
                myTIQRow.CartageCode = CurrentDeliveryOrder().CartageCode;
                bsTIQ2.EndEdit();
                iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1)
                {
                    TrucksInQuarry frmTIQ = new TrucksInQuarry();
                    frmTIQ.MdiParent = this.MdiParent;
                    frmTIQ.Show();
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

    }
}
