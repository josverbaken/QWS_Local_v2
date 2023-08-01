using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QWS_Local;

namespace PBS
{
    public partial class frmPBS_MDI : Form
    {
        public frmPBS_MDI()
        {
            InitializeComponent();
        }

        private void showMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openchild();
        }

        private void openchild()
        {
            PBSMaintenance form1 = new PBSMaintenance();
            form1.MdiParent = this;
            form1.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Show all");
            VehicleMaintenance frmVehicle = new VehicleMaintenance();
            frmVehicle.MdiParent = this;
            frmVehicle.WindowState = FormWindowState.Maximized;
            frmVehicle.Show();
        }

        private void pBSByRegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBSbyRego();
        }

        private void PBSbyRego()
        {
            try
            {
                PBS_by_Rego frmPBS = new PBS_by_Rego();
                frmPBS.MdiParent = this;
                frmPBS.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void regoByPBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rego_By_PBS frmRego = new Rego_By_PBS();
            frmRego.MdiParent = this;
            frmRego.Show();
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

        private void trucksInQuarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrucksInQuarry frmTIQ = new TrucksInQuarry();
            frmTIQ.MdiParent = this;
            frmTIQ.Show();
        }
    }

}
