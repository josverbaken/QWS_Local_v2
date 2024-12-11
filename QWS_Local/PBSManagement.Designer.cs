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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindOwner = new System.Windows.Forms.Button();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtVehicleApproval = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPBS_ConfigID = new System.Windows.Forms.TextBox();
            this.bsPBSConfig = new System.Windows.Forms.BindingSource(this.components);
            this.dsPBS = new QWS_Local.dsPBS();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.bsPBS = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPBS = new System.Windows.Forms.DataGridView();
            this.vehicleApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPBS_ID = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvPBSConfig = new System.Windows.Forms.DataGridView();
            this.tableNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgeAssessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPBSConfigScheme = new System.Windows.Forms.DataGridView();
            this.pBSLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS_ConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVMTruckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveAxleLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveAxleLoadUOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massMgmtRqdDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsPBSConfigScheme = new System.Windows.Forms.BindingSource(this.components);
            this.taPBS = new QWS_Local.dsPBSTableAdapters.PBSTableAdapter();
            this.taPBSConfig = new QWS_Local.dsPBSTableAdapters.PBS_ConfigTableAdapter();
            this.taPBSConfigScheme = new QWS_Local.dsPBSTableAdapters.PBS_ConfigSchemeTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsPBSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigScheme)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindOwner);
            this.splitContainer1.Panel1.Controls.Add(this.txtOwner);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.txtVehicleApproval);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtPBS_ConfigID);
            this.splitContainer1.Panel1.Controls.Add(this.txtOperator);
            this.splitContainer1.Panel1.Controls.Add(this.dgvPBS);
            this.splitContainer1.Panel1.Controls.Add(this.splitter2);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPBS_ID);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1111, 623);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "VA";
            // 
            // btnFindOwner
            // 
            this.btnFindOwner.Location = new System.Drawing.Point(250, 104);
            this.btnFindOwner.Name = "btnFindOwner";
            this.btnFindOwner.Size = new System.Drawing.Size(100, 30);
            this.btnFindOwner.TabIndex = 14;
            this.btnFindOwner.Text = "Find";
            this.btnFindOwner.UseVisualStyleBackColor = true;
            this.btnFindOwner.Click += new System.EventHandler(this.btnFindOwner_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(34, 107);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(206, 24);
            this.txtOwner.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtVehicleApproval
            // 
            this.txtVehicleApproval.Location = new System.Drawing.Point(140, 71);
            this.txtVehicleApproval.Name = "txtVehicleApproval";
            this.txtVehicleApproval.Size = new System.Drawing.Size(100, 24);
            this.txtVehicleApproval.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPBS_ConfigID
            // 
            this.txtPBS_ConfigID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBSConfig, "PBS_ConfigID", true));
            this.txtPBS_ConfigID.Location = new System.Drawing.Point(159, 252);
            this.txtPBS_ConfigID.Name = "txtPBS_ConfigID";
            this.txtPBS_ConfigID.Size = new System.Drawing.Size(81, 24);
            this.txtPBS_ConfigID.TabIndex = 9;
            // 
            // bsPBSConfig
            // 
            this.bsPBSConfig.DataMember = "PBS_Config";
            this.bsPBSConfig.DataSource = this.dsPBS;
            // 
            // dsPBS
            // 
            this.dsPBS.DataSetName = "dsPBS";
            this.dsPBS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "Operator", true));
            this.txtOperator.Location = new System.Drawing.Point(34, 151);
            this.txtOperator.Multiline = true;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(316, 50);
            this.txtOperator.TabIndex = 8;
            // 
            // bsPBS
            // 
            this.bsPBS.DataMember = "PBS";
            this.bsPBS.DataSource = this.dsPBS;
            // 
            // dgvPBS
            // 
            this.dgvPBS.AllowUserToAddRows = false;
            this.dgvPBS.AllowUserToDeleteRows = false;
            this.dgvPBS.AutoGenerateColumns = false;
            this.dgvPBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleApprovalDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.approvalDTDataGridViewTextBoxColumn});
            this.dgvPBS.DataSource = this.bsPBS;
            this.dgvPBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPBS.Location = new System.Drawing.Point(0, 295);
            this.dgvPBS.Name = "dgvPBS";
            this.dgvPBS.ReadOnly = true;
            this.dgvPBS.Size = new System.Drawing.Size(366, 165);
            this.dgvPBS.TabIndex = 7;
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.approvalDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.approvalDTDataGridViewTextBoxColumn.HeaderText = "ApprovalDT";
            this.approvalDTDataGridViewTextBoxColumn.Name = "approvalDTDataGridViewTextBoxColumn";
            this.approvalDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 460);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(366, 163);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPBS_ID
            // 
            this.txtPBS_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "PBS_ID", true));
            this.txtPBS_ID.Location = new System.Drawing.Point(159, 209);
            this.txtPBS_ID.Name = "txtPBS_ID";
            this.txtPBS_ID.Size = new System.Drawing.Size(81, 24);
            this.txtPBS_ID.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(366, 295);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvPBSConfig);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvPBSConfigScheme);
            this.splitContainer2.Size = new System.Drawing.Size(741, 623);
            this.splitContainer2.SplitterDistance = 243;
            this.splitContainer2.TabIndex = 0;
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
            this.dgvPBSConfig.Location = new System.Drawing.Point(0, 0);
            this.dgvPBSConfig.Name = "dgvPBSConfig";
            this.dgvPBSConfig.Size = new System.Drawing.Size(741, 243);
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
            // dgvPBSConfigScheme
            // 
            this.dgvPBSConfigScheme.AutoGenerateColumns = false;
            this.dgvPBSConfigScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPBSConfigScheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBSLevelDataGridViewTextBoxColumn,
            this.PBS_ConfigID,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.gCMDataGridViewTextBoxColumn,
            this.gVMTruckDataGridViewTextBoxColumn,
            this.driveAxleLoadDataGridViewTextBoxColumn,
            this.driveAxleLoadUOMDataGridViewTextBoxColumn,
            this.massMgmtRqdDataGridViewCheckBoxColumn});
            this.dgvPBSConfigScheme.DataSource = this.bsPBSConfigScheme;
            this.dgvPBSConfigScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPBSConfigScheme.Location = new System.Drawing.Point(0, 0);
            this.dgvPBSConfigScheme.Name = "dgvPBSConfigScheme";
            this.dgvPBSConfigScheme.Size = new System.Drawing.Size(741, 376);
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
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "Scheme";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
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
            // driveAxleLoadUOMDataGridViewTextBoxColumn
            // 
            this.driveAxleLoadUOMDataGridViewTextBoxColumn.DataPropertyName = "DriveAxleLoadUOM";
            this.driveAxleLoadUOMDataGridViewTextBoxColumn.HeaderText = "UOM";
            this.driveAxleLoadUOMDataGridViewTextBoxColumn.Name = "driveAxleLoadUOMDataGridViewTextBoxColumn";
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
            // PBSManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 623);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PBSManagement";
            this.Text = "PBS Maintenance v2";
            this.Load += new System.EventHandler(this.PBSManagement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBSConfigScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfigScheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPBS_ID;
        private System.Windows.Forms.DataGridView dgvPBS;
        private System.Windows.Forms.Splitter splitter2;
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private dsPBSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtVehicleApproval;
        private System.Windows.Forms.Button btnFindOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgeAssessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBS_ConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVMTruckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveAxleLoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveAxleLoadUOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn massMgmtRqdDataGridViewCheckBoxColumn;
    }
}