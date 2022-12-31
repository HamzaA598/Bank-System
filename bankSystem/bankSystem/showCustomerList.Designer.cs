namespace bankSystem
{
    partial class showCustomerList
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
            this.customersData = new System.Windows.Forms.DataGridView();
            this.backLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersData)).BeginInit();
            this.SuspendLayout();
            // 
            // customersData
            // 
            this.customersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersData.Location = new System.Drawing.Point(12, 45);
            this.customersData.Name = "customersData";
            this.customersData.ReadOnly = true;
            this.customersData.RowTemplate.Height = 25;
            this.customersData.Size = new System.Drawing.Size(751, 373);
            this.customersData.TabIndex = 0;
            this.customersData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersData_CellContentClick);
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
            // showCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 430);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.customersData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "showCustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showCustomerList";
            this.Load += new System.EventHandler(this.showCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView customersData;
        private Label backLbl;
    }
}