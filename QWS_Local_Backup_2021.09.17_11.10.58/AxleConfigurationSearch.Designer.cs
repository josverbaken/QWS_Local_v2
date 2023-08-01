
namespace QWS_Local
{
    partial class AxleConfigurationSearch
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
            System.Windows.Forms.Label vehicleDescriptionLabel;
            System.Windows.Forms.Label axleConfigurationLabel;
            System.Windows.Forms.Label axlesLabel;
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axleConfigurationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axlesTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.vehicleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.axleConfigurationTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.AxleConfigurationTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            vehicleDescriptionLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            axlesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleDescriptionLabel
            // 
            vehicleDescriptionLabel.AutoSize = true;
            vehicleDescriptionLabel.Location = new System.Drawing.Point(184, 86);
            vehicleDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vehicleDescriptionLabel.Name = "vehicleDescriptionLabel";
            vehicleDescriptionLabel.Size = new System.Drawing.Size(138, 18);
            vehicleDescriptionLabel.TabIndex = 1;
            vehicleDescriptionLabel.Text = "Vehicle Description:";
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(193, 54);
            axleConfigurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(131, 18);
            axleConfigurationLabel.TabIndex = 3;
            axleConfigurationLabel.Text = "Axle Configuration:";
            // 
            // axlesLabel
            // 
            axlesLabel.AutoSize = true;
            axlesLabel.Location = new System.Drawing.Point(283, 127);
            axlesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            axlesLabel.Name = "axlesLabel";
            axlesLabel.Size = new System.Drawing.Size(47, 18);
            axlesLabel.TabIndex = 5;
            axlesLabel.Text = "Axles:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.axleConfigurationDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(axlesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.axlesTextBox);
            this.splitContainer1.Panel2.Controls.Add(axleConfigurationLabel);
            this.splitContainer1.Panel2.Controls.Add(this.axleConfigurationTextBox);
            this.splitContainer1.Panel2.Controls.Add(vehicleDescriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.vehicleDescriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelect);
            this.splitContainer1.Size = new System.Drawing.Size(1750, 586);
            this.splitContainer1.SplitterDistance = 615;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // axleConfigurationDataGridView
            // 
            this.axleConfigurationDataGridView.AllowUserToAddRows = false;
            this.axleConfigurationDataGridView.AllowUserToDeleteRows = false;
            this.axleConfigurationDataGridView.AutoGenerateColumns = false;
            this.axleConfigurationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.axleConfigurationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.axleConfigurationDataGridView.DataSource = this.axleConfigurationBindingSource;
            this.axleConfigurationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axleConfigurationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.axleConfigurationDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.axleConfigurationDataGridView.Name = "axleConfigurationDataGridView";
            this.axleConfigurationDataGridView.ReadOnly = true;
            this.axleConfigurationDataGridView.RowTemplate.Height = 150;
            this.axleConfigurationDataGridView.Size = new System.Drawing.Size(615, 586);
            this.axleConfigurationDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AxleConfiguration";
            this.dataGridViewTextBoxColumn1.HeaderText = "AxleConfiguration";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VehicleDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "VehicleDescription";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 450;
            // 
            // axleConfigurationBindingSource
            // 
            this.axleConfigurationBindingSource.DataMember = "AxleConfiguration";
            this.axleConfigurationBindingSource.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.axleConfigurationBindingSource, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(42, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // axlesTextBox
            // 
            this.axlesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.axleConfigurationBindingSource, "Axles", true));
            this.axlesTextBox.Location = new System.Drawing.Point(344, 123);
            this.axlesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axlesTextBox.Name = "axlesTextBox";
            this.axlesTextBox.Size = new System.Drawing.Size(148, 24);
            this.axlesTextBox.TabIndex = 6;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.axleConfigurationBindingSource, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(344, 50);
            this.axleConfigurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(148, 24);
            this.axleConfigurationTextBox.TabIndex = 4;
            // 
            // vehicleDescriptionTextBox
            // 
            this.vehicleDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.axleConfigurationBindingSource, "VehicleDescription", true));
            this.vehicleDescriptionTextBox.Location = new System.Drawing.Point(344, 82);
            this.vehicleDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleDescriptionTextBox.Name = "vehicleDescriptionTextBox";
            this.vehicleDescriptionTextBox.Size = new System.Drawing.Size(148, 24);
            this.vehicleDescriptionTextBox.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(260, 324);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(232, 32);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select and Close";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // axleConfigurationTableAdapter
            // 
            this.axleConfigurationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = this.axleConfigurationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NHVR_GVMTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBS_VINTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TruckConfigTrailersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1764, 623);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1756, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1756, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSize = true;
            this.radGridView1.BackColor = System.Drawing.Color.Transparent;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "AxleConfiguration";
            gridViewTextBoxColumn1.HeaderText = "AxleConfiguration";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "AxleConfiguration";
            gridViewTextBoxColumn1.Width = 113;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "VehicleType";
            gridViewTextBoxColumn2.HeaderText = "VehicleType";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "VehicleType";
            gridViewTextBoxColumn2.Width = 76;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Axles";
            gridViewDecimalColumn1.HeaderText = "Axles";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Axles";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "AxleGroups";
            gridViewDecimalColumn2.HeaderText = "AxleGroups";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "AxleGroups";
            gridViewDecimalColumn2.Width = 66;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Compartments";
            gridViewDecimalColumn3.HeaderText = "Compartments";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Compartments";
            gridViewDecimalColumn3.Width = 82;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "VehicleDescription";
            gridViewTextBoxColumn3.HeaderText = "VehicleDescription";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "VehicleDescription";
            gridViewTextBoxColumn3.Width = 104;
            gridViewImageColumn1.AllowSort = false;
            gridViewImageColumn1.DataType = typeof(byte[]);
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.FieldName = "Schematic";
            gridViewImageColumn1.HeaderText = "Schematic";
            gridViewImageColumn1.IsAutoGenerated = true;
            gridViewImageColumn1.Name = "Schematic";
            gridViewImageColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewImageColumn1.Width = 450;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn3,
            gridViewImageColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.axleConfigurationBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "Schematic";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(956, 58);
            this.radGridView1.TabIndex = 0;
            // 
            // AxleConfigurationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 623);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AxleConfigurationSearch";
            this.Text = "AxleConfigurationSearch";
            this.Load += new System.EventHandler(this.AxleConfigurationSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axleConfigurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource axleConfigurationBindingSource;
        private dsQWSLocalTableAdapters.AxleConfigurationTableAdapter axleConfigurationTableAdapter;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView axleConfigurationDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox axlesTextBox;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.TextBox vehicleDescriptionTextBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}