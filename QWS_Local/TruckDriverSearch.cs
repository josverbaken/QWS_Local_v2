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
    public partial class TruckDriverSearch : Form
    {
        public TruckDriverSearch()
        {
            InitializeComponent();
        }

        public TruckDriverSearch(string SAPCode)
        {
            InitializeComponent();
            this.taTruckDriver2024.FillByCardCode(this.dsQWSLocal2024.TruckDriver,SAPCode);
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
            btnSelectDriver.Enabled = false;
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
            btnSelectDriver.Enabled = true;
            if (truckDriverRow.Active != 'Y'.ToString())
            {
                msg = "Driver status not Active! ";
                //btnSelectDriver.Enabled = false;
            }
            if (truckDriverRow.LicenseExp < DateTime.Now)
            {
                msg += "License is expired!";
                //btnSelectDriver.Enabled = false;
            }
            txtInfo.Text = msg;
        }

        private void Search4Driver(string SAPCode) //actual drivers for BP code
        {
            this.taTruckDriver2024.FillByCardCode(this.dsQWSLocal2024.TruckDriver, SAPCode);
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
    }
}
