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
    public partial class PreferredCustomers : Form
    {
        public PreferredCustomers()
        {
            InitializeComponent();
        }

        public PreferredCustomers(string Rego)
        {
            myRego = Rego;
            InitializeComponent();
        }

        private string myRego; // used in GetPrefCustomers

        private dsQWSLocal.VehiclePrefCustomersRow myCustomersRow;

        public dsQWSLocal.VehiclePrefCustomersRow customersRow
        {
            get { return myCustomersRow; }
        }

        private void GetPrefCustomers()
        {
            try
            {
                this.taVehiclePrefCustomers.FillBy(this.dsQWSLocal.VehiclePrefCustomers, myRego);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PreferredCustomers_Load(object sender, EventArgs e)
        {
            GetPrefCustomers();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ((DataRowView)bsVehiclePrefCustomers.Current).Row;
            myCustomersRow = (dsQWSLocal.VehiclePrefCustomersRow)dataRow;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
