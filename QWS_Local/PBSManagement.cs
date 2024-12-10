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
            // nothing at present
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            GetPBSConfig();
        }

        private void GetPBSConfig()
        {
            int myPBSID = Convert.ToInt32(txtPBS_ID.Text);
            taPBSConfig.FillByPBSID(dsPBS.PBS_Config, myPBSID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myPBSConfigID = Convert.ToInt32(txtPBS_ConfigID.Text);
            taPBSConfigScheme.FillBy(dsPBS.PBS_ConfigScheme,myPBSConfigID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dsPBS.Clear();
                int myPBSVA = Convert.ToInt32(txtVehicleApproval.Text);
                taPBS.FillByVA(dsPBS.PBS, myPBSVA);
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
            BusinessSearch frmBusinessSearch = new BusinessSearch(txtOwner.Text);
            DialogResult dr = frmBusinessSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show(frmBusinessSearch.BusinessName);
            }
        }

        private void dgvPBSConfigScheme_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            int myPBSConfigID = Convert.ToInt32(txtPBS_ConfigID.Text);
            e.Row.Cells["PBS_ConfigID"].Value = myPBSConfigID;
        }

        private void dgvPBSConfig_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int myPBSID = Convert.ToInt32(txtPBS_ID.Text);
                e.Row.Cells["PBS_ID"].Value = myPBSID;
                e.Row.Cells["MassMgmtRqd1"].Value = "true"; // TODO does not work nor error!@#
                // TODO maybe do at Dataset or BindingSource level instead. Howto access new record?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
