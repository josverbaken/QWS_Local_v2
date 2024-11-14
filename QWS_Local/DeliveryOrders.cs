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
    public partial class DeliveryOrders : Form
    {
        public DeliveryOrders()
        {
            InitializeComponent();
        }

        private void DeliveryOrders_Load(object sender, EventArgs e)
        {
            GetDeliveryOrders();
            bsDeliveryOrdersAll.Filter = "OrderStatus like 'Open'";
        }

        private void rbTruck_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruck.Checked)
            {
                bsDeliveryOrdersAll.Filter = "CartageCode like '%6-%' and OrderStatus like 'Open'";
            }
        }

        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTnT.Checked)
            {
                bsDeliveryOrdersAll.Filter = "CartageCode like '%7-%' and OrderStatus like 'Open'";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDeliveryOrders();
        }

        private void GetDeliveryOrders()
        {
            this.taDeliveryOrdersAll.Fill(this.dsBookIn.DeliveryOrdersAll);
        }

        private void rbClear_CheckedChanged(object sender, EventArgs e)
        {
            bsDeliveryOrdersAll.Filter = "OrderStatus like 'Open'";
        }

        // TODO discuss whether we need to show Closed orders here
    }
}
