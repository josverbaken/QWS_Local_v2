
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.exBinOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.exBinOrdersTableAdapter = new QWS_Local.dsBookInTableAdapters.ExBinOrdersTableAdapter();
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
            this.sAPCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAPUpdateDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtCardCode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1070, 450);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 0;
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
            this.sAPCommentsDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.itemQADataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.openQtyDataGridViewTextBoxColumn,
            this.suppliedDataGridViewTextBoxColumn,
            this.sAPUpdateDTTMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exBinOrdersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(930, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(23, 39);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(100, 20);
            this.txtCardCode.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(23, 88);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            // exBinOrdersTableAdapter
            // 
            this.exBinOrdersTableAdapter.ClearBeforeFill = true;
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
            // sAPUpdateDTTMDataGridViewTextBoxColumn
            // 
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.DataPropertyName = "SAPUpdateDTTM";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.HeaderText = "SAPUpdateDTTM";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.Name = "sAPUpdateDTTMDataGridViewTextBoxColumn";
            this.sAPUpdateDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookInExBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BookInExBin";
            this.Text = "BookInExBin";
            this.Load += new System.EventHandler(this.BookInExBin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exBinOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sAPCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAPUpdateDTTMDataGridViewTextBoxColumn;
    }
}