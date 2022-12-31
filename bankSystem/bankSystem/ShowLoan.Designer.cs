namespace bankSystem
{
    partial class ShowLoan
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
            this.loansData = new System.Windows.Forms.DataGridView();
            this.backLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loansData)).BeginInit();
            this.SuspendLayout();
            // 
            // loansData
            // 
            this.loansData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loansData.Location = new System.Drawing.Point(13, 42);
            this.loansData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loansData.Name = "loansData";
            this.loansData.Size = new System.Drawing.Size(743, 321);
            this.loansData.TabIndex = 0;
            this.loansData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // ShowLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 375);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.loansData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShowLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowLoan";
            this.Load += new System.EventHandler(this.ShowLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loansData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loansData;
        private Label backLbl;
    }
}