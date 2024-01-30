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
        private int myTruckConfigID;
        private string myAxleConfig;

        public BookInTruck()
        {
            InitializeComponent();
        }

        public BookInTruck(int TruckConfigID)
        {
            myTruckConfigID = TruckConfigID;
            InitializeComponent();
        }

        public BookInTruck (dsTruckConfig.ConfiguredTnTRow configuredTnTRow)
        {
            InitializeComponent();
            dsTruckConfig.ConfiguredTnT.Clear();
            dsTruckConfig.ConfiguredTnT.ImportRow(configuredTnTRow);
            myAxleConfig = configuredTnTRow.AxleConfiguration;
            myTruckConfigID = configuredTnTRow.TruckConfigID;
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
                }
                else
                {
                    txtOkay2Cart.Text = "N";
                    txtOkay2Cart.BackColor = Color.Salmon;
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

        private void BookInTruck_Load(object sender, EventArgs e)
        {
            DataRow myRow = ((DataRowView)bsConfiguredTnT.Current).Row;
            dsTruckConfig.ConfiguredTnTRow configuredTnTRow = (dsTruckConfig.ConfiguredTnTRow)myRow;
            if ( configuredTnTRow.GroupCode == 117)
            {
                chkACC.Checked = true;
            }
            else
            {
                chkACC.Checked = false;
            }
            if (configuredTnTRow.CardStatus == "A") // A = Active, I = Inactive, H = On Hold
            {
                txtCardStatus.BackColor = Color.PaleGreen;
            }
            else
            {
                txtCardStatus.BackColor = Color.Salmon;
            }
        }
    }
}
