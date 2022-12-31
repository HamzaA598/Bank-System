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
    public partial class AddBank : Form
    {
        public AddBank()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBank_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "INSERT INTO Bank (Name, Address, code) VALUES('" + bankNameTxt.Text + "', '" + bankAddressTxt.Text + "', '" + bankCodeTxt.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Bank has been added successfully!");
            new adminOptions().Show();
            this.Hide();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new adminOptions().Show();
            this.Hide();
        }
    }
}
