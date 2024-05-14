
namespace QWS_Local
{
    partial class BookInDelivery
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
            System.Windows.Forms.Label docNumLabel;
            System.Windows.Forms.Label docDateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label materialCodeLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label openQtyLabel;
            System.Windows.Forms.Label suppliedLabel;
            System.Windows.Forms.Label cartageCodeLabel;
            System.Windows.Forms.Label cartageLabel;
            System.Windows.Forms.Label itemQALabel;
            System.Windows.Forms.Label sAPCommentsLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label mapRefLabel;
            System.Windows.Forms.Label distanceLabel;
            System.Windows.Forms.Label sAPUpdateDTTMLabel;
            System.Windows.Forms.Label orderStatusLabel;
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label personLabel;
            System.Windows.Forms.Label mobLabel;
            System.Windows.Forms.Label gCMLabel;
            System.Windows.Forms.Label gVMTruckLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label materialLabel1;
            System.Windows.Forms.Label openQtyLabel1;
            System.Windows.Forms.Label cartageCodeLabel1;
            System.Windows.Forms.Label label1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBookIn = new System.Windows.Forms.Button();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.bsDriver = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.bsConfiguredTruckGVM = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.regoTkTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHVR_Network = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDeliveryOrders = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.orderStatusTextBox = new System.Windows.Forms.TextBox();
            this.exBinOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.mapRefTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.sAPCommentsTextBox = new System.Windows.Forms.TextBox();
            this.itemQATextBox = new System.Windows.Forms.TextBox();
            this.cartageTextBox = new System.Windows.Forms.TextBox();
            this.cartageCodeTextBox = new System.Windows.Forms.TextBox();
            this.suppliedTextBox = new System.Windows.Forms.TextBox();
            this.openQtyTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.materialCodeTextBox = new System.Windows.Forms.TextBox();
            this.docNumTextBox = new System.Windows.Forms.TextBox();
            this.tpTruckConfig = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.regoTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxGVMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadAccessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTIQ2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.taDeliveryOrders = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.exBinOrdersTableAdapter = new QWS_Local.dsBookInTableAdapters.ExBinOrdersTableAdapter();
            this.taConfiguredTruckGVM = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.taDriver = new QWS_Local.dsQWSLocalTableAdapters.TruckDriverTableAdapter();
            this.tableAdapterManager2 = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.taTIQ2 = new QWS_Local.dsTIQ2TableAdapters.TIQTableAdapter();
            this.tableAdapterManager3 = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.nudPayloadTk = new System.Windows.Forms.NumericUpDown();
            this.nudPayloadTr = new System.Windows.Forms.NumericUpDown();
            this.nudPayload = new System.Windows.Forms.NumericUpDown();
            this.gCMTextBox = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox = new System.Windows.Forms.TextBox();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.tareTkTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.materialCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.materialTextBox1 = new System.Windows.Forms.TextBox();
            this.openQtyTextBox1 = new System.Windows.Forms.TextBox();
            this.cartageCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.txtPayloadTk = new System.Windows.Forms.TextBox();
            this.txtPayloadTr = new System.Windows.Forms.TextBox();
            docNumLabel = new System.Windows.Forms.Label();
            docDateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            materialCodeLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            openQtyLabel = new System.Windows.Forms.Label();
            suppliedLabel = new System.Windows.Forms.Label();
            cartageCodeLabel = new System.Windows.Forms.Label();
            cartageLabel = new System.Windows.Forms.Label();
            itemQALabel = new System.Windows.Forms.Label();
            sAPCommentsLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            mapRefLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            sAPUpdateDTTMLabel = new System.Windows.Forms.Label();
            orderStatusLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            personLabel = new System.Windows.Forms.Label();
            mobLabel = new System.Windows.Forms.Label();
            gCMLabel = new System.Windows.Forms.Label();
            gVMTruckLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            materialLabel1 = new System.Windows.Forms.Label();
            openQtyLabel1 = new System.Windows.Forms.Label();
            cartageCodeLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).BeginInit();
            this.tpTruckConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayload)).BeginInit();
            this.SuspendLayout();
            // 
            // docNumLabel
            // 
            docNumLabel.AutoSize = true;
            docNumLabel.Location = new System.Drawing.Point(61, 28);
            docNumLabel.Name = "docNumLabel";
            docNumLabel.Size = new System.Drawing.Size(70, 17);
            docNumLabel.TabIndex = 0;
            docNumLabel.Text = "Doc Num:";
            // 
            // docDateLabel
            // 
            docDateLabel.AutoSize = true;
            docDateLabel.Location = new System.Drawing.Point(293, 57);
            docDateLabel.Name = "docDateLabel";
            docDateLabel.Size = new System.Drawing.Size(71, 17);
            docDateLabel.TabIndex = 2;
            docDateLabel.Text = "Doc Date:";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(32, 57);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(97, 17);
            deliveryDateLabel.TabIndex = 4;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // materialCodeLabel
            // 
            materialCodeLabel.AutoSize = true;
            materialCodeLabel.Location = new System.Drawing.Point(32, 116);
            materialCodeLabel.Name = "materialCodeLabel";
            materialCodeLabel.Size = new System.Drawing.Size(99, 17);
            materialCodeLabel.TabIndex = 6;
            materialCodeLabel.Text = "Material Code:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(67, 145);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(62, 17);
            materialLabel.TabIndex = 8;
            materialLabel.Text = "Material:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(64, 174);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(65, 17);
            quantityLabel.TabIndex = 10;
            quantityLabel.Text = "Quantity:";
            // 
            // openQtyLabel
            // 
            openQtyLabel.AutoSize = true;
            openQtyLabel.Location = new System.Drawing.Point(56, 232);
            openQtyLabel.Name = "openQtyLabel";
            openQtyLabel.Size = new System.Drawing.Size(73, 17);
            openQtyLabel.TabIndex = 12;
            openQtyLabel.Text = "Open Qty:";
            // 
            // suppliedLabel
            // 
            suppliedLabel.AutoSize = true;
            suppliedLabel.Location = new System.Drawing.Point(62, 203);
            suppliedLabel.Name = "suppliedLabel";
            suppliedLabel.Size = new System.Drawing.Size(67, 17);
            suppliedLabel.TabIndex = 14;
            suppliedLabel.Text = "Supplied:";
            // 
            // cartageCodeLabel
            // 
            cartageCodeLabel.AutoSize = true;
            cartageCodeLabel.Location = new System.Drawing.Point(510, 57);
            cartageCodeLabel.Name = "cartageCodeLabel";
            cartageCodeLabel.Size = new System.Drawing.Size(99, 17);
            cartageCodeLabel.TabIndex = 16;
            cartageCodeLabel.Text = "Cartage Code:";
            // 
            // cartageLabel
            // 
            cartageLabel.AutoSize = true;
            cartageLabel.Location = new System.Drawing.Point(547, 86);
            cartageLabel.Name = "cartageLabel";
            cartageLabel.Size = new System.Drawing.Size(62, 17);
            cartageLabel.TabIndex = 18;
            cartageLabel.Text = "Cartage:";
            // 
            // itemQALabel
            // 
            itemQALabel.AutoSize = true;
            itemQALabel.Location = new System.Drawing.Point(302, 116);
            itemQALabel.Name = "itemQALabel";
            itemQALabel.Size = new System.Drawing.Size(62, 17);
            itemQALabel.TabIndex = 20;
            itemQALabel.Text = "Item QA:";
            // 
            // sAPCommentsLabel
            // 
            sAPCommentsLabel.AutoSize = true;
            sAPCommentsLabel.Location = new System.Drawing.Point(504, 144);
            sAPCommentsLabel.Name = "sAPCommentsLabel";
            sAPCommentsLabel.Size = new System.Drawing.Size(105, 17);
            sAPCommentsLabel.TabIndex = 22;
            sAPCommentsLabel.Text = "SAPComments:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(490, 115);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(119, 17);
            deliveryAddressLabel.TabIndex = 24;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // mapRefLabel
            // 
            mapRefLabel.AutoSize = true;
            mapRefLabel.Location = new System.Drawing.Point(721, 57);
            mapRefLabel.Name = "mapRefLabel";
            mapRefLabel.Size = new System.Drawing.Size(65, 17);
            mapRefLabel.TabIndex = 26;
            mapRefLabel.Text = "Map Ref:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new System.Drawing.Point(542, 28);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(67, 17);
            distanceLabel.TabIndex = 28;
            distanceLabel.Text = "Distance:";
            // 
            // sAPUpdateDTTMLabel
            // 
            sAPUpdateDTTMLabel.AutoSize = true;
            sAPUpdateDTTMLabel.Location = new System.Drawing.Point(487, 176);
            sAPUpdateDTTMLabel.Name = "sAPUpdateDTTMLabel";
            sAPUpdateDTTMLabel.Size = new System.Drawing.Size(128, 17);
            sAPUpdateDTTMLabel.TabIndex = 30;
            sAPUpdateDTTMLabel.Text = "SAPUpdate DTTM:";
            // 
            // orderStatusLabel
            // 
            orderStatusLabel.AutoSize = true;
            orderStatusLabel.Location = new System.Drawing.Point(271, 28);
            orderStatusLabel.Name = "orderStatusLabel";
            orderStatusLabel.Size = new System.Drawing.Size(93, 17);
            orderStatusLabel.TabIndex = 33;
            orderStatusLabel.Text = "Order Status:";
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(486, 44);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(53, 17);
            ownerLabel.TabIndex = 79;
            ownerLabel.Text = "Owner:";
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(485, 73);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(50, 17);
            personLabel.TabIndex = 85;
            personLabel.Text = "Driver:";
            // 
            // mobLabel
            // 
            mobLabel.AutoSize = true;
            mobLabel.Location = new System.Drawing.Point(503, 102);
            mobLabel.Name = "mobLabel";
            mobLabel.Size = new System.Drawing.Size(39, 17);
            mobLabel.TabIndex = 86;
            mobLabel.Text = "Mob:";
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
            this.splitContainer1.Panel1.Controls.Add(this.nudPayloadTk);
            this.splitContainer1.Panel1.Controls.Add(label1);
            this.splitContainer1.Panel1.Controls.Add(this.nudPayloadTr);
            this.splitContainer1.Panel1.Controls.Add(this.txtPayloadTr);
            this.splitContainer1.Panel1.Controls.Add(this.nudPayload);
            this.splitContainer1.Panel1.Controls.Add(this.gCMTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.txtPayloadTk);
            this.splitContainer1.Panel1.Controls.Add(gCMLabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtPayload);
            this.splitContainer1.Panel1.Controls.Add(this.gVMTruckTextBox);
            this.splitContainer1.Panel1.Controls.Add(cartageCodeLabel1);
            this.splitContainer1.Panel1.Controls.Add(gVMTruckLabel);
            this.splitContainer1.Panel1.Controls.Add(this.cartageCodeTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tareTextBox);
            this.splitContainer1.Panel1.Controls.Add(openQtyLabel1);
            this.splitContainer1.Panel1.Controls.Add(tareLabel);
            this.splitContainer1.Panel1.Controls.Add(this.openQtyTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tareTkTextBox);
            this.splitContainer1.Panel1.Controls.Add(materialLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.materialTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.materialCodeTextBox1);
            this.splitContainer1.Panel1.Controls.Add(customerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.customerTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.cardCodeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.btnBookIn);
            this.splitContainer1.Panel1.Controls.Add(mobLabel);
            this.splitContainer1.Panel1.Controls.Add(this.mobTextBox);
            this.splitContainer1.Panel1.Controls.Add(personLabel);
            this.splitContainer1.Panel1.Controls.Add(this.personTextBox);
            this.splitContainer1.Panel1.Controls.Add(ownerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ownerTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.regoTkTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1361, 631);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnBookIn
            // 
            this.btnBookIn.Location = new System.Drawing.Point(1023, 249);
            this.btnBookIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookIn.Name = "btnBookIn";
            this.btnBookIn.Size = new System.Drawing.Size(203, 28);
            this.btnBookIn.TabIndex = 88;
            this.btnBookIn.Text = "Book In";
            this.btnBookIn.UseVisualStyleBackColor = true;
            this.btnBookIn.Click += new System.EventHandler(this.btnBookIn_Click);
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(548, 99);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.Size = new System.Drawing.Size(100, 23);
            this.mobTextBox.TabIndex = 87;
            // 
            // bsDriver
            // 
            this.bsDriver.DataMember = "TruckDriver";
            this.bsDriver.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(548, 70);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(194, 23);
            this.personTextBox.TabIndex = 86;
            // 
            // bsConfiguredTruckGVM
            // 
            this.bsConfiguredTruckGVM.DataMember = "ConfiguredTruckGVM";
            this.bsConfiguredTruckGVM.DataSource = this.dsTruckConfig;
            this.bsConfiguredTruckGVM.CurrentChanged += new System.EventHandler(this.bsConfiguredTruckGVM_CurrentChanged);
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTruckGVM, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(548, 41);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(194, 23);
            this.ownerTextBox.TabIndex = 82;
            // 
            // regoTkTextBox
            // 
            this.regoTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTruckGVM, "RegoTk", true));
            this.regoTkTextBox.Location = new System.Drawing.Point(12, 12);
            this.regoTkTextBox.Name = "regoTkTextBox";
            this.regoTkTextBox.Size = new System.Drawing.Size(100, 23);
            this.regoTkTextBox.TabIndex = 78;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsConfiguredTruckGVM, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 249);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(203, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Refresh Orders";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Controls.Add(this.tpTruckConfig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1361, 345);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 25);
            this.tpList.Margin = new System.Windows.Forms.Padding(4);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(4);
            this.tpList.Size = new System.Drawing.Size(1353, 316);
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
            this.docNumDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.OrderStatus,
            this.purchaseOrderDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactMobileDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.openQtyDataGridViewTextBoxColumn,
            this.cartageCodeDataGridViewTextBoxColumn,
            this.NHVR_Network});
            this.dataGridView1.DataSource = this.bsDeliveryOrders;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "DocNum";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            this.docNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // purchaseOrderDataGridViewTextBoxColumn
            // 
            this.purchaseOrderDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrder";
            this.purchaseOrderDataGridViewTextBoxColumn.HeaderText = "Cust PO";
            this.purchaseOrderDataGridViewTextBoxColumn.Name = "purchaseOrderDataGridViewTextBoxColumn";
            this.purchaseOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactMobileDataGridViewTextBoxColumn
            // 
            this.contactMobileDataGridViewTextBoxColumn.DataPropertyName = "ContactMobile";
            this.contactMobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.contactMobileDataGridViewTextBoxColumn.Name = "contactMobileDataGridViewTextBoxColumn";
            this.contactMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialCodeDataGridViewTextBoxColumn
            // 
            this.materialCodeDataGridViewTextBoxColumn.DataPropertyName = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.HeaderText = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.Name = "materialCodeDataGridViewTextBoxColumn";
            this.materialCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openQtyDataGridViewTextBoxColumn
            // 
            this.openQtyDataGridViewTextBoxColumn.DataPropertyName = "OpenQty";
            this.openQtyDataGridViewTextBoxColumn.HeaderText = "OpenQty";
            this.openQtyDataGridViewTextBoxColumn.Name = "openQtyDataGridViewTextBoxColumn";
            this.openQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartageCodeDataGridViewTextBoxColumn
            // 
            this.cartageCodeDataGridViewTextBoxColumn.DataPropertyName = "CartageCode";
            this.cartageCodeDataGridViewTextBoxColumn.HeaderText = "CartageCode";
            this.cartageCodeDataGridViewTextBoxColumn.Name = "cartageCodeDataGridViewTextBoxColumn";
            this.cartageCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NHVR_Network
            // 
            this.NHVR_Network.DataPropertyName = "NHVR_Network";
            this.NHVR_Network.HeaderText = "NHVR_Network";
            this.NHVR_Network.Name = "NHVR_Network";
            this.NHVR_Network.ReadOnly = true;
            // 
            // bsDeliveryOrders
            // 
            this.bsDeliveryOrders.DataMember = "DeliveryOrdersAll";
            this.bsDeliveryOrders.DataSource = this.dsBookIn;
            // 
            // dsBookIn
            // 
            this.dsBookIn.DataSetName = "dsBookIn";
            this.dsBookIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.textBox5);
            this.tpDetails.Controls.Add(orderStatusLabel);
            this.tpDetails.Controls.Add(this.orderStatusTextBox);
            this.tpDetails.Controls.Add(this.textBox3);
            this.tpDetails.Controls.Add(this.textBox2);
            this.tpDetails.Controls.Add(this.textBox1);
            this.tpDetails.Controls.Add(sAPUpdateDTTMLabel);
            this.tpDetails.Controls.Add(distanceLabel);
            this.tpDetails.Controls.Add(this.distanceTextBox);
            this.tpDetails.Controls.Add(mapRefLabel);
            this.tpDetails.Controls.Add(this.mapRefTextBox);
            this.tpDetails.Controls.Add(deliveryAddressLabel);
            this.tpDetails.Controls.Add(this.deliveryAddressTextBox);
            this.tpDetails.Controls.Add(sAPCommentsLabel);
            this.tpDetails.Controls.Add(this.sAPCommentsTextBox);
            this.tpDetails.Controls.Add(itemQALabel);
            this.tpDetails.Controls.Add(this.itemQATextBox);
            this.tpDetails.Controls.Add(cartageLabel);
            this.tpDetails.Controls.Add(this.cartageTextBox);
            this.tpDetails.Controls.Add(cartageCodeLabel);
            this.tpDetails.Controls.Add(this.cartageCodeTextBox);
            this.tpDetails.Controls.Add(suppliedLabel);
            this.tpDetails.Controls.Add(this.suppliedTextBox);
            this.tpDetails.Controls.Add(openQtyLabel);
            this.tpDetails.Controls.Add(this.openQtyTextBox);
            this.tpDetails.Controls.Add(quantityLabel);
            this.tpDetails.Controls.Add(this.quantityTextBox);
            this.tpDetails.Controls.Add(materialLabel);
            this.tpDetails.Controls.Add(this.materialTextBox);
            this.tpDetails.Controls.Add(materialCodeLabel);
            this.tpDetails.Controls.Add(this.materialCodeTextBox);
            this.tpDetails.Controls.Add(deliveryDateLabel);
            this.tpDetails.Controls.Add(docDateLabel);
            this.tpDetails.Controls.Add(docNumLabel);
            this.tpDetails.Controls.Add(this.docNumTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 25);
            this.tpDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(4);
            this.tpDetails.Size = new System.Drawing.Size(1353, 316);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "ItmsGrpCod", true));
            this.textBox5.Location = new System.Drawing.Point(243, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 23);
            this.textBox5.TabIndex = 35;
            // 
            // orderStatusTextBox
            // 
            this.orderStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "OrderStatus", true));
            this.orderStatusTextBox.Location = new System.Drawing.Point(370, 25);
            this.orderStatusTextBox.Name = "orderStatusTextBox";
            this.orderStatusTextBox.Size = new System.Drawing.Size(100, 23);
            this.orderStatusTextBox.TabIndex = 34;
            // 
            // exBinOrdersBindingSource
            // 
            this.exBinOrdersBindingSource.DataMember = "ExBinOrders";
            this.exBinOrdersBindingSource.DataSource = this.dsBookIn;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "SAPUpdateDTTM", true));
            this.textBox3.Location = new System.Drawing.Point(616, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "DeliveryDate", true));
            this.textBox2.Location = new System.Drawing.Point(135, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "DocDate", true));
            this.textBox1.Location = new System.Drawing.Point(370, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 31;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Distance", true));
            this.distanceTextBox.Location = new System.Drawing.Point(615, 25);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 23);
            this.distanceTextBox.TabIndex = 29;
            // 
            // mapRefTextBox
            // 
            this.mapRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "MapRef", true));
            this.mapRefTextBox.Location = new System.Drawing.Point(792, 54);
            this.mapRefTextBox.Name = "mapRefTextBox";
            this.mapRefTextBox.Size = new System.Drawing.Size(100, 23);
            this.mapRefTextBox.TabIndex = 27;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(615, 112);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(688, 23);
            this.deliveryAddressTextBox.TabIndex = 25;
            // 
            // sAPCommentsTextBox
            // 
            this.sAPCommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "SAPComments", true));
            this.sAPCommentsTextBox.Location = new System.Drawing.Point(615, 141);
            this.sAPCommentsTextBox.Name = "sAPCommentsTextBox";
            this.sAPCommentsTextBox.Size = new System.Drawing.Size(688, 23);
            this.sAPCommentsTextBox.TabIndex = 23;
            // 
            // itemQATextBox
            // 
            this.itemQATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "ItemQA", true));
            this.itemQATextBox.Location = new System.Drawing.Point(370, 113);
            this.itemQATextBox.Name = "itemQATextBox";
            this.itemQATextBox.Size = new System.Drawing.Size(100, 23);
            this.itemQATextBox.TabIndex = 21;
            // 
            // cartageTextBox
            // 
            this.cartageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Cartage", true));
            this.cartageTextBox.Location = new System.Drawing.Point(615, 83);
            this.cartageTextBox.Name = "cartageTextBox";
            this.cartageTextBox.Size = new System.Drawing.Size(277, 23);
            this.cartageTextBox.TabIndex = 19;
            // 
            // cartageCodeTextBox
            // 
            this.cartageCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "CartageCode", true));
            this.cartageCodeTextBox.Location = new System.Drawing.Point(615, 54);
            this.cartageCodeTextBox.Name = "cartageCodeTextBox";
            this.cartageCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cartageCodeTextBox.TabIndex = 17;
            // 
            // suppliedTextBox
            // 
            this.suppliedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Supplied", true));
            this.suppliedTextBox.Location = new System.Drawing.Point(135, 200);
            this.suppliedTextBox.Name = "suppliedTextBox";
            this.suppliedTextBox.Size = new System.Drawing.Size(100, 23);
            this.suppliedTextBox.TabIndex = 15;
            // 
            // openQtyTextBox
            // 
            this.openQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "OpenQty", true));
            this.openQtyTextBox.Location = new System.Drawing.Point(135, 229);
            this.openQtyTextBox.Name = "openQtyTextBox";
            this.openQtyTextBox.Size = new System.Drawing.Size(100, 23);
            this.openQtyTextBox.TabIndex = 13;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(135, 171);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 11;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(135, 142);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(335, 23);
            this.materialTextBox.TabIndex = 9;
            // 
            // materialCodeTextBox
            // 
            this.materialCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "MaterialCode", true));
            this.materialCodeTextBox.Location = new System.Drawing.Point(137, 113);
            this.materialCodeTextBox.Name = "materialCodeTextBox";
            this.materialCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.materialCodeTextBox.TabIndex = 7;
            // 
            // docNumTextBox
            // 
            this.docNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "DocNum", true));
            this.docNumTextBox.Location = new System.Drawing.Point(137, 25);
            this.docNumTextBox.Name = "docNumTextBox";
            this.docNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.docNumTextBox.TabIndex = 1;
            // 
            // tpTruckConfig
            // 
            this.tpTruckConfig.Controls.Add(this.dataGridView3);
            this.tpTruckConfig.Location = new System.Drawing.Point(4, 25);
            this.tpTruckConfig.Name = "tpTruckConfig";
            this.tpTruckConfig.Size = new System.Drawing.Size(1353, 316);
            this.tpTruckConfig.TabIndex = 3;
            this.tpTruckConfig.Text = "Truck Config";
            this.tpTruckConfig.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoTkDataGridViewTextBoxColumn,
            this.gCMDataGridViewTextBoxColumn,
            this.maxGVMDataGridViewTextBoxColumn,
            this.configSourceDataGridViewTextBoxColumn,
            this.roadAccessDataGridViewTextBoxColumn,
            this.pBSLevelDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.schemeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bsConfiguredTruckGVM;
            this.dataGridView3.Location = new System.Drawing.Point(21, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(864, 129);
            this.dataGridView3.TabIndex = 70;
            // 
            // regoTkDataGridViewTextBoxColumn
            // 
            this.regoTkDataGridViewTextBoxColumn.DataPropertyName = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.HeaderText = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.Name = "regoTkDataGridViewTextBoxColumn";
            this.regoTkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
            this.gCMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxGVMDataGridViewTextBoxColumn
            // 
            this.maxGVMDataGridViewTextBoxColumn.DataPropertyName = "MaxGVM";
            this.maxGVMDataGridViewTextBoxColumn.HeaderText = "MaxGVM";
            this.maxGVMDataGridViewTextBoxColumn.Name = "maxGVMDataGridViewTextBoxColumn";
            this.maxGVMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // configSourceDataGridViewTextBoxColumn
            // 
            this.configSourceDataGridViewTextBoxColumn.DataPropertyName = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.HeaderText = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.Name = "configSourceDataGridViewTextBoxColumn";
            this.configSourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roadAccessDataGridViewTextBoxColumn
            // 
            this.roadAccessDataGridViewTextBoxColumn.DataPropertyName = "RoadAccess";
            this.roadAccessDataGridViewTextBoxColumn.HeaderText = "RoadAccess";
            this.roadAccessDataGridViewTextBoxColumn.Name = "roadAccessDataGridViewTextBoxColumn";
            this.roadAccessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pBSLevelDataGridViewTextBoxColumn
            // 
            this.pBSLevelDataGridViewTextBoxColumn.DataPropertyName = "PBS_Level";
            this.pBSLevelDataGridViewTextBoxColumn.HeaderText = "PBS_Level";
            this.pBSLevelDataGridViewTextBoxColumn.Name = "pBSLevelDataGridViewTextBoxColumn";
            this.pBSLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            this.schemeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemeDataGridViewTextBoxColumn
            // 
            this.schemeDataGridViewTextBoxColumn.DataPropertyName = "Scheme";
            this.schemeDataGridViewTextBoxColumn.HeaderText = "Scheme";
            this.schemeDataGridViewTextBoxColumn.Name = "schemeDataGridViewTextBoxColumn";
            this.schemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTIQ2
            // 
            this.bsTIQ2.DataMember = "TIQ";
            this.bsTIQ2.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taDeliveryOrders
            // 
            this.taDeliveryOrders.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsBookInTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exBinOrdersTableAdapter
            // 
            this.exBinOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // taConfiguredTruckGVM
            // 
            this.taConfiguredTruckGVM.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taDriver
            // 
            this.taDriver.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.NHVLTableAdapter = null;
            this.tableAdapterManager2.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager2.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager2.PBSTableAdapter = null;
            this.tableAdapterManager2.SchemeCodesTableAdapter = null;
            this.tableAdapterManager2.TruckConfigTableAdapter = null;
            this.tableAdapterManager2.TruckConfigVehicleTableAdapter = null;
            this.tableAdapterManager2.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.VehiclePBSTableAdapter = null;
            this.tableAdapterManager2.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager2.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager2.VehicleTableAdapter = null;
            this.tableAdapterManager2.VehicleTypeTableAdapter = null;
            // 
            // taTIQ2
            // 
            this.taTIQ2.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.TIQTableAdapter = this.taTIQ2;
            this.tableAdapterManager3.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nudPayloadTk
            // 
            this.nudPayloadTk.DecimalPlaces = 2;
            this.nudPayloadTk.Enabled = false;
            this.nudPayloadTk.Location = new System.Drawing.Point(748, 218);
            this.nudPayloadTk.Name = "nudPayloadTk";
            this.nudPayloadTk.Size = new System.Drawing.Size(76, 23);
            this.nudPayloadTk.TabIndex = 68;
            this.nudPayloadTk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPayloadTr
            // 
            this.nudPayloadTr.DecimalPlaces = 2;
            this.nudPayloadTr.Enabled = false;
            this.nudPayloadTr.Location = new System.Drawing.Point(749, 244);
            this.nudPayloadTr.Name = "nudPayloadTr";
            this.nudPayloadTr.Size = new System.Drawing.Size(76, 23);
            this.nudPayloadTr.TabIndex = 67;
            this.nudPayloadTr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPayload
            // 
            this.nudPayload.DecimalPlaces = 2;
            this.nudPayload.Location = new System.Drawing.Point(749, 191);
            this.nudPayload.Name = "nudPayload";
            this.nudPayload.Size = new System.Drawing.Size(76, 23);
            this.nudPayload.TabIndex = 66;
            this.nudPayload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPayload.ValueChanged += new System.EventHandler(this.nudPayload_ValueChanged);
            // 
            // gCMTextBox
            // 
            this.gCMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTruckGVM, "GCM", true));
            this.gCMTextBox.Location = new System.Drawing.Point(575, 191);
            this.gCMTextBox.Name = "gCMTextBox";
            this.gCMTextBox.Size = new System.Drawing.Size(72, 23);
            this.gCMTextBox.TabIndex = 33;
            this.gCMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gCMLabel
            // 
            gCMLabel.AutoSize = true;
            gCMLabel.Location = new System.Drawing.Point(522, 194);
            gCMLabel.Name = "gCMLabel";
            gCMLabel.Size = new System.Drawing.Size(43, 17);
            gCMLabel.TabIndex = 32;
            gCMLabel.Text = "GCM:";
            // 
            // gVMTruckTextBox
            // 
            this.gVMTruckTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTruckGVM, "GVMTruck", true));
            this.gVMTruckTextBox.Location = new System.Drawing.Point(575, 217);
            this.gVMTruckTextBox.Name = "gVMTruckTextBox";
            this.gVMTruckTextBox.Size = new System.Drawing.Size(72, 23);
            this.gVMTruckTextBox.TabIndex = 34;
            this.gVMTruckTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gVMTruckLabel
            // 
            gVMTruckLabel.AutoSize = true;
            gVMTruckLabel.Location = new System.Drawing.Point(486, 220);
            gVMTruckLabel.Name = "gVMTruckLabel";
            gVMTruckLabel.Size = new System.Drawing.Size(79, 17);
            gVMTruckLabel.TabIndex = 33;
            gVMTruckLabel.Text = "GVMTruck:";
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTruckGVM, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(670, 191);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(72, 23);
            this.tareTextBox.TabIndex = 36;
            this.tareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(686, 168);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 17);
            tareLabel.TabIndex = 35;
            tareLabel.Text = "Tare:";
            // 
            // tareTkTextBox
            // 
            this.tareTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTruckGVM, "TareTk", true));
            this.tareTkTextBox.Location = new System.Drawing.Point(670, 217);
            this.tareTkTextBox.Name = "tareTkTextBox";
            this.tareTkTextBox.Size = new System.Drawing.Size(72, 23);
            this.tareTkTextBox.TabIndex = 38;
            this.tareTkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(1126, 40);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(57, 23);
            this.cardCodeTextBox.TabIndex = 89;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(793, 46);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(72, 17);
            customerLabel.TabIndex = 89;
            customerLabel.Text = "Customer:";
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Customer", true));
            this.customerTextBox.Location = new System.Drawing.Point(871, 41);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(249, 23);
            this.customerTextBox.TabIndex = 90;
            // 
            // materialCodeTextBox1
            // 
            this.materialCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "MaterialCode", true));
            this.materialCodeTextBox1.Location = new System.Drawing.Point(871, 70);
            this.materialCodeTextBox1.Name = "materialCodeTextBox1";
            this.materialCodeTextBox1.Size = new System.Drawing.Size(66, 23);
            this.materialCodeTextBox1.TabIndex = 91;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Location = new System.Drawing.Point(803, 73);
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(62, 17);
            materialLabel1.TabIndex = 91;
            materialLabel1.Text = "Material:";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Material", true));
            this.materialTextBox1.Location = new System.Drawing.Point(943, 70);
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(240, 23);
            this.materialTextBox1.TabIndex = 92;
            // 
            // openQtyLabel1
            // 
            openQtyLabel1.AutoSize = true;
            openQtyLabel1.Location = new System.Drawing.Point(792, 128);
            openQtyLabel1.Name = "openQtyLabel1";
            openQtyLabel1.Size = new System.Drawing.Size(73, 17);
            openQtyLabel1.TabIndex = 92;
            openQtyLabel1.Text = "Open Qty:";
            // 
            // openQtyTextBox1
            // 
            this.openQtyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "OpenQty", true));
            this.openQtyTextBox1.Location = new System.Drawing.Point(871, 125);
            this.openQtyTextBox1.Name = "openQtyTextBox1";
            this.openQtyTextBox1.Size = new System.Drawing.Size(100, 23);
            this.openQtyTextBox1.TabIndex = 93;
            // 
            // cartageCodeLabel1
            // 
            cartageCodeLabel1.AutoSize = true;
            cartageCodeLabel1.Location = new System.Drawing.Point(766, 99);
            cartageCodeLabel1.Name = "cartageCodeLabel1";
            cartageCodeLabel1.Size = new System.Drawing.Size(99, 17);
            cartageCodeLabel1.TabIndex = 93;
            cartageCodeLabel1.Text = "Cartage Code:";
            // 
            // cartageCodeTextBox1
            // 
            this.cartageCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "CartageCode", true));
            this.cartageCodeTextBox1.Location = new System.Drawing.Point(871, 96);
            this.cartageCodeTextBox1.Name = "cartageCodeTextBox1";
            this.cartageCodeTextBox1.Size = new System.Drawing.Size(100, 23);
            this.cartageCodeTextBox1.TabIndex = 94;
            // 
            // txtPayload
            // 
            this.txtPayload.Location = new System.Drawing.Point(871, 155);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(100, 23);
            this.txtPayload.TabIndex = 95;
            // 
            // txtPayloadTk
            // 
            this.txtPayloadTk.Location = new System.Drawing.Point(977, 155);
            this.txtPayloadTk.Name = "txtPayloadTk";
            this.txtPayloadTk.Size = new System.Drawing.Size(100, 23);
            this.txtPayloadTk.TabIndex = 96;
            // 
            // txtPayloadTr
            // 
            this.txtPayloadTr.Location = new System.Drawing.Point(1083, 155);
            this.txtPayloadTr.Name = "txtPayloadTr";
            this.txtPayloadTr.Size = new System.Drawing.Size(100, 23);
            this.txtPayloadTr.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(792, 158);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 17);
            label1.TabIndex = 98;
            label1.Text = "Payload :";
            // 
            // BookInDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 631);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookInDelivery";
            this.Text = "BookInDelivery";
            this.Load += new System.EventHandler(this.BookInDelivery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).EndInit();
            this.tpTruckConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource bsDeliveryOrders;
        private dsBookInTableAdapters.DeliveryOrdersAllTableAdapter taDeliveryOrders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox mapRefTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox sAPCommentsTextBox;
        private System.Windows.Forms.TextBox itemQATextBox;
        private System.Windows.Forms.TextBox cartageTextBox;
        private System.Windows.Forms.TextBox cartageCodeTextBox;
        private System.Windows.Forms.TextBox suppliedTextBox;
        private System.Windows.Forms.TextBox openQtyTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox materialCodeTextBox;
        private System.Windows.Forms.TextBox docNumTextBox;
        private dsBookInTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource exBinOrdersBindingSource;
        private dsBookInTableAdapters.ExBinOrdersTableAdapter exBinOrdersTableAdapter;
        private System.Windows.Forms.TextBox orderStatusTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHVR_Network;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource bsConfiguredTruckGVM;
        private dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter taConfiguredTruckGVM;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox regoTkTextBox;
        private System.Windows.Forms.Button btnLoad;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsDriver;
        private dsQWSLocalTableAdapters.TruckDriverTableAdapter taDriver;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.TabPage tpTruckConfig;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxGVMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadAccessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBookIn;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsTIQ2;
        private dsTIQ2TableAdapters.TIQTableAdapter taTIQ2;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown nudPayloadTk;
        private System.Windows.Forms.NumericUpDown nudPayloadTr;
        private System.Windows.Forms.NumericUpDown nudPayload;
        private System.Windows.Forms.TextBox gCMTextBox;
        private System.Windows.Forms.TextBox gVMTruckTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.TextBox tareTkTextBox;
        private System.Windows.Forms.TextBox cartageCodeTextBox1;
        private System.Windows.Forms.TextBox openQtyTextBox1;
        private System.Windows.Forms.TextBox materialTextBox1;
        private System.Windows.Forms.TextBox materialCodeTextBox1;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox txtPayloadTr;
        private System.Windows.Forms.TextBox txtPayloadTk;
        private System.Windows.Forms.TextBox txtPayload;
    }
}