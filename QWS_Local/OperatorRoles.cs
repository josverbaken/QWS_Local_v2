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



        private void OperatorRoles_Load(object sender, EventArgs e)
        {
            this.taRoleFunctions.Fill(this.dsAdmin.RoleFunctions);
            this.operatorRolesTableAdapter.Fill(this.dsAdmin.OperatorRoles);
            this.taFunctions.Fill(this.dsAdmin.Functions);
            this.taRole.Fill(this.dsAdmin.Role);
            this.taOperator.Fill(this.dsAdmin.Operator);
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

        private void dataGridView2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = "tba";
        }
    }
    
}
