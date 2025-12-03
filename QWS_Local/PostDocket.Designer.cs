namespace QWS_Local
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
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnderload = new System.Windows.Forms.TextBox();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.bsTIQ2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.regoTextBox = new System.Windows.Forms.TextBox();
            this.txtNett = new System.Windows.Forms.TextBox();
            this.txtTare = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.materialDescTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.custONTextBox = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bsSPLotNo = new System.Windows.Forms.BindingSource(this.components);
            this.taTIQ2 = new QWS_Local.dsTIQ2TableAdapters.TIQTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.taSPLotNo = new QWS_Local.dsTIQ2TableAdapters.SPLotNoAssignTableAdapter();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.taCustomer = new QWS_Local.dsTIQ2TableAdapters.BusinessGetByCodeTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            grossLabel = new System.Windows.Forms.Label();
            tareLabel = new System.Windows.Forms.Label();
            nettLabel = new System.Windows.Forms.Label();
            custONLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grossLabel
            // 
            grossLabel.AutoSize = true;
            grossLabel.Location = new System.Drawing.Point(318, 37);
            grossLabel.Name = "grossLabel";
            grossLabel.Size = new System.Drawing.Size(54, 18);
            grossLabel.TabIndex = 2;
            grossLabel.Text = "Gross:";
            // 
            // tareLabel
            // 
            tareLabel.AutoSize = true;
            tareLabel.Location = new System.Drawing.Point(330, 67);
            tareLabel.Name = "tareLabel";
            tareLabel.Size = new System.Drawing.Size(42, 18);
            tareLabel.TabIndex = 4;
            tareLabel.Text = "Tare:";
            // 
            // nettLabel
            // 
            nettLabel.AutoSize = true;
            nettLabel.Location = new System.Drawing.Point(333, 97);
            nettLabel.Name = "nettLabel";
            nettLabel.Size = new System.Drawing.Size(39, 18);
            nettLabel.TabIndex = 6;
            nettLabel.Text = "Nett:";
            // 
            // custONLabel
            // 
            custONLabel.AutoSize = true;
            custONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            custONLabel.Location = new System.Drawing.Point(286, 117);
            custONLabel.Name = "custONLabel";
            custONLabel.Size = new System.Drawing.Size(86, 24);
            custONLabel.TabIndex = 0;
            custONLabel.Text = "Cust ON:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(307, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 18);
            label1.TabIndex = 11;
            label1.Text = "Payload:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnderload);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtPayload);
            this.groupBox1.Controls.Add(this.regoTextBox);
            this.groupBox1.Controls.Add(nettLabel);
            this.groupBox1.Controls.Add(this.txtNett);
            this.groupBox1.Controls.Add(tareLabel);
            this.groupBox1.Controls.Add(this.txtTare);
            this.groupBox1.Controls.Add(grossLabel);
            this.groupBox1.Controls.Add(this.txtGross);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1) Check Truck Details";
            // 
            // txtUnderload
            // 
            this.txtUnderload.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnderload.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnderload.Location = new System.Drawing.Point(25, 127);
            this.txtUnderload.Name = "txtUnderload";
            this.txtUnderload.ReadOnly = true;
            this.txtUnderload.Size = new System.Drawing.Size(276, 17);
            this.txtUnderload.TabIndex = 12;
            this.txtUnderload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPayload
            // 
            this.txtPayload.BackColor = System.Drawing.SystemColors.Control;
            this.txtPayload.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Payload", true));
            this.txtPayload.Location = new System.Drawing.Point(378, 124);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.ReadOnly = true;
            this.txtPayload.Size = new System.Drawing.Size(100, 24);
            this.txtPayload.TabIndex = 10;
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
            // txtNett
            // 
            this.txtNett.BackColor = System.Drawing.SystemColors.Control;
            this.txtNett.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Nett", true));
            this.txtNett.Location = new System.Drawing.Point(378, 94);
            this.txtNett.Name = "txtNett";
            this.txtNett.ReadOnly = true;
            this.txtNett.Size = new System.Drawing.Size(100, 24);
            this.txtNett.TabIndex = 7;
            // 
            // txtTare
            // 
            this.txtTare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Tare", true));
            this.txtTare.Location = new System.Drawing.Point(378, 64);
            this.txtTare.Name = "txtTare";
            this.txtTare.ReadOnly = true;
            this.txtTare.Size = new System.Drawing.Size(100, 24);
            this.txtTare.TabIndex = 5;
            // 
            // txtGross
            // 
            this.txtGross.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Gross", true));
            this.txtGross.Location = new System.Drawing.Point(378, 34);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(100, 24);
            this.txtGross.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCOD);
            this.groupBox2.Controls.Add(this.customerTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2) Check Customer";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // txtCOD
            // 
            this.txtCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOD.ForeColor = System.Drawing.Color.Tomato;
            this.txtCOD.Location = new System.Drawing.Point(25, 75);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.ReadOnly = true;
            this.txtCOD.Size = new System.Drawing.Size(453, 29);
            this.txtCOD.TabIndex = 2;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Customer", true));
            this.customerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(25, 36);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(453, 29);
            this.customerTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInfo);
            this.groupBox3.Controls.Add(this.materialDescTextBox);
            this.groupBox3.Controls.Add(this.materialTextBox);
            this.groupBox3.Controls.Add(custONLabel);
            this.groupBox3.Controls.Add(this.custONTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3) Check Material and PO#";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(25, 159);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(453, 24);
            this.txtInfo.TabIndex = 6;
            // 
            // materialDescTextBox
            // 
            this.materialDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "MaterialDesc", true));
            this.materialDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialDescTextBox.Location = new System.Drawing.Point(25, 23);
            this.materialDescTextBox.Multiline = true;
            this.materialDescTextBox.Name = "materialDescTextBox";
            this.materialDescTextBox.ReadOnly = true;
            this.materialDescTextBox.Size = new System.Drawing.Size(347, 73);
            this.materialDescTextBox.TabIndex = 5;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "Material", true));
            this.materialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTextBox.Location = new System.Drawing.Point(378, 23);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.ReadOnly = true;
            this.materialTextBox.Size = new System.Drawing.Size(100, 29);
            this.materialTextBox.TabIndex = 3;
            // 
            // custONTextBox
            // 
            this.custONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTIQ2, "CustON", true));
            this.custONTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custONTextBox.Location = new System.Drawing.Point(378, 114);
            this.custONTextBox.Name = "custONTextBox";
            this.custONTextBox.ReadOnly = true;
            this.custONTextBox.Size = new System.Drawing.Size(100, 29);
            this.custONTextBox.TabIndex = 1;
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Location = new System.Drawing.Point(289, 652);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(241, 49);
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
            this.btnCancel.Location = new System.Drawing.Point(12, 652);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(241, 49);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // bsSPLotNo
            // 
            this.bsSPLotNo.DataMember = "SPLotNoAssign";
            this.bsSPLotNo.DataSource = this.dsTIQ2;
            // 
            // taTIQ2
            // 
            this.taTIQ2.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StockpileBOMTableAdapter = null;
            this.tableAdapterManager.StockpileLotAllocationTableAdapter = null;
            this.tableAdapterManager.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager.TIQTableAdapter = this.taTIQ2;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = null;
            // 
            // taSPLotNo
            // 
            this.taSPLotNo.ClearBeforeFill = true;
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataMember = "BusinessGetByCode";
            this.bsCustomer.DataSource = this.dsTIQ2;
            // 
            // taCustomer
            // 
            this.taCustomer.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtComment);
            this.groupBox4.Location = new System.Drawing.Point(13, 565);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 75);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4) Optional -WBO comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(24, 31);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(453, 24);
            this.txtComment.TabIndex = 0;
            // 
            // PostDocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 739);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostDocket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post Docket";
            this.Load += new System.EventHandler(this.PostDocket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPLotNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOkay;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsTIQ2;
        private dsTIQ2TableAdapters.TIQTableAdapter taTIQ2;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox regoTextBox;
        private System.Windows.Forms.TextBox txtNett;
        private System.Windows.Forms.TextBox txtTare;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox materialDescTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox custONTextBox;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.BindingSource bsSPLotNo;
        private dsTIQ2TableAdapters.SPLotNoAssignTableAdapter taSPLotNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsCustomer;
        private dsTIQ2TableAdapters.BusinessGetByCodeTableAdapter taCustomer;
        private System.Windows.Forms.TextBox txtCOD;
        private System.Windows.Forms.TextBox txtPayload;
        private System.Windows.Forms.TextBox txtUnderload;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtComment;
    }
}