
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
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label expiryDTLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label jurisdictionLabel1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleMaintenance));
            this.txtRego = new System.Windows.Forms.TextBox();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtVehicleMake = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.btnFeeCodesMore = new System.Windows.Forms.Button();
            this.txtJurisdiction = new System.Windows.Forms.TextBox();
            this.txtRegoExpiryDT = new System.Windows.Forms.TextBox();
            this.btnIdentificationSave = new System.Windows.Forms.Button();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.btnSetAxleConfig = new System.Windows.Forms.Button();
            this.btnSetFeeCodeMain = new System.Windows.Forms.Button();
            this.txtFeeCode = new System.Windows.Forms.TextBox();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVehiclePBS2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPBS = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.isDefaultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsPrefCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.btnSavePrefCustomers = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.prefCustomerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tpPrefCust = new System.Windows.Forms.TabPage();
            this.btnLoadPrefCustomers = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveMassMgmtAccred = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshPBS = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSetTruckOwner = new System.Windows.Forms.Button();
            this.bsAxleConfig = new System.Windows.Forms.BindingSource(this.components);
            this.taAxleConfig = new QWS_Local.dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.taPrefCustomers = new QWS_Local.dsQWSLocal2024TableAdapters.VehiclePrefCustomersTableAdapter();
            this.jurisdictionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jurisdictionTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.JurisdictionTableAdapter();
            this.taVehicle = new QWS_Local.dsQWSLocal2024TableAdapters.VehicleTableAdapter();
            this.taVehiclePBS2 = new QWS_Local.dsQWSLocal2024TableAdapters.VehiclePBSTableAdapter();
            this.bsFeeCodes = new System.Windows.Forms.BindingSource(this.components);
            this.taFeeCodes = new QWS_Local.dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter();
            vINLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            expiryDTLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            jurisdictionLabel1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePBS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpOverview.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.tpPrefCust.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurisdictionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(101, 27);
            vINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(35, 18);
            vINLabel.TabIndex = 3;
            vINLabel.Text = "VIN:";
            vINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(146, 92);
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
            modelLabel.Location = new System.Drawing.Point(140, 128);
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
            tareLabel.Location = new System.Drawing.Point(75, 197);
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
            expiryDTLabel.Location = new System.Drawing.Point(116, 162);
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
            label2.Location = new System.Drawing.Point(702, 218);
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
            label3.Location = new System.Drawing.Point(702, 56);
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
            jurisdictionLabel1.Location = new System.Drawing.Point(692, 22);
            jurisdictionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jurisdictionLabel1.Name = "jurisdictionLabel1";
            jurisdictionLabel1.Size = new System.Drawing.Size(87, 18);
            jurisdictionLabel1.TabIndex = 45;
            jurisdictionLabel1.Text = "Jurisdiction:";
            jurisdictionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(66, 41);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(143, 18);
            label5.TabIndex = 81;
            label5.Text = "Mass Management :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 194);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 18);
            label4.TabIndex = 74;
            label4.Text = "Registered Tare:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(56, 159);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 18);
            label6.TabIndex = 75;
            label6.Text = "Expiry DT:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(86, 89);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 18);
            label7.TabIndex = 72;
            label7.Text = "Make:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(80, 125);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(53, 18);
            label8.TabIndex = 73;
            label8.Text = "Model:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(161, 53);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(35, 18);
            label9.TabIndex = 43;
            label9.Text = "VIN:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(56, 293);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(153, 18);
            label10.TabIndex = 76;
            label10.Text = "Mass Mgmnt Accred :";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRego
            // 
            this.txtRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "Rego", true));
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRego.Location = new System.Drawing.Point(529, 14);
            this.txtRego.Margin = new System.Windows.Forms.Padding(4);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(232, 35);
            this.txtRego.TabIndex = 1;
            this.txtRego.Text = "Rego or Owner";
            this.toolTip1.SetToolTip(this.txtRego, "Search by Rego or Owner");
            this.txtRego.Click += new System.EventHandler(this.txtRego_Click);
            this.txtRego.Enter += new System.EventHandler(this.txtRego_Enter);
            // 
            // bsVehicle
            // 
            this.bsVehicle.DataMember = "Vehicle";
            this.bsVehicle.DataSource = this.dsQWSLocal2024;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtVIN
            // 
            this.txtVIN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "VIN", true));
            this.txtVIN.Location = new System.Drawing.Point(173, 19);
            this.txtVIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtVIN.MaxLength = 17;
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(394, 24);
            this.txtVIN.TabIndex = 3;
            this.txtVIN.Enter += new System.EventHandler(this.vINTextBox_Enter);
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(13, 174);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(372, 24);
            this.txtOwner.TabIndex = 4;
            // 
            // txtVehicleMake
            // 
            this.txtVehicleMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "Make", true));
            this.txtVehicleMake.Location = new System.Drawing.Point(233, 84);
            this.txtVehicleMake.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleMake.Name = "txtVehicleMake";
            this.txtVehicleMake.ReadOnly = true;
            this.txtVehicleMake.Size = new System.Drawing.Size(394, 24);
            this.txtVehicleMake.TabIndex = 6;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(233, 120);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(394, 24);
            this.modelTextBox.TabIndex = 7;
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "RegisteredTare", true));
            this.tareTextBox.Location = new System.Drawing.Point(234, 194);
            this.tareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.ReadOnly = true;
            this.tareTextBox.Size = new System.Drawing.Size(148, 24);
            this.tareTextBox.TabIndex = 9;
            // 
            // btnFeeCodesMore
            // 
            this.btnFeeCodesMore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFeeCodesMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeCodesMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeeCodesMore.Location = new System.Drawing.Point(965, 53);
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
            this.txtJurisdiction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "Jurisdiction", true));
            this.txtJurisdiction.Location = new System.Drawing.Point(789, 19);
            this.txtJurisdiction.Margin = new System.Windows.Forms.Padding(4);
            this.txtJurisdiction.Name = "txtJurisdiction";
            this.txtJurisdiction.Size = new System.Drawing.Size(148, 24);
            this.txtJurisdiction.TabIndex = 9;
            // 
            // txtRegoExpiryDT
            // 
            this.txtRegoExpiryDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "RegistrationExpiryDT", true));
            this.txtRegoExpiryDT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRegoExpiryDT.Location = new System.Drawing.Point(233, 159);
            this.txtRegoExpiryDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegoExpiryDT.Name = "txtRegoExpiryDT";
            this.txtRegoExpiryDT.ReadOnly = true;
            this.txtRegoExpiryDT.Size = new System.Drawing.Size(394, 24);
            this.txtRegoExpiryDT.TabIndex = 8;
            this.txtRegoExpiryDT.Click += new System.EventHandler(this.txtRegoExpiryDT_Click);
            this.txtRegoExpiryDT.Enter += new System.EventHandler(this.txtRegoExpiryDT_Enter);
            // 
            // btnIdentificationSave
            // 
            this.btnIdentificationSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdentificationSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentificationSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificationSave.Location = new System.Drawing.Point(858, 74);
            this.btnIdentificationSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdentificationSave.Name = "btnIdentificationSave";
            this.btnIdentificationSave.Size = new System.Drawing.Size(222, 42);
            this.btnIdentificationSave.TabIndex = 13;
            this.btnIdentificationSave.Text = "Save";
            this.btnIdentificationSave.UseVisualStyleBackColor = false;
            this.btnIdentificationSave.Click += new System.EventHandler(this.btnIdentificationSave_Click);
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFindVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindVehicle.Location = new System.Drawing.Point(858, 17);
            this.btnFindVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(115, 35);
            this.btnFindVehicle.TabIndex = 2;
            this.btnFindVehicle.Text = "Find (F3)";
            this.btnFindVehicle.UseVisualStyleBackColor = false;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // btnSetAxleConfig
            // 
            this.btnSetAxleConfig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSetAxleConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAxleConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAxleConfig.Location = new System.Drawing.Point(962, 208);
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
            this.btnSetFeeCodeMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSetFeeCodeMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetFeeCodeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFeeCodeMain.Location = new System.Drawing.Point(1028, 53);
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
            this.txtFeeCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFeeCodes, "FeeCode", true));
            this.txtFeeCode.Location = new System.Drawing.Point(830, 56);
            this.txtFeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.Size = new System.Drawing.Size(107, 24);
            this.txtFeeCode.TabIndex = 10;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "AxleConfiguration", true));
            this.txtAxleConfig.Location = new System.Drawing.Point(796, 215);
            this.txtAxleConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.ReadOnly = true;
            this.txtAxleConfig.Size = new System.Drawing.Size(148, 24);
            this.txtAxleConfig.TabIndex = 13;
            this.txtAxleConfig.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(696, 254);
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
            this.textBox1.Location = new System.Drawing.Point(696, 127);
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
            this.textBox6.Location = new System.Drawing.Point(696, 95);
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
            this.btnGo2Config.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGo2Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo2Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo2Config.Location = new System.Drawing.Point(858, 124);
            this.btnGo2Config.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo2Config.Name = "btnGo2Config";
            this.btnGo2Config.Size = new System.Drawing.Size(222, 42);
            this.btnGo2Config.TabIndex = 51;
            this.btnGo2Config.Text = "Go to GVM configuration.";
            this.btnGo2Config.UseVisualStyleBackColor = false;
            this.btnGo2Config.Click += new System.EventHandler(this.btnGo2Config_Click);
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVehicle.Location = new System.Drawing.Point(579, 79);
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
            this.btnNewVehicleCurrentOwner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewVehicleCurrentOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewVehicleCurrentOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVehicleCurrentOwner.Location = new System.Drawing.Point(579, 133);
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
            this.btnSetPrefCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSetPrefCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPrefCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPrefCustomer.Location = new System.Drawing.Point(316, 25);
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
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "FeeCodeID", true));
            this.textBox2.Location = new System.Drawing.Point(789, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 24);
            this.textBox2.TabIndex = 65;
            // 
            // isLeadVehicleCheckBox
            // 
            this.isLeadVehicleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsVehicle, "IsLeadVehicle", true));
            this.isLeadVehicleCheckBox.Enabled = false;
            this.isLeadVehicleCheckBox.Location = new System.Drawing.Point(357, 50);
            this.isLeadVehicleCheckBox.Name = "isLeadVehicleCheckBox";
            this.isLeadVehicleCheckBox.Size = new System.Drawing.Size(210, 24);
            this.isLeadVehicleCheckBox.TabIndex = 67;
            this.isLeadVehicleCheckBox.Text = "Is Lead Vehicle";
            this.isLeadVehicleCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtSAPCode
            // 
            this.txtSAPCode.Location = new System.Drawing.Point(393, 174);
            this.txtSAPCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAPCode.Name = "txtSAPCode";
            this.txtSAPCode.Size = new System.Drawing.Size(72, 24);
            this.txtSAPCode.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnVehiclesByCardCode
            // 
            this.btnVehiclesByCardCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVehiclesByCardCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiclesByCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiclesByCardCode.Location = new System.Drawing.Point(579, 173);
            this.btnVehiclesByCardCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiclesByCardCode.Name = "btnVehiclesByCardCode";
            this.btnVehiclesByCardCode.Size = new System.Drawing.Size(182, 25);
            this.btnVehiclesByCardCode.TabIndex = 69;
            this.btnVehiclesByCardCode.Text = "List Vehicles";
            this.btnVehiclesByCardCode.UseVisualStyleBackColor = false;
            this.btnVehiclesByCardCode.Click += new System.EventHandler(this.btnVehiclesByCardCode_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 71;
            this.button1.Text = "Update PBS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleApprovalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsVehiclePBS2;
            this.dataGridView1.Location = new System.Drawing.Point(101, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(163, 106);
            this.dataGridView1.TabIndex = 72;
            // 
            // vehicleApprovalDataGridViewTextBoxColumn
            // 
            this.vehicleApprovalDataGridViewTextBoxColumn.DataPropertyName = "VehicleApproval";
            this.vehicleApprovalDataGridViewTextBoxColumn.HeaderText = "VA";
            this.vehicleApprovalDataGridViewTextBoxColumn.Name = "vehicleApprovalDataGridViewTextBoxColumn";
            // 
            // bsVehiclePBS2
            // 
            this.bsVehiclePBS2.DataMember = "VehiclePBS";
            this.bsVehiclePBS2.DataSource = this.dsQWSLocal2024;
            // 
            // btnAddPBS
            // 
            this.btnAddPBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPBS.Location = new System.Drawing.Point(290, 36);
            this.btnAddPBS.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPBS.Name = "btnAddPBS";
            this.btnAddPBS.Size = new System.Drawing.Size(130, 32);
            this.btnAddPBS.TabIndex = 75;
            this.btnAddPBS.Text = "Add PBS";
            this.btnAddPBS.UseVisualStyleBackColor = false;
            this.btnAddPBS.Click += new System.EventHandler(this.btnAddPBS_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isDefaultDataGridViewCheckBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn,
            this.prefCustomerDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.bsPrefCustomers;
            this.dataGridView2.Location = new System.Drawing.Point(100, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(911, 285);
            this.dataGridView2.TabIndex = 77;
            // 
            // isDefaultDataGridViewCheckBoxColumn
            // 
            this.isDefaultDataGridViewCheckBoxColumn.DataPropertyName = "IsDefault";
            this.isDefaultDataGridViewCheckBoxColumn.HeaderText = "IsDefault";
            this.isDefaultDataGridViewCheckBoxColumn.Name = "isDefaultDataGridViewCheckBoxColumn";
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
            this.prefCustomerDataGridViewTextBoxColumn.Width = 250;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 300;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // bsPrefCustomers
            // 
            this.bsPrefCustomers.DataMember = "VehiclePrefCustomers";
            this.bsPrefCustomers.DataSource = this.dsQWSLocal2024;
            // 
            // btnSavePrefCustomers
            // 
            this.btnSavePrefCustomers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSavePrefCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrefCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrefCustomers.Location = new System.Drawing.Point(423, 25);
            this.btnSavePrefCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePrefCustomers.Name = "btnSavePrefCustomers";
            this.btnSavePrefCustomers.Size = new System.Drawing.Size(164, 25);
            this.btnSavePrefCustomers.TabIndex = 78;
            this.btnSavePrefCustomers.Text = "Save Pref Customers";
            this.btnSavePrefCustomers.UseVisualStyleBackColor = false;
            this.btnSavePrefCustomers.Click += new System.EventHandler(this.btnSavePrefCustomers_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "MassAccreditationLabel", true));
            this.textBox3.Location = new System.Drawing.Point(217, 39);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 24);
            this.textBox3.TabIndex = 80;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpOverview);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Controls.Add(this.tpPrefCust);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 476);
            this.tabControl1.TabIndex = 82;
            // 
            // tpOverview
            // 
            this.tpOverview.BackColor = System.Drawing.SystemColors.Control;
            this.tpOverview.Controls.Add(label10);
            this.tpOverview.Controls.Add(this.textBox14);
            this.tpOverview.Controls.Add(this.groupBox3);
            this.tpOverview.Controls.Add(this.groupBox2);
            this.tpOverview.Controls.Add(this.textBox13);
            this.tpOverview.Controls.Add(label9);
            this.tpOverview.Controls.Add(this.textBox10);
            this.tpOverview.Controls.Add(this.textBox11);
            this.tpOverview.Controls.Add(this.textBox12);
            this.tpOverview.Controls.Add(this.txtVehicleMake);
            this.tpOverview.Controls.Add(tareLabel);
            this.tpOverview.Controls.Add(this.tareTextBox);
            this.tpOverview.Controls.Add(expiryDTLabel);
            this.tpOverview.Controls.Add(makeLabel);
            this.tpOverview.Controls.Add(this.modelTextBox);
            this.tpOverview.Controls.Add(modelLabel);
            this.tpOverview.Controls.Add(this.txtRegoExpiryDT);
            this.tpOverview.Location = new System.Drawing.Point(4, 27);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverview.Size = new System.Drawing.Size(1163, 445);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Overview";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "MassAccreditationLabel", true));
            this.textBox14.Location = new System.Drawing.Point(233, 290);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(107, 24);
            this.textBox14.TabIndex = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Location = new System.Drawing.Point(698, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 139);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preferred Customers";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.ColumnHeadersVisible = false;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prefCustomerDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.bsPrefCustomers;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 20);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(290, 116);
            this.dataGridView4.TabIndex = 0;
            // 
            // prefCustomerDataGridViewTextBoxColumn1
            // 
            this.prefCustomerDataGridViewTextBoxColumn1.DataPropertyName = "PrefCustomer";
            this.prefCustomerDataGridViewTextBoxColumn1.HeaderText = "PrefCustomer";
            this.prefCustomerDataGridViewTextBoxColumn1.Name = "prefCustomerDataGridViewTextBoxColumn1";
            this.prefCustomerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prefCustomerDataGridViewTextBoxColumn1.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(698, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 123);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PBS";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(290, 100);
            this.dataGridView3.TabIndex = 73;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "VIN", true));
            this.textBox13.Location = new System.Drawing.Point(233, 45);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.MaxLength = 17;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(394, 24);
            this.textBox13.TabIndex = 42;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "AxleConfiguration", true));
            this.textBox10.Location = new System.Drawing.Point(360, 226);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(148, 24);
            this.textBox10.TabIndex = 38;
            this.textBox10.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(234, 226);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(107, 24);
            this.textBox11.TabIndex = 37;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(233, 258);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(448, 24);
            this.textBox12.TabIndex = 39;
            this.textBox12.TabStop = false;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpDetails
            // 
            this.tpDetails.AutoScroll = true;
            this.tpDetails.Controls.Add(this.textBox4);
            this.tpDetails.Controls.Add(label4);
            this.tpDetails.Controls.Add(this.textBox5);
            this.tpDetails.Controls.Add(label6);
            this.tpDetails.Controls.Add(label7);
            this.tpDetails.Controls.Add(this.textBox7);
            this.tpDetails.Controls.Add(label8);
            this.tpDetails.Controls.Add(this.textBox9);
            this.tpDetails.Controls.Add(this.textBox1);
            this.tpDetails.Controls.Add(this.txtAxleConfig);
            this.tpDetails.Controls.Add(this.btnFeeCodesMore);
            this.tpDetails.Controls.Add(label3);
            this.tpDetails.Controls.Add(this.isLeadVehicleCheckBox);
            this.tpDetails.Controls.Add(label2);
            this.tpDetails.Controls.Add(this.textBox2);
            this.tpDetails.Controls.Add(this.txtFeeCode);
            this.tpDetails.Controls.Add(this.btnSetAxleConfig);
            this.tpDetails.Controls.Add(this.btnSetFeeCodeMain);
            this.tpDetails.Controls.Add(this.textBox6);
            this.tpDetails.Controls.Add(jurisdictionLabel1);
            this.tpDetails.Controls.Add(this.txtJurisdiction);
            this.tpDetails.Controls.Add(this.textBox8);
            this.tpDetails.Controls.Add(this.txtVIN);
            this.tpDetails.Controls.Add(vINLabel);
            this.tpDetails.Location = new System.Drawing.Point(4, 27);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1163, 445);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "Make", true));
            this.textBox4.Location = new System.Drawing.Point(173, 81);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(394, 24);
            this.textBox4.TabIndex = 68;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "RegisteredTare", true));
            this.textBox5.Location = new System.Drawing.Point(174, 191);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 24);
            this.textBox5.TabIndex = 71;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "Model", true));
            this.textBox7.Location = new System.Drawing.Point(173, 117);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(394, 24);
            this.textBox7.TabIndex = 69;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "RegistrationExpiryDT", true));
            this.textBox9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox9.Location = new System.Drawing.Point(173, 156);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(394, 24);
            this.textBox9.TabIndex = 70;
            // 
            // tpPrefCust
            // 
            this.tpPrefCust.Controls.Add(this.btnLoadPrefCustomers);
            this.tpPrefCust.Controls.Add(this.btnSavePrefCustomers);
            this.tpPrefCust.Controls.Add(this.dataGridView2);
            this.tpPrefCust.Controls.Add(this.btnSetPrefCustomer);
            this.tpPrefCust.Location = new System.Drawing.Point(4, 22);
            this.tpPrefCust.Name = "tpPrefCust";
            this.tpPrefCust.Size = new System.Drawing.Size(1163, 450);
            this.tpPrefCust.TabIndex = 2;
            this.tpPrefCust.Text = "Preferred Customers";
            this.tpPrefCust.UseVisualStyleBackColor = true;
            // 
            // btnLoadPrefCustomers
            // 
            this.btnLoadPrefCustomers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoadPrefCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPrefCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPrefCustomers.Location = new System.Drawing.Point(150, 25);
            this.btnLoadPrefCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPrefCustomers.Name = "btnLoadPrefCustomers";
            this.btnLoadPrefCustomers.Size = new System.Drawing.Size(61, 25);
            this.btnLoadPrefCustomers.TabIndex = 80;
            this.btnLoadPrefCustomers.Text = "Refresh";
            this.btnLoadPrefCustomers.UseVisualStyleBackColor = false;
            this.btnLoadPrefCustomers.Click += new System.EventHandler(this.btnLoadPrefCustomers_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveMassMgmtAccred);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(label5);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1163, 445);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "NHVR Checker App";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveMassMgmtAccred
            // 
            this.btnSaveMassMgmtAccred.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveMassMgmtAccred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMassMgmtAccred.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMassMgmtAccred.Location = new System.Drawing.Point(359, 35);
            this.btnSaveMassMgmtAccred.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveMassMgmtAccred.Name = "btnSaveMassMgmtAccred";
            this.btnSaveMassMgmtAccred.Size = new System.Drawing.Size(130, 32);
            this.btnSaveMassMgmtAccred.TabIndex = 83;
            this.btnSaveMassMgmtAccred.Text = "Save";
            this.btnSaveMassMgmtAccred.UseVisualStyleBackColor = false;
            this.btnSaveMassMgmtAccred.Click += new System.EventHandler(this.btnSaveMassMgmtAccred_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnRefreshPBS);
            this.groupBox1.Controls.Add(this.btnAddPBS);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(69, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 181);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PBS Vehicle Approval/s";
            // 
            // btnRefreshPBS
            // 
            this.btnRefreshPBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefreshPBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPBS.Location = new System.Drawing.Point(290, 116);
            this.btnRefreshPBS.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshPBS.Name = "btnRefreshPBS";
            this.btnRefreshPBS.Size = new System.Drawing.Size(130, 32);
            this.btnRefreshPBS.TabIndex = 82;
            this.btnRefreshPBS.Text = "Refresh";
            this.btnRefreshPBS.UseVisualStyleBackColor = false;
            this.btnRefreshPBS.Click += new System.EventHandler(this.btnRefreshPBS_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSetTruckOwner);
            this.splitContainer1.Panel1.Controls.Add(this.btnVehiclesByCardCode);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtRego);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewVehicleCurrentOwner);
            this.splitContainer1.Panel1.Controls.Add(this.txtSAPCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindVehicle);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewVehicle);
            this.splitContainer1.Panel1.Controls.Add(this.btnIdentificationSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnGo2Config);
            this.splitContainer1.Panel1.Controls.Add(this.txtOwner);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 696);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 83;
            // 
            // btnSetTruckOwner
            // 
            this.btnSetTruckOwner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSetTruckOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTruckOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTruckOwner.Location = new System.Drawing.Point(473, 173);
            this.btnSetTruckOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetTruckOwner.Name = "btnSetTruckOwner";
            this.btnSetTruckOwner.Size = new System.Drawing.Size(98, 25);
            this.btnSetTruckOwner.TabIndex = 20;
            this.btnSetTruckOwner.Text = "Set";
            this.btnSetTruckOwner.UseVisualStyleBackColor = false;
            this.btnSetTruckOwner.Click += new System.EventHandler(this.btnSetTruckOwner_Click);
            // 
            // bsAxleConfig
            // 
            this.bsAxleConfig.DataMember = "AxleConfiguration";
            this.bsAxleConfig.DataSource = this.dsQWSLocal2024;
            // 
            // taAxleConfig
            // 
            this.taAxleConfig.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AxleConfigurationTableAdapter = this.taAxleConfig;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.NHVRTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VehiclePBSTableAdapter = null;
            this.tableAdapterManager1.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager1.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager1.VehicleTableAdapter = null;
            // 
            // taPrefCustomers
            // 
            this.taPrefCustomers.ClearBeforeFill = true;
            // 
            // jurisdictionTableAdapter
            // 
            this.jurisdictionTableAdapter.ClearBeforeFill = true;
            // 
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // taVehiclePBS2
            // 
            this.taVehiclePBS2.ClearBeforeFill = true;
            // 
            // bsFeeCodes
            // 
            this.bsFeeCodes.DataMember = "VehicleRegFeeCodes";
            this.bsFeeCodes.DataSource = this.dsQWSLocal2024;
            // 
            // taFeeCodes
            // 
            this.taFeeCodes.ClearBeforeFill = true;
            // 
            // VehicleMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 696);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle_Maintenance";
            this.Load += new System.EventHandler(this.Vehicle_Maintenance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VehicleMaintenance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePBS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefCustomers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpOverview.ResumeLayout(false);
            this.tpOverview.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.tpPrefCust.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurisdictionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeeCodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtVehicleMake;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.BindingSource jurisdictionBindingSource;
        private dsQWSLocalTableAdapters.JurisdictionTableAdapter jurisdictionTableAdapter;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFeeCode;
        private System.Windows.Forms.Button btnSetAxleConfig;
        private System.Windows.Forms.Button btnSetFeeCodeMain;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleApprovalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddPBS;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSavePrefCustomers;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TabPage tpPrefCust;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSetTruckOwner;
        private System.Windows.Forms.Button btnLoadPrefCustomers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDefaultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefCustomerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnSaveMassMgmtAccred;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshPBS;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsAxleConfig;
        private dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter taAxleConfig;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bsPrefCustomers;
        private dsQWSLocal2024TableAdapters.VehiclePrefCustomersTableAdapter taPrefCustomers;
        private System.Windows.Forms.BindingSource bsVehicle;
        private dsQWSLocal2024TableAdapters.VehicleTableAdapter taVehicle;
        private System.Windows.Forms.BindingSource bsVehiclePBS2;
        private dsQWSLocal2024TableAdapters.VehiclePBSTableAdapter taVehiclePBS2;
        private System.Windows.Forms.BindingSource bsFeeCodes;
        private dsQWSLocal2024TableAdapters.VehicleRegFeeCodesTableAdapter taFeeCodes;
    }
}