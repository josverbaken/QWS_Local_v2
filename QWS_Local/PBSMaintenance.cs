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
            // TODO: This line of code loads data into the 'dsQWSLocal.PBS_VIN' table. You can move, or remove it, as needed.
            //this.pBS_VINTableAdapter.Fill(this.dsQWSLocal.PBS_VIN);
            // TODO: This line of code loads data into the 'dsQWSLocal1.PBS_Config' table. You can move, or remove it, as needed.
            this.pBS_ConfigTableAdapter.Fill(this.dsQWSLocal.PBS_Config);
            // TODO: This line of code loads data into the 'dsQWSLocal1.PBS' table. You can move, or remove it, as needed.
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
                //throw;
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
                //throw;
            }
        }


        private void PBS_VIN_Add()
        {
            try
            {
                // TODO check if still rqd
                this.Validate();
                //this.pBS_VINBindingSource.EndEdit();
                //this.pBS_VINTableAdapter.Update(this.dsQWSLocal);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //throw;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            PBS_VIN_Add();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //copy bps_config_id
            //txtPBS_Config_ID_VIN.Text = txtPBS_Config_ID.Text;
        }
    }
}
