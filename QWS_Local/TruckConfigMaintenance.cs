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
            // check if already exists
            // 1 - truck only if axle config contains R
            // 2 - T&T or semi-trailer
            // 3 - B-double
            // 4 - A-double
            try
            {
                string[] RegoArray = new string[Vehicles];
                bool Okay2Continue = true;
                RegoArray[0] = Rego;
                dsQWSLocal2024.VehicleRow myVehicle = CurrentVehicle();
                string TruckAxleConfig = myVehicle.AxleConfiguration; 
                string TrailerAxleConfig = "tba";
                int iBreak = TruckAxleConfig.Length - 1;
                switch (Vehicles)
                {
                    case 1:
                    if (bsConfiguredTrucks.Count > 0)
                    {
                        foreach (dsTruckConfig.ConfiguredTrucksRow myConfigTruck in dsTruckConfig.ConfiguredTrucks)
                        {
                        // ensure comparison config is for vehicles = 1
                            if (myConfigTruck.RegoTk == Rego && myConfigTruck.Vehicles == 1 && myVehicle.AxleConfiguration.Contains("R") == true)
                            {
                                Okay2Continue = false;
                                MessageBox.Show("Already configured! \r\nCannot continue.", "Duplicate Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                        }
                    }
                        break;
                    case 2: // T&T or ST
                        //TrailerAxleConfig = CombinationAxleConfig.Substring(iBreak, CombinationAxleConfig.Length - iBreak); //keep R or A
                        TrailerAxleConfig = AxleConfig.Substring(iBreak, AxleConfig.Length - iBreak); //keep R or A
                        string Trailer = "";
                        VehicleSearch frmVehicleSearch = new VehicleSearch(myVehicle.CardCode, TrailerAxleConfig, true);
                        DialogResult dr = frmVehicleSearch.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            Trailer = frmVehicleSearch.Rego;
                        }
                        RegoArray[1] = Trailer;
                    if (bsConfiguredTrucks.Count > 0)
                    {
                        foreach (dsTruckConfig.ConfiguredTrucksRow myConfigTruck in dsTruckConfig.ConfiguredTrucks)
                        {
                            string testRego = RegoArray[0] + RegoArray[1];
                            string compareRego = myConfigTruck.RegoTk + myConfigTruck.RegoTr1;
                            if (testRego == compareRego)
                            {
                                Okay2Continue = false;
                                MessageBox.Show("Already configured! \r\nCannot continue.", "Duplicate Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                        }
                    }
                        break;
                    case 3: // BD
                        TrailerAxleConfig = AxleConfig.Substring(iBreak, 2); // A3, A2 etc
                        string BTrailer = "";
                        VehicleSearch frmVehicleSearchBD = new VehicleSearch(myVehicle.CardCode, TrailerAxleConfig, false);
                        DialogResult dr1 = frmVehicleSearchBD.ShowDialog();
                        if (dr1 == DialogResult.OK)
                        {
                            BTrailer = frmVehicleSearchBD.Rego;
                        }
                        RegoArray[1] = BTrailer;

                        // repeat above block for second trailer

                        TrailerAxleConfig = AxleConfig.Substring(iBreak + 2, 2); // 12A3 etc
                        string B2Trailer = "";
                        VehicleSearch frmVehicleSearchBD2 = new VehicleSearch(myVehicle.CardCode, TrailerAxleConfig, false);
                        DialogResult drB1 = frmVehicleSearchBD.ShowDialog();
                        if (dr1 == DialogResult.OK)
                        {
                            B2Trailer = frmVehicleSearchBD.Rego;
                        }
                        RegoArray[2] = B2Trailer;

                        if (bsConfiguredTrucks.Count > 0)
                        {
                            foreach (dsTruckConfig.ConfiguredTrucksRow myConfigTruck in dsTruckConfig.ConfiguredTrucks)
                            {
                                string testRego = RegoArray[0] + RegoArray[1] + RegoArray[2];
                                string compareRego = myConfigTruck.RegoTk + myConfigTruck.RegoTr1 + myConfigTruck.RegoTr2;
                                if (testRego == compareRego)
                                {
                                    Okay2Continue = false;
                                    MessageBox.Show("Already configured! \r\nCannot continue.", "Duplicate Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                }
                            }
                        }
                        break;
                    case 4: // A-Double with converter dolly
                        // A-trailer
                        TrailerAxleConfig = AxleConfig.Substring(iBreak, 2); // A3, A2 etc
                        string ATrailer = "";
                        VehicleSearch frmVehicleSearchATrailer = new VehicleSearch(myVehicle.CardCode, TrailerAxleConfig, false); 
                        DialogResult dr2 = frmVehicleSearchATrailer.ShowDialog();
                        if (dr2 == DialogResult.OK)
                        {
                            ATrailer = frmVehicleSearchATrailer.Rego;
                        }
                        RegoArray[1] = ATrailer;

                        // Dolly

                        TrailerAxleConfig = AxleConfig.Substring(iBreak + 2, 2); // 12A3 etc
                        string Dolly = "";
                        VehicleSearch frmVehicleSearchDolly = new VehicleSearch(myVehicle.CardCode, TrailerAxleConfig, false); 
                        DialogResult drA1 = frmVehicleSearchDolly.ShowDialog();
                        if (drA1 == DialogResult.OK)
                        {
                            Dolly = frmVehicleSearchDolly.Rego;
                        }
                        RegoArray[2] = Dolly;

                        // B-trailer

                        TrailerAxleConfig = AxleConfig.Substring(iBreak + 4, 2); // 12A3 etc
                        string ADBTrailer = "";
                        VehicleSearch frmVehicleSearchADBtrailer = new VehicleSearch(myVehicle.CardCode, TrailerAxleConfig, false);
                        DialogResult drA2 = frmVehicleSearchADBtrailer.ShowDialog();
                        if (drA2 == DialogResult.OK)
                        {
                            ADBTrailer = frmVehicleSearchADBtrailer.Rego;
                        }
                        RegoArray[3] = ADBTrailer;

                        // check for duplicates
                        if (bsConfiguredTrucks.Count > 0)
                        {
                            foreach (dsTruckConfig.ConfiguredTrucksRow myConfigTruck in dsTruckConfig.ConfiguredTrucks)
                            {
                                string testRego = RegoArray[0] + RegoArray[1] + RegoArray[2] + RegoArray[3];
                                string compareRego = myConfigTruck.RegoTk + myConfigTruck.RegoTr1 + myConfigTruck.RegoTr2 + myConfigTruck.RegoTr3;
                                if (testRego == compareRego)
                                {
                                    Okay2Continue = false;
                                    MessageBox.Show("Already configured! \r\nCannot continue.", "Duplicate Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                                }
                            }
                        }

                        break;
                    default:
                        Okay2Continue = false; // Might be an issue in the future
                        break;
                }
            //}

                if (Okay2Continue == true)            
                {
                    int myTruckConfigID = TruckConfigAdd(AxleConfig);
                    for (int i = 0; i < Vehicles; i++) 
                    {
                        // note Position is One based sp = i+1
                        if (RegoArray[i] != null)
                        {
                            TruckConfigVehicleAdd(myTruckConfigID, RegoArray[i], i + 1, 0.0M);
                        }
                    }
                    GetConfiguredTruck(Rego);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TruckConfigAddTrailer(int TruckConfigID, int Position)
        {
            // currently only called if check shows trailer rego missing
            // search vehicles by trailer axleconfiguration
            int iVehicles = CurrentConfigTruck().Vehicles;
            dsQWSLocal2024.VehicleRow myVehicle = CurrentVehicle();
            string TruckAxleConfig = myVehicle.AxleConfiguration;
            string TrailerAxleConfig = myVehicle.AxleConfiguration;
            string CombinationAxleConfig = CurrentConfigTruck().AxleConfiguration;
            int iBreak = TruckAxleConfig.Length - 1;

            switch (iVehicles)
            {
                case 2: // T&T or ST
                    TrailerAxleConfig = CombinationAxleConfig.Substring(iBreak, CombinationAxleConfig.Length - iBreak); //keep R or A
                    break;
                case 3: // BD
                    break;  
                case 4: // A-Double with converter dolly
                        break;
                default:
                    break;
            }
            string Trailer;
            VehicleSearch frmVehicleSearch = new VehicleSearch(myVehicle.CardCode, TrailerAxleConfig, true);
            DialogResult dr = frmVehicleSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Trailer = frmVehicleSearch.Rego;
                TruckConfigVehicleAdd(TruckConfigID, Trailer, Position, 0.0M);
            }
        }

        private void TruckConfigDelete(int TruckConfigID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TruckConfigDelete";
                cmd.Parameters.AddWithValue("@TruckConfigID", TruckConfigID);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TruckConfigDelete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TruckConfigNHVRDelete(int TruckConfigID, int TruckTypeID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TruckConfigNHVRDelete";
                cmd.Parameters.AddWithValue("@TruckConfigID", TruckConfigID);
                cmd.Parameters.AddWithValue("@TruckTypeID", TruckTypeID);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TruckConfigNHVRDelete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dsTruckConfig.ConfiguredTrucksRow myTruck = CurrentConfigTruck();
                int CfgVehicleCount = myTruck.Vehicles;
                bool blConfigOK = true;
                switch (CfgVehicleCount)
                {
                    case 1: // truck only, do nothing
                        break;
                    case 2:
                        if (myTruck.RegoTr1.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #1.");
                            blConfigOK = false;
                            TruckConfigAddTrailer(myTruck.TruckConfigID, 2);
                            GetConfiguredTruck(myTruck.RegoTk);
                            SyncConfiguredTruckGVM();
                        }
                        break;
                    case 3:
                        if (myTruck.RegoTr1.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #1.");
                            blConfigOK = false;
                        }
                        if (myTruck.RegoTr2.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #2.");
                            blConfigOK = false;
                        }
                        break;
                    case 4:
                        if (myTruck.RegoTr1.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #1.");
                            blConfigOK =false;
                        }
                        if (myTruck.RegoTr2.Length == 0)
                        {
                            MessageBox.Show("Please add trailer #2.");
                            blConfigOK =false;  
                        }
                        if (myTruck.RegoTr3.Length == 0)
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
            DialogResult dr = MessageBox.Show("Are you sure?\r\nDelete Configuration.","Delete Configuration.",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int myTruckConfigID = CurrentConfigTruck().TruckConfigID;
                TruckConfigDelete(myTruckConfigID);
                GetConfiguredTruck(txtRego.Text); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnDeleteConfigGVM_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?\r\nDelete GVM Allocation.", "Delete GVM Configuration.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DataRow myRow = ((DataRowView)bsConfiguredTruckGVM.Current).Row;
                dsTruckConfig.ConfiguredTruckGVMRow myConfiguredTruckGVMRow = (dsTruckConfig.ConfiguredTruckGVMRow)myRow;

                int myTruckConfigID = myConfiguredTruckGVMRow.TruckConfigID;
                int myTruckTypeID = myConfiguredTruckGVMRow.TruckTypeID;
                    
                TruckConfigNHVRDelete(myTruckConfigID, myTruckTypeID);

                GetConfiguredTruck(txtRego.Text);
            }
        }
    }
}
