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

namespace QWS_Local
{
    public partial class TrucksInQuarry : Form
    {
        public TrucksInQuarry()
        {
            InitializeComponent();
        }

        private void TrucksInQuarry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTIQ2.WBDocketLines' table. You can move, or remove it, as needed.
            //this.taWBDocketLines.Fill(this.dsTIQ2.WBDocketLines);
            // TODO: This line of code loads data into the 'dsTIQ2.WBDockets' table. You can move, or remove it, as needed.
            //this.taWBDockets.Fill(this.dsTIQ2.WBDockets);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
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
                frmTIQRemove.ShowDialog();
                // TODO show dialogue and only remove if OK
            CurrentTIQ().TIQOpen = false;
            bsTIQ2.EndEdit();
            taTIQ2.Update(dsTIQ2.TIQ);
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
                WeighTruck frmWeighTruck = new WeighTruck();
                DialogResult dr = frmWeighTruck.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string msg = "Weight = ";
                    msg += frmWeighTruck.Weight.ToString();
                    msg += "t";
                    MessageBox.Show(msg); 
                    CurrentTIQ().Gross = frmWeighTruck.Weight;
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
                MessageBox.Show(frmPostDocket.SPLotNo.ToString());
                return true;
            }
            return false;
        }

        private void PostDocket()
        {

        }

        private void NewDocket(int DocNum)
        {
            //btnSave.Enabled = false;
            //txtOverloaded.Visible = false;

            dsTIQ2.WBDockets.Clear();
            dsTIQ2.WBDocketLines.Clear();

            DataRow dr = dsTIQ2.WBDockets.NewRow();
            dsTIQ2.WBDocketsRow docketsRow = (dsTIQ2.WBDocketsRow)dr;
            docketsRow.DocNum = DocNum;
            docketsRow.DocDate = DateTime.Now;
            docketsRow.CardCode = "";
            docketsRow.CardName = "";
            docketsRow.PurchaseOrder = "";
            docketsRow.CntCode = -9;
            docketsRow.ContactName = "";
            docketsRow.ContactMobile = "";
            docketsRow.DeliveryDate = DateTime.Now;
            docketsRow.DeliveryAddress = "";
            docketsRow.MapRef = "";
            docketsRow.Distance = 0;
            docketsRow.TruckRego = "";
            docketsRow.TruckOwnerCode = "tba";
            docketsRow.TruckOwner = "";
            docketsRow.TruckConfig = "";
            docketsRow.TruckConfigID = 1;
            docketsRow.GrossLegal = 0;
            docketsRow.Gross = 0;
            docketsRow.Tare = 0;
            docketsRow.Nett = 0;
            docketsRow.WBMode = "m";
            docketsRow.TruckDriverID = -1;
            docketsRow.TruckDriver = "";//"Truck Driver";
            docketsRow.SalesPersonCode = -1;
            docketsRow.SalesPerson = "";//"Weighbridge Operator";
            docketsRow.Comments = "";
            docketsRow.CreatedDTTM = DateTime.Now;
            dsTIQ2.WBDockets.AddWBDocketsRow(docketsRow);
            bsWBDockets.EndEdit();

            //dtpDeliveryDTTM.Enabled = true;
            //dtpDeliveryDTTM.Focus();
        }

        private void DocketLineAdd(string ItemCode, string ItemDescription, bool ItemQA, int ItmsGrpCod, int SPLot, int BaseEntry)
        {
            try
            {
                // Transfer DocNum
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
                linesRow.Quantity = 0; //was docketsRow.Nett; but now have to wait for determination of nett
                linesRow.CreatedDTTM = DateTime.Now;
                dsTIQ2.WBDocketLines.AddWBDocketLinesRow(linesRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DocketLineAdd Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
