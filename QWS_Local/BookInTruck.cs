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
        public BookInTruck()
        {
            InitializeComponent();
        }

        public BookInTruck(int TruckConfigID)
        {
            InitializeComponent();
            textBox1.Text = TruckConfigID.ToString();
        }

        public BookInTruck (dsTruckConfig.ConfiguredTnTRow configuredTnTRow)
        {
            InitializeComponent();
            dsTruckConfig.ConfiguredTnTDataTable myTable = new dsTruckConfig.ConfiguredTnTDataTable();
            myTable.ImportRow(configuredTnTRow);
            textBox2.Text = configuredTnTRow.AxleConfiguration;
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
    }
}
