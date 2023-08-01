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
                // TODO determine if Add or Update
                // usp VehicleAdd requires parameter @Rego
                this.Validate();
                //DataRow myDR1 = ((DataRowView)vehicleBindingSource.Current).Row;
                //dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR1;
                //string myRego = vehicleRow.Rego;
                this.vehicleBindingSource.EndEdit();
                this.vehicleTableAdapter.Update(dsQWSLocal.Vehicle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                            DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
                            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                            SynchAxleConfig(vehicleRow.AxleConfiguration);
                            SynchFeeCode(vehicleRow.FeeCodeID);
                            break;
                        case int n when(n > 1):
                            VehicleSearch vehicleSearch = new VehicleSearch(strSearch);
                            dsQWSLocal.Clear();
                            DialogResult dr = vehicleSearch.ShowDialog();
                            if (dr == DialogResult.OK)
                            {
                                iRows = this.vehicleTableAdapter.FillBy(dsQWSLocal.Vehicle, vehicleSearch._Rego);
                                iRows += 2;
                                DataRow myDR1 = ((DataRowView)vehicleBindingSource.Current).Row;
                                dsQWSLocal.VehicleRow vehicleRow1 = (dsQWSLocal.VehicleRow)myDR1;
                                SynchAxleConfig(vehicleRow1.AxleConfiguration);
                                SynchFeeCode(vehicleRow1.FeeCodeID);
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
     
        private void btnSetAxleConfig_Click(object sender, EventArgs e)
        {
            AxleConfiguration();
        }

        private void AxleConfiguration()
        {
            AxleConfigurationSearch axleConfigurationSearch = new AxleConfigurationSearch();
            DialogResult dr = axleConfigurationSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
                dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                string myAxleConfig = axleConfigurationSearch._AxleConfigurationRow.AxleConfiguration;
                vehicleRow.AxleConfiguration = myAxleConfig;
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
                    DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
                    dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                    vehicleRow.SAPCode = businessSearch.SAPCode;
                    vehicleRow.Owner = businessSearch.BusinessName;
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

        private void txtRego_Click(object sender, EventArgs e)
        {
            txtRegoSelectAll();
        }

        private void txtRego_Enter(object sender, EventArgs e)
        {
            txtRegoSelectAll();
        }

        private void TruckConfiguration(string Rego, string SAPCode)
        {
            TruckConfiguration truckConfiguration = new TruckConfiguration();
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
                DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
                dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;

                DataRow myFeeCode = ((DataRowView)vehicleRegFeeCodesBindingSource.Current).Row;
                dsQWSLocal.VehicleRegFeeCodesRow vehicleRegFeeCodesRow = (dsQWSLocal.VehicleRegFeeCodesRow)myFeeCode;

                vehicleRow.FeeCodeID = vehicleRegFeeCodesRow.FeeCodeID;

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
                DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
                dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;

                vehicleRow.FeeCodeID = feeCodeSearch._FeeCodeRow.FeeCodeID;

                this.vehicleRegFeeCodesTableAdapter.FillByBoth(this.dsQWSLocal.VehicleRegFeeCodes, feeCodeSearch._FeeCodeRow.FeeCode, feeCodeSearch._FeeCodeRow.Jurisdiction);

                txtRegoExpiryDT.Focus();
            }
            else
            {
                MessageBox.Show("cancelled");
            }   
        }

        private void txtRego_Leave(object sender, EventArgs e)
        {
            //CheckRego();
        }

        private void CheckRego()
        {
            MessageBox.Show("check if rego is on file");
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
                    DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
                    dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                    SynchAxleConfig(vehicleRow.AxleConfiguration);
                    SynchFeeCode(vehicleRow.FeeCodeID);
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
            DataRow myDR = ((DataRowView)vehicleBindingSource.Current).Row;
            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
            // check if any trailers already associated with owner
            AddTrailer(vehicleRow.SAPCode, vehicleRow.Owner);
        }

        private void btnVehicleAdd_Click(object sender, EventArgs e)
        {
            AddVehicleRequest();
        }

        private void btnConfigureGVM_Click(object sender, EventArgs e)
        {
            //call truck configuration with current rego
        }
    }
}

