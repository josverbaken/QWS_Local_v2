
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
            System.Windows.Forms.Label steerAxleAllowanceLabel;
            System.Windows.Forms.Label trailersLabel;
            System.Windows.Forms.Label compartmentsLabel;
            System.Windows.Forms.Label trTkRatioLabel;
            System.Windows.Forms.Label gCMLabel;
            System.Windows.Forms.Label gVMTruckLabel;
            System.Windows.Forms.Label truckTypeDescriptionLabel;
            System.Windows.Forms.Label axleConfigurationLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nHVRGVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.truckTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.truckTypeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox = new System.Windows.Forms.TextBox();
            this.gCMTextBox = new System.Windows.Forms.TextBox();
            this.trTkRatioTextBox = new System.Windows.Forms.TextBox();
            this.compartmentsTextBox = new System.Windows.Forms.TextBox();
            this.trailersTextBox = new System.Windows.Forms.TextBox();
            this.steerAxleAllowanceCheckBox = new System.Windows.Forms.CheckBox();
            this.schemeCodeTextBox = new System.Windows.Forms.TextBox();
            this.maxLengthTextBox = new System.Windows.Forms.TextBox();
            this.couplingTextBox = new System.Windows.Forms.TextBox();
            this.axlesTextBox = new System.Windows.Forms.TextBox();
            this.nHVR_GVMTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.NHVLTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteerAxleAllowance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbSchemeCode = new System.Windows.Forms.GroupBox();
            this.gbSteerAxle = new System.Windows.Forms.GroupBox();
            this.rbSchemeGML = new System.Windows.Forms.RadioButton();
            this.rbSchemeOther = new System.Windows.Forms.RadioButton();
            this.rbSchemeAll = new System.Windows.Forms.RadioButton();
            this.rbSteer05 = new System.Windows.Forms.RadioButton();
            this.rbSteerZero = new System.Windows.Forms.RadioButton();
            this.rbSteerAll = new System.Windows.Forms.RadioButton();
            this.gbTruckPlusTrailer = new System.Windows.Forms.GroupBox();
            this.rbTruckAll = new System.Windows.Forms.RadioButton();
            this.rbTruckPlusTrailer = new System.Windows.Forms.RadioButton();
            this.rbTruckOnly = new System.Windows.Forms.RadioButton();
            axlesLabel = new System.Windows.Forms.Label();
            couplingLabel = new System.Windows.Forms.Label();
            maxLengthLabel = new System.Windows.Forms.Label();
            schemeCodeLabel = new System.Windows.Forms.Label();
            steerAxleAllowanceLabel = new System.Windows.Forms.Label();
            trailersLabel = new System.Windows.Forms.Label();
            compartmentsLabel = new System.Windows.Forms.Label();
            trTkRatioLabel = new System.Windows.Forms.Label();
            gCMLabel = new System.Windows.Forms.Label();
            gVMTruckLabel = new System.Windows.Forms.Label();
            truckTypeDescriptionLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHVRGVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            this.gbSchemeCode.SuspendLayout();
            this.gbSteerAxle.SuspendLayout();
            this.gbTruckPlusTrailer.SuspendLayout();
            this.SuspendLayout();
            // 
            // axlesLabel
            // 
            axlesLabel.AutoSize = true;
            axlesLabel.Location = new System.Drawing.Point(263, 371);
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
            couplingLabel.Location = new System.Drawing.Point(240, 403);
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
            maxLengthLabel.Location = new System.Drawing.Point(222, 435);
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
            schemeCodeLabel.Location = new System.Drawing.Point(203, 467);
            schemeCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            schemeCodeLabel.Name = "schemeCodeLabel";
            schemeCodeLabel.Size = new System.Drawing.Size(107, 18);
            schemeCodeLabel.TabIndex = 6;
            schemeCodeLabel.Text = "Scheme Code:";
            schemeCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // steerAxleAllowanceLabel
            // 
            steerAxleAllowanceLabel.AutoSize = true;
            steerAxleAllowanceLabel.Location = new System.Drawing.Point(161, 502);
            steerAxleAllowanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            steerAxleAllowanceLabel.Name = "steerAxleAllowanceLabel";
            steerAxleAllowanceLabel.Size = new System.Drawing.Size(149, 18);
            steerAxleAllowanceLabel.TabIndex = 8;
            steerAxleAllowanceLabel.Text = "Steer Axle Allowance:";
            steerAxleAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trailersLabel
            // 
            trailersLabel.AutoSize = true;
            trailersLabel.Location = new System.Drawing.Point(249, 540);
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
            compartmentsLabel.Location = new System.Drawing.Point(199, 571);
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
            trTkRatioLabel.Location = new System.Drawing.Point(224, 604);
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
            gCMLabel.Location = new System.Drawing.Point(262, 635);
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
            gVMTruckLabel.Location = new System.Drawing.Point(226, 668);
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
            truckTypeDescriptionLabel.Location = new System.Drawing.Point(145, 340);
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
            axleConfigurationLabel.Location = new System.Drawing.Point(179, 307);
            axleConfigurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(131, 18);
            axleConfigurationLabel.TabIndex = 22;
            axleConfigurationLabel.Text = "Axle Configuration:";
            axleConfigurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbTruckPlusTrailer);
            this.splitContainer1.Panel2.Controls.Add(this.gbSteerAxle);
            this.splitContainer1.Panel2.Controls.Add(this.gbSchemeCode);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel2.Controls.Add(this.truckTypeIDTextBox);
            this.splitContainer1.Panel2.Controls.Add(axleConfigurationLabel);
            this.splitContainer1.Panel2.Controls.Add(this.txtAxleConfig);
            this.splitContainer1.Panel2.Controls.Add(truckTypeDescriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.truckTypeDescriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(gVMTruckLabel);
            this.splitContainer1.Panel2.Controls.Add(this.gVMTruckTextBox);
            this.splitContainer1.Panel2.Controls.Add(gCMLabel);
            this.splitContainer1.Panel2.Controls.Add(this.gCMTextBox);
            this.splitContainer1.Panel2.Controls.Add(trTkRatioLabel);
            this.splitContainer1.Panel2.Controls.Add(this.trTkRatioTextBox);
            this.splitContainer1.Panel2.Controls.Add(compartmentsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.compartmentsTextBox);
            this.splitContainer1.Panel2.Controls.Add(trailersLabel);
            this.splitContainer1.Panel2.Controls.Add(this.trailersTextBox);
            this.splitContainer1.Panel2.Controls.Add(steerAxleAllowanceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.steerAxleAllowanceCheckBox);
            this.splitContainer1.Panel2.Controls.Add(schemeCodeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.schemeCodeTextBox);
            this.splitContainer1.Panel2.Controls.Add(maxLengthLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxLengthTextBox);
            this.splitContainer1.Panel2.Controls.Add(couplingLabel);
            this.splitContainer1.Panel2.Controls.Add(this.couplingTextBox);
            this.splitContainer1.Panel2.Controls.Add(axlesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.axlesTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(931, 811);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
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
            this.SteerAxleAllowance});
            this.dataGridView1.DataSource = this.nHVRGVMBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(381, 811);
            this.dataGridView1.TabIndex = 0;
            // 
            // nHVRGVMBindingSource
            // 
            this.nHVRGVMBindingSource.DataMember = "NHVL";
            this.nHVRGVMBindingSource.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(318, 759);
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
            this.btnSelect.Location = new System.Drawing.Point(318, 713);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(148, 31);
            this.btnSelect.TabIndex = 26;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // truckTypeIDTextBox
            // 
            this.truckTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "TruckTypeID", true));
            this.truckTypeIDTextBox.Location = new System.Drawing.Point(431, 304);
            this.truckTypeIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckTypeIDTextBox.Name = "truckTypeIDTextBox";
            this.truckTypeIDTextBox.ReadOnly = true;
            this.truckTypeIDTextBox.Size = new System.Drawing.Size(35, 24);
            this.truckTypeIDTextBox.TabIndex = 25;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "AxleConfiguration", true));
            this.txtAxleConfig.Location = new System.Drawing.Point(318, 304);
            this.txtAxleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.ReadOnly = true;
            this.txtAxleConfig.Size = new System.Drawing.Size(103, 24);
            this.txtAxleConfig.TabIndex = 23;
            // 
            // truckTypeDescriptionTextBox
            // 
            this.truckTypeDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "TruckTypeDescription", true));
            this.truckTypeDescriptionTextBox.Location = new System.Drawing.Point(318, 336);
            this.truckTypeDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckTypeDescriptionTextBox.Name = "truckTypeDescriptionTextBox";
            this.truckTypeDescriptionTextBox.ReadOnly = true;
            this.truckTypeDescriptionTextBox.Size = new System.Drawing.Size(148, 24);
            this.truckTypeDescriptionTextBox.TabIndex = 21;
            // 
            // gVMTruckTextBox
            // 
            this.gVMTruckTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "GVMTruck", true));
            this.gVMTruckTextBox.Location = new System.Drawing.Point(318, 665);
            this.gVMTruckTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gVMTruckTextBox.Name = "gVMTruckTextBox";
            this.gVMTruckTextBox.ReadOnly = true;
            this.gVMTruckTextBox.Size = new System.Drawing.Size(148, 24);
            this.gVMTruckTextBox.TabIndex = 19;
            // 
            // gCMTextBox
            // 
            this.gCMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "GCM", true));
            this.gCMTextBox.Location = new System.Drawing.Point(318, 633);
            this.gCMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gCMTextBox.Name = "gCMTextBox";
            this.gCMTextBox.ReadOnly = true;
            this.gCMTextBox.Size = new System.Drawing.Size(148, 24);
            this.gCMTextBox.TabIndex = 17;
            // 
            // trTkRatioTextBox
            // 
            this.trTkRatioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "TrTkRatio", true));
            this.trTkRatioTextBox.Location = new System.Drawing.Point(318, 601);
            this.trTkRatioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trTkRatioTextBox.Name = "trTkRatioTextBox";
            this.trTkRatioTextBox.ReadOnly = true;
            this.trTkRatioTextBox.Size = new System.Drawing.Size(148, 24);
            this.trTkRatioTextBox.TabIndex = 15;
            // 
            // compartmentsTextBox
            // 
            this.compartmentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "Compartments", true));
            this.compartmentsTextBox.Location = new System.Drawing.Point(318, 569);
            this.compartmentsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.compartmentsTextBox.Name = "compartmentsTextBox";
            this.compartmentsTextBox.ReadOnly = true;
            this.compartmentsTextBox.Size = new System.Drawing.Size(148, 24);
            this.compartmentsTextBox.TabIndex = 13;
            // 
            // trailersTextBox
            // 
            this.trailersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "Trailers", true));
            this.trailersTextBox.Location = new System.Drawing.Point(318, 537);
            this.trailersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trailersTextBox.Name = "trailersTextBox";
            this.trailersTextBox.ReadOnly = true;
            this.trailersTextBox.Size = new System.Drawing.Size(148, 24);
            this.trailersTextBox.TabIndex = 11;
            // 
            // steerAxleAllowanceCheckBox
            // 
            this.steerAxleAllowanceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nHVRGVMBindingSource, "SteerAxleAllowance", true));
            this.steerAxleAllowanceCheckBox.Enabled = false;
            this.steerAxleAllowanceCheckBox.Location = new System.Drawing.Point(318, 496);
            this.steerAxleAllowanceCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.steerAxleAllowanceCheckBox.Name = "steerAxleAllowanceCheckBox";
            this.steerAxleAllowanceCheckBox.Size = new System.Drawing.Size(156, 33);
            this.steerAxleAllowanceCheckBox.TabIndex = 9;
            this.steerAxleAllowanceCheckBox.Text = " ";
            this.steerAxleAllowanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // schemeCodeTextBox
            // 
            this.schemeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "SchemeCode", true));
            this.schemeCodeTextBox.Location = new System.Drawing.Point(318, 464);
            this.schemeCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.schemeCodeTextBox.Name = "schemeCodeTextBox";
            this.schemeCodeTextBox.ReadOnly = true;
            this.schemeCodeTextBox.Size = new System.Drawing.Size(148, 24);
            this.schemeCodeTextBox.TabIndex = 7;
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "MaxLength", true));
            this.maxLengthTextBox.Location = new System.Drawing.Point(318, 432);
            this.maxLengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.ReadOnly = true;
            this.maxLengthTextBox.Size = new System.Drawing.Size(148, 24);
            this.maxLengthTextBox.TabIndex = 5;
            // 
            // couplingTextBox
            // 
            this.couplingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "Coupling", true));
            this.couplingTextBox.Location = new System.Drawing.Point(318, 400);
            this.couplingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.couplingTextBox.Name = "couplingTextBox";
            this.couplingTextBox.ReadOnly = true;
            this.couplingTextBox.Size = new System.Drawing.Size(148, 24);
            this.couplingTextBox.TabIndex = 3;
            // 
            // axlesTextBox
            // 
            this.axlesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHVRGVMBindingSource, "Axles", true));
            this.axlesTextBox.Location = new System.Drawing.Point(318, 368);
            this.axlesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axlesTextBox.Name = "axlesTextBox";
            this.axlesTextBox.ReadOnly = true;
            this.axlesTextBox.Size = new System.Drawing.Size(148, 24);
            this.axlesTextBox.TabIndex = 1;
            // 
            // nHVR_GVMTableAdapter
            // 
            this.nHVR_GVMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NHVLTableAdapter = this.nHVR_GVMTableAdapter;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            this.axleConfigurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            this.schemeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SteerAxleAllowance
            // 
            this.SteerAxleAllowance.DataPropertyName = "SteerAxleAllowance";
            this.SteerAxleAllowance.HeaderText = "SteerAxleAllowance";
            this.SteerAxleAllowance.Name = "SteerAxleAllowance";
            this.SteerAxleAllowance.ReadOnly = true;
            // 
            // gbSchemeCode
            // 
            this.gbSchemeCode.Controls.Add(this.rbSchemeAll);
            this.gbSchemeCode.Controls.Add(this.rbSchemeOther);
            this.gbSchemeCode.Controls.Add(this.rbSchemeGML);
            this.gbSchemeCode.Location = new System.Drawing.Point(105, 31);
            this.gbSchemeCode.Name = "gbSchemeCode";
            this.gbSchemeCode.Size = new System.Drawing.Size(361, 74);
            this.gbSchemeCode.TabIndex = 29;
            this.gbSchemeCode.TabStop = false;
            this.gbSchemeCode.Text = "Scheme Code Filter";
            // 
            // gbSteerAxle
            // 
            this.gbSteerAxle.Controls.Add(this.rbSteerAll);
            this.gbSteerAxle.Controls.Add(this.rbSteerZero);
            this.gbSteerAxle.Controls.Add(this.rbSteer05);
            this.gbSteerAxle.Location = new System.Drawing.Point(105, 111);
            this.gbSteerAxle.Name = "gbSteerAxle";
            this.gbSteerAxle.Size = new System.Drawing.Size(361, 83);
            this.gbSteerAxle.TabIndex = 30;
            this.gbSteerAxle.TabStop = false;
            this.gbSteerAxle.Text = "Steer Axle Filter";
            // 
            // rbSchemeGML
            // 
            this.rbSchemeGML.AutoSize = true;
            this.rbSchemeGML.Location = new System.Drawing.Point(20, 39);
            this.rbSchemeGML.Name = "rbSchemeGML";
            this.rbSchemeGML.Size = new System.Drawing.Size(59, 22);
            this.rbSchemeGML.TabIndex = 0;
            this.rbSchemeGML.TabStop = true;
            this.rbSchemeGML.Text = "GML";
            this.rbSchemeGML.UseVisualStyleBackColor = true;
            this.rbSchemeGML.CheckedChanged += new System.EventHandler(this.rbSchemeGML_CheckedChanged);
            // 
            // rbSchemeOther
            // 
            this.rbSchemeOther.AutoSize = true;
            this.rbSchemeOther.Location = new System.Drawing.Point(124, 39);
            this.rbSchemeOther.Name = "rbSchemeOther";
            this.rbSchemeOther.Size = new System.Drawing.Size(63, 22);
            this.rbSchemeOther.TabIndex = 1;
            this.rbSchemeOther.TabStop = true;
            this.rbSchemeOther.Text = "Other";
            this.rbSchemeOther.UseVisualStyleBackColor = true;
            this.rbSchemeOther.CheckedChanged += new System.EventHandler(this.rbSchemeOther_CheckedChanged);
            // 
            // rbSchemeAll
            // 
            this.rbSchemeAll.AutoSize = true;
            this.rbSchemeAll.Location = new System.Drawing.Point(278, 39);
            this.rbSchemeAll.Name = "rbSchemeAll";
            this.rbSchemeAll.Size = new System.Drawing.Size(61, 22);
            this.rbSchemeAll.TabIndex = 2;
            this.rbSchemeAll.TabStop = true;
            this.rbSchemeAll.Text = "Clear";
            this.rbSchemeAll.UseVisualStyleBackColor = true;
            this.rbSchemeAll.CheckedChanged += new System.EventHandler(this.rbSchemeAll_CheckedChanged);
            // 
            // rbSteer05
            // 
            this.rbSteer05.AutoSize = true;
            this.rbSteer05.Location = new System.Drawing.Point(20, 40);
            this.rbSteer05.Name = "rbSteer05";
            this.rbSteer05.Size = new System.Drawing.Size(54, 22);
            this.rbSteer05.TabIndex = 0;
            this.rbSteer05.TabStop = true;
            this.rbSteer05.Text = "0.5 t";
            this.rbSteer05.UseVisualStyleBackColor = true;
            this.rbSteer05.CheckedChanged += new System.EventHandler(this.rbSteer05_CheckedChanged);
            // 
            // rbSteerZero
            // 
            this.rbSteerZero.AutoSize = true;
            this.rbSteerZero.Location = new System.Drawing.Point(124, 40);
            this.rbSteerZero.Name = "rbSteerZero";
            this.rbSteerZero.Size = new System.Drawing.Size(46, 22);
            this.rbSteerZero.TabIndex = 1;
            this.rbSteerZero.TabStop = true;
            this.rbSteerZero.Text = "n/a";
            this.rbSteerZero.UseVisualStyleBackColor = true;
            this.rbSteerZero.CheckedChanged += new System.EventHandler(this.rbSteerZero_CheckedChanged);
            // 
            // rbSteerAll
            // 
            this.rbSteerAll.AutoSize = true;
            this.rbSteerAll.Location = new System.Drawing.Point(278, 40);
            this.rbSteerAll.Name = "rbSteerAll";
            this.rbSteerAll.Size = new System.Drawing.Size(61, 22);
            this.rbSteerAll.TabIndex = 2;
            this.rbSteerAll.TabStop = true;
            this.rbSteerAll.Text = "Clear";
            this.rbSteerAll.UseVisualStyleBackColor = true;
            this.rbSteerAll.CheckedChanged += new System.EventHandler(this.rbSteerAll_CheckedChanged);
            // 
            // gbTruckPlusTrailer
            // 
            this.gbTruckPlusTrailer.Controls.Add(this.rbTruckAll);
            this.gbTruckPlusTrailer.Controls.Add(this.rbTruckPlusTrailer);
            this.gbTruckPlusTrailer.Controls.Add(this.rbTruckOnly);
            this.gbTruckPlusTrailer.Location = new System.Drawing.Point(105, 200);
            this.gbTruckPlusTrailer.Name = "gbTruckPlusTrailer";
            this.gbTruckPlusTrailer.Size = new System.Drawing.Size(361, 83);
            this.gbTruckPlusTrailer.TabIndex = 31;
            this.gbTruckPlusTrailer.TabStop = false;
            this.gbTruckPlusTrailer.Text = "Truck Config";
            // 
            // rbTruckAll
            // 
            this.rbTruckAll.AutoSize = true;
            this.rbTruckAll.Location = new System.Drawing.Point(278, 40);
            this.rbTruckAll.Name = "rbTruckAll";
            this.rbTruckAll.Size = new System.Drawing.Size(61, 22);
            this.rbTruckAll.TabIndex = 2;
            this.rbTruckAll.TabStop = true;
            this.rbTruckAll.Text = "Clear";
            this.rbTruckAll.UseVisualStyleBackColor = true;
            this.rbTruckAll.CheckedChanged += new System.EventHandler(this.rbTruckAll_CheckedChanged);
            // 
            // rbTruckPlusTrailer
            // 
            this.rbTruckPlusTrailer.AutoSize = true;
            this.rbTruckPlusTrailer.Location = new System.Drawing.Point(124, 40);
            this.rbTruckPlusTrailer.Name = "rbTruckPlusTrailer";
            this.rbTruckPlusTrailer.Size = new System.Drawing.Size(135, 22);
            this.rbTruckPlusTrailer.TabIndex = 1;
            this.rbTruckPlusTrailer.TabStop = true;
            this.rbTruckPlusTrailer.Text = "Truck plus trailer";
            this.rbTruckPlusTrailer.UseVisualStyleBackColor = true;
            this.rbTruckPlusTrailer.CheckedChanged += new System.EventHandler(this.rbTruckPlusTrailer_CheckedChanged);
            // 
            // rbTruckOnly
            // 
            this.rbTruckOnly.AutoSize = true;
            this.rbTruckOnly.Location = new System.Drawing.Point(20, 40);
            this.rbTruckOnly.Name = "rbTruckOnly";
            this.rbTruckOnly.Size = new System.Drawing.Size(98, 22);
            this.rbTruckOnly.TabIndex = 0;
            this.rbTruckOnly.TabStop = true;
            this.rbTruckOnly.Text = "Truck Only";
            this.rbTruckOnly.UseVisualStyleBackColor = true;
            this.rbTruckOnly.CheckedChanged += new System.EventHandler(this.rbTruckOnly_CheckedChanged);
            // 
            // NHVR_GVM_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 811);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NHVR_GVM_Search";
            this.Text = "NHVR_GVM_Search";
            this.Load += new System.EventHandler(this.NHVR_GVM_Search_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHVRGVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            this.gbSchemeCode.ResumeLayout(false);
            this.gbSchemeCode.PerformLayout();
            this.gbSteerAxle.ResumeLayout(false);
            this.gbSteerAxle.PerformLayout();
            this.gbTruckPlusTrailer.ResumeLayout(false);
            this.gbTruckPlusTrailer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource nHVRGVMBindingSource;
        private dsQWSLocalTableAdapters.NHVLTableAdapter nHVR_GVMTableAdapter;
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
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SteerAxleAllowance;
        private System.Windows.Forms.GroupBox gbSteerAxle;
        private System.Windows.Forms.RadioButton rbSteerAll;
        private System.Windows.Forms.RadioButton rbSteerZero;
        private System.Windows.Forms.RadioButton rbSteer05;
        private System.Windows.Forms.GroupBox gbSchemeCode;
        private System.Windows.Forms.RadioButton rbSchemeAll;
        private System.Windows.Forms.RadioButton rbSchemeOther;
        private System.Windows.Forms.RadioButton rbSchemeGML;
        private System.Windows.Forms.GroupBox gbTruckPlusTrailer;
        private System.Windows.Forms.RadioButton rbTruckAll;
        private System.Windows.Forms.RadioButton rbTruckPlusTrailer;
        private System.Windows.Forms.RadioButton rbTruckOnly;
    }
}