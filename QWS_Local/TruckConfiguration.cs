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
        private string myTrailerRego;
        private string myCardCode;
        private static bool blOK2BookIn = true;
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
                int iCount = this.taConfiguredTnT.Fill(dsTruckConfig.ConfiguredTnT, "", "", myCardCode);
                int iVehicleDetails = this.taVehicleDetails.FillBy(this.dsQWSLocal.VehicleDetails, myRego);
                TruckConfigFilterByRego(myRego, true);
                //if (iCount > 0)
                //{
                //DataRow myDR = ((DataRowView)bsConfiguredTnt.Current).Row;
                //dsTruckConfig.ConfiguredTnTRow truckConfigRow = (dsTruckConfig.ConfiguredTnTRow)myDR;
                //if (truckConfigRow.CardStatus == "A")
                //{
                //    txtCardStatus.BackColor = Color.PaleGreen;
                //}
                //else
                //{
                //    txtCardStatus.BackColor = Color.Salmon;
                //    blOK2BookIn = false;
                //}
                //if (truckConfigRow.GroupCode == 117)
                //{
                //    chkACC.Checked = true;
                //}
                //else
                //{ 
                //    chkACC.Checked = false;
                //}
                //}
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
            int iRows = taVehicleDetails.FillBy(dsQWSLocal.VehicleDetails, txtRego.Text);
            if (iRows == 1)
            {
                myRego = dsQWSLocal.VehicleDetails[0]["Rego"].ToString();
                myCardCode = dsQWSLocal.VehicleDetails[0]["CardCode"].ToString();
                if (System.Convert.ToBoolean(dsQWSLocal.VehicleDetails[0]["IsLeadVehicle"]) == false)
                {
                    myTrailerRego = myRego;
                    //FindVehicle(myCardCode, true);
                }

                TruckConfigurationLoad();
            }
            else
            {
                FindVehicle(txtRego.Text, false);
            }
        }

        private void FindVehicle(string Rego, bool isCardCode)
        {
            VehicleSearch vehicleSearch = new VehicleSearch(Rego, isCardCode);
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
            int myNHVLID;
            string leadRego;
            dsQWSLocal.NHVLRow myNHVLRow;

            // add truckconfigvehicle x n
            // where n = 1 for Truck only, 2 for T&T or semitrailer, 3 for B-double and up to 6 for road trains
            if (CurrentVehicleDetails().IsLeadVehicle)
            {
                leadRego = CurrentVehicleDetails().Rego;
                myNHVLRow = GetNHVLRow(CurrentVehicleDetails().AxleConfiguration);
                if (myNHVLRow != null)
                {
                    myNHVLID = myNHVLRow.TruckTypeID;
                    this.taNHVLDetails.FillByTruckTypeID(this.dsTruckConfig.NHVLDetails, myNHVLID);
                    //MessageBox.Show("NHVL ID chosen is :" + myNHVLID.ToString());
                }
                else
                {
                    MessageBox.Show("NHVL type code not chosen!");
                }
            }
            else
            {
                myTrailerRego = CurrentVehicleDetails().Rego;
                MessageBox.Show("Please find Truck!");
                FindVehicle(CurrentVehicleDetails().CardCode, true); // TODO fix search by CardCode
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

        //private dsQWSLocal.VehicleRow CurrentVehicle()
        //{
        //    try
        //    {
        //        if (bsVehicle.Count > 0)
        //        {
        //            DataRow myDR = ((DataRowView)bsVehicle.Current).Row;
        //            dsQWSLocal.VehicleRow vehicleRow = (dsQWSLocal.VehicleRow)myDR;
        //            return vehicleRow;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}

     
        private dsQWSLocal.NHVLRow GetNHVLRow(string AxleConfigTruck)
        {    
            NHVR_GVM_Search frmSearch = new NHVR_GVM_Search(AxleConfigTruck);
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

        private void btnBookIn_Click(object sender, EventArgs e)
        {
            BookInSelection();
        }

        private void BookInSelection()
        {
            try
            {
                if (blOK2BookIn == true)
                {
                    DataRow myDR = ((DataRowView)bsConfiguredTnt.Current).Row;
                    dsTruckConfig.ConfiguredTnTRow truckConfigRow = (dsTruckConfig.ConfiguredTnTRow)myDR;
                    BookInTruck frmBookInTruck = new BookInTruck(truckConfigRow);
                    frmBookInTruck.MdiParent = this.MdiParent;
                    frmBookInTruck.Show();
                }
                else
                {
                    MessageBox.Show("Cannot proceed, note truck owner not Active!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
