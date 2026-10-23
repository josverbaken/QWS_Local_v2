using System;
using System.Data;
using System.Data.SqlClient;
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

        private enum OfflineMode
        {
            None,
            CreateNew,
            LinkExisting
        }

        private OfflineMode frmOfflineMode = OfflineMode.None;

        private string myBusinessName;
        public string BusinessName
        {
            get { return myBusinessName; }
        }

        private string myACStatus;
        public string ACStatus
        {
            get { return myACStatus; }
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

        public BusinessSearch(bool SearchOnly, string FromMenu)
        {
            InitializeComponent();
            btnSelect.Visible = SearchOnly;
            this.Text = FromMenu;
        }

        private void BusinessSearch_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            SetOfflineUI();
            string msg = "If data seems old and out of sync with SAP,\r\n";
            msg += "please initiate an update by adding the following comment in SAP B1 and updating:\"Sync to QWS\"";
            txtSAP2QWSsyncAdvice.Text = msg;
            txtSearch.Focus();
        }

        private void btnSearchByCode_Click(object sender, EventArgs e)
        {
            SearchByCode();
        }

        private void SearchByCode()
        {
            try
            {
                dsQWSLocal2024TableAdapters.BusinessTableAdapter taBusiness = new dsQWSLocal2024TableAdapters.BusinessTableAdapter();
                taBusiness.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                int iCount = taBusiness.FillByNameOrCode(dsQWSLocal2024.Business, txtSearch.Text);
                if (SearchCustomerOnly == true)
                {
                    bsBusiness.Filter = "CardType like 'C'"; // 20261023 swap to card type C for customer only search, allows for Offline prefix = T
                }
                if (iCount == 0)
                {
                    string strMsgHeader = "Business not found!";
                    string strMsg = "Press Yes to create Offline account.";
                    DialogResult result = MessageBox.Show(strMsg, strMsgHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        GetOfflineCardCode();
                        frmOfflineMode = OfflineMode.CreateNew;
                        tabControl1.SelectedTab = tpOffline;
                    }
                }
                else
                {
                    DataRow dataRow = ((DataRowView)bsBusiness.Current).Row;
                    dsQWSLocal2024.BusinessRow businessRow = (dsQWSLocal2024.BusinessRow)dataRow;
                    if (businessRow.SAPCode.StartsWith("T"))
                    {
                        frmOfflineMode = OfflineMode.LinkExisting;
                    }
                    else
                    {
                        frmOfflineMode = OfflineMode.None;
                    }
                    ShowDetailsTab();
                }
                SetOfflineUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SearchByCode Error!");
            }
        }

        private void btnSelectBusiness_Click(object sender, EventArgs e)
        {
            if (SetOwnerParams() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
            this.Close();
        }

        private bool SetOwnerParams()
        {
            DataRow dataRow = ((DataRowView)bsBusiness.Current).Row;
            dsQWSLocal2024.BusinessRow businessRow = (dsQWSLocal2024.BusinessRow)dataRow;
            mySAPCode = businessRow.SAPCode;
            myBusinessName = businessRow.TradingName;
            myACStatus = businessRow.AccountStatus;
            //if (businessRow.ACType != "C")
            //{
            //    MessageBox.Show("Unable to proceed card type = " + businessRow.ACType, "Account Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            if (businessRow.AccountStatus == "A")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Warning card status = " + businessRow.AccountStatus, "Account Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
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
            if (SetOwnerParams() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtLinkCode.Text = "C000185";
        }

        private void btnAddOfflineBP_Click(object sender, EventArgs e)
        {
            txtLinkCode.Text = string.Empty;
        }

        private void GetOfflineCardCode()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(QWSConfig.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "OfflineCardCode";
                sqlConnection.Open();
                object queryResult = cmd.ExecuteScalar();
                string myCardCode = queryResult != null ? queryResult.ToString() : "failed!"; // string.Empty;
                sqlConnection.Close();
                txtQWSCardCode.Text = myCardCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetOfflineCardCode Error!");
            }
        }

        private void SetOfflineUI()
        {
            if (frmOfflineMode == OfflineMode.CreateNew)
            {
                lblLinkCode.Visible = false;
                txtLinkCode.Visible = false;
            }
            else if (frmOfflineMode == OfflineMode.LinkExisting)
            {
                lblLinkCode.Visible = true;
                txtLinkCode.Visible = true;
            }
            else
            {
                lblLinkCode.Visible = false;
                txtLinkCode.Visible = false;
            }
        }
    }
}
