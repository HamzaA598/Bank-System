using System.Windows.Forms;

namespace bankSystem
{
    partial class employeeOptions
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
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.showCustomersBtn = new System.Windows.Forms.Button();
            this.loanOptionsBtn = new System.Windows.Forms.Button();
            this.showLoansBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(12, 56);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(159, 126);
            this.addCustomerBtn.TabIndex = 1;
            this.addCustomerBtn.Text = "Add a customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // showCustomersBtn
            // 
            this.showCustomersBtn.Location = new System.Drawing.Point(205, 56);
            this.showCustomersBtn.Name = "showCustomersBtn";
            this.showCustomersBtn.Size = new System.Drawing.Size(159, 126);
            this.showCustomersBtn.TabIndex = 2;
            this.showCustomersBtn.Text = "Show customer list";
            this.showCustomersBtn.UseVisualStyleBackColor = true;
            this.showCustomersBtn.Click += new System.EventHandler(this.showCustomersBtn_Click);
            // 
            // loanOptionsBtn
            // 
            this.loanOptionsBtn.Location = new System.Drawing.Point(12, 222);
            this.loanOptionsBtn.Name = "loanOptionsBtn";
            this.loanOptionsBtn.Size = new System.Drawing.Size(159, 126);
            this.loanOptionsBtn.TabIndex = 3;
            this.loanOptionsBtn.Text = "Accept, reject, pay a lone";
            this.loanOptionsBtn.UseVisualStyleBackColor = true;
            this.loanOptionsBtn.Click += new System.EventHandler(this.loanOptionsBtn_Click);
            // 
            // showLoansBtn
            // 
            this.showLoansBtn.Location = new System.Drawing.Point(205, 222);
            this.showLoansBtn.Name = "showLoansBtn";
            this.showLoansBtn.Size = new System.Drawing.Size(159, 126);
            this.showLoansBtn.TabIndex = 4;
            this.showLoansBtn.Text = "Show loan list";
            this.showLoansBtn.UseVisualStyleBackColor = true;
            this.showLoansBtn.Click += new System.EventHandler(this.showLoansBtn_Click);
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
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(12, 381);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(352, 94);
            this.selectBtn.TabIndex = 20;
            this.selectBtn.Text = "SELECT queries";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // employeeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 487);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showLoansBtn);
            this.Controls.Add(this.loanOptionsBtn);
            this.Controls.Add(this.showCustomersBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "employeeOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addCustomerBtn;
        private Button showCustomersBtn;
        private Button loanOptionsBtn;
        private Button showLoansBtn;
        private Label label1;
        private Button selectBtn;
    }
}