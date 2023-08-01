namespace PBS
{
    partial class frmPBS_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBSByRegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regoByPBSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axleConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHVRGVMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleRegFeeCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truckConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessPlusPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trucksInQuarryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1718, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMeToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.pBSByRegoToolStripMenuItem,
            this.regoByPBSToolStripMenuItem,
            this.axleConfigurationToolStripMenuItem,
            this.nHVRGVMToolStripMenuItem,
            this.vehicleRegFeeCodesToolStripMenuItem,
            this.truckConfigurationToolStripMenuItem,
            this.businessPlusPersonToolStripMenuItem,
            this.itemSearchToolStripMenuItem,
            this.trucksInQuarryToolStripMenuItem});
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.form1ToolStripMenuItem.Text = "Menu";
            // 
            // showMeToolStripMenuItem
            // 
            this.showMeToolStripMenuItem.Name = "showMeToolStripMenuItem";
            this.showMeToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.showMeToolStripMenuItem.Text = "PBS Maintenance";
            this.showMeToolStripMenuItem.Click += new System.EventHandler(this.showMeToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.showAllToolStripMenuItem.Text = "Vehicle Maintenance";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // pBSByRegoToolStripMenuItem
            // 
            this.pBSByRegoToolStripMenuItem.Name = "pBSByRegoToolStripMenuItem";
            this.pBSByRegoToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.pBSByRegoToolStripMenuItem.Text = "PBS by Rego";
            this.pBSByRegoToolStripMenuItem.Click += new System.EventHandler(this.pBSByRegoToolStripMenuItem_Click);
            // 
            // regoByPBSToolStripMenuItem
            // 
            this.regoByPBSToolStripMenuItem.Name = "regoByPBSToolStripMenuItem";
            this.regoByPBSToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.regoByPBSToolStripMenuItem.Text = "Rego by PBS";
            this.regoByPBSToolStripMenuItem.Click += new System.EventHandler(this.regoByPBSToolStripMenuItem_Click);
            // 
            // axleConfigurationToolStripMenuItem
            // 
            this.axleConfigurationToolStripMenuItem.Name = "axleConfigurationToolStripMenuItem";
            this.axleConfigurationToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.axleConfigurationToolStripMenuItem.Text = "Axle Configuration";
            this.axleConfigurationToolStripMenuItem.Click += new System.EventHandler(this.axleConfigurationToolStripMenuItem_Click);
            // 
            // nHVRGVMToolStripMenuItem
            // 
            this.nHVRGVMToolStripMenuItem.Name = "nHVRGVMToolStripMenuItem";
            this.nHVRGVMToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.nHVRGVMToolStripMenuItem.Text = "NHVR GVM";
            this.nHVRGVMToolStripMenuItem.Click += new System.EventHandler(this.nHVRGVMToolStripMenuItem_Click);
            // 
            // vehicleRegFeeCodesToolStripMenuItem
            // 
            this.vehicleRegFeeCodesToolStripMenuItem.Name = "vehicleRegFeeCodesToolStripMenuItem";
            this.vehicleRegFeeCodesToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.vehicleRegFeeCodesToolStripMenuItem.Text = "Vehicle Reg Fee Codes";
            this.vehicleRegFeeCodesToolStripMenuItem.Click += new System.EventHandler(this.vehicleRegFeeCodesToolStripMenuItem_Click);
            // 
            // truckConfigurationToolStripMenuItem
            // 
            this.truckConfigurationToolStripMenuItem.Name = "truckConfigurationToolStripMenuItem";
            this.truckConfigurationToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.truckConfigurationToolStripMenuItem.Text = "Truck Configuration";
            this.truckConfigurationToolStripMenuItem.Click += new System.EventHandler(this.truckConfigurationToolStripMenuItem_Click);
            // 
            // businessPlusPersonToolStripMenuItem
            // 
            this.businessPlusPersonToolStripMenuItem.Name = "businessPlusPersonToolStripMenuItem";
            this.businessPlusPersonToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.businessPlusPersonToolStripMenuItem.Text = "Business plus Person";
            this.businessPlusPersonToolStripMenuItem.Click += new System.EventHandler(this.businessPlusPersonToolStripMenuItem_Click);
            // 
            // itemSearchToolStripMenuItem
            // 
            this.itemSearchToolStripMenuItem.Name = "itemSearchToolStripMenuItem";
            this.itemSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.itemSearchToolStripMenuItem.Text = "Item Search";
            this.itemSearchToolStripMenuItem.Click += new System.EventHandler(this.itemSearchToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.closeAllToolStripMenuItem.Text = "Close All";
            // 
            // trucksInQuarryToolStripMenuItem
            // 
            this.trucksInQuarryToolStripMenuItem.Name = "trucksInQuarryToolStripMenuItem";
            this.trucksInQuarryToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.trucksInQuarryToolStripMenuItem.Text = "TrucksInQuarry";
            this.trucksInQuarryToolStripMenuItem.Click += new System.EventHandler(this.trucksInQuarryToolStripMenuItem_Click);
            // 
            // frmPBS_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 809);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPBS_MDI";
            this.Text = "QWS PBS Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pBSByRegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regoByPBSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axleConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHVRGVMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleRegFeeCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truckConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessPlusPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trucksInQuarryToolStripMenuItem;
    }
}

