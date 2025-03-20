namespace QWS_Local
{
    partial class SelectSite
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
            this.rbNQ = new System.Windows.Forms.RadioButton();
            this.rbSQ = new System.Windows.Forms.RadioButton();
            this.btnSetSite = new System.Windows.Forms.Button();
            this.rbDummy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbNQ
            // 
            this.rbNQ.AutoSize = true;
            this.rbNQ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbNQ.Location = new System.Drawing.Point(82, 12);
            this.rbNQ.MinimumSize = new System.Drawing.Size(150, 40);
            this.rbNQ.Name = "rbNQ";
            this.rbNQ.Size = new System.Drawing.Size(150, 40);
            this.rbNQ.TabIndex = 0;
            this.rbNQ.TabStop = true;
            this.rbNQ.Text = "Northern Quarries";
            this.rbNQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNQ.UseVisualStyleBackColor = false;
            // 
            // rbSQ
            // 
            this.rbSQ.AutoSize = true;
            this.rbSQ.BackColor = System.Drawing.Color.LightGreen;
            this.rbSQ.Location = new System.Drawing.Point(82, 58);
            this.rbSQ.MinimumSize = new System.Drawing.Size(150, 40);
            this.rbSQ.Name = "rbSQ";
            this.rbSQ.Size = new System.Drawing.Size(150, 40);
            this.rbSQ.TabIndex = 1;
            this.rbSQ.Text = "Stawell Quarry";
            this.rbSQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSQ.UseVisualStyleBackColor = false;
            // 
            // btnSetSite
            // 
            this.btnSetSite.Location = new System.Drawing.Point(82, 104);
            this.btnSetSite.Name = "btnSetSite";
            this.btnSetSite.Size = new System.Drawing.Size(150, 40);
            this.btnSetSite.TabIndex = 2;
            this.btnSetSite.Text = "Set";
            this.btnSetSite.UseVisualStyleBackColor = true;
            this.btnSetSite.Click += new System.EventHandler(this.btnSetSite_Click);
            // 
            // rbDummy
            // 
            this.rbDummy.AutoSize = true;
            this.rbDummy.BackColor = System.Drawing.SystemColors.Control;
            this.rbDummy.Location = new System.Drawing.Point(22, 104);
            this.rbDummy.MinimumSize = new System.Drawing.Size(150, 40);
            this.rbDummy.Name = "rbDummy";
            this.rbDummy.Size = new System.Drawing.Size(150, 40);
            this.rbDummy.TabIndex = 3;
            this.rbDummy.Text = "unselected";
            this.rbDummy.UseVisualStyleBackColor = false;
            this.rbDummy.Visible = false;
            // 
            // SelectSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 165);
            this.Controls.Add(this.btnSetSite);
            this.Controls.Add(this.rbDummy);
            this.Controls.Add(this.rbSQ);
            this.Controls.Add(this.rbNQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "SelectSite";
            this.Text = "SelectSite";
            this.Load += new System.EventHandler(this.SelectSite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNQ;
        private System.Windows.Forms.RadioButton rbSQ;
        private System.Windows.Forms.Button btnSetSite;
        private System.Windows.Forms.RadioButton rbDummy;
    }
}