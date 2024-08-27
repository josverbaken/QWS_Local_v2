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

        private bool myIsLeadVehicle;
        private int myAxles;
        private string myCoupling;
        private string myAxleConfiguration = "";

        public dsQWSLocal.AxleConfigurationRow _AxleConfigurationRow
        {
            get { return myAxleConfigurationRow; }
        }

        public string SelectedAxleConfig
        {
            get { return myAxleConfiguration; }
        }

        public AxleConfigurationSearch()
        {
            InitializeComponent();
        }
        public AxleConfigurationSearch(string Axleconfiguration)
        {
            InitializeComponent();
            myAxleConfiguration=Axleconfiguration;
        }

        public AxleConfigurationSearch(bool IsLeadVehicle, int Axles, string Coupling)
        {
            InitializeComponent();
            myIsLeadVehicle = IsLeadVehicle;
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
                string myFilter = "";
                this.axleConfigurationTableAdapter.FillByView(this.dsQWSLocal.AxleConfiguration);
                if (myAxleConfiguration.Length > 0)
                {
                    myFilter = "AxleConfiguration like '" + myAxleConfiguration + "%'";
                }
                else
                {
                    myFilter = "Axles = " + myAxles.ToString();
                    if (myIsLeadVehicle == false)
                    {
                        myFilter += " and AxleConfiguration like '" + myCoupling + "%'";
                    }
                    else
                    {
                        myFilter += " and AxleConfiguration like '%" + myCoupling + "%'  and IsLeadVehicle = 1";
                    }

                }
                this.axleConfigurationBindingSource.Filter = myFilter;             
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
                myAxleConfiguration = axleConfigRow.AxleConfiguration;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();  
        }
    }
}
