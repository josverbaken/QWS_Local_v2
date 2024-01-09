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
        private static string AxleConfigFilter = "";
        private static int myNHVLID;
        private static dsQWSLocal.NHVLRow myNHVLRow;

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

        public static dsQWSLocal.NHVLRow NHVLRow
        {
            get { return myNHVLRow; }
        }            

        private void NHVR_GVM_Search_Load(object sender, EventArgs e)
        {
            SchemeCodeFilter = "SchemeCode like '%'";
            this.taAxleConfig.Fill(this.dsQWSLocal.AxleConfiguration);
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
            this.taNHVL.FillBy(this.dsQWSLocal.NHVL,AxleConfig);
            AxleConfigFilter = "AxleConfiguration like '" + AxleConfig + "%'";
            bsNHVL.Filter = AxleConfigFilter;
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
                TruckPlustrailerFilter = "len(AxleConfiguration) <= 3";//"Trailers = 0";
                SetAxleConfigFilter();
            }
        }

        private void rbTruckPlusTrailer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTruckPlusTrailer.Checked)
            {
                TruckPlustrailerFilter = "len(AxleConfiguration) > 3";//"Trailers > 0";
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


        private dsQWSLocal.NHVLRow CurrentNHVL()
        {
            DataRow myDR = ((DataRowView)bsNHVL.Current).Row;
            dsQWSLocal.NHVLRow NHVLRow = (dsQWSLocal.NHVLRow)myDR;
            myNHVLRow = NHVLRow;
            return NHVLRow;
        }

        private void bsNHVL_CurrentChanged(object sender, EventArgs e)
        {
            //myNHVLRow = (dsQWSLocal.NHVLRow)bsNHVL.Current;
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
