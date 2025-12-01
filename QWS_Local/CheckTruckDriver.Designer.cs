namespace QWS_Local
{
    partial class CheckTruckDriver
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
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label lastSeenLabel;
            System.Windows.Forms.Label regoLabel;
            this.btnFind = new System.Windows.Forms.Button();
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.bsCheckTruckDriver = new System.Windows.Forms.BindingSource(this.components);
            this.taCheckTruckDriver = new QWS_Local.dsTIQ2TableAdapters.CheckTruckDriverTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.lastSeenTextBox = new System.Windows.Forms.TextBox();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            driverLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            lastSeenLabel = new System.Windows.Forms.Label();
            regoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckTruckDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(151, 63);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 36);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsCheckTruckDriver
            // 
            this.bsCheckTruckDriver.DataMember = "CheckTruckDriver";
            this.bsCheckTruckDriver.DataSource = this.dsTIQ2;
            // 
            // taCheckTruckDriver
            // 
            this.taCheckTruckDriver.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.StockpileBOMTableAdapter = null;
            this.tableAdapterManager.StockpileLotAllocationTableAdapter = null;
            this.tableAdapterManager.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager.TIQTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = null;
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(94, 108);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(51, 18);
            driverLabel.TabIndex = 3;
            driverLabel.Text = "Driver:";
            // 
            // driverTextBox
            // 
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCheckTruckDriver, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(151, 105);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.ReadOnly = true;
            this.driverTextBox.Size = new System.Drawing.Size(273, 24);
            this.driverTextBox.TabIndex = 4;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(89, 138);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(56, 18);
            mobileLabel.TabIndex = 5;
            mobileLabel.Text = "Mobile:";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCheckTruckDriver, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(151, 135);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.ReadOnly = true;
            this.mobileTextBox.Size = new System.Drawing.Size(273, 24);
            this.mobileTextBox.TabIndex = 6;
            // 
            // lastSeenLabel
            // 
            lastSeenLabel.AutoSize = true;
            lastSeenLabel.Location = new System.Drawing.Point(67, 168);
            lastSeenLabel.Name = "lastSeenLabel";
            lastSeenLabel.Size = new System.Drawing.Size(78, 18);
            lastSeenLabel.TabIndex = 7;
            lastSeenLabel.Text = "Last Seen:";
            // 
            // lastSeenTextBox
            // 
            this.lastSeenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCheckTruckDriver, "LastSeen", true));
            this.lastSeenTextBox.Location = new System.Drawing.Point(151, 165);
            this.lastSeenTextBox.Name = "lastSeenTextBox";
            this.lastSeenTextBox.ReadOnly = true;
            this.lastSeenTextBox.Size = new System.Drawing.Size(273, 24);
            this.lastSeenTextBox.TabIndex = 8;
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(97, 36);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(48, 18);
            regoLabel.TabIndex = 9;
            regoLabel.Text = "Rego:";
            // 
            // txtRego
            // 
            this.txtRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCheckTruckDriver, "Rego", true));
            this.txtRego.Location = new System.Drawing.Point(151, 33);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(100, 24);
            this.txtRego.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(151, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(273, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CheckTruckDriver
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 451);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(regoLabel);
            this.Controls.Add(this.txtRego);
            this.Controls.Add(lastSeenLabel);
            this.Controls.Add(this.lastSeenTextBox);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(driverLabel);
            this.Controls.Add(this.driverTextBox);
            this.Controls.Add(this.btnFind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckTruckDriver";
            this.Text = "CheckTruckDriver";
            this.Load += new System.EventHandler(this.CheckTruckDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckTruckDriver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsCheckTruckDriver;
        private dsTIQ2TableAdapters.CheckTruckDriverTableAdapter taCheckTruckDriver;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox lastSeenTextBox;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.Button btnClose;
    }
}