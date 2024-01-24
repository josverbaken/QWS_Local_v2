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
            dsTruckConfig.ConfiguredTnTDataTable myTable = new dsTruckConfig.ConfiguredTnTDataTable();
            myTable.ImportRow(configuredTnTRow);
            myAxleConfig = configuredTnTRow.AxleConfiguration;
            // TODO search project for other use of ImportRow
        }


        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.configuredTnTTableAdapter.Fill(this.dsTruckConfig.ConfiguredTnT, regoToolStripTextBox.Text, ownerToolStripTextBox.Text, cardCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTruckDriver();
        }

        private void GetTruckDriver()
        {
            MessageBox.Show("Getting truck drver for CardCode : " + txtCardCode.Text);
        }

        private void BookInTruck_Load(object sender, EventArgs e)
        {
            txtAxleConfig2.Text = myAxleConfig;
            textBox1.Text = myTruckConfigID.ToString();
        }
    }
}
