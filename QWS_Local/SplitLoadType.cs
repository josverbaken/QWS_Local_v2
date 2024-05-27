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
    public partial class SplitLoadType : Form
    {
        public SplitLoadType()
        {
            InitializeComponent();
        }
        public string LoadType;

        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTnT.Checked)
            { 
                LoadType = "TT";
            }
        }

        private void rbSplitLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSplitLoad.Checked)
            {
                LoadType = "TKs"; // TODO check if B-Double
            }
        }

        private void rbTrailerOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrailerOnly.Checked)
            {
                LoadType = "TRs";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;  
            this.Close();   
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
