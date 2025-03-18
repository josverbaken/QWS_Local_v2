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

        public ItemSearch(bool ExBinNoOrder)
        {
            InitializeComponent();
            blExBinNoOrder = ExBinNoOrder;
        }

        private bool blExBinNoOrder = false;

        private dsQWSViews.ItemRow ItemRow;

        public dsQWSViews.ItemRow myItem
        {
            get { return ItemRow; }
        }

        private void ItemSearch_Load(object sender, EventArgs e)
        {
            var parent = this.MdiParent as QWS_MDIParent;
            string SiteCode = "0" + parent.SiteID.ToString();
            this.taItem.ExBinnoOrder(this.dsQWSViews.Item,SiteCode);
            this.bsItem.Filter = "Active like 'Y'";
            if (blExBinNoOrder)
            {
                this.bsItem.Filter += " and ExBinNoOrder = 'Y'";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // show active items only = default
                this.bsItem.Filter = "Active like 'Y'";
            }          
            if (blExBinNoOrder)
            {
                this.bsItem.Filter += " and ExBinNoOrder = 'Y'";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            AcceptSelect();
        }

        private void AcceptSelect()
        {
            DataRow dataRow = ((DataRowView)bsItem.Current).Row;
            dsQWSViews.ItemRow itemRow = (dsQWSViews.ItemRow)dataRow;
            ItemRow = itemRow;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                AcceptSelect();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                this.bsItem.Filter = "Active like 'Y' and ItmsGrpCod = 138";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.bsItem.Filter = "";
            }
        }
    }
}
