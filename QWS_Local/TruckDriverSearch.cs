using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QWS_Local
{
    public partial class TruckDriverSearch : Form
    {
        public TruckDriverSearch()
        {
            InitializeComponent();
        }

        public TruckDriverSearch(string SAPCode)
        {
            InitializeComponent();
            dsQWSLocal2024TableAdapters.TruckDriverTableAdapter taTruckDriver2024 = new dsQWSLocal2024TableAdapters.TruckDriverTableAdapter();
            taTruckDriver2024.Connection.ConnectionString = QWSConfig.cnQWSLocal;
            taTruckDriver2024.FillByCardCode(this.dsQWSLocal2024.TruckDriver, SAPCode);
        }

        private string myDriver;
        private int myDriverID;
        private dsQWSLocal2024.TruckDriverRow myTruckDriver;

        public dsQWSLocal2024.TruckDriverRow TruckDriverRow
        {
            get { return myTruckDriver; }
        }

        public string TruckDriver
        {
            get { return myDriver; }
        }

        public int TruckDriverID
        {
            get { return myDriverID; }
        }

        private void TruckDriverSearch_Load(object sender, EventArgs e)
        {
            bsTruckDriver2024.Sort = "Active DESC, Person ASC";
        }

        private void btnSelectDriver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a driver.");
            }
        }

        private void SetDriver()
        {
            string msg = "";
            DataRow dataRow = ((DataRowView)bsTruckDriver2024.Current).Row;
            QWS_Local.dsQWSLocal2024.TruckDriverRow truckDriverRow = (QWS_Local.dsQWSLocal2024.TruckDriverRow)dataRow;
            myTruckDriver = truckDriverRow;
            myDriver = truckDriverRow.Person;
            myDriverID = truckDriverRow.CntctCode;
            if (truckDriverRow.Active != 'Y'.ToString())
            {
                msg = "Driver status not Active! ";
            }
            if (truckDriverRow.LicenseExp < DateTime.Now)
            {
                msg += "License is expired!";
            }
            txtInfo.Text = msg;
        }

  
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void bsTruckDriver2024_CurrentChanged(object sender, EventArgs e)
        {
            if (bsTruckDriver2024.Count > 0)
            {
                SetDriver();
            }
        }

        private void btnAddOfflineContact_Click(object sender, EventArgs e)
        {
            AddOfflineContact();
        }

        private void btnLinkContact2SAP_Click(object sender, EventArgs e)
        {
            LinkContact2SAP();
        }

        private void LinkContact2SAP()
        {
            try
            {
                int cntctCode = Convert.ToInt32(txtQWSCntctCode.Text);
                int sapCntctCode = Convert.ToInt32(txtSAPCntctCode.Text);
                SqlConnection sqlConnection = new SqlConnection(QWSConfig.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LinkContact2SAP";
                cmd.Parameters.AddWithValue("@QWSCntctCode", cntctCode);
                cmd.Parameters.AddWithValue("@SAPCntctCode", sapCntctCode);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Link2SAP Error!");
            }
        }
        

        private void AddOfflineContact()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(QWSConfig.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "OfflineContactAdd";
                cmd.Parameters.AddWithValue("@CntctCode", txtQWSCntctCode.Text);
                cmd.Parameters.AddWithValue("@CardCode", txtCardCode.Text);
                cmd.Parameters.AddWithValue("@Name", txtPerson.Text);
                cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                cmd.Parameters.AddWithValue("@Tel1", "tba");
                cmd.Parameters.AddWithValue("@Cellolar", txtMobile.Text);
                cmd.Parameters.AddWithValue("@E_MailL", "tba");
                cmd.Parameters.AddWithValue("@LicenseType", txtLicenseType.Text);
                cmd.Parameters.AddWithValue("@LicenseExp", txtLicenseExp.Text);
                cmd.Parameters.AddWithValue("@InductionExp", txtInductionExp.Text);
                cmd.Parameters.AddWithValue("@Active", true);
                cmd.Parameters.AddWithValue("@SAPUpdateDTTM", DateTime.Now);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddOfflineContact Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
