
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
            System.Windows.Forms.Label axleConfigurationLabel;
            System.Windows.Forms.Label feeCodeLabel;
            System.Windows.Forms.Label vehicleDescriptionLabel;
            System.Windows.Forms.Label truckConfigIDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.bsVehicleDetails = new System.Windows.Forms.BindingSource(this.components);
            this.taVehicleDetails = new QWS_Local.dsQWSLocalTableAdapters.VehicleDetailsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.vehicleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.pbSchematic = new System.Windows.Forms.PictureBox();
            this.chkIsLeadVehicle = new System.Windows.Forms.CheckBox();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.taVehicle = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.bsTruckConfigDetails = new System.Windows.Forms.BindingSource(this.components);
            this.taTruckConfigDetails = new QWS_Local.dsTruckConfigTableAdapters.TruckConfigDetailsTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.truckConfigIDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bsTruckConfigVehicleList = new System.Windows.Forms.BindingSource(this.components);
            this.taTruckConfigVehicleList = new QWS_Local.dsTruckConfigTableAdapters.TruckConfigVehicleListTableAdapter();
            this.regoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            feeCodeLabel = new System.Windows.Forms.Label();
            vehicleDescriptionLabel = new System.Windows.Forms.Label();
            truckConfigIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckConfigDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckConfigVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(271, 254);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(95, 13);
            axleConfigurationLabel.TabIndex = 7;
            axleConfigurationLabel.Text = "Axle Configuration:";
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(310, 64);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(56, 13);
            feeCodeLabel.TabIndex = 9;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // vehicleDescriptionLabel
            // 
            vehicleDescriptionLabel.AutoSize = true;
            vehicleDescriptionLabel.Location = new System.Drawing.Point(161, 280);
            vehicleDescriptionLabel.Name = "vehicleDescriptionLabel";
            vehicleDescriptionLabel.Size = new System.Drawing.Size(101, 13);
            vehicleDescriptionLabel.TabIndex = 11;
            vehicleDescriptionLabel.Text = "Vehicle Description:";
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsVehicleDetails
            // 
            this.bsVehicleDetails.DataMember = "VehicleDetails";
            this.bsVehicleDetails.DataSource = this.dsQWSLocal;
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
            this.tableAdapterManager.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.VehicleTypeTableAdapter = null;
            // 
            // txtRego
            // 
            this.txtRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "Rego", true));
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.Location = new System.Drawing.Point(22, 61);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(100, 24);
            this.txtRego.TabIndex = 3;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(22, 35);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(344, 20);
            this.ownerTextBox.TabIndex = 4;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(372, 35);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardCodeTextBox.TabIndex = 6;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(372, 251);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.axleConfigurationTextBox.TabIndex = 8;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(372, 61);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.feeCodeTextBox.TabIndex = 10;
            // 
            // vehicleDescriptionTextBox
            // 
            this.vehicleDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.vehicleDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "VehicleDescription", true));
            this.vehicleDescriptionTextBox.Location = new System.Drawing.Point(268, 277);
            this.vehicleDescriptionTextBox.Name = "vehicleDescriptionTextBox";
            this.vehicleDescriptionTextBox.ReadOnly = true;
            this.vehicleDescriptionTextBox.Size = new System.Drawing.Size(204, 20);
            this.vehicleDescriptionTextBox.TabIndex = 12;
            // 
            // pbSchematic
            // 
            this.pbSchematic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSchematic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsVehicleDetails, "Schematic", true));
            this.pbSchematic.Location = new System.Drawing.Point(22, 93);
            this.pbSchematic.Name = "pbSchematic";
            this.pbSchematic.Size = new System.Drawing.Size(450, 150);
            this.pbSchematic.TabIndex = 14;
            this.pbSchematic.TabStop = false;
            // 
            // chkIsLeadVehicle
            // 
            this.chkIsLeadVehicle.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsVehicleDetails, "IsLeadVehicle", true));
            this.chkIsLeadVehicle.Enabled = false;
            this.chkIsLeadVehicle.Location = new System.Drawing.Point(22, 249);
            this.chkIsLeadVehicle.Name = "chkIsLeadVehicle";
            this.chkIsLeadVehicle.Size = new System.Drawing.Size(104, 24);
            this.chkIsLeadVehicle.TabIndex = 16;
            this.chkIsLeadVehicle.Text = "Is Lead Vehicle";
            this.chkIsLeadVehicle.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn,
            this.axleConfigurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsVehicle;
            this.dataGridView1.Location = new System.Drawing.Point(20, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(266, 278);
            this.dataGridView1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindVehicle);
            this.groupBox1.Controls.Add(this.cardCodeTextBox);
            this.groupBox1.Controls.Add(this.txtRego);
            this.groupBox1.Controls.Add(this.chkIsLeadVehicle);
            this.groupBox1.Controls.Add(this.ownerTextBox);
            this.groupBox1.Controls.Add(this.pbSchematic);
            this.groupBox1.Controls.Add(this.axleConfigurationTextBox);
            this.groupBox1.Controls.Add(vehicleDescriptionLabel);
            this.groupBox1.Controls.Add(axleConfigurationLabel);
            this.groupBox1.Controls.Add(this.vehicleDescriptionTextBox);
            this.groupBox1.Controls.Add(this.feeCodeTextBox);
            this.groupBox1.Controls.Add(feeCodeLabel);
            this.groupBox1.Location = new System.Drawing.Point(28, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 315);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Vehicle Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(28, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 229);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Truck Configurations";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(558, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 315);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Vehicles";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(316, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 42);
            this.button4.TabIndex = 21;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(316, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 42);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(316, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(truckConfigIDLabel);
            this.groupBox4.Controls.Add(this.truckConfigIDTextBox);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(558, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 236);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuration Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsTruckConfigDetails, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(20, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsTruckConfigDetails
            // 
            this.bsTruckConfigDetails.DataMember = "TruckConfigDetails";
            this.bsTruckConfigDetails.DataSource = this.dsTruckConfig;
            // 
            // taTruckConfigDetails
            // 
            this.taTruckConfigDetails.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // truckConfigIDLabel
            // 
            truckConfigIDLabel.AutoSize = true;
            truckConfigIDLabel.Location = new System.Drawing.Point(16, 199);
            truckConfigIDLabel.Name = "truckConfigIDLabel";
            truckConfigIDLabel.Size = new System.Drawing.Size(85, 13);
            truckConfigIDLabel.TabIndex = 17;
            truckConfigIDLabel.Text = "Truck Config ID:";
            // 
            // truckConfigIDTextBox
            // 
            this.truckConfigIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckConfigDetails, "TruckConfigID", true));
            this.truckConfigIDTextBox.Location = new System.Drawing.Point(107, 196);
            this.truckConfigIDTextBox.Name = "truckConfigIDTextBox";
            this.truckConfigIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.truckConfigIDTextBox.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn1,
            this.positionDataGridViewTextBoxColumn,
            this.axleConfigurationDataGridViewTextBoxColumn1,
            this.vehicleDescriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsTruckConfigVehicleList;
            this.dataGridView2.Location = new System.Drawing.Point(6, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(466, 187);
            this.dataGridView2.TabIndex = 0;
            // 
            // bsTruckConfigVehicleList
            // 
            this.bsTruckConfigVehicleList.DataMember = "TruckConfigVehicleList";
            this.bsTruckConfigVehicleList.DataSource = this.dsTruckConfig;
            this.bsTruckConfigVehicleList.CurrentChanged += new System.EventHandler(this.bsTruckConfigVehicleList_CurrentChanged);
            // 
            // taTruckConfigVehicleList
            // 
            this.taTruckConfigVehicleList.ClearBeforeFill = true;
            // 
            // regoDataGridViewTextBoxColumn1
            // 
            this.regoDataGridViewTextBoxColumn1.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn1.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn1.Name = "regoDataGridViewTextBoxColumn1";
            this.regoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axleConfigurationDataGridViewTextBoxColumn1
            // 
            this.axleConfigurationDataGridViewTextBoxColumn1.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn1.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn1.Name = "axleConfigurationDataGridViewTextBoxColumn1";
            this.axleConfigurationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vehicleDescriptionDataGridViewTextBoxColumn
            // 
            this.vehicleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VehicleDescription";
            this.vehicleDescriptionDataGridViewTextBoxColumn.HeaderText = "VehicleDescription";
            this.vehicleDescriptionDataGridViewTextBoxColumn.Name = "vehicleDescriptionDataGridViewTextBoxColumn";
            this.vehicleDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindVehicle.Location = new System.Drawing.Point(128, 61);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(120, 24);
            this.btnFindVehicle.TabIndex = 17;
            this.btnFindVehicle.Text = "Search";
            this.btnFindVehicle.UseVisualStyleBackColor = true;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckConfigDetails, "AxleConfiguration", true));
            this.textBox1.Location = new System.Drawing.Point(213, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckConfigDetails, "SchemeCode", true));
            this.textBox2.Location = new System.Drawing.Point(319, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.regoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            this.regoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.axleConfigurationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "Axle Config";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            this.axleConfigurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TruckConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 761);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TruckConfiguration";
            this.Text = "TruckConfiguration";
            this.Load += new System.EventHandler(this.TruckConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckConfigDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckConfigVehicleList)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.TextBox vehicleDescriptionTextBox;
        private System.Windows.Forms.PictureBox pbSchematic;
        private System.Windows.Forms.CheckBox chkIsLeadVehicle;
        private System.Windows.Forms.BindingSource bsVehicle;
        private dsQWSLocalTableAdapters.VehicleTableAdapter taVehicle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource bsTruckConfigDetails;
        private dsTruckConfigTableAdapters.TruckConfigDetailsTableAdapter taTruckConfigDetails;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox truckConfigIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTruckConfigVehicleList;
        private dsTruckConfigTableAdapters.TruckConfigVehicleListTableAdapter taTruckConfigVehicleList;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
    }
}