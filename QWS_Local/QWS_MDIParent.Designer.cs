﻿namespace QWS_Local
{
    partial class QWS_MDIParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axleConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feeCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHVRGVMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemMaintainVehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trucktrailerConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemQuality = new System.Windows.Forms.ToolStripMenuItem();
            this.lotNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryOrdersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tspSite = new System.Windows.Forms.ToolStripTextBox();
            this.tspUserName = new System.Windows.Forms.ToolStripTextBox();
            this.tspSignInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.dsAdmin = new QWS_Local.dsAdmin();
            this.bsOperator = new System.Windows.Forms.BindingSource(this.components);
            this.taOperator = new QWS_Local.dsAdminTableAdapters.OperatorTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsAdminTableAdapters.TableAdapterManager();
            this.pBSVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperator)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHome,
            this.menuitemMenu,
            this.windowsToolStripMenuItem,
            this.helloToolStripMenuItem,
            this.toolStripTextBox1,
            this.tspSite,
            this.tspUserName,
            this.tspSignInOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1884, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemHome
            // 
            this.menuItemHome.Name = "menuItemHome";
            this.menuItemHome.Size = new System.Drawing.Size(62, 27);
            this.menuItemHome.Text = "&Home";
            this.menuItemHome.Click += new System.EventHandler(this.tIQToolStripMenuItem_Click);
            // 
            // menuitemMenu
            // 
            this.menuitemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.menuitemMaintainVehicles,
            this.menuitemQuality,
            this.salesToolStripMenuItem});
            this.menuitemMenu.Name = "menuitemMenu";
            this.menuitemMenu.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuitemMenu.Size = new System.Drawing.Size(58, 27);
            this.menuitemMenu.Text = "&Menu";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.axleConfigurationToolStripMenuItem1,
            this.feeCodesToolStripMenuItem,
            this.nHVRGVMToolStripMenuItem,
            this.operatorRolesToolStripMenuItem,
            this.sMSToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // axleConfigurationToolStripMenuItem1
            // 
            this.axleConfigurationToolStripMenuItem1.Name = "axleConfigurationToolStripMenuItem1";
            this.axleConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.axleConfigurationToolStripMenuItem1.Text = "Axle Configuration";
            this.axleConfigurationToolStripMenuItem1.Click += new System.EventHandler(this.axleConfigurationToolStripMenuItem1_Click);
            // 
            // feeCodesToolStripMenuItem
            // 
            this.feeCodesToolStripMenuItem.Name = "feeCodesToolStripMenuItem";
            this.feeCodesToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.feeCodesToolStripMenuItem.Text = "Fee Codes";
            this.feeCodesToolStripMenuItem.Click += new System.EventHandler(this.feeCodesToolStripMenuItem_Click);
            // 
            // nHVRGVMToolStripMenuItem
            // 
            this.nHVRGVMToolStripMenuItem.Name = "nHVRGVMToolStripMenuItem";
            this.nHVRGVMToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.nHVRGVMToolStripMenuItem.Text = "NHVR GVM";
            this.nHVRGVMToolStripMenuItem.Click += new System.EventHandler(this.nHVRGVMToolStripMenuItem_Click_1);
            // 
            // operatorRolesToolStripMenuItem
            // 
            this.operatorRolesToolStripMenuItem.Name = "operatorRolesToolStripMenuItem";
            this.operatorRolesToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.operatorRolesToolStripMenuItem.Text = "Operator Roles";
            this.operatorRolesToolStripMenuItem.Click += new System.EventHandler(this.operatorRolesToolStripMenuItem_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.sMSToolStripMenuItem.Text = "SMS";
            this.sMSToolStripMenuItem.Click += new System.EventHandler(this.sMSToolStripMenuItem_Click_1);
            // 
            // menuitemMaintainVehicles
            // 
            this.menuitemMaintainVehicles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclesToolStripMenuItem,
            this.pBSToolStripMenuItem,
            this.trucktrailerConfigToolStripMenuItem,
            this.pBSVehiclesToolStripMenuItem});
            this.menuitemMaintainVehicles.Name = "menuitemMaintainVehicles";
            this.menuitemMaintainVehicles.Size = new System.Drawing.Size(180, 24);
            this.menuitemMaintainVehicles.Text = "Maintain";
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // pBSToolStripMenuItem
            // 
            this.pBSToolStripMenuItem.Name = "pBSToolStripMenuItem";
            this.pBSToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.pBSToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.pBSToolStripMenuItem.Text = "PBS";
            this.pBSToolStripMenuItem.Click += new System.EventHandler(this.pBSToolStripMenuItem_Click);
            // 
            // trucktrailerConfigToolStripMenuItem
            // 
            this.trucktrailerConfigToolStripMenuItem.Name = "trucktrailerConfigToolStripMenuItem";
            this.trucktrailerConfigToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.trucktrailerConfigToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.trucktrailerConfigToolStripMenuItem.Text = "Truck/trailer Config";
            this.trucktrailerConfigToolStripMenuItem.Click += new System.EventHandler(this.trucktrailerConfigToolStripMenuItem_Click);
            // 
            // menuitemQuality
            // 
            this.menuitemQuality.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotNumbersToolStripMenuItem});
            this.menuitemQuality.Name = "menuitemQuality";
            this.menuitemQuality.Size = new System.Drawing.Size(180, 24);
            this.menuitemQuality.Text = "Quality";
            // 
            // lotNumbersToolStripMenuItem
            // 
            this.lotNumbersToolStripMenuItem.Name = "lotNumbersToolStripMenuItem";
            this.lotNumbersToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.lotNumbersToolStripMenuItem.Text = "Lot Numbers";
            this.lotNumbersToolStripMenuItem.Click += new System.EventHandler(this.lotNumbersToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveryOrdersToolStripMenuItem1});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // deliveryOrdersToolStripMenuItem1
            // 
            this.deliveryOrdersToolStripMenuItem1.Name = "deliveryOrdersToolStripMenuItem1";
            this.deliveryOrdersToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.deliveryOrdersToolStripMenuItem1.Text = "Orders";
            this.deliveryOrdersToolStripMenuItem1.Click += new System.EventHandler(this.deliveryOrdersToolStripMenuItem1_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.helloToolStripMenuItem.Text = "H&elp";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            this.onlineHelpToolStripMenuItem.Visible = false;
            this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // tspSite
            // 
            this.tspSite.BackColor = System.Drawing.SystemColors.Control;
            this.tspSite.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tspSite.Name = "tspSite";
            this.tspSite.Size = new System.Drawing.Size(250, 27);
            this.tspSite.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tspUserName
            // 
            this.tspUserName.BackColor = System.Drawing.SystemColors.Control;
            this.tspUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tspUserName.Name = "tspUserName";
            this.tspUserName.Size = new System.Drawing.Size(250, 27);
            // 
            // tspSignInOut
            // 
            this.tspSignInOut.Name = "tspSignInOut";
            this.tspSignInOut.Size = new System.Drawing.Size(104, 27);
            this.tspSignInOut.Text = "Sign In / Out";
            this.tspSignInOut.Click += new System.EventHandler(this.tspSignInOut_Click);
            // 
            // dsAdmin
            // 
            this.dsAdmin.DataSetName = "dsAdmin";
            this.dsAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsOperator
            // 
            this.bsOperator.DataMember = "Operator";
            this.bsOperator.DataSource = this.dsAdmin;
            // 
            // taOperator
            // 
            this.taOperator.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FunctionsTableAdapter = null;
            this.tableAdapterManager.OperatorRolesTableAdapter = null;
            this.tableAdapterManager.OperatorTableAdapter = this.taOperator;
            this.tableAdapterManager.RoleFunctionsTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsAdminTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pBSVehiclesToolStripMenuItem
            // 
            this.pBSVehiclesToolStripMenuItem.Name = "pBSVehiclesToolStripMenuItem";
            this.pBSVehiclesToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.pBSVehiclesToolStripMenuItem.Text = "PBSVehicles";
            this.pBSVehiclesToolStripMenuItem.Click += new System.EventHandler(this.pBSVehiclesToolStripMenuItem_Click);
            // 
            // QWS_MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 661);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QWS_MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarry Weighbridge System (QWS)";
            this.Load += new System.EventHandler(this.QWS_MDIParent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QWS_MDIParent_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuitemMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemHome;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axleConfigurationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem feeCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHVRGVMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemMaintainVehicles;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pBSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trucktrailerConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemQuality;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryOrdersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operatorRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tspUserName;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox tspSite;
        private System.Windows.Forms.ToolStripMenuItem tspSignInOut;
        private dsAdmin dsAdmin;
        private System.Windows.Forms.BindingSource bsOperator;
        private dsAdminTableAdapters.OperatorTableAdapter taOperator;
        private dsAdminTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pBSVehiclesToolStripMenuItem;
    }
}