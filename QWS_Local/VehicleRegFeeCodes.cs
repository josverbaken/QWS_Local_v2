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
    public partial class VehicleRegFeeCodes : Form
    {
        public VehicleRegFeeCodes()
        {
            InitializeComponent();
        }

        private void VehicleRegFeeCodes_Load(object sender, EventArgs e)
        {
            try
            {
                this.taFeeCodes.Fill(this.dsQWSLocal2024.VehicleRegFeeCodes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
 
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bsFeeCodes.EndEdit();
            this.taFeeCodes.Update(this.dsQWSLocal2024.VehicleRegFeeCodes);
        }
    }
}
