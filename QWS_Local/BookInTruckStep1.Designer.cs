
namespace QWS_Local
{
    partial class BookInTruckStep1
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
            System.Windows.Forms.Label cardCodeLabel;
            System.Windows.Forms.Label truckOwnerLabel;
            System.Windows.Forms.Label cardStatusLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label inductionExpLabel;
            System.Windows.Forms.Label licenseExpLabel;
            System.Windows.Forms.Label licenseTypeLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label mobLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label personLabel;
            System.Windows.Forms.Label prefCustomerLabel;
            System.Windows.Forms.Label compartmentsLabel;
            this.pictureSchematic = new System.Windows.Forms.PictureBox();
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.txtTruckRego = new System.Windows.Forms.TextBox();
            this.btnFindTruck = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regoTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoTrailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nHVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.bsConfiguredTruckGVM = new System.Windows.Forms.BindingSource(this.components);
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.txtCardStatus = new System.Windows.Forms.TextBox();
            this.chkACC = new System.Windows.Forms.CheckBox();
            this.taConfiguredTrucks = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
            this.taConfiguredTruckGVM = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.txtFeeCode = new System.Windows.Forms.TextBox();
            this.txtFeeCodeConditions = new System.Windows.Forms.TextBox();
            this.chkDriverACC = new System.Windows.Forms.CheckBox();
            this.txtOkay2Cart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicenseExp = new System.Windows.Forms.TextBox();
            this.bsTruckDriver = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.txtInductionExp = new System.Windows.Forms.TextBox();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.licenseTypeTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.btnGetDriver = new System.Windows.Forms.Button();
            this.taTruckDriver = new QWS_Local.dsQWSLocalTableAdapters.TruckDriverTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCollected = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnRetare = new System.Windows.Forms.Button();
            this.btnImported = new System.Windows.Forms.Button();
            this.btnExBin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTrailerOnly = new System.Windows.Forms.RadioButton();
            this.rbSplitLoad = new System.Windows.Forms.RadioButton();
            this.rbTnT = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bsPrefCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.taPrefCustomers = new QWS_Local.dsQWSLocalTableAdapters.VehiclePrefCustomersTableAdapter();
            this.prefCustomerTextBox = new System.Windows.Forms.TextBox();
            this.compartmentsTextBox = new System.Windows.Forms.TextBox();
            cardCodeLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            cardStatusLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            inductionExpLabel = new System.Windows.Forms.Label();
            licenseExpLabel = new System.Windows.Forms.Label();
            licenseTypeLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            mobLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            personLabel = new System.Windows.Forms.Label();
            prefCustomerLabel = new System.Windows.Forms.Label();
            compartmentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // cardCodeLabel
            // 
            cardCodeLabel.AutoSize = true;
            cardCodeLabel.Location = new System.Drawing.Point(541, 59);
            cardCodeLabel.Name = "cardCodeLabel";
            cardCodeLabel.Size = new System.Drawing.Size(79, 17);
            cardCodeLabel.TabIndex = 9;
            cardCodeLabel.Text = "Card Code:";
            // 
            // truckOwnerLabel
            // 
            truckOwnerLabel.AutoSize = true;
            truckOwnerLabel.Location = new System.Drawing.Point(527, 88);
            truckOwnerLabel.Name = "truckOwnerLabel";
            truckOwnerLabel.Size = new System.Drawing.Size(93, 17);
            truckOwnerLabel.TabIndex = 11;
            truckOwnerLabel.Text = "Truck Owner:";
            // 
            // cardStatusLabel
            // 
            cardStatusLabel.AutoSize = true;
            cardStatusLabel.Location = new System.Drawing.Point(534, 117);
            cardStatusLabel.Name = "cardStatusLabel";
            cardStatusLabel.Size = new System.Drawing.Size(86, 17);
            cardStatusLabel.TabIndex = 17;
            cardStatusLabel.Text = "Card Status:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(282, 114);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(50, 17);
            activeLabel.TabIndex = 71;
            activeLabel.Text = "Active:";
            // 
            // inductionExpLabel
            // 
            inductionExpLabel.AutoSize = true;
            inductionExpLabel.Location = new System.Drawing.Point(26, 167);
            inductionExpLabel.Name = "inductionExpLabel";
            inductionExpLabel.Size = new System.Drawing.Size(96, 17);
            inductionExpLabel.TabIndex = 70;
            inductionExpLabel.Text = "Induction Exp:";
            // 
            // licenseExpLabel
            // 
            licenseExpLabel.AutoSize = true;
            licenseExpLabel.Location = new System.Drawing.Point(34, 141);
            licenseExpLabel.Name = "licenseExpLabel";
            licenseExpLabel.Size = new System.Drawing.Size(88, 17);
            licenseExpLabel.TabIndex = 69;
            licenseExpLabel.Text = "License Exp:";
            // 
            // licenseTypeLabel
            // 
            licenseTypeLabel.AutoSize = true;
            licenseTypeLabel.Location = new System.Drawing.Point(25, 114);
            licenseTypeLabel.Name = "licenseTypeLabel";
            licenseTypeLabel.Size = new System.Drawing.Size(97, 17);
            licenseTypeLabel.TabIndex = 67;
            licenseTypeLabel.Text = "License Type:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(90, 88);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(32, 17);
            telLabel.TabIndex = 65;
            telLabel.Text = "Tel:";
            // 
            // mobLabel
            // 
            mobLabel.AutoSize = true;
            mobLabel.Location = new System.Drawing.Point(232, 88);
            mobLabel.Name = "mobLabel";
            mobLabel.Size = new System.Drawing.Size(39, 17);
            mobLabel.TabIndex = 63;
            mobLabel.Text = "Mob:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(60, 62);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(62, 17);
            positionLabel.TabIndex = 60;
            positionLabel.Text = "Position:";
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(65, 28);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(57, 17);
            personLabel.TabIndex = 59;
            personLabel.Text = "Person:";
            // 
            // prefCustomerLabel
            // 
            prefCustomerLabel.AutoSize = true;
            prefCustomerLabel.Location = new System.Drawing.Point(686, 179);
            prefCustomerLabel.Name = "prefCustomerLabel";
            prefCustomerLabel.Size = new System.Drawing.Size(102, 17);
            prefCustomerLabel.TabIndex = 80;
            prefCustomerLabel.Text = "Pref Customer:";
            // 
            // compartmentsLabel
            // 
            compartmentsLabel.AutoSize = true;
            compartmentsLabel.Location = new System.Drawing.Point(791, 145);
            compartmentsLabel.Name = "compartmentsLabel";
            compartmentsLabel.Size = new System.Drawing.Size(103, 17);
            compartmentsLabel.TabIndex = 81;
            compartmentsLabel.Text = "Compartments:";
            // 
            // pictureSchematic
            // 
            this.pictureSchematic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSchematic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsConfiguredTrucks, "Schematic", true));
            this.pictureSchematic.Location = new System.Drawing.Point(63, 56);
            this.pictureSchematic.Name = "pictureSchematic";
            this.pictureSchematic.Size = new System.Drawing.Size(450, 150);
            this.pictureSchematic.TabIndex = 0;
            this.pictureSchematic.TabStop = false;
            // 
            // bsConfiguredTrucks
            // 
            this.bsConfiguredTrucks.DataMember = "ConfiguredTrucks";
            this.bsConfiguredTrucks.DataSource = this.dsTruckConfig;
            this.bsConfiguredTrucks.CurrentChanged += new System.EventHandler(this.bsConfiguredTrucks_CurrentChanged);
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTruckRego
            // 
            this.txtTruckRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruckRego.Location = new System.Drawing.Point(63, 23);
            this.txtTruckRego.Name = "txtTruckRego";
            this.txtTruckRego.Size = new System.Drawing.Size(100, 26);
            this.txtTruckRego.TabIndex = 1;
            // 
            // btnFindTruck
            // 
            this.btnFindTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindTruck.Location = new System.Drawing.Point(183, 22);
            this.btnFindTruck.Name = "btnFindTruck";
            this.btnFindTruck.Size = new System.Drawing.Size(75, 27);
            this.btnFindTruck.TabIndex = 2;
            this.btnFindTruck.Text = "Find";
            this.btnFindTruck.UseVisualStyleBackColor = true;
            this.btnFindTruck.Click += new System.EventHandler(this.btnFindTruck_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoTkDataGridViewTextBoxColumn,
            this.regoTrailerDataGridViewTextBoxColumn,
            this.RegoCheck,
            this.nHVLDataGridViewTextBoxColumn,
            this.PBS});
            this.dataGridView1.DataSource = this.bsConfiguredTrucks;
            this.dataGridView1.Location = new System.Drawing.Point(21, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(979, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // regoTkDataGridViewTextBoxColumn
            // 
            this.regoTkDataGridViewTextBoxColumn.DataPropertyName = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.HeaderText = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.Name = "regoTkDataGridViewTextBoxColumn";
            this.regoTkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regoTrailerDataGridViewTextBoxColumn
            // 
            this.regoTrailerDataGridViewTextBoxColumn.DataPropertyName = "RegoTrailer";
            this.regoTrailerDataGridViewTextBoxColumn.HeaderText = "RegoTrailer";
            this.regoTrailerDataGridViewTextBoxColumn.Name = "regoTrailerDataGridViewTextBoxColumn";
            this.regoTrailerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegoCheck
            // 
            this.RegoCheck.DataPropertyName = "RegoCheck";
            this.RegoCheck.HeaderText = "RegoCheck";
            this.RegoCheck.Name = "RegoCheck";
            this.RegoCheck.ReadOnly = true;
            // 
            // nHVLDataGridViewTextBoxColumn
            // 
            this.nHVLDataGridViewTextBoxColumn.DataPropertyName = "NHVL";
            this.nHVLDataGridViewTextBoxColumn.HeaderText = "NHVL";
            this.nHVLDataGridViewTextBoxColumn.Name = "nHVLDataGridViewTextBoxColumn";
            this.nHVLDataGridViewTextBoxColumn.ReadOnly = true;
            this.nHVLDataGridViewTextBoxColumn.Width = 200;
            // 
            // PBS
            // 
            this.PBS.HeaderText = "PBS Applies";
            this.PBS.Name = "PBS";
            this.PBS.ReadOnly = true;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "AxleConfiguration", true));
            this.txtAxleConfig.Location = new System.Drawing.Point(63, 212);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.Size = new System.Drawing.Size(100, 23);
            this.txtAxleConfig.TabIndex = 4;
            // 
            // txtVehicleDescription
            // 
            this.txtVehicleDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "VehicleDescription", true));
            this.txtVehicleDescription.Location = new System.Drawing.Point(169, 212);
            this.txtVehicleDescription.Name = "txtVehicleDescription";
            this.txtVehicleDescription.Size = new System.Drawing.Size(344, 23);
            this.txtVehicleDescription.TabIndex = 5;
            // 
            // bsConfiguredTruckGVM
            // 
            this.bsConfiguredTruckGVM.DataMember = "ConfiguredTruckGVM";
            this.bsConfiguredTruckGVM.DataSource = this.dsTruckConfig;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(626, 56);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cardCodeTextBox.TabIndex = 10;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(626, 85);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.Size = new System.Drawing.Size(374, 23);
            this.truckOwnerTextBox.TabIndex = 12;
            // 
            // txtCardStatus
            // 
            this.txtCardStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "CardStatus", true));
            this.txtCardStatus.Location = new System.Drawing.Point(626, 114);
            this.txtCardStatus.Name = "txtCardStatus";
            this.txtCardStatus.Size = new System.Drawing.Size(45, 23);
            this.txtCardStatus.TabIndex = 18;
            // 
            // chkACC
            // 
            this.chkACC.AutoSize = true;
            this.chkACC.Location = new System.Drawing.Point(626, 144);
            this.chkACC.Name = "chkACC";
            this.chkACC.Size = new System.Drawing.Size(54, 21);
            this.chkACC.TabIndex = 19;
            this.chkACC.Text = "ACC";
            this.chkACC.UseVisualStyleBackColor = true;
            // 
            // taConfiguredTrucks
            // 
            this.taConfiguredTrucks.ClearBeforeFill = true;
            // 
            // taConfiguredTruckGVM
            // 
            this.taConfiguredTruckGVM.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtFeeCode
            // 
            this.txtFeeCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "FeeCode", true));
            this.txtFeeCode.Location = new System.Drawing.Point(544, 212);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.Size = new System.Drawing.Size(76, 23);
            this.txtFeeCode.TabIndex = 20;
            // 
            // txtFeeCodeConditions
            // 
            this.txtFeeCodeConditions.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "FeeConditions", true));
            this.txtFeeCodeConditions.Location = new System.Drawing.Point(626, 212);
            this.txtFeeCodeConditions.Name = "txtFeeCodeConditions";
            this.txtFeeCodeConditions.Size = new System.Drawing.Size(374, 23);
            this.txtFeeCodeConditions.TabIndex = 21;
            // 
            // chkDriverACC
            // 
            this.chkDriverACC.AutoSize = true;
            this.chkDriverACC.Location = new System.Drawing.Point(338, 139);
            this.chkDriverACC.Name = "chkDriverACC";
            this.chkDriverACC.Size = new System.Drawing.Size(54, 21);
            this.chkDriverACC.TabIndex = 77;
            this.chkDriverACC.Text = "ACC";
            this.chkDriverACC.UseVisualStyleBackColor = true;
            // 
            // txtOkay2Cart
            // 
            this.txtOkay2Cart.Location = new System.Drawing.Point(339, 164);
            this.txtOkay2Cart.Name = "txtOkay2Cart";
            this.txtOkay2Cart.Size = new System.Drawing.Size(46, 23);
            this.txtOkay2Cart.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "OK 2 Cart:";
            // 
            // txtLicenseExp
            // 
            this.txtLicenseExp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "LicenseExp", true));
            this.txtLicenseExp.Location = new System.Drawing.Point(127, 137);
            this.txtLicenseExp.Name = "txtLicenseExp";
            this.txtLicenseExp.Size = new System.Drawing.Size(100, 23);
            this.txtLicenseExp.TabIndex = 74;
            // 
            // bsTruckDriver
            // 
            this.bsTruckDriver.DataMember = "TruckDriver";
            this.bsTruckDriver.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtInductionExp
            // 
            this.txtInductionExp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "InductionExp", true));
            this.txtInductionExp.Location = new System.Drawing.Point(127, 164);
            this.txtInductionExp.Name = "txtInductionExp";
            this.txtInductionExp.Size = new System.Drawing.Size(100, 23);
            this.txtInductionExp.TabIndex = 73;
            // 
            // txtActive
            // 
            this.txtActive.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Active", true));
            this.txtActive.Location = new System.Drawing.Point(338, 111);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(47, 23);
            this.txtActive.TabIndex = 72;
            // 
            // licenseTypeTextBox
            // 
            this.licenseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "LicenseType", true));
            this.licenseTypeTextBox.Location = new System.Drawing.Point(127, 111);
            this.licenseTypeTextBox.Name = "licenseTypeTextBox";
            this.licenseTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.licenseTypeTextBox.TabIndex = 68;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Tel", true));
            this.telTextBox.Location = new System.Drawing.Point(127, 85);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 23);
            this.telTextBox.TabIndex = 66;
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(285, 85);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.Size = new System.Drawing.Size(100, 23);
            this.mobTextBox.TabIndex = 64;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(127, 59);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(258, 23);
            this.positionTextBox.TabIndex = 62;
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(127, 28);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(156, 23);
            this.personTextBox.TabIndex = 61;
            // 
            // btnGetDriver
            // 
            this.btnGetDriver.Location = new System.Drawing.Point(301, 28);
            this.btnGetDriver.Name = "btnGetDriver";
            this.btnGetDriver.Size = new System.Drawing.Size(84, 23);
            this.btnGetDriver.TabIndex = 58;
            this.btnGetDriver.Text = "Get";
            this.btnGetDriver.UseVisualStyleBackColor = true;
            this.btnGetDriver.Click += new System.EventHandler(this.btnGetDriver_Click);
            // 
            // taTruckDriver
            // 
            this.taTruckDriver.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
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
            this.tableAdapterManager1.VehicleTableAdapter = null;
            this.tableAdapterManager1.VehicleTypeTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCollected);
            this.groupBox1.Controls.Add(this.btnDelivery);
            this.groupBox1.Controls.Add(this.btnRetare);
            this.groupBox1.Controls.Add(this.btnImported);
            this.groupBox1.Controls.Add(this.btnExBin);
            this.groupBox1.Location = new System.Drawing.Point(717, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 200);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book In Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Inbound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Outbound";
            // 
            // btnCollected
            // 
            this.btnCollected.Enabled = false;
            this.btnCollected.Location = new System.Drawing.Point(145, 104);
            this.btnCollected.Name = "btnCollected";
            this.btnCollected.Size = new System.Drawing.Size(121, 38);
            this.btnCollected.TabIndex = 58;
            this.btnCollected.Text = "Collected";
            this.btnCollected.UseVisualStyleBackColor = true;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Enabled = false;
            this.btnDelivery.Location = new System.Drawing.Point(15, 104);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(121, 38);
            this.btnDelivery.TabIndex = 57;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnRetare
            // 
            this.btnRetare.Enabled = false;
            this.btnRetare.Location = new System.Drawing.Point(15, 148);
            this.btnRetare.Name = "btnRetare";
            this.btnRetare.Size = new System.Drawing.Size(251, 38);
            this.btnRetare.TabIndex = 56;
            this.btnRetare.Text = "Retare";
            this.btnRetare.UseVisualStyleBackColor = true;
            // 
            // btnImported
            // 
            this.btnImported.Enabled = false;
            this.btnImported.Location = new System.Drawing.Point(145, 60);
            this.btnImported.Name = "btnImported";
            this.btnImported.Size = new System.Drawing.Size(121, 38);
            this.btnImported.TabIndex = 55;
            this.btnImported.Text = "Imported";
            this.btnImported.UseVisualStyleBackColor = true;
            // 
            // btnExBin
            // 
            this.btnExBin.Enabled = false;
            this.btnExBin.Location = new System.Drawing.Point(15, 60);
            this.btnExBin.Name = "btnExBin";
            this.btnExBin.Size = new System.Drawing.Size(121, 38);
            this.btnExBin.TabIndex = 54;
            this.btnExBin.Text = "Ex Bin";
            this.btnExBin.UseVisualStyleBackColor = true;
            this.btnExBin.Click += new System.EventHandler(this.btnExBin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTrailerOnly);
            this.groupBox2.Controls.Add(this.rbSplitLoad);
            this.groupBox2.Controls.Add(this.rbTnT);
            this.groupBox2.Location = new System.Drawing.Point(506, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 200);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Truck Configuration";
            // 
            // rbTrailerOnly
            // 
            this.rbTrailerOnly.AutoSize = true;
            this.rbTrailerOnly.Location = new System.Drawing.Point(24, 111);
            this.rbTrailerOnly.Name = "rbTrailerOnly";
            this.rbTrailerOnly.Size = new System.Drawing.Size(100, 21);
            this.rbTrailerOnly.TabIndex = 2;
            this.rbTrailerOnly.TabStop = true;
            this.rbTrailerOnly.Text = "Trailer Only";
            this.rbTrailerOnly.UseVisualStyleBackColor = true;
            // 
            // rbSplitLoad
            // 
            this.rbSplitLoad.AutoSize = true;
            this.rbSplitLoad.Location = new System.Drawing.Point(24, 80);
            this.rbSplitLoad.Name = "rbSplitLoad";
            this.rbSplitLoad.Size = new System.Drawing.Size(89, 21);
            this.rbSplitLoad.TabIndex = 1;
            this.rbSplitLoad.TabStop = true;
            this.rbSplitLoad.Text = "Split Load";
            this.rbSplitLoad.UseVisualStyleBackColor = true;
            // 
            // rbTnT
            // 
            this.rbTnT.AutoSize = true;
            this.rbTnT.Location = new System.Drawing.Point(24, 47);
            this.rbTnT.Name = "rbTnT";
            this.rbTnT.Size = new System.Drawing.Size(135, 21);
            this.rbTnT.TabIndex = 0;
            this.rbTnT.TabStop = true;
            this.rbTnT.Text = "Truck and Trailer";
            this.rbTnT.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.personTextBox);
            this.groupBox3.Controls.Add(this.btnGetDriver);
            this.groupBox3.Controls.Add(personLabel);
            this.groupBox3.Controls.Add(this.chkDriverACC);
            this.groupBox3.Controls.Add(this.positionTextBox);
            this.groupBox3.Controls.Add(this.txtOkay2Cart);
            this.groupBox3.Controls.Add(positionLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.mobTextBox);
            this.groupBox3.Controls.Add(this.txtLicenseExp);
            this.groupBox3.Controls.Add(mobLabel);
            this.groupBox3.Controls.Add(this.txtInductionExp);
            this.groupBox3.Controls.Add(this.telTextBox);
            this.groupBox3.Controls.Add(activeLabel);
            this.groupBox3.Controls.Add(telLabel);
            this.groupBox3.Controls.Add(this.txtActive);
            this.groupBox3.Controls.Add(this.licenseTypeTextBox);
            this.groupBox3.Controls.Add(inductionExpLabel);
            this.groupBox3.Controls.Add(licenseTypeLabel);
            this.groupBox3.Controls.Add(licenseExpLabel);
            this.groupBox3.Location = new System.Drawing.Point(21, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 200);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Truck Driver";
            // 
            // bsPrefCustomers
            // 
            this.bsPrefCustomers.DataMember = "VehiclePrefCustomers";
            this.bsPrefCustomers.DataSource = this.dsQWSLocal;
            // 
            // taPrefCustomers
            // 
            this.taPrefCustomers.ClearBeforeFill = true;
            // 
            // prefCustomerTextBox
            // 
            this.prefCustomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPrefCustomers, "PrefCustomer", true));
            this.prefCustomerTextBox.Location = new System.Drawing.Point(794, 176);
            this.prefCustomerTextBox.Name = "prefCustomerTextBox";
            this.prefCustomerTextBox.Size = new System.Drawing.Size(206, 23);
            this.prefCustomerTextBox.TabIndex = 81;
            // 
            // compartmentsTextBox
            // 
            this.compartmentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "Compartments", true));
            this.compartmentsTextBox.Location = new System.Drawing.Point(900, 142);
            this.compartmentsTextBox.Name = "compartmentsTextBox";
            this.compartmentsTextBox.Size = new System.Drawing.Size(100, 23);
            this.compartmentsTextBox.TabIndex = 82;
            // 
            // BookInTruckStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(compartmentsLabel);
            this.Controls.Add(this.compartmentsTextBox);
            this.Controls.Add(prefCustomerLabel);
            this.Controls.Add(this.prefCustomerTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFeeCodeConditions);
            this.Controls.Add(this.txtFeeCode);
            this.Controls.Add(this.chkACC);
            this.Controls.Add(cardStatusLabel);
            this.Controls.Add(this.txtCardStatus);
            this.Controls.Add(truckOwnerLabel);
            this.Controls.Add(this.truckOwnerTextBox);
            this.Controls.Add(cardCodeLabel);
            this.Controls.Add(this.cardCodeTextBox);
            this.Controls.Add(this.txtVehicleDescription);
            this.Controls.Add(this.txtAxleConfig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindTruck);
            this.Controls.Add(this.txtTruckRego);
            this.Controls.Add(this.pictureSchematic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookInTruckStep1";
            this.Text = "BookInTruckStep1";
            this.Load += new System.EventHandler(this.BookInTruckStep1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSchematic;
        private System.Windows.Forms.BindingSource bsConfiguredTrucks;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.TextBox txtTruckRego;
        private System.Windows.Forms.Button btnFindTruck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter taConfiguredTrucks;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.TextBox txtVehicleDescription;
        private System.Windows.Forms.BindingSource bsConfiguredTruckGVM;
        private dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter taConfiguredTruckGVM;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox txtCardStatus;
        private System.Windows.Forms.CheckBox chkACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTrailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RegoCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PBS;
        private System.Windows.Forms.TextBox txtFeeCode;
        private System.Windows.Forms.TextBox txtFeeCodeConditions;
        private System.Windows.Forms.CheckBox chkDriverACC;
        private System.Windows.Forms.TextBox txtOkay2Cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicenseExp;
        private System.Windows.Forms.TextBox txtInductionExp;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.TextBox licenseTypeTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.Button btnGetDriver;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsTruckDriver;
        private dsQWSLocalTableAdapters.TruckDriverTableAdapter taTruckDriver;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCollected;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnRetare;
        private System.Windows.Forms.Button btnImported;
        private System.Windows.Forms.Button btnExBin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource bsPrefCustomers;
        private dsQWSLocalTableAdapters.VehiclePrefCustomersTableAdapter taPrefCustomers;
        private System.Windows.Forms.TextBox prefCustomerTextBox;
        private System.Windows.Forms.RadioButton rbTrailerOnly;
        private System.Windows.Forms.RadioButton rbSplitLoad;
        private System.Windows.Forms.RadioButton rbTnT;
        private System.Windows.Forms.TextBox compartmentsTextBox;
    }
}