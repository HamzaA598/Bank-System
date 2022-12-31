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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            string s = "select ID from Employee where Username = '" + login.employeeUsername + "'";
            SqlCommand cmd = new SqlCommand();
            SqlCommand command = new SqlCommand();
            cmd.Connection = connection;
            command.Connection = connection;
            connection.Open();
            cmd.CommandText = s;
            int id = (int)cmd.ExecuteScalar();
            string s2 = "select Branch# From Employee where ID = " + id;
            cmd.CommandText = s2;
            int branch = (int)cmd.ExecuteScalar();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Deals_With WHERE SSN='" + customerSSNTxt.Text + "' AND ID='" + id + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() != "1")
            {
                command.CommandText = "INSERT INTO Deals_With (SSN, ID)  VALUES('" + customerSSNTxt.Text + "', '" + id + "')";
                command.ExecuteNonQuery();
            }
            command.CommandText = "UPDATE Customer SET Branch# = " + branch + ", empID = " + id + " where SSN = " + customerSSNTxt.Text;
            command.ExecuteNonQuery();
            command.CommandText = "INSERT INTO Account (Balance, Type, SSN)" +
                                  " VALUES(" + Int32.Parse(balanceTxt.Text) + ", '" + typeCmb.Text + "', '" + customerSSNTxt.Text + "')";
            command.ExecuteNonQuery();

            string s3 = "select Account# From Account " +
                "where SSN = '" + customerSSNTxt.Text + "' and Type = '" + typeCmb.Text + "' and Balance = " + Int32.Parse(balanceTxt.Text);

            cmd.CommandText = s3;
            int accountID = (int)cmd.ExecuteScalar();

            connection.Close();

            MessageBox.Show("Customer Added Successfully!, your Account number is " + accountID);
            new employeeOptions().Show();
            this.Hide();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new employeeOptions().Show();
            this.Hide();
        }
    }
}
