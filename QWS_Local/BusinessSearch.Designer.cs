
namespace QWS_Local
{
    partial class BusinessSearch
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
            System.Windows.Forms.Label sAPCodeLabel;
            System.Windows.Forms.Label tradingNameLabel;
            System.Windows.Forms.Label alternateNameLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label aCTypeLabel;
            System.Windows.Forms.Label aBNLabel;
            System.Windows.Forms.Label accountStatusLabel;
            System.Windows.Forms.Label pORequiredLabel;
            System.Windows.Forms.Label documentOwnerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessSearch));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sAPCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.documentOwnerTextBox = new System.Windows.Forms.TextBox();
            this.pORequiredTextBox = new System.Windows.Forms.TextBox();
            this.accountStatusTextBox = new System.Windows.Forms.TextBox();
            this.aBNTextBox = new System.Windows.Forms.TextBox();
            this.aCTypeTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.alternateNameTextBox = new System.Windows.Forms.TextBox();
            this.tradingNameTextBox = new System.Windows.Forms.TextBox();
            this.sAPCodeTextBox = new System.Windows.Forms.TextBox();
            this.businessTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.BusinessTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSAPCode = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearchByCode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectBusiness = new System.Windows.Forms.ToolStripButton();
            this.btnBusinessNOTfound = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            sAPCodeLabel = new System.Windows.Forms.Label();
            tradingNameLabel = new System.Windows.Forms.Label();
            alternateNameLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            aCTypeLabel = new System.Windows.Forms.Label();
            aBNLabel = new System.Windows.Forms.Label();
            accountStatusLabel = new System.Windows.Forms.Label();
            pORequiredLabel = new System.Windows.Forms.Label();
            documentOwnerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sAPCodeLabel
            // 
            sAPCodeLabel.AutoSize = true;
            sAPCodeLabel.Location = new System.Drawing.Point(75, 28);
            sAPCodeLabel.Name = "sAPCodeLabel";
            sAPCodeLabel.Size = new System.Drawing.Size(77, 18);
            sAPCodeLabel.TabIndex = 0;
            sAPCodeLabel.Text = "SAPCode:";
            // 
            // tradingNameLabel
            // 
            tradingNameLabel.AutoSize = true;
            tradingNameLabel.Location = new System.Drawing.Point(47, 58);
            tradingNameLabel.Name = "tradingNameLabel";
            tradingNameLabel.Size = new System.Drawing.Size(105, 18);
            tradingNameLabel.TabIndex = 2;
            tradingNameLabel.Text = "Trading Name:";
            // 
            // alternateNameLabel
            // 
            alternateNameLabel.AutoSize = true;
            alternateNameLabel.Location = new System.Drawing.Point(39, 88);
            alternateNameLabel.Name = "alternateNameLabel";
            alternateNameLabel.Size = new System.Drawing.Size(113, 18);
            alternateNameLabel.TabIndex = 4;
            alternateNameLabel.Text = "Alternate Name:";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(98, 118);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(54, 18);
            groupLabel.TabIndex = 6;
            groupLabel.Text = "Group:";
            // 
            // aCTypeLabel
            // 
            aCTypeLabel.AutoSize = true;
            aCTypeLabel.Location = new System.Drawing.Point(88, 148);
            aCTypeLabel.Name = "aCTypeLabel";
            aCTypeLabel.Size = new System.Drawing.Size(64, 18);
            aCTypeLabel.TabIndex = 8;
            aCTypeLabel.Text = "ACType:";
            // 
            // aBNLabel
            // 
            aBNLabel.AutoSize = true;
            aBNLabel.Location = new System.Drawing.Point(250, 28);
            aBNLabel.Name = "aBNLabel";
            aBNLabel.Size = new System.Drawing.Size(42, 18);
            aBNLabel.TabIndex = 10;
            aBNLabel.Text = "ABN:";
            // 
            // accountStatusLabel
            // 
            accountStatusLabel.AutoSize = true;
            accountStatusLabel.Location = new System.Drawing.Point(40, 178);
            accountStatusLabel.Name = "accountStatusLabel";
            accountStatusLabel.Size = new System.Drawing.Size(112, 18);
            accountStatusLabel.TabIndex = 12;
            accountStatusLabel.Text = "Account Status:";
            // 
            // pORequiredLabel
            // 
            pORequiredLabel.AutoSize = true;
            pORequiredLabel.Location = new System.Drawing.Point(295, 178);
            pORequiredLabel.Name = "pORequiredLabel";
            pORequiredLabel.Size = new System.Drawing.Size(93, 18);
            pORequiredLabel.TabIndex = 14;
            pORequiredLabel.Text = "PORequired:";
            // 
            // documentOwnerLabel
            // 
            documentOwnerLabel.AutoSize = true;
            documentOwnerLabel.Location = new System.Drawing.Point(23, 208);
            documentOwnerLabel.Name = "documentOwnerLabel";
            documentOwnerLabel.Size = new System.Drawing.Size(129, 18);
            documentOwnerLabel.TabIndex = 16;
            documentOwnerLabel.Text = "Document Owner:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(documentOwnerLabel);
            this.splitContainer1.Panel2.Controls.Add(this.documentOwnerTextBox);
            this.splitContainer1.Panel2.Controls.Add(pORequiredLabel);
            this.splitContainer1.Panel2.Controls.Add(this.pORequiredTextBox);
            this.splitContainer1.Panel2.Controls.Add(accountStatusLabel);
            this.splitContainer1.Panel2.Controls.Add(this.accountStatusTextBox);
            this.splitContainer1.Panel2.Controls.Add(aBNLabel);
            this.splitContainer1.Panel2.Controls.Add(this.aBNTextBox);
            this.splitContainer1.Panel2.Controls.Add(aCTypeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.aCTypeTextBox);
            this.splitContainer1.Panel2.Controls.Add(groupLabel);
            this.splitContainer1.Panel2.Controls.Add(this.groupTextBox);
            this.splitContainer1.Panel2.Controls.Add(alternateNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.alternateNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(tradingNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tradingNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(sAPCodeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.sAPCodeTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 340);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sAPCodeDataGridViewTextBoxColumn,
            this.tradingNameDataGridViewTextBoxColumn,
            this.alternateNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.businessBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(500, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // sAPCodeDataGridViewTextBoxColumn
            // 
            this.sAPCodeDataGridViewTextBoxColumn.DataPropertyName = "SAPCode";
            this.sAPCodeDataGridViewTextBoxColumn.HeaderText = "SAPCode";
            this.sAPCodeDataGridViewTextBoxColumn.Name = "sAPCodeDataGridViewTextBoxColumn";
            this.sAPCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tradingNameDataGridViewTextBoxColumn
            // 
            this.tradingNameDataGridViewTextBoxColumn.DataPropertyName = "TradingName";
            this.tradingNameDataGridViewTextBoxColumn.HeaderText = "TradingName";
            this.tradingNameDataGridViewTextBoxColumn.Name = "tradingNameDataGridViewTextBoxColumn";
            this.tradingNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tradingNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // alternateNameDataGridViewTextBoxColumn
            // 
            this.alternateNameDataGridViewTextBoxColumn.DataPropertyName = "AlternateName";
            this.alternateNameDataGridViewTextBoxColumn.HeaderText = "AlternateName";
            this.alternateNameDataGridViewTextBoxColumn.Name = "alternateNameDataGridViewTextBoxColumn";
            this.alternateNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.alternateNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // businessBindingSource
            // 
            this.businessBindingSource.DataMember = "Business";
            this.businessBindingSource.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentOwnerTextBox
            // 
            this.documentOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "DocumentOwner", true));
            this.documentOwnerTextBox.Location = new System.Drawing.Point(158, 205);
            this.documentOwnerTextBox.Name = "documentOwnerTextBox";
            this.documentOwnerTextBox.Size = new System.Drawing.Size(269, 24);
            this.documentOwnerTextBox.TabIndex = 17;
            // 
            // pORequiredTextBox
            // 
            this.pORequiredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "PORequired", true));
            this.pORequiredTextBox.Location = new System.Drawing.Point(394, 175);
            this.pORequiredTextBox.Name = "pORequiredTextBox";
            this.pORequiredTextBox.Size = new System.Drawing.Size(33, 24);
            this.pORequiredTextBox.TabIndex = 15;
            // 
            // accountStatusTextBox
            // 
            this.accountStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "AccountStatus", true));
            this.accountStatusTextBox.Location = new System.Drawing.Point(158, 175);
            this.accountStatusTextBox.Name = "accountStatusTextBox";
            this.accountStatusTextBox.Size = new System.Drawing.Size(29, 24);
            this.accountStatusTextBox.TabIndex = 13;
            // 
            // aBNTextBox
            // 
            this.aBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "ABN", true));
            this.aBNTextBox.Location = new System.Drawing.Point(298, 25);
            this.aBNTextBox.Name = "aBNTextBox";
            this.aBNTextBox.Size = new System.Drawing.Size(129, 24);
            this.aBNTextBox.TabIndex = 11;
            // 
            // aCTypeTextBox
            // 
            this.aCTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "ACType", true));
            this.aCTypeTextBox.Location = new System.Drawing.Point(158, 145);
            this.aCTypeTextBox.Name = "aCTypeTextBox";
            this.aCTypeTextBox.Size = new System.Drawing.Size(269, 24);
            this.aCTypeTextBox.TabIndex = 9;
            // 
            // groupTextBox
            // 
            this.groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "Group", true));
            this.groupTextBox.Location = new System.Drawing.Point(158, 115);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(269, 24);
            this.groupTextBox.TabIndex = 7;
            // 
            // alternateNameTextBox
            // 
            this.alternateNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "AlternateName", true));
            this.alternateNameTextBox.Location = new System.Drawing.Point(158, 85);
            this.alternateNameTextBox.Name = "alternateNameTextBox";
            this.alternateNameTextBox.Size = new System.Drawing.Size(269, 24);
            this.alternateNameTextBox.TabIndex = 5;
            // 
            // tradingNameTextBox
            // 
            this.tradingNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "TradingName", true));
            this.tradingNameTextBox.Location = new System.Drawing.Point(158, 55);
            this.tradingNameTextBox.Name = "tradingNameTextBox";
            this.tradingNameTextBox.Size = new System.Drawing.Size(269, 24);
            this.tradingNameTextBox.TabIndex = 3;
            // 
            // sAPCodeTextBox
            // 
            this.sAPCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "SAPCode", true));
            this.sAPCodeTextBox.Location = new System.Drawing.Point(158, 25);
            this.sAPCodeTextBox.Name = "sAPCodeTextBox";
            this.sAPCodeTextBox.Size = new System.Drawing.Size(84, 24);
            this.sAPCodeTextBox.TabIndex = 1;
            // 
            // businessTableAdapter
            // 
            this.businessTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.NHVLTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.SchemeCodesTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TruckConfigVehicleTableAdapter = null;
            this.tableAdapterManager.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclePBSTableAdapter = null;
            this.tableAdapterManager.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.VehicleTypeTableAdapter = null;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // txtSAPCode
            // 
            this.txtSAPCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSAPCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSAPCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSAPCode.Name = "txtSAPCode";
            this.txtSAPCode.Size = new System.Drawing.Size(200, 27);
            this.txtSAPCode.Text = "Name or SAP Code";
            this.txtSAPCode.Enter += new System.EventHandler(this.txtSAPCode_Enter);
            this.txtSAPCode.Click += new System.EventHandler(this.txtSAPCode_Click);
            // 
            // btnSearchByCode
            // 
            this.btnSearchByCode.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchByCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearchByCode.Image = global::QWS_Local.Properties.Resources.A2;
            this.btnSearchByCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchByCode.Name = "btnSearchByCode";
            this.btnSearchByCode.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchByCode.Size = new System.Drawing.Size(61, 24);
            this.btnSearchByCode.Text = "Find";
            this.btnSearchByCode.Click += new System.EventHandler(this.btnSearchByCode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSelectBusiness
            // 
            this.btnSelectBusiness.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectBusiness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectBusiness.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectBusiness.Image")));
            this.btnSelectBusiness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectBusiness.Name = "btnSelectBusiness";
            this.btnSelectBusiness.Size = new System.Drawing.Size(181, 24);
            this.btnSelectBusiness.Text = "Select Business and Close";
            this.btnSelectBusiness.Click += new System.EventHandler(this.btnSelectBusiness_Click);
            // 
            // btnBusinessNOTfound
            // 
            this.btnBusinessNOTfound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBusinessNOTfound.Image = ((System.Drawing.Image)(resources.GetObject("btnBusinessNOTfound.Image")));
            this.btnBusinessNOTfound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBusinessNOTfound.Name = "btnBusinessNOTfound";
            this.btnBusinessNOTfound.Size = new System.Drawing.Size(146, 24);
            this.btnBusinessNOTfound.Text = "Business NOT Found";
            this.btnBusinessNOTfound.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 24);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSAPCode,
            this.btnSearchByCode,
            this.toolStripSeparator2,
            this.btnSelectBusiness,
            this.toolStripSeparator3,
            this.btnBusinessNOTfound,
            this.toolStripSeparator1,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 2, 10);
            this.toolStrip1.Size = new System.Drawing.Size(1000, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // BusinessSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 382);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusinessSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Business Search";
            this.Load += new System.EventHandler(this.BusinessSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource businessBindingSource;
        private dsQWSLocalTableAdapters.BusinessTableAdapter businessTableAdapter;
        private System.Windows.Forms.TextBox documentOwnerTextBox;
        private System.Windows.Forms.TextBox pORequiredTextBox;
        private System.Windows.Forms.TextBox accountStatusTextBox;
        private System.Windows.Forms.TextBox aBNTextBox;
        private System.Windows.Forms.TextBox aCTypeTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox alternateNameTextBox;
        private System.Windows.Forms.TextBox tradingNameTextBox;
        private System.Windows.Forms.TextBox sAPCodeTextBox;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAPCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtSAPCode;
        private System.Windows.Forms.ToolStripButton btnSearchByCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSelectBusiness;
        private System.Windows.Forms.ToolStripButton btnBusinessNOTfound;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}