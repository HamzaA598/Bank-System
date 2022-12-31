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
    public partial class customerOptions : Form
    {
        public customerOptions()
        {
            InitializeComponent();
        }

        private void addBankBtn_Click(object sender, EventArgs e)
        {
            new depositMoney().Show();
            this.Hide();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            new withdrawMoney().Show();
            this.Hide();
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            new RequestLoan().Show();
            this.Hide();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            new StartLoan().Show();
            this.Hide();
        }

        private void customerOptions_Load(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
