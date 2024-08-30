using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QWS_Local
{
    public partial class TruckConfigMaintenance : Form
    {
        public TruckConfigMaintenance()
        {
            InitializeComponent();
        }

        public TruckConfigMaintenance(string myRego)
        {
            InitializeComponent();
            Rego = myRego;
        }

        private static string Rego = "";

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
                else if (CurrentVehicle().IsLeadVehicle == false)
                {
                    MessageBox.Show("Please get truck before trailer");
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
                            string SelectedAxleConfig = frmAxleConfig.SelectedAxleConfig;
                            string msg = "Selected axle config = ";
                            msg += SelectedAxleConfig;
                            dsQWSLocal.AxleConfigurationRow axleConfigurationRow = frmAxleConfig._AxleConfigurationRow;
                            msg += " vehicle count = " + axleConfigurationRow.Vehicles.ToString();
                            MessageBox.Show(msg);
                            TruckConfigAddTruck(SelectedAxleConfig, Rego, axleConfigurationRow.Vehicles);
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
            this.KeyPreview = true;
            if (Rego.Length>0)
            {
                GetConfiguredTruck(Rego);
            }
        }

        private void TruckConfigMaintenance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                GetConfiguredTruck(txtRego.Text);
            }
        }

        private int TruckConfigAdd(string AxleConfiguration)
        {
            try
            {
                int iTruckConfigID = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TruckConfigAdd";
                cmd.Parameters.AddWithValue("@AxleConfiguration", AxleConfiguration);
                cmd.Parameters.AddWithValue("@Tare", 0.0M);
                cmd.Parameters.AddWithValue("@TareTk", 0.0M);
                cmd.Parameters.AddWithValue("@TareDt", DateTime.Now);
                cmd.Parameters.AddWithValue("@ForceRetare", false);
                cmd.Parameters.AddWithValue("@RetareEveryTime", false);
                sqlConnection.Open();
                iTruckConfigID = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                return iTruckConfigID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NewTruckConfig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -9;
            }
        }

        private void TruckConfigVehicleAdd(int TruckConfigID, string Rego, int Position, decimal PrefPayload)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TruckConfigVehicleAdd";
                cmd.Parameters.AddWithValue("@TruckConfigID", TruckConfigID);
                cmd.Parameters.AddWithValue("@Rego", Rego);
                cmd.Parameters.AddWithValue("@Position", Position);
                cmd.Parameters.AddWithValue("@PrefPayload", PrefPayload);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TruckConfigVehicleAdd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TruckConfigAddTruck(string AxleConfig, string Rego, int Vehicles)
        {
            int myTruckConfigID = TruckConfigAdd(AxleConfig);
            TruckConfigVehicleAdd(myTruckConfigID, Rego, 1, 0.0M);
            for (int i = 1; i < Vehicles; i++) //0 taken by truck as above
            {
                string Trailer;
                // /*TODO*/ filter to trailers and truck axles
                VehicleSearch frmVehicleSearch = new VehicleSearch(CurrentVehicle().CardCode,CurrentVehicle().AxleConfiguration);
                DialogResult dr = frmVehicleSearch.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Trailer = frmVehicleSearch.Rego;
                    TruckConfigVehicleAdd(myTruckConfigID, Trailer, i+1, 0.0M);
                }
            }

            GetConfiguredTruck(Rego);
        }

        private void btnAddTrailer_Click(object sender, EventArgs e)
        {
            // check if truck found
            // check if vehicle count satisfied
            // provide option to add diferent trailer
            MessageBox.Show("check if truck found\r\ncheck if vehicle count satisfied\r\nprovide option to add diferent trailer");
        }

        private void btnAddGVM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("configure gvm, need at least one combination with Road Access = All Roads\r\nPBS should show automatically");
        }
    }
}
