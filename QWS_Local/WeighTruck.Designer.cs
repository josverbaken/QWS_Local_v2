namespace QWS_Local
{
    partial class WeighTruck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbWB3 = new System.Windows.Forms.RadioButton();
            this.rbWB2 = new System.Windows.Forms.RadioButton();
            this.rbWB1 = new System.Windows.Forms.RadioButton();
            this.mtxtWeight = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWBInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.Controls.Add(this.rbManual);
            this.groupBox1.Location = new System.Drawing.Point(43, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 71);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weighing Mode";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(128, 34);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(56, 22);
            this.rbAuto.TabIndex = 0;
            this.rbAuto.Text = "Auto";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(248, 34);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(74, 22);
            this.rbManual.TabIndex = 1;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbWB3
            // 
            this.rbWB3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbWB3.AutoSize = true;
            this.rbWB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWB3.Location = new System.Drawing.Point(248, 3);
            this.rbWB3.Name = "rbWB3";
            this.rbWB3.Size = new System.Drawing.Size(60, 34);
            this.rbWB3.TabIndex = 68;
            this.rbWB3.Text = "WB3";
            this.rbWB3.UseVisualStyleBackColor = true;
            this.rbWB3.CheckedChanged += new System.EventHandler(this.WBn_CheckChanged);
            // 
            // rbWB2
            // 
            this.rbWB2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbWB2.AutoSize = true;
            this.rbWB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWB2.Location = new System.Drawing.Point(143, 3);
            this.rbWB2.Name = "rbWB2";
            this.rbWB2.Size = new System.Drawing.Size(60, 34);
            this.rbWB2.TabIndex = 67;
            this.rbWB2.Text = "WB2";
            this.rbWB2.UseVisualStyleBackColor = true;
            this.rbWB2.CheckedChanged += new System.EventHandler(this.WBn_CheckChanged);
            // 
            // rbWB1
            // 
            this.rbWB1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbWB1.AutoSize = true;
            this.rbWB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWB1.Location = new System.Drawing.Point(30, 3);
            this.rbWB1.Name = "rbWB1";
            this.rbWB1.Size = new System.Drawing.Size(60, 34);
            this.rbWB1.TabIndex = 66;
            this.rbWB1.Text = "WB1";
            this.rbWB1.UseVisualStyleBackColor = true;
            this.rbWB1.CheckedChanged += new System.EventHandler(this.WBn_CheckChanged);
            // 
            // mtxtWeight
            // 
            this.mtxtWeight.Location = new System.Drawing.Point(292, 220);
            this.mtxtWeight.Mask = "00.00";
            this.mtxtWeight.Name = "mtxtWeight";
            this.mtxtWeight.ReadOnly = true;
            this.mtxtWeight.Size = new System.Drawing.Size(59, 24);
            this.mtxtWeight.TabIndex = 2;
            this.mtxtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(43, 264);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 49);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(260, 264);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(129, 49);
            this.btnAccept.TabIndex = 61;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(43, 13);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ReadOnly = true;
            this.txtInstruction.Size = new System.Drawing.Size(346, 55);
            this.txtInstruction.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbWB1);
            this.panel1.Controls.Add(this.rbWB2);
            this.panel1.Controls.Add(this.rbWB3);
            this.panel1.Location = new System.Drawing.Point(43, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 39);
            this.panel1.TabIndex = 69;
            // 
            // txtWBInfo
            // 
            this.txtWBInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWBInfo.Location = new System.Drawing.Point(43, 220);
            this.txtWBInfo.Name = "txtWBInfo";
            this.txtWBInfo.ReadOnly = true;
            this.txtWBInfo.Size = new System.Drawing.Size(233, 17);
            this.txtWBInfo.TabIndex = 70;
            // 
            // WeighTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 356);
            this.ControlBox = false;
            this.Controls.Add(this.txtWBInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.mtxtWeight);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeighTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WeighTruck";
            this.Load += new System.EventHandler(this.WeighTruck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtWeight;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.RadioButton rbWB3;
        private System.Windows.Forms.RadioButton rbWB2;
        private System.Windows.Forms.RadioButton rbWB1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWBInfo;
    }
}