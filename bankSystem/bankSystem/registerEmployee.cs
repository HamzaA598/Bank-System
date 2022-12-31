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
    public partial class registerEmployee : Form
    {

        public registerEmployee()
        {
            InitializeComponent();
        }

        private void registerEmployee_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Branch# FROM Branch", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                branchNumberCmb.Items.Add(dr.GetValue(0));
            }

            con.Close();
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
                                      "VALUES('" + usernameTxt.Text + "', '" + passwordTxt.Text + "', 'Employee')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Employee(Name, Branch#, Username)" +
                                      "VALUES('" + nameTxt.Text + "', '" + branchNumberCmb.Text + "', '" + usernameTxt.Text + "')";
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();
        }
    }
}
