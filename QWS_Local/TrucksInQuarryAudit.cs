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
