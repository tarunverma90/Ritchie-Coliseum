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
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
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
            UsageTime m = new UsageTime();
            m.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            WorkHour m = new WorkHour();
            m.Show();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            rbdisplayvendor.Select();
        }

        private void btnoptions_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();

            try
            { 
            if(rbdisplayvendor.Checked)
            { 
            string txt = cbVendorName.Text;

            string query = "select * from vendor where vendorname=@vname";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@vname", txt));

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtVendorAddress.Text = dr["vendoraddress"].ToString();
                txtVendorID.Text = dr["vendorid"].ToString();
                txtVendorPhone.Text = dr["vendorPhone"].ToString();
               
            }
            dr.Close();
            dr.Dispose();
            }
            else
            {
                string sqlQuery = "INSERT into vendor values (@vid, @vname,@vphone,@vaddress)";
                SqlCommand s = new SqlCommand(sqlQuery, con);
                s.Parameters.AddWithValue("@vid", txtVendorID.Text);
                s.Parameters.AddWithValue("@vname", cbVendorName.Text);
                s.Parameters.AddWithValue("@vphone", txtVendorPhone.Text);
                s.Parameters.AddWithValue("@vaddress", txtVendorAddress.Text);
               
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

        private void rbdisplayvendor_CheckedChanged(object sender, EventArgs e)
        {
            txtVendorAddress.Text = "";
            txtVendorID.Text = "";
            txtVendorPhone.Text = "";
            cbVendorName.Text = "";
            btnoptions.Text = "Display";

            SqlDataAdapter da = new SqlDataAdapter("Select * from vendor", Properties.Settings.Default.connection);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbVendorName.Items.Add(dt.Rows[i]["vendorname"]);
            }

            AutoCompleteStringCollection autoSourceCollection1 = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                autoSourceCollection1.Add(row["vendorname"].ToString()); //assuming required data is in first column 
            }

            cbVendorName.AutoCompleteCustomSource = autoSourceCollection1;
            cbVendorName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbVendorName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void rbAddVendor_CheckedChanged(object sender, EventArgs e)
        {
            txtVendorAddress.Text = "";
            txtVendorID.Text = "";
            txtVendorPhone.Text = "";
            cbVendorName.Items.Clear();
            cbVendorName.Text = "";
            btnoptions.Text = "Add";
        }
    }
}
