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
                taTIQ.FillByTIQID(dsQWSLocal.TrucksInQuarry, TIQID);
                DataRow myRow = ((DataRowView)bsTIQ.Current).Row;
                dsQWSLocal.TrucksInQuarryRow myTIQRow = (dsQWSLocal.TrucksInQuarryRow)myRow;
                myTIQRow.AllocateDTTM = DateTime.Now;
                // TODO update other fields
                myTIQRow.Material = "Allocated";
                bsTIQ.EndEdit();
                int iRow = taTIQ.Update(dsQWSLocal.TrucksInQuarry);
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

    }
}
