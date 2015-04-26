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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Employee m = new Employee();
            m.Show();
        }

        private void btndepartmentaction_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();
            try
            {
                      
                if (rbdisplay.Checked)
                {
                    string txt = cbdepartmentname.Text;

                    string query = "select * from department where departmentname=@dep";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@dep", txt));

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txtdepartmentid.Text = dr["departmentid"].ToString();
                        txtdepartmentlocation.Text = dr["departmentlocation"].ToString();
                        txtdepartmentphone.Text = dr["departmentphone"].ToString();

                    }
                    dr.Close();
                    dr.Dispose();

                }
                else
                {
                    string sqlQuery = "INSERT into department values (@did, @dname,@dloc,@dphone)";
                    SqlCommand s = new SqlCommand(sqlQuery, con);
                    s.Parameters.AddWithValue("@did", txtdepartmentid.Text);
                    s.Parameters.AddWithValue("@dname", cbdepartmentname.Text);
                    s.Parameters.AddWithValue("@dloc", txtdepartmentlocation.Text);
                    s.Parameters.AddWithValue("@dphone", txtdepartmentphone.Text);

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
                MessageBox.Show("May be some Problem occured in SQL! Please check your input\n"+ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void Department_Load(object sender, EventArgs e)
        {
            rbdisplay.Select();
            
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
            LostFound m = new LostFound();
            m.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderPlaced m = new OrderPlaced();
            m.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UsageTime m = new UsageTime();
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

        private void rbdisplay_CheckedChanged(object sender, EventArgs e)
        {
            btndepartmentaction.Text = "Display";
            txtdepartmentid.Text = "";
            txtdepartmentlocation.Text = "";
            txtdepartmentphone.Text = "";
            cbdepartmentname.Items.Clear();

            SqlDataAdapter da = new SqlDataAdapter("Select * from department", Properties.Settings.Default.connection);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbdepartmentname.Items.Add(dt.Rows[i]["departmentname"]);
            }

            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();


            foreach (DataRow row in dt.Rows)
            {
                autoSourceCollection.Add(row["departmentname"].ToString()); //assuming required data is in first column 
            }

            cbdepartmentname.AutoCompleteCustomSource = autoSourceCollection;
            cbdepartmentname.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbdepartmentname.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void rbinsert_CheckedChanged(object sender, EventArgs e)
        {
            txtdepartmentid.Text = "";
            txtdepartmentlocation.Text = "";
            txtdepartmentphone.Text="";
            cbdepartmentname.Items.Clear();
            cbdepartmentname.Text = "";
            btndepartmentaction.Text = "Add";
        }
    }
}
