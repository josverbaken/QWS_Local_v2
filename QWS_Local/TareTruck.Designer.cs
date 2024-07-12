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
            this.button1 = new System.Windows.Forms.Button();
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
            regoLabel = new System.Windows.Forms.Label();
            truckConfigLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            truckOwnerCodeLabel = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            tareTkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTareTk
            // 
            this.txtTareTk.Location = new System.Drawing.Point(268, 41);
            this.txtTareTk.Name = "txtTareTk";
            this.txtTareTk.Size = new System.Drawing.Size(100, 20);
            this.txtTareTk.TabIndex = 1;
            // 
            // txtTare
            // 
            this.txtTare.Location = new System.Drawing.Point(268, 68);
            this.txtTare.Name = "txtTare";
            this.txtTare.Size = new System.Drawing.Size(100, 20);
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
            this.tableAdapterManager.TIQTableAdapter = this.taTIQ;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = null;
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(254, 128);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(36, 13);
            regoLabel.TabIndex = 5;
            regoLabel.Text = "Rego:";
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(296, 125);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTextBox.TabIndex = 6;
            // 
            // truckConfigLabel
            // 
            truckConfigLabel.AutoSize = true;
            truckConfigLabel.Location = new System.Drawing.Point(219, 154);
            truckConfigLabel.Name = "truckConfigLabel";
            truckConfigLabel.Size = new System.Drawing.Size(71, 13);
            truckConfigLabel.TabIndex = 6;
            truckConfigLabel.Text = "Truck Config:";
            // 
            // truckConfigTextBox
            // 
            this.truckConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckConfig", true));
            this.truckConfigTextBox.Location = new System.Drawing.Point(296, 151);
            this.truckConfigTextBox.Name = "truckConfigTextBox";
            this.truckConfigTextBox.Size = new System.Drawing.Size(100, 20);
            this.truckConfigTextBox.TabIndex = 7;
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(195, 180);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(95, 13);
            axleConfigurationLabel.TabIndex = 7;
            axleConfigurationLabel.Text = "Axle Configuration:";
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(296, 177);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.axleConfigurationTextBox.TabIndex = 8;
            // 
            // truckOwnerLabel
            // 
            truckOwnerLabel.AutoSize = true;
            truckOwnerLabel.Location = new System.Drawing.Point(218, 206);
            truckOwnerLabel.Name = "truckOwnerLabel";
            truckOwnerLabel.Size = new System.Drawing.Size(72, 13);
            truckOwnerLabel.TabIndex = 9;
            truckOwnerLabel.Text = "Truck Owner:";
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(296, 203);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.Size = new System.Drawing.Size(100, 20);
            this.truckOwnerTextBox.TabIndex = 10;
            // 
            // truckOwnerCodeLabel
            // 
            truckOwnerCodeLabel.AutoSize = true;
            truckOwnerCodeLabel.Location = new System.Drawing.Point(190, 232);
            truckOwnerCodeLabel.Name = "truckOwnerCodeLabel";
            truckOwnerCodeLabel.Size = new System.Drawing.Size(100, 13);
            truckOwnerCodeLabel.TabIndex = 11;
            truckOwnerCodeLabel.Text = "Truck Owner Code:";
            // 
            // truckOwnerCodeTextBox
            // 
            this.truckOwnerCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TruckOwnerCode", true));
            this.truckOwnerCodeTextBox.Location = new System.Drawing.Point(296, 229);
            this.truckOwnerCodeTextBox.Name = "truckOwnerCodeTextBox";
            this.truckOwnerCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.truckOwnerCodeTextBox.TabIndex = 12;
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(252, 258);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(38, 13);
            driverLabel.TabIndex = 13;
            driverLabel.Text = "Driver:";
            // 
            // driverTextBox
            // 
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(296, 255);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.Size = new System.Drawing.Size(100, 20);
            this.driverTextBox.TabIndex = 14;
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(258, 284);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(32, 13);
            tareLabel.TabIndex = 15;
            tareLabel.Text = "Tare:";
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(296, 281);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(100, 20);
            this.tareTextBox.TabIndex = 16;
            // 
            // tareTkLabel
            // 
            tareTkLabel.AutoSize = true;
            tareTkLabel.Location = new System.Drawing.Point(242, 310);
            tareTkLabel.Name = "tareTkLabel";
            tareTkLabel.Size = new System.Drawing.Size(48, 13);
            tareTkLabel.TabIndex = 17;
            tareTkLabel.Text = "Tare Tk:";
            // 
            // tareTkTextBox
            // 
            this.tareTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ, "TareTk", true));
            this.tareTkTextBox.Location = new System.Drawing.Point(296, 307);
            this.tareTkTextBox.Name = "tareTkTextBox";
            this.tareTkTextBox.Size = new System.Drawing.Size(100, 20);
            this.tareTkTextBox.TabIndex = 18;
            // 
            // TareTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.button1);
            this.Name = "TareTruck";
            this.Text = "TareTruck";
            this.Load += new System.EventHandler(this.TareTruck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}