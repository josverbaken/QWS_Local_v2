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
        public BookInDelivery()
        {
            InitializeComponent();
        }

        private void BookInDelivery_Load(object sender, EventArgs e)
        {
            // nothing yet
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DeliveryOrdersLoad();
        }

        private void DeliveryOrdersLoad()
        {
            this.taDeliveryOrders.FillByOpenQty(this.dsBookIn.DeliveryOrdersAll);
        }
    }
}
