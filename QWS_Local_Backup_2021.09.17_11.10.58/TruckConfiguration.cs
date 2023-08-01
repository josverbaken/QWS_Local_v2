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

        private void TruckConfiguration_Load(object sender, EventArgs e)
        {
            this.truckConfigTrailersTableAdapter.Fill(this.dsQWSLocal.TruckConfigTrailers);
            this.truckConfigTableAdapter.Fill(this.dsQWSLocal.TruckConfig);

        }

        private void tspSaveTruckConfig_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.truckConfigBindingSource.EndEdit();
            truckConfigTableAdapter.Update(dsQWSLocal.TruckConfig);
        }

        private void tspSaveTruckconfigtrailers_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fKVehicleConfigTrailersVehicleConfigBindingSource.EndEdit();
            truckConfigTrailersTableAdapter.Update(dsQWSLocal.TruckConfigTrailers);
        }
    }
}
