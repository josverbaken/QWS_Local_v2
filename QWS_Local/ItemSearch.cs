﻿using System;
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
            this.taItem.ExBinnoOrder(this.dsQWSViews.Item,Properties.Settings.Default.SiteCode);
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
            else if (radioButton3.Checked == true)
            {
                this.bsItem.Filter = "Active like 'Y' and ItmsGrpCod = 138";
            }
            else
            {
                this.bsItem.Filter = "";
            }
            if (blExBinNoOrder)
            {
                this.bsItem.Filter += " and ExBinNoOrder = 'Y'";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ((DataRowView)bsItem.Current).Row;
            dsQWSViews.ItemRow itemRow = (dsQWSViews.ItemRow)dataRow;
            ItemRow = itemRow;
            this.DialogResult = DialogResult.OK;
            this.Close();   
        }
    }
}
