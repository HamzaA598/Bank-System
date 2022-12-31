namespace bankSystem
{
    partial class depositMoney
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
            this.depositBtn = new System.Windows.Forms.Button();
            this.accountNumberTxt = new System.Windows.Forms.TextBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(122, 181);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(84, 32);
            this.depositBtn.TabIndex = 2;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountNumberTxt
            // 
            this.accountNumberTxt.Location = new System.Drawing.Point(161, 58);
            this.accountNumberTxt.Name = "accountNumberTxt";
            this.accountNumberTxt.Size = new System.Drawing.Size(111, 23);
            this.accountNumberTxt.TabIndex = 3;
            this.accountNumberTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(161, 119);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(111, 23);
            this.amountTxt.TabIndex = 4;
            this.amountTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "back";
            this.label3.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // depositMoney
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.accountNumberTxt);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "depositMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.depositMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.TextBox accountNumberTxt;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label3;
    }
}