
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
            System.Windows.Forms.Label jurisdictionLabel;
            System.Windows.Forms.Label feeTypeLabel;
            System.Windows.Forms.Label feeConditionsLabel;
            System.Windows.Forms.Label vehicleTypeLabel;
            System.Windows.Forms.Label maxAxlesLabel;
            System.Windows.Forms.Label maxGVMLabel;
            System.Windows.Forms.Label couplingLabel;
            System.Windows.Forms.Label axlesLabel;
            System.Windows.Forms.Label maxTrailersLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vehicleRegFeeCodesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.maxTrailersTextBox = new System.Windows.Forms.TextBox();
            this.axlesTextBox = new System.Windows.Forms.TextBox();
            this.couplingTextBox = new System.Windows.Forms.TextBox();
            this.maxGVMTextBox = new System.Windows.Forms.TextBox();
            this.maxAxlesTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.feeConditionsTextBox = new System.Windows.Forms.TextBox();
            this.feeTypeTextBox = new System.Windows.Forms.TextBox();
            this.jurisdictionTextBox = new System.Windows.Forms.TextBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegFeeCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.vehicleRegFeeCodesTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.VehicleRegFeeCodesTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.rbFeeCode = new System.Windows.Forms.RadioButton();
            this.rbVehicleType = new System.Windows.Forms.RadioButton();
            this.rbClearFilters = new System.Windows.Forms.RadioButton();
            this.rbCoupling = new System.Windows.Forms.RadioButton();
            feeCodeLabel = new System.Windows.Forms.Label();
            jurisdictionLabel = new System.Windows.Forms.Label();
            feeTypeLabel = new System.Windows.Forms.Label();
            feeConditionsLabel = new System.Windows.Forms.Label();
            vehicleTypeLabel = new System.Windows.Forms.Label();
            maxAxlesLabel = new System.Windows.Forms.Label();
            maxGVMLabel = new System.Windows.Forms.Label();
            couplingLabel = new System.Windows.Forms.Label();
            axlesLabel = new System.Windows.Forms.Label();
            maxTrailersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegFeeCodesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegFeeCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(81, 65);
            feeCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(77, 18);
            feeCodeLabel.TabIndex = 0;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // jurisdictionLabel
            // 
            jurisdictionLabel.AutoSize = true;
            jurisdictionLabel.Location = new System.Drawing.Point(71, 29);
            jurisdictionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jurisdictionLabel.Name = "jurisdictionLabel";
            jurisdictionLabel.Size = new System.Drawing.Size(87, 18);
            jurisdictionLabel.TabIndex = 2;
            jurisdictionLabel.Text = "Jurisdiction:";
            // 
            // feeTypeLabel
            // 
            feeTypeLabel.AutoSize = true;
            feeTypeLabel.Location = new System.Drawing.Point(82, 101);
            feeTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            feeTypeLabel.Name = "feeTypeLabel";
            feeTypeLabel.Size = new System.Drawing.Size(73, 18);
            feeTypeLabel.TabIndex = 4;
            feeTypeLabel.Text = "Fee Type:";
            // 
            // feeConditionsLabel
            // 
            feeConditionsLabel.AutoSize = true;
            feeConditionsLabel.Location = new System.Drawing.Point(45, 139);
            feeConditionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            feeConditionsLabel.Name = "feeConditionsLabel";
            feeConditionsLabel.Size = new System.Drawing.Size(112, 18);
            feeConditionsLabel.TabIndex = 6;
            feeConditionsLabel.Text = "Fee Conditions:";
            // 
            // vehicleTypeLabel
            // 
            vehicleTypeLabel.AutoSize = true;
            vehicleTypeLabel.Location = new System.Drawing.Point(57, 348);
            vehicleTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vehicleTypeLabel.Name = "vehicleTypeLabel";
            vehicleTypeLabel.Size = new System.Drawing.Size(95, 18);
            vehicleTypeLabel.TabIndex = 8;
            vehicleTypeLabel.Text = "Vehicle Type:";
            // 
            // maxAxlesLabel
            // 
            maxAxlesLabel.AutoSize = true;
            maxAxlesLabel.Location = new System.Drawing.Point(77, 216);
            maxAxlesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maxAxlesLabel.Name = "maxAxlesLabel";
            maxAxlesLabel.Size = new System.Drawing.Size(79, 18);
            maxAxlesLabel.TabIndex = 10;
            maxAxlesLabel.Text = "Max Axles:";
            // 
            // maxGVMLabel
            // 
            maxGVMLabel.AutoSize = true;
            maxGVMLabel.Location = new System.Drawing.Point(78, 252);
            maxGVMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maxGVMLabel.Name = "maxGVMLabel";
            maxGVMLabel.Size = new System.Drawing.Size(78, 18);
            maxGVMLabel.TabIndex = 12;
            maxGVMLabel.Text = "Max GVM:";
            // 
            // couplingLabel
            // 
            couplingLabel.AutoSize = true;
            couplingLabel.Location = new System.Drawing.Point(87, 384);
            couplingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            couplingLabel.Name = "couplingLabel";
            couplingLabel.Size = new System.Drawing.Size(70, 18);
            couplingLabel.TabIndex = 14;
            couplingLabel.Text = "Coupling:";
            // 
            // axlesLabel
            // 
            axlesLabel.AutoSize = true;
            axlesLabel.Location = new System.Drawing.Point(112, 421);
            axlesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            axlesLabel.Name = "axlesLabel";
            axlesLabel.Size = new System.Drawing.Size(47, 18);
            axlesLabel.TabIndex = 16;
            axlesLabel.Text = "Axles:";
            // 
            // maxTrailersLabel
            // 
            maxTrailersLabel.AutoSize = true;
            maxTrailersLabel.Location = new System.Drawing.Point(64, 301);
            maxTrailersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maxTrailersLabel.Name = "maxTrailersLabel";
            maxTrailersLabel.Size = new System.Drawing.Size(93, 18);
            maxTrailersLabel.TabIndex = 18;
            maxTrailersLabel.Text = "Max Trailers:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.vehicleRegFeeCodesDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbCoupling);
            this.splitContainer1.Panel2.Controls.Add(this.rbClearFilters);
            this.splitContainer1.Panel2.Controls.Add(this.rbVehicleType);
            this.splitContainer1.Panel2.Controls.Add(this.rbFeeCode);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel2.Controls.Add(maxTrailersLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxTrailersTextBox);
            this.splitContainer1.Panel2.Controls.Add(axlesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.axlesTextBox);
            this.splitContainer1.Panel2.Controls.Add(couplingLabel);
            this.splitContainer1.Panel2.Controls.Add(this.couplingTextBox);
            this.splitContainer1.Panel2.Controls.Add(maxGVMLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxGVMTextBox);
            this.splitContainer1.Panel2.Controls.Add(maxAxlesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxAxlesTextBox);
            this.splitContainer1.Panel2.Controls.Add(vehicleTypeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.vehicleTypeTextBox);
            this.splitContainer1.Panel2.Controls.Add(feeConditionsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.feeConditionsTextBox);
            this.splitContainer1.Panel2.Controls.Add(feeTypeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.feeTypeTextBox);
            this.splitContainer1.Panel2.Controls.Add(jurisdictionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.jurisdictionTextBox);
            this.splitContainer1.Panel2.Controls.Add(feeCodeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.feeCodeTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 623);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // vehicleRegFeeCodesDataGridView
            // 
            this.vehicleRegFeeCodesDataGridView.AllowUserToAddRows = false;
            this.vehicleRegFeeCodesDataGridView.AllowUserToDeleteRows = false;
            this.vehicleRegFeeCodesDataGridView.AutoGenerateColumns = false;
            this.vehicleRegFeeCodesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleRegFeeCodesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.vehicleRegFeeCodesDataGridView.DataSource = this.vehicleRegFeeCodesBindingSource;
            this.vehicleRegFeeCodesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleRegFeeCodesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vehicleRegFeeCodesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleRegFeeCodesDataGridView.Name = "vehicleRegFeeCodesDataGridView";
            this.vehicleRegFeeCodesDataGridView.ReadOnly = true;
            this.vehicleRegFeeCodesDataGridView.Size = new System.Drawing.Size(414, 623);
            this.vehicleRegFeeCodesDataGridView.TabIndex = 21;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(174, 466);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(148, 32);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "Select and Close";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxTrailersTextBox
            // 
            this.maxTrailersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "MaxTrailers", true));
            this.maxTrailersTextBox.Location = new System.Drawing.Point(174, 297);
            this.maxTrailersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxTrailersTextBox.Name = "maxTrailersTextBox";
            this.maxTrailersTextBox.Size = new System.Drawing.Size(148, 24);
            this.maxTrailersTextBox.TabIndex = 19;
            // 
            // axlesTextBox
            // 
            this.axlesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "Axles", true));
            this.axlesTextBox.Location = new System.Drawing.Point(174, 417);
            this.axlesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axlesTextBox.Name = "axlesTextBox";
            this.axlesTextBox.Size = new System.Drawing.Size(148, 24);
            this.axlesTextBox.TabIndex = 17;
            // 
            // couplingTextBox
            // 
            this.couplingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "Coupling", true));
            this.couplingTextBox.Location = new System.Drawing.Point(174, 380);
            this.couplingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.couplingTextBox.Name = "couplingTextBox";
            this.couplingTextBox.Size = new System.Drawing.Size(148, 24);
            this.couplingTextBox.TabIndex = 15;
            // 
            // maxGVMTextBox
            // 
            this.maxGVMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "MaxGVM", true));
            this.maxGVMTextBox.Location = new System.Drawing.Point(174, 247);
            this.maxGVMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxGVMTextBox.Name = "maxGVMTextBox";
            this.maxGVMTextBox.Size = new System.Drawing.Size(148, 24);
            this.maxGVMTextBox.TabIndex = 13;
            // 
            // maxAxlesTextBox
            // 
            this.maxAxlesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "MaxAxles", true));
            this.maxAxlesTextBox.Location = new System.Drawing.Point(174, 211);
            this.maxAxlesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxAxlesTextBox.Name = "maxAxlesTextBox";
            this.maxAxlesTextBox.Size = new System.Drawing.Size(148, 24);
            this.maxAxlesTextBox.TabIndex = 11;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "VehicleType", true));
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(174, 344);
            this.vehicleTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(148, 24);
            this.vehicleTypeTextBox.TabIndex = 9;
            // 
            // feeConditionsTextBox
            // 
            this.feeConditionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "FeeConditions", true));
            this.feeConditionsTextBox.Location = new System.Drawing.Point(174, 136);
            this.feeConditionsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.feeConditionsTextBox.Multiline = true;
            this.feeConditionsTextBox.Name = "feeConditionsTextBox";
            this.feeConditionsTextBox.Size = new System.Drawing.Size(426, 54);
            this.feeConditionsTextBox.TabIndex = 7;
            // 
            // feeTypeTextBox
            // 
            this.feeTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "FeeType", true));
            this.feeTypeTextBox.Location = new System.Drawing.Point(174, 97);
            this.feeTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.feeTypeTextBox.Name = "feeTypeTextBox";
            this.feeTypeTextBox.Size = new System.Drawing.Size(148, 24);
            this.feeTypeTextBox.TabIndex = 5;
            // 
            // jurisdictionTextBox
            // 
            this.jurisdictionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "Jurisdiction", true));
            this.jurisdictionTextBox.Location = new System.Drawing.Point(174, 25);
            this.jurisdictionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jurisdictionTextBox.Name = "jurisdictionTextBox";
            this.jurisdictionTextBox.Size = new System.Drawing.Size(148, 24);
            this.jurisdictionTextBox.TabIndex = 3;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(174, 61);
            this.feeCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(148, 24);
            this.feeCodeTextBox.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FeeCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "FeeCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Jurisdiction";
            this.dataGridViewTextBoxColumn2.HeaderText = "Jurisdiction";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // vehicleRegFeeCodesBindingSource
            // 
            this.vehicleRegFeeCodesBindingSource.DataMember = "VehicleRegFeeCodes";
            this.vehicleRegFeeCodesBindingSource.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleRegFeeCodesTableAdapter
            // 
            this.vehicleRegFeeCodesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.NHVR_GVMTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBS_VINTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TruckConfigTrailersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // rbFeeCode
            // 
            this.rbFeeCode.AutoSize = true;
            this.rbFeeCode.Location = new System.Drawing.Point(343, 65);
            this.rbFeeCode.Name = "rbFeeCode";
            this.rbFeeCode.Size = new System.Drawing.Size(53, 22);
            this.rbFeeCode.TabIndex = 21;
            this.rbFeeCode.TabStop = true;
            this.rbFeeCode.Text = "filter";
            this.rbFeeCode.UseVisualStyleBackColor = true;
            this.rbFeeCode.CheckedChanged += new System.EventHandler(this.rbFeeCode_CheckedChanged);
            // 
            // rbVehicleType
            // 
            this.rbVehicleType.AutoSize = true;
            this.rbVehicleType.Location = new System.Drawing.Point(343, 346);
            this.rbVehicleType.Name = "rbVehicleType";
            this.rbVehicleType.Size = new System.Drawing.Size(53, 22);
            this.rbVehicleType.TabIndex = 24;
            this.rbVehicleType.TabStop = true;
            this.rbVehicleType.Text = "filter";
            this.rbVehicleType.UseVisualStyleBackColor = true;
            this.rbVehicleType.CheckedChanged += new System.EventHandler(this.rbVehicleType_CheckedChanged);
            // 
            // rbClearFilters
            // 
            this.rbClearFilters.AutoSize = true;
            this.rbClearFilters.Location = new System.Drawing.Point(474, 419);
            this.rbClearFilters.Name = "rbClearFilters";
            this.rbClearFilters.Size = new System.Drawing.Size(105, 22);
            this.rbClearFilters.TabIndex = 25;
            this.rbClearFilters.TabStop = true;
            this.rbClearFilters.Text = "Clear Filters";
            this.rbClearFilters.UseVisualStyleBackColor = true;
            this.rbClearFilters.CheckedChanged += new System.EventHandler(this.rbClearFilters_CheckedChanged);
            // 
            // rbCoupling
            // 
            this.rbCoupling.AutoSize = true;
            this.rbCoupling.Location = new System.Drawing.Point(343, 382);
            this.rbCoupling.Name = "rbCoupling";
            this.rbCoupling.Size = new System.Drawing.Size(53, 22);
            this.rbCoupling.TabIndex = 26;
            this.rbCoupling.TabStop = true;
            this.rbCoupling.Text = "filter";
            this.rbCoupling.UseVisualStyleBackColor = true;
            this.rbCoupling.CheckedChanged += new System.EventHandler(this.rbCoupling_CheckedChanged);
            // 
            // FeeCodeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 623);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeeCodeSearch";
            this.Text = "FeeCodeSearch";
            this.Load += new System.EventHandler(this.FeeCodeSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegFeeCodesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegFeeCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.TextBox feeConditionsTextBox;
        private System.Windows.Forms.TextBox feeTypeTextBox;
        private System.Windows.Forms.TextBox jurisdictionTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView vehicleRegFeeCodesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton rbFeeCode;
        private System.Windows.Forms.RadioButton rbVehicleType;
        private System.Windows.Forms.RadioButton rbClearFilters;
        private System.Windows.Forms.RadioButton rbCoupling;
    }
}