﻿
namespace QWS_Local
{
    partial class BookInTruck
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
            System.Windows.Forms.Label cardStatusLabel;
            System.Windows.Forms.Label inductionExpLabel;
            System.Windows.Forms.Label licenseExpLabel;
            System.Windows.Forms.Label licenseTypeLabel;
            System.Windows.Forms.Label truckConfigLabel;
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.txtTruckRego = new System.Windows.Forms.TextBox();
            this.btnFindTruck = new System.Windows.Forms.Button();
            this.dgvConfiguredTrucks = new System.Windows.Forms.DataGridView();
            this.regoTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoTrailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nHVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.txtCardStatus = new System.Windows.Forms.TextBox();
            this.chkACCDelivery = new System.Windows.Forms.CheckBox();
            this.txtFeeCode = new System.Windows.Forms.TextBox();
            this.txtFeeCodeConditions = new System.Windows.Forms.TextBox();
            this.txtLicenseExp = new System.Windows.Forms.TextBox();
            this.bsTruckDriver = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.txtInductionExp = new System.Windows.Forms.TextBox();
            this.licenseTypeTextBox = new System.Windows.Forms.TextBox();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.btnGetDriver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.truckConfigTextBox = new System.Windows.Forms.TextBox();
            this.bsTIQ = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHold = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportedPickUp = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnRetare = new System.Windows.Forms.Button();
            this.btnImported = new System.Windows.Forms.Button();
            this.btnExBin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.taConfiguredTrucks = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.pictureSchematic = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager2 = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.txtTruckConfig = new System.Windows.Forms.TextBox();
            this.bsPrefCustomers2 = new System.Windows.Forms.BindingSource(this.components);
            this.taPrefCustomers2 = new QWS_Local.dsQWSLocal2024TableAdapters.VehiclePrefCustomersTableAdapter();
            this.tableAdapterManager3 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.taTruckDriver1 = new QWS_Local.dsQWSLocal2024TableAdapters.TruckDriverTableAdapter();
            this.taTIQ = new QWS_Local.dsTIQ2TableAdapters.TIQTableAdapter();
            this.gbSplitLoad = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.rbTrailerOnly = new System.Windows.Forms.RadioButton();
            this.rbTruckOnly = new System.Windows.Forms.RadioButton();
            this.rbSplitLoad = new System.Windows.Forms.RadioButton();
            this.rbTnT = new System.Windows.Forms.RadioButton();
            this.gbTruckOwner = new System.Windows.Forms.GroupBox();
            this.chkACCPickUp = new System.Windows.Forms.CheckBox();
            this.btnSessionID = new System.Windows.Forms.Button();
            this.btnSetTruckConfig = new System.Windows.Forms.Button();
            cardStatusLabel = new System.Windows.Forms.Label();
            inductionExpLabel = new System.Windows.Forms.Label();
            licenseExpLabel = new System.Windows.Forms.Label();
            licenseTypeLabel = new System.Windows.Forms.Label();
            truckConfigLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers2)).BeginInit();
            this.gbSplitLoad.SuspendLayout();
            this.gbTruckOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardStatusLabel
            // 
            cardStatusLabel.AutoSize = true;
            cardStatusLabel.Location = new System.Drawing.Point(11, 93);
            cardStatusLabel.Name = "cardStatusLabel";
            cardStatusLabel.Size = new System.Drawing.Size(86, 17);
            cardStatusLabel.TabIndex = 17;
            cardStatusLabel.Text = "Card Status:";
            // 
            // inductionExpLabel
            // 
            inductionExpLabel.AutoSize = true;
            inductionExpLabel.Location = new System.Drawing.Point(123, 165);
            inductionExpLabel.Name = "inductionExpLabel";
            inductionExpLabel.Size = new System.Drawing.Size(96, 17);
            inductionExpLabel.TabIndex = 70;
            inductionExpLabel.Text = "Induction Exp:";
            // 
            // licenseExpLabel
            // 
            licenseExpLabel.AutoSize = true;
            licenseExpLabel.Location = new System.Drawing.Point(131, 139);
            licenseExpLabel.Name = "licenseExpLabel";
            licenseExpLabel.Size = new System.Drawing.Size(88, 17);
            licenseExpLabel.TabIndex = 69;
            licenseExpLabel.Text = "License Exp:";
            // 
            // licenseTypeLabel
            // 
            licenseTypeLabel.AutoSize = true;
            licenseTypeLabel.Location = new System.Drawing.Point(122, 112);
            licenseTypeLabel.Name = "licenseTypeLabel";
            licenseTypeLabel.Size = new System.Drawing.Size(97, 17);
            licenseTypeLabel.TabIndex = 67;
            licenseTypeLabel.Text = "License Type:";
            // 
            // truckConfigLabel
            // 
            truckConfigLabel.AutoSize = true;
            truckConfigLabel.Location = new System.Drawing.Point(174, 172);
            truckConfigLabel.Name = "truckConfigLabel";
            truckConfigLabel.Size = new System.Drawing.Size(92, 17);
            truckConfigLabel.TabIndex = 62;
            truckConfigLabel.Text = "Truck Config:";
            // 
            // bsConfiguredTrucks
            // 
            this.bsConfiguredTrucks.DataMember = "ConfiguredTrucks";
            this.bsConfiguredTrucks.DataSource = this.dsTruckConfig;
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
            this.btnFindTruck.Size = new System.Drawing.Size(101, 27);
            this.btnFindTruck.TabIndex = 2;
            this.btnFindTruck.Text = "Find (F3)";
            this.btnFindTruck.UseVisualStyleBackColor = true;
            this.btnFindTruck.Click += new System.EventHandler(this.btnFindTruck_Click);
            // 
            // dgvConfiguredTrucks
            // 
            this.dgvConfiguredTrucks.AllowUserToAddRows = false;
            this.dgvConfiguredTrucks.AllowUserToDeleteRows = false;
            this.dgvConfiguredTrucks.AutoGenerateColumns = false;
            this.dgvConfiguredTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfiguredTrucks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoTkDataGridViewTextBoxColumn,
            this.regoTrailerDataGridViewTextBoxColumn,
            this.RegoCheck,
            this.nHVLDataGridViewTextBoxColumn,
            this.TareDT,
            this.VehicleType,
            this.TruckConfigID});
            this.dgvConfiguredTrucks.DataSource = this.bsConfiguredTrucks;
            this.dgvConfiguredTrucks.Location = new System.Drawing.Point(21, 250);
            this.dgvConfiguredTrucks.MultiSelect = false;
            this.dgvConfiguredTrucks.Name = "dgvConfiguredTrucks";
            this.dgvConfiguredTrucks.ReadOnly = true;
            this.dgvConfiguredTrucks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfiguredTrucks.Size = new System.Drawing.Size(979, 150);
            this.dgvConfiguredTrucks.TabIndex = 3;
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
            this.regoTrailerDataGridViewTextBoxColumn.Width = 150;
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
            this.nHVLDataGridViewTextBoxColumn.Width = 300;
            // 
            // TareDT
            // 
            this.TareDT.DataPropertyName = "TareDT";
            this.TareDT.HeaderText = "TareDT";
            this.TareDT.Name = "TareDT";
            this.TareDT.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "TruckConfig";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // TruckConfigID
            // 
            this.TruckConfigID.DataPropertyName = "TruckConfigID";
            this.TruckConfigID.HeaderText = "TruckConfigID";
            this.TruckConfigID.Name = "TruckConfigID";
            this.TruckConfigID.ReadOnly = true;
            this.TruckConfigID.Visible = false;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "AxleConfiguration", true));
            this.txtAxleConfig.Location = new System.Drawing.Point(63, 212);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.ReadOnly = true;
            this.txtAxleConfig.Size = new System.Drawing.Size(100, 23);
            this.txtAxleConfig.TabIndex = 4;
            // 
            // txtVehicleDescription
            // 
            this.txtVehicleDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "VehicleDescription", true));
            this.txtVehicleDescription.Location = new System.Drawing.Point(169, 212);
            this.txtVehicleDescription.Name = "txtVehicleDescription";
            this.txtVehicleDescription.ReadOnly = true;
            this.txtVehicleDescription.Size = new System.Drawing.Size(304, 23);
            this.txtVehicleDescription.TabIndex = 5;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(6, 51);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.ReadOnly = true;
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cardCodeTextBox.TabIndex = 10;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(6, 22);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.ReadOnly = true;
            this.truckOwnerTextBox.Size = new System.Drawing.Size(430, 23);
            this.truckOwnerTextBox.TabIndex = 12;
            // 
            // txtCardStatus
            // 
            this.txtCardStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "CardStatus", true));
            this.txtCardStatus.Location = new System.Drawing.Point(103, 90);
            this.txtCardStatus.Name = "txtCardStatus";
            this.txtCardStatus.ReadOnly = true;
            this.txtCardStatus.Size = new System.Drawing.Size(45, 23);
            this.txtCardStatus.TabIndex = 18;
            // 
            // chkACCDelivery
            // 
            this.chkACCDelivery.AutoSize = true;
            this.chkACCDelivery.Enabled = false;
            this.chkACCDelivery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkACCDelivery.Location = new System.Drawing.Point(326, 53);
            this.chkACCDelivery.Name = "chkACCDelivery";
            this.chkACCDelivery.Size = new System.Drawing.Size(110, 21);
            this.chkACCDelivery.TabIndex = 19;
            this.chkACCDelivery.Text = "ACC-Delivery";
            this.chkACCDelivery.UseVisualStyleBackColor = true;
            // 
            // txtFeeCode
            // 
            this.txtFeeCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "FeeCode", true));
            this.txtFeeCode.Location = new System.Drawing.Point(544, 212);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.ReadOnly = true;
            this.txtFeeCode.Size = new System.Drawing.Size(76, 23);
            this.txtFeeCode.TabIndex = 20;
            // 
            // txtFeeCodeConditions
            // 
            this.txtFeeCodeConditions.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "FeeConditions", true));
            this.txtFeeCodeConditions.Location = new System.Drawing.Point(626, 212);
            this.txtFeeCodeConditions.Name = "txtFeeCodeConditions";
            this.txtFeeCodeConditions.ReadOnly = true;
            this.txtFeeCodeConditions.Size = new System.Drawing.Size(374, 23);
            this.txtFeeCodeConditions.TabIndex = 21;
            // 
            // txtLicenseExp
            // 
            this.txtLicenseExp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "LicenseExp", true));
            this.txtLicenseExp.Location = new System.Drawing.Point(224, 135);
            this.txtLicenseExp.Name = "txtLicenseExp";
            this.txtLicenseExp.ReadOnly = true;
            this.txtLicenseExp.Size = new System.Drawing.Size(100, 23);
            this.txtLicenseExp.TabIndex = 74;
            // 
            // bsTruckDriver
            // 
            this.bsTruckDriver.DataMember = "TruckDriver";
            this.bsTruckDriver.DataSource = this.dsQWSLocal2024;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtInductionExp
            // 
            this.txtInductionExp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "InductionExp", true));
            this.txtInductionExp.Location = new System.Drawing.Point(224, 162);
            this.txtInductionExp.Name = "txtInductionExp";
            this.txtInductionExp.ReadOnly = true;
            this.txtInductionExp.Size = new System.Drawing.Size(100, 23);
            this.txtInductionExp.TabIndex = 73;
            // 
            // licenseTypeTextBox
            // 
            this.licenseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "LicenseType", true));
            this.licenseTypeTextBox.Location = new System.Drawing.Point(224, 109);
            this.licenseTypeTextBox.Name = "licenseTypeTextBox";
            this.licenseTypeTextBox.ReadOnly = true;
            this.licenseTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.licenseTypeTextBox.TabIndex = 68;
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(23, 79);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.ReadOnly = true;
            this.mobTextBox.Size = new System.Drawing.Size(100, 23);
            this.mobTextBox.TabIndex = 64;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(23, 50);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(258, 23);
            this.positionTextBox.TabIndex = 62;
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(23, 21);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.ReadOnly = true;
            this.personTextBox.Size = new System.Drawing.Size(194, 23);
            this.personTextBox.TabIndex = 61;
            // 
            // btnGetDriver
            // 
            this.btnGetDriver.Enabled = false;
            this.btnGetDriver.Location = new System.Drawing.Point(240, 21);
            this.btnGetDriver.Name = "btnGetDriver";
            this.btnGetDriver.Size = new System.Drawing.Size(84, 23);
            this.btnGetDriver.TabIndex = 58;
            this.btnGetDriver.Text = "Get";
            this.btnGetDriver.UseVisualStyleBackColor = true;
            this.btnGetDriver.Click += new System.EventHandler(this.btnGetDriver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(truckConfigLabel);
            this.groupBox1.Controls.Add(this.truckConfigTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHold);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnImportedPickUp);
            this.groupBox1.Controls.Add(this.btnDelivery);
            this.groupBox1.Controls.Add(this.btnRetare);
            this.groupBox1.Controls.Add(this.btnImported);
            this.groupBox1.Controls.Add(this.btnExBin);
            this.groupBox1.Location = new System.Drawing.Point(398, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 223);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book In Mode";
            // 
            // truckConfigTextBox
            // 
            this.truckConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckConfig", true));
            this.truckConfigTextBox.Location = new System.Drawing.Point(272, 169);
            this.truckConfigTextBox.Name = "truckConfigTextBox";
            this.truckConfigTextBox.ReadOnly = true;
            this.truckConfigTextBox.Size = new System.Drawing.Size(100, 23);
            this.truckConfigTextBox.TabIndex = 63;
            // 
            // bsTIQ
            // 
            this.bsTIQ.DataMember = "TIQ";
            this.bsTIQ.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Admin";
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.SystemColors.Control;
            this.btnHold.Enabled = false;
            this.btnHold.Location = new System.Drawing.Point(18, 120);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(110, 38);
            this.btnHold.TabIndex = 61;
            this.btnHold.Text = "Hold - park up.";
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Inbound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Outbound";
            // 
            // btnImportedPickUp
            // 
            this.btnImportedPickUp.Enabled = false;
            this.btnImportedPickUp.Location = new System.Drawing.Point(140, 120);
            this.btnImportedPickUp.Name = "btnImportedPickUp";
            this.btnImportedPickUp.Size = new System.Drawing.Size(110, 38);
            this.btnImportedPickUp.TabIndex = 58;
            this.btnImportedPickUp.Text = "Pick Up";
            this.btnImportedPickUp.UseVisualStyleBackColor = true;
            this.btnImportedPickUp.Click += new System.EventHandler(this.btnImportedPickUp_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Enabled = false;
            this.btnDelivery.Location = new System.Drawing.Point(262, 120);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(110, 38);
            this.btnDelivery.TabIndex = 57;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnRetare
            // 
            this.btnRetare.BackColor = System.Drawing.SystemColors.Control;
            this.btnRetare.Enabled = false;
            this.btnRetare.Location = new System.Drawing.Point(18, 59);
            this.btnRetare.Name = "btnRetare";
            this.btnRetare.Size = new System.Drawing.Size(110, 38);
            this.btnRetare.TabIndex = 56;
            this.btnRetare.Text = "Retare";
            this.btnRetare.UseVisualStyleBackColor = false;
            this.btnRetare.Click += new System.EventHandler(this.btnRetare_Click);
            // 
            // btnImported
            // 
            this.btnImported.Enabled = false;
            this.btnImported.Location = new System.Drawing.Point(140, 59);
            this.btnImported.Name = "btnImported";
            this.btnImported.Size = new System.Drawing.Size(110, 38);
            this.btnImported.TabIndex = 55;
            this.btnImported.Text = "Imported";
            this.btnImported.UseVisualStyleBackColor = true;
            this.btnImported.Click += new System.EventHandler(this.btnImported_Click);
            // 
            // btnExBin
            // 
            this.btnExBin.Enabled = false;
            this.btnExBin.Location = new System.Drawing.Point(262, 59);
            this.btnExBin.Name = "btnExBin";
            this.btnExBin.Size = new System.Drawing.Size(110, 38);
            this.btnExBin.TabIndex = 54;
            this.btnExBin.Text = "Ex Bin";
            this.btnExBin.UseVisualStyleBackColor = true;
            this.btnExBin.Click += new System.EventHandler(this.btnExBin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.personTextBox);
            this.groupBox3.Controls.Add(this.btnGetDriver);
            this.groupBox3.Controls.Add(this.positionTextBox);
            this.groupBox3.Controls.Add(this.mobTextBox);
            this.groupBox3.Controls.Add(this.txtLicenseExp);
            this.groupBox3.Controls.Add(this.txtInductionExp);
            this.groupBox3.Controls.Add(this.licenseTypeTextBox);
            this.groupBox3.Controls.Add(inductionExpLabel);
            this.groupBox3.Controls.Add(licenseTypeLabel);
            this.groupBox3.Controls.Add(licenseExpLabel);
            this.groupBox3.Location = new System.Drawing.Point(21, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 200);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Truck Driver";
            // 
            // taConfiguredTrucks
            // 
            this.taConfiguredTrucks.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.StockpileBOMTableAdapter = null;
            this.tableAdapterManager2.StockpileLotAllocationTableAdapter = null;
            this.tableAdapterManager2.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager2.TIQTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager2.WBDocketsTableAdapter = null;
            // 
            // txtTruckConfig
            // 
            this.txtTruckConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "VehicleType", true));
            this.txtTruckConfig.Location = new System.Drawing.Point(480, 212);
            this.txtTruckConfig.Name = "txtTruckConfig";
            this.txtTruckConfig.ReadOnly = true;
            this.txtTruckConfig.Size = new System.Drawing.Size(33, 23);
            this.txtTruckConfig.TabIndex = 81;
            // 
            // bsPrefCustomers2
            // 
            this.bsPrefCustomers2.DataMember = "VehiclePrefCustomers";
            this.bsPrefCustomers2.DataSource = this.dsQWSLocal2024;
            // 
            // taPrefCustomers2
            // 
            this.taPrefCustomers2.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.NHVRTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager3.VehiclePBSTableAdapter = null;
            this.tableAdapterManager3.VehiclePrefCustomersTableAdapter = this.taPrefCustomers2;
            this.tableAdapterManager3.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager3.VehicleTableAdapter = null;
            // 
            // taTruckDriver1
            // 
            this.taTruckDriver1.ClearBeforeFill = true;
            // 
            // taTIQ
            // 
            this.taTIQ.ClearBeforeFill = true;
            // 
            // gbSplitLoad
            // 
            this.gbSplitLoad.Controls.Add(this.btnContinue);
            this.gbSplitLoad.Controls.Add(this.rbTrailerOnly);
            this.gbSplitLoad.Controls.Add(this.rbTruckOnly);
            this.gbSplitLoad.Controls.Add(this.rbSplitLoad);
            this.gbSplitLoad.Controls.Add(this.rbTnT);
            this.gbSplitLoad.Enabled = false;
            this.gbSplitLoad.Location = new System.Drawing.Point(813, 427);
            this.gbSplitLoad.Name = "gbSplitLoad";
            this.gbSplitLoad.Size = new System.Drawing.Size(186, 200);
            this.gbSplitLoad.TabIndex = 82;
            this.gbSplitLoad.TabStop = false;
            this.gbSplitLoad.Text = "Truck Config";
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(32, 154);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(110, 38);
            this.btnContinue.TabIndex = 63;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // rbTrailerOnly
            // 
            this.rbTrailerOnly.AutoSize = true;
            this.rbTrailerOnly.Location = new System.Drawing.Point(32, 123);
            this.rbTrailerOnly.Name = "rbTrailerOnly";
            this.rbTrailerOnly.Size = new System.Drawing.Size(100, 21);
            this.rbTrailerOnly.TabIndex = 3;
            this.rbTrailerOnly.TabStop = true;
            this.rbTrailerOnly.Text = "Trailer Only";
            this.rbTrailerOnly.UseVisualStyleBackColor = true;
            this.rbTrailerOnly.CheckedChanged += new System.EventHandler(this.rbTrailerOnly_CheckedChanged);
            // 
            // rbTruckOnly
            // 
            this.rbTruckOnly.AutoSize = true;
            this.rbTruckOnly.Location = new System.Drawing.Point(32, 92);
            this.rbTruckOnly.Name = "rbTruckOnly";
            this.rbTruckOnly.Size = new System.Drawing.Size(95, 21);
            this.rbTruckOnly.TabIndex = 2;
            this.rbTruckOnly.TabStop = true;
            this.rbTruckOnly.Text = "Truck Only";
            this.rbTruckOnly.UseVisualStyleBackColor = true;
            this.rbTruckOnly.CheckedChanged += new System.EventHandler(this.rbTruckOnly_CheckedChanged);
            // 
            // rbSplitLoad
            // 
            this.rbSplitLoad.AutoSize = true;
            this.rbSplitLoad.Location = new System.Drawing.Point(32, 61);
            this.rbSplitLoad.Name = "rbSplitLoad";
            this.rbSplitLoad.Size = new System.Drawing.Size(89, 21);
            this.rbSplitLoad.TabIndex = 1;
            this.rbSplitLoad.TabStop = true;
            this.rbSplitLoad.Text = "Split Load";
            this.rbSplitLoad.UseVisualStyleBackColor = true;
            this.rbSplitLoad.CheckedChanged += new System.EventHandler(this.rbSplitLoad_CheckedChanged);
            // 
            // rbTnT
            // 
            this.rbTnT.AutoSize = true;
            this.rbTnT.Location = new System.Drawing.Point(32, 30);
            this.rbTnT.Name = "rbTnT";
            this.rbTnT.Size = new System.Drawing.Size(135, 21);
            this.rbTnT.TabIndex = 0;
            this.rbTnT.TabStop = true;
            this.rbTnT.Text = "Truck and Trailer";
            this.rbTnT.UseVisualStyleBackColor = true;
            this.rbTnT.CheckedChanged += new System.EventHandler(this.rbTnT_CheckedChanged);
            // 
            // gbTruckOwner
            // 
            this.gbTruckOwner.Controls.Add(this.chkACCPickUp);
            this.gbTruckOwner.Controls.Add(this.cardCodeTextBox);
            this.gbTruckOwner.Controls.Add(this.truckOwnerTextBox);
            this.gbTruckOwner.Controls.Add(this.chkACCDelivery);
            this.gbTruckOwner.Controls.Add(this.txtCardStatus);
            this.gbTruckOwner.Controls.Add(cardStatusLabel);
            this.gbTruckOwner.Location = new System.Drawing.Point(544, 56);
            this.gbTruckOwner.Name = "gbTruckOwner";
            this.gbTruckOwner.Size = new System.Drawing.Size(455, 119);
            this.gbTruckOwner.TabIndex = 83;
            this.gbTruckOwner.TabStop = false;
            this.gbTruckOwner.Text = "Truck Owner";
            // 
            // chkACCPickUp
            // 
            this.chkACCPickUp.AutoSize = true;
            this.chkACCPickUp.Enabled = false;
            this.chkACCPickUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkACCPickUp.Location = new System.Drawing.Point(326, 92);
            this.chkACCPickUp.Name = "chkACCPickUp";
            this.chkACCPickUp.Size = new System.Drawing.Size(103, 21);
            this.chkACCPickUp.TabIndex = 20;
            this.chkACCPickUp.Text = "ACC-PickUp";
            this.chkACCPickUp.UseVisualStyleBackColor = true;
            // 
            // btnSessionID
            // 
            this.btnSessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionID.Location = new System.Drawing.Point(325, 22);
            this.btnSessionID.Name = "btnSessionID";
            this.btnSessionID.Size = new System.Drawing.Size(101, 27);
            this.btnSessionID.TabIndex = 84;
            this.btnSessionID.Text = "Session ID";
            this.btnSessionID.UseVisualStyleBackColor = true;
            this.btnSessionID.Click += new System.EventHandler(this.btnSessionID_Click);
            // 
            // btnSetTruckConfig
            // 
            this.btnSetTruckConfig.Location = new System.Drawing.Point(156, 406);
            this.btnSetTruckConfig.Name = "btnSetTruckConfig";
            this.btnSetTruckConfig.Size = new System.Drawing.Size(84, 23);
            this.btnSetTruckConfig.TabIndex = 85;
            this.btnSetTruckConfig.Text = "Set";
            this.btnSetTruckConfig.UseVisualStyleBackColor = true;
            this.btnSetTruckConfig.Click += new System.EventHandler(this.btnSetTruckConfig_Click);
            // 
            // BookInTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.btnSetTruckConfig);
            this.Controls.Add(this.btnSessionID);
            this.Controls.Add(this.gbTruckOwner);
            this.Controls.Add(this.gbSplitLoad);
            this.Controls.Add(this.txtTruckConfig);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFeeCodeConditions);
            this.Controls.Add(this.txtFeeCode);
            this.Controls.Add(this.txtVehicleDescription);
            this.Controls.Add(this.txtAxleConfig);
            this.Controls.Add(this.dgvConfiguredTrucks);
            this.Controls.Add(this.btnFindTruck);
            this.Controls.Add(this.txtTruckRego);
            this.Controls.Add(this.pictureSchematic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookInTruck";
            this.Text = "Book In Truck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookInTruck_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookInTruck_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers2)).EndInit();
            this.gbSplitLoad.ResumeLayout(false);
            this.gbSplitLoad.PerformLayout();
            this.gbTruckOwner.ResumeLayout(false);
            this.gbTruckOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSchematic;
        private System.Windows.Forms.BindingSource bsConfiguredTrucks;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.TextBox txtTruckRego;
        private System.Windows.Forms.Button btnFindTruck;
        private System.Windows.Forms.DataGridView dgvConfiguredTrucks;
        private dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter taConfiguredTrucks;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.TextBox txtVehicleDescription;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox txtCardStatus;
        private System.Windows.Forms.CheckBox chkACCDelivery;
        private System.Windows.Forms.TextBox txtFeeCode;
        private System.Windows.Forms.TextBox txtFeeCodeConditions;
        private System.Windows.Forms.TextBox txtLicenseExp;
        private System.Windows.Forms.TextBox txtInductionExp;
        private System.Windows.Forms.TextBox licenseTypeTextBox;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.Button btnGetDriver;
        private System.Windows.Forms.BindingSource bsTruckDriver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportedPickUp;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnRetare;
        private System.Windows.Forms.Button btnImported;
        private System.Windows.Forms.Button btnExBin;
        private System.Windows.Forms.GroupBox groupBox3;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TextBox txtTruckConfig;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Label label1;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsPrefCustomers2;
        private dsQWSLocal2024TableAdapters.VehiclePrefCustomersTableAdapter taPrefCustomers2;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager3;
        private dsQWSLocal2024TableAdapters.TruckDriverTableAdapter taTruckDriver1;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsTIQ;
        private dsTIQ2TableAdapters.TIQTableAdapter taTIQ;
        private System.Windows.Forms.GroupBox gbSplitLoad;
        private System.Windows.Forms.RadioButton rbTrailerOnly;
        private System.Windows.Forms.RadioButton rbTruckOnly;
        private System.Windows.Forms.RadioButton rbSplitLoad;
        private System.Windows.Forms.RadioButton rbTnT;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.GroupBox gbTruckOwner;
        private System.Windows.Forms.CheckBox chkACCPickUp;
        private System.Windows.Forms.Button btnSessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTrailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RegoCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckConfigID;
        private System.Windows.Forms.Button btnSetTruckConfig;
        private System.Windows.Forms.TextBox truckConfigTextBox;
    }
}