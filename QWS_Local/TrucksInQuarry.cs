using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QWS_Local
{
    public partial class TrucksInQuarry : Form
    {
        private int mySPLotNo;

        public TrucksInQuarry()
        {
            InitializeComponent();
        }

        private void TrucksInQuarry_Load(object sender, EventArgs e)
        {
            this.taAxleConfig.Fill(this.dsQWSLocal.AxleConfiguration);
            // set up and down arrows
            //button3.Text = ""+ (char)24;
            //button2.Text = ""+ (char)25;
            // TODO: find a nicer solution, probably images/icons
        }

        public void ClearTIQ()
        {
            dataGridView1.ClearSelection();
            txtRego.Clear();
            pictureBox1.Image = null;   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshQueue();
        }

        public void RefreshQueue()
        {
            try
            {         
                int SiteID = Properties.Settings.Default.SiteID;
                this.taTIQ2.Fill(dsTIQ2.TIQ, SiteID);
                ClearTIQ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTIQ_Click(object sender, EventArgs e)
        {
            BookInTruck();
        }

        private void BookInTruck()
        {
            BookInTruckStep1 frmBookIn = new BookInTruckStep1();
            frmBookIn.MdiParent = this.MdiParent;
            frmBookIn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTIQDetail();
        }

        private void ShowTIQDetail()
        {
            tabControl1.SelectedTab = tpDetails;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //move up
            TIQRowUp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //move down
            TIQRowDown();
        }

        private void TIQRowDown()
        {
            int iCount = dataGridView1.Rows.Count;
            if (iCount == 1)
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            else if (iCount > 1)
            {
                int iRow;
                int iSelectedRow = -1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    iRow = dataGridView1.CurrentCell.RowIndex; // zero based
                    if(row.Selected == true)
                    {
                        iSelectedRow = iRow;
                    }
                }
                if (iSelectedRow + 1 < iCount)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[iSelectedRow + 1].Cells[0];
                    dataGridView1.Rows[iSelectedRow + 1].Selected = true;
                }
            }
        }

        private void TIQRowUp()
        {
            int iCount = dataGridView1.Rows.Count;
            if (iCount == 1)
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            else if (iCount > 1)
            {
                int iRow;
                int iSelectedRow = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    iRow = dataGridView1.CurrentCell.RowIndex; // zero based
                    if (row.Selected == true)
                    {
                        iSelectedRow = iRow;
                    }
                }
                if (iSelectedRow <= 1)
                {
                    iSelectedRow = 1;
                }
                    dataGridView1.CurrentCell = dataGridView1.Rows[iSelectedRow - 1].Cells[0];
                    dataGridView1.Rows[iSelectedRow - 1].Selected = true;                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearTIQ();
        }

        private dsTIQ2.TIQRow CurrentTIQ()
        {
            if ( bsTIQ2.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
                return myTIQRow;
            }
            else
            {
                return null;
            }
        }

           private void SyncAxleConfig(string AxleConfig)
        {
           bsAxleConfig.Position = bsAxleConfig.Find("AxleConfiguration", AxleConfig);
        }

        private void btnTINRemove_Click(object sender, EventArgs e)
        {
            TINRemove();
            RefreshQueue();
        }

        private void TINRemove()
        {
            try 
            { 
               TIQRemove frmTIQRemove = new TIQRemove();
               DialogResult dr = frmTIQRemove.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    CurrentTIQ().TIQOpen = false;
                    bsTIQ2.EndEdit();
                    taTIQ2.Update(dsTIQ2.TIQ);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void bsTIQ2_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (bsTIQ2.Count > 0)
                {
                    string AxleConfig = CurrentTIQ().AxleConfiguration;
                    SyncAxleConfig(AxleConfig);
                    txtRego.Text = CurrentTIQ().Rego;
                    // also load associated picture from bsAxleConfig
                    DataRow myRow = ((DataRowView)bsAxleConfig.Current).Row;
                    dsQWSLocal.AxleConfigurationRow myAxleConfigRow = (dsQWSLocal.AxleConfigurationRow)myRow;
                    MemoryStream ms = new MemoryStream((byte[])myAxleConfigRow.Schematic);
                    pictureBox1.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWeigh_Click(object sender, EventArgs e)
        {
            GoToWeighTruck();
        }

        private void GoToWeighTruck()
        {
            if (dataGridView1.SelectedRows.Count == 1) 
            {
                // TODO check if Item is QA
                //if (CurrentTIQ().)
                WeighTruck frmWeighTruck = new WeighTruck();
                DialogResult dr = frmWeighTruck.ShowDialog();
                if (dr == DialogResult.OK)
                {
 
                    if (CurrentTIQ().QueueStatus == "T") // Tare
                    {
                        decimal myTare = 0.0M;
                        decimal myTareTk = 0.0M;
                        if (CurrentTIQ().TruckConfig != "TT")
                        {
                            myTare = frmWeighTruck.Weight;
                        }
                        else
                        {
                            myTareTk = frmWeighTruck.Weight;
                            WeighTruck frmTare = new WeighTruck();
                            DialogResult dr1 = frmTare.ShowDialog();
                            if (dr1 == DialogResult.OK)
                            {
                                myTare = frmTare.Weight;
                            }
                        }
                        RetareTruck(myTareTk, myTare);
                    }
                    else
                    {
                        decimal myWeight = frmWeighTruck.Weight;
                        decimal myQty = myWeight - CurrentTIQ().Tare;
                        CurrentTIQ().Gross = myWeight;
                        CurrentTIQ().Nett = myQty;
                        bsTIQ2.EndEdit();

                        if (ConfirmPostDocket())
                        {
                            PostDocket();
                        }
                        else
                        {
                            MessageBox.Show("Post docket - cancelled!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Weighing cancelled!");
                }
                //okay to proceed
                //if (rbManual.Checked)
                //{
                //    if(mtxtWeight.Text.Length == 3) // __._
                //        // TODO consider parsing and checking value between 2 - 90 t
                //    {
                //        MessageBox.Show("Please enter weight as displayed on console.");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Manually captured weight = " + mtxtWeight.Text);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Captured weight = ");
                //}
            }
            else
            {
                MessageBox.Show("Please select a truck to weigh!");
            }
        }

        private bool ConfirmPostDocket()
        {
            PostDocket frmPostDocket = new PostDocket(CurrentTIQ());
            DialogResult dr = frmPostDocket.ShowDialog();
            if (dr == DialogResult.OK )
            {
                //MessageBox.Show(frmPostDocket.SPLotNo.ToString());
                mySPLotNo = frmPostDocket.SPLotNo;
                return true;
            }
            return false;
        }

        private void RetareTruck(decimal TareTk, decimal Tare)
        {
            TareTruck frmTareTruck = new TareTruck(TareTk, Tare, CurrentTIQ());
            DialogResult dr = frmTareTruck.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Retare form OK");
            }
        }

        private void PostDocket()
        {
            // create new WBDockets row using NewDocket, then add lines
            // lock TIQ row and get DocNum
            int myTIQID = CurrentTIQ().TIQID;
            if (LockTIQ(myTIQID))
            {
                int myDocNum = GetDocNum();
                if (myDocNum > 0)
                {
                    NewDocket(myDocNum);
                    taWBDockets.Update(dsTIQ2.WBDockets);
                    int myOrderBaseEntry = 0;
                    myOrderBaseEntry = GetOrderDocEntry(CurrentTIQ().SAPOrder);
                    //DocketLineAdd(CurrentTIQ().Material, CurrentTIQ().MaterialDesc, true, 132, CurrentTIQ().StockpileLotNo, myOrderBaseEntry);
                    DocketLineAdd(CurrentTIQ().Material, CurrentTIQ().MaterialDesc, true, 132, mySPLotNo, myOrderBaseEntry);
                    // TODO get ItemQA, itmsgrpcod
                    if (CurrentTIQ().CartageCode.Length > 0)
                    {
                        DocketLineAdd(CurrentTIQ().CartageCode, "cartage desc", true,132, 0, myOrderBaseEntry);
                    }
                    taWBDocketLines.Update(dsTIQ2.WBDocketLines);
                }
                else
                {
                    MessageBox.Show("Unable to get docket number!");
                }
            }
            else
            {
                MessageBox.Show("Unable to proceed, Truck locked by another operator!");
            }
        }

        private int GetDocNum()
        {
            try
            {
                int DocNumNext = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DocNumNext";
                sqlConnection.Open();
                DocNumNext = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                return DocNumNext;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -9;
            }


        }

        private int GetOrderDocEntry(int DocNum)
        {
            try
            {
                int DocEntry = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "OrderDocEntry";
                cmd.Parameters.AddWithValue("@DocNum", DocNum);
                sqlConnection.Open();
                DocEntry = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                return DocEntry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetOrderDocEntry", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return -9;
            }


        }

        private bool LockTIQ(int TIQID)
        {
            // TODO add logic
            return true;
        }

        private void NewDocket(int DocNum)
        {
            dsTIQ2.WBDockets.Clear();
            dsTIQ2.WBDocketLines.Clear();

            DataRow dr = dsTIQ2.WBDockets.NewRow();
            dsTIQ2.WBDocketsRow docketsRow = (dsTIQ2.WBDocketsRow)dr;

            docketsRow.DocNum = DocNum;
            docketsRow.DocDate = DateTime.Now;
            docketsRow.CardCode = CurrentTIQ().CustomerCode;
            docketsRow.CardName = CurrentTIQ().Customer;
            docketsRow.PurchaseOrder = "";
            docketsRow.CntCode = -9;
            docketsRow.ContactName = "";
            docketsRow.ContactMobile = "";
            docketsRow.DeliveryDate = DateTime.Now;
            docketsRow.DeliveryAddress = "";
            docketsRow.MapRef = "";
            docketsRow.Distance = 0;
            docketsRow.TruckRego = CurrentTIQ().Rego;
            docketsRow.TruckOwnerCode = "tba";
            docketsRow.TruckOwner = "";
            docketsRow.TruckConfig = "";
            docketsRow.TruckConfigID = 1;
            docketsRow.GrossLegal = 0;
            docketsRow.Gross = CurrentTIQ().Gross;
            docketsRow.Tare = CurrentTIQ().Tare;
            docketsRow.Nett = CurrentTIQ().Nett;
            docketsRow.WBMode = "m";
            docketsRow.TruckDriverID = -1;
            docketsRow.TruckDriver = "";//"Truck Driver";
            docketsRow.SalesPersonCode = -1;
            docketsRow.SalesPerson = "";//"Weighbridge Operator";
            docketsRow.Comments = "";
            docketsRow.CreatedDTTM = DateTime.Now;
            dsTIQ2.WBDockets.AddWBDocketsRow(docketsRow);
            bsWBDockets.EndEdit();
        }

        private void DocketLineAdd(string ItemCode, string ItemDescription, bool ItemQA, int ItmsGrpCod, int SPLot, int BaseEntry)
        {
            try
            {
                DataRow myDR = ((DataRowView)bsWBDockets.Current).Row;
                dsTIQ2.WBDocketsRow docketsRow = (dsTIQ2.WBDocketsRow)myDR;

                int iLines = bsWBDocketLines.Count; //TODO maybe inherit from order?

                DataRow dr = dsTIQ2.WBDocketLines.NewRow();
                dsTIQ2.WBDocketLinesRow linesRow = (dsTIQ2.WBDocketLinesRow)dr;

                linesRow.DocNum = docketsRow.DocNum;
                linesRow.BaseEntry = BaseEntry;
                linesRow.DocketLine = iLines;
                linesRow.WarehouseCode = "7";
                linesRow.ItemCode = ItemCode;
                linesRow.ItemDescription = ItemDescription;
                linesRow.ItemQA = ItemQA;
                linesRow.ItmsGrpCod = ItmsGrpCod;
                linesRow.StockpileLot = SPLot;
                linesRow.Quantity = CurrentTIQ().Nett;
                linesRow.CreatedDTTM = DateTime.Now;
                dsTIQ2.WBDocketLines.AddWBDocketLinesRow(linesRow);
                bsWBDocketLines.EndEdit();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DocketLineAdd Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTINReleaseHold_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO implement release / hold");
        }
    }
}
