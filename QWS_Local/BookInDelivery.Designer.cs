
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsDeliveryOrders = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.taDeliveryOrders = new QWS_Local.dsBookInTableAdapters.DeliveryOrdersAllTableAdapter();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAPUpdateDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 450);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(26, 63);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.OrderStatus,
            this.cardCodeDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.purchaseOrderDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactMobileDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.mapRefDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.itemQADataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.openQtyDataGridViewTextBoxColumn,
            this.suppliedDataGridViewTextBoxColumn,
            this.cartageCodeDataGridViewTextBoxColumn,
            this.sAPUpdateDTTMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsDeliveryOrders;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(873, 450);
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
            // taDeliveryOrders
            // 
            this.taDeliveryOrders.ClearBeforeFill = true;
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
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "OrderStatus";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
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
            // sAPUpdateDTTMDataGridViewTextBoxColumn
            // 
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.DataPropertyName = "SAPUpdateDTTM";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.HeaderText = "SAPUpdateDTTM";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.Name = "sAPUpdateDTTMDataGridViewTextBoxColumn";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookInDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BookInDelivery";
            this.Text = "BookInDelivery";
            this.Load += new System.EventHandler(this.BookInDelivery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource bsDeliveryOrders;
        private dsBookInTableAdapters.DeliveryOrdersAllTableAdapter taDeliveryOrders;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAPUpdateDTTMDataGridViewTextBoxColumn;
    }
}