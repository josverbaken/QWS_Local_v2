
namespace QWS_Local
{
    partial class VehicleMaintenance
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
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label expiryDTLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label jurisdictionLabel1;
            System.Windows.Forms.Label tareLabel1;
            System.Windows.Forms.Label tareDTLabel;
            this.txtRego = new System.Windows.Forms.TextBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.btnFeeCodesMore = new System.Windows.Forms.Button();
            this.txtJurisdiction = new System.Windows.Forms.TextBox();
            this.vehicleRegFeeCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRegoExpiryDT = new System.Windows.Forms.TextBox();
            this.btnIdentificationSave = new System.Windows.Forms.Button();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.btnSetTruckOwner = new System.Windows.Forms.Button();
            this.btnSetAxleConfig = new System.Windows.Forms.Button();
            this.btnSetFeeCodeMain = new System.Windows.Forms.Button();
            this.txtFeeCode = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axleConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNextAction = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkForceRetare = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tareTextBox1 = new System.Windows.Forms.TextBox();
            this.jurisdictionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.vehicleRegFeeCodesTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.VehicleRegFeeCodesTableAdapter();
            this.jurisdictionTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.JurisdictionTableAdapter();
            this.axleConfigurationTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.AxleConfigurationTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfigureGVM = new System.Windows.Forms.Button();
            this.btnVehicleAdd = new System.Windows.Forms.Button();
            this.btnTrailerAdd = new System.Windows.Forms.Button();
            this.rbAddTrailer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigTnTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVMTruckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckConfigTruckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.truckConfigTruckTableAdapter = new QWS_Local.dsTruckConfigTableAdapters.TruckConfigTruckTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.regoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDTTMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truck2TrailerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckConfigTruckTruckConfigTrailerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckConfigTrailerTableAdapter = new QWS_Local.dsTruckConfigTableAdapters.TruckConfigTrailerTableAdapter();
            this.truckConfigTrailerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.unconfiguredVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unconfiguredVehiclesTableAdapter = new QWS_Local.dsTruckConfigTableAdapters.UnconfiguredVehiclesTableAdapter();
            this.regoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDTTMDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regoLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            expiryDTLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            jurisdictionLabel1 = new System.Windows.Forms.Label();
            tareLabel1 = new System.Windows.Forms.Label();
            tareDTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegFeeCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jurisdictionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckConfigTruckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck2TrailerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckConfigTruckTruckConfigTrailerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckConfigTrailerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unconfiguredVehiclesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(123, 33);
            regoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(48, 18);
            regoLabel.TabIndex = 1;
            regoLabel.Text = "Rego:";
            regoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(142, 86);
            vINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(35, 18);
            vINLabel.TabIndex = 3;
            vINLabel.Text = "VIN:";
            vINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(111, 121);
            ownerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(56, 18);
            ownerLabel.TabIndex = 7;
            ownerLabel.Text = "Owner:";
            ownerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(121, 165);
            makeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(49, 18);
            makeLabel.TabIndex = 9;
            makeLabel.Text = "Make:";
            makeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(115, 201);
            modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(53, 18);
            modelLabel.TabIndex = 11;
            modelLabel.Text = "Model:";
            modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(50, 267);
            tareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(117, 18);
            tareLabel.TabIndex = 13;
            tareLabel.Text = "Registered Tare:";
            tareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // expiryDTLabel
            // 
            expiryDTLabel.AutoSize = true;
            expiryDTLabel.Location = new System.Drawing.Point(91, 235);
            expiryDTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            expiryDTLabel.Name = "expiryDTLabel";
            expiryDTLabel.Size = new System.Drawing.Size(76, 18);
            expiryDTLabel.TabIndex = 19;
            expiryDTLabel.Text = "Expiry DT:";
            expiryDTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(684, 234);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 18);
            label2.TabIndex = 27;
            label2.Text = "Axle Config:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(684, 72);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 18);
            label3.TabIndex = 33;
            label3.Text = "Fee Code :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jurisdictionLabel1
            // 
            jurisdictionLabel1.AutoSize = true;
            jurisdictionLabel1.Location = new System.Drawing.Point(674, 38);
            jurisdictionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jurisdictionLabel1.Name = "jurisdictionLabel1";
            jurisdictionLabel1.Size = new System.Drawing.Size(87, 18);
            jurisdictionLabel1.TabIndex = 45;
            jurisdictionLabel1.Text = "Jurisdiction:";
            jurisdictionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tareLabel1
            // 
            tareLabel1.AutoSize = true;
            tareLabel1.Location = new System.Drawing.Point(86, 46);
            tareLabel1.Name = "tareLabel1";
            tareLabel1.Size = new System.Drawing.Size(42, 18);
            tareLabel1.TabIndex = 0;
            tareLabel1.Text = "Tare:";
            // 
            // tareDTLabel
            // 
            tareDTLabel.AutoSize = true;
            tareDTLabel.Location = new System.Drawing.Point(59, 87);
            tareDTLabel.Name = "tareDTLabel";
            tareDTLabel.Size = new System.Drawing.Size(66, 18);
            tareDTLabel.TabIndex = 2;
            tareDTLabel.Text = "Tare DT:";
            // 
            // txtRego
            // 
            this.txtRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Rego", true));
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRego.Location = new System.Drawing.Point(208, 24);
            this.txtRego.Margin = new System.Windows.Forms.Padding(4);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(232, 35);
            this.txtRego.TabIndex = 1;
            this.txtRego.Text = "Rego or Owner";
            this.toolTip1.SetToolTip(this.txtRego, "Search by Rego or Owner");
            this.txtRego.Click += new System.EventHandler(this.txtRego_Click);
            this.txtRego.Enter += new System.EventHandler(this.txtRego_Enter);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(208, 78);
            this.vINTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vINTextBox.MaxLength = 16;
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(355, 24);
            this.vINTextBox.TabIndex = 3;
            this.vINTextBox.Enter += new System.EventHandler(this.vINTextBox_Enter);
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(208, 113);
            this.ownerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.ReadOnly = true;
            this.ownerTextBox.Size = new System.Drawing.Size(280, 24);
            this.ownerTextBox.TabIndex = 8;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(208, 157);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(355, 24);
            this.makeTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(208, 193);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(355, 24);
            this.modelTextBox.TabIndex = 6;
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "RegisteredTare", true));
            this.tareTextBox.Location = new System.Drawing.Point(209, 264);
            this.tareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(148, 24);
            this.tareTextBox.TabIndex = 8;
            // 
            // btnFeeCodesMore
            // 
            this.btnFeeCodesMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFeeCodesMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeCodesMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeeCodesMore.Location = new System.Drawing.Point(947, 69);
            this.btnFeeCodesMore.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeeCodesMore.Name = "btnFeeCodesMore";
            this.btnFeeCodesMore.Size = new System.Drawing.Size(56, 33);
            this.btnFeeCodesMore.TabIndex = 47;
            this.btnFeeCodesMore.TabStop = false;
            this.btnFeeCodesMore.Text = "...";
            this.btnFeeCodesMore.UseVisualStyleBackColor = false;
            this.btnFeeCodesMore.Click += new System.EventHandler(this.btnFeeCodesMore_Click);
            // 
            // txtJurisdiction
            // 
            this.txtJurisdiction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "Jurisdiction", true));
            this.txtJurisdiction.Location = new System.Drawing.Point(771, 35);
            this.txtJurisdiction.Margin = new System.Windows.Forms.Padding(4);
            this.txtJurisdiction.Name = "txtJurisdiction";
            this.txtJurisdiction.Size = new System.Drawing.Size(148, 24);
            this.txtJurisdiction.TabIndex = 9;
            // 
            // vehicleRegFeeCodesBindingSource
            // 
            this.vehicleRegFeeCodesBindingSource.DataMember = "VehicleRegFeeCodes";
            this.vehicleRegFeeCodesBindingSource.DataSource = this.dsQWSLocal;
            // 
            // txtRegoExpiryDT
            // 
            this.txtRegoExpiryDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "ExpiryDT", true));
            this.txtRegoExpiryDT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRegoExpiryDT.Location = new System.Drawing.Point(208, 232);
            this.txtRegoExpiryDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegoExpiryDT.Name = "txtRegoExpiryDT";
            this.txtRegoExpiryDT.Size = new System.Drawing.Size(354, 24);
            this.txtRegoExpiryDT.TabIndex = 7;
            this.txtRegoExpiryDT.Click += new System.EventHandler(this.txtRegoExpiryDT_Click);
            this.txtRegoExpiryDT.Enter += new System.EventHandler(this.txtRegoExpiryDT_Enter);
            // 
            // btnIdentificationSave
            // 
            this.btnIdentificationSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIdentificationSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentificationSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificationSave.Location = new System.Drawing.Point(678, 493);
            this.btnIdentificationSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdentificationSave.Name = "btnIdentificationSave";
            this.btnIdentificationSave.Size = new System.Drawing.Size(448, 42);
            this.btnIdentificationSave.TabIndex = 13;
            this.btnIdentificationSave.Text = "Save";
            this.btnIdentificationSave.UseVisualStyleBackColor = false;
            this.btnIdentificationSave.Click += new System.EventHandler(this.btnIdentificationSave_Click);
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindVehicle.BackgroundImage = global::QWS_Local.Properties.Resources.Search_2;
            this.btnFindVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindVehicle.Location = new System.Drawing.Point(488, 24);
            this.btnFindVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(75, 48);
            this.btnFindVehicle.TabIndex = 2;
            this.btnFindVehicle.Text = " ";
            this.btnFindVehicle.UseVisualStyleBackColor = false;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // btnSetTruckOwner
            // 
            this.btnSetTruckOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetTruckOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTruckOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTruckOwner.Location = new System.Drawing.Point(501, 113);
            this.btnSetTruckOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetTruckOwner.Name = "btnSetTruckOwner";
            this.btnSetTruckOwner.Size = new System.Drawing.Size(61, 25);
            this.btnSetTruckOwner.TabIndex = 4;
            this.btnSetTruckOwner.Text = "Set";
            this.btnSetTruckOwner.UseVisualStyleBackColor = false;
            this.btnSetTruckOwner.Click += new System.EventHandler(this.btnSetTruckOwner_Click);
            // 
            // btnSetAxleConfig
            // 
            this.btnSetAxleConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetAxleConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAxleConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAxleConfig.Location = new System.Drawing.Point(944, 224);
            this.btnSetAxleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetAxleConfig.Name = "btnSetAxleConfig";
            this.btnSetAxleConfig.Size = new System.Drawing.Size(182, 33);
            this.btnSetAxleConfig.TabIndex = 12;
            this.btnSetAxleConfig.Text = "Set";
            this.btnSetAxleConfig.UseVisualStyleBackColor = false;
            this.btnSetAxleConfig.Click += new System.EventHandler(this.btnSetAxleConfig_Click);
            // 
            // btnSetFeeCodeMain
            // 
            this.btnSetFeeCodeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetFeeCodeMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetFeeCodeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFeeCodeMain.Location = new System.Drawing.Point(1010, 69);
            this.btnSetFeeCodeMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetFeeCodeMain.Name = "btnSetFeeCodeMain";
            this.btnSetFeeCodeMain.Size = new System.Drawing.Size(116, 33);
            this.btnSetFeeCodeMain.TabIndex = 11;
            this.btnSetFeeCodeMain.Text = "Set";
            this.btnSetFeeCodeMain.UseVisualStyleBackColor = false;
            this.btnSetFeeCodeMain.Click += new System.EventHandler(this.btnSetFeeCodeMain_Click);
            // 
            // txtFeeCode
            // 
            this.txtFeeCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "FeeCode", true));
            this.txtFeeCode.Location = new System.Drawing.Point(773, 69);
            this.txtFeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.Size = new System.Drawing.Size(148, 24);
            this.txtFeeCode.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "AxleConfiguration", true));
            this.textBox2.Location = new System.Drawing.Point(778, 231);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(148, 24);
            this.textBox2.TabIndex = 13;
            this.textBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.axleConfigurationBindingSource, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(676, 319);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // axleConfigurationBindingSource
            // 
            this.axleConfigurationBindingSource.DataMember = "AxleConfiguration";
            this.axleConfigurationBindingSource.DataSource = this.dsQWSLocal;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.axleConfigurationBindingSource, "VehicleDescription", true));
            this.textBox8.Location = new System.Drawing.Point(678, 270);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(448, 24);
            this.textBox8.TabIndex = 36;
            this.textBox8.TabStop = false;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "FeeConditions", true));
            this.textBox1.Location = new System.Drawing.Point(678, 143);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(448, 73);
            this.textBox1.TabIndex = 34;
            this.textBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleRegFeeCodesBindingSource, "FeeType", true));
            this.textBox6.Location = new System.Drawing.Point(678, 111);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(448, 24);
            this.textBox6.TabIndex = 32;
            this.textBox6.TabStop = false;
            // 
            // lblNextAction
            // 
            this.lblNextAction.AutoSize = true;
            this.lblNextAction.Location = new System.Drawing.Point(40, 517);
            this.lblNextAction.Name = "lblNextAction";
            this.lblNextAction.Size = new System.Drawing.Size(20, 18);
            this.lblNextAction.TabIndex = 48;
            this.lblNextAction.Text = "...";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(448, 23);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(31, 49);
            this.btnAddVehicle.TabIndex = 49;
            this.btnAddVehicle.Text = "+";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.bthAddVehicle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.chkForceRetare);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(tareDTLabel);
            this.groupBox1.Controls.Add(tareLabel1);
            this.groupBox1.Controls.Add(this.tareTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(43, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 170);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operating Tare";
            // 
            // chkForceRetare
            // 
            this.chkForceRetare.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehicleBindingSource, "ForceRetare", true));
            this.chkForceRetare.Location = new System.Drawing.Point(164, 127);
            this.chkForceRetare.Name = "chkForceRetare";
            this.chkForceRetare.Size = new System.Drawing.Size(138, 24);
            this.chkForceRetare.TabIndex = 5;
            this.chkForceRetare.Text = "Force Retare";
            this.chkForceRetare.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "TareDT", true));
            this.textBox3.Location = new System.Drawing.Point(166, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 24);
            this.textBox3.TabIndex = 3;
            // 
            // tareTextBox1
            // 
            this.tareTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Tare", true));
            this.tareTextBox1.Location = new System.Drawing.Point(166, 40);
            this.tareTextBox1.Name = "tareTextBox1";
            this.tareTextBox1.Size = new System.Drawing.Size(148, 24);
            this.tareTextBox1.TabIndex = 1;
            // 
            // jurisdictionBindingSource
            // 
            this.jurisdictionBindingSource.DataMember = "Jurisdiction";
            this.jurisdictionBindingSource.DataSource = this.dsQWSLocal;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NHVR_GVMTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBS_VINTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TruckConfigTrailersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // vehicleRegFeeCodesTableAdapter
            // 
            this.vehicleRegFeeCodesTableAdapter.ClearBeforeFill = true;
            // 
            // jurisdictionTableAdapter
            // 
            this.jurisdictionTableAdapter.ClearBeforeFill = true;
            // 
            // axleConfigurationTableAdapter
            // 
            this.axleConfigurationTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfigureGVM);
            this.groupBox2.Controls.Add(this.btnVehicleAdd);
            this.groupBox2.Controls.Add(this.btnTrailerAdd);
            this.groupBox2.Controls.Add(this.rbAddTrailer);
            this.groupBox2.Location = new System.Drawing.Point(676, 552);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 76);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Next Action";
            // 
            // btnConfigureGVM
            // 
            this.btnConfigureGVM.Location = new System.Drawing.Point(290, 32);
            this.btnConfigureGVM.Name = "btnConfigureGVM";
            this.btnConfigureGVM.Size = new System.Drawing.Size(137, 38);
            this.btnConfigureGVM.TabIndex = 11;
            this.btnConfigureGVM.Text = "Configure GVM";
            this.btnConfigureGVM.UseVisualStyleBackColor = true;
            this.btnConfigureGVM.Click += new System.EventHandler(this.btnConfigureGVM_Click);
            // 
            // btnVehicleAdd
            // 
            this.btnVehicleAdd.Location = new System.Drawing.Point(159, 32);
            this.btnVehicleAdd.Name = "btnVehicleAdd";
            this.btnVehicleAdd.Size = new System.Drawing.Size(107, 38);
            this.btnVehicleAdd.TabIndex = 10;
            this.btnVehicleAdd.Text = "Add Vehicle";
            this.btnVehicleAdd.UseVisualStyleBackColor = true;
            this.btnVehicleAdd.Click += new System.EventHandler(this.btnVehicleAdd_Click);
            // 
            // btnTrailerAdd
            // 
            this.btnTrailerAdd.Location = new System.Drawing.Point(26, 32);
            this.btnTrailerAdd.Name = "btnTrailerAdd";
            this.btnTrailerAdd.Size = new System.Drawing.Size(109, 38);
            this.btnTrailerAdd.TabIndex = 9;
            this.btnTrailerAdd.Text = "Add Trailer";
            this.btnTrailerAdd.UseVisualStyleBackColor = true;
            this.btnTrailerAdd.Click += new System.EventHandler(this.btnTrailerAdd_Click);
            // 
            // rbAddTrailer
            // 
            this.rbAddTrailer.AutoSize = true;
            this.rbAddTrailer.Location = new System.Drawing.Point(208, -26);
            this.rbAddTrailer.Name = "rbAddTrailer";
            this.rbAddTrailer.Size = new System.Drawing.Size(96, 22);
            this.rbAddTrailer.TabIndex = 4;
            this.rbAddTrailer.Text = "Add Trailer";
            this.rbAddTrailer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1248, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 25);
            this.button1.TabIndex = 52;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn,
            this.createDTTMDataGridViewTextBoxColumn,
            this.axleConfigTnTDataGridViewTextBoxColumn,
            this.gVMTruckDataGridViewTextBoxColumn,
            this.gCMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.truckConfigTruckBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1197, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 325);
            this.dataGridView1.TabIndex = 53;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            this.regoDataGridViewTextBoxColumn.ReadOnly = true;
            this.regoDataGridViewTextBoxColumn.Width = 80;
            // 
            // createDTTMDataGridViewTextBoxColumn
            // 
            this.createDTTMDataGridViewTextBoxColumn.DataPropertyName = "CreateDTTM";
            this.createDTTMDataGridViewTextBoxColumn.HeaderText = "CreateDTTM";
            this.createDTTMDataGridViewTextBoxColumn.Name = "createDTTMDataGridViewTextBoxColumn";
            this.createDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axleConfigTnTDataGridViewTextBoxColumn
            // 
            this.axleConfigTnTDataGridViewTextBoxColumn.DataPropertyName = "AxleConfigTnT";
            this.axleConfigTnTDataGridViewTextBoxColumn.HeaderText = "Axles";
            this.axleConfigTnTDataGridViewTextBoxColumn.Name = "axleConfigTnTDataGridViewTextBoxColumn";
            this.axleConfigTnTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gVMTruckDataGridViewTextBoxColumn
            // 
            this.gVMTruckDataGridViewTextBoxColumn.DataPropertyName = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.HeaderText = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.Name = "gVMTruckDataGridViewTextBoxColumn";
            this.gVMTruckDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
            this.gCMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // truckConfigTruckBindingSource
            // 
            this.truckConfigTruckBindingSource.DataMember = "TruckConfigTruck";
            this.truckConfigTruckBindingSource.DataSource = this.dsTruckConfig;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // truckConfigTruckTableAdapter
            // 
            this.truckConfigTruckTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn1,
            this.createDTTMDataGridViewTextBoxColumn1,
            this.axleConfigurationDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.truck2TrailerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1377, 457);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(354, 150);
            this.dataGridView2.TabIndex = 54;
            // 
            // regoDataGridViewTextBoxColumn1
            // 
            this.regoDataGridViewTextBoxColumn1.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn1.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn1.Name = "regoDataGridViewTextBoxColumn1";
            this.regoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createDTTMDataGridViewTextBoxColumn1
            // 
            this.createDTTMDataGridViewTextBoxColumn1.DataPropertyName = "CreateDTTM";
            this.createDTTMDataGridViewTextBoxColumn1.HeaderText = "CreateDTTM";
            this.createDTTMDataGridViewTextBoxColumn1.Name = "createDTTMDataGridViewTextBoxColumn1";
            this.createDTTMDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // axleConfigurationDataGridViewTextBoxColumn1
            // 
            this.axleConfigurationDataGridViewTextBoxColumn1.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn1.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn1.Name = "axleConfigurationDataGridViewTextBoxColumn1";
            this.axleConfigurationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // truck2TrailerBindingSource
            // 
            this.truck2TrailerBindingSource.DataMember = "Truck2Trailer";
            this.truck2TrailerBindingSource.DataSource = this.truckConfigTruckBindingSource;
            // 
            // truckConfigTruckTruckConfigTrailerBindingSource
            // 
            this.truckConfigTruckTruckConfigTrailerBindingSource.DataMember = "TruckConfigTruck_TruckConfigTrailer";
            this.truckConfigTruckTruckConfigTrailerBindingSource.DataSource = this.truckConfigTruckBindingSource;
            // 
            // truckConfigTrailerTableAdapter
            // 
            this.truckConfigTrailerTableAdapter.ClearBeforeFill = true;
            // 
            // truckConfigTrailerBindingSource
            // 
            this.truckConfigTrailerBindingSource.DataMember = "TruckConfigTrailer";
            this.truckConfigTrailerBindingSource.DataSource = this.dsTruckConfig;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn2,
            this.createDTTMDataGridViewTextBoxColumn2,
            this.axleConfigurationDataGridViewTextBoxColumn,
            this.feeCodeDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.unconfiguredVehiclesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(53, 584);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(562, 213);
            this.dataGridView3.TabIndex = 55;
            // 
            // unconfiguredVehiclesBindingSource
            // 
            this.unconfiguredVehiclesBindingSource.DataMember = "UnconfiguredVehicles";
            this.unconfiguredVehiclesBindingSource.DataSource = this.dsTruckConfig;
            // 
            // unconfiguredVehiclesTableAdapter
            // 
            this.unconfiguredVehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // regoDataGridViewTextBoxColumn2
            // 
            this.regoDataGridViewTextBoxColumn2.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn2.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn2.Name = "regoDataGridViewTextBoxColumn2";
            this.regoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // createDTTMDataGridViewTextBoxColumn2
            // 
            this.createDTTMDataGridViewTextBoxColumn2.DataPropertyName = "CreateDTTM";
            this.createDTTMDataGridViewTextBoxColumn2.HeaderText = "CreateDTTM";
            this.createDTTMDataGridViewTextBoxColumn2.Name = "createDTTMDataGridViewTextBoxColumn2";
            this.createDTTMDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            this.axleConfigurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeCodeDataGridViewTextBoxColumn
            // 
            this.feeCodeDataGridViewTextBoxColumn.DataPropertyName = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn.HeaderText = "FeeCode";
            this.feeCodeDataGridViewTextBoxColumn.Name = "feeCodeDataGridViewTextBoxColumn";
            this.feeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VehicleMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 809);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.lblNextAction);
            this.Controls.Add(this.btnFeeCodesMore);
            this.Controls.Add(this.btnIdentificationSave);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtJurisdiction);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(jurisdictionLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtRegoExpiryDT);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtRego);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.btnFindVehicle);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.btnSetTruckOwner);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.btnSetAxleConfig);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(this.btnSetFeeCodeMain);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.txtFeeCode);
            this.Controls.Add(expiryDTLabel);
            this.Controls.Add(label2);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.tareTextBox);
            this.Controls.Add(this.vINTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(regoLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(tareLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle_Maintenance";
            this.Load += new System.EventHandler(this.Vehicle_Maintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegFeeCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jurisdictionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckConfigTruckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck2TrailerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckConfigTrailerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unconfiguredVehiclesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private dsQWSLocalTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.BindingSource vehicleRegFeeCodesBindingSource;
        private dsQWSLocalTableAdapters.VehicleRegFeeCodesTableAdapter vehicleRegFeeCodesTableAdapter;
        private System.Windows.Forms.BindingSource jurisdictionBindingSource;
        private dsQWSLocalTableAdapters.JurisdictionTableAdapter jurisdictionTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource axleConfigurationBindingSource;
        private dsQWSLocalTableAdapters.AxleConfigurationTableAdapter axleConfigurationTableAdapter;
        private System.Windows.Forms.TextBox txtFeeCode;
        private System.Windows.Forms.Button btnSetAxleConfig;
        private System.Windows.Forms.Button btnSetFeeCodeMain;
        private System.Windows.Forms.Button btnSetTruckOwner;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtRegoExpiryDT;
        private System.Windows.Forms.Button btnIdentificationSave;
        private System.Windows.Forms.TextBox txtJurisdiction;
        private System.Windows.Forms.Button btnFeeCodesMore;
        private System.Windows.Forms.Label lblNextAction;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkForceRetare;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tareTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAddTrailer;
        private System.Windows.Forms.Button btnConfigureGVM;
        private System.Windows.Forms.Button btnVehicleAdd;
        private System.Windows.Forms.Button btnTrailerAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource truckConfigTruckBindingSource;
        private dsTruckConfigTableAdapters.TruckConfigTruckTableAdapter truckConfigTruckTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource truckConfigTruckTruckConfigTrailerBindingSource;
        private dsTruckConfigTableAdapters.TruckConfigTrailerTableAdapter truckConfigTrailerTableAdapter;
        private System.Windows.Forms.BindingSource truckConfigTrailerBindingSource;
        private System.Windows.Forms.BindingSource truck2TrailerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigTnTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVMTruckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDTTMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDTTMDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource unconfiguredVehiclesBindingSource;
        private dsTruckConfigTableAdapters.UnconfiguredVehiclesTableAdapter unconfiguredVehiclesTableAdapter;
    }
}