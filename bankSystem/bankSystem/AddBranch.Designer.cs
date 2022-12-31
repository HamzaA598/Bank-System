namespace bankSystem
{
    partial class AddBranch
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
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.bankCodeTxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(139, 58);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(181, 23);
            this.addressTxt.TabIndex = 1;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bank Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(139, 198);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 27);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add Branch";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // bankCodeTxt
            // 
            this.bankCodeTxt.FormattingEnabled = true;
            this.bankCodeTxt.Location = new System.Drawing.Point(139, 131);
            this.bankCodeTxt.Name = "bankCodeTxt";
            this.bankCodeTxt.Size = new System.Drawing.Size(180, 23);
            this.bankCodeTxt.TabIndex = 10;
            this.bankCodeTxt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "back";
            this.label1.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankCodeTxt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBranch";
            this.Load += new System.EventHandler(this.AddBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox bankCodeTxt;
        private System.Windows.Forms.Label label1;
    }
}