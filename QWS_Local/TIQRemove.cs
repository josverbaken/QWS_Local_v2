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
        private string _RemoveReason;
        private string _RemoveCode;

        public string RemoveReason
        {
            get { return _RemoveReason; }
        }

        public string RemoveCode
        {
            get { return _RemoveCode; }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            _RemoveCode = "Z";
            RemoveAndClose();
        }

        private void btnRebook_Click(object sender, EventArgs e)
        {
            _RemoveCode = "R";
            RemoveAndClose();
        }

        private void RemoveAndClose()
        {
            _RemoveReason = txtReason.Text;
            if (_RemoveReason.Length < 5)
            {
                MessageBox.Show("Please enter the reason for removal.", "Reason not supplied.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
