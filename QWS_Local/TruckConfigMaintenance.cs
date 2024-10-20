﻿using System;
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
                int iVehicle = this.taVehicle2.FillBy(dsQWSLocal2024.Vehicle, Rego);
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
                    DialogResult dr = MessageBox.Show("No configuration found. Do you want to add a new configuration?", "Not yet configured.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        TruckConfigAdd();
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TruckConfigAdd()
        {
            AxleConfigurationSearch frmAxleConfig = new AxleConfigurationSearch(CurrentVehicle().AxleConfiguration);
            DialogResult dr1 = frmAxleConfig.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                string SelectedAxleConfig = frmAxleConfig.SelectedAxleConfig;
                dsQWSLocal2024.AxleConfigurationRow axleConfigurationRow = frmAxleConfig._AxleConfigurationRow;
                TruckConfigAddTruck(SelectedAxleConfig, CurrentVehicle().Rego, axleConfigurationRow.Vehicles);
            }            
        }

        private dsQWSLocal2024.VehicleRow CurrentVehicle()
        {
            try
            {
                DataRow myDR = ((DataRowView)bsVehicle2.Current).Row;
                dsQWSLocal2024.VehicleRow vehicleRow = (dsQWSLocal2024.VehicleRow)myDR;
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

         private void SearchNHVR()
        {
            NHVR_GVM_Search frmNHVR = new NHVR_GVM_Search(CurrentConfigTruck().AxleConfiguration, CurrentConfigTruck().MassAccreditationLabel);
            DialogResult dr = frmNHVR.ShowDialog();
            if (dr == DialogResult.OK)
            {
                int myTruckConfigID = CurrentConfigTruck().TruckConfigID;
                int myTrucktypeID = frmNHVR.NHVRID;
                TruckConfigNHVRAdd(myTruckConfigID, myTrucktypeID);
                SyncConfiguredTruckGVM();
            }
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

        private void TruckConfigNHVRAdd(int TruckConfigID, int TruckTypeID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TruckConfigNHVRAdd";
                cmd.Parameters.AddWithValue("@TruckConfigID", TruckConfigID);
                cmd.Parameters.AddWithValue("@TruckTypeID",TruckTypeID);
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
            // TODO check if already exists
            // 1 - truck only
            // 2 - T&T
            // 3 - B-double
            bool Okay2Continue = true;
            DialogResult dr11;
            switch (Vehicles)
            {
                case 1:
                    // check if rego and axleconfig already recorded
                    if (bsConfiguredTrucks.Count > 0)
                    {
                        foreach (dsTruckConfig.ConfiguredTrucksRow myConfigTruck in dsTruckConfig.ConfiguredTrucks)
                        {
                            if (myConfigTruck.RegoTk == Rego)
                            {
                                Okay2Continue = false;
                                MessageBox.Show("Already configured! \r\nCannot continue.","Duplicate Check", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                break;
                            }
                        }
                    }
                    //dr11 = MessageBox.Show("Is duplicate?","Check b4 add.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if (dr11 == DialogResult.Yes) { Okay2Continue = false; }    
                    break;
                case 2:
                    // check if rego and trailer regos in same sequence already recorded
                    dr11 = MessageBox.Show("Is duplicate?", "Check b4 add.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr11 == DialogResult.Yes) { Okay2Continue = false; }
                    break;
                case 3:
                    // check if rego and trailer regos in same sequence already recorded
                    dr11 = MessageBox.Show("Is duplicate?", "Check b4 add.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr11 == DialogResult.Yes) { Okay2Continue = false; }
                    break;
                default:
                    Okay2Continue=false;
                    break;
            }
            if (Okay2Continue == true)
            {
                int myTruckConfigID = TruckConfigAdd(AxleConfig);
                TruckConfigVehicleAdd(myTruckConfigID, Rego, 1, 0.0M);
                for (int i = 1; i < Vehicles; i++) //0 taken by truck as above
                {
                    TruckConfigAddTrailer(myTruckConfigID, i + 1);
                }
                GetConfiguredTruck(Rego);
            }
        }

        private void TruckConfigAddTrailer(int TruckConfigID, int Position)
        {
            // search vehicles by trailer axleconfiguration
            int iVehicles = CurrentConfigTruck().Vehicles;

            string TruckAxleConfig = CurrentVehicle().AxleConfiguration;
            string TrailerAxleConfig = CurrentVehicle().AxleConfiguration;
            string CombinationAxleConfig = CurrentConfigTruck().AxleConfiguration;
            int iBreak = TruckAxleConfig.Length - 1;

            switch (iVehicles)
            {
                case 2: // T&T or ST
                    TrailerAxleConfig = CombinationAxleConfig.Substring(iBreak, CombinationAxleConfig.Length - iBreak); //keep R or A
                    break;
                    case 3: // BD
                    break;  
                default:
                    break;
            }
            string Trailer;
            VehicleSearch frmVehicleSearch = new VehicleSearch(CurrentVehicle().CardCode, TrailerAxleConfig, true);
            DialogResult dr = frmVehicleSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Trailer = frmVehicleSearch.Rego;
                TruckConfigVehicleAdd(TruckConfigID, Trailer, Position, 0.0M);
            }
        }

        private void btnAddTrailer_Click(object sender, EventArgs e)
        {
            // Add new configuration for selected truck / prime mover.
            TruckConfigAdd();
        }

        private void btnAddGVM_Click(object sender, EventArgs e)
        {
            SearchNHVR();
        }

        private void btnCheckConfig_Click(object sender, EventArgs e)
        {
            CheckSelectedConfig();
        }

        private void CheckSelectedConfig()
        {
            if (bsConfiguredTrucks.Count == 0)
            {
                MessageBox.Show("Please select a truck first.");
            }
            else
            {
                int CfgVehicleCount = CurrentConfigTruck().Vehicles;
                bool blConfigOK = true;
                switch (CfgVehicleCount)
                {
                    case 1: // truck only, do nothing
                        break;
                    case 2:
                        if (CurrentConfigTruck().RegoTr1.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #1.");
                            blConfigOK = false;
                            TruckConfigAddTrailer(CurrentConfigTruck().TruckConfigID, 2);
                            GetConfiguredTruck(CurrentConfigTruck().RegoTk);
                            SyncConfiguredTruckGVM();
                        }
                        break;
                    case 3:
                        if (CurrentConfigTruck().RegoTr1.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #1.");
                            blConfigOK = false;
                        }
                        if (CurrentConfigTruck().RegoTr2.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #2.");
                            blConfigOK = false;
                        }
                        break;
                    case 4:
                        if (CurrentConfigTruck().RegoTr1.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #1.");
                            blConfigOK =false;
                        }
                        if (CurrentConfigTruck().RegoTr2.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #2.");
                            blConfigOK =false;  
                        }
                        if (CurrentConfigTruck().RegoTr3.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #3.");
                            blConfigOK =false;
                        }
                        break;
                    default:
                        MessageBox.Show("provide option to add diferent trailer");
                        break;

                }
                if (blConfigOK == true)
                {
                    MessageBox.Show("Truck configuration is okay.");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TODO delete or inactive?
            MessageBox.Show("Delete - to be implemented");
        }
    }
}
