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
        private static string AxleConfigFilter = "";
        private static string RoadAccessFilter = "";
        private static int myNHVRID;
        private static string AxleConfiguration;
        private static dsQWSLocal.NHVLRow myNHVLRow;

        public NHVR_GVM_Search()
        {
            InitializeComponent();
        }

        public NHVR_GVM_Search(string AxleConfig)
        {
            InitializeComponent();
            AxleConfiguration = AxleConfig;
            LoadAxleConfiguration();
            LoadByAxleConfig(AxleConfiguration);
        }

        public  int NHVRID
        {
            get { return myNHVRID; }
        }

        public static dsQWSLocal.NHVLRow NHVLRow
        {
            get { return myNHVLRow; }
        }            

        private void LoadAxleConfiguration()
        {
            //SchemeCodeFilter = "SchemeCode like '%'";
            this.taAxleConfig.Fill(this.dsQWSLocal.AxleConfiguration);
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
                string myFilter = "AxleConfiguration like '" + AxleConfiguration + "%'";
                if (SchemeCodeFilter.Length > 0) 
                {
                    myFilter += " and ";
                    myFilter += SchemeCodeFilter;
                }

                if (SteerAxleFilter.Length > 0)
                {
                    myFilter += " and ";
                    myFilter += SteerAxleFilter;
                }
                if (RoadAccessFilter.Length > 0)
                {   myFilter += " and ";
                    myFilter += RoadAccessFilter;
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
            myNHVRID = CurrentNHVL().TruckTypeID;
           int myIndex =  bsAxleConfig.Find("AxleConfiguration", CurrentNHVL().AxleConfiguration);
            if (myIndex >=0)
            {
                bsAxleConfig.Position = myIndex;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllRoads.Checked)
            {
                RoadAccessFilter = "RoadAccess like 'All Roads'";
                SetAxleConfigFilter();
            }
            else
            {
                RoadAccessFilter = "";
            }
        }

        private void rbRoadAccessAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRoadAccessAll.Checked)
            {
                RoadAccessFilter = "";
                SetAxleConfigFilter();
            }
        }

        private void rbRoadAccessOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRoadAccessOther.Checked)
            {
                RoadAccessFilter = "RoadAccess not like 'All Roads'";
                SetAxleConfigFilter();
            }
        }
    }
}
