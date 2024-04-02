
namespace QWS_Local
{
    partial class BookInExBin
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
            System.Windows.Forms.Label cardCodeLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label purchaseOrderLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.Windows.Forms.Label contactMobileLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label materialCodeLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label itemQALabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label suppliedLabel;
            System.Windows.Forms.Label openQtyLabel;
            System.Windows.Forms.Label sAPUpdateDTTMLabel;
            System.Windows.Forms.Label orderStatusLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpExBinOrders = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exBinOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDocDate = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openQtyTextBox = new System.Windows.Forms.TextBox();
            this.suppliedTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemQATextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.materialCodeTextBox = new System.Windows.Forms.TextBox();
            this.contactMobileTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.purchaseOrderTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.docNumTextBox = new System.Windows.Forms.TextBox();
            this.tpExBinNoOrder = new System.Windows.Forms.TabPage();
            this.exBinOrdersTableAdapter = new QWS_Local.dsBookInTableAdapters.ExBinOrdersTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.orderStatusTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            docNumLabel = new System.Windows.Forms.Label();
            docDateLabel = new System.Windows.Forms.Label();
            cardCodeLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            purchaseOrderLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            contactMobileLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            materialCodeLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            itemQALabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            suppliedLabel = new System.Windows.Forms.Label();
            openQtyLabel = new System.Windows.Forms.Label();
            sAPUpdateDTTMLabel = new System.Windows.Forms.Label();
            orderStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpExBinOrders.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // docNumLabel
            // 
            docNumLabel.AutoSize = true;
            docNumLabel.Location = new System.Drawing.Point(82, 21);
            docNumLabel.Name = "docNumLabel";
            docNumLabel.Size = new System.Drawing.Size(70, 17);
            docNumLabel.TabIndex = 0;
            docNumLabel.Text = "Doc Num:";
            // 
            // docDateLabel
            // 
            docDateLabel.AutoSize = true;
            docDateLabel.Location = new System.Drawing.Point(81, 51);
            docDateLabel.Name = "docDateLabel";
            docDateLabel.Size = new System.Drawing.Size(71, 17);
            docDateLabel.TabIndex = 2;
            docDateLabel.Text = "Doc Date:";
            // 
            // cardCodeLabel
            // 
            cardCodeLabel.AutoSize = true;
            cardCodeLabel.Location = new System.Drawing.Point(73, 79);
            cardCodeLabel.Name = "cardCodeLabel";
            cardCodeLabel.Size = new System.Drawing.Size(79, 17);
            cardCodeLabel.TabIndex = 4;
            cardCodeLabel.Text = "Card Code:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(80, 108);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(72, 17);
            customerLabel.TabIndex = 6;
            customerLabel.Text = "Customer:";
            // 
            // purchaseOrderLabel
            // 
            purchaseOrderLabel.AutoSize = true;
            purchaseOrderLabel.Location = new System.Drawing.Point(38, 137);
            purchaseOrderLabel.Name = "purchaseOrderLabel";
            purchaseOrderLabel.Size = new System.Drawing.Size(113, 17);
            purchaseOrderLabel.TabIndex = 8;
            purchaseOrderLabel.Text = "Purchase Order:";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(305, 135);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(101, 17);
            contactNameLabel.TabIndex = 10;
            contactNameLabel.Text = "Contact Name:";
            // 
            // contactMobileLabel
            // 
            contactMobileLabel.AutoSize = true;
            contactMobileLabel.Location = new System.Drawing.Point(301, 164);
            contactMobileLabel.Name = "contactMobileLabel";
            contactMobileLabel.Size = new System.Drawing.Size(105, 17);
            contactMobileLabel.TabIndex = 12;
            contactMobileLabel.Text = "Contact Mobile:";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(318, 50);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(97, 17);
            deliveryDateLabel.TabIndex = 14;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // materialCodeLabel
            // 
            materialCodeLabel.AutoSize = true;
            materialCodeLabel.Location = new System.Drawing.Point(52, 197);
            materialCodeLabel.Name = "materialCodeLabel";
            materialCodeLabel.Size = new System.Drawing.Size(99, 17);
            materialCodeLabel.TabIndex = 16;
            materialCodeLabel.Text = "Material Code:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(89, 226);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(62, 17);
            materialLabel.TabIndex = 18;
            materialLabel.Text = "Material:";
            // 
            // itemQALabel
            // 
            itemQALabel.AutoSize = true;
            itemQALabel.Location = new System.Drawing.Point(266, 200);
            itemQALabel.Name = "itemQALabel";
            itemQALabel.Size = new System.Drawing.Size(62, 17);
            itemQALabel.TabIndex = 20;
            itemQALabel.Text = "Item QA:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(86, 255);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(65, 17);
            quantityLabel.TabIndex = 22;
            quantityLabel.Text = "Quantity:";
            // 
            // suppliedLabel
            // 
            suppliedLabel.AutoSize = true;
            suppliedLabel.Location = new System.Drawing.Point(84, 284);
            suppliedLabel.Name = "suppliedLabel";
            suppliedLabel.Size = new System.Drawing.Size(67, 17);
            suppliedLabel.TabIndex = 24;
            suppliedLabel.Text = "Supplied:";
            // 
            // openQtyLabel
            // 
            openQtyLabel.AutoSize = true;
            openQtyLabel.Location = new System.Drawing.Point(78, 313);
            openQtyLabel.Name = "openQtyLabel";
            openQtyLabel.Size = new System.Drawing.Size(73, 17);
            openQtyLabel.TabIndex = 26;
            openQtyLabel.Text = "Open Qty:";
            // 
            // sAPUpdateDTTMLabel
            // 
            sAPUpdateDTTMLabel.AutoSize = true;
            sAPUpdateDTTMLabel.Location = new System.Drawing.Point(23, 345);
            sAPUpdateDTTMLabel.Name = "sAPUpdateDTTMLabel";
            sAPUpdateDTTMLabel.Size = new System.Drawing.Size(128, 17);
            sAPUpdateDTTMLabel.TabIndex = 28;
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
            this.splitContainer1.Panel1.Controls.Add(this.txtCardCode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1427, 554);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(31, 108);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(31, 48);
            this.txtCardCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(132, 23);
            this.txtCardCode.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpExBinOrders);
            this.tabControl2.Controls.Add(this.tpExBinNoOrder);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1241, 554);
            this.tabControl2.TabIndex = 2;
            // 
            // tpExBinOrders
            // 
            this.tpExBinOrders.Controls.Add(this.tabControl1);
            this.tpExBinOrders.Location = new System.Drawing.Point(4, 25);
            this.tpExBinOrders.Name = "tpExBinOrders";
            this.tpExBinOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpExBinOrders.Size = new System.Drawing.Size(1233, 525);
            this.tpExBinOrders.TabIndex = 0;
            this.tpExBinOrders.Text = "Ex-Bin Orders";
            this.tpExBinOrders.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 519);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 25);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(1219, 490);
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
            this.deliveryDateDataGridViewTextBoxColumn,
            this.docNumDataGridViewTextBoxColumn,
            this.OrderStatus,
            this.customerDataGridViewTextBoxColumn,
            this.purchaseOrderDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.openQtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exBinOrdersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // exBinOrdersBindingSource
            // 
            this.exBinOrdersBindingSource.DataMember = "ExBinOrders";
            this.exBinOrdersBindingSource.DataSource = this.dsBookIn;
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
            this.tpDetails.Controls.Add(this.txtDocDate);
            this.tpDetails.Controls.Add(this.textBox1);
            this.tpDetails.Controls.Add(sAPUpdateDTTMLabel);
            this.tpDetails.Controls.Add(openQtyLabel);
            this.tpDetails.Controls.Add(this.openQtyTextBox);
            this.tpDetails.Controls.Add(suppliedLabel);
            this.tpDetails.Controls.Add(this.suppliedTextBox);
            this.tpDetails.Controls.Add(quantityLabel);
            this.tpDetails.Controls.Add(this.quantityTextBox);
            this.tpDetails.Controls.Add(itemQALabel);
            this.tpDetails.Controls.Add(this.itemQATextBox);
            this.tpDetails.Controls.Add(materialLabel);
            this.tpDetails.Controls.Add(this.materialTextBox);
            this.tpDetails.Controls.Add(materialCodeLabel);
            this.tpDetails.Controls.Add(this.materialCodeTextBox);
            this.tpDetails.Controls.Add(deliveryDateLabel);
            this.tpDetails.Controls.Add(contactMobileLabel);
            this.tpDetails.Controls.Add(this.contactMobileTextBox);
            this.tpDetails.Controls.Add(contactNameLabel);
            this.tpDetails.Controls.Add(this.contactNameTextBox);
            this.tpDetails.Controls.Add(purchaseOrderLabel);
            this.tpDetails.Controls.Add(this.purchaseOrderTextBox);
            this.tpDetails.Controls.Add(customerLabel);
            this.tpDetails.Controls.Add(this.customerTextBox);
            this.tpDetails.Controls.Add(cardCodeLabel);
            this.tpDetails.Controls.Add(this.cardCodeTextBox);
            this.tpDetails.Controls.Add(docDateLabel);
            this.tpDetails.Controls.Add(docNumLabel);
            this.tpDetails.Controls.Add(this.docNumTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 25);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1219, 490);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "SAPUpdateDTTM", true));
            this.textBox3.Location = new System.Drawing.Point(157, 339);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 23);
            this.textBox3.TabIndex = 34;
            // 
            // txtDocDate
            // 
            this.txtDocDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "DocDate", true));
            this.txtDocDate.Location = new System.Drawing.Point(157, 47);
            this.txtDocDate.Name = "txtDocDate";
            this.txtDocDate.Size = new System.Drawing.Size(155, 23);
            this.txtDocDate.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "DeliveryDate", true));
            this.textBox1.Location = new System.Drawing.Point(412, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 32;
            // 
            // openQtyTextBox
            // 
            this.openQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "OpenQty", true));
            this.openQtyTextBox.Location = new System.Drawing.Point(157, 310);
            this.openQtyTextBox.Name = "openQtyTextBox";
            this.openQtyTextBox.Size = new System.Drawing.Size(100, 23);
            this.openQtyTextBox.TabIndex = 27;
            // 
            // suppliedTextBox
            // 
            this.suppliedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "Supplied", true));
            this.suppliedTextBox.Location = new System.Drawing.Point(157, 281);
            this.suppliedTextBox.Name = "suppliedTextBox";
            this.suppliedTextBox.Size = new System.Drawing.Size(100, 23);
            this.suppliedTextBox.TabIndex = 25;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(157, 252);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 23;
            // 
            // itemQATextBox
            // 
            this.itemQATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "ItemQA", true));
            this.itemQATextBox.Location = new System.Drawing.Point(334, 197);
            this.itemQATextBox.Name = "itemQATextBox";
            this.itemQATextBox.Size = new System.Drawing.Size(72, 23);
            this.itemQATextBox.TabIndex = 21;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(157, 223);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(355, 23);
            this.materialTextBox.TabIndex = 19;
            // 
            // materialCodeTextBox
            // 
            this.materialCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "MaterialCode", true));
            this.materialCodeTextBox.Location = new System.Drawing.Point(157, 194);
            this.materialCodeTextBox.Name = "materialCodeTextBox";
            this.materialCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.materialCodeTextBox.TabIndex = 17;
            // 
            // contactMobileTextBox
            // 
            this.contactMobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "ContactMobile", true));
            this.contactMobileTextBox.Location = new System.Drawing.Point(412, 161);
            this.contactMobileTextBox.Name = "contactMobileTextBox";
            this.contactMobileTextBox.Size = new System.Drawing.Size(100, 23);
            this.contactMobileTextBox.TabIndex = 13;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "ContactName", true));
            this.contactNameTextBox.Location = new System.Drawing.Point(412, 132);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.contactNameTextBox.TabIndex = 11;
            // 
            // purchaseOrderTextBox
            // 
            this.purchaseOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "PurchaseOrder", true));
            this.purchaseOrderTextBox.Location = new System.Drawing.Point(157, 134);
            this.purchaseOrderTextBox.Name = "purchaseOrderTextBox";
            this.purchaseOrderTextBox.Size = new System.Drawing.Size(100, 23);
            this.purchaseOrderTextBox.TabIndex = 9;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "Customer", true));
            this.customerTextBox.Location = new System.Drawing.Point(158, 105);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(354, 23);
            this.customerTextBox.TabIndex = 7;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(158, 76);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cardCodeTextBox.TabIndex = 5;
            // 
            // docNumTextBox
            // 
            this.docNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "DocNum", true));
            this.docNumTextBox.Location = new System.Drawing.Point(158, 18);
            this.docNumTextBox.Name = "docNumTextBox";
            this.docNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.docNumTextBox.TabIndex = 1;
            // 
            // tpExBinNoOrder
            // 
            this.tpExBinNoOrder.Location = new System.Drawing.Point(4, 22);
            this.tpExBinNoOrder.Name = "tpExBinNoOrder";
            this.tpExBinNoOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tpExBinNoOrder.Size = new System.Drawing.Size(1233, 528);
            this.tpExBinNoOrder.TabIndex = 1;
            this.tpExBinNoOrder.Text = "Ex-Bin No Order";
            this.tpExBinNoOrder.UseVisualStyleBackColor = true;
            // 
            // exBinOrdersTableAdapter
            // 
            this.exBinOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsBookInTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderStatusLabel
            // 
            orderStatusLabel.AutoSize = true;
            orderStatusLabel.Location = new System.Drawing.Point(313, 21);
            orderStatusLabel.Name = "orderStatusLabel";
            orderStatusLabel.Size = new System.Drawing.Size(93, 17);
            orderStatusLabel.TabIndex = 34;
            orderStatusLabel.Text = "Order Status:";
            // 
            // orderStatusTextBox
            // 
            this.orderStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exBinOrdersBindingSource, "OrderStatus", true));
            this.orderStatusTextBox.Location = new System.Drawing.Point(412, 18);
            this.orderStatusTextBox.Name = "orderStatusTextBox";
            this.orderStatusTextBox.Size = new System.Drawing.Size(100, 23);
            this.orderStatusTextBox.TabIndex = 35;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "DocNum";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            this.docNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
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
            // materialCodeDataGridViewTextBoxColumn
            // 
            this.materialCodeDataGridViewTextBoxColumn.DataPropertyName = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.materialCodeDataGridViewTextBoxColumn.Name = "materialCodeDataGridViewTextBoxColumn";
            this.materialCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material ";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openQtyDataGridViewTextBoxColumn
            // 
            this.openQtyDataGridViewTextBoxColumn.DataPropertyName = "OpenQty";
            this.openQtyDataGridViewTextBoxColumn.HeaderText = "Open Qty";
            this.openQtyDataGridViewTextBoxColumn.Name = "openQtyDataGridViewTextBoxColumn";
            this.openQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookInExBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookInExBin";
            this.Text = "BookInExBin";
            this.Load += new System.EventHandler(this.BookInExBin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpExBinOrders.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource exBinOrdersBindingSource;
        private dsBookInTableAdapters.ExBinOrdersTableAdapter exBinOrdersTableAdapter;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDocDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox openQtyTextBox;
        private System.Windows.Forms.TextBox suppliedTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemQATextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox materialCodeTextBox;
        private System.Windows.Forms.TextBox contactMobileTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox purchaseOrderTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox docNumTextBox;
        private dsBookInTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpExBinOrders;
        private System.Windows.Forms.TabPage tpExBinNoOrder;
        private System.Windows.Forms.TextBox orderStatusTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openQtyDataGridViewTextBoxColumn;
    }
}