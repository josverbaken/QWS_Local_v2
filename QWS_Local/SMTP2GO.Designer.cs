namespace QWS_Local
{
    partial class SMTP2GO
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
            System.Windows.Forms.Label docNumLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtMsgLength = new System.Windows.Forms.TextBox();
            this.dsTIQ2 = new QWS_Local.dsTIQ2();
            this.bsWBDockets = new System.Windows.Forms.BindingSource(this.components);
            this.taWBDockets = new QWS_Local.dsTIQ2TableAdapters.WBDocketsTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTIQ2TableAdapters.TableAdapterManager();
            this.docNumTextBox = new System.Windows.Forms.TextBox();
            this.btnSent = new System.Windows.Forms.Button();
            this.btnCloseSuccessful = new System.Windows.Forms.Button();
            docNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).BeginInit();
            this.SuspendLayout();
            // 
            // docNumLabel
            // 
            docNumLabel.AutoSize = true;
            docNumLabel.Location = new System.Drawing.Point(202, 26);
            docNumLabel.Name = "docNumLabel";
            docNumLabel.Size = new System.Drawing.Size(55, 13);
            docNumLabel.TabIndex = 12;
            docNumLabel.Text = "Doc Num:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(33, 235);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(249, 59);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(33, 124);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(331, 99);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.Text = "write something";
            this.txtMessage.DoubleClick += new System.EventHandler(this.txtMessage_Click);
            this.txtMessage.Enter += new System.EventHandler(this.txtMessage_Enter);
            // 
            // txtRecipient
            // 
            this.txtRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipient.Location = new System.Drawing.Point(33, 53);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(334, 26);
            this.txtRecipient.TabIndex = 7;
            this.txtRecipient.Text = "+61409163869";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(30, 300);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(334, 206);
            this.txtResult.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(301, 267);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(66, 27);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtMsgLength
            // 
            this.txtMsgLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgLength.Location = new System.Drawing.Point(301, 235);
            this.txtMsgLength.Name = "txtMsgLength";
            this.txtMsgLength.ReadOnly = true;
            this.txtMsgLength.Size = new System.Drawing.Size(66, 26);
            this.txtMsgLength.TabIndex = 11;
            this.txtMsgLength.Text = " ";
            // 
            // dsTIQ2
            // 
            this.dsTIQ2.DataSetName = "dsTIQ2";
            this.dsTIQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsWBDockets
            // 
            this.bsWBDockets.DataMember = "WBDockets";
            this.bsWBDockets.DataSource = this.dsTIQ2;
            // 
            // taWBDockets
            // 
            this.taWBDockets.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StockpileBOMTableAdapter = null;
            this.tableAdapterManager.StockpileLotAllocationTableAdapter = null;
            this.tableAdapterManager.StockpileManualAllocationTableAdapter = null;
            this.tableAdapterManager.TIQTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTIQ2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WBDocketLinesTableAdapter = null;
            this.tableAdapterManager.WBDocketsTableAdapter = this.taWBDockets;
            // 
            // docNumTextBox
            // 
            this.docNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsWBDockets, "DocNum", true));
            this.docNumTextBox.Location = new System.Drawing.Point(267, 23);
            this.docNumTextBox.Name = "docNumTextBox";
            this.docNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.docNumTextBox.TabIndex = 13;
            // 
            // btnSent
            // 
            this.btnSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.Location = new System.Drawing.Point(30, 512);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(249, 59);
            this.btnSent.TabIndex = 14;
            this.btnSent.Text = "Sent Successfully";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnCloseSuccessful
            // 
            this.btnCloseSuccessful.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSuccessful.Location = new System.Drawing.Point(285, 512);
            this.btnCloseSuccessful.Name = "btnCloseSuccessful";
            this.btnCloseSuccessful.Size = new System.Drawing.Size(82, 59);
            this.btnCloseSuccessful.TabIndex = 15;
            this.btnCloseSuccessful.Text = "Close";
            this.btnCloseSuccessful.UseVisualStyleBackColor = true;
            this.btnCloseSuccessful.Click += new System.EventHandler(this.btnCloseSuccessful_Click);
            // 
            // SMTP2GO
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 599);
            this.Controls.Add(this.btnCloseSuccessful);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(docNumLabel);
            this.Controls.Add(this.docNumTextBox);
            this.Controls.Add(this.txtMsgLength);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "SMTP2GO";
            this.Text = "SMTP2GO";
            this.Load += new System.EventHandler(this.SMTP2GO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTIQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWBDockets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtMsgLength;
        private dsTIQ2 dsTIQ2;
        private System.Windows.Forms.BindingSource bsWBDockets;
        private dsTIQ2TableAdapters.WBDocketsTableAdapter taWBDockets;
        private dsTIQ2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox docNumTextBox;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Button btnCloseSuccessful;
    }
}