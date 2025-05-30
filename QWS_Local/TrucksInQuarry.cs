using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Abstractions;
using QWS_Local.dsQWSLocal2024TableAdapters;
using static QWS_Local.dsTIQ2;

namespace QWS_Local
{
    public partial class TrucksInQuarry : Form
    {
        private int mySiteID;
        private int mySPLotNo;
        private string WeighbridgeOperator;
        private string ComputerName;
        private string Domain;
        private string myConnectionString;

        public TrucksInQuarry()
        {
            InitializeComponent();
        }

        private void TrucksInQuarry_Load(object sender, EventArgs e)
        {
            var parent = this.MdiParent as QWS_MDIParent;
            mySiteID = parent.SiteID;
            WeighbridgeOperator = parent.UserName;
            ComputerName = parent.ComputerName;
            Domain = parent.DomainName;
            this.KeyPreview = true;
            myConnectionString = Properties.Settings.Default.cnQWSLocal;
            int iRows = this.taAxleConfiguration.Fill(this.dsQWSLocal2024.AxleConfiguration);
            iRows += 1;

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
                var parent = this.MdiParent as QWS_MDIParent;
                int SiteID = parent.SiteID;
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
            BookInTruck frmBookIn = new BookInTruck();
            frmBookIn.MdiParent = this.MdiParent;
            frmBookIn.Show();
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
        }

        private void TINRemove()
        {
            try 
            { 
               TIQRemove frmTIQRemove = new TIQRemove();
               DialogResult dr = frmTIQRemove.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string Reason = frmTIQRemove.TIQRemoveReason;
                    int myTIQID = CurrentTIQ().TIQID;
                    TIQStatusAudit(myTIQID, "Z" ,9,false, 0.00M, Reason);
                    CurrentTIQ().TIQOpen = false;
                    bsTIQ2.EndEdit();
                    taTIQ2.Update(dsTIQ2.TIQ);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RefreshQueue();
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
                // apply lock here 20250527
                if (LockTIQ(CurrentTIQ().TIQID) == true)
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
                                frmWeighTruck = new WeighTruck("Collect Tare of truck as split weight", mySiteID);
                                dr = frmWeighTruck.ShowDialog();
                            }
                            else
                            {
                                frmWeighTruck = new WeighTruck("Collect Tare with whole truck on weighbridge.", mySiteID);
                                dr = frmWeighTruck.ShowDialog();
                            }
                            if (dr == DialogResult.OK)
                            {
                                TIQStatusAudit(myTIQRow.TIQID, "T", frmWeighTruck.WBID, frmWeighTruck.WBConnected, frmWeighTruck.Weight, "Capture tare");
                                string myRego = myTIQRow.Rego;
                                int myTruckConfigID = myTIQRow.TruckConfigID;
                                int myDriverID = myTIQRow.DriverID;
                                int myParentTIQID = myTIQRow.TIQID;
                                decimal myTare = 0.0M;
                                decimal myTareTk = 0.0M;
                                if (myTIQRow.TruckConfig != "TT")
                                {
                                    myTIQRow.WeighbridgeID = frmWeighTruck.WBID;
                                    myTIQRow.WBConnected = frmWeighTruck.WBConnected;
                                    bsTIQ2.EndEdit();
                                    taTIQ2.Update(dsTIQ2.TIQ);
                                    myTare = frmWeighTruck.Weight;
                                }
                                else
                                {
                                    myTareTk = frmWeighTruck.Weight;
                                    WeighTruck frmTare = new WeighTruck("Collect Tare of T&T as a total weight", mySiteID);
                                    DialogResult dr1 = frmTare.ShowDialog();
                                    if (dr1 == DialogResult.OK)
                                    {
                                        myTIQRow.WeighbridgeID = frmTare.WBID;
                                        myTIQRow.WBConnected = frmTare.WBConnected;
                                        bsTIQ2.EndEdit();
                                        taTIQ2.Update(dsTIQ2.TIQ);
                                        myTare = frmTare.Weight;
                                    }
                                }
                                RetareTruck(myTareTk, myTare);
                                GoBack2BookIn(myRego, myTruckConfigID, myDriverID, myParentTIQID, myTIQRow.TruckConfig, "Retare.");
                                RefreshQueue();
                            }
                            else
                            {
                                LockTIQUsp(myTIQRow.TIQID, "U");
                                MessageBox.Show("Tare Weighing cancelled!");
                            }
                            break;
                        case "I":
                            frmWeighTruck = new WeighTruck("Collect weight with whole truck on weighbridge.", mySiteID);
                            dr = frmWeighTruck.ShowDialog();
                            myWeight = frmWeighTruck.Weight;
                            if (dr == DialogResult.OK)
                            {
                                TIQStatusAudit(myTIQRow.TIQID, "I", frmWeighTruck.WBID, frmWeighTruck.WBConnected, myWeight, "Capture gross of imported load");
                                if (myWeight > myTIQRow.GCM)
                                {
                                    ImportedOverload frmImportedOverload = new ImportedOverload(myTIQRow.DriverID, myTIQRow.Driver, myWeight, myTIQRow.GCM);
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
                                        LockTIQUsp(myTIQRow.TIQID, "U");
                                        MessageBox.Show("Imported Weighing Cancelled!");
                                    }
                                }
                                else
                                {
                                    myTIQRow.Gross = myWeight;
                                    myTIQRow.QueueStatus = "G";
                                    bsTIQ2.EndEdit();
                                }
                                bsTIQ2.EndEdit();
                                myTIQRow.WeighbridgeID = frmWeighTruck.WBID;
                                myTIQRow.WBConnected = frmWeighTruck.WBConnected;
                                taTIQ2.Update(dsTIQ2.TIQ);
                                //RefreshQueue();
                            }
                            else
                            {
                                LockTIQUsp(myTIQRow.TIQID, "U");
                                MessageBox.Show("Weighing cancelled!");
                            }
                            break;
                        case "G":
                            frmWeighTruck = new WeighTruck("Collect weight with whole truck on weighbridge.", mySiteID);
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
                                //TODO ensure > 0 and challenge if less than MinMaterial ~ 8.0t
                                decimal myNett = myTIQRow.Gross - myWeight;
                                if (myNett < Properties.Settings.Default.MinimumMaterial)
                                {
                                    MessageBox.Show("Under loaded!");
                                }

                                if (myTIQRow.Tare == 0.00M)
                                {
                                    RetareDue = true;
                                }
                                myTIQRow.Tare = myWeight;
                                myTIQRow.Nett = myNett;
                                myTIQRow.WeighbridgeID = frmWeighTruck.WBID;
                                myTIQRow.WBConnected = frmWeighTruck.WBConnected;
                                myTIQRow.QueueStatus = "E";
                                bsTIQ2.EndEdit();
                                taTIQ2.Update(dsTIQ2.TIQ);
                                TIQStatusAudit(myTIQRow.TIQID, "G", frmWeighTruck.WBID, frmWeighTruck.WBConnected, myWeight, "Capture tare of imported load");

                                if (ConfirmPostDocket())
                                {
                                    PostDocket();
                                    if (RetareDue == true)
                                    {
                                        GoBack2BookIn(myRego, myTruckConfigID, myDriverID, myParentTIQID, myTruckConfig, "Imported load.");
                                    }
                                }
                            }

                            break;
                        case "Q":
                            frmWeighTruck = new WeighTruck("Collect weight with whole truck on weighbridge.", mySiteID);
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
                                    MessageBox.Show(msg, "Overweight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    TIQStatusAudit(myTIQRow.TIQID, "O", frmWeighTruck.WBID, frmWeighTruck.WBConnected, myWeight, msg);
                                }
                                else
                                {
                                    TIQStatusAudit(myTIQRow.TIQID, "Q", frmWeighTruck.WBID, frmWeighTruck.WBConnected, myWeight, "weight logged");
                                    decimal myQty = myWeight - myTIQRow.Tare;
                                    myTIQRow.Gross = myWeight;
                                    myTIQRow.Nett = myQty;
                                    string myTruckRego = myTIQRow.Rego;
                                    myTIQRow.WeighbridgeID = frmWeighTruck.WBID;
                                    myTIQRow.WBConnected = frmWeighTruck.WBConnected;
                                    bsTIQ2.EndEdit();
                                    taTIQ2.Update(dsTIQ2.TIQ);
                                    if (ConfirmPostDocket())
                                    {
                                        if (myTruckConfig == "TKs" || myTruckConfig == "BDa")
                                        {
                                            int myPosition = bsTIQ2.Find("ParentTIQID", myTIQID);
                                            if (myPosition >= 0)
                                            {
                                                ReleaseSplit(myTruckRego, myWeight);
                                            }
                                        }
                                        PostDocket();
                                    }
                                }
                            }
                            else
                            {
                                LockTIQUsp(myTIQRow.TIQID, "U");
                                MessageBox.Show("Weighing cancelled!");
                            }
                            break;
                        case "S":
                            MessageBox.Show("Please process truck first!", "Split Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "X": // Truck or Trailer Only Split Load
                            frmWeighTruck = new WeighTruck("Collect weight with both truck and trailer on weighbridge.", mySiteID);
                            dr = frmWeighTruck.ShowDialog();
                            myWeight = frmWeighTruck.Weight;
                            if (dr == DialogResult.OK)
                            {
                                //string myRego = myTIQRow.Rego;
                                //int myTruckConfigID = myTIQRow.TruckConfigID;
                                //int myDriverID = myTIQRow.DriverID;
                                //int myParentTIQID = myTIQRow.TIQID;
                                //string myTruckConfig = myTIQRow.TruckConfig;

                                int myWBID = frmWeighTruck.WBID;
                                bool myWBConnected = frmWeighTruck.WBConnected;

                                TIQStatusAudit(myTIQRow.TIQID, "X", myWBID, myWBConnected, myWeight, "temp tare captured");

                                myTIQRow.Tare = myWeight;
                                myTIQRow.WeighbridgeID = myWBID;
                                myTIQRow.WBConnected = myWBConnected;
                                myTIQRow.QueueStatus = "Q";
                                bsTIQ2.EndEdit();
                                taTIQ2.Update(dsTIQ2.TIQ);
                            }
                            break;

                        default:
                            break;
                    }
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
            BookInTruck frmBookInStep1 = new BookInTruck(Rego, TruckConfigID, DriverID, ParentTIQID ,"TruckConfig", msg, TrailerConfig );
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
                //MessageBox.Show("Retare form OK");
            }
        }

        private void PostDocket()
        {
            // create new WBDockets row using NewDocket, then add lines
            // TODO ensure docket has not already been posted, in case second WBO tries to sneak in!@#
            dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
            int DocketExists = CheckDocketExists(myTIQRow.TIQID);
            if (DocketExists == 0)
            {
                int myTIQID = myTIQRow.TIQID;
                int myDocNum = GetDocNum();
                if (myDocNum > 0)
                {
                    NewDocket(myDocNum);
                    taWBDockets.Update(dsTIQ2.WBDockets);
                    int myOrderBaseEntry = 0;
                    myOrderBaseEntry = GetOrderDocEntry(myTIQRow.SAPOrder);
                    if (myOrderBaseEntry > 0) // i.e. SAP Order
                    {
                        int iRows = taQuarryOrderLines.FillByDocEntry(dsBookIn.QuarryOrderLines, myOrderBaseEntry);
                        for (int i = 0; i < iRows; i++) // Order LineNum is also zero based
                        {
                            dsBookIn.QuarryOrderLinesRow myOrderLine = (dsBookIn.QuarryOrderLinesRow)dsBookIn.QuarryOrderLines.Rows[i];
                            switch (myOrderLine.SWW)
                            {
                                case "Items":
                                    DocketLineAdd(myOrderLine.ItemCode, myOrderLine.Dscription, GetItemQA(myTIQRow.Material), GetItmsGrpCod(myOrderLine.ItemCode), myOrderLine.SWW, mySPLotNo, myOrderLine.DocEntry);
                                    break;
                                case "Imported":
                                    DocketLineAdd(myOrderLine.ItemCode, myOrderLine.Dscription, GetItemQA(myTIQRow.Material), GetItmsGrpCod(myOrderLine.ItemCode), myOrderLine.SWW, mySPLotNo, myOrderLine.DocEntry);
                                    break;
                                case "Freight":
                                    DocketLineAdd(myOrderLine.ItemCode, myOrderLine.Dscription, false, 99, myOrderLine.SWW, 0, myOrderLine.DocEntry);
                                    break;
                                case "Other":
                                    // surcharge maybe
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        // ExBin No Order
                        DocketLineAdd(myTIQRow.Material, myTIQRow.MaterialDesc, GetItemQA(myTIQRow.Material), GetItmsGrpCod(myTIQRow.Material), "Items", mySPLotNo, myOrderBaseEntry);
                    }
                    if (myTIQRow.Nett < Properties.Settings.Default.MinimumMaterial)
                    {
                        string ShortLoadFee = Properties.Settings.Default.ShortLoadFee;
                        DocketLineAdd(ShortLoadFee, "Short Load Fee", GetItemQA(ShortLoadFee), GetItmsGrpCod(ShortLoadFee), "Other", 0, 0);
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
        }

        private int GetDocNum()
        {
            try
            {
                int DocNumNext = 0;
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
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
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
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

        private int CheckDocketExists(int TIQID)
        {
            try
            {
                int DocketExists;
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DocketExists";
                cmd.Parameters.AddWithValue("@TIQID", TIQID);
                sqlConnection.Open();
                DocketExists = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                if (DocketExists > 0)
                {
                    MessageBox.Show("Cannot proceed as Docket already exists: " + DocketExists.ToString(),"CheckDocketExists",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                return DocketExists;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CheckDocketExists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -99;
            }
        }

        private int GetItmsGrpCod(string ItemCode)
        {
            try
            {
                int ItmsGrpCod;
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ItmsGrpCod from SAP_OITM where ItemCode like '" + ItemCode + "'";
                sqlConnection.Open();
                ItmsGrpCod = System.Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                return ItmsGrpCod;
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
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
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
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
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

        private void TIQStatusAudit(int TIQID, string Status, int WBID, bool WBConnected, decimal WBReading, string Comment)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQStatusAuditAdd";
                cmd.Parameters.AddWithValue("@TIQID", TIQID);
                cmd.Parameters.AddWithValue("@SiteID", mySiteID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Computer", ComputerName);
                cmd.Parameters.AddWithValue("@Domain", Domain);
                cmd.Parameters.AddWithValue("@Operator", WeighbridgeOperator);
                cmd.Parameters.AddWithValue("@WBID", WBID);
                cmd.Parameters.AddWithValue("@WBConnected", WBConnected);
                cmd.Parameters.AddWithValue("@WBReading", WBReading);
                cmd.Parameters.AddWithValue("@Comments", Comment);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TIQStatusAudit Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LockTIQ(int TIQID)
        {
            // Called by button Weigh (F9) so applies to retare as well as post docket
            // First check if locked by someone else using username, machine name and process ID
            // If not locked then apply lock
            try
            {
                string LockMsg = LockTIQUsp(TIQID, "L");
                if (LockMsg == "Locked")
                {
                    return true;
                }
                else
                {
                    DialogResult dr1 = MessageBox.Show(LockMsg + "\r\nDo you want to takeover?", "TIQ Lock", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dr1 == DialogResult.Yes)
                    {
                        LockMsg = LockTIQUsp(TIQID, "T");
                        if (LockMsg == "Locked")
                        {
                            return true;
                        }
                        else if (LockMsg == "Too Soon")
                        {
                            // TODO update USP
                            MessageBox.Show("Too soon");
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LockTIQ ERROR!",MessageBoxButtons.OK);
                return false;
            }

        }

        private string LockTIQUsp(int TIQID, string LockAction)
        {
            try
            {
                int ProcessID = System.Diagnostics.Process.GetCurrentProcess().Id;
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQLock";
                cmd.Parameters.AddWithValue("@TIQID", TIQID);
                cmd.Parameters.AddWithValue("@ProcessID", ProcessID);
                cmd.Parameters.AddWithValue("@Username", WeighbridgeOperator);
                cmd.Parameters.AddWithValue("@Computer", ComputerName);
                cmd.Parameters.AddWithValue("@LockAction", LockAction);
                sqlConnection.Open();
                string LockMsg = cmd.ExecuteScalar().ToString();
                sqlConnection.Close();
                return LockMsg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Error";
            }
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

        private void DocketLineAdd(string ItemCode, string ItemDescription, bool ItemQA, int ItmsGrpCod, string SWW, int SPLot, int BaseEntry)
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
                linesRow.DocketLine = iLines;
                linesRow.WarehouseCode = "7";
                linesRow.ItemCode = ItemCode;
                linesRow.ItemDescription = ItemDescription;
                linesRow.ItemQA = ItemQA;
                linesRow.ItmsGrpCod = ItmsGrpCod;
                linesRow.SWW = SWW;
                linesRow.StockpileLot = SPLot;
                linesRow.AgrNo = CurrentTIQ().AgrNo;
                linesRow.AgrLine = CurrentTIQ().AgrLine;
                string UOM = ItemCode.Substring(ItemCode.Length - 1, 1);
                if (UOM=="1")
                {
                    linesRow.Quantity = 1.0M;
                }
                else
                {
                    if (SWW == "Freight" && CurrentTIQ().Nett < Properties.Settings.Default.MinimumCart)
                    {
                        linesRow.Quantity = Properties.Settings.Default.MinimumCart;
                    }
                    else
                    {
                        linesRow.Quantity = CurrentTIQ().Nett;
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

        private void RemoveFromTIQ(int TIQID, string Comment)
        {
            try
            {
                int iStatus = 0;               
                SqlConnection sqlConnection = new SqlConnection(myConnectionString);
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
            ButtonUpdate(); // button labelled Update (F4)
        }

        private void ButtonUpdate()
        {
            try
            {
                bool blSave = false;
                if (bsTIQ2.Count > 0)
                {

                    switch (CurrentTIQ().QueueStatus)
                    {
                        case "U":
                            if (CheckConfirmCustomer() == true)
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
                            DialogResult drHold = MessageBox.Show("Has Queue KPI been met?", "Queue KPI Hold", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drHold == DialogResult.Yes)
                            {
                                blSave = true;
                                CurrentTIQ().QueueStatus = "Q";
                            }
                            break;
                        case "K":
                            DialogResult dr1 = MessageBox.Show("Please continue booking in process.", "Parked Up.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dr1 == DialogResult.Yes)
                            {
                                ContinueInProgress();
                            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckConfirmCustomer()
        {
            ConfirmCustomer frmConfirmCustomer = new ConfirmCustomer(CurrentTIQ().Rego,CurrentTIQ().DriverID, CurrentTIQ().CustomerCode, CurrentTIQ().Customer);
            DialogResult dr = frmConfirmCustomer.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void ContinueInProgress()
        {
            try
            {
                BookInTruck frmBookIn = new BookInTruck(CurrentTIQ().TIQID, CurrentTIQ().Rego, CurrentTIQ().TruckConfigID, CurrentTIQ().DriverID, true);
                frmBookIn.MdiParent = this.MdiParent;
                frmBookIn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TrucksInQuarry_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {     
                case Keys.F2:
                    BookInTruck();
                    break;
                case Keys.F4:
                    ButtonUpdate();
                    break;
                case Keys.F5:
                    RefreshQueue();
                    break;
                case Keys.F8:
                    PrintDocket();
                    break;
                case Keys.F9:
                    GoToWeighTruck();
                    break;
                case Keys.F12:
                    TINRemove();
                    break;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int DelaySeconds = Properties.Settings.Default.ClearTIQDelay * 1000;
                ClearTIQDelayed(DelaySeconds);
            }
        }

        private async void ClearTIQDelayed(int DelaySeconds)
        {
            await Task.Delay(DelaySeconds);
            ClearTIQ();
        }

        private void btnPrintDocket_Click(object sender, EventArgs e)
        {
            PrintDocket();
        }

        private void PrintDocket()
        {
            var parent = this.MdiParent as QWS_MDIParent;
            parent.PrintDocket();
        }
    }
}
