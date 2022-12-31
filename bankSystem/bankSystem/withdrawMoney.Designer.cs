using System.Windows.Forms;

namespace bankSystem
{
    partial class withdrawMoney
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
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.withdrawTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNumberTxt = new System.Windows.Forms.TextBox();
            this.backLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ammount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(173, 173);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(83, 29);
            this.withdrawBtn.TabIndex = 4;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // withdrawTxt
            // 
            this.withdrawTxt.Location = new System.Drawing.Point(173, 107);
            this.withdrawTxt.Name = "withdrawTxt";
            this.withdrawTxt.Size = new System.Drawing.Size(204, 23);
            this.withdrawTxt.TabIndex = 3;
            this.withdrawTxt.TextChanged += new System.EventHandler(this.withdrawTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // accountNumberTxt
            // 
            this.accountNumberTxt.Location = new System.Drawing.Point(173, 52);
            this.accountNumberTxt.Name = "accountNumberTxt";
            this.accountNumberTxt.Size = new System.Drawing.Size(204, 23);
            this.accountNumberTxt.TabIndex = 3;
            this.accountNumberTxt.TextChanged += new System.EventHandler(this.withdrawTxt_TextChanged);
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
            // withdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 214);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.accountNumberTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.withdrawTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "withdrawMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdrawMoney";
            this.Load += new System.EventHandler(this.withdrawMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button withdrawBtn;
        private TextBox withdrawTxt;
        private Label label2;
        private TextBox accountNumberTxt;
        private Label backLbl;
    }
}