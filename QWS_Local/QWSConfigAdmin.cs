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
    public partial class QWSConfigAdmin : Form
    {
        public QWSConfigAdmin()
        {
            InitializeComponent();
        }

        private void qWSConfigBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsQWSConfig.EndEdit();
            this.tableAdapterManager.UpdateAll(dsAdmin);
        }

        private void QWSConfigAdmin_Load(object sender, EventArgs e)
        {
            // nothing yet
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dsAdminTableAdapters.taQWSConfig taQWSConfig = new dsAdminTableAdapters.taQWSConfig();
                taQWSConfig.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                taQWSConfig.Fill(dsAdmin.QWSConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
