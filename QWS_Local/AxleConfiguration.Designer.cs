﻿
namespace QWS_Local
{
    partial class AxleConfiguration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxleConfiguration));
            this.dgvAxleConfiguration = new System.Windows.Forms.DataGridView();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleGroupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compartmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schematicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tspSearchPattern = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.bsAxleConfig = new System.Windows.Forms.BindingSource(this.components);
            this.taAxleConfig = new QWS_Local.dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAxleConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAxleConfiguration
            // 
            this.dgvAxleConfiguration.AllowUserToDeleteRows = false;
            this.dgvAxleConfiguration.AutoGenerateColumns = false;
            this.dgvAxleConfiguration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAxleConfiguration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.axleConfigurationDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.axlesDataGridViewTextBoxColumn,
            this.axleGroupsDataGridViewTextBoxColumn,
            this.Vehicles,
            this.compartmentsDataGridViewTextBoxColumn,
            this.vehicleDescriptionDataGridViewTextBoxColumn,
            this.schematicDataGridViewImageColumn});
            this.dgvAxleConfiguration.DataSource = this.bsAxleConfig;
            this.dgvAxleConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAxleConfiguration.Location = new System.Drawing.Point(0, 0);
            this.dgvAxleConfiguration.Name = "dgvAxleConfiguration";
            this.dgvAxleConfiguration.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAxleConfiguration.RowTemplate.Height = 150;
            this.dgvAxleConfiguration.Size = new System.Drawing.Size(1171, 423);
            this.dgvAxleConfiguration.TabIndex = 0;
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 80;
            // 
            // axlesDataGridViewTextBoxColumn
            // 
            this.axlesDataGridViewTextBoxColumn.DataPropertyName = "Axles";
            this.axlesDataGridViewTextBoxColumn.HeaderText = "Axles";
            this.axlesDataGridViewTextBoxColumn.Name = "axlesDataGridViewTextBoxColumn";
            this.axlesDataGridViewTextBoxColumn.Width = 60;
            // 
            // axleGroupsDataGridViewTextBoxColumn
            // 
            this.axleGroupsDataGridViewTextBoxColumn.DataPropertyName = "AxleGroups";
            this.axleGroupsDataGridViewTextBoxColumn.HeaderText = "AxleGroups";
            this.axleGroupsDataGridViewTextBoxColumn.Name = "axleGroupsDataGridViewTextBoxColumn";
            this.axleGroupsDataGridViewTextBoxColumn.Width = 80;
            // 
            // Vehicles
            // 
            this.Vehicles.DataPropertyName = "Vehicles";
            this.Vehicles.HeaderText = "Vehicles";
            this.Vehicles.Name = "Vehicles";
            // 
            // compartmentsDataGridViewTextBoxColumn
            // 
            this.compartmentsDataGridViewTextBoxColumn.DataPropertyName = "Compartments";
            this.compartmentsDataGridViewTextBoxColumn.HeaderText = "Compartments";
            this.compartmentsDataGridViewTextBoxColumn.Name = "compartmentsDataGridViewTextBoxColumn";
            this.compartmentsDataGridViewTextBoxColumn.Width = 80;
            // 
            // vehicleDescriptionDataGridViewTextBoxColumn
            // 
            this.vehicleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VehicleDescription";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicleDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.vehicleDescriptionDataGridViewTextBoxColumn.HeaderText = "VehicleDescription";
            this.vehicleDescriptionDataGridViewTextBoxColumn.Name = "vehicleDescriptionDataGridViewTextBoxColumn";
            this.vehicleDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // schematicDataGridViewImageColumn
            // 
            this.schematicDataGridViewImageColumn.DataPropertyName = "Schematic";
            this.schematicDataGridViewImageColumn.HeaderText = "Schematic";
            this.schematicDataGridViewImageColumn.Name = "schematicDataGridViewImageColumn";
            this.schematicDataGridViewImageColumn.Width = 450;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.tspUpdate,
            this.btnUpload,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.tspSearchPattern,
            this.toolStripButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(773, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tspUpdate
            // 
            this.tspUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tspUpdate.Image")));
            this.tspUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspUpdate.Name = "tspUpdate";
            this.tspUpdate.Size = new System.Drawing.Size(44, 24);
            this.tspUpdate.Text = "Save";
            this.tspUpdate.Click += new System.EventHandler(this.tspUpdate_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(111, 24);
            this.btnUpload.Text = "Upload Picture";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 24);
            this.toolStripButton1.Text = "Combinations";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(66, 24);
            this.toolStripButton3.Text = "Vehicles";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton2.Text = "Unfilter";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tspSearchPattern
            // 
            this.tspSearchPattern.Name = "tspSearchPattern";
            this.tspSearchPattern.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(41, 24);
            this.toolStripButton4.Text = "Find";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvAxleConfiguration);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1171, 423);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1171, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAxleConfig
            // 
            this.bsAxleConfig.DataMember = "AxleConfiguration";
            this.bsAxleConfig.DataSource = this.dsQWSLocal2024;
            // 
            // taAxleConfig
            // 
            this.taAxleConfig.ClearBeforeFill = true;
            // 
            // AxleConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "AxleConfiguration";
            this.Text = "Axle_Configuration";
            this.Load += new System.EventHandler(this.Axle_Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAxleConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAxleConfiguration;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tspUpdate;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox tspSearchPattern;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleGroupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn compartmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn schematicDataGridViewImageColumn;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsAxleConfig;
        private dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter taAxleConfig;
    }
}