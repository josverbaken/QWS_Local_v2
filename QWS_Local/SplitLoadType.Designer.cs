namespace QWS_Local
{
    partial class SplitLoadType
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
            this.gbSplitLoadType = new System.Windows.Forms.GroupBox();
            this.rbTrailerOnly = new System.Windows.Forms.RadioButton();
            this.rbSplitLoad = new System.Windows.Forms.RadioButton();
            this.rbTnT = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.rbTruckOnly = new System.Windows.Forms.RadioButton();
            this.gbSplitLoadType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSplitLoadType
            // 
            this.gbSplitLoadType.Controls.Add(this.rbTruckOnly);
            this.gbSplitLoadType.Controls.Add(this.rbTrailerOnly);
            this.gbSplitLoadType.Controls.Add(this.rbSplitLoad);
            this.gbSplitLoadType.Controls.Add(this.rbTnT);
            this.gbSplitLoadType.Location = new System.Drawing.Point(13, 13);
            this.gbSplitLoadType.Margin = new System.Windows.Forms.Padding(4);
            this.gbSplitLoadType.Name = "gbSplitLoadType";
            this.gbSplitLoadType.Padding = new System.Windows.Forms.Padding(4);
            this.gbSplitLoadType.Size = new System.Drawing.Size(221, 221);
            this.gbSplitLoadType.TabIndex = 81;
            this.gbSplitLoadType.TabStop = false;
            this.gbSplitLoadType.Text = "Load Type";
            // 
            // rbTrailerOnly
            // 
            this.rbTrailerOnly.AutoSize = true;
            this.rbTrailerOnly.Location = new System.Drawing.Point(36, 172);
            this.rbTrailerOnly.Margin = new System.Windows.Forms.Padding(4);
            this.rbTrailerOnly.Name = "rbTrailerOnly";
            this.rbTrailerOnly.Size = new System.Drawing.Size(101, 22);
            this.rbTrailerOnly.TabIndex = 2;
            this.rbTrailerOnly.Text = "Trailer Only";
            this.rbTrailerOnly.UseVisualStyleBackColor = true;
            this.rbTrailerOnly.CheckedChanged += new System.EventHandler(this.rbTrailerOnly_CheckedChanged);
            // 
            // rbSplitLoad
            // 
            this.rbSplitLoad.AutoSize = true;
            this.rbSplitLoad.Location = new System.Drawing.Point(36, 88);
            this.rbSplitLoad.Margin = new System.Windows.Forms.Padding(4);
            this.rbSplitLoad.Name = "rbSplitLoad";
            this.rbSplitLoad.Size = new System.Drawing.Size(91, 22);
            this.rbSplitLoad.TabIndex = 1;
            this.rbSplitLoad.Text = "Split Load";
            this.rbSplitLoad.UseVisualStyleBackColor = true;
            this.rbSplitLoad.CheckedChanged += new System.EventHandler(this.rbSplitLoad_CheckedChanged);
            // 
            // rbTnT
            // 
            this.rbTnT.AutoSize = true;
            this.rbTnT.Checked = true;
            this.rbTnT.Location = new System.Drawing.Point(36, 46);
            this.rbTnT.Margin = new System.Windows.Forms.Padding(4);
            this.rbTnT.Name = "rbTnT";
            this.rbTnT.Size = new System.Drawing.Size(137, 22);
            this.rbTnT.TabIndex = 0;
            this.rbTnT.TabStop = true;
            this.rbTnT.Text = "Truck and Trailer";
            this.rbTnT.UseVisualStyleBackColor = true;
            this.rbTnT.CheckedChanged += new System.EventHandler(this.rbTnT_CheckedChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(13, 251);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(221, 39);
            this.btnSelect.TabIndex = 82;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // rbTruckOnly
            // 
            this.rbTruckOnly.AutoSize = true;
            this.rbTruckOnly.Location = new System.Drawing.Point(36, 130);
            this.rbTruckOnly.Margin = new System.Windows.Forms.Padding(4);
            this.rbTruckOnly.Name = "rbTruckOnly";
            this.rbTruckOnly.Size = new System.Drawing.Size(98, 22);
            this.rbTruckOnly.TabIndex = 3;
            this.rbTruckOnly.Text = "Truck Only";
            this.rbTruckOnly.UseVisualStyleBackColor = true;
            this.rbTruckOnly.CheckedChanged += new System.EventHandler(this.rbTruckOnly_CheckedChanged);
            // 
            // SplitLoadType
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 310);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.gbSplitLoadType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplitLoadType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Split Load Type";
            this.gbSplitLoadType.ResumeLayout(false);
            this.gbSplitLoadType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSplitLoadType;
        private System.Windows.Forms.RadioButton rbTrailerOnly;
        private System.Windows.Forms.RadioButton rbSplitLoad;
        private System.Windows.Forms.RadioButton rbTnT;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RadioButton rbTruckOnly;
    }
}