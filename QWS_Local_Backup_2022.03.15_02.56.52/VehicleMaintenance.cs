using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class VehicleMaintenance : Form
    {
        public VehicleMaintenance()
        {
            InitializeComponent();
        }

        private void Vehicle_Maintenance_Load(object sender, EventArgs e)
        {
            try
            {
                // nothing currently
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void IdentificationSave()
        {
            try
            {
                this.Validate();
                this.vehicleBindingSource.EndEdit();
                this.vehicleTableAdapter.Update(dsQWSLocal.Vehicle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsQWSLocal.VehicleRow CurrentVehicle()
        {
            DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
            return vehicleRow;
        }

        private void FindByOwnerOrRego()
        {
            //find by owner or rego using SQL stored procedure
            try
            {
                lblNextAction.Text = "find vehicle";
                if (txtRego.Text != "Rego or Owner")
                {
                    string strSearch = this.txtRego.Text;
                    int iRows = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, strSearch);
                    switch (iRows)
                    {
                        case 0: MessageBox.Show("No Vehicles Found!");
                                break;
                        case 1:
                            SynchAxleConfig(CurrentVehicle().AxleConfiguration);
                            SynchFeeCode(CurrentVehicle().FeeCodeID);
                            break;
                        case int n when(n > 1):
                            VehicleSearch vehicleSearch = new VehicleSearch(strSearch);
                            dsQWSLocal.Clear();
                            DialogResult dr = vehicleSearch.ShowDialog();
                            if (dr == DialogResult.OK)
                            {
                                iRows = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, vehicleSearch._Rego);
                                iRows += 2;
                                SynchAxleConfig(CurrentVehicle().AxleConfiguration);
                                SynchFeeCode(CurrentVehicle().FeeCodeID);
                            }
                            else
                            {
                                MessageBox.Show("Not okay");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SynchFeeCode(int FeeCodeID)
        {
            try
            {
                int iCount =  this.vehicleRegFeeCodesTableAdapter.FillByID(this.dsQWSLocal.VehicleRegFeeCodes,FeeCodeID);
                if (iCount != 1)
                {
                    MessageBox.Show("Fee Code Error");
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                strError += " !";
                vehicleRegFeeCodesBindingSource.Position = vehicleRegFeeCodesBindingSource.Find("FeeCodeID", Properties.Settings.Default.defaultFeeCodeID);
            }
        }

        private void SynchAxleConfig(string AxleConfig)
        {
            try
            {
                int iCount = this.axleConfigurationTableAdapter.FillBy(dsQWSLocal.AxleConfiguration,AxleConfig);
                if (iCount != 1)
                {
                    MessageBox.Show("Axle config error");
                }
            }
            catch (Exception)
            {
                axleConfigurationBindingSource.Position = axleConfigurationBindingSource.Find("AxleConfiguration", Properties.Settings.Default.defaultAxleConfig);
            }
        }

        private void btnIdentificationSave_Click(object sender, EventArgs e)
        {
            IdentificationSave();
        }

        private void vINTextBox_Enter(object sender, EventArgs e)
        {
            int iCount = this.vINTextBox.Text.Length;
            if (iCount == 0)
            //{
            //    this.vINTextBox.Text = "Empty";
            //}
            this.vINTextBox.Text.Trim();
            this.vINTextBox.SelectAll();
        }

        private void btnSetAxleConfig_Click(object sender, EventArgs e) => AxleConfiguration();

        private dsQWSLocal.VehicleRegFeeCodesRow CurrentFeeCode()
        {
            try
            {
                DataRow myFeeCode = ((DataRowView)vehicleRegFeeCodesBindingSource.Current).Row;
            dsQWSLocal.VehicleRegFeeCodesRow vehicleRegFeeCodesRow = (dsQWSLocal.VehicleRegFeeCodesRow)myFeeCode;
            return vehicleRegFeeCodesRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CurrentFeeCode Error!");
                return null;
            }
        }

        private void AxleConfiguration()
        {

            string myVehicleType = CurrentFeeCode().VehicleType;
            int myAxles = CurrentFeeCode().Axles;
            string myCoupling = CurrentFeeCode().Coupling;

            AxleConfigurationSearch axleConfigurationSearch = new AxleConfigurationSearch(myVehicleType, myAxles, myCoupling);
            DialogResult dr = axleConfigurationSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string myAxleConfig = axleConfigurationSearch._AxleConfigurationRow.AxleConfiguration;
                CurrentVehicle().AxleConfiguration = myAxleConfig;
                this.axleConfigurationTableAdapter.FillBy(dsQWSLocal.AxleConfiguration,myAxleConfig);
            }
        }

        private void btnSetTruckOwner_Click(object sender, EventArgs e)
        {
            BusinessSearch();
        }

        private void BusinessSearch()
        {
            try
            {
                BusinessSearch businessSearch = new BusinessSearch("Called by Vehicle Maintenance");
                DialogResult dr =  businessSearch.ShowDialog();
                if (dr == DialogResult.OK)
                { 
                    CurrentVehicle().SAPCode = businessSearch.SAPCode;
                    CurrentVehicle().Owner = businessSearch.BusinessName;
                    // TODO why not refreshing GUI for NEW vehicle??
                }
                else
                {
                    MessageBox.Show("Change truck owner - cancelled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Business Search Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            FindByOwnerOrRego();
        }

         private void txtRegoSelectAll()
        {
            this.txtRego.SelectAll();
        }

        private void txtRegoUnselect()
        {
            this.txtRego.DeselectAll();
        }

        private void txtRego_Click(object sender, EventArgs e)
        {
            txtRegoUnselect();
        }

        private void txtRego_Enter(object sender, EventArgs e)
        {
            txtRegoSelectAll();
        }

        private void TruckConfiguration(string Truck, string Trailer, string SAPCode, string Mode)
        {
            TruckConfiguration truckConfiguration = new TruckConfiguration(Truck, SAPCode);
            truckConfiguration.MdiParent = this.MdiParent;
           
            truckConfiguration.Show();
        }

        private void txtRegoExpiryDT_Click(object sender, EventArgs e)
        {
            txtRegoExpiryDTSelectAll();
        }

        private void txtRegoExpiryDT_Enter(object sender, EventArgs e)
        {
            txtRegoExpiryDTSelectAll();
        }

        private void txtRegoExpiryDTSelectAll()
        {
            this.txtRegoExpiryDT.SelectAll();
        }

        private void btnSetFeeCodeMain_Click(object sender, EventArgs e)
        {
            SetFeeCode();
        }

        private void SetFeeCode()
        { 
            // TODO run stored procedure, actually parameterised query b/c ds issue
            int iCount = -1;
            iCount = vehicleRegFeeCodesTableAdapter.FillByBoth(dsQWSLocal.VehicleRegFeeCodes, txtFeeCode.Text,txtJurisdiction.Text);
            if (iCount != 1)
            {
                MessageBox.Show("exact fee code not found");
            }
            else
            {
                CurrentVehicle().FeeCodeID = CurrentFeeCode().FeeCodeID;

                txtRegoExpiryDT.Focus();
            }
        }

        private void btnFeeCodesMore_Click(object sender, EventArgs e)
        {
            FeeCodesMore();
        }

        private void FeeCodesMore()
        {
            FeeCodeSearch feeCodeSearch = new FeeCodeSearch();
            DialogResult dr = feeCodeSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                CurrentVehicle().FeeCodeID = feeCodeSearch._FeeCodeRow.FeeCodeID;

                this.vehicleRegFeeCodesTableAdapter.FillByBoth(this.dsQWSLocal.VehicleRegFeeCodes, feeCodeSearch._FeeCodeRow.FeeCode, feeCodeSearch._FeeCodeRow.Jurisdiction);

                txtRegoExpiryDT.Focus();
            }
            else
            {
                MessageBox.Show("cancelled");
            }   
        }

        private void bthAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleRequest();
        }

        private void AddVehicleRequest()
        {
            if (txtRego.TextLength > 6)
            {
                MessageBox.Show("Please enter registration number (max 6 characters)", "New vehicle Rego error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string newRego = txtRego.Text;
                int iCount = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, newRego);
                if (iCount == 0)
                {
                    AddVehicle(newRego);
                }
                else
                {
                    MessageBox.Show("Registration number already on file", "Rego Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SynchAxleConfig(CurrentVehicle().AxleConfiguration);
                    SynchFeeCode(CurrentVehicle().FeeCodeID);
                }

            }
        }

        private void AddVehicle(string newRego)
        {
            dsQWSLocal.Vehicle.Clear();
            DataRow dr = dsQWSLocal.Vehicle.NewRow();
            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)dr;
            vehicleRow.Rego = newRego; //don't overwrite user input
            vehicleRow.VIN = "";
            vehicleRow.SAPCode = "";
            vehicleRow.Owner = "";
            vehicleRow.Make = "";
            vehicleRow.Model = "";
            vehicleRow.ForceRetare = false;
            dsQWSLocal.Vehicle.AddVehicleRow(vehicleRow);
            SynchAxleConfig("tba");
            SynchFeeCode(0);
            txtRego.Focus();
        }

        private void AddTruck(string SAPCode, string Owner)
        {
            dsQWSLocal.Vehicle.Clear();
            DataRow dr = dsQWSLocal.Vehicle.NewRow();
            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)dr;
            vehicleRow.Rego = "New Truck Reg";
            vehicleRow.VIN = "";
            vehicleRow.SAPCode = SAPCode;
            vehicleRow.Owner = Owner;
            vehicleRow.Make = "";
            vehicleRow.Model = "";
            vehicleRow.ForceRetare = false;
            dsQWSLocal.Vehicle.AddVehicleRow(vehicleRow);
            SynchAxleConfig("tba");
            SynchFeeCode(0);
            txtRego.Focus();
        }
        private void AddTrailer(string SAPCode, string Owner)
        {
            dsQWSLocal.Vehicle.Clear();
            DataRow dr = dsQWSLocal.Vehicle.NewRow();
            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)dr;
            vehicleRow.Rego = "newReg";
            vehicleRow.VIN = "";
            vehicleRow.SAPCode = SAPCode;
            vehicleRow.Owner = Owner;
            vehicleRow.Make = "";
            vehicleRow.Model = "";
            vehicleRow.ForceRetare = false;
            dsQWSLocal.Vehicle.AddVehicleRow(vehicleRow);
            SynchAxleConfig("tba");
            SynchFeeCode(0);
            txtRego.Focus();
        }

        private void btnTrailerAdd_Click(object sender, EventArgs e)
        {
            // check if any trailers already associated with owner
            AddTrailer(CurrentVehicle().SAPCode, CurrentVehicle().Owner);
        }

        private void btnVehicleAdd_Click(object sender, EventArgs e)
        {
            AddVehicleRequest();
        }

        private void btnConfigureGVM_Click(object sender, EventArgs e)
        {
            int iVehicleCount;
            if (CurrentFeeCode().VehicleType == "Truck")
            {
                iVehicleCount = VehicleCount("Trailer", CurrentVehicle().SAPCode);
                if (iVehicleCount == 0)
                {
                    DialogResult dr = MessageBox.Show("Do you want to configure Truck only. Press No to add trailer first.","No trailers",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // go to TruckConfguration and add Truck only use axle configuration to filter NHVR_GVM
                        TruckConfiguration(CurrentVehicle().Rego, "", CurrentVehicle().SAPCode, "TruckOnly");
                    }
                }
                else if (iVehicleCount ==1)
                {
                    //check if new trailer by CreateDTTM
                    DialogResult dr = MessageBox.Show("Do you want to configure Truck with this trailer. Press No to add trailer first.", "No trailers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // go to TruckConfguration and add Truck only use axle configuration to filter NHVR_GVM
                        TruckConfiguration(CurrentVehicle().Rego, "", CurrentVehicle().SAPCode, "TruckOnly");
                    }
                    else
                    {
                        AddTrailer(CurrentVehicle().SAPCode, CurrentVehicle().Owner);
                    }
                }
                else if (iVehicleCount > 1)
                {

                }
            }
            else if (CurrentFeeCode().VehicleType == "Trailer")
            {
                DialogResult dr = MessageBox.Show("Press OK to add trailer to an existing truck.", "Add trailer to GVM Configuration", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dr ==DialogResult.OK)
                {
                    //search by owner ? filter trucks
                    string myRego = FindTruck4Trailer(CurrentVehicle().Rego);
                    if (myRego =="Not Found")
                    {
                        // see if any trucks at all
                        iVehicleCount = VehicleCount("Truck", CurrentVehicle().SAPCode);
                        if (iVehicleCount >0)
                        {
                            MessageBox.Show("No recent truck found so will list by SAPCode", "Truck 4 Trailer");
                        }
                        else
                        {
                            MessageBox.Show("Please add Truck first", "Truck 4 Trailer");
                            AddTruck(CurrentVehicle().SAPCode, CurrentVehicle().Owner);
                        }
                    }
                    else
                    {
                        MessageBox.Show(myRego, "Truck 4 Trailer");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vehicle Type = " + CurrentFeeCode().VehicleType, "Vehicle Type Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private int VehicleCount(string VehicleType, string SAPCode)
        {
            int myCount = -9;
            try
            {
                SqlConnection sqlConn = new SqlConnection();
                sqlConn.ConnectionString = Properties.Settings.Default.cnQWSLocal;
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("VehicleCount", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@SAPCode", SqlDbType.NVarChar).Value = SAPCode;
                sqlCmd.Parameters.AddWithValue("@VehicleType", SqlDbType.NVarChar).Value = VehicleType;
                myCount = (int) sqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myCount;
        }

        private string FindTruck4Trailer(string Rego)
        {
            string myRego = "Truck";
            try
            {
                SqlConnection sqlConn = new SqlConnection();
                sqlConn.ConnectionString = Properties.Settings.Default.cnQWSLocal;
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("Truck4Trailer", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Rego", SqlDbType.NVarChar).Value = Rego;
                sqlCmd.Parameters.AddWithValue("@Lag", SqlDbType.Int).Value = 80; //TODO add to settings
                myRego = (string)sqlCmd.ExecuteScalar();
                if (myRego == null)
                {
                    myRego = "No Truck";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myRego;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TruckConfigTruck();
        }

        private void TruckConfigTruck()
        {
            string mySAPCode;
            mySAPCode = CurrentVehicle().SAPCode;
            this.truckConfigTruckTableAdapter.FillBy(this.dsTruckConfig.TruckConfigTruck,mySAPCode);
            this.truckConfigTrailerTableAdapter.FillBy(this.dsTruckConfig.TruckConfigTrailer,mySAPCode);
            this.unconfiguredVehiclesTableAdapter.Fill(this.dsTruckConfig.UnconfiguredVehicles, mySAPCode);
        }
    }
}

