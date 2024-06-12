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
    public partial class PostDocket : Form
    {
        private dsTIQ2.TIQRow myRow;

        public PostDocket()
        {
            InitializeComponent();
        }

        public PostDocket(dsTIQ2.TIQRow row)
        {
            InitializeComponent();
            myRow = row;    
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close ();  
        }

        private void PostDocket_Load(object sender, EventArgs e)
        {
            // import row
            //txtGross.Text = "56.50t";
            dsTIQ2.TIQ.Clear();
            dsTIQ2.TIQ.ImportRow(myRow);
        }
    }
}
