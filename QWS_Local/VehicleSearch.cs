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
            // nothing at present
        }

        public VehicleSearch()
        {
            InitializeComponent();
        }

        public VehicleSearch(string CardCode, string AxleConfig, bool Exact)
        {
            InitializeComponent();
            Search4Vehicle(CardCode,true);
            this.txtSearch.Text = CardCode;
            //TODO set axle config filter
            //this.bsVehicleDetails.Filter = "AxleConfiguration like '" + TkAxleConfig + "%' and IsLeadVehicle = 0";
            MessageBox.Show("Truck Axle config = " + AxleConfig + " Exact = " + Exact.ToString());
            FilterByAxleConfig(AxleConfig,Exact);
            //FilterByTrailers();
        }

        public VehicleSearch(string strSearch, bool IsCardCode)
        {
            InitializeComponent();
            Search4Vehicle(strSearch, IsCardCode);
            // prime search textbox
            this.txtSearch.Text = strSearch;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search4Vehicle(this.txtSearch.Text, false);
        }

        private void Search4Vehicle(string strSearch, bool IsCardCode)
        {
            try
            {
                if (IsCardCode)
                {
                    this.vehicleDetailsTableAdapter.FillBySAPCode(this.dsQWSLocal.VehicleDetails, strSearch);
                    //this.bsVehicleDetails.Filter = "IsLeadVehicle = 1";
                    // maybe pass in as a parameter from calling form
                    // maybe create function for filter
                }
                else
                {
                    this.vehicleDetailsTableAdapter.FillBy(this.dsQWSLocal.VehicleDetails, strSearch);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VehicleSet()
        {
            if (bsVehicleDetails.Count > 0)
            {
                DataRow myDR = ((DataRowView)bsVehicleDetails.Current).Row;
                dsQWSLocal.VehicleDetailsRow vehicleDetailsRow = (dsQWSLocal.VehicleDetailsRow)myDR;
                myRego = vehicleDetailsRow.Rego;
                myCardCode = vehicleDetailsRow.CardCode;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VehicleSet();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FilterByTrailers();
        }

        private void FilterByAxleConfig(string AxleConfig, bool Exact)
        {
            if (Exact == true) 
            {
                this.bsVehicleDetails.Filter = "AxleConfiguration like '" + AxleConfig + "'";
            }
            else
            {
                this.bsVehicleDetails.Filter = "AxleConfiguration like '" + AxleConfig + "%'";
            }
        }

        private void FilterByTrailers()
        {
            this.bsVehicleDetails.Filter = "IsLeadVehicle = 0";
        }

        private void btnTruck_Click(object sender, EventArgs e)
        {
                this.bsVehicleDetails.Filter = "IsLeadVehicle = 1";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.bsVehicleDetails.Filter = "";
        }
    }
}
