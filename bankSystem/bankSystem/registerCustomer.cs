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
    public partial class registerCustomer : Form
    {
        public registerCustomer()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            if (passwordTxt.Text == confirmTxt.Text)
            {
                connection.Open();
                command.CommandText = "INSERT INTO UserAccount(Username, Password, Type)" +
                                      "VALUES('" + usernameTxt.Text + "', '" + passwordTxt.Text + "', 'Customer')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Customer(SSN, Address, Phone, Name, Branch#, Username)" +
                                      "VALUES('" + ssnTxt.Text + "', '" + addressTxt.Text + "', '" + phoneTxt.Text + "', '" + nameTxt.Text +
                                      "', NULL, '" + usernameTxt.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Account registered successfully!");
                new login().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Passowrds are not the same");
        }

        private void registerLbl_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void registerCustomer_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ssnTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirmTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();
        }
    }
}
