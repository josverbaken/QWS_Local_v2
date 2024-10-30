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
                int iRows = taOperatorRolesDetailed.Fill(dsAdmin.OperatorRolesDetailed, OperatorID);
                iRows += 1;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FindOperatorRoles ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OperatorRoles_Load(object sender, EventArgs e)
        {
            this.taRoleFunctions.Fill(this.dsAdmin.RoleFunctions);
            this.operatorRolesTableAdapter.Fill(this.dsAdmin.OperatorRoles);
            this.taFunctions.Fill(this.dsAdmin.Functions);
            this.taRole.Fill(this.dsAdmin.Role);
            this.taOperator.Fill(this.dsAdmin.Operator);
        }

        private void btnSaveOperator_Click(object sender, EventArgs e)
        {
            try
            {
                taOperator.Update(dsAdmin.Operator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            taRole.Update(dsAdmin.Role);
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                taFunctions.Update(dsAdmin.Functions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveOperatorRoles_Click(object sender, EventArgs e)
        {
            try
            {
                operatorRolesTableAdapter.Update(dsAdmin.OperatorRoles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveRoleFunctions_Click(object sender, EventArgs e)
        {
            try
            {
                taRoleFunctions.Update(dsAdmin.RoleFunctions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
