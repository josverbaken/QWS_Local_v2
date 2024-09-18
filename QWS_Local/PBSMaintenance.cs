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
            this.taPBS.Fill(this.dsPBS.PBS);
            this.taPBS_Config.Fill(this.dsPBS.PBS_Config);
            this.taPBS_ConfigScheme.Fill(this.dsPBS.PBS_ConfigScheme);
        }

        private void PBS_Save()
        {
            try
            {
                this.Validate();
                this.bsPBS.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.dsPBS);
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
                int foundIndex = this.bsPBS.Find("VehicleApproval", txtPBS2Find.Text);
                this.bsPBS.Position = foundIndex;
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
                this.bsPBS_Config.EndEdit();
                this.taPBS_ConfigScheme.Update(this.dsPBS);
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
                this.bsPBS_ConfigScheme.EndEdit();
                int iCount = this.taPBS_ConfigScheme.Update(this.dsPBS);
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

        private dsPBS.PBS_ConfigRow CurrentPBSConfig()
        {
           try
            {
                DataRow myDR = ((DataRowView)bsPBS_Config.Current).Row;
                dsPBS.PBS_ConfigRow PBS_ConfigRow = (dsPBS.PBS_ConfigRow)myDR;
                return PBS_ConfigRow;
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
                DataRow myDR = ((DataRowView)bsPBS_ConfigScheme.Current).Row;
                dsPBS.PBS_ConfigSchemeRow PBS_ConfigSchemeRow = (dsPBS.PBS_ConfigSchemeRow)myDR;
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
