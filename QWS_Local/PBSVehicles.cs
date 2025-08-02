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
    public partial class PBSVehicles : Form
    {
        public PBSVehicles()
        {
            InitializeComponent();
        }

        private void pBSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsPBS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPBS);

        }

        private void PBSVehicles_Load(object sender, EventArgs e)
        {
            

        }

        private void btnFindPBS_Click(object sender, EventArgs e)
        {
            try
            {
                int myVA = Convert.ToInt32(txtVA.Text);
                this.taPBS.FillByVA(dsPBS.PBS, myVA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                bsPBS_Vehicles.EndEdit();
                this.taPBS_Vehicles.Update(this.dsPBS.PBS_Vehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFindVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                int myPBS_ID = Convert.ToInt32( txtPBS_ID.Text);
                this.taPBS_Vehicles.FillByPBS_ID(this.dsPBS.PBS_Vehicles,myPBS_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
