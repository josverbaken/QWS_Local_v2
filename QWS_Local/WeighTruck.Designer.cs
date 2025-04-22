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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbWB3 = new System.Windows.Forms.RadioButton();
            this.rbWB2 = new System.Windows.Forms.RadioButton();
            this.rbWB1 = new System.Windows.Forms.RadioButton();
            this.mtxtWeight = new System.Windows.Forms.MaskedTextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.bsWBConfig4Site = new System.Windows.Forms.BindingSource(this.components);
            this.taWBConfig4Site = new QWS_Local.dsTIQ2TableAdapters.WBConfig4SiteTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBConfig4Site)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.Controls.Add(this.rbManual);
            this.groupBox1.Location = new System.Drawing.Point(21, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 59);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weighing Mode";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(128, 27);
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
            this.rbManual.Location = new System.Drawing.Point(248, 27);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(74, 22);
            this.rbManual.TabIndex = 1;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // rbWB3
            // 
            this.rbWB3.AutoSize = true;
            this.rbWB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWB3.Location = new System.Drawing.Point(247, 31);
            this.rbWB3.Name = "rbWB3";
            this.rbWB3.Size = new System.Drawing.Size(68, 28);
            this.rbWB3.TabIndex = 68;
            this.rbWB3.Text = "WB3";
            this.rbWB3.UseVisualStyleBackColor = true;
            this.rbWB3.CheckedChanged += new System.EventHandler(this.WBn_CheckChanged);
            // 
            // rbWB2
            // 
            this.rbWB2.AutoSize = true;
            this.rbWB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWB2.Location = new System.Drawing.Point(141, 31);
            this.rbWB2.Name = "rbWB2";
            this.rbWB2.Size = new System.Drawing.Size(68, 28);
            this.rbWB2.TabIndex = 67;
            this.rbWB2.Text = "WB2";
            this.rbWB2.UseVisualStyleBackColor = true;
            this.rbWB2.CheckedChanged += new System.EventHandler(this.WBn_CheckChanged);
            // 
            // rbWB1
            // 
            this.rbWB1.AutoSize = true;
            this.rbWB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWB1.Location = new System.Drawing.Point(35, 31);
            this.rbWB1.Name = "rbWB1";
            this.rbWB1.Size = new System.Drawing.Size(68, 28);
            this.rbWB1.TabIndex = 66;
            this.rbWB1.Text = "WB1";
            this.rbWB1.UseVisualStyleBackColor = true;
            this.rbWB1.CheckedChanged += new System.EventHandler(this.WBn_CheckChanged);
            // 
            // mtxtWeight
            // 
            this.mtxtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtWeight.Location = new System.Drawing.Point(267, 89);
            this.mtxtWeight.Mask = "00.00";
            this.mtxtWeight.Name = "mtxtWeight";
            this.mtxtWeight.ReadOnly = true;
            this.mtxtWeight.Size = new System.Drawing.Size(73, 29);
            this.mtxtWeight.TabIndex = 2;
            this.mtxtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(7, 132);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(332, 44);
            this.btnAccept.TabIndex = 61;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(6, 23);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ReadOnly = true;
            this.txtInstruction.Size = new System.Drawing.Size(333, 55);
            this.txtInstruction.TabIndex = 62;
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Location = new System.Drawing.Point(7, 85);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(101, 39);
            this.btnCapture.TabIndex = 71;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor.Location = new System.Drawing.Point(128, 85);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(105, 38);
            this.btnMonitor.TabIndex = 72;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Visible = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapture);
            this.groupBox2.Controls.Add(this.mtxtWeight);
            this.groupBox2.Controls.Add(this.txtInstruction);
            this.groupBox2.Controls.Add(this.btnMonitor);
            this.groupBox2.Controls.Add(this.btnAccept);
            this.groupBox2.Location = new System.Drawing.Point(21, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 194);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capture Weight";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbWB3);
            this.groupBox3.Controls.Add(this.rbWB2);
            this.groupBox3.Controls.Add(this.rbWB1);
            this.groupBox3.Location = new System.Drawing.Point(21, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 81);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weighbridge Selection";
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsWBConfig4Site
            // 
            this.bsWBConfig4Site.DataMember = "WBConfig4Site";
            this.bsWBConfig4Site.DataSource = this.dsTIQ2;
            // 
            // taWBConfig4Site
            // 
            this.taWBConfig4Site.ClearBeforeFill = true;
            // 
            // WeighTruck
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeighTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WeighTruck";
            this.Load += new System.EventHandler(this.WeighTruck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBConfig4Site)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtWeight;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.RadioButton rbWB3;
        private System.Windows.Forms.RadioButton rbWB2;
        private System.Windows.Forms.RadioButton rbWB1;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsWBConfig4Site;
        private dsTIQ2TableAdapters.WBConfig4SiteTableAdapter taWBConfig4Site;
    }
}