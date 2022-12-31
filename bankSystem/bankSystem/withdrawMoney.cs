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
    public partial class withdrawMoney : Form
    {
        public withdrawMoney()
        {
            InitializeComponent();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            string s = "select SSN from Customer where Username = '" + login.customerUsername + "'";
            SqlCommand cmd = new SqlCommand();
            SqlCommand command = new SqlCommand();
            cmd.Connection = connection;
            command.Connection = connection;
            connection.Open();

            cmd.CommandText = s;
            string ssn = (string)cmd.ExecuteScalar();

            s = "SELECT Balance FROM Account WHERE SSN = '" + ssn + "' and Account# ='"+accountNumberTxt.Text+"' ";
            cmd.CommandText = s;
            int balance = (int)cmd.ExecuteScalar();

            if (Convert.ToInt32(withdrawTxt.Text) > balance)
            {
                MessageBox.Show("Not enough balance to complete the withdrawal");
            }
            else
            {
                command.CommandText = "UPDATE Account " +
                                      "SET Balance = Balance - " + Convert.ToInt32(withdrawTxt.Text) + 
                                      " WHERE SSN = " + ssn + " and Account# = " + Convert.ToInt32(accountNumberTxt.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Withdrawal Successful");
                new customerOptions().Show();
                this.Hide();
            }

            connection.Close();
        }

        private void withdrawMoney_Load(object sender, EventArgs e)
        {

        }

        private void withdrawTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new customerOptions().Show();
            this.Hide();
        }
    }
}
