using System.Windows.Forms;

namespace bankSystem
{
    partial class AddCustomer
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
            this.balanceTxt = new System.Windows.Forms.TextBox();
            this.customerSSNTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.typeCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balanceTxt
            // 
            this.balanceTxt.Location = new System.Drawing.Point(157, 106);
            this.balanceTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.Size = new System.Drawing.Size(220, 23);
            this.balanceTxt.TabIndex = 15;
            // 
            // customerSSNTxt
            // 
            this.customerSSNTxt.Location = new System.Drawing.Point(157, 62);
            this.customerSSNTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customerSSNTxt.Name = "customerSSNTxt";
            this.customerSSNTxt.Size = new System.Drawing.Size(220, 23);
            this.customerSSNTxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Account Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Initial Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "SSN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeCmb
            // 
            this.typeCmb.FormattingEnabled = true;
            this.typeCmb.Items.AddRange(new object[] {
            "Saving",
            "Checking",
            "Salary"});
            this.typeCmb.Location = new System.Drawing.Point(157, 149);
            this.typeCmb.Name = "typeCmb";
            this.typeCmb.Size = new System.Drawing.Size(220, 23);
            this.typeCmb.TabIndex = 16;
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
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeCmb);
            this.Controls.Add(this.balanceTxt);
            this.Controls.Add(this.customerSSNTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox balanceTxt;
        private System.Windows.Forms.TextBox customerSSNTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ComboBox typeCmb;
        private Label label4;
    }
}