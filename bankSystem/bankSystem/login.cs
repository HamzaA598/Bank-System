
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
    public partial class login : Form
    {
        public static string customerUsername = "";
        public static string customerPassword = "";
        public static string employeeUsername = "";
        public static string employeePassword = "";

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True"); 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserAccount WHERE username='" + usernameTxt.Text + "' AND password='" + passwordTxt.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT Type FROM UserAccount WHERE username='" + usernameTxt.Text + "' AND password='" + passwordTxt.Text + "'";
                string type = (string) command.ExecuteScalar();

                if(type == "Employee")
                {
                    employeeUsername = usernameTxt.Text;
                    employeePassword = passwordTxt.Text;
                    MessageBox.Show("logged in successfully!");
                    new employeeOptions().Show();

                }
                else if(type == "Customer")
                {
                    customerUsername = usernameTxt.Text;
                    customerPassword = passwordTxt.Text;
                    MessageBox.Show("logged in successfully!");
                    new customerOptions().Show();
                }
                connection.Close();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid username or password");

        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();
        }

        private void adminLbl_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show();
            this.Hide();
        }

        private void updateLbl_Click(object sender, EventArgs e)
        {
            new UpdateCustomer().Show();
            this.Hide();
        }
    }
}