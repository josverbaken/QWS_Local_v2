namespace QWS_Local
{
    partial class ConfirmCustomer
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
            this.btnOkayOnce = new System.Windows.Forms.Button();
            this.btnOkayAlways = new System.Windows.Forms.Button();
            this.btnNotOkay = new System.Windows.Forms.Button();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOkayOnce
            // 
            this.btnOkayOnce.Location = new System.Drawing.Point(37, 269);
            this.btnOkayOnce.Name = "btnOkayOnce";
            this.btnOkayOnce.Size = new System.Drawing.Size(142, 92);
            this.btnOkayOnce.TabIndex = 0;
            this.btnOkayOnce.Text = "OK Once";
            this.btnOkayOnce.UseVisualStyleBackColor = true;
            this.btnOkayOnce.Click += new System.EventHandler(this.btnOkayOnce_Click);
            // 
            // btnOkayAlways
            // 
            this.btnOkayAlways.Location = new System.Drawing.Point(210, 269);
            this.btnOkayAlways.Name = "btnOkayAlways";
            this.btnOkayAlways.Size = new System.Drawing.Size(144, 91);
            this.btnOkayAlways.TabIndex = 1;
            this.btnOkayAlways.Text = "OK Always";
            this.btnOkayAlways.UseVisualStyleBackColor = true;
            this.btnOkayAlways.Click += new System.EventHandler(this.btnOkayAlways_Click);
            // 
            // btnNotOkay
            // 
            this.btnNotOkay.Location = new System.Drawing.Point(374, 269);
            this.btnNotOkay.Name = "btnNotOkay";
            this.btnNotOkay.Size = new System.Drawing.Size(142, 91);
            this.btnNotOkay.TabIndex = 2;
            this.btnNotOkay.Text = "Not Okay";
            this.btnNotOkay.UseVisualStyleBackColor = true;
            this.btnNotOkay.Click += new System.EventHandler(this.btnNotOkay_Click);
            // 
            // txtRego
            // 
            this.txtRego.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRego.Location = new System.Drawing.Point(235, 12);
            this.txtRego.Name = "txtRego";
            this.txtRego.ReadOnly = true;
            this.txtRego.Size = new System.Drawing.Size(100, 35);
            this.txtRego.TabIndex = 3;
            // 
            // ConfirmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txtRego);
            this.Controls.Add(this.btnNotOkay);
            this.Controls.Add(this.btnOkayAlways);
            this.Controls.Add(this.btnOkayOnce);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfirmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmCustomer";
            this.Load += new System.EventHandler(this.ConfirmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkayOnce;
        private System.Windows.Forms.Button btnOkayAlways;
        private System.Windows.Forms.Button btnNotOkay;
        private System.Windows.Forms.TextBox txtRego;
    }
}