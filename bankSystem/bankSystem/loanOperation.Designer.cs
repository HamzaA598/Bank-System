namespace bankSystem
{
    partial class loanOperations
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
            this.loanData = new System.Windows.Forms.DataGridView();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.rejectBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loanData)).BeginInit();
            this.SuspendLayout();
            // 
            // loanData
            // 
            this.loanData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanData.Location = new System.Drawing.Point(11, 80);
            this.loanData.Name = "loanData";
            this.loanData.ReadOnly = true;
            this.loanData.RowTemplate.Height = 25;
            this.loanData.Size = new System.Drawing.Size(745, 318);
            this.loanData.TabIndex = 0;
            this.loanData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loanData_CellContentClick);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(11, 426);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(98, 64);
            this.acceptBtn.TabIndex = 1;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // rejectBtn
            // 
            this.rejectBtn.Location = new System.Drawing.Point(336, 426);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(98, 64);
            this.rejectBtn.TabIndex = 2;
            this.rejectBtn.Text = "Reject";
            this.rejectBtn.UseVisualStyleBackColor = true;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(658, 426);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(98, 64);
            this.payBtn.TabIndex = 3;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Showing the list of pending and accepted loans only";
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
            // loanOperations
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.loanData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loanOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loanOperation";
            this.Load += new System.EventHandler(this.loanOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView loanData;
        private Button acceptBtn;
        private Button rejectBtn;
        private Button payBtn;
        private Label label1;
        private Label backLbl;
    }
}