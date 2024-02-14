
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
            System.Windows.Forms.Label cardCodeLabel;
            System.Windows.Forms.Label truckOwnerLabel;
            System.Windows.Forms.Label cardStatusLabel;
            this.pictureSchematic = new System.Windows.Forms.PictureBox();
            this.bsConfiguredTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.txtTruckRego = new System.Windows.Forms.TextBox();
            this.btnFindTruck = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regoTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoTrailerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nHVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVMTruckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bridgeAssessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsConfiguredTruckGVM = new System.Windows.Forms.BindingSource(this.components);
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.txtCardStatus = new System.Windows.Forms.TextBox();
            this.chkACC = new System.Windows.Forms.CheckBox();
            this.taConfiguredTrucks = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTrucksTableAdapter();
            this.taConfiguredTruckGVM = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.txtFeeCode = new System.Windows.Forms.TextBox();
            this.txtFeeCodeConditions = new System.Windows.Forms.TextBox();
            cardCodeLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            cardStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTruckGVM)).BeginInit();
            this.SuspendLayout();
            // 
            // cardCodeLabel
            // 
            cardCodeLabel.AutoSize = true;
            cardCodeLabel.Location = new System.Drawing.Point(541, 59);
            cardCodeLabel.Name = "cardCodeLabel";
            cardCodeLabel.Size = new System.Drawing.Size(79, 17);
            cardCodeLabel.TabIndex = 9;
            cardCodeLabel.Text = "Card Code:";
            // 
            // truckOwnerLabel
            // 
            truckOwnerLabel.AutoSize = true;
            truckOwnerLabel.Location = new System.Drawing.Point(527, 88);
            truckOwnerLabel.Name = "truckOwnerLabel";
            truckOwnerLabel.Size = new System.Drawing.Size(93, 17);
            truckOwnerLabel.TabIndex = 11;
            truckOwnerLabel.Text = "Truck Owner:";
            // 
            // cardStatusLabel
            // 
            cardStatusLabel.AutoSize = true;
            cardStatusLabel.Location = new System.Drawing.Point(534, 117);
            cardStatusLabel.Name = "cardStatusLabel";
            cardStatusLabel.Size = new System.Drawing.Size(86, 17);
            cardStatusLabel.TabIndex = 17;
            cardStatusLabel.Text = "Card Status:";
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
            // bsConfiguredTrucks
            // 
            this.bsConfiguredTrucks.DataMember = "ConfiguredTrucks";
            this.bsConfiguredTrucks.DataSource = this.dsTruckConfig;
            this.bsConfiguredTrucks.CurrentChanged += new System.EventHandler(this.bsConfiguredTrucks_CurrentChanged);
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.RegoCheck,
            this.nHVLDataGridViewTextBoxColumn,
            this.PBS});
            this.dataGridView1.DataSource = this.bsConfiguredTrucks;
            this.dataGridView1.Location = new System.Drawing.Point(21, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(979, 150);
            this.dataGridView1.TabIndex = 3;
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
            // RegoCheck
            // 
            this.RegoCheck.DataPropertyName = "RegoCheck";
            this.RegoCheck.HeaderText = "RegoCheck";
            this.RegoCheck.Name = "RegoCheck";
            this.RegoCheck.ReadOnly = true;
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
            // btnNextForm
            // 
            this.btnNextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextForm.Location = new System.Drawing.Point(818, 599);
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
            this.gCMDataGridViewTextBoxColumn,
            this.gVMTruckDataGridViewTextBoxColumn,
            this.configSourceDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.schemeDataGridViewTextBoxColumn,
            this.pBSLevelDataGridViewTextBoxColumn,
            this.bridgeAssessmentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsConfiguredTruckGVM;
            this.dataGridView2.Location = new System.Drawing.Point(21, 443);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(979, 150);
            this.dataGridView2.TabIndex = 8;
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
            // schemeDataGridViewTextBoxColumn
            // 
            this.schemeDataGridViewTextBoxColumn.DataPropertyName = "Scheme";
            this.schemeDataGridViewTextBoxColumn.HeaderText = "Scheme";
            this.schemeDataGridViewTextBoxColumn.Name = "schemeDataGridViewTextBoxColumn";
            this.schemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.schemeDataGridViewTextBoxColumn.Width = 200;
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
            // bsConfiguredTruckGVM
            // 
            this.bsConfiguredTruckGVM.DataMember = "ConfiguredTruckGVM";
            this.bsConfiguredTruckGVM.DataSource = this.dsTruckConfig;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(626, 56);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cardCodeTextBox.TabIndex = 10;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(626, 85);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.Size = new System.Drawing.Size(374, 23);
            this.truckOwnerTextBox.TabIndex = 12;
            // 
            // txtCardStatus
            // 
            this.txtCardStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "CardStatus", true));
            this.txtCardStatus.Location = new System.Drawing.Point(626, 114);
            this.txtCardStatus.Name = "txtCardStatus";
            this.txtCardStatus.Size = new System.Drawing.Size(45, 23);
            this.txtCardStatus.TabIndex = 18;
            // 
            // chkACC
            // 
            this.chkACC.AutoSize = true;
            this.chkACC.Location = new System.Drawing.Point(626, 144);
            this.chkACC.Name = "chkACC";
            this.chkACC.Size = new System.Drawing.Size(54, 21);
            this.chkACC.TabIndex = 19;
            this.chkACC.Text = "ACC";
            this.chkACC.UseVisualStyleBackColor = true;
            // 
            // taConfiguredTrucks
            // 
            this.taConfiguredTrucks.ClearBeforeFill = true;
            // 
            // taConfiguredTruckGVM
            // 
            this.taConfiguredTruckGVM.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtFeeCode
            // 
            this.txtFeeCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "FeeCode", true));
            this.txtFeeCode.Location = new System.Drawing.Point(544, 212);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.Size = new System.Drawing.Size(76, 23);
            this.txtFeeCode.TabIndex = 20;
            // 
            // txtFeeCodeConditions
            // 
            this.txtFeeCodeConditions.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTrucks, "FeeConditions", true));
            this.txtFeeCodeConditions.Location = new System.Drawing.Point(626, 212);
            this.txtFeeCodeConditions.Name = "txtFeeCodeConditions";
            this.txtFeeCodeConditions.Size = new System.Drawing.Size(374, 23);
            this.txtFeeCodeConditions.TabIndex = 21;
            // 
            // BookInTruckStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.txtFeeCodeConditions);
            this.Controls.Add(this.txtFeeCode);
            this.Controls.Add(this.chkACC);
            this.Controls.Add(cardStatusLabel);
            this.Controls.Add(this.txtCardStatus);
            this.Controls.Add(truckOwnerLabel);
            this.Controls.Add(this.truckOwnerTextBox);
            this.Controls.Add(cardCodeLabel);
            this.Controls.Add(this.cardCodeTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.txtVehicleDescription);
            this.Controls.Add(this.txtAxleConfig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindTruck);
            this.Controls.Add(this.txtTruckRego);
            this.Controls.Add(this.pictureSchematic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookInTruckStep1";
            this.Text = "BookInTruckStep1";
            this.Load += new System.EventHandler(this.BookInTruckStep1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSchematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bsConfiguredTruckGVM;
        private dsTruckConfigTableAdapters.ConfiguredTruckGVMTableAdapter taConfiguredTruckGVM;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox txtCardStatus;
        private System.Windows.Forms.CheckBox chkACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTrailerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RegoCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVMTruckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bridgeAssessmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtFeeCode;
        private System.Windows.Forms.TextBox txtFeeCodeConditions;
    }
}