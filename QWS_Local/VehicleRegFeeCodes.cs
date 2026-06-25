using System;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class VehicleRegFeeCodes : Form
    {
        public VehicleRegFeeCodes()
        {
            InitializeComponent();
        }

        private void VehicleRegFeeCodes_Load(object sender, EventArgs e)
        {
            try
            {
                dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter taFeeCodes = new dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter();
                taFeeCodes.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                taFeeCodes.Fill(dsQWSLocal2024.VehicleRegFeeCodes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            bsFeeCodes.EndEdit();
            taFeeCodes.Update(dsQWSLocal2024.VehicleRegFeeCodes);
        }
    }
}
