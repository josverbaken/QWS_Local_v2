
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
            System.Windows.Forms.Label docDateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label openQtyLabel;
            System.Windows.Forms.Label suppliedLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.rbTnT = new System.Windows.Forms.RadioButton();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.deliveryOrdersAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryOrdersAllTableAdapter = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntctCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAPCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itmsGrpCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAPUpdateDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHVRRouteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHVRNetworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHVRMassLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHVRConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHVRCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryOrdersAllTableAdapter1 = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.tableAdapterManager = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.docNumTextBox = new System.Windows.Forms.TextBox();
            this.docDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialCodeTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.openQtyTextBox = new System.Windows.Forms.TextBox();
            this.suppliedTextBox = new System.Windows.Forms.TextBox();
            docNumLabel = new System.Windows.Forms.Label();
            docDateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            openQtyLabel = new System.Windows.Forms.Label();
            suppliedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersAllBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            this.tpDetails.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docNumDataGridViewTextBoxColumn,
            this.docDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.purchaseOrderDataGridViewTextBoxColumn,
            this.cntctCodeDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactMobileDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.mapRefDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.sAPCommentsDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.itmsGrpCodDataGridViewTextBoxColumn,
            this.itemQADataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.openQtyDataGridViewTextBoxColumn,
            this.suppliedDataGridViewTextBoxColumn,
            this.cartageCodeDataGridViewTextBoxColumn,
            this.cartageDataGridViewTextBoxColumn,
            this.sAPUpdateDTTMDataGridViewTextBoxColumn,
            this.nHVRRouteIDDataGridViewTextBoxColumn,
            this.nHVRNetworkDataGridViewTextBoxColumn,
            this.nHVRMassLimitDataGridViewTextBoxColumn,
            this.nHVRConditionDataGridViewTextBoxColumn,
            this.nHVRCommentDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryOrdersAllBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(849, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsBookIn
            // 
            this.dsBookIn.DataSetName = "dsBookIn";
            this.dsBookIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryOrdersAllBindingSource
            // 
            this.deliveryOrdersAllBindingSource.DataMember = "DeliveryOrdersAll";
            this.deliveryOrdersAllBindingSource.DataSource = this.dsBookIn;
            // 
            // deliveryOrdersAllTableAdapter
            // 
            this.deliveryOrdersAllTableAdapter.ClearBeforeFill = true;
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "DocNum";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            this.docNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docDateDataGridViewTextBoxColumn
            // 
            this.docDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate";
            this.docDateDataGridViewTextBoxColumn.HeaderText = "DocDate";
            this.docDateDataGridViewTextBoxColumn.Name = "docDateDataGridViewTextBoxColumn";
            this.docDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            this.cardCodeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.purchaseOrderDataGridViewTextBoxColumn.HeaderText = "PurchaseOrder";
            this.purchaseOrderDataGridViewTextBoxColumn.Name = "purchaseOrderDataGridViewTextBoxColumn";
            this.purchaseOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntctCodeDataGridViewTextBoxColumn
            // 
            this.cntctCodeDataGridViewTextBoxColumn.DataPropertyName = "CntctCode";
            this.cntctCodeDataGridViewTextBoxColumn.HeaderText = "CntctCode";
            this.cntctCodeDataGridViewTextBoxColumn.Name = "cntctCodeDataGridViewTextBoxColumn";
            this.cntctCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactMobileDataGridViewTextBoxColumn
            // 
            this.contactMobileDataGridViewTextBoxColumn.DataPropertyName = "ContactMobile";
            this.contactMobileDataGridViewTextBoxColumn.HeaderText = "ContactMobile";
            this.contactMobileDataGridViewTextBoxColumn.Name = "contactMobileDataGridViewTextBoxColumn";
            this.contactMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mapRefDataGridViewTextBoxColumn
            // 
            this.mapRefDataGridViewTextBoxColumn.DataPropertyName = "MapRef";
            this.mapRefDataGridViewTextBoxColumn.HeaderText = "MapRef";
            this.mapRefDataGridViewTextBoxColumn.Name = "mapRefDataGridViewTextBoxColumn";
            this.mapRefDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAPCommentsDataGridViewTextBoxColumn
            // 
            this.sAPCommentsDataGridViewTextBoxColumn.DataPropertyName = "SAPComments";
            this.sAPCommentsDataGridViewTextBoxColumn.HeaderText = "SAPComments";
            this.sAPCommentsDataGridViewTextBoxColumn.Name = "sAPCommentsDataGridViewTextBoxColumn";
            this.sAPCommentsDataGridViewTextBoxColumn.ReadOnly = true;
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
            // itmsGrpCodDataGridViewTextBoxColumn
            // 
            this.itmsGrpCodDataGridViewTextBoxColumn.DataPropertyName = "ItmsGrpCod";
            this.itmsGrpCodDataGridViewTextBoxColumn.HeaderText = "ItmsGrpCod";
            this.itmsGrpCodDataGridViewTextBoxColumn.Name = "itmsGrpCodDataGridViewTextBoxColumn";
            this.itmsGrpCodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemQADataGridViewTextBoxColumn
            // 
            this.itemQADataGridViewTextBoxColumn.DataPropertyName = "ItemQA";
            this.itemQADataGridViewTextBoxColumn.HeaderText = "ItemQA";
            this.itemQADataGridViewTextBoxColumn.Name = "itemQADataGridViewTextBoxColumn";
            this.itemQADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openQtyDataGridViewTextBoxColumn
            // 
            this.openQtyDataGridViewTextBoxColumn.DataPropertyName = "OpenQty";
            this.openQtyDataGridViewTextBoxColumn.HeaderText = "OpenQty";
            this.openQtyDataGridViewTextBoxColumn.Name = "openQtyDataGridViewTextBoxColumn";
            this.openQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliedDataGridViewTextBoxColumn
            // 
            this.suppliedDataGridViewTextBoxColumn.DataPropertyName = "Supplied";
            this.suppliedDataGridViewTextBoxColumn.HeaderText = "Supplied";
            this.suppliedDataGridViewTextBoxColumn.Name = "suppliedDataGridViewTextBoxColumn";
            this.suppliedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartageCodeDataGridViewTextBoxColumn
            // 
            this.cartageCodeDataGridViewTextBoxColumn.DataPropertyName = "CartageCode";
            this.cartageCodeDataGridViewTextBoxColumn.HeaderText = "CartageCode";
            this.cartageCodeDataGridViewTextBoxColumn.Name = "cartageCodeDataGridViewTextBoxColumn";
            this.cartageCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartageDataGridViewTextBoxColumn
            // 
            this.cartageDataGridViewTextBoxColumn.DataPropertyName = "Cartage";
            this.cartageDataGridViewTextBoxColumn.HeaderText = "Cartage";
            this.cartageDataGridViewTextBoxColumn.Name = "cartageDataGridViewTextBoxColumn";
            this.cartageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAPUpdateDTTMDataGridViewTextBoxColumn
            // 
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.DataPropertyName = "SAPUpdateDTTM";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.HeaderText = "SAPUpdateDTTM";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.Name = "sAPUpdateDTTMDataGridViewTextBoxColumn";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHVRRouteIDDataGridViewTextBoxColumn
            // 
            this.nHVRRouteIDDataGridViewTextBoxColumn.DataPropertyName = "NHVR_RouteID";
            this.nHVRRouteIDDataGridViewTextBoxColumn.HeaderText = "NHVR_RouteID";
            this.nHVRRouteIDDataGridViewTextBoxColumn.Name = "nHVRRouteIDDataGridViewTextBoxColumn";
            this.nHVRRouteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHVRNetworkDataGridViewTextBoxColumn
            // 
            this.nHVRNetworkDataGridViewTextBoxColumn.DataPropertyName = "NHVR_Network";
            this.nHVRNetworkDataGridViewTextBoxColumn.HeaderText = "NHVR_Network";
            this.nHVRNetworkDataGridViewTextBoxColumn.Name = "nHVRNetworkDataGridViewTextBoxColumn";
            this.nHVRNetworkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHVRMassLimitDataGridViewTextBoxColumn
            // 
            this.nHVRMassLimitDataGridViewTextBoxColumn.DataPropertyName = "NHVR_MassLimit";
            this.nHVRMassLimitDataGridViewTextBoxColumn.HeaderText = "NHVR_MassLimit";
            this.nHVRMassLimitDataGridViewTextBoxColumn.Name = "nHVRMassLimitDataGridViewTextBoxColumn";
            this.nHVRMassLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHVRConditionDataGridViewTextBoxColumn
            // 
            this.nHVRConditionDataGridViewTextBoxColumn.DataPropertyName = "NHVR_Condition";
            this.nHVRConditionDataGridViewTextBoxColumn.HeaderText = "NHVR_Condition";
            this.nHVRConditionDataGridViewTextBoxColumn.Name = "nHVRConditionDataGridViewTextBoxColumn";
            this.nHVRConditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHVRCommentDataGridViewTextBoxColumn
            // 
            this.nHVRCommentDataGridViewTextBoxColumn.DataPropertyName = "NHVR_Comment";
            this.nHVRCommentDataGridViewTextBoxColumn.HeaderText = "NHVR_Comment";
            this.nHVRCommentDataGridViewTextBoxColumn.Name = "nHVRCommentDataGridViewTextBoxColumn";
            this.nHVRCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryOrdersAllTableAdapter1
            // 
            this.deliveryOrdersAllTableAdapter1.ClearBeforeFill = true;
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
            // tpDetails
            // 
            this.tpDetails.Controls.Add(suppliedLabel);
            this.tpDetails.Controls.Add(this.suppliedTextBox);
            this.tpDetails.Controls.Add(openQtyLabel);
            this.tpDetails.Controls.Add(this.openQtyTextBox);
            this.tpDetails.Controls.Add(quantityLabel);
            this.tpDetails.Controls.Add(this.quantityTextBox);
            this.tpDetails.Controls.Add(materialLabel);
            this.tpDetails.Controls.Add(this.materialTextBox);
            this.tpDetails.Controls.Add(this.materialCodeTextBox);
            this.tpDetails.Controls.Add(deliveryDateLabel);
            this.tpDetails.Controls.Add(this.deliveryDateDateTimePicker);
            this.tpDetails.Controls.Add(docDateLabel);
            this.tpDetails.Controls.Add(this.docDateDateTimePicker);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsBookInTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // docNumTextBox
            // 
            this.docNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOrdersAllBindingSource, "DocNum", true));
            this.docNumTextBox.Location = new System.Drawing.Point(139, 34);
            this.docNumTextBox.Name = "docNumTextBox";
            this.docNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.docNumTextBox.TabIndex = 1;
            // 
            // docDateLabel
            // 
            docDateLabel.AutoSize = true;
            docDateLabel.Location = new System.Drawing.Point(62, 67);
            docDateLabel.Name = "docDateLabel";
            docDateLabel.Size = new System.Drawing.Size(71, 17);
            docDateLabel.TabIndex = 2;
            docDateLabel.Text = "Doc Date:";
            // 
            // docDateDateTimePicker
            // 
            this.docDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryOrdersAllBindingSource, "DocDate", true));
            this.docDateDateTimePicker.Location = new System.Drawing.Point(139, 63);
            this.docDateDateTimePicker.Name = "docDateDateTimePicker";
            this.docDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.docDateDateTimePicker.TabIndex = 3;
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(36, 96);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(97, 17);
            deliveryDateLabel.TabIndex = 4;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryOrdersAllBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(139, 92);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.deliveryDateDateTimePicker.TabIndex = 5;
            // 
            // materialCodeTextBox
            // 
            this.materialCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOrdersAllBindingSource, "MaterialCode", true));
            this.materialCodeTextBox.Location = new System.Drawing.Point(139, 121);
            this.materialCodeTextBox.Name = "materialCodeTextBox";
            this.materialCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.materialCodeTextBox.TabIndex = 7;
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
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOrdersAllBindingSource, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(245, 121);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(217, 23);
            this.materialTextBox.TabIndex = 9;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(68, 153);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(65, 17);
            quantityLabel.TabIndex = 10;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOrdersAllBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(139, 150);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 11;
            // 
            // openQtyLabel
            // 
            openQtyLabel.AutoSize = true;
            openQtyLabel.Location = new System.Drawing.Point(60, 182);
            openQtyLabel.Name = "openQtyLabel";
            openQtyLabel.Size = new System.Drawing.Size(73, 17);
            openQtyLabel.TabIndex = 12;
            openQtyLabel.Text = "Open Qty:";
            // 
            // openQtyTextBox
            // 
            this.openQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOrdersAllBindingSource, "OpenQty", true));
            this.openQtyTextBox.Location = new System.Drawing.Point(139, 179);
            this.openQtyTextBox.Name = "openQtyTextBox";
            this.openQtyTextBox.Size = new System.Drawing.Size(100, 23);
            this.openQtyTextBox.TabIndex = 13;
            // 
            // suppliedLabel
            // 
            suppliedLabel.AutoSize = true;
            suppliedLabel.Location = new System.Drawing.Point(66, 211);
            suppliedLabel.Name = "suppliedLabel";
            suppliedLabel.Size = new System.Drawing.Size(67, 17);
            suppliedLabel.TabIndex = 14;
            suppliedLabel.Text = "Supplied:";
            // 
            // suppliedTextBox
            // 
            this.suppliedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryOrdersAllBindingSource, "Supplied", true));
            this.suppliedTextBox.Location = new System.Drawing.Point(139, 208);
            this.suppliedTextBox.Name = "suppliedTextBox";
            this.suppliedTextBox.Size = new System.Drawing.Size(100, 23);
            this.suppliedTextBox.TabIndex = 15;
            // 
            // DeliveryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeliveryOrders";
            this.Text = "DeliveryOrders";
            this.Load += new System.EventHandler(this.DeliveryOrders_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersAllBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource deliveryOrdersAllBindingSource;
        private dsBookInTableAdapters.DeliveryOrdersAllTableAdapter deliveryOrdersAllTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntctCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAPCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmsGrpCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAPUpdateDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVRRouteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVRNetworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVRMassLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVRConditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVRCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox suppliedTextBox;
        private System.Windows.Forms.TextBox openQtyTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox materialCodeTextBox;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker docDateDateTimePicker;
        private System.Windows.Forms.TextBox docNumTextBox;
        private dsBookInTableAdapters.DeliveryOrdersAllTableAdapter deliveryOrdersAllTableAdapter1;
        private dsBookInTableAdapters.TableAdapterManager tableAdapterManager;
    }
}