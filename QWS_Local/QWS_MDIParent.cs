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
    public partial class QWS_MDIParent : Form
    {
        public QWS_MDIParent()
        {
            InitializeComponent();
        }

        private void QWS_MDIParent_Load(object sender, EventArgs e)
        {
            //string msg = "QWS Local - ";
            //string SiteLabel = string.Empty;
            //// TODO refactor to cater for more than 2 sites
            //if (Properties.Settings.Default.SiteCode == "07")
            //{
            //    SiteLabel = "Northern Quarries SiteID 07";
            //}
            //else if (Properties.Settings.Default.SiteCode == "02")
            //{
            //    SiteLabel = "Stawell Quarry SiteID 02";
            //}
            //msg += SiteLabel;
            //string DomainName = Environment.UserDomainName;
            //string Username = Environment.UserName;
            //string MachineName = Environment.MachineName;
            //msg += " Username: " + DomainName + "\\" + Username;
            //msg += " Computer: " + MachineName;
            //this.Text = msg;
            this.Size = new Size(1400, 800);
            TrucksInQuarry frmTIQ = new TrucksInQuarry();
            frmTIQ.MdiParent = this;            
            frmTIQ.Show();
        }

        private void bookInTruckStep1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInTruck frmBookIn1 = new BookInTruck();
            frmBookIn1.MdiParent = this;
            frmBookIn1.Show();
        }

        private void deliveryOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        public void BringTIQ2Front()
        {
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                if (tempChild.Name == "TrucksInQuarry")
                {
                    ((TrucksInQuarry)this.MdiChildren[x]).RefreshQueue();
                    this.MdiChildren[x].BringToFront();
                }
            }
        }

        private void tIQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BringTIQ2Front();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMDIChildren();
        }

        private void CloseMDIChildren()
        {
            // except home page = TrucksInQuarry
           while (this.MdiChildren.Length>1)
            {
                for (int x = 0; x < 2; x++)
                {
                    Form tempChild = (Form)this.MdiChildren[x];
                    if (tempChild.Name != "TrucksInQuarry")
                    {
                        this.MdiChildren[x].Close();
                    }
                }
            }
        }

  

        private void printDocketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocket frmPrintDocket = new PrintDocket();
            frmPrintDocket.MdiParent = this;
            frmPrintDocket.WindowState = FormWindowState.Maximized;
            frmPrintDocket.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutQWSLocal frmAbout = new AboutQWSLocal();
            frmAbout.MdiParent = this;
            //frmAbout.WindowState = FormWindowState.Normal;
            //frmAbout.Size = new Size(500, 350);
            frmAbout.Show();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Read the supplied documentation first. Online help is being created soon...");
        }

        private void deliveryOrdersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeliveryOrders frmDeliveryOrders = new DeliveryOrders();
            frmDeliveryOrders.MdiParent = this;
            frmDeliveryOrders.Show();
        }

        private void pBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBSMaintenance frmPBSMaintenance = new PBSMaintenance();
            frmPBSMaintenance.MdiParent = this;
            frmPBSMaintenance.WindowState = FormWindowState.Maximized;
            frmPBSMaintenance.Show();

        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleMaintenance frmVehicle = new VehicleMaintenance();
            frmVehicle.MdiParent = this;
            frmVehicle.WindowState = FormWindowState.Maximized;
            frmVehicle.Show();
        }

        private void trucktrailerConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruckConfigMaintenance frmTruckConfigMaintenance = new TruckConfigMaintenance();
            frmTruckConfigMaintenance.MdiParent = this;
            frmTruckConfigMaintenance.WindowState = FormWindowState.Maximized;
            frmTruckConfigMaintenance.Show();
        }

        private void axleConfigurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AxleConfiguration frmAxle = new AxleConfiguration();
            frmAxle.MdiParent = this;
            frmAxle.Show();
        }

        private void feeCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleRegFeeCodes frmFeeCodes = new VehicleRegFeeCodes();
            frmFeeCodes.MdiParent = this;
            frmFeeCodes.Show();
        }

        private void nHVRGVMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NHVR_GVM frmGVM = new NHVR_GVM();
            frmGVM.MdiParent = this;
            frmGVM.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSearch frmItemSearch = new ItemSearch();
            frmItemSearch.MdiParent = this;
            frmItemSearch.Show();

        }

        private void lotNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPLotMaintenance frmSPLotMaintenance = new SPLotMaintenance();
            frmSPLotMaintenance.MdiParent = this;
            frmSPLotMaintenance.WindowState = FormWindowState.Maximized;
            frmSPLotMaintenance.Show();

        }

        private void operatorRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorRoles frmOperatorRoles = new OperatorRoles();
            frmOperatorRoles.MdiParent = this;
            frmOperatorRoles.WindowState = FormWindowState.Maximized;
            frmOperatorRoles.Show();
        }

        private void sMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SMSGlobal frmSMS = new SMSGlobal();
            frmSMS.MdiParent = this;
            frmSMS.WindowState = FormWindowState.Maximized;
            frmSMS.Show();
        }
    }
}
