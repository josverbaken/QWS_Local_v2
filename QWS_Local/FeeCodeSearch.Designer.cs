
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
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.bsFeeCodes = new System.Windows.Forms.BindingSource(this.components);
            this.taFeeCodes = new QWS_Local.dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rbFeeCode = new System.Windows.Forms.RadioButton();
            this.rbCoupling = new System.Windows.Forms.RadioButton();
            this.rbClearFilters = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feeCodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurisdictionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLeadVehicleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.couplingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeConditionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTrailersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAxlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxGVMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.couplingTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.couplingTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.feeCodeTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.btnSelect);
            this.splitContainer2.Panel1.Controls.Add(this.rbClearFilters);
            this.splitContainer2.Panel1.Controls.Add(this.rbCoupling);
            this.splitContainer2.Panel1.Controls.Add(this.rbFeeCode);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(1195, 524);
            this.splitContainer2.SplitterDistance = 397;
            this.splitContainer2.TabIndex = 0;
            // 
            // rbFeeCode
            // 
            this.rbFeeCode.AutoSize = true;
            this.rbFeeCode.Location = new System.Drawing.Point(66, 150);
            this.rbFeeCode.Name = "rbFeeCode";
            this.rbFeeCode.Size = new System.Drawing.Size(71, 17);
            this.rbFeeCode.TabIndex = 0;
            this.rbFeeCode.TabStop = true;
            this.rbFeeCode.Text = "Fee Code";
            this.rbFeeCode.UseVisualStyleBackColor = true;
            // 
            // rbCoupling
            // 
            this.rbCoupling.AutoSize = true;
            this.rbCoupling.Location = new System.Drawing.Point(66, 245);
            this.rbCoupling.Name = "rbCoupling";
            this.rbCoupling.Size = new System.Drawing.Size(66, 17);
            this.rbCoupling.TabIndex = 1;
            this.rbCoupling.TabStop = true;
            this.rbCoupling.Text = "Coupling";
            this.rbCoupling.UseVisualStyleBackColor = true;
            // 
            // rbClearFilters
            // 
            this.rbClearFilters.AutoSize = true;
            this.rbClearFilters.Location = new System.Drawing.Point(48, 343);
            this.rbClearFilters.Name = "rbClearFilters";
            this.rbClearFilters.Size = new System.Drawing.Size(49, 17);
            this.rbClearFilters.TabIndex = 2;
            this.rbClearFilters.TabStop = true;
            this.rbClearFilters.Text = "Clear";
            this.rbClearFilters.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(35, 409);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feeCodeIDDataGridViewTextBoxColumn,
            this.jurisdictionDataGridViewTextBoxColumn,
            this.feeCodeDataGridViewTextBoxColumn,
            this.feeTypeDataGridViewTextBoxColumn,
            this.isLeadVehicleDataGridViewCheckBoxColumn,
            this.couplingDataGridViewTextBoxColumn,
            this.axlesDataGridViewTextBoxColumn,
            this.feeConditionsDataGridViewTextBoxColumn,
            this.maxTrailersDataGridViewTextBoxColumn,
            this.maxAxlesDataGridViewTextBoxColumn,
            this.maxGVMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsFeeCodes;
            this.dataGridView1.Location = new System.Drawing.Point(26, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(738, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // feeCodeIDDataGridViewTextBoxColumn
            // 
            this.feeCodeIDDataGridViewTextBoxColumn.DataPropertyName = "FeeCodeID";
            this.feeCodeIDDataGridViewTextBoxColumn.HeaderText = "FeeCodeID";
            this.feeCodeIDDataGridViewTextBoxColumn.Name = "feeCodeIDDataGridViewTextBoxColumn";
            this.feeCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurisdictionDataGridViewTextBoxColumn
            // 
            this.jurisdictionDataGridViewTextBoxColumn.DataPropertyName = "Jurisdiction";
            this.jurisdictionDataGridViewTextBoxColumn.HeaderText = "Jurisdiction";
            this.jurisdictionDataGridViewTextBoxColumn.Name = "jurisdictionDataGridViewTextBoxColumn";
            this.jurisdictionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeCodeDataGridViewTextBoxColumn
            // 
            this.feeCodeDataGridViewTextBoxColumn.DataPropertyName = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn.HeaderText = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn.Name = "feeCodeDataGridViewTextBoxColumn";
            this.feeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeTypeDataGridViewTextBoxColumn
            // 
            this.feeTypeDataGridViewTextBoxColumn.DataPropertyName = "FeeType";
            this.feeTypeDataGridViewTextBoxColumn.HeaderText = "FeeType";
            this.feeTypeDataGridViewTextBoxColumn.Name = "feeTypeDataGridViewTextBoxColumn";
            this.feeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isLeadVehicleDataGridViewCheckBoxColumn
            // 
            this.isLeadVehicleDataGridViewCheckBoxColumn.DataPropertyName = "IsLeadVehicle";
            this.isLeadVehicleDataGridViewCheckBoxColumn.HeaderText = "IsLeadVehicle";
            this.isLeadVehicleDataGridViewCheckBoxColumn.Name = "isLeadVehicleDataGridViewCheckBoxColumn";
            this.isLeadVehicleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // couplingDataGridViewTextBoxColumn
            // 
            this.couplingDataGridViewTextBoxColumn.DataPropertyName = "Coupling";
            this.couplingDataGridViewTextBoxColumn.HeaderText = "Coupling";
            this.couplingDataGridViewTextBoxColumn.Name = "couplingDataGridViewTextBoxColumn";
            this.couplingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axlesDataGridViewTextBoxColumn
            // 
            this.axlesDataGridViewTextBoxColumn.DataPropertyName = "Axles";
            this.axlesDataGridViewTextBoxColumn.HeaderText = "Axles";
            this.axlesDataGridViewTextBoxColumn.Name = "axlesDataGridViewTextBoxColumn";
            this.axlesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeConditionsDataGridViewTextBoxColumn
            // 
            this.feeConditionsDataGridViewTextBoxColumn.DataPropertyName = "FeeConditions";
            this.feeConditionsDataGridViewTextBoxColumn.HeaderText = "FeeConditions";
            this.feeConditionsDataGridViewTextBoxColumn.Name = "feeConditionsDataGridViewTextBoxColumn";
            this.feeConditionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxTrailersDataGridViewTextBoxColumn
            // 
            this.maxTrailersDataGridViewTextBoxColumn.DataPropertyName = "MaxTrailers";
            this.maxTrailersDataGridViewTextBoxColumn.HeaderText = "MaxTrailers";
            this.maxTrailersDataGridViewTextBoxColumn.Name = "maxTrailersDataGridViewTextBoxColumn";
            this.maxTrailersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxAxlesDataGridViewTextBoxColumn
            // 
            this.maxAxlesDataGridViewTextBoxColumn.DataPropertyName = "MaxAxles";
            this.maxAxlesDataGridViewTextBoxColumn.HeaderText = "MaxAxles";
            this.maxAxlesDataGridViewTextBoxColumn.Name = "maxAxlesDataGridViewTextBoxColumn";
            this.maxAxlesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxGVMDataGridViewTextBoxColumn
            // 
            this.maxGVMDataGridViewTextBoxColumn.DataPropertyName = "MaxGVM";
            this.maxGVMDataGridViewTextBoxColumn.HeaderText = "MaxGVM";
            this.maxGVMDataGridViewTextBoxColumn.Name = "maxGVMDataGridViewTextBoxColumn";
            this.maxGVMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.Location = new System.Drawing.Point(66, 104);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.feeCodeTextBox.TabIndex = 4;
            // 
            // couplingTextBox
            // 
            this.couplingTextBox.Location = new System.Drawing.Point(66, 201);
            this.couplingTextBox.Name = "couplingTextBox";
            this.couplingTextBox.Size = new System.Drawing.Size(100, 20);
            this.couplingTextBox.TabIndex = 5;
            // 
            // FeeCodeSearch
            // 
            this.ClientSize = new System.Drawing.Size(1195, 524);
            this.Controls.Add(this.splitContainer2);
            this.Name = "FeeCodeSearch";
            this.Load += new System.EventHandler(this.FeeCodeSearch_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsFeeCodes;
        private dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter taFeeCodes;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RadioButton rbClearFilters;
        private System.Windows.Forms.RadioButton rbCoupling;
        private System.Windows.Forms.RadioButton rbFeeCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeCodeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurisdictionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLeadVehicleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couplingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeConditionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTrailersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAxlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxGVMDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox couplingTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
    }
}