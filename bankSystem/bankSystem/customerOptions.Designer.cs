using System.Windows.Forms;

namespace bankSystem
{
    partial class customerOptions
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
            this.addBankBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.requestBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBankBtn
            // 
            this.addBankBtn.Location = new System.Drawing.Point(23, 48);
            this.addBankBtn.Name = "addBankBtn";
            this.addBankBtn.Size = new System.Drawing.Size(159, 126);
            this.addBankBtn.TabIndex = 1;
            this.addBankBtn.Text = "Deposit money";
            this.addBankBtn.UseVisualStyleBackColor = true;
            this.addBankBtn.Click += new System.EventHandler(this.addBankBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(209, 48);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(159, 126);
            this.withdrawBtn.TabIndex = 2;
            this.withdrawBtn.Text = "Withdraw money";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // requestBtn
            // 
            this.requestBtn.Location = new System.Drawing.Point(23, 196);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(159, 126);
            this.requestBtn.TabIndex = 3;
            this.requestBtn.Text = "Request a loan";
            this.requestBtn.UseVisualStyleBackColor = true;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(209, 196);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(159, 126);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start a loan";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // customerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.requestBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.addBankBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "customerOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerOptions";
            this.Load += new System.EventHandler(this.customerOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addBankBtn;
        private Button withdrawBtn;
        private Button requestBtn;
        private Button startBtn;
        private Label label1;
    }
}