namespace bankSystem
{
    partial class register
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
            this.registerEmployeeBtn = new System.Windows.Forms.Button();
            this.registerCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerEmployeeBtn
            // 
            this.registerEmployeeBtn.Location = new System.Drawing.Point(12, 12);
            this.registerEmployeeBtn.Name = "registerEmployeeBtn";
            this.registerEmployeeBtn.Size = new System.Drawing.Size(165, 161);
            this.registerEmployeeBtn.TabIndex = 0;
            this.registerEmployeeBtn.Text = "Register As an Employee";
            this.registerEmployeeBtn.UseVisualStyleBackColor = true;
            this.registerEmployeeBtn.Click += new System.EventHandler(this.registerEmployeeBtn_Click);
            // 
            // registerCustomerBtn
            // 
            this.registerCustomerBtn.Location = new System.Drawing.Point(211, 12);
            this.registerCustomerBtn.Name = "registerCustomerBtn";
            this.registerCustomerBtn.Size = new System.Drawing.Size(165, 161);
            this.registerCustomerBtn.TabIndex = 2;
            this.registerCustomerBtn.Text = "Register As a Customer";
            this.registerCustomerBtn.UseVisualStyleBackColor = true;
            this.registerCustomerBtn.Click += new System.EventHandler(this.registerCustomerBtn_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 187);
            this.Controls.Add(this.registerCustomerBtn);
            this.Controls.Add(this.registerEmployeeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.ResumeLayout(false);

        }

        #endregion

        private Button registerEmployeeBtn;
        private Button registerCustomerBtn;
    }
}