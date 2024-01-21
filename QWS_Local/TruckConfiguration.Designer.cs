
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
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label regoTkLabel;
            this.txtRego = new System.Windows.Forms.TextBox();
            this.bsVehicleDetails = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.bsConfiguredTnt = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAllConfig = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFindVehicle = new System.Windows.Forms.Button();
            this.maxLengthTextBox = new System.Windows.Forms.TextBox();
            this.bsNHVL = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddVehicle2Config = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.taConfiguredTnT = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter();
            this.taVehicleDetails = new QWS_Local.dsQWSLocalTableAdapters.VehicleDetailsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.taVehicle = new QWS_Local.dsQWSLocalTableAdapters.VehicleTableAdapter();
            this.taNHVL = new QWS_Local.dsQWSLocalTableAdapters.NHVLTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RegoTk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoTrailer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AxleConfiguration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BridgeAssessment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.regoTkTextBox = new System.Windows.Forms.TextBox();
            tareLabel = new System.Windows.Forms.Label();
            regoTkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRego
            // 
            this.txtRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "Rego", true));
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.Location = new System.Drawing.Point(22, 25);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(100, 24);
            this.txtRego.TabIndex = 3;
            // 
            // bsVehicleDetails
            // 
            this.bsVehicleDetails.DataMember = "VehicleDetails";
            this.bsVehicleDetails.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsConfiguredTnt
            // 
            this.bsConfiguredTnt.DataMember = "ConfiguredTnT";
            this.bsConfiguredTnt.DataSource = this.dsTruckConfig;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicleDetails, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(254, 29);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(99, 20);
            this.axleConfigurationTextBox.TabIndex = 8;
            // 
            // bsVehicle
            // 
            this.bsVehicle.DataMember = "Vehicle";
            this.bsVehicle.DataSource = this.dsQWSLocal;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnShowAllConfig);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnFindVehicle);
            this.groupBox1.Controls.Add(this.txtRego);
            this.groupBox1.Controls.Add(this.axleConfigurationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(28, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 94);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Vehicle";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Single";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowAllConfig
            // 
            this.btnShowAllConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllConfig.Location = new System.Drawing.Point(128, 56);
            this.btnShowAllConfig.Name = "btnShowAllConfig";
            this.btnShowAllConfig.Size = new System.Drawing.Size(120, 24);
            this.btnShowAllConfig.TabIndex = 19;
            this.btnShowAllConfig.Text = "Show All";
            this.btnShowAllConfig.UseVisualStyleBackColor = true;
            this.btnShowAllConfig.Click += new System.EventHandler(this.btnShowAllConfig_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsVehicleDetails, "IsLeadVehicle", true));
            this.checkBox1.Location = new System.Drawing.Point(254, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Is Lead Vehicle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindVehicle.Location = new System.Drawing.Point(128, 25);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(120, 24);
            this.btnFindVehicle.TabIndex = 17;
            this.btnFindVehicle.Text = "Search";
            this.btnFindVehicle.UseVisualStyleBackColor = true;
            this.btnFindVehicle.Click += new System.EventHandler(this.btnFindVehicle_Click);
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsNHVL, "MaxLength", true));
            this.maxLengthTextBox.Location = new System.Drawing.Point(822, 83);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxLengthTextBox.TabIndex = 19;
            // 
            // bsNHVL
            // 
            this.bsNHVL.DataMember = "NHVL";
            this.bsNHVL.DataSource = this.dsQWSLocal;
            // 
            // btnAddVehicle2Config
            // 
            this.btnAddVehicle2Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle2Config.Location = new System.Drawing.Point(603, 47);
            this.btnAddVehicle2Config.Name = "btnAddVehicle2Config";
            this.btnAddVehicle2Config.Size = new System.Drawing.Size(140, 69);
            this.btnAddVehicle2Config.TabIndex = 18;
            this.btnAddVehicle2Config.Text = "Add Config";
            this.btnAddVehicle2Config.UseVisualStyleBackColor = true;
            this.btnAddVehicle2Config.Click += new System.EventHandler(this.btnAddVehicle2Config_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taConfiguredTnT
            // 
            this.taConfiguredTnT.ClearBeforeFill = true;
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
            this.tableAdapterManager.VehiclePBSTableAdapter = null;
            this.tableAdapterManager.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.VehicleTypeTableAdapter = null;
            // 
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // taNHVL
            // 
            this.taNHVL.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegoTk,
            this.RegoTrailer,
            this.AxleConfiguration,
            this.GCM,
            this.Tare,
            this.TareDT,
            this.configSourceDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.Scheme,
            this.BridgeAssessment});
            this.dataGridView2.DataSource = this.bsConfiguredTnt;
            this.dataGridView2.Location = new System.Drawing.Point(50, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1031, 257);
            this.dataGridView2.TabIndex = 22;
            // 
            // RegoTk
            // 
            this.RegoTk.DataPropertyName = "RegoTk";
            this.RegoTk.HeaderText = "Truck";
            this.RegoTk.Name = "RegoTk";
            this.RegoTk.ReadOnly = true;
            // 
            // RegoTrailer
            // 
            this.RegoTrailer.DataPropertyName = "RegoTrailer";
            this.RegoTrailer.HeaderText = "Trailer";
            this.RegoTrailer.Name = "RegoTrailer";
            this.RegoTrailer.ReadOnly = true;
            this.RegoTrailer.Width = 200;
            // 
            // AxleConfiguration
            // 
            this.AxleConfiguration.DataPropertyName = "AxleConfiguration";
            this.AxleConfiguration.HeaderText = "Axle Cfg";
            this.AxleConfiguration.Name = "AxleConfiguration";
            this.AxleConfiguration.ReadOnly = true;
            // 
            // GCM
            // 
            this.GCM.DataPropertyName = "GCM";
            this.GCM.HeaderText = "GCM";
            this.GCM.Name = "GCM";
            this.GCM.ReadOnly = true;
            // 
            // Tare
            // 
            this.Tare.DataPropertyName = "Tare";
            this.Tare.HeaderText = "Tare";
            this.Tare.Name = "Tare";
            this.Tare.ReadOnly = true;
            // 
            // TareDT
            // 
            this.TareDT.DataPropertyName = "TareDT";
            this.TareDT.HeaderText = "Tare Date";
            this.TareDT.Name = "TareDT";
            this.TareDT.ReadOnly = true;
            // 
            // configSourceDataGridViewTextBoxColumn
            // 
            this.configSourceDataGridViewTextBoxColumn.DataPropertyName = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.HeaderText = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.Name = "configSourceDataGridViewTextBoxColumn";
            this.configSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.configSourceDataGridViewTextBoxColumn.Width = 200;
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            this.schemeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Scheme
            // 
            this.Scheme.DataPropertyName = "Scheme";
            this.Scheme.HeaderText = "Scheme";
            this.Scheme.Name = "Scheme";
            this.Scheme.ReadOnly = true;
            this.Scheme.Width = 200;
            // 
            // BridgeAssessment
            // 
            this.BridgeAssessment.DataPropertyName = "BridgeAssessment";
            this.BridgeAssessment.HeaderText = "BridgeAssessment";
            this.BridgeAssessment.Name = "BridgeAssessment";
            this.BridgeAssessment.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsConfiguredTnt, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(50, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(400, 137);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardCodeTextBox.TabIndex = 25;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(50, 137);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(344, 20);
            this.ownerTextBox.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(603, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(590, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 160);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(regoTkLabel);
            this.tabPage2.Controls.Add(this.regoTkTextBox);
            this.tabPage2.Controls.Add(tareLabel);
            this.tabPage2.Controls.Add(this.tareTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(28, 52);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(32, 13);
            tareLabel.TabIndex = 0;
            tareLabel.Text = "Tare:";
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(66, 49);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.Size = new System.Drawing.Size(100, 20);
            this.tareTextBox.TabIndex = 1;
            // 
            // regoTkLabel
            // 
            regoTkLabel.AutoSize = true;
            regoTkLabel.Location = new System.Drawing.Point(34, 20);
            regoTkLabel.Name = "regoTkLabel";
            regoTkLabel.Size = new System.Drawing.Size(52, 13);
            regoTkLabel.TabIndex = 2;
            regoTkLabel.Text = "Rego Tk:";
            // 
            // regoTkTextBox
            // 
            this.regoTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnt, "RegoTk", true));
            this.regoTkTextBox.Location = new System.Drawing.Point(92, 17);
            this.regoTkTextBox.Name = "regoTkTextBox";
            this.regoTkTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTkTextBox.TabIndex = 3;
            // 
            // TruckConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 831);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cardCodeTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maxLengthTextBox);
            this.Controls.Add(this.btnAddVehicle2Config);
            this.Controls.Add(this.groupBox1);
            this.Name = "TruckConfiguration";
            this.Text = "Truck Configuration";
            this.Load += new System.EventHandler(this.TruckConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsVehicleDetails;
        private dsQWSLocalTableAdapters.VehicleDetailsTableAdapter taVehicleDetails;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.BindingSource bsVehicle;
        private dsQWSLocalTableAdapters.VehicleTableAdapter taVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddVehicle2Config;
        private dsTruckConfig dsTruckConfig;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnFindVehicle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnShowAllConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsNHVL;
        private dsQWSLocalTableAdapters.NHVLTableAdapter taNHVL;
        private System.Windows.Forms.TextBox maxLengthTextBox;
        private System.Windows.Forms.BindingSource bsConfiguredTnt;
        private dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter taConfiguredTnT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegoTk;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegoTrailer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AxleConfiguration;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn configSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BridgeAssessment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox regoTkTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
    }
}