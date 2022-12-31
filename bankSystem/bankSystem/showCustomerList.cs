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
    public partial class showCustomerList : Form
    {
        public showCustomerList()
        {
            InitializeComponent();
        }

        private void customersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showCustomerList_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Customer", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "customers data");
            customersData.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new employeeOptions().Show();
            this.Hide();
        }
    }
}
