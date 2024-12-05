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
    public partial class PBSManagement : Form
    {
        public PBSManagement()
        {
            InitializeComponent();
        }

        private void PBSManagement_Load(object sender, EventArgs e)
        {
            // nothing at present
        }

        private void btnGetPBS_Click(object sender, EventArgs e)
        {
            GetPBSbyCardCode(txtCardCode.Text);
        }

        private void GetPBSbyCardCode(string CardCode)
        {
            try
            {
                taPBS.FillByCardCode(dsPBS.PBS, CardCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetPBSConfig();
        }

        private void GetPBSConfig()
        {
            int myPBSID = Convert.ToInt32(textBox2.Text);
            taPBSConfig.FillByPBSID(dsPBS.PBS_Config, myPBSID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myPBSConfigID = Convert.ToInt32(textBox1.Text);
            taPBSConfigScheme.FillBy(dsPBS.PBS_ConfigScheme,myPBSConfigID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dsPBS.Clear();
                int myPBSVA = Convert.ToInt32(textBox3.Text);
                taPBS.FillByVA(dsPBS.PBS, myPBSVA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindOwner_Click(object sender, EventArgs e)
        {
            GetOwner();
        }

        private void GetOwner()
        {
            BusinessSearch frmBusinessSearch = new BusinessSearch(txtOwner.Text);
            DialogResult dr = frmBusinessSearch.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show(frmBusinessSearch.BusinessName);
            }
        }
    }
}
