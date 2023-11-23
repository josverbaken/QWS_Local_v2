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
    public partial class AxleConfigurationSearch : Form
    {
        private dsQWSLocal.AxleConfigurationRow myAxleConfigurationRow;

        //private string myVehicleType;
        private int myAxles;
        private string myCoupling;

        public dsQWSLocal.AxleConfigurationRow _AxleConfigurationRow
        {
            get { return myAxleConfigurationRow; }
        }
        public AxleConfigurationSearch()
        {
            InitializeComponent();
        }

        public AxleConfigurationSearch(int Axles, string Coupling)
        {
            InitializeComponent();
            //myVehicleType = VehicleType;
            myAxles = Axles;
            myCoupling = Coupling;
        }

        private void axleConfigurationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.axleConfigurationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQWSLocal);

        }

        private void AxleConfigurationSearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.axleConfigurationTableAdapter.Fill(this.dsQWSLocal.AxleConfiguration);
                // TODO probably better to call parameterised stored procedure
            string myFilter = "Axles = " + myAxles.ToString();
                //"VehicleType like '" + myVehicleType + "'";
                //myFilter += " and Axles = " + myAxles.ToString();
                if (myVehicleType == "Trailer")
                {
                    myFilter += " and AxleConfiguration like '" + myCoupling + "%'";
                }
                else
                {
                    myFilter += " and AxleConfiguration like '%" + myCoupling + "%'";
                }
                this.axleConfigurationBindingSource.Filter = myFilter;
            //this.radGridView1.TableElement.RowHeight = 150;
            //this.dataGridView1.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void SelectAndClose()
        {
            try
            {
                DataRow myDR = ((DataRowView)axleConfigurationBindingSource.Current).Row;
                dsQWSLocal.AxleConfigurationRow axleConfigRow = (dsQWSLocal.AxleConfigurationRow)myDR;
                myAxleConfigurationRow = axleConfigRow;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                axleConfigurationBindingSource.Filter = "";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.axleConfigurationTableAdapter.Fill(this.dsQWSLocal.AxleConfiguration);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dsQWSLocal.AxleConfiguration.Clear();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            axleConfigurationBindingSource.Filter = "";
        }
    }
}
