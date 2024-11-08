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

        private void GetDocketList()
        {
            try
            {
                this.docketListTableAdapter.Fill(this.dsQWS.DocketList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetDocketList Error!");
            }
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
                int iRows = this.docketListTableAdapter.FillBy(this.dsQWS.DocketList,DocDate);
                iRows += 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetDocketListDTP Error!");
            }
        }

        private void btnRefreshDockets_Click(object sender, EventArgs e)
        {
            GetDocketList();
        }

        private void btnGetDocket_Click(object sender, EventArgs e)
        {
            GetDeliveryDocket(System.Convert.ToInt32(txtDocketNo.Text));
        }

        private void GetDeliveryDocket(int DocNum)
        {
            try
            {
                taDeliveryDocketRpt.Fill(dsDocketReport.DeliveryDocketRpt, DocNum);
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
            int myDocNum = 5500109;
            myDocNum = CurrentDocketList().DocNum;
            GetDeliveryDocket(myDocNum);
            txtDocketNo.Text =  myDocNum.ToString();
            tabControl1.SelectedTab = tpDocket;
        }

        private dsQWSViews.DocketListRow CurrentDocketList()
        {
            try
            {
                DataRow myDR = ((DataRowView)bsDocketList.Current).Row;
                dsQWSViews.DocketListRow docketListRow = (dsQWSViews.DocketListRow)myDR;
                return docketListRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
