using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bankSystem
{
    public partial class depositMoney : Form
    {
        public depositMoney()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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


            command.CommandText = "UPDATE Account SET Balance = Balance + " + Convert.ToInt32(amountTxt.Text) + " WHERE SSN = " + ssn +
                                   "and Account# = " + Int32.Parse(accountNumberTxt.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Deposit Successful");
            new customerOptions().Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void depositMoney_Load(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new customerOptions().Show();
            this.Hide();
        }
    }
}
