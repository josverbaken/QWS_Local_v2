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
    public partial class PrintDocket : Form
    {
        private int mySiteID;

        public PrintDocket()
        {
            InitializeComponent();
        }

        public PrintDocket(int SiteID)
        {
            InitializeComponent();
            this.mySiteID = SiteID;
        }

        private void PrintDocket_Load(object sender, EventArgs e)
        {
        }

        private void btnGetDocketList_Click(object sender, EventArgs e)
        {
            GetDocketListDTP(dtpDocketList.Value);
        }
        private void GetDocketListDTP(DateTime DocDate)
        {
            try
            {
                dsQWS.DocketList.Clear();
                int iRows = this.taDocketList.FillBy(this.dsQWS.DocketList,DocDate,mySiteID);
                textBox2.Text = iRows.ToString();
                dgvDocketList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetDocketListDTP Error!");
            }
        }

        private void btnGetDocket_Click(object sender, EventArgs e)
        {
            GetDeliveryDocket(System.Convert.ToInt32(txtDocketNo.Text));
        }

        private void GetDeliveryDocket(int DocNum)
        {
            try
            {
                dsDocketReport.Clear();
                int iRows = taDeliveryDocket.Fill(dsDocketReport.DeliveryDocket, DocNum);
                textBox1.Text = iRows.ToString();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetDeliveryDocket ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void PrintPreview()
        {
            try
            {
                int myDocNum;
            if (bsDocketList.Count > 0)
            {
                myDocNum = CurrentDocketList().DocNum;
                GetDeliveryDocket(myDocNum);
                txtDocketNo.Text = myDocNum.ToString();
                tabControl1.SelectedTab = tpDocket;
            }
            else
            {
                MessageBox.Show("No dockets found!\r\nPlease try a different date.");
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsQWSViews.DocketListRow CurrentDocketList()
        {
            try
            {
                if (bsDocketList != null)
                {
                    DataRow myDR = ((DataRowView)bsDocketList.Current).Row;
                    dsQWSViews.DocketListRow docketListRow = (dsQWSViews.DocketListRow)myDR;
                    return docketListRow;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnPrintDocket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still to implement PrintDirect");
        }
    }
}
