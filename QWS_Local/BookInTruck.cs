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

        public BookInTruck (dsTruckConfig.ConfiguredTnTRow configuredTnTRow)
        {
            InitializeComponent();
            dsTruckConfig.ConfiguredTnT.Clear();
            dsTruckConfig.ConfiguredTnT.ImportRow(configuredTnTRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTruckDriver();
        }

        private void GetTruckDriver()
        {
            bool blOkay2Cart = true;
            TruckDriverSearch frmTruckDriverSearch = new TruckDriverSearch(txtCardCode.Text);
            DialogResult dr = frmTruckDriverSearch.ShowDialog();
            if (dr ==DialogResult.OK)
            {
                dsQWSLocal.TruckDriver.Clear();
                dsQWSLocal.TruckDriver.ImportRow(frmTruckDriverSearch.TruckDriverRow);
                bsTruckDriver.Position = 0;
                DataRow myRow = ((DataRowView)bsTruckDriver.Current).Row;
                dsQWSLocal.TruckDriverRow myTruckDriverRow = (dsQWSLocal.TruckDriverRow)myRow;
                if (myTruckDriverRow.LicenseExp < DateTime.Now)
                {
                    txtLicenseExp.BackColor = Color.Salmon;
                    blOkay2Cart = false;
                }
                else
                {
                    txtLicenseExp.BackColor = Color.PaleGreen;
                }
                if (myTruckDriverRow.InductionExp < DateTime.Now)
                {
                    txtInductionExp.BackColor = Color.Salmon;
                    blOkay2Cart = false;
                }
                else
                {
                    txtInductionExp.BackColor = Color.PaleGreen;
                }
                if (myTruckDriverRow.Active == "Y")
                {
                    txtActive.BackColor = Color.PaleGreen;
                }
                else
                {
                    txtActive.BackColor = Color.Salmon;
                    blOkay2Cart = false;
                }
                if (blOkay2Cart)
                {
                    txtOkay2Cart.Text = "Y";
                    txtOkay2Cart.BackColor = Color.PaleGreen;
                    btnExBin.Enabled = true;
                }
                else
                {
                    txtOkay2Cart.Text = "N";
                    txtOkay2Cart.BackColor = Color.Salmon;
                    btnExBin.Enabled = false;
                }
                if (myTruckDriverRow.Position == "Authorised Cartage Contractor")
                {
                    chkDriverACC.Checked = true;

                }
                else
                {
                    chkDriverACC.Checked = false;
                }
            }
        }

        private dsTruckConfig.ConfiguredTnTRow CurrentTNT()
        {
            DataRow myRow = ((DataRowView)bsConfiguredTnT.Current).Row;
            dsTruckConfig.ConfiguredTnTRow configuredTnTRow = (dsTruckConfig.ConfiguredTnTRow)myRow;
            return configuredTnTRow;
        }

        private void BookInTruck_Load(object sender, EventArgs e)
        {
            
            if (CurrentTNT().GroupCode == 117)
            {
                chkACC.Checked = true;
            }
            else
            {
                chkACC.Checked = false;
            }
            if (CurrentTNT().CardStatus == "A") // A = Active, I = Inactive, H = On Hold
            {
                txtCardStatus.BackColor = Color.PaleGreen;
            }
            else
            {
                txtCardStatus.BackColor = Color.Salmon;
            }
            if (CurrentTNT().Compartments > 1)
            {
                btnTnT.Enabled = true;
                btnSplitLoad.Enabled = true;
                btnTrailerOnly.Enabled = true;
            }
            else
            {
                btnTnT.Enabled = false;
                btnSplitLoad.Enabled = false;
                btnTrailerOnly.Enabled = false;
            }
            if (CurrentTNT().TareDT < DateTime.Now)
            {
                btnRetare.Enabled = true;
                btnRetare.BackColor = Color.Orange;
            }
            else
            {
                btnRetare.Enabled = false;
                btnRetare.BackColor = SystemColors.Control;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetPrefCustomer();
        }

        private void GetPrefCustomer()
        {
            string myRego = CurrentTNT().RegoTk;
            PreferredCustomers frmPrefCust = new PreferredCustomers(myRego);
            DialogResult dr = frmPrefCust.ShowDialog();

        }
    }
}
