
namespace QWS_Local
{
    partial class TIQDetail
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
            System.Windows.Forms.Label siteIDLabel;
            System.Windows.Forms.Label regoLabel;
            System.Windows.Forms.Label entryDTTMLabel;
            System.Windows.Forms.Label allocateDTTMLabel;
            System.Windows.Forms.Label releaseDTTMLabel;
            System.Windows.Forms.Label acceptanceDTTMLabel;
            System.Windows.Forms.Label exitDTTMLabel;
            System.Windows.Forms.Label queueStatusLabel;
            System.Windows.Forms.Label weighbridgeIDLabel;
            System.Windows.Forms.Label sAPOrderLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label materialDescLabel;
            System.Windows.Forms.Label driverLabel;
            System.Windows.Forms.Label payloadLabel;
            System.Windows.Forms.Label gVMLabel;
            this.dsQWSLocal = new QWS_Local.dsQWSLocal();
            this.trucksInQuarryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trucksInQuarryTableAdapter = new QWS_Local.dsQWSLocalTableAdapters.TrucksInQuarryTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager();
            this.siteIDTextBox = new System.Windows.Forms.TextBox();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.entryDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.allocateDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.releaseDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.acceptanceDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.exitDTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.queueStatusTextBox = new System.Windows.Forms.TextBox();
            this.weighbridgeIDTextBox = new System.Windows.Forms.TextBox();
            this.sAPOrderTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.materialDescTextBox = new System.Windows.Forms.TextBox();
            this.driverTextBox = new System.Windows.Forms.TextBox();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            this.gVMTextBox = new System.Windows.Forms.TextBox();
            siteIDLabel = new System.Windows.Forms.Label();
            regoLabel = new System.Windows.Forms.Label();
            entryDTTMLabel = new System.Windows.Forms.Label();
            allocateDTTMLabel = new System.Windows.Forms.Label();
            releaseDTTMLabel = new System.Windows.Forms.Label();
            acceptanceDTTMLabel = new System.Windows.Forms.Label();
            exitDTTMLabel = new System.Windows.Forms.Label();
            queueStatusLabel = new System.Windows.Forms.Label();
            weighbridgeIDLabel = new System.Windows.Forms.Label();
            sAPOrderLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            materialDescLabel = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            payloadLabel = new System.Windows.Forms.Label();
            gVMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksInQuarryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siteIDLabel
            // 
            siteIDLabel.AutoSize = true;
            siteIDLabel.Location = new System.Drawing.Point(90, 91);
            siteIDLabel.Name = "siteIDLabel";
            siteIDLabel.Size = new System.Drawing.Size(42, 13);
            siteIDLabel.TabIndex = 2;
            siteIDLabel.Text = "Site ID:";
            // 
            // regoLabel
            // 
            regoLabel.AutoSize = true;
            regoLabel.Location = new System.Drawing.Point(75, 135);
            regoLabel.Name = "regoLabel";
            regoLabel.Size = new System.Drawing.Size(36, 13);
            regoLabel.TabIndex = 4;
            regoLabel.Text = "Rego:";
            // 
            // entryDTTMLabel
            // 
            entryDTTMLabel.AutoSize = true;
            entryDTTMLabel.Location = new System.Drawing.Point(81, 176);
            entryDTTMLabel.Name = "entryDTTMLabel";
            entryDTTMLabel.Size = new System.Drawing.Size(68, 13);
            entryDTTMLabel.TabIndex = 6;
            entryDTTMLabel.Text = "Entry DTTM:";
            // 
            // allocateDTTMLabel
            // 
            allocateDTTMLabel.AutoSize = true;
            allocateDTTMLabel.Location = new System.Drawing.Point(70, 220);
            allocateDTTMLabel.Name = "allocateDTTMLabel";
            allocateDTTMLabel.Size = new System.Drawing.Size(82, 13);
            allocateDTTMLabel.TabIndex = 8;
            allocateDTTMLabel.Text = "Allocate DTTM:";
            // 
            // releaseDTTMLabel
            // 
            releaseDTTMLabel.AutoSize = true;
            releaseDTTMLabel.Location = new System.Drawing.Point(72, 273);
            releaseDTTMLabel.Name = "releaseDTTMLabel";
            releaseDTTMLabel.Size = new System.Drawing.Size(83, 13);
            releaseDTTMLabel.TabIndex = 10;
            releaseDTTMLabel.Text = "Release DTTM:";
            // 
            // acceptanceDTTMLabel
            // 
            acceptanceDTTMLabel.AutoSize = true;
            acceptanceDTTMLabel.Location = new System.Drawing.Point(74, 314);
            acceptanceDTTMLabel.Name = "acceptanceDTTMLabel";
            acceptanceDTTMLabel.Size = new System.Drawing.Size(102, 13);
            acceptanceDTTMLabel.TabIndex = 12;
            acceptanceDTTMLabel.Text = "Acceptance DTTM:";
            // 
            // exitDTTMLabel
            // 
            exitDTTMLabel.AutoSize = true;
            exitDTTMLabel.Location = new System.Drawing.Point(85, 349);
            exitDTTMLabel.Name = "exitDTTMLabel";
            exitDTTMLabel.Size = new System.Drawing.Size(61, 13);
            exitDTTMLabel.TabIndex = 14;
            exitDTTMLabel.Text = "Exit DTTM:";
            // 
            // queueStatusLabel
            // 
            queueStatusLabel.AutoSize = true;
            queueStatusLabel.Location = new System.Drawing.Point(98, 388);
            queueStatusLabel.Name = "queueStatusLabel";
            queueStatusLabel.Size = new System.Drawing.Size(75, 13);
            queueStatusLabel.TabIndex = 16;
            queueStatusLabel.Text = "Queue Status:";
            // 
            // weighbridgeIDLabel
            // 
            weighbridgeIDLabel.AutoSize = true;
            weighbridgeIDLabel.Location = new System.Drawing.Point(453, 92);
            weighbridgeIDLabel.Name = "weighbridgeIDLabel";
            weighbridgeIDLabel.Size = new System.Drawing.Size(84, 13);
            weighbridgeIDLabel.TabIndex = 17;
            weighbridgeIDLabel.Text = "Weighbridge ID:";
            // 
            // sAPOrderLabel
            // 
            sAPOrderLabel.AutoSize = true;
            sAPOrderLabel.Location = new System.Drawing.Point(469, 149);
            sAPOrderLabel.Name = "sAPOrderLabel";
            sAPOrderLabel.Size = new System.Drawing.Size(57, 13);
            sAPOrderLabel.TabIndex = 19;
            sAPOrderLabel.Text = "SAPOrder:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(479, 191);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(47, 13);
            materialLabel.TabIndex = 21;
            materialLabel.Text = "Material:";
            // 
            // materialDescLabel
            // 
            materialDescLabel.AutoSize = true;
            materialDescLabel.Location = new System.Drawing.Point(483, 232);
            materialDescLabel.Name = "materialDescLabel";
            materialDescLabel.Size = new System.Drawing.Size(75, 13);
            materialDescLabel.TabIndex = 23;
            materialDescLabel.Text = "Material Desc:";
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(497, 276);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(38, 13);
            driverLabel.TabIndex = 25;
            driverLabel.Text = "Driver:";
            // 
            // payloadLabel
            // 
            payloadLabel.AutoSize = true;
            payloadLabel.Location = new System.Drawing.Point(519, 321);
            payloadLabel.Name = "payloadLabel";
            payloadLabel.Size = new System.Drawing.Size(48, 13);
            payloadLabel.TabIndex = 27;
            payloadLabel.Text = "Payload:";
            // 
            // gVMLabel
            // 
            gVMLabel.AutoSize = true;
            gVMLabel.Location = new System.Drawing.Point(511, 365);
            gVMLabel.Name = "gVMLabel";
            gVMLabel.Size = new System.Drawing.Size(34, 13);
            gVMLabel.TabIndex = 29;
            gVMLabel.Text = "GVM:";
            // 
            // dsQWSLocal
            // 
            this.dsQWSLocal.DataSetName = "dsQWSLocal";
            this.dsQWSLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trucksInQuarryBindingSource
            // 
            this.trucksInQuarryBindingSource.DataMember = "TrucksInQuarry";
            this.trucksInQuarryBindingSource.DataSource = this.dsQWSLocal;
            // 
            // trucksInQuarryTableAdapter
            // 
            this.trucksInQuarryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AxleConfigurationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NHVR_GVMTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBS_VINTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = null;
            this.tableAdapterManager.TruckConfigTableAdapter = null;
            this.tableAdapterManager.TruckConfigTrailersTableAdapter = null;
            this.tableAdapterManager.TrucksInQuarryTableAdapter = this.trucksInQuarryTableAdapter;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsQWSLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // siteIDTextBox
            // 
            this.siteIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "SiteID", true));
            this.siteIDTextBox.Location = new System.Drawing.Point(138, 88);
            this.siteIDTextBox.Name = "siteIDTextBox";
            this.siteIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.siteIDTextBox.TabIndex = 3;
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "Rego", true));
            this.regoTextBox.Location = new System.Drawing.Point(117, 132);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTextBox.TabIndex = 5;
            // 
            // entryDTTMDateTimePicker
            // 
            this.entryDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trucksInQuarryBindingSource, "EntryDTTM", true));
            this.entryDTTMDateTimePicker.Location = new System.Drawing.Point(155, 172);
            this.entryDTTMDateTimePicker.Name = "entryDTTMDateTimePicker";
            this.entryDTTMDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.entryDTTMDateTimePicker.TabIndex = 7;
            // 
            // allocateDTTMDateTimePicker
            // 
            this.allocateDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trucksInQuarryBindingSource, "AllocateDTTM", true));
            this.allocateDTTMDateTimePicker.Location = new System.Drawing.Point(158, 216);
            this.allocateDTTMDateTimePicker.Name = "allocateDTTMDateTimePicker";
            this.allocateDTTMDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.allocateDTTMDateTimePicker.TabIndex = 9;
            // 
            // releaseDTTMDateTimePicker
            // 
            this.releaseDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trucksInQuarryBindingSource, "ReleaseDTTM", true));
            this.releaseDTTMDateTimePicker.Location = new System.Drawing.Point(161, 269);
            this.releaseDTTMDateTimePicker.Name = "releaseDTTMDateTimePicker";
            this.releaseDTTMDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.releaseDTTMDateTimePicker.TabIndex = 11;
            // 
            // acceptanceDTTMDateTimePicker
            // 
            this.acceptanceDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trucksInQuarryBindingSource, "AcceptanceDTTM", true));
            this.acceptanceDTTMDateTimePicker.Location = new System.Drawing.Point(182, 310);
            this.acceptanceDTTMDateTimePicker.Name = "acceptanceDTTMDateTimePicker";
            this.acceptanceDTTMDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.acceptanceDTTMDateTimePicker.TabIndex = 13;
            // 
            // exitDTTMDateTimePicker
            // 
            this.exitDTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trucksInQuarryBindingSource, "ExitDTTM", true));
            this.exitDTTMDateTimePicker.Location = new System.Drawing.Point(152, 345);
            this.exitDTTMDateTimePicker.Name = "exitDTTMDateTimePicker";
            this.exitDTTMDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.exitDTTMDateTimePicker.TabIndex = 15;
            // 
            // queueStatusTextBox
            // 
            this.queueStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "QueueStatus", true));
            this.queueStatusTextBox.Location = new System.Drawing.Point(179, 385);
            this.queueStatusTextBox.Name = "queueStatusTextBox";
            this.queueStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.queueStatusTextBox.TabIndex = 17;
            // 
            // weighbridgeIDTextBox
            // 
            this.weighbridgeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "WeighbridgeID", true));
            this.weighbridgeIDTextBox.Location = new System.Drawing.Point(543, 89);
            this.weighbridgeIDTextBox.Name = "weighbridgeIDTextBox";
            this.weighbridgeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.weighbridgeIDTextBox.TabIndex = 18;
            // 
            // sAPOrderTextBox
            // 
            this.sAPOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "SAPOrder", true));
            this.sAPOrderTextBox.Location = new System.Drawing.Point(532, 146);
            this.sAPOrderTextBox.Name = "sAPOrderTextBox";
            this.sAPOrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.sAPOrderTextBox.TabIndex = 20;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(532, 188);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialTextBox.TabIndex = 22;
            // 
            // materialDescTextBox
            // 
            this.materialDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "MaterialDesc", true));
            this.materialDescTextBox.Location = new System.Drawing.Point(564, 229);
            this.materialDescTextBox.Name = "materialDescTextBox";
            this.materialDescTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialDescTextBox.TabIndex = 24;
            // 
            // driverTextBox
            // 
            this.driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "Driver", true));
            this.driverTextBox.Location = new System.Drawing.Point(541, 273);
            this.driverTextBox.Name = "driverTextBox";
            this.driverTextBox.Size = new System.Drawing.Size(100, 20);
            this.driverTextBox.TabIndex = 26;
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "Payload", true));
            this.payloadTextBox.Location = new System.Drawing.Point(573, 318);
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.Size = new System.Drawing.Size(100, 20);
            this.payloadTextBox.TabIndex = 28;
            // 
            // gVMTextBox
            // 
            this.gVMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trucksInQuarryBindingSource, "GVM", true));
            this.gVMTextBox.Location = new System.Drawing.Point(551, 362);
            this.gVMTextBox.Name = "gVMTextBox";
            this.gVMTextBox.Size = new System.Drawing.Size(100, 20);
            this.gVMTextBox.TabIndex = 30;
            // 
            // TIQDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(gVMLabel);
            this.Controls.Add(this.gVMTextBox);
            this.Controls.Add(payloadLabel);
            this.Controls.Add(this.payloadTextBox);
            this.Controls.Add(driverLabel);
            this.Controls.Add(this.driverTextBox);
            this.Controls.Add(materialDescLabel);
            this.Controls.Add(this.materialDescTextBox);
            this.Controls.Add(materialLabel);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(sAPOrderLabel);
            this.Controls.Add(this.sAPOrderTextBox);
            this.Controls.Add(weighbridgeIDLabel);
            this.Controls.Add(this.weighbridgeIDTextBox);
            this.Controls.Add(queueStatusLabel);
            this.Controls.Add(this.queueStatusTextBox);
            this.Controls.Add(exitDTTMLabel);
            this.Controls.Add(this.exitDTTMDateTimePicker);
            this.Controls.Add(acceptanceDTTMLabel);
            this.Controls.Add(this.acceptanceDTTMDateTimePicker);
            this.Controls.Add(releaseDTTMLabel);
            this.Controls.Add(this.releaseDTTMDateTimePicker);
            this.Controls.Add(allocateDTTMLabel);
            this.Controls.Add(this.allocateDTTMDateTimePicker);
            this.Controls.Add(entryDTTMLabel);
            this.Controls.Add(this.entryDTTMDateTimePicker);
            this.Controls.Add(regoLabel);
            this.Controls.Add(this.regoTextBox);
            this.Controls.Add(siteIDLabel);
            this.Controls.Add(this.siteIDTextBox);
            this.Name = "TIQDetail";
            this.Text = "TIQDetail";
            this.Load += new System.EventHandler(this.TIQDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsQWSLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksInQuarryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsQWSLocal dsQWSLocal;
        private System.Windows.Forms.BindingSource trucksInQuarryBindingSource;
        private dsQWSLocalTableAdapters.TrucksInQuarryTableAdapter trucksInQuarryTableAdapter;
        private dsQWSLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox siteIDTextBox;
        private System.Windows.Forms.TextBox regoTextBox;
        private System.Windows.Forms.DateTimePicker entryDTTMDateTimePicker;
        private System.Windows.Forms.DateTimePicker allocateDTTMDateTimePicker;
        private System.Windows.Forms.DateTimePicker releaseDTTMDateTimePicker;
        private System.Windows.Forms.DateTimePicker acceptanceDTTMDateTimePicker;
        private System.Windows.Forms.DateTimePicker exitDTTMDateTimePicker;
        private System.Windows.Forms.TextBox queueStatusTextBox;
        private System.Windows.Forms.TextBox weighbridgeIDTextBox;
        private System.Windows.Forms.TextBox sAPOrderTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox materialDescTextBox;
        private System.Windows.Forms.TextBox driverTextBox;
        private System.Windows.Forms.TextBox payloadTextBox;
        private System.Windows.Forms.TextBox gVMTextBox;
    }
}