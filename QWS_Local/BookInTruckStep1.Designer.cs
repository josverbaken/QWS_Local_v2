
namespace QWS_Local
{
    partial class BookInTruckStep1
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
            this.pictureSchematic = new System.Windows.Forms.PictureBox();
            this.txtTruckRego = new System.Windows.Forms.TextBox();
            this.btnFindTruck = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.taConfiguredTrucks = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.regoTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoTrailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forceRetareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.retareEverytimeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nHVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bsConfiguredTruckGVM = new System.Windows.Forms.BindingSource(this.components);
            this.taConfiguredTruckGVM = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationExpiryDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoCheckDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareDTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgeAssessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVMTruckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveAxleLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveAxleLoadUOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trTkRatioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSchematic
            // 
            this.pictureSchematic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSchematic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsConfiguredTrucks, "Schematic", true));
            this.pictureSchematic.Location = new System.Drawing.Point(63, 56);
            this.pictureSchematic.Name = "pictureSchematic";
            this.pictureSchematic.Size = new System.Drawing.Size(450, 150);
            this.pictureSchematic.TabIndex = 0;
            this.pictureSchematic.TabStop = false;
            // 
            // txtTruckRego
            // 
            this.txtTruckRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruckRego.Location = new System.Drawing.Point(63, 23);
            this.txtTruckRego.Name = "txtTruckRego";
            this.txtTruckRego.Size = new System.Drawing.Size(100, 26);
            this.txtTruckRego.TabIndex = 1;
            // 
            // btnFindTruck
            // 
            this.btnFindTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindTruck.Location = new System.Drawing.Point(183, 22);
            this.btnFindTruck.Name = "btnFindTruck";
            this.btnFindTruck.Size = new System.Drawing.Size(75, 27);
            this.btnFindTruck.TabIndex = 2;
            this.btnFindTruck.Text = "Find";
            this.btnFindTruck.UseVisualStyleBackColor = true;
            this.btnFindTruck.Click += new System.EventHandler(this.btnFindTruck_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoTkDataGridViewTextBoxColumn,
            this.regoTrailerDataGridViewTextBoxColumn,
            this.tareDataGridViewTextBoxColumn,
            this.tareDTDataGridViewTextBoxColumn,
            this.forceRetareDataGridViewCheckBoxColumn,
            this.retareEverytimeDataGridViewCheckBoxColumn,
            this.nHVLDataGridViewTextBoxColumn,
            this.PBS});
            this.dataGridView1.DataSource = this.bsConfiguredTrucks;
            this.dataGridView1.Location = new System.Drawing.Point(21, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(909, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsConfiguredTrucks
            // 
            this.bsConfiguredTrucks.DataMember = "ConfiguredTrucks";
            this.bsConfiguredTrucks.DataSource = this.dsTruckConfig;
            // 
            // taConfiguredTrucks
            // 
            this.taConfiguredTrucks.ClearBeforeFill = true;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "AxleConfiguration", true));
            this.txtAxleConfig.Location = new System.Drawing.Point(63, 212);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.Size = new System.Drawing.Size(100, 23);
            this.txtAxleConfig.TabIndex = 4;
            // 
            // txtVehicleDescription
            // 
            this.txtVehicleDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "VehicleDescription", true));
            this.txtVehicleDescription.Location = new System.Drawing.Point(169, 212);
            this.txtVehicleDescription.Name = "txtVehicleDescription";
            this.txtVehicleDescription.Size = new System.Drawing.Size(344, 23);
            this.txtVehicleDescription.TabIndex = 5;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStep.Location = new System.Drawing.Point(748, 406);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(182, 27);
            this.btnNextStep.TabIndex = 6;
            this.btnNextStep.Text = "Next Step";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // regoTkDataGridViewTextBoxColumn
            // 
            this.regoTkDataGridViewTextBoxColumn.DataPropertyName = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.HeaderText = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.Name = "regoTkDataGridViewTextBoxColumn";
            this.regoTkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regoTrailerDataGridViewTextBoxColumn
            // 
            this.regoTrailerDataGridViewTextBoxColumn.DataPropertyName = "RegoTrailer";
            this.regoTrailerDataGridViewTextBoxColumn.HeaderText = "RegoTrailer";
            this.regoTrailerDataGridViewTextBoxColumn.Name = "regoTrailerDataGridViewTextBoxColumn";
            this.regoTrailerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tareDataGridViewTextBoxColumn
            // 
            this.tareDataGridViewTextBoxColumn.DataPropertyName = "Tare";
            this.tareDataGridViewTextBoxColumn.HeaderText = "Tare";
            this.tareDataGridViewTextBoxColumn.Name = "tareDataGridViewTextBoxColumn";
            this.tareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tareDTDataGridViewTextBoxColumn
            // 
            this.tareDTDataGridViewTextBoxColumn.DataPropertyName = "TareDT";
            this.tareDTDataGridViewTextBoxColumn.HeaderText = "TareDT";
            this.tareDTDataGridViewTextBoxColumn.Name = "tareDTDataGridViewTextBoxColumn";
            this.tareDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forceRetareDataGridViewCheckBoxColumn
            // 
            this.forceRetareDataGridViewCheckBoxColumn.DataPropertyName = "ForceRetare";
            this.forceRetareDataGridViewCheckBoxColumn.HeaderText = "ForceRetare";
            this.forceRetareDataGridViewCheckBoxColumn.Name = "forceRetareDataGridViewCheckBoxColumn";
            this.forceRetareDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // retareEverytimeDataGridViewCheckBoxColumn
            // 
            this.retareEverytimeDataGridViewCheckBoxColumn.DataPropertyName = "RetareEverytime";
            this.retareEverytimeDataGridViewCheckBoxColumn.HeaderText = "RetareEverytime";
            this.retareEverytimeDataGridViewCheckBoxColumn.Name = "retareEverytimeDataGridViewCheckBoxColumn";
            this.retareEverytimeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nHVLDataGridViewTextBoxColumn
            // 
            this.nHVLDataGridViewTextBoxColumn.DataPropertyName = "NHVL";
            this.nHVLDataGridViewTextBoxColumn.HeaderText = "NHVL";
            this.nHVLDataGridViewTextBoxColumn.Name = "nHVLDataGridViewTextBoxColumn";
            this.nHVLDataGridViewTextBoxColumn.ReadOnly = true;
            this.nHVLDataGridViewTextBoxColumn.Width = 200;
            // 
            // PBS
            // 
            this.PBS.HeaderText = "PBS Applies";
            this.PBS.Name = "PBS";
            this.PBS.ReadOnly = true;
            // 
            // btnNextForm
            // 
            this.btnNextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextForm.Location = new System.Drawing.Point(748, 611);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(182, 27);
            this.btnNextForm.TabIndex = 7;
            this.btnNextForm.Text = "Next Form";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardCodeDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.cardStatusDataGridViewTextBoxColumn,
            this.registrationExpiryDTDataGridViewTextBoxColumn,
            this.regoCheckDataGridViewCheckBoxColumn,
            this.tareDataGridViewTextBoxColumn1,
            this.tareTkDataGridViewTextBoxColumn,
            this.tareDTDataGridViewTextBoxColumn1,
            this.axleConfigurationDataGridViewTextBoxColumn,
            this.configSourceDataGridViewTextBoxColumn,
            this.pBSLevelDataGridViewTextBoxColumn,
            this.bridgeAssessmentDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.schemeDataGridViewTextBoxColumn,
            this.gCMDataGridViewTextBoxColumn,
            this.gVMTruckDataGridViewTextBoxColumn,
            this.driveAxleLoadDataGridViewTextBoxColumn,
            this.driveAxleLoadUOMDataGridViewTextBoxColumn,
            this.trTkRatioDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsConfiguredTruckGVM;
            this.dataGridView2.Location = new System.Drawing.Point(21, 443);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(909, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // bsConfiguredTruckGVM
            // 
            this.bsConfiguredTruckGVM.DataMember = "ConfiguredTruckGVM";
            this.bsConfiguredTruckGVM.DataSource = this.dsTruckConfig;
            // 
            // taConfiguredTruckGVM
            // 
            this.taConfiguredTruckGVM.ClearBeforeFill = true;
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            this.cardCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardStatusDataGridViewTextBoxColumn
            // 
            this.cardStatusDataGridViewTextBoxColumn.DataPropertyName = "CardStatus";
            this.cardStatusDataGridViewTextBoxColumn.HeaderText = "CardStatus";
            this.cardStatusDataGridViewTextBoxColumn.Name = "cardStatusDataGridViewTextBoxColumn";
            this.cardStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationExpiryDTDataGridViewTextBoxColumn
            // 
            this.registrationExpiryDTDataGridViewTextBoxColumn.DataPropertyName = "RegistrationExpiryDT";
            this.registrationExpiryDTDataGridViewTextBoxColumn.HeaderText = "RegistrationExpiryDT";
            this.registrationExpiryDTDataGridViewTextBoxColumn.Name = "registrationExpiryDTDataGridViewTextBoxColumn";
            this.registrationExpiryDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regoCheckDataGridViewCheckBoxColumn
            // 
            this.regoCheckDataGridViewCheckBoxColumn.DataPropertyName = "RegoCheck";
            this.regoCheckDataGridViewCheckBoxColumn.HeaderText = "RegoCheck";
            this.regoCheckDataGridViewCheckBoxColumn.Name = "regoCheckDataGridViewCheckBoxColumn";
            this.regoCheckDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tareDataGridViewTextBoxColumn1
            // 
            this.tareDataGridViewTextBoxColumn1.DataPropertyName = "Tare";
            this.tareDataGridViewTextBoxColumn1.HeaderText = "Tare";
            this.tareDataGridViewTextBoxColumn1.Name = "tareDataGridViewTextBoxColumn1";
            this.tareDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tareTkDataGridViewTextBoxColumn
            // 
            this.tareTkDataGridViewTextBoxColumn.DataPropertyName = "TareTk";
            this.tareTkDataGridViewTextBoxColumn.HeaderText = "TareTk";
            this.tareTkDataGridViewTextBoxColumn.Name = "tareTkDataGridViewTextBoxColumn";
            this.tareTkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tareDTDataGridViewTextBoxColumn1
            // 
            this.tareDTDataGridViewTextBoxColumn1.DataPropertyName = "TareDT";
            this.tareDTDataGridViewTextBoxColumn1.HeaderText = "TareDT";
            this.tareDTDataGridViewTextBoxColumn1.Name = "tareDTDataGridViewTextBoxColumn1";
            this.tareDTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            this.axleConfigurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // configSourceDataGridViewTextBoxColumn
            // 
            this.configSourceDataGridViewTextBoxColumn.DataPropertyName = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.HeaderText = "ConfigSource";
            this.configSourceDataGridViewTextBoxColumn.Name = "configSourceDataGridViewTextBoxColumn";
            this.configSourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pBSLevelDataGridViewTextBoxColumn
            // 
            this.pBSLevelDataGridViewTextBoxColumn.DataPropertyName = "PBS_Level";
            this.pBSLevelDataGridViewTextBoxColumn.HeaderText = "PBS_Level";
            this.pBSLevelDataGridViewTextBoxColumn.Name = "pBSLevelDataGridViewTextBoxColumn";
            this.pBSLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bridgeAssessmentDataGridViewTextBoxColumn
            // 
            this.bridgeAssessmentDataGridViewTextBoxColumn.DataPropertyName = "BridgeAssessment";
            this.bridgeAssessmentDataGridViewTextBoxColumn.HeaderText = "BridgeAssessment";
            this.bridgeAssessmentDataGridViewTextBoxColumn.Name = "bridgeAssessmentDataGridViewTextBoxColumn";
            this.bridgeAssessmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            this.schemeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemeDataGridViewTextBoxColumn
            // 
            this.schemeDataGridViewTextBoxColumn.DataPropertyName = "Scheme";
            this.schemeDataGridViewTextBoxColumn.HeaderText = "Scheme";
            this.schemeDataGridViewTextBoxColumn.Name = "schemeDataGridViewTextBoxColumn";
            this.schemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
            this.gCMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gVMTruckDataGridViewTextBoxColumn
            // 
            this.gVMTruckDataGridViewTextBoxColumn.DataPropertyName = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.HeaderText = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.Name = "gVMTruckDataGridViewTextBoxColumn";
            this.gVMTruckDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveAxleLoadDataGridViewTextBoxColumn
            // 
            this.driveAxleLoadDataGridViewTextBoxColumn.DataPropertyName = "DriveAxleLoad";
            this.driveAxleLoadDataGridViewTextBoxColumn.HeaderText = "DriveAxleLoad";
            this.driveAxleLoadDataGridViewTextBoxColumn.Name = "driveAxleLoadDataGridViewTextBoxColumn";
            this.driveAxleLoadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveAxleLoadUOMDataGridViewTextBoxColumn
            // 
            this.driveAxleLoadUOMDataGridViewTextBoxColumn.DataPropertyName = "DriveAxleLoadUOM";
            this.driveAxleLoadUOMDataGridViewTextBoxColumn.HeaderText = "DriveAxleLoadUOM";
            this.driveAxleLoadUOMDataGridViewTextBoxColumn.Name = "driveAxleLoadUOMDataGridViewTextBoxColumn";
            this.driveAxleLoadUOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trTkRatioDataGridViewTextBoxColumn
            // 
            this.trTkRatioDataGridViewTextBoxColumn.DataPropertyName = "TrTkRatio";
            this.trTkRatioDataGridViewTextBoxColumn.HeaderText = "TrTkRatio";
            this.trTkRatioDataGridViewTextBoxColumn.Name = "trTkRatioDataGridViewTextBoxColumn";
            this.trTkRatioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookInTruckStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.txtVehicleDescription);
            this.Controls.Add(this.txtAxleConfig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindTruck);
            this.Controls.Add(this.txtTruckRego);
            this.Controls.Add(this.pictureSchematic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookInTruckStep1";
            this.Text = "BookInTruckStep1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSchematic;
        private System.Windows.Forms.BindingSource bsConfiguredTrucks;
        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.TextBox txtTruckRego;
        private System.Windows.Forms.Button btnFindTruck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter taConfiguredTrucks;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.TextBox txtVehicleDescription;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTrailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn forceRetareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn retareEverytimeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PBS;
        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationExpiryDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn regoCheckDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgeAssessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVMTruckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveAxleLoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveAxleLoadUOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trTkRatioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsConfiguredTruckGVM;
        private dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter taConfiguredTruckGVM;
    }
}