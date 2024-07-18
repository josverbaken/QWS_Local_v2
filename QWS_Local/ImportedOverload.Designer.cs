namespace QWS_Local
{
    partial class ImportedOverload
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOverload = new System.Windows.Forms.TabPage();
            this.tpSanctions = new System.Windows.Forms.TabPage();
            this.tpDockets = new System.Windows.Forms.TabPage();
            this.rtxtSanctions = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tpSanctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpOverload);
            this.tabControl1.Controls.Add(this.tpSanctions);
            this.tabControl1.Controls.Add(this.tpDockets);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tpOverload
            // 
            this.tpOverload.Location = new System.Drawing.Point(4, 27);
            this.tpOverload.Name = "tpOverload";
            this.tpOverload.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverload.Size = new System.Drawing.Size(937, 452);
            this.tpOverload.TabIndex = 0;
            this.tpOverload.Text = "Overload Processing";
            this.tpOverload.UseVisualStyleBackColor = true;
            // 
            // tpSanctions
            // 
            this.tpSanctions.Controls.Add(this.rtxtSanctions);
            this.tpSanctions.Location = new System.Drawing.Point(4, 27);
            this.tpSanctions.Name = "tpSanctions";
            this.tpSanctions.Padding = new System.Windows.Forms.Padding(3);
            this.tpSanctions.Size = new System.Drawing.Size(872, 380);
            this.tpSanctions.TabIndex = 1;
            this.tpSanctions.Text = "Sanctions";
            this.tpSanctions.UseVisualStyleBackColor = true;
            // 
            // tpDockets
            // 
            this.tpDockets.Location = new System.Drawing.Point(4, 27);
            this.tpDockets.Name = "tpDockets";
            this.tpDockets.Size = new System.Drawing.Size(1034, 286);
            this.tpDockets.TabIndex = 2;
            this.tpDockets.Text = "Dockets";
            this.tpDockets.UseVisualStyleBackColor = true;
            // 
            // rtxtSanctions
            // 
            this.rtxtSanctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtSanctions.Location = new System.Drawing.Point(3, 3);
            this.rtxtSanctions.Name = "rtxtSanctions";
            this.rtxtSanctions.Size = new System.Drawing.Size(866, 374);
            this.rtxtSanctions.TabIndex = 0;
            this.rtxtSanctions.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(723, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(153, 58);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Accept";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(7, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 58);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnOK);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Size = new System.Drawing.Size(880, 519);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 3;
            // 
            // ImportedOverload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 519);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportedOverload";
            this.Text = "ImportedOverload";
            this.Load += new System.EventHandler(this.ImportedOverload_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSanctions.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOverload;
        private System.Windows.Forms.TabPage tpSanctions;
        private System.Windows.Forms.RichTextBox rtxtSanctions;
        private System.Windows.Forms.TabPage tpDockets;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}