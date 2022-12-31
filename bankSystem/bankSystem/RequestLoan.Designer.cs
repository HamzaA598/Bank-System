namespace bankSystem
{
    partial class RequestLoan
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
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loanAmountTxt = new System.Windows.Forms.TextBox();
            this.loanTypeTxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ssnTxt = new System.Windows.Forms.TextBox();
            this.backLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(110, 183);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 27);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Request";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loan Type";
            // 
            // loanAmountTxt
            // 
            this.loanAmountTxt.Location = new System.Drawing.Point(125, 91);
            this.loanAmountTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loanAmountTxt.Name = "loanAmountTxt";
            this.loanAmountTxt.Size = new System.Drawing.Size(157, 23);
            this.loanAmountTxt.TabIndex = 4;
            // 
            // loanTypeTxt
            // 
            this.loanTypeTxt.FormattingEnabled = true;
            this.loanTypeTxt.Items.AddRange(new object[] {
            "Personal",
            "Industry",
            "Commercial",
            "Student"});
            this.loanTypeTxt.Location = new System.Drawing.Point(125, 50);
            this.loanTypeTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loanTypeTxt.Name = "loanTypeTxt";
            this.loanTypeTxt.Size = new System.Drawing.Size(157, 23);
            this.loanTypeTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "SSN";
            // 
            // ssnTxt
            // 
            this.ssnTxt.Location = new System.Drawing.Point(125, 135);
            this.ssnTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ssnTxt.Name = "ssnTxt";
            this.ssnTxt.Size = new System.Drawing.Size(157, 23);
            this.ssnTxt.TabIndex = 4;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backLbl.Location = new System.Drawing.Point(12, 9);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(38, 20);
            this.backLbl.TabIndex = 20;
            this.backLbl.Text = "back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // RequestLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 225);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.ssnTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loanTypeTxt);
            this.Controls.Add(this.loanAmountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RequestLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestLoan";
            this.Load += new System.EventHandler(this.RequestLoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loanAmountTxt;
        private System.Windows.Forms.ComboBox loanTypeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ssnTxt;
        private Label backLbl;
    }
}