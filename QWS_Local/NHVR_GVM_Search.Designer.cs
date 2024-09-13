
namespace QWS_Local
{
    partial class NHVR_GVM_Search
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
            System.Windows.Forms.Label axlesLabel;
            System.Windows.Forms.Label couplingLabel;
            System.Windows.Forms.Label maxLengthLabel;
            System.Windows.Forms.Label schemeCodeLabel;
            System.Windows.Forms.Label trailersLabel;
            System.Windows.Forms.Label compartmentsLabel;
            System.Windows.Forms.Label trTkRatioLabel;
            System.Windows.Forms.Label gCMLabel;
            System.Windows.Forms.Label gVMTruckLabel;
            System.Windows.Forms.Label truckTypeDescriptionLabel;
            System.Windows.Forms.Label axleConfigurationLabel;
            System.Windows.Forms.Label roadAccessLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMassMgmtAccred = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsAxleConfiguration = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MassMgmtRqd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SteerAxleAllowance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoadAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNHVR = new System.Windows.Forms.BindingSource(this.components);
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.couplingTextBox = new System.Windows.Forms.TextBox();
            this.roadAccessTextBox = new System.Windows.Forms.TextBox();
            this.axlesTextBox = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox = new System.Windows.Forms.TextBox();
            this.maxLengthTextBox = new System.Windows.Forms.TextBox();
            this.gCMTextBox = new System.Windows.Forms.TextBox();
            this.schemeCodeTextBox = new System.Windows.Forms.TextBox();
            this.trTkRatioTextBox = new System.Windows.Forms.TextBox();
            this.truckTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.compartmentsTextBox = new System.Windows.Forms.TextBox();
            this.steerAxleAllowanceCheckBox = new System.Windows.Forms.CheckBox();
            this.trailersTextBox = new System.Windows.Forms.TextBox();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.truckTypeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.taNHVR = new QWS_Local.dsQWSLocal2024TableAdapters.NHVRTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.taAxleConfiguration = new QWS_Local.dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter();
            axlesLabel = new System.Windows.Forms.Label();
            couplingLabel = new System.Windows.Forms.Label();
            maxLengthLabel = new System.Windows.Forms.Label();
            schemeCodeLabel = new System.Windows.Forms.Label();
            trailersLabel = new System.Windows.Forms.Label();
            compartmentsLabel = new System.Windows.Forms.Label();
            trTkRatioLabel = new System.Windows.Forms.Label();
            gCMLabel = new System.Windows.Forms.Label();
            gVMTruckLabel = new System.Windows.Forms.Label();
            truckTypeDescriptionLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            roadAccessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVR)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // axlesLabel
            // 
            axlesLabel.AutoSize = true;
            axlesLabel.Location = new System.Drawing.Point(194, 99);
            axlesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            axlesLabel.Name = "axlesLabel";
            axlesLabel.Size = new System.Drawing.Size(47, 18);
            axlesLabel.TabIndex = 0;
            axlesLabel.Text = "Axles:";
            axlesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // couplingLabel
            // 
            couplingLabel.AutoSize = true;
            couplingLabel.Location = new System.Drawing.Point(171, 131);
            couplingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            couplingLabel.Name = "couplingLabel";
            couplingLabel.Size = new System.Drawing.Size(70, 18);
            couplingLabel.TabIndex = 2;
            couplingLabel.Text = "Coupling:";
            couplingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxLengthLabel
            // 
            maxLengthLabel.AutoSize = true;
            maxLengthLabel.Location = new System.Drawing.Point(153, 163);
            maxLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maxLengthLabel.Name = "maxLengthLabel";
            maxLengthLabel.Size = new System.Drawing.Size(88, 18);
            maxLengthLabel.TabIndex = 4;
            maxLengthLabel.Text = "Max Length:";
            maxLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // schemeCodeLabel
            // 
            schemeCodeLabel.AutoSize = true;
            schemeCodeLabel.Location = new System.Drawing.Point(134, 195);
            schemeCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            schemeCodeLabel.Name = "schemeCodeLabel";
            schemeCodeLabel.Size = new System.Drawing.Size(107, 18);
            schemeCodeLabel.TabIndex = 6;
            schemeCodeLabel.Text = "Scheme Code:";
            schemeCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trailersLabel
            // 
            trailersLabel.AutoSize = true;
            trailersLabel.Location = new System.Drawing.Point(561, 67);
            trailersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trailersLabel.Name = "trailersLabel";
            trailersLabel.Size = new System.Drawing.Size(61, 18);
            trailersLabel.TabIndex = 10;
            trailersLabel.Text = "Trailers:";
            trailersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // compartmentsLabel
            // 
            compartmentsLabel.AutoSize = true;
            compartmentsLabel.Location = new System.Drawing.Point(511, 98);
            compartmentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            compartmentsLabel.Name = "compartmentsLabel";
            compartmentsLabel.Size = new System.Drawing.Size(111, 18);
            compartmentsLabel.TabIndex = 12;
            compartmentsLabel.Text = "Compartments:";
            compartmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trTkRatioLabel
            // 
            trTkRatioLabel.AutoSize = true;
            trTkRatioLabel.Location = new System.Drawing.Point(536, 131);
            trTkRatioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trTkRatioLabel.Name = "trTkRatioLabel";
            trTkRatioLabel.Size = new System.Drawing.Size(86, 18);
            trTkRatioLabel.TabIndex = 14;
            trTkRatioLabel.Text = "Tr Tk Ratio:";
            trTkRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gCMLabel
            // 
            gCMLabel.AutoSize = true;
            gCMLabel.Location = new System.Drawing.Point(574, 162);
            gCMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gCMLabel.Name = "gCMLabel";
            gCMLabel.Size = new System.Drawing.Size(48, 18);
            gCMLabel.TabIndex = 16;
            gCMLabel.Text = "GCM:";
            gCMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gVMTruckLabel
            // 
            gVMTruckLabel.AutoSize = true;
            gVMTruckLabel.Location = new System.Drawing.Point(538, 195);
            gVMTruckLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gVMTruckLabel.Name = "gVMTruckLabel";
            gVMTruckLabel.Size = new System.Drawing.Size(84, 18);
            gVMTruckLabel.TabIndex = 18;
            gVMTruckLabel.Text = "GVMTruck:";
            gVMTruckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // truckTypeDescriptionLabel
            // 
            truckTypeDescriptionLabel.AutoSize = true;
            truckTypeDescriptionLabel.Location = new System.Drawing.Point(76, 68);
            truckTypeDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            truckTypeDescriptionLabel.Name = "truckTypeDescriptionLabel";
            truckTypeDescriptionLabel.Size = new System.Drawing.Size(165, 18);
            truckTypeDescriptionLabel.TabIndex = 20;
            truckTypeDescriptionLabel.Text = "Truck Type Description:";
            truckTypeDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(110, 35);
            axleConfigurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(131, 18);
            axleConfigurationLabel.TabIndex = 22;
            axleConfigurationLabel.Text = "Axle Configuration:";
            axleConfigurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roadAccessLabel
            // 
            roadAccessLabel.AutoSize = true;
            roadAccessLabel.Location = new System.Drawing.Point(143, 226);
            roadAccessLabel.Name = "roadAccessLabel";
            roadAccessLabel.Size = new System.Drawing.Size(101, 18);
            roadAccessLabel.TabIndex = 31;
            roadAccessLabel.Text = "Road Access:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1007, 495);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMassMgmtAccred);
            this.groupBox1.Location = new System.Drawing.Point(406, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 68);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mass Management Accreditation";
            // 
            // txtMassMgmtAccred
            // 
            this.txtMassMgmtAccred.Location = new System.Drawing.Point(175, 29);
            this.txtMassMgmtAccred.Name = "txtMassMgmtAccred";
            this.txtMassMgmtAccred.Size = new System.Drawing.Size(138, 24);
            this.txtMassMgmtAccred.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(811, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 31);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(811, 150);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(148, 31);
            this.btnSelect.TabIndex = 26;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsAxleConfiguration, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bsAxleConfiguration
            // 
            this.bsAxleConfiguration.DataMember = "AxleConfiguration";
            this.bsAxleConfiguration.DataSource = this.dsQWSLocal2024;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 262);
            this.tabControl1.TabIndex = 4;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(999, 231);
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
            this.axleConfigurationDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.GCM,
            this.MassMgmtRqd,
            this.SteerAxleAllowance,
            this.RoadAccess});
            this.dataGridView1.DataSource = this.bsNHVR;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(993, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "Axle Config";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            this.axleConfigurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "Scheme";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            this.schemeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.schemeCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // GCM
            // 
            this.GCM.DataPropertyName = "GCM";
            this.GCM.HeaderText = "GCM";
            this.GCM.Name = "GCM";
            this.GCM.ReadOnly = true;
            // 
            // MassMgmtRqd
            // 
            this.MassMgmtRqd.DataPropertyName = "MassMgmtRqd";
            this.MassMgmtRqd.HeaderText = "Mass Mgmt";
            this.MassMgmtRqd.Name = "MassMgmtRqd";
            this.MassMgmtRqd.ReadOnly = true;
            // 
            // SteerAxleAllowance
            // 
            this.SteerAxleAllowance.DataPropertyName = "SteerAxleAllowance";
            this.SteerAxleAllowance.HeaderText = "Steer";
            this.SteerAxleAllowance.Name = "SteerAxleAllowance";
            this.SteerAxleAllowance.ReadOnly = true;
            // 
            // RoadAccess
            // 
            this.RoadAccess.DataPropertyName = "RoadAccess";
            this.RoadAccess.HeaderText = "RoadAccess";
            this.RoadAccess.Name = "RoadAccess";
            this.RoadAccess.ReadOnly = true;
            this.RoadAccess.Width = 250;
            // 
            // bsNHVR
            // 
            this.bsNHVR.DataMember = "NHVR";
            this.bsNHVR.DataSource = this.dsQWSLocal2024;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(roadAccessLabel);
            this.tpDetails.Controls.Add(this.couplingTextBox);
            this.tpDetails.Controls.Add(this.roadAccessTextBox);
            this.tpDetails.Controls.Add(this.axlesTextBox);
            this.tpDetails.Controls.Add(axlesLabel);
            this.tpDetails.Controls.Add(gVMTruckLabel);
            this.tpDetails.Controls.Add(couplingLabel);
            this.tpDetails.Controls.Add(this.gVMTruckTextBox);
            this.tpDetails.Controls.Add(gCMLabel);
            this.tpDetails.Controls.Add(this.maxLengthTextBox);
            this.tpDetails.Controls.Add(this.gCMTextBox);
            this.tpDetails.Controls.Add(maxLengthLabel);
            this.tpDetails.Controls.Add(trTkRatioLabel);
            this.tpDetails.Controls.Add(this.schemeCodeTextBox);
            this.tpDetails.Controls.Add(this.trTkRatioTextBox);
            this.tpDetails.Controls.Add(this.truckTypeIDTextBox);
            this.tpDetails.Controls.Add(compartmentsLabel);
            this.tpDetails.Controls.Add(schemeCodeLabel);
            this.tpDetails.Controls.Add(this.compartmentsTextBox);
            this.tpDetails.Controls.Add(axleConfigurationLabel);
            this.tpDetails.Controls.Add(trailersLabel);
            this.tpDetails.Controls.Add(this.steerAxleAllowanceCheckBox);
            this.tpDetails.Controls.Add(this.trailersTextBox);
            this.tpDetails.Controls.Add(this.txtAxleConfig);
            this.tpDetails.Controls.Add(this.truckTypeDescriptionTextBox);
            this.tpDetails.Controls.Add(truckTypeDescriptionLabel);
            this.tpDetails.Location = new System.Drawing.Point(4, 22);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(999, 236);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // couplingTextBox
            // 
            this.couplingTextBox.Location = new System.Drawing.Point(249, 128);
            this.couplingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.couplingTextBox.Name = "couplingTextBox";
            this.couplingTextBox.ReadOnly = true;
            this.couplingTextBox.Size = new System.Drawing.Size(148, 24);
            this.couplingTextBox.TabIndex = 3;
            // 
            // roadAccessTextBox
            // 
            this.roadAccessTextBox.Location = new System.Drawing.Point(249, 223);
            this.roadAccessTextBox.Name = "roadAccessTextBox";
            this.roadAccessTextBox.ReadOnly = true;
            this.roadAccessTextBox.Size = new System.Drawing.Size(284, 24);
            this.roadAccessTextBox.TabIndex = 32;
            // 
            // axlesTextBox
            // 
            this.axlesTextBox.Location = new System.Drawing.Point(249, 96);
            this.axlesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axlesTextBox.Name = "axlesTextBox";
            this.axlesTextBox.ReadOnly = true;
            this.axlesTextBox.Size = new System.Drawing.Size(148, 24);
            this.axlesTextBox.TabIndex = 1;
            // 
            // gVMTruckTextBox
            // 
            this.gVMTruckTextBox.Location = new System.Drawing.Point(630, 192);
            this.gVMTruckTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gVMTruckTextBox.Name = "gVMTruckTextBox";
            this.gVMTruckTextBox.ReadOnly = true;
            this.gVMTruckTextBox.Size = new System.Drawing.Size(148, 24);
            this.gVMTruckTextBox.TabIndex = 19;
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.Location = new System.Drawing.Point(249, 160);
            this.maxLengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.ReadOnly = true;
            this.maxLengthTextBox.Size = new System.Drawing.Size(148, 24);
            this.maxLengthTextBox.TabIndex = 5;
            // 
            // gCMTextBox
            // 
            this.gCMTextBox.Location = new System.Drawing.Point(630, 160);
            this.gCMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gCMTextBox.Name = "gCMTextBox";
            this.gCMTextBox.ReadOnly = true;
            this.gCMTextBox.Size = new System.Drawing.Size(148, 24);
            this.gCMTextBox.TabIndex = 17;
            // 
            // schemeCodeTextBox
            // 
            this.schemeCodeTextBox.Location = new System.Drawing.Point(249, 192);
            this.schemeCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.schemeCodeTextBox.Name = "schemeCodeTextBox";
            this.schemeCodeTextBox.ReadOnly = true;
            this.schemeCodeTextBox.Size = new System.Drawing.Size(148, 24);
            this.schemeCodeTextBox.TabIndex = 7;
            // 
            // trTkRatioTextBox
            // 
            this.trTkRatioTextBox.Location = new System.Drawing.Point(630, 128);
            this.trTkRatioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trTkRatioTextBox.Name = "trTkRatioTextBox";
            this.trTkRatioTextBox.ReadOnly = true;
            this.trTkRatioTextBox.Size = new System.Drawing.Size(148, 24);
            this.trTkRatioTextBox.TabIndex = 15;
            // 
            // truckTypeIDTextBox
            // 
            this.truckTypeIDTextBox.Location = new System.Drawing.Point(362, 32);
            this.truckTypeIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckTypeIDTextBox.Name = "truckTypeIDTextBox";
            this.truckTypeIDTextBox.ReadOnly = true;
            this.truckTypeIDTextBox.Size = new System.Drawing.Size(35, 24);
            this.truckTypeIDTextBox.TabIndex = 25;
            // 
            // compartmentsTextBox
            // 
            this.compartmentsTextBox.Location = new System.Drawing.Point(630, 96);
            this.compartmentsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.compartmentsTextBox.Name = "compartmentsTextBox";
            this.compartmentsTextBox.ReadOnly = true;
            this.compartmentsTextBox.Size = new System.Drawing.Size(148, 24);
            this.compartmentsTextBox.TabIndex = 13;
            // 
            // steerAxleAllowanceCheckBox
            // 
            this.steerAxleAllowanceCheckBox.Enabled = false;
            this.steerAxleAllowanceCheckBox.Location = new System.Drawing.Point(426, 29);
            this.steerAxleAllowanceCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.steerAxleAllowanceCheckBox.Name = "steerAxleAllowanceCheckBox";
            this.steerAxleAllowanceCheckBox.Size = new System.Drawing.Size(107, 33);
            this.steerAxleAllowanceCheckBox.TabIndex = 9;
            this.steerAxleAllowanceCheckBox.Text = "Steer Axle";
            this.steerAxleAllowanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // trailersTextBox
            // 
            this.trailersTextBox.Location = new System.Drawing.Point(630, 64);
            this.trailersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trailersTextBox.Name = "trailersTextBox";
            this.trailersTextBox.ReadOnly = true;
            this.trailersTextBox.Size = new System.Drawing.Size(148, 24);
            this.trailersTextBox.TabIndex = 11;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.Location = new System.Drawing.Point(249, 32);
            this.txtAxleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.ReadOnly = true;
            this.txtAxleConfig.Size = new System.Drawing.Size(103, 24);
            this.txtAxleConfig.TabIndex = 23;
            // 
            // truckTypeDescriptionTextBox
            // 
            this.truckTypeDescriptionTextBox.Location = new System.Drawing.Point(249, 64);
            this.truckTypeDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckTypeDescriptionTextBox.Name = "truckTypeDescriptionTextBox";
            this.truckTypeDescriptionTextBox.ReadOnly = true;
            this.truckTypeDescriptionTextBox.Size = new System.Drawing.Size(148, 24);
            this.truckTypeDescriptionTextBox.TabIndex = 21;
            // 
            // taNHVR
            // 
            this.taNHVR.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AxleConfigurationTableAdapter = this.taAxleConfiguration;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.NHVRTableAdapter = this.taNHVR;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taAxleConfiguration
            // 
            this.taAxleConfiguration.ClearBeforeFill = true;
            // 
            // NHVR_GVM_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 495);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NHVR_GVM_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHVR_GVM_Search";
            this.Load += new System.EventHandler(this.NHVR_GVM_Search_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVR)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox truckTypeIDTextBox;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.TextBox truckTypeDescriptionTextBox;
        private System.Windows.Forms.TextBox gVMTruckTextBox;
        private System.Windows.Forms.TextBox gCMTextBox;
        private System.Windows.Forms.TextBox trTkRatioTextBox;
        private System.Windows.Forms.TextBox compartmentsTextBox;
        private System.Windows.Forms.TextBox trailersTextBox;
        private System.Windows.Forms.CheckBox steerAxleAllowanceCheckBox;
        private System.Windows.Forms.TextBox schemeCodeTextBox;
        private System.Windows.Forms.TextBox maxLengthTextBox;
        private System.Windows.Forms.TextBox couplingTextBox;
        private System.Windows.Forms.TextBox axlesTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox roadAccessTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MassMgmtRqd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SteerAxleAllowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoadAccess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMassMgmtAccred;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsNHVR;
        private dsQWSLocal2024TableAdapters.NHVRTableAdapter taNHVR;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager1;
        private dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter taAxleConfiguration;
        private System.Windows.Forms.BindingSource bsAxleConfiguration;
    }
}