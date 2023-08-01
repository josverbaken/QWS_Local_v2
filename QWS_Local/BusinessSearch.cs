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
    public partial class BusinessSearch : Form
    {
        private string mySAPCode;
        public string SAPCode
        {
            get { return mySAPCode; }
        }

        private string myBusinessName;
        public string BusinessName
        {
            get { return myBusinessName; }
        }
        public BusinessSearch()
        {
            InitializeComponent();
        }
        public BusinessSearch(string myCode)
        {
            // Initialize with string argument
            InitializeComponent();
            txtSAPCode.Text = myCode;
            SearchByCode();
        }
        private void BusinessSearch_Load(object sender, EventArgs e)
        {
            // nothing at present
            txtSAPCode.Focus();
        }

        private void btnSearchByCode_Click(object sender, EventArgs e)
        {
            SearchByCode();
        }

        private void SearchByCode()
        {
            try
            {
                if (txtSAPCode.Text != "Name or SAP Code")
                {
                   int iCount = this.businessTableAdapter.FillByNameOrCode(this.dsQWSLocal.Business, txtSAPCode.Text);
                   if (iCount > 0)
                    {
                        txtSAPCode.Text = "Name or SAP Code";
                    }
                   iCount += 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               // txtSAPCode.Text = "Name or SAP Code";
            }
        }

        private void btnSelectBusiness_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            SetOwnerParams();
            this.Close();
        }

        private void SetOwnerParams()
        {
            DataRow dataRow = ((DataRowView)businessBindingSource.Current).Row;
            dsQWSLocal.BusinessRow businessRow = (dsQWSLocal.BusinessRow)dataRow;
            mySAPCode = businessRow.SAPCode;
            myBusinessName = businessRow.TradingName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //business not found
            this.DialogResult = DialogResult.Abort; //distinguish from cancel, WBO is saying the BP not found
            this.Close();
        }

        private void txtSAPCode_Enter(object sender, EventArgs e)
        {
            SAPCodeSelectAll();
        }

        private void SAPCodeSelectAll()
        {
            try
            {
                this.txtSAPCode.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSAPCode_Click(object sender, EventArgs e)
        {
            SAPCodeSelectAll();
        }
    }

}
