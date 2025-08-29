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
        private bool SearchCustomerOnly = false;
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
        public BusinessSearch(bool CustomerOnly)
        {
            InitializeComponent();
            SearchCustomerOnly = CustomerOnly;
        }
        public BusinessSearch(string myCode)
        {
            // Initialize with string argument
            InitializeComponent();
            txtSearch.Text = myCode;
            SearchByCode();
        }
        private void BusinessSearch_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            btnSearch.Focus();
        }

        private void btnSearchByCode_Click(object sender, EventArgs e)
        {
            SearchByCode();
        }

        private void SearchByCode()
        {
            try
            {
                int iCount = this.taBusiness.FillByNameOrCode(this.dsQWSLocal2024.Business, txtSearch.Text);
                if (SearchCustomerOnly == true)
                {
                    bsBusiness.Filter = "SAPCode like 'C%'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            DataRow dataRow = ((DataRowView)bsBusiness.Current).Row;
            dsQWSLocal2024.BusinessRow businessRow = (dsQWSLocal2024.BusinessRow)dataRow;
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

   
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchByCode();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            SetOwnerParams();
            this.Close();
        }
   
        private void btnInfo_Click(object sender, EventArgs e)
        {
            ShowDetailsTab();
        }

        private void ShowDetailsTab()
        {
            tabControl1.SelectedTab = tpDetails;
        }

        private void BusinessSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SearchByCode();
            }
        }
    }

}
