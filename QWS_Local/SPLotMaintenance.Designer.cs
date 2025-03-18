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
            System.Windows.Forms.Label allocationIDLabel;
            System.Windows.Forms.Label itemCodeLabel;
            System.Windows.Forms.Label sPLotNoLabel;
            System.Windows.Forms.Label docketNumLabel;
            System.Windows.Forms.Label tonnesLabel;
            System.Windows.Forms.Label reversalLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label itemCodeLabel1;
            System.Windows.Forms.Label stockpileLotLabel;
            System.Windows.Forms.Label quantityLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsSPLotNoAudit = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSPLots = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindBaseItemCode = new System.Windows.Forms.Button();
            this.txtBaseItemCode = new System.Windows.Forms.TextBox();
            this.bsStockpileBOM = new System.Windows.Forms.BindingSource(this.components);
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allocationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocationDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStockpileLotAllocation = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOpen = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.tpDockets = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnFindAllDockets = new System.Windows.Forms.Button();
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
            this.btnRefreshManualAllocation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbClearFilter = new System.Windows.Forms.RadioButton();
            this.rbLotNoFilter = new System.Windows.Forms.RadioButton();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.tabManualDocktAllocation = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.allocationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPLotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docketNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonnesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reversalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStockpileManualAllocation = new System.Windows.Forms.BindingSource(this.components);
            this.tpDataEntry = new System.Windows.Forms.TabPage();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.bsSPLotCheckDocket = new System.Windows.Forms.BindingSource(this.components);
            this.stockpileLotTextBox = new System.Windows.Forms.TextBox();
            this.itemCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.txtDocNum2Check = new System.Windows.Forms.TextBox();
            this.btnAddAllocation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.allocationIDTextBox = new System.Windows.Forms.TextBox();
            this.btnSaveManualAllocation = new System.Windows.Forms.Button();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.sPLotNoTextBox = new System.Windows.Forms.TextBox();
            this.docketNumTextBox = new System.Windows.Forms.TextBox();
            this.tonnesTextBox = new System.Windows.Forms.TextBox();
            this.reversalCheckBox = new System.Windows.Forms.CheckBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.tpBaseItem = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveBaseItemMapping = new System.Windows.Forms.Button();
            this.btnBaseItemMapping = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.taSPLotCheckDocket = new QWS_Local.dsTIQ2TableAdapters.SPLotCheckDocketTableAdapter();
            this.itemQACheckBox = new System.Windows.Forms.CheckBox();
            allocationIDLabel = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            sPLotNoLabel = new System.Windows.Forms.Label();
            docketNumLabel = new System.Windows.Forms.Label();
            tonnesLabel = new System.Windows.Forms.Label();
            reversalLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            itemCodeLabel1 = new System.Windows.Forms.Label();
            stockpileLotLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotNoAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpSPLots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileLotAllocation)).BeginInit();
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
            this.tabManualDocktAllocation.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileManualAllocation)).BeginInit();
            this.tpDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotCheckDocket)).BeginInit();
            this.tpBaseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotItemsMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPLotNoAuditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allocationIDLabel
            // 
            allocationIDLabel.AutoSize = true;
            allocationIDLabel.Location = new System.Drawing.Point(538, 197);
            allocationIDLabel.Name = "allocationIDLabel";
            allocationIDLabel.Size = new System.Drawing.Size(94, 18);
            allocationIDLabel.TabIndex = 0;
            allocationIDLabel.Text = "Allocation ID:";
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(538, 227);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(80, 18);
            itemCodeLabel.TabIndex = 2;
            itemCodeLabel.Text = "Item Code:";
            // 
            // sPLotNoLabel
            // 
            sPLotNoLabel.AutoSize = true;
            sPLotNoLabel.Location = new System.Drawing.Point(538, 257);
            sPLotNoLabel.Name = "sPLotNoLabel";
            sPLotNoLabel.Size = new System.Drawing.Size(77, 18);
            sPLotNoLabel.TabIndex = 4;
            sPLotNoLabel.Text = "SPLot No:";
            // 
            // docketNumLabel
            // 
            docketNumLabel.AutoSize = true;
            docketNumLabel.Location = new System.Drawing.Point(538, 287);
            docketNumLabel.Name = "docketNumLabel";
            docketNumLabel.Size = new System.Drawing.Size(96, 18);
            docketNumLabel.TabIndex = 6;
            docketNumLabel.Text = "Docket Num:";
            // 
            // tonnesLabel
            // 
            tonnesLabel.AutoSize = true;
            tonnesLabel.Location = new System.Drawing.Point(538, 317);
            tonnesLabel.Name = "tonnesLabel";
            tonnesLabel.Size = new System.Drawing.Size(62, 18);
            tonnesLabel.TabIndex = 8;
            tonnesLabel.Text = "Tonnes:";
            // 
            // reversalLabel
            // 
            reversalLabel.AutoSize = true;
            reversalLabel.Location = new System.Drawing.Point(538, 349);
            reversalLabel.Name = "reversalLabel";
            reversalLabel.Size = new System.Drawing.Size(70, 18);
            reversalLabel.TabIndex = 10;
            reversalLabel.Text = "Reversal:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(538, 377);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(78, 18);
            commentLabel.TabIndex = 12;
            commentLabel.Text = "Comment:";
            // 
            // bsSPLotNoAudit
            // 
            this.bsSPLotNoAudit.DataMember = "SPLotNoAudit";
            this.bsSPLotNoAudit.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemCodeLabel1
            // 
            itemCodeLabel1.AutoSize = true;
            itemCodeLabel1.Location = new System.Drawing.Point(75, 89);
            itemCodeLabel1.Name = "itemCodeLabel1";
            itemCodeLabel1.Size = new System.Drawing.Size(80, 18);
            itemCodeLabel1.TabIndex = 18;
            itemCodeLabel1.Text = "Item Code:";
            // 
            // stockpileLotLabel
            // 
            stockpileLotLabel.AutoSize = true;
            stockpileLotLabel.Location = new System.Drawing.Point(57, 149);
            stockpileLotLabel.Name = "stockpileLotLabel";
            stockpileLotLabel.Size = new System.Drawing.Size(98, 18);
            stockpileLotLabel.TabIndex = 20;
            stockpileLotLabel.Text = "Stockpile Lot:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(89, 179);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(66, 18);
            quantityLabel.TabIndex = 22;
            quantityLabel.Text = "Quantity:";
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
            // bsStockpileBOM
            // 
            this.bsStockpileBOM.DataMember = "StockpileBOM";
            this.bsStockpileBOM.DataSource = this.dsTIQ2;
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
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
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
            this.mCODataGridViewTextBoxColumn.ReadOnly = true;
            this.mCODataGridViewTextBoxColumn.Width = 150;
            // 
            // BaseItemCode
            // 
            this.BaseItemCode.DataPropertyName = "BaseItemCode";
            this.BaseItemCode.HeaderText = "Base Item";
            this.BaseItemCode.Name = "BaseItemCode";
            this.BaseItemCode.ReadOnly = true;
            this.BaseItemCode.Width = 150;
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
            this.allocationDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            this.allocationDTTMDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsStockpileLotAllocation
            // 
            this.bsStockpileLotAllocation.DataMember = "StockpileLotAllocation";
            this.bsStockpileLotAllocation.DataSource = this.dsTIQ2;
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
            this.splitContainer3.Panel1.Controls.Add(this.btnFindAllDockets);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.txtSPLotNo);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.txtItem2Report);
            this.splitContainer3.Panel1.Controls.Add(this.btnGetReportData);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer3.Size = new System.Drawing.Size(1124, 767);
            this.splitContainer3.SplitterDistance = 194;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnFindAllDockets
            // 
            this.btnFindAllDockets.Location = new System.Drawing.Point(23, 289);
            this.btnFindAllDockets.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAllDockets.Name = "btnFindAllDockets";
            this.btnFindAllDockets.Size = new System.Drawing.Size(150, 40);
            this.btnFindAllDockets.TabIndex = 9;
            this.btnFindAllDockets.Text = "Find All";
            this.btnFindAllDockets.UseVisualStyleBackColor = true;
            this.btnFindAllDockets.Click += new System.EventHandler(this.btnFindAllDockets_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lot No";
            // 
            // txtSPLotNo
            // 
            this.txtSPLotNo.Location = new System.Drawing.Point(25, 150);
            this.txtSPLotNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSPLotNo.Name = "txtSPLotNo";
            this.txtSPLotNo.Size = new System.Drawing.Size(148, 24);
            this.txtSPLotNo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "ItemCode";
            // 
            // txtItem2Report
            // 
            this.txtItem2Report.Location = new System.Drawing.Point(25, 67);
            this.txtItem2Report.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem2Report.Name = "txtItem2Report";
            this.txtItem2Report.Size = new System.Drawing.Size(148, 24);
            this.txtItem2Report.TabIndex = 5;
            // 
            // btnGetReportData
            // 
            this.btnGetReportData.Location = new System.Drawing.Point(25, 215);
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
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.bsSPLotNoAudit;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QWS_Local.SPLotNoAudit.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(924, 767);
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
            this.splitContainer4.Panel2.Controls.Add(this.tabManualDocktAllocation);
            this.splitContainer4.Size = new System.Drawing.Size(1132, 775);
            this.splitContainer4.SplitterDistance = 186;
            this.splitContainer4.SplitterWidth = 6;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtManualItemCode);
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
            // tabManualDocktAllocation
            // 
            this.tabManualDocktAllocation.Controls.Add(this.tpList);
            this.tabManualDocktAllocation.Controls.Add(this.tpDataEntry);
            this.tabManualDocktAllocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManualDocktAllocation.Location = new System.Drawing.Point(0, 0);
            this.tabManualDocktAllocation.Name = "tabManualDocktAllocation";
            this.tabManualDocktAllocation.SelectedIndex = 0;
            this.tabManualDocktAllocation.Size = new System.Drawing.Size(940, 775);
            this.tabManualDocktAllocation.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView3);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(932, 744);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
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
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(926, 738);
            this.dataGridView3.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sPLotNoDataGridViewTextBoxColumn
            // 
            this.sPLotNoDataGridViewTextBoxColumn.DataPropertyName = "SPLotNo";
            this.sPLotNoDataGridViewTextBoxColumn.HeaderText = "SP Lot No";
            this.sPLotNoDataGridViewTextBoxColumn.Name = "sPLotNoDataGridViewTextBoxColumn";
            this.sPLotNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docketNumDataGridViewTextBoxColumn
            // 
            this.docketNumDataGridViewTextBoxColumn.DataPropertyName = "DocketNum";
            this.docketNumDataGridViewTextBoxColumn.HeaderText = "Docket";
            this.docketNumDataGridViewTextBoxColumn.Name = "docketNumDataGridViewTextBoxColumn";
            this.docketNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonnesDataGridViewTextBoxColumn
            // 
            this.tonnesDataGridViewTextBoxColumn.DataPropertyName = "Tonnes";
            this.tonnesDataGridViewTextBoxColumn.HeaderText = "Tonnes";
            this.tonnesDataGridViewTextBoxColumn.Name = "tonnesDataGridViewTextBoxColumn";
            this.tonnesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reversalDataGridViewCheckBoxColumn
            // 
            this.reversalDataGridViewCheckBoxColumn.DataPropertyName = "Reversal";
            this.reversalDataGridViewCheckBoxColumn.HeaderText = "Reversal";
            this.reversalDataGridViewCheckBoxColumn.Name = "reversalDataGridViewCheckBoxColumn";
            this.reversalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsStockpileManualAllocation
            // 
            this.bsStockpileManualAllocation.DataMember = "StockpileManualAllocation";
            this.bsStockpileManualAllocation.DataSource = this.dsTIQ2;
            // 
            // tpDataEntry
            // 
            this.tpDataEntry.Controls.Add(this.itemQACheckBox);
            this.tpDataEntry.Controls.Add(quantityLabel);
            this.tpDataEntry.Controls.Add(this.quantityTextBox);
            this.tpDataEntry.Controls.Add(stockpileLotLabel);
            this.tpDataEntry.Controls.Add(this.stockpileLotTextBox);
            this.tpDataEntry.Controls.Add(itemCodeLabel1);
            this.tpDataEntry.Controls.Add(this.itemCodeTextBox1);
            this.tpDataEntry.Controls.Add(this.txtDocNum2Check);
            this.tpDataEntry.Controls.Add(this.btnAddAllocation);
            this.tpDataEntry.Controls.Add(this.button1);
            this.tpDataEntry.Controls.Add(allocationIDLabel);
            this.tpDataEntry.Controls.Add(this.allocationIDTextBox);
            this.tpDataEntry.Controls.Add(this.btnSaveManualAllocation);
            this.tpDataEntry.Controls.Add(itemCodeLabel);
            this.tpDataEntry.Controls.Add(this.itemCodeTextBox);
            this.tpDataEntry.Controls.Add(sPLotNoLabel);
            this.tpDataEntry.Controls.Add(this.sPLotNoTextBox);
            this.tpDataEntry.Controls.Add(docketNumLabel);
            this.tpDataEntry.Controls.Add(this.docketNumTextBox);
            this.tpDataEntry.Controls.Add(tonnesLabel);
            this.tpDataEntry.Controls.Add(this.tonnesTextBox);
            this.tpDataEntry.Controls.Add(reversalLabel);
            this.tpDataEntry.Controls.Add(this.reversalCheckBox);
            this.tpDataEntry.Controls.Add(commentLabel);
            this.tpDataEntry.Controls.Add(this.commentTextBox);
            this.tpDataEntry.Location = new System.Drawing.Point(4, 27);
            this.tpDataEntry.Name = "tpDataEntry";
            this.tpDataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataEntry.Size = new System.Drawing.Size(932, 744);
            this.tpDataEntry.TabIndex = 1;
            this.tpDataEntry.Text = "Data Entry";
            this.tpDataEntry.UseVisualStyleBackColor = true;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSPLotCheckDocket, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(161, 176);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 24);
            this.quantityTextBox.TabIndex = 23;
            // 
            // bsSPLotCheckDocket
            // 
            this.bsSPLotCheckDocket.DataMember = "SPLotCheckDocket";
            this.bsSPLotCheckDocket.DataSource = this.dsTIQ2;
            // 
            // stockpileLotTextBox
            // 
            this.stockpileLotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSPLotCheckDocket, "StockpileLot", true));
            this.stockpileLotTextBox.Location = new System.Drawing.Point(161, 146);
            this.stockpileLotTextBox.Name = "stockpileLotTextBox";
            this.stockpileLotTextBox.Size = new System.Drawing.Size(100, 24);
            this.stockpileLotTextBox.TabIndex = 21;
            // 
            // itemCodeTextBox1
            // 
            this.itemCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSPLotCheckDocket, "ItemCode", true));
            this.itemCodeTextBox1.Location = new System.Drawing.Point(161, 86);
            this.itemCodeTextBox1.Name = "itemCodeTextBox1";
            this.itemCodeTextBox1.Size = new System.Drawing.Size(100, 24);
            this.itemCodeTextBox1.TabIndex = 19;
            // 
            // txtDocNum2Check
            // 
            this.txtDocNum2Check.Location = new System.Drawing.Point(161, 56);
            this.txtDocNum2Check.Name = "txtDocNum2Check";
            this.txtDocNum2Check.Size = new System.Drawing.Size(100, 24);
            this.txtDocNum2Check.TabIndex = 17;
            // 
            // btnAddAllocation
            // 
            this.btnAddAllocation.Location = new System.Drawing.Point(110, 448);
            this.btnAddAllocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAllocation.Name = "btnAddAllocation";
            this.btnAddAllocation.Size = new System.Drawing.Size(118, 58);
            this.btnAddAllocation.TabIndex = 16;
            this.btnAddAllocation.Text = "Allocate";
            this.btnAddAllocation.UseVisualStyleBackColor = true;
            this.btnAddAllocation.Click += new System.EventHandler(this.btnAddAllocation_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Check Docket Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allocationIDTextBox
            // 
            this.allocationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStockpileManualAllocation, "AllocationID", true));
            this.allocationIDTextBox.Location = new System.Drawing.Point(640, 194);
            this.allocationIDTextBox.Name = "allocationIDTextBox";
            this.allocationIDTextBox.Size = new System.Drawing.Size(104, 24);
            this.allocationIDTextBox.TabIndex = 1;
            // 
            // btnSaveManualAllocation
            // 
            this.btnSaveManualAllocation.Location = new System.Drawing.Point(296, 448);
            this.btnSaveManualAllocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveManualAllocation.Name = "btnSaveManualAllocation";
            this.btnSaveManualAllocation.Size = new System.Drawing.Size(118, 58);
            this.btnSaveManualAllocation.TabIndex = 14;
            this.btnSaveManualAllocation.Text = "Save";
            this.btnSaveManualAllocation.UseVisualStyleBackColor = true;
            this.btnSaveManualAllocation.Click += new System.EventHandler(this.btnSaveManualAllocation_Click);
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStockpileManualAllocation, "ItemCode", true));
            this.itemCodeTextBox.Location = new System.Drawing.Point(640, 224);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(104, 24);
            this.itemCodeTextBox.TabIndex = 3;
            // 
            // sPLotNoTextBox
            // 
            this.sPLotNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStockpileManualAllocation, "SPLotNo", true));
            this.sPLotNoTextBox.Location = new System.Drawing.Point(640, 254);
            this.sPLotNoTextBox.Name = "sPLotNoTextBox";
            this.sPLotNoTextBox.Size = new System.Drawing.Size(104, 24);
            this.sPLotNoTextBox.TabIndex = 5;
            // 
            // docketNumTextBox
            // 
            this.docketNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStockpileManualAllocation, "DocketNum", true));
            this.docketNumTextBox.Location = new System.Drawing.Point(640, 284);
            this.docketNumTextBox.Name = "docketNumTextBox";
            this.docketNumTextBox.Size = new System.Drawing.Size(104, 24);
            this.docketNumTextBox.TabIndex = 7;
            // 
            // tonnesTextBox
            // 
            this.tonnesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStockpileManualAllocation, "Tonnes", true));
            this.tonnesTextBox.Location = new System.Drawing.Point(640, 314);
            this.tonnesTextBox.Name = "tonnesTextBox";
            this.tonnesTextBox.Size = new System.Drawing.Size(104, 24);
            this.tonnesTextBox.TabIndex = 9;
            // 
            // reversalCheckBox
            // 
            this.reversalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsStockpileManualAllocation, "Reversal", true));
            this.reversalCheckBox.Location = new System.Drawing.Point(640, 344);
            this.reversalCheckBox.Name = "reversalCheckBox";
            this.reversalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.reversalCheckBox.TabIndex = 11;
            this.reversalCheckBox.Text = "checkBox1";
            this.reversalCheckBox.UseVisualStyleBackColor = true;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStockpileManualAllocation, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(640, 374);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(104, 24);
            this.commentTextBox.TabIndex = 13;
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
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnClear);
            this.splitContainer5.Panel1.Controls.Add(this.btnSaveBaseItemMapping);
            this.splitContainer5.Panel1.Controls.Add(this.btnBaseItemMapping);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer5.Size = new System.Drawing.Size(1132, 775);
            this.splitContainer5.SplitterDistance = 377;
            this.splitContainer5.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(97, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveBaseItemMapping
            // 
            this.btnSaveBaseItemMapping.Location = new System.Drawing.Point(97, 202);
            this.btnSaveBaseItemMapping.Name = "btnSaveBaseItemMapping";
            this.btnSaveBaseItemMapping.Size = new System.Drawing.Size(126, 40);
            this.btnSaveBaseItemMapping.TabIndex = 1;
            this.btnSaveBaseItemMapping.Text = "Save";
            this.btnSaveBaseItemMapping.UseVisualStyleBackColor = true;
            this.btnSaveBaseItemMapping.Visible = false;
            this.btnSaveBaseItemMapping.Click += new System.EventHandler(this.btnSaveBaseItemMapping_Click);
            // 
            // btnBaseItemMapping
            // 
            this.btnBaseItemMapping.Location = new System.Drawing.Point(97, 110);
            this.btnBaseItemMapping.Name = "btnBaseItemMapping";
            this.btnBaseItemMapping.Size = new System.Drawing.Size(126, 40);
            this.btnBaseItemMapping.TabIndex = 0;
            this.btnBaseItemMapping.Text = "Load";
            this.btnBaseItemMapping.UseVisualStyleBackColor = true;
            this.btnBaseItemMapping.Click += new System.EventHandler(this.btnBaseItemMapping_Click);
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
            // taSPLotCheckDocket
            // 
            this.taSPLotCheckDocket.ClearBeforeFill = true;
            // 
            // itemQACheckBox
            // 
            this.itemQACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsSPLotCheckDocket, "ItemQA", true));
            this.itemQACheckBox.Location = new System.Drawing.Point(161, 116);
            this.itemQACheckBox.Name = "itemQACheckBox";
            this.itemQACheckBox.Size = new System.Drawing.Size(104, 24);
            this.itemQACheckBox.TabIndex = 25;
            this.itemQACheckBox.Text = "Item QA";
            this.itemQACheckBox.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotNoAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpSPLots.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileBOM)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileLotAllocation)).EndInit();
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
            this.tabManualDocktAllocation.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileManualAllocation)).EndInit();
            this.tpDataEntry.ResumeLayout(false);
            this.tpDataEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotCheckDocket)).EndInit();
            this.tpBaseItem.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button btnSaveBaseItemMapping;
        private System.Windows.Forms.Button btnBaseItemMapping;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindAllDockets;
        private System.Windows.Forms.TabControl tabManualDocktAllocation;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDataEntry;
        private System.Windows.Forms.TextBox allocationIDTextBox;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.TextBox sPLotNoTextBox;
        private System.Windows.Forms.TextBox docketNumTextBox;
        private System.Windows.Forms.TextBox tonnesTextBox;
        private System.Windows.Forms.CheckBox reversalCheckBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button btnAddAllocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDocNum2Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSPLotCheckDocket;
        private dsTIQ2TableAdapters.SPLotCheckDocketTableAdapter taSPLotCheckDocket;
        private System.Windows.Forms.TextBox itemCodeTextBox1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox stockpileLotTextBox;
        private System.Windows.Forms.CheckBox itemQACheckBox;
    }
}