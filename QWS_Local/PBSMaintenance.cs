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
    public partial class PBSMaintenance : Form
    {
        public PBSMaintenance()
        {
            InitializeComponent();
        }

        private void pBSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            PBS_Save();
        }

        private void PBS_Maintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPBS.PBS_ConfigScheme' table. You can move, or remove it, as needed.
            this.taPBS_ConfigScheme.Fill(this.dsPBS.PBS_ConfigScheme);
            // TODO: This line of code loads data into the 'dsPBS.PBS_Config' table. You can move, or remove it, as needed.
            this.taPBS_Config.Fill(this.dsPBS.PBS_Config);
            // TODO: This line of code loads data into the 'dsPBS.PBS' table. You can move, or remove it, as needed.
            this.taPBS.Fill(this.dsPBS.PBS);
            this.pBS_ConfigSchemeTableAdapter.Fill(this.dsQWSLocal.PBS_ConfigScheme);
            this.pBS_ConfigTableAdapter.Fill(this.dsQWSLocal.PBS_Config);
            this.pBSTableAdapter.Fill(this.dsQWSLocal.PBS);
        }

        private void PBS_Save()
        {
            try
            {
                this.Validate();
                this.pBSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsQWSLocal);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("adding new PBS base document");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            FindPBSbyVA();
        }

        private void FindPBSbyVA()
        {
            try
            {
                int foundIndex = this.pBSBindingSource.Find("VehicleApproval", txtPBS2Find.Text);
                this.pBSBindingSource.Position = foundIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            PBS_Config_Add();
        }

        private void PBS_Config_Add()
        {
            try
            {
                this.Validate();
                this.pBS_ConfigBindingSource.EndEdit();
                this.pBS_ConfigTableAdapter.Update(this.dsQWSLocal);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void tspSavePBSConfigScheme_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pBS_ConfigSchemeBindingSource1.EndEdit();
                int iCount = this.pBS_ConfigSchemeTableAdapter.Update(this.dsQWSLocal);
                iCount += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetCardCode_Click(object sender, EventArgs e)
        {
            SetCardCode();
        }

        private void SetCardCode()
        {
            {
                try
                {
                    BusinessSearch businessSearch = new BusinessSearch(txtOperator.Text);
                    DialogResult dr = businessSearch.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txtCardCode.Text = businessSearch.SAPCode;
                        txtOperator.Text = businessSearch.BusinessName;
                    }
                    else if (dr == DialogResult.Abort)
                    {
                        MessageBox.Show("Customer NOT found, please check with Accounts Manager.", "BP not on file!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Truck Operator Search Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PBSConfigSchemAdd();
        }

        private void PBSConfigSchemAdd()
        {
            txtPBSConfigSchemeID.Text = "-1";
            chkMassMgmtRqd.Checked = false;
            CurrentPBSConfigScheme().PBS_ConfigID = CurrentPBSConfig().PBS_ConfigID;
        }

        private dsQWSLocal.PBS_ConfigRow CurrentPBSConfig()
        {
           try
            {
                DataRow myDR = ((DataRowView)pBS_ConfigBindingSource.Current).Row;
                dsQWSLocal.PBS_ConfigRow PBS_ConfigRow = (dsQWSLocal.PBS_ConfigRow)myDR;
                return PBS_ConfigRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private dsQWSLocal.PBS_ConfigSchemeRow CurrentPBSConfigScheme()
        {
            try
            {
                DataRow myDR = ((DataRowView)pBS_ConfigSchemeBindingSource1.Current).Row;
                dsQWSLocal.PBS_ConfigSchemeRow PBS_ConfigSchemeRow = (dsQWSLocal.PBS_ConfigSchemeRow)myDR;
                return PBS_ConfigSchemeRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
