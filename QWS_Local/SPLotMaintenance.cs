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
    public partial class SPLotMaintenance : Form
    {
        public SPLotMaintenance()
        {
            InitializeComponent();
        }

        private void SPLotMaintenance_Load(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Remove(tpBaseItem);
        }

        private void FindLotsByItemCode()
        {
            try
            {
                taStockpileLotAllocation.FillByItemCode(dsTIQ2.StockpileLotAllocation, CurrentItemsMap().ItemCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowBOM4ItemCode(string ItemCode)
        {
            try
            {
                taStockpileBOM.FillByItemCode(dsTIQ2.StockpileBOM, ItemCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetReportData_Click(object sender, EventArgs e)
        {
            GetReportData(true);
        }

        private void GetReportData(bool ByLotNo)
        {
            try
            {
                if (ByLotNo == true)
                {
                    int SPLotNo;
                    SPLotNo = System.Convert.ToInt32(txtSPLotNo.Text);
                    this.taSPLotNoAudit.Fill(this.dsTIQ2.SPLotNoAudit, txtItem2Report.Text, SPLotNo);
                }
                else
                {
                    this.taSPLotNoAudit.FillByItemCode(this.dsTIQ2.SPLotNoAudit, txtItem2Report.Text);
                }
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAllocation();
        }

        private void SaveAllocation()
        {
            try
            {
                bsStockpileLotAllocation.EndEdit();
                taStockpileLotAllocation.Update(dsTIQ2.StockpileLotAllocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsTIQ2.StockpileLotAllocationRow CurrentStockpile()
        {
            try
            {
                    DataRow myDR = ((DataRowView)bsStockpileLotAllocation.Current).Row;
                    dsTIQ2.StockpileLotAllocationRow stockpileRow = (dsTIQ2.StockpileLotAllocationRow)myDR;
                    return stockpileRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        private dsTIQ2.SPLotItemsMapRow CurrentItemsMap()
        {
            try
            {
                DataRow myDR = ((DataRowView)bsSPLotItemsMap.Current).Row;
                dsTIQ2.SPLotItemsMapRow itemsMapRow = (dsTIQ2.SPLotItemsMapRow)myDR;
                return itemsMapRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnSaveManualAllocation_Click(object sender, EventArgs e)
        {
            SaveManualAllocation();
        }

        private void SaveManualAllocation()
        {
            try
            {
                bsStockpileManualAllocation.EndEdit();
                taStockpileManualAllocation.Update(dsTIQ2.StockpileManualAllocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshManualAllocation_Click(object sender, EventArgs e)
        {
            GetManualAllocation();
        }

        private void GetManualAllocation()
        {
            if (txtManualItemCode.Text.Length > 0)
            {
                this.taStockpileManualAllocation.FillByItemCode(this.dsTIQ2.StockpileManualAllocation,txtManualItemCode.Text);
            }
            else
            {
                this.taStockpileManualAllocation.Fill(this.dsTIQ2.StockpileManualAllocation);
            }
        }
      
        private void btnFindBaseItemCode_Click(object sender, EventArgs e)
        {
            FindBaseItemCode(); // to display for MCO
            GetStockpileLotAllocations(txtBaseItemCode.Text); // to get existing allocations
        }

        private void FindBaseItemCode()
        {
            try
            {
                taStockpileBOM.FillByItemCode(dsTIQ2.StockpileBOM, txtItemCode.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpen.Checked == true)
            {
                bsStockpileLotAllocation.Filter = "LotStatus like 'O'";
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
            {
                bsStockpileLotAllocation.Filter = "";
            }
        }

        private void btnAddAllocation_Click(object sender, EventArgs e)
        {
            GetStockpileLotAllocations(txtBaseItemCode.Text);
        }

        private void GetStockpileLotAllocations(string BaseItemCode)
        {
            try
            {
                taStockpileLotAllocation.FillByItemCode(dsTIQ2.StockpileLotAllocation, BaseItemCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbLotNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if ( rbLotNoFilter.Checked == true)
            {
                if (Int32.TryParse(txtLotNo.Text,out Int32 numValue))
                {
                    bsStockpileManualAllocation.Filter = "SPLotNo = '" + txtLotNo.Text + "'";
                }
                else
                {
                    MessageBox.Show("Cannot convert " + txtLotNo.Text + " to an integer!");
                }                
            }
        }

        private void rbClearFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClearFilter.Checked == true)
            {
                bsStockpileManualAllocation.Filter = "";
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            GetAllStockpileLotAllocations();
        }

        private void GetAllStockpileLotAllocations()
        {
            try
            {
                taStockpileLotAllocation.Fill(dsTIQ2.StockpileLotAllocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaseItemMapping_Click(object sender, EventArgs e)
        {
            taSPLotItemsMap.Fill(dsTIQ2.SPLotItemsMap);
        }

        private void btnSaveBaseItemMapping_Click(object sender, EventArgs e)
        {
            //taSPLotItemsMap
            // TODO add update method to data adaptor
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dsTIQ2.SPLotItemsMap.Clear();
        }

        private void btnFindAllDockets_Click(object sender, EventArgs e)
        {
            GetReportData(false);
        }

        private void btnAddAllocation_Click_1(object sender, EventArgs e)
        {            
            AddAllocation();
        }

        private void AddAllocation()
        {
            MessageBox.Show("Add new record.");
            // check docket number exists and not allocated already
            // get ItemCode from Docket
            // create new record
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int DocNum2Check = -99;
            DocNum2Check = System.Convert.ToInt32(txtDocNum2Check.Text);
            CheckDocNumAllocation(DocNum2Check);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckDocNumAllocation(int DocNum)
        {
            MessageBox.Show("Checking docket");
        }
    }
}
