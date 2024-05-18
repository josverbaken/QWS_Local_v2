
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
            System.Windows.Forms.Label tIQIDLabel;
            System.Windows.Forms.Label siteIDLabel;
            System.Windows.Forms.Label regoLabel;
            System.Windows.Forms.Label truckConfigLabel;
            System.Windows.Forms.Label roadAccessLabel;
            System.Windows.Forms.Label feeCodeLabel;
            System.Windows.Forms.Label queueStatusLabel;
            System.Windows.Forms.Label entryDTTMLabel;
            System.Windows.Forms.Label allocateDTTMLabel;
            System.Windows.Forms.Label sAPOrderLabel;
            System.Windows.Forms.Label deliveryAddressLabel1;
            System.Windows.Forms.Label custONLabel;
            System.Windows.Forms.Label materialLabel2;
            System.Windows.Forms.Label materialDescLabel;
            System.Windows.Forms.Label cartageCodeLabel2;
            System.Windows.Forms.Label stockpileLotNoLabel;
            System.Windows.Forms.Label driverLabel;
            System.Windows.Forms.Label truckOwnerLabel;
            System.Windows.Forms.Label payloadLabel;
            System.Windows.Forms.Label payloadSplitLabel;
            System.Windows.Forms.Label gCMLabel1;
            System.Windows.Forms.Label gVMTruckLabel1;
            System.Windows.Forms.Label grossLabel;
            System.Windows.Forms.Label tareLabel1;
            System.Windows.Forms.Label tareTkLabel;
            System.Windows.Forms.Label nettLabel;
            System.Windows.Forms.Label regoTrailersLabel;
            System.Windows.Forms.Label customerLabel1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.nudPayloadTk = new System.Windows.Forms.NumericUpDown();
            this.nudPayloadTr = new System.Windows.Forms.NumericUpDown();
            this.txtPayloadTr = new System.Windows.Forms.TextBox();
            this.nudPayload = new System.Windows.Forms.NumericUpDown();
            this.gCMTextBox = new System.Windows.Forms.TextBox();
            this.bsConfiguredTruckGVM = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.txtPayloadTk = new System.Windows.Forms.TextBox();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox = new System.Windows.Forms.TextBox();
            this.cartageCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.bsDeliveryOrders = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.openQtyTextBox1 = new System.Windows.Forms.TextBox();
            this.tareTkTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox1 = new System.Windows.Forms.TextBox();
            this.materialCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.btnBookIn = new System.Windows.Forms.Button();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.bsDriver = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.personTextBox = new System.Windows.Forms.TextBox();
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
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.orderStatusTextBox = new System.Windows.Forms.TextBox();
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
            this.tpTIQ = new System.Windows.Forms.TabPage();
            this.regoTrailersTextBox = new System.Windows.Forms.TextBox();
            this.nettTextBox = new System.Windows.Forms.TextBox();
            this.tareTkTextBox1 = new System.Windows.Forms.TextBox();
            this.tareTextBox1 = new System.Windows.Forms.TextBox();
            this.grossTextBox = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox1 = new System.Windows.Forms.TextBox();
            this.gCMTextBox1 = new System.Windows.Forms.TextBox();
            this.payloadSplitTextBox = new System.Windows.Forms.TextBox();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.stockpileLotNoTextBox = new System.Windows.Forms.TextBox();
            this.cartageCodeTextBox2 = new System.Windows.Forms.TextBox();
            this.materialDescTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox2 = new System.Windows.Forms.TextBox();
            this.custONTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox1 = new System.Windows.Forms.TextBox();
            this.sAPOrderTextBox = new System.Windows.Forms.TextBox();
            this.allocateDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.entryDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.queueStatusTextBox = new System.Windows.Forms.TextBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.roadAccessTextBox = new System.Windows.Forms.TextBox();
            this.truckConfigTextBox = new System.Windows.Forms.TextBox();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.siteIDTextBox = new System.Windows.Forms.TextBox();
            this.tIQIDTextBox = new System.Windows.Forms.TextBox();
            this.exBinOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taDeliveryOrders = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.exBinOrdersTableAdapter = new QWS_Local.dsBookInTableAdapters.ExBinOrdersTableAdapter();
            this.taConfiguredTruckGVM = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.taDriver = new QWS_Local.dsQWSLocalTableAdapters.TruckDriverTableAdapter();
            this.tableAdapterManager2 = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.bsTIQ2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.taTIQ2 = new QWS_Local.dsTIQ2TableAdapters.TIQTableAdapter();
            this.tableAdapterManager3 = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.customerCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox1 = new System.Windows.Forms.TextBox();
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
            tIQIDLabel = new System.Windows.Forms.Label();
            siteIDLabel = new System.Windows.Forms.Label();
            regoLabel = new System.Windows.Forms.Label();
            truckConfigLabel = new System.Windows.Forms.Label();
            roadAccessLabel = new System.Windows.Forms.Label();
            feeCodeLabel = new System.Windows.Forms.Label();
            queueStatusLabel = new System.Windows.Forms.Label();
            entryDTTMLabel = new System.Windows.Forms.Label();
            allocateDTTMLabel = new System.Windows.Forms.Label();
            sAPOrderLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel1 = new System.Windows.Forms.Label();
            custONLabel = new System.Windows.Forms.Label();
            materialLabel2 = new System.Windows.Forms.Label();
            materialDescLabel = new System.Windows.Forms.Label();
            cartageCodeLabel2 = new System.Windows.Forms.Label();
            stockpileLotNoLabel = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            payloadLabel = new System.Windows.Forms.Label();
            payloadSplitLabel = new System.Windows.Forms.Label();
            gCMLabel1 = new System.Windows.Forms.Label();
            gVMTruckLabel1 = new System.Windows.Forms.Label();
            grossLabel = new System.Windows.Forms.Label();
            tareLabel1 = new System.Windows.Forms.Label();
            tareTkLabel = new System.Windows.Forms.Label();
            nettLabel = new System.Windows.Forms.Label();
            regoTrailersLabel = new System.Windows.Forms.Label();
            customerLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.tpTruckConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpTIQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
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
            // gCMLabel
            // 
            gCMLabel.AutoSize = true;
            gCMLabel.Location = new System.Drawing.Point(522, 194);
            gCMLabel.Name = "gCMLabel";
            gCMLabel.Size = new System.Drawing.Size(43, 17);
            gCMLabel.TabIndex = 32;
            gCMLabel.Text = "GCM:";
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
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(686, 168);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 17);
            tareLabel.TabIndex = 35;
            tareLabel.Text = "Tare:";
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Location = new System.Drawing.Point(803, 73);
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(62, 17);
            materialLabel1.TabIndex = 91;
            materialLabel1.Text = "Material:";
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
            // cartageCodeLabel1
            // 
            cartageCodeLabel1.AutoSize = true;
            cartageCodeLabel1.Location = new System.Drawing.Point(766, 99);
            cartageCodeLabel1.Name = "cartageCodeLabel1";
            cartageCodeLabel1.Size = new System.Drawing.Size(99, 17);
            cartageCodeLabel1.TabIndex = 93;
            cartageCodeLabel1.Text = "Cartage Code:";
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
            // tIQIDLabel
            // 
            tIQIDLabel.AutoSize = true;
            tIQIDLabel.Location = new System.Drawing.Point(46, 21);
            tIQIDLabel.Name = "tIQIDLabel";
            tIQIDLabel.Size = new System.Drawing.Size(48, 17);
            tIQIDLabel.TabIndex = 0;
            tIQIDLabel.Text = "TIQID:";
            // 
            // siteIDLabel
            // 
            siteIDLabel.AutoSize = true;
            siteIDLabel.Location = new System.Drawing.Point(41, 50);
            siteIDLabel.Name = "siteIDLabel";
            siteIDLabel.Size = new System.Drawing.Size(53, 17);
            siteIDLabel.TabIndex = 2;
            siteIDLabel.Text = "Site ID:";
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(48, 79);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(46, 17);
            regoLabel.TabIndex = 4;
            regoLabel.Text = "Rego:";
            // 
            // truckConfigLabel
            // 
            truckConfigLabel.AutoSize = true;
            truckConfigLabel.Location = new System.Drawing.Point(440, 108);
            truckConfigLabel.Name = "truckConfigLabel";
            truckConfigLabel.Size = new System.Drawing.Size(92, 17);
            truckConfigLabel.TabIndex = 6;
            truckConfigLabel.Text = "Truck Config:";
            // 
            // roadAccessLabel
            // 
            roadAccessLabel.AutoSize = true;
            roadAccessLabel.Location = new System.Drawing.Point(221, 108);
            roadAccessLabel.Name = "roadAccessLabel";
            roadAccessLabel.Size = new System.Drawing.Size(95, 17);
            roadAccessLabel.TabIndex = 8;
            roadAccessLabel.Text = "Road Access:";
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(21, 111);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(73, 17);
            feeCodeLabel.TabIndex = 10;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // queueStatusLabel
            // 
            queueStatusLabel.AutoSize = true;
            queueStatusLabel.Location = new System.Drawing.Point(217, 21);
            queueStatusLabel.Name = "queueStatusLabel";
            queueStatusLabel.Size = new System.Drawing.Size(99, 17);
            queueStatusLabel.TabIndex = 12;
            queueStatusLabel.Text = "Queue Status:";
            // 
            // entryDTTMLabel
            // 
            entryDTTMLabel.AutoSize = true;
            entryDTTMLabel.Location = new System.Drawing.Point(444, 22);
            entryDTTMLabel.Name = "entryDTTMLabel";
            entryDTTMLabel.Size = new System.Drawing.Size(88, 17);
            entryDTTMLabel.TabIndex = 14;
            entryDTTMLabel.Text = "Entry DTTM:";
            // 
            // allocateDTTMLabel
            // 
            allocateDTTMLabel.AutoSize = true;
            allocateDTTMLabel.Location = new System.Drawing.Point(427, 51);
            allocateDTTMLabel.Name = "allocateDTTMLabel";
            allocateDTTMLabel.Size = new System.Drawing.Size(105, 17);
            allocateDTTMLabel.TabIndex = 16;
            allocateDTTMLabel.Text = "Allocate DTTM:";
            // 
            // sAPOrderLabel
            // 
            sAPOrderLabel.AutoSize = true;
            sAPOrderLabel.Location = new System.Drawing.Point(785, 51);
            sAPOrderLabel.Name = "sAPOrderLabel";
            sAPOrderLabel.Size = new System.Drawing.Size(76, 17);
            sAPOrderLabel.TabIndex = 18;
            sAPOrderLabel.Text = "SAPOrder:";
            // 
            // deliveryAddressLabel1
            // 
            deliveryAddressLabel1.AutoSize = true;
            deliveryAddressLabel1.Location = new System.Drawing.Point(742, 79);
            deliveryAddressLabel1.Name = "deliveryAddressLabel1";
            deliveryAddressLabel1.Size = new System.Drawing.Size(119, 17);
            deliveryAddressLabel1.TabIndex = 20;
            deliveryAddressLabel1.Text = "Delivery Address:";
            // 
            // custONLabel
            // 
            custONLabel.AutoSize = true;
            custONLabel.Location = new System.Drawing.Point(1018, 50);
            custONLabel.Name = "custONLabel";
            custONLabel.Size = new System.Drawing.Size(65, 17);
            custONLabel.TabIndex = 22;
            custONLabel.Text = "Cust ON:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Location = new System.Drawing.Point(799, 108);
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(62, 17);
            materialLabel2.TabIndex = 24;
            materialLabel2.Text = "Material:";
            // 
            // materialDescLabel
            // 
            materialDescLabel.AutoSize = true;
            materialDescLabel.Location = new System.Drawing.Point(763, 137);
            materialDescLabel.Name = "materialDescLabel";
            materialDescLabel.Size = new System.Drawing.Size(98, 17);
            materialDescLabel.TabIndex = 26;
            materialDescLabel.Text = "Material Desc:";
            // 
            // cartageCodeLabel2
            // 
            cartageCodeLabel2.AutoSize = true;
            cartageCodeLabel2.Location = new System.Drawing.Point(984, 108);
            cartageCodeLabel2.Name = "cartageCodeLabel2";
            cartageCodeLabel2.Size = new System.Drawing.Size(99, 17);
            cartageCodeLabel2.TabIndex = 28;
            cartageCodeLabel2.Text = "Cartage Code:";
            // 
            // stockpileLotNoLabel
            // 
            stockpileLotNoLabel.AutoSize = true;
            stockpileLotNoLabel.Location = new System.Drawing.Point(746, 166);
            stockpileLotNoLabel.Name = "stockpileLotNoLabel";
            stockpileLotNoLabel.Size = new System.Drawing.Size(115, 17);
            stockpileLotNoLabel.TabIndex = 30;
            stockpileLotNoLabel.Text = "Stockpile Lot No:";
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(44, 140);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(50, 17);
            driverLabel.TabIndex = 32;
            driverLabel.Text = "Driver:";
            // 
            // truckOwnerLabel
            // 
            truckOwnerLabel.AutoSize = true;
            truckOwnerLabel.Location = new System.Drawing.Point(1, 169);
            truckOwnerLabel.Name = "truckOwnerLabel";
            truckOwnerLabel.Size = new System.Drawing.Size(93, 17);
            truckOwnerLabel.TabIndex = 34;
            truckOwnerLabel.Text = "Truck Owner:";
            // 
            // payloadLabel
            // 
            payloadLabel.AutoSize = true;
            payloadLabel.Location = new System.Drawing.Point(31, 198);
            payloadLabel.Name = "payloadLabel";
            payloadLabel.Size = new System.Drawing.Size(63, 17);
            payloadLabel.TabIndex = 36;
            payloadLabel.Text = "Payload:";
            // 
            // payloadSplitLabel
            // 
            payloadSplitLabel.AutoSize = true;
            payloadSplitLabel.Location = new System.Drawing.Point(222, 198);
            payloadSplitLabel.Name = "payloadSplitLabel";
            payloadSplitLabel.Size = new System.Drawing.Size(94, 17);
            payloadSplitLabel.TabIndex = 38;
            payloadSplitLabel.Text = "Payload Split:";
            // 
            // gCMLabel1
            // 
            gCMLabel1.AutoSize = true;
            gCMLabel1.Location = new System.Drawing.Point(489, 137);
            gCMLabel1.Name = "gCMLabel1";
            gCMLabel1.Size = new System.Drawing.Size(43, 17);
            gCMLabel1.TabIndex = 40;
            gCMLabel1.Text = "GCM:";
            // 
            // gVMTruckLabel1
            // 
            gVMTruckLabel1.AutoSize = true;
            gVMTruckLabel1.Location = new System.Drawing.Point(453, 169);
            gVMTruckLabel1.Name = "gVMTruckLabel1";
            gVMTruckLabel1.Size = new System.Drawing.Size(79, 17);
            gVMTruckLabel1.TabIndex = 42;
            gVMTruckLabel1.Text = "GVMTruck:";
            // 
            // grossLabel
            // 
            grossLabel.AutoSize = true;
            grossLabel.Location = new System.Drawing.Point(482, 198);
            grossLabel.Name = "grossLabel";
            grossLabel.Size = new System.Drawing.Size(50, 17);
            grossLabel.TabIndex = 44;
            grossLabel.Text = "Gross:";
            // 
            // tareLabel1
            // 
            tareLabel1.AutoSize = true;
            tareLabel1.Location = new System.Drawing.Point(490, 227);
            tareLabel1.Name = "tareLabel1";
            tareLabel1.Size = new System.Drawing.Size(42, 17);
            tareLabel1.TabIndex = 46;
            tareLabel1.Text = "Tare:";
            // 
            // tareTkLabel
            // 
            tareTkLabel.AutoSize = true;
            tareTkLabel.Location = new System.Drawing.Point(652, 227);
            tareTkLabel.Name = "tareTkLabel";
            tareTkLabel.Size = new System.Drawing.Size(62, 17);
            tareTkLabel.TabIndex = 48;
            tareTkLabel.Text = "Tare Tk:";
            // 
            // nettLabel
            // 
            nettLabel.AutoSize = true;
            nettLabel.Location = new System.Drawing.Point(494, 256);
            nettLabel.Name = "nettLabel";
            nettLabel.Size = new System.Drawing.Size(38, 17);
            nettLabel.TabIndex = 50;
            nettLabel.Text = "Nett:";
            // 
            // regoTrailersLabel
            // 
            regoTrailersLabel.AutoSize = true;
            regoTrailersLabel.Location = new System.Drawing.Point(218, 82);
            regoTrailersLabel.Name = "regoTrailersLabel";
            regoTrailersLabel.Size = new System.Drawing.Size(98, 17);
            regoTrailersLabel.TabIndex = 52;
            regoTrailersLabel.Text = "Rego Trailers:";
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 28);
            this.button1.TabIndex = 99;
            this.button1.Text = "Refresh Orders";
            this.button1.UseVisualStyleBackColor = true;
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
            // txtPayloadTr
            // 
            this.txtPayloadTr.Location = new System.Drawing.Point(1083, 155);
            this.txtPayloadTr.Name = "txtPayloadTr";
            this.txtPayloadTr.Size = new System.Drawing.Size(100, 23);
            this.txtPayloadTr.TabIndex = 97;
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
            // txtPayloadTk
            // 
            this.txtPayloadTk.Location = new System.Drawing.Point(977, 155);
            this.txtPayloadTk.Name = "txtPayloadTk";
            this.txtPayloadTk.Size = new System.Drawing.Size(100, 23);
            this.txtPayloadTk.TabIndex = 96;
            // 
            // txtPayload
            // 
            this.txtPayload.Location = new System.Drawing.Point(871, 155);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(100, 23);
            this.txtPayload.TabIndex = 95;
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
            // cartageCodeTextBox1
            // 
            this.cartageCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "CartageCode", true));
            this.cartageCodeTextBox1.Location = new System.Drawing.Point(871, 96);
            this.cartageCodeTextBox1.Name = "cartageCodeTextBox1";
            this.cartageCodeTextBox1.Size = new System.Drawing.Size(100, 23);
            this.cartageCodeTextBox1.TabIndex = 94;
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
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTruckGVM, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(670, 191);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(72, 23);
            this.tareTextBox.TabIndex = 36;
            this.tareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openQtyTextBox1
            // 
            this.openQtyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "OpenQty", true));
            this.openQtyTextBox1.Location = new System.Drawing.Point(871, 125);
            this.openQtyTextBox1.Name = "openQtyTextBox1";
            this.openQtyTextBox1.Size = new System.Drawing.Size(100, 23);
            this.openQtyTextBox1.TabIndex = 93;
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
            // materialTextBox1
            // 
            this.materialTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Material", true));
            this.materialTextBox1.Location = new System.Drawing.Point(943, 70);
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(240, 23);
            this.materialTextBox1.TabIndex = 92;
            // 
            // materialCodeTextBox1
            // 
            this.materialCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "MaterialCode", true));
            this.materialCodeTextBox1.Location = new System.Drawing.Point(871, 70);
            this.materialCodeTextBox1.Name = "materialCodeTextBox1";
            this.materialCodeTextBox1.Size = new System.Drawing.Size(66, 23);
            this.materialCodeTextBox1.TabIndex = 91;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "Customer", true));
            this.customerTextBox.Location = new System.Drawing.Point(871, 41);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(249, 23);
            this.customerTextBox.TabIndex = 90;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(1126, 40);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(57, 23);
            this.cardCodeTextBox.TabIndex = 89;
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
            this.tabControl1.Controls.Add(this.tpTIQ);
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
            // tpTIQ
            // 
            this.tpTIQ.Controls.Add(customerLabel1);
            this.tpTIQ.Controls.Add(this.customerTextBox1);
            this.tpTIQ.Controls.Add(this.customerCodeTextBox);
            this.tpTIQ.Controls.Add(regoTrailersLabel);
            this.tpTIQ.Controls.Add(this.regoTrailersTextBox);
            this.tpTIQ.Controls.Add(nettLabel);
            this.tpTIQ.Controls.Add(this.nettTextBox);
            this.tpTIQ.Controls.Add(tareTkLabel);
            this.tpTIQ.Controls.Add(this.tareTkTextBox1);
            this.tpTIQ.Controls.Add(tareLabel1);
            this.tpTIQ.Controls.Add(this.tareTextBox1);
            this.tpTIQ.Controls.Add(grossLabel);
            this.tpTIQ.Controls.Add(this.grossTextBox);
            this.tpTIQ.Controls.Add(gVMTruckLabel1);
            this.tpTIQ.Controls.Add(this.gVMTruckTextBox1);
            this.tpTIQ.Controls.Add(gCMLabel1);
            this.tpTIQ.Controls.Add(this.gCMTextBox1);
            this.tpTIQ.Controls.Add(payloadSplitLabel);
            this.tpTIQ.Controls.Add(this.payloadSplitTextBox);
            this.tpTIQ.Controls.Add(payloadLabel);
            this.tpTIQ.Controls.Add(this.payloadTextBox);
            this.tpTIQ.Controls.Add(truckOwnerLabel);
            this.tpTIQ.Controls.Add(this.truckOwnerTextBox);
            this.tpTIQ.Controls.Add(driverLabel);
            this.tpTIQ.Controls.Add(this.driverTextBox);
            this.tpTIQ.Controls.Add(stockpileLotNoLabel);
            this.tpTIQ.Controls.Add(this.stockpileLotNoTextBox);
            this.tpTIQ.Controls.Add(cartageCodeLabel2);
            this.tpTIQ.Controls.Add(this.cartageCodeTextBox2);
            this.tpTIQ.Controls.Add(materialDescLabel);
            this.tpTIQ.Controls.Add(this.materialDescTextBox);
            this.tpTIQ.Controls.Add(materialLabel2);
            this.tpTIQ.Controls.Add(this.materialTextBox2);
            this.tpTIQ.Controls.Add(custONLabel);
            this.tpTIQ.Controls.Add(this.custONTextBox);
            this.tpTIQ.Controls.Add(deliveryAddressLabel1);
            this.tpTIQ.Controls.Add(this.deliveryAddressTextBox1);
            this.tpTIQ.Controls.Add(sAPOrderLabel);
            this.tpTIQ.Controls.Add(this.sAPOrderTextBox);
            this.tpTIQ.Controls.Add(allocateDTTMLabel);
            this.tpTIQ.Controls.Add(this.allocateDTTMDateTimePicker);
            this.tpTIQ.Controls.Add(entryDTTMLabel);
            this.tpTIQ.Controls.Add(this.entryDTTMDateTimePicker);
            this.tpTIQ.Controls.Add(queueStatusLabel);
            this.tpTIQ.Controls.Add(this.queueStatusTextBox);
            this.tpTIQ.Controls.Add(feeCodeLabel);
            this.tpTIQ.Controls.Add(this.feeCodeTextBox);
            this.tpTIQ.Controls.Add(roadAccessLabel);
            this.tpTIQ.Controls.Add(this.roadAccessTextBox);
            this.tpTIQ.Controls.Add(truckConfigLabel);
            this.tpTIQ.Controls.Add(this.truckConfigTextBox);
            this.tpTIQ.Controls.Add(regoLabel);
            this.tpTIQ.Controls.Add(this.regoTextBox);
            this.tpTIQ.Controls.Add(siteIDLabel);
            this.tpTIQ.Controls.Add(this.siteIDTextBox);
            this.tpTIQ.Controls.Add(tIQIDLabel);
            this.tpTIQ.Controls.Add(this.tIQIDTextBox);
            this.tpTIQ.Location = new System.Drawing.Point(4, 25);
            this.tpTIQ.Name = "tpTIQ";
            this.tpTIQ.Size = new System.Drawing.Size(1353, 316);
            this.tpTIQ.TabIndex = 4;
            this.tpTIQ.Text = "TIQ";
            this.tpTIQ.UseVisualStyleBackColor = true;
            // 
            // regoTrailersTextBox
            // 
            this.regoTrailersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "RegoTrailers", true));
            this.regoTrailersTextBox.Location = new System.Drawing.Point(322, 79);
            this.regoTrailersTextBox.Name = "regoTrailersTextBox";
            this.regoTrailersTextBox.Size = new System.Drawing.Size(209, 23);
            this.regoTrailersTextBox.TabIndex = 53;
            // 
            // nettTextBox
            // 
            this.nettTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Nett", true));
            this.nettTextBox.Location = new System.Drawing.Point(538, 253);
            this.nettTextBox.Name = "nettTextBox";
            this.nettTextBox.Size = new System.Drawing.Size(100, 23);
            this.nettTextBox.TabIndex = 51;
            // 
            // tareTkTextBox1
            // 
            this.tareTkTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TareTk", true));
            this.tareTkTextBox1.Location = new System.Drawing.Point(720, 224);
            this.tareTkTextBox1.Name = "tareTkTextBox1";
            this.tareTkTextBox1.Size = new System.Drawing.Size(100, 23);
            this.tareTkTextBox1.TabIndex = 49;
            // 
            // tareTextBox1
            // 
            this.tareTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Tare", true));
            this.tareTextBox1.Location = new System.Drawing.Point(538, 224);
            this.tareTextBox1.Name = "tareTextBox1";
            this.tareTextBox1.Size = new System.Drawing.Size(100, 23);
            this.tareTextBox1.TabIndex = 47;
            // 
            // grossTextBox
            // 
            this.grossTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Gross", true));
            this.grossTextBox.Location = new System.Drawing.Point(538, 195);
            this.grossTextBox.Name = "grossTextBox";
            this.grossTextBox.Size = new System.Drawing.Size(100, 23);
            this.grossTextBox.TabIndex = 45;
            // 
            // gVMTruckTextBox1
            // 
            this.gVMTruckTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "GVMTruck", true));
            this.gVMTruckTextBox1.Location = new System.Drawing.Point(538, 166);
            this.gVMTruckTextBox1.Name = "gVMTruckTextBox1";
            this.gVMTruckTextBox1.Size = new System.Drawing.Size(100, 23);
            this.gVMTruckTextBox1.TabIndex = 43;
            // 
            // gCMTextBox1
            // 
            this.gCMTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "GCM", true));
            this.gCMTextBox1.Location = new System.Drawing.Point(538, 134);
            this.gCMTextBox1.Name = "gCMTextBox1";
            this.gCMTextBox1.Size = new System.Drawing.Size(100, 23);
            this.gCMTextBox1.TabIndex = 41;
            // 
            // payloadSplitTextBox
            // 
            this.payloadSplitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "PayloadSplit", true));
            this.payloadSplitTextBox.Location = new System.Drawing.Point(322, 195);
            this.payloadSplitTextBox.Name = "payloadSplitTextBox";
            this.payloadSplitTextBox.Size = new System.Drawing.Size(100, 23);
            this.payloadSplitTextBox.TabIndex = 39;
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Payload", true));
            this.payloadTextBox.Location = new System.Drawing.Point(100, 195);
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.Size = new System.Drawing.Size(100, 23);
            this.payloadTextBox.TabIndex = 37;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(100, 166);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.Size = new System.Drawing.Size(322, 23);
            this.truckOwnerTextBox.TabIndex = 35;
            // 
            // driverTextBox
            // 
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(100, 137);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.Size = new System.Drawing.Size(322, 23);
            this.driverTextBox.TabIndex = 33;
            // 
            // stockpileLotNoTextBox
            // 
            this.stockpileLotNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "StockpileLotNo", true));
            this.stockpileLotNoTextBox.Location = new System.Drawing.Point(867, 163);
            this.stockpileLotNoTextBox.Name = "stockpileLotNoTextBox";
            this.stockpileLotNoTextBox.Size = new System.Drawing.Size(100, 23);
            this.stockpileLotNoTextBox.TabIndex = 31;
            // 
            // cartageCodeTextBox2
            // 
            this.cartageCodeTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "CartageCode", true));
            this.cartageCodeTextBox2.Location = new System.Drawing.Point(1089, 105);
            this.cartageCodeTextBox2.Name = "cartageCodeTextBox2";
            this.cartageCodeTextBox2.Size = new System.Drawing.Size(100, 23);
            this.cartageCodeTextBox2.TabIndex = 29;
            // 
            // materialDescTextBox
            // 
            this.materialDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "MaterialDesc", true));
            this.materialDescTextBox.Location = new System.Drawing.Point(867, 134);
            this.materialDescTextBox.Name = "materialDescTextBox";
            this.materialDescTextBox.Size = new System.Drawing.Size(322, 23);
            this.materialDescTextBox.TabIndex = 27;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Material", true));
            this.materialTextBox2.Location = new System.Drawing.Point(867, 105);
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(100, 23);
            this.materialTextBox2.TabIndex = 25;
            // 
            // custONTextBox
            // 
            this.custONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "CustON", true));
            this.custONTextBox.Location = new System.Drawing.Point(1089, 47);
            this.custONTextBox.Name = "custONTextBox";
            this.custONTextBox.Size = new System.Drawing.Size(100, 23);
            this.custONTextBox.TabIndex = 23;
            // 
            // deliveryAddressTextBox1
            // 
            this.deliveryAddressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "DeliveryAddress", true));
            this.deliveryAddressTextBox1.Location = new System.Drawing.Point(867, 76);
            this.deliveryAddressTextBox1.Name = "deliveryAddressTextBox1";
            this.deliveryAddressTextBox1.Size = new System.Drawing.Size(322, 23);
            this.deliveryAddressTextBox1.TabIndex = 21;
            // 
            // sAPOrderTextBox
            // 
            this.sAPOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "SAPOrder", true));
            this.sAPOrderTextBox.Location = new System.Drawing.Point(867, 48);
            this.sAPOrderTextBox.Name = "sAPOrderTextBox";
            this.sAPOrderTextBox.Size = new System.Drawing.Size(100, 23);
            this.sAPOrderTextBox.TabIndex = 19;
            // 
            // allocateDTTMDateTimePicker
            // 
            this.allocateDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTIQ2, "AllocateDTTM", true));
            this.allocateDTTMDateTimePicker.Location = new System.Drawing.Point(538, 47);
            this.allocateDTTMDateTimePicker.Name = "allocateDTTMDateTimePicker";
            this.allocateDTTMDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.allocateDTTMDateTimePicker.TabIndex = 17;
            // 
            // entryDTTMDateTimePicker
            // 
            this.entryDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTIQ2, "EntryDTTM", true));
            this.entryDTTMDateTimePicker.Location = new System.Drawing.Point(538, 18);
            this.entryDTTMDateTimePicker.Name = "entryDTTMDateTimePicker";
            this.entryDTTMDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.entryDTTMDateTimePicker.TabIndex = 15;
            // 
            // queueStatusTextBox
            // 
            this.queueStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "QueueStatus", true));
            this.queueStatusTextBox.Location = new System.Drawing.Point(322, 18);
            this.queueStatusTextBox.Name = "queueStatusTextBox";
            this.queueStatusTextBox.Size = new System.Drawing.Size(100, 23);
            this.queueStatusTextBox.TabIndex = 13;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(100, 108);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.feeCodeTextBox.TabIndex = 11;
            // 
            // roadAccessTextBox
            // 
            this.roadAccessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "RoadAccess", true));
            this.roadAccessTextBox.Location = new System.Drawing.Point(322, 105);
            this.roadAccessTextBox.Name = "roadAccessTextBox";
            this.roadAccessTextBox.Size = new System.Drawing.Size(100, 23);
            this.roadAccessTextBox.TabIndex = 9;
            // 
            // truckConfigTextBox
            // 
            this.truckConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TruckConfig", true));
            this.truckConfigTextBox.Location = new System.Drawing.Point(538, 105);
            this.truckConfigTextBox.Name = "truckConfigTextBox";
            this.truckConfigTextBox.Size = new System.Drawing.Size(100, 23);
            this.truckConfigTextBox.TabIndex = 7;
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(100, 76);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.Size = new System.Drawing.Size(100, 23);
            this.regoTextBox.TabIndex = 5;
            // 
            // siteIDTextBox
            // 
            this.siteIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "SiteID", true));
            this.siteIDTextBox.Location = new System.Drawing.Point(100, 47);
            this.siteIDTextBox.Name = "siteIDTextBox";
            this.siteIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.siteIDTextBox.TabIndex = 3;
            // 
            // tIQIDTextBox
            // 
            this.tIQIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TIQID", true));
            this.tIQIDTextBox.Location = new System.Drawing.Point(100, 18);
            this.tIQIDTextBox.Name = "tIQIDTextBox";
            this.tIQIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.tIQIDTextBox.TabIndex = 1;
            // 
            // exBinOrdersBindingSource
            // 
            this.exBinOrdersBindingSource.DataMember = "ExBinOrders";
            this.exBinOrdersBindingSource.DataSource = this.dsBookIn;
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
            // customerCodeTextBox
            // 
            this.customerCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "CustomerCode", true));
            this.customerCodeTextBox.Location = new System.Drawing.Point(1129, 18);
            this.customerCodeTextBox.Name = "customerCodeTextBox";
            this.customerCodeTextBox.Size = new System.Drawing.Size(60, 23);
            this.customerCodeTextBox.TabIndex = 55;
            // 
            // customerLabel1
            // 
            customerLabel1.AutoSize = true;
            customerLabel1.Location = new System.Drawing.Point(789, 21);
            customerLabel1.Name = "customerLabel1";
            customerLabel1.Size = new System.Drawing.Size(72, 17);
            customerLabel1.TabIndex = 56;
            customerLabel1.Text = "Customer:";
            // 
            // customerTextBox1
            // 
            this.customerTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Customer", true));
            this.customerTextBox1.Location = new System.Drawing.Point(867, 18);
            this.customerTextBox1.Name = "customerTextBox1";
            this.customerTextBox1.Size = new System.Drawing.Size(256, 23);
            this.customerTextBox1.TabIndex = 57;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayloadTr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.tpTruckConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpTIQ.ResumeLayout(false);
            this.tpTIQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpTIQ;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.TextBox roadAccessTextBox;
        private System.Windows.Forms.TextBox truckConfigTextBox;
        private System.Windows.Forms.TextBox regoTextBox;
        private System.Windows.Forms.TextBox siteIDTextBox;
        private System.Windows.Forms.TextBox tIQIDTextBox;
        private System.Windows.Forms.TextBox payloadSplitTextBox;
        private System.Windows.Forms.TextBox payloadTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.TextBox stockpileLotNoTextBox;
        private System.Windows.Forms.TextBox cartageCodeTextBox2;
        private System.Windows.Forms.TextBox materialDescTextBox;
        private System.Windows.Forms.TextBox materialTextBox2;
        private System.Windows.Forms.TextBox custONTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox1;
        private System.Windows.Forms.TextBox sAPOrderTextBox;
        private System.Windows.Forms.DateTimePicker allocateDTTMDateTimePicker;
        private System.Windows.Forms.DateTimePicker entryDTTMDateTimePicker;
        private System.Windows.Forms.TextBox queueStatusTextBox;
        private System.Windows.Forms.TextBox gCMTextBox1;
        private System.Windows.Forms.TextBox regoTrailersTextBox;
        private System.Windows.Forms.TextBox nettTextBox;
        private System.Windows.Forms.TextBox tareTkTextBox1;
        private System.Windows.Forms.TextBox tareTextBox1;
        private System.Windows.Forms.TextBox grossTextBox;
        private System.Windows.Forms.TextBox gVMTruckTextBox1;
        private System.Windows.Forms.TextBox customerTextBox1;
        private System.Windows.Forms.TextBox customerCodeTextBox;
    }
}