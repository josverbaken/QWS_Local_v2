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
    public partial class BookInExBin : Form
    {
        public BookInExBin()
        {
            InitializeComponent();
        }

        public BookInExBin(int myTruckConfigID, string myCardCode, string myCustomerName, dsQWSLocal.TruckDriverRow driverRow)
        {
            InitializeComponent();
            //EntryDTTM = _EntryDTTM;
            TruckConfigID = myTruckConfigID;
            CardCode = myCardCode;
            CustomerName = myCustomerName;
            DriverRow = driverRow;
        }

        private int TruckConfigID;
        private string CardCode;
        private string CustomerName;
        private dsQWSLocal.TruckDriverRow DriverRow;

        private void BookInExBin_Load(object sender, EventArgs e)
        {
            LoadExBinItems();
            LoadConfiguredTruckGVM(TruckConfigID);
            LoadDriver();
            ExBinOrdersLoad(CardCode);
            label1.Text = "Customer  = " + CardCode + " " + CustomerName;
        }

        private void ExBinOrdersLoad(string CardCode)
        {
            this.exBinOrdersTableAdapter.FillBy(this.dsBookIn.ExBinOrders,CardCode);
        }

        private void LoadExBinItems()
        {
            string mySiteCode = Properties.Settings.Default.SiteCode;
            taItem.Fill(dsBookIn.Item, mySiteCode);
        }

        private void LoadConfiguredTruckGVM(int myTruckConfigID)
        {
            taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", myTruckConfigID);
        }

        private void LoadDriver()
        {
            dsQWSLocal.TruckDriver.Clear();
            dsQWSLocal.TruckDriver.ImportRow(DriverRow);
            //bsDriver.Position = 0;
            //DataRow myRow = ((DataRowView)bsDriver.Current).Row;
            //dsQWSLocal.TruckDriverRow myDriverRow = (dsQWSLocal.TruckDriverRow)myRow;
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

        private void PayloadNUDLimit()
        {
            decimal PayloadLimit = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;

            if (nudPayload.Value > PayloadLimit)
            {
                nudPayload.Value = PayloadLimit;
                MessageBox.Show("Sorry - can only reduce payload!");
            }
        }

        private void PayloadValidate()
        {
            if ((nudPayloadTk.Value + nudPayloadTr.Value) > nudPayload.Value)
            {
                MessageBox.Show("Payload split > total Payload!");
            }
        }

        private void btnPayload_Click(object sender, EventArgs e)
        {
            CalcPayload();
        }

        private void nudPayload_ValueChanged(object sender, EventArgs e)
        {
            PayloadNUDLimit();
        }

        private void btnPayloadValidate_Click(object sender, EventArgs e)
        {
            PayloadValidate();
        }
    }
}
