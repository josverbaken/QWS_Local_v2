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
            this.taNHVL.Fill(this.dsQWSLocal.NHVL);
            TruckConfigurationLoad();
        }

        private void TruckConfigurationLoad()
        {
            try
            {
                //int iVehicle = this.taVehicle.FillByCardCode(this.dsQWSLocal.Vehicle, myCardCode);
                this.taConfiguredTnT.Fill(dsTruckConfig.ConfiguredTnT, "", "", myCardCode);
                int iVehicleDetails = this.taVehicleDetails.FillBy(this.dsQWSLocal.VehicleDetails, myRego);
                TruckConfigFilterByRego(myRego, true);
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
                if (bsVehicleDetails.Count > 0)
                {
                DataRow myDR = ((DataRowView)bsVehicleDetails.Current).Row;
                dsQWSLocal.VehicleDetailsRow vehicleRow = (dsQWSLocal.VehicleDetailsRow)myDR;
                return vehicleRow;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            int iRows = taVehicle.FillBy(dsQWSLocal.Vehicle, txtRego.Text);
            if (iRows == 1)
            {
                myRego = dsQWSLocal.Vehicle[0]["Rego"].ToString();
                myCardCode = dsQWSLocal.Vehicle[0]["CardCode"].ToString();
                TruckConfigurationLoad();
            }
            else
            {
                FindVehicle(txtRego.Text);
            }
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
            AddTruckConfig();
        }

        private void AddTruckConfig()
        {
            int myNHVLID;// = GetNHVLRow().TruckTypeID;
            string leadRego;
            string trailerRego;
            dsQWSLocal.NHVLRow myNHVLRow;
            myNHVLRow = GetNHVLRow();
            if (myNHVLRow != null)
            {
                myNHVLID = myNHVLRow.TruckTypeID;
            }

            // add truckconfig using NHVLID


            // add truckconfigvehicle x n
            // where n = 1 for Truck only, 2 for T&T or semitrailer, 3 for B-double and up to 6 for road trains
            if (CurrentVehicleDetails().IsLeadVehicle)
            {
                leadRego = CurrentVehicleDetails().Rego;
                trailerRego = CurrentVehicle().Rego;
            }
            else
            {
                leadRego = CurrentVehicle().Rego;
                trailerRego = CurrentVehicleDetails().Rego;
            }
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
            if (SingleVehicle && bsVehicleDetails.Count > 0)
            {
                if (CurrentVehicleDetails().IsLeadVehicle)
                {
                    this.bsConfiguredTnt.Filter = "RegoTk like '" + Rego + "'";
                }
                else
                {
                    this.bsConfiguredTnt.Filter = "RegoTrailer like '%" + Rego + "%'";
                }
            }
            else
            {
                this.bsConfiguredTnt.Filter = "";
            }
        }

        private dsQWSLocal.VehicleRow CurrentVehicle()
        {
            try
            {
                if (bsVehicle.Count > 0)
                {
                    DataRow myDR = ((DataRowView)bsVehicle.Current).Row;
                    dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
                    return vehicleRow;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

     
        private dsQWSLocal.NHVLRow GetNHVLRow()
        {
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
                dsQWSLocal.NHVLRow myNHVLRow = NHVR_GVM_Search.NHVLRow;
                return myNHVLRow;
            }
            else
            {        
                MessageBox.Show("NHVL row not available!");
                return null;
            }
        }
    }
}
