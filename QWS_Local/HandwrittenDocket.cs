using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class HandwrittenDocket : Form
    {
        private static int mySiteID;
        private static decimal myGross;
        private static decimal myTare;
        private static decimal myNett;

        public HandwrittenDocket()
        {
            InitializeComponent();
        }

        private string QWS_WBO
        {
            get
            {
                var parent = this.MdiParent as QWS_MDIParent;
                return parent.UserName;
            }
        }

        private void wBDocketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsWBDockets.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsTIQ2);

        }

        private void HandwrittenDocket_Load(object sender, EventArgs e)
        {
            var parent = this.MdiParent as QWS_MDIParent;
            mySiteID = parent.SiteID;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckDocketNumber();
        }

        private void CheckDocketNumber()
        {
            try
            {
                dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets = new dsTIQ2TableAdapters.WBDocketsTableAdapter();
                taWBDockets.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                int myDocNum = System.Convert.ToInt32(txtDocNum.Text);
                int iCount = taWBDockets.FillBy(dsTIQ2.WBDockets,myDocNum);
                if (iCount == 0)
                {
                    DialogResult dr = MessageBox.Show("Press OK to create docket","Confirm New Docket.",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        CreateNewDocket(myDocNum);
                    }
                }
                else
                {
                    dsTIQ2TableAdapters.WBDocketLinesTableAdapter taWBDocketLines = new dsTIQ2TableAdapters.WBDocketLinesTableAdapter();
                    taWBDocketLines.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                    taWBDocketLines.FillBy(dsTIQ2.WBDocketLines, myDocNum);
                    MessageBox.Show("Docket already used!", "Docket Number Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CheckDocketNumber Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveDocket_Click(object sender, EventArgs e)
        {
            SaveHandwrittenDocket();
        }

        private void SaveHandwrittenDocket()
        {
            try
            {
                dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets = new dsTIQ2TableAdapters.WBDocketsTableAdapter();
                taWBDockets.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                taWBDockets.Update(dsTIQ2.WBDockets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Docket Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewDocket(int DocNum)
        {
            try
            {
                MessageBox.Show("TODO to write code for new docket with DocNum = " + DocNum.ToString());
                dsTIQ2.WBDockets.Clear();
                dsTIQ2.WBDocketLines.Clear();
                //dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                //string RegB = myTIQRow.RegoTr2;
                //if (myTIQRow.RegoTr3.Length > 0)
                //{
                //    RegB = myTIQRow.RegoTr2;
                //}
                string myContactName = "";
                string myContactMobile = "";
                int myCntCode = -9;

                // Safely attempt the conversion
                if (decimal.TryParse(txtGross.Text, out decimal Gross))
                {
                    myGross =Gross;
                }
                else
                {
                    myGross = 0.0M;
                }

                if (decimal.TryParse(txtTare.Text, out decimal Tare))
                {
                    myTare = Tare;
                }
                else
                {
                    myTare = 0.0M;
                }

                if (decimal.TryParse(txtNett.Text, out decimal Nett))
                {
                    myNett = Nett;
                }
                else
                {
                    myNett = 0.0M;
                }

                //int myORDRDocNum = myTIQRow.SAPOrder;
                //if (myORDRDocNum > 0)
                //{
                //    dsBookInTableAdapters.QuarryOrdersTableAdapter taQuarryOrders = new dsBookInTableAdapters.QuarryOrdersTableAdapter();
                //    taQuarryOrders.Connection.ConnectionString = QWSConfig.cnQWSLocal;
                //    int iRows = taQuarryOrders.FillBy(dsBookIn.QuarryOrders, myTIQRow.SAPOrder);
                //    if (iRows > 0)
                //    {
                //        dsBookIn.QuarryOrdersRow myOrderRow = (dsBookIn.QuarryOrdersRow)dsBookIn.QuarryOrders.Rows[0];
                //        myContactName = myOrderRow.ContactName;
                //        myContactMobile = myOrderRow.ContactMobile;
                //        myCntCode = myOrderRow.CntctCode;
                //    }
                //}
                DataRow dr = dsTIQ2.WBDockets.NewRow();
                dsTIQ2.WBDocketsRow docketsRow = (dsTIQ2.WBDocketsRow)dr;

                docketsRow.DocNum = DocNum;
                docketsRow.DocDate = DateTime.Now;
                docketsRow.CardCode = "<CustomerCode>";
                docketsRow.CardName = "<Customer>";
                docketsRow.PurchaseOrder = "CustON";
                docketsRow.SAPOrderDocNum = 0;
                docketsRow.CntCode = myCntCode;
                docketsRow.ContactName = myContactName;
                docketsRow.ContactMobile = myContactMobile;
                docketsRow.DeliveryDate = DateTime.Now;
                docketsRow.DeliveryAddress = "";
                docketsRow.MapRef = "";
                docketsRow.Distance = 0;
                docketsRow.TruckRego = "<Rego>";
                docketsRow.RegA = "<RegA>";
                docketsRow.RegB = "<RegB>";
                docketsRow.TruckOwnerCode = "C01234";
                docketsRow.TruckOwner = "<TruckOwner>";
                docketsRow.TruckConfig = "";
                docketsRow.TruckConfigID = 1;
                docketsRow.GrossLegal = 43.50M;
                docketsRow.Gross = myGross;
                docketsRow.Tare = myTare;
                docketsRow.Nett = myNett;
                docketsRow.OverloadPoints = 0;
                docketsRow.OverloadDesc = "<OverloadDesc>";
                docketsRow.WBMode = "Manual";
                docketsRow.TruckDriverID = 1;
                docketsRow.TruckDriver = "<Driver>";
                docketsRow.SalesPersonCode = -1;
                docketsRow.SalesPerson = "";//"Weighbridge Operator";
                docketsRow.EnteredBy = QWS_WBO;
                docketsRow.Comments = "";
                docketsRow.CreatedDTTM = DateTime.Now;
                docketsRow.TIQID = 0; // TODO check what issues this may cause
                dsTIQ2.WBDockets.AddWBDocketsRow(docketsRow);
                bsWBDockets.EndEdit();
                DocketLineAdd("tba", "item", false, 128, "Items", 0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Docket Error!");
            }
        }

        private void DocketLineAdd(string ItemCode, string ItemDescription, bool ItemQA, int ItmsGrpCod, string SWW, int SPLot, int BaseEntry, int lineNum)
        {
            try
            {
                DataRow myDR = ((DataRowView)bsWBDockets.Current).Row;
                dsTIQ2.WBDocketsRow docketsRow = (dsTIQ2.WBDocketsRow)myDR;

                int iLines = bsWBDocketLines.Count; // is zero based, will increment as lines added

                DataRow dr = dsTIQ2.WBDocketLines.NewRow();
                dsTIQ2.WBDocketLinesRow linesRow = (dsTIQ2.WBDocketLinesRow)dr;

                linesRow.DocNum = docketsRow.DocNum;
                linesRow.BaseEntry = BaseEntry;
                linesRow.DocketLine = lineNum;
                linesRow.WarehouseCode = mySiteID.ToString();
                linesRow.ItemCode = ItemCode;
                linesRow.ItemDescription = ItemDescription;
                linesRow.ItemQA = ItemQA;
                linesRow.ItmsGrpCod = ItmsGrpCod;
                linesRow.SWW = SWW;
                linesRow.StockpileLot = SPLot;
                linesRow.AgrNo = 0; // CurrentTIQ().AgrNo;
                linesRow.AgrLine = 0; // CurrentTIQ().AgrLine;
                string UOM = ItemCode.Substring(ItemCode.Length - 1, 1);
                if (UOM == "1")
                {
                    linesRow.Quantity = 1.0M;
                }
                else
                {
                    decimal myMinimumCart = QWSConfig.MinimumCart;
                    if (SWW == "Freight" && myNett < myMinimumCart)
                    {
                        decimal myPayload = docketsRow.GrossLegal - docketsRow.Tare;
                        if (myPayload < myMinimumCart)
                        {
                            linesRow.Quantity = myPayload;
                        }
                        else
                        {
                            linesRow.Quantity = myMinimumCart;
                        }
                    }
                    else
                    {
                        linesRow.Quantity = myNett;
                    }
                }
                linesRow.CreatedDTTM = DateTime.Now;
                dsTIQ2.WBDocketLines.AddWBDocketLinesRow(linesRow);
                bsWBDocketLines.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DocketLineAdd Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
