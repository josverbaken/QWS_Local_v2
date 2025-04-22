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
using static QWS_Local.dsQWSLocal2024;

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
                //txtJurisdiction.Text = Properties.Settings.Default.defaultJurisdiction;
                //tabControl1.TabPages.Remove(tpPrefCust);
                this.KeyPreview = true; // enable Function keys
                //txtRegoExpiryDT.Text.
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

        private void VehicleSave()
        {
            try
            {
                if (txtSAPCode.TextLength == 0)
                {
                    MessageBox.Show("Please select an owner.", "VehicleSave Error.",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOwner.SelectAll();
                    txtOwner.Focus();
                }
                else
                {
                    this.Validate();
                    this.bsVehicle.EndEdit();
                    this.taVehicle.Update(dsQWSLocal2024.Vehicle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsQWSLocal2024.VehicleRow CurrentVehicle()
        {
            try
            {
                DataRow myDR = ((DataRowView)bsVehicle.Current).Row;
                dsQWSLocal2024.VehicleRow vehicleRow = (dsQWSLocal2024.VehicleRow)myDR;
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
                    if (bsVehicle.Count > 0) //to carry over owner for new truck 
                    {
                        _SAPCode = CurrentVehicle().CardCode;
                        _Owner = CurrentVehicle().Owner;
                    }
                    int iRows = this.taVehicle.FillBy(dsQWSLocal2024.Vehicle, strSearch);
                    switch (iRows)
                    {
                        case 0: DialogResult dr = MessageBox.Show("No Vehicles Found! Do you wish to add this Rego?","Add New Vehicle", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            dsQWSLocal2024.Clear();
                            if (dr == DialogResult.Yes)
                            {
                                AddVehicleRequest(strSearch);                        
                                txtOwner.Focus();
                            }
                                break;
                        case 1:
                            VehicleFound();
                            break;
                        case int n when(n > 1):
                            VehicleSearch vehicleSearch = new VehicleSearch(strSearch, false);
                            dsQWSLocal2024.Clear();
                            DialogResult dr1 = vehicleSearch.ShowDialog();
                            if (dr1 == DialogResult.OK)
                            {
                                iRows = this.taVehicle.FillBy(dsQWSLocal2024.Vehicle, vehicleSearch.Rego);
                                iRows += 2;
                                VehicleFound();
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

        private void VehicleFound()
        {
            dsQWSLocal2024.VehicleRow myVehicle = CurrentVehicle();
            if (CheckACC(myVehicle.Rego) == true)
            {
                chkACC.Checked = true;
                if (myVehicle.IsLeadVehicle == true)
                {
                    gbACC.Enabled = true;
                }
                else
                    { 
                        gbACC.Enabled = false; 
                }
            }
            else
            {
                chkACC.Checked = false;
                gbACC.Enabled = false;
            }
            SynchAxleConfig(myVehicle.AxleConfiguration);
            SynchFeeCode(myVehicle.FeeCodeID);
            CheckExpiryDT();
            GetPBSApprovals(myVehicle.Rego);
            LoadPrefCustomers();
        }

        private void SynchFeeCode(int FeeCodeID)
        {
            try
            {
                int iCount =  this.taFeeCodes.FillByID(this.dsQWSLocal2024.VehicleRegFeeCodes,FeeCodeID);
                if (iCount != 1)
                {
                    MessageBox.Show("Fee Code Error");
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                strError += " !";
                bsFeeCodes.Position = bsFeeCodes.Find("FeeCodeID", Properties.Settings.Default.defaultFeeCodeID);
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
                bsAxleConfig.Position = bsAxleConfig.Find("AxleConfiguration", Properties.Settings.Default.defaultAxleConfig);
            }
        }

        private dsQWSLocal2024.VehicleRegFeeCodesRow CurrentFeeCode()
        {
            try
            {
                DataRow myFeeCode = ((DataRowView)bsFeeCodes.Current).Row;
            dsQWSLocal2024.VehicleRegFeeCodesRow vehicleRegFeeCodesRow = (dsQWSLocal2024.VehicleRegFeeCodesRow)myFeeCode;
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
               lblExpiryDT.BackColor = Color.Salmon;
            }
            else
            {
                lblExpiryDT.BackColor = SystemColors.Window;
            }
        }

        private dsQWSLocal2024.AxleConfigurationRow CurrentAxleConfiguration()
        {
            try
            {
                DataRow myAxleConfig = ((DataRowView)bsAxleConfig.Current).Row;
                dsQWSLocal2024.AxleConfigurationRow axleConfigurationRow = (dsQWSLocal2024.AxleConfigurationRow)myAxleConfig;
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
                CurrentVehicle().IsLeadVehicle = true; 
                this.taAxleConfig.FillByAxleConfig(dsQWSLocal2024.AxleConfiguration, myAxleConfig); // WHY - for the picture!
                VehicleSaveBlock();
            }
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
                    bsVehicle.EndEdit();
                    txtVIN.Focus();
                }          
                else
                {
                    txtVIN.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Business Search Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void PrefCustomerSearch()
        {
            // TODO refactor PrefCustomerSearch to just return found BP
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
    
        private void SetFeeCode()
        { 
            int iCount = -1;
            iCount = taFeeCodes.FillByBoth(dsQWSLocal2024.VehicleRegFeeCodes, txtFeeCode.Text,txtJurisdiction.Text);
            if (iCount != 1)
            {
                MessageBox.Show("exact fee code not found");
            }
            else
            {
                CurrentVehicle().FeeCodeID = CurrentFeeCode().FeeCodeID;

                txtAxleConfig.Focus();
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

                this.taFeeCodes.FillByBoth(this.dsQWSLocal2024.VehicleRegFeeCodes, feeCodeSearch._FeeCodeRow.FeeCode, feeCodeSearch._FeeCodeRow.Jurisdiction);

                dtpExpiryDT.Focus();
            }
            else
            {
                MessageBox.Show("Cancelled","Fee Code Search",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }   
        }

        private void AddVehicleRequest(string newRego)
        {
            if ( newRego.Length > 6)
            {
                MessageBox.Show("Please enter registration number (max 6 characters)", "New vehicle Rego error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int iCount = this.taVehicle.FillBy(dsQWSLocal2024.Vehicle, newRego);
                if (iCount == 0)
                {
                    AddVehicle(newRego.ToUpper());
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
            try
            {
                dsQWSLocal2024.Vehicle.Clear();
                DataRow dr = dsQWSLocal2024.Vehicle.NewRow();
                dsQWSLocal2024.VehicleRow vehicleRow = (dsQWSLocal2024.VehicleRow)dr;
                vehicleRow.Rego = newRego; //don't overwrite user input
                vehicleRow.VIN = "";
                vehicleRow.CardCode = "";
                vehicleRow.Owner = "Name or Code";
                vehicleRow.Make = "";
                vehicleRow.Model = "";
                vehicleRow.AxleConfiguration = "tba";
                vehicleRow.MassAccreditationLabel = "";
                vehicleRow.RegisteredTare = 0.0M;
                vehicleRow.FeeCodeID = 0;
                vehicleRow.RegistrationExpiryDT = DateTime.Now;
                vehicleRow.IsLeadVehicle = false;
                vehicleRow.Active = true;
                vehicleRow.CreateDTTM = DateTime.Now;
                dsQWSLocal2024.Vehicle.AddVehicleRow(vehicleRow);
                SynchAxleConfig("tba");
                SynchFeeCode(0); // 0 = unspecified, see database
                // actually save to database
                bsVehicle.EndEdit();
                taVehicle.Update(dsQWSLocal2024.Vehicle);
                txtRego.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"AddVehicle Error.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
 
        private void btnGo2Config_Click(object sender, EventArgs e)
        {
            VehicleSaveBlock(); // just to be sure
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
  
        private void btnSetPrefCustomer_Click(object sender, EventArgs e)
        {
            PrefCustomerSearch();
        }

        private void UpdateVehiclePBS()
        {
            try
            {
                bsVehiclePBS2.EndEdit();
                this.taVehiclePBS2.Update(dsQWSLocal2024.VehiclePBS);
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
              int iCount =  this.taVehiclePBS2.FillBy(this.dsQWSLocal2024.VehiclePBS,Rego);
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

        private dsQWSLocal2024.VehiclePBSRow NewVehiclePBS()
        {
            try
            {
                DataRow dr = dsQWSLocal2024.VehiclePBS.NewRow();
            dsQWSLocal2024.VehiclePBSRow vehiclePBSRow = (dsQWSLocal2024.VehiclePBSRow)dr;
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

        private void SavePrefCustomers()
        {
            try
            {
                bsPrefCustomers.EndEdit();
                taPrefCustomers.Update(dsQWSLocal2024.VehiclePrefCustomers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadPrefCustomers_Click(object sender, EventArgs e)
        {
            LoadPrefCustomers();
        }

        private void LoadPrefCustomers()
        {
            dsQWSLocal2024.VehicleRow myVehicle = CurrentVehicle();
            if (myVehicle.IsLeadVehicle == true)
            {
                taPrefCustomers.FillBy(dsQWSLocal2024.VehiclePrefCustomers, CurrentVehicle().Rego);
                bsPrefCustomers.Sort = "IsDefault DESC, PrefCustomer ASC";
                //tabControl1.TabPages.Add(tpPrefCust);
                tpPrefCust.Text = "Preferred Customers";
                gbPrefCustomers.Visible = true;
            }
            else
            {
                //tabControl1.TabPages.Remove(tpPrefCust);
                tpPrefCust.Text = " . . . . . ";
                gbPrefCustomers.Visible = false;
            }
        }

        private void VehicleMaintenance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                FindByOwnerOrRego();
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DeleteVehicle();
        }

        private void DeleteVehicle()
        {
            try
            {
                if (dsQWSLocal2024.Vehicle.Count == 1)
                {
                    dsQWSLocal2024.VehicleRow myVehicleRow = dsQWSLocal2024.Vehicle[0];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this vehicle and associated configurations?", "Confirm Delete " + myVehicleRow.Rego, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {                  
                        myVehicleRow.Delete();
                        bsVehicle.EndEdit();
                        taVehicle.Update(dsQWSLocal2024.Vehicle);
                        dsQWSLocal2024.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DeleteVehicle Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvPBS_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Rego"].Value = CurrentVehicle().Rego;
        }

        private void VehicleSaveBlock()
        {
            VehicleSave();
            SavePrefCustomers();
            UpdateVehiclePBS();
            CheckExpiryDT();
        }

        private void txtOwner_Enter(object sender, EventArgs e)
        {
            txtOwner.SelectAll();
        }

        private void txtOwner_Click(object sender, EventArgs e)
        {
            txtOwner.SelectAll();
        }

        private void txtOwner_Leave(object sender, EventArgs e)
        {
            BusinessSearch();
        }

        private void txtFeeCode_Leave(object sender, EventArgs e)
        {
            SetFeeCode();
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Left groupbox2");
            VehicleSave();
        }

        private void groupBox3_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Left groupbox3");
            VehicleSaveBlock();
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Left groupbox1");
            VehicleSaveBlock();
        }

        private void btnSetOwner_Click(object sender, EventArgs e)
        {
            BusinessSearch();
        }

        private void btnSetAxleConfig_Click(object sender, EventArgs e)
        {
            AxleConfiguration();
        }

        private bool CheckACC(string Rego)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsACC";
                cmd.Parameters.AddWithValue("@Rego", Rego);
                sqlConnection.Open();
                int iGroupCode = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                if (iGroupCode == 117)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IsACC Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

