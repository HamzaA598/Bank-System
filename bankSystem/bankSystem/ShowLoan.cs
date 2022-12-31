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
    public partial class ShowLoan : Form
    {
        public ShowLoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowLoan_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-S7OU5UD;Initial Catalog=bankSystem;Integrated Security=True");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("Select Loan_Amount, Loan#, Loan_Type, Branch#, cust.SSN, cust.Name as 'customer name'," +
                                                   " empID, Emp.Name as 'employee name' from Loan left join (select Name, ID from Employee) as Emp on Loan.empID = Emp.ID" +
                                                   " left join(select Name, SSN from customer) as cust on Loan.SSN = cust.SSN", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "customers data");
            loansData.DataSource = ds.Tables[0];
            sc.Close();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            new employeeOptions().Show();
            this.Hide();
        }
    }
}