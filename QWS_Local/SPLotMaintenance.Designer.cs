namespace QWS_Local
{
    partial class SPLotMaintenance
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSPLots = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindBaseItemCode = new System.Windows.Forms.Button();
            this.txtBaseItemCode = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BaseItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOpen = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.tpDockets = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSPLotNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem2Report = new System.Windows.Forms.TextBox();
            this.btnGetReportData = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpManual = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManualItemCode = new System.Windows.Forms.TextBox();
            this.btnSaveManualAllocation = new System.Windows.Forms.Button();
            this.btnRefreshManualAllocation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbClearFilter = new System.Windows.Forms.RadioButton();
            this.rbLotNoFilter = new System.Windows.Forms.RadioButton();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tpBaseItem = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.bsStockpileBOM = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.allocationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocationDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStockpileLotAllocation = new System.Windows.Forms.BindingSource(this.components);
            this.bsSPLotNoAudit = new System.Windows.Forms.BindingSource(this.components);
            this.allocationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPLotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docketNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonnesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reversalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStockpileManualAllocation = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseItemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSPLotItemsMap = new System.Windows.Forms.BindingSource(this.components);
            this.taStockpileLotAllocation = new QWS_Local.dsTIQ2TableAdapters.StockpileLotAllocationTableAdapter();
            this.taStockpileBOM = new QWS_Local.dsTIQ2TableAdapters.StockpileBOMTableAdapter();
            this.taSPLotNoAudit = new QWS_Local.dsTIQ2TableAdapters.SPLotNoAuditTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.SPLotNoAuditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taStockpileManualAllocation = new QWS_Local.dsTIQ2TableAdapters.StockpileManualAllocationTableAdapter();
            this.taSPLotItemsMap = new QWS_Local.dsTIQ2TableAdapters.SPLotItemsMapTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tpSPLots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpDockets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tpManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpBaseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileLotAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotNoAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileManualAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotItemsMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPLotNoAuditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSPLots);
            this.tabControl1.Controls.Add(this.tpDockets);
            this.tabControl1.Controls.Add(this.tpManual);
            this.tabControl1.Controls.Add(this.tpBaseItem);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 806);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSPLots
            // 
            this.tpSPLots.Controls.Add(this.splitContainer1);
            this.tpSPLots.Location = new System.Drawing.Point(4, 27);
            this.tpSPLots.Margin = new System.Windows.Forms.Padding(4);
            this.tpSPLots.Name = "tpSPLots";
            this.tpSPLots.Padding = new System.Windows.Forms.Padding(4);
            this.tpSPLots.Size = new System.Drawing.Size(1132, 775);
            this.tpSPLots.TabIndex = 0;
            this.tpSPLots.Text = "Stockpile Lot Allocation";
            this.tpSPLots.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFindAll);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindBaseItemCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtBaseItemCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemCode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 767);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Base Item Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Code";
            // 
            // btnFindBaseItemCode
            // 
            this.btnFindBaseItemCode.Location = new System.Drawing.Point(159, 134);
            this.btnFindBaseItemCode.Name = "btnFindBaseItemCode";
            this.btnFindBaseItemCode.Size = new System.Drawing.Size(100, 33);
            this.btnFindBaseItemCode.TabIndex = 2;
            this.btnFindBaseItemCode.Text = "Find";
            this.btnFindBaseItemCode.UseVisualStyleBackColor = true;
            this.btnFindBaseItemCode.Click += new System.EventHandler(this.btnFindBaseItemCode_Click);
            // 
            // txtBaseItemCode
            // 
            this.txtBaseItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStockpileBOM, "BaseItemCode", true));
            this.txtBaseItemCode.Location = new System.Drawing.Point(159, 67);
            this.txtBaseItemCode.Name = "txtBaseItemCode";
            this.txtBaseItemCode.ReadOnly = true;
            this.txtBaseItemCode.Size = new System.Drawing.Size(100, 24);
            this.txtBaseItemCode.TabIndex = 1;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(159, 24);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 24);
            this.txtItemCode.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.btnSave);
            this.splitContainer2.Size = new System.Drawing.Size(834, 767);
            this.splitContainer2.SplitterDistance = 383;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allocationIDDataGridViewTextBoxColumn,
            this.mCODataGridViewTextBoxColumn,
            this.BaseItemCode,
            this.lotNoDataGridViewTextBoxColumn,
            this.lotStatusDataGridViewTextBoxColumn,
            this.allocationDTTMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsStockpileLotAllocation;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // BaseItemCode
            // 
            this.BaseItemCode.DataPropertyName = "BaseItemCode";
            this.BaseItemCode.HeaderText = "Base Item";
            this.BaseItemCode.Name = "BaseItemCode";
            this.BaseItemCode.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbOpen);
            this.groupBox1.Location = new System.Drawing.Point(34, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Filter";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(116, 52);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(41, 22);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbOpen
            // 
            this.rbOpen.AutoSize = true;
            this.rbOpen.Location = new System.Drawing.Point(116, 23);
            this.rbOpen.Name = "rbOpen";
            this.rbOpen.Size = new System.Drawing.Size(62, 22);
            this.rbOpen.TabIndex = 0;
            this.rbOpen.TabStop = true;
            this.rbOpen.Text = "Open";
            this.rbOpen.UseVisualStyleBackColor = true;
            this.rbOpen.CheckedChanged += new System.EventHandler(this.rbOpen_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 25);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tpDockets
            // 
            this.tpDockets.Controls.Add(this.splitContainer3);
            this.tpDockets.Location = new System.Drawing.Point(4, 27);
            this.tpDockets.Margin = new System.Windows.Forms.Padding(4);
            this.tpDockets.Name = "tpDockets";
            this.tpDockets.Padding = new System.Windows.Forms.Padding(4);
            this.tpDockets.Size = new System.Drawing.Size(1132, 775);
            this.tpDockets.TabIndex = 1;
            this.tpDockets.Text = "Dockets";
            this.tpDockets.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 4);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.txtSPLotNo);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.txtItem2Report);
            this.splitContainer3.Panel1.Controls.Add(this.btnGetReportData);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer3.Size = new System.Drawing.Size(1124, 772);
            this.splitContainer3.SplitterDistance = 194;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lot No";
            // 
            // txtSPLotNo
            // 
            this.txtSPLotNo.Location = new System.Drawing.Point(40, 152);
            this.txtSPLotNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSPLotNo.Name = "txtSPLotNo";
            this.txtSPLotNo.Size = new System.Drawing.Size(148, 24);
            this.txtSPLotNo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "ItemCode";
            // 
            // txtItem2Report
            // 
            this.txtItem2Report.Location = new System.Drawing.Point(40, 69);
            this.txtItem2Report.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem2Report.Name = "txtItem2Report";
            this.txtItem2Report.Size = new System.Drawing.Size(148, 24);
            this.txtItem2Report.TabIndex = 5;
            // 
            // btnGetReportData
            // 
            this.btnGetReportData.Location = new System.Drawing.Point(40, 217);
            this.btnGetReportData.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetReportData.Name = "btnGetReportData";
            this.btnGetReportData.Size = new System.Drawing.Size(150, 40);
            this.btnGetReportData.TabIndex = 4;
            this.btnGetReportData.Text = "Find";
            this.btnGetReportData.UseVisualStyleBackColor = true;
            this.btnGetReportData.Click += new System.EventHandler(this.btnGetReportData_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bsSPLotNoAudit;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QWS_Local.SPLotNoAudit.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(924, 772);
            this.reportViewer1.TabIndex = 0;
            // 
            // tpManual
            // 
            this.tpManual.Controls.Add(this.splitContainer4);
            this.tpManual.Location = new System.Drawing.Point(4, 27);
            this.tpManual.Margin = new System.Windows.Forms.Padding(4);
            this.tpManual.Name = "tpManual";
            this.tpManual.Size = new System.Drawing.Size(1132, 775);
            this.tpManual.TabIndex = 2;
            this.tpManual.Text = "Manual Docket Allocation";
            this.tpManual.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer4.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer4.Size = new System.Drawing.Size(1132, 780);
            this.splitContainer4.SplitterDistance = 186;
            this.splitContainer4.SplitterWidth = 6;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtManualItemCode);
            this.groupBox3.Controls.Add(this.btnSaveManualAllocation);
            this.groupBox3.Controls.Add(this.btnRefreshManualAllocation);
            this.groupBox3.Location = new System.Drawing.Point(22, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 232);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Allocation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "ItemCode";
            // 
            // txtManualItemCode
            // 
            this.txtManualItemCode.Location = new System.Drawing.Point(7, 57);
            this.txtManualItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtManualItemCode.Name = "txtManualItemCode";
            this.txtManualItemCode.Size = new System.Drawing.Size(118, 24);
            this.txtManualItemCode.TabIndex = 10;
            // 
            // btnSaveManualAllocation
            // 
            this.btnSaveManualAllocation.Location = new System.Drawing.Point(7, 153);
            this.btnSaveManualAllocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveManualAllocation.Name = "btnSaveManualAllocation";
            this.btnSaveManualAllocation.Size = new System.Drawing.Size(118, 58);
            this.btnSaveManualAllocation.TabIndex = 14;
            this.btnSaveManualAllocation.Text = "Save";
            this.btnSaveManualAllocation.UseVisualStyleBackColor = true;
            this.btnSaveManualAllocation.Click += new System.EventHandler(this.btnSaveManualAllocation_Click);
            // 
            // btnRefreshManualAllocation
            // 
            this.btnRefreshManualAllocation.Location = new System.Drawing.Point(7, 89);
            this.btnRefreshManualAllocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshManualAllocation.Name = "btnRefreshManualAllocation";
            this.btnRefreshManualAllocation.Size = new System.Drawing.Size(118, 56);
            this.btnRefreshManualAllocation.TabIndex = 15;
            this.btnRefreshManualAllocation.Text = "Find";
            this.btnRefreshManualAllocation.UseVisualStyleBackColor = true;
            this.btnRefreshManualAllocation.Click += new System.EventHandler(this.btnRefreshManualAllocation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbClearFilter);
            this.groupBox2.Controls.Add(this.rbLotNoFilter);
            this.groupBox2.Controls.Add(this.txtLotNo);
            this.groupBox2.Location = new System.Drawing.Point(22, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 142);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lot No Filter";
            // 
            // rbClearFilter
            // 
            this.rbClearFilter.AutoSize = true;
            this.rbClearFilter.Location = new System.Drawing.Point(64, 105);
            this.rbClearFilter.Name = "rbClearFilter";
            this.rbClearFilter.Size = new System.Drawing.Size(61, 22);
            this.rbClearFilter.TabIndex = 14;
            this.rbClearFilter.TabStop = true;
            this.rbClearFilter.Text = "Clear";
            this.rbClearFilter.UseVisualStyleBackColor = true;
            this.rbClearFilter.CheckedChanged += new System.EventHandler(this.rbClearFilter_CheckedChanged);
            // 
            // rbLotNoFilter
            // 
            this.rbLotNoFilter.AutoSize = true;
            this.rbLotNoFilter.Location = new System.Drawing.Point(64, 76);
            this.rbLotNoFilter.Name = "rbLotNoFilter";
            this.rbLotNoFilter.Size = new System.Drawing.Size(61, 22);
            this.rbLotNoFilter.TabIndex = 13;
            this.rbLotNoFilter.TabStop = true;
            this.rbLotNoFilter.Text = "Apply";
            this.rbLotNoFilter.UseVisualStyleBackColor = true;
            this.rbLotNoFilter.CheckedChanged += new System.EventHandler(this.rbLotNoFilter_CheckedChanged);
            // 
            // txtLotNo
            // 
            this.txtLotNo.Location = new System.Drawing.Point(10, 45);
            this.txtLotNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(115, 24);
            this.txtLotNo.TabIndex = 12;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allocationIDDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.sPLotNoDataGridViewTextBoxColumn,
            this.docketNumDataGridViewTextBoxColumn,
            this.tonnesDataGridViewTextBoxColumn,
            this.reversalDataGridViewCheckBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bsStockpileManualAllocation;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(940, 780);
            this.dataGridView3.TabIndex = 0;
            // 
            // tpBaseItem
            // 
            this.tpBaseItem.Controls.Add(this.splitContainer5);
            this.tpBaseItem.Location = new System.Drawing.Point(4, 27);
            this.tpBaseItem.Name = "tpBaseItem";
            this.tpBaseItem.Size = new System.Drawing.Size(1132, 775);
            this.tpBaseItem.TabIndex = 3;
            this.tpBaseItem.Text = "Base Item Mapping";
            this.tpBaseItem.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer5.Size = new System.Drawing.Size(1132, 775);
            this.splitContainer5.SplitterDistance = 377;
            this.splitContainer5.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.itemNameDataGridViewTextBoxColumn,
            this.baseItemCodeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsSPLotItemsMap;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(751, 775);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(159, 206);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(100, 33);
            this.btnFindAll.TabIndex = 6;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // bsStockpileBOM
            // 
            this.bsStockpileBOM.DataMember = "StockpileBOM";
            this.bsStockpileBOM.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allocationIDDataGridViewTextBoxColumn
            // 
            this.allocationIDDataGridViewTextBoxColumn.DataPropertyName = "AllocationID";
            this.allocationIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.allocationIDDataGridViewTextBoxColumn.Name = "allocationIDDataGridViewTextBoxColumn";
            this.allocationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.allocationIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // mCODataGridViewTextBoxColumn
            // 
            this.mCODataGridViewTextBoxColumn.DataPropertyName = "MCO";
            this.mCODataGridViewTextBoxColumn.HeaderText = "MCO";
            this.mCODataGridViewTextBoxColumn.Name = "mCODataGridViewTextBoxColumn";
            this.mCODataGridViewTextBoxColumn.Width = 150;
            // 
            // lotNoDataGridViewTextBoxColumn
            // 
            this.lotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo";
            this.lotNoDataGridViewTextBoxColumn.HeaderText = "Lot No";
            this.lotNoDataGridViewTextBoxColumn.Name = "lotNoDataGridViewTextBoxColumn";
            this.lotNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // lotStatusDataGridViewTextBoxColumn
            // 
            this.lotStatusDataGridViewTextBoxColumn.DataPropertyName = "LotStatus";
            this.lotStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.lotStatusDataGridViewTextBoxColumn.Name = "lotStatusDataGridViewTextBoxColumn";
            this.lotStatusDataGridViewTextBoxColumn.Width = 70;
            // 
            // allocationDTTMDataGridViewTextBoxColumn
            // 
            this.allocationDTTMDataGridViewTextBoxColumn.DataPropertyName = "AllocationDTTM";
            this.allocationDTTMDataGridViewTextBoxColumn.HeaderText = "Allocation DTTM";
            this.allocationDTTMDataGridViewTextBoxColumn.Name = "allocationDTTMDataGridViewTextBoxColumn";
            this.allocationDTTMDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsStockpileLotAllocation
            // 
            this.bsStockpileLotAllocation.DataMember = "StockpileLotAllocation";
            this.bsStockpileLotAllocation.DataSource = this.dsTIQ2;
            // 
            // bsSPLotNoAudit
            // 
            this.bsSPLotNoAudit.DataMember = "SPLotNoAudit";
            this.bsSPLotNoAudit.DataSource = this.dsTIQ2;
            // 
            // allocationIDDataGridViewTextBoxColumn1
            // 
            this.allocationIDDataGridViewTextBoxColumn1.DataPropertyName = "AllocationID";
            this.allocationIDDataGridViewTextBoxColumn1.HeaderText = "AllocationID";
            this.allocationIDDataGridViewTextBoxColumn1.Name = "allocationIDDataGridViewTextBoxColumn1";
            this.allocationIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.allocationIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // sPLotNoDataGridViewTextBoxColumn
            // 
            this.sPLotNoDataGridViewTextBoxColumn.DataPropertyName = "SPLotNo";
            this.sPLotNoDataGridViewTextBoxColumn.HeaderText = "SP Lot No";
            this.sPLotNoDataGridViewTextBoxColumn.Name = "sPLotNoDataGridViewTextBoxColumn";
            // 
            // docketNumDataGridViewTextBoxColumn
            // 
            this.docketNumDataGridViewTextBoxColumn.DataPropertyName = "DocketNum";
            this.docketNumDataGridViewTextBoxColumn.HeaderText = "Docket";
            this.docketNumDataGridViewTextBoxColumn.Name = "docketNumDataGridViewTextBoxColumn";
            // 
            // tonnesDataGridViewTextBoxColumn
            // 
            this.tonnesDataGridViewTextBoxColumn.DataPropertyName = "Tonnes";
            this.tonnesDataGridViewTextBoxColumn.HeaderText = "Tonnes";
            this.tonnesDataGridViewTextBoxColumn.Name = "tonnesDataGridViewTextBoxColumn";
            // 
            // reversalDataGridViewCheckBoxColumn
            // 
            this.reversalDataGridViewCheckBoxColumn.DataPropertyName = "Reversal";
            this.reversalDataGridViewCheckBoxColumn.HeaderText = "Reversal";
            this.reversalDataGridViewCheckBoxColumn.Name = "reversalDataGridViewCheckBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsStockpileManualAllocation
            // 
            this.bsStockpileManualAllocation.DataMember = "StockpileManualAllocation";
            this.bsStockpileManualAllocation.DataSource = this.dsTIQ2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // baseItemCodeDataGridViewTextBoxColumn
            // 
            this.baseItemCodeDataGridViewTextBoxColumn.DataPropertyName = "BaseItemCode";
            this.baseItemCodeDataGridViewTextBoxColumn.HeaderText = "BaseItemCode";
            this.baseItemCodeDataGridViewTextBoxColumn.Name = "baseItemCodeDataGridViewTextBoxColumn";
            this.baseItemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseItemCodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // bsSPLotItemsMap
            // 
            this.bsSPLotItemsMap.DataMember = "SPLotItemsMap";
            this.bsSPLotItemsMap.DataSource = this.dsTIQ2;
            // 
            // taStockpileLotAllocation
            // 
            this.taStockpileLotAllocation.ClearBeforeFill = true;
            // 
            // taStockpileBOM
            // 
            this.taStockpileBOM.ClearBeforeFill = true;
            // 
            // taSPLotNoAudit
            // 
            this.taSPLotNoAudit.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StockpileBOMTableAdapter = this.taStockpileBOM;
            this.tableAdapterManager.StockpileLotAllocationTableAdapter = this.taStockpileLotAllocation;
            this.tableAdapterManager.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager.TIQTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = null;
            // 
            // SPLotNoAuditBindingSource
            // 
            this.SPLotNoAuditBindingSource.DataMember = "SPLotNoAudit";
            this.SPLotNoAuditBindingSource.DataSource = this.dsTIQ2;
            // 
            // taStockpileManualAllocation
            // 
            this.taStockpileManualAllocation.ClearBeforeFill = true;
            // 
            // taSPLotItemsMap
            // 
            this.taSPLotItemsMap.ClearBeforeFill = true;
            // 
            // SPLotMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 806);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SPLotMaintenance";
            this.Text = "SPLotMaintenance";
            this.Load += new System.EventHandler(this.SPLotMaintenance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSPLots.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpDockets.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tpManual.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpBaseItem.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileBOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileLotAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotNoAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileManualAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotItemsMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPLotNoAuditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSPLots;
        private System.Windows.Forms.TabPage tpDockets;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsStockpileLotAllocation;
        private dsTIQ2TableAdapters.StockpileLotAllocationTableAdapter taStockpileLotAllocation;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingSource bsStockpileBOM;
        private dsTIQ2TableAdapters.StockpileBOMTableAdapter taStockpileBOM;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem2Report;
        private System.Windows.Forms.Button btnGetReportData;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bsSPLotNoAudit;
        private dsTIQ2TableAdapters.SPLotNoAuditTableAdapter taSPLotNoAudit;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSPLotNo;
        private System.Windows.Forms.BindingSource SPLotNoAuditBindingSource;
        private System.Windows.Forms.TabPage tpManual;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bsStockpileManualAllocation;
        private dsTIQ2TableAdapters.StockpileManualAllocationTableAdapter taStockpileManualAllocation;
        private System.Windows.Forms.Button btnSaveManualAllocation;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManualItemCode;
        private System.Windows.Forms.Button btnRefreshManualAllocation;
        private System.Windows.Forms.BindingSource bsSPLotItemsMap;
        private dsTIQ2TableAdapters.SPLotItemsMapTableAdapter taSPLotItemsMap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindBaseItemCode;
        private System.Windows.Forms.TextBox txtBaseItemCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TabPage tpBaseItem;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseItemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPLotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docketNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonnesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reversalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbClearFilter;
        private System.Windows.Forms.RadioButton rbLotNoFilter;
        private System.Windows.Forms.Button btnFindAll;
    }
}