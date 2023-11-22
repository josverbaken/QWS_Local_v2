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
            // TODO link to NHVL
            //this.nHVR_GVMTableAdapter.Fill(this.dsQWSLocal.NHVR_GVM);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.nHVRGVMBindingSource.EndEdit();
            //this.nHVR_GVMTableAdapter.Update(this.dsQWSLocal.NHVR_GVM);
        }
    }
}
