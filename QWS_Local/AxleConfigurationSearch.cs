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
        private dsQWSLocal2024.AxleConfigurationRow myAxleConfigurationRow;

        private bool myIsLeadVehicle;
        private int myAxles;
        private string myCoupling;
        private string myAxleConfiguration = "";

        public dsQWSLocal2024.AxleConfigurationRow _AxleConfigurationRow
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
            this.bsAxleConfig.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dsQWSLocal2024);

        }

        private void AxleConfigurationSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQWSLocal2024.AxleConfiguration' table. You can move, or remove it, as needed.
            this.taAxleConfig.Fill(this.dsQWSLocal2024.AxleConfiguration);
            try
            {
                string myFilter = "";
                this.taAxleConfig.FillByView(this.dsQWSLocal2024.AxleConfiguration);
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
                this.bsAxleConfig.Filter = myFilter;             
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
                DataRow myDR = ((DataRowView)bsAxleConfig.Current).Row;
                dsQWSLocal2024.AxleConfigurationRow axleConfigRow = (dsQWSLocal2024.AxleConfigurationRow)myDR;
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
                bsAxleConfig.Filter = "";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.taAxleConfig.Fill(this.dsQWSLocal2024.AxleConfiguration);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dsQWSLocal2024.AxleConfiguration.Clear();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            bsAxleConfig.Filter = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();  
        }
    }
}
