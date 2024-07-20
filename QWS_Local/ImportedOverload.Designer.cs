namespace QWS_Local
{
    partial class ImportedOverload
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
            System.Windows.Forms.Label driverLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOverload = new System.Windows.Forms.TabPage();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPointsThisWeek = new System.Windows.Forms.TextBox();
            this.txtPointsToday = new System.Windows.Forms.TextBox();
            this.txtPointsDocket = new System.Windows.Forms.TextBox();
            this.txtOverloadCategory = new System.Windows.Forms.TextBox();
            this.txtOverloadTonnes = new System.Windows.Forms.TextBox();
            this.txtOverloadPercent = new System.Windows.Forms.TextBox();
            this.txtGVM = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.tpSanctions = new System.Windows.Forms.TabPage();
            this.rtxtSanctions = new System.Windows.Forms.RichTextBox();
            this.tpDockets = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.driverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overloadPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsImportedOverloads = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.taImportedOverloads = new QWS_Local.dsTIQ2TableAdapters.ImportedOverloadsByDriverTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            driverLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpOverload.SuspendLayout();
            this.tpSanctions.SuspendLayout();
            this.tpDockets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsImportedOverloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(90, 23);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(51, 18);
            driverLabel.TabIndex = 16;
            driverLabel.Text = "Driver:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpOverload);
            this.tabControl1.Controls.Add(this.tpSanctions);
            this.tabControl1.Controls.Add(this.tpDockets);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tpOverload
            // 
            this.tpOverload.Controls.Add(this.txtDriver);
            this.tpOverload.Controls.Add(driverLabel);
            this.tpOverload.Controls.Add(this.label6);
            this.tpOverload.Controls.Add(this.label5);
            this.tpOverload.Controls.Add(this.label4);
            this.tpOverload.Controls.Add(this.label3);
            this.tpOverload.Controls.Add(this.label2);
            this.tpOverload.Controls.Add(this.label1);
            this.tpOverload.Controls.Add(this.txtPointsThisWeek);
            this.tpOverload.Controls.Add(this.txtPointsToday);
            this.tpOverload.Controls.Add(this.txtPointsDocket);
            this.tpOverload.Controls.Add(this.txtOverloadCategory);
            this.tpOverload.Controls.Add(this.txtOverloadTonnes);
            this.tpOverload.Controls.Add(this.txtOverloadPercent);
            this.tpOverload.Controls.Add(this.txtGVM);
            this.tpOverload.Controls.Add(this.txtGross);
            this.tpOverload.Location = new System.Drawing.Point(4, 27);
            this.tpOverload.Name = "tpOverload";
            this.tpOverload.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverload.Size = new System.Drawing.Size(872, 380);
            this.tpOverload.TabIndex = 0;
            this.tpOverload.Text = "Overload Processing";
            this.tpOverload.UseVisualStyleBackColor = true;
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(147, 24);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(206, 24);
            this.txtDriver.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "This week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Today";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Docket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Overload";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "GVM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gross";
            // 
            // txtPointsThisWeek
            // 
            this.txtPointsThisWeek.Location = new System.Drawing.Point(147, 245);
            this.txtPointsThisWeek.Name = "txtPointsThisWeek";
            this.txtPointsThisWeek.Size = new System.Drawing.Size(100, 24);
            this.txtPointsThisWeek.TabIndex = 8;
            // 
            // txtPointsToday
            // 
            this.txtPointsToday.Location = new System.Drawing.Point(147, 215);
            this.txtPointsToday.Name = "txtPointsToday";
            this.txtPointsToday.Size = new System.Drawing.Size(100, 24);
            this.txtPointsToday.TabIndex = 7;
            // 
            // txtPointsDocket
            // 
            this.txtPointsDocket.Location = new System.Drawing.Point(147, 185);
            this.txtPointsDocket.Name = "txtPointsDocket";
            this.txtPointsDocket.Size = new System.Drawing.Size(100, 24);
            this.txtPointsDocket.TabIndex = 6;
            // 
            // txtOverloadCategory
            // 
            this.txtOverloadCategory.Location = new System.Drawing.Point(147, 155);
            this.txtOverloadCategory.Name = "txtOverloadCategory";
            this.txtOverloadCategory.Size = new System.Drawing.Size(206, 24);
            this.txtOverloadCategory.TabIndex = 5;
            // 
            // txtOverloadTonnes
            // 
            this.txtOverloadTonnes.Location = new System.Drawing.Point(253, 114);
            this.txtOverloadTonnes.Name = "txtOverloadTonnes";
            this.txtOverloadTonnes.Size = new System.Drawing.Size(100, 24);
            this.txtOverloadTonnes.TabIndex = 4;
            // 
            // txtOverloadPercent
            // 
            this.txtOverloadPercent.Location = new System.Drawing.Point(147, 114);
            this.txtOverloadPercent.Name = "txtOverloadPercent";
            this.txtOverloadPercent.Size = new System.Drawing.Size(100, 24);
            this.txtOverloadPercent.TabIndex = 3;
            // 
            // txtGVM
            // 
            this.txtGVM.Location = new System.Drawing.Point(147, 84);
            this.txtGVM.Name = "txtGVM";
            this.txtGVM.Size = new System.Drawing.Size(100, 24);
            this.txtGVM.TabIndex = 2;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(147, 54);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(100, 24);
            this.txtGross.TabIndex = 1;
            // 
            // tpSanctions
            // 
            this.tpSanctions.Controls.Add(this.rtxtSanctions);
            this.tpSanctions.Location = new System.Drawing.Point(4, 22);
            this.tpSanctions.Name = "tpSanctions";
            this.tpSanctions.Padding = new System.Windows.Forms.Padding(3);
            this.tpSanctions.Size = new System.Drawing.Size(872, 385);
            this.tpSanctions.TabIndex = 1;
            this.tpSanctions.Text = "Sanctions";
            this.tpSanctions.UseVisualStyleBackColor = true;
            // 
            // rtxtSanctions
            // 
            this.rtxtSanctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtSanctions.Location = new System.Drawing.Point(3, 3);
            this.rtxtSanctions.Name = "rtxtSanctions";
            this.rtxtSanctions.Size = new System.Drawing.Size(866, 379);
            this.rtxtSanctions.TabIndex = 0;
            this.rtxtSanctions.Text = "";
            // 
            // tpDockets
            // 
            this.tpDockets.Controls.Add(this.dataGridView1);
            this.tpDockets.Location = new System.Drawing.Point(4, 22);
            this.tpDockets.Name = "tpDockets";
            this.tpDockets.Size = new System.Drawing.Size(872, 385);
            this.tpDockets.TabIndex = 2;
            this.tpDockets.Text = "Dockets";
            this.tpDockets.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverDataGridViewTextBoxColumn,
            this.timeInDTTMDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.regoDataGridViewTextBoxColumn,
            this.grossDataGridViewTextBoxColumn,
            this.gCMDataGridViewTextBoxColumn,
            this.overloadPointsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsImportedOverloads;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(872, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            this.driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn.HeaderText = "Driver";
            this.driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            this.driverDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeInDTTMDataGridViewTextBoxColumn
            // 
            this.timeInDTTMDataGridViewTextBoxColumn.DataPropertyName = "timeInDTTM";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.timeInDTTMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeInDTTMDataGridViewTextBoxColumn.HeaderText = "timeInDTTM";
            this.timeInDTTMDataGridViewTextBoxColumn.Name = "timeInDTTMDataGridViewTextBoxColumn";
            this.timeInDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.timeInDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.timeInDataGridViewTextBoxColumn.HeaderText = "TimeIn";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            this.regoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossDataGridViewTextBoxColumn
            // 
            this.grossDataGridViewTextBoxColumn.DataPropertyName = "Gross";
            this.grossDataGridViewTextBoxColumn.HeaderText = "Gross";
            this.grossDataGridViewTextBoxColumn.Name = "grossDataGridViewTextBoxColumn";
            this.grossDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
            this.gCMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overloadPointsDataGridViewTextBoxColumn
            // 
            this.overloadPointsDataGridViewTextBoxColumn.DataPropertyName = "OverloadPoints";
            this.overloadPointsDataGridViewTextBoxColumn.HeaderText = "OverloadPoints";
            this.overloadPointsDataGridViewTextBoxColumn.Name = "overloadPointsDataGridViewTextBoxColumn";
            this.overloadPointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsImportedOverloads
            // 
            this.bsImportedOverloads.DataMember = "ImportedOverloadsByDriver";
            this.bsImportedOverloads.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(723, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(153, 58);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Accept";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(7, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 58);
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnOK);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Size = new System.Drawing.Size(880, 519);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 3;
            // 
            // taImportedOverloads
            // 
            this.taImportedOverloads.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TIQTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = null;
            // 
            // ImportedOverload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 519);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportedOverload";
            this.Text = "ImportedOverload";
            this.Load += new System.EventHandler(this.ImportedOverload_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpOverload.ResumeLayout(false);
            this.tpOverload.PerformLayout();
            this.tpSanctions.ResumeLayout(false);
            this.tpDockets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsImportedOverloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOverload;
        private System.Windows.Forms.TabPage tpSanctions;
        private System.Windows.Forms.RichTextBox rtxtSanctions;
        private System.Windows.Forms.TabPage tpDockets;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPointsThisWeek;
        private System.Windows.Forms.TextBox txtPointsToday;
        private System.Windows.Forms.TextBox txtPointsDocket;
        private System.Windows.Forms.TextBox txtOverloadCategory;
        private System.Windows.Forms.TextBox txtOverloadTonnes;
        private System.Windows.Forms.TextBox txtOverloadPercent;
        private System.Windows.Forms.TextBox txtGVM;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overloadPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsImportedOverloads;
        private dsTIQ2 dsTIQ2;
        private dsTIQ2TableAdapters.ImportedOverloadsByDriverTableAdapter taImportedOverloads;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtDriver;
    }
}