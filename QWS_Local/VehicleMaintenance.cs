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
                this.KeyPreview = true; // enable Function keys
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FindVehicleByCallingRego(string Rego)
        {
            txtRego.Text = Rego;
        }

        private void IdentificationSave()
        {
            try
            {
                CurrentVehicle().Rego = CurrentVehicle().Rego.ToUpper();
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
                            GetPBSApprovals(CurrentVehicle().Rego);
                            LoadPrefCustomers();
                            break;
                        case int n when(n > 1):
                            VehicleSearch vehicleSearch = new VehicleSearch(strSearch, false);
                            dsQWSLocal2024.Clear();
                            DialogResult dr1 = vehicleSearch.ShowDialog();
                            if (dr1 == DialogResult.OK)
                            {
                                iRows = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, vehicleSearch.Rego);
                                iRows += 2;
                                SynchAxleConfig(CurrentVehicle().AxleConfiguration);
                                SynchFeeCode(CurrentVehicle().FeeCodeID);
                                GetPBSApprovals(CurrentVehicle().Rego);
                                LoadPrefCustomers();
                            }
                            else
                            {
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
                dsQWSLocal2024.Clear();
                txtRego.Focus();
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
                int iCount = this.taAxleConfig.FillByAxleConfig(dsQWSLocal2024.AxleConfiguration,AxleConfig);
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
                CurrentVehicle().IsLeadVehicle = true; //TODO change to dsQWSLocal2024 axleConfigurationSearch._AxleConfigurationRow.IsLeadVehicle; // set/sync
                this.taAxleConfig.FillByAxleConfig(dsQWSLocal2024.AxleConfiguration, myAxleConfig); // WHY - for the picture!
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
                    txtOwner.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Business Search Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void PrefCustomerSearch()
        {
            // /*TODO*/ refactor PrefCustomerSearch to just return found BP
            try
            {
                BusinessSearch frmBusinessSearch = new BusinessSearch(""); // txtPrefCustName.Text);
                DialogResult dr = frmBusinessSearch.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    AddVehiclePreCustomer(frmBusinessSearch.SAPCode, frmBusinessSearch.BusinessName);
                    bsPrefCustomers.EndEdit();
                }
                else if (dr == DialogResult.Abort)
                {
                    MessageBox.Show("Customer NOT found, please check with Accounts Manager.", "BP not on file!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOwner.Focus();
                }
                else
                {
                    txtOwner.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Preferred Customer Search Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            vehicleRow.CreateDTTM = DateTime.Now;
            vehicleRow.RegistrationExpiryDT = DateTime.Now;
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
            vehicleRow.RegistrationExpiryDT = DateTime.Now;
            dsQWSLocal.Vehicle.AddVehicleRow(vehicleRow);
            SynchAxleConfig("tba");
            SynchFeeCode(0);
            txtRego.Focus();
        }
 
        private void btnGo2Config_Click(object sender, EventArgs e)
        {
            Go2GVMConfiguration();
        }

        private void Go2GVMConfiguration()
        {
            if (CurrentVehicle().IsLeadVehicle == true)
            {
                // TODO check if form already open
                TruckConfigMaintenance frmTruckConfig = new TruckConfigMaintenance(CurrentVehicle().Rego);
                frmTruckConfig.MdiParent = this.MdiParent;
                frmTruckConfig.Show();
            }
            else
            {
                MessageBox.Show("Please choose truck/prime mover first.","Not lead vehicle!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnNewVehicleCurrentOwner_Click(object sender, EventArgs e)
        {
            UseCurrentOwner = true;
            txtRego.Text = "NewReg";
            // TODO clear out fields
            txtRego.Focus();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            txtOwner.Text = "";
            txtRego.Text = "NewReg";
            // TODO clear out fields
            txtRego.Focus();
        }

        private void btnSetPrefCustomer_Click(object sender, EventArgs e)
        {
            PrefCustomerSearch();
        }

        private void btnVehiclesByCardCode_Click(object sender, EventArgs e)
        {
            ListVehicles4CardCode(CurrentVehicle().CardCode);
        }

        private void ListVehicles4CardCode(string CardCode)
        {
            VehicleSearch vehicleSearch = new VehicleSearch(CardCode, true);
            DialogResult dr1 = vehicleSearch.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                dsQWSLocal.Clear();
                int iRows = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, vehicleSearch.Rego);
                iRows += 2;
                SynchAxleConfig(CurrentVehicle().AxleConfiguration);
                SynchFeeCode(CurrentVehicle().FeeCodeID);
            }
            else
            {
                txtRego.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateVehiclePBS();
        }

        private void UpdateVehiclePBS()
        {
            try
            {
                bsVehiclePBS.EndEdit();
                this.taVehiclePBS.Update(dsQWSLocal.VehiclePBS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetPBSApprovals(string Rego)
        {
            try
            {
              int iCount =  this.taVehiclePBS.FillBy(this.dsQWSLocal.VehiclePBS,Rego);
                iCount += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bsVehiclePBS_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                e.NewObject = NewVehiclePBS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            }
        }

        private dsQWSLocal.VehiclePBSRow NewVehiclePBS()
        {
            try
            {
                DataRow dr = dsQWSLocal.VehiclePBS.NewRow();
            dsQWSLocal.VehiclePBSRow vehiclePBSRow = (dsQWSLocal.VehiclePBSRow)dr;
            vehiclePBSRow.Rego = CurrentVehicle().Rego;
                vehiclePBSRow.VehicleApproval = -9;
                return vehiclePBSRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnAddPBS_Click(object sender, EventArgs e)
        {
            AddVehiclePBS();
        }

        private void AddVehiclePBS()
        {
            try
            {
                DataRow dr = dsQWSLocal.VehiclePBS.NewRow();
                dsQWSLocal.VehiclePBSRow vehiclePBSRow = (dsQWSLocal.VehiclePBSRow)dr;
                vehiclePBSRow.Rego = CurrentVehicle().Rego;
                vehiclePBSRow.VehicleApproval = 0; // System.Convert.ToInt32(txtPBS_VA.Text);
                dsQWSLocal.VehiclePBS.AddVehiclePBSRow(vehiclePBSRow);
                //txtPBS_VA.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddVehiclePreCustomer(string CardCode, string CardName)
        {
            try
            {
                DataRow dr = dsQWSLocal2024.VehiclePrefCustomers.NewRow();
                dsQWSLocal2024.VehiclePrefCustomersRow vehiclePrefCustomersRow = (dsQWSLocal2024.VehiclePrefCustomersRow)dr;
                vehiclePrefCustomersRow.Rego = CurrentVehicle().Rego;
                vehiclePrefCustomersRow.CardCode = CardCode;
                vehiclePrefCustomersRow.PrefCustomer = CardName;
                vehiclePrefCustomersRow.IsDefault = false;
                vehiclePrefCustomersRow.Active = true;
                vehiclePrefCustomersRow.Comment = "";
                vehiclePrefCustomersRow.Rank = 0;
                dsQWSLocal2024.VehiclePrefCustomers.AddVehiclePrefCustomersRow(vehiclePrefCustomersRow);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSavePrefCustomers_Click(object sender, EventArgs e)
        {
            bsPrefCustomers.EndEdit();
            taPrefCustomers.Update(dsQWSLocal2024.VehiclePrefCustomers);
        }

        private void btnLoadPrefCustomers_Click(object sender, EventArgs e)
        {
            LoadPrefCustomers();
        }

        private void LoadPrefCustomers()
        {
            taPrefCustomers.FillBy(dsQWSLocal2024.VehiclePrefCustomers, CurrentVehicle().Rego);
            bsPrefCustomers.Sort = "IsDefault DESC, PrefCustomer ASC";
        }

        private void VehicleMaintenance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                FindByOwnerOrRego();
            }
        }

        private void btnGo2PrefCust_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpPrefCust;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnSaveMassMgmtAccred_Click(object sender, EventArgs e)
        {
            IdentificationSave();
        }

        private void btnRefreshPBS_Click(object sender, EventArgs e)
        {
            GetPBSApprovals(CurrentVehicle().Rego);
        }
    }
}

