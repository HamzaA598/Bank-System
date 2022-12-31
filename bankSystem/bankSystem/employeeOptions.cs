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
    public partial class employeeOptions : Form
    {
        public employeeOptions()
        {
            InitializeComponent();
        }

        private void showCustomersBtn_Click(object sender, EventArgs e)
        {
            new showCustomerList().Show();
            this.Hide();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            new AddCustomer().Show();
            this.Hide();
        }

        private void showLoansBtn_Click(object sender, EventArgs e)
        {
            new ShowLoan().Show();
            this.Hide();
        }

        private void loanOptionsBtn_Click(object sender, EventArgs e)
        {
            new loanOperations().Show();
            this.Hide();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            new Select().Show();
            this.Hide();
        }
    }
}
