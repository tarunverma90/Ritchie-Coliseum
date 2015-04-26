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
    public partial class UsageTime : Form
    {
        public UsageTime()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();

            try
            { 
            if(rbDisplay.Checked)
            { 
            string txt = txtMemberID.Text;

            string query = "select * from uses where universityid=@uid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@uid", txt));

            SqlDataReader dr = cmd.ExecuteReader();

            using (dr)
            {
                DataTable table = new DataTable();
                table.Load(dr);
                dgvUsageTime.DataSource = table;
            }
           
            dr.Close();
            dr.Dispose();
            }
            else
            {
                

                string sqlQuery = "INSERT into uses values (@usage, @uid,@eid)";
                SqlCommand s = new SqlCommand(sqlQuery, con);
                s.Parameters.AddWithValue("@usage", DateTime.Now.ToString());
                s.Parameters.AddWithValue("@uid", txtMemberID.Text);
                s.Parameters.AddWithValue("@eid", txtEquipmentid.Text);
               
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
                MessageBox.Show("Some problem may have occurred in SQL! Please checked your inputs\n"+ex.Message);
            }
            finally
            { 
                 con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Department m = new Department();
            m.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            Vendor m = new Vendor();
            m.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            WorkHour m = new WorkHour();
            m.Show();
        }

        private void UsageTime_Load(object sender, EventArgs e)
        {
            rbDisplay.Select();
        }

        private void rbDisplay_CheckedChanged(object sender, EventArgs e)
        {
            txtMemberID.Text = "";
            txtEquipmentid.Text = "";
            
            btnShow.Text = "Show";
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtEquipmentid.Text = "";
            txtMemberID.Text = "";
            btnShow.Text = "Add";
            dgvUsageTime.DataSource = null;
        }
    }
}
