namespace QWS_Local
{
    partial class QWSLogin
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
            this.gbSite = new System.Windows.Forms.GroupBox();
            this.rbSQ = new System.Windows.Forms.RadioButton();
            this.rbNQ = new System.Windows.Forms.RadioButton();
            this.gbEnvironment = new System.Windows.Forms.GroupBox();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.rbProd = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.gbSite.SuspendLayout();
            this.gbEnvironment.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSite
            // 
            this.gbSite.Controls.Add(this.rbClear);
            this.gbSite.Controls.Add(this.rbSQ);
            this.gbSite.Controls.Add(this.rbNQ);
            this.gbSite.Location = new System.Drawing.Point(138, 39);
            this.gbSite.Margin = new System.Windows.Forms.Padding(4);
            this.gbSite.Name = "gbSite";
            this.gbSite.Padding = new System.Windows.Forms.Padding(4);
            this.gbSite.Size = new System.Drawing.Size(300, 148);
            this.gbSite.TabIndex = 0;
            this.gbSite.TabStop = false;
            this.gbSite.Text = "Site";
            // 
            // rbSQ
            // 
            this.rbSQ.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSQ.AutoSize = true;
            this.rbSQ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbSQ.Location = new System.Drawing.Point(30, 68);
            this.rbSQ.Margin = new System.Windows.Forms.Padding(4);
            this.rbSQ.MinimumSize = new System.Drawing.Size(200, 0);
            this.rbSQ.Name = "rbSQ";
            this.rbSQ.Size = new System.Drawing.Size(200, 28);
            this.rbSQ.TabIndex = 1;
            this.rbSQ.TabStop = true;
            this.rbSQ.Text = "Stawell Quarry - Site 2";
            this.rbSQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSQ.UseVisualStyleBackColor = true;
            this.rbSQ.CheckedChanged += new System.EventHandler(this.rbSQ_CheckedChanged);
            // 
            // rbNQ
            // 
            this.rbNQ.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNQ.AutoSize = true;
            this.rbNQ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbNQ.Location = new System.Drawing.Point(30, 28);
            this.rbNQ.Margin = new System.Windows.Forms.Padding(4);
            this.rbNQ.MinimumSize = new System.Drawing.Size(200, 0);
            this.rbNQ.Name = "rbNQ";
            this.rbNQ.Size = new System.Drawing.Size(200, 28);
            this.rbNQ.TabIndex = 0;
            this.rbNQ.TabStop = true;
            this.rbNQ.Text = "Northern Quarries - Site 7";
            this.rbNQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNQ.UseVisualStyleBackColor = true;
            this.rbNQ.CheckedChanged += new System.EventHandler(this.rbNQ_CheckedChanged);
            // 
            // gbEnvironment
            // 
            this.gbEnvironment.Controls.Add(this.rbTest);
            this.gbEnvironment.Controls.Add(this.rbProd);
            this.gbEnvironment.Location = new System.Drawing.Point(138, 205);
            this.gbEnvironment.Margin = new System.Windows.Forms.Padding(4);
            this.gbEnvironment.Name = "gbEnvironment";
            this.gbEnvironment.Padding = new System.Windows.Forms.Padding(4);
            this.gbEnvironment.Size = new System.Drawing.Size(300, 138);
            this.gbEnvironment.TabIndex = 1;
            this.gbEnvironment.TabStop = false;
            this.gbEnvironment.Text = "Environment";
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Location = new System.Drawing.Point(30, 76);
            this.rbTest.Margin = new System.Windows.Forms.Padding(4);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(55, 22);
            this.rbTest.TabIndex = 1;
            this.rbTest.TabStop = true;
            this.rbTest.Text = "Test";
            this.rbTest.UseVisualStyleBackColor = true;
            // 
            // rbProd
            // 
            this.rbProd.AutoSize = true;
            this.rbProd.Location = new System.Drawing.Point(30, 28);
            this.rbProd.Margin = new System.Windows.Forms.Padding(4);
            this.rbProd.Name = "rbProd";
            this.rbProd.Size = new System.Drawing.Size(52, 22);
            this.rbProd.TabIndex = 0;
            this.rbProd.TabStop = true;
            this.rbProd.Text = "Live";
            this.rbProd.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(138, 353);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(30, 109);
            this.rbClear.Margin = new System.Windows.Forms.Padding(4);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(61, 22);
            this.rbClear.TabIndex = 2;
            this.rbClear.TabStop = true;
            this.rbClear.Text = "Clear";
            this.rbClear.UseVisualStyleBackColor = true;
            this.rbClear.CheckedChanged += new System.EventHandler(this.rbClear_CheckedChanged);
            // 
            // QWSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 457);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gbEnvironment);
            this.Controls.Add(this.gbSite);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QWSLogin";
            this.Text = "Login to QWS";
            this.Load += new System.EventHandler(this.QWSLogin_Load);
            this.gbSite.ResumeLayout(false);
            this.gbSite.PerformLayout();
            this.gbEnvironment.ResumeLayout(false);
            this.gbEnvironment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSite;
        private System.Windows.Forms.RadioButton rbSQ;
        private System.Windows.Forms.RadioButton rbNQ;
        private System.Windows.Forms.GroupBox gbEnvironment;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.RadioButton rbProd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rbClear;
    }
}