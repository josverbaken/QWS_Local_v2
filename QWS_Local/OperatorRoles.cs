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
    public partial class OperatorRoles : Form
    {
        public OperatorRoles()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindOperatorRoles(Convert.ToInt32(txtOperatorID.Text));
        }

        private void FindOperatorRoles(int OperatorID)
        {
            try
            {
                int iRows = taOperatorRoles.Fill(dsAdmin.OperatorRolesDetailed, OperatorID);
                iRows += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FindOperatorRoles ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OperatorRoles_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
