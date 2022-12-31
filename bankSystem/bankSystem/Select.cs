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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void noCustomerBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Branch where Branch#  not in (select Branch# from Customer)", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "customer");
            dataGridView1.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void noEmployeeBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Branch where Branch#  not in (select Branch# from Employee)", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "table name");
            dataGridView1.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void employeeMaxLoanBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Employee where ID = (select max(sub.empID) from(select top 1 empID, count(*) as num from Loan group by empID order by num desc) as sub)", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "table name");
            dataGridView1.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void customerMaxLoanBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Customer where SSN = (select max(sub.SSN) from(select top 1 SSN, count(*) as num from Loan group by SSN order by num desc) as sub)", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "table name");
            dataGridView1.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void noLoanCustomerBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Customer where SSN  not in (select SSN from Loan)", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "table name");
            dataGridView1.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void customerDataBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select Customer.SSN, Customer.Address, Customer.Phone, Customer.Name, Customer.Branch#, Customer.Username, num.numberOfEmps from Customer join (select Deals_With.SSN, count(*) as numberOfEmps from Deals_With group by Deals_With.SSN) as num on Customer.SSN = num.SSN", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "table name");
            dataGridView1.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new employeeOptions().Show();
            this.Hide();
        }
    }
}
