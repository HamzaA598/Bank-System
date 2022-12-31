using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bankSystem
{
    public partial class StartLoan : Form
    {
        public StartLoan()
        {
            InitializeComponent();
        }

        private void update()
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Loan where status = 'Accepted'", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "customers data");
            acceptedLoansData.DataSource = ds.Tables[0];
            sc.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            int rowindex = acceptedLoansData.CurrentCell.RowIndex;
            int loanNumber = Int32.Parse(acceptedLoansData.Rows[rowindex].Cells[1].Value.ToString());
            command.CommandText = "update Loan set status = 'Started' where Loan# = " + loanNumber;
            command.ExecuteNonQuery();
            connection.Close();
            update();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void StartLoan_Load(object sender, EventArgs e)
        {
            update();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new customerOptions().Show();
            this.Hide();
        }
    }
}
