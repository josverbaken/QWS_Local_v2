namespace QWS_Local
{
    partial class ConfirmCustomer
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
            this.btnOkayOnce = new System.Windows.Forms.Button();
            this.btnOkayAlways = new System.Windows.Forms.Button();
            this.btnNotOkay = new System.Windows.Forms.Button();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.bsDriver = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.personTextBox1 = new System.Windows.Forms.TextBox();
            this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.mobTextBox1 = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.btnSeachPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taDriver = new QWS_Local.dsQWSLocal2024TableAdapters.TruckDriverTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.taPerson = new QWS_Local.dsQWSLocal2024TableAdapters.PersonTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.tpContactPersons = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpContactPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkayOnce
            // 
            this.btnOkayOnce.Location = new System.Drawing.Point(63, 299);
            this.btnOkayOnce.Name = "btnOkayOnce";
            this.btnOkayOnce.Size = new System.Drawing.Size(142, 92);
            this.btnOkayOnce.TabIndex = 0;
            this.btnOkayOnce.Text = "OK Once";
            this.btnOkayOnce.UseVisualStyleBackColor = true;
            this.btnOkayOnce.Click += new System.EventHandler(this.btnOkayOnce_Click);
            // 
            // btnOkayAlways
            // 
            this.btnOkayAlways.Location = new System.Drawing.Point(236, 299);
            this.btnOkayAlways.Name = "btnOkayAlways";
            this.btnOkayAlways.Size = new System.Drawing.Size(144, 91);
            this.btnOkayAlways.TabIndex = 1;
            this.btnOkayAlways.Text = "OK Always";
            this.btnOkayAlways.UseVisualStyleBackColor = true;
            this.btnOkayAlways.Click += new System.EventHandler(this.btnOkayAlways_Click);
            // 
            // btnNotOkay
            // 
            this.btnNotOkay.Location = new System.Drawing.Point(400, 299);
            this.btnNotOkay.Name = "btnNotOkay";
            this.btnNotOkay.Size = new System.Drawing.Size(142, 91);
            this.btnNotOkay.TabIndex = 2;
            this.btnNotOkay.Text = "Not Okay";
            this.btnNotOkay.UseVisualStyleBackColor = true;
            this.btnNotOkay.Click += new System.EventHandler(this.btnNotOkay_Click);
            // 
            // txtRego
            // 
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.Location = new System.Drawing.Point(280, 26);
            this.txtRego.Name = "txtRego";
            this.txtRego.ReadOnly = true;
            this.txtRego.Size = new System.Drawing.Size(100, 35);
            this.txtRego.TabIndex = 3;
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(82, 69);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.ReadOnly = true;
            this.personTextBox.Size = new System.Drawing.Size(298, 24);
            this.personTextBox.TabIndex = 6;
            // 
            // bsDriver
            // 
            this.bsDriver.DataMember = "TruckDriver";
            this.bsDriver.DataSource = this.dsQWSLocal2024;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDriver, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(400, 69);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.ReadOnly = true;
            this.mobTextBox.Size = new System.Drawing.Size(142, 24);
            this.mobTextBox.TabIndex = 8;
            // 
            // personTextBox1
            // 
            this.personTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "Person", true));
            this.personTextBox1.Location = new System.Drawing.Point(188, 182);
            this.personTextBox1.Name = "personTextBox1";
            this.personTextBox1.ReadOnly = true;
            this.personTextBox1.Size = new System.Drawing.Size(192, 24);
            this.personTextBox1.TabIndex = 10;
            // 
            // bsPerson
            // 
            this.bsPerson.DataMember = "Person";
            this.bsPerson.DataSource = this.dsQWSLocal2024;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(188, 212);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(192, 24);
            this.positionTextBox.TabIndex = 12;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "Tel", true));
            this.telTextBox.Location = new System.Drawing.Point(280, 242);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.ReadOnly = true;
            this.telTextBox.Size = new System.Drawing.Size(100, 24);
            this.telTextBox.TabIndex = 14;
            // 
            // mobTextBox1
            // 
            this.mobTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "Mob", true));
            this.mobTextBox1.Location = new System.Drawing.Point(400, 242);
            this.mobTextBox1.Name = "mobTextBox1";
            this.mobTextBox1.ReadOnly = true;
            this.mobTextBox1.Size = new System.Drawing.Size(142, 24);
            this.mobTextBox1.TabIndex = 16;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(188, 145);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(192, 24);
            this.txtPerson.TabIndex = 17;
            this.txtPerson.Click += new System.EventHandler(this.txtPerson_Click);
            this.txtPerson.Enter += new System.EventHandler(this.txtPerson_Enter);
            // 
            // btnSeachPerson
            // 
            this.btnSeachPerson.Location = new System.Drawing.Point(400, 144);
            this.btnSeachPerson.Name = "btnSeachPerson";
            this.btnSeachPerson.Size = new System.Drawing.Size(142, 27);
            this.btnSeachPerson.TabIndex = 18;
            this.btnSeachPerson.Text = "Find";
            this.btnSeachPerson.UseVisualStyleBackColor = true;
            this.btnSeachPerson.Click += new System.EventHandler(this.btnSeachPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search for : ";
            // 
            // taDriver
            // 
            this.taDriver.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taPerson
            // 
            this.taPerson.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMain);
            this.tabControl1.Controls.Add(this.tpContactPersons);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 468);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedTabChanged);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.btnClear);
            this.tpMain.Controls.Add(this.txtCardCode);
            this.tpMain.Controls.Add(this.txtCustomer);
            this.tpMain.Controls.Add(this.txtRego);
            this.tpMain.Controls.Add(this.label1);
            this.tpMain.Controls.Add(this.btnOkayOnce);
            this.tpMain.Controls.Add(this.btnSeachPerson);
            this.tpMain.Controls.Add(this.btnOkayAlways);
            this.tpMain.Controls.Add(this.txtPerson);
            this.tpMain.Controls.Add(this.btnNotOkay);
            this.tpMain.Controls.Add(this.personTextBox);
            this.tpMain.Controls.Add(this.mobTextBox1);
            this.tpMain.Controls.Add(this.mobTextBox);
            this.tpMain.Controls.Add(this.personTextBox1);
            this.tpMain.Controls.Add(this.telTextBox);
            this.tpMain.Controls.Add(this.positionTextBox);
            this.tpMain.Location = new System.Drawing.Point(4, 27);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(615, 437);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(400, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 27);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(400, 115);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.ReadOnly = true;
            this.txtCardCode.Size = new System.Drawing.Size(142, 24);
            this.txtCardCode.TabIndex = 21;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(82, 115);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(298, 24);
            this.txtCustomer.TabIndex = 20;
            // 
            // tpContactPersons
            // 
            this.tpContactPersons.Controls.Add(this.dataGridView1);
            this.tpContactPersons.Location = new System.Drawing.Point(4, 27);
            this.tpContactPersons.Name = "tpContactPersons";
            this.tpContactPersons.Padding = new System.Windows.Forms.Padding(3);
            this.tpContactPersons.Size = new System.Drawing.Size(615, 437);
            this.tpContactPersons.TabIndex = 1;
            this.tpContactPersons.Text = "Contact Persons";
            this.tpContactPersons.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.mobDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsPerson;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(609, 431);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            this.personDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 150;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobDataGridViewTextBoxColumn
            // 
            this.mobDataGridViewTextBoxColumn.DataPropertyName = "Mob";
            this.mobDataGridViewTextBoxColumn.HeaderText = "Mob";
            this.mobDataGridViewTextBoxColumn.Name = "mobDataGridViewTextBoxColumn";
            this.mobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "Active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            this.activeDataGridViewTextBoxColumn.Width = 60;
            // 
            // ConfirmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 468);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfirmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmCustomer";
            this.Load += new System.EventHandler(this.ConfirmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.tpContactPersons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOkayOnce;
        private System.Windows.Forms.Button btnOkayAlways;
        private System.Windows.Forms.Button btnNotOkay;
        private System.Windows.Forms.TextBox txtRego;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsDriver;
        private dsQWSLocal2024TableAdapters.TruckDriverTableAdapter taDriver;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.BindingSource bsPerson;
        private dsQWSLocal2024TableAdapters.PersonTableAdapter taPerson;
        private System.Windows.Forms.TextBox personTextBox1;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox mobTextBox1;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Button btnSeachPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpContactPersons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
    }
}