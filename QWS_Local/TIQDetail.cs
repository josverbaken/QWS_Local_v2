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
    public partial class TIQDetail : Form
    {
        public TIQDetail()
        {
            InitializeComponent();
        }

        public TIQDetail(int TIQID)
        {
            InitializeComponent();
            GetTIQDetail(TIQID);
        }

        //private void trucksInQuarryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.trucksInQuarryBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dsQWSLocal);

        //}

        private void TIQDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQWSLocal.TrucksInQuarry' table. You can move, or remove it, as needed.
            //this.trucksInQuarryTableAdapter.Fill(this.dsQWSLocal.TrucksInQuarry);

        }

        private void GetTIQDetail(int TIQID)
        {
            this.trucksInQuarryTableAdapter.FillByTIQID(this.dsQWSLocal.TrucksInQuarry,TIQID);
        }
    }
}
