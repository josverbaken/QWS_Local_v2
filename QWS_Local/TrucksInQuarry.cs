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
    public partial class TrucksInQuarry : Form
    {
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

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshQueue();
        }

        private void RefreshQueue()
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
            // TODO run truckconfigsearch as if from vehiclemaintenance or truckconfiguration
            //BookInTruck frmBookIn = new BookInTruck();
            //frmBookIn.MdiParent = this.MdiParent;
            //frmBookIn.Show();
            //TruckConfiguration frmTruckConfig = new TruckConfiguration();
            //frmTruckConfig.MdiParent = this.MdiParent;
            //frmTruckConfig.Show();
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
            // 20240312 JV Swap to tabControl with List and Details tabs as elsewhere
            tabControl1.SelectedTab = tpDetails;
            // get TIQID of selected row
            // test that a row is selected
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataRow dataRow = ((DataRowView)bsTIQ.Current).Row;
            //    dsQWSLocal.TrucksInQuarryRow trucksInQuarryRow = (dsQWSLocal.TrucksInQuarryRow)dataRow;
            //    int TIQID = trucksInQuarryRow.TIQID;
            //    TIQDetail frmTIQDetail = new TIQDetail(TIQID);
            //    frmTIQDetail.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Please select a row!");
            //}
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
            dataGridView1.ClearSelection();
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
        }

        private void TINRemove()
        {
            try 
            { 
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
