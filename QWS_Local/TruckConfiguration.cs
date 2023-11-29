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
        }

        public TruckConfiguration(string Rego, string SAPCode, string Mode)
        {
            InitializeComponent();
            //LoadTruckConfig(Rego, SAPCode);
            // TODO use MODE
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
            //Rego = "ABC123";
            //MessageBox.Show("Loading config for {0}.", Rego);
            MessageBox.Show("Loading config for " + Rego);
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello - blank form, start afresh!");
        }
    }
}
