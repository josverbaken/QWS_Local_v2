namespace QWS_Local
{
    partial class PBSManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.bsPBS = new System.Windows.Forms.BindingSource(this.components);
            this.dsPBS = new QWS_Local.dsPBS();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindOwner = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.txtVehicleApproval = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPBS_ConfigID = new System.Windows.Forms.TextBox();
            this.bsPBSConfig = new System.Windows.Forms.BindingSource(this.components);
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPBS_ID = new System.Windows.Forms.TextBox();
            this.txtInstruction1 = new System.Windows.Forms.TextBox();
            this.gbPBSGVMConfig = new System.Windows.Forms.GroupBox();
            this.dgvPBSConfigScheme = new System.Windows.Forms.DataGridView();
            this.pBSLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS_ConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchemeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVMTruckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveAxleLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveAxleLoadUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massMgmtRqdDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsPBSConfigScheme = new System.Windows.Forms.BindingSource(this.components);
            this.gbPBSVA = new System.Windows.Forms.GroupBox();
            this.dgvPBS = new System.Windows.Forms.DataGridView();
            this.vehicleApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPBSTables = new System.Windows.Forms.GroupBox();
            this.dgvPBSConfig = new System.Windows.Forms.DataGridView();
            this.tableNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgeAssessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taPBS = new QWS_Local.dsPBSTableAdapters.PBSTableAdapter();
            this.taPBSConfig = new QWS_Local.dsPBSTableAdapters.PBS_ConfigTableAdapter();
            this.taPBSConfigScheme = new QWS_Local.dsPBSTableAdapters.PBS_ConfigSchemeTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsPBSTableAdapters.TableAdapterManager();
            this.btnSaveVA = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).BeginInit();
            this.gbPBSGVMConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigScheme)).BeginInit();
            this.gbPBSVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).BeginInit();
            this.gbPBSTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtCardCode);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindOwner);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveTable);
            this.splitContainer1.Panel1.Controls.Add(this.txtVehicleApproval);
            this.splitContainer1.Panel1.Controls.Add(this.txtOperator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveConfig);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveVA);
            this.splitContainer1.Panel2.Controls.Add(this.txtInstruction1);
            this.splitContainer1.Panel2.Controls.Add(this.gbPBSGVMConfig);
            this.splitContainer1.Panel2.Controls.Add(this.gbPBSVA);
            this.splitContainer1.Panel2.Controls.Add(this.gbPBSTables);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.txtPBS_ConfigID);
            this.splitContainer1.Panel2.Controls.Add(this.txtPBS_ID);
            this.splitContainer1.Size = new System.Drawing.Size(1111, 712);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "...";
            // 
            // txtCardCode
            // 
            this.txtCardCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "CardCode", true));
            this.txtCardCode.Location = new System.Drawing.Point(499, 65);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.ReadOnly = true;
            this.txtCardCode.Size = new System.Drawing.Size(100, 24);
            this.txtCardCode.TabIndex = 17;
            // 
            // bsPBS
            // 
            this.bsPBS.DataMember = "PBS";
            this.bsPBS.DataSource = this.dsPBS;
            // 
            // dsPBS
            // 
            this.dsPBS.DataSetName = "dsPBS";
            this.dsPBS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vehicle Approval";
            // 
            // btnFindOwner
            // 
            this.btnFindOwner.Location = new System.Drawing.Point(605, 62);
            this.btnFindOwner.Name = "btnFindOwner";
            this.btnFindOwner.Size = new System.Drawing.Size(100, 30);
            this.btnFindOwner.TabIndex = 14;
            this.btnFindOwner.Text = "Find";
            this.btnFindOwner.UseVisualStyleBackColor = true;
            this.btnFindOwner.Click += new System.EventHandler(this.btnFindOwner_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Location = new System.Drawing.Point(393, 29);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(100, 30);
            this.btnSaveTable.TabIndex = 12;
            this.btnSaveTable.Text = "Find";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtVehicleApproval
            // 
            this.txtVehicleApproval.Location = new System.Drawing.Point(181, 35);
            this.txtVehicleApproval.Name = "txtVehicleApproval";
            this.txtVehicleApproval.Size = new System.Drawing.Size(100, 24);
            this.txtVehicleApproval.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPBS_ConfigID
            // 
            this.txtPBS_ConfigID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBSConfig, "PBS_ConfigID", true));
            this.txtPBS_ConfigID.Location = new System.Drawing.Point(410, 286);
            this.txtPBS_ConfigID.Name = "txtPBS_ConfigID";
            this.txtPBS_ConfigID.Size = new System.Drawing.Size(81, 24);
            this.txtPBS_ConfigID.TabIndex = 9;
            // 
            // bsPBSConfig
            // 
            this.bsPBSConfig.DataMember = "PBS_Config";
            this.bsPBSConfig.DataSource = this.dsPBS;
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "Operator", true));
            this.txtOperator.Location = new System.Drawing.Point(34, 65);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(459, 24);
            this.txtOperator.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load Table/s";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPBS_ID
            // 
            this.txtPBS_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "PBS_ID", true));
            this.txtPBS_ID.Location = new System.Drawing.Point(791, 39);
            this.txtPBS_ID.Name = "txtPBS_ID";
            this.txtPBS_ID.Size = new System.Drawing.Size(81, 24);
            this.txtPBS_ID.TabIndex = 2;
            // 
            // txtInstruction1
            // 
            this.txtInstruction1.BackColor = System.Drawing.SystemColors.Control;
            this.txtInstruction1.Location = new System.Drawing.Point(902, 319);
            this.txtInstruction1.Multiline = true;
            this.txtInstruction1.Name = "txtInstruction1";
            this.txtInstruction1.Size = new System.Drawing.Size(165, 172);
            this.txtInstruction1.TabIndex = 19;
            this.txtInstruction1.Text = "Scheme either: ";
            // 
            // gbPBSGVMConfig
            // 
            this.gbPBSGVMConfig.Controls.Add(this.dgvPBSConfigScheme);
            this.gbPBSGVMConfig.Location = new System.Drawing.Point(15, 319);
            this.gbPBSGVMConfig.Name = "gbPBSGVMConfig";
            this.gbPBSGVMConfig.Size = new System.Drawing.Size(858, 175);
            this.gbPBSGVMConfig.TabIndex = 4;
            this.gbPBSGVMConfig.TabStop = false;
            this.gbPBSGVMConfig.Text = "PBS Configuration";
            // 
            // dgvPBSConfigScheme
            // 
            this.dgvPBSConfigScheme.AutoGenerateColumns = false;
            this.dgvPBSConfigScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBSConfigScheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBSLevelDataGridViewTextBoxColumn,
            this.PBS_ConfigID,
            this.gCMDataGridViewTextBoxColumn,
            this.SchemeCode,
            this.gVMTruckDataGridViewTextBoxColumn,
            this.driveAxleLoadDataGridViewTextBoxColumn,
            this.DriveAxleLoadUOM,
            this.massMgmtRqdDataGridViewCheckBoxColumn});
            this.dgvPBSConfigScheme.DataSource = this.bsPBSConfigScheme;
            this.dgvPBSConfigScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPBSConfigScheme.Location = new System.Drawing.Point(3, 20);
            this.dgvPBSConfigScheme.Name = "dgvPBSConfigScheme";
            this.dgvPBSConfigScheme.Size = new System.Drawing.Size(852, 152);
            this.dgvPBSConfigScheme.TabIndex = 3;
            this.dgvPBSConfigScheme.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPBSConfigScheme_DefaultValuesNeeded);
            // 
            // pBSLevelDataGridViewTextBoxColumn
            // 
            this.pBSLevelDataGridViewTextBoxColumn.DataPropertyName = "PBS_Level";
            this.pBSLevelDataGridViewTextBoxColumn.HeaderText = "PBS_Level";
            this.pBSLevelDataGridViewTextBoxColumn.Name = "pBSLevelDataGridViewTextBoxColumn";
            // 
            // PBS_ConfigID
            // 
            this.PBS_ConfigID.DataPropertyName = "PBS_ConfigID";
            this.PBS_ConfigID.HeaderText = "PBS_ConfigID";
            this.PBS_ConfigID.Name = "PBS_ConfigID";
            this.PBS_ConfigID.Visible = false;
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
            // 
            // SchemeCode
            // 
            this.SchemeCode.DataPropertyName = "SchemeCode";
            this.SchemeCode.HeaderText = "Scheme";
            this.SchemeCode.Name = "SchemeCode";
            // 
            // gVMTruckDataGridViewTextBoxColumn
            // 
            this.gVMTruckDataGridViewTextBoxColumn.DataPropertyName = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.HeaderText = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.Name = "gVMTruckDataGridViewTextBoxColumn";
            // 
            // driveAxleLoadDataGridViewTextBoxColumn
            // 
            this.driveAxleLoadDataGridViewTextBoxColumn.DataPropertyName = "DriveAxleLoad";
            this.driveAxleLoadDataGridViewTextBoxColumn.HeaderText = "DriveAxleLoad";
            this.driveAxleLoadDataGridViewTextBoxColumn.Name = "driveAxleLoadDataGridViewTextBoxColumn";
            // 
            // DriveAxleLoadUOM
            // 
            this.DriveAxleLoadUOM.DataPropertyName = "DriveAxleLoadUOM";
            this.DriveAxleLoadUOM.HeaderText = "UOM";
            this.DriveAxleLoadUOM.Name = "DriveAxleLoadUOM";
            // 
            // massMgmtRqdDataGridViewCheckBoxColumn
            // 
            this.massMgmtRqdDataGridViewCheckBoxColumn.DataPropertyName = "MassMgmtRqd";
            this.massMgmtRqdDataGridViewCheckBoxColumn.HeaderText = "MassMgmtRqd";
            this.massMgmtRqdDataGridViewCheckBoxColumn.Name = "massMgmtRqdDataGridViewCheckBoxColumn";
            // 
            // bsPBSConfigScheme
            // 
            this.bsPBSConfigScheme.DataMember = "PBS_ConfigScheme";
            this.bsPBSConfigScheme.DataSource = this.dsPBS;
            // 
            // gbPBSVA
            // 
            this.gbPBSVA.Controls.Add(this.dgvPBS);
            this.gbPBSVA.Location = new System.Drawing.Point(12, 11);
            this.gbPBSVA.Name = "gbPBSVA";
            this.gbPBSVA.Size = new System.Drawing.Size(373, 224);
            this.gbPBSVA.TabIndex = 18;
            this.gbPBSVA.TabStop = false;
            this.gbPBSVA.Text = "Vehicle Approvals";
            // 
            // dgvPBS
            // 
            this.dgvPBS.AllowUserToDeleteRows = false;
            this.dgvPBS.AutoGenerateColumns = false;
            this.dgvPBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleApprovalDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.approvalDTDataGridViewTextBoxColumn});
            this.dgvPBS.DataSource = this.bsPBS;
            this.dgvPBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPBS.Location = new System.Drawing.Point(3, 20);
            this.dgvPBS.Name = "dgvPBS";
            this.dgvPBS.Size = new System.Drawing.Size(367, 201);
            this.dgvPBS.TabIndex = 7;
            this.dgvPBS.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPBS_DefaultValuesNeeded);
            // 
            // vehicleApprovalDataGridViewTextBoxColumn
            // 
            this.vehicleApprovalDataGridViewTextBoxColumn.DataPropertyName = "VehicleApproval";
            this.vehicleApprovalDataGridViewTextBoxColumn.HeaderText = "Vehicle Approval";
            this.vehicleApprovalDataGridViewTextBoxColumn.Name = "vehicleApprovalDataGridViewTextBoxColumn";
            this.vehicleApprovalDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleApprovalDataGridViewTextBoxColumn.Width = 130;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            this.versionDataGridViewTextBoxColumn.Width = 80;
            // 
            // approvalDTDataGridViewTextBoxColumn
            // 
            this.approvalDTDataGridViewTextBoxColumn.DataPropertyName = "ApprovalDT";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.approvalDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.approvalDTDataGridViewTextBoxColumn.HeaderText = "ApprovalDT";
            this.approvalDTDataGridViewTextBoxColumn.Name = "approvalDTDataGridViewTextBoxColumn";
            // 
            // gbPBSTables
            // 
            this.gbPBSTables.Controls.Add(this.dgvPBSConfig);
            this.gbPBSTables.Location = new System.Drawing.Point(418, 72);
            this.gbPBSTables.Name = "gbPBSTables";
            this.gbPBSTables.Size = new System.Drawing.Size(455, 160);
            this.gbPBSTables.TabIndex = 3;
            this.gbPBSTables.TabStop = false;
            this.gbPBSTables.Text = "PBS Tables";
            // 
            // dgvPBSConfig
            // 
            this.dgvPBSConfig.AutoGenerateColumns = false;
            this.dgvPBSConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBSConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableNoDataGridViewTextBoxColumn,
            this.PBS_ID,
            this.bridgeAssessmentDataGridViewTextBoxColumn,
            this.axleConfigurationDataGridViewTextBoxColumn});
            this.dgvPBSConfig.DataSource = this.bsPBSConfig;
            this.dgvPBSConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPBSConfig.Location = new System.Drawing.Point(3, 20);
            this.dgvPBSConfig.Name = "dgvPBSConfig";
            this.dgvPBSConfig.Size = new System.Drawing.Size(449, 137);
            this.dgvPBSConfig.TabIndex = 2;
            this.dgvPBSConfig.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPBSConfig_DefaultValuesNeeded);
            // 
            // tableNoDataGridViewTextBoxColumn
            // 
            this.tableNoDataGridViewTextBoxColumn.DataPropertyName = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.HeaderText = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.Name = "tableNoDataGridViewTextBoxColumn";
            // 
            // PBS_ID
            // 
            this.PBS_ID.DataPropertyName = "PBS_ID";
            this.PBS_ID.HeaderText = "PBS_ID";
            this.PBS_ID.Name = "PBS_ID";
            this.PBS_ID.Visible = false;
            // 
            // bridgeAssessmentDataGridViewTextBoxColumn
            // 
            this.bridgeAssessmentDataGridViewTextBoxColumn.DataPropertyName = "BridgeAssessment";
            this.bridgeAssessmentDataGridViewTextBoxColumn.HeaderText = "BridgeAssessment";
            this.bridgeAssessmentDataGridViewTextBoxColumn.Name = "bridgeAssessmentDataGridViewTextBoxColumn";
            this.bridgeAssessmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            this.axleConfigurationDataGridViewTextBoxColumn.Width = 150;
            // 
            // taPBS
            // 
            this.taPBS.ClearBeforeFill = true;
            // 
            // taPBSConfig
            // 
            this.taPBSConfig.ClearBeforeFill = true;
            // 
            // taPBSConfigScheme
            // 
            this.taPBSConfigScheme.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsPBSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnSaveVA
            // 
            this.btnSaveVA.Location = new System.Drawing.Point(421, 37);
            this.btnSaveVA.Name = "btnSaveVA";
            this.btnSaveVA.Size = new System.Drawing.Size(193, 29);
            this.btnSaveVA.TabIndex = 20;
            this.btnSaveVA.Text = "Save Vehicle Approval";
            this.btnSaveVA.UseVisualStyleBackColor = true;
            this.btnSaveVA.Click += new System.EventHandler(this.btnSaveVA_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 29);
            this.button4.TabIndex = 21;
            this.button4.Text = "Save Table";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(567, 281);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(193, 29);
            this.btnSaveConfig.TabIndex = 22;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // PBSManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 712);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PBSManagement";
            this.Text = "PBS Maintenance v2";
            this.Load += new System.EventHandler(this.PBSManagement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).EndInit();
            this.gbPBSGVMConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigScheme)).EndInit();
            this.gbPBSVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).EndInit();
            this.gbPBSTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPBS_ID;
        private System.Windows.Forms.DataGridView dgvPBS;
        private dsPBS dsPBS;
        private System.Windows.Forms.BindingSource bsPBS;
        private dsPBSTableAdapters.PBSTableAdapter taPBS;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleApprovalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvPBSConfig;
        private System.Windows.Forms.BindingSource bsPBSConfig;
        private dsPBSTableAdapters.PBS_ConfigTableAdapter taPBSConfig;
        private System.Windows.Forms.DataGridView dgvPBSConfigScheme;
        private System.Windows.Forms.BindingSource bsPBSConfigScheme;
        private dsPBSTableAdapters.PBS_ConfigSchemeTableAdapter taPBSConfigScheme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPBS_ConfigID;
        private dsPBSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.TextBox txtVehicleApproval;
        private System.Windows.Forms.Button btnFindOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgeAssessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBS_ConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchemeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVMTruckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveAxleLoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveAxleLoadUOM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn massMgmtRqdDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.GroupBox gbPBSTables;
        private System.Windows.Forms.GroupBox gbPBSGVMConfig;
        private System.Windows.Forms.GroupBox gbPBSVA;
        private System.Windows.Forms.TextBox txtInstruction1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSaveVA;
    }
}