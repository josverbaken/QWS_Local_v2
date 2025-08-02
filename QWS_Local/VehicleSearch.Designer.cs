
namespace QWS_Local
{
    partial class VehicleSearch
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
            System.Windows.Forms.Label regoLabel;
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label cardCodeLabel;
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label axleConfigurationLabel;
            System.Windows.Forms.Label massAccreditationLabelLabel;
            System.Windows.Forms.Label registeredTareLabel;
            System.Windows.Forms.Label feeCodeLabel;
            System.Windows.Forms.Label jurisdictionLabel;
            System.Windows.Forms.Label feeTypeLabel;
            System.Windows.Forms.Label feeConditionsLabel;
            System.Windows.Forms.Label registrationExpDTLabel;
            System.Windows.Forms.Label isLeadVehicleLabel;
            System.Windows.Forms.Label vehicleDescriptionLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label createDTTMLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.rbRego = new System.Windows.Forms.RadioButton();
            this.rbCardCode = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAxleConfig = new System.Windows.Forms.RadioButton();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.rbTrailers = new System.Windows.Forms.RadioButton();
            this.rbTrucks = new System.Windows.Forms.RadioButton();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.createDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.vehicleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.isLeadVehicleCheckBox = new System.Windows.Forms.CheckBox();
            this.registrationExpDTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.feeConditionsTextBox = new System.Windows.Forms.TextBox();
            this.feeTypeTextBox = new System.Windows.Forms.TextBox();
            this.jurisdictionTextBox = new System.Windows.Forms.TextBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.registeredTareTextBox = new System.Windows.Forms.TextBox();
            this.massAccreditationLabelTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.bsVehicleDetails2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.taVehicleDetails2 = new QWS_Local.dsQWSLocal2024TableAdapters.VehicleDetailsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.txtboxcolumnRego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schematic = new System.Windows.Forms.DataGridViewImageColumn();
            this.FeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regoLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            cardCodeLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            massAccreditationLabelLabel = new System.Windows.Forms.Label();
            registeredTareLabel = new System.Windows.Forms.Label();
            feeCodeLabel = new System.Windows.Forms.Label();
            jurisdictionLabel = new System.Windows.Forms.Label();
            feeTypeLabel = new System.Windows.Forms.Label();
            feeConditionsLabel = new System.Windows.Forms.Label();
            registrationExpDTLabel = new System.Windows.Forms.Label();
            isLeadVehicleLabel = new System.Windows.Forms.Label();
            vehicleDescriptionLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            createDTTMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            this.SuspendLayout();
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(105, 50);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(48, 18);
            regoLabel.TabIndex = 0;
            regoLabel.Text = "Rego:";
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(374, 50);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(35, 18);
            vINLabel.TabIndex = 2;
            vINLabel.Text = "VIN:";
            // 
            // cardCodeLabel
            // 
            cardCodeLabel.AutoSize = true;
            cardCodeLabel.Location = new System.Drawing.Point(69, 80);
            cardCodeLabel.Name = "cardCodeLabel";
            cardCodeLabel.Size = new System.Drawing.Size(84, 18);
            cardCodeLabel.TabIndex = 4;
            cardCodeLabel.Text = "Card Code:";
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(353, 77);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(56, 18);
            ownerLabel.TabIndex = 6;
            ownerLabel.Text = "Owner:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(104, 110);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(49, 18);
            makeLabel.TabIndex = 8;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(100, 140);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(53, 18);
            modelLabel.TabIndex = 10;
            modelLabel.Text = "Model:";
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(278, 107);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(131, 18);
            axleConfigurationLabel.TabIndex = 12;
            axleConfigurationLabel.Text = "Axle Configuration:";
            // 
            // massAccreditationLabelLabel
            // 
            massAccreditationLabelLabel.AutoSize = true;
            massAccreditationLabelLabel.Location = new System.Drawing.Point(19, 170);
            massAccreditationLabelLabel.Name = "massAccreditationLabelLabel";
            massAccreditationLabelLabel.Size = new System.Drawing.Size(134, 18);
            massAccreditationLabelLabel.TabIndex = 14;
            massAccreditationLabelLabel.Text = "Mass Accreditation";
            // 
            // registeredTareLabel
            // 
            registeredTareLabel.AutoSize = true;
            registeredTareLabel.Location = new System.Drawing.Point(36, 200);
            registeredTareLabel.Name = "registeredTareLabel";
            registeredTareLabel.Size = new System.Drawing.Size(117, 18);
            registeredTareLabel.TabIndex = 16;
            registeredTareLabel.Text = "Registered Tare:";
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(76, 230);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(77, 18);
            feeCodeLabel.TabIndex = 18;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // jurisdictionLabel
            // 
            jurisdictionLabel.AutoSize = true;
            jurisdictionLabel.Location = new System.Drawing.Point(322, 230);
            jurisdictionLabel.Name = "jurisdictionLabel";
            jurisdictionLabel.Size = new System.Drawing.Size(87, 18);
            jurisdictionLabel.TabIndex = 20;
            jurisdictionLabel.Text = "Jurisdiction:";
            // 
            // feeTypeLabel
            // 
            feeTypeLabel.AutoSize = true;
            feeTypeLabel.Location = new System.Drawing.Point(80, 260);
            feeTypeLabel.Name = "feeTypeLabel";
            feeTypeLabel.Size = new System.Drawing.Size(73, 18);
            feeTypeLabel.TabIndex = 22;
            feeTypeLabel.Text = "Fee Type:";
            // 
            // feeConditionsLabel
            // 
            feeConditionsLabel.AutoSize = true;
            feeConditionsLabel.Location = new System.Drawing.Point(41, 290);
            feeConditionsLabel.Name = "feeConditionsLabel";
            feeConditionsLabel.Size = new System.Drawing.Size(112, 18);
            feeConditionsLabel.TabIndex = 24;
            feeConditionsLabel.Text = "Fee Conditions:";
            // 
            // registrationExpDTLabel
            // 
            registrationExpDTLabel.AutoSize = true;
            registrationExpDTLabel.Location = new System.Drawing.Point(9, 321);
            registrationExpDTLabel.Name = "registrationExpDTLabel";
            registrationExpDTLabel.Size = new System.Drawing.Size(144, 18);
            registrationExpDTLabel.TabIndex = 26;
            registrationExpDTLabel.Text = "Registration Exp DT:";
            // 
            // isLeadVehicleLabel
            // 
            isLeadVehicleLabel.AutoSize = true;
            isLeadVehicleLabel.Location = new System.Drawing.Point(299, 140);
            isLeadVehicleLabel.Name = "isLeadVehicleLabel";
            isLeadVehicleLabel.Size = new System.Drawing.Size(110, 18);
            isLeadVehicleLabel.TabIndex = 28;
            isLeadVehicleLabel.Text = "Is Lead Vehicle:";
            // 
            // vehicleDescriptionLabel
            // 
            vehicleDescriptionLabel.AutoSize = true;
            vehicleDescriptionLabel.Location = new System.Drawing.Point(15, 350);
            vehicleDescriptionLabel.Name = "vehicleDescriptionLabel";
            vehicleDescriptionLabel.Size = new System.Drawing.Size(138, 18);
            vehicleDescriptionLabel.TabIndex = 30;
            vehicleDescriptionLabel.Text = "Vehicle Description:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(354, 172);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(51, 18);
            activeLabel.TabIndex = 32;
            activeLabel.Text = "Active:";
            // 
            // createDTTMLabel
            // 
            createDTTMLabel.AutoSize = true;
            createDTTMLabel.Location = new System.Drawing.Point(51, 381);
            createDTTMLabel.Name = "createDTTMLabel";
            createDTTMLabel.Size = new System.Drawing.Size(102, 18);
            createDTTMLabel.TabIndex = 34;
            createDTTMLabel.Text = "Create DTTM:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblSearchInfo);
            this.splitContainer1.Panel1.Controls.Add(this.rbRego);
            this.splitContainer1.Panel1.Controls.Add(this.rbCardCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnFind);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1331, 623);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Location = new System.Drawing.Point(62, 202);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(12, 18);
            this.lblSearchInfo.TabIndex = 10;
            this.lblSearchInfo.Text = " ";
            // 
            // rbRego
            // 
            this.rbRego.AutoSize = true;
            this.rbRego.Checked = true;
            this.rbRego.Location = new System.Drawing.Point(78, 86);
            this.rbRego.Name = "rbRego";
            this.rbRego.Size = new System.Drawing.Size(62, 22);
            this.rbRego.TabIndex = 9;
            this.rbRego.TabStop = true;
            this.rbRego.Text = "Rego";
            this.rbRego.UseVisualStyleBackColor = true;
            // 
            // rbCardCode
            // 
            this.rbCardCode.AutoSize = true;
            this.rbCardCode.Location = new System.Drawing.Point(78, 114);
            this.rbCardCode.Name = "rbCardCode";
            this.rbCardCode.Size = new System.Drawing.Size(94, 22);
            this.rbCardCode.TabIndex = 8;
            this.rbCardCode.Text = "CardCode";
            this.rbCardCode.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(62, 151);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(147, 44);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find (F3)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(62, 295);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(147, 34);
            this.btnSelect1.TabIndex = 6;
            this.btnSelect1.Text = "Select";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAxleConfig);
            this.groupBox1.Controls.Add(this.txtAxleConfig);
            this.groupBox1.Controls.Add(this.rbClear);
            this.groupBox1.Controls.Add(this.rbTrailers);
            this.groupBox1.Controls.Add(this.rbTrucks);
            this.groupBox1.Location = new System.Drawing.Point(33, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // rbAxleConfig
            // 
            this.rbAxleConfig.AutoSize = true;
            this.rbAxleConfig.Location = new System.Drawing.Point(29, 64);
            this.rbAxleConfig.Name = "rbAxleConfig";
            this.rbAxleConfig.Size = new System.Drawing.Size(100, 22);
            this.rbAxleConfig.TabIndex = 11;
            this.rbAxleConfig.TabStop = true;
            this.rbAxleConfig.Text = "Axle Config";
            this.rbAxleConfig.UseVisualStyleBackColor = true;
            this.rbAxleConfig.CheckedChanged += new System.EventHandler(this.rbAxleConfig_CheckedChanged);
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.Location = new System.Drawing.Point(29, 34);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.Size = new System.Drawing.Size(100, 24);
            this.txtAxleConfig.TabIndex = 10;
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(29, 192);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(61, 22);
            this.rbClear.TabIndex = 4;
            this.rbClear.TabStop = true;
            this.rbClear.Text = "Clear";
            this.rbClear.UseVisualStyleBackColor = true;
            this.rbClear.CheckedChanged += new System.EventHandler(this.rbClear_CheckedChanged);
            // 
            // rbTrailers
            // 
            this.rbTrailers.AutoSize = true;
            this.rbTrailers.Location = new System.Drawing.Point(29, 146);
            this.rbTrailers.Name = "rbTrailers";
            this.rbTrailers.Size = new System.Drawing.Size(75, 22);
            this.rbTrailers.TabIndex = 3;
            this.rbTrailers.TabStop = true;
            this.rbTrailers.Text = "Trailers";
            this.rbTrailers.UseVisualStyleBackColor = true;
            this.rbTrailers.CheckedChanged += new System.EventHandler(this.rbTrailers_CheckedChanged);
            // 
            // rbTrucks
            // 
            this.rbTrucks.AutoSize = true;
            this.rbTrucks.Location = new System.Drawing.Point(29, 106);
            this.rbTrucks.Name = "rbTrucks";
            this.rbTrucks.Size = new System.Drawing.Size(72, 22);
            this.rbTrucks.TabIndex = 2;
            this.rbTrucks.TabStop = true;
            this.rbTrucks.Text = "Trucks";
            this.rbTrucks.UseVisualStyleBackColor = true;
            this.rbTrucks.CheckedChanged += new System.EventHandler(this.rbTrucks_CheckedChanged);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(78, 56);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(100, 24);
            this.txtSearch1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 623);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.vehicleDataGridView);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(1056, 592);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AllowUserToAddRows = false;
            this.vehicleDataGridView.AllowUserToDeleteRows = false;
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtboxcolumnRego,
            this.TruckOwner,
            this.Schematic,
            this.FeeCode});
            this.vehicleDataGridView.DataSource = this.bsVehicleDetails2;
            this.vehicleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleDataGridView.Location = new System.Drawing.Point(3, 3);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.ReadOnly = true;
            this.vehicleDataGridView.RowTemplate.Height = 150;
            this.vehicleDataGridView.Size = new System.Drawing.Size(1050, 586);
            this.vehicleDataGridView.TabIndex = 0;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(createDTTMLabel);
            this.tpDetails.Controls.Add(this.createDTTMDateTimePicker);
            this.tpDetails.Controls.Add(activeLabel);
            this.tpDetails.Controls.Add(this.activeCheckBox);
            this.tpDetails.Controls.Add(vehicleDescriptionLabel);
            this.tpDetails.Controls.Add(this.vehicleDescriptionTextBox);
            this.tpDetails.Controls.Add(isLeadVehicleLabel);
            this.tpDetails.Controls.Add(this.isLeadVehicleCheckBox);
            this.tpDetails.Controls.Add(registrationExpDTLabel);
            this.tpDetails.Controls.Add(this.registrationExpDTDateTimePicker);
            this.tpDetails.Controls.Add(feeConditionsLabel);
            this.tpDetails.Controls.Add(this.feeConditionsTextBox);
            this.tpDetails.Controls.Add(feeTypeLabel);
            this.tpDetails.Controls.Add(this.feeTypeTextBox);
            this.tpDetails.Controls.Add(jurisdictionLabel);
            this.tpDetails.Controls.Add(this.jurisdictionTextBox);
            this.tpDetails.Controls.Add(feeCodeLabel);
            this.tpDetails.Controls.Add(this.feeCodeTextBox);
            this.tpDetails.Controls.Add(registeredTareLabel);
            this.tpDetails.Controls.Add(this.registeredTareTextBox);
            this.tpDetails.Controls.Add(massAccreditationLabelLabel);
            this.tpDetails.Controls.Add(this.massAccreditationLabelTextBox);
            this.tpDetails.Controls.Add(axleConfigurationLabel);
            this.tpDetails.Controls.Add(this.axleConfigurationTextBox);
            this.tpDetails.Controls.Add(modelLabel);
            this.tpDetails.Controls.Add(this.modelTextBox);
            this.tpDetails.Controls.Add(makeLabel);
            this.tpDetails.Controls.Add(this.makeTextBox);
            this.tpDetails.Controls.Add(ownerLabel);
            this.tpDetails.Controls.Add(this.ownerTextBox);
            this.tpDetails.Controls.Add(cardCodeLabel);
            this.tpDetails.Controls.Add(this.cardCodeTextBox);
            this.tpDetails.Controls.Add(vINLabel);
            this.tpDetails.Controls.Add(this.vINTextBox);
            this.tpDetails.Controls.Add(regoLabel);
            this.tpDetails.Controls.Add(this.regoTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 27);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1056, 592);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // createDTTMDateTimePicker
            // 
            this.createDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsVehicleDetails2, "CreateDTTM", true));
            this.createDTTMDateTimePicker.Location = new System.Drawing.Point(159, 377);
            this.createDTTMDateTimePicker.Name = "createDTTMDateTimePicker";
            this.createDTTMDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.createDTTMDateTimePicker.TabIndex = 35;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsVehicleDetails2, "Active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(411, 167);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activeCheckBox.TabIndex = 33;
            this.activeCheckBox.Text = "checkBox1";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // vehicleDescriptionTextBox
            // 
            this.vehicleDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "VehicleDescription", true));
            this.vehicleDescriptionTextBox.Location = new System.Drawing.Point(159, 347);
            this.vehicleDescriptionTextBox.Name = "vehicleDescriptionTextBox";
            this.vehicleDescriptionTextBox.Size = new System.Drawing.Size(360, 24);
            this.vehicleDescriptionTextBox.TabIndex = 31;
            // 
            // isLeadVehicleCheckBox
            // 
            this.isLeadVehicleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsVehicleDetails2, "IsLeadVehicle", true));
            this.isLeadVehicleCheckBox.Location = new System.Drawing.Point(415, 135);
            this.isLeadVehicleCheckBox.Name = "isLeadVehicleCheckBox";
            this.isLeadVehicleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isLeadVehicleCheckBox.TabIndex = 29;
            this.isLeadVehicleCheckBox.Text = "checkBox1";
            this.isLeadVehicleCheckBox.UseVisualStyleBackColor = true;
            // 
            // registrationExpDTDateTimePicker
            // 
            this.registrationExpDTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsVehicleDetails2, "RegistrationExpDT", true));
            this.registrationExpDTDateTimePicker.Location = new System.Drawing.Point(159, 317);
            this.registrationExpDTDateTimePicker.Name = "registrationExpDTDateTimePicker";
            this.registrationExpDTDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.registrationExpDTDateTimePicker.TabIndex = 27;
            // 
            // feeConditionsTextBox
            // 
            this.feeConditionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "FeeConditions", true));
            this.feeConditionsTextBox.Location = new System.Drawing.Point(159, 287);
            this.feeConditionsTextBox.Name = "feeConditionsTextBox";
            this.feeConditionsTextBox.Size = new System.Drawing.Size(566, 24);
            this.feeConditionsTextBox.TabIndex = 25;
            // 
            // feeTypeTextBox
            // 
            this.feeTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "FeeType", true));
            this.feeTypeTextBox.Location = new System.Drawing.Point(159, 257);
            this.feeTypeTextBox.Name = "feeTypeTextBox";
            this.feeTypeTextBox.Size = new System.Drawing.Size(100, 24);
            this.feeTypeTextBox.TabIndex = 23;
            // 
            // jurisdictionTextBox
            // 
            this.jurisdictionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "Jurisdiction", true));
            this.jurisdictionTextBox.Location = new System.Drawing.Point(415, 227);
            this.jurisdictionTextBox.Name = "jurisdictionTextBox";
            this.jurisdictionTextBox.Size = new System.Drawing.Size(100, 24);
            this.jurisdictionTextBox.TabIndex = 21;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(159, 227);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.feeCodeTextBox.TabIndex = 19;
            // 
            // registeredTareTextBox
            // 
            this.registeredTareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "RegisteredTare", true));
            this.registeredTareTextBox.Location = new System.Drawing.Point(159, 197);
            this.registeredTareTextBox.Name = "registeredTareTextBox";
            this.registeredTareTextBox.Size = new System.Drawing.Size(100, 24);
            this.registeredTareTextBox.TabIndex = 17;
            // 
            // massAccreditationLabelTextBox
            // 
            this.massAccreditationLabelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "MassAccreditationLabel", true));
            this.massAccreditationLabelTextBox.Location = new System.Drawing.Point(159, 167);
            this.massAccreditationLabelTextBox.Name = "massAccreditationLabelTextBox";
            this.massAccreditationLabelTextBox.Size = new System.Drawing.Size(100, 24);
            this.massAccreditationLabelTextBox.TabIndex = 15;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(415, 104);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(100, 24);
            this.axleConfigurationTextBox.TabIndex = 13;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(159, 137);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 24);
            this.modelTextBox.TabIndex = 11;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(159, 107);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 24);
            this.makeTextBox.TabIndex = 9;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "TruckOwner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(415, 74);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(310, 24);
            this.ownerTextBox.TabIndex = 7;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(159, 77);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.cardCodeTextBox.TabIndex = 5;
            // 
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(415, 47);
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(100, 24);
            this.vINTextBox.TabIndex = 3;
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails2, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(159, 47);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.Size = new System.Drawing.Size(100, 24);
            this.regoTextBox.TabIndex = 1;
            // 
            // bsVehicleDetails2
            // 
            this.bsVehicleDetails2.DataMember = "VehicleDetails";
            this.bsVehicleDetails2.DataSource = this.dsQWSLocal2024;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taVehicleDetails2
            // 
            this.taVehicleDetails2.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.NHVRTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclePBSTableAdapter = null;
            this.tableAdapterManager.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // txtboxcolumnRego
            // 
            this.txtboxcolumnRego.DataPropertyName = "Rego";
            this.txtboxcolumnRego.HeaderText = "Rego";
            this.txtboxcolumnRego.Name = "txtboxcolumnRego";
            this.txtboxcolumnRego.ReadOnly = true;
            // 
            // TruckOwner
            // 
            this.TruckOwner.DataPropertyName = "TruckOwner";
            this.TruckOwner.HeaderText = "Truck Owner";
            this.TruckOwner.Name = "TruckOwner";
            this.TruckOwner.ReadOnly = true;
            this.TruckOwner.Width = 200;
            // 
            // Schematic
            // 
            this.Schematic.DataPropertyName = "Schematic";
            this.Schematic.HeaderText = "Schematic";
            this.Schematic.Name = "Schematic";
            this.Schematic.ReadOnly = true;
            this.Schematic.Width = 450;
            // 
            // FeeCode
            // 
            this.FeeCode.DataPropertyName = "FeeCode";
            this.FeeCode.HeaderText = "FeeCode";
            this.FeeCode.Name = "FeeCode";
            this.FeeCode.ReadOnly = true;
            // 
            // VehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 623);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleSearch";
            this.Text = "Vehicle Search";
            this.Load += new System.EventHandler(this.VehicleSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VehicleSearch_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsVehicleDetails2;
        private dsQWSLocal2024TableAdapters.VehicleDetailsTableAdapter taVehicleDetails2;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTrailers;
        private System.Windows.Forms.RadioButton rbTrucks;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox regoTextBox;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton rbClear;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.DateTimePicker createDTTMDateTimePicker;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.TextBox vehicleDescriptionTextBox;
        private System.Windows.Forms.CheckBox isLeadVehicleCheckBox;
        private System.Windows.Forms.DateTimePicker registrationExpDTDateTimePicker;
        private System.Windows.Forms.TextBox feeConditionsTextBox;
        private System.Windows.Forms.TextBox feeTypeTextBox;
        private System.Windows.Forms.TextBox jurisdictionTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.TextBox registeredTareTextBox;
        private System.Windows.Forms.TextBox massAccreditationLabelTextBox;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.RadioButton rbCardCode;
        private System.Windows.Forms.RadioButton rbRego;
        private System.Windows.Forms.RadioButton rbAxleConfig;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtboxcolumnRego;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckOwner;
        private System.Windows.Forms.DataGridViewImageColumn Schematic;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeCode;
    }
}