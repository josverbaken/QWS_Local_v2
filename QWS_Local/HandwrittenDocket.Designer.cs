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
            System.Windows.Forms.Label contactMobileLabel;
            System.Windows.Forms.Label itemCodeLabel;
            System.Windows.Forms.Label grossLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label nettLabel;
            System.Windows.Forms.Label agrNoLabel;
            System.Windows.Forms.Label truckDriverLabel;
            System.Windows.Forms.Label truckRegoLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label distanceLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.bsWBDockets = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.contactMobileTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.txtCustON = new System.Windows.Forms.TextBox();
            this.btnGetContact = new System.Windows.Forms.Button();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.gbDocket = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.btnSaveDocket = new System.Windows.Forms.Button();
            this.docDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbTruck = new System.Windows.Forms.GroupBox();
            this.btnGetDriver = new System.Windows.Forms.Button();
            this.truckDriverTextBox = new System.Windows.Forms.TextBox();
            this.txtTruckRego = new System.Windows.Forms.TextBox();
            this.btnCalculateNett = new System.Windows.Forms.Button();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtTare = new System.Windows.Forms.TextBox();
            this.txtNett = new System.Windows.Forms.TextBox();
            this.wBDocketLinesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsWBDocketLines = new System.Windows.Forms.BindingSource(this.components);
            this.agrNoTextBox = new System.Windows.Forms.TextBox();
            this.bsBlanketAgreementCheck = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.taWBDockets = new QWS_Local.dsTIQ2TableAdapters.WBDocketsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.taWBDocketLines = new QWS_Local.dsTIQ2TableAdapters.WBDocketLinesTableAdapter();
            this.taItem = new QWS_Local.dsBookInTableAdapters.ItemTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.taBlanketAgreementCheck = new QWS_Local.dsBookInTableAdapters.BlanketAgreementCheckTableAdapter();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDocketLines = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFindTruck = new System.Windows.Forms.Button();
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.taConfiguredTrucks = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
            this.tableAdapterManager2 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.configuredTrucksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            docNumLabel = new System.Windows.Forms.Label();
            cardNameLabel = new System.Windows.Forms.Label();
            purchaseOrderLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            contactMobileLabel = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            grossLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            nettLabel = new System.Windows.Forms.Label();
            agrNoLabel = new System.Windows.Forms.Label();
            truckDriverLabel = new System.Windows.Forms.Label();
            truckRegoLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            this.gbDocket.SuspendLayout();
            this.gbTruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wBDocketLinesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDocketLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlanketAgreementCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.gbDocketLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuredTrucksDataGridView)).BeginInit();
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
            contactNameLabel.Location = new System.Drawing.Point(23, 98);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(108, 18);
            contactNameLabel.TabIndex = 12;
            contactNameLabel.Text = "Contact Name:";
            // 
            // contactMobileLabel
            // 
            contactMobileLabel.AutoSize = true;
            contactMobileLabel.Location = new System.Drawing.Point(19, 128);
            contactMobileLabel.Name = "contactMobileLabel";
            contactMobileLabel.Size = new System.Drawing.Size(112, 18);
            contactMobileLabel.TabIndex = 14;
            contactMobileLabel.Text = "Contact Mobile:";
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(208, 31);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(80, 18);
            itemCodeLabel.TabIndex = 18;
            itemCodeLabel.Text = "Item Code:";
            // 
            // grossLabel
            // 
            grossLabel.AutoSize = true;
            grossLabel.Location = new System.Drawing.Point(79, 61);
            grossLabel.Name = "grossLabel";
            grossLabel.Size = new System.Drawing.Size(54, 18);
            grossLabel.TabIndex = 23;
            grossLabel.Text = "Gross:";
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(91, 91);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 18);
            tareLabel.TabIndex = 25;
            tareLabel.Text = "Tare:";
            // 
            // nettLabel
            // 
            nettLabel.AutoSize = true;
            nettLabel.Location = new System.Drawing.Point(94, 121);
            nettLabel.Name = "nettLabel";
            nettLabel.Size = new System.Drawing.Size(39, 18);
            nettLabel.TabIndex = 27;
            nettLabel.Text = "Nett:";
            // 
            // agrNoLabel
            // 
            agrNoLabel.AutoSize = true;
            agrNoLabel.Location = new System.Drawing.Point(619, 31);
            agrNoLabel.Name = "agrNoLabel";
            agrNoLabel.Size = new System.Drawing.Size(58, 18);
            agrNoLabel.TabIndex = 33;
            agrNoLabel.Text = "Agr No:";
            // 
            // truckDriverLabel
            // 
            truckDriverLabel.AutoSize = true;
            truckDriverLabel.Location = new System.Drawing.Point(509, 31);
            truckDriverLabel.Name = "truckDriverLabel";
            truckDriverLabel.Size = new System.Drawing.Size(51, 18);
            truckDriverLabel.TabIndex = 38;
            truckDriverLabel.Text = "Driver:";
            // 
            // truckRegoLabel
            // 
            truckRegoLabel.AutoSize = true;
            truckRegoLabel.Location = new System.Drawing.Point(43, 31);
            truckRegoLabel.Name = "truckRegoLabel";
            truckRegoLabel.Size = new System.Drawing.Size(90, 18);
            truckRegoLabel.TabIndex = 39;
            truckRegoLabel.Text = "Truck Rego:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(9, 158);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(122, 18);
            deliveryAddressLabel.TabIndex = 40;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new System.Drawing.Point(61, 192);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(70, 18);
            distanceLabel.TabIndex = 41;
            distanceLabel.Text = "Distance:";
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
            this.splitContainer1.Size = new System.Drawing.Size(1160, 773);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.btnGetOrder);
            this.gbCustomer.Controls.Add(this.cardNameTextBox);
            this.gbCustomer.Controls.Add(contactMobileLabel);
            this.gbCustomer.Controls.Add(this.contactMobileTextBox);
            this.gbCustomer.Controls.Add(distanceLabel);
            this.gbCustomer.Controls.Add(contactNameLabel);
            this.gbCustomer.Controls.Add(this.distanceTextBox);
            this.gbCustomer.Controls.Add(this.contactNameTextBox);
            this.gbCustomer.Controls.Add(deliveryAddressLabel);
            this.gbCustomer.Controls.Add(purchaseOrderLabel);
            this.gbCustomer.Controls.Add(this.deliveryAddressTextBox);
            this.gbCustomer.Controls.Add(this.txtCustON);
            this.gbCustomer.Controls.Add(cardNameLabel);
            this.gbCustomer.Controls.Add(this.btnGetContact);
            this.gbCustomer.Controls.Add(this.txtCardCode);
            this.gbCustomer.Controls.Add(this.btnGetCustomer);
            this.gbCustomer.Location = new System.Drawing.Point(51, 91);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(937, 241);
            this.gbCustomer.TabIndex = 45;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer | Order | Delivery Address";
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(638, 151);
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
            this.cardNameTextBox.Size = new System.Drawing.Size(200, 24);
            this.cardNameTextBox.TabIndex = 7;
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
            // contactMobileTextBox
            // 
            this.contactMobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "ContactMobile", true));
            this.contactMobileTextBox.Location = new System.Drawing.Point(137, 125);
            this.contactMobileTextBox.Name = "contactMobileTextBox";
            this.contactMobileTextBox.Size = new System.Drawing.Size(100, 24);
            this.contactMobileTextBox.TabIndex = 15;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "Distance", true));
            this.distanceTextBox.Location = new System.Drawing.Point(137, 189);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 24);
            this.distanceTextBox.TabIndex = 42;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "ContactName", true));
            this.contactNameTextBox.Location = new System.Drawing.Point(137, 95);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(200, 24);
            this.contactNameTextBox.TabIndex = 13;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(137, 155);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(457, 24);
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
            // btnGetContact
            // 
            this.btnGetContact.Location = new System.Drawing.Point(638, 91);
            this.btnGetContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetContact.Name = "btnGetContact";
            this.btnGetContact.Size = new System.Drawing.Size(128, 32);
            this.btnGetContact.TabIndex = 37;
            this.btnGetContact.Text = "Get Contact";
            this.btnGetContact.UseVisualStyleBackColor = true;
            this.btnGetContact.Click += new System.EventHandler(this.btnGetContact_Click);
            // 
            // txtCardCode
            // 
            this.txtCardCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "CardCode", true));
            this.txtCardCode.Location = new System.Drawing.Point(353, 35);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(100, 24);
            this.txtCardCode.TabIndex = 3;
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(638, 31);
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
            this.txtDocNum.TabIndex = 5;
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
            this.docDateDateTimePicker.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(504, 26);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 32);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gbTruck
            // 
            this.gbTruck.Controls.Add(this.configuredTrucksDataGridView);
            this.gbTruck.Controls.Add(this.btnFindTruck);
            this.gbTruck.Controls.Add(this.textBox1);
            this.gbTruck.Controls.Add(this.btnGetDriver);
            this.gbTruck.Controls.Add(this.truckDriverTextBox);
            this.gbTruck.Controls.Add(truckDriverLabel);
            this.gbTruck.Controls.Add(this.txtTruckRego);
            this.gbTruck.Controls.Add(truckRegoLabel);
            this.gbTruck.Controls.Add(this.btnCalculateNett);
            this.gbTruck.Controls.Add(this.txtGross);
            this.gbTruck.Controls.Add(grossLabel);
            this.gbTruck.Controls.Add(this.txtTare);
            this.gbTruck.Controls.Add(tareLabel);
            this.gbTruck.Controls.Add(this.txtNett);
            this.gbTruck.Controls.Add(nettLabel);
            this.gbTruck.Location = new System.Drawing.Point(51, 338);
            this.gbTruck.Name = "gbTruck";
            this.gbTruck.Size = new System.Drawing.Size(939, 312);
            this.gbTruck.TabIndex = 43;
            this.gbTruck.TabStop = false;
            this.gbTruck.Text = "Truck";
            // 
            // btnGetDriver
            // 
            this.btnGetDriver.Location = new System.Drawing.Point(774, 24);
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
            this.truckDriverTextBox.Location = new System.Drawing.Point(566, 28);
            this.truckDriverTextBox.Name = "truckDriverTextBox";
            this.truckDriverTextBox.Size = new System.Drawing.Size(200, 24);
            this.truckDriverTextBox.TabIndex = 39;
            // 
            // txtTruckRego
            // 
            this.txtTruckRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "TruckRego", true));
            this.txtTruckRego.Location = new System.Drawing.Point(139, 28);
            this.txtTruckRego.Name = "txtTruckRego";
            this.txtTruckRego.Size = new System.Drawing.Size(100, 24);
            this.txtTruckRego.TabIndex = 40;
            // 
            // btnCalculateNett
            // 
            this.btnCalculateNett.Location = new System.Drawing.Point(258, 114);
            this.btnCalculateNett.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateNett.Name = "btnCalculateNett";
            this.btnCalculateNett.Size = new System.Drawing.Size(128, 32);
            this.btnCalculateNett.TabIndex = 38;
            this.btnCalculateNett.Text = "Calculate";
            this.btnCalculateNett.UseVisualStyleBackColor = true;
            this.btnCalculateNett.Click += new System.EventHandler(this.btnCalculateNett_Click);
            // 
            // txtGross
            // 
            this.txtGross.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "Gross", true));
            this.txtGross.Location = new System.Drawing.Point(139, 58);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(100, 24);
            this.txtGross.TabIndex = 24;
            this.txtGross.Text = "23.40";
            // 
            // txtTare
            // 
            this.txtTare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "Tare", true));
            this.txtTare.Location = new System.Drawing.Point(139, 88);
            this.txtTare.Name = "txtTare";
            this.txtTare.Size = new System.Drawing.Size(100, 24);
            this.txtTare.TabIndex = 26;
            this.txtTare.Text = "10.0";
            // 
            // txtNett
            // 
            this.txtNett.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "Nett", true));
            this.txtNett.Location = new System.Drawing.Point(139, 118);
            this.txtNett.Name = "txtNett";
            this.txtNett.ReadOnly = true;
            this.txtNett.Size = new System.Drawing.Size(100, 24);
            this.txtNett.TabIndex = 28;
            this.txtNett.Text = "13.4";
            // 
            // wBDocketLinesDataGridView1
            // 
            this.wBDocketLinesDataGridView1.AutoGenerateColumns = false;
            this.wBDocketLinesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wBDocketLinesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60});
            this.wBDocketLinesDataGridView1.DataSource = this.bsWBDocketLines;
            this.wBDocketLinesDataGridView1.Location = new System.Drawing.Point(6, 69);
            this.wBDocketLinesDataGridView1.Name = "wBDocketLinesDataGridView1";
            this.wBDocketLinesDataGridView1.Size = new System.Drawing.Size(927, 169);
            this.wBDocketLinesDataGridView1.TabIndex = 22;
            // 
            // bsWBDocketLines
            // 
            this.bsWBDocketLines.DataMember = "FK_WBDocketLines_WBDockets";
            this.bsWBDocketLines.DataSource = this.bsWBDockets;
            // 
            // agrNoTextBox
            // 
            this.agrNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlanketAgreementCheck, "AgrNo", true));
            this.agrNoTextBox.Location = new System.Drawing.Point(683, 28);
            this.agrNoTextBox.Name = "agrNoTextBox";
            this.agrNoTextBox.Size = new System.Drawing.Size(100, 24);
            this.agrNoTextBox.TabIndex = 34;
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
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(414, 24);
            this.btnGetItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(128, 32);
            this.btnGetItem.TabIndex = 4;
            this.btnGetItem.Text = "Get Item";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.btnGetItem_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDocketLines, "ItemCode", true));
            this.txtItemCode.Location = new System.Drawing.Point(294, 28);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 24);
            this.txtItemCode.TabIndex = 19;
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
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn54.HeaderText = "ItemCode";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn55.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ItemQA";
            this.dataGridViewCheckBoxColumn2.HeaderText = "ItemQA";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "StockpileLot";
            this.dataGridViewTextBoxColumn57.HeaderText = "StockpileLot";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn58.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "AgrNo";
            this.dataGridViewTextBoxColumn61.HeaderText = "AgrNo";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "AgrLine";
            this.dataGridViewTextBoxColumn62.HeaderText = "AgrLine";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "DocNum";
            this.dataGridViewTextBoxColumn50.HeaderText = "DocNum";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "DocketLine";
            this.dataGridViewTextBoxColumn51.HeaderText = "DocketLine";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "WarehouseCode";
            this.dataGridViewTextBoxColumn52.HeaderText = "WarehouseCode";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "BaseEntry";
            this.dataGridViewTextBoxColumn53.HeaderText = "BaseEntry";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "ItmsGrpCod";
            this.dataGridViewTextBoxColumn56.HeaderText = "ItmsGrpCod";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "CreatedDTTM";
            this.dataGridViewTextBoxColumn59.HeaderText = "CreatedDTTM";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "SWW";
            this.dataGridViewTextBoxColumn60.HeaderText = "SWW";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            // 
            // gbDocketLines
            // 
            this.gbDocketLines.Controls.Add(this.wBDocketLinesDataGridView1);
            this.gbDocketLines.Controls.Add(this.btnGetItem);
            this.gbDocketLines.Controls.Add(this.txtItemCode);
            this.gbDocketLines.Controls.Add(itemCodeLabel);
            this.gbDocketLines.Controls.Add(agrNoLabel);
            this.gbDocketLines.Controls.Add(this.agrNoTextBox);
            this.gbDocketLines.Location = new System.Drawing.Point(51, 517);
            this.gbDocketLines.Name = "gbDocketLines";
            this.gbDocketLines.Size = new System.Drawing.Size(939, 244);
            this.gbDocketLines.TabIndex = 46;
            this.gbDocketLines.TabStop = false;
            this.gbDocketLines.Text = "Material | Cartage | Short Load Fee";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "TruckRego", true));
            this.textBox1.Location = new System.Drawing.Point(245, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 24);
            this.textBox1.TabIndex = 45;
            // 
            // btnFindTruck
            // 
            this.btnFindTruck.Location = new System.Drawing.Point(295, 24);
            this.btnFindTruck.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindTruck.Name = "btnFindTruck";
            this.btnFindTruck.Size = new System.Drawing.Size(128, 32);
            this.btnFindTruck.TabIndex = 46;
            this.btnFindTruck.Text = "Find Truck";
            this.btnFindTruck.UseVisualStyleBackColor = true;
            this.btnFindTruck.Click += new System.EventHandler(this.btnFindTruck_Click);
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsConfiguredTrucks
            // 
            this.bsConfiguredTrucks.DataMember = "ConfiguredTrucks";
            this.bsConfiguredTrucks.DataSource = this.dsTruckConfig;
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
            // configuredTrucksDataGridView
            // 
            this.configuredTrucksDataGridView.AutoGenerateColumns = false;
            this.configuredTrucksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configuredTrucksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewCheckBoxColumn7,
            this.dataGridViewTextBoxColumn28});
            this.configuredTrucksDataGridView.DataSource = this.bsConfiguredTrucks;
            this.configuredTrucksDataGridView.Location = new System.Drawing.Point(414, 72);
            this.configuredTrucksDataGridView.Name = "configuredTrucksDataGridView";
            this.configuredTrucksDataGridView.Size = new System.Drawing.Size(488, 101);
            this.configuredTrucksDataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RegoTk";
            this.dataGridViewTextBoxColumn1.HeaderText = "RegoTk";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegoTr1";
            this.dataGridViewTextBoxColumn2.HeaderText = "RegoTr1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RegoTr2";
            this.dataGridViewTextBoxColumn3.HeaderText = "RegoTr2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RegoTr3";
            this.dataGridViewTextBoxColumn4.HeaderText = "RegoTr3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RegoTrailer";
            this.dataGridViewTextBoxColumn5.HeaderText = "RegoTrailer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tare";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tare";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TareDT";
            this.dataGridViewTextBoxColumn7.HeaderText = "TareDT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ForceRetare";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ForceRetare";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "RetareEverytime";
            this.dataGridViewCheckBoxColumn3.HeaderText = "RetareEverytime";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TruckConfigID";
            this.dataGridViewTextBoxColumn8.HeaderText = "TruckConfigID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TruckTypeID";
            this.dataGridViewTextBoxColumn9.HeaderText = "TruckTypeID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NHVL";
            this.dataGridViewTextBoxColumn10.HeaderText = "NHVL";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AxleConfiguration";
            this.dataGridViewTextBoxColumn11.HeaderText = "AxleConfiguration";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "VehicleType";
            this.dataGridViewTextBoxColumn12.HeaderText = "VehicleType";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Axles";
            this.dataGridViewTextBoxColumn13.HeaderText = "Axles";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AxleGroups";
            this.dataGridViewTextBoxColumn14.HeaderText = "AxleGroups";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Compartments";
            this.dataGridViewTextBoxColumn15.HeaderText = "Compartments";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Vehicles";
            this.dataGridViewTextBoxColumn16.HeaderText = "Vehicles";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "VehicleDescription";
            this.dataGridViewTextBoxColumn17.HeaderText = "VehicleDescription";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Schematic";
            this.dataGridViewImageColumn1.HeaderText = "Schematic";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TruckOwner";
            this.dataGridViewTextBoxColumn18.HeaderText = "TruckOwner";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "CardCode";
            this.dataGridViewTextBoxColumn19.HeaderText = "CardCode";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CardType";
            this.dataGridViewTextBoxColumn20.HeaderText = "CardType";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "GroupCode";
            this.dataGridViewTextBoxColumn21.HeaderText = "GroupCode";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "CardStatus";
            this.dataGridViewTextBoxColumn22.HeaderText = "CardStatus";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "RegoCheck";
            this.dataGridViewCheckBoxColumn4.HeaderText = "RegoCheck";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "FeeCode";
            this.dataGridViewTextBoxColumn23.HeaderText = "FeeCode";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "FeeConditions";
            this.dataGridViewTextBoxColumn24.HeaderText = "FeeConditions";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "MaxGVM";
            this.dataGridViewTextBoxColumn25.HeaderText = "MaxGVM";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "MaxAxles";
            this.dataGridViewTextBoxColumn26.HeaderText = "MaxAxles";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "MassAccreditationLabel";
            this.dataGridViewTextBoxColumn27.HeaderText = "MassAccreditationLabel";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "ACCDelivery";
            this.dataGridViewCheckBoxColumn5.HeaderText = "ACCDelivery";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "ACCPickup";
            this.dataGridViewCheckBoxColumn6.HeaderText = "ACCPickup";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.DataPropertyName = "OverrideMinCart";
            this.dataGridViewCheckBoxColumn7.HeaderText = "OverrideMinCart";
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "TareTk";
            this.dataGridViewTextBoxColumn28.HeaderText = "TareTk";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // HandwrittenDocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 773);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HandwrittenDocket";
            this.Text = "HandwrittenDocket";
            this.Load += new System.EventHandler(this.HandwrittenDocket_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.gbDocket.ResumeLayout(false);
            this.gbDocket.PerformLayout();
            this.gbTruck.ResumeLayout(false);
            this.gbTruck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wBDocketLinesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDocketLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlanketAgreementCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.gbDocketLines.ResumeLayout(false);
            this.gbDocketLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuredTrucksDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox contactMobileTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox txtCustON;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.DateTimePicker docDateDateTimePicker;
        private System.Windows.Forms.DataGridView wBDocketLinesDataGridView1;
        private System.Windows.Forms.TextBox txtNett;
        private System.Windows.Forms.TextBox txtTare;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Button btnGetItem;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource bsItem;
        private dsBookInTableAdapters.ItemTableAdapter taItem;
        private dsBookInTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bsBlanketAgreementCheck;
        private dsBookInTableAdapters.BlanketAgreementCheckTableAdapter taBlanketAgreementCheck;
        private System.Windows.Forms.TextBox agrNoTextBox;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculateNett;
        private System.Windows.Forms.Button btnGetContact;
        private System.Windows.Forms.TextBox truckDriverTextBox;
        private System.Windows.Forms.GroupBox gbDocket;
        private System.Windows.Forms.GroupBox gbTruck;
        private System.Windows.Forms.TextBox txtTruckRego;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Button btnGetDriver;
        private System.Windows.Forms.GroupBox gbDocketLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.Button btnFindTruck;
        private System.Windows.Forms.TextBox textBox1;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource bsConfiguredTrucks;
        private dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter taConfiguredTrucks;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView configuredTrucksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
    }
}