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
        public PBSManagement()
        {
            InitializeComponent();
        }

        private void PBSManagement_Load(object sender, EventArgs e)
        {
            string strInstruction = "Scheme either:\r\n\t* GML\r\n\t* HML";
            strInstruction += "\r\nUOM either:\r\n\t* Ratio\r\n\t* Tonnes";
            txtInstruction1.Text = strInstruction;
        }
  
        private void button3_Click(object sender, EventArgs e)
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
                    DialogResult dr = MessageBox.Show(strMsg,"VA not found",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        NewVA(myPBSVA);
                    }
                    else
                    {
                        label1.Text = "***";
                    }
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
            }
        }

        private void dgvPBSConfigScheme_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            int myPBSConfigID = CurrentPBSConfig().PBS_ConfigID; //Convert.ToInt32(txtPBS_ConfigID.Text);
            e.Row.Cells["PBS_ConfigID"].Value = myPBSConfigID;
        }

        private void dgvPBSConfig_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int myPBSID = CurrentPBS().PBS_ID;  //Convert.ToInt32(txtPBS_ID.Text);
                e.Row.Cells["PBS_ID"].Value = myPBSID;
                e.Row.Cells["MassMgmtRqd1"].Value = "true"; // TODO does not work nor error!@#
                // TODO maybe do at Dataset or BindingSource level instead. Howto access new record?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewVA(int PBSVA)
        {
            // create new record using built in functionality of DataGridView and set default value for VA.
            label1.Text = "Click new row in grid below and add Version and Approval Date before saving.";
        }

        private void dgvPBS_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            { 
            int myPBSVA = Convert.ToInt32(txtVehicleApproval.Text);
                //e.Row.Cells["Vehicle Approval"].Value = myPBSVA;
                // TODO investigate why not recognising column names?
                // 20250325 handled elsewhere by using index of column
                e.Row.Cells[0].Value = myPBSVA;
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
                if (CurrentPBS()  != null)
                {
                    taPBSConfig.FillByPBSID(dsPBS.PBS_Config, CurrentPBS().PBS_ID);
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

        private dsPBS.PBS_ConfigSchemeRow CurrentPBSConfigScheme()
        {
            try
            {
                DataRow myDR = ((DataRowView)bsPBSConfigScheme.Current).Row;
                dsPBS.PBS_ConfigSchemeRow PBS_ConfigSchemeRow = (dsPBS.PBS_ConfigSchemeRow)myDR;
                return PBS_ConfigSchemeRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void bsPBSConfig_CurrentChanged(object sender, EventArgs e)
        {
            if (bsPBSConfig.Count > 0)
            {
                taPBSConfigScheme.FillBy(dsPBS.PBS_ConfigScheme, CurrentPBSConfig().PBS_ConfigID);
            }
        }
    }
}
