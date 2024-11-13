
namespace QWS_Local
{
    partial class DeliveryOrders
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
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label openQtyLabel;
            System.Windows.Forms.Label suppliedLabel;
            System.Windows.Forms.Label cartageCodeLabel;
            System.Windows.Forms.Label docDateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.Windows.Forms.Label orderStatusLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.rbTnT = new System.Windows.Forms.RadioButton();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsDeliveryOrdersAll = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.suppliedTextBox = new System.Windows.Forms.TextBox();
            this.openQtyTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.materialCodeTextBox = new System.Windows.Forms.TextBox();
            this.docNumTextBox = new System.Windows.Forms.TextBox();
            this.taDeliveryOrdersAll = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.deliveryOrdersAllTableAdapter1 = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.cartageCodeTextBox = new System.Windows.Forms.TextBox();
            this.cartageTextBox = new System.Windows.Forms.TextBox();
            this.docDateTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.contactMobileTextBox = new System.Windows.Forms.TextBox();
            this.orderStatusTextBox = new System.Windows.Forms.TextBox();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            docNumLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            openQtyLabel = new System.Windows.Forms.Label();
            suppliedLabel = new System.Windows.Forms.Label();
            cartageCodeLabel = new System.Windows.Forms.Label();
            docDateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            orderStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrdersAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            this.tpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // docNumLabel
            // 
            docNumLabel.AutoSize = true;
            docNumLabel.Location = new System.Drawing.Point(63, 37);
            docNumLabel.Name = "docNumLabel";
            docNumLabel.Size = new System.Drawing.Size(70, 17);
            docNumLabel.TabIndex = 0;
            docNumLabel.Text = "Doc Num:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(71, 124);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(62, 17);
            materialLabel.TabIndex = 8;
            materialLabel.Text = "Material:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(68, 182);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(65, 17);
            quantityLabel.TabIndex = 10;
            quantityLabel.Text = "Quantity:";
            // 
            // openQtyLabel
            // 
            openQtyLabel.AutoSize = true;
            openQtyLabel.Location = new System.Drawing.Point(60, 211);
            openQtyLabel.Name = "openQtyLabel";
            openQtyLabel.Size = new System.Drawing.Size(73, 17);
            openQtyLabel.TabIndex = 12;
            openQtyLabel.Text = "Open Qty:";
            // 
            // suppliedLabel
            // 
            suppliedLabel.AutoSize = true;
            suppliedLabel.Location = new System.Drawing.Point(66, 240);
            suppliedLabel.Name = "suppliedLabel";
            suppliedLabel.Size = new System.Drawing.Size(67, 17);
            suppliedLabel.TabIndex = 14;
            suppliedLabel.Text = "Supplied:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(25, 289);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 47);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClear);
            this.groupBox1.Controls.Add(this.rbTnT);
            this.groupBox1.Controls.Add(this.rbTruck);
            this.groupBox1.Location = new System.Drawing.Point(3, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Mode";
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Checked = true;
            this.rbClear.Location = new System.Drawing.Point(22, 106);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(59, 21);
            this.rbClear.TabIndex = 2;
            this.rbClear.TabStop = true;
            this.rbClear.Text = "Clear";
            this.rbClear.UseVisualStyleBackColor = true;
            this.rbClear.CheckedChanged += new System.EventHandler(this.rbClear_CheckedChanged);
            // 
            // rbTnT
            // 
            this.rbTnT.AutoSize = true;
            this.rbTnT.Location = new System.Drawing.Point(22, 68);
            this.rbTnT.Name = "rbTnT";
            this.rbTnT.Size = new System.Drawing.Size(165, 21);
            this.rbTnT.TabIndex = 1;
            this.rbTnT.Text = "Truck and Trailer (97)";
            this.rbTnT.UseVisualStyleBackColor = true;
            this.rbTnT.CheckedChanged += new System.EventHandler(this.rbTnT_CheckedChanged);
            // 
            // rbTruck
            // 
            this.rbTruck.AutoSize = true;
            this.rbTruck.Location = new System.Drawing.Point(22, 32);
            this.rbTruck.Name = "rbTruck";
            this.rbTruck.Size = new System.Drawing.Size(92, 21);
            this.rbTruck.TabIndex = 0;
            this.rbTruck.Text = "Truck (96)";
            this.rbTruck.UseVisualStyleBackColor = true;
            this.rbTruck.CheckedChanged += new System.EventHandler(this.rbTruck_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 554);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 25);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(855, 525);
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
            this.deliveryDateDataGridViewTextBoxColumn,
            this.openQtyDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.cartageCodeDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsDeliveryOrdersAll;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(849, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // bsDeliveryOrdersAll
            // 
            this.bsDeliveryOrdersAll.DataMember = "DeliveryOrdersAll";
            this.bsDeliveryOrdersAll.DataSource = this.dsBookIn;
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
            this.tpDetails.Controls.Add(this.contactMobileTextBox);
            this.tpDetails.Controls.Add(contactNameLabel);
            this.tpDetails.Controls.Add(this.contactNameTextBox);
            this.tpDetails.Controls.Add(this.cardCodeTextBox);
            this.tpDetails.Controls.Add(customerLabel);
            this.tpDetails.Controls.Add(this.customerTextBox);
            this.tpDetails.Controls.Add(deliveryDateLabel);
            this.tpDetails.Controls.Add(this.deliveryDateTextBox);
            this.tpDetails.Controls.Add(docDateLabel);
            this.tpDetails.Controls.Add(this.docDateTextBox);
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
            this.tpDetails.Controls.Add(this.materialCodeTextBox);
            this.tpDetails.Controls.Add(docNumLabel);
            this.tpDetails.Controls.Add(this.docNumTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 25);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(855, 525);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // suppliedTextBox
            // 
            this.suppliedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "Supplied", true));
            this.suppliedTextBox.Location = new System.Drawing.Point(139, 237);
            this.suppliedTextBox.Name = "suppliedTextBox";
            this.suppliedTextBox.Size = new System.Drawing.Size(100, 23);
            this.suppliedTextBox.TabIndex = 15;
            // 
            // openQtyTextBox
            // 
            this.openQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "OpenQty", true));
            this.openQtyTextBox.Location = new System.Drawing.Point(139, 208);
            this.openQtyTextBox.Name = "openQtyTextBox";
            this.openQtyTextBox.Size = new System.Drawing.Size(100, 23);
            this.openQtyTextBox.TabIndex = 13;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(139, 179);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 11;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(245, 121);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(217, 23);
            this.materialTextBox.TabIndex = 9;
            // 
            // materialCodeTextBox
            // 
            this.materialCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "MaterialCode", true));
            this.materialCodeTextBox.Location = new System.Drawing.Point(139, 121);
            this.materialCodeTextBox.Name = "materialCodeTextBox";
            this.materialCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.materialCodeTextBox.TabIndex = 7;
            // 
            // docNumTextBox
            // 
            this.docNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "DocNum", true));
            this.docNumTextBox.Location = new System.Drawing.Point(139, 34);
            this.docNumTextBox.Name = "docNumTextBox";
            this.docNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.docNumTextBox.TabIndex = 1;
            // 
            // taDeliveryOrdersAll
            // 
            this.taDeliveryOrdersAll.ClearBeforeFill = true;
            // 
            // deliveryOrdersAllTableAdapter1
            // 
            this.deliveryOrdersAllTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsBookInTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cartageCodeLabel
            // 
            cartageCodeLabel.AutoSize = true;
            cartageCodeLabel.Location = new System.Drawing.Point(68, 153);
            cartageCodeLabel.Name = "cartageCodeLabel";
            cartageCodeLabel.Size = new System.Drawing.Size(62, 17);
            cartageCodeLabel.TabIndex = 15;
            cartageCodeLabel.Text = "Cartage:";
            // 
            // cartageCodeTextBox
            // 
            this.cartageCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "CartageCode", true));
            this.cartageCodeTextBox.Location = new System.Drawing.Point(139, 150);
            this.cartageCodeTextBox.Name = "cartageCodeTextBox";
            this.cartageCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cartageCodeTextBox.TabIndex = 16;
            // 
            // cartageTextBox
            // 
            this.cartageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "Cartage", true));
            this.cartageTextBox.Location = new System.Drawing.Point(245, 150);
            this.cartageTextBox.Name = "cartageTextBox";
            this.cartageTextBox.Size = new System.Drawing.Size(217, 23);
            this.cartageTextBox.TabIndex = 18;
            // 
            // docDateLabel
            // 
            docDateLabel.AutoSize = true;
            docDateLabel.Location = new System.Drawing.Point(62, 66);
            docDateLabel.Name = "docDateLabel";
            docDateLabel.Size = new System.Drawing.Size(71, 17);
            docDateLabel.TabIndex = 18;
            docDateLabel.Text = "Doc Date:";
            // 
            // docDateTextBox
            // 
            this.docDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "DocDate", true));
            this.docDateTextBox.Location = new System.Drawing.Point(139, 63);
            this.docDateTextBox.Name = "docDateTextBox";
            this.docDateTextBox.Size = new System.Drawing.Size(100, 23);
            this.docDateTextBox.TabIndex = 19;
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(36, 95);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(97, 17);
            deliveryDateLabel.TabIndex = 19;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // deliveryDateTextBox
            // 
            this.deliveryDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "DeliveryDate", true));
            this.deliveryDateTextBox.Location = new System.Drawing.Point(139, 92);
            this.deliveryDateTextBox.Name = "deliveryDateTextBox";
            this.deliveryDateTextBox.Size = new System.Drawing.Size(100, 23);
            this.deliveryDateTextBox.TabIndex = 20;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(284, 37);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(72, 17);
            customerLabel.TabIndex = 20;
            customerLabel.Text = "Customer:";
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "Customer", true));
            this.customerTextBox.Location = new System.Drawing.Point(362, 34);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(265, 23);
            this.customerTextBox.TabIndex = 21;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(633, 34);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cardCodeTextBox.TabIndex = 22;
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(255, 66);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(101, 17);
            contactNameLabel.TabIndex = 22;
            contactNameLabel.Text = "Contact Name:";
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "ContactName", true));
            this.contactNameTextBox.Location = new System.Drawing.Point(362, 63);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(265, 23);
            this.contactNameTextBox.TabIndex = 23;
            // 
            // contactMobileTextBox
            // 
            this.contactMobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "ContactMobile", true));
            this.contactMobileTextBox.Location = new System.Drawing.Point(633, 63);
            this.contactMobileTextBox.Name = "contactMobileTextBox";
            this.contactMobileTextBox.Size = new System.Drawing.Size(100, 23);
            this.contactMobileTextBox.TabIndex = 24;
            // 
            // orderStatusLabel
            // 
            orderStatusLabel.AutoSize = true;
            orderStatusLabel.Location = new System.Drawing.Point(40, 269);
            orderStatusLabel.Name = "orderStatusLabel";
            orderStatusLabel.Size = new System.Drawing.Size(93, 17);
            orderStatusLabel.TabIndex = 24;
            orderStatusLabel.Text = "Order Status:";
            // 
            // orderStatusTextBox
            // 
            this.orderStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeliveryOrdersAll, "OrderStatus", true));
            this.orderStatusTextBox.Location = new System.Drawing.Point(139, 266);
            this.orderStatusTextBox.Name = "orderStatusTextBox";
            this.orderStatusTextBox.Size = new System.Drawing.Size(100, 23);
            this.orderStatusTextBox.TabIndex = 25;
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "DocNum";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            this.docNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openQtyDataGridViewTextBoxColumn
            // 
            this.openQtyDataGridViewTextBoxColumn.DataPropertyName = "OpenQty";
            this.openQtyDataGridViewTextBoxColumn.HeaderText = "OpenQty";
            this.openQtyDataGridViewTextBoxColumn.Name = "openQtyDataGridViewTextBoxColumn";
            this.openQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cartageCodeDataGridViewTextBoxColumn
            // 
            this.cartageCodeDataGridViewTextBoxColumn.DataPropertyName = "CartageCode";
            this.cartageCodeDataGridViewTextBoxColumn.HeaderText = "CartageCode";
            this.cartageCodeDataGridViewTextBoxColumn.Name = "cartageCodeDataGridViewTextBoxColumn";
            this.cartageCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeliveryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeliveryOrders";
            this.Text = "DeliveryOrders";
            this.Load += new System.EventHandler(this.DeliveryOrders_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrdersAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClear;
        private System.Windows.Forms.RadioButton rbTnT;
        private System.Windows.Forms.RadioButton rbTruck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource bsDeliveryOrdersAll;
        private dsBookInTableAdapters.DeliveryOrdersAllTableAdapter taDeliveryOrdersAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox suppliedTextBox;
        private System.Windows.Forms.TextBox openQtyTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox materialCodeTextBox;
        private System.Windows.Forms.TextBox docNumTextBox;
        private dsBookInTableAdapters.DeliveryOrdersAllTableAdapter deliveryOrdersAllTableAdapter1;
        private dsBookInTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox orderStatusTextBox;
        private System.Windows.Forms.TextBox contactMobileTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox deliveryDateTextBox;
        private System.Windows.Forms.TextBox docDateTextBox;
        private System.Windows.Forms.TextBox cartageTextBox;
        private System.Windows.Forms.TextBox cartageCodeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
    }
}