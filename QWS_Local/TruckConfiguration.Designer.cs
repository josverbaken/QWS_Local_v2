
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckConfiguration));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.truckConfigIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSConfigIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.truckConfigIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKVehicleConfigTrailersVehicleConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tspSaveTruckConfig = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tspSaveTruckconfigtrailers = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.configuredTnTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAddTrailer = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.regoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axleConfigurationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSTrailers4TruckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vehicleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPBS_ID = new System.Windows.Forms.TextBox();
            this.txtApprovalDT = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtVehicleApproval = new System.Windows.Forms.TextBox();
            this.btnLoadDetails = new System.Windows.Forms.Button();
            this.btnFindNHVR_GVM = new System.Windows.Forms.Button();
            this.btnFindVehicleDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.schematicPictureBox = new System.Windows.Forms.PictureBox();
            this.txtAxleConfig = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tkTrConfigNotPBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBSTruckConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckConfigTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.TruckConfigTableAdapter();
            this.vehicleDetailsTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.VehicleDetailsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.pBSTrailers4TruckTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.PBSTrailers4TruckTableAdapter();
            this.pBSTruckConfigTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.PBSTruckConfigTableAdapter();
            this.tkTrConfigNotPBSTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.TkTrConfigNotPBSTableAdapter();
            this.configuredTnTTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.ConfiguredTnTTableAdapter();
            this.regoTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoTrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegoTrB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AxleConfig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchemeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regoLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            axleConfigurationLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVehicleConfigTrailersVehicleConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuredTnTBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSTrailers4TruckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schematicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkTrConfigNotPBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSTruckConfigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(73, 59);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(36, 13);
            regoLabel.TabIndex = 0;
            regoLabel.Text = "Rego:";
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(68, 86);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(41, 13);
            ownerLabel.TabIndex = 2;
            ownerLabel.Text = "Owner:";
            // 
            // axleConfigurationLabel
            // 
            axleConfigurationLabel.AutoSize = true;
            axleConfigurationLabel.Location = new System.Drawing.Point(161, 138);
            axleConfigurationLabel.Name = "axleConfigurationLabel";
            axleConfigurationLabel.Size = new System.Drawing.Size(95, 13);
            axleConfigurationLabel.TabIndex = 4;
            axleConfigurationLabel.Text = "Axle Configuration:";
            axleConfigurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(197, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 13);
            label4.TabIndex = 24;
            label4.Text = "Fee Code :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(167, 164);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 13);
            label5.TabIndex = 25;
            label5.Text = "Registered Tare ;";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.truckConfigIDDataGridViewTextBoxColumn,
            this.regoDataGridViewTextBoxColumn,
            this.truckTypeIDDataGridViewTextBoxColumn,
            this.pBSConfigIDDataGridViewTextBoxColumn,
            this.tareDataGridViewTextBoxColumn,
            this.TareDT});
            this.dataGridView1.DataSource = this.truckConfigBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // truckConfigIDDataGridViewTextBoxColumn
            // 
            this.truckConfigIDDataGridViewTextBoxColumn.DataPropertyName = "TruckConfigID";
            this.truckConfigIDDataGridViewTextBoxColumn.HeaderText = "TruckConfigID";
            this.truckConfigIDDataGridViewTextBoxColumn.Name = "truckConfigIDDataGridViewTextBoxColumn";
            this.truckConfigIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            // 
            // truckTypeIDDataGridViewTextBoxColumn
            // 
            this.truckTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TruckTypeID";
            this.truckTypeIDDataGridViewTextBoxColumn.HeaderText = "TruckTypeID";
            this.truckTypeIDDataGridViewTextBoxColumn.Name = "truckTypeIDDataGridViewTextBoxColumn";
            // 
            // pBSConfigIDDataGridViewTextBoxColumn
            // 
            this.pBSConfigIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_Config_ID";
            this.pBSConfigIDDataGridViewTextBoxColumn.HeaderText = "PBS_Config_ID";
            this.pBSConfigIDDataGridViewTextBoxColumn.Name = "pBSConfigIDDataGridViewTextBoxColumn";
            // 
            // tareDataGridViewTextBoxColumn
            // 
            this.tareDataGridViewTextBoxColumn.DataPropertyName = "Tare";
            this.tareDataGridViewTextBoxColumn.HeaderText = "Tare";
            this.tareDataGridViewTextBoxColumn.Name = "tareDataGridViewTextBoxColumn";
            // 
            // TareDT
            // 
            this.TareDT.DataPropertyName = "TareDT";
            this.TareDT.HeaderText = "TareDT";
            this.TareDT.Name = "TareDT";
            // 
            // truckConfigBindingSource
            // 
            this.truckConfigBindingSource.DataMember = "TruckConfig";
            this.truckConfigBindingSource.DataSource = this.dsQWSLocal;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.truckConfigIDDataGridViewTextBoxColumn1,
            this.regoDataGridViewTextBoxColumn1,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKVehicleConfigTrailersVehicleConfigBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(647, 100);
            this.dataGridView2.TabIndex = 1;
            // 
            // truckConfigIDDataGridViewTextBoxColumn1
            // 
            this.truckConfigIDDataGridViewTextBoxColumn1.DataPropertyName = "TruckConfigID";
            this.truckConfigIDDataGridViewTextBoxColumn1.HeaderText = "TruckConfigID";
            this.truckConfigIDDataGridViewTextBoxColumn1.Name = "truckConfigIDDataGridViewTextBoxColumn1";
            // 
            // regoDataGridViewTextBoxColumn1
            // 
            this.regoDataGridViewTextBoxColumn1.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn1.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn1.Name = "regoDataGridViewTextBoxColumn1";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // fKVehicleConfigTrailersVehicleConfigBindingSource
            // 
            this.fKVehicleConfigTrailersVehicleConfigBindingSource.DataMember = "FK_VehicleConfigTrailers_VehicleConfig";
            this.fKVehicleConfigTrailersVehicleConfigBindingSource.DataSource = this.truckConfigBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.truckConfigBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.tspSaveTruckConfig,
            this.btnRefresh});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(317, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tspSaveTruckConfig
            // 
            this.tspSaveTruckConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspSaveTruckConfig.Image = ((System.Drawing.Image)(resources.GetObject("tspSaveTruckConfig.Image")));
            this.tspSaveTruckConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSaveTruckConfig.Name = "tspSaveTruckConfig";
            this.tspSaveTruckConfig.Size = new System.Drawing.Size(35, 22);
            this.tspSaveTruckConfig.Text = "Save";
            this.tspSaveTruckConfig.Click += new System.EventHandler(this.tspSaveTruckConfig_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton1;
            this.bindingNavigator2.BindingSource = this.fKVehicleConfigTrailersVehicleConfigBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.tspSaveTruckconfigtrailers});
            this.bindingNavigator2.Location = new System.Drawing.Point(12, 0);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(267, 25);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tspSaveTruckconfigtrailers
            // 
            this.tspSaveTruckconfigtrailers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspSaveTruckconfigtrailers.Image = ((System.Drawing.Image)(resources.GetObject("tspSaveTruckconfigtrailers.Image")));
            this.tspSaveTruckconfigtrailers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSaveTruckconfigtrailers.Name = "tspSaveTruckconfigtrailers";
            this.tspSaveTruckconfigtrailers.Size = new System.Drawing.Size(35, 22);
            this.tspSaveTruckconfigtrailers.Text = "Save";
            this.tspSaveTruckconfigtrailers.Click += new System.EventHandler(this.tspSaveTruckconfigtrailers_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bindingNavigator2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 729);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 4;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1079, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1079, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 761);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1085, 735);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.btnAddTrailer);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Controls.Add(label5);
            this.tabPage2.Controls.Add(label4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.txtPBS_ID);
            this.tabPage2.Controls.Add(this.txtApprovalDT);
            this.tabPage2.Controls.Add(this.txtVersion);
            this.tabPage2.Controls.Add(this.txtVehicleApproval);
            this.tabPage2.Controls.Add(this.btnLoadDetails);
            this.tabPage2.Controls.Add(this.btnFindNHVR_GVM);
            this.tabPage2.Controls.Add(this.btnFindVehicleDetails);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.schematicPictureBox);
            this.tabPage2.Controls.Add(axleConfigurationLabel);
            this.tabPage2.Controls.Add(this.txtAxleConfig);
            this.tabPage2.Controls.Add(ownerLabel);
            this.tabPage2.Controls.Add(this.ownerTextBox);
            this.tabPage2.Controls.Add(regoLabel);
            this.tabPage2.Controls.Add(this.txtRego);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1085, 735);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.configuredTnTBindingSource, "Schematic", true));
            this.pictureBox1.Location = new System.Drawing.Point(448, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // configuredTnTBindingSource
            // 
            this.configuredTnTBindingSource.DataMember = "ConfiguredTnT";
            this.configuredTnTBindingSource.DataSource = this.dsQWSLocal;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuredTnTBindingSource, "TareDT", true));
            this.textBox4.Location = new System.Drawing.Point(609, 434);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuredTnTBindingSource, "Tare", true));
            this.textBox3.Location = new System.Drawing.Point(609, 408);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 28;
            // 
            // btnAddTrailer
            // 
            this.btnAddTrailer.Location = new System.Drawing.Point(76, 451);
            this.btnAddTrailer.Name = "btnAddTrailer";
            this.btnAddTrailer.Size = new System.Drawing.Size(119, 23);
            this.btnAddTrailer.TabIndex = 27;
            this.btnAddTrailer.Text = "Add Trailer";
            this.btnAddTrailer.UseVisualStyleBackColor = true;
            this.btnAddTrailer.Visible = false;
            this.btnAddTrailer.Click += new System.EventHandler(this.btnAddTrailer_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(225, 401);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(361, 143);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Unconfigured Trailers - both PBS and NHVR generic";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoDataGridViewTextBoxColumn3,
            this.axleConfigurationDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.pBSTrailers4TruckBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 50);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(355, 90);
            this.dataGridView4.TabIndex = 13;
            // 
            // regoDataGridViewTextBoxColumn3
            // 
            this.regoDataGridViewTextBoxColumn3.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn3.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn3.Name = "regoDataGridViewTextBoxColumn3";
            this.regoDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // axleConfigurationDataGridViewTextBoxColumn1
            // 
            this.axleConfigurationDataGridViewTextBoxColumn1.DataPropertyName = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn1.HeaderText = "AxleConfiguration";
            this.axleConfigurationDataGridViewTextBoxColumn1.Name = "axleConfigurationDataGridViewTextBoxColumn1";
            this.axleConfigurationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SchemeCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "SchemeCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pBSTrailers4TruckBindingSource
            // 
            this.pBSTrailers4TruckBindingSource.DataMember = "PBSTrailers4Truck";
            this.pBSTrailers4TruckBindingSource.DataSource = this.dsQWSLocal;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDetailsBindingSource, "RegisteredTare", true));
            this.textBox2.Location = new System.Drawing.Point(262, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // vehicleDetailsBindingSource
            // 
            this.vehicleDetailsBindingSource.DataMember = "VehicleDetails";
            this.vehicleDetailsBindingSource.DataSource = this.dsQWSLocal;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDetailsBindingSource, "FeeCode", true));
            this.textBox1.Location = new System.Drawing.Point(262, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 223);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.68627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.31373F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 163);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regoTkDataGridViewTextBoxColumn,
            this.regoTrDataGridViewTextBoxColumn,
            this.RegoTrB,
            this.AxleConfig,
            this.SchemeCode,
            this.GCM});
            this.dataGridView5.DataSource = this.configuredTnTBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 36);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(541, 124);
            this.dataGridView5.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Configured Truck and Trailers - both PBS and NHVR generic";
       

            // 
            // btnLoadDetails
            // 
            this.btnLoadDetails.Location = new System.Drawing.Point(923, 183);
            this.btnLoadDetails.Name = "btnLoadDetails";
            this.btnLoadDetails.Size = new System.Drawing.Size(119, 23);
            this.btnLoadDetails.TabIndex = 12;
            this.btnLoadDetails.Text = "Load Details";
            this.btnLoadDetails.UseVisualStyleBackColor = true;
            this.btnLoadDetails.Click += new System.EventHandler(this.btnLoadDetails_Click);
            // 
            // btnFindNHVR_GVM
            // 
            this.btnFindNHVR_GVM.Location = new System.Drawing.Point(923, 154);
            this.btnFindNHVR_GVM.Name = "btnFindNHVR_GVM";
            this.btnFindNHVR_GVM.Size = new System.Drawing.Size(119, 23);
            this.btnFindNHVR_GVM.TabIndex = 10;
            this.btnFindNHVR_GVM.Text = "Find NHVR GVM";
            this.btnFindNHVR_GVM.UseVisualStyleBackColor = true;
            this.btnFindNHVR_GVM.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFindVehicleDetails
            // 
            this.btnFindVehicleDetails.Location = new System.Drawing.Point(287, 54);
            this.btnFindVehicleDetails.Name = "btnFindVehicleDetails";
            this.btnFindVehicleDetails.Size = new System.Drawing.Size(75, 23);
            this.btnFindVehicleDetails.TabIndex = 9;
            this.btnFindVehicleDetails.Text = "Find";
            this.btnFindVehicleDetails.UseVisualStyleBackColor = true;
            this.btnFindVehicleDetails.Click += new System.EventHandler(this.btnFindVehicleDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // schematicPictureBox
            // 
            this.schematicPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.vehicleDetailsBindingSource, "Schematic", true));
            this.schematicPictureBox.Location = new System.Drawing.Point(404, 56);
            this.schematicPictureBox.Name = "schematicPictureBox";
            this.schematicPictureBox.Size = new System.Drawing.Size(450, 150);
            this.schematicPictureBox.TabIndex = 7;
            this.schematicPictureBox.TabStop = false;
            // 
            // txtAxleConfig
            // 
            this.txtAxleConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDetailsBindingSource, "AxleConfiguration", true));
            this.txtAxleConfig.Location = new System.Drawing.Point(262, 135);
            this.txtAxleConfig.Name = "txtAxleConfig";
            this.txtAxleConfig.Size = new System.Drawing.Size(100, 20);
            this.txtAxleConfig.TabIndex = 5;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDetailsBindingSource, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(115, 83);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(247, 20);
            this.ownerTextBox.TabIndex = 3;
            // 
            // txtRego
            // 
            this.txtRego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDetailsBindingSource, "Rego", true));
            this.txtRego.Location = new System.Drawing.Point(115, 56);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(100, 20);
            this.txtRego.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1085, 735);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tkTrConfigNotPBSBindingSource
            // 
            this.tkTrConfigNotPBSBindingSource.DataMember = "TkTrConfigNotPBS";
            this.tkTrConfigNotPBSBindingSource.DataSource = this.dsQWSLocal;
            // 
            // pBSTruckConfigBindingSource
            // 
            this.pBSTruckConfigBindingSource.DataMember = "PBSTruckConfig";
            this.pBSTruckConfigBindingSource.DataSource = this.dsQWSLocal;
            // 
            // truckConfigTableAdapter
            // 
            this.truckConfigTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleDetailsTableAdapter
            // 
            this.vehicleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NHVLTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = this.truckConfigTableAdapter;
            this.tableAdapterManager.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // pBSTrailers4TruckTableAdapter
            // 
            this.pBSTrailers4TruckTableAdapter.ClearBeforeFill = true;
            // 
            // pBSTruckConfigTableAdapter
            // 
            this.pBSTruckConfigTableAdapter.ClearBeforeFill = true;
            // 
            // tkTrConfigNotPBSTableAdapter
            // 
            this.tkTrConfigNotPBSTableAdapter.ClearBeforeFill = true;
            // 
            // configuredTnTTableAdapter
            // 
            this.configuredTnTTableAdapter.ClearBeforeFill = true;
            // 
            // regoTkDataGridViewTextBoxColumn
            // 
            this.regoTkDataGridViewTextBoxColumn.DataPropertyName = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.HeaderText = "RegoTk";
            this.regoTkDataGridViewTextBoxColumn.Name = "regoTkDataGridViewTextBoxColumn";
            this.regoTkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regoTrDataGridViewTextBoxColumn
            // 
            this.regoTrDataGridViewTextBoxColumn.DataPropertyName = "RegoTr";
            this.regoTrDataGridViewTextBoxColumn.HeaderText = "RegoTr";
            this.regoTrDataGridViewTextBoxColumn.Name = "regoTrDataGridViewTextBoxColumn";
            this.regoTrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegoTrB
            // 
            this.RegoTrB.DataPropertyName = "RegoTrB";
            this.RegoTrB.HeaderText = "RegoTrB";
            this.RegoTrB.Name = "RegoTrB";
            this.RegoTrB.ReadOnly = true;
            // 
            // AxleConfig
            // 
            this.AxleConfig.DataPropertyName = "AxleConfig";
            this.AxleConfig.HeaderText = "Axles";
            this.AxleConfig.Name = "AxleConfig";
            this.AxleConfig.ReadOnly = true;
            // 
            // SchemeCode
            // 
            this.SchemeCode.DataPropertyName = "SchemeCode";
            this.SchemeCode.HeaderText = "Scheme";
            this.SchemeCode.Name = "SchemeCode";
            this.SchemeCode.ReadOnly = true;
            // 
            // GCM
            // 
            this.GCM.DataPropertyName = "GCM";
            this.GCM.HeaderText = "GVM";
            this.GCM.Name = "GCM";
            this.GCM.ReadOnly = true;
            // 
            // TruckConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 761);
            this.Controls.Add(this.tabControl1);
            this.Name = "TruckConfiguration";
            this.Text = "TruckConfiguration";
            this.Load += new System.EventHandler(this.TruckConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVehicleConfigTrailersVehicleConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuredTnTBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSTrailers4TruckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schematicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkTrConfigNotPBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSTruckConfigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource truckConfigBindingSource;
        private dsQWSLocalTableAdapters.TruckConfigTableAdapter truckConfigTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKVehicleConfigTrailersVehicleConfigBindingSource;
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
        private System.Windows.Forms.ToolStripButton tspSaveTruckConfig;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tspSaveTruckconfigtrailers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource vehicleDetailsBindingSource;
        private dsQWSLocalTableAdapters.VehicleDetailsTableAdapter vehicleDetailsTableAdapter;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox schematicPictureBox;
        private System.Windows.Forms.TextBox txtAxleConfig;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindVehicleDetails;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFindNHVR_GVM;
        private System.Windows.Forms.Button btnLoadDetails;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource pBSTrailers4TruckBindingSource;
        private dsQWSLocalTableAdapters.PBSTrailers4TruckTableAdapter pBSTrailers4TruckTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckConfigIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtApprovalDT;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtVehicleApproval;
        private System.Windows.Forms.TextBox txtPBS_ID;
        private System.Windows.Forms.BindingSource pBSTruckConfigBindingSource;
        private dsQWSLocalTableAdapters.PBSTruckConfigTableAdapter pBSTruckConfigTableAdapter;
        private System.Windows.Forms.BindingSource tkTrConfigNotPBSBindingSource;
        private dsQWSLocalTableAdapters.TkTrConfigNotPBSTableAdapter tkTrConfigNotPBSTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource configuredTnTBindingSource;
        private dsQWSLocalTableAdapters.ConfiguredTnTTableAdapter configuredTnTTableAdapter;
        private System.Windows.Forms.Button btnAddTrailer;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn axleConfigurationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckConfigIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSConfigIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareDT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoTrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegoTrB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AxleConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchemeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCM;
    }
}