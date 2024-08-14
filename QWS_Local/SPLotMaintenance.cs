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
    public partial class SPLotMaintenance : Form
    {
        public SPLotMaintenance()
        {
            InitializeComponent();
        }

        private void SPLotMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTIQ2.StockpileLotAllocation' table. You can move, or remove it, as needed.
            this.stockpileLotAllocationTableAdapter.Fill(this.dsTIQ2.StockpileLotAllocation);

        }
    }
}
