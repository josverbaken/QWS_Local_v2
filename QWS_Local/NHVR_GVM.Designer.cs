﻿
namespace QWS_Local
{
    partial class NHVR_GVM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHVR_GVM));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.rbGML = new System.Windows.Forms.RadioButton();
            this.rbMassMgmt = new System.Windows.Forms.RadioButton();
            this.rbRFS = new System.Windows.Forms.RadioButton();
            this.rbSteer = new System.Windows.Forms.RadioButton();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsNHVR2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.taNHVR2 = new QWS_Local.dsQWSLocal2024TableAdapters.NHVRTableAdapter();
            this.truckTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couplingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoadAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steerAxleAllowanceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trTkRatioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVMTruckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massMgmtRqdDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnApply);
            this.splitContainer1.Panel1.Controls.Add(this.txtAxleConfig);
            this.splitContainer1.Panel1.Controls.Add(this.rbClear);
            this.splitContainer1.Panel1.Controls.Add(this.rbGML);
            this.splitContainer1.Panel1.Controls.Add(this.rbMassMgmt);
            this.splitContainer1.Panel1.Controls.Add(this.rbRFS);
            this.splitContainer1.Panel1.Controls.Add(this.rbSteer);
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigator1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 623);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(908, 32);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.Location = new System.Drawing.Point(46, 32);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.Size = new System.Drawing.Size(100, 24);
            this.txtAxleConfig.TabIndex = 6;
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(808, 30);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(61, 22);
            this.rbClear.TabIndex = 5;
            this.rbClear.TabStop = true;
            this.rbClear.Text = "Clear";
            this.rbClear.UseVisualStyleBackColor = true;
            this.rbClear.CheckedChanged += new System.EventHandler(this.rbClear_CheckedChanged);
            // 
            // rbGML
            // 
            this.rbGML.AutoSize = true;
            this.rbGML.Location = new System.Drawing.Point(732, 30);
            this.rbGML.Name = "rbGML";
            this.rbGML.Size = new System.Drawing.Size(59, 22);
            this.rbGML.TabIndex = 4;
            this.rbGML.TabStop = true;
            this.rbGML.Text = "GML";
            this.rbGML.UseVisualStyleBackColor = true;
            this.rbGML.CheckedChanged += new System.EventHandler(this.rbGML_CheckedChanged);
            // 
            // rbMassMgmt
            // 
            this.rbMassMgmt.AutoSize = true;
            this.rbMassMgmt.Location = new System.Drawing.Point(471, 30);
            this.rbMassMgmt.Name = "rbMassMgmt";
            this.rbMassMgmt.Size = new System.Drawing.Size(238, 22);
            this.rbMassMgmt.TabIndex = 3;
            this.rbMassMgmt.TabStop = true;
            this.rbMassMgmt.Text = "Mass Management Accrediation";
            this.rbMassMgmt.UseVisualStyleBackColor = true;
            this.rbMassMgmt.CheckedChanged += new System.EventHandler(this.rbMassMgmt_CheckedChanged);
            // 
            // rbRFS
            // 
            this.rbRFS.AutoSize = true;
            this.rbRFS.Location = new System.Drawing.Point(398, 30);
            this.rbRFS.Name = "rbRFS";
            this.rbRFS.Size = new System.Drawing.Size(56, 22);
            this.rbRFS.TabIndex = 2;
            this.rbRFS.TabStop = true;
            this.rbRFS.Text = "RFS";
            this.rbRFS.UseVisualStyleBackColor = true;
            // 
            // rbSteer
            // 
            this.rbSteer.AutoSize = true;
            this.rbSteer.Location = new System.Drawing.Point(213, 30);
            this.rbSteer.Name = "rbSteer";
            this.rbSteer.Size = new System.Drawing.Size(163, 22);
            this.rbSteer.TabIndex = 1;
            this.rbSteer.TabStop = true;
            this.rbSteer.Text = "Steer Axle Allowance";
            this.rbSteer.UseVisualStyleBackColor = true;
            this.rbSteer.CheckedChanged += new System.EventHandler(this.rbSteer_CheckedChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
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
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1200, 27);
            this.bindingNavigator1.TabIndex = 0;
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 24);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.truckTypeIDDataGridViewTextBoxColumn,
            this.ReferenceDocument,
            this.axleConfigurationDataGridViewTextBoxColumn,
            this.truckTypeDescriptionDataGridViewTextBoxColumn,
            this.axlesDataGridViewTextBoxColumn,
            this.couplingDataGridViewTextBoxColumn,
            this.maxLengthDataGridViewTextBoxColumn,
            this.schemeCodeDataGridViewTextBoxColumn,
            this.RoadAccess,
            this.steerAxleAllowanceDataGridViewCheckBoxColumn,
            this.trTkRatioDataGridViewTextBoxColumn,
            this.gCMDataGridViewTextBoxColumn,
            this.gVMTruckDataGridViewTextBoxColumn,
            this.massMgmtRqdDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bsNHVR2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1200, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // bsNHVR2
            // 
            this.bsNHVR2.DataMember = "NHVR";
            this.bsNHVR2.DataSource = this.dsQWSLocal2024;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taNHVR2
            // 
            this.taNHVR2.ClearBeforeFill = true;
            // 
            // truckTypeIDDataGridViewTextBoxColumn
            // 
            this.truckTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TruckTypeID";
            this.truckTypeIDDataGridViewTextBoxColumn.HeaderText = "TruckTypeID";
            this.truckTypeIDDataGridViewTextBoxColumn.Name = "truckTypeIDDataGridViewTextBoxColumn";
            this.truckTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReferenceDocument
            // 
            this.ReferenceDocument.DataPropertyName = "ReferenceDocument";
            this.ReferenceDocument.HeaderText = "ReferenceDocument";
            this.ReferenceDocument.Name = "ReferenceDocument";
            // 
            // axleConfigurationDataGridViewTextBoxColumn
            // 
            this.axleConfigurationDataGridViewTextBoxColumn.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn.Name = "axleConfigurationDataGridViewTextBoxColumn";
            // 
            // truckTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.truckTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TruckTypeDescription";
            this.truckTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "TruckTypeDescription";
            this.truckTypeDescriptionDataGridViewTextBoxColumn.Name = "truckTypeDescriptionDataGridViewTextBoxColumn";
            // 
            // axlesDataGridViewTextBoxColumn
            // 
            this.axlesDataGridViewTextBoxColumn.DataPropertyName = "Axles";
            this.axlesDataGridViewTextBoxColumn.HeaderText = "Axles";
            this.axlesDataGridViewTextBoxColumn.Name = "axlesDataGridViewTextBoxColumn";
            // 
            // couplingDataGridViewTextBoxColumn
            // 
            this.couplingDataGridViewTextBoxColumn.DataPropertyName = "Coupling";
            this.couplingDataGridViewTextBoxColumn.HeaderText = "Coupling";
            this.couplingDataGridViewTextBoxColumn.Name = "couplingDataGridViewTextBoxColumn";
            // 
            // maxLengthDataGridViewTextBoxColumn
            // 
            this.maxLengthDataGridViewTextBoxColumn.DataPropertyName = "MaxLength";
            this.maxLengthDataGridViewTextBoxColumn.HeaderText = "MaxLength";
            this.maxLengthDataGridViewTextBoxColumn.Name = "maxLengthDataGridViewTextBoxColumn";
            // 
            // schemeCodeDataGridViewTextBoxColumn
            // 
            this.schemeCodeDataGridViewTextBoxColumn.DataPropertyName = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.HeaderText = "SchemeCode";
            this.schemeCodeDataGridViewTextBoxColumn.Name = "schemeCodeDataGridViewTextBoxColumn";
            // 
            // RoadAccess
            // 
            this.RoadAccess.DataPropertyName = "RoadAccess";
            this.RoadAccess.HeaderText = "RoadAccess";
            this.RoadAccess.Name = "RoadAccess";
            // 
            // steerAxleAllowanceDataGridViewCheckBoxColumn
            // 
            this.steerAxleAllowanceDataGridViewCheckBoxColumn.DataPropertyName = "SteerAxleAllowance";
            this.steerAxleAllowanceDataGridViewCheckBoxColumn.HeaderText = "SteerAxleAllowance";
            this.steerAxleAllowanceDataGridViewCheckBoxColumn.Name = "steerAxleAllowanceDataGridViewCheckBoxColumn";
            // 
            // trTkRatioDataGridViewTextBoxColumn
            // 
            this.trTkRatioDataGridViewTextBoxColumn.DataPropertyName = "TrTkRatio";
            this.trTkRatioDataGridViewTextBoxColumn.HeaderText = "TrTkRatio";
            this.trTkRatioDataGridViewTextBoxColumn.Name = "trTkRatioDataGridViewTextBoxColumn";
            // 
            // gCMDataGridViewTextBoxColumn
            // 
            this.gCMDataGridViewTextBoxColumn.DataPropertyName = "GCM";
            this.gCMDataGridViewTextBoxColumn.HeaderText = "GCM";
            this.gCMDataGridViewTextBoxColumn.Name = "gCMDataGridViewTextBoxColumn";
            // 
            // gVMTruckDataGridViewTextBoxColumn
            // 
            this.gVMTruckDataGridViewTextBoxColumn.DataPropertyName = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.HeaderText = "GVMTruck";
            this.gVMTruckDataGridViewTextBoxColumn.Name = "gVMTruckDataGridViewTextBoxColumn";
            // 
            // massMgmtRqdDataGridViewCheckBoxColumn
            // 
            this.massMgmtRqdDataGridViewCheckBoxColumn.DataPropertyName = "MassMgmtRqd";
            this.massMgmtRqdDataGridViewCheckBoxColumn.HeaderText = "MassMgmtRqd";
            this.massMgmtRqdDataGridViewCheckBoxColumn.Name = "massMgmtRqdDataGridViewCheckBoxColumn";
            // 
            // NHVR_GVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NHVR_GVM";
            this.Text = "NHVR_GVM";
            this.Load += new System.EventHandler(this.NHVR_GVM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNHVR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.RadioButton rbClear;
        private System.Windows.Forms.RadioButton rbGML;
        private System.Windows.Forms.RadioButton rbMassMgmt;
        private System.Windows.Forms.RadioButton rbRFS;
        private System.Windows.Forms.RadioButton rbSteer;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.Button btnApply;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsNHVR2;
        private dsQWSLocal2024TableAdapters.NHVRTableAdapter taNHVR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn axlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couplingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoadAccess;
        private System.Windows.Forms.DataGridViewCheckBoxColumn steerAxleAllowanceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trTkRatioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gVMTruckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn massMgmtRqdDataGridViewCheckBoxColumn;
    }
}