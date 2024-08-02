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
    public partial class TruckConfigMaintenance : Form
    {
        public TruckConfigMaintenance()
        {
            InitializeComponent();
        }

    
        private void GetConfiguredTruckGVM(string Rego, int TruckConfigID)
        {
            try
            {
                taConfiguredTruckGVM.Fill(dsTruckConfig.ConfiguredTruckGVM, "", TruckConfigID);
                // leave Rego as "" to get just by TruckConfigID
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetConfiguredTruck(string Rego)
        {
            try
            {
                this.taConfiguredTrucks.FillByRego(this.dsTruckConfig.ConfiguredTrucks, Rego);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnFindConfiguredTrucks_Click(object sender, EventArgs e)
        {
            GetConfiguredTruck(txtRego.Text);
        }

        private void bsConfiguredTrucks_CurrentChanged(object sender, EventArgs e)
        {
            SyncConfiguredTruckGVM();
        }

        private void SyncConfiguredTruckGVM()
        {
            try
            {
                if (bsConfiguredTrucks.Count > 0)
                {
                    string myRego = CurrentConfigTruck().RegoTk;
                    int myTruckConfigID = CurrentConfigTruck().TruckConfigID;
                    GetConfiguredTruckGVM(myRego, myTruckConfigID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsTruckConfig.ConfiguredTrucksRow CurrentConfigTruck()
        {
            if (bsConfiguredTrucks.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsConfiguredTrucks.Current).Row;
                dsTruckConfig.ConfiguredTrucksRow configuredTruckRow = (dsTruckConfig.ConfiguredTrucksRow)myRow;
                return configuredTruckRow;
            }
            else
            {
                return null;
            }
        }

        private void btnSearchNHVR_Click(object sender, EventArgs e)
        {
            SearchNHVR(CurrentConfigTruck().AxleConfiguration);
        }

        private void SearchNHVR(string AxleConfig)
        {
            NHVR_GVM_Search frmNHVR = new NHVR_GVM_Search(AxleConfig);
            frmNHVR.ShowDialog();
        }
    }
}
