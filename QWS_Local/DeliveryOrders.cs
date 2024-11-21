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
        private static string DeliveryModeFilter = "";
        private static string DeliveryDateFilter = "";

        public DeliveryOrders()
        {
            InitializeComponent();
        }

        private void DeliveryOrders_Load(object sender, EventArgs e)
        {
            GetQuarryOrders();
        }

        private void rbTruck_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruck.Checked)
            {
                string myFilter = "";
                DeliveryModeFilter = "CartageCode like '%6-%'";
                if (DeliveryDateFilter.Length > 0)
                { 
                    myFilter = DeliveryModeFilter + " and " + DeliveryDateFilter; 
                }
                else
                {
                    myFilter = DeliveryModeFilter;
                }
                bsQuarryOrders.Filter = myFilter;
            }
        }

        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTnT.Checked)
            {
                string myFilter = "";
                DeliveryModeFilter = "CartageCode like '%7-%'";
                if (DeliveryDateFilter.Length > 0)
                {
                    myFilter = DeliveryModeFilter + " and " + DeliveryDateFilter;
                }
                else
                {
                    myFilter = DeliveryModeFilter;
                }
                bsQuarryOrders.Filter = myFilter;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetQuarryOrders();
        }


        private void rbClear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClear.Checked)
            {
                string myFilter = "";
                DeliveryModeFilter = "";
                if (DeliveryDateFilter.Length > 0)
                {
                    myFilter = DeliveryDateFilter;
                }
                bsQuarryOrders.Filter = myFilter;
            }
        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToday.Checked)
            { 
            string myFilter = "";
            if (DeliveryModeFilter.Length > 0)
            {
                myFilter = DeliveryModeFilter + " and  DeliveryDate <= '" + DateTime.Today + "'";
            }
            bsQuarryOrders.Filter = myFilter;
            }
        }

        private void rbFuture_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFuture.Checked)
            {
                string myFilter = "";
                if (DeliveryModeFilter.Length > 0)
                {
                    myFilter = DeliveryModeFilter + " and  DeliveryDate > '" + DateTime.Today + "'";
                }
                bsQuarryOrders.Filter = myFilter;
            }
        }

        private void rbClearDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClearDate.Checked)
            {
                string myFilter = "";
                DeliveryDateFilter = "";
                if (DeliveryModeFilter.Length > 0)
                {
                    myFilter = DeliveryModeFilter;
                }
                bsQuarryOrders.Filter = myFilter;
            }
        }
   
        private void GetQuarryOrders()
        {
            try
            {
                taQuarryOrders.Fill(dsBookIn.QuarryOrders, "Delivery", "xxx", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
