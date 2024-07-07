namespace QWS_Local
{
    partial class PrintDocket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label docDateLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnRefreshDockets = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpDocket = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGetDocket = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPrintDocket = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Overload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckRegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overloadPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overloadDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wBModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDocketList = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWS = new QWS_Local.dsQWSViews();
            this.docketListTableAdapter = new QWS_Local.dsQWSViewsTableAdapters.DocketListTableAdapter();
            this.dtpDocketList = new System.Windows.Forms.DateTimePicker();
            this.btnGetDocketList = new System.Windows.Forms.Button();
            this.tableAdapterManager = new QWS_Local.dsQWSViewsTableAdapters.TableAdapterManager();
            this.docNumTextBox = new System.Windows.Forms.TextBox();
            docDateLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpDocket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocketList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDocket);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.splitContainer2);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Margin = new System.Windows.Forms.Padding(4);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(4);
            this.tpList.Size = new System.Drawing.Size(1192, 592);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.docNumTextBox);
            this.splitContainer2.Panel1.Controls.Add(docDateLabel);
            this.splitContainer2.Panel1.Controls.Add(this.btnGetDocketList);
            this.splitContainer2.Panel1.Controls.Add(this.dtpDocketList);
            this.splitContainer2.Panel1.Controls.Add(this.btnRefreshDockets);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(1184, 584);
            this.splitContainer2.SplitterDistance = 214;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnRefreshDockets
            // 
            this.btnRefreshDockets.Location = new System.Drawing.Point(39, 131);
            this.btnRefreshDockets.Name = "btnRefreshDockets";
            this.btnRefreshDockets.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDockets.TabIndex = 0;
            this.btnRefreshDockets.Text = "Refresh";
            this.btnRefreshDockets.UseVisualStyleBackColor = true;
            this.btnRefreshDockets.Click += new System.EventHandler(this.btnRefreshDockets_Click);
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
            this.truckRegoDataGridViewTextBoxColumn,
            this.grossDataGridViewTextBoxColumn,
            this.Overload,
            this.cardNameDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.tareDataGridViewTextBoxColumn,
            this.nettDataGridViewTextBoxColumn,
            this.overloadPointsDataGridViewTextBoxColumn,
            this.overloadDescDataGridViewTextBoxColumn,
            this.wBModeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsDocketList;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(966, 584);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpDocket
            // 
            this.tpDocket.Controls.Add(this.splitContainer1);
            this.tpDocket.Location = new System.Drawing.Point(4, 27);
            this.tpDocket.Margin = new System.Windows.Forms.Padding(4);
            this.tpDocket.Name = "tpDocket";
            this.tpDocket.Padding = new System.Windows.Forms.Padding(4);
            this.tpDocket.Size = new System.Drawing.Size(1192, 592);
            this.tpDocket.TabIndex = 1;
            this.tpDocket.Text = "Docket";
            this.tpDocket.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnGetDocket);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrintDocket);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 584);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnGetDocket
            // 
            this.btnGetDocket.Location = new System.Drawing.Point(44, 168);
            this.btnGetDocket.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetDocket.Name = "btnGetDocket";
            this.btnGetDocket.Size = new System.Drawing.Size(150, 32);
            this.btnGetDocket.TabIndex = 2;
            this.btnGetDocket.Text = "Find";
            this.btnGetDocket.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 24);
            this.textBox1.TabIndex = 1;
            // 
            // btnPrintDocket
            // 
            this.btnPrintDocket.Location = new System.Drawing.Point(44, 238);
            this.btnPrintDocket.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintDocket.Name = "btnPrintDocket";
            this.btnPrintDocket.Size = new System.Drawing.Size(150, 32);
            this.btnPrintDocket.TabIndex = 0;
            this.btnPrintDocket.Text = "Print";
            this.btnPrintDocket.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QWS_Local.DocketRpt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(898, 584);
            this.reportViewer1.TabIndex = 1;
            // 
            // Overload
            // 
            this.Overload.DataPropertyName = "Overload";
            this.Overload.HeaderText = "Overload";
            this.Overload.Name = "Overload";
            this.Overload.ReadOnly = true;
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "Docket";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            this.docNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docDateDataGridViewTextBoxColumn
            // 
            this.docDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.docDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.docDateDataGridViewTextBoxColumn.HeaderText = "Time";
            this.docDateDataGridViewTextBoxColumn.Name = "docDateDataGridViewTextBoxColumn";
            this.docDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // truckRegoDataGridViewTextBoxColumn
            // 
            this.truckRegoDataGridViewTextBoxColumn.DataPropertyName = "TruckRego";
            this.truckRegoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.truckRegoDataGridViewTextBoxColumn.Name = "truckRegoDataGridViewTextBoxColumn";
            this.truckRegoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossDataGridViewTextBoxColumn
            // 
            this.grossDataGridViewTextBoxColumn.DataPropertyName = "Gross";
            this.grossDataGridViewTextBoxColumn.HeaderText = "Gross";
            this.grossDataGridViewTextBoxColumn.Name = "grossDataGridViewTextBoxColumn";
            this.grossDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardNameDataGridViewTextBoxColumn
            // 
            this.cardNameDataGridViewTextBoxColumn.DataPropertyName = "CardName";
            this.cardNameDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.cardNameDataGridViewTextBoxColumn.Name = "cardNameDataGridViewTextBoxColumn";
            this.cardNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "Material";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "MaterialDesc";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tareDataGridViewTextBoxColumn
            // 
            this.tareDataGridViewTextBoxColumn.DataPropertyName = "Tare";
            this.tareDataGridViewTextBoxColumn.HeaderText = "Tare";
            this.tareDataGridViewTextBoxColumn.Name = "tareDataGridViewTextBoxColumn";
            this.tareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nettDataGridViewTextBoxColumn
            // 
            this.nettDataGridViewTextBoxColumn.DataPropertyName = "Nett";
            this.nettDataGridViewTextBoxColumn.HeaderText = "Nett";
            this.nettDataGridViewTextBoxColumn.Name = "nettDataGridViewTextBoxColumn";
            this.nettDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overloadPointsDataGridViewTextBoxColumn
            // 
            this.overloadPointsDataGridViewTextBoxColumn.DataPropertyName = "OverloadPoints";
            this.overloadPointsDataGridViewTextBoxColumn.HeaderText = "OverloadPoints";
            this.overloadPointsDataGridViewTextBoxColumn.Name = "overloadPointsDataGridViewTextBoxColumn";
            this.overloadPointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overloadDescDataGridViewTextBoxColumn
            // 
            this.overloadDescDataGridViewTextBoxColumn.DataPropertyName = "OverloadDesc";
            this.overloadDescDataGridViewTextBoxColumn.HeaderText = "OverloadDesc";
            this.overloadDescDataGridViewTextBoxColumn.Name = "overloadDescDataGridViewTextBoxColumn";
            this.overloadDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wBModeDataGridViewTextBoxColumn
            // 
            this.wBModeDataGridViewTextBoxColumn.DataPropertyName = "WBMode";
            this.wBModeDataGridViewTextBoxColumn.HeaderText = "WBMode";
            this.wBModeDataGridViewTextBoxColumn.Name = "wBModeDataGridViewTextBoxColumn";
            this.wBModeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDocketList
            // 
            this.bsDocketList.DataMember = "DocketList";
            this.bsDocketList.DataSource = this.dsQWS;
            // 
            // dsQWS
            // 
            this.dsQWS.DataSetName = "dsQWSViews";
            this.dsQWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docketListTableAdapter
            // 
            this.docketListTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDocketList
            // 
            this.dtpDocketList.Location = new System.Drawing.Point(4, 233);
            this.dtpDocketList.Name = "dtpDocketList";
            this.dtpDocketList.Size = new System.Drawing.Size(200, 24);
            this.dtpDocketList.TabIndex = 1;
            // 
            // btnGetDocketList
            // 
            this.btnGetDocketList.Location = new System.Drawing.Point(4, 276);
            this.btnGetDocketList.Name = "btnGetDocketList";
            this.btnGetDocketList.Size = new System.Drawing.Size(200, 23);
            this.btnGetDocketList.TabIndex = 2;
            this.btnGetDocketList.Text = "Get List";
            this.btnGetDocketList.UseVisualStyleBackColor = true;
            this.btnGetDocketList.Click += new System.EventHandler(this.btnGetDocketList_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSViewsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // docDateLabel
            // 
            docDateLabel.AutoSize = true;
            docDateLabel.Location = new System.Drawing.Point(11, 350);
            docDateLabel.Name = "docDateLabel";
            docDateLabel.Size = new System.Drawing.Size(75, 18);
            docDateLabel.TabIndex = 3;
            docDateLabel.Text = "Doc Date:";
            // 
            // docNumTextBox
            // 
            this.docNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocketList, "DocDate", true));
            this.docNumTextBox.Location = new System.Drawing.Point(4, 381);
            this.docNumTextBox.Name = "docNumTextBox";
            this.docNumTextBox.Size = new System.Drawing.Size(200, 24);
            this.docNumTextBox.TabIndex = 6;
            // 
            // PrintDocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintDocket";
            this.Text = "PrintDocket";
            this.Load += new System.EventHandler(this.PrintDocket_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpDocket.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocketList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDocket;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGetDocket;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPrintDocket;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnRefreshDockets;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsQWSViewsTableAdapters.DocketListTableAdapter docketListTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsQWSViews dsQWS;
        private System.Windows.Forms.BindingSource bsDocketList;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckRegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overload;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overloadPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overloadDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wBModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGetDocketList;
        private System.Windows.Forms.DateTimePicker dtpDocketList;
        private System.Windows.Forms.TextBox docNumTextBox;
        private dsQWSViewsTableAdapters.TableAdapterManager tableAdapterManager;
    }
}