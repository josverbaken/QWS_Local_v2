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
        private bool UseCurrentOwner = false;
        public VehicleMaintenance()
        {
            InitializeComponent();
        }

        private void Vehicle_Maintenance_Load(object sender, EventArgs e)
        {
            try
            {
                txtJurisdiction.Text = Properties.Settings.Default.defaultJurisdiction;
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
            try
            {
                DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
                dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                return vehicleRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void FindByOwnerOrRego()
        {
            //find by owner or rego using SQL stored procedure
            try
            {
                if (txtRego.Text != "Rego or Owner" && txtRego.Text != "newReg")
                {
                    string strSearch = this.txtRego.Text;
                    string _SAPCode = "";
                    string _Owner = "";
                    //CheckPBS(); // not yet need axle config etc
                    if (vehicleBindingSource.Count > 0) //to carry over owner for new truck 
                    {
                        _SAPCode = CurrentVehicle().CardCode;
                        _Owner = CurrentVehicle().Owner;
                    }
                    int iRows = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, strSearch);
                    switch (iRows)
                    {
                        case 0: DialogResult dr = MessageBox.Show("No Vehicles Found! Do you wish to add this Rego?","Add New Vehicle", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                AddVehicleRequest(strSearch);
                                if (UseCurrentOwner == true)
                                {
                                    CurrentVehicle().CardCode = _SAPCode;
                                    CurrentVehicle().Owner = _Owner;
                                    vehicleBindingSource.EndEdit();
                                }
                                txtVIN.Focus();
                            }
                                break;
                        case 1:
                            SynchAxleConfig(CurrentVehicle().AxleConfiguration);
                            SynchFeeCode(CurrentVehicle().FeeCodeID);
                            CheckExpiryDT();
                            break;
                        case int n when(n > 1):
                            VehicleSearch vehicleSearch = new VehicleSearch(strSearch);
                            dsQWSLocal.Clear();
                            DialogResult dr1 = vehicleSearch.ShowDialog();
                            if (dr1 == DialogResult.OK)
                            {
                                iRows = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, vehicleSearch.Rego);
                                iRows += 2;
                                SynchAxleConfig(CurrentVehicle().AxleConfiguration);
                                SynchFeeCode(CurrentVehicle().FeeCodeID);
                            }
                            else
                            {
                                //MessageBox.Show("Not okay");
                                txtRego.Focus();
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
            CheckExpiryDT();
        }

        private void vINTextBox_Enter(object sender, EventArgs e)
        {
            int iCount = this.txtVIN.Text.Length;
            if (iCount == 0)
            //{
            //    this.vINTextBox.Text = "Empty";
            //}
            this.txtVIN.Text.Trim();
            this.txtVIN.SelectAll();
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

        private void CheckExpiryDT()
        {
            if (CurrentVehicle().RegistrationExpiryDT < DateTime.Now)
            {
                txtRegoExpiryDT.BackColor = Color.Salmon;
            }
            else
            {
                txtRegoExpiryDT.BackColor = SystemColors.Control;
            }
        }

        private dsQWSLocal.AxleConfigurationRow CurrentAxleConfiguration()
        {
            try
            {
                DataRow myAxleConfig = ((DataRowView)axleConfigurationBindingSource.Current).Row;
                dsQWSLocal.AxleConfigurationRow axleConfigurationRow = (dsQWSLocal.AxleConfigurationRow)myAxleConfig;
                return axleConfigurationRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void AxleConfiguration()
        {
            bool myIsLeadVehicle = CurrentFeeCode().IsLeadVehicle;
            int myAxles = CurrentFeeCode().Axles;
            string myCoupling = CurrentFeeCode().Coupling;

            AxleConfigurationSearch axleConfigurationSearch = new AxleConfigurationSearch(myIsLeadVehicle, myAxles, myCoupling);
            DialogResult dr = axleConfigurationSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string myAxleConfig = axleConfigurationSearch._AxleConfigurationRow.AxleConfiguration;
                txtAxleConfig.Text = myAxleConfig;
                CurrentVehicle().AxleConfiguration = myAxleConfig;
                this.axleConfigurationTableAdapter.FillBy(dsQWSLocal.AxleConfiguration,myAxleConfig); // WHY - for the picture!
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
                BusinessSearch businessSearch = new BusinessSearch(txtOwner.Text);
                DialogResult dr =  businessSearch.ShowDialog();
                if (dr == DialogResult.OK)
                { 
                    CurrentVehicle().CardCode = businessSearch.SAPCode;
                    CurrentVehicle().Owner = businessSearch.BusinessName;
                    vehicleBindingSource.EndEdit();
                    txtVehicleMake.Focus();
                }
                else if (dr == DialogResult.Abort )
                {
                    MessageBox.Show("Truck owner NOT found, please check with Accounts Manager.","BP not on file!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOwner.Focus();
                }
                else
                {
                    //just return to screen
                    txtOwner.Focus();
                    //MessageBox.Show("Change truck owner - cancelled.");
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
            TruckConfiguration truckConfiguration = new TruckConfiguration(Truck);
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
            AddVehicleRequest(txtRego.Text);
        }

        private void AddVehicleRequest(string newRego)
        {
            if ( newRego.Length > 6)
            {
                MessageBox.Show("Please enter registration number (max 6 characters)", "New vehicle Rego error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
            vehicleRow.CardCode = "";
            vehicleRow.Owner = "Name or Code";
            vehicleRow.Make = "";
            vehicleRow.Model = "";
            vehicleRow.ForceRetare = false;
            vehicleRow.RetareEverytime = false;
            vehicleRow.CreateDTTM = DateTime.Now;
            dsQWSLocal.Vehicle.AddVehicleRow(vehicleRow);
            SynchAxleConfig("tba");
            SynchFeeCode(0); // 0 = unspecified, see database
            txtRego.Focus();
        }

        private void AddTruck(string SAPCode, string Owner)
        {
            dsQWSLocal.Vehicle.Clear();
            DataRow dr = dsQWSLocal.Vehicle.NewRow();
            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)dr;
            vehicleRow.Rego = "NewReg";
            vehicleRow.VIN = "";
            vehicleRow.CardCode = SAPCode;
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
            vehicleRow.CardCode = SAPCode;
            vehicleRow.Owner = Owner;
            vehicleRow.Make = "";
            vehicleRow.Model = "";
            vehicleRow.ForceRetare = false;
            dsQWSLocal.Vehicle.AddVehicleRow(vehicleRow);
            //vehicleBindingSource.EndEdit();
            SynchAxleConfig("tba");
            SynchFeeCode(0);
            txtRego.Focus();
        }

        private void btnTrailerAdd_Click(object sender, EventArgs e)
        {
            // check if any trailers already associated with owner
            AddTrailer(CurrentVehicle().CardCode, CurrentVehicle().Owner);
        }

        private void btnVehicleAdd_Click(object sender, EventArgs e)
        {
            AddVehicleRequest(txtRego.Text);
        }

        private void btnConfigureGVM_Click(object sender, EventArgs e)
        {
            int iVehicleCount;
            // TODO revise logic
            if (CurrentFeeCode().FeeCode.Substring(0, 2) == "MR")// (CurrentFeeCode().VehicleType == "Truck")
            {
                iVehicleCount = VehicleCount("Trailer", CurrentVehicle().CardCode);
                if (iVehicleCount == 0)
                {
                    DialogResult dr = MessageBox.Show("Do you want to configure Truck only. Press No to add trailer first.","No trailers",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // go to TruckConfguration and add Truck only use axle configuration to filter NHVR_GVM
                        TruckConfiguration(CurrentVehicle().Rego, "", CurrentVehicle().CardCode, "TruckOnly");
                    }
                }
                else if (iVehicleCount ==1)
                {
                    //check if new trailer by CreateDTTM
                    DialogResult dr = MessageBox.Show("Do you want to configure Truck with this trailer. Press No to add trailer first.", "No trailers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // go to TruckConfguration and add Truck only use axle configuration to filter NHVR_GVM
                        TruckConfiguration(CurrentVehicle().Rego, "", CurrentVehicle().CardCode, "TruckOnly");
                    }
                    else
                    {
                        AddTrailer(CurrentVehicle().CardCode, CurrentVehicle().Owner);
                    }
                }
                else if (iVehicleCount > 1)
                {

                }
            }
            // TODO revise logic
            else if (CurrentFeeCode().FeeCode.Substring(0,2) == "TD") //(CurrentFeeCode().VehicleType == "Trailer")
            {
                DialogResult dr = MessageBox.Show("Press OK to add trailer to an existing truck.", "Add trailer to GVM Configuration", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dr ==DialogResult.OK)
                {
                    //search by owner ? filter trucks
                    string myRego = FindTruck4Trailer(CurrentVehicle().Rego);
                    if (myRego =="Not Found")
                    {
                        // see if any trucks at all
                        iVehicleCount = VehicleCount("Truck", CurrentVehicle().CardCode);
                        if (iVehicleCount >0)
                        {
                            MessageBox.Show("No recent truck found so will list by SAPCode", "Truck 4 Trailer");
                        }
                        else
                        {
                            MessageBox.Show("Please add Truck first", "Truck 4 Trailer");
                            AddTruck(CurrentVehicle().CardCode, CurrentVehicle().Owner);
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
                MessageBox.Show("Vehicle Type = " + CurrentFeeCode().FeeCode, "Vehicle Type Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            mySAPCode = CurrentVehicle().CardCode;
            int iCount = this.truckConfigTruckTableAdapter.FillBy(this.dsTruckConfig.TruckConfigTruck,mySAPCode);
            int iCount2 = this.truckConfigTrailerTableAdapter.FillBy(this.dsTruckConfig.TruckConfigTrailer,mySAPCode);
            int iCount3 = this.unconfiguredVehiclesTableAdapter.Fill(this.dsTruckConfig.UnconfiguredVehicles, mySAPCode);
            iCount += iCount2;
            iCount += iCount3;
        }

        private void btnGo2Config_Click(object sender, EventArgs e)
        {
            Go2GVMConfiguration();
        }

        private void Go2GVMConfiguration()
        {     
                TruckConfiguration truckConfiguration = new TruckConfiguration(CurrentVehicle().Rego);
                truckConfiguration.MdiParent = this.MdiParent;
                truckConfiguration.Show();
        }

        private void btnNewVehicleCurrentOwner_Click(object sender, EventArgs e)
        {
            UseCurrentOwner = true;
            txtRego.Text = "NewReg";
            txtRego.Focus();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            txtOwner.Text = "";
            txtRego.Text = "NewReg";
            txtRego.Focus();
        }
   }
}

