
namespace QWS_Local
{
    partial class TrucksInQuarry
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
            System.Windows.Forms.Label entryDTTMLabel;
            System.Windows.Forms.Label sAPOrderLabel;
            System.Windows.Forms.Label roadAccessLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label stockpileLotNoLabel;
            System.Windows.Forms.Label custONLabel;
            System.Windows.Forms.Label regoLabel;
            System.Windows.Forms.Label driverLabel;
            System.Windows.Forms.Label truckOwnerLabel;
            System.Windows.Forms.Label cartageCodeLabel;
            System.Windows.Forms.Label payloadSplitLabel;
            System.Windows.Forms.Label tareLabel1;
            System.Windows.Forms.Label tareTkLabel1;
            System.Windows.Forms.Label gCMLabel;
            System.Windows.Forms.Label gVMTruckLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label schemeCodeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnPrintDocket = new System.Windows.Forms.Button();
            this.btnTINRemove = new System.Windows.Forms.Button();
            this.btnWeigh = new System.Windows.Forms.Button();
            this.btnAddTIQ = new System.Windows.Forms.Button();
            this.btnTINReleaseHold = new System.Windows.Forms.Button();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTINRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.queueStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDTTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckConfig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayloadSplit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTIQ2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.materialDescTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.gVMTruckTextBox = new System.Windows.Forms.TextBox();
            this.gCMTextBox = new System.Windows.Forms.TextBox();
            this.tareTkTextBox1 = new System.Windows.Forms.TextBox();
            this.tareTextBox1 = new System.Windows.Forms.TextBox();
            this.payloadSplitTextBox = new System.Windows.Forms.TextBox();
            this.cartageCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckConfigTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerCodeTextBox = new System.Windows.Forms.TextBox();
            this.truckOwnerTextBox = new System.Windows.Forms.TextBox();
            this.schemeCodeTextBox = new System.Windows.Forms.TextBox();
            this.axleConfigurationTextBox = new System.Windows.Forms.TextBox();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.custONTextBox = new System.Windows.Forms.TextBox();
            this.stockpileLotNoTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.feeCodeTextBox = new System.Windows.Forms.TextBox();
            this.roadAccessTextBox = new System.Windows.Forms.TextBox();
            this.sAPOrderTextBox = new System.Windows.Forms.TextBox();
            this.queueStatusTextBox = new System.Windows.Forms.TextBox();
            this.bsWBDocketLines = new System.Windows.Forms.BindingSource(this.components);
            this.bsWBDockets = new System.Windows.Forms.BindingSource(this.components);
            this.taTIQ2 = new QWS_Local.dsTIQ2TableAdapters.TIQTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.taWBDockets = new QWS_Local.dsTIQ2TableAdapters.WBDocketsTableAdapter();
            this.taWBDocketLines = new QWS_Local.dsTIQ2TableAdapters.WBDocketLinesTableAdapter();
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.bsAxleConfiguration = new System.Windows.Forms.BindingSource(this.components);
            this.taAxleConfiguration = new QWS_Local.dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter();
            this.tableAdapterManager2 = new QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager();
            this.dsBookIn = new QWS_Local.dsBookIn();
            this.bsQuarryOrderLines = new System.Windows.Forms.BindingSource(this.components);
            this.taQuarryOrderLines = new QWS_Local.dsBookInTableAdapters.QuarryOrderLinesTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsBookInTableAdapters.TableAdapterManager();
            this.textBox5 = new System.Windows.Forms.TextBox();
            entryDTTMLabel = new System.Windows.Forms.Label();
            sAPOrderLabel = new System.Windows.Forms.Label();
            roadAccessLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            stockpileLotNoLabel = new System.Windows.Forms.Label();
            custONLabel = new System.Windows.Forms.Label();
            regoLabel = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            truckOwnerLabel = new System.Windows.Forms.Label();
            cartageCodeLabel = new System.Windows.Forms.Label();
            payloadSplitLabel = new System.Windows.Forms.Label();
            tareLabel1 = new System.Windows.Forms.Label();
            tareTkLabel1 = new System.Windows.Forms.Label();
            gCMLabel = new System.Windows.Forms.Label();
            gVMTruckLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            schemeCodeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDocketLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuarryOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // entryDTTMLabel
            // 
            entryDTTMLabel.AutoSize = true;
            entryDTTMLabel.Location = new System.Drawing.Point(708, 17);
            entryDTTMLabel.Name = "entryDTTMLabel";
            entryDTTMLabel.Size = new System.Drawing.Size(97, 20);
            entryDTTMLabel.TabIndex = 2;
            entryDTTMLabel.Text = "Entry DTTM:";
            // 
            // sAPOrderLabel
            // 
            sAPOrderLabel.AutoSize = true;
            sAPOrderLabel.Location = new System.Drawing.Point(59, 113);
            sAPOrderLabel.Name = "sAPOrderLabel";
            sAPOrderLabel.Size = new System.Drawing.Size(85, 20);
            sAPOrderLabel.TabIndex = 10;
            sAPOrderLabel.Text = "SAPOrder:";
            // 
            // roadAccessLabel
            // 
            roadAccessLabel.AutoSize = true;
            roadAccessLabel.Location = new System.Drawing.Point(439, 209);
            roadAccessLabel.Name = "roadAccessLabel";
            roadAccessLabel.Size = new System.Drawing.Size(108, 20);
            roadAccessLabel.TabIndex = 32;
            roadAccessLabel.Text = "Road Access:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(13, 145);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(131, 20);
            deliveryAddressLabel.TabIndex = 40;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // stockpileLotNoLabel
            // 
            stockpileLotNoLabel.AutoSize = true;
            stockpileLotNoLabel.Location = new System.Drawing.Point(698, 235);
            stockpileLotNoLabel.Name = "stockpileLotNoLabel";
            stockpileLotNoLabel.Size = new System.Drawing.Size(78, 20);
            stockpileLotNoLabel.TabIndex = 42;
            stockpileLotNoLabel.Text = "Stockpile:";
            // 
            // custONLabel
            // 
            custONLabel.AutoSize = true;
            custONLabel.Location = new System.Drawing.Point(391, 116);
            custONLabel.Name = "custONLabel";
            custONLabel.Size = new System.Drawing.Size(73, 20);
            custONLabel.TabIndex = 54;
            custONLabel.Text = "Cust ON:";
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(92, 17);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(52, 20);
            regoLabel.TabIndex = 55;
            regoLabel.Text = "Rego:";
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(90, 81);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(54, 20);
            driverLabel.TabIndex = 56;
            driverLabel.Text = "Driver:";
            // 
            // truckOwnerLabel
            // 
            truckOwnerLabel.AutoSize = true;
            truckOwnerLabel.Location = new System.Drawing.Point(42, 49);
            truckOwnerLabel.Name = "truckOwnerLabel";
            truckOwnerLabel.Size = new System.Drawing.Size(102, 20);
            truckOwnerLabel.TabIndex = 59;
            truckOwnerLabel.Text = "Truck Owner:";
            // 
            // cartageCodeLabel
            // 
            cartageCodeLabel.AutoSize = true;
            cartageCodeLabel.Location = new System.Drawing.Point(32, 209);
            cartageCodeLabel.Name = "cartageCodeLabel";
            cartageCodeLabel.Size = new System.Drawing.Size(112, 20);
            cartageCodeLabel.TabIndex = 62;
            cartageCodeLabel.Text = "Cartage Code:";
            // 
            // payloadSplitLabel
            // 
            payloadSplitLabel.AutoSize = true;
            payloadSplitLabel.Location = new System.Drawing.Point(764, 148);
            payloadSplitLabel.Name = "payloadSplitLabel";
            payloadSplitLabel.Size = new System.Drawing.Size(104, 20);
            payloadSplitLabel.TabIndex = 64;
            payloadSplitLabel.Text = "Payload Split:";
            // 
            // tareLabel1
            // 
            tareLabel1.AutoSize = true;
            tareLabel1.Location = new System.Drawing.Point(893, 81);
            tareLabel1.Name = "tareLabel1";
            tareLabel1.Size = new System.Drawing.Size(45, 20);
            tareLabel1.TabIndex = 65;
            tareLabel1.Text = "Tare:";
            // 
            // tareTkLabel1
            // 
            tareTkLabel1.AutoSize = true;
            tareTkLabel1.Location = new System.Drawing.Point(872, 113);
            tareTkLabel1.Name = "tareTkLabel1";
            tareTkLabel1.Size = new System.Drawing.Size(66, 20);
            tareTkLabel1.TabIndex = 66;
            tareTkLabel1.Text = "Tare Tk:";
            // 
            // gCMLabel
            // 
            gCMLabel.AutoSize = true;
            gCMLabel.Location = new System.Drawing.Point(712, 81);
            gCMLabel.Name = "gCMLabel";
            gCMLabel.Size = new System.Drawing.Size(50, 20);
            gCMLabel.TabIndex = 67;
            gCMLabel.Text = "GCM:";
            // 
            // gVMTruckLabel
            // 
            gVMTruckLabel.AutoSize = true;
            gVMTruckLabel.Location = new System.Drawing.Point(671, 113);
            gVMTruckLabel.Name = "gVMTruckLabel";
            gVMTruckLabel.Size = new System.Drawing.Size(89, 20);
            gVMTruckLabel.TabIndex = 68;
            gVMTruckLabel.Text = "GVMTruck:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(75, 177);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(69, 20);
            materialLabel.TabIndex = 69;
            materialLabel.Text = "Material:";
            // 
            // schemeCodeLabel
            // 
            schemeCodeLabel.AutoSize = true;
            schemeCodeLabel.Location = new System.Drawing.Point(433, 241);
            schemeCodeLabel.Name = "schemeCodeLabel";
            schemeCodeLabel.Size = new System.Drawing.Size(114, 20);
            schemeCodeLabel.TabIndex = 58;
            schemeCodeLabel.Text = "Scheme Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(882, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 20);
            label1.TabIndex = 75;
            label1.Text = "Gross:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer2.Panel1.Controls.Add(this.btnPrintDocket);
            this.splitContainer2.Panel1.Controls.Add(this.btnTINRemove);
            this.splitContainer2.Panel1.Controls.Add(this.btnWeigh);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddTIQ);
            this.splitContainer2.Panel1.Controls.Add(this.btnTINReleaseHold);
            this.splitContainer2.Panel1.Controls.Add(this.txtRego);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btnTINRefresh);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1364, 661);
            this.splitContainer2.SplitterDistance = 279;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnPrintDocket
            // 
            this.btnPrintDocket.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrintDocket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDocket.Location = new System.Drawing.Point(679, 225);
            this.btnPrintDocket.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintDocket.Name = "btnPrintDocket";
            this.btnPrintDocket.Size = new System.Drawing.Size(210, 49);
            this.btnPrintDocket.TabIndex = 64;
            this.btnPrintDocket.Text = "Print Docket (F8)";
            this.btnPrintDocket.UseVisualStyleBackColor = false;
            this.btnPrintDocket.Click += new System.EventHandler(this.btnPrintDocket_Click);
            // 
            // btnTINRemove
            // 
            this.btnTINRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTINRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTINRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTINRemove.Location = new System.Drawing.Point(1123, 225);
            this.btnTINRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnTINRemove.Name = "btnTINRemove";
            this.btnTINRemove.Size = new System.Drawing.Size(210, 49);
            this.btnTINRemove.TabIndex = 63;
            this.btnTINRemove.Text = "Remove (F12)";
            this.btnTINRemove.UseVisualStyleBackColor = false;
            this.btnTINRemove.Click += new System.EventHandler(this.btnTINRemove_Click);
            // 
            // btnWeigh
            // 
            this.btnWeigh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWeigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeigh.Location = new System.Drawing.Point(901, 225);
            this.btnWeigh.Margin = new System.Windows.Forms.Padding(4);
            this.btnWeigh.Name = "btnWeigh";
            this.btnWeigh.Size = new System.Drawing.Size(210, 49);
            this.btnWeigh.TabIndex = 62;
            this.btnWeigh.Text = "Weigh (F9)";
            this.btnWeigh.UseVisualStyleBackColor = false;
            this.btnWeigh.Click += new System.EventHandler(this.btnWeigh_Click);
            // 
            // btnAddTIQ
            // 
            this.btnAddTIQ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTIQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTIQ.Location = new System.Drawing.Point(13, 225);
            this.btnAddTIQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTIQ.Name = "btnAddTIQ";
            this.btnAddTIQ.Size = new System.Drawing.Size(210, 49);
            this.btnAddTIQ.TabIndex = 50;
            this.btnAddTIQ.Text = "Book In (F2)";
            this.btnAddTIQ.UseVisualStyleBackColor = false;
            this.btnAddTIQ.Click += new System.EventHandler(this.btnAddTIQ_Click);
            // 
            // btnTINReleaseHold
            // 
            this.btnTINReleaseHold.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTINReleaseHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTINReleaseHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTINReleaseHold.Location = new System.Drawing.Point(235, 225);
            this.btnTINReleaseHold.Margin = new System.Windows.Forms.Padding(4);
            this.btnTINReleaseHold.Name = "btnTINReleaseHold";
            this.btnTINReleaseHold.Size = new System.Drawing.Size(210, 49);
            this.btnTINReleaseHold.TabIndex = 60;
            this.btnTINReleaseHold.Text = "Update (F4)";
            this.btnTINReleaseHold.UseVisualStyleBackColor = false;
            this.btnTINReleaseHold.Click += new System.EventHandler(this.btnTINReleaseHold_Click);
            // 
            // txtRego
            // 
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.Location = new System.Drawing.Point(12, 17);
            this.txtRego.Name = "txtRego";
            this.txtRego.ReadOnly = true;
            this.txtRego.Size = new System.Drawing.Size(450, 32);
            this.txtRego.TabIndex = 57;
            this.txtRego.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnTINRefresh
            // 
            this.btnTINRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTINRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTINRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTINRefresh.Location = new System.Drawing.Point(457, 225);
            this.btnTINRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTINRefresh.Name = "btnTINRefresh";
            this.btnTINRefresh.Size = new System.Drawing.Size(210, 49);
            this.btnTINRefresh.TabIndex = 54;
            this.btnTINRefresh.Text = "Refresh (F5)";
            this.btnTINRefresh.UseVisualStyleBackColor = false;
            this.btnTINRefresh.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1364, 378);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 29);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(1356, 345);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queueStatusDataGridViewTextBoxColumn,
            this.releaseDTTMDataGridViewTextBoxColumn,
            this.regoDataGridViewTextBoxColumn,
            this.TruckConfig,
            this.driverDataGridViewTextBoxColumn,
            this.Customer,
            this.materialDescDataGridViewTextBoxColumn,
            this.PayloadSplit,
            this.WBO});
            this.dataGridView1.DataSource = this.bsTIQ2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1350, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // queueStatusDataGridViewTextBoxColumn
            // 
            this.queueStatusDataGridViewTextBoxColumn.DataPropertyName = "QueueStatus";
            this.queueStatusDataGridViewTextBoxColumn.HeaderText = "QS";
            this.queueStatusDataGridViewTextBoxColumn.Name = "queueStatusDataGridViewTextBoxColumn";
            this.queueStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.queueStatusDataGridViewTextBoxColumn.Width = 50;
            // 
            // releaseDTTMDataGridViewTextBoxColumn
            // 
            this.releaseDTTMDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDTTM";
            dataGridViewCellStyle1.Format = "HH:mm";
            dataGridViewCellStyle1.NullValue = null;
            this.releaseDTTMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.releaseDTTMDataGridViewTextBoxColumn.HeaderText = "Time";
            this.releaseDTTMDataGridViewTextBoxColumn.Name = "releaseDTTMDataGridViewTextBoxColumn";
            this.releaseDTTMDataGridViewTextBoxColumn.ReadOnly = true;
            this.releaseDTTMDataGridViewTextBoxColumn.Width = 70;
            // 
            // regoDataGridViewTextBoxColumn
            // 
            this.regoDataGridViewTextBoxColumn.DataPropertyName = "Rego";
            this.regoDataGridViewTextBoxColumn.HeaderText = "Rego";
            this.regoDataGridViewTextBoxColumn.Name = "regoDataGridViewTextBoxColumn";
            this.regoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TruckConfig
            // 
            this.TruckConfig.DataPropertyName = "TruckConfig";
            this.TruckConfig.HeaderText = "Cfg";
            this.TruckConfig.Name = "TruckConfig";
            this.TruckConfig.ReadOnly = true;
            this.TruckConfig.Width = 70;
            // 
            // driverDataGridViewTextBoxColumn
            // 
            this.driverDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.driverDataGridViewTextBoxColumn.HeaderText = "Driver";
            this.driverDataGridViewTextBoxColumn.Name = "driverDataGridViewTextBoxColumn";
            this.driverDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverDataGridViewTextBoxColumn.Width = 200;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 250;
            // 
            // materialDescDataGridViewTextBoxColumn
            // 
            this.materialDescDataGridViewTextBoxColumn.DataPropertyName = "MaterialDesc";
            this.materialDescDataGridViewTextBoxColumn.HeaderText = "Material / Instruction";
            this.materialDescDataGridViewTextBoxColumn.Name = "materialDescDataGridViewTextBoxColumn";
            this.materialDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialDescDataGridViewTextBoxColumn.Width = 250;
            // 
            // PayloadSplit
            // 
            this.PayloadSplit.DataPropertyName = "PayloadSplit";
            this.PayloadSplit.HeaderText = "Payload";
            this.PayloadSplit.Name = "PayloadSplit";
            this.PayloadSplit.ReadOnly = true;
            this.PayloadSplit.Width = 120;
            // 
            // WBO
            // 
            this.WBO.DataPropertyName = "Operator";
            this.WBO.HeaderText = "WBO";
            this.WBO.Name = "WBO";
            this.WBO.ReadOnly = true;
            this.WBO.Width = 200;
            // 
            // bsTIQ2
            // 
            this.bsTIQ2.DataMember = "TIQ";
            this.bsTIQ2.DataSource = this.dsTIQ2;
            this.bsTIQ2.CurrentChanged += new System.EventHandler(this.bsTIQ2_CurrentChanged);
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpDetails
            // 
            this.tpDetails.AutoScroll = true;
            this.tpDetails.Controls.Add(this.textBox5);
            this.tpDetails.Controls.Add(this.textBox3);
            this.tpDetails.Controls.Add(this.textBox2);
            this.tpDetails.Controls.Add(label1);
            this.tpDetails.Controls.Add(this.textBox1);
            this.tpDetails.Controls.Add(this.textBox4);
            this.tpDetails.Controls.Add(this.materialDescTextBox);
            this.tpDetails.Controls.Add(materialLabel);
            this.tpDetails.Controls.Add(this.materialTextBox);
            this.tpDetails.Controls.Add(gVMTruckLabel);
            this.tpDetails.Controls.Add(this.gVMTruckTextBox);
            this.tpDetails.Controls.Add(gCMLabel);
            this.tpDetails.Controls.Add(this.gCMTextBox);
            this.tpDetails.Controls.Add(tareTkLabel1);
            this.tpDetails.Controls.Add(this.tareTkTextBox1);
            this.tpDetails.Controls.Add(tareLabel1);
            this.tpDetails.Controls.Add(this.tareTextBox1);
            this.tpDetails.Controls.Add(payloadSplitLabel);
            this.tpDetails.Controls.Add(this.payloadSplitTextBox);
            this.tpDetails.Controls.Add(cartageCodeLabel);
            this.tpDetails.Controls.Add(this.cartageCodeTextBox);
            this.tpDetails.Controls.Add(this.truckConfigTextBox);
            this.tpDetails.Controls.Add(this.truckOwnerCodeTextBox);
            this.tpDetails.Controls.Add(truckOwnerLabel);
            this.tpDetails.Controls.Add(this.truckOwnerTextBox);
            this.tpDetails.Controls.Add(schemeCodeLabel);
            this.tpDetails.Controls.Add(this.schemeCodeTextBox);
            this.tpDetails.Controls.Add(this.axleConfigurationTextBox);
            this.tpDetails.Controls.Add(driverLabel);
            this.tpDetails.Controls.Add(this.driverTextBox);
            this.tpDetails.Controls.Add(regoLabel);
            this.tpDetails.Controls.Add(this.regoTextBox);
            this.tpDetails.Controls.Add(custONLabel);
            this.tpDetails.Controls.Add(this.custONTextBox);
            this.tpDetails.Controls.Add(stockpileLotNoLabel);
            this.tpDetails.Controls.Add(this.stockpileLotNoTextBox);
            this.tpDetails.Controls.Add(deliveryAddressLabel);
            this.tpDetails.Controls.Add(this.deliveryAddressTextBox);
            this.tpDetails.Controls.Add(this.feeCodeTextBox);
            this.tpDetails.Controls.Add(roadAccessLabel);
            this.tpDetails.Controls.Add(this.roadAccessTextBox);
            this.tpDetails.Controls.Add(sAPOrderLabel);
            this.tpDetails.Controls.Add(this.sAPOrderTextBox);
            this.tpDetails.Controls.Add(this.queueStatusTextBox);
            this.tpDetails.Controls.Add(entryDTTMLabel);
            this.tpDetails.Location = new System.Drawing.Point(4, 29);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1356, 345);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "ParentTIQID", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(944, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 77;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TIQID", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(944, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 76;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Gross", true));
            this.textBox1.Location = new System.Drawing.Point(944, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 74;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "EntryDTTM", true));
            this.textBox4.Location = new System.Drawing.Point(813, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(178, 26);
            this.textBox4.TabIndex = 73;
            // 
            // materialDescTextBox
            // 
            this.materialDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "MaterialDesc", true));
            this.materialDescTextBox.Location = new System.Drawing.Point(150, 174);
            this.materialDescTextBox.Name = "materialDescTextBox";
            this.materialDescTextBox.ReadOnly = true;
            this.materialDescTextBox.Size = new System.Drawing.Size(392, 26);
            this.materialDescTextBox.TabIndex = 71;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(553, 174);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.ReadOnly = true;
            this.materialTextBox.Size = new System.Drawing.Size(100, 26);
            this.materialTextBox.TabIndex = 70;
            // 
            // gVMTruckTextBox
            // 
            this.gVMTruckTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "GVMTruck", true));
            this.gVMTruckTextBox.Location = new System.Drawing.Point(768, 110);
            this.gVMTruckTextBox.Name = "gVMTruckTextBox";
            this.gVMTruckTextBox.ReadOnly = true;
            this.gVMTruckTextBox.Size = new System.Drawing.Size(100, 26);
            this.gVMTruckTextBox.TabIndex = 69;
            // 
            // gCMTextBox
            // 
            this.gCMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "GCM", true));
            this.gCMTextBox.Location = new System.Drawing.Point(768, 78);
            this.gCMTextBox.Name = "gCMTextBox";
            this.gCMTextBox.ReadOnly = true;
            this.gCMTextBox.Size = new System.Drawing.Size(100, 26);
            this.gCMTextBox.TabIndex = 68;
            // 
            // tareTkTextBox1
            // 
            this.tareTkTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TareTk", true));
            this.tareTkTextBox1.Location = new System.Drawing.Point(944, 110);
            this.tareTkTextBox1.Name = "tareTkTextBox1";
            this.tareTkTextBox1.ReadOnly = true;
            this.tareTkTextBox1.Size = new System.Drawing.Size(100, 26);
            this.tareTkTextBox1.TabIndex = 67;
            // 
            // tareTextBox1
            // 
            this.tareTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Tare", true));
            this.tareTextBox1.Location = new System.Drawing.Point(944, 78);
            this.tareTextBox1.Name = "tareTextBox1";
            this.tareTextBox1.ReadOnly = true;
            this.tareTextBox1.Size = new System.Drawing.Size(100, 26);
            this.tareTextBox1.TabIndex = 66;
            // 
            // payloadSplitTextBox
            // 
            this.payloadSplitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "PayloadSplit", true));
            this.payloadSplitTextBox.Location = new System.Drawing.Point(876, 142);
            this.payloadSplitTextBox.Name = "payloadSplitTextBox";
            this.payloadSplitTextBox.ReadOnly = true;
            this.payloadSplitTextBox.Size = new System.Drawing.Size(168, 26);
            this.payloadSplitTextBox.TabIndex = 65;
            // 
            // cartageCodeTextBox
            // 
            this.cartageCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "CartageCode", true));
            this.cartageCodeTextBox.Location = new System.Drawing.Point(150, 206);
            this.cartageCodeTextBox.Name = "cartageCodeTextBox";
            this.cartageCodeTextBox.ReadOnly = true;
            this.cartageCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.cartageCodeTextBox.TabIndex = 63;
            // 
            // truckConfigTextBox
            // 
            this.truckConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TruckConfig", true));
            this.truckConfigTextBox.Location = new System.Drawing.Point(515, 14);
            this.truckConfigTextBox.Name = "truckConfigTextBox";
            this.truckConfigTextBox.ReadOnly = true;
            this.truckConfigTextBox.Size = new System.Drawing.Size(68, 26);
            this.truckConfigTextBox.TabIndex = 62;
            // 
            // truckOwnerCodeTextBox
            // 
            this.truckOwnerCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TruckOwnerCode", true));
            this.truckOwnerCodeTextBox.Location = new System.Drawing.Point(553, 46);
            this.truckOwnerCodeTextBox.Name = "truckOwnerCodeTextBox";
            this.truckOwnerCodeTextBox.ReadOnly = true;
            this.truckOwnerCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.truckOwnerCodeTextBox.TabIndex = 61;
            // 
            // truckOwnerTextBox
            // 
            this.truckOwnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "TruckOwner", true));
            this.truckOwnerTextBox.Location = new System.Drawing.Point(150, 46);
            this.truckOwnerTextBox.Name = "truckOwnerTextBox";
            this.truckOwnerTextBox.ReadOnly = true;
            this.truckOwnerTextBox.Size = new System.Drawing.Size(392, 26);
            this.truckOwnerTextBox.TabIndex = 60;
            // 
            // schemeCodeTextBox
            // 
            this.schemeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "SchemeCode", true));
            this.schemeCodeTextBox.Location = new System.Drawing.Point(553, 238);
            this.schemeCodeTextBox.Name = "schemeCodeTextBox";
            this.schemeCodeTextBox.ReadOnly = true;
            this.schemeCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.schemeCodeTextBox.TabIndex = 59;
            // 
            // axleConfigurationTextBox
            // 
            this.axleConfigurationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "AxleConfiguration", true));
            this.axleConfigurationTextBox.Location = new System.Drawing.Point(454, 14);
            this.axleConfigurationTextBox.Name = "axleConfigurationTextBox";
            this.axleConfigurationTextBox.ReadOnly = true;
            this.axleConfigurationTextBox.Size = new System.Drawing.Size(55, 26);
            this.axleConfigurationTextBox.TabIndex = 58;
            // 
            // driverTextBox
            // 
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(150, 78);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.ReadOnly = true;
            this.driverTextBox.Size = new System.Drawing.Size(224, 26);
            this.driverTextBox.TabIndex = 57;
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(150, 14);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.ReadOnly = true;
            this.regoTextBox.Size = new System.Drawing.Size(100, 26);
            this.regoTextBox.TabIndex = 56;
            // 
            // custONTextBox
            // 
            this.custONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "CustON", true));
            this.custONTextBox.Location = new System.Drawing.Point(480, 113);
            this.custONTextBox.Name = "custONTextBox";
            this.custONTextBox.ReadOnly = true;
            this.custONTextBox.Size = new System.Drawing.Size(173, 26);
            this.custONTextBox.TabIndex = 55;
            // 
            // stockpileLotNoTextBox
            // 
            this.stockpileLotNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "StockpileLotNo", true));
            this.stockpileLotNoTextBox.Location = new System.Drawing.Point(790, 232);
            this.stockpileLotNoTextBox.Name = "stockpileLotNoTextBox";
            this.stockpileLotNoTextBox.ReadOnly = true;
            this.stockpileLotNoTextBox.Size = new System.Drawing.Size(78, 26);
            this.stockpileLotNoTextBox.TabIndex = 43;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(150, 142);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.ReadOnly = true;
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(503, 26);
            this.deliveryAddressTextBox.TabIndex = 41;
            // 
            // feeCodeTextBox
            // 
            this.feeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "FeeCode", true));
            this.feeCodeTextBox.Location = new System.Drawing.Point(594, 14);
            this.feeCodeTextBox.Name = "feeCodeTextBox";
            this.feeCodeTextBox.ReadOnly = true;
            this.feeCodeTextBox.Size = new System.Drawing.Size(59, 26);
            this.feeCodeTextBox.TabIndex = 35;
            // 
            // roadAccessTextBox
            // 
            this.roadAccessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "RoadAccess", true));
            this.roadAccessTextBox.Location = new System.Drawing.Point(553, 206);
            this.roadAccessTextBox.Name = "roadAccessTextBox";
            this.roadAccessTextBox.ReadOnly = true;
            this.roadAccessTextBox.Size = new System.Drawing.Size(100, 26);
            this.roadAccessTextBox.TabIndex = 33;
            // 
            // sAPOrderTextBox
            // 
            this.sAPOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "SAPOrder", true));
            this.sAPOrderTextBox.Location = new System.Drawing.Point(150, 110);
            this.sAPOrderTextBox.Name = "sAPOrderTextBox";
            this.sAPOrderTextBox.ReadOnly = true;
            this.sAPOrderTextBox.Size = new System.Drawing.Size(100, 26);
            this.sAPOrderTextBox.TabIndex = 11;
            // 
            // queueStatusTextBox
            // 
            this.queueStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "QueueStatus", true));
            this.queueStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueStatusTextBox.Location = new System.Drawing.Point(997, 14);
            this.queueStatusTextBox.Name = "queueStatusTextBox";
            this.queueStatusTextBox.ReadOnly = true;
            this.queueStatusTextBox.Size = new System.Drawing.Size(47, 26);
            this.queueStatusTextBox.TabIndex = 5;
            this.queueStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bsWBDocketLines
            // 
            this.bsWBDocketLines.DataMember = "WBDocketLines";
            this.bsWBDocketLines.DataSource = this.dsTIQ2;
            // 
            // bsWBDockets
            // 
            this.bsWBDockets.DataMember = "WBDockets";
            this.bsWBDockets.DataSource = this.dsTIQ2;
            // 
            // taTIQ2
            // 
            this.taTIQ2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StockpileBOMTableAdapter = null;
            this.tableAdapterManager1.StockpileLotAllocationTableAdapter = null;
            this.tableAdapterManager1.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager1.TIQTableAdapter = this.taTIQ2;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager1.WBDocketsTableAdapter = null;
            // 
            // taWBDockets
            // 
            this.taWBDockets.ClearBeforeFill = true;
            // 
            // taWBDocketLines
            // 
            this.taWBDocketLines.ClearBeforeFill = true;
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAxleConfiguration
            // 
            this.bsAxleConfiguration.DataMember = "AxleConfiguration";
            this.bsAxleConfiguration.DataSource = this.dsQWSLocal2024;
            // 
            // taAxleConfiguration
            // 
            this.taAxleConfiguration.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.AxleConfigurationTableAdapter = this.taAxleConfiguration;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.NHVRTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = QWS_Local.dsQWSLocal2024TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.VehiclePBSTableAdapter = null;
            this.tableAdapterManager2.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager2.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager2.VehicleTableAdapter = null;
            // 
            // dsBookIn
            // 
            this.dsBookIn.DataSetName = "dsBookIn";
            this.dsBookIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsQuarryOrderLines
            // 
            this.bsQuarryOrderLines.DataMember = "QuarryOrderLines";
            this.bsQuarryOrderLines.DataSource = this.dsBookIn;
            // 
            // taQuarryOrderLines
            // 
            this.taQuarryOrderLines.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsBookInTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "RegoTrailers", true));
            this.textBox5.Location = new System.Drawing.Point(256, 14);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(192, 26);
            this.textBox5.TabIndex = 78;
            // 
            // TrucksInQuarry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 661);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TrucksInQuarry";
            this.Text = "Trucks In Quarry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrucksInQuarry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrucksInQuarry_KeyDown);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDocketLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAxleConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuarryOrderLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddTIQ;
        private System.Windows.Forms.Button btnTINRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox sAPOrderTextBox;
        private System.Windows.Forms.TextBox queueStatusTextBox;
        private System.Windows.Forms.TextBox feeCodeTextBox;
        private System.Windows.Forms.TextBox roadAccessTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.Button btnTINRemove;
        private System.Windows.Forms.Button btnWeigh;
        private System.Windows.Forms.Button btnTINReleaseHold;
        private System.Windows.Forms.TextBox stockpileLotNoTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox custONTextBox;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsTIQ2;
        private dsTIQ2TableAdapters.TIQTableAdapter taTIQ2;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox truckConfigTextBox;
        private System.Windows.Forms.TextBox truckOwnerCodeTextBox;
        private System.Windows.Forms.TextBox truckOwnerTextBox;
        private System.Windows.Forms.TextBox schemeCodeTextBox;
        private System.Windows.Forms.TextBox axleConfigurationTextBox;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.TextBox regoTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox materialDescTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox gVMTruckTextBox;
        private System.Windows.Forms.TextBox gCMTextBox;
        private System.Windows.Forms.TextBox tareTkTextBox1;
        private System.Windows.Forms.TextBox tareTextBox1;
        private System.Windows.Forms.TextBox payloadSplitTextBox;
        private System.Windows.Forms.TextBox cartageCodeTextBox;
        private System.Windows.Forms.BindingSource bsWBDockets;
        private dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets;
        private System.Windows.Forms.BindingSource bsWBDocketLines;
        private dsTIQ2TableAdapters.WBDocketLinesTableAdapter taWBDocketLines;
        private System.Windows.Forms.TextBox textBox1;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsAxleConfiguration;
        private dsQWSLocal2024TableAdapters.AxleConfigurationTableAdapter taAxleConfiguration;
        private dsQWSLocal2024TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDTTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayloadSplit;
        private System.Windows.Forms.DataGridViewTextBoxColumn WBO;
        private dsBookIn dsBookIn;
        private System.Windows.Forms.BindingSource bsQuarryOrderLines;
        private dsBookInTableAdapters.QuarryOrderLinesTableAdapter taQuarryOrderLines;
        private dsBookInTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnPrintDocket;
        private System.Windows.Forms.TextBox textBox5;
    }
}