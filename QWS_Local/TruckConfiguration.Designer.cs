
namespace QWS_Local
{
    partial class TruckConfiguration
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
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label axleConfigurationLabel;
            System.Windows.Forms.Label feeCodeLabel;
            System.Windows.Forms.Label vehicleDescriptionLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.bsVehicleDetails = new System.Windows.Forms.BindingSource(this.components);
            this.taVehicleDetails = new QWS_Local.dsQWSLocalTableAdapters.VehicleDetailsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.vehicleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.pbSchematic = new System.Windows.Forms.PictureBox();
            this.chkIsLeadVehicle = new System.Windows.Forms.CheckBox();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.taVehicle = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            regoLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            feeCodeLabel = new System.Windows.Forms.Label();
            vehicleDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(112, 41);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(36, 13);
            regoLabel.TabIndex = 2;
            regoLabel.Text = "Rego:";
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(107, 15);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(41, 13);
            ownerLabel.TabIndex = 3;
            ownerLabel.Text = "Owner:";
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(403, 225);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(95, 13);
            axleConfigurationLabel.TabIndex = 7;
            axleConfigurationLabel.Text = "Axle Configuration:";
            // 
            // feeCodeLabel
            // 
            feeCodeLabel.AutoSize = true;
            feeCodeLabel.Location = new System.Drawing.Point(442, 41);
            feeCodeLabel.Name = "feeCodeLabel";
            feeCodeLabel.Size = new System.Drawing.Size(56, 13);
            feeCodeLabel.TabIndex = 9;
            feeCodeLabel.Text = "Fee Code:";
            // 
            // vehicleDescriptionLabel
            // 
            vehicleDescriptionLabel.AutoSize = true;
            vehicleDescriptionLabel.Location = new System.Drawing.Point(293, 251);
            vehicleDescriptionLabel.Name = "vehicleDescriptionLabel";
            vehicleDescriptionLabel.Size = new System.Drawing.Size(101, 13);
            vehicleDescriptionLabel.TabIndex = 11;
            vehicleDescriptionLabel.Text = "Vehicle Description:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsVehicleDetails
            // 
            this.bsVehicleDetails.DataMember = "VehicleDetails";
            this.bsVehicleDetails.DataSource = this.dsQWSLocal;
            // 
            // taVehicleDetails
            // 
            this.taVehicleDetails.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.NHVLTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.SchemeCodesTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TruckConfigVehicleTableAdapter = null;
            this.tableAdapterManager.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.VehicleTypeTableAdapter = null;
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(154, 38);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTextBox.TabIndex = 3;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(260, 12);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(344, 20);
            this.ownerTextBox.TabIndex = 4;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(154, 12);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardCodeTextBox.TabIndex = 6;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(504, 222);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.axleConfigurationTextBox.TabIndex = 8;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(504, 38);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.feeCodeTextBox.TabIndex = 10;
            // 
            // vehicleDescriptionTextBox
            // 
            this.vehicleDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "VehicleDescription", true));
            this.vehicleDescriptionTextBox.Location = new System.Drawing.Point(400, 248);
            this.vehicleDescriptionTextBox.Name = "vehicleDescriptionTextBox";
            this.vehicleDescriptionTextBox.Size = new System.Drawing.Size(204, 20);
            this.vehicleDescriptionTextBox.TabIndex = 12;
            // 
            // pbSchematic
            // 
            this.pbSchematic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsVehicleDetails, "Schematic", true));
            this.pbSchematic.Location = new System.Drawing.Point(154, 64);
            this.pbSchematic.Name = "pbSchematic";
            this.pbSchematic.Size = new System.Drawing.Size(450, 150);
            this.pbSchematic.TabIndex = 14;
            this.pbSchematic.TabStop = false;
            // 
            // chkIsLeadVehicle
            // 
            this.chkIsLeadVehicle.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsVehicleDetails, "IsLeadVehicle", true));
            this.chkIsLeadVehicle.Enabled = false;
            this.chkIsLeadVehicle.Location = new System.Drawing.Point(154, 220);
            this.chkIsLeadVehicle.Name = "chkIsLeadVehicle";
            this.chkIsLeadVehicle.Size = new System.Drawing.Size(104, 24);
            this.chkIsLeadVehicle.TabIndex = 16;
            this.chkIsLeadVehicle.Text = "Is Lead Vehicle";
            this.chkIsLeadVehicle.UseVisualStyleBackColor = true;
            // 
            // bsVehicle
            // 
            this.bsVehicle.DataMember = "Vehicle";
            this.bsVehicle.DataSource = this.dsQWSLocal;
            // 
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn,
            this.axleConfigurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsVehicle;
            this.dataGridView1.Location = new System.Drawing.Point(691, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 323);
            this.dataGridView1.TabIndex = 17;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(823, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TruckConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 761);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkIsLeadVehicle);
            this.Controls.Add(this.pbSchematic);
            this.Controls.Add(vehicleDescriptionLabel);
            this.Controls.Add(this.vehicleDescriptionTextBox);
            this.Controls.Add(feeCodeLabel);
            this.Controls.Add(this.feeCodeTextBox);
            this.Controls.Add(axleConfigurationLabel);
            this.Controls.Add(this.axleConfigurationTextBox);
            this.Controls.Add(this.cardCodeTextBox);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(regoLabel);
            this.Controls.Add(this.regoTextBox);
            this.Controls.Add(this.button1);
            this.Name = "TruckConfiguration";
            this.Text = "TruckConfiguration";
            this.Load += new System.EventHandler(this.TruckConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsVehicleDetails;
        private dsQWSLocalTableAdapters.VehicleDetailsTableAdapter taVehicleDetails;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox regoTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.TextBox vehicleDescriptionTextBox;
        private System.Windows.Forms.PictureBox pbSchematic;
        private System.Windows.Forms.CheckBox chkIsLeadVehicle;
        private System.Windows.Forms.BindingSource bsVehicle;
        private dsQWSLocalTableAdapters.VehicleTableAdapter taVehicle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}