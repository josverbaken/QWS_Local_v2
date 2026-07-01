using System;
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
            dsQWSLocal2024TableAdapters.NHVRTableAdapter taNHVR2 = new dsQWSLocal2024TableAdapters.NHVRTableAdapter();
            taNHVR2.Connection.ConnectionString = QWSConfig.cnQWSLocal;
            taNHVR2.Fill(this.dsQWSLocal2024.NHVR);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsNHVR2.EndEdit();
            dsQWSLocal2024TableAdapters.NHVRTableAdapter taNHVR2 = new dsQWSLocal2024TableAdapters.NHVRTableAdapter();
            taNHVR2.Connection.ConnectionString = QWSConfig.cnQWSLocal;
            taNHVR2.Update(dsQWSLocal2024.NHVR);
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
            if (MassMgmtFilter.Length > 0)
            {
                NHVRFilter += " and " + MassMgmtFilter;
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
