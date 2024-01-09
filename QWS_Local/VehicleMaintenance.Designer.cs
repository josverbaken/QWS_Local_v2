
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleMaintenance));
            this.txtRego = new System.Windows.Forms.TextBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtVehicleMake = new System.Windows.Forms.TextBox();
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
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.axleConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.btnGo2Config = new System.Windows.Forms.Button();
            this.btnNewVehicle = new System.Windows.Forms.Button();
            this.btnNewVehicleCurrentOwner = new System.Windows.Forms.Button();
            this.btnSetPrefCustomer = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.isLeadVehicleCheckBox = new System.Windows.Forms.CheckBox();
            this.txtSAPCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVehiclesByCardCode = new System.Windows.Forms.Button();
            this.jurisdictionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.vehicleRegFeeCodesTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.VehicleRegFeeCodesTableAdapter();
            this.jurisdictionTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.JurisdictionTableAdapter();
            this.axleConfigurationTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.AxleConfigurationTableAdapter();
            this.bsVehiclePBS = new System.Windows.Forms.BindingSource(this.components);
            this.taVehiclePBS = new QWS_Local.dsQWSLocalTableAdapters.VehiclePBSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.vehicleApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddPBS = new System.Windows.Forms.Button();
            this.txtPBS_VA = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bsVehiclePrefCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.taVehiclePrefCustomers = new QWS_Local.dsQWSLocalTableAdapters.VehiclePrefCustomersTableAdapter();
            this.prefCustIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDefaultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSavePrefCustomers = new System.Windows.Forms.Button();
            this.btnLoadPrefCustomers = new System.Windows.Forms.Button();
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
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegFeeCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurisdictionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePrefCustomers)).BeginInit();
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
            vINLabel.Location = new System.Drawing.Point(136, 86);
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
            ownerLabel.Location = new System.Drawing.Point(115, 114);
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
            makeLabel.Location = new System.Drawing.Point(121, 187);
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
            modelLabel.Location = new System.Drawing.Point(115, 223);
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
            tareLabel.Location = new System.Drawing.Point(50, 292);
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
            expiryDTLabel.Location = new System.Drawing.Point(91, 257);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(406, 291);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 18);
            label4.TabIndex = 62;
            label4.Text = "Pref Customer :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 521);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(170, 18);
            label1.TabIndex = 64;
            label1.Text = "PBS Vehicle Approval/s :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // txtVIN
            // 
            this.txtVIN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "VIN", true));
            this.txtVIN.Location = new System.Drawing.Point(208, 78);
            this.txtVIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtVIN.MaxLength = 17;
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(394, 24);
            this.txtVIN.TabIndex = 3;
            this.txtVIN.Enter += new System.EventHandler(this.vINTextBox_Enter);
            // 
            // txtOwner
            // 
            this.txtOwner.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Owner", true));
            this.txtOwner.Location = new System.Drawing.Point(209, 143);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(393, 24);
            this.txtOwner.TabIndex = 4;
            // 
            // txtVehicleMake
            // 
            this.txtVehicleMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Make", true));
            this.txtVehicleMake.Location = new System.Drawing.Point(208, 179);
            this.txtVehicleMake.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleMake.Name = "txtVehicleMake";
            this.txtVehicleMake.Size = new System.Drawing.Size(394, 24);
            this.txtVehicleMake.TabIndex = 6;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(208, 215);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(394, 24);
            this.modelTextBox.TabIndex = 7;
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "RegisteredTare", true));
            this.tareTextBox.Location = new System.Drawing.Point(209, 289);
            this.tareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(148, 24);
            this.tareTextBox.TabIndex = 9;
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
            this.txtRegoExpiryDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "RegistrationExpiryDT", true));
            this.txtRegoExpiryDT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRegoExpiryDT.Location = new System.Drawing.Point(208, 254);
            this.txtRegoExpiryDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegoExpiryDT.Name = "txtRegoExpiryDT";
            this.txtRegoExpiryDT.Size = new System.Drawing.Size(394, 24);
            this.txtRegoExpiryDT.TabIndex = 8;
            this.txtRegoExpiryDT.Click += new System.EventHandler(this.txtRegoExpiryDT_Click);
            this.txtRegoExpiryDT.Enter += new System.EventHandler(this.txtRegoExpiryDT_Enter);
            // 
            // btnIdentificationSave
            // 
            this.btnIdentificationSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIdentificationSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentificationSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificationSave.Location = new System.Drawing.Point(676, 512);
            this.btnIdentificationSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdentificationSave.Name = "btnIdentificationSave";
            this.btnIdentificationSave.Size = new System.Drawing.Size(450, 42);
            this.btnIdentificationSave.TabIndex = 13;
            this.btnIdentificationSave.Text = "Save";
            this.btnIdentificationSave.UseVisualStyleBackColor = false;
            this.btnIdentificationSave.Click += new System.EventHandler(this.btnIdentificationSave_Click);
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindVehicle.Location = new System.Drawing.Point(487, 25);
            this.btnFindVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(115, 35);
            this.btnFindVehicle.TabIndex = 2;
            this.btnFindVehicle.Text = "Find / New";
            this.btnFindVehicle.UseVisualStyleBackColor = false;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // btnSetTruckOwner
            // 
            this.btnSetTruckOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetTruckOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTruckOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTruckOwner.Location = new System.Drawing.Point(541, 109);
            this.btnSetTruckOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetTruckOwner.Name = "btnSetTruckOwner";
            this.btnSetTruckOwner.Size = new System.Drawing.Size(61, 25);
            this.btnSetTruckOwner.TabIndex = 5;
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
            this.txtFeeCode.Location = new System.Drawing.Point(812, 72);
            this.txtFeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.Size = new System.Drawing.Size(107, 24);
            this.txtFeeCode.TabIndex = 10;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "AxleConfiguration", true));
            this.txtAxleConfig.Location = new System.Drawing.Point(778, 231);
            this.txtAxleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.ReadOnly = true;
            this.txtAxleConfig.Size = new System.Drawing.Size(148, 24);
            this.txtAxleConfig.TabIndex = 13;
            this.txtAxleConfig.TabStop = false;
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
            // axleConfigurationBindingSource
            // 
            this.axleConfigurationBindingSource.DataMember = "AxleConfiguration";
            this.axleConfigurationBindingSource.DataSource = this.dsQWSLocal;
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
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGo2Config
            // 
            this.btnGo2Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGo2Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo2Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo2Config.Location = new System.Drawing.Point(676, 624);
            this.btnGo2Config.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo2Config.Name = "btnGo2Config";
            this.btnGo2Config.Size = new System.Drawing.Size(450, 42);
            this.btnGo2Config.TabIndex = 51;
            this.btnGo2Config.Text = "Go to GVM configuration.";
            this.btnGo2Config.UseVisualStyleBackColor = false;
            this.btnGo2Config.Click += new System.EventHandler(this.btnGo2Config_Click);
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVehicle.Location = new System.Drawing.Point(676, 571);
            this.btnNewVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(182, 33);
            this.btnNewVehicle.TabIndex = 52;
            this.btnNewVehicle.Text = "New (blank)";
            this.btnNewVehicle.UseVisualStyleBackColor = false;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // btnNewVehicleCurrentOwner
            // 
            this.btnNewVehicleCurrentOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewVehicleCurrentOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewVehicleCurrentOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVehicleCurrentOwner.Location = new System.Drawing.Point(944, 571);
            this.btnNewVehicleCurrentOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewVehicleCurrentOwner.Name = "btnNewVehicleCurrentOwner";
            this.btnNewVehicleCurrentOwner.Size = new System.Drawing.Size(182, 33);
            this.btnNewVehicleCurrentOwner.TabIndex = 53;
            this.btnNewVehicleCurrentOwner.Text = "New current owner";
            this.btnNewVehicleCurrentOwner.UseVisualStyleBackColor = false;
            this.btnNewVehicleCurrentOwner.Click += new System.EventHandler(this.btnNewVehicleCurrentOwner_Click);
            // 
            // btnSetPrefCustomer
            // 
            this.btnSetPrefCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetPrefCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPrefCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPrefCustomer.Location = new System.Drawing.Point(541, 288);
            this.btnSetPrefCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPrefCustomer.Name = "btnSetPrefCustomer";
            this.btnSetPrefCustomer.Size = new System.Drawing.Size(61, 25);
            this.btnSetPrefCustomer.TabIndex = 61;
            this.btnSetPrefCustomer.Text = "Set";
            this.btnSetPrefCustomer.UseVisualStyleBackColor = false;
            this.btnSetPrefCustomer.Click += new System.EventHandler(this.btnSetPrefCustomer_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "FeeCodeID", true));
            this.textBox2.Location = new System.Drawing.Point(771, 72);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 24);
            this.textBox2.TabIndex = 65;
            // 
            // isLeadVehicleCheckBox
            // 
            this.isLeadVehicleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehicleBindingSource, "IsLeadVehicle", true));
            this.isLeadVehicleCheckBox.Enabled = false;
            this.isLeadVehicleCheckBox.Location = new System.Drawing.Point(678, 303);
            this.isLeadVehicleCheckBox.Name = "isLeadVehicleCheckBox";
            this.isLeadVehicleCheckBox.Size = new System.Drawing.Size(210, 24);
            this.isLeadVehicleCheckBox.TabIndex = 67;
            this.isLeadVehicleCheckBox.Text = "Is Lead Vehicle";
            this.isLeadVehicleCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtSAPCode
            // 
            this.txtSAPCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "CardCode", true));
            this.txtSAPCode.Location = new System.Drawing.Point(209, 110);
            this.txtSAPCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAPCode.Name = "txtSAPCode";
            this.txtSAPCode.Size = new System.Drawing.Size(72, 24);
            this.txtSAPCode.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.axleConfigurationBindingSource, "Schematic", true));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 338);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnVehiclesByCardCode
            // 
            this.btnVehiclesByCardCode.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVehiclesByCardCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiclesByCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiclesByCardCode.Location = new System.Drawing.Point(303, 109);
            this.btnVehiclesByCardCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiclesByCardCode.Name = "btnVehiclesByCardCode";
            this.btnVehiclesByCardCode.Size = new System.Drawing.Size(137, 25);
            this.btnVehiclesByCardCode.TabIndex = 69;
            this.btnVehiclesByCardCode.Text = "List Vehicles";
            this.btnVehiclesByCardCode.UseVisualStyleBackColor = false;
            this.btnVehiclesByCardCode.Click += new System.EventHandler(this.btnVehiclesByCardCode_Click);
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
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            this.tableAdapterManager.VehicleTypeTableAdapter = null;
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
            // bsVehiclePBS
            // 
            this.bsVehiclePBS.DataMember = "VehiclePBS";
            this.bsVehiclePBS.DataSource = this.dsQWSLocal;
            // 
            // taVehiclePBS
            // 
            this.taVehiclePBS.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(472, 595);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 71;
            this.button1.Text = "Update PBS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicleApprovalDataGridViewTextBoxColumn
            // 
            this.vehicleApprovalDataGridViewTextBoxColumn.DataPropertyName = "VehicleApproval";
            this.vehicleApprovalDataGridViewTextBoxColumn.HeaderText = "VA";
            this.vehicleApprovalDataGridViewTextBoxColumn.Name = "vehicleApprovalDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleApprovalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsVehiclePBS;
            this.dataGridView1.Location = new System.Drawing.Point(208, 521);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(163, 106);
            this.dataGridView1.TabIndex = 72;
            // 
            // btnAddPBS
            // 
            this.btnAddPBS.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddPBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPBS.Location = new System.Drawing.Point(472, 555);
            this.btnAddPBS.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPBS.Name = "btnAddPBS";
            this.btnAddPBS.Size = new System.Drawing.Size(130, 32);
            this.btnAddPBS.TabIndex = 75;
            this.btnAddPBS.Text = "Add PBS";
            this.btnAddPBS.UseVisualStyleBackColor = false;
            this.btnAddPBS.Click += new System.EventHandler(this.btnAddPBS_Click);
            // 
            // txtPBS_VA
            // 
            this.txtPBS_VA.Location = new System.Drawing.Point(472, 521);
            this.txtPBS_VA.Name = "txtPBS_VA";
            this.txtPBS_VA.Size = new System.Drawing.Size(130, 24);
            this.txtPBS_VA.TabIndex = 76;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prefCustIDDataGridViewTextBoxColumn,
            this.regoDataGridViewTextBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn,
            this.prefCustomerDataGridViewTextBoxColumn,
            this.isDefaultDataGridViewCheckBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.bsVehiclePrefCustomers;
            this.dataGridView2.Location = new System.Drawing.Point(12, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(614, 150);
            this.dataGridView2.TabIndex = 77;
            // 
            // bsVehiclePrefCustomers
            // 
            this.bsVehiclePrefCustomers.DataMember = "VehiclePrefCustomers";
            this.bsVehiclePrefCustomers.DataSource = this.dsQWSLocal;
            // 
            // taVehiclePrefCustomers
            // 
            this.taVehiclePrefCustomers.ClearBeforeFill = true;
            // 
            // prefCustIDDataGridViewTextBoxColumn
            // 
            this.prefCustIDDataGridViewTextBoxColumn.DataPropertyName = "PrefCustID";
            this.prefCustIDDataGridViewTextBoxColumn.HeaderText = "PrefCustID";
            this.prefCustIDDataGridViewTextBoxColumn.Name = "prefCustIDDataGridViewTextBoxColumn";
            this.prefCustIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            // 
            // prefCustomerDataGridViewTextBoxColumn
            // 
            this.prefCustomerDataGridViewTextBoxColumn.DataPropertyName = "PrefCustomer";
            this.prefCustomerDataGridViewTextBoxColumn.HeaderText = "PrefCustomer";
            this.prefCustomerDataGridViewTextBoxColumn.Name = "prefCustomerDataGridViewTextBoxColumn";
            // 
            // isDefaultDataGridViewCheckBoxColumn
            // 
            this.isDefaultDataGridViewCheckBoxColumn.DataPropertyName = "IsDefault";
            this.isDefaultDataGridViewCheckBoxColumn.HeaderText = "IsDefault";
            this.isDefaultDataGridViewCheckBoxColumn.Name = "isDefaultDataGridViewCheckBoxColumn";
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // btnSavePrefCustomers
            // 
            this.btnSavePrefCustomers.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSavePrefCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrefCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrefCustomers.Location = new System.Drawing.Point(438, 477);
            this.btnSavePrefCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePrefCustomers.Name = "btnSavePrefCustomers";
            this.btnSavePrefCustomers.Size = new System.Drawing.Size(164, 25);
            this.btnSavePrefCustomers.TabIndex = 78;
            this.btnSavePrefCustomers.Text = "Save Pref Customers";
            this.btnSavePrefCustomers.UseVisualStyleBackColor = false;
            this.btnSavePrefCustomers.Click += new System.EventHandler(this.btnSavePrefCustomers_Click);
            // 
            // btnLoadPrefCustomers
            // 
            this.btnLoadPrefCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadPrefCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPrefCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPrefCustomers.Location = new System.Drawing.Point(349, 477);
            this.btnLoadPrefCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPrefCustomers.Name = "btnLoadPrefCustomers";
            this.btnLoadPrefCustomers.Size = new System.Drawing.Size(61, 25);
            this.btnLoadPrefCustomers.TabIndex = 79;
            this.btnLoadPrefCustomers.Text = "Load";
            this.btnLoadPrefCustomers.UseVisualStyleBackColor = false;
            this.btnLoadPrefCustomers.Click += new System.EventHandler(this.btnLoadPrefCustomers_Click);
            // 
            // VehicleMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 696);
            this.Controls.Add(this.btnLoadPrefCustomers);
            this.Controls.Add(this.btnSavePrefCustomers);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtPBS_VA);
            this.Controls.Add(this.btnAddPBS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVehiclesByCardCode);
            this.Controls.Add(this.txtSAPCode);
            this.Controls.Add(this.isLeadVehicleCheckBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(label1);
            this.Controls.Add(label4);
            this.Controls.Add(this.btnSetPrefCustomer);
            this.Controls.Add(this.btnNewVehicleCurrentOwner);
            this.Controls.Add(this.btnNewVehicle);
            this.Controls.Add(this.btnGo2Config);
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
            this.Controls.Add(this.txtVehicleMake);
            this.Controls.Add(this.btnSetAxleConfig);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(this.btnSetFeeCodeMain);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtFeeCode);
            this.Controls.Add(expiryDTLabel);
            this.Controls.Add(label2);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.tareTextBox);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(label3);
            this.Controls.Add(regoLabel);
            this.Controls.Add(this.txtAxleConfig);
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
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurisdictionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePrefCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private dsQWSLocalTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtVehicleMake;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.BindingSource vehicleRegFeeCodesBindingSource;
        private dsQWSLocalTableAdapters.VehicleRegFeeCodesTableAdapter vehicleRegFeeCodesTableAdapter;
        private System.Windows.Forms.BindingSource jurisdictionBindingSource;
        private dsQWSLocalTableAdapters.JurisdictionTableAdapter jurisdictionTableAdapter;
        private System.Windows.Forms.TextBox txtAxleConfig;
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
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.Button btnGo2Config;
        private System.Windows.Forms.Button btnNewVehicle;
        private System.Windows.Forms.Button btnNewVehicleCurrentOwner;
        private System.Windows.Forms.Button btnSetPrefCustomer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox isLeadVehicleCheckBox;
        private System.Windows.Forms.TextBox txtSAPCode;
        private System.Windows.Forms.Button btnVehiclesByCardCode;
        private System.Windows.Forms.BindingSource bsVehiclePBS;
        private dsQWSLocalTableAdapters.VehiclePBSTableAdapter taVehiclePBS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleApprovalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddPBS;
        private System.Windows.Forms.TextBox txtPBS_VA;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bsVehiclePrefCustomers;
        private dsQWSLocalTableAdapters.VehiclePrefCustomersTableAdapter taVehiclePrefCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefCustIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDefaultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnSavePrefCustomers;
        private System.Windows.Forms.Button btnLoadPrefCustomers;
    }
}