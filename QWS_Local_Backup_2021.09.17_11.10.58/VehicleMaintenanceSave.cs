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
    public partial class VehicleMaintenanceSave : Form
    {
        private string myRadioButtonAction;

        public string RadioButtonAction
        {
            get { return myRadioButtonAction; }
        }
        public VehicleMaintenanceSave()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CheckRadioButtons();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void CheckRadioButtons()
        {
            if (rbAddTrailer.Checked == true)
            {
                myRadioButtonAction = "AddTrailer";
            }
            if (rbAddTruck.Checked == true)
            {
                myRadioButtonAction = "AddVehicle";
            }
            if (rbConfigureTruck.Checked == true)
            {
                myRadioButtonAction = "ConfigureTruck";
            }
            if (rbReview.Checked == true)
            {
                myRadioButtonAction = "View";
            }
        }

        private void VehicleMaintenanceSave_Load(object sender, EventArgs e)
        {
            UncheckRadioButtons();
        }

        private void UncheckRadioButtons()
        {
            rbAddTrailer.Checked = false;
            rbAddTruck.Checked = false;
            rbConfigureTruck.Checked = false;
            rbReview.Checked = false;
        }
    }
}
