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
    public partial class TareTruck : Form
    {
        private decimal TareTk;
        private decimal Tare;
        private dsTIQ2.TIQRow TIQRow;

        public TareTruck()
        {
            InitializeComponent();
        }

        public TareTruck(decimal TareTk, decimal Tare, dsTIQ2.TIQRow tIQRow)
        {
            InitializeComponent();
            this.TareTk = TareTk;
            this.Tare = Tare;
            TIQRow = tIQRow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            // TODO update tare via USP
            // TODO remove from TIQ and resume booking in
            this.Close();
        }

        private void TareTruck_Load(object sender, EventArgs e)
        {
            txtTare.Text = Tare.ToString();
            txtTareTk.Text = TareTk.ToString();
            dsTIQ2.TIQ.ImportRow(TIQRow);
        }

        private void tIQBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsTIQ.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsTIQ2);

        }

    }
}
