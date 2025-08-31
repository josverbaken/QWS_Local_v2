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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.bsPBS = new System.Windows.Forms.BindingSource(this.components);
            this.dsPBS = new QWS_Local.dsPBS();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindOwner = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.txtVehicleApproval = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.gbPBSTables = new System.Windows.Forms.GroupBox();
            this.dgvPBSConfigMatrix = new System.Windows.Forms.DataGridView();
            this.pBSConfigMatrixIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSConfigIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSTruckNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSTrailerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPBSConfigMatrix = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bsPBSConfig = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSavePBSConfigMatrix = new System.Windows.Forms.Button();
            this.btnFindPBSConfigMatrix = new System.Windows.Forms.Button();
            this.dgvPBSConfig = new System.Windows.Forms.DataGridView();
            this.tableNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgeAssessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSavePBSTables = new System.Windows.Forms.Button();
            this.gbPBSGVMConfig = new System.Windows.Forms.GroupBox();
            this.dgvPBSConfigScheme = new System.Windows.Forms.DataGridView();
            this.bsPBSConfigScheme = new System.Windows.Forms.BindingSource(this.components);
            this.gbPBSVA = new System.Windows.Forms.GroupBox();
            this.btnNewVIN = new System.Windows.Forms.Button();
            this.btnRefreshPBSVehicles = new System.Windows.Forms.Button();
            this.btnAcceptVIN = new System.Windows.Forms.Button();
            this.dgvPBS_Vehicles = new System.Windows.Forms.DataGridView();
            this.pBSVehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.truckTypeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPBSVehicles = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveVA = new System.Windows.Forms.Button();
            this.txtFoundVIN = new System.Windows.Forms.TextBox();
            this.dgvPBS = new System.Windows.Forms.DataGridView();
            this.vehicleApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindVIN = new System.Windows.Forms.Button();
            this.txtRego4VIN = new System.Windows.Forms.TextBox();
            this.btnSAVEPBS_Vehicle = new System.Windows.Forms.Button();
            this.taPBS = new QWS_Local.dsPBSTableAdapters.PBSTableAdapter();
            this.taPBSConfig = new QWS_Local.dsPBSTableAdapters.PBS_ConfigTableAdapter();
            this.taPBSConfigScheme = new QWS_Local.dsPBSTableAdapters.PBS_ConfigSchemeTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsPBSTableAdapters.TableAdapterManager();
            this.taPBSVehicles = new QWS_Local.dsPBSTableAdapters.PBS_VehiclesTableAdapter();
            this.taPBSConfigMatrix = new QWS_Local.dsPBSTableAdapters.PBS_ConfigMatrixTableAdapter();
            this.pBSLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS_ConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchemeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gVMTruckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveAxleLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveAxleLoadUOM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.massMgmtRqdDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).BeginInit();
            this.gbPBSTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfig)).BeginInit();
            this.gbPBSGVMConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigScheme)).BeginInit();
            this.gbPBSVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS_Vehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label3);
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
            this.splitContainer1.Panel2.Controls.Add(this.gbPBSTables);
            this.splitContainer1.Panel2.Controls.Add(this.gbPBSGVMConfig);
            this.splitContainer1.Panel2.Controls.Add(this.gbPBSVA);
            this.splitContainer1.Size = new System.Drawing.Size(1258, 783);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "...";
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
            this.bsPBS.CurrentChanged += new System.EventHandler(this.bsPBS_CurrentChanged);
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
            this.btnFindOwner.TabIndex = 4;
            this.btnFindOwner.Text = "Set";
            this.btnFindOwner.UseVisualStyleBackColor = true;
            this.btnFindOwner.Click += new System.EventHandler(this.btnFindOwner_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Location = new System.Drawing.Point(393, 29);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(100, 30);
            this.btnSaveTable.TabIndex = 2;
            this.btnSaveTable.Text = "Find (F3)";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtVehicleApproval
            // 
            this.txtVehicleApproval.Location = new System.Drawing.Point(181, 35);
            this.txtVehicleApproval.Name = "txtVehicleApproval";
            this.txtVehicleApproval.Size = new System.Drawing.Size(100, 24);
            this.txtVehicleApproval.TabIndex = 1;
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "Operator", true));
            this.txtOperator.Location = new System.Drawing.Point(34, 65);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(459, 24);
            this.txtOperator.TabIndex = 3;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(876, 453);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(78, 29);
            this.btnSaveConfig.TabIndex = 22;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // gbPBSTables
            // 
            this.gbPBSTables.Controls.Add(this.dgvPBSConfigMatrix);
            this.gbPBSTables.Controls.Add(this.textBox2);
            this.gbPBSTables.Controls.Add(this.textBox1);
            this.gbPBSTables.Controls.Add(this.btnSavePBSConfigMatrix);
            this.gbPBSTables.Controls.Add(this.btnFindPBSConfigMatrix);
            this.gbPBSTables.Controls.Add(this.dgvPBSConfig);
            this.gbPBSTables.Controls.Add(this.btnSavePBSTables);
            this.gbPBSTables.Location = new System.Drawing.Point(15, 231);
            this.gbPBSTables.Name = "gbPBSTables";
            this.gbPBSTables.Size = new System.Drawing.Size(855, 160);
            this.gbPBSTables.TabIndex = 3;
            this.gbPBSTables.TabStop = false;
            this.gbPBSTables.Text = "PBS Tables and Vehicle Matrix";
            // 
            // dgvPBSConfigMatrix
            // 
            this.dgvPBSConfigMatrix.AutoGenerateColumns = false;
            this.dgvPBSConfigMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBSConfigMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBSConfigMatrixIDDataGridViewTextBoxColumn,
            this.pBSConfigIDDataGridViewTextBoxColumn,
            this.pBSTruckNoDataGridViewTextBoxColumn,
            this.pBSTrailerNoDataGridViewTextBoxColumn});
            this.dgvPBSConfigMatrix.DataSource = this.bsPBSConfigMatrix;
            this.dgvPBSConfigMatrix.Location = new System.Drawing.Point(458, 20);
            this.dgvPBSConfigMatrix.Name = "dgvPBSConfigMatrix";
            this.dgvPBSConfigMatrix.Size = new System.Drawing.Size(273, 134);
            this.dgvPBSConfigMatrix.TabIndex = 26;
            this.dgvPBSConfigMatrix.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPBSConfigMatrix_DefaultValuesNeeded);
            // 
            // pBSConfigMatrixIDDataGridViewTextBoxColumn
            // 
            this.pBSConfigMatrixIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_ConfigMatrixID";
            this.pBSConfigMatrixIDDataGridViewTextBoxColumn.HeaderText = "PBS_ConfigMatrixID";
            this.pBSConfigMatrixIDDataGridViewTextBoxColumn.Name = "pBSConfigMatrixIDDataGridViewTextBoxColumn";
            this.pBSConfigMatrixIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pBSConfigMatrixIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pBSConfigIDDataGridViewTextBoxColumn
            // 
            this.pBSConfigIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_ConfigID";
            this.pBSConfigIDDataGridViewTextBoxColumn.HeaderText = "PBS_ConfigID";
            this.pBSConfigIDDataGridViewTextBoxColumn.Name = "pBSConfigIDDataGridViewTextBoxColumn";
            this.pBSConfigIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pBSTruckNoDataGridViewTextBoxColumn
            // 
            this.pBSTruckNoDataGridViewTextBoxColumn.DataPropertyName = "PBS_TruckNo";
            this.pBSTruckNoDataGridViewTextBoxColumn.HeaderText = "TruckNo";
            this.pBSTruckNoDataGridViewTextBoxColumn.Name = "pBSTruckNoDataGridViewTextBoxColumn";
            // 
            // pBSTrailerNoDataGridViewTextBoxColumn
            // 
            this.pBSTrailerNoDataGridViewTextBoxColumn.DataPropertyName = "PBS_TrailerNo";
            this.pBSTrailerNoDataGridViewTextBoxColumn.HeaderText = "TrailerNo";
            this.pBSTrailerNoDataGridViewTextBoxColumn.Name = "pBSTrailerNoDataGridViewTextBoxColumn";
            // 
            // bsPBSConfigMatrix
            // 
            this.bsPBSConfigMatrix.DataMember = "PBS_ConfigMatrix";
            this.bsPBSConfigMatrix.DataSource = this.dsPBS;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBSConfig, "PBS_ConfigID", true));
            this.textBox2.Location = new System.Drawing.Point(368, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 24);
            this.textBox2.TabIndex = 25;
            this.textBox2.Visible = false;
            // 
            // bsPBSConfig
            // 
            this.bsPBSConfig.DataMember = "PBS_Config";
            this.bsPBSConfig.DataSource = this.dsPBS;
            this.bsPBSConfig.CurrentChanged += new System.EventHandler(this.bsPBSConfig_CurrentChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBSConfigMatrix, "PBS_ConfigID", true));
            this.textBox1.Location = new System.Drawing.Point(746, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 24);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // btnSavePBSConfigMatrix
            // 
            this.btnSavePBSConfigMatrix.Location = new System.Drawing.Point(746, 109);
            this.btnSavePBSConfigMatrix.Name = "btnSavePBSConfigMatrix";
            this.btnSavePBSConfigMatrix.Size = new System.Drawing.Size(84, 29);
            this.btnSavePBSConfigMatrix.TabIndex = 24;
            this.btnSavePBSConfigMatrix.Text = "Save";
            this.btnSavePBSConfigMatrix.UseVisualStyleBackColor = true;
            this.btnSavePBSConfigMatrix.Click += new System.EventHandler(this.btnSavePBSConfigMatrix_Click);
            // 
            // btnFindPBSConfigMatrix
            // 
            this.btnFindPBSConfigMatrix.Location = new System.Drawing.Point(746, 35);
            this.btnFindPBSConfigMatrix.Name = "btnFindPBSConfigMatrix";
            this.btnFindPBSConfigMatrix.Size = new System.Drawing.Size(84, 29);
            this.btnFindPBSConfigMatrix.TabIndex = 24;
            this.btnFindPBSConfigMatrix.Text = "Find";
            this.btnFindPBSConfigMatrix.UseVisualStyleBackColor = true;
            this.btnFindPBSConfigMatrix.Visible = false;
            this.btnFindPBSConfigMatrix.Click += new System.EventHandler(this.btnFindPBSConfigMatrix_Click);
            // 
            // dgvPBSConfig
            // 
            this.dgvPBSConfig.AutoGenerateColumns = false;
            this.dgvPBSConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBSConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableNoDataGridViewTextBoxColumn,
            this.PBS_ID,
            this.bridgeAssessmentDataGridViewTextBoxColumn});
            this.dgvPBSConfig.DataSource = this.bsPBSConfig;
            this.dgvPBSConfig.Location = new System.Drawing.Point(3, 20);
            this.dgvPBSConfig.Name = "dgvPBSConfig";
            this.dgvPBSConfig.Size = new System.Drawing.Size(359, 137);
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
            this.bridgeAssessmentDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Tier 1",
            "Tier 2/3",
            "tba"});
            this.bridgeAssessmentDataGridViewTextBoxColumn.Name = "bridgeAssessmentDataGridViewTextBoxColumn";
            this.bridgeAssessmentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bridgeAssessmentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bridgeAssessmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnSavePBSTables
            // 
            this.btnSavePBSTables.Location = new System.Drawing.Point(368, 67);
            this.btnSavePBSTables.Name = "btnSavePBSTables";
            this.btnSavePBSTables.Size = new System.Drawing.Size(84, 29);
            this.btnSavePBSTables.TabIndex = 21;
            this.btnSavePBSTables.Text = "Save";
            this.btnSavePBSTables.UseVisualStyleBackColor = true;
            this.btnSavePBSTables.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbPBSGVMConfig
            // 
            this.gbPBSGVMConfig.Controls.Add(this.dgvPBSConfigScheme);
            this.gbPBSGVMConfig.Location = new System.Drawing.Point(12, 397);
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
            // bsPBSConfigScheme
            // 
            this.bsPBSConfigScheme.DataMember = "PBS_ConfigScheme";
            this.bsPBSConfigScheme.DataSource = this.dsPBS;
            // 
            // gbPBSVA
            // 
            this.gbPBSVA.Controls.Add(this.btnNewVIN);
            this.gbPBSVA.Controls.Add(this.btnRefreshPBSVehicles);
            this.gbPBSVA.Controls.Add(this.btnAcceptVIN);
            this.gbPBSVA.Controls.Add(this.dgvPBS_Vehicles);
            this.gbPBSVA.Controls.Add(this.btnSaveVA);
            this.gbPBSVA.Controls.Add(this.txtFoundVIN);
            this.gbPBSVA.Controls.Add(this.dgvPBS);
            this.gbPBSVA.Controls.Add(this.btnFindVIN);
            this.gbPBSVA.Controls.Add(this.txtRego4VIN);
            this.gbPBSVA.Controls.Add(this.btnSAVEPBS_Vehicle);
            this.gbPBSVA.Location = new System.Drawing.Point(12, 3);
            this.gbPBSVA.Name = "gbPBSVA";
            this.gbPBSVA.Size = new System.Drawing.Size(1223, 208);
            this.gbPBSVA.TabIndex = 18;
            this.gbPBSVA.TabStop = false;
            this.gbPBSVA.Text = "Vehicle Approval and Associated Vehicles";
            // 
            // btnNewVIN
            // 
            this.btnNewVIN.Location = new System.Drawing.Point(1030, 123);
            this.btnNewVIN.Name = "btnNewVIN";
            this.btnNewVIN.Size = new System.Drawing.Size(84, 29);
            this.btnNewVIN.TabIndex = 31;
            this.btnNewVIN.Text = "New VIN";
            this.btnNewVIN.UseVisualStyleBackColor = true;
            this.btnNewVIN.Click += new System.EventHandler(this.btnNewVIN_Click);
            // 
            // btnRefreshPBSVehicles
            // 
            this.btnRefreshPBSVehicles.Location = new System.Drawing.Point(1122, 23);
            this.btnRefreshPBSVehicles.Name = "btnRefreshPBSVehicles";
            this.btnRefreshPBSVehicles.Size = new System.Drawing.Size(84, 29);
            this.btnRefreshPBSVehicles.TabIndex = 30;
            this.btnRefreshPBSVehicles.Text = "Refresh";
            this.btnRefreshPBSVehicles.UseVisualStyleBackColor = true;
            this.btnRefreshPBSVehicles.Click += new System.EventHandler(this.btnRefreshPBSVehicles_Click);
            // 
            // btnAcceptVIN
            // 
            this.btnAcceptVIN.Location = new System.Drawing.Point(1122, 123);
            this.btnAcceptVIN.Name = "btnAcceptVIN";
            this.btnAcceptVIN.Size = new System.Drawing.Size(84, 29);
            this.btnAcceptVIN.TabIndex = 29;
            this.btnAcceptVIN.Text = "Update";
            this.btnAcceptVIN.UseVisualStyleBackColor = true;
            this.btnAcceptVIN.Click += new System.EventHandler(this.btnAcceptVIN_Click);
            // 
            // dgvPBS_Vehicles
            // 
            this.dgvPBS_Vehicles.AllowUserToAddRows = false;
            this.dgvPBS_Vehicles.AutoGenerateColumns = false;
            this.dgvPBS_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBS_Vehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBSVehicleIDDataGridViewTextBoxColumn,
            this.pBSIDDataGridViewTextBoxColumn,
            this.vINDataGridViewTextBoxColumn,
            this.truckTypeDataGridViewTextBoxColumn,
            this.truckTypeNoDataGridViewTextBoxColumn,
            this.Rego});
            this.dgvPBS_Vehicles.DataSource = this.bsPBSVehicles;
            this.dgvPBS_Vehicles.Location = new System.Drawing.Point(461, 23);
            this.dgvPBS_Vehicles.Name = "dgvPBS_Vehicles";
            this.dgvPBS_Vehicles.Size = new System.Drawing.Size(554, 171);
            this.dgvPBS_Vehicles.TabIndex = 21;
            // 
            // pBSVehicleIDDataGridViewTextBoxColumn
            // 
            this.pBSVehicleIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_VehicleID";
            this.pBSVehicleIDDataGridViewTextBoxColumn.HeaderText = "PBS_VehicleID";
            this.pBSVehicleIDDataGridViewTextBoxColumn.Name = "pBSVehicleIDDataGridViewTextBoxColumn";
            this.pBSVehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pBSVehicleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pBSIDDataGridViewTextBoxColumn
            // 
            this.pBSIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_ID";
            this.pBSIDDataGridViewTextBoxColumn.HeaderText = "PBS_ID";
            this.pBSIDDataGridViewTextBoxColumn.Name = "pBSIDDataGridViewTextBoxColumn";
            this.pBSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vINDataGridViewTextBoxColumn
            // 
            this.vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vINDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            this.vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            this.vINDataGridViewTextBoxColumn.Width = 180;
            // 
            // truckTypeDataGridViewTextBoxColumn
            // 
            this.truckTypeDataGridViewTextBoxColumn.DataPropertyName = "TruckType";
            this.truckTypeDataGridViewTextBoxColumn.HeaderText = "TruckType";
            this.truckTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "TK",
            "TR",
            "PM",
            "TR1",
            "DY",
            "TR2",
            "tba"});
            this.truckTypeDataGridViewTextBoxColumn.Name = "truckTypeDataGridViewTextBoxColumn";
            this.truckTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.truckTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // truckTypeNoDataGridViewTextBoxColumn
            // 
            this.truckTypeNoDataGridViewTextBoxColumn.DataPropertyName = "TruckTypeNo";
            this.truckTypeNoDataGridViewTextBoxColumn.HeaderText = "TruckTypeNo";
            this.truckTypeNoDataGridViewTextBoxColumn.Name = "truckTypeNoDataGridViewTextBoxColumn";
            this.truckTypeNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // Rego
            // 
            this.Rego.DataPropertyName = "Rego";
            this.Rego.HeaderText = "Rego";
            this.Rego.Name = "Rego";
            this.Rego.ReadOnly = true;
            // 
            // bsPBSVehicles
            // 
            this.bsPBSVehicles.DataMember = "PBS_Vehicles";
            this.bsPBSVehicles.DataSource = this.dsPBS;
            // 
            // btnSaveVA
            // 
            this.btnSaveVA.Location = new System.Drawing.Point(371, 93);
            this.btnSaveVA.Name = "btnSaveVA";
            this.btnSaveVA.Size = new System.Drawing.Size(84, 29);
            this.btnSaveVA.TabIndex = 20;
            this.btnSaveVA.Text = "Save";
            this.btnSaveVA.UseVisualStyleBackColor = true;
            this.btnSaveVA.Click += new System.EventHandler(this.btnSaveVA_Click);
            // 
            // txtFoundVIN
            // 
            this.txtFoundVIN.Location = new System.Drawing.Point(1030, 93);
            this.txtFoundVIN.Name = "txtFoundVIN";
            this.txtFoundVIN.Size = new System.Drawing.Size(176, 24);
            this.txtFoundVIN.TabIndex = 27;
            // 
            // dgvPBS
            // 
            this.dgvPBS.AllowUserToDeleteRows = false;
            this.dgvPBS.AutoGenerateColumns = false;
            this.dgvPBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleApprovalDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.approvalDTDataGridViewTextBoxColumn,
            this.Operator,
            this.CardCode});
            this.dgvPBS.DataSource = this.bsPBS;
            this.dgvPBS.Location = new System.Drawing.Point(3, 20);
            this.dgvPBS.Name = "dgvPBS";
            this.dgvPBS.Size = new System.Drawing.Size(362, 185);
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
            this.versionDataGridViewTextBoxColumn.Width = 80;
            // 
            // approvalDTDataGridViewTextBoxColumn
            // 
            this.approvalDTDataGridViewTextBoxColumn.DataPropertyName = "ApprovalDT";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.approvalDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.approvalDTDataGridViewTextBoxColumn.HeaderText = "ApprovalDT";
            this.approvalDTDataGridViewTextBoxColumn.Name = "approvalDTDataGridViewTextBoxColumn";
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "Operator";
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            this.Operator.Visible = false;
            // 
            // CardCode
            // 
            this.CardCode.DataPropertyName = "CardCode";
            this.CardCode.HeaderText = "CardCode";
            this.CardCode.Name = "CardCode";
            this.CardCode.Visible = false;
            // 
            // btnFindVIN
            // 
            this.btnFindVIN.Location = new System.Drawing.Point(1122, 58);
            this.btnFindVIN.Name = "btnFindVIN";
            this.btnFindVIN.Size = new System.Drawing.Size(84, 29);
            this.btnFindVIN.TabIndex = 24;
            this.btnFindVIN.Text = "Find";
            this.btnFindVIN.UseVisualStyleBackColor = true;
            this.btnFindVIN.Click += new System.EventHandler(this.btnFindVIN_Click);
            // 
            // txtRego4VIN
            // 
            this.txtRego4VIN.Location = new System.Drawing.Point(1030, 60);
            this.txtRego4VIN.Name = "txtRego4VIN";
            this.txtRego4VIN.Size = new System.Drawing.Size(84, 24);
            this.txtRego4VIN.TabIndex = 28;
            // 
            // btnSAVEPBS_Vehicle
            // 
            this.btnSAVEPBS_Vehicle.Location = new System.Drawing.Point(1122, 158);
            this.btnSAVEPBS_Vehicle.Name = "btnSAVEPBS_Vehicle";
            this.btnSAVEPBS_Vehicle.Size = new System.Drawing.Size(84, 29);
            this.btnSAVEPBS_Vehicle.TabIndex = 22;
            this.btnSAVEPBS_Vehicle.Text = "Save";
            this.btnSAVEPBS_Vehicle.UseVisualStyleBackColor = true;
            this.btnSAVEPBS_Vehicle.Click += new System.EventHandler(this.btnSAVEPBS_Vehicle_Click);
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
            this.tableAdapterManager.PBS_ConfigMatrixTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBS_VehiclesTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsPBSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taPBSVehicles
            // 
            this.taPBSVehicles.ClearBeforeFill = true;
            // 
            // taPBSConfigMatrix
            // 
            this.taPBSConfigMatrix.ClearBeforeFill = true;
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
            this.SchemeCode.Items.AddRange(new object[] {
            "GML",
            "HML",
            "L1-GML"});
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
            this.DriveAxleLoadUOM.Items.AddRange(new object[] {
            "Ratio",
            "Tonnes"});
            this.DriveAxleLoadUOM.Name = "DriveAxleLoadUOM";
            // 
            // massMgmtRqdDataGridViewCheckBoxColumn
            // 
            this.massMgmtRqdDataGridViewCheckBoxColumn.DataPropertyName = "MassMgmtRqd";
            this.massMgmtRqdDataGridViewCheckBoxColumn.HeaderText = "MassMgmtRqd";
            this.massMgmtRqdDataGridViewCheckBoxColumn.Name = "massMgmtRqdDataGridViewCheckBoxColumn";
            // 
            // PBSManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 783);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PBSManagement";
            this.Text = "PBS Maintenance v2";
            this.Load += new System.EventHandler(this.PBSManagement_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PBSManagement_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).EndInit();
            this.gbPBSTables.ResumeLayout(false);
            this.gbPBSTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfig)).EndInit();
            this.gbPBSGVMConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigScheme)).EndInit();
            this.gbPBSVA.ResumeLayout(false);
            this.gbPBSVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS_Vehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPBS;
        private dsPBS dsPBS;
        private System.Windows.Forms.BindingSource bsPBS;
        private dsPBSTableAdapters.PBSTableAdapter taPBS;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.DataGridView dgvPBSConfig;
        private System.Windows.Forms.BindingSource bsPBSConfig;
        private dsPBSTableAdapters.PBS_ConfigTableAdapter taPBSConfig;
        private System.Windows.Forms.DataGridView dgvPBSConfigScheme;
        private System.Windows.Forms.BindingSource bsPBSConfigScheme;
        private dsPBSTableAdapters.PBS_ConfigSchemeTableAdapter taPBSConfigScheme;
        private dsPBSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.TextBox txtVehicleApproval;
        private System.Windows.Forms.Button btnFindOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.GroupBox gbPBSTables;
        private System.Windows.Forms.GroupBox gbPBSGVMConfig;
        private System.Windows.Forms.GroupBox gbPBSVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnSavePBSTables;
        private System.Windows.Forms.Button btnSaveVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleApprovalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardCode;
        private System.Windows.Forms.DataGridView dgvPBS_Vehicles;
        private System.Windows.Forms.BindingSource bsPBSVehicles;
        private dsPBSTableAdapters.PBS_VehiclesTableAdapter taPBSVehicles;
        private System.Windows.Forms.Button btnSAVEPBS_Vehicle;
        private System.Windows.Forms.BindingSource bsPBSConfigMatrix;
        private dsPBSTableAdapters.PBS_ConfigMatrixTableAdapter taPBSConfigMatrix;
        private System.Windows.Forms.Button btnFindPBSConfigMatrix;
        private System.Windows.Forms.Button btnSavePBSConfigMatrix;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvPBSConfigMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSConfigMatrixIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSConfigIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSTruckNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSTrailerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtFoundVIN;
        private System.Windows.Forms.TextBox txtRego4VIN;
        private System.Windows.Forms.Button btnFindVIN;
        private System.Windows.Forms.Button btnAcceptVIN;
        private System.Windows.Forms.Button btnRefreshPBSVehicles;
        private System.Windows.Forms.Button btnNewVIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSVehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn truckTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckTypeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rego;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBS_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn bridgeAssessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBS_ConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn SchemeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVMTruckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveAxleLoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DriveAxleLoadUOM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn massMgmtRqdDataGridViewCheckBoxColumn;
    }
}