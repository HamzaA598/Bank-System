using System.Windows.Forms;

namespace bankSystem
{
    partial class adminOptions
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
            this.addBranchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBankBtn
            // 
            this.addBankBtn.Location = new System.Drawing.Point(26, 69);
            this.addBankBtn.Name = "addBankBtn";
            this.addBankBtn.Size = new System.Drawing.Size(159, 126);
            this.addBankBtn.TabIndex = 0;
            this.addBankBtn.Text = "Add a bank";
            this.addBankBtn.UseVisualStyleBackColor = true;
            this.addBankBtn.Click += new System.EventHandler(this.addBankBtn_Click);
            // 
            // addBranchBtn
            // 
            this.addBranchBtn.Location = new System.Drawing.Point(204, 69);
            this.addBranchBtn.Name = "addBranchBtn";
            this.addBranchBtn.Size = new System.Drawing.Size(159, 126);
            this.addBranchBtn.TabIndex = 1;
            this.addBranchBtn.Text = "Add a bank branch";
            this.addBranchBtn.UseVisualStyleBackColor = true;
            this.addBranchBtn.Click += new System.EventHandler(this.addBranchBtn_Click);
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
            // adminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBranchBtn);
            this.Controls.Add(this.addBankBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adminOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminOptions";
            this.Load += new System.EventHandler(this.adminOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addBankBtn;
        private Button addBranchBtn;
        private Label label1;
    }
}