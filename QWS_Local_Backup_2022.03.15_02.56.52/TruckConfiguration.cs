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
        public TruckConfiguration()
        {
            InitializeComponent();
        }

        public TruckConfiguration(string Truck, string Trailer, string SAPCode, string Mode)
        {
            InitializeComponent();
            //LoadTruckConfig(Rego, SAPCode);
            // TODO use MODE
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
        public TruckConfiguration(string Rego, string SAPCode)
        {
            InitializeComponent();
            LoadTruckConfig(Rego, SAPCode);
        }

        private void TruckConfiguration_Load(object sender, EventArgs e)
        {
            // nothing yet
        }



        private void LoadTruckConfig(string Rego, string SAPCode)
        {
            this.truckConfigTableAdapter.FillBy(this.dsQWSLocal.TruckConfig,Rego);
            this.truckConfigTrailersTableAdapter.FillBy(this.dsQWSLocal.TruckConfigTrailers, SAPCode);
            this.vehicleDetailsTableAdapter.FillBy(this.dsQWSLocal.VehicleDetails,Rego);
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
            this.Validate();
            this.fKVehicleConfigTrailersVehicleConfigBindingSource.EndEdit();
            truckConfigTrailersTableAdapter.Update(dsQWSLocal.TruckConfigTrailers);
        }
    }
}
