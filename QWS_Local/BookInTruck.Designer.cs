
namespace QWS_Local
{
    partial class BookInTruck
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
            System.Windows.Forms.Label regoTkLabel;
            this.regoTkTextBox = new System.Windows.Forms.TextBox();
            this.bsConfiguredTnT = new System.Windows.Forms.BindingSource(this.components);
            this.dsTruckConfig = new QWS_Local.dsTruckConfig();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.taConfiguredTnT = new QWS_Local.dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter();
            this.tableAdapterManager = new QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.txtAxleConfig2 = new System.Windows.Forms.TextBox();
            regoTkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // regoTkLabel
            // 
            regoTkLabel.AutoSize = true;
            regoTkLabel.Location = new System.Drawing.Point(183, 80);
            regoTkLabel.Name = "regoTkLabel";
            regoTkLabel.Size = new System.Drawing.Size(52, 13);
            regoTkLabel.TabIndex = 2;
            regoTkLabel.Text = "Rego Tk:";
            // 
            // regoTkTextBox
            // 
            this.regoTkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnT, "RegoTk", true));
            this.regoTkTextBox.Location = new System.Drawing.Point(241, 77);
            this.regoTkTextBox.Name = "regoTkTextBox";
            this.regoTkTextBox.Size = new System.Drawing.Size(100, 20);
            this.regoTkTextBox.TabIndex = 3;
            // 
            // bsConfiguredTnT
            // 
            this.bsConfiguredTnT.DataMember = "ConfiguredTnT";
            this.bsConfiguredTnT.DataSource = this.dsTruckConfig;
            // 
            // dsTruckConfig
            // 
            this.dsTruckConfig.DataSetName = "dsTruckConfig";
            this.dsTruckConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taConfiguredTnT
            // 
            this.taConfiguredTnT.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QWS_Local.dsTruckConfigTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtCardCode
            // 
            this.txtCardCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsConfiguredTnT, "CardCode", true));
            this.txtCardCode.Location = new System.Drawing.Point(241, 120);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(100, 20);
            this.txtCardCode.TabIndex = 6;
            // 
            // txtAxleConfig2
            // 
            this.txtAxleConfig2.Location = new System.Drawing.Point(241, 146);
            this.txtAxleConfig2.Name = "txtAxleConfig2";
            this.txtAxleConfig2.Size = new System.Drawing.Size(100, 20);
            this.txtAxleConfig2.TabIndex = 7;
            // 
            // BookInTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAxleConfig2);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(regoTkLabel);
            this.Controls.Add(this.regoTkTextBox);
            this.Name = "BookInTruck";
            this.Text = "BookInTruck";
            this.Load += new System.EventHandler(this.BookInTruck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguredTnT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTruckConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsTruckConfig dsTruckConfig;
        private System.Windows.Forms.BindingSource bsConfiguredTnT;
        private dsTruckConfigTableAdapters.ConfiguredTnTTableAdapter taConfiguredTnT;
        private dsTruckConfigTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox regoTkTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TextBox txtAxleConfig2;
    }
}