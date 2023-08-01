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
    public partial class BusinessPlusPerson : Form
    {
        private string mySAPCode;
        public string _SAPCode
        {
            get { return mySAPCode; }
        }
        public BusinessPlusPerson()
        {
            InitializeComponent();
        }

        private void BusinessPlusPerson_Load(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer2.SplitterDistance = 125;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BusinessPersonFindAll();
        }

        private void BusinessPersonFindAll()
        {
            this.businessTableAdapter.Fill(this.dsQWSLocal.Business);
            this.personTableAdapter.Fill(this.dsQWSLocal.Person);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //bp by name
            BusinessFindByName();
        }

        private void BusinessFindByName()
        {
            this.lblResultCount.Text = this.businessTableAdapter.FillByName(this.dsQWSLocal.Business,this.tspBPName.Text).ToString();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BusinessFindByCode();
        }

        private void BusinessFindByCode()
        {
            this.lblResultCount.Text = this.businessTableAdapter.FillByBPCode(this.dsQWSLocal.Business, this.tspBPCode.Text).ToString();

        }
        private void BusinessFindByCode(string SAPCode)
        {
            this.lblResultCount.Text = this.businessTableAdapter.FillByBPCode(this.dsQWSLocal.Business, SAPCode).ToString();

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PersonFindByName();
        }

        private void PersonFindByName()
        {
            this.lblResultCount.Text = this.personTableAdapter.FillByName(this.dsQWSLocal.Person, this.tspPersonName.Text, this.tspBPName.Text).ToString();
        }
        private void PersonFindByBPCode(string SAPCode)
        {
            this.lblResultCount.Text = this.personTableAdapter.FillByBPCode(this.dsQWSLocal.Person,SAPCode).ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[1] != null)
                {
                    string SAPCode = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //MessageBox.Show(SAPCode);
                    BusinessFindByCode(SAPCode);
                    PersonFindByBPCode(SAPCode);
                    tabControl1.SelectedTab = tpBusinessPlusPerson;
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            PersonFindByTelephone();
        }

        private void PersonFindByTelephone()
        {
            this.lblResultCount.Text =  this.personTableAdapter.FillByTelephone(this.dsQWSLocal.Person, tspTelephone.Text).ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //go to connected BP if code supplied
            if (dataGridView2.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                {
                    string SAPCode = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (SAPCode.Length>0)
                    {
                        //MessageBox.Show(SAPCode);
                        BusinessFindByCode(SAPCode);
                        PersonFindByBPCode(SAPCode);
                        tabControl1.SelectedTab = tpBusinessPlusPerson;
                    }
                }
                    
            }
        }

     

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dr = dataGridView3.Rows[e.RowIndex];
            var strVal = dr.Cells["AccountStatus"].Value.ToString();
            switch (strVal)
            {
                case "A":
                    e.CellStyle.BackColor = SystemColors.Window; //AppWorkspace;
                    break;
                case "H":
                    e.CellStyle.BackColor = Color.LightSalmon;
                    break;
                case "I":
                    e.CellStyle.BackColor = Color.LightSkyBlue;
                    break;
                default:
                    break;
            }
        }

        private void btnUnfiltered_Click(object sender, EventArgs e)
        {
            personBindingSource.Filter = null;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            personBindingSource.Filter = "AccountStatus like 'A'";
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            personBindingSource.Filter = "AccountStatus like 'H'";
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            personBindingSource.Filter = "AccountStatus like 'I'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSAPUpdateDTTM.Text = String.Format("{0:dd MMM yyyy}", txtSAPUpdateDTTM.Text); // System.DateTime.Now);
        }

        private void txtSAPUpdateDTTM_Validated(object sender, EventArgs e)
        {
            txtSAPUpdateDTTM.Text = String.Format("{0:dd MMM yyyy hh:mm }", System.DateTime.Now);
        }

        private void businessBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                mySAPCode = "xyz";
                DataRow dataRow = ((DataRowView)businessBindingSource.Current).Row;
                dsQWSLocal.BusinessRow businessRow = (dsQWSLocal.BusinessRow)dataRow;
                mySAPCode = businessRow.SAPCode;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }


    }
}
