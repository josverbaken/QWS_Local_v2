using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QWS_Local
{
    public partial class PBSManagement : Form
    {
        private string myCardCode;
        private string myOperator;

        public PBSManagement()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PBSManagement_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // enable Function keys
        }
  
        private void button3_Click(object sender, EventArgs e)
        {
            VehicleApprovalFind();
        }

        private void VehicleApprovalFind()
        {
            try
            {
                dsPBS.Clear();
                int myPBSVA = Convert.ToInt32(txtVehicleApproval.Text);
                int iRows = taPBS.FillByVA(dsPBS.PBS, myPBSVA);
                if (iRows == 0)
                {
                    string strMsg = "VA";
                    strMsg += txtVehicleApproval.Text + " not found.\r\nDo you want to add a new record?";
                    DialogResult dr = MessageBox.Show(strMsg, "VA not found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        NewVA(myPBSVA);
                    }
                    else
                    {
                        label1.Text = "***";
                    }
                }
                else
                {
                    // variables CardCode, Operator
                    myCardCode = CurrentPBS().CardCode;
                    myOperator = CurrentPBS().Operator;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindOwner_Click(object sender, EventArgs e)
        {
            GetOwner(txtOperator.Text);
        }

        private string GetOwner(string Owner)
        {
            BusinessSearch frmBusinessSearch = new BusinessSearch(Owner);
            DialogResult dr = frmBusinessSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show(frmBusinessSearch.BusinessName);
                label3.Text = "Click new row in grid below and add Version and Approval Date before saving.";
                myCardCode = frmBusinessSearch.SAPCode;
                myOperator = frmBusinessSearch.BusinessName;
                txtCardCode.Text = frmBusinessSearch.SAPCode;
                txtOperator.Text = frmBusinessSearch.BusinessName;
                return myCardCode;
            }
            else
            {
                label3.Text = "...";
                return "not found";
            }
        }

        private void dgvPBSConfigScheme_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int myPBSConfigID = CurrentPBSConfig().PBS_ConfigID; //Convert.ToInt32(txtPBS_ConfigID.Text);
                e.Row.Cells[1].Value = myPBSConfigID; // "PBS_ConfigID"
                e.Row.Cells[6].Value = "GML";
                e.Row.Cells[7].Value = 0.20M;
                e.Row.Cells[8].Value = "Ratio";
                e.Row.Cells[9].Value = false; //"MassMgmtRqd"
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPBSConfig_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int myPBSID = CurrentPBS().PBS_ID;  //Convert.ToInt32(txtPBS_ID.Text);
                e.Row.Cells[1].Value = myPBSID; // "PBS_ID"
                e.Row.Cells[2].Value = "Tier 1"; // 99%, some Tier 2/3
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewVA(int PBSVA)
        {
            label1.Text = "Find SAP Busness Partner";              
        }

        private void dgvPBS_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            { 
            int myPBSVA = Convert.ToInt32(txtVehicleApproval.Text);
                //e.Row.Cells["Vehicle Approval"].Value = myPBSVA;
                // investigate why not recognising column names?
                // 20250325 handled elsewhere by using index of column (dgv not dataset)
                e.Row.Cells[0].Value = myPBSVA;
                e.Row.Cells[3].Value = myOperator;
                e.Row.Cells[4].Value = myCardCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VehicleApprovalSave()
        {
            bsPBS.EndEdit();
            taPBS.Update(dsPBS.PBS);
        }

        private void PBSConfigSave()
        {
            bsPBSConfig.EndEdit();
            taPBSConfig.Update(dsPBS.PBS_Config);
        }

        private void btnSaveVA_Click(object sender, EventArgs e)
        {
            VehicleApprovalSave();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PBSConfigSave();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            bsPBSConfigScheme.EndEdit();
            taPBSConfigScheme.Update(dsPBS.PBS_ConfigScheme);
            this.Close();
        }

        private void PBSConfigSchemeSave()
        {
            bsPBSConfigScheme.EndEdit();
            taPBSConfigScheme.Update(dsPBS.PBS_ConfigScheme);
        }

        private void bsPBS_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                dsPBS.PBS_ConfigScheme.Clear();
                if (CurrentPBS()  != null)
                {
                    taPBSConfig.FillByPBSID(dsPBS.PBS_Config, CurrentPBS().PBS_ID);
                    taPBSVehicles.FillBy(dsPBS.PBS_Vehicles, CurrentPBS().PBS_ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsPBS.PBSRow CurrentPBS()
        {
            try
            {
                if (bsPBS.Count > 0)
                {
                    DataRow myDR = ((DataRowView)bsPBS.Current).Row;
                    if (myDR != null)
                    {
                        dsPBS.PBSRow row = (dsPBS.PBSRow)myDR;
                        return row;
                    }
                    else
                    {
                        return null;
                    }    
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private dsPBS.PBS_VehiclesRow CurrentPBSVehicle()
        {
            try
            {
                if (bsPBSVehicles.Count > 0)
                {
                    DataRow myDR = ((DataRowView)bsPBSVehicles.Current).Row;
                    if (myDR != null)
                    {
                        dsPBS.PBS_VehiclesRow row = (dsPBS.PBS_VehiclesRow)myDR;
                        return row;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private dsPBS.PBS_ConfigRow CurrentPBSConfig()
        {
            try
            {
                if (bsPBSConfig.Count > 0)
                {
                    DataRow myDR = ((DataRowView)bsPBSConfig.Current).Row;
                    dsPBS.PBS_ConfigRow PBS_ConfigRow = (dsPBS.PBS_ConfigRow)myDR;
                    return PBS_ConfigRow;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //private dsPBS.PBS_ConfigSchemeRow CurrentPBSConfigScheme()
        //{
        //    try
        //    {
        //        DataRow myDR = ((DataRowView)bsPBSConfigScheme.Current).Row;
        //        dsPBS.PBS_ConfigSchemeRow PBS_ConfigSchemeRow = (dsPBS.PBS_ConfigSchemeRow)myDR;
        //        return PBS_ConfigSchemeRow;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}

        private void bsPBSConfig_CurrentChanged(object sender, EventArgs e)
        {
            if (bsPBSConfig.Count > 0)
            {
                int myPBS_ConfigID = CurrentPBSConfig().PBS_ConfigID;
                taPBSConfigScheme.FillBy(dsPBS.PBS_ConfigScheme, myPBS_ConfigID);
                int iRows = taPBSConfigMatrix.FillBy(dsPBS.PBS_ConfigMatrix, myPBS_ConfigID);
                iRows += 1;
            }
        }

        private void PBSManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                VehicleApprovalFind();
            }
        }

        private void btnFindPBS_Vehicle_Click(object sender, EventArgs e)
        {
            try
            {
                int myPBS_ID = CurrentPBS().PBS_ID;
                taPBSVehicles.FillBy(dsPBS.PBS_Vehicles, myPBS_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSAVEPBS_Vehicle_Click(object sender, EventArgs e)
        {
            try
            {
                bsPBSVehicles.EndEdit();
                taPBSVehicles.Update(dsPBS.PBS_Vehicles);
                RefreshPBSVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindPBSConfigMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                int myPBS_ConfigID = CurrentPBSConfig().PBS_ConfigID;
                taPBSConfigMatrix.FillBy(dsPBS.PBS_ConfigMatrix, myPBS_ConfigID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSavePBSConfigMatrix_Click(object sender, EventArgs e)
        {
            PBSConfigMatrixSave();
        }

        private void PBSConfigMatrixSave()
        {
            try
            {
                bsPBSConfigMatrix.EndEdit();
                int iRows = taPBSConfigMatrix.Update(dsPBS.PBS_ConfigMatrix);
                iRows += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPBSConfigMatrix_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            int myPBS_ConfigID = CurrentPBSConfig().PBS_ConfigID;
            e.Row.Cells[1].Value = myPBS_ConfigID.ToString();
        }

        private void btnFindVIN_Click(object sender, EventArgs e)
        {
// do nothing
}

        private string GetVIN(string Rego)
        {
            try
            {
                if (string.IsNullOrEmpty(Rego))
                {
                    MessageBox.Show("Rego missing!");
                    return "not found";
                }
                else
                { 
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "FindVIN";
                    cmd.Parameters.AddWithValue("@Rego", Rego);
                    sqlConnection.Open();
                    string myVIN = cmd.ExecuteScalar().ToString();
                    sqlConnection.Close();
                    return myVIN;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "not found";
            }
        }

        private void btnAcceptVIN_Click(object sender, EventArgs e)
        {
            //CurrentPBSVehicle().VIN = txtFoundVIN.Text;
            int iRow = dgvPBS_Vehicles.CurrentCellAddress.Y;
            if (iRow > 0)
            {
                //deprecated dgvPBS_Vehicles.Rows[iRow].Cells[2].Value = txtFoundVIN.Text;
                //dgvPBS_Vehicles.Rows[iRow].Cells[5].Value = txtRego4VIN.Text; // column Rego is Read Only!
            }
            bsPBSVehicles.EndEdit();
        }

        private void btnRefreshPBSVehicles_Click(object sender, EventArgs e)
        {
            RefreshPBSVehicles();
        }

        private void RefreshPBSVehicles()
        {
            try
            {
                int myPBS_ID = CurrentPBS().PBS_ID;
                taPBSVehicles.FillBy(dsPBS.PBS_Vehicles, myPBS_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewVIN_Click(object sender, EventArgs e)
        {
            NewPBSVehicle();
            Move2TruckType();
        }

        private void Move2TruckType()
        {
            try
            {
                int iRow = dgvPBS_Vehicles.RowCount;
                dgvPBS_Vehicles.ClearSelection();
                dgvPBS_Vehicles.CurrentCell = dgvPBS_Vehicles.Rows[iRow - 1].Cells[3];
                //dgvPBS_Vehicles.CurrentCell.Selected = true; // same as above
                // seems quite convoluted to actually select cell contents
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewPBSVehicle()
        {
            try
            {
                string myVIN = "tba";              
                string myRego = "tba";
                DataRow dr = dsPBS.PBS_Vehicles.NewRow();
                dsPBS.PBS_VehiclesRow myVehicle = (dsPBS.PBS_VehiclesRow)dr;
                myVehicle.PBS_ID = CurrentPBS().PBS_ID;
                myVehicle.VIN = myVIN;
                myVehicle.Rego = myRego;
                myVehicle.TruckType = "tba";
                myVehicle.TruckTypeNo = 0;
                dsPBS.PBS_Vehicles.AddPBS_VehiclesRow(myVehicle);
                bsPBSVehicles.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPBS_Leave(object sender, EventArgs e)
        {
            dgvPBS.EndEdit();
            VehicleApprovalSave();
        }

        private void dgvPBSConfig_Leave(object sender, EventArgs e)
        {
            dgvPBSConfig.EndEdit();
            PBSConfigSave();
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            VAFindAll();
        }

        private void VAFindAll()
        {
            taPBS_Search.Fill(dsPBS.PBS_Search,"%","%",0);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PBSFindBy("xx",txtRego.Text,0);
        }

        private void PBSFindBy(string CardCode, string Rego, int VA)
        {
            taPBS_Search.Fill(dsPBS.PBS_Search, CardCode, Rego, VA);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOwnerCode.Text = GetOwner(txtOwner2Search.Text);
        }

        private void dgvPBSConfigScheme_Leave(object sender, EventArgs e)
        {
            dgvPBSConfigScheme.EndEdit();
            PBSConfigSchemeSave();
        }

        private void dgvPBSConfigMatrix_Leave(object sender, EventArgs e)
        {
            dgvPBSConfigMatrix.EndEdit();
            PBSConfigMatrixSave();
        }

        private void btnFindByVA_Click(object sender, EventArgs e)
        {
            PBSFindBy("xx","xx",System.Convert.ToInt32(txtVA.Text));
        }

        private void btnFindByCardCode_Click(object sender, EventArgs e)
        {
            PBSFindBy(txtOwnerCode.Text, "xx", 0);
        }

        private void dgvPBS_Vehicles_Leave(object sender, EventArgs e)
        {
            dgvPBS_Vehicles.EndEdit();
            PBSVehiclesSave();
        }

        private void PBSVehiclesSave()
        {
            try
            {
                bsPBSVehicles.EndEdit();
                taPBSVehicles.Update(dsPBS.PBS_Vehicles);
                RefreshPBSVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPBSConfig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvPBSConfig.Columns["Next"].Index && e.RowIndex >= 0)
                {
                    // TODO Save
                    dgvPBSConfigMatrix.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPBS_Vehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvPBS_Vehicles.Columns["Rego2VIN"].Index && e.RowIndex >= 0)
                {
                    string rowData = dgvPBS_Vehicles.Rows[e.RowIndex].Cells["Rego"].Value.ToString();
                    string myVIN = GetVIN(rowData);
                    dgvPBS_Vehicles.Rows[e.RowIndex].Cells[4].Value = myVIN; 
                }
                if (e.ColumnIndex == dgvPBS_Vehicles.Columns["Next3"].Index && e.RowIndex >= 0)
                {
                    // TODO save 
                    dgvPBSConfig.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPBS_Vehicles_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int myPBSID = CurrentPBS().PBS_ID;  //Convert.ToInt32(txtPBS_ID.Text);
                e.Row.Cells[0].Value = myPBSID; // "PBS_ID"
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvPBS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvPBS.Columns["Next2"].Index && e.RowIndex >= 0)
                {
                    // TODO save 
                    dgvPBS_Vehicles.Focus();
                }
            }        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvPBSConfigMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvPBSConfigMatrix.Columns["Next1"].Index && e.RowIndex >= 0)
                {
                    // TODO save 
                    dgvPBSConfigScheme.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPBSConfigScheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvPBSConfigScheme.Columns["Next4"].Index && e.RowIndex >= 0)
                {
                    // TODO save 
                    btnSaveConfig.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
