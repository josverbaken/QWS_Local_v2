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
    public partial class NHVR_GVM : Form
    {
        private string NHVRFilter = "";
        private string GMLFilter = "";
        private string SteerAxleFilter = "";
        private string MassMgmtFilter = "";

        public NHVR_GVM()
        {
            InitializeComponent();
        }

        private void NHVR_GVM_Load(object sender, EventArgs e)
        {
            this.taNHVR2.Fill(this.dsQWSLocal2024.NHVR);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsNHVR2.EndEdit();
            this.taNHVR2.Update(this.dsQWSLocal2024.NHVR);
        }

        private void rbClear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClear.Checked)
            {
                bsNHVR2.Filter = "";
                //ApplyNHVRFilter();  
            }
        }

        private void rbGML_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGML.Checked)
            {
                GMLFilter = "SchemeCode like 'GML'";
                ApplyNHVRFilter();
            }
            else
            {
                GMLFilter = "";
            }

        }

        private void ApplyNHVRFilter()
        {
            string axleconfig = txtAxleConfig.Text;
            NHVRFilter = "AxleConfiguration like '";
            NHVRFilter += axleconfig + "%'";
            if (GMLFilter.Length > 0)
            {
                NHVRFilter += " and " + GMLFilter;
            }
            if (SteerAxleFilter.Length > 0)
            {
                NHVRFilter += " and " + SteerAxleFilter;
            }
            if(MassMgmtFilter.Length > 0)
            {
                NHVRFilter+= " and " + MassMgmtFilter;
            }
            bsNHVR2.Filter = NHVRFilter;
        }

            private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyNHVRFilter();
        }

        private void rbSteer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSteer.Checked)
            {
                SteerAxleFilter = "SteerAxleAllowance = 1";
                ApplyNHVRFilter();
            }
            else
            {
                SteerAxleFilter = "";
            }
        }

        private void rbMassMgmt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMassMgmt.Checked)
            {
                MassMgmtFilter = "MassMgmtRqd = 1";
                ApplyNHVRFilter();
            }
            else
            {
                MassMgmtFilter = "";
            }
        }
    }
}
