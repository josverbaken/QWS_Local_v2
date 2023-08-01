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
    public partial class BookInTruck : Form
    {
        public BookInTruck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check rego input
            string Rego2Find = mtxtRego.Text;
            if (Rego2Find.Length != 6)
            {
                //
                MessageBox.Show("Is this a special rego ? " + mtxtRego.Text);
            }
            else
            {
                MessageBox.Show("entry was " + mtxtRego.Text.Length.ToString() + " .. " + Rego2Find);
            }
            Search4Vehicle(Rego2Find);
        }

        private void Search4Vehicle(string Rego2Find)
        {
            VehicleSearch vehicleSearch = new VehicleSearch(Rego2Find);
            DialogResult dr = vehicleSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //vehicle found
                label1.Text = "Vehicle Found.";
                mtxtRego.Text = vehicleSearch.Rego;
            }
            else if (dr == DialogResult.Cancel)
            {
                //cancelled
                label1.Text = "Vehicle Search Cancelled!";
            }
            else
            {
                //??
                label1.Text = " .. other ..";
            }
        }
    }
}
