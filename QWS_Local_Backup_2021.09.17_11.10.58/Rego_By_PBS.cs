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
    public partial class Rego_By_PBS : Form
    {
        public Rego_By_PBS()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getRegoByPBSTableAdapter.Fill(this.dsQWSLocal.GetRegoByPBS, new System.Nullable<int>(((int)(System.Convert.ChangeType(vehicleApprovalToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            getRegoByPBSBindingSource.Sort ="Version ASC, Rego ASC";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            getRegoByPBSBindingSource.Sort = "Rego ASC, Version ASC";
        }
    }
}
