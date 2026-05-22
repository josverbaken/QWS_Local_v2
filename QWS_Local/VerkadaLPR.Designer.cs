namespace QWS_Local
{
    partial class VerkadaLPR
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
            System.Windows.Forms.Label entryDTTMLabel;
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label vehicleOwnerLabel;
            System.Windows.Forms.Label visitStatusLabel;
            System.Windows.Forms.Label vehicleTypeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSeenLPR = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.lblUTCOffset = new System.Windows.Forms.Label();
            this.btnRefreshDTP = new System.Windows.Forms.Button();
            this.btnManualExit = new System.Windows.Forms.Button();
            this.rbQuarryToday = new System.Windows.Forms.RadioButton();
            this.rbAllOnSite = new System.Windows.Forms.RadioButton();
            this.rbQuarryOnSite = new System.Windows.Forms.RadioButton();
            this.rbAllPlates = new System.Windows.Forms.RadioButton();
            this.btnDiscardLP = new System.Windows.Forms.Button();
            this.btnMapLicensePlate = new System.Windows.Forms.Button();
            this.btnNewVehicle = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvVehiclesOnSite = new System.Windows.Forms.DataGridView();
            this.entryDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVehiclesOnSite = new System.Windows.Forms.BindingSource(this.components);
            this.dsVerkada = new QWS_Local.dsVerkada();
            this.tpVehicles = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.btnRefreshVehicle = new System.Windows.Forms.Button();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.txtVehicleRego = new System.Windows.Forms.TextBox();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVehicles = new System.Windows.Forms.BindingSource(this.components);
            this.tpLicensesPlates = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnLPSave = new System.Windows.Forms.Button();
            this.btnLPRefresh = new System.Windows.Forms.Button();
            this.btnLPFind = new System.Windows.Forms.Button();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLicensePlates = new System.Windows.Forms.BindingSource(this.components);
            this.tpDiscards = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnDiscardsSave = new System.Windows.Forms.Button();
            this.btnDiscardsRefresh = new System.Windows.Forms.Button();
            this.btnDiscardsFind = new System.Windows.Forms.Button();
            this.txtDiscards = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.licensePlateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bslPR2Discard = new System.Windows.Forms.BindingSource(this.components);
            this.tpManualExit = new System.Windows.Forms.TabPage();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.visitStatusTextBox = new System.Windows.Forms.TextBox();
            this.vehicleOwnerTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.entryDTTMTextBox = new System.Windows.Forms.TextBox();
            this.btnSaveManualExit = new System.Windows.Forms.Button();
            this.dtpManualDepartureDTTM = new System.Windows.Forms.DateTimePicker();
            this.taVehiclesOnSite = new QWS_Local.dsVerkadaTableAdapters.taVehiclesOnSite();
            this.taVehiclesLPR = new QWS_Local.dsVerkadaTableAdapters.taVehiclesLPR();
            this.taLicensePlates = new QWS_Local.dsVerkadaTableAdapters.LicensePlatesTableAdapter();
            this.talPR2Discard = new QWS_Local.dsVerkadaTableAdapters.LPR2DiscardTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsVerkadaTableAdapters.TableAdapterManager();
            entryDTTMLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            vehicleOwnerLabel = new System.Windows.Forms.Label();
            visitStatusLabel = new System.Windows.Forms.Label();
            vehicleTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpSeenLPR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiclesOnSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclesOnSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVerkada)).BeginInit();
            this.tpVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicles)).BeginInit();
            this.tpLicensesPlates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLicensePlates)).BeginInit();
            this.tpDiscards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bslPR2Discard)).BeginInit();
            this.tpManualExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryDTTMLabel
            // 
            entryDTTMLabel.AutoSize = true;
            entryDTTMLabel.Location = new System.Drawing.Point(196, 130);
            entryDTTMLabel.Name = "entryDTTMLabel";
            entryDTTMLabel.Size = new System.Drawing.Size(92, 18);
            entryDTTMLabel.TabIndex = 2;
            entryDTTMLabel.Text = "Entry DTTM:";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new System.Drawing.Point(188, 100);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(100, 18);
            licensePlateLabel.TabIndex = 4;
            licensePlateLabel.Text = "License Plate:";
            // 
            // vehicleOwnerLabel
            // 
            vehicleOwnerLabel.AutoSize = true;
            vehicleOwnerLabel.Location = new System.Drawing.Point(181, 160);
            vehicleOwnerLabel.Name = "vehicleOwnerLabel";
            vehicleOwnerLabel.Size = new System.Drawing.Size(107, 18);
            vehicleOwnerLabel.TabIndex = 6;
            vehicleOwnerLabel.Text = "Vehicle Owner:";
            // 
            // visitStatusLabel
            // 
            visitStatusLabel.AutoSize = true;
            visitStatusLabel.Location = new System.Drawing.Point(203, 190);
            visitStatusLabel.Name = "visitStatusLabel";
            visitStatusLabel.Size = new System.Drawing.Size(85, 18);
            visitStatusLabel.TabIndex = 8;
            visitStatusLabel.Text = "Visit Status:";
            // 
            // vehicleTypeLabel
            // 
            vehicleTypeLabel.AutoSize = true;
            vehicleTypeLabel.Location = new System.Drawing.Point(193, 220);
            vehicleTypeLabel.Name = "vehicleTypeLabel";
            vehicleTypeLabel.Size = new System.Drawing.Size(95, 18);
            vehicleTypeLabel.TabIndex = 10;
            vehicleTypeLabel.Text = "Vehicle Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(115, 252);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 18);
            label1.TabIndex = 12;
            label1.Text = "Departure Date and Time";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSeenLPR);
            this.tabControl1.Controls.Add(this.tpVehicles);
            this.tabControl1.Controls.Add(this.tpLicensesPlates);
            this.tabControl1.Controls.Add(this.tpDiscards);
            this.tabControl1.Controls.Add(this.tpManualExit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 799);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSeenLPR
            // 
            this.tpSeenLPR.Controls.Add(this.splitContainer1);
            this.tpSeenLPR.Location = new System.Drawing.Point(4, 27);
            this.tpSeenLPR.Margin = new System.Windows.Forms.Padding(4);
            this.tpSeenLPR.Name = "tpSeenLPR";
            this.tpSeenLPR.Padding = new System.Windows.Forms.Padding(4);
            this.tpSeenLPR.Size = new System.Drawing.Size(1052, 768);
            this.tpSeenLPR.TabIndex = 3;
            this.tpSeenLPR.Text = "Seen LPR";
            this.tpSeenLPR.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.lblUTCOffset);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefreshDTP);
            this.splitContainer1.Panel1.Controls.Add(this.btnManualExit);
            this.splitContainer1.Panel1.Controls.Add(this.rbQuarryToday);
            this.splitContainer1.Panel1.Controls.Add(this.rbAllOnSite);
            this.splitContainer1.Panel1.Controls.Add(this.rbQuarryOnSite);
            this.splitContainer1.Panel1.Controls.Add(this.rbAllPlates);
            this.splitContainer1.Panel1.Controls.Add(this.btnDiscardLP);
            this.splitContainer1.Panel1.Controls.Add(this.btnMapLicensePlate);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewVehicle);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVehiclesOnSite);
            this.splitContainer1.Size = new System.Drawing.Size(1044, 760);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(153, 721);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblUTCOffset
            // 
            this.lblUTCOffset.AutoSize = true;
            this.lblUTCOffset.Location = new System.Drawing.Point(27, 473);
            this.lblUTCOffset.Name = "lblUTCOffset";
            this.lblUTCOffset.Size = new System.Drawing.Size(46, 18);
            this.lblUTCOffset.TabIndex = 13;
            this.lblUTCOffset.Text = "label1";
            // 
            // btnRefreshDTP
            // 
            this.btnRefreshDTP.Location = new System.Drawing.Point(27, 505);
            this.btnRefreshDTP.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshDTP.Name = "btnRefreshDTP";
            this.btnRefreshDTP.Size = new System.Drawing.Size(201, 44);
            this.btnRefreshDTP.TabIndex = 12;
            this.btnRefreshDTP.Text = "Refresh (dtp)";
            this.btnRefreshDTP.UseVisualStyleBackColor = true;
            this.btnRefreshDTP.Click += new System.EventHandler(this.btnRefreshDTP_Click);
            // 
            // btnManualExit
            // 
            this.btnManualExit.Location = new System.Drawing.Point(27, 382);
            this.btnManualExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnManualExit.Name = "btnManualExit";
            this.btnManualExit.Size = new System.Drawing.Size(201, 44);
            this.btnManualExit.TabIndex = 11;
            this.btnManualExit.Text = "Manual Exit";
            this.btnManualExit.UseVisualStyleBackColor = true;
            this.btnManualExit.Click += new System.EventHandler(this.btnManualExit_Click);
            // 
            // rbQuarryToday
            // 
            this.rbQuarryToday.AutoSize = true;
            this.rbQuarryToday.Location = new System.Drawing.Point(44, 98);
            this.rbQuarryToday.Margin = new System.Windows.Forms.Padding(4);
            this.rbQuarryToday.Name = "rbQuarryToday";
            this.rbQuarryToday.Size = new System.Drawing.Size(121, 22);
            this.rbQuarryToday.TabIndex = 10;
            this.rbQuarryToday.TabStop = true;
            this.rbQuarryToday.Text = "Quarry Trucks";
            this.rbQuarryToday.UseVisualStyleBackColor = true;
            this.rbQuarryToday.CheckedChanged += new System.EventHandler(this.rbQuarryToday_CheckedChanged);
            // 
            // rbAllOnSite
            // 
            this.rbAllOnSite.AutoSize = true;
            this.rbAllOnSite.Location = new System.Drawing.Point(44, 68);
            this.rbAllOnSite.Margin = new System.Windows.Forms.Padding(4);
            this.rbAllOnSite.Name = "rbAllOnSite";
            this.rbAllOnSite.Size = new System.Drawing.Size(94, 22);
            this.rbAllOnSite.TabIndex = 9;
            this.rbAllOnSite.TabStop = true;
            this.rbAllOnSite.Text = "All On Site";
            this.rbAllOnSite.UseVisualStyleBackColor = true;
            this.rbAllOnSite.CheckedChanged += new System.EventHandler(this.rbAllOnSite_CheckedChanged);
            // 
            // rbQuarryOnSite
            // 
            this.rbQuarryOnSite.AutoSize = true;
            this.rbQuarryOnSite.Location = new System.Drawing.Point(41, 128);
            this.rbQuarryOnSite.Margin = new System.Windows.Forms.Padding(4);
            this.rbQuarryOnSite.Name = "rbQuarryOnSite";
            this.rbQuarryOnSite.Size = new System.Drawing.Size(124, 22);
            this.rbQuarryOnSite.TabIndex = 7;
            this.rbQuarryOnSite.TabStop = true;
            this.rbQuarryOnSite.Text = "Quarry On Site";
            this.rbQuarryOnSite.UseVisualStyleBackColor = true;
            this.rbQuarryOnSite.CheckedChanged += new System.EventHandler(this.rbQuarryOnSite_CheckedChanged);
            // 
            // rbAllPlates
            // 
            this.rbAllPlates.AutoSize = true;
            this.rbAllPlates.Location = new System.Drawing.Point(44, 38);
            this.rbAllPlates.Margin = new System.Windows.Forms.Padding(4);
            this.rbAllPlates.Name = "rbAllPlates";
            this.rbAllPlates.Size = new System.Drawing.Size(41, 22);
            this.rbAllPlates.TabIndex = 6;
            this.rbAllPlates.TabStop = true;
            this.rbAllPlates.Text = "All";
            this.rbAllPlates.UseVisualStyleBackColor = true;
            this.rbAllPlates.CheckedChanged += new System.EventHandler(this.rbAllPlates_CheckedChanged);
            // 
            // btnDiscardLP
            // 
            this.btnDiscardLP.Location = new System.Drawing.Point(27, 330);
            this.btnDiscardLP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscardLP.Name = "btnDiscardLP";
            this.btnDiscardLP.Size = new System.Drawing.Size(201, 44);
            this.btnDiscardLP.TabIndex = 5;
            this.btnDiscardLP.Text = "Discard License Plate";
            this.btnDiscardLP.UseVisualStyleBackColor = true;
            this.btnDiscardLP.Click += new System.EventHandler(this.btnDiscardLP_Click);
            // 
            // btnMapLicensePlate
            // 
            this.btnMapLicensePlate.Location = new System.Drawing.Point(27, 278);
            this.btnMapLicensePlate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMapLicensePlate.Name = "btnMapLicensePlate";
            this.btnMapLicensePlate.Size = new System.Drawing.Size(201, 44);
            this.btnMapLicensePlate.TabIndex = 4;
            this.btnMapLicensePlate.Text = "Map License Plate";
            this.btnMapLicensePlate.UseVisualStyleBackColor = true;
            this.btnMapLicensePlate.Click += new System.EventHandler(this.btnMapLicensePlate_Click);
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Location = new System.Drawing.Point(27, 226);
            this.btnNewVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(201, 44);
            this.btnNewVehicle.TabIndex = 3;
            this.btnNewVehicle.Text = "New Vehicle";
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(27, 174);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 44);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh (now)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 441);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 24);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dgvVehiclesOnSite
            // 
            this.dgvVehiclesOnSite.AllowUserToAddRows = false;
            this.dgvVehiclesOnSite.AllowUserToDeleteRows = false;
            this.dgvVehiclesOnSite.AutoGenerateColumns = false;
            this.dgvVehiclesOnSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiclesOnSite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryDTTMDataGridViewTextBoxColumn,
            this.LicensePlate,
            this.Duration,
            this.VisitStatus,
            this.VehicleOwner,
            this.VehicleType});
            this.dgvVehiclesOnSite.DataSource = this.bsVehiclesOnSite;
            this.dgvVehiclesOnSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehiclesOnSite.Location = new System.Drawing.Point(0, 0);
            this.dgvVehiclesOnSite.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehiclesOnSite.Name = "dgvVehiclesOnSite";
            this.dgvVehiclesOnSite.ReadOnly = true;
            this.dgvVehiclesOnSite.Size = new System.Drawing.Size(784, 760);
            this.dgvVehiclesOnSite.TabIndex = 0;
            this.dgvVehiclesOnSite.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVehiclesOnSite_CellFormatting);
            // 
            // entryDTTMDataGridViewTextBoxColumn
            // 
            this.entryDTTMDataGridViewTextBoxColumn.DataPropertyName = "EntryDTTM";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.entryDTTMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.entryDTTMDataGridViewTextBoxColumn.HeaderText = "EntryDTTM";
            this.entryDTTMDataGridViewTextBoxColumn.Name = "entryDTTMDataGridViewTextBoxColumn";
            this.entryDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LicensePlate
            // 
            this.LicensePlate.DataPropertyName = "LicensePlate";
            this.LicensePlate.HeaderText = "LicensePlate";
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // VisitStatus
            // 
            this.VisitStatus.DataPropertyName = "VisitStatus";
            this.VisitStatus.HeaderText = "VisitStatus";
            this.VisitStatus.Name = "VisitStatus";
            this.VisitStatus.ReadOnly = true;
            // 
            // VehicleOwner
            // 
            this.VehicleOwner.DataPropertyName = "VehicleOwner";
            this.VehicleOwner.HeaderText = "VehicleOwner";
            this.VehicleOwner.Name = "VehicleOwner";
            this.VehicleOwner.ReadOnly = true;
            this.VehicleOwner.Width = 250;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "VehicleType";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            this.VehicleType.Width = 150;
            // 
            // bsVehiclesOnSite
            // 
            this.bsVehiclesOnSite.DataMember = "VehiclesOnSite";
            this.bsVehiclesOnSite.DataSource = this.dsVerkada;
            // 
            // dsVerkada
            // 
            this.dsVerkada.DataSetName = "dsVerkada";
            this.dsVerkada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpVehicles
            // 
            this.tpVehicles.Controls.Add(this.splitContainer2);
            this.tpVehicles.Location = new System.Drawing.Point(4, 27);
            this.tpVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.tpVehicles.Name = "tpVehicles";
            this.tpVehicles.Padding = new System.Windows.Forms.Padding(4);
            this.tpVehicles.Size = new System.Drawing.Size(1052, 768);
            this.tpVehicles.TabIndex = 0;
            this.tpVehicles.Text = "Vehicles";
            this.tpVehicles.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveVehicle);
            this.splitContainer2.Panel1.Controls.Add(this.btnRefreshVehicle);
            this.splitContainer2.Panel1.Controls.Add(this.btnFindVehicle);
            this.splitContainer2.Panel1.Controls.Add(this.txtVehicleRego);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvVehicles);
            this.splitContainer2.Size = new System.Drawing.Size(1044, 760);
            this.splitContainer2.SplitterDistance = 234;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(69, 240);
            this.btnSaveVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(112, 32);
            this.btnSaveVehicle.TabIndex = 3;
            this.btnSaveVehicle.Text = "Save";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // btnRefreshVehicle
            // 
            this.btnRefreshVehicle.Location = new System.Drawing.Point(69, 189);
            this.btnRefreshVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshVehicle.Name = "btnRefreshVehicle";
            this.btnRefreshVehicle.Size = new System.Drawing.Size(112, 32);
            this.btnRefreshVehicle.TabIndex = 2;
            this.btnRefreshVehicle.Text = "Refresh";
            this.btnRefreshVehicle.UseVisualStyleBackColor = true;
            this.btnRefreshVehicle.Click += new System.EventHandler(this.btnRefreshVehicle_Click);
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.Location = new System.Drawing.Point(69, 136);
            this.btnFindVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(112, 32);
            this.btnFindVehicle.TabIndex = 1;
            this.btnFindVehicle.Text = "Find";
            this.btnFindVehicle.UseVisualStyleBackColor = true;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // txtVehicleRego
            // 
            this.txtVehicleRego.Location = new System.Drawing.Point(69, 75);
            this.txtVehicleRego.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleRego.Name = "txtVehicleRego";
            this.txtVehicleRego.Size = new System.Drawing.Size(112, 24);
            this.txtVehicleRego.TabIndex = 0;
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AutoGenerateColumns = false;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn});
            this.dgvVehicles.DataSource = this.bsVehicles;
            this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicles.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.Size = new System.Drawing.Size(804, 760);
            this.dgvVehicles.TabIndex = 0;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.Width = 250;
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsVehicles
            // 
            this.bsVehicles.DataMember = "Vehicles";
            this.bsVehicles.DataSource = this.dsVerkada;
            // 
            // tpLicensesPlates
            // 
            this.tpLicensesPlates.Controls.Add(this.splitContainer3);
            this.tpLicensesPlates.Location = new System.Drawing.Point(4, 27);
            this.tpLicensesPlates.Margin = new System.Windows.Forms.Padding(4);
            this.tpLicensesPlates.Name = "tpLicensesPlates";
            this.tpLicensesPlates.Padding = new System.Windows.Forms.Padding(4);
            this.tpLicensesPlates.Size = new System.Drawing.Size(1052, 768);
            this.tpLicensesPlates.TabIndex = 1;
            this.tpLicensesPlates.Text = "License Plates";
            this.tpLicensesPlates.UseVisualStyleBackColor = true;
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
            this.splitContainer3.Panel1.Controls.Add(this.btnLPSave);
            this.splitContainer3.Panel1.Controls.Add(this.btnLPRefresh);
            this.splitContainer3.Panel1.Controls.Add(this.btnLPFind);
            this.splitContainer3.Panel1.Controls.Add(this.txtLicensePlate);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer3.Size = new System.Drawing.Size(1044, 760);
            this.splitContainer3.SplitterDistance = 347;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnLPSave
            // 
            this.btnLPSave.Location = new System.Drawing.Point(50, 184);
            this.btnLPSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnLPSave.Name = "btnLPSave";
            this.btnLPSave.Size = new System.Drawing.Size(112, 32);
            this.btnLPSave.TabIndex = 7;
            this.btnLPSave.Text = "Save";
            this.btnLPSave.UseVisualStyleBackColor = true;
            this.btnLPSave.Click += new System.EventHandler(this.btnLPSave_Click);
            // 
            // btnLPRefresh
            // 
            this.btnLPRefresh.Location = new System.Drawing.Point(50, 241);
            this.btnLPRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnLPRefresh.Name = "btnLPRefresh";
            this.btnLPRefresh.Size = new System.Drawing.Size(112, 32);
            this.btnLPRefresh.TabIndex = 6;
            this.btnLPRefresh.Text = "Refresh";
            this.btnLPRefresh.UseVisualStyleBackColor = true;
            this.btnLPRefresh.Click += new System.EventHandler(this.btnLPRefresh_Click);
            // 
            // btnLPFind
            // 
            this.btnLPFind.Location = new System.Drawing.Point(50, 127);
            this.btnLPFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnLPFind.Name = "btnLPFind";
            this.btnLPFind.Size = new System.Drawing.Size(112, 32);
            this.btnLPFind.TabIndex = 5;
            this.btnLPFind.Text = "Find";
            this.btnLPFind.UseVisualStyleBackColor = true;
            this.btnLPFind.Click += new System.EventHandler(this.btnLPFind_Click);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(50, 66);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(112, 24);
            this.txtLicensePlate.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateDataGridViewTextBoxColumn,
            this.regoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bsLicensePlates;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(691, 760);
            this.dataGridView2.TabIndex = 0;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            // 
            // regoDataGridViewTextBoxColumn1
            // 
            this.regoDataGridViewTextBoxColumn1.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn1.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn1.Name = "regoDataGridViewTextBoxColumn1";
            // 
            // bsLicensePlates
            // 
            this.bsLicensePlates.DataMember = "LicensePlates";
            this.bsLicensePlates.DataSource = this.dsVerkada;
            // 
            // tpDiscards
            // 
            this.tpDiscards.Controls.Add(this.splitContainer4);
            this.tpDiscards.Location = new System.Drawing.Point(4, 27);
            this.tpDiscards.Margin = new System.Windows.Forms.Padding(4);
            this.tpDiscards.Name = "tpDiscards";
            this.tpDiscards.Padding = new System.Windows.Forms.Padding(4);
            this.tpDiscards.Size = new System.Drawing.Size(1052, 768);
            this.tpDiscards.TabIndex = 2;
            this.tpDiscards.Text = "Discards";
            this.tpDiscards.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(4, 4);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnDiscardsSave);
            this.splitContainer4.Panel1.Controls.Add(this.btnDiscardsRefresh);
            this.splitContainer4.Panel1.Controls.Add(this.btnDiscardsFind);
            this.splitContainer4.Panel1.Controls.Add(this.txtDiscards);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer4.Size = new System.Drawing.Size(1044, 760);
            this.splitContainer4.SplitterDistance = 347;
            this.splitContainer4.SplitterWidth = 6;
            this.splitContainer4.TabIndex = 0;
            // 
            // btnDiscardsSave
            // 
            this.btnDiscardsSave.Location = new System.Drawing.Point(70, 170);
            this.btnDiscardsSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscardsSave.Name = "btnDiscardsSave";
            this.btnDiscardsSave.Size = new System.Drawing.Size(112, 32);
            this.btnDiscardsSave.TabIndex = 11;
            this.btnDiscardsSave.Text = "Save";
            this.btnDiscardsSave.UseVisualStyleBackColor = true;
            this.btnDiscardsSave.Click += new System.EventHandler(this.btnDiscardsSave_Click);
            // 
            // btnDiscardsRefresh
            // 
            this.btnDiscardsRefresh.Location = new System.Drawing.Point(70, 227);
            this.btnDiscardsRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscardsRefresh.Name = "btnDiscardsRefresh";
            this.btnDiscardsRefresh.Size = new System.Drawing.Size(112, 32);
            this.btnDiscardsRefresh.TabIndex = 10;
            this.btnDiscardsRefresh.Text = "Refresh";
            this.btnDiscardsRefresh.UseVisualStyleBackColor = true;
            this.btnDiscardsRefresh.Click += new System.EventHandler(this.btnDiscardsRefresh_Click);
            // 
            // btnDiscardsFind
            // 
            this.btnDiscardsFind.Location = new System.Drawing.Point(70, 113);
            this.btnDiscardsFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscardsFind.Name = "btnDiscardsFind";
            this.btnDiscardsFind.Size = new System.Drawing.Size(112, 32);
            this.btnDiscardsFind.TabIndex = 9;
            this.btnDiscardsFind.Text = "Find";
            this.btnDiscardsFind.UseVisualStyleBackColor = true;
            this.btnDiscardsFind.Click += new System.EventHandler(this.btnDiscardsFind_Click);
            // 
            // txtDiscards
            // 
            this.txtDiscards.Location = new System.Drawing.Point(70, 52);
            this.txtDiscards.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscards.Name = "txtDiscards";
            this.txtDiscards.Size = new System.Drawing.Size(112, 24);
            this.txtDiscards.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bslPR2Discard;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(691, 760);
            this.dataGridView3.TabIndex = 0;
            // 
            // licensePlateDataGridViewTextBoxColumn1
            // 
            this.licensePlateDataGridViewTextBoxColumn1.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn1.HeaderText = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn1.Name = "licensePlateDataGridViewTextBoxColumn1";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 400;
            // 
            // bslPR2Discard
            // 
            this.bslPR2Discard.DataMember = "LPR2Discard";
            this.bslPR2Discard.DataSource = this.dsVerkada;
            // 
            // tpManualExit
            // 
            this.tpManualExit.Controls.Add(label1);
            this.tpManualExit.Controls.Add(vehicleTypeLabel);
            this.tpManualExit.Controls.Add(this.vehicleTypeTextBox);
            this.tpManualExit.Controls.Add(visitStatusLabel);
            this.tpManualExit.Controls.Add(this.visitStatusTextBox);
            this.tpManualExit.Controls.Add(vehicleOwnerLabel);
            this.tpManualExit.Controls.Add(this.vehicleOwnerTextBox);
            this.tpManualExit.Controls.Add(licensePlateLabel);
            this.tpManualExit.Controls.Add(this.licensePlateTextBox);
            this.tpManualExit.Controls.Add(entryDTTMLabel);
            this.tpManualExit.Controls.Add(this.entryDTTMTextBox);
            this.tpManualExit.Controls.Add(this.btnSaveManualExit);
            this.tpManualExit.Controls.Add(this.dtpManualDepartureDTTM);
            this.tpManualExit.Location = new System.Drawing.Point(4, 27);
            this.tpManualExit.Name = "tpManualExit";
            this.tpManualExit.Size = new System.Drawing.Size(1052, 768);
            this.tpManualExit.TabIndex = 4;
            this.tpManualExit.Text = "Manual Exit";
            this.tpManualExit.UseVisualStyleBackColor = true;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehiclesOnSite, "VehicleType", true));
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(294, 217);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(299, 24);
            this.vehicleTypeTextBox.TabIndex = 11;
            // 
            // visitStatusTextBox
            // 
            this.visitStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehiclesOnSite, "VisitStatus", true));
            this.visitStatusTextBox.Location = new System.Drawing.Point(294, 187);
            this.visitStatusTextBox.Name = "visitStatusTextBox";
            this.visitStatusTextBox.Size = new System.Drawing.Size(299, 24);
            this.visitStatusTextBox.TabIndex = 9;
            // 
            // vehicleOwnerTextBox
            // 
            this.vehicleOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehiclesOnSite, "VehicleOwner", true));
            this.vehicleOwnerTextBox.Location = new System.Drawing.Point(294, 157);
            this.vehicleOwnerTextBox.Name = "vehicleOwnerTextBox";
            this.vehicleOwnerTextBox.Size = new System.Drawing.Size(299, 24);
            this.vehicleOwnerTextBox.TabIndex = 7;
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehiclesOnSite, "LicensePlate", true));
            this.licensePlateTextBox.Location = new System.Drawing.Point(294, 97);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(100, 24);
            this.licensePlateTextBox.TabIndex = 5;
            // 
            // entryDTTMTextBox
            // 
            this.entryDTTMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehiclesOnSite, "EntryDTTM", true));
            this.entryDTTMTextBox.Location = new System.Drawing.Point(294, 127);
            this.entryDTTMTextBox.Name = "entryDTTMTextBox";
            this.entryDTTMTextBox.Size = new System.Drawing.Size(299, 24);
            this.entryDTTMTextBox.TabIndex = 3;
            // 
            // btnSaveManualExit
            // 
            this.btnSaveManualExit.Location = new System.Drawing.Point(294, 299);
            this.btnSaveManualExit.Name = "btnSaveManualExit";
            this.btnSaveManualExit.Size = new System.Drawing.Size(299, 46);
            this.btnSaveManualExit.TabIndex = 1;
            this.btnSaveManualExit.Text = "Process Departure";
            this.btnSaveManualExit.UseVisualStyleBackColor = true;
            this.btnSaveManualExit.Click += new System.EventHandler(this.btnSaveManualExit_Click);
            // 
            // dtpManualDepartureDTTM
            // 
            this.dtpManualDepartureDTTM.CustomFormat = "ddd MMM yyyy HH:mm";
            this.dtpManualDepartureDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpManualDepartureDTTM.Location = new System.Drawing.Point(294, 247);
            this.dtpManualDepartureDTTM.Name = "dtpManualDepartureDTTM";
            this.dtpManualDepartureDTTM.Size = new System.Drawing.Size(200, 24);
            this.dtpManualDepartureDTTM.TabIndex = 0;
            // 
            // taVehiclesOnSite
            // 
            this.taVehiclesOnSite.ClearBeforeFill = true;
            // 
            // taVehiclesLPR
            // 
            this.taVehiclesLPR.ClearBeforeFill = true;
            // 
            // taLicensePlates
            // 
            this.taLicensePlates.ClearBeforeFill = true;
            // 
            // talPR2Discard
            // 
            this.talPR2Discard.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LicensePlatesTableAdapter = this.taLicensePlates;
            this.tableAdapterManager.LPR2DiscardTableAdapter = this.talPR2Discard;
            this.tableAdapterManager.taVehiclesLPR = this.taVehiclesLPR;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsVerkadaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // VerkadaLPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 799);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerkadaLPR";
            this.Text = "VerkadaLPR";
            this.Load += new System.EventHandler(this.VerkadaLPR_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSeenLPR.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiclesOnSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclesOnSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVerkada)).EndInit();
            this.tpVehicles.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicles)).EndInit();
            this.tpLicensesPlates.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLicensePlates)).EndInit();
            this.tpDiscards.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bslPR2Discard)).EndInit();
            this.tpManualExit.ResumeLayout(false);
            this.tpManualExit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVehicles;
        private System.Windows.Forms.TabPage tpLicensesPlates;
        private System.Windows.Forms.TabPage tpDiscards;
        private System.Windows.Forms.TabPage tpSeenLPR;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvVehiclesOnSite;
        private dsVerkada dsVerkada;
        private dsVerkadaTableAdapters.taVehiclesOnSite taVehiclesOnSite;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource bsVehiclesOnSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.BindingSource bsVehicles;
        private dsVerkadaTableAdapters.taVehiclesLPR taVehiclesLPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bsLicensePlates;
        private dsVerkadaTableAdapters.LicensePlatesTableAdapter taLicensePlates;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bslPR2Discard;
        private dsVerkadaTableAdapters.LPR2DiscardTableAdapter talPR2Discard;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDiscardLP;
        private System.Windows.Forms.Button btnMapLicensePlate;
        private System.Windows.Forms.Button btnNewVehicle;
        private System.Windows.Forms.RadioButton rbAllOnSite;
        private System.Windows.Forms.RadioButton rbQuarryOnSite;
        private System.Windows.Forms.RadioButton rbAllPlates;
        private System.Windows.Forms.RadioButton rbQuarryToday;
        private System.Windows.Forms.Button btnSaveVehicle;
        private System.Windows.Forms.Button btnRefreshVehicle;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.TextBox txtVehicleRego;
        private System.Windows.Forms.Button btnLPSave;
        private System.Windows.Forms.Button btnLPRefresh;
        private System.Windows.Forms.Button btnLPFind;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Button btnDiscardsSave;
        private System.Windows.Forms.Button btnDiscardsRefresh;
        private System.Windows.Forms.Button btnDiscardsFind;
        private System.Windows.Forms.TextBox txtDiscards;
        private System.Windows.Forms.Button btnManualExit;
        private System.Windows.Forms.Button btnRefreshDTP;
        private System.Windows.Forms.Label lblUTCOffset;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tpManualExit;
        private System.Windows.Forms.Button btnSaveManualExit;
        private System.Windows.Forms.DateTimePicker dtpManualDepartureDTTM;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.TextBox visitStatusTextBox;
        private System.Windows.Forms.TextBox vehicleOwnerTextBox;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox entryDTTMTextBox;
        private dsVerkadaTableAdapters.TableAdapterManager tableAdapterManager;
    }
}