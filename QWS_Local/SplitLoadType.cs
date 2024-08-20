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

        public SplitLoadType(string myAxleConfig)
        {
            InitializeComponent();
            AxleConfig = myAxleConfig;
        }

        private string AxleConfig;

        private enum LoadType
        {
            TK,
            TT,
            TKs,
            TRs,
            ST,
            BD,
            BDa,
            BDb,
            AD,
            ADa,
            ADb
        }

        private LoadType formLoadType;

        public string strSplitLoadType
        {
            get { return formLoadType.ToString(); }
        }

        // TODO check if B-Double
        private void rbTnT_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTnT.Checked)
            {
                if (AxleConfig.IndexOf("R") > 0)
                {
                    formLoadType = LoadType.TT; 
                }
                else
                {
                    formLoadType= LoadType.BD;
                }
            }
        }

        private void rbSplitLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSplitLoad.Checked)
            {
                if (AxleConfig.IndexOf("R") > 0)
                {
                    formLoadType = LoadType.TKs;
                }
                else
                {
                    formLoadType = LoadType.BDa;
                }
            }
        }

        private void rbTrailerOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrailerOnly.Checked)
            {
                if (AxleConfig.IndexOf("R") > 0)
                {
                    formLoadType = LoadType.TRs;
                }
                else
                {
                    formLoadType = LoadType.BDb;
                }
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
