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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.bsPBS = new System.Windows.Forms.BindingSource(this.components);
            this.dsPBS = new QWS_Local.dsPBS();
            this.dgvPBS = new System.Windows.Forms.DataGridView();
            this.vehicleApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetPBS = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pBSConfigIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgeAssessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPBSConfig = new System.Windows.Forms.BindingSource(this.components);
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.taPBS = new QWS_Local.dsPBSTableAdapters.PBSTableAdapter();
            this.taPBSConfig = new QWS_Local.dsPBSTableAdapters.PBS_ConfigTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtOperator);
            this.splitContainer1.Panel1.Controls.Add(this.dgvPBS);
            this.splitContainer1.Panel1.Controls.Add(this.splitter2);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetPBS);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.txtCardCode);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1057, 623);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "Operator", true));
            this.txtOperator.Location = new System.Drawing.Point(34, 69);
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
            // dsPBS
            // 
            this.dsPBS.DataSetName = "dsPBS";
            this.dsPBS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dgvPBS.Size = new System.Drawing.Size(381, 165);
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.approvalDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.approvalDTDataGridViewTextBoxColumn.HeaderText = "ApprovalDT";
            this.approvalDTDataGridViewTextBoxColumn.Name = "approvalDTDataGridViewTextBoxColumn";
            this.approvalDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 460);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(381, 163);
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
            // btnGetPBS
            // 
            this.btnGetPBS.Location = new System.Drawing.Point(140, 24);
            this.btnGetPBS.Name = "btnGetPBS";
            this.btnGetPBS.Size = new System.Drawing.Size(100, 30);
            this.btnGetPBS.TabIndex = 3;
            this.btnGetPBS.Text = "Find";
            this.btnGetPBS.UseVisualStyleBackColor = true;
            this.btnGetPBS.Click += new System.EventHandler(this.btnGetPBS_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPBS, "PBS_ID", true));
            this.textBox2.Location = new System.Drawing.Point(159, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 2;
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(34, 27);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(100, 24);
            this.txtCardCode.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(381, 295);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.splitter4);
            this.tabPage1.Controls.Add(this.splitter3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBSConfigIDDataGridViewTextBoxColumn,
            this.pBSIDDataGridViewTextBoxColumn,
            this.tableNoDataGridViewTextBoxColumn,
            this.bridgeAssessmentDataGridViewTextBoxColumn,
            this.axleConfigurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsPBSConfig;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 210);
            this.dataGridView1.TabIndex = 2;
            // 
            // pBSConfigIDDataGridViewTextBoxColumn
            // 
            this.pBSConfigIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_ConfigID";
            this.pBSConfigIDDataGridViewTextBoxColumn.HeaderText = "PBS_ConfigID";
            this.pBSConfigIDDataGridViewTextBoxColumn.Name = "pBSConfigIDDataGridViewTextBoxColumn";
            this.pBSConfigIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pBSIDDataGridViewTextBoxColumn
            // 
            this.pBSIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_ID";
            this.pBSIDDataGridViewTextBoxColumn.HeaderText = "PBS_ID";
            this.pBSIDDataGridViewTextBoxColumn.Name = "pBSIDDataGridViewTextBoxColumn";
            // 
            // tableNoDataGridViewTextBoxColumn
            // 
            this.tableNoDataGridViewTextBoxColumn.DataPropertyName = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.HeaderText = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.Name = "tableNoDataGridViewTextBoxColumn";
            // 
            // bridgeAssessmentDataGridViewTextBoxColumn
            // 
            this.bridgeAssessmentDataGridViewTextBoxColumn.DataPropertyName = "BridgeAssessment";
            this.bridgeAssessmentDataGridViewTextBoxColumn.HeaderText = "BridgeAssessment";
            this.bridgeAssessmentDataGridViewTextBoxColumn.Name = "bridgeAssessmentDataGridViewTextBoxColumn";
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            // 
            // bsPBSConfig
            // 
            this.bsPBSConfig.DataMember = "PBS_Config";
            this.bsPBSConfig.DataSource = this.dsPBS;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(3, 399);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(658, 190);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(3, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(658, 186);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // taPBS
            // 
            this.taPBS.ClearBeforeFill = true;
            // 
            // taPBSConfig
            // 
            this.taPBSConfig.ClearBeforeFill = true;
            // 
            // PBSManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 623);
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
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPBS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBSConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGetPBS;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPBS;
        private System.Windows.Forms.Splitter splitter2;
        private dsPBS dsPBS;
        private System.Windows.Forms.BindingSource bsPBS;
        private dsPBSTableAdapters.PBSTableAdapter taPBS;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleApprovalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.BindingSource bsPBSConfig;
        private dsPBSTableAdapters.PBS_ConfigTableAdapter taPBSConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSConfigIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgeAssessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
    }
}