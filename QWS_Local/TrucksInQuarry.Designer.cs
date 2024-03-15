
namespace QWS_Local
{
    partial class TrucksInQuarry
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
            System.Windows.Forms.Label entryDTTMLabel;
            System.Windows.Forms.Label queueStatusLabel;
            System.Windows.Forms.Label weighbridgeIDLabel;
            System.Windows.Forms.Label driverLabel;
            System.Windows.Forms.Label sAPOrderLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label materialDescLabel;
            System.Windows.Forms.Label gVMLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label gVMTruckLabel;
            System.Windows.Forms.Label tareTkLabel;
            System.Windows.Forms.Label axleConfigurationLabel;
            System.Windows.Forms.Label schemeCodeLabel;
            System.Windows.Forms.Label truckOwnerLabel;
            System.Windows.Forms.Label truckOwnerCodeLabel;
            System.Windows.Forms.Label roadAccessLabel;
            System.Windows.Forms.Label feeCodeLabel;
            System.Windows.Forms.Label truckConfigLabel;
            System.Windows.Forms.Label payloadLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label stockpileLotNoLabel;
            System.Windows.Forms.Label cartageCodeLabel;
            System.Windows.Forms.Label payloadSplitLabel;
            System.Windows.Forms.Label schemeCodeLabel1;
            System.Windows.Forms.Label tareTkLabel1;
            System.Windows.Forms.Label tareLabel1;
            System.Windows.Forms.Label custONLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            this.truckConfigTextBox = new System.Windows.Forms.TextBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.roadAccessTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.schemeCodeTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.tareTkTextBox = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox = new System.Windows.Forms.TextBox();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.gVMTextBox = new System.Windows.Forms.TextBox();
            this.materialDescTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.sAPOrderTextBox = new System.Windows.Forms.TextBox();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.weighbridgeIDTextBox = new System.Windows.Forms.TextBox();
            this.queueStatusTextBox = new System.Windows.Forms.TextBox();
            this.entryDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regoTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.mtxtWeight = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.TruckConfig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVMTruck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTIQ = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.bsAxleConfig = new System.Windows.Forms.BindingSource(this.components);
            this.queueStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taTIQ = new QWS_Local.dsQWSLocalTableAdapters.TrucksInQuarryTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.taAxleConfig = new QWS_Local.dsQWSLocalTableAdapters.AxleConfigurationTableAdapter();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.stockpileLotNoTextBox = new System.Windows.Forms.TextBox();
            this.cartageCodeTextBox = new System.Windows.Forms.TextBox();
            this.payloadSplitTextBox = new System.Windows.Forms.TextBox();
            this.schemeCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.tareTkTextBox1 = new System.Windows.Forms.TextBox();
            this.tareTextBox1 = new System.Windows.Forms.TextBox();
            this.custONTextBox = new System.Windows.Forms.TextBox();
            regoLabel = new System.Windows.Forms.Label();
            entryDTTMLabel = new System.Windows.Forms.Label();
            queueStatusLabel = new System.Windows.Forms.Label();
            weighbridgeIDLabel = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            sAPOrderLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            materialDescLabel = new System.Windows.Forms.Label();
            gVMLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            gVMTruckLabel = new System.Windows.Forms.Label();
            tareTkLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            schemeCodeLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            truckOwnerCodeLabel = new System.Windows.Forms.Label();
            roadAccessLabel = new System.Windows.Forms.Label();
            feeCodeLabel = new System.Windows.Forms.Label();
            truckConfigLabel = new System.Windows.Forms.Label();
            payloadLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            stockpileLotNoLabel = new System.Windows.Forms.Label();
            cartageCodeLabel = new System.Windows.Forms.Label();
            payloadSplitLabel = new System.Windows.Forms.Label();
            schemeCodeLabel1 = new System.Windows.Forms.Label();
            tareTkLabel1 = new System.Windows.Forms.Label();
            tareLabel1 = new System.Windows.Forms.Label();
            custONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(92, 33);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(52, 20);
            regoLabel.TabIndex = 0;
            regoLabel.Text = "Rego:";
            // 
            // entryDTTMLabel
            // 
            entryDTTMLabel.AutoSize = true;
            entryDTTMLabel.Location = new System.Drawing.Point(47, 97);
            entryDTTMLabel.Name = "entryDTTMLabel";
            entryDTTMLabel.Size = new System.Drawing.Size(97, 20);
            entryDTTMLabel.TabIndex = 2;
            entryDTTMLabel.Text = "Entry DTTM:";
            // 
            // queueStatusLabel
            // 
            queueStatusLabel.AutoSize = true;
            queueStatusLabel.Location = new System.Drawing.Point(32, 128);
            queueStatusLabel.Name = "queueStatusLabel";
            queueStatusLabel.Size = new System.Drawing.Size(112, 20);
            queueStatusLabel.TabIndex = 4;
            queueStatusLabel.Text = "Queue Status:";
            // 
            // weighbridgeIDLabel
            // 
            weighbridgeIDLabel.AutoSize = true;
            weighbridgeIDLabel.Location = new System.Drawing.Point(22, 261);
            weighbridgeIDLabel.Name = "weighbridgeIDLabel";
            weighbridgeIDLabel.Size = new System.Drawing.Size(123, 20);
            weighbridgeIDLabel.TabIndex = 6;
            weighbridgeIDLabel.Text = "Weighbridge ID:";
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(91, 64);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(54, 20);
            driverLabel.TabIndex = 8;
            driverLabel.Text = "Driver:";
            // 
            // sAPOrderLabel
            // 
            sAPOrderLabel.AutoSize = true;
            sAPOrderLabel.Location = new System.Drawing.Point(59, 164);
            sAPOrderLabel.Name = "sAPOrderLabel";
            sAPOrderLabel.Size = new System.Drawing.Size(85, 20);
            sAPOrderLabel.TabIndex = 10;
            sAPOrderLabel.Text = "SAPOrder:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(75, 196);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(69, 20);
            materialLabel.TabIndex = 12;
            materialLabel.Text = "Material:";
            // 
            // materialDescLabel
            // 
            materialDescLabel.AutoSize = true;
            materialDescLabel.Location = new System.Drawing.Point(34, 228);
            materialDescLabel.Name = "materialDescLabel";
            materialDescLabel.Size = new System.Drawing.Size(110, 20);
            materialDescLabel.TabIndex = 14;
            materialDescLabel.Text = "Material Desc:";
            // 
            // gVMLabel
            // 
            gVMLabel.AutoSize = true;
            gVMLabel.Location = new System.Drawing.Point(445, 229);
            gVMLabel.Name = "gVMLabel";
            gVMLabel.Size = new System.Drawing.Size(50, 20);
            gVMLabel.TabIndex = 16;
            gVMLabel.Text = "GCM:";
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(497, 327);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(45, 20);
            tareLabel.TabIndex = 18;
            tareLabel.Text = "Tare:";
            // 
            // gVMTruckLabel
            // 
            gVMTruckLabel.AutoSize = true;
            gVMTruckLabel.Location = new System.Drawing.Point(406, 261);
            gVMTruckLabel.Name = "gVMTruckLabel";
            gVMTruckLabel.Size = new System.Drawing.Size(89, 20);
            gVMTruckLabel.TabIndex = 20;
            gVMTruckLabel.Text = "GVMTruck:";
            // 
            // tareTkLabel
            // 
            tareTkLabel.AutoSize = true;
            tareTkLabel.Location = new System.Drawing.Point(696, 322);
            tareTkLabel.Name = "tareTkLabel";
            tareTkLabel.Size = new System.Drawing.Size(66, 20);
            tareTkLabel.TabIndex = 22;
            tareTkLabel.Text = "Tare Tk:";
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(265, 36);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(93, 20);
            axleConfigurationLabel.TabIndex = 24;
            axleConfigurationLabel.Text = "Axle Config:";
            // 
            // schemeCodeLabel
            // 
            schemeCodeLabel.AutoSize = true;
            schemeCodeLabel.Location = new System.Drawing.Point(472, 33);
            schemeCodeLabel.Name = "schemeCodeLabel";
            schemeCodeLabel.Size = new System.Drawing.Size(114, 20);
            schemeCodeLabel.TabIndex = 26;
            schemeCodeLabel.Text = "Scheme Code:";
            // 
            // truckOwnerLabel
            // 
            truckOwnerLabel.AutoSize = true;
            truckOwnerLabel.Location = new System.Drawing.Point(484, 64);
            truckOwnerLabel.Name = "truckOwnerLabel";
            truckOwnerLabel.Size = new System.Drawing.Size(102, 20);
            truckOwnerLabel.TabIndex = 28;
            truckOwnerLabel.Text = "Truck Owner:";
            // 
            // truckOwnerCodeLabel
            // 
            truckOwnerCodeLabel.AutoSize = true;
            truckOwnerCodeLabel.Location = new System.Drawing.Point(734, 36);
            truckOwnerCodeLabel.Name = "truckOwnerCodeLabel";
            truckOwnerCodeLabel.Size = new System.Drawing.Size(144, 20);
            truckOwnerCodeLabel.TabIndex = 30;
            truckOwnerCodeLabel.Text = "Truck Owner Code:";
            // 
            // roadAccessLabel
            // 
            roadAccessLabel.AutoSize = true;
            roadAccessLabel.Location = new System.Drawing.Point(57, 351);
            roadAccessLabel.Name = "roadAccessLabel";
            roadAccessLabel.Size = new System.Drawing.Size(108, 20);
            roadAccessLabel.TabIndex = 32;
            roadAccessLabel.Text = "Road Access:";
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(82, 319);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(83, 20);
            feeCodeLabel.TabIndex = 34;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // truckConfigLabel
            // 
            truckConfigLabel.AutoSize = true;
            truckConfigLabel.Location = new System.Drawing.Point(776, 128);
            truckConfigLabel.Name = "truckConfigLabel";
            truckConfigLabel.Size = new System.Drawing.Size(102, 20);
            truckConfigLabel.TabIndex = 36;
            truckConfigLabel.Text = "Truck Config:";
            // 
            // payloadLabel
            // 
            payloadLabel.AutoSize = true;
            payloadLabel.Location = new System.Drawing.Point(809, 225);
            payloadLabel.Name = "payloadLabel";
            payloadLabel.Size = new System.Drawing.Size(69, 20);
            payloadLabel.TabIndex = 38;
            payloadLabel.Text = "Payload:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 692);
            this.splitContainer1.SplitterDistance = 1170;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.button8);
            this.splitContainer2.Panel1.Controls.Add(this.button7);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddVehicle);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.button6);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.regoTextBox1);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1170, 692);
            this.splitContainer2.SplitterDistance = 347;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 341);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 29);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(1162, 210);
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
            this.queueStatusDataGridViewTextBoxColumn,
            this.releaseDTTMDataGridViewTextBoxColumn,
            this.regoDataGridViewTextBoxColumn,
            this.TruckConfig,
            this.payloadDataGridViewTextBoxColumn,
            this.materialDescDataGridViewTextBoxColumn,
            this.driverDataGridViewTextBoxColumn,
            this.GCM,
            this.GVMTruck,
            this.TruckOwner,
            this.materialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsTIQ;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpDetails
            // 
            this.tpDetails.AutoScroll = true;
            this.tpDetails.Controls.Add(custONLabel);
            this.tpDetails.Controls.Add(this.custONTextBox);
            this.tpDetails.Controls.Add(tareLabel1);
            this.tpDetails.Controls.Add(this.tareTextBox1);
            this.tpDetails.Controls.Add(tareTkLabel1);
            this.tpDetails.Controls.Add(this.tareTkTextBox1);
            this.tpDetails.Controls.Add(schemeCodeLabel1);
            this.tpDetails.Controls.Add(this.schemeCodeTextBox1);
            this.tpDetails.Controls.Add(payloadSplitLabel);
            this.tpDetails.Controls.Add(this.payloadSplitTextBox);
            this.tpDetails.Controls.Add(cartageCodeLabel);
            this.tpDetails.Controls.Add(this.cartageCodeTextBox);
            this.tpDetails.Controls.Add(stockpileLotNoLabel);
            this.tpDetails.Controls.Add(this.stockpileLotNoTextBox);
            this.tpDetails.Controls.Add(deliveryAddressLabel);
            this.tpDetails.Controls.Add(this.deliveryAddressTextBox);
            this.tpDetails.Controls.Add(payloadLabel);
            this.tpDetails.Controls.Add(this.payloadTextBox);
            this.tpDetails.Controls.Add(truckConfigLabel);
            this.tpDetails.Controls.Add(this.truckConfigTextBox);
            this.tpDetails.Controls.Add(feeCodeLabel);
            this.tpDetails.Controls.Add(this.feeCodeTextBox);
            this.tpDetails.Controls.Add(roadAccessLabel);
            this.tpDetails.Controls.Add(this.roadAccessTextBox);
            this.tpDetails.Controls.Add(truckOwnerCodeLabel);
            this.tpDetails.Controls.Add(this.truckOwnerCodeTextBox);
            this.tpDetails.Controls.Add(truckOwnerLabel);
            this.tpDetails.Controls.Add(this.truckOwnerTextBox);
            this.tpDetails.Controls.Add(schemeCodeLabel);
            this.tpDetails.Controls.Add(this.schemeCodeTextBox);
            this.tpDetails.Controls.Add(axleConfigurationLabel);
            this.tpDetails.Controls.Add(this.axleConfigurationTextBox);
            this.tpDetails.Controls.Add(tareTkLabel);
            this.tpDetails.Controls.Add(this.tareTkTextBox);
            this.tpDetails.Controls.Add(gVMTruckLabel);
            this.tpDetails.Controls.Add(this.gVMTruckTextBox);
            this.tpDetails.Controls.Add(tareLabel);
            this.tpDetails.Controls.Add(this.tareTextBox);
            this.tpDetails.Controls.Add(gVMLabel);
            this.tpDetails.Controls.Add(this.gVMTextBox);
            this.tpDetails.Controls.Add(materialDescLabel);
            this.tpDetails.Controls.Add(this.materialDescTextBox);
            this.tpDetails.Controls.Add(materialLabel);
            this.tpDetails.Controls.Add(this.materialTextBox);
            this.tpDetails.Controls.Add(sAPOrderLabel);
            this.tpDetails.Controls.Add(this.sAPOrderTextBox);
            this.tpDetails.Controls.Add(driverLabel);
            this.tpDetails.Controls.Add(this.driverTextBox);
            this.tpDetails.Controls.Add(weighbridgeIDLabel);
            this.tpDetails.Controls.Add(this.weighbridgeIDTextBox);
            this.tpDetails.Controls.Add(queueStatusLabel);
            this.tpDetails.Controls.Add(this.queueStatusTextBox);
            this.tpDetails.Controls.Add(entryDTTMLabel);
            this.tpDetails.Controls.Add(this.entryDTTMDateTimePicker);
            this.tpDetails.Controls.Add(regoLabel);
            this.tpDetails.Controls.Add(this.regoTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 29);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1162, 308);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Payload", true));
            this.payloadTextBox.Location = new System.Drawing.Point(884, 222);
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.Size = new System.Drawing.Size(100, 26);
            this.payloadTextBox.TabIndex = 39;
            // 
            // truckConfigTextBox
            // 
            this.truckConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckConfig", true));
            this.truckConfigTextBox.Location = new System.Drawing.Point(884, 125);
            this.truckConfigTextBox.Name = "truckConfigTextBox";
            this.truckConfigTextBox.Size = new System.Drawing.Size(100, 26);
            this.truckConfigTextBox.TabIndex = 37;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(171, 316);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.feeCodeTextBox.TabIndex = 35;
            // 
            // roadAccessTextBox
            // 
            this.roadAccessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "RoadAccess", true));
            this.roadAccessTextBox.Location = new System.Drawing.Point(171, 348);
            this.roadAccessTextBox.Name = "roadAccessTextBox";
            this.roadAccessTextBox.Size = new System.Drawing.Size(100, 26);
            this.roadAccessTextBox.TabIndex = 33;
            // 
            // truckOwnerCodeTextBox
            // 
            this.truckOwnerCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwnerCode", true));
            this.truckOwnerCodeTextBox.Location = new System.Drawing.Point(884, 33);
            this.truckOwnerCodeTextBox.Name = "truckOwnerCodeTextBox";
            this.truckOwnerCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.truckOwnerCodeTextBox.TabIndex = 31;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(592, 65);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.Size = new System.Drawing.Size(392, 26);
            this.truckOwnerTextBox.TabIndex = 29;
            // 
            // schemeCodeTextBox
            // 
            this.schemeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "SchemeCode", true));
            this.schemeCodeTextBox.Location = new System.Drawing.Point(592, 30);
            this.schemeCodeTextBox.Name = "schemeCodeTextBox";
            this.schemeCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.schemeCodeTextBox.TabIndex = 27;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(364, 30);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(100, 26);
            this.axleConfigurationTextBox.TabIndex = 25;
            // 
            // tareTkTextBox
            // 
            this.tareTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TareTk", true));
            this.tareTkTextBox.Location = new System.Drawing.Point(768, 319);
            this.tareTkTextBox.Name = "tareTkTextBox";
            this.tareTkTextBox.Size = new System.Drawing.Size(100, 26);
            this.tareTkTextBox.TabIndex = 23;
            // 
            // gVMTruckTextBox
            // 
            this.gVMTruckTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "GVMTruck", true));
            this.gVMTruckTextBox.Location = new System.Drawing.Point(501, 258);
            this.gVMTruckTextBox.Name = "gVMTruckTextBox";
            this.gVMTruckTextBox.Size = new System.Drawing.Size(100, 26);
            this.gVMTruckTextBox.TabIndex = 21;
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(548, 324);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(100, 26);
            this.tareTextBox.TabIndex = 19;
            // 
            // gVMTextBox
            // 
            this.gVMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "GCM", true));
            this.gVMTextBox.Location = new System.Drawing.Point(501, 226);
            this.gVMTextBox.Name = "gVMTextBox";
            this.gVMTextBox.Size = new System.Drawing.Size(100, 26);
            this.gVMTextBox.TabIndex = 17;
            // 
            // materialDescTextBox
            // 
            this.materialDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "MaterialDesc", true));
            this.materialDescTextBox.Location = new System.Drawing.Point(150, 225);
            this.materialDescTextBox.Name = "materialDescTextBox";
            this.materialDescTextBox.Size = new System.Drawing.Size(271, 26);
            this.materialDescTextBox.TabIndex = 15;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(150, 193);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(100, 26);
            this.materialTextBox.TabIndex = 13;
            // 
            // sAPOrderTextBox
            // 
            this.sAPOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "SAPOrder", true));
            this.sAPOrderTextBox.Location = new System.Drawing.Point(150, 161);
            this.sAPOrderTextBox.Name = "sAPOrderTextBox";
            this.sAPOrderTextBox.Size = new System.Drawing.Size(100, 26);
            this.sAPOrderTextBox.TabIndex = 11;
            // 
            // driverTextBox
            // 
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(151, 61);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.Size = new System.Drawing.Size(256, 26);
            this.driverTextBox.TabIndex = 9;
            // 
            // weighbridgeIDTextBox
            // 
            this.weighbridgeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "WeighbridgeID", true));
            this.weighbridgeIDTextBox.Location = new System.Drawing.Point(151, 258);
            this.weighbridgeIDTextBox.Name = "weighbridgeIDTextBox";
            this.weighbridgeIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.weighbridgeIDTextBox.TabIndex = 7;
            // 
            // queueStatusTextBox
            // 
            this.queueStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "QueueStatus", true));
            this.queueStatusTextBox.Location = new System.Drawing.Point(150, 125);
            this.queueStatusTextBox.Name = "queueStatusTextBox";
            this.queueStatusTextBox.Size = new System.Drawing.Size(100, 26);
            this.queueStatusTextBox.TabIndex = 5;
            // 
            // entryDTTMDateTimePicker
            // 
            this.entryDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTIQ, "EntryDTTM", true));
            this.entryDTTMDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.entryDTTMDateTimePicker.Location = new System.Drawing.Point(150, 93);
            this.entryDTTMDateTimePicker.Name = "entryDTTMDateTimePicker";
            this.entryDTTMDateTimePicker.Size = new System.Drawing.Size(134, 26);
            this.entryDTTMDateTimePicker.TabIndex = 3;
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(150, 30);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.Size = new System.Drawing.Size(100, 26);
            this.regoTextBox.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(33, 287);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 49);
            this.button4.TabIndex = 54;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PeachPuff;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(919, 287);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 49);
            this.button5.TabIndex = 54;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(919, 69);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 49);
            this.button3.TabIndex = 53;
            this.button3.Text = "up";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(919, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 49);
            this.button2.TabIndex = 52;
            this.button2.Text = "down";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(919, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 49);
            this.button1.TabIndex = 51;
            this.button1.Text = "info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(659, 287);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(86, 49);
            this.btnAddVehicle.TabIndex = 50;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsAxleConfig, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(417, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // regoTextBox1
            // 
            this.regoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Rego", true));
            this.regoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regoTextBox1.Location = new System.Drawing.Point(417, 28);
            this.regoTextBox1.Name = "regoTextBox1";
            this.regoTextBox1.Size = new System.Drawing.Size(450, 32);
            this.regoTextBox1.TabIndex = 57;
            this.regoTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtWeight);
            this.groupBox1.Controls.Add(this.rbManual);
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 87);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weighing Mode";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(42, 46);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(61, 24);
            this.rbAuto.TabIndex = 0;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Auto";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(143, 46);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(79, 24);
            this.rbManual.TabIndex = 1;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // mtxtWeight
            // 
            this.mtxtWeight.Location = new System.Drawing.Point(255, 46);
            this.mtxtWeight.Mask = "00.00";
            this.mtxtWeight.Name = "mtxtWeight";
            this.mtxtWeight.Size = new System.Drawing.Size(59, 26);
            this.mtxtWeight.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "AxleConfiguration", true));
            this.textBox1.Location = new System.Drawing.Point(767, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 59;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(417, 287);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 49);
            this.button6.TabIndex = 60;
            this.button6.Text = "Release/Hold";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox2.Location = new System.Drawing.Point(417, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(344, 26);
            this.textBox2.TabIndex = 61;
            this.textBox2.Text = "weighing instructions";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(265, 287);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 49);
            this.button7.TabIndex = 62;
            this.button7.Text = "Weigh";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(753, 287);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 49);
            this.button8.TabIndex = 63;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox3.Location = new System.Drawing.Point(33, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 26);
            this.textBox3.TabIndex = 64;
            this.textBox3.Text = "overdue message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Location = new System.Drawing.Point(33, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 77);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Captured Weights";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(255, 32);
            this.maskedTextBox1.Mask = "00.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(59, 26);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.Text = "0000";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(143, 32);
            this.maskedTextBox2.Mask = "00.00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(59, 26);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.Text = "0000";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(18, 32);
            this.maskedTextBox3.Mask = "00.00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(59, 26);
            this.maskedTextBox3.TabIndex = 5;
            this.maskedTextBox3.Text = "0000";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TruckConfig
            // 
            this.TruckConfig.DataPropertyName = "TruckConfig";
            this.TruckConfig.HeaderText = "Config";
            this.TruckConfig.Name = "TruckConfig";
            this.TruckConfig.ReadOnly = true;
            this.TruckConfig.Width = 70;
            // 
            // GCM
            // 
            this.GCM.DataPropertyName = "GCM";
            this.GCM.HeaderText = "GCM";
            this.GCM.Name = "GCM";
            this.GCM.ReadOnly = true;
            // 
            // GVMTruck
            // 
            this.GVMTruck.DataPropertyName = "GVMTruck";
            this.GVMTruck.HeaderText = "GVMTruck";
            this.GVMTruck.Name = "GVMTruck";
            this.GVMTruck.ReadOnly = true;
            // 
            // TruckOwner
            // 
            this.TruckOwner.DataPropertyName = "TruckOwner";
            this.TruckOwner.HeaderText = "TruckOwner";
            this.TruckOwner.Name = "TruckOwner";
            this.TruckOwner.ReadOnly = true;
            // 
            // bsTIQ
            // 
            this.bsTIQ.DataMember = "TrucksInQuarry";
            this.bsTIQ.DataSource = this.dsQWSLocal;
            this.bsTIQ.CurrentChanged += new System.EventHandler(this.bsTIQ_CurrentChanged);
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAxleConfig
            // 
            this.bsAxleConfig.DataMember = "AxleConfiguration";
            this.bsAxleConfig.DataSource = this.dsQWSLocal;
            // 
            // queueStatusDataGridViewTextBoxColumn
            // 
            this.queueStatusDataGridViewTextBoxColumn.DataPropertyName = "QueueStatus";
            this.queueStatusDataGridViewTextBoxColumn.HeaderText = "QS";
            this.queueStatusDataGridViewTextBoxColumn.Name = "queueStatusDataGridViewTextBoxColumn";
            this.queueStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.queueStatusDataGridViewTextBoxColumn.Width = 50;
            // 
            // releaseDTTMDataGridViewTextBoxColumn
            // 
            this.releaseDTTMDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDTTM";
            dataGridViewCellStyle2.Format = "HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.releaseDTTMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.releaseDTTMDataGridViewTextBoxColumn.HeaderText = "Release";
            this.releaseDTTMDataGridViewTextBoxColumn.Name = "releaseDTTMDataGridViewTextBoxColumn";
            this.releaseDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            this.releaseDTTMDataGridViewTextBoxColumn.Width = 70;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            this.regoDataGridViewTextBoxColumn.ReadOnly = true;
            this.regoDataGridViewTextBoxColumn.Width = 70;
            // 
            // payloadDataGridViewTextBoxColumn
            // 
            this.payloadDataGridViewTextBoxColumn.DataPropertyName = "Payload";
            this.payloadDataGridViewTextBoxColumn.HeaderText = "Payload";
            this.payloadDataGridViewTextBoxColumn.Name = "payloadDataGridViewTextBoxColumn";
            this.payloadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDescDataGridViewTextBoxColumn
            // 
            this.materialDescDataGridViewTextBoxColumn.DataPropertyName = "MaterialDesc";
            this.materialDescDataGridViewTextBoxColumn.HeaderText = "MaterialDesc";
            this.materialDescDataGridViewTextBoxColumn.Name = "materialDescDataGridViewTextBoxColumn";
            this.materialDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialDescDataGridViewTextBoxColumn.Width = 200;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            this.driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn.HeaderText = "Driver";
            this.driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            this.driverDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taTIQ
            // 
            this.taTIQ.ClearBeforeFill = true;
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
            this.tableAdapterManager.TrucksInQuarryTableAdapter = this.taTIQ;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclePBSTableAdapter = null;
            this.tableAdapterManager.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.VehicleTypeTableAdapter = null;
            // 
            // taAxleConfig
            // 
            this.taAxleConfig.ClearBeforeFill = true;
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(276, 164);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(131, 20);
            deliveryAddressLabel.TabIndex = 40;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(413, 161);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(279, 26);
            this.deliveryAddressTextBox.TabIndex = 41;
            // 
            // stockpileLotNoLabel
            // 
            stockpileLotNoLabel.AutoSize = true;
            stockpileLotNoLabel.Location = new System.Drawing.Point(278, 192);
            stockpileLotNoLabel.Name = "stockpileLotNoLabel";
            stockpileLotNoLabel.Size = new System.Drawing.Size(129, 20);
            stockpileLotNoLabel.TabIndex = 42;
            stockpileLotNoLabel.Text = "Stockpile Lot No:";
            // 
            // stockpileLotNoTextBox
            // 
            this.stockpileLotNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "StockpileLotNo", true));
            this.stockpileLotNoTextBox.Location = new System.Drawing.Point(413, 189);
            this.stockpileLotNoTextBox.Name = "stockpileLotNoTextBox";
            this.stockpileLotNoTextBox.Size = new System.Drawing.Size(100, 26);
            this.stockpileLotNoTextBox.TabIndex = 43;
            // 
            // cartageCodeLabel
            // 
            cartageCodeLabel.AutoSize = true;
            cartageCodeLabel.Location = new System.Drawing.Point(766, 160);
            cartageCodeLabel.Name = "cartageCodeLabel";
            cartageCodeLabel.Size = new System.Drawing.Size(112, 20);
            cartageCodeLabel.TabIndex = 44;
            cartageCodeLabel.Text = "Cartage Code:";
            // 
            // cartageCodeTextBox
            // 
            this.cartageCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "CartageCode", true));
            this.cartageCodeTextBox.Location = new System.Drawing.Point(884, 157);
            this.cartageCodeTextBox.Name = "cartageCodeTextBox";
            this.cartageCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.cartageCodeTextBox.TabIndex = 45;
            // 
            // payloadSplitLabel
            // 
            payloadSplitLabel.AutoSize = true;
            payloadSplitLabel.Location = new System.Drawing.Point(774, 193);
            payloadSplitLabel.Name = "payloadSplitLabel";
            payloadSplitLabel.Size = new System.Drawing.Size(104, 20);
            payloadSplitLabel.TabIndex = 46;
            payloadSplitLabel.Text = "Payload Split:";
            // 
            // payloadSplitTextBox
            // 
            this.payloadSplitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "PayloadSplit", true));
            this.payloadSplitTextBox.Location = new System.Drawing.Point(884, 190);
            this.payloadSplitTextBox.Name = "payloadSplitTextBox";
            this.payloadSplitTextBox.Size = new System.Drawing.Size(100, 26);
            this.payloadSplitTextBox.TabIndex = 47;
            // 
            // schemeCodeLabel1
            // 
            schemeCodeLabel1.AutoSize = true;
            schemeCodeLabel1.Location = new System.Drawing.Point(765, 96);
            schemeCodeLabel1.Name = "schemeCodeLabel1";
            schemeCodeLabel1.Size = new System.Drawing.Size(114, 20);
            schemeCodeLabel1.TabIndex = 48;
            schemeCodeLabel1.Text = "Scheme Code:";
            // 
            // schemeCodeTextBox1
            // 
            this.schemeCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "SchemeCode", true));
            this.schemeCodeTextBox1.Location = new System.Drawing.Point(885, 93);
            this.schemeCodeTextBox1.Name = "schemeCodeTextBox1";
            this.schemeCodeTextBox1.Size = new System.Drawing.Size(100, 26);
            this.schemeCodeTextBox1.TabIndex = 49;
            // 
            // tareTkLabel1
            // 
            tareTkLabel1.AutoSize = true;
            tareTkLabel1.Location = new System.Drawing.Point(614, 261);
            tareTkLabel1.Name = "tareTkLabel1";
            tareTkLabel1.Size = new System.Drawing.Size(66, 20);
            tareTkLabel1.TabIndex = 50;
            tareTkLabel1.Text = "Tare Tk:";
            // 
            // tareTkTextBox1
            // 
            this.tareTkTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TareTk", true));
            this.tareTkTextBox1.Location = new System.Drawing.Point(686, 258);
            this.tareTkTextBox1.Name = "tareTkTextBox1";
            this.tareTkTextBox1.Size = new System.Drawing.Size(100, 26);
            this.tareTkTextBox1.TabIndex = 51;
            // 
            // tareLabel1
            // 
            tareLabel1.AutoSize = true;
            tareLabel1.Location = new System.Drawing.Point(635, 229);
            tareLabel1.Name = "tareLabel1";
            tareLabel1.Size = new System.Drawing.Size(45, 20);
            tareLabel1.TabIndex = 52;
            tareLabel1.Text = "Tare:";
            // 
            // tareTextBox1
            // 
            this.tareTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Tare", true));
            this.tareTextBox1.Location = new System.Drawing.Point(686, 226);
            this.tareTextBox1.Name = "tareTextBox1";
            this.tareTextBox1.Size = new System.Drawing.Size(100, 26);
            this.tareTextBox1.TabIndex = 53;
            // 
            // custONLabel
            // 
            custONLabel.AutoSize = true;
            custONLabel.Location = new System.Drawing.Point(334, 132);
            custONLabel.Name = "custONLabel";
            custONLabel.Size = new System.Drawing.Size(73, 20);
            custONLabel.TabIndex = 54;
            custONLabel.Text = "Cust ON:";
            // 
            // custONTextBox
            // 
            this.custONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "CustON", true));
            this.custONTextBox.Location = new System.Drawing.Point(413, 129);
            this.custONTextBox.Name = "custONTextBox";
            this.custONTextBox.Size = new System.Drawing.Size(173, 26);
            this.custONTextBox.TabIndex = 55;
            // 
            // TrucksInQuarry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TrucksInQuarry";
            this.Text = "Trucks In Quarry";
            this.Load += new System.EventHandler(this.TrucksInQuarry_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsTIQ;
        private dsQWSLocalTableAdapters.TrucksInQuarryTableAdapter taTIQ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.TextBox gVMTextBox;
        private System.Windows.Forms.TextBox materialDescTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox sAPOrderTextBox;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.TextBox weighbridgeIDTextBox;
        private System.Windows.Forms.TextBox queueStatusTextBox;
        private System.Windows.Forms.DateTimePicker entryDTTMDateTimePicker;
        private System.Windows.Forms.TextBox regoTextBox;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox payloadTextBox;
        private System.Windows.Forms.TextBox truckConfigTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.TextBox roadAccessTextBox;
        private System.Windows.Forms.TextBox truckOwnerCodeTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox schemeCodeTextBox;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.TextBox tareTkTextBox;
        private System.Windows.Forms.TextBox gVMTruckTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bsAxleConfig;
        private dsQWSLocalTableAdapters.AxleConfigurationTableAdapter taAxleConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtWeight;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.TextBox regoTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn payloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVMTruck;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tareTextBox1;
        private System.Windows.Forms.TextBox tareTkTextBox1;
        private System.Windows.Forms.TextBox schemeCodeTextBox1;
        private System.Windows.Forms.TextBox payloadSplitTextBox;
        private System.Windows.Forms.TextBox cartageCodeTextBox;
        private System.Windows.Forms.TextBox stockpileLotNoTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox custONTextBox;
    }
}