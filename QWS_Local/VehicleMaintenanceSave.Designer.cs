
namespace QWS_Local
{
    partial class VehicleMaintenanceSave
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
            this.rbAddTrailer = new System.Windows.Forms.RadioButton();
            this.rbConfigureTruck = new System.Windows.Forms.RadioButton();
            this.rbAddTruck = new System.Windows.Forms.RadioButton();
            this.rbReview = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbAddTrailer
            // 
            this.rbAddTrailer.AutoSize = true;
            this.rbAddTrailer.Location = new System.Drawing.Point(24, 23);
            this.rbAddTrailer.Name = "rbAddTrailer";
            this.rbAddTrailer.Size = new System.Drawing.Size(96, 22);
            this.rbAddTrailer.TabIndex = 0;
            this.rbAddTrailer.Text = "Add Trailer";
            this.rbAddTrailer.UseVisualStyleBackColor = true;
            // 
            // rbConfigureTruck
            // 
            this.rbConfigureTruck.AutoSize = true;
            this.rbConfigureTruck.Location = new System.Drawing.Point(24, 109);
            this.rbConfigureTruck.Name = "rbConfigureTruck";
            this.rbConfigureTruck.Size = new System.Drawing.Size(128, 22);
            this.rbConfigureTruck.TabIndex = 1;
            this.rbConfigureTruck.Text = "Configure GVM";
            this.rbConfigureTruck.UseVisualStyleBackColor = true;
            // 
            // rbAddTruck
            // 
            this.rbAddTruck.AutoSize = true;
            this.rbAddTruck.Location = new System.Drawing.Point(24, 66);
            this.rbAddTruck.Name = "rbAddTruck";
            this.rbAddTruck.Size = new System.Drawing.Size(102, 22);
            this.rbAddTruck.TabIndex = 2;
            this.rbAddTruck.Text = "Add Vehicle";
            this.rbAddTruck.UseVisualStyleBackColor = true;
            // 
            // rbReview
            // 
            this.rbReview.AutoSize = true;
            this.rbReview.Location = new System.Drawing.Point(24, 152);
            this.rbReview.Name = "rbReview";
            this.rbReview.Size = new System.Drawing.Size(57, 22);
            this.rbReview.TabIndex = 3;
            this.rbReview.Text = "View";
            this.rbReview.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClose.Location = new System.Drawing.Point(24, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Confirm and Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VehicleMaintenanceSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 259);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rbReview);
            this.Controls.Add(this.rbAddTruck);
            this.Controls.Add(this.rbConfigureTruck);
            this.Controls.Add(this.rbAddTrailer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleMaintenanceSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Next Action";
            this.Load += new System.EventHandler(this.VehicleMaintenanceSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAddTrailer;
        private System.Windows.Forms.RadioButton rbConfigureTruck;
        private System.Windows.Forms.RadioButton rbAddTruck;
        private System.Windows.Forms.RadioButton rbReview;
        private System.Windows.Forms.Button btnClose;
    }
}