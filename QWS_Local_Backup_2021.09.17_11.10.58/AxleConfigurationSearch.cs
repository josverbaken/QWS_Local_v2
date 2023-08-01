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
    public partial class AxleConfigurationSearch : Form
    {
        private dsQWSLocal.AxleConfigurationRow myAxleConfigurationRow;

        public dsQWSLocal.AxleConfigurationRow _AxleConfigurationRow
        {
            get { return myAxleConfigurationRow; }
        }
        public AxleConfigurationSearch()
        {
            InitializeComponent();
        }

        private void axleConfigurationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.axleConfigurationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQWSLocal);

        }

        private void AxleConfigurationSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQWSLocal.AxleConfiguration' table. You can move, or remove it, as needed.
            this.axleConfigurationTableAdapter.Fill(this.dsQWSLocal.AxleConfiguration);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void SelectAndClose()
        {
            try
            {
                DataRow myDR = ((DataRowView)axleConfigurationBindingSource.Current).Row;
                dsQWSLocal.AxleConfigurationRow axleConfigRow = (dsQWSLocal.AxleConfigurationRow)myDR;
                myAxleConfigurationRow = axleConfigRow;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
