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
    public partial class NHVR_GVM_Search : Form
    {
        private static int myNHVRID = 0;
        private static string AxleConfiguration;
        private static string MassAccreditationLabel;
        private static dsQWSLocal2024.NHVRRow myNHVRRow;

        public NHVR_GVM_Search()
        {
            InitializeComponent();
        }

        public NHVR_GVM_Search(string AxleConfig, string MassAccreditation)
        {
            InitializeComponent();
            AxleConfiguration = AxleConfig;
            MassAccreditationLabel = MassAccreditation;
        }

        public  int NHVRID
        {
            get { return myNHVRID; }
        }

        public static dsQWSLocal2024.NHVRRow NHVRRow
        {
            get { return myNHVRRow; }
        }

        private void NHVR_GVM_Search_Load(object sender, EventArgs e)
        {
            LoadAxleConfiguration(AxleConfiguration);
            LoadByAxleConfig(AxleConfiguration);
            if (MassAccreditationLabel.Length > 0)
            {
                txtMassMgmtAccred.Text = MassAccreditationLabel;
            }
            else
            {
                txtMassMgmtAccred.Text = "n/a";
            }
        }

        private void LoadAxleConfiguration(string AxleConfig)
        {
            this.taAxleConfiguration.FillByAxleConfig(this.dsQWSLocal2024.AxleConfiguration, AxleConfig);
        }


        private void LoadByAxleConfig(string AxleConfig)
        {
            this.taNHVR.FillByAxleConfig(this.dsQWSLocal2024.NHVR, AxleConfig);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bool ok2continue = CheckSelection();
            if (ok2continue == true)
            {
                myNHVRID = CurrentNHVR().TruckTypeID;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool CheckSelection()
        {
            if (CurrentNHVR().MassMgmtRqd == true && MassAccreditationLabel.Length < 4)
            {
                string msg = "Unable to select as Mass Management Accreditation not recorded against truck!";
                MessageBox.Show(msg,"Accreditation Not Record!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
        private dsQWSLocal2024.NHVRRow CurrentNHVR()
        {
            DataRow myDR = ((DataRowView)bsNHVR.Current).Row;
            dsQWSLocal2024.NHVRRow NHVRRow = (dsQWSLocal2024.NHVRRow)myDR;
            myNHVRRow = NHVRRow;
            return NHVRRow;
        }

    }
}
