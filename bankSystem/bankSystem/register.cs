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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void registerCustomerBtn_Click(object sender, EventArgs e)
        {
            new registerCustomer().Show();
            this.Hide();
        }

        private void registerEmployeeBtn_Click(object sender, EventArgs e)
        {
            new registerEmployee().Show();
            this.Hide();
        }
    }
}
