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
        }

        private void rbTruck_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruck.Checked)
            {
                MessageBox.Show("TODO set filter to truck only.");
            }
        }

        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTnT.Checked)
            {
                MessageBox.Show("TODO set filter to truck and trailer.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDeliveryOrders();
        }

        private void GetDeliveryOrders()
        {
            this.deliveryOrdersAllTableAdapter.Fill(this.dsBookIn.DeliveryOrdersAll);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
