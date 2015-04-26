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
    public partial class WorkHour : Form
    {
        public WorkHour()
        {
            InitializeComponent();
        }

        private void Department_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Department m = new Department();
            m.Show();
        }

        private void Employee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Employee m = new Employee();
            m.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Equipment m = new Equipment();
            m.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LostFound m = new LostFound();
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
            OrderPlaced m = new OrderPlaced();
            m.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UsageTime m = new UsageTime();
            m.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Vendor m = new Vendor();
            m.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();

            try
            {

            if(rbDisplay.Checked)
            { 
            string txt = txtEMployeeID.Text;
                
            string query = "select * from workhours where employeeid=@eid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@eid", txt));

            SqlDataReader dr = cmd.ExecuteReader();

            using (dr)
            {
                DataTable table = new DataTable();
                table.Load(dr);
                dgvworkhour.DataSource = table;
            }
            
            dr.Close();
            dr.Dispose();

            }
            else
            {
                string sqlQuery = "INSERT into Workhours values (@eid, @ecin,@ecout)";
                SqlCommand s = new SqlCommand(sqlQuery, con);
                string cin = dtClockIn.Value.ToShortDateString() +" " + txtclockin.Text;
                string cout = dtClockIn.Value.ToShortDateString() +" " + txtclockout.Text;

                
                s.Parameters.AddWithValue("@eid", txtEMployeeID.Text);
                s.Parameters.AddWithValue("@ecin", cin);
                s.Parameters.AddWithValue("@ecout", cout);

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
                MessageBox.Show("Some problem may have occurred in SQL! Please check your inputs\n"+ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void WorkHour_Load(object sender, EventArgs e)
        {
            rbDisplay.Select();

        }

        private void rbDisplay_CheckedChanged(object sender, EventArgs e)
        {
            txtEMployeeID.Text = "";
            txtclockout.Text = "";
            txtclockin.Text = "";
            btnDisplay.Text = "Display";

            SqlDataAdapter da = new SqlDataAdapter("Select * from employee", Properties.Settings.Default.connection);

            DataTable dt = new DataTable();
            da.Fill(dt);

            AutoCompleteStringCollection autoSourceCollection1 = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                autoSourceCollection1.Add(row["employeeid"].ToString()); //assuming required data is in first column 
            }

            txtEMployeeID.AutoCompleteCustomSource = autoSourceCollection1;
            txtEMployeeID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEMployeeID.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtclockin.Text = "";
            txtclockout.Text = "";
            txtEMployeeID.Text = "";
            btnDisplay.Text = "Add";
            dgvworkhour.DataSource = null;
        }
    }
}
