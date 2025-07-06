
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
            System.Windows.Forms.Label jurisdictionLabel;
            System.Windows.Forms.Label feeCodeLabel;
            System.Windows.Forms.Label feeTypeLabel;
            System.Windows.Forms.Label feeConditionsLabel;
            System.Windows.Forms.Label maxAxlesLabel;
            System.Windows.Forms.Label maxGVMLabel;
            System.Windows.Forms.Label maxTrailersLabel;
            System.Windows.Forms.Label couplingLabel;
            System.Windows.Forms.Label axlesLabel;
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.bsFeeCodes = new System.Windows.Forms.BindingSource(this.components);
            this.taFeeCodes = new QWS_Local.dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter();
            this.tamQWSLocal2024 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurisdictionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axlesTextBox = new System.Windows.Forms.TextBox();
            this.maxTrailersTextBox = new System.Windows.Forms.TextBox();
            this.maxGVMTextBox = new System.Windows.Forms.TextBox();
            this.maxAxlesTextBox = new System.Windows.Forms.TextBox();
            this.feeConditionsTextBox = new System.Windows.Forms.TextBox();
            this.feeTypeTextBox = new System.Windows.Forms.TextBox();
            this.jurisdictionTextBox = new System.Windows.Forms.TextBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.couplingTextBox = new System.Windows.Forms.TextBox();
            this.rbFeeCode = new System.Windows.Forms.RadioButton();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.rbCoupling = new System.Windows.Forms.RadioButton();
            this.isLeadVehicleCheckBox = new System.Windows.Forms.CheckBox();
            jurisdictionLabel = new System.Windows.Forms.Label();
            feeCodeLabel = new System.Windows.Forms.Label();
            feeTypeLabel = new System.Windows.Forms.Label();
            feeConditionsLabel = new System.Windows.Forms.Label();
            maxAxlesLabel = new System.Windows.Forms.Label();
            maxGVMLabel = new System.Windows.Forms.Label();
            maxTrailersLabel = new System.Windows.Forms.Label();
            couplingLabel = new System.Windows.Forms.Label();
            axlesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // jurisdictionLabel
            // 
            jurisdictionLabel.AutoSize = true;
            jurisdictionLabel.Location = new System.Drawing.Point(76, 29);
            jurisdictionLabel.Name = "jurisdictionLabel";
            jurisdictionLabel.Size = new System.Drawing.Size(87, 18);
            jurisdictionLabel.TabIndex = 7;
            jurisdictionLabel.Text = "Jurisdiction:";
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(86, 60);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(77, 18);
            feeCodeLabel.TabIndex = 9;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // feeTypeLabel
            // 
            feeTypeLabel.AutoSize = true;
            feeTypeLabel.Location = new System.Drawing.Point(90, 89);
            feeTypeLabel.Name = "feeTypeLabel";
            feeTypeLabel.Size = new System.Drawing.Size(73, 18);
            feeTypeLabel.TabIndex = 10;
            feeTypeLabel.Text = "Fee Type:";
            // 
            // feeConditionsLabel
            // 
            feeConditionsLabel.AutoSize = true;
            feeConditionsLabel.Location = new System.Drawing.Point(51, 119);
            feeConditionsLabel.Name = "feeConditionsLabel";
            feeConditionsLabel.Size = new System.Drawing.Size(112, 18);
            feeConditionsLabel.TabIndex = 12;
            feeConditionsLabel.Text = "Fee Conditions:";
            // 
            // maxAxlesLabel
            // 
            maxAxlesLabel.AutoSize = true;
            maxAxlesLabel.Location = new System.Drawing.Point(84, 232);
            maxAxlesLabel.Name = "maxAxlesLabel";
            maxAxlesLabel.Size = new System.Drawing.Size(79, 18);
            maxAxlesLabel.TabIndex = 14;
            maxAxlesLabel.Text = "Max Axles:";
            // 
            // maxGVMLabel
            // 
            maxGVMLabel.AutoSize = true;
            maxGVMLabel.Location = new System.Drawing.Point(85, 262);
            maxGVMLabel.Name = "maxGVMLabel";
            maxGVMLabel.Size = new System.Drawing.Size(78, 18);
            maxGVMLabel.TabIndex = 16;
            maxGVMLabel.Text = "Max GVM:";
            // 
            // maxTrailersLabel
            // 
            maxTrailersLabel.AutoSize = true;
            maxTrailersLabel.Location = new System.Drawing.Point(70, 292);
            maxTrailersLabel.Name = "maxTrailersLabel";
            maxTrailersLabel.Size = new System.Drawing.Size(93, 18);
            maxTrailersLabel.TabIndex = 18;
            maxTrailersLabel.Text = "Max Trailers:";
            // 
            // couplingLabel
            // 
            couplingLabel.AutoSize = true;
            couplingLabel.Location = new System.Drawing.Point(93, 322);
            couplingLabel.Name = "couplingLabel";
            couplingLabel.Size = new System.Drawing.Size(70, 18);
            couplingLabel.TabIndex = 20;
            couplingLabel.Text = "Coupling:";
            // 
            // axlesLabel
            // 
            axlesLabel.AutoSize = true;
            axlesLabel.Location = new System.Drawing.Point(116, 352);
            axlesLabel.Name = "axlesLabel";
            axlesLabel.Size = new System.Drawing.Size(47, 18);
            axlesLabel.TabIndex = 21;
            axlesLabel.Text = "Axles:";
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
            // tamQWSLocal2024
            // 
            this.tamQWSLocal2024.AxleConfigurationTableAdapter = null;
            this.tamQWSLocal2024.BackupDataSetBeforeUpdate = false;
            this.tamQWSLocal2024.NHVRTableAdapter = null;
            this.tamQWSLocal2024.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tamQWSLocal2024.VehiclePBSTableAdapter = null;
            this.tamQWSLocal2024.VehiclePrefCustomersTableAdapter = null;
            this.tamQWSLocal2024.VehicleRegFeeCodesTableAdapter = this.taFeeCodes;
            this.tamQWSLocal2024.VehicleTableAdapter = null;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.isLeadVehicleCheckBox);
            this.splitContainer2.Panel2.Controls.Add(axlesLabel);
            this.splitContainer2.Panel2.Controls.Add(this.axlesTextBox);
            this.splitContainer2.Panel2.Controls.Add(couplingLabel);
            this.splitContainer2.Panel2.Controls.Add(maxTrailersLabel);
            this.splitContainer2.Panel2.Controls.Add(this.maxTrailersTextBox);
            this.splitContainer2.Panel2.Controls.Add(maxGVMLabel);
            this.splitContainer2.Panel2.Controls.Add(this.maxGVMTextBox);
            this.splitContainer2.Panel2.Controls.Add(maxAxlesLabel);
            this.splitContainer2.Panel2.Controls.Add(this.maxAxlesTextBox);
            this.splitContainer2.Panel2.Controls.Add(feeConditionsLabel);
            this.splitContainer2.Panel2.Controls.Add(this.feeConditionsTextBox);
            this.splitContainer2.Panel2.Controls.Add(feeTypeLabel);
            this.splitContainer2.Panel2.Controls.Add(this.feeTypeTextBox);
            this.splitContainer2.Panel2.Controls.Add(feeCodeLabel);
            this.splitContainer2.Panel2.Controls.Add(jurisdictionLabel);
            this.splitContainer2.Panel2.Controls.Add(this.jurisdictionTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.btnClearFilters);
            this.splitContainer2.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer2.Panel2.Controls.Add(this.btnSelect);
            this.splitContainer2.Panel2.Controls.Add(this.couplingTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.rbFeeCode);
            this.splitContainer2.Panel2.Controls.Add(this.feeCodeTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.rbCoupling);
            this.splitContainer2.Size = new System.Drawing.Size(751, 475);
            this.splitContainer2.SplitterDistance = 278;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feeCodeDataGridViewTextBoxColumn,
            this.jurisdictionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsFeeCodes;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(278, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // feeCodeDataGridViewTextBoxColumn
            // 
            this.feeCodeDataGridViewTextBoxColumn.DataPropertyName = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn.HeaderText = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn.Name = "feeCodeDataGridViewTextBoxColumn";
            this.feeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurisdictionDataGridViewTextBoxColumn
            // 
            this.jurisdictionDataGridViewTextBoxColumn.DataPropertyName = "Jurisdiction";
            this.jurisdictionDataGridViewTextBoxColumn.HeaderText = "Jurisdiction";
            this.jurisdictionDataGridViewTextBoxColumn.Name = "jurisdictionDataGridViewTextBoxColumn";
            this.jurisdictionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axlesTextBox
            // 
            this.axlesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "Axles", true));
            this.axlesTextBox.Location = new System.Drawing.Point(169, 349);
            this.axlesTextBox.Name = "axlesTextBox";
            this.axlesTextBox.Size = new System.Drawing.Size(100, 24);
            this.axlesTextBox.TabIndex = 22;
            // 
            // maxTrailersTextBox
            // 
            this.maxTrailersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "MaxTrailers", true));
            this.maxTrailersTextBox.Location = new System.Drawing.Point(169, 289);
            this.maxTrailersTextBox.Name = "maxTrailersTextBox";
            this.maxTrailersTextBox.Size = new System.Drawing.Size(100, 24);
            this.maxTrailersTextBox.TabIndex = 19;
            // 
            // maxGVMTextBox
            // 
            this.maxGVMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "MaxGVM", true));
            this.maxGVMTextBox.Location = new System.Drawing.Point(169, 259);
            this.maxGVMTextBox.Name = "maxGVMTextBox";
            this.maxGVMTextBox.Size = new System.Drawing.Size(100, 24);
            this.maxGVMTextBox.TabIndex = 17;
            // 
            // maxAxlesTextBox
            // 
            this.maxAxlesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "MaxAxles", true));
            this.maxAxlesTextBox.Location = new System.Drawing.Point(169, 229);
            this.maxAxlesTextBox.Name = "maxAxlesTextBox";
            this.maxAxlesTextBox.Size = new System.Drawing.Size(100, 24);
            this.maxAxlesTextBox.TabIndex = 15;
            // 
            // feeConditionsTextBox
            // 
            this.feeConditionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "FeeConditions", true));
            this.feeConditionsTextBox.Location = new System.Drawing.Point(169, 116);
            this.feeConditionsTextBox.Multiline = true;
            this.feeConditionsTextBox.Name = "feeConditionsTextBox";
            this.feeConditionsTextBox.Size = new System.Drawing.Size(252, 63);
            this.feeConditionsTextBox.TabIndex = 13;
            // 
            // feeTypeTextBox
            // 
            this.feeTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "FeeType", true));
            this.feeTypeTextBox.Location = new System.Drawing.Point(169, 86);
            this.feeTypeTextBox.Name = "feeTypeTextBox";
            this.feeTypeTextBox.Size = new System.Drawing.Size(252, 24);
            this.feeTypeTextBox.TabIndex = 11;
            // 
            // jurisdictionTextBox
            // 
            this.jurisdictionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "Jurisdiction", true));
            this.jurisdictionTextBox.Location = new System.Drawing.Point(169, 26);
            this.jurisdictionTextBox.Name = "jurisdictionTextBox";
            this.jurisdictionTextBox.Size = new System.Drawing.Size(100, 24);
            this.jurisdictionTextBox.TabIndex = 8;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(279, 349);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(142, 37);
            this.btnClearFilters.TabIndex = 7;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(279, 392);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(142, 43);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // couplingTextBox
            // 
            this.couplingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "Coupling", true));
            this.couplingTextBox.Location = new System.Drawing.Point(169, 319);
            this.couplingTextBox.Name = "couplingTextBox";
            this.couplingTextBox.Size = new System.Drawing.Size(100, 24);
            this.couplingTextBox.TabIndex = 5;
            // 
            // rbFeeCode
            // 
            this.rbFeeCode.AutoSize = true;
            this.rbFeeCode.Location = new System.Drawing.Point(304, 58);
            this.rbFeeCode.Name = "rbFeeCode";
            this.rbFeeCode.Size = new System.Drawing.Size(53, 22);
            this.rbFeeCode.TabIndex = 0;
            this.rbFeeCode.TabStop = true;
            this.rbFeeCode.Text = "filter";
            this.rbFeeCode.UseVisualStyleBackColor = true;
            this.rbFeeCode.CheckedChanged += new System.EventHandler(this.rbFeeCode_CheckedChanged);
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(169, 56);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.feeCodeTextBox.TabIndex = 4;
            // 
            // rbCoupling
            // 
            this.rbCoupling.AutoSize = true;
            this.rbCoupling.Location = new System.Drawing.Point(311, 277);
            this.rbCoupling.Name = "rbCoupling";
            this.rbCoupling.Size = new System.Drawing.Size(53, 22);
            this.rbCoupling.TabIndex = 1;
            this.rbCoupling.TabStop = true;
            this.rbCoupling.Text = "filter";
            this.rbCoupling.UseVisualStyleBackColor = true;
            this.rbCoupling.CheckedChanged += new System.EventHandler(this.rbCoupling_CheckedChanged);
            // 
            // isLeadVehicleCheckBox
            // 
            this.isLeadVehicleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsFeeCodes, "IsLeadVehicle", true));
            this.isLeadVehicleCheckBox.Location = new System.Drawing.Point(169, 185);
            this.isLeadVehicleCheckBox.Name = "isLeadVehicleCheckBox";
            this.isLeadVehicleCheckBox.Size = new System.Drawing.Size(136, 24);
            this.isLeadVehicleCheckBox.TabIndex = 24;
            this.isLeadVehicleCheckBox.Text = "Is Lead Vehicle";
            this.isLeadVehicleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FeeCodeSearch
            // 
            this.ClientSize = new System.Drawing.Size(751, 475);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FeeCodeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fee Code Search";
            this.Load += new System.EventHandler(this.FeeCodeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsFeeCodes;
        private dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter taFeeCodes;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tamQWSLocal2024;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RadioButton rbCoupling;
        private System.Windows.Forms.RadioButton rbFeeCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox couplingTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurisdictionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TextBox maxGVMTextBox;
        private System.Windows.Forms.TextBox maxAxlesTextBox;
        private System.Windows.Forms.TextBox feeConditionsTextBox;
        private System.Windows.Forms.TextBox feeTypeTextBox;
        private System.Windows.Forms.TextBox jurisdictionTextBox;
        private System.Windows.Forms.TextBox axlesTextBox;
        private System.Windows.Forms.TextBox maxTrailersTextBox;
        private System.Windows.Forms.CheckBox isLeadVehicleCheckBox;
    }
}