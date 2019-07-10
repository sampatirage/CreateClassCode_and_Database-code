namespace WriteClassCode
{
    partial class MainForm
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
            this.btnAddAnotherTbox = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowCode = new System.Windows.Forms.Button();
            this.txbShowCode = new System.Windows.Forms.TextBox();
            this.cBoxClassVisibility = new System.Windows.Forms.ComboBox();
            this.txbClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatabaseCode = new System.Windows.Forms.Button();
            this.btnEditTableItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbOutPut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAnotherTbox
            // 
            this.btnAddAnotherTbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddAnotherTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnotherTbox.Location = new System.Drawing.Point(743, 93);
            this.btnAddAnotherTbox.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnotherTbox.Name = "btnAddAnotherTbox";
            this.btnAddAnotherTbox.Size = new System.Drawing.Size(172, 48);
            this.btnAddAnotherTbox.TabIndex = 1;
            this.btnAddAnotherTbox.Text = "Add Variable";
            this.btnAddAnotherTbox.UseVisualStyleBackColor = false;
            this.btnAddAnotherTbox.Click += new System.EventHandler(this.btnButon1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(51, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 230);
            this.panel1.TabIndex = 2;
            // 
            // btnShowCode
            // 
            this.btnShowCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCode.Location = new System.Drawing.Point(743, 162);
            this.btnShowCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCode.Name = "btnShowCode";
            this.btnShowCode.Size = new System.Drawing.Size(172, 47);
            this.btnShowCode.TabIndex = 3;
            this.btnShowCode.Text = "Class Code";
            this.btnShowCode.UseVisualStyleBackColor = false;
            this.btnShowCode.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // txbShowCode
            // 
            this.txbShowCode.CausesValidation = false;
            this.txbShowCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbShowCode.Location = new System.Drawing.Point(51, 348);
            this.txbShowCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbShowCode.Multiline = true;
            this.txbShowCode.Name = "txbShowCode";
            this.txbShowCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbShowCode.Size = new System.Drawing.Size(932, 244);
            this.txbShowCode.TabIndex = 4;
            // 
            // cBoxClassVisibility
            // 
            this.cBoxClassVisibility.FormattingEnabled = true;
            this.cBoxClassVisibility.Items.AddRange(new object[] {
            "public",
            "internal",
            "private "});
            this.cBoxClassVisibility.Location = new System.Drawing.Point(193, 5);
            this.cBoxClassVisibility.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxClassVisibility.Name = "cBoxClassVisibility";
            this.cBoxClassVisibility.Size = new System.Drawing.Size(160, 24);
            this.cBoxClassVisibility.TabIndex = 5;
            // 
            // txbClassName
            // 
            this.txbClassName.Location = new System.Drawing.Point(457, 1);
            this.txbClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txbClassName.Name = "txbClassName";
            this.txbClassName.Size = new System.Drawing.Size(179, 23);
            this.txbClassName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class name:";
            // 
            // btnDatabaseCode
            // 
            this.btnDatabaseCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDatabaseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabaseCode.Location = new System.Drawing.Point(743, 217);
            this.btnDatabaseCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatabaseCode.Name = "btnDatabaseCode";
            this.btnDatabaseCode.Size = new System.Drawing.Size(172, 44);
            this.btnDatabaseCode.TabIndex = 8;
            this.btnDatabaseCode.Text = "Database Code";
            this.btnDatabaseCode.UseVisualStyleBackColor = false;
            this.btnDatabaseCode.Click += new System.EventHandler(this.btnDatabaseCode_Click);
            // 
            // btnEditTableItem
            // 
            this.btnEditTableItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditTableItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTableItem.Location = new System.Drawing.Point(743, 269);
            this.btnEditTableItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTableItem.Name = "btnEditTableItem";
            this.btnEditTableItem.Size = new System.Drawing.Size(172, 38);
            this.btnEditTableItem.TabIndex = 9;
            this.btnEditTableItem.Text = "Edit database code";
            this.btnEditTableItem.UseVisualStyleBackColor = false;
            this.btnEditTableItem.Click += new System.EventHandler(this.btnEditTableItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(660, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add variables starting from Primary key";
            // 
            // txbOutPut
            // 
            this.txbOutPut.Location = new System.Drawing.Point(51, 321);
            this.txbOutPut.Name = "txbOutPut";
            this.txbOutPut.ReadOnly = true;
            this.txbOutPut.Size = new System.Drawing.Size(932, 23);
            this.txbOutPut.TabIndex = 11;
            this.txbOutPut.Text = "Copy and paste the content of box below to your code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Scope select";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 735);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbOutPut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditTableItem);
            this.Controls.Add(this.btnDatabaseCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbClassName);
            this.Controls.Add(this.cBoxClassVisibility);
            this.Controls.Add(this.txbShowCode);
            this.Controls.Add(this.btnShowCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddAnotherTbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Write Class Code";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAnotherTbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowCode;
        private System.Windows.Forms.TextBox txbShowCode;
        private System.Windows.Forms.ComboBox cBoxClassVisibility;
        private System.Windows.Forms.TextBox txbClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatabaseCode;
        private System.Windows.Forms.Button btnEditTableItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbOutPut;
        private System.Windows.Forms.Label label3;
    }
}

