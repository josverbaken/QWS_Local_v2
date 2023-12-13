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
            TruckConfigurationLoad();
        }

        private void TruckConfigurationLoad()
        {
            try
            {
                this.taVehicle.FillByCardCode(this.dsQWSLocal.Vehicle, myCardCode);
                this.taTruckConfigByOwner.Fill(this.dsTruckConfig.TruckConfigByOwner, myCardCode);
                this.taVehicleDetails.FillBy(this.dsQWSLocal.VehicleDetails, myRego);
                TruckConfigFilterByRego(myRego, true);
                if (CurrentVehicleDetails().IsLeadVehicle)
                {
                    // show trailers
                    this.bsVehicle.Filter = "IsLeadVehicle = 0 and AxleConfiguration not like 'tba'";
                    int iCount = dgvAvailableVehicles.SelectedRows.Count;
                    dgvAvailableVehicles.ClearSelection();
                    iCount = dgvAvailableVehicles.SelectedRows.Count;
                    iCount += 1;
                }
                else
                {
                    // show truck or prime mover
                    this.bsVehicle.Filter = "IsLeadVehicle = 1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form Load Error!");
            }
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

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            FindVehicle(txtRego.Text);
        }

        private void FindVehicle(string Rego)
        {
            VehicleSearch vehicleSearch = new VehicleSearch(Rego, false);
            DialogResult dr1 = vehicleSearch.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                myCardCode = vehicleSearch.CardCode;
                myRego = vehicleSearch.Rego;
                TruckConfigurationLoad();
            }
            else
            {
                txtRego.Focus();
            }
        }


        private void btnAddVehicle2Config_Click(object sender, EventArgs e)
        {
            string msg = "Will add selected vehicles as a new truck config. ";
            //msg += myRego;
            //msg += " ";
            //msg += CurrentVehicle().Rego;
            MessageBox.Show(msg);
            GetNHVLID();
        }

        private void btnShowAllConfig_Click(object sender, EventArgs e)
        {
            TruckConfigFilterByRego(myRego, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TruckConfigFilterByRego(myRego, true);
        }

        private void TruckConfigFilterByRego(string Rego, bool SingleVehicle)
        {
            if (SingleVehicle)
            {
                if (CurrentVehicleDetails().IsLeadVehicle)
                {
                    this.bsTruckConfigByOwner.Filter = "Truck like '" + Rego + "'";
                }
                else
                {
                    this.bsTruckConfigByOwner.Filter = "Trailer like '%" + Rego + "%'";
                }
            }
            else
            {
                this.bsTruckConfigByOwner.Filter = "";
            }
        }

        private dsQWSLocal.VehicleRow CurrentVehicle()
        {
            try
            {

                DataRow myDR = ((DataRowView)bsVehicle.Current).Row;
                dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                return vehicleRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

     
        private void GetNHVLID()
        {
            int NHVLID;
            string AxleConfig;
            if (CurrentVehicleDetails().IsLeadVehicle)
            {
                AxleConfig = CurrentVehicleDetails().AxleConfiguration;
            }
            else
            {
                AxleConfig = CurrentVehicle().AxleConfiguration;
            }
            NHVR_GVM_Search frmSearch = new NHVR_GVM_Search(AxleConfig);
            DialogResult dr = frmSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                NHVLID = NHVR_GVM_Search.NHVLID;
                MessageBox.Show("Got NHVL code :" + NHVLID.ToString());
            }
            else
            {
                MessageBox.Show("NHVL code not available yet.");
            }
        }
    }
}
