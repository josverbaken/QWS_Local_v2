namespace QWS_Local
{
    partial class OperatorRoles
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtOperatorID = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsAdmin = new QWS_Local.dsAdmin();
            this.bsOperatorRoles = new System.Windows.Forms.BindingSource(this.components);
            this.taOperatorRoles = new QWS_Local.dsAdminTableAdapters.OperatorRolesDetailedTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OperatorRolesDetailedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperatorRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorRolesDetailedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnFind);
            this.splitContainer1.Panel1.Controls.Add(this.txtOperatorID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(995, 590);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtOperatorID
            // 
            this.txtOperatorID.Location = new System.Drawing.Point(58, 49);
            this.txtOperatorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOperatorID.Name = "txtOperatorID";
            this.txtOperatorID.Size = new System.Drawing.Size(112, 24);
            this.txtOperatorID.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(58, 104);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 32);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(58, 172);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpList.Size = new System.Drawing.Size(771, 559);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.reportViewer1);
            this.tpDetails.Location = new System.Drawing.Point(4, 27);
            this.tpDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDetails.Size = new System.Drawing.Size(771, 559);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.functionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsOperatorRoles;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsAdmin
            // 
            this.dsAdmin.DataSetName = "dsAdmin";
            this.dsAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsOperatorRoles
            // 
            this.bsOperatorRoles.DataMember = "OperatorRolesDetailed";
            this.bsOperatorRoles.DataSource = this.dsAdmin;
            // 
            // taOperatorRoles
            // 
            this.taOperatorRoles.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 200;
            // 
            // functionDataGridViewTextBoxColumn
            // 
            this.functionDataGridViewTextBoxColumn.DataPropertyName = "Function";
            this.functionDataGridViewTextBoxColumn.HeaderText = "Function";
            this.functionDataGridViewTextBoxColumn.Name = "functionDataGridViewTextBoxColumn";
            this.functionDataGridViewTextBoxColumn.ReadOnly = true;
            this.functionDataGridViewTextBoxColumn.Width = 300;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportDataSet";
            reportDataSource1.Value = this.bsOperatorRoles;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QWS_Local.OperatorRolesDetailed.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 551);
            this.reportViewer1.TabIndex = 0;
            // 
            // OperatorRolesDetailedBindingSource
            // 
            this.OperatorRolesDetailedBindingSource.DataMember = "OperatorRolesDetailed";
            this.OperatorRolesDetailedBindingSource.DataSource = this.dsAdmin;
            // 
            // OperatorRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 590);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OperatorRoles";
            this.Text = "Operator Roles and Functions";
            this.Load += new System.EventHandler(this.OperatorRoles_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.tpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperatorRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorRolesDetailedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtOperatorID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsOperatorRoles;
        private dsAdmin dsAdmin;
        private System.Windows.Forms.TabPage tpDetails;
        private dsAdminTableAdapters.OperatorRolesDetailedTableAdapter taOperatorRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OperatorRolesDetailedBindingSource;
    }
}