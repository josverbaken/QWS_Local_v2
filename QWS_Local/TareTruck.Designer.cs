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
            System.Windows.Forms.Label regoLabel;
            System.Windows.Forms.Label truckConfigLabel;
            System.Windows.Forms.Label axleConfigurationLabel;
            System.Windows.Forms.Label truckOwnerLabel;
            System.Windows.Forms.Label truckOwnerCodeLabel;
            System.Windows.Forms.Label driverLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label tareTkLabel;
            System.Windows.Forms.Label truckConfigIDLabel;
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
            this.truckConfigIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            regoLabel = new System.Windows.Forms.Label();
            truckConfigLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            truckOwnerCodeLabel = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            tareTkLabel = new System.Windows.Forms.Label();
            truckConfigIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).BeginInit();
            this.SuspendLayout();
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(151, 213);
            regoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(48, 18);
            regoLabel.TabIndex = 5;
            regoLabel.Text = "Rego:";
            // 
            // truckConfigLabel
            // 
            truckConfigLabel.AutoSize = true;
            truckConfigLabel.Location = new System.Drawing.Point(98, 249);
            truckConfigLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            truckConfigLabel.Name = "truckConfigLabel";
            truckConfigLabel.Size = new System.Drawing.Size(97, 18);
            truckConfigLabel.TabIndex = 6;
            truckConfigLabel.Text = "Truck Config:";
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(62, 285);
            axleConfigurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(131, 18);
            axleConfigurationLabel.TabIndex = 7;
            axleConfigurationLabel.Text = "Axle Configuration:";
            // 
            // truckOwnerLabel
            // 
            truckOwnerLabel.AutoSize = true;
            truckOwnerLabel.Location = new System.Drawing.Point(97, 321);
            truckOwnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            truckOwnerLabel.Name = "truckOwnerLabel";
            truckOwnerLabel.Size = new System.Drawing.Size(98, 18);
            truckOwnerLabel.TabIndex = 9;
            truckOwnerLabel.Text = "Truck Owner:";
            // 
            // truckOwnerCodeLabel
            // 
            truckOwnerCodeLabel.AutoSize = true;
            truckOwnerCodeLabel.Location = new System.Drawing.Point(55, 357);
            truckOwnerCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            truckOwnerCodeLabel.Name = "truckOwnerCodeLabel";
            truckOwnerCodeLabel.Size = new System.Drawing.Size(138, 18);
            truckOwnerCodeLabel.TabIndex = 11;
            truckOwnerCodeLabel.Text = "Truck Owner Code:";
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(148, 393);
            driverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(51, 18);
            driverLabel.TabIndex = 13;
            driverLabel.Text = "Driver:";
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(157, 429);
            tareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 18);
            tareLabel.TabIndex = 15;
            tareLabel.Text = "Tare:";
            // 
            // tareTkLabel
            // 
            tareTkLabel.AutoSize = true;
            tareTkLabel.Location = new System.Drawing.Point(133, 465);
            tareTkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tareTkLabel.Name = "tareTkLabel";
            tareTkLabel.Size = new System.Drawing.Size(63, 18);
            tareTkLabel.TabIndex = 17;
            tareTkLabel.Text = "Tare Tk:";
            // 
            // truckConfigIDLabel
            // 
            truckConfigIDLabel.AutoSize = true;
            truckConfigIDLabel.Location = new System.Drawing.Point(84, 52);
            truckConfigIDLabel.Name = "truckConfigIDLabel";
            truckConfigIDLabel.Size = new System.Drawing.Size(115, 18);
            truckConfigIDLabel.TabIndex = 19;
            truckConfigIDLabel.Text = "Truck Config ID:";
            // 
            // btnUpdateTare
            // 
            this.btnUpdateTare.Location = new System.Drawing.Point(214, 141);
            this.btnUpdateTare.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTare.Name = "btnUpdateTare";
            this.btnUpdateTare.Size = new System.Drawing.Size(290, 60);
            this.btnUpdateTare.TabIndex = 0;
            this.btnUpdateTare.Text = "Update";
            this.btnUpdateTare.UseVisualStyleBackColor = true;
            this.btnUpdateTare.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTareTk
            // 
            this.txtTareTk.Location = new System.Drawing.Point(214, 77);
            this.txtTareTk.Margin = new System.Windows.Forms.Padding(4);
            this.txtTareTk.Name = "txtTareTk";
            this.txtTareTk.Size = new System.Drawing.Size(148, 24);
            this.txtTareTk.TabIndex = 1;
            // 
            // txtTare
            // 
            this.txtTare.Location = new System.Drawing.Point(214, 109);
            this.txtTare.Margin = new System.Windows.Forms.Padding(4);
            this.txtTare.Name = "txtTare";
            this.txtTare.Size = new System.Drawing.Size(148, 24);
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
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(214, 209);
            this.regoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.Size = new System.Drawing.Size(148, 24);
            this.regoTextBox.TabIndex = 6;
            // 
            // truckConfigTextBox
            // 
            this.truckConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckConfig", true));
            this.truckConfigTextBox.Location = new System.Drawing.Point(214, 245);
            this.truckConfigTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckConfigTextBox.Name = "truckConfigTextBox";
            this.truckConfigTextBox.Size = new System.Drawing.Size(148, 24);
            this.truckConfigTextBox.TabIndex = 7;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(214, 281);
            this.axleConfigurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(148, 24);
            this.axleConfigurationTextBox.TabIndex = 8;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(214, 317);
            this.truckOwnerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.Size = new System.Drawing.Size(290, 24);
            this.truckOwnerTextBox.TabIndex = 10;
            // 
            // truckOwnerCodeTextBox
            // 
            this.truckOwnerCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwnerCode", true));
            this.truckOwnerCodeTextBox.Location = new System.Drawing.Point(214, 353);
            this.truckOwnerCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.truckOwnerCodeTextBox.Name = "truckOwnerCodeTextBox";
            this.truckOwnerCodeTextBox.Size = new System.Drawing.Size(148, 24);
            this.truckOwnerCodeTextBox.TabIndex = 12;
            // 
            // driverTextBox
            // 
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(214, 389);
            this.driverTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.Size = new System.Drawing.Size(148, 24);
            this.driverTextBox.TabIndex = 14;
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(214, 425);
            this.tareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(148, 24);
            this.tareTextBox.TabIndex = 16;
            // 
            // tareTkTextBox
            // 
            this.tareTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TareTk", true));
            this.tareTkTextBox.Location = new System.Drawing.Point(214, 461);
            this.tareTkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tareTkTextBox.Name = "tareTkTextBox";
            this.tareTkTextBox.Size = new System.Drawing.Size(148, 24);
            this.tareTkTextBox.TabIndex = 18;
            // 
            // truckConfigIDTextBox
            // 
            this.truckConfigIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckConfigID", true));
            this.truckConfigIDTextBox.Location = new System.Drawing.Point(214, 46);
            this.truckConfigIDTextBox.Name = "truckConfigIDTextBox";
            this.truckConfigIDTextBox.Size = new System.Drawing.Size(148, 24);
            this.truckConfigIDTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tare Tk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tare";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 493);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(290, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TareTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 555);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(truckConfigIDLabel);
            this.Controls.Add(this.truckConfigIDTextBox);
            this.Controls.Add(tareTkLabel);
            this.Controls.Add(this.tareTkTextBox);
            this.Controls.Add(tareLabel);
            this.Controls.Add(this.tareTextBox);
            this.Controls.Add(driverLabel);
            this.Controls.Add(this.driverTextBox);
            this.Controls.Add(truckOwnerCodeLabel);
            this.Controls.Add(this.truckOwnerCodeTextBox);
            this.Controls.Add(truckOwnerLabel);
            this.Controls.Add(this.truckOwnerTextBox);
            this.Controls.Add(axleConfigurationLabel);
            this.Controls.Add(this.axleConfigurationTextBox);
            this.Controls.Add(truckConfigLabel);
            this.Controls.Add(this.truckConfigTextBox);
            this.Controls.Add(regoLabel);
            this.Controls.Add(this.regoTextBox);
            this.Controls.Add(this.txtTare);
            this.Controls.Add(this.txtTareTk);
            this.Controls.Add(this.btnUpdateTare);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TareTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tare Truck";
            this.Load += new System.EventHandler(this.TareTruck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox truckConfigIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    }
}