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
    public partial class VehicleSearch : Form
    {
        private string myRego;

        public string _Rego
        {
            get { return myRego; }
        }

        private void VehicleSearch_Load(object sender, EventArgs e)
        {
            // nothing at present
        }

        public VehicleSearch()
        {
            InitializeComponent();
        }

        public VehicleSearch(string strSearch)
        {
            InitializeComponent();
            Search4Vehicle(strSearch);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search4Vehicle(this.txtSearch.Text);
        }

        private void Search4Vehicle(string strSearch)
        {
            try
            {
                this.vehicleDetailsTableAdapter.FillBy(this.dsQWSLocal.VehicleDetails, strSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VehicleSet()
        {
            DataRow myDR = ((DataRowView)vehicleDetailsBindingSource.Current).Row;
            dsQWSLocal.VehicleDetailsRow vehicleDetailsRow = (dsQWSLocal.VehicleDetailsRow)myDR;
            myRego = vehicleDetailsRow.Rego;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VehicleSet();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FilterByTrailers();
        }

        private void FilterByTrailers()
        {
            if (this.vehicleDetailsBindingSource.Filter == "")
            {
                this.vehicleDetailsBindingSource.Filter = "VehicleType like 'Trailer'";
            }
            else
            {
                this.vehicleDetailsBindingSource.Filter = "";
            }
        }
    }
}
