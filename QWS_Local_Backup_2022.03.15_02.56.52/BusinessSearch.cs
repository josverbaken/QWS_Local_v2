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
            MessageBox.Show(myCode);
        }
        private void BusinessSearch_Load(object sender, EventArgs e)
        {
            // nothing at present
        }

        private void btnSearchByCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSAPCode.Text != "Name or SAP Code")
                {
                    this.businessTableAdapter.FillByNameOrCode(this.dsQWSLocal.Business, txtSAPCode.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtSAPCode.Text = "Name or SAP Code";
            }
        }

        private void btnSelectBusiness_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void businessBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (businessBindingSource.Current != null)
            {
                mySAPCode = "xyz";
                DataRow dataRow = ((DataRowView)businessBindingSource.Current).Row;
                dsQWSLocal.BusinessRow businessRow = (dsQWSLocal.BusinessRow)dataRow;
                mySAPCode = businessRow.SAPCode;
                myBusinessName = businessRow.TradingName;
                    BusinessPartner businessPartner = new BusinessPartner();
                    businessPartner.SAPCode = mySAPCode;
                    businessPartner.BusinessName = myBusinessName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Binding source positon changed error!");
                throw;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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
