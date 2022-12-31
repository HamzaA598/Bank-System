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
    public partial class RequestLoan : Form
    {
        public RequestLoan()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            string s1 = "SELECT ID FROM Deals_With WHERE SSN ='" + ssnTxt.Text + "'";
            string s2 = "SELECT Branch# FROM Customer WHERE SSN = '"+ ssnTxt.Text+"'";
            SqlCommand cmd = new SqlCommand();
            SqlCommand command = new SqlCommand();
            cmd.Connection = connection;
            command.Connection = connection;
            connection.Open();

            cmd.CommandText = s1;
            int id = (int)cmd.ExecuteScalar();

            cmd.CommandText = s2;
            int branch = (int)cmd.ExecuteScalar();

            command.CommandText = "INSERT INTO Loan (Loan_Type, Loan_Amount, SSN, Branch#, empID) " +
                                  "VALUES('" + loanTypeTxt.Text + "', " + Convert.ToInt32(loanAmountTxt.Text) + ", '" + ssnTxt.Text + "', " + branch + ", " + id + ")";
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Loan requested successfully!");
            new customerOptions().Show();
            this.Hide();

        }

        private void RequestLoan_Load(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new customerOptions().Show();
            this.Hide();
        }
    }
}
