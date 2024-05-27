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
            this.txtTruckConfig = new System.Windows.Forms.TextBox();
            this.rbTrailerOnly = new System.Windows.Forms.RadioButton();
            this.rbSplitLoad = new System.Windows.Forms.RadioButton();
            this.rbTnT = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbSplitLoadType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSplitLoadType
            // 
            this.gbSplitLoadType.Controls.Add(this.txtTruckConfig);
            this.gbSplitLoadType.Controls.Add(this.rbTrailerOnly);
            this.gbSplitLoadType.Controls.Add(this.rbSplitLoad);
            this.gbSplitLoadType.Controls.Add(this.rbTnT);
            this.gbSplitLoadType.Location = new System.Drawing.Point(13, 13);
            this.gbSplitLoadType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSplitLoadType.Name = "gbSplitLoadType";
            this.gbSplitLoadType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSplitLoadType.Size = new System.Drawing.Size(282, 277);
            this.gbSplitLoadType.TabIndex = 81;
            this.gbSplitLoadType.TabStop = false;
            this.gbSplitLoadType.Text = "Load Type";
            // 
            // txtTruckConfig
            // 
            this.txtTruckConfig.Location = new System.Drawing.Point(36, 205);
            this.txtTruckConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTruckConfig.Name = "txtTruckConfig";
            this.txtTruckConfig.ReadOnly = true;
            this.txtTruckConfig.Size = new System.Drawing.Size(148, 24);
            this.txtTruckConfig.TabIndex = 3;
            // 
            // rbTrailerOnly
            // 
            this.rbTrailerOnly.AutoSize = true;
            this.rbTrailerOnly.Location = new System.Drawing.Point(36, 154);
            this.rbTrailerOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTrailerOnly.Name = "rbTrailerOnly";
            this.rbTrailerOnly.Size = new System.Drawing.Size(101, 22);
            this.rbTrailerOnly.TabIndex = 2;
            this.rbTrailerOnly.TabStop = true;
            this.rbTrailerOnly.Text = "Trailer Only";
            this.rbTrailerOnly.UseVisualStyleBackColor = true;
            this.rbTrailerOnly.CheckedChanged += new System.EventHandler(this.rbTrailerOnly_CheckedChanged);
            // 
            // rbSplitLoad
            // 
            this.rbSplitLoad.AutoSize = true;
            this.rbSplitLoad.Location = new System.Drawing.Point(36, 111);
            this.rbSplitLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSplitLoad.Name = "rbSplitLoad";
            this.rbSplitLoad.Size = new System.Drawing.Size(91, 22);
            this.rbSplitLoad.TabIndex = 1;
            this.rbSplitLoad.TabStop = true;
            this.rbSplitLoad.Text = "Split Load";
            this.rbSplitLoad.UseVisualStyleBackColor = true;
            this.rbSplitLoad.CheckedChanged += new System.EventHandler(this.rbSplitLoad_CheckedChanged);
            // 
            // rbTnT
            // 
            this.rbTnT.AutoSize = true;
            this.rbTnT.Location = new System.Drawing.Point(36, 65);
            this.rbTnT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnSelect.Location = new System.Drawing.Point(13, 297);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(184, 39);
            this.btnSelect.TabIndex = 82;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SplitLoadType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 359);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.gbSplitLoadType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SplitLoadType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Split Load Type";
            this.gbSplitLoadType.ResumeLayout(false);
            this.gbSplitLoadType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSplitLoadType;
        private System.Windows.Forms.TextBox txtTruckConfig;
        private System.Windows.Forms.RadioButton rbTrailerOnly;
        private System.Windows.Forms.RadioButton rbSplitLoad;
        private System.Windows.Forms.RadioButton rbTnT;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}