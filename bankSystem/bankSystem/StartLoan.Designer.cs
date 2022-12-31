namespace bankSystem
{
    partial class StartLoan
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
            this.acceptedLoansData = new System.Windows.Forms.DataGridView();
            this.startBtn = new System.Windows.Forms.Button();
            this.backLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedLoansData)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptedLoansData
            // 
            this.acceptedLoansData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acceptedLoansData.Location = new System.Drawing.Point(13, 47);
            this.acceptedLoansData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.acceptedLoansData.Name = "acceptedLoansData";
            this.acceptedLoansData.ReadOnly = true;
            this.acceptedLoansData.Size = new System.Drawing.Size(743, 258);
            this.acceptedLoansData.TabIndex = 0;
            this.acceptedLoansData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(331, 328);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(98, 42);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
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
            // StartLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 387);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.acceptedLoansData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StartLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartLoan";
            this.Load += new System.EventHandler(this.StartLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acceptedLoansData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView acceptedLoansData;
        private System.Windows.Forms.Button startBtn;
        private Label backLbl;
    }
}