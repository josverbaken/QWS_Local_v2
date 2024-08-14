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
            this.Size = new Size(1400, 800);
            TrucksInQuarry frmTIQ = new TrucksInQuarry();
            frmTIQ.MdiParent = this;
            frmTIQ.Show();
        }

        private void pBSMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PBSMaintenance frmPBSMaintenance = new PBSMaintenance();
            frmPBSMaintenance.MdiParent = this;
            frmPBSMaintenance.WindowState = FormWindowState.Maximized;
            frmPBSMaintenance.Show();
        }

        private void axleConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AxleConfiguration frmAxle = new AxleConfiguration();
            frmAxle.MdiParent = this;
            frmAxle.Show();
        }

        private void nHVRGVMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NHVR_GVM frmGVM = new NHVR_GVM();
            frmGVM.MdiParent = this;
            frmGVM.Show();
        }

        private void vehicleRegFeeCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleRegFeeCodes frmFeeCodes = new VehicleRegFeeCodes();
            frmFeeCodes.MdiParent = this;
            frmFeeCodes.Show();
        }

        private void truckConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruckConfiguration frmTruckConfiguration = new TruckConfiguration();
            frmTruckConfiguration.MdiParent = this;
            frmTruckConfiguration.Show();
        }

        private void businessPlusPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessPlusPerson frmBusiness = new BusinessPlusPerson();
            frmBusiness.MdiParent = this;
            frmBusiness.Show();
        }

        private void itemSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSearch frmItemSearch = new ItemSearch();
            frmItemSearch.MdiParent = this;
            frmItemSearch.Show();
        }
        private void bookInTruckStep1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInTruckStep1 frmBookIn1 = new BookInTruckStep1();
            frmBookIn1.MdiParent = this;
            frmBookIn1.Show();
        }

        private void deliveryOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryOrders frmDeliveryOrders = new DeliveryOrders();
            frmDeliveryOrders.MdiParent = this;
            frmDeliveryOrders.Show();
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
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                if (tempChild.Name != "TrucksInQuarry")
                {
                    this.MdiChildren[x].Close();
                }
            }
        }

        private void vehicleMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleMaintenance frmVehicle = new VehicleMaintenance();
            frmVehicle.MdiParent = this;
            frmVehicle.WindowState = FormWindowState.Maximized;
            frmVehicle.Show();
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Read the supplied documentation first.");
        }

        private void printDocketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocket frmPrintDocket = new PrintDocket();
            frmPrintDocket.MdiParent = this;
            frmPrintDocket.WindowState = FormWindowState.Maximized;
            frmPrintDocket.Show();
        }

        private void truckConfigMaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruckConfigMaintenance frmTruckConfigMaintenance = new TruckConfigMaintenance();
            frmTruckConfigMaintenance.MdiParent = this;
            frmTruckConfigMaintenance.WindowState = FormWindowState.Maximized;
            frmTruckConfigMaintenance.Show();   
        }
    
        private void trafficCamerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrafficCameras frmTrafficCameras = new TrafficCameras();
            frmTrafficCameras.MdiParent = this;
            frmTrafficCameras.WindowState = FormWindowState.Maximized;
            frmTrafficCameras.Show();
        }

        private void stockpileLotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPLotMaintenance frmSPLotMaintenance = new SPLotMaintenance();
            frmSPLotMaintenance.MdiParent = this;
            frmSPLotMaintenance.WindowState = FormWindowState.Maximized;
            frmSPLotMaintenance.Show(); 
        }
    }
}
