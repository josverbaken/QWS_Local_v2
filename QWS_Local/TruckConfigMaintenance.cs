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
    public partial class TruckConfigMaintenance : Form
    {
        public TruckConfigMaintenance()
        {
            InitializeComponent();
        }


        private void GetConfiguredTruckGVM(string Rego, int TruckConfigID)
        {
            try
            {
                taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", TruckConfigID);
                // leave Rego as "" to get just by TruckConfigID
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetConfiguredTruck(string Rego)
        {
            try
            {
                dsTruckConfig.ConfiguredTrucks.Clear();
                dsTruckConfig.ConfiguredTruckGVM.Clear();
                int iVehicleConfig = this.taConfiguredTrucks.FillByRego(this.dsTruckConfig.ConfiguredTrucks, Rego);
                int iVehicle = this.taVehicle.FillBy(dsQWSLocal.Vehicle, Rego);
                if (iVehicle == 0)
                {
                    DialogResult dr2 = MessageBox.Show("Vehicle not on record. Do you want to add it?", "Vehicle not found!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        VehicleMaintenance frmVehicleMaintenance = new VehicleMaintenance();
                        frmVehicleMaintenance.MdiParent = this.MdiParent;
                        frmVehicleMaintenance.Show();
                    }
                }
                else if (iVehicleConfig == 0) 
                {
                    string myAxleConfig = CurrentVehicle().AxleConfiguration;
                    DialogResult dr = MessageBox.Show("No configuration found. Do you want to add a new configuration?", "Not yet configured.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        AxleConfigurationSearch frmAxleConfig = new AxleConfigurationSearch(myAxleConfig);
                        DialogResult dr1 = frmAxleConfig.ShowDialog();
                        if (dr1 == DialogResult.OK)
                        {
                            string msg = "Selected axle config = ";
                            msg += frmAxleConfig.SelectedAxleConfig;
                            MessageBox.Show(msg);
                            ////TODO if SelectedAxleConfig.length > myAxleConfig.length then get trailer/s
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private dsQWSLocal.VehicleRow CurrentVehicle()
        {
            try
            {
                DataRow myDR = ((DataRowView)bsVehicle.Current).Row;
                dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                return vehicleRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnFindConfiguredTrucks_Click(object sender, EventArgs e)
        {
            GetConfiguredTruck(txtRego.Text);
        }

        private void bsConfiguredTrucks_CurrentChanged(object sender, EventArgs e)
        {
            SyncConfiguredTruckGVM();
        }

        private void SyncConfiguredTruckGVM()
        {
            try
            {
                if (bsConfiguredTrucks.Count > 0)
                {
                    string myRego = CurrentConfigTruck().RegoTk;
                    int myTruckConfigID = CurrentConfigTruck().TruckConfigID;
                    GetConfiguredTruckGVM(myRego, myTruckConfigID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsTruckConfig.ConfiguredTrucksRow CurrentConfigTruck()
        {
            if (bsConfiguredTrucks.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsConfiguredTrucks.Current).Row;
                dsTruckConfig.ConfiguredTrucksRow configuredTruckRow = (dsTruckConfig.ConfiguredTrucksRow)myRow;
                return configuredTruckRow;
            }
            else
            {
                return null;
            }
        }

        private void btnSearchNHVR_Click(object sender, EventArgs e)
        {
            SearchNHVR(CurrentConfigTruck().AxleConfiguration);
        }

        private void SearchNHVR(string AxleConfig)
        {
            NHVR_GVM_Search frmNHVR = new NHVR_GVM_Search(AxleConfig);
            frmNHVR.ShowDialog();
        }

        private void TruckConfigMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQWSLocal.Vehicle' table. You can move, or remove it, as needed.
            this.taVehicle.Fill(this.dsQWSLocal.Vehicle);
            this.KeyPreview = true;
        }

        private void TruckConfigMaintenance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                GetConfiguredTruck(txtRego.Text);
            }
        }
    }
}
