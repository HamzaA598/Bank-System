namespace bankSystem
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginLbl = new System.Windows.Forms.Label();
            this.adminLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(85, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(85, 172);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(180, 23);
            this.usernameTxt.TabIndex = 4;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(85, 238);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '•';
            this.passwordTxt.Size = new System.Drawing.Size(180, 23);
            this.passwordTxt.TabIndex = 5;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(105, 293);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(89, 36);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "log in";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(25, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 2);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(25, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 2);
            this.panel2.TabIndex = 9;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(85, 348);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(131, 15);
            this.loginLbl.TabIndex = 69;
            this.loginLbl.Text = "Don\'t have an account?";
            this.loginLbl.Click += new System.EventHandler(this.loginLbl_Click);
            // 
            // adminLbl
            // 
            this.adminLbl.AutoSize = true;
            this.adminLbl.Location = new System.Drawing.Point(101, 398);
            this.adminLbl.Name = "adminLbl";
            this.adminLbl.Size = new System.Drawing.Size(90, 15);
            this.adminLbl.TabIndex = 70;
            this.adminLbl.Text = "Login as Admin";
            this.adminLbl.Click += new System.EventHandler(this.adminLbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "password";
            // 
            // updateLbl
            // 
            this.updateLbl.AutoSize = true;
            this.updateLbl.Location = new System.Drawing.Point(96, 373);
            this.updateLbl.Name = "updateLbl";
            this.updateLbl.Size = new System.Drawing.Size(109, 15);
            this.updateLbl.TabIndex = 71;
            this.updateLbl.Text = "Update User Details";
            this.updateLbl.Click += new System.EventHandler(this.updateLbl_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.updateLbl);
            this.Controls.Add(this.adminLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private Panel panel1;
        private Panel panel2;
        private Label loginLbl;
        private Label adminLbl;
        private Label label3;
        private Label updateLbl;
    }
}