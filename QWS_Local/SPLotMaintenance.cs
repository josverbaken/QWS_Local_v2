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
            // TODO: This line of code loads data into the 'dsTIQ2.StockpileBOM' table. You can move, or remove it, as needed.
            this.taStockpileBOM.Fill(this.dsTIQ2.StockpileBOM);
            // TODO: This line of code loads data into the 'dsTIQ2.StockpileLotAllocation' table. You can move, or remove it, as needed.
            this.taStockpileLotAllocation.Fill(this.dsTIQ2.StockpileLotAllocation);

        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            FindLotsByItemCode();
        }

        private void FindLotsByItemCode()
        {
            try
            {
                taStockpileLotAllocation.FillByItemCode(dsTIQ2.StockpileLotAllocation, txtItemCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

           private void button1_Click(object sender, EventArgs e)
        {
            ShowBOM4ItemCode();
        }

        private void ShowBOM4ItemCode()
        {
            try
            {
                taStockpileBOM.FillByItemCode(dsTIQ2.StockpileBOM, txtItemCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
