
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
            System.Windows.Forms.Label bridgeAssessmentLabel;
            this.txtRego = new System.Windows.Forms.TextBox();
            this.bsVehicleDetails = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.bsConfiguredTnt = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAllConfig = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maxLengthTextBox = new System.Windows.Forms.TextBox();
            this.bsNHVL = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddVehicle2Config = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bridgeAssessmentTextBox = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.truckConfigIDTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager1 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.taConfiguredTnT = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter();
            this.taVehicleDetails = new QWS_Local.dsQWSLocalTableAdapters.VehicleDetailsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.taVehicle = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.taNHVL = new QWS_Local.dsQWSLocalTableAdapters.NHVLTableAdapter();
            this.RegoTk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoTrailer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AxleConfiguration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BridgeAssessment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bridgeAssessmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVL)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bridgeAssessmentLabel
            // 
            bridgeAssessmentLabel.AutoSize = true;
            bridgeAssessmentLabel.Location = new System.Drawing.Point(61, 374);
            bridgeAssessmentLabel.Name = "bridgeAssessmentLabel";
            bridgeAssessmentLabel.Size = new System.Drawing.Size(99, 13);
            bridgeAssessmentLabel.TabIndex = 42;
            bridgeAssessmentLabel.Text = "Bridge Assessment:";
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
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(20, 26);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(344, 20);
            this.ownerTextBox.TabIndex = 4;
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
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(370, 26);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardCodeTextBox.TabIndex = 6;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(28, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 229);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Truck Configurations";
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
            this.TareDT,
            this.configSourceDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.GCM,
            this.BridgeAssessment});
            this.dataGridView2.DataSource = this.bsConfiguredTnt;
            this.dataGridView2.Location = new System.Drawing.Point(6, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(781, 187);
            this.dataGridView2.TabIndex = 0;
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsNHVL, "MaxLength", true));
            this.maxLengthTextBox.Location = new System.Drawing.Point(822, 83);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxLengthTextBox.TabIndex = 19;
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
            this.btnAddVehicle2Config.Text = "Add Vehicle to Config";
            this.btnAddVehicle2Config.UseVisualStyleBackColor = true;
            this.btnAddVehicle2Config.Click += new System.EventHandler(this.btnAddVehicle2Config_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(bridgeAssessmentLabel);
            this.groupBox4.Controls.Add(this.bridgeAssessmentTextBox);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cardCodeTextBox);
            this.groupBox4.Controls.Add(this.ownerTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.truckConfigIDTextBox);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(716, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 416);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuration Details";
            // 
            // bridgeAssessmentTextBox
            // 
            this.bridgeAssessmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "BridgeAssessment", true));
            this.bridgeAssessmentTextBox.Location = new System.Drawing.Point(166, 371);
            this.bridgeAssessmentTextBox.Name = "bridgeAssessmentTextBox";
            this.bridgeAssessmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.bridgeAssessmentTextBox.TabIndex = 43;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "PBS_Level", true));
            this.textBox15.Location = new System.Drawing.Point(168, 240);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(27, 20);
            this.textBox15.TabIndex = 42;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTk", true));
            this.textBox4.Location = new System.Drawing.Point(20, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 20);
            this.textBox4.TabIndex = 41;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTrailer", true));
            this.textBox9.Location = new System.Drawing.Point(107, 207);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(224, 20);
            this.textBox9.TabIndex = 40;
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "TrTkRatio", true));
            this.textBox14.Location = new System.Drawing.Point(370, 316);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(71, 20);
            this.textBox14.TabIndex = 39;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "DriveAxleLoadUOM", true));
            this.textBox13.Location = new System.Drawing.Point(293, 316);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(71, 20);
            this.textBox13.TabIndex = 38;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "DriveAxleLoad", true));
            this.textBox12.Location = new System.Drawing.Point(216, 316);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(71, 20);
            this.textBox12.TabIndex = 37;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "SchemeCode", true));
            this.textBox11.Location = new System.Drawing.Point(201, 240);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(81, 20);
            this.textBox11.TabIndex = 36;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "PrefCustomer", true));
            this.textBox10.Location = new System.Drawing.Point(166, 345);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(275, 20);
            this.textBox10.TabIndex = 35;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "ConfigSource", true));
            this.textBox8.Location = new System.Drawing.Point(20, 240);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(140, 20);
            this.textBox8.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Scheme", true));
            this.textBox7.Location = new System.Drawing.Point(288, 240);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(182, 20);
            this.textBox7.TabIndex = 33;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "PrefCustomerCode", true));
            this.textBox6.Location = new System.Drawing.Point(89, 346);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(71, 20);
            this.textBox6.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "GVMTruck", true));
            this.textBox5.Location = new System.Drawing.Point(291, 289);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(73, 20);
            this.textBox5.TabIndex = 31;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(418, 207);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "ACC";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "TareTk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "TareDT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "GCM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "GVM Truck";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Payload A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Payload B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tare";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "TareTk", true));
            this.textBox3.Location = new System.Drawing.Point(89, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "TareDT", true));
            this.textBox2.Location = new System.Drawing.Point(89, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "GCM", true));
            this.textBox1.Location = new System.Drawing.Point(291, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 19;
            // 
            // truckConfigIDTextBox
            // 
            this.truckConfigIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Tare", true));
            this.truckConfigIDTextBox.Location = new System.Drawing.Point(89, 266);
            this.truckConfigIDTextBox.Name = "truckConfigIDTextBox";
            this.truckConfigIDTextBox.Size = new System.Drawing.Size(71, 20);
            this.truckConfigIDTextBox.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsConfiguredTnt, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(20, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
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
            // 
            // AxleConfiguration
            // 
            this.AxleConfiguration.DataPropertyName = "AxleConfiguration";
            this.AxleConfiguration.HeaderText = "Axle Config";
            this.AxleConfiguration.Name = "AxleConfiguration";
            this.AxleConfiguration.ReadOnly = true;
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
            // GCM
            // 
            this.GCM.DataPropertyName = "GCM";
            this.GCM.HeaderText = "GCM";
            this.GCM.Name = "GCM";
            this.GCM.ReadOnly = true;
            // 
            // BridgeAssessment
            // 
            this.BridgeAssessment.DataPropertyName = "BridgeAssessment";
            this.BridgeAssessment.HeaderText = "BridgeAssessment";
            this.BridgeAssessment.Name = "BridgeAssessment";
            this.BridgeAssessment.ReadOnly = true;
            // 
            // TruckConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 831);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.maxLengthTextBox);
            this.Controls.Add(this.btnAddVehicle2Config);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVL)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsVehicleDetails;
        private dsQWSLocalTableAdapters.VehicleDetailsTableAdapter taVehicleDetails;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.BindingSource bsVehicle;
        private dsQWSLocalTableAdapters.VehicleTableAdapter taVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddVehicle2Config;
        private dsTruckConfig dsTruckConfig;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox truckConfigIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnShowAllConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.BindingSource bsNHVL;
        private dsQWSLocalTableAdapters.NHVLTableAdapter taNHVL;
        private System.Windows.Forms.TextBox maxLengthTextBox;
        private System.Windows.Forms.BindingSource bsConfiguredTnt;
        private dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter taConfiguredTnT;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox bridgeAssessmentTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegoTk;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegoTrailer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AxleConfiguration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn configSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BridgeAssessment;
    }
}