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
            this.taTruckDriver.FillByCardCode(this.dsQWSLocal.TruckDriver,SAPCode);
        }

        private string myDriver;
        private int myDriverID;
        private dsQWSLocal.TruckDriverRow myTruckDriver;

        public dsQWSLocal.TruckDriverRow TruckDriverRow
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
            //dataGridView1.ClearSelection();
            bsTruckDriver.Sort = "Active DESC, Person ASC";
        }

     
        private void btnSelectDriver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {


                if (SetDriver())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a driver.");
            }
        }

        private bool SetDriver()
        {
            bool blDriverOK = true;
            DataRow dataRow = ((DataRowView)bsTruckDriver.Current).Row;
           QWS_Local.dsQWSLocal.TruckDriverRow truckDriverRow = (QWS_Local.dsQWSLocal.TruckDriverRow)dataRow;
            myTruckDriver = truckDriverRow;
            myDriver = truckDriverRow.Person;
            myDriverID = truckDriverRow.CntctCode;
            //if (truckDriverRow.LicenseExp < DateTime.Now)
            //{
            //    DialogResult dr = MessageBox.Show("License has expired, cannot proceed!","License Expiry Date Check",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            //    if (dr == DialogResult.Cancel)
            //    {
            //        blDriverOK = false;
            //    }
            //}
            //if (truckDriverRow.InductionExp < DateTime.Now)
            //{
            //    DialogResult dr = MessageBox.Show("Induction expired, cannot [proceed!", "Induction Expiry Date Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    if (dr == DialogResult.Cancel)
            //    {
            //        blDriverOK = false;
            //    }
            //}
            if (truckDriverRow.Active != 'Y'.ToString())
            {
                DialogResult dr = MessageBox.Show("Driver status not Active!", "Driver Status Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    blDriverOK = false;
            }
            return blDriverOK;

        }

 

        private void Search4Driver(string SAPCode) //actual drivers for BP code
        {
            this.taTruckDriver.FillByCardCode(this.dsQWSLocal.TruckDriver, SAPCode);

        }

    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
