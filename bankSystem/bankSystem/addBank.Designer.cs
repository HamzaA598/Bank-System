namespace bankSystem
{
    partial class AddBank
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bankNameTxt = new System.Windows.Forms.TextBox();
            this.bankAddressTxt = new System.Windows.Forms.TextBox();
            this.bankCodeTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bankNameTxt
            // 
            this.bankNameTxt.Location = new System.Drawing.Point(134, 51);
            this.bankNameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bankNameTxt.Name = "bankNameTxt";
            this.bankNameTxt.Size = new System.Drawing.Size(171, 23);
            this.bankNameTxt.TabIndex = 4;
            this.bankNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bankAddressTxt
            // 
            this.bankAddressTxt.Location = new System.Drawing.Point(134, 95);
            this.bankAddressTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bankAddressTxt.Name = "bankAddressTxt";
            this.bankAddressTxt.Size = new System.Drawing.Size(170, 23);
            this.bankAddressTxt.TabIndex = 5;
            // 
            // bankCodeTxt
            // 
            this.bankCodeTxt.Location = new System.Drawing.Point(134, 137);
            this.bankCodeTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bankCodeTxt.Name = "bankCodeTxt";
            this.bankCodeTxt.Size = new System.Drawing.Size(170, 23);
            this.bankCodeTxt.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(134, 195);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 27);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Bank";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "back";
            this.label4.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // AddBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.bankCodeTxt);
            this.Controls.Add(this.bankAddressTxt);
            this.Controls.Add(this.bankNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addBank";
            this.Load += new System.EventHandler(this.addBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bankNameTxt;
        private System.Windows.Forms.TextBox bankAddressTxt;
        private System.Windows.Forms.TextBox bankCodeTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label4;
    }
}