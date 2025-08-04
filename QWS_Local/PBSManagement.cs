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
            GetOwner();
        }

        private void GetOwner()
        {
            BusinessSearch frmBusinessSearch = new BusinessSearch(txtOperator.Text);
            DialogResult dr = frmBusinessSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show(frmBusinessSearch.BusinessName);
                label3.Text = "Click new row in grid below and add Version and Approval Date before saving.";
                myCardCode = frmBusinessSearch.SAPCode;
                myOperator = frmBusinessSearch.BusinessName;
                txtCardCode.Text = frmBusinessSearch.SAPCode;
                txtOperator.Text = frmBusinessSearch.BusinessName;
            }
            else
            {
                label3.Text = "...";
            }
        }

        private void dgvPBSConfigScheme_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int myPBSConfigID = CurrentPBSConfig().PBS_ConfigID; //Convert.ToInt32(txtPBS_ConfigID.Text);
                e.Row.Cells[1].Value = myPBSConfigID; // "PBS_ConfigID"
                e.Row.Cells[3].Value = "GML";
                e.Row.Cells[6].Value = "Ratio";
                e.Row.Cells[7].Value = false; //"MassMgmtRqd"
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

        private void btnSaveVA_Click(object sender, EventArgs e)
        {
            bsPBS.EndEdit();
            taPBS.Update(dsPBS.PBS);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bsPBSConfig.EndEdit();
            taPBSConfig.Update(dsPBS.PBS_Config);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
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
                    taPBSVehicles.FillByPBS_ID(dsPBS.PBS_Vehicles, CurrentPBS().PBS_ID);
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
                taPBSVehicles.FillByPBS_ID(dsPBS.PBS_Vehicles, myPBS_ID);
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

        private void pBS_VehiclesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int myPBS_ID = CurrentPBS().PBS_ID;
                e.Row.Cells[1].Value = myPBS_ID.ToString();
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
    }
}
