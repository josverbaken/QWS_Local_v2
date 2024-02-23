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
        private static bool FormLoaded = false;

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
                int iCount = taConfiguredTrucks.FillByRego(dsTruckConfig.ConfiguredTrucks, Rego);
                if (iCount > 0)
                {
                    UpdateOwnerGUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateOwnerGUI()
        {
            if ( CurrentConfigTruck().CardStatus != "A")
            {
                txtCardStatus.BackColor = Color.Salmon;
            }
            else
            {
                txtCardStatus.BackColor = Color.PaleGreen;
            }

            if (CurrentConfigTruck().GroupCode == 117 )
            {
                chkACC.Checked = true;
            }
            else
            {
                chkACC.Checked = false;
            }
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
                if (FormLoaded == true && bsConfiguredTrucks.Count > 0)
                {
                    int myTruckConfigID = 26;
                    myTruckConfigID = CurrentConfigTruck().TruckConfigID;
                    taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", myTruckConfigID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            DataRow myDR = ((DataRowView)bsConfiguredTruckGVM.Current).Row;
            dsTruckConfig.ConfiguredTruckGVMRow truckConfigRow = (dsTruckConfig.ConfiguredTruckGVMRow)myDR;
            // TODO create new form similar to BookInTruck but accepting ConfiguredTruckGVMRow
            BookInTruck frmBookInTruck = new BookInTruck();
            frmBookInTruck.MdiParent = this.MdiParent;
            frmBookInTruck.Show();
        }

        private void BookInTruckStep1_Load(object sender, EventArgs e)
        {
            FormLoaded = true;
        }

        private void bsConfiguredTrucks_CurrentChanged(object sender, EventArgs e)
        {
            if (FormLoaded)
            {
                GetConfiguredTrucksGVM();
            }
        }

    }
}
