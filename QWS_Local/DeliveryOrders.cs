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
        private int mySiteID;
        enum OrderType
        {
            Delivery,
            ExBin,
            Imported,
            None,
        };
        private OrderType myOrderType;

        public DeliveryOrders()
        {
            InitializeComponent();
        }

        private void DeliveryOrders_Load(object sender, EventArgs e)
        {
            GetQuarryOrders();
            var parent = this.MdiParent as QWS_MDIParent;
            mySiteID = parent.SiteID;
        }

        private void SetDeliveryModeFilter()
        {
            if (myOrderType == OrderType.Delivery)
            {
                string myFilter = "";
                string mySitePrefix = "";
                if (mySiteID == 2)
                {
                    mySitePrefix = "02";
                }
                else if (mySiteID == 7)
                {
                    mySitePrefix = "07";
                }
                if (rbTruck.Checked)
                {
                    DeliveryModeFilter = "CartageCode like '" + mySitePrefix + "6%'";
                    if (DeliveryDateFilter.Length > 0)
                    {
                        myFilter = DeliveryModeFilter + " and " + DeliveryDateFilter;
                    }
                    else
                    {
                        myFilter = DeliveryModeFilter;
                    }
                }
                if (rbTnT.Checked)
                {
                    DeliveryModeFilter = "CartageCode like '" + mySitePrefix + "7%'";
                    if (DeliveryDateFilter.Length > 0)
                    {
                        myFilter = DeliveryModeFilter + " and " + DeliveryDateFilter;
                    }
                    else
                    {
                        myFilter = DeliveryModeFilter;
                    }
                }
                if (rbClear.Checked)
                {
                    DeliveryModeFilter = "";
                    if (DeliveryDateFilter.Length > 0)
                    {
                        myFilter = DeliveryDateFilter;
                    }
                }
                bsQuarryOrders.Filter = myFilter;
            }
            else
            {
                DeliveryModeFilter = "";
                rbClear.Checked = true;
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //bsQuarryOrders.Filter = "";
            rbClear.Checked = true;

            GetQuarryOrders();
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
            else
            {
                myFilter = "DeliveryDate <= '" + DateTime.Today + "'";
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
                else
                {
                    myFilter = "DeliveryDate > '" + DateTime.Today + "'";
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
                myOrderType = OrderType.Delivery;
                taQuarryOrders.Fill(dsBookIn.QuarryOrders, "Delivery", "xxx", 0, mySiteID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetExBinOrders()
        {
            try
            {      
                myOrderType = OrderType.ExBin;
                taQuarryOrders.Fill(dsBookIn.QuarryOrders, "ExBin", "AnyCustomer", 0, mySiteID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetImportedOrders()
        {
            try
            {
                myOrderType = OrderType.Imported;
                taQuarryOrders.Fill(dsBookIn.QuarryOrders, "Imported", "AnyCustomer", 0, mySiteID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetImportedPickupOrders()
        {
            try
            {
                myOrderType = OrderType.Imported;
                taQuarryOrders.Fill(dsBookIn.QuarryOrders, "ImportedPickUp", "AnyCustomer", 0, mySiteID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbTruck_CheckedChanged(object sender, EventArgs e)
        {
            SetDeliveryModeFilter();
        }

        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            SetDeliveryModeFilter();
        }

        private void rbClear_CheckedChanged(object sender, EventArgs e)
        {
            SetDeliveryModeFilter();
        }

        private void btnGetExBinOrders_Click(object sender, EventArgs e)
        {
            bsQuarryOrders.Filter = "";
            rbClearDate.Checked = true;
            rbClear.Checked = true;
            GetExBinOrders();
        }

        private void btnImportedOrders_Click(object sender, EventArgs e)
        {
            bsQuarryOrders.Filter = "";
            rbClearDate.Checked=true;
            rbClear.Checked = true; 
            GetImportedOrders();
        }

        private void btnImportedPickupOrders_Click(object sender, EventArgs e)
        {
            bsQuarryOrders.Filter = "";
            rbClearDate.Checked = true;
            rbClear.Checked = true;
            GetImportedPickupOrders();
        }
    }
}
