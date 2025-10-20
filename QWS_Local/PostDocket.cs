using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class PostDocket : Form
    {
        private dsTIQ2.TIQRow myRow;
        private int mySPLotNo;
        private bool myItemQA;
        private decimal myTareWeight;

        public int SPLotNo
        {
            get { return mySPLotNo; }
        }

        public decimal TareWeight
        {
            get { return myTareWeight; }
        }

        public PostDocket()
        {
            InitializeComponent();
        }

        public PostDocket(dsTIQ2.TIQRow row, bool ItemQA)
        {
            InitializeComponent();
            myRow = row;    
            myItemQA = ItemQA;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            myTareWeight = System.Convert.ToDecimal(txtTare.Text);
            if (myRow.Nett <= 0.0M && myTareWeight == 0.0M)
            {
                MessageBox.Show("Unable to proceed NETT <= 0!\r\nor Tare = 0", "Zero Nett Weight.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PostDocketCancel();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    

        private void PostDocketCancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PostDocket_Load(object sender, EventArgs e)
        {
            dsTIQ2.TIQ.Clear();
            dsTIQ2.TIQ.ImportRow(myRow);
            if (myItemQA)
            {
                GetSPLotNo();
            }
            if (myRow.Nett < 0.0M)
            {
                txtNett.BackColor = Color.LightSalmon;
            }
            decimal UnderloadAmount = myRow.Payload - myRow.Nett;
            bool SplitLoad = false;
            switch (myRow.TruckConfig)
            {
                case "TRs":
                        SplitLoad=true;
                    break;
                case "TKs":
                    SplitLoad = true;   
                    break;
                default:
                    SplitLoad = false;
                    break;
            }
            if (UnderloadAmount > 1.0M && SplitLoad == false)
            {
                txtNett.BackColor = Color.LightPink;
                txtUnderload.Text = "Under by : " + UnderloadAmount.ToString() + "t";
            }
            else
            {
                txtNett.BackColor = Color.PaleGreen;
            }
                CheckCOD(myRow.CustomerCode);
            if (myRow.Tare == 0.0M)
            {
                txtTare.ReadOnly = false;
                MessageBox.Show("Tare = zero! \r\nPlease enter Tare Weight.","Zero Tare ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CheckCOD(string CardCode)
        {
            try
            {
                txtCOD.Visible = false;
                int iRows = taCustomer.FillByCardCode(dsTIQ2.BusinessGetByCode, CardCode);
                if (iRows == 1)
                {
                    dsTIQ2.BusinessGetByCodeRow myCustomerRow = (dsTIQ2.BusinessGetByCodeRow)dsTIQ2.BusinessGetByCode.Rows[0];
                    if (myCustomerRow.ACType == "AR - COD")
                    {
                        txtCOD.BackColor = Color.LightCyan;
                        txtCOD.Text = "Cash On Delivery!";
                        txtCOD.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private dsTIQ2.SPLotNoAssignRow CurrentSPLotNo()
        {
            if (bsSPLotNo.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsSPLotNo.Current).Row;
                dsTIQ2.SPLotNoAssignRow mySPLotNoRow = (dsTIQ2.SPLotNoAssignRow)myRow;
                return mySPLotNoRow;
            }
            else
            {
                return null;
            }
        }

        private void GetSPLotNo()
        {
            // call stored procedure SPLotNoAssign with material code, returns SPLotNo, Lot Status, Remaining Tonnes
            try
            {
                string msg = "";
                this.taSPLotNo.Fill(this.dsTIQ2.SPLotNoAssign, myRow.Material, System.Convert.ToInt32(myRow.Nett));
                mySPLotNo = CurrentSPLotNo().SPLotNo;
                if (CurrentSPLotNo().LotStatus == 'M'.ToString())
                {
                    msg = "No lot allocated yet!";
                }
                else
                {
                    msg = "Lot No: " + CurrentSPLotNo().SPLotNo.ToString() +  " .. Remaining tonnes: " + CurrentSPLotNo().TonnesRemaining.ToString();
                    // extend message to include additional open lots, after go-live, not critical after discussion with David
                }
                txtInfo.Text = msg;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            PostDocketCancel();
        }

    }
}
