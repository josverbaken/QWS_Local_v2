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
        private dsQWSLocal2024.VehicleRegFeeCodesRow myFeeCodeRow;

        public dsQWSLocal2024.VehicleRegFeeCodesRow _FeeCodeRow
        {
            get { return myFeeCodeRow; }
        }

        public FeeCodeSearch()
        {
            InitializeComponent();
        }

        private dsQWSLocal2024.VehicleRegFeeCodesRow CurrentVehicleRegFeeCode()
        {
            DataRow myDR = ((DataRowView)bsFeeCodes.Current).Row;
            dsQWSLocal2024.VehicleRegFeeCodesRow feeCodesRow = (dsQWSLocal2024.VehicleRegFeeCodesRow)myDR;
            return feeCodesRow;           
        }

        private void SetFeeCode()
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
            int iRows = this.taFeeCodes.Fill(this.dsQWSLocal2024.VehicleRegFeeCodes);
            iRows += 2;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SetFeeCode();
        }
   
        private void ClearFilters()
        {
            rbFeeCode.Checked = false;
            rbCoupling.Checked = false;
            bsFeeCodes.RemoveFilter();
        }

        private void rbFeeCode_CheckedChanged(object sender, EventArgs e)
        {
           if (rbFeeCode.Checked == true)
            {
                string strFilter = "FeeCode like '%" + this.feeCodeTextBox.Text + "%'";
                bsFeeCodes.Filter = strFilter;
            }
        }

 
       private void rbCoupling_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCoupling.Checked == true)
            {
                string strFilter = "Coupling like '" + this.couplingTextBox.Text + "'";
                bsFeeCodes.Filter = strFilter;
            }
        }

        private void vehicleRegFeeCodesBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsFeeCodes.EndEdit();
            this.tamQWSLocal2024.UpdateAll(this.dsQWSLocal2024);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
    }
}
