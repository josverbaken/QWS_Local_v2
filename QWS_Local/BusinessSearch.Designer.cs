
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelNotFound = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.sAPCodeTextBox = new System.Windows.Forms.TextBox();
            this.documentOwnerTextBox = new System.Windows.Forms.TextBox();
            this.tradingNameTextBox = new System.Windows.Forms.TextBox();
            this.pORequiredTextBox = new System.Windows.Forms.TextBox();
            this.alternateNameTextBox = new System.Windows.Forms.TextBox();
            this.accountStatusTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.aBNTextBox = new System.Windows.Forms.TextBox();
            this.aCTypeTextBox = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.businessTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.BusinessTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.sAPCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // sAPCodeLabel
            // 
            sAPCodeLabel.AutoSize = true;
            sAPCodeLabel.Location = new System.Drawing.Point(82, 34);
            sAPCodeLabel.Name = "sAPCodeLabel";
            sAPCodeLabel.Size = new System.Drawing.Size(77, 18);
            sAPCodeLabel.TabIndex = 0;
            sAPCodeLabel.Text = "SAPCode:";
            // 
            // tradingNameLabel
            // 
            tradingNameLabel.AutoSize = true;
            tradingNameLabel.Location = new System.Drawing.Point(54, 64);
            tradingNameLabel.Name = "tradingNameLabel";
            tradingNameLabel.Size = new System.Drawing.Size(105, 18);
            tradingNameLabel.TabIndex = 2;
            tradingNameLabel.Text = "Trading Name:";
            // 
            // alternateNameLabel
            // 
            alternateNameLabel.AutoSize = true;
            alternateNameLabel.Location = new System.Drawing.Point(46, 94);
            alternateNameLabel.Name = "alternateNameLabel";
            alternateNameLabel.Size = new System.Drawing.Size(113, 18);
            alternateNameLabel.TabIndex = 4;
            alternateNameLabel.Text = "Alternate Name:";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(105, 124);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(54, 18);
            groupLabel.TabIndex = 6;
            groupLabel.Text = "Group:";
            // 
            // aCTypeLabel
            // 
            aCTypeLabel.AutoSize = true;
            aCTypeLabel.Location = new System.Drawing.Point(95, 154);
            aCTypeLabel.Name = "aCTypeLabel";
            aCTypeLabel.Size = new System.Drawing.Size(64, 18);
            aCTypeLabel.TabIndex = 8;
            aCTypeLabel.Text = "ACType:";
            // 
            // aBNLabel
            // 
            aBNLabel.AutoSize = true;
            aBNLabel.Location = new System.Drawing.Point(257, 34);
            aBNLabel.Name = "aBNLabel";
            aBNLabel.Size = new System.Drawing.Size(42, 18);
            aBNLabel.TabIndex = 10;
            aBNLabel.Text = "ABN:";
            // 
            // accountStatusLabel
            // 
            accountStatusLabel.AutoSize = true;
            accountStatusLabel.Location = new System.Drawing.Point(47, 184);
            accountStatusLabel.Name = "accountStatusLabel";
            accountStatusLabel.Size = new System.Drawing.Size(112, 18);
            accountStatusLabel.TabIndex = 12;
            accountStatusLabel.Text = "Account Status:";
            // 
            // pORequiredLabel
            // 
            pORequiredLabel.AutoSize = true;
            pORequiredLabel.Location = new System.Drawing.Point(302, 184);
            pORequiredLabel.Name = "pORequiredLabel";
            pORequiredLabel.Size = new System.Drawing.Size(93, 18);
            pORequiredLabel.TabIndex = 14;
            pORequiredLabel.Text = "PORequired:";
            // 
            // documentOwnerLabel
            // 
            documentOwnerLabel.AutoSize = true;
            documentOwnerLabel.Location = new System.Drawing.Point(30, 214);
            documentOwnerLabel.Name = "documentOwnerLabel";
            documentOwnerLabel.Size = new System.Drawing.Size(129, 18);
            documentOwnerLabel.TabIndex = 16;
            documentOwnerLabel.Text = "Document Owner:";
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
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelNotFound);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 628);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnCancelNotFound
            // 
            this.btnCancelNotFound.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelNotFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNotFound.Location = new System.Drawing.Point(670, 24);
            this.btnCancelNotFound.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelNotFound.Name = "btnCancelNotFound";
            this.btnCancelNotFound.Size = new System.Drawing.Size(157, 49);
            this.btnCancelNotFound.TabIndex = 68;
            this.btnCancelNotFound.Text = "Cancel - Not Found";
            this.btnCancelNotFound.UseVisualStyleBackColor = false;
            this.btnCancelNotFound.Click += new System.EventHandler(this.btnCancelNotFound_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(29, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 35);
            this.txtSearch.TabIndex = 67;
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.Location = new System.Drawing.Point(541, 24);
            this.btnCancel1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(112, 49);
            this.btnCancel1.TabIndex = 64;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(404, 24);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(114, 49);
            this.btnSelect.TabIndex = 66;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(271, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 49);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnDown);
            this.splitContainer2.Panel2.Controls.Add(this.btnInfo);
            this.splitContainer2.Panel2.Controls.Add(this.btnUp);
            this.splitContainer2.Size = new System.Drawing.Size(1000, 516);
            this.splitContainer2.SplitterDistance = 818;
            this.splitContainer2.TabIndex = 57;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 516);
            this.tabControl1.TabIndex = 18;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(810, 485);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
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
            this.AccountStatus,
            this.DefaultContact,
            this.OfficePhone});
            this.dataGridView1.DataSource = this.businessBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(804, 479);
            this.dataGridView1.TabIndex = 0;
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
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.sAPCodeTextBox);
            this.tpDetails.Controls.Add(documentOwnerLabel);
            this.tpDetails.Controls.Add(sAPCodeLabel);
            this.tpDetails.Controls.Add(this.documentOwnerTextBox);
            this.tpDetails.Controls.Add(this.tradingNameTextBox);
            this.tpDetails.Controls.Add(pORequiredLabel);
            this.tpDetails.Controls.Add(tradingNameLabel);
            this.tpDetails.Controls.Add(this.pORequiredTextBox);
            this.tpDetails.Controls.Add(this.alternateNameTextBox);
            this.tpDetails.Controls.Add(accountStatusLabel);
            this.tpDetails.Controls.Add(alternateNameLabel);
            this.tpDetails.Controls.Add(this.accountStatusTextBox);
            this.tpDetails.Controls.Add(this.groupTextBox);
            this.tpDetails.Controls.Add(aBNLabel);
            this.tpDetails.Controls.Add(groupLabel);
            this.tpDetails.Controls.Add(this.aBNTextBox);
            this.tpDetails.Controls.Add(this.aCTypeTextBox);
            this.tpDetails.Controls.Add(aCTypeLabel);
            this.tpDetails.Location = new System.Drawing.Point(4, 22);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(810, 490);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // sAPCodeTextBox
            // 
            this.sAPCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "SAPCode", true));
            this.sAPCodeTextBox.Location = new System.Drawing.Point(165, 31);
            this.sAPCodeTextBox.Name = "sAPCodeTextBox";
            this.sAPCodeTextBox.Size = new System.Drawing.Size(84, 24);
            this.sAPCodeTextBox.TabIndex = 1;
            // 
            // documentOwnerTextBox
            // 
            this.documentOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "DocumentOwner", true));
            this.documentOwnerTextBox.Location = new System.Drawing.Point(165, 211);
            this.documentOwnerTextBox.Name = "documentOwnerTextBox";
            this.documentOwnerTextBox.Size = new System.Drawing.Size(269, 24);
            this.documentOwnerTextBox.TabIndex = 17;
            // 
            // tradingNameTextBox
            // 
            this.tradingNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "TradingName", true));
            this.tradingNameTextBox.Location = new System.Drawing.Point(165, 61);
            this.tradingNameTextBox.Name = "tradingNameTextBox";
            this.tradingNameTextBox.Size = new System.Drawing.Size(269, 24);
            this.tradingNameTextBox.TabIndex = 3;
            // 
            // pORequiredTextBox
            // 
            this.pORequiredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "PORequired", true));
            this.pORequiredTextBox.Location = new System.Drawing.Point(401, 181);
            this.pORequiredTextBox.Name = "pORequiredTextBox";
            this.pORequiredTextBox.Size = new System.Drawing.Size(33, 24);
            this.pORequiredTextBox.TabIndex = 15;
            // 
            // alternateNameTextBox
            // 
            this.alternateNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "AlternateName", true));
            this.alternateNameTextBox.Location = new System.Drawing.Point(165, 91);
            this.alternateNameTextBox.Name = "alternateNameTextBox";
            this.alternateNameTextBox.Size = new System.Drawing.Size(269, 24);
            this.alternateNameTextBox.TabIndex = 5;
            // 
            // accountStatusTextBox
            // 
            this.accountStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "AccountStatus", true));
            this.accountStatusTextBox.Location = new System.Drawing.Point(165, 181);
            this.accountStatusTextBox.Name = "accountStatusTextBox";
            this.accountStatusTextBox.Size = new System.Drawing.Size(29, 24);
            this.accountStatusTextBox.TabIndex = 13;
            // 
            // groupTextBox
            // 
            this.groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "Group", true));
            this.groupTextBox.Location = new System.Drawing.Point(165, 121);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(269, 24);
            this.groupTextBox.TabIndex = 7;
            // 
            // aBNTextBox
            // 
            this.aBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "ABN", true));
            this.aBNTextBox.Location = new System.Drawing.Point(305, 31);
            this.aBNTextBox.Name = "aBNTextBox";
            this.aBNTextBox.Size = new System.Drawing.Size(129, 24);
            this.aBNTextBox.TabIndex = 11;
            // 
            // aCTypeTextBox
            // 
            this.aCTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "ACType", true));
            this.aCTypeTextBox.Location = new System.Drawing.Point(165, 151);
            this.aCTypeTextBox.Name = "aCTypeTextBox";
            this.aCTypeTextBox.Size = new System.Drawing.Size(269, 24);
            this.aCTypeTextBox.TabIndex = 9;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(18, 102);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(86, 49);
            this.btnDown.TabIndex = 55;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(18, 210);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(86, 49);
            this.btnInfo.TabIndex = 54;
            this.btnInfo.Text = "info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(18, 30);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(86, 49);
            this.btnUp.TabIndex = 56;
            this.btnUp.Text = "up";
            this.btnUp.UseVisualStyleBackColor = false;
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
            // sAPCodeDataGridViewTextBoxColumn
            // 
            this.sAPCodeDataGridViewTextBoxColumn.DataPropertyName = "SAPCode";
            this.sAPCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.sAPCodeDataGridViewTextBoxColumn.Name = "sAPCodeDataGridViewTextBoxColumn";
            this.sAPCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tradingNameDataGridViewTextBoxColumn
            // 
            this.tradingNameDataGridViewTextBoxColumn.DataPropertyName = "TradingName";
            this.tradingNameDataGridViewTextBoxColumn.HeaderText = "Business Partner";
            this.tradingNameDataGridViewTextBoxColumn.Name = "tradingNameDataGridViewTextBoxColumn";
            this.tradingNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tradingNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // AccountStatus
            // 
            this.AccountStatus.DataPropertyName = "AccountStatus";
            this.AccountStatus.HeaderText = "AC Status";
            this.AccountStatus.Name = "AccountStatus";
            this.AccountStatus.ReadOnly = true;
            // 
            // DefaultContact
            // 
            this.DefaultContact.HeaderText = "Contact";
            this.DefaultContact.Name = "DefaultContact";
            this.DefaultContact.ReadOnly = true;
            // 
            // OfficePhone
            // 
            this.OfficePhone.HeaderText = "Phone";
            this.OfficePhone.Name = "OfficePhone";
            this.OfficePhone.ReadOnly = true;
            // 
            // BusinessSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 628);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusinessSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Business Search";
            this.Load += new System.EventHandler(this.BusinessSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnCancelNotFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAPCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficePhone;
    }
}