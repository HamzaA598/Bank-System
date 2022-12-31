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
    public partial class AddBranch : Form
    {

        public AddBranch()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void AddBranch_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Code FROM Bank", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                bankCodeTxt.Items.Add(dr.GetValue(0));
            }

            con.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "INSERT INTO Branch (Address, code)  VALUES('" + addressTxt.Text + "', '" + bankCodeTxt.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Branch has been added successfully!");
            new adminOptions().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new adminOptions().Show();
            this.Hide();
        }
    }
}
