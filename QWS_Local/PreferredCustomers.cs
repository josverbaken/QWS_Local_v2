using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QWS_Local.dsQWSLocal2024;

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

        private dsQWSLocal2024.VehiclePrefCustomersRow myCustomersRow;

        public dsQWSLocal2024.VehiclePrefCustomersRow customersRow
        {
            get { return myCustomersRow; }
        }

        private void GetPrefCustomers()
        {
            try
            {
                this.taPrefCustomers2.FillBy(this.dsQWSLocal2024.VehiclePrefCustomers, myRego);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PreferredCustomers_Load(object sender, EventArgs e)
        {
            GetPrefCustomers();
            bsPrefCustomers2.Sort = "IsDefault DESC, PrefCustomer ASC";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ((DataRowView)bsPrefCustomers2.Current).Row;
            myCustomersRow = (dsQWSLocal2024.VehiclePrefCustomersRow)dataRow;
            if (myCustomersRow.Active == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Unable to proceed card not active", "Account Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
            }
            this.Close();
        }

    }
}
