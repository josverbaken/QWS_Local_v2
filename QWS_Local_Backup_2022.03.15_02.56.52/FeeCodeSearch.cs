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

        private dsQWSLocal.VehicleRegFeeCodesRow CurrentVehicleRegFeeCode()
        {
            DataRow myDR = ((DataRowView)vehicleRegFeeCodesBindingSource.Current).Row;
            dsQWSLocal.VehicleRegFeeCodesRow feeCodesRow = (dsQWSLocal.VehicleRegFeeCodesRow)myDR;
            return feeCodesRow;           
        }

        private void FindFeeCode()
        {
            try
            {
                myFeeCodeRow = CurrentVehicleRegFeeCode();
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FindFeeCode();
        }

        private void ClearFilters()
        {
            vehicleRegFeeCodesBindingSource.RemoveFilter();
        }

        private void rbFeeCode_CheckedChanged(object sender, EventArgs e)
        {
           if (rbFeeCode.Checked == true)
            {
                string strFilter = "FeeCode like '%" + this.feeCodeTextBox.Text + "%'";
                vehicleRegFeeCodesBindingSource.Filter = strFilter;
            }
        }

        private void rbVehicleType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVehicleType.Checked == true)
            {
                string strFilter = "VehicleType like '%" + this.vehicleTypeTextBox.Text + "%'";
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
