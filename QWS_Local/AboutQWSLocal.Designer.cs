namespace QWS_Local
{
    partial class AboutQWSLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.Label roleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutQWSLocal));
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wBOFunctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOperatorRolesDetailed = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdmin = new QWS_Local.dsAdmin();
            this.bsOperator = new System.Windows.Forms.BindingSource(this.components);
            this.taOperator = new QWS_Local.dsAdminTableAdapters.OperatorTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsAdminTableAdapters.TableAdapterManager();
            this.taOperatorRolesDetailed = new QWS_Local.dsAdminTableAdapters.OperatorRolesDetailedTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperatorRolesDetailed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperator)).BeginInit();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(531, 478);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(43, 18);
            roleLabel.TabIndex = 25;
            roleLabel.Text = "Role:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(34, 220);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(9, 4, 4, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(525, 170);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(34, 12);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(200, 200);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 24;
            this.logoPictureBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleDataGridViewTextBoxColumn,
            this.wBOFunctionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsOperatorRolesDetailed;
            this.dataGridView1.Location = new System.Drawing.Point(582, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 287);
            this.dataGridView1.TabIndex = 25;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 200;
            // 
            // wBOFunctionDataGridViewTextBoxColumn
            // 
            this.wBOFunctionDataGridViewTextBoxColumn.DataPropertyName = "WBOFunction";
            this.wBOFunctionDataGridViewTextBoxColumn.HeaderText = "Function";
            this.wBOFunctionDataGridViewTextBoxColumn.Name = "wBOFunctionDataGridViewTextBoxColumn";
            this.wBOFunctionDataGridViewTextBoxColumn.ReadOnly = true;
            this.wBOFunctionDataGridViewTextBoxColumn.Width = 250;
            // 
            // bsOperatorRolesDetailed
            // 
            this.bsOperatorRolesDetailed.DataMember = "OperatorRolesDetailed";
            this.bsOperatorRolesDetailed.DataSource = this.dsAdmin;
            // 
            // dsAdmin
            // 
            this.dsAdmin.DataSetName = "dsAdmin";
            this.dsAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsOperator
            // 
            this.bsOperator.DataMember = "Operator";
            this.bsOperator.DataSource = this.dsAdmin;
            // 
            // taOperator
            // 
            this.taOperator.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FunctionsTableAdapter = null;
            this.tableAdapterManager.OperatorRolesTableAdapter = null;
            this.tableAdapterManager.OperatorTableAdapter = this.taOperator;
            this.tableAdapterManager.RoleFunctionsTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsAdminTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taOperatorRolesDetailed
            // 
            this.taOperatorRolesDetailed.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "label4";
            // 
            // AboutQWSLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutQWSLocal";
            this.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutQWSLocal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AboutQWSLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperatorRolesDetailed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsAdmin dsAdmin;
        private System.Windows.Forms.BindingSource bsOperator;
        private dsAdminTableAdapters.OperatorTableAdapter taOperator;
        private dsAdminTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bsOperatorRolesDetailed;
        private dsAdminTableAdapters.OperatorRolesDetailedTableAdapter taOperatorRolesDetailed;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wBOFunctionDataGridViewTextBoxColumn;
    }
}
