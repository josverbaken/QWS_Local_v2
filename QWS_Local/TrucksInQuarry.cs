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
using Microsoft.IdentityModel.Abstractions;

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
            int iRows =  this.taAxleConfiguration.Fill(this.dsQWSLocal2024.AxleConfiguration);
            // set up and down arrows
            //button3.Text = ""+ (char)24;
            //button2.Text = ""+ (char)25;
            // TODO: find a nicer solution, probably images/icons
            iRows += 1;
            this.KeyPreview = true;
            RefreshQueue();
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
           bsAxleConfiguration.Position = bsAxleConfiguration.Find("AxleConfiguration", AxleConfig);
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
                    if (bsAxleConfiguration.Count > 0)
                    {
                        DataRow myRow = ((DataRowView)bsAxleConfiguration.Current).Row;
                        dsQWSLocal2024.AxleConfigurationRow myAxleConfigRow = (dsQWSLocal2024.AxleConfigurationRow)myRow;
                        MemoryStream ms = new MemoryStream((byte[])myAxleConfigRow.Schematic);
                        pictureBox1.Image = new Bitmap(ms);
                    }
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
                DialogResult dr;
                WeighTruck frmWeighTruck;
                decimal myWeight;
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                switch (myTIQRow.QueueStatus)
                {
                    case "U":
                        dr = MessageBox.Show("Contact customer to confirm if OK to pick up.", "Queuestatus = U", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            if (CheckConfirmCustomer() == true)
                            {
                                myTIQRow.QueueStatus = "Q";
                                bsTIQ2.EndEdit();
                                taTIQ2.Update(dsTIQ2.TIQ);
                                RefreshQueue();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Customer NOT confirmed, so cannot proceed!", "Customer Unconfirmed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "H":
                        MessageBox.Show("Truck is still on hold, cannot proceed!", "Queuestatus = H", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "T":
                        if (myTIQRow.QueueStatus == "T" && myTIQRow.TruckConfig == "TT")
                        {
                            frmWeighTruck = new WeighTruck("Collect Tare of truck as split weight");
                            dr = frmWeighTruck.ShowDialog();
                        }
                        else
                        {
                            frmWeighTruck = new WeighTruck("Collect Tare with whole truck on weighbridge.");
                            dr = frmWeighTruck.ShowDialog();
                        }
                        if (dr == DialogResult.OK)
                        {
                            string myRego = myTIQRow.Rego;
                            int myTruckConfigID = myTIQRow.TruckConfigID;
                            int myDriverID = myTIQRow.DriverID;
                            int myParentTIQID = myTIQRow.TIQID;
                            decimal myTare = 0.0M;
                            decimal myTareTk = 0.0M;
                            if (myTIQRow.TruckConfig != "TT")
                            {
                                myTare = frmWeighTruck.Weight;
                            }
                            else
                            {
                                myTareTk = frmWeighTruck.Weight;
                                WeighTruck frmTare = new WeighTruck("Collect Tare of T&T as a total weight");
                                DialogResult dr1 = frmTare.ShowDialog();
                                if (dr1 == DialogResult.OK)
                                {
                                    myTare = frmTare.Weight;
                                }
                            }
                            RetareTruck(myTareTk, myTare);
                            RefreshQueue();
                            GoBack2BookIn(myRego, myTruckConfigID, myDriverID, myParentTIQID, myTIQRow.TruckConfig, "Retare.");
                        }
                        else
                        {
                            MessageBox.Show("Tare Weighing cancelled!");
                        }
                        break;
                    case "I":
                        frmWeighTruck = new WeighTruck("Collect weight with whole truck on weighbridge.");
                        dr = frmWeighTruck.ShowDialog();
                        myWeight = frmWeighTruck.Weight;
                        if (dr == DialogResult.OK)
                        {
                            if (myWeight > myTIQRow.GCM)
                            {
                                ImportedOverload frmImportedOverload = new ImportedOverload(myTIQRow.DriverID, myTIQRow.Driver, myWeight, myTIQRow  .GCM);
                                DialogResult dr2 = frmImportedOverload.ShowDialog();
                                if (dr2 == DialogResult.OK)
                                {
                                    myTIQRow.Gross = myWeight;
                                    myTIQRow.QueueStatus = "G";
                                    myTIQRow.OverloadPoints = frmImportedOverload.OverloadPoints;
                                    myTIQRow.OverloadDesc = frmImportedOverload.OverloadDesc;
                                    bsTIQ2.EndEdit();
                                }
                                else
                                {
                                    MessageBox.Show("Imported Weighing Cancelled!");
                                }
                            }
                            else
                            {
                                myTIQRow.Gross = myWeight;
                                myTIQRow.QueueStatus = "G";
                                bsTIQ2.EndEdit();
                            }
                            taTIQ2.Update(dsTIQ2.TIQ);
                            //RefreshQueue();
                        }
                        else
                        {
                            MessageBox.Show("Weighing cancelled!");
                        }
                        break;
                    case "G":
                        frmWeighTruck = new WeighTruck("Collect weight with whole truck on weighbridge.");
                        dr = frmWeighTruck.ShowDialog();
                        myWeight = frmWeighTruck.Weight;
                        if (dr == DialogResult.OK)
                        {
                            bool RetareDue = false;
                            string myRego = myTIQRow.Rego;
                            int myTruckConfigID = myTIQRow.TruckConfigID;
                            int myDriverID = myTIQRow.DriverID;
                            int myParentTIQID = myTIQRow.TIQID;
                            string myTruckConfig = myTIQRow.TruckConfig;

                            if (myTIQRow.Tare == 0.00M)
                            {
                                RetareDue = true;
                            }
                            myTIQRow.Tare = myWeight;
                            myTIQRow.Nett = myTIQRow.Gross - myWeight;//TODO ensure > 0 and challenge if less than MinMaterial ~ 8.0t
                            myTIQRow.QueueStatus = "E";
                            bsTIQ2.EndEdit();
                            taTIQ2.Update(dsTIQ2.TIQ);

                            if (ConfirmPostDocket())
                            {
                                PostDocket();
                                // GoBack2BookIn - might need a different signature for Re-Tare
                                if (RetareDue == true)
                                {
                                    GoBack2BookIn(myRego, myTruckConfigID, myDriverID, myParentTIQID, myTruckConfig,"Imported load.");
                                }
                            }
                            else
                            {
                                //MessageBox.Show("Post docket - cancelled!");
                            }
                        }

                        break;
                    case "Q":
                        frmWeighTruck = new WeighTruck("Collect weight with whole truck on weighbridge.");
                        dr = frmWeighTruck.ShowDialog();                        
                        if (dr == DialogResult.OK)
                        {
                            string myRego = myTIQRow.Rego;
                            int myTIQID = myTIQRow.TIQID;
                            int myTruckConfigID = myTIQRow.TruckConfigID;
                            int myDriverID = myTIQRow.DriverID;
                            string myTruckConfig = myTIQRow.TruckConfig;

                            decimal myGVM = myTIQRow.GCM;
                            if (myTruckConfig == "TKs")
                            {
                                myGVM = myTIQRow.GVMTruck + myTIQRow.Tare - myTIQRow.TareTk;
                            }
                            myWeight = frmWeighTruck.Weight;
                            if (myWeight > myGVM)
                            {
                                decimal Overweight = myWeight - myGVM;
                                string msg = "Truck overloaded by : " + Overweight.ToString() + "t";
                                MessageBox.Show(msg,"Overweight",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                TIQStatusAudit(myTIQRow.TIQID, "O",myGVM,Overweight,msg);
                            }
                            else
                            {
                                decimal myQty = myWeight - myTIQRow.Tare;
                                myTIQRow.Gross = myWeight;
                                myTIQRow.Nett = myQty;
                                string myTruckRego = myTIQRow.Rego;
                                bsTIQ2.EndEdit();
                                taTIQ2.Update(dsTIQ2.TIQ);

                                if (ConfirmPostDocket())
                                {
                                    if (myTruckConfig == "TKs" || myTruckConfig == "BDa") 
                                    {
                                        // confirm Trailer row exists
                                        int myPosition = bsTIQ2.Find("ParentTIQID", myTIQID);
                                        if (myPosition >= 0)
                                        {
                                            // change status of TRs from S to Q
                                            ReleaseSplit(myTruckRego, myWeight); // TODO error because row has been removed!
                                        }
                                    }
                                    PostDocket();
                                }
                                else
                                {
                                    //MessageBox.Show("Post docket - cancelled!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Weighing cancelled!");
                        }
                        break;
                    case "S":
                        MessageBox.Show("Please process truck first!", "Split Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a truck to weigh!", "No truck selected yet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void GoBack2BookIn(string Rego, int TruckConfigID, int DriverID, int ParentTIQID, string TrailerConfig, string Caller)
        {
            //called after retare successful or Import with retare due
            string msg = "Called after ";
            msg += Caller;
            BookInTruckStep1 frmBookInStep1 = new BookInTruckStep1(Rego, TruckConfigID, DriverID, ParentTIQID ,"TruckConfig", msg, TrailerConfig );
            frmBookInStep1.MdiParent = this.MdiParent;
            frmBookInStep1.Show();
        }

        private bool ConfirmPostDocket()
        {
            bool ItemQA = GetItemQA(CurrentTIQ().Material);
            PostDocket frmPostDocket = new PostDocket(CurrentTIQ(),ItemQA);
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
                    DocketLineAdd(CurrentTIQ().Material, CurrentTIQ().MaterialDesc, GetItemQA(CurrentTIQ().Material), GetItmsGrpCod(CurrentTIQ().Material), mySPLotNo, myOrderBaseEntry);
                    if (CurrentTIQ().CartageCode.Length > 0)
                    {
                        DocketLineAdd(CurrentTIQ().CartageCode, "cartage desc", true,132, 0, myOrderBaseEntry);
                    }
                    taWBDocketLines.Update(dsTIQ2.WBDocketLines);
                    RemoveFromTIQ(myTIQID, "Docket posted successfully.");
                    RefreshQueue();
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

        private int GetItmsGrpCod(string ItemCode)
        {
            try
            {
                int DocNumNext = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ItmsGrpCod from SAP_OITM where ItemCode like '" + ItemCode + "'";
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

        private bool GetItemQA(string ItemCode)
        {
            try
            {
                bool ItemQA = false;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select U_QWS_QA from SAP_OITM where ItemCode like '" + ItemCode + "'";
                sqlConnection.Open();
                string myItemQA = System.Convert.ToString(cmd.ExecuteScalar());
                if (myItemQA == "Y")
                {
                    ItemQA = true;
                }
                sqlConnection.Close();
                return ItemQA;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetItemQA Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        private void ReleaseSplit(string Rego, decimal TempTare)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQReleaseSplit";
                cmd.Parameters.AddWithValue("@Rego", Rego);
                cmd.Parameters.AddWithValue("@Tare", TempTare);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReleaseSplit Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TIQStatusAudit(int TIQID, string Status, decimal GVM, decimal Overweight, string Comment)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQStatusAuditAdd";
                cmd.Parameters.AddWithValue("@TIQID", TIQID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@GVM", GVM);
                cmd.Parameters.AddWithValue("@Overweight", Overweight);
                cmd.Parameters.AddWithValue("@Comments", Comment);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReleaseSplit Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            docketsRow.PurchaseOrder = CurrentTIQ().CustON;
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
            docketsRow.OverloadPoints = CurrentTIQ().OverloadPoints;
            docketsRow.OverloadDesc = CurrentTIQ().OverloadDesc;
            docketsRow.WBMode = "m";
            docketsRow.TruckDriverID = -1;
            docketsRow.TruckDriver = "";//"Truck Driver";
            docketsRow.SalesPersonCode = -1;
            docketsRow.SalesPerson = "";//"Weighbridge Operator";
            docketsRow.Comments = "";
            docketsRow.CreatedDTTM = DateTime.Now;
            docketsRow.TIQID = CurrentTIQ().TIQID;
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

        private void RemoveFromTIQ(int TIQID, string Comment)
        {
            try
            {
                int iStatus = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQRemove";
                cmd.Parameters.AddWithValue("@TIQID", TIQID);
                cmd.Parameters.AddWithValue("@Comment", Comment);
                sqlConnection.Open();
                iStatus = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RemoveFromTIQ - ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTINReleaseHold_Click(object sender, EventArgs e)
        {
            try
            {
                bool blSave = false;

                switch (CurrentTIQ().QueueStatus)
                {
                    case "U":
                        //MessageBox.Show("Contact customer to confirm okay to pick up.", "Confirm non-preferred customer."); 
                        if (CheckConfirmCustomer() ==  true)
                        {
                            blSave = true;
                            CurrentTIQ().QueueStatus = "Q";
                        }
                        break;
                    case "Q":
                        blSave = true;
                        CurrentTIQ().QueueStatus = "H";
                        break;
                    case "H":
                        DialogResult drHold = MessageBox.Show("Has Queue KPI been met?","Queue KPI Hold", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drHold == DialogResult.Yes)
                        {
                            blSave = true;
                            CurrentTIQ().QueueStatus = "Q";
                        }
                        break;
                    case "K":
                        MessageBox.Show("Please continue booking in process.","Parked Up.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "P":
                        DialogResult dr = MessageBox.Show("Press Yes to continue booking in process.", "In Progress.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            ContinueInProgress();
                        }
                        break;
                    default:
                        break;
                }
            if (blSave == true)
            {
                bsTIQ2.EndEdit();
                taTIQ2.Update(dsTIQ2.TIQ);
                RefreshQueue();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckConfirmCustomer()
        {
            ConfirmCustomer frmConfirmCustomer = new ConfirmCustomer(CurrentTIQ().Rego,CurrentTIQ().DriverID, CurrentTIQ().CustomerCode, CurrentTIQ().Customer);
            //OOPs frmConfirmCustomer.MdiParent = this.MdiParent;
            DialogResult dr = frmConfirmCustomer.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void ContinueInProgress()
        {
            BookInTruckStep1 frmBookIn = new BookInTruckStep1(CurrentTIQ().TIQID, CurrentTIQ().Rego, CurrentTIQ().TruckConfigID, CurrentTIQ().DriverID, true);
            frmBookIn.MdiParent = this.MdiParent;
            frmBookIn.Show();
        }

        private void TrucksInQuarry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                GoToWeighTruck();
            }
        }
    }
}
