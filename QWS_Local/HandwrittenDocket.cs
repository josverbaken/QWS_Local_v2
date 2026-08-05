using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class HandwrittenDocket : Form
    {
        public HandwrittenDocket()
        {
            InitializeComponent();
        }

        private void wBDocketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsWBDockets.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsTIQ2);

        }

        private void HandwrittenDocket_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dsTIQ2.WBDocketLines' table. You can move, or remove it, as needed.
            //dsTIQ2TableAdapters.WBDocketLinesTableAdapter taWBDocketLines = new dsTIQ2TableAdapters.WBDocketLinesTableAdapter();
            //taWBDocketLines.Connection.ConnectionString = QWSConfig.cnQWSLocal;
            //taWBDocketLines.Fill(dsTIQ2.WBDocketLines);
            //// TODO: This line of code loads data into the 'dsTIQ2.WBDockets' table. You can move, or remove it, as needed.
            //dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets = new dsTIQ2TableAdapters.WBDocketsTableAdapter();
            //taWBDockets.Connection.ConnectionString=QWSConfig.cnQWSLocal;
            //taWBDockets.Fill(dsTIQ2.WBDockets);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckDocketNumber();
        }

        private void CheckDocketNumber()
        {
            try
            {
                dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets = new dsTIQ2TableAdapters.WBDocketsTableAdapter();
                taWBDockets.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                int iCount = taWBDockets.FillBy(dsTIQ2.WBDockets,System.Convert.ToInt32(txtDocNum.Text));
                if (iCount > 0) 
                {
                    MessageBox.Show("Docket already used!", "Docket Number Check",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CheckDocketNumber Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
