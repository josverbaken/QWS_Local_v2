
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.rbTrucks = new System.Windows.Forms.RadioButton();
            this.rbTrailers = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.bsVehicleDetails2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.taVehicleDetails2 = new QWS_Local.dsQWSLocal2024TableAdapters.VehicleDetailsTableAdapter();
            this.bsVehicleDetails3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schematic = new System.Windows.Forms.DataGridViewImageColumn();
            this.RegistrationExpDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails3)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnFind);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1331, 623);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn13,
            this.FeeCode,
            this.Schematic,
            this.RegistrationExpDT});
            this.vehicleDataGridView.DataSource = this.bsVehicleDetails3;
            this.vehicleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleDataGridView.Location = new System.Drawing.Point(3, 3);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.ReadOnly = true;
            this.vehicleDataGridView.RowTemplate.Height = 150;
            this.vehicleDataGridView.Size = new System.Drawing.Size(1050, 586);
            this.vehicleDataGridView.TabIndex = 0;
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(80, 91);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(100, 24);
            this.txtSearch1.TabIndex = 1;
            // 
            // rbTrucks
            // 
            this.rbTrucks.AutoSize = true;
            this.rbTrucks.Location = new System.Drawing.Point(29, 23);
            this.rbTrucks.Name = "rbTrucks";
            this.rbTrucks.Size = new System.Drawing.Size(72, 22);
            this.rbTrucks.TabIndex = 2;
            this.rbTrucks.TabStop = true;
            this.rbTrucks.Text = "Trucks";
            this.rbTrucks.UseVisualStyleBackColor = true;
            this.rbTrucks.CheckedChanged += new System.EventHandler(this.rbTrucks_CheckedChanged);
            // 
            // rbTrailers
            // 
            this.rbTrailers.AutoSize = true;
            this.rbTrailers.Location = new System.Drawing.Point(29, 63);
            this.rbTrailers.Name = "rbTrailers";
            this.rbTrailers.Size = new System.Drawing.Size(75, 22);
            this.rbTrailers.TabIndex = 3;
            this.rbTrailers.TabStop = true;
            this.rbTrailers.Text = "Trailers";
            this.rbTrailers.UseVisualStyleBackColor = true;
            this.rbTrailers.CheckedChanged += new System.EventHandler(this.rbTrailers_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.rbTrailers);
            this.groupBox1.Controls.Add(this.rbTrucks);
            this.groupBox1.Location = new System.Drawing.Point(33, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(29, 118);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(118, 39);
            this.btnClearFilter.TabIndex = 4;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(62, 222);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(147, 44);
            this.btnCancel1.TabIndex = 5;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(62, 295);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(147, 34);
            this.btnSelect1.TabIndex = 6;
            this.btnSelect1.Text = "Select and Close";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 623);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.vehicleDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(62, 151);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(147, 44);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // bsVehicleDetails2
            // 
            this.bsVehicleDetails2.DataMember = "VehicleDetails";
            this.bsVehicleDetails2.DataSource = this.dsQWSLocal2024;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taVehicleDetails2
            // 
            this.taVehicleDetails2.ClearBeforeFill = true;
            // 
            // bsVehicleDetails3
            // 
            this.bsVehicleDetails3.DataMember = "VehicleDetails";
            this.bsVehicleDetails3.DataSource = this.dsQWSLocal2024;
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
            // RegistrationExpDT
            // 
            this.RegistrationExpDT.DataPropertyName = "RegistrationExpDT";
            this.RegistrationExpDT.HeaderText = "RegistrationExpDT";
            this.RegistrationExpDT.Name = "RegistrationExpDT";
            this.RegistrationExpDT.ReadOnly = true;
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
            this.Text = "Vehicle Search";
            this.Load += new System.EventHandler(this.VehicleSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsVehicleDetails2;
        private dsQWSLocal2024TableAdapters.VehicleDetailsTableAdapter taVehicleDetails2;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.RadioButton rbTrailers;
        private System.Windows.Forms.RadioButton rbTrucks;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeCode;
        private System.Windows.Forms.DataGridViewImageColumn Schematic;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationExpDT;
        private System.Windows.Forms.BindingSource bsVehicleDetails3;
    }
}