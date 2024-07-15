using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


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
            if (TruckConfigTare(CurrentTIQ().TruckConfigID, TareTk, Tare) == true)
            {
                // TODO remove from TIQ and resume booking in
                RemoveFromTIQ(CurrentTIQ().TIQID, "Retare successful");
                // clone, set parenttiq and return to bookinstep1 form
                this.Close();
            }
        }

        private void TareTruck_Load(object sender, EventArgs e)
        {
            txtTare.Text = Tare.ToString();
            txtTareTk.Text = TareTk.ToString();
            dsTIQ2.TIQ.ImportRow(TIQRow);
        }

        //private dsTruckConfig.ConfiguredTrucksRow CurrentConfigTruck()
        //{
        //    if (bsConfiguredTrucks.Count > 0)
        //    {
        //        DataRow myRow = ((DataRowView)bsConfiguredTrucks.Current).Row;
        //        dsTruckConfig.ConfiguredTrucksRow configuredTruckRow = (dsTruckConfig.ConfiguredTrucksRow)myRow;
        //        return configuredTruckRow;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        private dsTIQ2.TIQRow CurrentTIQ()
        {
            if (bsTIQ.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsTIQ.Current).Row;
                dsTIQ2.TIQRow TIQRow = (dsTIQ2.TIQRow)myRow;
                return TIQRow;
            }
            else
            {
                return null;
            }
        }


        private bool TruckConfigTare(int TruckConfigID, decimal TareTk, decimal Tare)
        {
            try
            {
                int iStatus = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TruckConfigtareUpdate";
                cmd.Parameters.AddWithValue("@TruckConfigID", TruckConfigID);
                cmd.Parameters.AddWithValue("@TareTk", TareTk);
                cmd.Parameters.AddWithValue("@Tare", Tare);
                sqlConnection.Open();
                iStatus = cmd.ExecuteNonQuery();    
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TruckConfigTareUpate - ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void RemoveFromTIQ(int TIQID, string Comment)
        {
            try
            {
                int iStatus = 0;
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.cnQWSLocal);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIQRemove";
                cmd.Parameters.AddWithValue("@TIQID", TIQID);
                cmd.Parameters.AddWithValue("@Comment",Comment);
                sqlConnection.Open();
                iStatus = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RemoveFromTIQ - ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
