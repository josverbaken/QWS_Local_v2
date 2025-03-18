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
    public partial class SelectSite: Form
    {
        private int mySiteID;
        public int SiteID
        {
            get { return mySiteID; }
        }

        public SelectSite()
        {
            InitializeComponent();
        }

        private void btnSetSite_Click(object sender, EventArgs e)
        {
            if (rbNQ.Checked)
            {
                mySiteID = 7;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (rbSQ.Checked)
            {
                mySiteID = 2;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must pick a site!");
            }
        }

        private void SelectSite_Load(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            //rbNQ.Checked = false;
            //rbSQ.Checked = false;
            rbDummy.Checked = true;
        }
    }
}
