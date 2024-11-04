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
            this.taSPLotItemsMap.Fill(this.dsTIQ2.SPLotItemsMap);
            this.taStockpileLotAllocation.Fill(this.dsTIQ2.StockpileLotAllocation);
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
            GetReportData();
        }

        private void GetReportData()
        {
            try
            {
                int SPLotNo;
                SPLotNo = System.Convert.ToInt32(txtSPLotNo.Text);
                this.taSPLotNoAudit.Fill(this.dsTIQ2.SPLotNoAudit, txtItem2Report.Text, SPLotNo);
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

        private void bsSPLotItemsMap_CurrentChanged(object sender, EventArgs e)
        {
            FindLotsByItemCode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
