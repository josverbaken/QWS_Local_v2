using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QWS_Local.dsBookIn;

namespace QWS_Local
{
    public partial class BookInMaterial : Form
    {
        private bool FormLoaded = false;
        private bool IsPrefCust = false;

        private int TruckConfigID;
        private int TIQID;
        private string CardCode;
        private string CustomerName;
        private static dsQWSLocal2024.TruckDriverRow _DriverRow;
        //private static dsTIQ2.TIQRow _TIQRow;
        private int mySiteID;

        private enum TIQType // N.B. these match variables in SQL usp QuarryOrders
        {
            ExBin,
            Imported,
            ImportedPickUp,
            Delivery
        }

        private TIQType FormTIQType;

        public BookInMaterial()
        {
            InitializeComponent();
        }

        public BookInMaterial(dsTIQ2.TIQRow TIQRow , string myTIQType, bool myIsPrefCust , dsQWSLocal2024.TruckDriverRow driverRow)
        {
            try
            {
                InitializeComponent();
                TIQID = TIQRow.TIQID;
                //_TIQRow = TIQRow;
                dsTIQ2.TIQ.Clear();
                dsTIQ2.TIQ.ImportRow(TIQRow);
                //_TIQRow = (dsTIQ2.TIQRow)dsTIQ2.TIQ.Rows[0]; // bind to dataset
                dsQWSLocal2024.TruckDriver.Clear();
                dsQWSLocal2024.TruckDriver.ImportRow(driverRow);
                _DriverRow = driverRow;
                TruckConfigID = TIQRow.TruckConfigID;
                CardCode = TIQRow.CustomerCode;
                CustomerName = TIQRow.Customer;
                mySiteID = TIQRow.SiteID;
                IsPrefCust = myIsPrefCust;
                int ImportedGrpCode = Properties.Settings.Default.ImportedGrpCode;
                int ImportedPickUpGrpCode = Properties.Settings.Default.ImportedPickUpGrpCode;
                string ImportGrpCod = ImportedGrpCode.ToString();
                string ImportPUGrpCod = ImportedPickUpGrpCode.ToString();   
                switch (myTIQType) 
                {
                    case "Delivery":
                        this.Text = "Book In Delivery";
                        FormTIQType = TIQType.Delivery;
                        break;
                    case "ExBin":
                        this.Text = "Book In ExBin";
                        FormTIQType = TIQType.ExBin;
                        break;
                    case "Imported":
                        this.Text = "Book In Imported";
                        FormTIQType = TIQType.Imported;
                        break;
                    case "ImportedPickUp":
                        this.Text = "Book In Imported PickUp";
                        FormTIQType = TIQType.ImportedPickUp;
                        break;
                    default:
                    
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsTIQ2.TIQRow CurrentTIQ()
        {
            if (bsTIQ2.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                dsTIQ2.TIQRow TIQRow = (dsTIQ2.TIQRow)myRow;
                return TIQRow;
            }
            else
            {
                return null;
            }

        }

        private int GetCartageInt()
        {
            dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
            int myCartageInt;
            switch (_TIQRow.TruckConfig)
            {
                case "TK":
                    myCartageInt = 6;
                    break;
                case "TT":
                case "TKs":
                case "TRS":
                    myCartageInt = 7;
                    break;
                case "BD":
                    myCartageInt = 7;
                    break;
                default:
                    myCartageInt = 7;
                    break;
            }
            return myCartageInt;
        }

        private void BookInMaterial_Load(object sender, EventArgs e)
        {
            LoadConfiguredTruckGVM(TruckConfigID);
            QuarryOrdersLoad(FormTIQType.ToString(), CardCode, GetCartageInt());
            SetExBinNoOrderCustomer();
            FormLoaded = true;
            dgvQuarryOrders.ClearSelection();
            if (FormTIQType != TIQType.ExBin)
            {
                //tpExBinNoOrder.Hide(); // known not to work, must remove
                tabControl2.TabPages.Remove(tpExBinNoOrder);
            }
        }

        private void SetExBinNoOrderCustomer()
        {
            txtCardCode.Text = CardCode;
            txtCustomer.Text = CustomerName;
        }

        private void LoadConfiguredTruckGVM(int myTruckConfigID)
        {
            taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", myTruckConfigID);
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
                MessageBox.Show(ex.Message,"CurrentTruckGVM",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }

        private void CalcPayload()
        {
            try
            {
                decimal myPayload = 0.0M;
                decimal myPayloadTk = 0.0M;
                decimal myPayloadTr = 0.0M;
                decimal PayloadLimit;
                dsTruckConfig.ConfiguredTruckGVMRow myTruckConfigGVM = CurrentTruckGVM();
                if (myTruckConfigGVM.GCM > myTruckConfigGVM.MaxGVM && myTruckConfigGVM.MaxGVM > 0)
                {
                    PayloadLimit = myTruckConfigGVM.MaxGVM - myTruckConfigGVM.Tare;
                }
                else
                {
                    PayloadLimit = myTruckConfigGVM.GCM - myTruckConfigGVM.Tare;
                }

                myPayload = PayloadLimit;
                nudPayload.Value = myPayload;
                dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
                switch (_TIQRow.TruckConfig)
                {
                    case "TT":
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = true;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = true;
                        txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    case "TKs":
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = true;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = false;
                        txtPayloadSplit.Text = myPayloadTk.ToString();
                        //+ " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    case "TRs":
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = false;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = true;
                        txtPayloadSplit.Text = myPayloadTr.ToString();
                        //txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    case "BD":
                        nudPayloadTk.Value = myPayload;
                        nudPayloadTk.Enabled = true;
                        //nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = false;
                        txtPayloadSplit.Text = "";//myPayload.ToString();
                        btnUpdatePayloadSplit.Enabled = false;
                        break;
                    case "BDa": // TODO fix logic
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = true;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = false;
                        txtPayloadSplit.Text = myPayloadTk.ToString();
                        //+ " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    case "BDb": // TODO fix logic
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = false;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = true;
                        txtPayloadSplit.Text = myPayloadTr.ToString();
                        //txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;

                    case "AD": // ADa, ADb treat like TT because dolly i.e 12A3RD3A3
                        nudPayloadTk.Value = myPayload;
                        nudPayloadTk.Enabled = true;
                        //nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = false;
                        txtPayloadSplit.Text = ""; // myPayload.ToString();
                        btnUpdatePayloadSplit.Enabled = false;
                        break;
                    case "ADa": // 
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = true;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = false;
                        txtPayloadSplit.Text = myPayloadTk.ToString();
                        //+ " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;
                    case "ADb": // TODO fix logic
                        myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
                        myPayloadTr = myPayload - myPayloadTk;
                        nudPayloadTk.Value = myPayloadTk;
                        nudPayloadTk.Enabled = false;
                        nudPayloadTr.Value = myPayloadTr;
                        nudPayloadTr.Enabled = true;
                        txtPayloadSplit.Text = myPayloadTr.ToString();
                        //txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                        //+ " (" + myPayload.ToString() + ")";
                        btnUpdatePayloadSplit.Enabled = true;
                        break;

                    default:
                        txtPayloadSplit.Text = string.Empty; // value to write to TIQ determined later
                        nudPayloadTk.Enabled = false;
                        nudPayloadTr.Enabled = false;
                        btnUpdatePayloadSplit.Enabled = false;
                        break;
                }
                //if (myTruckConfigGVM.Compartments > 1 && myTruckConfigGVM.AxleConfiguration.IndexOf("R") > 0)
                ////if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
                //{
                //    myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM  .TareTk;
                //    myPayloadTr = myPayload - myPayloadTk;
                //    nudPayloadTk.Value = myPayloadTk;
                //    nudPayloadTk.Enabled = true;
                //    nudPayloadTr.Value = myPayloadTr;
                //    nudPayloadTr.Enabled = true;
                //    txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
                //    //+ " (" + myPayload.ToString() + ")";
                //    btnUpdatePayloadSplit.Enabled = true;
                //}
                //else
                //{
                //    txtPayloadSplit.Text = string.Empty; // value to write to TIQ determined later
                //    nudPayloadTk.Enabled = false;
                //    nudPayloadTr.Enabled = false;
                //    btnUpdatePayloadSplit.Enabled = false;
                //}
                bsTIQ2.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CalcPayload ERROR");
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

        private void nudPayload_ValueChanged(object sender, EventArgs e)
        {
            PayloadNUDLimit();
        }

        private void btnPayloadValidate_Click(object sender, EventArgs e)
        {
            PayloadValidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddExBinOrder2TIQ();
        }

        private void AddExBinOrder2TIQ()
        {
            try
            {
                //dsTIQ2.TIQRow myTIQ = _TIQRow; // don't remove, need for binding!@#
                dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
                _TIQRow.AllocateDTTM = DateTime.Now;
                _TIQRow.SAPOrder = CurrentQuarryOrder().DocNum;
                if (CurrentQuarryOrder().ItemQA == "Y")
                {
                    _TIQRow.StockpileLotNo = -9;
                }
                else
                {
                    _TIQRow.StockpileLotNo = 0;
                }
                _TIQRow.CustON = CurrentQuarryOrder().PurchaseOrder;
                _TIQRow.Material = CurrentQuarryOrder().MaterialCode;
                _TIQRow.MaterialDesc = CurrentQuarryOrder().Material;
                _TIQRow.DeliveryAddress = "Ex-Bin";
                _TIQRow.CartageCode = "";
                _TIQRow.QueueStatus = "Q";
                this.Validate();
                bsTIQ2.EndEdit();
                int iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1)
                {
                    ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();                   
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddDelivery2TIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private dsBookIn.QuarryOrdersRow CurrentQuarryOrder()
        {
            if (bsQuarryOrders.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsQuarryOrders.Current).Row;
                dsBookIn.QuarryOrdersRow QuarryOrderRow = (dsBookIn.QuarryOrdersRow)myRow;
                return QuarryOrderRow;
            }
            else
            {
                return null;
            }
        }

        private void bsConfiguredTruckGVM_CurrentChanged(object sender, EventArgs e)
        {
            if (FormLoaded == true)
            {
                CalcPayload();
            }
        }

        private void btnExBinItems_Click(object sender, EventArgs e)
        {
            ItemSearch frmItemSearch = new ItemSearch(true, mySiteID);
            DialogResult dr = frmItemSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {//get details
                dsBookIn.Item.Clear(); // to allow multiple look ups
                dsBookIn.Item.ImportRow(frmItemSearch.myItem);
            }
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            QuarryOrdersLoad(FormTIQType.ToString(), CardCode, GetCartageInt());
        }

        private void btnSetExBinOrder_Click(object sender, EventArgs e)
        {
            SetTIQOrderDetails();
        }

        private void SetTIQOrderDetails()
        {
            try
            {
                dsBookIn.QuarryOrdersRow myOrderRow = CurrentQuarryOrder();
                //dsTIQ2.TIQRow myTIQ = _TIQRow;
                dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
                _TIQRow.SAPOrder = myOrderRow.DocNum;
                _TIQRow.CustomerCode = myOrderRow.CardCode;
                _TIQRow.Customer = myOrderRow.Customer;
                _TIQRow.CustON = myOrderRow.PurchaseOrder;
                _TIQRow.Material = myOrderRow.MaterialCode;
                _TIQRow.MaterialDesc = myOrderRow.Material;
                _TIQRow.DeliveryAddress = myOrderRow.DeliveryAddress;
                if (myOrderRow.CartageCode.Length > 0 )
                {
                    _TIQRow.CartageCode = myOrderRow.CartageCode; 
                }
                this.Validate();            
                bsTIQ2.EndEdit();
                int iRow = taTIQ2.Update(dsTIQ2.TIQ);
                iRow += 1;
                tabControl2.SelectedTab = tpTruckconfig;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SetTIQOrderDetails");
            }
        }

        private void TextBoxFormatDecimal()
        {
            if (bsQuarryOrders.Count > 0)
            {
                dsBookIn.QuarryOrdersRow myOrderRow = CurrentQuarryOrder();
                txtQuantity.Text = myOrderRow.Quantity.ToString("#.00");
                txtSupplied.Text = myOrderRow.Supplied.ToString("#.00");
                txtOpenQty.Text = myOrderRow.OpenQty.ToString("#.00");
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tpOrderDetails)
            {
                TextBoxFormatDecimal();
            }
        }

        private void btnSetTruckConfig_Click(object sender, EventArgs e)
        {
            SetTIQTruckconfig();
        }

        private void SetTIQTruckconfig()
        {
            dsTruckConfig.ConfiguredTruckGVMRow myTruckGVM = CurrentTruckGVM();
            decimal myGCM = myTruckGVM.GCM;
            decimal myMaxGVM = myTruckGVM.MaxGVM;
            if (myGCM > myMaxGVM && myMaxGVM > 0)
            {
                myGCM = myMaxGVM;
            }
            dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
            _TIQRow.GCM = myGCM;
            _TIQRow.GVMTruck = myTruckGVM.GVMTruck;
            bsTIQ2.EndEdit();
            tabControl2.SelectedTab = tpPayload;        
            CalcPayload();
            SetSplitLoadGUI(_TIQRow.TruckConfig);
        }

        private void SetSplitLoadGUI(string LoadType)
        {
            switch (LoadType)
            {
                case "TK":
                    txtGVMTruck.Visible = false;
                    txtTareTruck.Visible = false;
                    txtPayloadSplit.Visible = false;
                    nudPayloadTk.Visible = false;
                    nudPayloadTr.Visible = false;
                    break;
                case "BD":
                    txtGVMTruck.Visible = false;
                    txtTareTruck.Visible = false;
                    txtPayloadSplit.Visible = false;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = false;
                    nudPayloadTr.Visible = false;
                    break;
                case "TT":
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = true;
                    break;
                case "TKs":
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = false;
                    break;
                case "TRs":
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = true;
                    break;
                default:
                    txtGVMTruck.Visible = true;
                    txtTareTruck.Visible = true;
                    txtPayloadSplit.Visible = true;
                    nudPayloadTk.Visible = true;
                    nudPayloadTr.Visible = true;
                    break;            
            }
        }

        private void btnBookIn_Click(object sender, EventArgs e)
        {
            AddMaterial2TIQ();
        }

        private void AddMaterial2TIQ()
        {
            try
            {
                SetTIQPayload();
                //dsTIQ2.TIQRow myTIQ = _TIQRow;
                dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
                _TIQRow.AllocateDTTM = DateTime.Now;
                _TIQRow.CartageCode = "";
                switch (FormTIQType) // test ExBin or Delivery for Truck or Trailer Only Load
                {
                    case TIQType.ExBin:
                        if (IsPrefCust == true)
                        {
                            switch (_TIQRow.TruckConfig)
                            {
                                case "TRs":
                                case "BDb":
                                    if (_TIQRow.QueueStatus.Equals("X") == false)
                                    {
                                        _TIQRow.QueueStatus = "S";
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            _TIQRow.QueueStatus = "U";
                        }
                        break;
                    case TIQType.Delivery:
                        switch (_TIQRow.TruckConfig)
                        {
                            case "TRs":
                            case "BDb":
                                if (_TIQRow.QueueStatus.Equals("X") == false)
                                {
                                    _TIQRow.QueueStatus = "S";
                                }
                                break;
                        }
                        break;
                }

                if (_TIQRow.QueueStatus == "P")
                {
                    _TIQRow.QueueStatus = "Q";
                }
                //this.Validate();
                //string msg = "Rowstate = ";
                //msg += _TIQRow.RowState.ToString();
                //MessageBox.Show(msg); // modified so issue probably with not specifying binding source due to import statement!@#

                bsTIQ2.EndEdit();
                int iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1) // test if split load
                {
                    if (_TIQRow.TruckConfig == "TKs" && _TIQRow.QueueStatus != "X") // X = truck only
                    {
                        GoBack2BookIn(_TIQRow.Rego, _TIQRow.TruckConfigID, _TIQRow.DriverID, _TIQRow.TIQID, "TRs");
                    }
                    else if (_TIQRow.TruckConfig == "Bda")
                    {
                        // TODO handle split load for B-double
                        MessageBox.Show("","Split B-double",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        GoBack2BookIn(_TIQRow.Rego, _TIQRow.TruckConfigID, _TIQRow.DriverID, _TIQRow.TIQID, "BDb");
                    }
                    else
                    {
                        ((QWS_MDIParent)this.MdiParent).BringTIQ2Front();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddExBin2TIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTIQPayload()
        {
            dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
            _TIQRow.Payload = nudPayload.Value;
            if (txtPayloadSplit.Text.Length == 0)
            {
                _TIQRow.PayloadSplit = nudPayload.Value.ToString();
            }
            else
            {
                _TIQRow.PayloadSplit = txtPayloadSplit.Text;
            }
            bsTIQ2.EndEdit();
        }
    
        private void dgvQuarryOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (bsQuarryOrders.Count > 0 && FormLoaded == true && dgvQuarryOrders.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Move to details ?", "Choose Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    tabControl2.SelectedTab = tpOrderDetails;
                }
            }
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            SetExBinNoOrderItem();
        }

        private void SetExBinNoOrderItem()
        {
            try
            {
                bool ItemOK = true;
            if (bsItem.Count > 0)
            {
                    // Check blanket agreement
                    int myAgrNo = 0;
                    int myAgrLine = 0;
                dsBookIn.BlanketAgreementCheckRow myBlanketRow = (dsBookIn.BlanketAgreementCheckRow)CheckBlanketAgreement(txtCardCode.Text, txtExBinItem.Text);
                if (myBlanketRow != null) 
                    {
                        if (myBlanketRow.AgrStatus == "D")
                        {
                            MessageBox.Show("Unable to continue! Please resolve Agreement no " + myBlanketRow.AgrNo.ToString());
                            ItemOK = false;
                        }
                        if (myBlanketRow.AgrStatus == "A")
                        {
                            MessageBox.Show("Blanket Agreement is approved!");
                            myAgrNo = myBlanketRow.AgrNo;
                            myAgrLine = myBlanketRow.AgrLineNum;
                        }
                    }
                DataRow myRow = ((DataRowView)bsItem.Current).Row;
                if (myRow != null && ItemOK == true)
                    {
                        dsBookIn.ItemRow itemRow = (dsBookIn.ItemRow)myRow;
                        dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
                        _TIQRow.SAPOrder = 0;
                        _TIQRow.CustomerCode = txtCardCode.Text;
                        _TIQRow.Customer = txtCustomer.Text;
                        _TIQRow.CustON = txtCustON.Text;
                        _TIQRow.Material = itemRow.ItemCode;
                        _TIQRow.MaterialDesc = itemRow.ItemName;
                        _TIQRow.AgrNo = myAgrNo;
                        _TIQRow.AgrLine = myAgrLine;   
                        bsTIQ2.EndEdit();
                        tabControl2.SelectedTab = tpTruckconfig;
                    }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SetExBinNoOrderItem");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeCustomer();
        }

        private void ChangeCustomer()
        {
            BusinessSearch frmBusinessSearch = new BusinessSearch();
            DialogResult dr = frmBusinessSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtCardCode.Text = frmBusinessSearch.SAPCode;
                txtCustomer.Text = frmBusinessSearch.BusinessName;
                //return 
            }
            else
            {
                //return null;
                txtCardCode.Text = "n/a";
                txtCustomer.Text = "n/a";
            }
        }

        private void GoBack2BookIn(string Rego, int TruckConfigID, int DriverID, int myParentTIQID, string TrailerConfig)
        {
            // call to book in trailer for split load
            dsTIQ2.TIQRow _TIQRow = CurrentTIQ();
            BookInTruck frmBookInStep1 = new BookInTruck(Rego, TruckConfigID, DriverID, myParentTIQID,_TIQRow.TruckConfig, "Called after book in TKs", TrailerConfig);
            frmBookInStep1.MdiParent = this.MdiParent;
            frmBookInStep1.Show();
        }

        private void btnUpdatePayloadSplit_Click(object sender, EventArgs e)
        {
            PayloadSplitRefreshGUI();
        }

        private void PayloadSplitRefreshGUI()
        {            
            decimal myPayloadTk = nudPayloadTk.Value;
            decimal myPayloadTr = nudPayloadTr.Value;
            decimal myPayload = myPayloadTk + myPayloadTr;
            if (myPayload <= nudPayload.Value)
            {
                //txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString() + " (" + myPayload.ToString() + ")";
                txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString();
            }
            else
            {
                MessageBox.Show("Invalid weights!");
                CalcPayload();
            }
        }
   
        private void btnQuarryOrdersLoad_Click(object sender, EventArgs e)
        {
            QuarryOrdersLoad(FormTIQType.ToString(), CardCode, GetCartageInt());
        }

        private void QuarryOrdersLoad(string OrderType,  string CardCode, int CartageInt)
        {
            try
            {
                this.taQuarryOrders.Fill(this.dsBookIn.QuarryOrders, OrderType,CardCode, CartageInt,mySiteID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void nudPayloadTk_ValueChanged(object sender, EventArgs e)
        {
            SplitPayloadNUDLimit("TK");
        }

        private void nudPayloadTr_ValueChanged(object sender, EventArgs e)
        {
            SplitPayloadNUDLimit("TR");
        }

        private void SplitPayloadNUDLimit(string TKTR)
        {
            decimal myPayload = 0.0M;
            decimal myPayloadTk = 0.0M;
            decimal myPayloadTr = 0.0M;
            decimal PayloadLimit;
            dsTruckConfig.ConfiguredTruckGVMRow myTruckConfigGVM = CurrentTruckGVM();
            if (myTruckConfigGVM.GCM > myTruckConfigGVM.MaxGVM && myTruckConfigGVM.MaxGVM > 0)
            {
                PayloadLimit = myTruckConfigGVM.MaxGVM - myTruckConfigGVM.Tare;
            }
            else
            {
                PayloadLimit = myTruckConfigGVM.GCM - myTruckConfigGVM.Tare;
            }

            myPayload = PayloadLimit;

            myPayloadTk = myTruckConfigGVM.GVMTruck - myTruckConfigGVM.TareTk;
            myPayloadTr = myPayload - myPayloadTk;


            switch (TKTR)
            {
                case "TK":
                    if (nudPayloadTk.Value > myPayloadTk)
                    {
                        nudPayloadTk.Value = myPayloadTk;
                        MessageBox.Show("Sorry - can only reduce payload!");
                    }
                    break;
                case "TR":
                    if (nudPayloadTr.Value > myPayloadTr)
                    {
                        nudPayloadTr.Value = myPayloadTr;
                        MessageBox.Show("Sorry - can only reduce payload!");
                    }
                    break;
            }
        }

        private void btnCheckBlanket_Click(object sender, EventArgs e)
        {
            CheckBlanketAgreement(txtCardCode.Text, txtExBinItem.Text);
        }

        private BlanketAgreementCheckRow CheckBlanketAgreement(string CardCode, string ItemCode)
        {
            try
            {
               int iCount = this.taBlanketAgreement.Fill(this.dsBookIn.BlanketAgreementCheck,CardCode, ItemCode);
                if (iCount == 1)
                {
                    BlanketAgreementCheckRow myRow = (BlanketAgreementCheckRow) dsBookIn.BlanketAgreementCheck.Rows[0];
                    return myRow;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


    }
}
