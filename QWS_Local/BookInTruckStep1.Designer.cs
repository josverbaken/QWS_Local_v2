
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
            System.Windows.Forms.Label inductionExpLabel;
            System.Windows.Forms.Label licenseExpLabel;
            System.Windows.Forms.Label licenseTypeLabel;
            System.Windows.Forms.Label mobLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label personLabel;
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.txtTruckRego = new System.Windows.Forms.TextBox();
            this.btnFindTruck = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regoTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoTrailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nHVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.txtCardStatus = new System.Windows.Forms.TextBox();
            this.chkACC = new System.Windows.Forms.CheckBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHold = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCollected = new System.Windows.Forms.Button();
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
            this.btnNext = new System.Windows.Forms.Button();
            this.bsPrefCustomers2 = new System.Windows.Forms.BindingSource(this.components);
            this.taPrefCustomers2 = new QWS_Local.dsQWSLocal2024TableAdapters.VehiclePrefCustomersTableAdapter();
            this.tableAdapterManager3 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.taTruckDriver1 = new QWS_Local.dsQWSLocal2024TableAdapters.TruckDriverTableAdapter();
            cardCodeLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            cardStatusLabel = new System.Windows.Forms.Label();
            inductionExpLabel = new System.Windows.Forms.Label();
            licenseExpLabel = new System.Windows.Forms.Label();
            licenseTypeLabel = new System.Windows.Forms.Label();
            mobLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            personLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers2)).BeginInit();
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
            // mobLabel
            // 
            mobLabel.AutoSize = true;
            mobLabel.Location = new System.Drawing.Point(74, 85);
            mobLabel.Name = "mobLabel";
            mobLabel.Size = new System.Drawing.Size(39, 17);
            mobLabel.TabIndex = 63;
            mobLabel.Text = "Mob:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(60, 56);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(62, 17);
            positionLabel.TabIndex = 60;
            positionLabel.Text = "Position:";
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(65, 24);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(57, 17);
            personLabel.TabIndex = 59;
            personLabel.Text = "Person:";
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
            this.TareDT});
            this.dataGridView1.DataSource = this.bsConfiguredTrucks;
            this.dataGridView1.Location = new System.Drawing.Point(21, 250);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(979, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
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
            this.txtVehicleDescription.Size = new System.Drawing.Size(304, 23);
            this.txtVehicleDescription.TabIndex = 5;
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
            this.txtInductionExp.Location = new System.Drawing.Point(127, 164);
            this.txtInductionExp.Name = "txtInductionExp";
            this.txtInductionExp.Size = new System.Drawing.Size(100, 23);
            this.txtInductionExp.TabIndex = 73;
            // 
            // licenseTypeTextBox
            // 
            this.licenseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "LicenseType", true));
            this.licenseTypeTextBox.Location = new System.Drawing.Point(127, 111);
            this.licenseTypeTextBox.Name = "licenseTypeTextBox";
            this.licenseTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.licenseTypeTextBox.TabIndex = 68;
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(127, 82);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.Size = new System.Drawing.Size(100, 23);
            this.mobTextBox.TabIndex = 64;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(127, 53);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(258, 23);
            this.positionTextBox.TabIndex = 62;
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(127, 24);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(156, 23);
            this.personTextBox.TabIndex = 61;
            // 
            // btnGetDriver
            // 
            this.btnGetDriver.Location = new System.Drawing.Point(301, 24);
            this.btnGetDriver.Name = "btnGetDriver";
            this.btnGetDriver.Size = new System.Drawing.Size(84, 23);
            this.btnGetDriver.TabIndex = 58;
            this.btnGetDriver.Text = "Get";
            this.btnGetDriver.UseVisualStyleBackColor = true;
            this.btnGetDriver.Click += new System.EventHandler(this.btnGetDriver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHold);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCollected);
            this.groupBox1.Controls.Add(this.btnDelivery);
            this.groupBox1.Controls.Add(this.btnRetare);
            this.groupBox1.Controls.Add(this.btnImported);
            this.groupBox1.Controls.Add(this.btnExBin);
            this.groupBox1.Location = new System.Drawing.Point(582, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 200);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book In Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Admin";
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.SystemColors.Control;
            this.btnHold.Location = new System.Drawing.Point(272, 103);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(121, 38);
            this.btnHold.TabIndex = 61;
            this.btnHold.Text = "Hold - park up.";
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
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
            this.btnRetare.BackColor = System.Drawing.SystemColors.Control;
            this.btnRetare.Enabled = false;
            this.btnRetare.Location = new System.Drawing.Point(272, 60);
            this.btnRetare.Name = "btnRetare";
            this.btnRetare.Size = new System.Drawing.Size(121, 38);
            this.btnRetare.TabIndex = 56;
            this.btnRetare.Text = "Retare";
            this.btnRetare.UseVisualStyleBackColor = false;
            this.btnRetare.Click += new System.EventHandler(this.btnRetare_Click);
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
            this.btnImported.Click += new System.EventHandler(this.btnImported_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.personTextBox);
            this.groupBox3.Controls.Add(this.btnGetDriver);
            this.groupBox3.Controls.Add(personLabel);
            this.groupBox3.Controls.Add(this.positionTextBox);
            this.groupBox3.Controls.Add(positionLabel);
            this.groupBox3.Controls.Add(this.mobTextBox);
            this.groupBox3.Controls.Add(this.txtLicenseExp);
            this.groupBox3.Controls.Add(mobLabel);
            this.groupBox3.Controls.Add(this.txtInductionExp);
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
            this.txtTruckConfig.Size = new System.Drawing.Size(33, 23);
            this.txtTruckConfig.TabIndex = 81;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(322, 406);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 23);
            this.btnNext.TabIndex = 75;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            // BookInTruckStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtTruckConfig);
            this.Controls.Add(this.groupBox3);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookInTruckStep1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers2)).EndInit();
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
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox txtCardStatus;
        private System.Windows.Forms.CheckBox chkACC;
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
        private System.Windows.Forms.Button btnCollected;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnRetare;
        private System.Windows.Forms.Button btnImported;
        private System.Windows.Forms.Button btnExBin;
        private System.Windows.Forms.GroupBox groupBox3;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTrailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RegoCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareDT;
        private System.Windows.Forms.TextBox txtTruckConfig;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsPrefCustomers2;
        private dsQWSLocal2024TableAdapters.VehiclePrefCustomersTableAdapter taPrefCustomers2;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager3;
        private dsQWSLocal2024TableAdapters.TruckDriverTableAdapter taTruckDriver1;
    }
}