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

        public BookInDelivery()
        {
            InitializeComponent();
        }

        public BookInDelivery(int myTruckConfigID)
        {
            InitializeComponent();
            TruckConfigID = myTruckConfigID;
        }

        private void BookInDelivery_Load(object sender, EventArgs e)
        {
            taConfiguredTruckGVM.Fill(this.dsTruckConfig.ConfiguredTruckGVM, "", TruckConfigID);
            DeliveryOrdersLoad();
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

    }
}
