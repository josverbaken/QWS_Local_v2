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
        private string mySAPCode;
        public string SAPCode
        {
            get { return mySAPCode; }
        }
        public TruckConfiguration()
        {
            InitializeComponent();
        }

        public TruckConfiguration(string Truck, string Trailer, string SAPCode, string Mode)
        {
            InitializeComponent();
            //LoadTruckConfig(Rego, SAPCode);
            // TODO use MODE
            string TruckOwnerCode = SAPCode;
            string myMode = Mode;
            tabControl1.SelectedTab = tabPage2;
            label1.Text = "Called by truck " + Truck + " with trailer " + Trailer + ", will try to add automatically";
        }

        public TruckConfiguration(string Rego, string SAPCode, string Mode)
        {
            InitializeComponent();
            //LoadTruckConfig(Rego, SAPCode);
            // TODO use MODE
            tabControl1.SelectedTab = tabPage2;
            label1.Text = "called by trailer " + Rego +", please available trucks";
        }
        public TruckConfiguration(string Rego)
        {
            InitializeComponent();
            LoadTruckConfig(Rego);
        }

        private void TruckConfiguration_Load(object sender, EventArgs e)
        {
            // nothing yet
        }



        private void LoadTruckConfig(string Rego)
        {
            try
            {
                int iCount = this.vehicleDetailsTableAdapter.FillBy(this.dsQWSLocal.VehicleDetails, Rego);
                // if type truck
                if (iCount == 1)
                {
                    dsQWSLocal.VehicleDetailsRow vehicleDetailsRow = (dsQWSLocal.VehicleDetailsRow)dsQWSLocal.VehicleDetails.Rows[0];
                    if (vehicleDetailsRow.VehicleType == "Truck")
                    {
                        this.truckConfigTableAdapter.FillBy(this.dsQWSLocal.TruckConfig, Rego);
                        string SAPCode = vehicleDetailsRow.SAPCode; // TODO - I think this okay but otherwise reload TruckConfigTrailers on binding source changed
                        this.truckConfigTrailersTableAdapter.FillBy(this.dsQWSLocal.TruckConfigTrailers, SAPCode);
                    }
                    // else trailer ? what TODO
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Truck config Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tspSaveTruckConfig_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.truckConfigBindingSource.EndEdit();    
                truckConfigTableAdapter.Update(dsQWSLocal.TruckConfig); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tspSaveTruckconfigtrailers_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.fKVehicleConfigTrailersVehicleConfigBindingSource.EndEdit();
                truckConfigTrailersTableAdapter.Update(dsQWSLocal.TruckConfigTrailers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Trailer Config Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindVehicleDetails_Click(object sender, EventArgs e)
        {
            FindVehicleDetails();
        }

        private void FindVehicleDetails()
        {
            try
            {
                vehicleDetailsTableAdapter.FillBy(dsQWSLocal.VehicleDetails, txtRego.Text);
                dsQWSLocal.VehicleDetailsRow vehicleDetailsRow = (dsQWSLocal.VehicleDetailsRow)dsQWSLocal.VehicleDetails.Rows[0];
                mySAPCode = vehicleDetailsRow.SAPCode;
                if(vehicleDetailsRow.VehicleType == "Trailer")
                {
                    btnFindNHVR_GVM.Enabled = false;
                }
                else
                {
                    btnFindNHVR_GVM.Enabled = true;
                }
                CheckPBS();
                ConfiguredTnT();
                //PBSTruckConfig();
                //TruckTrailerConfigNotPBS();
                // maybe only if PBS? - doesn't matter zero rows if not PBS
                int iCount = pBSTrailers4TruckTableAdapter.Fill(dsQWSLocal.PBSTrailers4Truck, txtRego.Text);
                if (iCount > 0)
                {
                    btnAddTrailer.Visible = false;
                }
                else
                {
                    btnAddTrailer.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewColumns()
        {
            try
            {
                dataGridView5.Columns["GVMTruck"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfiguredTnT()
        {
            try
            {
                int iRows = configuredTnTTableAdapter.Fill(dsQWSLocal.ConfiguredTnT, txtRego.Text,"");
                if (iRows > 0)
                {
                    //schematicPictureBox.DataBindings.Clear();
                    //schematicPictureBox.DataBindings.Add(configuredTnTBindingSource.DataSource());
                    schematicPictureBox.Visible = false;
                    pictureBox1.Visible = true;
                }
                else
                {
                    schematicPictureBox.Visible = true;
                    pictureBox1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TruckTrailerConfigNotPBS()
        {
            tkTrConfigNotPBSTableAdapter.Fill(dsQWSLocal.TkTrConfigNotPBS, txtRego.Text);
        }

        private void PBSTruckConfig()
        {
            try
            {
                pBSTruckConfigTableAdapter.Fill(dsQWSLocal.PBSTruckConfig, txtRego.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckPBS()
        {
            try
            {
                int myCount;
                checkPBSbyRegoTableAdapter.Fill(dsQWSLocal.CheckPBSbyRego, txtRego.Text);
                myCount = checkPBSbyRegoBindingSource.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadVehicles(string SAPCode)
        {
            try
            {
                int iCount = vehicleDetailsTableAdapter.FillBySAPCode(dsQWSLocal.VehicleDetails, SAPCode);
                iCount += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchNHVR_GVM();
        }

        private void SearchNHVR_GVM()
        {
            try
            {
                NHVR_GVM_Search _Search = new NHVR_GVM_Search(txtAxleConfig.Text);
                DialogResult dr = _Search.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    MessageBox.Show("Search Cancelled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadDetails_Click(object sender, EventArgs e)
        {
            if (mySAPCode.Length > 0)
            {
                LoadVehicles(mySAPCode);
            }
        }

        private void btnAddTrailer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO - take to Vehicle Maintenance");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTruckConfig(txtRego.Text);
            
        }
    }
}
