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
    public partial class LostFound : Form
    {
        public LostFound()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Department m = new Department();
            m.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Employee m = new Employee();
            m.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Equipment m = new Equipment();
            m.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Member m = new Member();
            m.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderPlaced m = new OrderPlaced();
            m.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UsageTime m = new UsageTime();
            m.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnOptions_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();

            try
            { 
            if(rbDisplay.Checked)
            { 
            
            string txt = txtUniversityID.Text;

            string query = "select * from lostandfound where universityid=@uid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@uid", txt));

            SqlDataReader dr = cmd.ExecuteReader();

            using (dr)
            {
                DataTable table = new DataTable();
                table.Load(dr);
                dgvLostFound.DataSource = table;
            }
            //while (dr.Read())
            //{
            //    txtItemDescription.Text = dr["itemdescription"].ToString();
            //    txtItemLost.Text = dr["itemLost"].ToString();
            //    txtStatus.Text = dr["status"].ToString();
            //    txtType.Text = dr["type"].ToString();
            //    dtdateFound.Text = dr["dateFound"].ToString();
            //    dtDateLost.Text = dr["dateLost"].ToString();

            //}
            dr.Close();
            dr.Dispose();

            }
            else
            {
                
                string sqlQuery = "INSERT into lostandfound values (@uid, @itemlost,@itemdesc,@datelost,@datefound,@type,@status)";
                SqlCommand s = new SqlCommand(sqlQuery, con);
                s.Parameters.AddWithValue("@uid", txtUniversityID.Text);
                s.Parameters.AddWithValue("@itemlost", txtItemLost.Text);
                s.Parameters.AddWithValue("@itemdesc", txtItemDescription.Text);
               
                if (txtType.Text == "L" && txtStatus.Text == "NR")
                {
                    s.Parameters.AddWithValue("@datelost", dtDateLost.Value);
                    s.Parameters.AddWithValue("@datefound", System.Convert.DBNull);
                }
                else if (txtType.Text == "L" && txtStatus.Text == "R")
                {
                    s.Parameters.AddWithValue("@datelost", dtDateLost.Value);
                    s.Parameters.AddWithValue("@datefound", dtdateFound.Value);
                }
                else if (txtType.Text == "F" && txtStatus.Text == "NR")
                {
                    s.Parameters.AddWithValue("@datelost", System.Convert.DBNull);
                    s.Parameters.AddWithValue("@datefound", dtdateFound.Value);
                }
                else 
                {
                    s.Parameters.AddWithValue("@datelost", dtDateLost.Value);
                    s.Parameters.AddWithValue("@datefound", dtdateFound.Value);
                }
               
                s.Parameters.AddWithValue("@type", txtType.Text);
                s.Parameters.AddWithValue("@status", txtStatus.Text);
                
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

        private void LostFound_Load(object sender, EventArgs e)
        {
            rbDisplay.Select();
        }

        private void rbAddDetails_CheckedChanged(object sender, EventArgs e)
        {
            btnOptions.Text = "Add";
            dgvLostFound.DataSource = null;
        }

        private void rbDisplay_CheckedChanged(object sender, EventArgs e)
        {
            btnOptions.Text = "Display";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
