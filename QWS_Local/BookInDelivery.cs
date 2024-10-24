﻿using System;
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
    public partial class BookInDelivery : Form
    {
        private static int TruckConfigID;
        private static int TIQID;
        private string LoadType = "TK";
        private dsQWSLocal2024.TruckDriverRow DriverRow;
        private bool FormLoaded = false;

        public BookInDelivery()
        {
            InitializeComponent();
        }

        public BookInDelivery(int myTIQID, int myTruckConfigID, dsQWSLocal2024.TruckDriverRow driverRow)
        {
            InitializeComponent();
            TIQID = myTIQID;
            TruckConfigID = myTruckConfigID;
            DriverRow = driverRow;
        }

        private void BookInDelivery_Load(object sender, EventArgs e)
        {
            taConfiguredTruckGVM.Fill(this.dsTruckConfig.ConfiguredTruckGVM, "", TruckConfigID);
            LoadTIQ();
            DeliveryOrdersLoad();
            LoadDriver();
            FormLoaded = true;
            dataGridView1.ClearSelection();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DeliveryOrdersLoad();
            // TODO: add parameter for cartage type n6 or n7
        }

        private void LoadTIQ()
        {
            int iRow = taTIQ2.FillBy(dsTIQ2.TIQ, 7, TIQID);
            if (iRow != 1)
            {
                MessageBox.Show("Error loading TIQ row!");
            }
        }

        private void DeliveryOrdersLoad()
        {
            this.taDeliveryOrders.FillByOpenQty(this.dsBookIn.DeliveryOrdersAll);
        }

        private void LoadDriver()
        {
            dsQWSLocal2024.TruckDriver.Clear();
            dsQWSLocal2024.TruckDriver.ImportRow(DriverRow);
        }

        private void btnBookIn_Click(object sender, EventArgs e)
        {
            AddDelivery2TIQ();
        }

        private void AddDelivery2TIQ()
        {
            try
            {
                SetTIQPayload();
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                myTIQRow.AllocateDTTM = DateTime.Now;
                //myTIQRow.SAPOrder = CurrentDeliveryOrder().DocNum;
                if (CurrentDeliveryOrder().ItemQA == "Y")
                {
                    myTIQRow.StockpileLotNo = -9;
                }
                else
                {
                    myTIQRow.StockpileLotNo = 0;
                }
                myTIQRow.QueueStatus = "Q";
                bsTIQ2.EndEdit();
                int iRow = taTIQ2.Update(dsTIQ2.TIQ);
                if (iRow == 1) // TODO test if split load
                {
                    if (txtTruckConfig.Text == "TKs")
                    {
                        MessageBox.Show("To book in TRs", "Split Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GoBack2BookIn(CurrentTIQ().Rego, CurrentTIQ().TruckConfigID, CurrentTIQ().DriverID);
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
                MessageBox.Show(ex.Message, "AddDelivery2TIQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private dsBookIn.DeliveryOrdersAllRow CurrentDeliveryOrder()
        {
            if (bsDeliveryOrders.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsDeliveryOrders.Current).Row;
                dsBookIn.DeliveryOrdersAllRow deliveryRow = (dsBookIn.DeliveryOrdersAllRow)myRow;
                return deliveryRow;
            }
            else
            {
                return null;
            }
        }

        private void btnPayload_Click(object sender, EventArgs e)
        {
            CalcPayload();
        }

        private dsTIQ2.TIQRow CurrentTIQ()
        {
            try
            {
                if (bsTIQ2.Count > 0)
                {
                    DataRow myRow = ((DataRowView)bsTIQ2.Current).Row;
                    dsTIQ2.TIQRow myTIQRow = (dsTIQ2.TIQRow)myRow;
                    return myTIQRow;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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

        private void CalcPayload()
        {
            decimal myPayload = 0.0M;
            decimal myPayloadTk = 0.0M;
            decimal myPayloadTr = 0.0M;

            decimal PayloadLimit;
            if (CurrentTruckGVM().GCM > CurrentTruckGVM().MaxGVM && CurrentTruckGVM().MaxGVM > 0)
            {
                PayloadLimit = CurrentTruckGVM().MaxGVM - CurrentTruckGVM().Tare;
            }
            else
            {
                PayloadLimit = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
            }

            myPayload = PayloadLimit;
            nudPayload.Value = myPayload;
            if (CurrentTruckGVM().Compartments > 1)
            //if (CurrentTruckGVM().GCM != CurrentTruckGVM().GVMTruck)
            {
                myPayloadTk = CurrentTruckGVM().GVMTruck - CurrentTruckGVM().TareTk;
                myPayloadTr = myPayload - myPayloadTk;
                nudPayloadTk.Value = myPayloadTk;
                nudPayloadTk.Enabled = true;
                nudPayloadTr.Value = myPayloadTr;
                nudPayloadTr.Enabled= true;
                txtPayloadSplit.Text = myPayloadTk.ToString() + " / " + myPayloadTr.ToString() + " (" + myPayload.ToString() + ")";
            }
            else
            {
                txtPayloadSplit.Text = myPayload.ToString(); //string.Empty;
                nudPayloadTk.Enabled = false;
                nudPayloadTr.Enabled = false;
            }
            bsTIQ2.EndEdit();
        }

        private void SetTIQPayload()
        {
            dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
            myTIQRow.Payload = nudPayload.Value;
            if (txtPayloadSplit.Text.Length == 0)
            {
                txtPayloadSplit.Text = nudPayload.Value.ToString();
            }
            else
            {
                myTIQRow.PayloadSplit = txtPayloadSplit.Text;
            }
            if (LoadType.Length == 3)
            {
                myTIQRow.TruckConfig = LoadType;
            }
            bsTIQ2.EndEdit();
        }
        private void PayloadNUDLimit()
        {
            decimal PayloadLimit;
            if (CurrentTruckGVM().GCM > CurrentTruckGVM().MaxGVM && CurrentTruckGVM().MaxGVM > 0 )
            {
                PayloadLimit = CurrentTruckGVM().MaxGVM - CurrentTruckGVM().Tare;
            }
            else
            {
                PayloadLimit = CurrentTruckGVM().GCM - CurrentTruckGVM().Tare;
            }
            
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

        private void btnPayloadValidate_Click(object sender, EventArgs e)
        {
            PayloadValidate();
        }

        private void btnPayload_Click_1(object sender, EventArgs e)
        {
            CalcPayload();
        }

        private void btnPayloadValidate_Click_1(object sender, EventArgs e)
        {
            PayloadValidate();
        }

        private void nudPayload_ValueChanged(object sender, EventArgs e)
        {
            PayloadNUDLimit();
        }

        private void bsConfiguredTruckGVM_CurrentChanged(object sender, EventArgs e)
        {
            if (bsConfiguredTruckGVM != null)
            {
                CalcPayload();
            }
        }

        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            SetTIQOrderDetails();
        }

        private void SetTIQOrderDetails()
        {
            try
            {
                dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
                myTIQRow.SAPOrder = CurrentDeliveryOrder().DocNum;
                myTIQRow.CustomerCode = CurrentDeliveryOrder().CardCode;
                myTIQRow.Customer = CurrentDeliveryOrder().Customer;
                myTIQRow.CustON = CurrentDeliveryOrder().PurchaseOrder;
                myTIQRow.Material = CurrentDeliveryOrder().MaterialCode;
                myTIQRow.MaterialDesc = CurrentDeliveryOrder().Material;
                myTIQRow.DeliveryAddress = CurrentDeliveryOrder().DeliveryAddress;
                myTIQRow.CartageCode = CurrentDeliveryOrder().CartageCode;
                bsTIQ2.EndEdit();
                tabControl1.SelectedTab = tpTruckConfig;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetTruckConfig_Click(object sender, EventArgs e)
        {
            SetTIQTruckconfig();
        }

        private void SetTIQTruckconfig()
        {
            dsTIQ2.TIQRow myTIQRow = CurrentTIQ();
            decimal myGCM = CurrentTruckGVM().GCM;
            decimal myMaxGVM = CurrentTruckGVM().MaxGVM;
            if (myGCM > myMaxGVM && myMaxGVM > 0)
            {
                myGCM = myMaxGVM;
            }
            myTIQRow.GCM = myGCM;
            myTIQRow.GVMTruck =  CurrentTruckGVM().GVMTruck;
            bsTIQ2.EndEdit();
            tabControl1.SelectedTab = tpLoading;
            if (CurrentTruckGVM().Compartments > 1)
            {
                btnSplitLoadType.Enabled = true;
            }
            else
            {
                btnSplitLoadType.Enabled = false;   
            }
            CalcPayload();     
            SetSplitLoadGUI(txtTruckConfig.Text);
        }    
     
         private void SetSplitLoadType()
        {
            SplitLoadType frmLoadType = new SplitLoadType();
            DialogResult dr = frmLoadType.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtTruckConfig.Text = frmLoadType.strSplitLoadType;
                bsTIQ2.EndEdit();
                SetSplitLoadGUI(frmLoadType.strSplitLoadType);
            }
            else
            {
                txtTruckConfig.Text = "Cancelled!";
            }
        }

        private void SetSplitLoadGUI(string LoadType)
        {
            if (LoadType == "TK")
            {
                txtGVMTruck.Visible = false;
                txtTareTruck.Visible = false;   
                txtPayloadSplit.Visible = false;
                nudPayloadTk.Visible = false;
                nudPayloadTr.Visible = false;
                //lblPayloadSplit.Visible = false;
            }
            else
            {
                txtGVMTruck.Visible = true;
                txtTareTruck.Visible = true;
                txtPayloadSplit.Visible = true;
                nudPayloadTk.Visible = true;
                nudPayloadTr.Visible = true;
                //lblPayloadSplit.Visible = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bsDeliveryOrders.Count > 0 && FormLoaded == true && dataGridView1.SelectedRows.Count == 1) 
            {
                DialogResult dr = MessageBox.Show("Move to details ?","Choose Order",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    tabControl1.SelectedTab = tpDetails;
                }
            }            
        }

        private void btnSplitLoadType_Click(object sender, EventArgs e)
        {
            SetSplitLoadType();
        }

        private void GoBack2BookIn(string Rego, int TruckConfigID, int DriverID)
        {
            //called after retare successful
            BookInTruckStep1 frmBookInStep1 = new BookInTruckStep1(Rego, TruckConfigID, DriverID, CurrentTIQ().TruckConfig, "Called after book in TKs.");
            frmBookInStep1.MdiParent = this.MdiParent;
            frmBookInStep1.Show();
        }
    }
}
