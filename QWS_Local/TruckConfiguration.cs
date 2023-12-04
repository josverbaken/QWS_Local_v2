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
            //LoadTruckConfig(Rego);
        }

        private void TruckConfiguration_Load(object sender, EventArgs e)
        {
            this.taVehicle.FillByCardCode(this.dsQWSLocal.Vehicle,myCardCode);
            this.taVehicleDetails.FillBy(this.dsQWSLocal.VehicleDetails,myRego);
        }

        private void LoadTruckConfig(string Rego)
        {
            //Rego = "ABC123";
            //MessageBox.Show("Loading config for {0}.", Rego);
            MessageBox.Show("Loading config for " + Rego );
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello - blank form, start afresh!");
            if (checkBox1.Checked)
            {
                this.bsVehicle.Filter = "IsLeadVehicle = 1";
            }
            else
            {
                this.bsVehicle.Filter = "IsLeadVehicle = 0";
            }
        }
    }
}
