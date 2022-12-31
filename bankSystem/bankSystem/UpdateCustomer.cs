using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bankSystem
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            if (passwordTxt.Text == confirmPasswordTxt.Text)
            {
                command.Connection = connection;

                connection.Open();
                command.CommandText = "update UserAccount set Password = '"+ passwordTxt.Text +"' where Username = '"+ usernameTxt.Text + "'";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Password updated successfully");
                new login().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passowrds are not the same");
            }
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
