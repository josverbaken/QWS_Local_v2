﻿namespace QWS_Local
{
    partial class PostDocket
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
            System.Windows.Forms.Label grossLabel;
            System.Windows.Forms.Label tareLabel;
            System.Windows.Forms.Label nettLabel;
            System.Windows.Forms.Label custONLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTruckRego = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.bsTIQ2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.nettTextBox = new System.Windows.Forms.TextBox();
            this.tareTextBox = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStockpileLotNo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.materialDescTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.custONTextBox = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.taTIQ2 = new QWS_Local.dsTIQ2TableAdapters.TIQTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            grossLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            nettLabel = new System.Windows.Forms.Label();
            custONLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grossLabel
            // 
            grossLabel.AutoSize = true;
            grossLabel.Location = new System.Drawing.Point(523, 67);
            grossLabel.Name = "grossLabel";
            grossLabel.Size = new System.Drawing.Size(54, 18);
            grossLabel.TabIndex = 2;
            grossLabel.Text = "Gross:";
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(535, 97);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 18);
            tareLabel.TabIndex = 4;
            tareLabel.Text = "Tare:";
            // 
            // nettLabel
            // 
            nettLabel.AutoSize = true;
            nettLabel.Location = new System.Drawing.Point(538, 127);
            nettLabel.Name = "nettLabel";
            nettLabel.Size = new System.Drawing.Size(39, 18);
            nettLabel.TabIndex = 6;
            nettLabel.Text = "Nett:";
            // 
            // custONLabel
            // 
            custONLabel.AutoSize = true;
            custONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            custONLabel.Location = new System.Drawing.Point(43, 120);
            custONLabel.Name = "custONLabel";
            custONLabel.Size = new System.Drawing.Size(86, 24);
            custONLabel.TabIndex = 0;
            custONLabel.Text = "Cust ON:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTruckRego);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.regoTextBox);
            this.groupBox1.Controls.Add(nettLabel);
            this.groupBox1.Controls.Add(this.nettTextBox);
            this.groupBox1.Controls.Add(tareLabel);
            this.groupBox1.Controls.Add(this.tareTextBox);
            this.groupBox1.Controls.Add(grossLabel);
            this.groupBox1.Controls.Add(this.txtGross);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1) Check Truck Details";
            // 
            // chkTruckRego
            // 
            this.chkTruckRego.AutoSize = true;
            this.chkTruckRego.Location = new System.Drawing.Point(526, 196);
            this.chkTruckRego.Name = "chkTruckRego";
            this.chkTruckRego.Size = new System.Drawing.Size(119, 22);
            this.chkTruckRego.TabIndex = 11;
            this.chkTruckRego.Text = "Truck confirm";
            this.chkTruckRego.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 10;
            // 
            // regoTextBox
            // 
            this.regoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Rego", true));
            this.regoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regoTextBox.Location = new System.Drawing.Point(25, 29);
            this.regoTextBox.Name = "regoTextBox";
            this.regoTextBox.ReadOnly = true;
            this.regoTextBox.Size = new System.Drawing.Size(133, 29);
            this.regoTextBox.TabIndex = 9;
            // 
            // bsTIQ2
            // 
            this.bsTIQ2.DataMember = "TIQ";
            this.bsTIQ2.DataSource = this.dsTIQ2;
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nettTextBox
            // 
            this.nettTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Nett", true));
            this.nettTextBox.Location = new System.Drawing.Point(583, 124);
            this.nettTextBox.Name = "nettTextBox";
            this.nettTextBox.ReadOnly = true;
            this.nettTextBox.Size = new System.Drawing.Size(100, 24);
            this.nettTextBox.TabIndex = 7;
            // 
            // tareTextBox
            // 
            this.tareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Tare", true));
            this.tareTextBox.Location = new System.Drawing.Point(583, 94);
            this.tareTextBox.Name = "tareTextBox";
            this.tareTextBox.ReadOnly = true;
            this.tareTextBox.Size = new System.Drawing.Size(100, 24);
            this.tareTextBox.TabIndex = 5;
            // 
            // txtGross
            // 
            this.txtGross.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Gross", true));
            this.txtGross.Location = new System.Drawing.Point(583, 64);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(100, 24);
            this.txtGross.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2) Check Customer";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Customer", true));
            this.customerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(25, 48);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(450, 29);
            this.customerTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStockpileLotNo);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.materialDescTextBox);
            this.groupBox3.Controls.Add(this.materialTextBox);
            this.groupBox3.Controls.Add(custONLabel);
            this.groupBox3.Controls.Add(this.custONTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3) Check Material and PO#";
            // 
            // txtStockpileLotNo
            // 
            this.txtStockpileLotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockpileLotNo.Location = new System.Drawing.Point(526, 86);
            this.txtStockpileLotNo.Name = "txtStockpileLotNo";
            this.txtStockpileLotNo.Size = new System.Drawing.Size(157, 29);
            this.txtStockpileLotNo.TabIndex = 12;
            this.txtStockpileLotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockpileLotNo.Validated += new System.EventHandler(this.txtStockpileLotNo_Validated);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(526, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Stockpile Lot No";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialDescTextBox
            // 
            this.materialDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "MaterialDesc", true));
            this.materialDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialDescTextBox.Location = new System.Drawing.Point(135, 82);
            this.materialDescTextBox.Name = "materialDescTextBox";
            this.materialDescTextBox.Size = new System.Drawing.Size(234, 29);
            this.materialDescTextBox.TabIndex = 5;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Material", true));
            this.materialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTextBox.Location = new System.Drawing.Point(375, 82);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(100, 29);
            this.materialTextBox.TabIndex = 3;
            // 
            // custONTextBox
            // 
            this.custONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "CustON", true));
            this.custONTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custONTextBox.Location = new System.Drawing.Point(135, 117);
            this.custONTextBox.Name = "custONTextBox";
            this.custONTextBox.Size = new System.Drawing.Size(100, 29);
            this.custONTextBox.TabIndex = 1;
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Location = new System.Drawing.Point(685, 740);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(114, 49);
            this.btnOkay.TabIndex = 63;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 740);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 49);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // taTIQ2
            // 
            this.taTIQ2.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TIQTableAdapter = this.taTIQ2;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = null;
            // 
            // PostDocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 815);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostDocket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PostDocket";
            this.Load += new System.EventHandler(this.PostDocket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsTIQ2;
        private dsTIQ2TableAdapters.TIQTableAdapter taTIQ2;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox regoTextBox;
        private System.Windows.Forms.TextBox nettTextBox;
        private System.Windows.Forms.TextBox tareTextBox;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.CheckBox chkTruckRego;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox txtStockpileLotNo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox materialDescTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox custONTextBox;
    }
}