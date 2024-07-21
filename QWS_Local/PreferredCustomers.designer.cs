
namespace QWS_Local
{
    partial class PreferredCustomers
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
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.bsVehiclePrefCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.taVehiclePrefCustomers = new QWS_Local.dsQWSLocalTableAdapters.VehiclePrefCustomersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.isDefaultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePrefCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsVehiclePrefCustomers
            // 
            this.bsVehiclePrefCustomers.DataMember = "VehiclePrefCustomers";
            this.bsVehiclePrefCustomers.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taVehiclePrefCustomers
            // 
            this.taVehiclePrefCustomers.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isDefaultDataGridViewCheckBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn,
            this.prefCustomerDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.rankDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsVehiclePrefCustomers;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(827, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(386, 29);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(129, 42);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select and Close";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(540, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Size = new System.Drawing.Size(827, 282);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 3;
            // 
            // isDefaultDataGridViewCheckBoxColumn
            // 
            this.isDefaultDataGridViewCheckBoxColumn.DataPropertyName = "IsDefault";
            this.isDefaultDataGridViewCheckBoxColumn.HeaderText = "Default";
            this.isDefaultDataGridViewCheckBoxColumn.Name = "isDefaultDataGridViewCheckBoxColumn";
            this.isDefaultDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            this.cardCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prefCustomerDataGridViewTextBoxColumn
            // 
            this.prefCustomerDataGridViewTextBoxColumn.DataPropertyName = "PrefCustomer";
            this.prefCustomerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.prefCustomerDataGridViewTextBoxColumn.Name = "prefCustomerDataGridViewTextBoxColumn";
            this.prefCustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.prefCustomerDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PreferredCustomers
            // 
            this.ClientSize = new System.Drawing.Size(827, 282);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PreferredCustomers";
            this.Text = "Preferred Customers";
            this.Load += new System.EventHandler(this.PreferredCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehiclePrefCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource bsVehiclePrefCustomers;
        private dsQWSLocalTableAdapters.VehiclePrefCustomersTableAdapter taVehiclePrefCustomers;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDefaultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
    }
}