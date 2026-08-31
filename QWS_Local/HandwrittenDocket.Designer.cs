namespace QWS_Local
{
    partial class HandwrittenDocket
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
            System.Windows.Forms.Label cardNameLabel;
            System.Windows.Forms.Label purchaseOrderLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.Windows.Forms.Label grossLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label nettLabel;
            System.Windows.Forms.Label truckDriverLabel;
            System.Windows.Forms.Label truckRegoLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label label1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbDocketLines = new System.Windows.Forms.GroupBox();
            this.wBDocketLinesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsWBDocketLines = new System.Windows.Forms.BindingSource(this.components);
            this.bsWBDockets = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.txtDocketType = new System.Windows.Forms.TextBox();
            this.mtxtSAPOrderDocNum = new System.Windows.Forms.MaskedTextBox();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.contactMobileTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.txtCustON = new System.Windows.Forms.TextBox();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.gbDocket = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.btnSaveDocket = new System.Windows.Forms.Button();
            this.docDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbTruck = new System.Windows.Forms.GroupBox();
            this.nudNett = new System.Windows.Forms.NumericUpDown();
            this.nudGross = new System.Windows.Forms.NumericUpDown();
            this.nudTare = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSetTruckConfig = new System.Windows.Forms.Button();
            this.configuredTrucksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxGVM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.btnFindTruck = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetDriver = new System.Windows.Forms.Button();
            this.truckDriverTextBox = new System.Windows.Forms.TextBox();
            this.txtTruckRego = new System.Windows.Forms.TextBox();
            this.btnCalculateNett = new System.Windows.Forms.Button();
            this.bsBlanketAgreementCheck = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.taWBDockets = new QWS_Local.dsTIQ2TableAdapters.WBDocketsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.taWBDocketLines = new QWS_Local.dsTIQ2TableAdapters.WBDocketLinesTableAdapter();
            this.taItem = new QWS_Local.dsBookInTableAdapters.ItemTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.taBlanketAgreementCheck = new QWS_Local.dsBookInTableAdapters.BlanketAgreementCheckTableAdapter();
            this.taConfiguredTrucks = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
            this.tableAdapterManager2 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            docNumLabel = new System.Windows.Forms.Label();
            cardNameLabel = new System.Windows.Forms.Label();
            purchaseOrderLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            grossLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            nettLabel = new System.Windows.Forms.Label();
            truckDriverLabel = new System.Windows.Forms.Label();
            truckRegoLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbDocketLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wBDocketLinesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDocketLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            this.gbCustomer.SuspendLayout();
            this.gbDocket.SuspendLayout();
            this.gbTruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuredTrucksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlanketAgreementCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // docNumLabel
            // 
            docNumLabel.AutoSize = true;
            docNumLabel.Location = new System.Drawing.Point(57, 33);
            docNumLabel.Name = "docNumLabel";
            docNumLabel.Size = new System.Drawing.Size(76, 18);
            docNumLabel.TabIndex = 4;
            docNumLabel.Text = "Doc Num:";
            // 
            // cardNameLabel
            // 
            cardNameLabel.AutoSize = true;
            cardNameLabel.Location = new System.Drawing.Point(43, 38);
            cardNameLabel.Name = "cardNameLabel";
            cardNameLabel.Size = new System.Drawing.Size(88, 18);
            cardNameLabel.TabIndex = 6;
            cardNameLabel.Text = "Card Name:";
            // 
            // purchaseOrderLabel
            // 
            purchaseOrderLabel.AutoSize = true;
            purchaseOrderLabel.Location = new System.Drawing.Point(14, 68);
            purchaseOrderLabel.Name = "purchaseOrderLabel";
            purchaseOrderLabel.Size = new System.Drawing.Size(117, 18);
            purchaseOrderLabel.TabIndex = 8;
            purchaseOrderLabel.Text = "Purchase Order:";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(34, 162);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(97, 18);
            contactNameLabel.TabIndex = 12;
            contactNameLabel.Text = "Site Contact :";
            // 
            // grossLabel
            // 
            grossLabel.AutoSize = true;
            grossLabel.Location = new System.Drawing.Point(606, 121);
            grossLabel.Name = "grossLabel";
            grossLabel.Size = new System.Drawing.Size(54, 18);
            grossLabel.TabIndex = 23;
            grossLabel.Text = "Gross:";
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(618, 151);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 18);
            tareLabel.TabIndex = 25;
            tareLabel.Text = "Tare:";
            // 
            // nettLabel
            // 
            nettLabel.AutoSize = true;
            nettLabel.Location = new System.Drawing.Point(621, 181);
            nettLabel.Name = "nettLabel";
            nettLabel.Size = new System.Drawing.Size(39, 18);
            nettLabel.TabIndex = 27;
            nettLabel.Text = "Nett:";
            // 
            // truckDriverLabel
            // 
            truckDriverLabel.AutoSize = true;
            truckDriverLabel.Location = new System.Drawing.Point(509, 66);
            truckDriverLabel.Name = "truckDriverLabel";
            truckDriverLabel.Size = new System.Drawing.Size(51, 18);
            truckDriverLabel.TabIndex = 38;
            truckDriverLabel.Text = "Driver:";
            // 
            // truckRegoLabel
            // 
            truckRegoLabel.AutoSize = true;
            truckRegoLabel.Location = new System.Drawing.Point(115, 31);
            truckRegoLabel.Name = "truckRegoLabel";
            truckRegoLabel.Size = new System.Drawing.Size(90, 18);
            truckRegoLabel.TabIndex = 39;
            truckRegoLabel.Text = "Truck Rego:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(9, 98);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(122, 18);
            deliveryAddressLabel.TabIndex = 40;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(546, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 18);
            label1.TabIndex = 45;
            label1.Text = "SAP Order:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbDocketLines);
            this.splitContainer1.Panel2.Controls.Add(this.gbCustomer);
            this.splitContainer1.Panel2.Controls.Add(this.gbDocket);
            this.splitContainer1.Panel2.Controls.Add(this.gbTruck);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 799);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbDocketLines
            // 
            this.gbDocketLines.Controls.Add(this.wBDocketLinesDataGridView1);
            this.gbDocketLines.Controls.Add(this.btnGetItem);
            this.gbDocketLines.Location = new System.Drawing.Point(49, 297);
            this.gbDocketLines.Name = "gbDocketLines";
            this.gbDocketLines.Size = new System.Drawing.Size(939, 212);
            this.gbDocketLines.TabIndex = 46;
            this.gbDocketLines.TabStop = false;
            this.gbDocketLines.Text = "Material | Cartage | Short Load Fee";
            // 
            // wBDocketLinesDataGridView1
            // 
            this.wBDocketLinesDataGridView1.AutoGenerateColumns = false;
            this.wBDocketLinesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wBDocketLinesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn57});
            this.wBDocketLinesDataGridView1.DataSource = this.bsWBDocketLines;
            this.wBDocketLinesDataGridView1.Location = new System.Drawing.Point(6, 32);
            this.wBDocketLinesDataGridView1.Name = "wBDocketLinesDataGridView1";
            this.wBDocketLinesDataGridView1.Size = new System.Drawing.Size(761, 169);
            this.wBDocketLinesDataGridView1.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn54.HeaderText = "ItemCode";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn55.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Width = 350;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ItemQA";
            this.dataGridViewCheckBoxColumn2.HeaderText = "ItemQA";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "StockpileLot";
            this.dataGridViewTextBoxColumn57.HeaderText = "StockpileLot";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            // 
            // bsWBDocketLines
            // 
            this.bsWBDocketLines.DataMember = "FK_WBDocketLines_WBDockets";
            this.bsWBDocketLines.DataSource = this.bsWBDockets;
            // 
            // bsWBDockets
            // 
            this.bsWBDockets.DataMember = "WBDockets";
            this.bsWBDockets.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(774, 56);
            this.btnGetItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(128, 32);
            this.btnGetItem.TabIndex = 4;
            this.btnGetItem.Text = "Get Item";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.btnGetItem_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.txtDocketType);
            this.gbCustomer.Controls.Add(this.mtxtSAPOrderDocNum);
            this.gbCustomer.Controls.Add(label1);
            this.gbCustomer.Controls.Add(this.btnGetOrder);
            this.gbCustomer.Controls.Add(this.cardNameTextBox);
            this.gbCustomer.Controls.Add(this.contactMobileTextBox);
            this.gbCustomer.Controls.Add(contactNameLabel);
            this.gbCustomer.Controls.Add(this.contactNameTextBox);
            this.gbCustomer.Controls.Add(deliveryAddressLabel);
            this.gbCustomer.Controls.Add(purchaseOrderLabel);
            this.gbCustomer.Controls.Add(this.deliveryAddressTextBox);
            this.gbCustomer.Controls.Add(this.txtCustON);
            this.gbCustomer.Controls.Add(cardNameLabel);
            this.gbCustomer.Controls.Add(this.txtCardCode);
            this.gbCustomer.Controls.Add(this.btnGetCustomer);
            this.gbCustomer.Location = new System.Drawing.Point(51, 91);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(937, 200);
            this.gbCustomer.TabIndex = 45;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer | Order | Delivery Address";
            // 
            // txtDocketType
            // 
            this.txtDocketType.Location = new System.Drawing.Point(581, 35);
            this.txtDocketType.Name = "txtDocketType";
            this.txtDocketType.ReadOnly = true;
            this.txtDocketType.Size = new System.Drawing.Size(154, 24);
            this.txtDocketType.TabIndex = 50;
            // 
            // mtxtSAPOrderDocNum
            // 
            this.mtxtSAPOrderDocNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "SAPOrderDocNum", true));
            this.mtxtSAPOrderDocNum.Location = new System.Drawing.Point(635, 68);
            this.mtxtSAPOrderDocNum.Name = "mtxtSAPOrderDocNum";
            this.mtxtSAPOrderDocNum.Size = new System.Drawing.Size(100, 24);
            this.mtxtSAPOrderDocNum.TabIndex = 48;
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(772, 71);
            this.btnGetOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(128, 32);
            this.btnGetOrder.TabIndex = 43;
            this.btnGetOrder.Text = "Get Order";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "CardName", true));
            this.cardNameTextBox.Location = new System.Drawing.Point(137, 35);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.ReadOnly = true;
            this.cardNameTextBox.Size = new System.Drawing.Size(317, 24);
            this.cardNameTextBox.TabIndex = 7;
            // 
            // contactMobileTextBox
            // 
            this.contactMobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "ContactMobile", true));
            this.contactMobileTextBox.Location = new System.Drawing.Point(356, 159);
            this.contactMobileTextBox.Name = "contactMobileTextBox";
            this.contactMobileTextBox.ReadOnly = true;
            this.contactMobileTextBox.Size = new System.Drawing.Size(100, 24);
            this.contactMobileTextBox.TabIndex = 15;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "ContactName", true));
            this.contactNameTextBox.Location = new System.Drawing.Point(137, 159);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.ReadOnly = true;
            this.contactNameTextBox.Size = new System.Drawing.Size(213, 24);
            this.contactNameTextBox.TabIndex = 13;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(137, 95);
            this.deliveryAddressTextBox.Multiline = true;
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.ReadOnly = true;
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(319, 58);
            this.deliveryAddressTextBox.TabIndex = 41;
            // 
            // txtCustON
            // 
            this.txtCustON.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "PurchaseOrder", true));
            this.txtCustON.Location = new System.Drawing.Point(137, 65);
            this.txtCustON.Name = "txtCustON";
            this.txtCustON.Size = new System.Drawing.Size(100, 24);
            this.txtCustON.TabIndex = 9;
            // 
            // txtCardCode
            // 
            this.txtCardCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "CardCode", true));
            this.txtCardCode.Location = new System.Drawing.Point(460, 35);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.ReadOnly = true;
            this.txtCardCode.Size = new System.Drawing.Size(93, 24);
            this.txtCardCode.TabIndex = 3;
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(772, 31);
            this.btnGetCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(128, 32);
            this.btnGetCustomer.TabIndex = 36;
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // gbDocket
            // 
            this.gbDocket.Controls.Add(this.btnClear);
            this.gbDocket.Controls.Add(this.txtDocNum);
            this.gbDocket.Controls.Add(this.btnSaveDocket);
            this.gbDocket.Controls.Add(docNumLabel);
            this.gbDocket.Controls.Add(this.docDateDateTimePicker);
            this.gbDocket.Controls.Add(this.btnCheck);
            this.gbDocket.Location = new System.Drawing.Point(49, 12);
            this.gbDocket.Name = "gbDocket";
            this.gbDocket.Size = new System.Drawing.Size(939, 73);
            this.gbDocket.TabIndex = 44;
            this.gbDocket.TabStop = false;
            this.gbDocket.Text = "Docket";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(776, 26);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDocNum
            // 
            this.txtDocNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "DocNum", true));
            this.txtDocNum.Location = new System.Drawing.Point(139, 30);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(100, 24);
            this.txtDocNum.TabIndex = 1;
            // 
            // btnSaveDocket
            // 
            this.btnSaveDocket.Enabled = false;
            this.btnSaveDocket.Location = new System.Drawing.Point(640, 26);
            this.btnSaveDocket.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDocket.Name = "btnSaveDocket";
            this.btnSaveDocket.Size = new System.Drawing.Size(128, 32);
            this.btnSaveDocket.TabIndex = 1;
            this.btnSaveDocket.Text = "Save";
            this.btnSaveDocket.UseVisualStyleBackColor = true;
            this.btnSaveDocket.Click += new System.EventHandler(this.btnSaveDocket_Click);
            // 
            // docDateDateTimePicker
            // 
            this.docDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsWBDockets, "DocDate", true));
            this.docDateDateTimePicker.Location = new System.Drawing.Point(258, 30);
            this.docDateDateTimePicker.Name = "docDateDateTimePicker";
            this.docDateDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.docDateDateTimePicker.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(504, 26);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 32);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gbTruck
            // 
            this.gbTruck.Controls.Add(this.nudNett);
            this.gbTruck.Controls.Add(this.nudGross);
            this.gbTruck.Controls.Add(this.nudTare);
            this.gbTruck.Controls.Add(this.textBox2);
            this.gbTruck.Controls.Add(this.btnSetTruckConfig);
            this.gbTruck.Controls.Add(this.configuredTrucksDataGridView);
            this.gbTruck.Controls.Add(this.btnFindTruck);
            this.gbTruck.Controls.Add(this.textBox1);
            this.gbTruck.Controls.Add(this.btnGetDriver);
            this.gbTruck.Controls.Add(this.truckDriverTextBox);
            this.gbTruck.Controls.Add(truckDriverLabel);
            this.gbTruck.Controls.Add(this.txtTruckRego);
            this.gbTruck.Controls.Add(truckRegoLabel);
            this.gbTruck.Controls.Add(this.btnCalculateNett);
            this.gbTruck.Controls.Add(grossLabel);
            this.gbTruck.Controls.Add(tareLabel);
            this.gbTruck.Controls.Add(nettLabel);
            this.gbTruck.Location = new System.Drawing.Point(51, 515);
            this.gbTruck.Name = "gbTruck";
            this.gbTruck.Size = new System.Drawing.Size(937, 246);
            this.gbTruck.TabIndex = 43;
            this.gbTruck.TabStop = false;
            this.gbTruck.Text = "Truck";
            // 
            // nudNett
            // 
            this.nudNett.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsWBDockets, "Nett", true));
            this.nudNett.DecimalPlaces = 2;
            this.nudNett.Location = new System.Drawing.Point(667, 179);
            this.nudNett.Name = "nudNett";
            this.nudNett.ReadOnly = true;
            this.nudNett.Size = new System.Drawing.Size(98, 24);
            this.nudNett.TabIndex = 54;
            this.nudNett.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudGross
            // 
            this.nudGross.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsWBDockets, "Gross", true));
            this.nudGross.DecimalPlaces = 2;
            this.nudGross.Location = new System.Drawing.Point(667, 121);
            this.nudGross.Name = "nudGross";
            this.nudGross.Size = new System.Drawing.Size(99, 24);
            this.nudGross.TabIndex = 53;
            this.nudGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGross.Enter += new System.EventHandler(this.NumericUpDown_SelectAll);
            this.nudGross.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericUpDown_SelectAll);
            // 
            // nudTare
            // 
            this.nudTare.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsWBDockets, "Tare", true));
            this.nudTare.DecimalPlaces = 2;
            this.nudTare.Location = new System.Drawing.Point(667, 148);
            this.nudTare.Name = "nudTare";
            this.nudTare.Size = new System.Drawing.Size(98, 24);
            this.nudTare.TabIndex = 52;
            this.nudTare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTare.Enter += new System.EventHandler(this.NumericUpDown_SelectAll);
            this.nudTare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericUpDown_MouseUp);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "TruckOwner", true));
            this.textBox2.Location = new System.Drawing.Point(564, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(336, 24);
            this.textBox2.TabIndex = 48;
            // 
            // btnSetTruckConfig
            // 
            this.btnSetTruckConfig.Location = new System.Drawing.Point(527, 167);
            this.btnSetTruckConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetTruckConfig.Name = "btnSetTruckConfig";
            this.btnSetTruckConfig.Size = new System.Drawing.Size(55, 32);
            this.btnSetTruckConfig.TabIndex = 47;
            this.btnSetTruckConfig.Text = "Set";
            this.btnSetTruckConfig.UseVisualStyleBackColor = true;
            this.btnSetTruckConfig.Click += new System.EventHandler(this.btnSetTruckConfig_Click);
            // 
            // configuredTrucksDataGridView
            // 
            this.configuredTrucksDataGridView.AllowUserToAddRows = false;
            this.configuredTrucksDataGridView.AllowUserToDeleteRows = false;
            this.configuredTrucksDataGridView.AutoGenerateColumns = false;
            this.configuredTrucksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configuredTrucksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn12,
            this.Tare,
            this.MaxGVM});
            this.configuredTrucksDataGridView.DataSource = this.bsConfiguredTrucks;
            this.configuredTrucksDataGridView.Location = new System.Drawing.Point(6, 60);
            this.configuredTrucksDataGridView.Name = "configuredTrucksDataGridView";
            this.configuredTrucksDataGridView.ReadOnly = true;
            this.configuredTrucksDataGridView.Size = new System.Drawing.Size(489, 139);
            this.configuredTrucksDataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RegoTk";
            this.dataGridViewTextBoxColumn1.HeaderText = "RegoTk";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RegoTrailer";
            this.dataGridViewTextBoxColumn5.HeaderText = "RegoTrailer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "VehicleType";
            this.dataGridViewTextBoxColumn12.HeaderText = "Config";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // Tare
            // 
            this.Tare.DataPropertyName = "Tare";
            this.Tare.HeaderText = "Tare";
            this.Tare.Name = "Tare";
            this.Tare.ReadOnly = true;
            this.Tare.Width = 80;
            // 
            // MaxGVM
            // 
            this.MaxGVM.DataPropertyName = "MaxGVM";
            this.MaxGVM.HeaderText = "MaxGVM";
            this.MaxGVM.Name = "MaxGVM";
            this.MaxGVM.ReadOnly = true;
            this.MaxGVM.Width = 80;
            // 
            // bsConfiguredTrucks
            // 
            this.bsConfiguredTrucks.DataMember = "ConfiguredTrucks";
            this.bsConfiguredTrucks.DataSource = this.dsTruckConfig;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFindTruck
            // 
            this.btnFindTruck.Location = new System.Drawing.Point(367, 24);
            this.btnFindTruck.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindTruck.Name = "btnFindTruck";
            this.btnFindTruck.Size = new System.Drawing.Size(128, 32);
            this.btnFindTruck.TabIndex = 46;
            this.btnFindTruck.Text = "Find Truck";
            this.btnFindTruck.UseVisualStyleBackColor = true;
            this.btnFindTruck.Click += new System.EventHandler(this.btnFindTruck_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "TruckConfig", true));
            this.textBox1.Location = new System.Drawing.Point(317, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(43, 24);
            this.textBox1.TabIndex = 45;
            // 
            // btnGetDriver
            // 
            this.btnGetDriver.Location = new System.Drawing.Point(774, 59);
            this.btnGetDriver.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetDriver.Name = "btnGetDriver";
            this.btnGetDriver.Size = new System.Drawing.Size(128, 32);
            this.btnGetDriver.TabIndex = 44;
            this.btnGetDriver.Text = "Get Driver";
            this.btnGetDriver.UseVisualStyleBackColor = true;
            this.btnGetDriver.Click += new System.EventHandler(this.btnGetDriver_Click);
            // 
            // truckDriverTextBox
            // 
            this.truckDriverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "TruckDriver", true));
            this.truckDriverTextBox.Location = new System.Drawing.Point(566, 63);
            this.truckDriverTextBox.Name = "truckDriverTextBox";
            this.truckDriverTextBox.ReadOnly = true;
            this.truckDriverTextBox.Size = new System.Drawing.Size(199, 24);
            this.truckDriverTextBox.TabIndex = 39;
            // 
            // txtTruckRego
            // 
            this.txtTruckRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "TruckRego", true));
            this.txtTruckRego.Location = new System.Drawing.Point(211, 28);
            this.txtTruckRego.Name = "txtTruckRego";
            this.txtTruckRego.Size = new System.Drawing.Size(100, 24);
            this.txtTruckRego.TabIndex = 40;
            this.txtTruckRego.Leave += new System.EventHandler(this.txtTruckRego_Leave);
            // 
            // btnCalculateNett
            // 
            this.btnCalculateNett.Location = new System.Drawing.Point(774, 174);
            this.btnCalculateNett.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateNett.Name = "btnCalculateNett";
            this.btnCalculateNett.Size = new System.Drawing.Size(128, 32);
            this.btnCalculateNett.TabIndex = 38;
            this.btnCalculateNett.Text = "Calculate";
            this.btnCalculateNett.UseVisualStyleBackColor = true;
            this.btnCalculateNett.Click += new System.EventHandler(this.btnCalculateNett_Click);
            // 
            // bsBlanketAgreementCheck
            // 
            this.bsBlanketAgreementCheck.DataMember = "BlanketAgreementCheck";
            this.bsBlanketAgreementCheck.DataSource = this.dsBookIn;
            // 
            // dsBookIn
            // 
            this.dsBookIn.DataSetName = "dsBookIn";
            this.dsBookIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsItem
            // 
            this.bsItem.DataMember = "Item";
            this.bsItem.DataSource = this.dsBookIn;
            // 
            // taWBDockets
            // 
            this.taWBDockets.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StockpileBOMTableAdapter = null;
            this.tableAdapterManager.StockpileLotAllocationTableAdapter = null;
            this.tableAdapterManager.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager.TIQTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = this.taWBDocketLines;
            this.tableAdapterManager.WBDocketsTableAdapter = this.taWBDockets;
            // 
            // taWBDocketLines
            // 
            this.taWBDocketLines.ClearBeforeFill = true;
            // 
            // taItem
            // 
            this.taItem.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsBookInTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taBlanketAgreementCheck
            // 
            this.taBlanketAgreementCheck.ClearBeforeFill = true;
            // 
            // taConfiguredTrucks
            // 
            this.taConfiguredTrucks.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // HandwrittenDocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 799);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HandwrittenDocket";
            this.Text = "HandwrittenDocket";
            this.Load += new System.EventHandler(this.HandwrittenDocket_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbDocketLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wBDocketLinesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDocketLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbDocket.ResumeLayout(false);
            this.gbDocket.PerformLayout();
            this.gbTruck.ResumeLayout(false);
            this.gbTruck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuredTrucksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlanketAgreementCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSaveDocket;
        private System.Windows.Forms.Button btnCheck;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsWBDockets;
        private dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private dsTIQ2TableAdapters.WBDocketLinesTableAdapter taWBDocketLines;
        private System.Windows.Forms.BindingSource bsWBDocketLines;
        private System.Windows.Forms.TextBox contactMobileTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox txtCustON;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.DateTimePicker docDateDateTimePicker;
        private System.Windows.Forms.DataGridView wBDocketLinesDataGridView1;
        private System.Windows.Forms.Button btnGetItem;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource bsItem;
        private dsBookInTableAdapters.ItemTableAdapter taItem;
        private dsBookInTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bsBlanketAgreementCheck;
        private dsBookInTableAdapters.BlanketAgreementCheckTableAdapter taBlanketAgreementCheck;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculateNett;
        private System.Windows.Forms.TextBox truckDriverTextBox;
        private System.Windows.Forms.GroupBox gbDocket;
        private System.Windows.Forms.GroupBox gbTruck;
        private System.Windows.Forms.TextBox txtTruckRego;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Button btnGetDriver;
        private System.Windows.Forms.GroupBox gbDocketLines;
        private System.Windows.Forms.Button btnFindTruck;
        private System.Windows.Forms.TextBox textBox1;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource bsConfiguredTrucks;
        private dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter taConfiguredTrucks;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView configuredTrucksDataGridView;
        private System.Windows.Forms.Button btnSetTruckConfig;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox mtxtSAPOrderDocNum;
        private System.Windows.Forms.TextBox txtDocketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxGVM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.NumericUpDown nudTare;
        private System.Windows.Forms.NumericUpDown nudNett;
        private System.Windows.Forms.NumericUpDown nudGross;
    }
}