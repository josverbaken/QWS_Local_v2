namespace QWS_Local
{
    partial class TruckConfigMaintenance
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
            this.txtRego = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roadAccessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsConfiguredTruckGVM = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.taConfiguredTruckGVM = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.regoTkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoTrailerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.schematicPictureBox = new System.Windows.Forms.PictureBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.regoTkTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCheckConfig = new System.Windows.Forms.Button();
            this.btnAddGVM = new System.Windows.Forms.Button();
            this.btnAddTrailer = new System.Windows.Forms.Button();
            this.btnFindConfiguredTrucks = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpConfigGVMList = new System.Windows.Forms.TabPage();
            this.tpConfigGVMDetails = new System.Windows.Forms.TabPage();
            this.tableAdapterManager = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.taConfiguredTrucks = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.taVehicle = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.bsAxleConfiguration = new System.Windows.Forms.BindingSource(this.components);
            this.taAxleConfiguration = new QWS_Local.dsQWSLocalTableAdapters.AxleConfigurationTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schematicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpConfigGVMList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfiguration)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRego
            // 
            this.txtRego.Location = new System.Drawing.Point(48, 30);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(100, 24);
            this.txtRego.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roadAccessDataGridViewTextBoxColumn,
            this.configSourceDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.schemeDataGridViewTextBoxColumn,
            this.gCMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsConfiguredTruckGVM;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(972, 298);
            this.dataGridView1.TabIndex = 2;
            // 
            // roadAccessDataGridViewTextBoxColumn
            // 
            this.roadAccessDataGridViewTextBoxColumn.DataPropertyName = "RoadAccess";
            this.roadAccessDataGridViewTextBoxColumn.HeaderText = "RoadAccess";
            this.roadAccessDataGridViewTextBoxColumn.Name = "roadAccessDataGridViewTextBoxColumn";
            this.roadAccessDataGridViewTextBoxColumn.ReadOnly = true;
            this.roadAccessDataGridViewTextBoxColumn.Width = 150;
            // 
            // configSourceDataGridViewTextBoxColumn
            // 
            this.configSourceDataGridViewTextBoxColumn.DataPropertyName = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.HeaderText = "Config Source";
            this.configSourceDataGridViewTextBoxColumn.Name = "configSourceDataGridViewTextBoxColumn";
            this.configSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.configSourceDataGridViewTextBoxColumn.Width = 200;
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "Scheme Code";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            this.schemeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemeDataGridViewTextBoxColumn
            // 
            this.schemeDataGridViewTextBoxColumn.DataPropertyName = "Scheme";
            this.schemeDataGridViewTextBoxColumn.HeaderText = "Scheme";
            this.schemeDataGridViewTextBoxColumn.Name = "schemeDataGridViewTextBoxColumn";
            this.schemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.schemeDataGridViewTextBoxColumn.Width = 400;
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
            this.gCMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsConfiguredTruckGVM
            // 
            this.bsConfiguredTruckGVM.DataMember = "ConfiguredTruckGVM";
            this.bsConfiguredTruckGVM.DataSource = this.dsTruckConfig;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taConfiguredTruckGVM
            // 
            this.taConfiguredTruckGVM.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 284);
            this.tabControl1.TabIndex = 3;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView2);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(978, 253);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List - Truck Combinations";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoTkDataGridViewTextBoxColumn1,
            this.regoTrailerDataGridViewTextBoxColumn1,
            this.axleConfigurationDataGridViewTextBoxColumn1,
            this.VehicleType,
            this.vehicleDescriptionDataGridViewTextBoxColumn,
            this.feeCodeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bsConfiguredTrucks;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(972, 247);
            this.dataGridView2.TabIndex = 0;
            // 
            // regoTkDataGridViewTextBoxColumn1
            // 
            this.regoTkDataGridViewTextBoxColumn1.DataPropertyName = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn1.HeaderText = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn1.Name = "regoTkDataGridViewTextBoxColumn1";
            this.regoTkDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // regoTrailerDataGridViewTextBoxColumn1
            // 
            this.regoTrailerDataGridViewTextBoxColumn1.DataPropertyName = "RegoTrailer";
            this.regoTrailerDataGridViewTextBoxColumn1.HeaderText = "Rego Trailer/s";
            this.regoTrailerDataGridViewTextBoxColumn1.Name = "regoTrailerDataGridViewTextBoxColumn1";
            this.regoTrailerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.regoTrailerDataGridViewTextBoxColumn1.Width = 200;
            // 
            // axleConfigurationDataGridViewTextBoxColumn1
            // 
            this.axleConfigurationDataGridViewTextBoxColumn1.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn1.HeaderText = "Axle Config";
            this.axleConfigurationDataGridViewTextBoxColumn1.Name = "axleConfigurationDataGridViewTextBoxColumn1";
            this.axleConfigurationDataGridViewTextBoxColumn1.ReadOnly = true;
            this.axleConfigurationDataGridViewTextBoxColumn1.Width = 120;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "Type";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            this.VehicleType.Width = 60;
            // 
            // vehicleDescriptionDataGridViewTextBoxColumn
            // 
            this.vehicleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VehicleDescription";
            this.vehicleDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.vehicleDescriptionDataGridViewTextBoxColumn.Name = "vehicleDescriptionDataGridViewTextBoxColumn";
            this.vehicleDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleDescriptionDataGridViewTextBoxColumn.Width = 340;
            // 
            // feeCodeDataGridViewTextBoxColumn1
            // 
            this.feeCodeDataGridViewTextBoxColumn1.DataPropertyName = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn1.HeaderText = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn1.Name = "feeCodeDataGridViewTextBoxColumn1";
            this.feeCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsConfiguredTrucks
            // 
            this.bsConfiguredTrucks.DataMember = "ConfiguredTrucks";
            this.bsConfiguredTrucks.DataSource = this.dsTruckConfig;
            this.bsConfiguredTrucks.CurrentChanged += new System.EventHandler(this.bsConfiguredTrucks_CurrentChanged);
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.schematicPictureBox);
            this.tpDetails.Controls.Add(this.feeCodeTextBox);
            this.tpDetails.Controls.Add(this.truckOwnerTextBox);
            this.tpDetails.Controls.Add(this.regoTkTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 22);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(978, 258);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // schematicPictureBox
            // 
            this.schematicPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsConfiguredTrucks, "Schematic", true));
            this.schematicPictureBox.Location = new System.Drawing.Point(26, 18);
            this.schematicPictureBox.Name = "schematicPictureBox";
            this.schematicPictureBox.Size = new System.Drawing.Size(450, 150);
            this.schematicPictureBox.TabIndex = 7;
            this.schematicPictureBox.TabStop = false;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(630, 23);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.feeCodeTextBox.TabIndex = 5;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(503, 53);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.Size = new System.Drawing.Size(409, 24);
            this.truckOwnerTextBox.TabIndex = 3;
            // 
            // regoTkTextBox
            // 
            this.regoTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "RegoTk", true));
            this.regoTkTextBox.Location = new System.Drawing.Point(503, 23);
            this.regoTkTextBox.Name = "regoTkTextBox";
            this.regoTkTextBox.Size = new System.Drawing.Size(100, 24);
            this.regoTkTextBox.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckConfig);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddGVM);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddTrailer);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindConfiguredTrucks);
            this.splitContainer1.Panel1.Controls.Add(this.txtRego);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 623);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnCheckConfig
            // 
            this.btnCheckConfig.Location = new System.Drawing.Point(48, 99);
            this.btnCheckConfig.Name = "btnCheckConfig";
            this.btnCheckConfig.Size = new System.Drawing.Size(100, 33);
            this.btnCheckConfig.TabIndex = 7;
            this.btnCheckConfig.Text = "Check Config";
            this.btnCheckConfig.UseVisualStyleBackColor = true;
            this.btnCheckConfig.Click += new System.EventHandler(this.btnCheckConfig_Click);
            // 
            // btnAddGVM
            // 
            this.btnAddGVM.Location = new System.Drawing.Point(48, 415);
            this.btnAddGVM.Name = "btnAddGVM";
            this.btnAddGVM.Size = new System.Drawing.Size(100, 33);
            this.btnAddGVM.TabIndex = 6;
            this.btnAddGVM.Text = "Config GVM";
            this.btnAddGVM.UseVisualStyleBackColor = true;
            this.btnAddGVM.Click += new System.EventHandler(this.btnAddGVM_Click);
            // 
            // btnAddTrailer
            // 
            this.btnAddTrailer.Location = new System.Drawing.Point(48, 138);
            this.btnAddTrailer.Name = "btnAddTrailer";
            this.btnAddTrailer.Size = new System.Drawing.Size(100, 33);
            this.btnAddTrailer.TabIndex = 5;
            this.btnAddTrailer.Text = "Add Config";
            this.btnAddTrailer.UseVisualStyleBackColor = true;
            this.btnAddTrailer.Click += new System.EventHandler(this.btnAddTrailer_Click);
            // 
            // btnFindConfiguredTrucks
            // 
            this.btnFindConfiguredTrucks.Location = new System.Drawing.Point(48, 60);
            this.btnFindConfiguredTrucks.Name = "btnFindConfiguredTrucks";
            this.btnFindConfiguredTrucks.Size = new System.Drawing.Size(100, 33);
            this.btnFindConfiguredTrucks.TabIndex = 3;
            this.btnFindConfiguredTrucks.Text = "Find (F3)";
            this.btnFindConfiguredTrucks.UseVisualStyleBackColor = true;
            this.btnFindConfiguredTrucks.Click += new System.EventHandler(this.btnFindConfiguredTrucks_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Size = new System.Drawing.Size(986, 623);
            this.splitContainer2.SplitterDistance = 284;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpConfigGVMList);
            this.tabControl2.Controls.Add(this.tpConfigGVMDetails);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(986, 335);
            this.tabControl2.TabIndex = 1;
            // 
            // tpConfigGVMList
            // 
            this.tpConfigGVMList.Controls.Add(this.dataGridView1);
            this.tpConfigGVMList.Location = new System.Drawing.Point(4, 27);
            this.tpConfigGVMList.Name = "tpConfigGVMList";
            this.tpConfigGVMList.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfigGVMList.Size = new System.Drawing.Size(978, 304);
            this.tpConfigGVMList.TabIndex = 0;
            this.tpConfigGVMList.Text = "List - Truck Configurations";
            this.tpConfigGVMList.UseVisualStyleBackColor = true;
            // 
            // tpConfigGVMDetails
            // 
            this.tpConfigGVMDetails.Location = new System.Drawing.Point(4, 22);
            this.tpConfigGVMDetails.Name = "tpConfigGVMDetails";
            this.tpConfigGVMDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfigGVMDetails.Size = new System.Drawing.Size(978, 309);
            this.tpConfigGVMDetails.TabIndex = 1;
            this.tpConfigGVMDetails.Text = "Details";
            this.tpConfigGVMDetails.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taConfiguredTrucks
            // 
            this.taConfiguredTrucks.ClearBeforeFill = true;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsVehicle
            // 
            this.bsVehicle.DataMember = "Vehicle";
            this.bsVehicle.DataSource = this.dsQWSLocal;
            // 
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.NHVLTableAdapter = null;
            this.tableAdapterManager1.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager1.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager1.PBSTableAdapter = null;
            this.tableAdapterManager1.SchemeCodesTableAdapter = null;
            this.tableAdapterManager1.TruckConfigTableAdapter = null;
            this.tableAdapterManager1.TruckConfigVehicleTableAdapter = null;
            this.tableAdapterManager1.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VehiclePBSTableAdapter = null;
            this.tableAdapterManager1.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager1.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager1.VehicleTableAdapter = this.taVehicle;
            this.tableAdapterManager1.VehicleTypeTableAdapter = null;
            // 
            // bsAxleConfiguration
            // 
            this.bsAxleConfiguration.DataMember = "AxleConfiguration";
            this.bsAxleConfiguration.DataSource = this.dsQWSLocal;
            // 
            // taAxleConfiguration
            // 
            this.taAxleConfiguration.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(48, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TruckConfigMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TruckConfigMaintenance";
            this.Text = "TruckConfigMaintenance";
            this.Load += new System.EventHandler(this.TruckConfigMaintenance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TruckConfigMaintenance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schematicPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpConfigGVMList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfiguration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsConfiguredTruckGVM;
        private dsTruckConfig dsTruckConfig;
        private dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter taConfiguredTruckGVM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bsConfiguredTrucks;
        private dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter taConfiguredTrucks;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnFindConfiguredTrucks;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpConfigGVMList;
        private System.Windows.Forms.TabPage tpConfigGVMDetails;
        private System.Windows.Forms.PictureBox schematicPictureBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox regoTkTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTrailerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadAccessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsVehicle;
        private dsQWSLocalTableAdapters.VehicleTableAdapter taVehicle;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bsAxleConfiguration;
        private dsQWSLocalTableAdapters.AxleConfigurationTableAdapter taAxleConfiguration;
        private System.Windows.Forms.Button btnAddGVM;
        private System.Windows.Forms.Button btnAddTrailer;
        private System.Windows.Forms.Button btnCheckConfig;
        private System.Windows.Forms.Button btnDelete;
    }
}