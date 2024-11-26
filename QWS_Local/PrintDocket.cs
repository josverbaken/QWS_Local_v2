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
        public PrintDocket()
        {
            InitializeComponent();
        }

        private void PrintDocket_Load(object sender, EventArgs e)
        {            
            //GetDocketList();
            //this.reportViewer1.RefreshReport();
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
                int iRows = this.taDocketList.FillBy(this.dsQWS.DocketList,DocDate);
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
                //int iRows = taDeliveryDocketRpt.Fill(dsDocketReport.DeliveryDocketRpt, DocNum);
                int iRowLines = deliveryDocketLinesTableAdapter.Fill(this.dsDocketReport.DeliveryDocketLines,DocNum);
                int iRows = taDeliveryDocket.Fill(dsDocketReport.DeliveryDocket, DocNum);
                textBox1.Text = iRows.ToString() + " " + iRowLines.ToString();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void PrintPreview()
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
    }
}
