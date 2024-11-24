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
    public partial class TIQRemove : Form
    {
        public TIQRemove()
        {
            InitializeComponent();
        }

        public string TIQRemoveReason;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TIQRemoveReason = txtReason.Text;
            if (TIQRemoveReason.Length < 5 )
            {
                MessageBox.Show("Please enter the reason for removal.","Reason not supplied.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
