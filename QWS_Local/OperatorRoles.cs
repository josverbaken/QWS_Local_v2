using System;
using System.Data;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class OperatorRoles : Form
    {
        public OperatorRoles()
        {
            InitializeComponent();
        }



        private void OperatorRoles_Load(object sender, EventArgs e)
        {
            dsAdminTableAdapters.taRoleFunctions taRoleFunctions = new dsAdminTableAdapters.taRoleFunctions();
            taRoleFunctions.Connection.ConnectionString = QWSConfig.cnQWSLocal;
            taRoleFunctions.Fill(dsAdmin.RoleFunctions);

            dsAdminTableAdapters.taOperatorRoles taOperatorRoles = new dsAdminTableAdapters.taOperatorRoles();
            taOperatorRoles.Connection.ConnectionString=QWSConfig.cnQWSLocal;
            operatorRolesTableAdapter.Fill(dsAdmin.OperatorRoles);

            dsAdminTableAdapters.taFunctions taFunctions = new dsAdminTableAdapters.taFunctions();
            taFunctions.Connection.ConnectionString =(QWSConfig.cnQWSLocal);
            taFunctions.Fill(dsAdmin.Functions);

            dsAdminTableAdapters.taRole taRole = new dsAdminTableAdapters.taRole();
            taRole.Connection.ConnectionString =( QWSConfig.cnQWSLocal);
            taRole.Fill(dsAdmin.Role);

            dsAdminTableAdapters.taOperator taOperator = new dsAdminTableAdapters.taOperator();
            taOperator.Connection.ConnectionString=( QWSConfig.cnQWSLocal);
            taOperator.Fill(dsAdmin.Operator);
        }

        dsAdmin.OperatorRow CurrentOperator()
        {
            try
            {
                if (bsOperator.Count > 0)
                {
                    DataRow myRow = ((DataRowView)bsOperator.Current).Row;
                    dsAdmin.OperatorRow myOperator = (dsAdmin.OperatorRow)myRow;
                    return myOperator;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ViewOperatorRoles();
        }

        private void ViewOperatorRoles()
        {
            int OperatorID = CurrentOperator().OperatorID;
            FindOperatorRoles(OperatorID);
            tabControl1.SelectedTab = tpDetails;
        }

        private void FindOperatorRoles(int OperatorID)
        {
            try
            {
                dsAdminTableAdapters.taOperatorRolesDetailed taOperatorRolesDetailed = new dsAdminTableAdapters.taOperatorRolesDetailed();
                taOperatorRolesDetailed.Connection.ConnectionString=QWSConfig.cnQWSLocal;
                int iRows = taOperatorRolesDetailed.Fill(dsAdmin.OperatorRolesDetailed, OperatorID);
                iRows += 1;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FindOperatorRoles ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSaveOperator_Click(object sender, EventArgs e)
        {
            try
            {
                dsAdminTableAdapters.taOperator taOperator = new dsAdminTableAdapters.taOperator();
                taOperator.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                taOperator.Update(dsAdmin.Operator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            try
            {
                dsAdminTableAdapters.taRole taRole = new dsAdminTableAdapters.taRole();
                taRole.Connection.ConnectionString =(QWSConfig.cnQWSLocal);
                taRole.Update(dsAdmin.Role);
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
                dsAdminTableAdapters.taFunctions taFunctions = new dsAdminTableAdapters.taFunctions();
                taFunctions.Connection.ConnectionString =( QWSConfig.cnQWSLocal);
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
                dsAdminTableAdapters.taOperatorRoles taOperators = new dsAdminTableAdapters.taOperatorRoles();
                taOperators.Connection.ConnectionString =QWSConfig.cnQWSLocal;
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
                dsAdminTableAdapters.taRoleFunctions taRoleFunctions = new dsAdminTableAdapters.taRoleFunctions();
                taRoleFunctions.Connection.ConnectionString =(QWSConfig.cnQWSLocal);
                taRoleFunctions.Update(dsAdmin.RoleFunctions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                e.Row.Cells[0].Value = -9; // "tba";
                e.Row.Cells[1].Value = "na";
                e.Row.Cells[4].Value = true;
                e.Row.Cells[5].Value = 0;
                e.Row.Cells[6].Value = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operator Data ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }

}
