namespace QWS_Local
{
    partial class PBSVehicles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtVA = new System.Windows.Forms.TextBox();
            this.btnFindPBS = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pBS_VehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnFindVehicles = new System.Windows.Forms.Button();
            this.btnSaveVehicles = new System.Windows.Forms.Button();
            this.pBSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPBS = new System.Windows.Forms.BindingSource(this.components);
            this.dsPBS = new QWS_Local.dsPBS();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPBS_Vehicles = new System.Windows.Forms.BindingSource(this.components);
            this.taPBS = new QWS_Local.dsPBSTableAdapters.PBSTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsPBSTableAdapters.TableAdapterManager();
            this.taPBS_Vehicles = new QWS_Local.dsPBSTableAdapters.PBS_VehiclesTableAdapter();
            this.txtPBS_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBS_VehiclesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS_Vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBSIDDataGridViewTextBoxColumn,
            this.vehicleApprovalDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.approvalDTDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsPBS;
            this.dataGridView1.Location = new System.Drawing.Point(26, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(703, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtVA
            // 
            this.txtVA.Location = new System.Drawing.Point(26, 14);
            this.txtVA.Name = "txtVA";
            this.txtVA.Size = new System.Drawing.Size(100, 20);
            this.txtVA.TabIndex = 1;
            // 
            // btnFindPBS
            // 
            this.btnFindPBS.Location = new System.Drawing.Point(154, 14);
            this.btnFindPBS.Name = "btnFindPBS";
            this.btnFindPBS.Size = new System.Drawing.Size(75, 23);
            this.btnFindPBS.TabIndex = 2;
            this.btnFindPBS.Text = "Find";
            this.btnFindPBS.UseVisualStyleBackColor = true;
            this.btnFindPBS.Click += new System.EventHandler(this.btnFindPBS_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindPBS);
            this.splitContainer1.Panel1.Controls.Add(this.txtVA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.txtPBS_ID);
            this.splitContainer1.Panel2.Controls.Add(this.btnFindVehicles);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveVehicles);
            this.splitContainer1.Panel2.Controls.Add(this.pBS_VehiclesDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 558);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 3;
            // 
            // pBS_VehiclesDataGridView
            // 
            this.pBS_VehiclesDataGridView.AutoGenerateColumns = false;
            this.pBS_VehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pBS_VehiclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pBS_VehiclesDataGridView.DataSource = this.bsPBS_Vehicles;
            this.pBS_VehiclesDataGridView.Location = new System.Drawing.Point(26, 26);
            this.pBS_VehiclesDataGridView.Name = "pBS_VehiclesDataGridView";
            this.pBS_VehiclesDataGridView.Size = new System.Drawing.Size(606, 220);
            this.pBS_VehiclesDataGridView.TabIndex = 0;
            // 
            // btnFindVehicles
            // 
            this.btnFindVehicles.Location = new System.Drawing.Point(201, 266);
            this.btnFindVehicles.Name = "btnFindVehicles";
            this.btnFindVehicles.Size = new System.Drawing.Size(75, 23);
            this.btnFindVehicles.TabIndex = 3;
            this.btnFindVehicles.Text = "Find";
            this.btnFindVehicles.UseVisualStyleBackColor = true;
            this.btnFindVehicles.Click += new System.EventHandler(this.btnFindVehicles_Click);
            // 
            // btnSaveVehicles
            // 
            this.btnSaveVehicles.Location = new System.Drawing.Point(557, 266);
            this.btnSaveVehicles.Name = "btnSaveVehicles";
            this.btnSaveVehicles.Size = new System.Drawing.Size(75, 23);
            this.btnSaveVehicles.TabIndex = 4;
            this.btnSaveVehicles.Text = "Save";
            this.btnSaveVehicles.UseVisualStyleBackColor = true;
            this.btnSaveVehicles.Click += new System.EventHandler(this.btnSaveVehicles_Click);
            // 
            // pBSIDDataGridViewTextBoxColumn
            // 
            this.pBSIDDataGridViewTextBoxColumn.DataPropertyName = "PBS_ID";
            this.pBSIDDataGridViewTextBoxColumn.HeaderText = "PBS_ID";
            this.pBSIDDataGridViewTextBoxColumn.Name = "pBSIDDataGridViewTextBoxColumn";
            this.pBSIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleApprovalDataGridViewTextBoxColumn
            // 
            this.vehicleApprovalDataGridViewTextBoxColumn.DataPropertyName = "VehicleApproval";
            this.vehicleApprovalDataGridViewTextBoxColumn.HeaderText = "VehicleApproval";
            this.vehicleApprovalDataGridViewTextBoxColumn.Name = "vehicleApprovalDataGridViewTextBoxColumn";
            this.vehicleApprovalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvalDTDataGridViewTextBoxColumn
            // 
            this.approvalDTDataGridViewTextBoxColumn.DataPropertyName = "ApprovalDT";
            this.approvalDTDataGridViewTextBoxColumn.HeaderText = "ApprovalDT";
            this.approvalDTDataGridViewTextBoxColumn.Name = "approvalDTDataGridViewTextBoxColumn";
            this.approvalDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            this.cardCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPBS
            // 
            this.bsPBS.DataMember = "PBS";
            this.bsPBS.DataSource = this.dsPBS;
            // 
            // dsPBS
            // 
            this.dsPBS.DataSetName = "dsPBS";
            this.dsPBS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PBS_VehicleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PBS_VehicleID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PBS_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PBS_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VIN";
            this.dataGridViewTextBoxColumn3.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TruckType";
            this.dataGridViewTextBoxColumn4.HeaderText = "TruckType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TruckTypeNo";
            this.dataGridViewTextBoxColumn5.HeaderText = "TruckTypeNo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bsPBS_Vehicles
            // 
            this.bsPBS_Vehicles.DataMember = "PBS_Vehicles";
            this.bsPBS_Vehicles.DataSource = this.dsPBS;
            // 
            // taPBS
            // 
            this.taPBS.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PBS_ConfigSchemeTableAdapter = null;
            this.tableAdapterManager.PBS_ConfigTableAdapter = null;
            this.tableAdapterManager.PBS_VehiclesTableAdapter = null;
            this.tableAdapterManager.PBSTableAdapter = this.taPBS;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsPBSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taPBS_Vehicles
            // 
            this.taPBS_Vehicles.ClearBeforeFill = true;
            // 
            // txtPBS_ID
            // 
            this.txtPBS_ID.Location = new System.Drawing.Point(26, 266);
            this.txtPBS_ID.Name = "txtPBS_ID";
            this.txtPBS_ID.Size = new System.Drawing.Size(100, 20);
            this.txtPBS_ID.TabIndex = 5;
            // 
            // PBSVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PBSVehicles";
            this.Text = "PBSVehicles";
            this.Load += new System.EventHandler(this.PBSVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBS_VehiclesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPBS_Vehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsPBS dsPBS;
        private System.Windows.Forms.BindingSource bsPBS;
        private dsPBSTableAdapters.PBSTableAdapter taPBS;
        private dsPBSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleApprovalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtVA;
        private System.Windows.Forms.Button btnFindPBS;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bsPBS_Vehicles;
        private dsPBSTableAdapters.PBS_VehiclesTableAdapter taPBS_Vehicles;
        private System.Windows.Forms.DataGridView pBS_VehiclesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnFindVehicles;
        private System.Windows.Forms.Button btnSaveVehicles;
        private System.Windows.Forms.TextBox txtPBS_ID;
    }
}