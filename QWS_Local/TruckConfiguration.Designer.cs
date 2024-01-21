
namespace QWS_Local
{
    partial class TruckConfiguration
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
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label regoTkLabel;
            System.Windows.Forms.Label tareTkLabel;
            System.Windows.Forms.Label tareDTLabel;
            System.Windows.Forms.Label schemeCodeLabel;
            System.Windows.Forms.Label schemeLabel;
            System.Windows.Forms.Label gCMLabel;
            System.Windows.Forms.Label gVMTruckLabel;
            System.Windows.Forms.Label driveAxleLoadLabel;
            System.Windows.Forms.Label driveAxleLoadUOMLabel;
            System.Windows.Forms.Label trTkRatioLabel;
            System.Windows.Forms.Label regoTrailerLabel;
            System.Windows.Forms.Label pBS_LevelLabel;
            System.Windows.Forms.Label bridgeAssessmentLabel;
            System.Windows.Forms.Label regoTr1Label;
            System.Windows.Forms.Label regoTr2Label;
            System.Windows.Forms.Label regoTr3Label;
            this.txtRego = new System.Windows.Forms.TextBox();
            this.bsVehicleDetails = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.bsConfiguredTnt = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAllConfig = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.bsNHVL = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddVehicle2Config = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.taConfiguredTnT = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter();
            this.taVehicleDetails = new QWS_Local.dsQWSLocalTableAdapters.VehicleDetailsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.taVehicle = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.taNHVL = new QWS_Local.dsQWSLocalTableAdapters.NHVLTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RegoTk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoTrailer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AxleConfiguration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BridgeAssessment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.regoTkTextBox = new System.Windows.Forms.TextBox();
            this.tareTkTextBox = new System.Windows.Forms.TextBox();
            this.tareDTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.schemeCodeTextBox = new System.Windows.Forms.TextBox();
            this.schemeTextBox = new System.Windows.Forms.TextBox();
            this.gCMTextBox = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox = new System.Windows.Forms.TextBox();
            this.driveAxleLoadTextBox = new System.Windows.Forms.TextBox();
            this.driveAxleLoadUOMTextBox = new System.Windows.Forms.TextBox();
            this.trTkRatioTextBox = new System.Windows.Forms.TextBox();
            this.regoTrailerTextBox = new System.Windows.Forms.TextBox();
            this.pBS_LevelTextBox = new System.Windows.Forms.TextBox();
            this.bridgeAssessmentTextBox = new System.Windows.Forms.TextBox();
            this.regoTr1TextBox = new System.Windows.Forms.TextBox();
            this.regoTr2TextBox = new System.Windows.Forms.TextBox();
            this.regoTr3TextBox = new System.Windows.Forms.TextBox();
            tareLabel = new System.Windows.Forms.Label();
            regoTkLabel = new System.Windows.Forms.Label();
            tareTkLabel = new System.Windows.Forms.Label();
            tareDTLabel = new System.Windows.Forms.Label();
            schemeCodeLabel = new System.Windows.Forms.Label();
            schemeLabel = new System.Windows.Forms.Label();
            gCMLabel = new System.Windows.Forms.Label();
            gVMTruckLabel = new System.Windows.Forms.Label();
            driveAxleLoadLabel = new System.Windows.Forms.Label();
            driveAxleLoadUOMLabel = new System.Windows.Forms.Label();
            trTkRatioLabel = new System.Windows.Forms.Label();
            regoTrailerLabel = new System.Windows.Forms.Label();
            pBS_LevelLabel = new System.Windows.Forms.Label();
            bridgeAssessmentLabel = new System.Windows.Forms.Label();
            regoTr1Label = new System.Windows.Forms.Label();
            regoTr2Label = new System.Windows.Forms.Label();
            regoTr3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            this.tpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRego
            // 
            this.txtRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "Rego", true));
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.Location = new System.Drawing.Point(22, 25);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(100, 24);
            this.txtRego.TabIndex = 3;
            // 
            // bsVehicleDetails
            // 
            this.bsVehicleDetails.DataMember = "VehicleDetails";
            this.bsVehicleDetails.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsConfiguredTnt
            // 
            this.bsConfiguredTnt.DataMember = "ConfiguredTnT";
            this.bsConfiguredTnt.DataSource = this.dsTruckConfig;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(254, 29);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(99, 20);
            this.axleConfigurationTextBox.TabIndex = 8;
            // 
            // bsVehicle
            // 
            this.bsVehicle.DataMember = "Vehicle";
            this.bsVehicle.DataSource = this.dsQWSLocal;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnShowAllConfig);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnFindVehicle);
            this.groupBox1.Controls.Add(this.txtRego);
            this.groupBox1.Controls.Add(this.axleConfigurationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(28, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 94);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Vehicle";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Single";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowAllConfig
            // 
            this.btnShowAllConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllConfig.Location = new System.Drawing.Point(128, 56);
            this.btnShowAllConfig.Name = "btnShowAllConfig";
            this.btnShowAllConfig.Size = new System.Drawing.Size(120, 24);
            this.btnShowAllConfig.TabIndex = 19;
            this.btnShowAllConfig.Text = "Show All";
            this.btnShowAllConfig.UseVisualStyleBackColor = true;
            this.btnShowAllConfig.Click += new System.EventHandler(this.btnShowAllConfig_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsVehicleDetails, "IsLeadVehicle", true));
            this.checkBox1.Location = new System.Drawing.Point(254, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Is Lead Vehicle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindVehicle.Location = new System.Drawing.Point(128, 25);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(120, 24);
            this.btnFindVehicle.TabIndex = 17;
            this.btnFindVehicle.Text = "Search";
            this.btnFindVehicle.UseVisualStyleBackColor = true;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // bsNHVL
            // 
            this.bsNHVL.DataMember = "NHVL";
            this.bsNHVL.DataSource = this.dsQWSLocal;
            // 
            // btnAddVehicle2Config
            // 
            this.btnAddVehicle2Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle2Config.Location = new System.Drawing.Point(603, 47);
            this.btnAddVehicle2Config.Name = "btnAddVehicle2Config";
            this.btnAddVehicle2Config.Size = new System.Drawing.Size(140, 69);
            this.btnAddVehicle2Config.TabIndex = 18;
            this.btnAddVehicle2Config.Text = "Add Config";
            this.btnAddVehicle2Config.UseVisualStyleBackColor = true;
            this.btnAddVehicle2Config.Click += new System.EventHandler(this.btnAddVehicle2Config_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taConfiguredTnT
            // 
            this.taConfiguredTnT.ClearBeforeFill = true;
            // 
            // taVehicleDetails
            // 
            this.taVehicleDetails.ClearBeforeFill = true;
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
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // taNHVL
            // 
            this.taNHVL.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegoTk,
            this.RegoTrailer,
            this.AxleConfiguration,
            this.GCM,
            this.Tare,
            this.TareDT,
            this.configSourceDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.Scheme,
            this.BridgeAssessment});
            this.dataGridView2.DataSource = this.bsConfiguredTnt;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(995, 347);
            this.dataGridView2.TabIndex = 22;
            // 
            // RegoTk
            // 
            this.RegoTk.DataPropertyName = "RegoTk";
            this.RegoTk.HeaderText = "Truck";
            this.RegoTk.Name = "RegoTk";
            this.RegoTk.ReadOnly = true;
            // 
            // RegoTrailer
            // 
            this.RegoTrailer.DataPropertyName = "RegoTrailer";
            this.RegoTrailer.HeaderText = "Trailer";
            this.RegoTrailer.Name = "RegoTrailer";
            this.RegoTrailer.ReadOnly = true;
            this.RegoTrailer.Width = 200;
            // 
            // AxleConfiguration
            // 
            this.AxleConfiguration.DataPropertyName = "AxleConfiguration";
            this.AxleConfiguration.HeaderText = "Axle Cfg";
            this.AxleConfiguration.Name = "AxleConfiguration";
            this.AxleConfiguration.ReadOnly = true;
            // 
            // GCM
            // 
            this.GCM.DataPropertyName = "GCM";
            this.GCM.HeaderText = "GCM";
            this.GCM.Name = "GCM";
            this.GCM.ReadOnly = true;
            // 
            // Tare
            // 
            this.Tare.DataPropertyName = "Tare";
            this.Tare.HeaderText = "Tare";
            this.Tare.Name = "Tare";
            this.Tare.ReadOnly = true;
            // 
            // TareDT
            // 
            this.TareDT.DataPropertyName = "TareDT";
            this.TareDT.HeaderText = "Tare Date";
            this.TareDT.Name = "TareDT";
            this.TareDT.ReadOnly = true;
            // 
            // configSourceDataGridViewTextBoxColumn
            // 
            this.configSourceDataGridViewTextBoxColumn.DataPropertyName = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.HeaderText = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.Name = "configSourceDataGridViewTextBoxColumn";
            this.configSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.configSourceDataGridViewTextBoxColumn.Width = 200;
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            this.schemeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Scheme
            // 
            this.Scheme.DataPropertyName = "Scheme";
            this.Scheme.HeaderText = "Scheme";
            this.Scheme.Name = "Scheme";
            this.Scheme.ReadOnly = true;
            this.Scheme.Width = 200;
            // 
            // BridgeAssessment
            // 
            this.BridgeAssessment.DataPropertyName = "BridgeAssessment";
            this.BridgeAssessment.HeaderText = "BridgeAssessment";
            this.BridgeAssessment.Name = "BridgeAssessment";
            this.BridgeAssessment.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsConfiguredTnt, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(50, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(400, 137);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardCodeTextBox.TabIndex = 25;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(50, 137);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(344, 20);
            this.ownerTextBox.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Location = new System.Drawing.Point(48, 319);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 379);
            this.tabControl1.TabIndex = 27;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView2);
            this.tpList.Location = new System.Drawing.Point(4, 22);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(1001, 353);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(regoTr3Label);
            this.tpDetails.Controls.Add(this.regoTr3TextBox);
            this.tpDetails.Controls.Add(regoTr2Label);
            this.tpDetails.Controls.Add(this.regoTr2TextBox);
            this.tpDetails.Controls.Add(regoTr1Label);
            this.tpDetails.Controls.Add(this.regoTr1TextBox);
            this.tpDetails.Controls.Add(bridgeAssessmentLabel);
            this.tpDetails.Controls.Add(this.bridgeAssessmentTextBox);
            this.tpDetails.Controls.Add(pBS_LevelLabel);
            this.tpDetails.Controls.Add(this.pBS_LevelTextBox);
            this.tpDetails.Controls.Add(regoTrailerLabel);
            this.tpDetails.Controls.Add(this.regoTrailerTextBox);
            this.tpDetails.Controls.Add(trTkRatioLabel);
            this.tpDetails.Controls.Add(this.trTkRatioTextBox);
            this.tpDetails.Controls.Add(driveAxleLoadUOMLabel);
            this.tpDetails.Controls.Add(this.driveAxleLoadUOMTextBox);
            this.tpDetails.Controls.Add(driveAxleLoadLabel);
            this.tpDetails.Controls.Add(this.driveAxleLoadTextBox);
            this.tpDetails.Controls.Add(gVMTruckLabel);
            this.tpDetails.Controls.Add(this.gVMTruckTextBox);
            this.tpDetails.Controls.Add(gCMLabel);
            this.tpDetails.Controls.Add(this.gCMTextBox);
            this.tpDetails.Controls.Add(schemeLabel);
            this.tpDetails.Controls.Add(this.schemeTextBox);
            this.tpDetails.Controls.Add(schemeCodeLabel);
            this.tpDetails.Controls.Add(this.schemeCodeTextBox);
            this.tpDetails.Controls.Add(tareDTLabel);
            this.tpDetails.Controls.Add(this.tareDTDateTimePicker);
            this.tpDetails.Controls.Add(tareTkLabel);
            this.tpDetails.Controls.Add(this.tareTkTextBox);
            this.tpDetails.Controls.Add(regoTkLabel);
            this.tpDetails.Controls.Add(this.regoTkTextBox);
            this.tpDetails.Controls.Add(tareLabel);
            this.tpDetails.Controls.Add(this.tareTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 22);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1001, 353);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(28, 52);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(32, 13);
            tareLabel.TabIndex = 0;
            tareLabel.Text = "Tare:";
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(66, 49);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(100, 20);
            this.tareTextBox.TabIndex = 1;
            // 
            // regoTkLabel
            // 
            regoTkLabel.AutoSize = true;
            regoTkLabel.Location = new System.Drawing.Point(34, 20);
            regoTkLabel.Name = "regoTkLabel";
            regoTkLabel.Size = new System.Drawing.Size(52, 13);
            regoTkLabel.TabIndex = 2;
            regoTkLabel.Text = "Rego Tk:";
            // 
            // regoTkTextBox
            // 
            this.regoTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTk", true));
            this.regoTkTextBox.Location = new System.Drawing.Point(92, 17);
            this.regoTkTextBox.Name = "regoTkTextBox";
            this.regoTkTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTkTextBox.TabIndex = 3;
            // 
            // tareTkLabel
            // 
            tareTkLabel.AutoSize = true;
            tareTkLabel.Location = new System.Drawing.Point(43, 92);
            tareTkLabel.Name = "tareTkLabel";
            tareTkLabel.Size = new System.Drawing.Size(48, 13);
            tareTkLabel.TabIndex = 4;
            tareTkLabel.Text = "Tare Tk:";
            // 
            // tareTkTextBox
            // 
            this.tareTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "TareTk", true));
            this.tareTkTextBox.Location = new System.Drawing.Point(97, 89);
            this.tareTkTextBox.Name = "tareTkTextBox";
            this.tareTkTextBox.Size = new System.Drawing.Size(100, 20);
            this.tareTkTextBox.TabIndex = 5;
            // 
            // tareDTLabel
            // 
            tareDTLabel.AutoSize = true;
            tareDTLabel.Location = new System.Drawing.Point(43, 127);
            tareDTLabel.Name = "tareDTLabel";
            tareDTLabel.Size = new System.Drawing.Size(50, 13);
            tareDTLabel.TabIndex = 6;
            tareDTLabel.Text = "Tare DT:";
            // 
            // tareDTDateTimePicker
            // 
            this.tareDTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsConfiguredTnt, "TareDT", true));
            this.tareDTDateTimePicker.Location = new System.Drawing.Point(99, 123);
            this.tareDTDateTimePicker.Name = "tareDTDateTimePicker";
            this.tareDTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tareDTDateTimePicker.TabIndex = 7;
            // 
            // schemeCodeLabel
            // 
            schemeCodeLabel.AutoSize = true;
            schemeCodeLabel.Location = new System.Drawing.Point(49, 159);
            schemeCodeLabel.Name = "schemeCodeLabel";
            schemeCodeLabel.Size = new System.Drawing.Size(77, 13);
            schemeCodeLabel.TabIndex = 8;
            schemeCodeLabel.Text = "Scheme Code:";
            // 
            // schemeCodeTextBox
            // 
            this.schemeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "SchemeCode", true));
            this.schemeCodeTextBox.Location = new System.Drawing.Point(132, 156);
            this.schemeCodeTextBox.Name = "schemeCodeTextBox";
            this.schemeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.schemeCodeTextBox.TabIndex = 9;
            // 
            // schemeLabel
            // 
            schemeLabel.AutoSize = true;
            schemeLabel.Location = new System.Drawing.Point(52, 193);
            schemeLabel.Name = "schemeLabel";
            schemeLabel.Size = new System.Drawing.Size(49, 13);
            schemeLabel.TabIndex = 10;
            schemeLabel.Text = "Scheme:";
            // 
            // schemeTextBox
            // 
            this.schemeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Scheme", true));
            this.schemeTextBox.Location = new System.Drawing.Point(107, 190);
            this.schemeTextBox.Name = "schemeTextBox";
            this.schemeTextBox.Size = new System.Drawing.Size(100, 20);
            this.schemeTextBox.TabIndex = 11;
            // 
            // gCMLabel
            // 
            gCMLabel.AutoSize = true;
            gCMLabel.Location = new System.Drawing.Point(441, 76);
            gCMLabel.Name = "gCMLabel";
            gCMLabel.Size = new System.Drawing.Size(34, 13);
            gCMLabel.TabIndex = 12;
            gCMLabel.Text = "GCM:";
            // 
            // gCMTextBox
            // 
            this.gCMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "GCM", true));
            this.gCMTextBox.Location = new System.Drawing.Point(481, 73);
            this.gCMTextBox.Name = "gCMTextBox";
            this.gCMTextBox.Size = new System.Drawing.Size(100, 20);
            this.gCMTextBox.TabIndex = 13;
            // 
            // gVMTruckLabel
            // 
            gVMTruckLabel.AutoSize = true;
            gVMTruckLabel.Location = new System.Drawing.Point(439, 104);
            gVMTruckLabel.Name = "gVMTruckLabel";
            gVMTruckLabel.Size = new System.Drawing.Size(62, 13);
            gVMTruckLabel.TabIndex = 14;
            gVMTruckLabel.Text = "GVMTruck:";
            // 
            // gVMTruckTextBox
            // 
            this.gVMTruckTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "GVMTruck", true));
            this.gVMTruckTextBox.Location = new System.Drawing.Point(507, 101);
            this.gVMTruckTextBox.Name = "gVMTruckTextBox";
            this.gVMTruckTextBox.Size = new System.Drawing.Size(100, 20);
            this.gVMTruckTextBox.TabIndex = 15;
            // 
            // driveAxleLoadLabel
            // 
            driveAxleLoadLabel.AutoSize = true;
            driveAxleLoadLabel.Location = new System.Drawing.Point(439, 146);
            driveAxleLoadLabel.Name = "driveAxleLoadLabel";
            driveAxleLoadLabel.Size = new System.Drawing.Size(85, 13);
            driveAxleLoadLabel.TabIndex = 16;
            driveAxleLoadLabel.Text = "Drive Axle Load:";
            // 
            // driveAxleLoadTextBox
            // 
            this.driveAxleLoadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "DriveAxleLoad", true));
            this.driveAxleLoadTextBox.Location = new System.Drawing.Point(530, 143);
            this.driveAxleLoadTextBox.Name = "driveAxleLoadTextBox";
            this.driveAxleLoadTextBox.Size = new System.Drawing.Size(100, 20);
            this.driveAxleLoadTextBox.TabIndex = 17;
            // 
            // driveAxleLoadUOMLabel
            // 
            driveAxleLoadUOMLabel.AutoSize = true;
            driveAxleLoadUOMLabel.Location = new System.Drawing.Point(440, 183);
            driveAxleLoadUOMLabel.Name = "driveAxleLoadUOMLabel";
            driveAxleLoadUOMLabel.Size = new System.Drawing.Size(113, 13);
            driveAxleLoadUOMLabel.TabIndex = 18;
            driveAxleLoadUOMLabel.Text = "Drive Axle Load UOM:";
            // 
            // driveAxleLoadUOMTextBox
            // 
            this.driveAxleLoadUOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "DriveAxleLoadUOM", true));
            this.driveAxleLoadUOMTextBox.Location = new System.Drawing.Point(559, 180);
            this.driveAxleLoadUOMTextBox.Name = "driveAxleLoadUOMTextBox";
            this.driveAxleLoadUOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.driveAxleLoadUOMTextBox.TabIndex = 19;
            // 
            // trTkRatioLabel
            // 
            trTkRatioLabel.AutoSize = true;
            trTkRatioLabel.Location = new System.Drawing.Point(451, 212);
            trTkRatioLabel.Name = "trTkRatioLabel";
            trTkRatioLabel.Size = new System.Drawing.Size(64, 13);
            trTkRatioLabel.TabIndex = 20;
            trTkRatioLabel.Text = "Tr Tk Ratio:";
            // 
            // trTkRatioTextBox
            // 
            this.trTkRatioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "TrTkRatio", true));
            this.trTkRatioTextBox.Location = new System.Drawing.Point(521, 209);
            this.trTkRatioTextBox.Name = "trTkRatioTextBox";
            this.trTkRatioTextBox.Size = new System.Drawing.Size(100, 20);
            this.trTkRatioTextBox.TabIndex = 21;
            // 
            // regoTrailerLabel
            // 
            regoTrailerLabel.AutoSize = true;
            regoTrailerLabel.Location = new System.Drawing.Point(277, 23);
            regoTrailerLabel.Name = "regoTrailerLabel";
            regoTrailerLabel.Size = new System.Drawing.Size(68, 13);
            regoTrailerLabel.TabIndex = 22;
            regoTrailerLabel.Text = "Rego Trailer:";
            // 
            // regoTrailerTextBox
            // 
            this.regoTrailerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTrailer", true));
            this.regoTrailerTextBox.Location = new System.Drawing.Point(351, 20);
            this.regoTrailerTextBox.Name = "regoTrailerTextBox";
            this.regoTrailerTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTrailerTextBox.TabIndex = 23;
            // 
            // pBS_LevelLabel
            // 
            pBS_LevelLabel.AutoSize = true;
            pBS_LevelLabel.Location = new System.Drawing.Point(453, 241);
            pBS_LevelLabel.Name = "pBS_LevelLabel";
            pBS_LevelLabel.Size = new System.Drawing.Size(60, 13);
            pBS_LevelLabel.TabIndex = 24;
            pBS_LevelLabel.Text = "PBS Level:";
            // 
            // pBS_LevelTextBox
            // 
            this.pBS_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "PBS_Level", true));
            this.pBS_LevelTextBox.Location = new System.Drawing.Point(519, 238);
            this.pBS_LevelTextBox.Name = "pBS_LevelTextBox";
            this.pBS_LevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.pBS_LevelTextBox.TabIndex = 25;
            // 
            // bridgeAssessmentLabel
            // 
            bridgeAssessmentLabel.AutoSize = true;
            bridgeAssessmentLabel.Location = new System.Drawing.Point(456, 272);
            bridgeAssessmentLabel.Name = "bridgeAssessmentLabel";
            bridgeAssessmentLabel.Size = new System.Drawing.Size(99, 13);
            bridgeAssessmentLabel.TabIndex = 26;
            bridgeAssessmentLabel.Text = "Bridge Assessment:";
            // 
            // bridgeAssessmentTextBox
            // 
            this.bridgeAssessmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "BridgeAssessment", true));
            this.bridgeAssessmentTextBox.Location = new System.Drawing.Point(561, 269);
            this.bridgeAssessmentTextBox.Name = "bridgeAssessmentTextBox";
            this.bridgeAssessmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.bridgeAssessmentTextBox.TabIndex = 27;
            // 
            // regoTr1Label
            // 
            regoTr1Label.AutoSize = true;
            regoTr1Label.Location = new System.Drawing.Point(483, 35);
            regoTr1Label.Name = "regoTr1Label";
            regoTr1Label.Size = new System.Drawing.Size(55, 13);
            regoTr1Label.TabIndex = 28;
            regoTr1Label.Text = "Rego Tr1:";
            // 
            // regoTr1TextBox
            // 
            this.regoTr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTr1", true));
            this.regoTr1TextBox.Location = new System.Drawing.Point(544, 32);
            this.regoTr1TextBox.Name = "regoTr1TextBox";
            this.regoTr1TextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTr1TextBox.TabIndex = 29;
            // 
            // regoTr2Label
            // 
            regoTr2Label.AutoSize = true;
            regoTr2Label.Location = new System.Drawing.Point(671, 40);
            regoTr2Label.Name = "regoTr2Label";
            regoTr2Label.Size = new System.Drawing.Size(55, 13);
            regoTr2Label.TabIndex = 30;
            regoTr2Label.Text = "Rego Tr2:";
            // 
            // regoTr2TextBox
            // 
            this.regoTr2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTr2", true));
            this.regoTr2TextBox.Location = new System.Drawing.Point(732, 37);
            this.regoTr2TextBox.Name = "regoTr2TextBox";
            this.regoTr2TextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTr2TextBox.TabIndex = 31;
            // 
            // regoTr3Label
            // 
            regoTr3Label.AutoSize = true;
            regoTr3Label.Location = new System.Drawing.Point(746, 77);
            regoTr3Label.Name = "regoTr3Label";
            regoTr3Label.Size = new System.Drawing.Size(55, 13);
            regoTr3Label.TabIndex = 32;
            regoTr3Label.Text = "Rego Tr3:";
            // 
            // regoTr3TextBox
            // 
            this.regoTr3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTr3", true));
            this.regoTr3TextBox.Location = new System.Drawing.Point(807, 74);
            this.regoTr3TextBox.Name = "regoTr3TextBox";
            this.regoTr3TextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTr3TextBox.TabIndex = 33;
            // 
            // TruckConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 831);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cardCodeTextBox);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddVehicle2Config);
            this.Controls.Add(this.groupBox1);
            this.Name = "TruckConfiguration";
            this.Text = "Truck Configuration";
            this.Load += new System.EventHandler(this.TruckConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsVehicleDetails;
        private dsQWSLocalTableAdapters.VehicleDetailsTableAdapter taVehicleDetails;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.BindingSource bsVehicle;
        private dsQWSLocalTableAdapters.VehicleTableAdapter taVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddVehicle2Config;
        private dsTruckConfig dsTruckConfig;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnShowAllConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsNHVL;
        private dsQWSLocalTableAdapters.NHVLTableAdapter taNHVL;
        private System.Windows.Forms.BindingSource bsConfiguredTnt;
        private dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter taConfiguredTnT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegoTk;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegoTrailer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AxleConfiguration;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn configSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BridgeAssessment;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox regoTkTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.TextBox regoTr3TextBox;
        private System.Windows.Forms.TextBox regoTr2TextBox;
        private System.Windows.Forms.TextBox regoTr1TextBox;
        private System.Windows.Forms.TextBox bridgeAssessmentTextBox;
        private System.Windows.Forms.TextBox pBS_LevelTextBox;
        private System.Windows.Forms.TextBox regoTrailerTextBox;
        private System.Windows.Forms.TextBox trTkRatioTextBox;
        private System.Windows.Forms.TextBox driveAxleLoadUOMTextBox;
        private System.Windows.Forms.TextBox driveAxleLoadTextBox;
        private System.Windows.Forms.TextBox gVMTruckTextBox;
        private System.Windows.Forms.TextBox gCMTextBox;
        private System.Windows.Forms.TextBox schemeTextBox;
        private System.Windows.Forms.TextBox schemeCodeTextBox;
        private System.Windows.Forms.DateTimePicker tareDTDateTimePicker;
        private System.Windows.Forms.TextBox tareTkTextBox;
    }
}