namespace QWS_Local
{
    partial class TrucksInQuarryAudit
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpAudit = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsWeightLog = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.taWeightLog = new QWS_Local.dsTIQ2TableAdapters.CheckWeightLogTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wBConnectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wBReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWeightLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFindAll);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpAudit);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtRego);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 623);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtpAudit
            // 
            this.dtpAudit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAudit.Location = new System.Drawing.Point(59, 122);
            this.dtpAudit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAudit.Name = "dtpAudit";
            this.dtpAudit.Size = new System.Drawing.Size(150, 24);
            this.dtpAudit.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(59, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRego
            // 
            this.txtRego.Location = new System.Drawing.Point(59, 60);
            this.txtRego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(150, 24);
            this.txtRego.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn,
            this.tMDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.wBIDDataGridViewTextBoxColumn,
            this.wBConnectedDataGridViewCheckBoxColumn,
            this.wBReadingDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsWeightLog;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(931, 623);
            this.dataGridView1.TabIndex = 0;
            // 
            // bsWeightLog
            // 
            this.bsWeightLog.DataMember = "CheckWeightLog";
            this.bsWeightLog.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taWeightLog
            // 
            this.taWeightLog.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Rego";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 24);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Date";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            this.regoDataGridViewTextBoxColumn.ReadOnly = true;
            this.regoDataGridViewTextBoxColumn.Width = 70;
            // 
            // tMDataGridViewTextBoxColumn
            // 
            this.tMDataGridViewTextBoxColumn.DataPropertyName = "TM";
            this.tMDataGridViewTextBoxColumn.HeaderText = "Time";
            this.tMDataGridViewTextBoxColumn.Name = "tMDataGridViewTextBoxColumn";
            this.tMDataGridViewTextBoxColumn.ReadOnly = true;
            this.tMDataGridViewTextBoxColumn.Width = 70;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 130;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 60;
            // 
            // wBIDDataGridViewTextBoxColumn
            // 
            this.wBIDDataGridViewTextBoxColumn.DataPropertyName = "WBID";
            this.wBIDDataGridViewTextBoxColumn.HeaderText = "WBID";
            this.wBIDDataGridViewTextBoxColumn.Name = "wBIDDataGridViewTextBoxColumn";
            this.wBIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.wBIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // wBConnectedDataGridViewCheckBoxColumn
            // 
            this.wBConnectedDataGridViewCheckBoxColumn.DataPropertyName = "WBConnected";
            this.wBConnectedDataGridViewCheckBoxColumn.HeaderText = "Connected";
            this.wBConnectedDataGridViewCheckBoxColumn.Name = "wBConnectedDataGridViewCheckBoxColumn";
            this.wBConnectedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.wBConnectedDataGridViewCheckBoxColumn.Width = 90;
            // 
            // wBReadingDataGridViewTextBoxColumn
            // 
            this.wBReadingDataGridViewTextBoxColumn.DataPropertyName = "WBReading";
            this.wBReadingDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.wBReadingDataGridViewTextBoxColumn.Name = "wBReadingDataGridViewTextBoxColumn";
            this.wBReadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Width = 300;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(59, 201);
            this.btnFindAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(150, 39);
            this.btnFindAll.TabIndex = 6;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // TrucksInQuarryAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrucksInQuarryAudit";
            this.Text = "TrucksInQuarryAudit";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWeightLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsWeightLog;
        private dsTIQ2 dsTIQ2;
        private dsTIQ2TableAdapters.CheckWeightLogTableAdapter taWeightLog;
        private System.Windows.Forms.DateTimePicker dtpAudit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wBConnectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wBReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFindAll;
    }
}