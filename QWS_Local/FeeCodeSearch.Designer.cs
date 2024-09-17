
namespace QWS_Local
{
    partial class FeeCodeSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label feeCodeLabel;
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.bsFeeCodes = new System.Windows.Forms.BindingSource(this.components);
            this.taFeeCodes = new QWS_Local.dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.feeCodeTextBox1 = new System.Windows.Forms.TextBox();
            feeCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsFeeCodes
            // 
            this.bsFeeCodes.DataMember = "VehicleRegFeeCodes";
            this.bsFeeCodes.DataSource = this.dsQWSLocal2024;
            // 
            // taFeeCodes
            // 
            this.taFeeCodes.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.NHVRTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager1.VehicleRegFeeCodesTableAdapter = this.taFeeCodes;
            this.tableAdapterManager1.VehicleTableAdapter = null;
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(43, 228);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(56, 13);
            feeCodeLabel.TabIndex = 1;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // feeCodeTextBox1
            // 
            this.feeCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "FeeCode", true));
            this.feeCodeTextBox1.Location = new System.Drawing.Point(105, 225);
            this.feeCodeTextBox1.Name = "feeCodeTextBox1";
            this.feeCodeTextBox1.Size = new System.Drawing.Size(100, 20);
            this.feeCodeTextBox1.TabIndex = 2;
            // 
            // FeeCodeSearch
            // 
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(feeCodeLabel);
            this.Controls.Add(this.feeCodeTextBox1);
            this.Name = "FeeCodeSearch";
            this.Load += new System.EventHandler(this.FeeCodeSearch_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource vehicleRegFeeCodesBindingSource;
        private dsQWSLocalTableAdapters.VehicleRegFeeCodesTableAdapter vehicleRegFeeCodesTableAdapter;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maxTrailersTextBox;
        private System.Windows.Forms.TextBox axlesTextBox;
        private System.Windows.Forms.TextBox couplingTextBox;
        private System.Windows.Forms.TextBox maxGVMTextBox;
        private System.Windows.Forms.TextBox maxAxlesTextBox;
        private System.Windows.Forms.TextBox feeConditionsTextBox;
        private System.Windows.Forms.TextBox feeTypeTextBox;
        private System.Windows.Forms.TextBox jurisdictionTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView vehicleRegFeeCodesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton rbFeeCode;
        private System.Windows.Forms.RadioButton rbClearFilters;
        private System.Windows.Forms.RadioButton rbCoupling;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsFeeCodes;
        private dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter taFeeCodes;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox feeCodeTextBox1;
    }
}