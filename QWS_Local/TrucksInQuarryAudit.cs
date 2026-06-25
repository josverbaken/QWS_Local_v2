using System;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class TrucksInQuarryAudit : Form
    {
        public TrucksInQuarryAudit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckWeightLog(txtRego.Text);
        }

        private void CheckWeightLog(string myRego)
        {
            try
            {
                dsTIQ2TableAdapters.CheckWeightLogTableAdapter taWeightLog = new dsTIQ2TableAdapters.CheckWeightLogTableAdapter();
                taWeightLog.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                taWeightLog.Fill(dsTIQ2.CheckWeightLog, myRego, dtpAudit.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            CheckWeightLog("%");
        }
    }
}
