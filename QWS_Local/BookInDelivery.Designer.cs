
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsDeliveryOrders = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.tpDetails = new System.Windows.Forms.TabPage();
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
            this.taDeliveryOrders = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.exBinOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exBinOrdersTableAdapter = new QWS_Local.dsBookInTableAdapters.ExBinOrdersTableAdapter();
            this.orderStatusTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).BeginInit();
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
            cartageCodeLabel.Location = new System.Drawing.Point(30, 290);
            cartageCodeLabel.Name = "cartageCodeLabel";
            cartageCodeLabel.Size = new System.Drawing.Size(99, 17);
            cartageCodeLabel.TabIndex = 16;
            cartageCodeLabel.Text = "Cartage Code:";
            // 
            // cartageLabel
            // 
            cartageLabel.AutoSize = true;
            cartageLabel.Location = new System.Drawing.Point(67, 319);
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
            sAPCommentsLabel.Location = new System.Drawing.Point(24, 377);
            sAPCommentsLabel.Name = "sAPCommentsLabel";
            sAPCommentsLabel.Size = new System.Drawing.Size(105, 17);
            sAPCommentsLabel.TabIndex = 22;
            sAPCommentsLabel.Text = "SAPComments:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(10, 348);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(119, 17);
            deliveryAddressLabel.TabIndex = 24;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // mapRefLabel
            // 
            mapRefLabel.AutoSize = true;
            mapRefLabel.Location = new System.Drawing.Point(241, 290);
            mapRefLabel.Name = "mapRefLabel";
            mapRefLabel.Size = new System.Drawing.Size(65, 17);
            mapRefLabel.TabIndex = 26;
            mapRefLabel.Text = "Map Ref:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new System.Drawing.Point(62, 261);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(67, 17);
            distanceLabel.TabIndex = 28;
            distanceLabel.Text = "Distance:";
            // 
            // sAPUpdateDTTMLabel
            // 
            sAPUpdateDTTMLabel.AutoSize = true;
            sAPUpdateDTTMLabel.Location = new System.Drawing.Point(7, 409);
            sAPUpdateDTTMLabel.Name = "sAPUpdateDTTMLabel";
            sAPUpdateDTTMLabel.Size = new System.Drawing.Size(128, 17);
            sAPUpdateDTTMLabel.TabIndex = 30;
            sAPUpdateDTTMLabel.Text = "SAPUpdate DTTM:";
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
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1361, 554);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(35, 78);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 554);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 25);
            this.tpList.Margin = new System.Windows.Forms.Padding(4);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(4);
            this.tpList.Size = new System.Drawing.Size(1157, 525);
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
            this.dataGridView1.Size = new System.Drawing.Size(1149, 517);
            this.dataGridView1.TabIndex = 0;
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
            this.tpDetails.Size = new System.Drawing.Size(1157, 525);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "SAPUpdateDTTM", true));
            this.textBox3.Location = new System.Drawing.Point(136, 406);
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
            this.distanceTextBox.Location = new System.Drawing.Point(135, 258);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 23);
            this.distanceTextBox.TabIndex = 29;
            // 
            // mapRefTextBox
            // 
            this.mapRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "MapRef", true));
            this.mapRefTextBox.Location = new System.Drawing.Point(312, 287);
            this.mapRefTextBox.Name = "mapRefTextBox";
            this.mapRefTextBox.Size = new System.Drawing.Size(100, 23);
            this.mapRefTextBox.TabIndex = 27;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(135, 345);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(688, 23);
            this.deliveryAddressTextBox.TabIndex = 25;
            // 
            // sAPCommentsTextBox
            // 
            this.sAPCommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "SAPComments", true));
            this.sAPCommentsTextBox.Location = new System.Drawing.Point(135, 374);
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
            this.cartageTextBox.Location = new System.Drawing.Point(135, 316);
            this.cartageTextBox.Name = "cartageTextBox";
            this.cartageTextBox.Size = new System.Drawing.Size(277, 23);
            this.cartageTextBox.TabIndex = 19;
            // 
            // cartageCodeTextBox
            // 
            this.cartageCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrders, "CartageCode", true));
            this.cartageCodeTextBox.Location = new System.Drawing.Point(135, 287);
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
            // exBinOrdersBindingSource
            // 
            this.exBinOrdersBindingSource.DataMember = "ExBinOrders";
            this.exBinOrdersBindingSource.DataSource = this.dsBookIn;
            // 
            // exBinOrdersTableAdapter
            // 
            this.exBinOrdersTableAdapter.ClearBeforeFill = true;
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
            // orderStatusTextBox
            // 
            this.orderStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "OrderStatus", true));
            this.orderStatusTextBox.Location = new System.Drawing.Point(370, 25);
            this.orderStatusTextBox.Name = "orderStatusTextBox";
            this.orderStatusTextBox.Size = new System.Drawing.Size(100, 23);
            this.orderStatusTextBox.TabIndex = 34;
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
            // BookInDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookInDelivery";
            this.Text = "BookInDelivery";
            this.Load += new System.EventHandler(this.BookInDelivery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource bsDeliveryOrders;
        private dsBookInTableAdapters.DeliveryOrdersAllTableAdapter taDeliveryOrders;
        private System.Windows.Forms.Button btnLoad;
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
    }
}