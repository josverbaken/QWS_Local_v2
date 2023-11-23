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
    public partial class NHVR_GVM : Form
    {
        public NHVR_GVM()
        {
            InitializeComponent();
        }

        private void NHVR_GVM_Load(object sender, EventArgs e)
        {
            this.nHVLTableAdapter.Fill(this.dsQWSLocal1.NHVL);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHVLBindingSource.EndEdit();
            this.nHVLTableAdapter.Update(this.dsQWSLocal1.NHVL);
        }
    }
}
