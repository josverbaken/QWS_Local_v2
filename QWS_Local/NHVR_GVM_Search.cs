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
        private static string SchemeCodeFilter = "";
        private static string SteerAxleFilter = "";
        private static string TruckPlustrailerFilter = "";
        private static int myNHVLID;
        public NHVR_GVM_Search()
        {
            InitializeComponent();
        }

        public NHVR_GVM_Search(string AxleConfig)
        {
            InitializeComponent();
            LoadByAxleConfig(AxleConfig);
        }

        public static int NHVLID
        {
            get { return myNHVLID; }
        }

        private void NHVR_GVM_Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQWSLocal.AxleConfiguration' table. You can move, or remove it, as needed.
            this.taAxleConfig.Fill(this.dsQWSLocal.AxleConfiguration);
            // TODO: This line of code loads data into the 'dsQWSLocal.NHVR_GVM' table. You can move, or remove it, as needed.
            //int iCount = this.nHVR_GVMTableAdapter.Fill(this.dsQWSLocal.NHVL);
            //iCount += 1;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadByAxleConfig(string AxleConfig)
        {
            this.nHVR_GVMTableAdapter.FillBy(this.dsQWSLocal.NHVL,AxleConfig);
        }
  
         private void SetAxleConfigFilter()
        {
            try
            {
                string myFilter = SchemeCodeFilter;
                if (SteerAxleFilter.Length > 0)
                {
                    myFilter += " and ";
                    myFilter += SteerAxleFilter;
                }
                if (TruckPlustrailerFilter.Length > 0)
                {
                    myFilter += " and ";
                    myFilter += TruckPlustrailerFilter;
                }
                bsNHVL.Filter = myFilter;
                // TODO test filter why just and Trailer
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbSchemeGML_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSchemeGML.Checked)
            {
                SchemeCodeFilter = "SchemeCode like 'GML'";
                SetAxleConfigFilter();
            }
        }

        private void rbSchemeOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSchemeOther.Checked)
            {
                SchemeCodeFilter = "SchemeCode not like 'GML'";
                SetAxleConfigFilter();
            }
        }

        private void rbSchemeAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSchemeAll.Checked)
            {
                SchemeCodeFilter = "SchemeCode like '%'";
                SetAxleConfigFilter();
            }
        }

        private void rbSteer05_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSteer05.Checked)
            {
                SteerAxleFilter = "SteerAxleAllowance = true";
                SetAxleConfigFilter();
            }
        }

        private void rbSteerZero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSteerZero.Checked)
            {
                SteerAxleFilter = "SteerAxleAllowance = false";
                SetAxleConfigFilter();
            }
        }

        private void rbSteerAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSteerAll.Checked)
            {
                SteerAxleFilter = "";
                SetAxleConfigFilter();
            }
        }

        private void rbTruckOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruckOnly.Checked)
            {
                TruckPlustrailerFilter = "Trailers = 0";
                SetAxleConfigFilter();
            }
        }

        private void rbTruckPlusTrailer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruckPlusTrailer.Checked)
            {
                TruckPlustrailerFilter = "Trailers > 0";
                SetAxleConfigFilter();
            }
        }

        private void rbTruckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruckAll.Checked)
            {
                TruckPlustrailerFilter = "";
                SetAxleConfigFilter();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 

            txtAxleConfiguration.Text = CurrentNHVL().AxleConfiguration;
        }


        private dsQWSLocal.NHVLRow CurrentNHVL()
        {
            DataRow myDR = ((DataRowView)bsNHVL.Current).Row;
            dsQWSLocal.NHVLRow NHVLRow = (dsQWSLocal.NHVLRow)myDR;
            return NHVLRow;
        }

        private void bsNHVL_CurrentChanged(object sender, EventArgs e)
        {
            SyncNHVL2AxleConfiguration();
        }

        private void SyncNHVL2AxleConfiguration()
        {
            myNHVLID = CurrentNHVL().TruckTypeID;
           int myIndex =  bsAxleConfig.Find("AxleConfiguration", CurrentNHVL().AxleConfiguration);
            if (myIndex >=0)
            {
                bsAxleConfig.Position = myIndex;
            }
        }
    }
}
