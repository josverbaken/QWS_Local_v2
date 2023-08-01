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
    public partial class ItemSearch : Form
    {
        public ItemSearch()
        {
            InitializeComponent();
        }

        private void ItemSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQWSViews.Item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.dsQWSViews.Item);
            this.itemTableAdapter.ExBinnoOrder(this.dsQWSViews.Item,Properties.Settings.Default.SiteCode);
            this.itemBindingSource.Filter = "Active like 'Y'";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // show active items only = default
                this.itemBindingSource.Filter = "Active like 'Y'";
            }
            else if (radioButton3.Checked == true)
            {
                this.itemBindingSource.Filter = "Active like 'Y' and ItmsGrpCod = 138";
            }
            else
            {
                this.itemBindingSource.Filter = "";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // close form and pass selected item
        }
    }
}
