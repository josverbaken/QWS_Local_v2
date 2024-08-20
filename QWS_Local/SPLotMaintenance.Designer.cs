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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFindItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BaseItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.allocationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocationDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStockpileLotAllocation = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.taStockpileLotAllocation = new QWS_Local.dsTIQ2TableAdapters.StockpileLotAllocationTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bsStockpileBOM = new System.Windows.Forms.BindingSource(this.components);
            this.taStockpileBOM = new QWS_Local.dsTIQ2TableAdapters.StockpileBOMTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseItemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileLotAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileBOM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindItem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(879, 484);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(39, 160);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnFindItem
            // 
            this.btnFindItem.Location = new System.Drawing.Point(39, 111);
            this.btnFindItem.Name = "btnFindItem";
            this.btnFindItem.Size = new System.Drawing.Size(100, 29);
            this.btnFindItem.TabIndex = 0;
            this.btnFindItem.Text = "Find";
            this.btnFindItem.UseVisualStyleBackColor = true;
            this.btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // BaseItemCode
            // 
            this.BaseItemCode.DataPropertyName = "BaseItemCode";
            this.BaseItemCode.HeaderText = "BaseItemCode";
            this.BaseItemCode.Name = "BaseItemCode";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(39, 62);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 20);
            this.txtItemCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ItemCode";
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
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(700, 484);
            this.splitContainer2.SplitterDistance = 242;
            this.splitContainer2.TabIndex = 1;
            // 
            // allocationIDDataGridViewTextBoxColumn
            // 
            this.allocationIDDataGridViewTextBoxColumn.DataPropertyName = "AllocationID";
            this.allocationIDDataGridViewTextBoxColumn.HeaderText = "AllocationID";
            this.allocationIDDataGridViewTextBoxColumn.Name = "allocationIDDataGridViewTextBoxColumn";
            this.allocationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mCODataGridViewTextBoxColumn
            // 
            this.mCODataGridViewTextBoxColumn.DataPropertyName = "MCO";
            this.mCODataGridViewTextBoxColumn.HeaderText = "MCO";
            this.mCODataGridViewTextBoxColumn.Name = "mCODataGridViewTextBoxColumn";
            // 
            // lotNoDataGridViewTextBoxColumn
            // 
            this.lotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo";
            this.lotNoDataGridViewTextBoxColumn.HeaderText = "LotNo";
            this.lotNoDataGridViewTextBoxColumn.Name = "lotNoDataGridViewTextBoxColumn";
            // 
            // lotStatusDataGridViewTextBoxColumn
            // 
            this.lotStatusDataGridViewTextBoxColumn.DataPropertyName = "LotStatus";
            this.lotStatusDataGridViewTextBoxColumn.HeaderText = "LotStatus";
            this.lotStatusDataGridViewTextBoxColumn.Name = "lotStatusDataGridViewTextBoxColumn";
            // 
            // allocationDTTMDataGridViewTextBoxColumn
            // 
            this.allocationDTTMDataGridViewTextBoxColumn.DataPropertyName = "AllocationDTTM";
            this.allocationDTTMDataGridViewTextBoxColumn.HeaderText = "AllocationDTTM";
            this.allocationDTTMDataGridViewTextBoxColumn.Name = "allocationDTTMDataGridViewTextBoxColumn";
            // 
            // bsStockpileLotAllocation
            // 
            this.bsStockpileLotAllocation.DataMember = "StockpileLotAllocation";
            this.bsStockpileLotAllocation.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taStockpileLotAllocation
            // 
            this.taStockpileLotAllocation.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.baseItemCodeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsStockpileBOM;
            this.dataGridView2.Location = new System.Drawing.Point(27, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(259, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // bsStockpileBOM
            // 
            this.bsStockpileBOM.DataMember = "StockpileBOM";
            this.bsStockpileBOM.DataSource = this.dsTIQ2;
            // 
            // taStockpileBOM
            // 
            this.taStockpileBOM.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // baseItemCodeDataGridViewTextBoxColumn
            // 
            this.baseItemCodeDataGridViewTextBoxColumn.DataPropertyName = "BaseItemCode";
            this.baseItemCodeDataGridViewTextBoxColumn.HeaderText = "BaseItemCode";
            this.baseItemCodeDataGridViewTextBoxColumn.Name = "baseItemCodeDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SPLotMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "SPLotMaintenance";
            this.Text = "SPLotMaintenance";
            this.Load += new System.EventHandler(this.SPLotMaintenance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileLotAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockpileBOM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFindItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsStockpileLotAllocation;
        private dsTIQ2TableAdapters.StockpileLotAllocationTableAdapter taStockpileLotAllocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bsStockpileBOM;
        private dsTIQ2TableAdapters.StockpileBOMTableAdapter taStockpileBOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseItemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}