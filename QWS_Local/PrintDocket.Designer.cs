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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsDeliveryDocket = new System.Windows.Forms.BindingSource(this.components);
            this.dsDocketReport = new QWS_Local.dsDocketReport();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnGetDocketList = new System.Windows.Forms.Button();
            this.dtpDocketList = new System.Windows.Forms.DateTimePicker();
            this.dgvDocketList = new System.Windows.Forms.DataGridView();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turnaround = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckRegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overload = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tpDocket = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetDocket = new System.Windows.Forms.Button();
            this.txtDocketNo = new System.Windows.Forms.TextBox();
            this.btnPrintDocket = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.taDeliveryDocket = new QWS_Local.dsDocketReportTableAdapters.DeliveryDocketTableAdapter();
            this.taDocketList = new QWS_Local.dsQWSViewsTableAdapters.DocketListTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSViewsTableAdapters.TableAdapterManager();
            this.txtRegoFilter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFilter = new System.Windows.Forms.RadioButton();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryDocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDocketReport)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocketList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocketList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWS)).BeginInit();
            this.tpDocket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsDeliveryDocket
            // 
            this.bsDeliveryDocket.DataMember = "DeliveryDocket";
            this.bsDeliveryDocket.DataSource = this.dsDocketReport;
            // 
            // dsDocketReport
            // 
            this.dsDocketReport.DataSetName = "dsDocketReport";
            this.dsDocketReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.btnPrintPreview);
            this.splitContainer2.Panel1.Controls.Add(this.btnGetDocketList);
            this.splitContainer2.Panel1.Controls.Add(this.dtpDocketList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvDocketList);
            this.splitContainer2.Size = new System.Drawing.Size(1184, 584);
            this.splitContainer2.SplitterDistance = 214;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 24);
            this.textBox2.TabIndex = 8;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(4, 268);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(200, 52);
            this.btnPrintPreview.TabIndex = 7;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnGetDocketList
            // 
            this.btnGetDocketList.Location = new System.Drawing.Point(4, 133);
            this.btnGetDocketList.Name = "btnGetDocketList";
            this.btnGetDocketList.Size = new System.Drawing.Size(200, 52);
            this.btnGetDocketList.TabIndex = 2;
            this.btnGetDocketList.Text = "Get List";
            this.btnGetDocketList.UseVisualStyleBackColor = true;
            this.btnGetDocketList.Click += new System.EventHandler(this.btnGetDocketList_Click);
            // 
            // dtpDocketList
            // 
            this.dtpDocketList.Location = new System.Drawing.Point(4, 90);
            this.dtpDocketList.Name = "dtpDocketList";
            this.dtpDocketList.Size = new System.Drawing.Size(200, 24);
            this.dtpDocketList.TabIndex = 1;
            // 
            // dgvDocketList
            // 
            this.dgvDocketList.AllowUserToAddRows = false;
            this.dgvDocketList.AllowUserToDeleteRows = false;
            this.dgvDocketList.AutoGenerateColumns = false;
            this.dgvDocketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocketList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docNumDataGridViewTextBoxColumn,
            this.ProcessStatus,
            this.docDateDataGridViewTextBoxColumn,
            this.Turnaround,
            this.truckRegoDataGridViewTextBoxColumn,
            this.Driver,
            this.DriverMobile,
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
            this.dgvDocketList.DataSource = this.bsDocketList;
            this.dgvDocketList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocketList.Location = new System.Drawing.Point(0, 0);
            this.dgvDocketList.Name = "dgvDocketList";
            this.dgvDocketList.ReadOnly = true;
            this.dgvDocketList.Size = new System.Drawing.Size(966, 584);
            this.dgvDocketList.TabIndex = 0;
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "Docket";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            this.docNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProcessStatus
            // 
            this.ProcessStatus.DataPropertyName = "ProcessStatus";
            this.ProcessStatus.HeaderText = "Status";
            this.ProcessStatus.Name = "ProcessStatus";
            this.ProcessStatus.ReadOnly = true;
            this.ProcessStatus.Width = 60;
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
            // Turnaround
            // 
            this.Turnaround.DataPropertyName = "Turnaround";
            this.Turnaround.HeaderText = "Turnaround";
            this.Turnaround.Name = "Turnaround";
            this.Turnaround.ReadOnly = true;
            // 
            // truckRegoDataGridViewTextBoxColumn
            // 
            this.truckRegoDataGridViewTextBoxColumn.DataPropertyName = "TruckRego";
            this.truckRegoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.truckRegoDataGridViewTextBoxColumn.Name = "truckRegoDataGridViewTextBoxColumn";
            this.truckRegoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Driver
            // 
            this.Driver.DataPropertyName = "Driver";
            this.Driver.HeaderText = "Driver";
            this.Driver.Name = "Driver";
            this.Driver.ReadOnly = true;
            // 
            // DriverMobile
            // 
            this.DriverMobile.DataPropertyName = "DriverMobile";
            this.DriverMobile.HeaderText = "Driver Mobile";
            this.DriverMobile.Name = "DriverMobile";
            this.DriverMobile.ReadOnly = true;
            // 
            // grossDataGridViewTextBoxColumn
            // 
            this.grossDataGridViewTextBoxColumn.DataPropertyName = "Gross";
            this.grossDataGridViewTextBoxColumn.HeaderText = "Gross";
            this.grossDataGridViewTextBoxColumn.Name = "grossDataGridViewTextBoxColumn";
            this.grossDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossDataGridViewTextBoxColumn.Width = 80;
            // 
            // Overload
            // 
            this.Overload.DataPropertyName = "Overload";
            this.Overload.HeaderText = "Overload";
            this.Overload.Name = "Overload";
            this.Overload.ReadOnly = true;
            this.Overload.Width = 80;
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
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
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
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Material Description";
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
            this.overloadPointsDataGridViewTextBoxColumn.HeaderText = "Overload Points";
            this.overloadPointsDataGridViewTextBoxColumn.Name = "overloadPointsDataGridViewTextBoxColumn";
            this.overloadPointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overloadDescDataGridViewTextBoxColumn
            // 
            this.overloadDescDataGridViewTextBoxColumn.DataPropertyName = "OverloadDesc";
            this.overloadDescDataGridViewTextBoxColumn.HeaderText = "Overload Description";
            this.overloadDescDataGridViewTextBoxColumn.Name = "overloadDescDataGridViewTextBoxColumn";
            this.overloadDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wBModeDataGridViewTextBoxColumn
            // 
            this.wBModeDataGridViewTextBoxColumn.DataPropertyName = "WBMode";
            this.wBModeDataGridViewTextBoxColumn.HeaderText = "WB Mode";
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
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetDocket);
            this.splitContainer1.Panel1.Controls.Add(this.txtDocketNo);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 3;
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
            this.btnGetDocket.Click += new System.EventHandler(this.btnGetDocket_Click);
            // 
            // txtDocketNo
            // 
            this.txtDocketNo.Location = new System.Drawing.Point(44, 115);
            this.txtDocketNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocketNo.Name = "txtDocketNo";
            this.txtDocketNo.Size = new System.Drawing.Size(148, 24);
            this.txtDocketNo.TabIndex = 1;
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
            this.btnPrintDocket.Click += new System.EventHandler(this.btnPrintDocket_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DocketReportDataset";
            reportDataSource3.Value = this.bsDeliveryDocket;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QWS_Local.DocketRpt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(898, 584);
            this.reportViewer1.TabIndex = 1;
            // 
            // taDeliveryDocket
            // 
            this.taDeliveryDocket.ClearBeforeFill = true;
            // 
            // taDocketList
            // 
            this.taDocketList.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSViewsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtRegoFilter
            // 
            this.txtRegoFilter.Location = new System.Drawing.Point(24, 35);
            this.txtRegoFilter.Name = "txtRegoFilter";
            this.txtRegoFilter.Size = new System.Drawing.Size(100, 24);
            this.txtRegoFilter.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClear);
            this.groupBox1.Controls.Add(this.rbFilter);
            this.groupBox1.Controls.Add(this.txtRegoFilter);
            this.groupBox1.Location = new System.Drawing.Point(4, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by Rego";
            // 
            // rbFilter
            // 
            this.rbFilter.AutoSize = true;
            this.rbFilter.Location = new System.Drawing.Point(24, 66);
            this.rbFilter.Name = "rbFilter";
            this.rbFilter.Size = new System.Drawing.Size(58, 22);
            this.rbFilter.TabIndex = 10;
            this.rbFilter.TabStop = true;
            this.rbFilter.Text = "Filter";
            this.rbFilter.UseVisualStyleBackColor = true;
            this.rbFilter.CheckedChanged += new System.EventHandler(this.rbFilter_CheckedChanged);
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(24, 95);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(61, 22);
            this.rbClear.TabIndex = 11;
            this.rbClear.TabStop = true;
            this.rbClear.Text = "Clear";
            this.rbClear.UseVisualStyleBackColor = true;
            this.rbClear.CheckedChanged += new System.EventHandler(this.rbClear_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dockets :";
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
            this.Text = "Print Docket";
            this.Load += new System.EventHandler(this.PrintDocket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryDocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDocketReport)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocketList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocketList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWS)).EndInit();
            this.tpDocket.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDocket;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGetDocket;
        private System.Windows.Forms.TextBox txtDocketNo;
        private System.Windows.Forms.Button btnPrintDocket;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvDocketList;
        private dsQWSViewsTableAdapters.DocketListTableAdapter taDocketList;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsQWSViews dsQWS;
        private System.Windows.Forms.BindingSource bsDocketList;
        private System.Windows.Forms.Button btnGetDocketList;
        private System.Windows.Forms.DateTimePicker dtpDocketList;
        private dsQWSViewsTableAdapters.TableAdapterManager tableAdapterManager;
        private dsDocketReport dsDocketReport;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.BindingSource bsDeliveryDocket;
        private dsDocketReportTableAdapters.DeliveryDocketTableAdapter taDeliveryDocket;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turnaround;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckRegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverMobile;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClear;
        private System.Windows.Forms.RadioButton rbFilter;
        private System.Windows.Forms.TextBox txtRegoFilter;
        private System.Windows.Forms.Label label1;
    }
}