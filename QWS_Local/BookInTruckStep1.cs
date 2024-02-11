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
    public partial class BookInTruckStep1 : Form
    {
        public BookInTruckStep1()
        {
            InitializeComponent();
        }

        private void btnFindTruck_Click(object sender, EventArgs e)
        {
            FindTruckConfig(txtTruckRego.Text);
        }

        private void FindTruckConfig(string Rego)
        {
            try
            {
                taConfiguredTrucks.FillByRego(dsTruckConfig.ConfiguredTrucks, Rego);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            GetConfiguredTrucksGVM();
        }

        private dsTruckConfig.ConfiguredTrucksRow CurrentConfigTruck()
        {
            if (bsConfiguredTrucks.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsConfiguredTrucks.Current).Row;
                dsTruckConfig.ConfiguredTrucksRow configuredTruckRow = (dsTruckConfig.ConfiguredTrucksRow)myRow;
                return configuredTruckRow;
            }
            else
            {
                return null;
            }
        }

        private void GetConfiguredTrucksGVM()
        {
            try
            {
                int myTruckConfigID = 26;
                myTruckConfigID = CurrentConfigTruck().TruckConfigID;
                taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", myTruckConfigID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            BookInTruck frmBookInTruck = new BookInTruck();
            frmBookInTruck.MdiParent = this.MdiParent;
            frmBookInTruck.Show();
        }
    }
}
