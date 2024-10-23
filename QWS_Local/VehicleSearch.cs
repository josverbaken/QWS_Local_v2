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
    public partial class VehicleSearch : Form
    {
        private string myRego;
        private string myCardCode;

        public string CardCode
        {
            get { return myCardCode; }
        }

        public string Rego
        {
            get { return myRego; }
        }

        private void VehicleSearch_Load(object sender, EventArgs e)
        {
            rbClear.Checked = true;
        }

        public VehicleSearch()
        {
            InitializeComponent();
        }

        public VehicleSearch(string CardCode, string AxleConfig, bool Exact)
        {
            InitializeComponent();
            Search4Vehicle(CardCode,true);
            this.txtSearch1.Text = CardCode;
            //MessageBox.Show("Truck Axle config = " + AxleConfig + " Exact = " + Exact.ToString());
            FilterByAxleConfig(AxleConfig,Exact);
        }

        public VehicleSearch(string strSearch, bool IsCardCode)
        {
            InitializeComponent();
            Search4Vehicle(strSearch, IsCardCode);
            // prime search textbox
            this.txtSearch1.Text = strSearch;
        }

        private void Search4Vehicle(string strSearch, bool IsCardCode)
        {
            try
            {
                if (IsCardCode)
                {
                    this.taVehicleDetails2.FillByCardCode(this.dsQWSLocal2024.VehicleDetails, strSearch);
                    //this.bsVehicleDetails.Filter = "IsLeadVehicle = 1";
                    // maybe pass in as a parameter from calling form
                    // maybe create function for filter
                    // testing 20241002
                    if (bsVehicleDetails2.Count > 0)
                    {
                        DataRow myDR = ((DataRowView)bsVehicleDetails2.Current).Row;
                        dsQWSLocal2024.VehicleDetailsRow vehicleDetailsRow = (dsQWSLocal2024.VehicleDetailsRow)myDR;
                        myRego = vehicleDetailsRow.Rego;
                        myCardCode = vehicleDetailsRow.CardCode;
                    }
                }
                else
                {
                    this.taVehicleDetails2.FillBy(this.dsQWSLocal2024.VehicleDetails, strSearch);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VehicleSet()
        {
            if (bsVehicleDetails2.Count > 0)
            {
                DataRow myDR = ((DataRowView)bsVehicleDetails2.Current).Row;
                dsQWSLocal2024.VehicleDetailsRow vehicleDetailsRow = (dsQWSLocal2024.VehicleDetailsRow)myDR;
                myRego = vehicleDetailsRow.Rego;
                myCardCode = vehicleDetailsRow.CardCode;
            }
        }

 
        private void FilterByAxleConfig(string AxleConfig, bool Exact)
        {
            rbClear.Checked=true; //to ensure desired filter 
            if (Exact == true) 
            {
                this.bsVehicleDetails2.Filter = "AxleConfiguration like '" + AxleConfig + "'";
            }
            else
            {
                this.bsVehicleDetails2.Filter = "AxleConfiguration like '" + AxleConfig + "%'";
            }
        }

        private void FilterByTrailers()
        {
            this.bsVehicleDetails2.Filter = "IsLeadVehicle = 0";
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            this.bsVehicleDetails2.Filter = "";
            rbTrailers.Checked = false;
            
        }

        private void rbTrucks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrucks.Checked == true)
            {
                this.bsVehicleDetails2.Filter = "IsLeadVehicle = 1";
            }
        }

        private void rbTrailers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrailers.Checked == true)
            {
                this.bsVehicleDetails2.Filter = "IsLeadVehicle = 0";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Search4Vehicle(this.txtSearch1.Text, false);
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            VehicleSet();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbClear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClear.Checked == true)
            {
                bsVehicleDetails2.Filter = "";
            }
        }
    }
}
