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
    public partial class FeeCodeSearch : Form
    {
        private dsQWSLocal.VehicleRegFeeCodesRow myFeeCodeRow;

        public dsQWSLocal.VehicleRegFeeCodesRow _FeeCodeRow
        {
            get { return myFeeCodeRow; }
        }

        public FeeCodeSearch()
        {
            InitializeComponent();
        }

        private void FindFeeCode()
        {
            try
            {
                DataRow myDR = ((DataRowView)vehicleRegFeeCodesBindingSource.Current).Row;
                dsQWSLocal.VehicleRegFeeCodesRow feeCodesRow = (dsQWSLocal.VehicleRegFeeCodesRow)myDR;
                myFeeCodeRow = feeCodesRow;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FeeCodeSearch_Load(object sender, EventArgs e)
        {
            this.vehicleRegFeeCodesTableAdapter.Fill(this.dsQWSLocal.VehicleRegFeeCodes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindFeeCode();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ClearFilters()
        {
            vehicleRegFeeCodesBindingSource.RemoveFilter();
        }

        private void rbFeeCode_CheckedChanged(object sender, EventArgs e)
        {
           if (rbFeeCode.Checked == true)
            {
                string strFilter = "FeeCode like '" + this.feeCodeTextBox.Text + "%'";
                vehicleRegFeeCodesBindingSource.Filter = strFilter;
            }
        }

        private void rbVehicleType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVehicleType.Checked == true)
            {
                string strFilter = "VehicleType like '" + this.vehicleTypeTextBox.Text + "%'";
                vehicleRegFeeCodesBindingSource.Filter = strFilter;
            }
        }

        private void rbClearFilters_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClearFilters.Checked == true)
            {
                ClearFilters();
            }
        }

        private void rbCoupling_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCoupling.Checked == true)
            {
                string strFilter = "Coupling like '" + this.couplingTextBox.Text + "'";
                vehicleRegFeeCodesBindingSource.Filter = strFilter;
            }
        }
    }
}
