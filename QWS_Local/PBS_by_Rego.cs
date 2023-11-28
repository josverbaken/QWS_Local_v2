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
    public partial class PBS_by_Rego : Form
    {
        public PBS_by_Rego()
        {
            InitializeComponent();
        }

        private void PBS_by_Rego_Load(object sender, EventArgs e)
        {
            // nothing to do at this stage
        }

        private void btnGetPBSbyRego_Click(object sender, EventArgs e)
        {
            try
            {
                //int iRow;
                //iRow = this.pBSbyRegoTableAdapter.FillByRego(this.dsQWSLocal.PBSbyRego, txtRego.Text);
                //if (iRow ==0)
                //{
                //    MessageBox.Show("No truck found!");
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
