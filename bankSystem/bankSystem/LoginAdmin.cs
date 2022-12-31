using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankSystem
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTxt.Text == "admin" && passwordTxt.Text == "admin")
            {
                MessageBox.Show("Successfully logged in!");
                new adminOptions().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid username or password!");
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("admin username: admin\nadmin password: admin");
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
