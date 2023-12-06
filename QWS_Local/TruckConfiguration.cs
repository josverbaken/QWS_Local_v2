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
    public partial class TruckConfiguration : Form
    {
        private string myRego;
        private string myCardCode;
        public TruckConfiguration()
        {
            InitializeComponent();
        }

        public TruckConfiguration(string Rego, string CardCode)
        {
            InitializeComponent();
            myRego = Rego;
            myCardCode = CardCode;
        }

        private void TruckConfiguration_Load(object sender, EventArgs e)
        {
            this.taVehicle.FillByCardCode(this.dsQWSLocal.Vehicle,myCardCode);
            this.taVehicleDetails.FillBy(this.dsQWSLocal.VehicleDetails,myRego);
            LoadTruckConfigVehicleList(myRego);
            if (CurrentVehicleDetails().IsLeadVehicle)
            {
                // show trailers
                this.bsVehicle.Filter = "IsLeadVehicle = 0 and AxleConfiguration not like 'tba'";
            }
            else
            {
                // show truck or prime mover
                this.bsVehicle.Filter = "IsLeadVehicle = 1";
            }
        }

        private void LoadTruckConfigVehicleList(string Rego)
        {
            this.taTruckConfigVehicleList.Fill(dsTruckConfig.TruckConfigVehicleList, Rego);
        }

        private dsQWSLocal.VehicleDetailsRow CurrentVehicleDetails()
        {
            try
            {

                DataRow myDR = ((DataRowView)bsVehicleDetails.Current).Row;
                dsQWSLocal.VehicleDetailsRow vehicleRow = (dsQWSLocal.VehicleDetailsRow)myDR;
                return vehicleRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void LoadTruckConfigDetails(int TruckConfigID)
        {
            try
            {
                this.taTruckConfigDetails.Fill(this.dsTruckConfig.TruckConfigDetails, TruckConfigID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To find vehicle with rego :" + txtRego.Text);
        }

        private void bsTruckConfigVehicleList_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (bsTruckConfigVehicleList.Count > 0)
                {
                    int myTruckConfigID = CurrentVehicleDetailsList().TruckConfigID;

                    LoadTruckConfigDetails(myTruckConfigID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Current Changed Error");
            }
        }

        private dsTruckConfig.TruckConfigVehicleListRow CurrentVehicleDetailsList()
        {
            try
            {

                DataRow myDR = ((DataRowView)bsTruckConfigVehicleList.Current).Row;
                dsTruckConfig.TruckConfigVehicleListRow vehicleRow = (dsTruckConfig.TruckConfigVehicleListRow)myDR;
                return vehicleRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnAddVehicle2Config_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will add selected vehicle as new truck config.");
        }

        private void btnShowAllConfig_Click(object sender, EventArgs e)
        {
            this.taTruckConfigVehicleList.FillBy(dsTruckConfig.TruckConfigVehicleList, myCardCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.taTruckConfigVehicleList.Fill(dsTruckConfig.TruckConfigVehicleList, myRego);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
