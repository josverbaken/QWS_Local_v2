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
    public partial class BookInExBin : Form
    {
        public BookInExBin()
        {
            InitializeComponent();
        }

        private void BookInExBin_Load(object sender, EventArgs e)
        {
            LoadExBinItems();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ExBinOrdersLoad();
        }

        private void ExBinOrdersLoad()
        {
            this.exBinOrdersTableAdapter.FillBy(this.dsBookIn.ExBinOrders,txtCardCode.Text);
        }

        private void LoadExBinItems()
        {
            string mySiteCode = Properties.Settings.Default.SiteCode;
            taItem.Fill(dsBookIn.Item, mySiteCode);
        }
    }
}
