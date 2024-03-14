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
        private static int SiteID = 7;
        private static DateTime EntryDTTM;

        public BookInTruck()
        {
            InitializeComponent();
        }

        public BookInTruck (dsTruckConfig.ConfiguredTruckGVMRow configuredTruckGVMRow, DateTime _EntryDTTM)
        {
            InitializeComponent();
            EntryDTTM = _EntryDTTM;
            dsTruckConfig.ConfiguredTruckGVM.Clear();
            dsTruckConfig.ConfiguredTruckGVM.ImportRow(configuredTruckGVMRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTruckDriver();
        }

        private void GetTruckDriver()
        {
            bool blOkay2Cart = true;
            TruckDriverSearch frmTruckDriverSearch = new TruckDriverSearch(CurrentTruckGVM().CardCode);
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

        private dsTruckConfig.ConfiguredTruckGVMRow CurrentTruckGVM()
        {
            try
            {
                if (bsConfiguredTruckGVM.Count > 0)
                {
                    DataRow myRow = ((DataRowView)bsConfiguredTruckGVM.Current).Row;
                    dsTruckConfig.ConfiguredTruckGVMRow configuredTruckGVMRow = (dsTruckConfig.ConfiguredTruckGVMRow)myRow;
                    return configuredTruckGVMRow;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private dsQWSLocal.TruckDriverRow CurrentTruckDriver()
        {
            if (bsTruckDriver.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTruckDriver.Current).Row;
                dsQWSLocal.TruckDriverRow myTruckDriverRow = (dsQWSLocal.TruckDriverRow)myRow;
                return myTruckDriverRow;
            }
            return null;
        }

        private void BookInTruck_Load(object sender, EventArgs e)
        {   
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            if (bsConfiguredTruckGVM.Count > 0)
            {
                if (CurrentTruckGVM().GroupCode == 117)
                {
                    chkACC.Checked = true;
                }
                else
                {
                    chkACC.Checked = false;
                }
                if (CurrentTruckGVM().CardStatus == "A") // A = Active, I = Inactive, H = On Hold
                {
                    txtCardStatus.BackColor = Color.PaleGreen;
                }
                else
                {
                    txtCardStatus.BackColor = Color.Salmon;
                }
                if (CurrentTruckGVM().Compartments > 1)
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
                if (CurrentTruckGVM().TareDT < DateTime.Now)
                {
                    btnRetare.Enabled = true;
                    btnRetare.BackColor = Color.Orange;
                }
                else
                {
                    btnRetare.Enabled = false;
                    btnRetare.BackColor = SystemColors.Control;
                }
                if (CurrentTruckGVM().GCM == CurrentTruckGVM().GVMTruck) //Truck only config
                {
                    nudPayload.Value = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
                    nudPayloadTk.Value = 0.0M;
                    nudPayloadTk.Enabled = false;
                    nudPayloadTr.Value = 0.0M;
                    nudPayloadTr.Enabled = false;
                }
                else
                {
                    decimal _Payload = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
                    decimal _PayloadTk = CurrentTruckGVM().GVMTruck - CurrentTruckGVM().TareTk;
                    nudPayload.Value = _Payload;
                    nudPayloadTk.Value = _PayloadTk;
                    nudPayloadTk.Enabled = true;
                    nudPayloadTr.Value = _Payload - _PayloadTk;
                    nudPayloadTr.Enabled = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetExBinCustomer();
        }

        private void SetExBinCustomer()
        {
            int iCust = taPrefCustomers.FillBy(dsQWSLocal.VehiclePrefCustomers, CurrentTruckGVM().RegoTk);
            if (iCust > 0)
            {
                GetPrefCustomer();
            }
            else
            {
                //search customers
                MessageBox.Show("TODO - search customers");
            }
        }

        private void GetPrefCustomer()
        {
            string myRego = CurrentTruckGVM().RegoTk;
            PreferredCustomers frmPrefCust = new PreferredCustomers(myRego);
            DialogResult dr = frmPrefCust.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // set pref cust
                MessageBox.Show("TODO - set pref customer to " + frmPrefCust.customersRow.PrefCustomer);

            }

        }

        private void btnPayload_Click(object sender, EventArgs e)
        {
            CalcPayload();
        }

        private void CalcPayload()
        {
            decimal myPayload = 0.0M;
            decimal myPayloadTk = 0.0M;
            decimal myPayloadTr = 0.0M;
            myPayload = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
            nudPayload.Value = myPayload;
            if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
            {
                myPayloadTk = CurrentTruckGVM().GVMTruck - CurrentTruckGVM().TareTk;
                myPayloadTr = myPayload - myPayloadTk;
                nudPayloadTk.Value = myPayloadTk;
                nudPayloadTr.Value = myPayloadTr;
            }
        }

        private void nudPayload_ValueChanged(object sender, EventArgs e)
        {
            PayloadNUDLimit();
        }

        private void PayloadNUDLimit()
        {
            decimal PayloadLimit = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;

            if ( nudPayload.Value > PayloadLimit)
            {
                nudPayload.Value = PayloadLimit;
                MessageBox.Show("Sorry - can only reduce payload!");
            }
        }

        private void btnPayloadValidate_Click(object sender, EventArgs e)
        {
            PayloadValidate();
        }

        private void PayloadValidate()
        {
            if ((nudPayloadTk.Value + nudPayloadTr.Value) > nudPayload.Value)
            {
                MessageBox.Show("Payload split > total Payload!");
            }
        }

        private void btnBookInExBin_Click(object sender, EventArgs e)
        {
            BookInExBin();
        }

        private void BookInExBin()
        {
            BookInExBin frmBookInExBin = new BookInExBin();
            frmBookInExBin.MdiParent = this.MdiParent;
            frmBookInExBin.Show();
        }

        private void btnBookInDelivery_Click(object sender, EventArgs e)
        {
            BookInDelivery frmBookInDelivery = new BookInDelivery();
            frmBookInDelivery.MdiParent = this.MdiParent;
            frmBookInDelivery.Show();
        }

        private void btnRetare_Click(object sender, EventArgs e)
        {
            BookInRetare();
        }

        private void BookInRetare()
        {
            try
            {
                DataRow dr = dsQWSLocal.TrucksInQuarry.NewRow();
                dsQWSLocal.TrucksInQuarryRow rowTIQ = (dsQWSLocal.TrucksInQuarryRow)dr;
                rowTIQ.TIQID = -1;
                rowTIQ.ParentTIQID = 0;
                rowTIQ.SiteID = SiteID;
                rowTIQ.Rego = CurrentTruckGVM().RegoTk;
                rowTIQ.TruckConfig = "TK"; // TODO
                rowTIQ.TruckConfigID = CurrentTruckGVM().TruckConfigID;
                rowTIQ.AxleConfiguration = CurrentTruckGVM().AxleConfiguration;
                rowTIQ.FeeCode = CurrentTruckGVM().FeeCode;
                rowTIQ.ConfigSource = CurrentTruckGVM().ConfigSource;
                rowTIQ.SchemeCode = CurrentTruckGVM().SchemeCode;
                rowTIQ.RoadAccess = CurrentTruckGVM().RoadAccess;
                rowTIQ.QueueStatus = "T";
                rowTIQ.WeighbridgeID = 1;
                rowTIQ.SAPOrder = -9;
                rowTIQ.Material = "Retare";
                rowTIQ.MaterialDesc = "Retare Vehicle";
                rowTIQ.TruckOwnerCode = CurrentTruckGVM().CardCode;
                rowTIQ.TruckOwner = CurrentTruckGVM().Owner;
                rowTIQ.DriverID = CurrentTruckDriver().CntctCode; // TODO: ensure driver selected before getting here!
                rowTIQ.Driver = CurrentTruckDriver().Person;
                rowTIQ.Payload = nudPayload.Value;
                rowTIQ.GCM = CurrentTruckGVM().GCM;
                rowTIQ.GVMTruck = CurrentTruckGVM().GVMTruck;
                rowTIQ.Tare = CurrentTruckGVM().Tare;
                rowTIQ.TareTk = CurrentTruckGVM().TareTk;
                rowTIQ.EntryDTTM = EntryDTTM;
                rowTIQ.AllocateDTTM = DateTime.Now;
                rowTIQ.ReleaseDTTM = DateTime.Now;
                dsQWSLocal.TrucksInQuarry.AddTrucksInQuarryRow(rowTIQ);
                int iRow = this.taTIQ.Update(dsQWSLocal.TrucksInQuarry);
                if (iRow == 1)
                {
                    TrucksInQuarry frmTIQ = new TrucksInQuarry();
                    frmTIQ.MdiParent = this.MdiParent;
                    frmTIQ.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
