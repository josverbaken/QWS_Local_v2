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
    public partial class BookInTruck : Form
    {
        private int myTruckConfigID;
        private string myAxleConfig;

        public BookInTruck()
        {
            InitializeComponent();
        }

        public BookInTruck(int TruckConfigID)
        {
            myTruckConfigID = TruckConfigID;
            InitializeComponent();
        }

        public BookInTruck (dsTruckConfig.ConfiguredTnTRow configuredTnTRow)
        {
            InitializeComponent();
            dsTruckConfig.ConfiguredTnT.Clear();
            dsTruckConfig.ConfiguredTnT.ImportRow(configuredTnTRow);
            myAxleConfig = configuredTnTRow.AxleConfiguration;
            myTruckConfigID = configuredTnTRow.TruckConfigID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTruckDriver();
        }

        private void GetTruckDriver()
        {
            MessageBox.Show("Getting truck drver for CardCode : " + txtCardCode.Text);
            TruckDriverSearch frmTruckDriverSearch = new TruckDriverSearch(txtCardCode.Text);
            DialogResult dr = frmTruckDriverSearch.ShowDialog();
            if (dr ==DialogResult.OK)
            {
                textBox2.Text = frmTruckDriverSearch.TruckDriverID.ToString();
                textBox3.Text = frmTruckDriverSearch.TruckDriver;
            }
        }

        private void BookInTruck_Load(object sender, EventArgs e)
        {
            txtAxleConfig2.Text = myAxleConfig;
            textBox1.Text = myTruckConfigID.ToString();
        }
    }
}
