
namespace QWS_Local
{
    partial class VehicleSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleSearch));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnTrailer = new System.Windows.Forms.ToolStripButton();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schematic = new System.Windows.Forms.DataGridViewImageColumn();
            this.vehicleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.vehicleDetailsTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.VehicleDetailsTableAdapter();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnTruck = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vehicleDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1331, 623);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearch,
            this.btnSearch,
            this.btnSelect,
            this.btnCancel,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.btnTruck,
            this.btnTrailer,
            this.btnClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1331, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 39);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.Image = global::QWS_Local.Properties.Resources.Search_1;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 36);
            this.btnSearch.Text = "Find";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 36);
            this.btnSelect.Text = "Select and Close";
            this.btnSelect.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 36);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnTrailer
            // 
            this.btnTrailer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTrailer.Image = ((System.Drawing.Image)(resources.GetObject("btnTrailer.Image")));
            this.btnTrailer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(60, 36);
            this.btnTrailer.Text = "Trailers";
            this.btnTrailer.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AllowUserToAddRows = false;
            this.vehicleDataGridView.AllowUserToDeleteRows = false;
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.VehicleType,
            this.dataGridViewTextBoxColumn13,
            this.FeeCode,
            this.Schematic});
            this.vehicleDataGridView.DataSource = this.vehicleDetailsBindingSource;
            this.vehicleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.ReadOnly = true;
            this.vehicleDataGridView.RowTemplate.Height = 150;
            this.vehicleDataGridView.Size = new System.Drawing.Size(1331, 553);
            this.vehicleDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rego";
            this.dataGridViewTextBoxColumn1.HeaderText = "Rego";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn3.HeaderText = "Owner";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn4.HeaderText = "Make";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "VehicleType";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "AxleConfiguration";
            this.dataGridViewTextBoxColumn13.HeaderText = "AxleConfiguration";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // FeeCode
            // 
            this.FeeCode.DataPropertyName = "FeeCode";
            this.FeeCode.HeaderText = "FeeCode";
            this.FeeCode.Name = "FeeCode";
            this.FeeCode.ReadOnly = true;
            // 
            // Schematic
            // 
            this.Schematic.DataPropertyName = "Schematic";
            this.Schematic.HeaderText = "Schematic";
            this.Schematic.Name = "Schematic";
            this.Schematic.ReadOnly = true;
            this.Schematic.Width = 450;
            // 
            // vehicleDetailsBindingSource
            // 
            this.vehicleDetailsBindingSource.DataMember = "VehicleDetails";
            this.vehicleDetailsBindingSource.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.NHVLTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // vehicleDetailsTableAdapter
            // 
            this.vehicleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 36);
            this.toolStripLabel1.Text = "Filters :";
            // 
            // btnTruck
            // 
            this.btnTruck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnTruck.Image")));
            this.btnTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTruck.Name = "btnTruck";
            this.btnTruck.Size = new System.Drawing.Size(53, 36);
            this.btnTruck.Text = "Trucks";
            this.btnTruck.Click += new System.EventHandler(this.btnTruck_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 36);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // VehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 623);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleSearch";
            this.Text = "VehicleSearch";
            this.Load += new System.EventHandler(this.VehicleSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private dsQWSLocal dsQWSLocal;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource vehicleDetailsBindingSource;
        private dsQWSLocalTableAdapters.VehicleDetailsTableAdapter vehicleDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeCode;
        private System.Windows.Forms.DataGridViewImageColumn Schematic;
        private System.Windows.Forms.ToolStripButton btnTrailer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnTruck;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}