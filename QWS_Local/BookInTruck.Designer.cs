
namespace QWS_Local
{
    partial class BookInTruck
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
            System.Windows.Forms.Label regoTkLabel;
            System.Windows.Forms.Label personLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label mobLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label licenseTypeLabel;
            System.Windows.Forms.Label licenseExpLabel;
            System.Windows.Forms.Label inductionExpLabel;
            System.Windows.Forms.Label activeLabel;
            this.regoTkTextBox = new System.Windows.Forms.TextBox();
            this.bsConfiguredTnT = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.taConfiguredTnT = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.txtAxleConfig2 = new System.Windows.Forms.TextBox();
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.bsTruckDriver = new System.Windows.Forms.BindingSource(this.components);
            this.taTruckDriver = new QWS_Local.dsQWSLocalTableAdapters.TruckDriverTableAdapter();
            this.tableAdapterManager1 = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.mobTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.licenseTypeTextBox = new System.Windows.Forms.TextBox();
            this.inductionExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activeTextBox = new System.Windows.Forms.TextBox();
            this.licenseExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            regoTkLabel = new System.Windows.Forms.Label();
            personLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            mobLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            licenseTypeLabel = new System.Windows.Forms.Label();
            licenseExpLabel = new System.Windows.Forms.Label();
            inductionExpLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // regoTkLabel
            // 
            regoTkLabel.AutoSize = true;
            regoTkLabel.Location = new System.Drawing.Point(183, 80);
            regoTkLabel.Name = "regoTkLabel";
            regoTkLabel.Size = new System.Drawing.Size(52, 13);
            regoTkLabel.TabIndex = 2;
            regoTkLabel.Text = "Rego Tk:";
            // 
            // regoTkTextBox
            // 
            this.regoTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnT, "RegoTk", true));
            this.regoTkTextBox.Location = new System.Drawing.Point(241, 77);
            this.regoTkTextBox.Name = "regoTkTextBox";
            this.regoTkTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTkTextBox.TabIndex = 3;
            // 
            // bsConfiguredTnT
            // 
            this.bsConfiguredTnT.DataMember = "ConfiguredTnT";
            this.bsConfiguredTnT.DataSource = this.dsTruckConfig;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Truck Driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taConfiguredTnT
            // 
            this.taConfiguredTnT.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtCardCode
            // 
            this.txtCardCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnT, "CardCode", true));
            this.txtCardCode.Location = new System.Drawing.Point(241, 120);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(100, 20);
            this.txtCardCode.TabIndex = 6;
            // 
            // txtAxleConfig2
            // 
            this.txtAxleConfig2.Location = new System.Drawing.Point(241, 146);
            this.txtAxleConfig2.Name = "txtAxleConfig2";
            this.txtAxleConfig2.Size = new System.Drawing.Size(100, 20);
            this.txtAxleConfig2.TabIndex = 7;
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsTruckDriver
            // 
            this.bsTruckDriver.DataMember = "TruckDriver";
            this.bsTruckDriver.DataSource = this.dsQWSLocal;
            // 
            // taTruckDriver
            // 
            this.taTruckDriver.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.NHVLTableAdapter = null;
            this.tableAdapterManager1.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager1.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager1.PBSTableAdapter = null;
            this.tableAdapterManager1.SchemeCodesTableAdapter = null;
            this.tableAdapterManager1.TruckConfigTableAdapter = null;
            this.tableAdapterManager1.TruckConfigVehicleTableAdapter = null;
            this.tableAdapterManager1.TrucksInQuarryTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VehiclePBSTableAdapter = null;
            this.tableAdapterManager1.VehiclePrefCustomersTableAdapter = null;
            this.tableAdapterManager1.VehicleRegFeeCodesTableAdapter = null;
            this.tableAdapterManager1.VehicleTableAdapter = null;
            this.tableAdapterManager1.VehicleTypeTableAdapter = null;
            // 
            // personLabel
            // 
            personLabel.AutoSize = true;
            personLabel.Location = new System.Drawing.Point(406, 201);
            personLabel.Name = "personLabel";
            personLabel.Size = new System.Drawing.Size(43, 13);
            personLabel.TabIndex = 9;
            personLabel.Text = "Person:";
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(455, 198);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(100, 20);
            this.personTextBox.TabIndex = 10;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(402, 227);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 10;
            positionLabel.Text = "Position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(455, 224);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(245, 20);
            this.positionTextBox.TabIndex = 11;
            // 
            // mobLabel
            // 
            mobLabel.AutoSize = true;
            mobLabel.Location = new System.Drawing.Point(563, 253);
            mobLabel.Name = "mobLabel";
            mobLabel.Size = new System.Drawing.Size(31, 13);
            mobLabel.TabIndex = 12;
            mobLabel.Text = "Mob:";
            // 
            // mobTextBox
            // 
            this.mobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Mob", true));
            this.mobTextBox.Location = new System.Drawing.Point(600, 250);
            this.mobTextBox.Name = "mobTextBox";
            this.mobTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobTextBox.TabIndex = 13;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(424, 253);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(25, 13);
            telLabel.TabIndex = 14;
            telLabel.Text = "Tel:";
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Tel", true));
            this.telTextBox.Location = new System.Drawing.Point(455, 250);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 20);
            this.telTextBox.TabIndex = 15;
            // 
            // licenseTypeLabel
            // 
            licenseTypeLabel.AutoSize = true;
            licenseTypeLabel.Location = new System.Drawing.Point(375, 279);
            licenseTypeLabel.Name = "licenseTypeLabel";
            licenseTypeLabel.Size = new System.Drawing.Size(74, 13);
            licenseTypeLabel.TabIndex = 16;
            licenseTypeLabel.Text = "License Type:";
            // 
            // licenseTypeTextBox
            // 
            this.licenseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "LicenseType", true));
            this.licenseTypeTextBox.Location = new System.Drawing.Point(455, 276);
            this.licenseTypeTextBox.Name = "licenseTypeTextBox";
            this.licenseTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.licenseTypeTextBox.TabIndex = 17;
            // 
            // licenseExpLabel
            // 
            licenseExpLabel.AutoSize = true;
            licenseExpLabel.Location = new System.Drawing.Point(381, 306);
            licenseExpLabel.Name = "licenseExpLabel";
            licenseExpLabel.Size = new System.Drawing.Size(68, 13);
            licenseExpLabel.TabIndex = 18;
            licenseExpLabel.Text = "License Exp:";
            // 
            // inductionExpLabel
            // 
            inductionExpLabel.AutoSize = true;
            inductionExpLabel.Location = new System.Drawing.Point(374, 332);
            inductionExpLabel.Name = "inductionExpLabel";
            inductionExpLabel.Size = new System.Drawing.Size(75, 13);
            inductionExpLabel.TabIndex = 20;
            inductionExpLabel.Text = "Induction Exp:";
            // 
            // inductionExpDateTimePicker
            // 
            this.inductionExpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTruckDriver, "InductionExp", true));
            this.inductionExpDateTimePicker.Enabled = false;
            this.inductionExpDateTimePicker.Location = new System.Drawing.Point(455, 328);
            this.inductionExpDateTimePicker.Name = "inductionExpDateTimePicker";
            this.inductionExpDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.inductionExpDateTimePicker.TabIndex = 21;
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(577, 201);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(40, 13);
            activeLabel.TabIndex = 22;
            activeLabel.Text = "Active:";
            // 
            // activeTextBox
            // 
            this.activeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTruckDriver, "Active", true));
            this.activeTextBox.Location = new System.Drawing.Point(623, 198);
            this.activeTextBox.Name = "activeTextBox";
            this.activeTextBox.Size = new System.Drawing.Size(77, 20);
            this.activeTextBox.TabIndex = 23;
            // 
            // licenseExpDateTimePicker
            // 
            this.licenseExpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTruckDriver, "LicenseExp", true));
            this.licenseExpDateTimePicker.Enabled = false;
            this.licenseExpDateTimePicker.Location = new System.Drawing.Point(455, 302);
            this.licenseExpDateTimePicker.Name = "licenseExpDateTimePicker";
            this.licenseExpDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.licenseExpDateTimePicker.TabIndex = 19;
            // 
            // BookInTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeTextBox);
            this.Controls.Add(inductionExpLabel);
            this.Controls.Add(this.inductionExpDateTimePicker);
            this.Controls.Add(licenseExpLabel);
            this.Controls.Add(this.licenseExpDateTimePicker);
            this.Controls.Add(licenseTypeLabel);
            this.Controls.Add(this.licenseTypeTextBox);
            this.Controls.Add(telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(mobLabel);
            this.Controls.Add(this.mobTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(personLabel);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.txtAxleConfig2);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(regoTkLabel);
            this.Controls.Add(this.regoTkTextBox);
            this.Name = "BookInTruck";
            this.Text = "BookInTruck";
            this.Load += new System.EventHandler(this.BookInTruck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTruckDriver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource bsConfiguredTnT;
        private dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter taConfiguredTnT;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox regoTkTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TextBox txtAxleConfig2;
        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource bsTruckDriver;
        private dsQWSLocalTableAdapters.TruckDriverTableAdapter taTruckDriver;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox mobTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox licenseTypeTextBox;
        private System.Windows.Forms.DateTimePicker inductionExpDateTimePicker;
        private System.Windows.Forms.TextBox activeTextBox;
        private System.Windows.Forms.DateTimePicker licenseExpDateTimePicker;
    }
}