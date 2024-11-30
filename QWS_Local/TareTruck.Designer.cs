namespace QWS_Local
{
    partial class TareTruck
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
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label tareTkLabel;
            this.btnUpdateTare = new System.Windows.Forms.Button();
            this.txtTareTk = new System.Windows.Forms.TextBox();
            this.txtTare = new System.Windows.Forms.TextBox();
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.bsTIQ = new System.Windows.Forms.BindingSource(this.components);
            this.taTIQ = new QWS_Local.dsTIQ2TableAdapters.TIQTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.truckConfigTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerCodeTextBox = new System.Windows.Forms.TextBox();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.tareTkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            tareLabel = new System.Windows.Forms.Label();
            tareTkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(167, 150);
            tareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 18);
            tareLabel.TabIndex = 15;
            tareLabel.Text = "Tare:";
            // 
            // tareTkLabel
            // 
            tareTkLabel.AutoSize = true;
            tareTkLabel.Location = new System.Drawing.Point(414, 149);
            tareTkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tareTkLabel.Name = "tareTkLabel";
            tareTkLabel.Size = new System.Drawing.Size(63, 18);
            tareTkLabel.TabIndex = 17;
            tareTkLabel.Text = "Tare Tk:";
            // 
            // btnUpdateTare
            // 
            this.btnUpdateTare.Location = new System.Drawing.Point(365, 316);
            this.btnUpdateTare.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTare.Name = "btnUpdateTare";
            this.btnUpdateTare.Size = new System.Drawing.Size(261, 53);
            this.btnUpdateTare.TabIndex = 0;
            this.btnUpdateTare.Text = "Update";
            this.btnUpdateTare.UseVisualStyleBackColor = true;
            this.btnUpdateTare.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTareTk
            // 
            this.txtTareTk.Location = new System.Drawing.Point(485, 37);
            this.txtTareTk.Margin = new System.Windows.Forms.Padding(4);
            this.txtTareTk.Name = "txtTareTk";
            this.txtTareTk.Size = new System.Drawing.Size(100, 24);
            this.txtTareTk.TabIndex = 1;
            // 
            // txtTare
            // 
            this.txtTare.Location = new System.Drawing.Point(224, 37);
            this.txtTare.Margin = new System.Windows.Forms.Padding(4);
            this.txtTare.Name = "txtTare";
            this.txtTare.Size = new System.Drawing.Size(100, 24);
            this.txtTare.TabIndex = 2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsTIQ
            // 
            this.bsTIQ.DataMember = "TIQ";
            this.bsTIQ.DataSource = this.dsTIQ2;
            // 
            // taTIQ
            // 
            this.taTIQ.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StockpileBOMTableAdapter = null;
            this.tableAdapterManager.StockpileLotAllocationTableAdapter = null;
            this.tableAdapterManager.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager.TIQTableAdapter = this.taTIQ;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = null;
            // 
            // regoTextBox
            // 
            this.regoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(25, 31);
            this.regoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.ReadOnly = true;
            this.regoTextBox.Size = new System.Drawing.Size(148, 24);
            this.regoTextBox.TabIndex = 6;
            // 
            // truckConfigTextBox
            // 
            this.truckConfigTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.truckConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckConfig", true));
            this.truckConfigTextBox.Location = new System.Drawing.Point(181, 31);
            this.truckConfigTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckConfigTextBox.Name = "truckConfigTextBox";
            this.truckConfigTextBox.ReadOnly = true;
            this.truckConfigTextBox.Size = new System.Drawing.Size(56, 24);
            this.truckConfigTextBox.TabIndex = 7;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(245, 31);
            this.axleConfigurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.ReadOnly = true;
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(48, 24);
            this.axleConfigurationTextBox.TabIndex = 8;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(25, 64);
            this.truckOwnerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.ReadOnly = true;
            this.truckOwnerTextBox.Size = new System.Drawing.Size(452, 24);
            this.truckOwnerTextBox.TabIndex = 10;
            // 
            // truckOwnerCodeTextBox
            // 
            this.truckOwnerCodeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.truckOwnerCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwnerCode", true));
            this.truckOwnerCodeTextBox.Location = new System.Drawing.Point(485, 64);
            this.truckOwnerCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckOwnerCodeTextBox.Name = "truckOwnerCodeTextBox";
            this.truckOwnerCodeTextBox.ReadOnly = true;
            this.truckOwnerCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.truckOwnerCodeTextBox.TabIndex = 12;
            // 
            // driverTextBox
            // 
            this.driverTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(25, 96);
            this.driverTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.ReadOnly = true;
            this.driverTextBox.Size = new System.Drawing.Size(268, 24);
            this.driverTextBox.TabIndex = 14;
            // 
            // tareTextBox
            // 
            this.tareTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(224, 146);
            this.tareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.ReadOnly = true;
            this.tareTextBox.Size = new System.Drawing.Size(100, 24);
            this.tareTextBox.TabIndex = 16;
            // 
            // tareTkTextBox
            // 
            this.tareTkTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tareTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TareTk", true));
            this.tareTkTextBox.Location = new System.Drawing.Point(485, 145);
            this.tareTkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tareTkTextBox.Name = "tareTkTextBox";
            this.tareTkTextBox.ReadOnly = true;
            this.tareTkTextBox.Size = new System.Drawing.Size(100, 24);
            this.tareTkTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tare Tk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tare";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(23, 316);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(313, 53);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTareTk);
            this.groupBox1.Controls.Add(this.txtTare);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 82);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Tare Values";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.regoTextBox);
            this.groupBox2.Controls.Add(this.truckConfigTextBox);
            this.groupBox2.Controls.Add(tareTkLabel);
            this.groupBox2.Controls.Add(this.tareTkTextBox);
            this.groupBox2.Controls.Add(this.axleConfigurationTextBox);
            this.groupBox2.Controls.Add(tareLabel);
            this.groupBox2.Controls.Add(this.tareTextBox);
            this.groupBox2.Controls.Add(this.truckOwnerTextBox);
            this.groupBox2.Controls.Add(this.driverTextBox);
            this.groupBox2.Controls.Add(this.truckOwnerCodeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 189);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Values";
            // 
            // TareTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 399);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateTare);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TareTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tare Truck";
            this.Load += new System.EventHandler(this.TareTruck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateTare;
        private System.Windows.Forms.TextBox txtTareTk;
        private System.Windows.Forms.TextBox txtTare;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsTIQ;
        private dsTIQ2TableAdapters.TIQTableAdapter taTIQ;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox regoTextBox;
        private System.Windows.Forms.TextBox truckConfigTextBox;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox truckOwnerCodeTextBox;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.TextBox tareTkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}