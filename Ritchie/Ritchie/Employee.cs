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

namespace Ritchie
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            rbDisplayEmployee.Select();
                       
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            WorkHour m = new WorkHour();
            m.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Vendor m = new Vendor();
            m.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UsageTime m = new UsageTime();
            m.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderPlaced m = new OrderPlaced();
            m.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Department m=new Department();
            m.Show();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Member m = new Member();
            m.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LostFound m = new LostFound();
            m.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Equipment m = new Equipment();
            m.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnEmpoyeeOptions_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();

            try
            {

             if (rbDisplayEmployee.Checked)
            {
                string txt = cbEmployeeName.Text;

                string query = "select * from employee where employeename=@ename";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@ename", txt));

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtEmployeeID.Text = dr["employeeid"].ToString();
                    txtEmployeeAddess.Text = dr["employeeaddress"].ToString();
                    txtEmployeePaySCale.Text = dr["emppayscale"].ToString();
                    txtEMployeePhone.Text = dr["employeePhone"].ToString();
                    txtEmployeeTitle.Text = dr["employeeTitle"].ToString();
                    txtManagerID.Text = dr["managerid"].ToString();
                    txtDepartmentID.Text = dr["departmentid"].ToString();
                    dtEmployeeDOb.Text = dr["employeeDOB"].ToString();
                }
                dr.Close();
                dr.Dispose();
            }
            else
            {
                string sqlQuery = "INSERT into employee values (@eid, @ename,@did,@mid,@eTitle,@eadd,@eDOB,@ephone,@epay)";
                SqlCommand s = new SqlCommand(sqlQuery, con);
                s.Parameters.AddWithValue("@eid", txtEmployeeID.Text);
                s.Parameters.AddWithValue("@ename", cbEmployeeName.Text);
                s.Parameters.AddWithValue("@did", txtDepartmentID.Text);
                s.Parameters.AddWithValue("@mid", txtManagerID.Text);
                s.Parameters.AddWithValue("@eTitle", txtEmployeeTitle.Text);
                s.Parameters.AddWithValue("@eadd", txtEmployeeAddess.Text);
                s.Parameters.AddWithValue("@eDOB", dtEmployeeDOb.Value);
                s.Parameters.AddWithValue("@ephone", txtEMployeePhone.Text);
                s.Parameters.AddWithValue("@epay", txtEmployeePaySCale.Text);


                int i = s.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Record Inserted");
                }
                else
                {
                    MessageBox.Show("May Be Some Problem Occure !");
                }
            }
           }
            catch(Exception ex)
            {
                MessageBox.Show("Some problem may have occured in SQL! Please checked your inputs\n"+ex.Message);
            }
            finally
            { 
            con.Close();
            }
        }

        private void rbDisplayEmployee_CheckedChanged(object sender, EventArgs e)
        {
            btnEmpoyeeOptions.Text = "Display";

            SqlDataAdapter da = new SqlDataAdapter("Select * from employee", Properties.Settings.Default.connection);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbEmployeeName.Items.Add(dt.Rows[i]["employeename"]);
            }
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();


            foreach (DataRow row in dt.Rows)
            {
                autoSourceCollection.Add(row["employeename"].ToString()); //assuming required data is in first column 
            }

            cbEmployeeName.AutoCompleteCustomSource = autoSourceCollection;
            cbEmployeeName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEmployeeName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void rbAddEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtEmployeeAddess.Text = "";
            txtEmployeeID.Text = "";
            txtEmployeePaySCale.Text = "";
            txtEMployeePhone.Text = "";
            txtEmployeeTitle.Text = "";
            txtManagerID.Text = "";
            cbEmployeeName.Items.Clear();
            cbEmployeeName.Text = "";
            btnEmpoyeeOptions.Text = "Add";
            txtDepartmentID.Text = "";
        }
    }
}
