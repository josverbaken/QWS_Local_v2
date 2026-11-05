
namespace QWS_Local
{
    partial class TruckDriverSearch
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
            System.Windows.Forms.Label licenseTypeLabel;
            System.Windows.Forms.Label sAPUpdateDTTMLabel;
            System.Windows.Forms.Label licenseExpLabel;
            System.Windows.Forms.Label inductionExpLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTruckDriver2024 = new System.Windows.Forms.BindingSource(this.components);
            this.dsQWSLocal2024 = new QWS_Local.dsQWSLocal2024();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.activeTextBox = new System.Windows.Forms.TextBox();
            this.inductionExpTextBox = new System.Windows.Forms.TextBox();
            this.licenseExpTextBox = new System.Windows.Forms.TextBox();
            this.sAPUpdateDTTMTextBox = new System.Windows.Forms.TextBox();
            this.licenseTypeTextBox = new System.Windows.Forms.TextBox();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.cardCodeTextBox = new System.Windows.Forms.TextBox();
            this.tradingNameTextBox = new System.Windows.Forms.TextBox();
            this.tpOffline = new System.Windows.Forms.TabPage();
            this.txtSAPCntctCode = new System.Windows.Forms.TextBox();
            this.txtQWSCntctCode = new System.Windows.Forms.TextBox();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.txtInductionExp = new System.Windows.Forms.TextBox();
            this.txtLicenseExp = new System.Windows.Forms.TextBox();
            this.txtSAPUpdateDTTM = new System.Windows.Forms.TextBox();
            this.txtLicenseType = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.txtTradingName = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSelectDriver = new System.Windows.Forms.Button();
            this.taTruckDriver2024 = new QWS_Local.dsQWSLocal2024TableAdapters.TruckDriverTableAdapter();
            this.btnLinkContact2SAP = new System.Windows.Forms.Button();
            this.btnAddOfflineContact = new System.Windows.Forms.Button();
            licenseTypeLabel = new System.Windows.Forms.Label();
            sAPUpdateDTTMLabel = new System.Windows.Forms.Label();
            licenseExpLabel = new System.Windows.Forms.Label();
            inductionExpLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpList.SuspendLayout();
            this.tpDetails.SuspendLayout();
            this.tpOffline.SuspendLayout();
            this.SuspendLayout();
            // 
            // licenseTypeLabel
            // 
            licenseTypeLabel.AutoSize = true;
            licenseTypeLabel.Location = new System.Drawing.Point(394, 96);
            licenseTypeLabel.Name = "licenseTypeLabel";
            licenseTypeLabel.Size = new System.Drawing.Size(99, 18);
            licenseTypeLabel.TabIndex = 10;
            licenseTypeLabel.Text = "License Type:";
            // 
            // sAPUpdateDTTMLabel
            // 
            sAPUpdateDTTMLabel.AutoSize = true;
            sAPUpdateDTTMLabel.Location = new System.Drawing.Point(592, 235);
            sAPUpdateDTTMLabel.Name = "sAPUpdateDTTMLabel";
            sAPUpdateDTTMLabel.Size = new System.Drawing.Size(134, 18);
            sAPUpdateDTTMLabel.TabIndex = 18;
            sAPUpdateDTTMLabel.Text = "SAPUpdate DTTM:";
            // 
            // licenseExpLabel
            // 
            licenseExpLabel.AutoSize = true;
            licenseExpLabel.Location = new System.Drawing.Point(404, 128);
            licenseExpLabel.Name = "licenseExpLabel";
            licenseExpLabel.Size = new System.Drawing.Size(92, 18);
            licenseExpLabel.TabIndex = 19;
            licenseExpLabel.Text = "License Exp:";
            // 
            // inductionExpLabel
            // 
            inductionExpLabel.AutoSize = true;
            inductionExpLabel.Location = new System.Drawing.Point(395, 161);
            inductionExpLabel.Name = "inductionExpLabel";
            inductionExpLabel.Size = new System.Drawing.Size(100, 18);
            inductionExpLabel.TabIndex = 20;
            inductionExpLabel.Text = "Induction Exp:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(447, 194);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(51, 18);
            activeLabel.TabIndex = 21;
            activeLabel.Text = "Active:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(426, 201);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 18);
            label1.TabIndex = 35;
            label1.Text = "Active:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(374, 168);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 18);
            label2.TabIndex = 33;
            label2.Text = "Induction Exp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(383, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 18);
            label3.TabIndex = 31;
            label3.Text = "License Exp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(174, 230);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 18);
            label4.TabIndex = 30;
            label4.Text = "SAPUpdate DTTM:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(373, 103);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 18);
            label5.TabIndex = 28;
            label5.Text = "License Type:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activeDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn,
            this.mobDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsTruckDriver2024;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewTextBoxColumn.FalseValue = "N";
            this.activeDataGridViewTextBoxColumn.HeaderText = "Active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            this.activeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.activeDataGridViewTextBoxColumn.TrueValue = "Y";
            this.activeDataGridViewTextBoxColumn.Width = 70;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            this.personDataGridViewTextBoxColumn.Width = 250;
            // 
            // mobDataGridViewTextBoxColumn
            // 
            this.mobDataGridViewTextBoxColumn.DataPropertyName = "Mob";
            this.mobDataGridViewTextBoxColumn.HeaderText = "Mob";
            this.mobDataGridViewTextBoxColumn.Name = "mobDataGridViewTextBoxColumn";
            this.mobDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 250;
            // 
            // bsTruckDriver2024
            // 
            this.bsTruckDriver2024.DataMember = "TruckDriver";
            this.bsTruckDriver2024.DataSource = this.dsQWSLocal2024;
            this.bsTruckDriver2024.CurrentChanged += new System.EventHandler(this.bsTruckDriver2024_CurrentChanged);
            // 
            // dsQWSLocal2024
            // 
            this.dsQWSLocal2024.DataSetName = "dsQWSLocal2024";
            this.dsQWSLocal2024.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtInfo);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelectDriver);
            this.splitContainer1.Size = new System.Drawing.Size(1195, 430);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpList);
            this.tabControl1.Controls.Add(this.tpDetails);
            this.tabControl1.Controls.Add(this.tpOffline);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 311);
            this.tabControl1.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dataGridView1);
            this.tpList.Location = new System.Drawing.Point(4, 27);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(1187, 280);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // tpDetails
            // 
            this.tpDetails.AutoScroll = true;
            this.tpDetails.Controls.Add(activeLabel);
            this.tpDetails.Controls.Add(this.activeTextBox);
            this.tpDetails.Controls.Add(inductionExpLabel);
            this.tpDetails.Controls.Add(this.inductionExpTextBox);
            this.tpDetails.Controls.Add(licenseExpLabel);
            this.tpDetails.Controls.Add(this.licenseExpTextBox);
            this.tpDetails.Controls.Add(sAPUpdateDTTMLabel);
            this.tpDetails.Controls.Add(this.sAPUpdateDTTMTextBox);
            this.tpDetails.Controls.Add(licenseTypeLabel);
            this.tpDetails.Controls.Add(this.licenseTypeTextBox);
            this.tpDetails.Controls.Add(this.mobTextBox);
            this.tpDetails.Controls.Add(this.positionTextBox);
            this.tpDetails.Controls.Add(this.personTextBox);
            this.tpDetails.Controls.Add(this.cardCodeTextBox);
            this.tpDetails.Controls.Add(this.tradingNameTextBox);
            this.tpDetails.Location = new System.Drawing.Point(4, 22);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(1187, 285);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // activeTextBox
            // 
            this.activeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Active", true));
            this.activeTextBox.Location = new System.Drawing.Point(510, 190);
            this.activeTextBox.Name = "activeTextBox";
            this.activeTextBox.Size = new System.Drawing.Size(112, 24);
            this.activeTextBox.TabIndex = 22;
            // 
            // inductionExpTextBox
            // 
            this.inductionExpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "InductionExp", true));
            this.inductionExpTextBox.Location = new System.Drawing.Point(510, 158);
            this.inductionExpTextBox.Name = "inductionExpTextBox";
            this.inductionExpTextBox.Size = new System.Drawing.Size(112, 24);
            this.inductionExpTextBox.TabIndex = 21;
            // 
            // licenseExpTextBox
            // 
            this.licenseExpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "LicenseExp", true));
            this.licenseExpTextBox.Location = new System.Drawing.Point(510, 125);
            this.licenseExpTextBox.Name = "licenseExpTextBox";
            this.licenseExpTextBox.Size = new System.Drawing.Size(112, 24);
            this.licenseExpTextBox.TabIndex = 20;
            // 
            // sAPUpdateDTTMTextBox
            // 
            this.sAPUpdateDTTMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "SAPUpdateDTTM", true));
            this.sAPUpdateDTTMTextBox.Location = new System.Drawing.Point(742, 232);
            this.sAPUpdateDTTMTextBox.Name = "sAPUpdateDTTMTextBox";
            this.sAPUpdateDTTMTextBox.Size = new System.Drawing.Size(277, 24);
            this.sAPUpdateDTTMTextBox.TabIndex = 19;
            // 
            // licenseTypeTextBox
            // 
            this.licenseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "LicenseType", true));
            this.licenseTypeTextBox.Location = new System.Drawing.Point(510, 92);
            this.licenseTypeTextBox.Name = "licenseTypeTextBox";
            this.licenseTypeTextBox.Size = new System.Drawing.Size(112, 24);
            this.licenseTypeTextBox.TabIndex = 11;
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(57, 125);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.Size = new System.Drawing.Size(112, 24);
            this.mobTextBox.TabIndex = 9;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(57, 92);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(264, 24);
            this.positionTextBox.TabIndex = 7;
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(57, 60);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(264, 24);
            this.personTextBox.TabIndex = 5;
            // 
            // cardCodeTextBox
            // 
            this.cardCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "CardCode", true));
            this.cardCodeTextBox.Location = new System.Drawing.Point(328, 27);
            this.cardCodeTextBox.Name = "cardCodeTextBox";
            this.cardCodeTextBox.Size = new System.Drawing.Size(112, 24);
            this.cardCodeTextBox.TabIndex = 3;
            // 
            // tradingNameTextBox
            // 
            this.tradingNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "TradingName", true));
            this.tradingNameTextBox.Location = new System.Drawing.Point(57, 27);
            this.tradingNameTextBox.Name = "tradingNameTextBox";
            this.tradingNameTextBox.Size = new System.Drawing.Size(264, 24);
            this.tradingNameTextBox.TabIndex = 1;
            // 
            // tpOffline
            // 
            this.tpOffline.Controls.Add(this.btnLinkContact2SAP);
            this.tpOffline.Controls.Add(this.btnAddOfflineContact);
            this.tpOffline.Controls.Add(this.txtSAPCntctCode);
            this.tpOffline.Controls.Add(this.txtQWSCntctCode);
            this.tpOffline.Controls.Add(label1);
            this.tpOffline.Controls.Add(this.txtActive);
            this.tpOffline.Controls.Add(label2);
            this.tpOffline.Controls.Add(this.txtInductionExp);
            this.tpOffline.Controls.Add(label3);
            this.tpOffline.Controls.Add(this.txtLicenseExp);
            this.tpOffline.Controls.Add(label4);
            this.tpOffline.Controls.Add(this.txtSAPUpdateDTTM);
            this.tpOffline.Controls.Add(label5);
            this.tpOffline.Controls.Add(this.txtLicenseType);
            this.tpOffline.Controls.Add(this.txtMobile);
            this.tpOffline.Controls.Add(this.txtPosition);
            this.tpOffline.Controls.Add(this.txtPerson);
            this.tpOffline.Controls.Add(this.txtCardCode);
            this.tpOffline.Controls.Add(this.txtTradingName);
            this.tpOffline.Location = new System.Drawing.Point(4, 27);
            this.tpOffline.Name = "tpOffline";
            this.tpOffline.Size = new System.Drawing.Size(1187, 280);
            this.tpOffline.TabIndex = 2;
            this.tpOffline.Text = "Offline";
            this.tpOffline.UseVisualStyleBackColor = true;
            // 
            // txtSAPCntctCode
            // 
            this.txtSAPCntctCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "CntctCode", true));
            this.txtSAPCntctCode.Location = new System.Drawing.Point(489, 34);
            this.txtSAPCntctCode.Name = "txtSAPCntctCode";
            this.txtSAPCntctCode.Size = new System.Drawing.Size(112, 24);
            this.txtSAPCntctCode.TabIndex = 39;
            // 
            // txtQWSCntctCode
            // 
            this.txtQWSCntctCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "SAPCntctCode", true));
            this.txtQWSCntctCode.Location = new System.Drawing.Point(721, 34);
            this.txtQWSCntctCode.Name = "txtQWSCntctCode";
            this.txtQWSCntctCode.Size = new System.Drawing.Size(112, 24);
            this.txtQWSCntctCode.TabIndex = 38;
            // 
            // txtActive
            // 
            this.txtActive.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Active", true));
            this.txtActive.Location = new System.Drawing.Point(489, 197);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(112, 24);
            this.txtActive.TabIndex = 37;
            // 
            // txtInductionExp
            // 
            this.txtInductionExp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "InductionExp", true));
            this.txtInductionExp.Location = new System.Drawing.Point(489, 165);
            this.txtInductionExp.Name = "txtInductionExp";
            this.txtInductionExp.Size = new System.Drawing.Size(112, 24);
            this.txtInductionExp.TabIndex = 36;
            // 
            // txtLicenseExp
            // 
            this.txtLicenseExp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "LicenseExp", true));
            this.txtLicenseExp.Location = new System.Drawing.Point(489, 132);
            this.txtLicenseExp.Name = "txtLicenseExp";
            this.txtLicenseExp.Size = new System.Drawing.Size(112, 24);
            this.txtLicenseExp.TabIndex = 34;
            // 
            // txtSAPUpdateDTTM
            // 
            this.txtSAPUpdateDTTM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "SAPUpdateDTTM", true));
            this.txtSAPUpdateDTTM.Location = new System.Drawing.Point(324, 227);
            this.txtSAPUpdateDTTM.Name = "txtSAPUpdateDTTM";
            this.txtSAPUpdateDTTM.Size = new System.Drawing.Size(277, 24);
            this.txtSAPUpdateDTTM.TabIndex = 32;
            // 
            // txtLicenseType
            // 
            this.txtLicenseType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "LicenseType", true));
            this.txtLicenseType.Location = new System.Drawing.Point(489, 99);
            this.txtLicenseType.Name = "txtLicenseType";
            this.txtLicenseType.Size = new System.Drawing.Size(112, 24);
            this.txtLicenseType.TabIndex = 29;
            // 
            // txtMobile
            // 
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Mob", true));
            this.txtMobile.Location = new System.Drawing.Point(36, 132);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(112, 24);
            this.txtMobile.TabIndex = 27;
            // 
            // txtPosition
            // 
            this.txtPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Position", true));
            this.txtPosition.Location = new System.Drawing.Point(36, 99);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(264, 24);
            this.txtPosition.TabIndex = 26;
            // 
            // txtPerson
            // 
            this.txtPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "Person", true));
            this.txtPerson.Location = new System.Drawing.Point(36, 67);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(264, 24);
            this.txtPerson.TabIndex = 25;
            // 
            // txtCardCode
            // 
            this.txtCardCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "CardCode", true));
            this.txtCardCode.Location = new System.Drawing.Point(307, 34);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(112, 24);
            this.txtCardCode.TabIndex = 24;
            // 
            // txtTradingName
            // 
            this.txtTradingName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver2024, "TradingName", true));
            this.txtTradingName.Location = new System.Drawing.Point(36, 34);
            this.txtTradingName.Name = "txtTradingName";
            this.txtTradingName.Size = new System.Drawing.Size(264, 24);
            this.txtTradingName.TabIndex = 23;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(62, 34);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(445, 24);
            this.txtInfo.TabIndex = 5;
            // 
            // btnSelectDriver
            // 
            this.btnSelectDriver.Location = new System.Drawing.Point(560, 21);
            this.btnSelectDriver.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectDriver.Name = "btnSelectDriver";
            this.btnSelectDriver.Size = new System.Drawing.Size(150, 62);
            this.btnSelectDriver.TabIndex = 1;
            this.btnSelectDriver.Text = "Select";
            this.btnSelectDriver.UseVisualStyleBackColor = true;
            this.btnSelectDriver.Click += new System.EventHandler(this.btnSelectDriver_Click);
            // 
            // taTruckDriver2024
            // 
            this.taTruckDriver2024.ClearBeforeFill = true;
            // 
            // btnLinkContact2SAP
            // 
            this.btnLinkContact2SAP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinkContact2SAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkContact2SAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkContact2SAP.Location = new System.Drawing.Point(859, 30);
            this.btnLinkContact2SAP.Margin = new System.Windows.Forms.Padding(4);
            this.btnLinkContact2SAP.Name = "btnLinkContact2SAP";
            this.btnLinkContact2SAP.Size = new System.Drawing.Size(63, 33);
            this.btnLinkContact2SAP.TabIndex = 74;
            this.btnLinkContact2SAP.Text = "Link";
            this.btnLinkContact2SAP.UseVisualStyleBackColor = false;
            this.btnLinkContact2SAP.Click += new System.EventHandler(this.btnLinkContact2SAP_Click);
            // 
            // btnAddOfflineContact
            // 
            this.btnAddOfflineContact.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddOfflineContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOfflineContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOfflineContact.Location = new System.Drawing.Point(808, 202);
            this.btnAddOfflineContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOfflineContact.Name = "btnAddOfflineContact";
            this.btnAddOfflineContact.Size = new System.Drawing.Size(114, 49);
            this.btnAddOfflineContact.TabIndex = 73;
            this.btnAddOfflineContact.Text = "Save";
            this.btnAddOfflineContact.UseVisualStyleBackColor = false;
            this.btnAddOfflineContact.Click += new System.EventHandler(this.btnAddOfflineContact_Click);
            // 
            // TruckDriverSearch
            // 
            this.AcceptButton = this.btnSelectDriver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 432);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TruckDriverSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Truck Driver Search";
            this.Load += new System.EventHandler(this.TruckDriverSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal2024)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.tpOffline.ResumeLayout(false);
            this.tpOffline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSelectDriver;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TextBox inductionExpTextBox;
        private System.Windows.Forms.TextBox licenseExpTextBox;
        private System.Windows.Forms.TextBox sAPUpdateDTTMTextBox;
        private System.Windows.Forms.TextBox licenseTypeTextBox;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.TextBox cardCodeTextBox;
        private System.Windows.Forms.TextBox tradingNameTextBox;
        private System.Windows.Forms.TextBox activeTextBox;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private dsQWSLocal2024 dsQWSLocal2024;
        private System.Windows.Forms.BindingSource bsTruckDriver2024;
        private dsQWSLocal2024TableAdapters.TruckDriverTableAdapter taTruckDriver2024;
        private System.Windows.Forms.TabPage tpOffline;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.TextBox txtInductionExp;
        private System.Windows.Forms.TextBox txtLicenseExp;
        private System.Windows.Forms.TextBox txtSAPUpdateDTTM;
        private System.Windows.Forms.TextBox txtLicenseType;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TextBox txtTradingName;
        private System.Windows.Forms.TextBox txtQWSCntctCode;
        private System.Windows.Forms.TextBox txtSAPCntctCode;
        private System.Windows.Forms.Button btnLinkContact2SAP;
        private System.Windows.Forms.Button btnAddOfflineContact;
    }
}