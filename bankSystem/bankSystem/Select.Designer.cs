namespace bankSystem
{
    partial class Select
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noCustomerBtn = new System.Windows.Forms.Button();
            this.noEmployeeBtn = new System.Windows.Forms.Button();
            this.customerMaxLoanBtn = new System.Windows.Forms.Button();
            this.noLoanCustomerBtn = new System.Windows.Forms.Button();
            this.employeeMaxLoanBtn = new System.Windows.Forms.Button();
            this.customerDataBtn = new System.Windows.Forms.Button();
            this.backLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // noCustomerBtn
            // 
            this.noCustomerBtn.Location = new System.Drawing.Point(14, 248);
            this.noCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.noCustomerBtn.Name = "noCustomerBtn";
            this.noCustomerBtn.Size = new System.Drawing.Size(338, 27);
            this.noCustomerBtn.TabIndex = 1;
            this.noCustomerBtn.Text = "Show branch with no customers";
            this.noCustomerBtn.UseVisualStyleBackColor = true;
            this.noCustomerBtn.Click += new System.EventHandler(this.noCustomerBtn_Click);
            // 
            // noEmployeeBtn
            // 
            this.noEmployeeBtn.Location = new System.Drawing.Point(14, 281);
            this.noEmployeeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.noEmployeeBtn.Name = "noEmployeeBtn";
            this.noEmployeeBtn.Size = new System.Drawing.Size(338, 27);
            this.noEmployeeBtn.TabIndex = 2;
            this.noEmployeeBtn.Text = "Show branch with no employees";
            this.noEmployeeBtn.UseVisualStyleBackColor = true;
            this.noEmployeeBtn.Click += new System.EventHandler(this.noEmployeeBtn_Click);
            // 
            // customerMaxLoanBtn
            // 
            this.customerMaxLoanBtn.Location = new System.Drawing.Point(372, 248);
            this.customerMaxLoanBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customerMaxLoanBtn.Name = "customerMaxLoanBtn";
            this.customerMaxLoanBtn.Size = new System.Drawing.Size(341, 27);
            this.customerMaxLoanBtn.TabIndex = 4;
            this.customerMaxLoanBtn.Text = "Show customer with max number of loans";
            this.customerMaxLoanBtn.UseVisualStyleBackColor = true;
            this.customerMaxLoanBtn.Click += new System.EventHandler(this.customerMaxLoanBtn_Click);
            // 
            // noLoanCustomerBtn
            // 
            this.noLoanCustomerBtn.Location = new System.Drawing.Point(372, 281);
            this.noLoanCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.noLoanCustomerBtn.Name = "noLoanCustomerBtn";
            this.noLoanCustomerBtn.Size = new System.Drawing.Size(341, 27);
            this.noLoanCustomerBtn.TabIndex = 5;
            this.noLoanCustomerBtn.Text = "Show customers with no loans taken";
            this.noLoanCustomerBtn.UseVisualStyleBackColor = true;
            this.noLoanCustomerBtn.Click += new System.EventHandler(this.noLoanCustomerBtn_Click);
            // 
            // employeeMaxLoanBtn
            // 
            this.employeeMaxLoanBtn.Location = new System.Drawing.Point(14, 315);
            this.employeeMaxLoanBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.employeeMaxLoanBtn.Name = "employeeMaxLoanBtn";
            this.employeeMaxLoanBtn.Size = new System.Drawing.Size(338, 27);
            this.employeeMaxLoanBtn.TabIndex = 7;
            this.employeeMaxLoanBtn.Text = "Show employee with max number of loans";
            this.employeeMaxLoanBtn.UseVisualStyleBackColor = true;
            this.employeeMaxLoanBtn.Click += new System.EventHandler(this.employeeMaxLoanBtn_Click);
            // 
            // customerDataBtn
            // 
            this.customerDataBtn.Location = new System.Drawing.Point(372, 315);
            this.customerDataBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customerDataBtn.Name = "customerDataBtn";
            this.customerDataBtn.Size = new System.Drawing.Size(341, 27);
            this.customerDataBtn.TabIndex = 8;
            this.customerDataBtn.Text = "Show customer data";
            this.customerDataBtn.UseVisualStyleBackColor = true;
            this.customerDataBtn.Click += new System.EventHandler(this.customerDataBtn_Click);
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
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 370);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.customerDataBtn);
            this.Controls.Add(this.employeeMaxLoanBtn);
            this.Controls.Add(this.noLoanCustomerBtn);
            this.Controls.Add(this.customerMaxLoanBtn);
            this.Controls.Add(this.noEmployeeBtn);
            this.Controls.Add(this.noCustomerBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button noCustomerBtn;
        private System.Windows.Forms.Button noEmployeeBtn;
        private System.Windows.Forms.Button customerMaxLoanBtn;
        private System.Windows.Forms.Button noLoanCustomerBtn;
        private System.Windows.Forms.Button employeeMaxLoanBtn;
        private System.Windows.Forms.Button customerDataBtn;
        private Label backLbl;
    }
}