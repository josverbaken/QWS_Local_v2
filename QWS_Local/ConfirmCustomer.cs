using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QWS_Local
{
    public partial class ConfirmCustomer : Form
    {
        private string Rego;
        private int DriverID;
        private string CardCode;
        private string Customer;

        public ConfirmCustomer()
        {
            InitializeComponent();
        }

        public ConfirmCustomer(string myRego, int myDriverID, string myCardCode, string myCustomer)
        {
            Rego = myRego;
            DriverID = myDriverID;
            CardCode = myCardCode;
            Customer = myCustomer;
            InitializeComponent();
        }
        private void btnNotOkay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }

        private void btnOkayOnce_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();   
        }

        private void btnOkayAlways_Click(object sender, EventArgs e)
        {
            if (AddPrefCustomer() == false)
            {
                MessageBox.Show("Unable to add preferred customer!");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void ConfirmCustomer_Load(object sender, EventArgs e)
        {
            int iRows = this.taPerson.FillByCardCode(this.dsQWSLocal2024.Person, CardCode);
            if (iRows == 0)
            {
                MessageBox.Show("No contact persons on files for selected customer!");
            }
            else if (iRows > 1)            
            {
                bsPerson.Filter = "Person like 'xcvbn'"; // don't want to display first record
                txtPerson.Text = "* multiple found *";
            }
            this.taDriver.FillByID(this.dsQWSLocal2024.TruckDriver, DriverID);
            txtRego.Text = Rego;
            txtCustomer.Text = Customer;
            txtCardCode.Text = CardCode;    
        }

        private void btnSeachPerson_Click(object sender, EventArgs e)
        {
            //if (bsPerson.)
            //{
                bsPerson.Filter = "Person like '%" + txtPerson.Text + "%'";
            //}

        }

        private bool AddPrefCustomer()
        {
            try
            {
                int iQuery = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TruckPrefCustomerAdd";
                cmd.Parameters.AddWithValue("Rego", Rego);
                cmd.Parameters.AddWithValue("CardCode", CardCode);
                cmd.Parameters.AddWithValue("Comment", "added by form ConfirmCustomer.");
                sqlConnection.Open();
                iQuery = System.Convert.ToInt32(cmd.ExecuteNonQuery());
                sqlConnection.Close();
                if (iQuery > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void txtPerson_Enter(object sender, EventArgs e)
        {
            txtPerson.SelectAll();
        }

        private void txtPerson_Click(object sender, EventArgs e)
        {
            txtPerson.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPerson.Text = "";
            bsPerson.Filter = "";
            if (bsPerson.Count > 1) // if 1 just show them!
            {
                txtPerson.Text = "* multiple found *";
                tabControl1.SelectedTab = tpContactPersons;
                dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab=tpMain;
        }

        private void tabControl1_SelectedTabChanged(object sender, EventArgs e)
        {
            bsPerson.Filter = "";
            // tabControl1.SelectedTab=tpContactPersons; // don't do this!
        }
    }
}
