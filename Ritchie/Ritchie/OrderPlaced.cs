using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritchie
{
    public partial class OrderPlaced : Form
    {
        public OrderPlaced()
        {
            InitializeComponent();
        }

        private void OrderPlaced_Load(object sender, EventArgs e)
        {
            rbDisplayOrder.Select();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Department_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            UsageTime m = new UsageTime();
            m.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Vendor m = new Vendor();
            m.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            if (rbDisplayOrder.Checked)
            {
                string txt = txtOrderId.Text;

                string query = "select * from orderplaced where orderid=@oid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@oid", txt));

                SqlDataReader dr = cmd.ExecuteReader();

                
                while (dr.Read())
                {
                     
                    
                       
                    txtCost.Text = dr["Cost"].ToString();
                    txtDepartmentname.Text = dr["departmentID"].ToString();
                    txtDescription.Text = dr["description"].ToString();
                    txtQuantity.Text = dr["quantity"].ToString();
                    if (dr.GetBoolean(8) == Convert.ToBoolean(1))
                        txtStatus.Text="Deliverd";
                    else
                        txtStatus.Text="Not Delivered";

                    txtVendorName.Text = dr["vendorID"].ToString();
                    txtEquipmentName.Text = dr["equipmentID"].ToString();
                    dtDatePlaced.Text = dr["datePlaced"].ToString();
                }
                dr.Close();
                dr.Dispose();
            }
            else
            {
                Boolean b = new Boolean();

                if (txtStatus.Text == "Yes")
                    b = Convert.ToBoolean(1);
                else
                    b = Convert.ToBoolean(0);

                string sqlQuery = "INSERT into orderplaced values (@oid,@did,@eid,@vid,@dateplaced,@quantity,@cost,@description,@status)";
                SqlCommand s = new SqlCommand(sqlQuery, con);
                s.Parameters.AddWithValue("@oid", txtOrderId.Text);
                s.Parameters.AddWithValue("@did", txtDepartmentname.Text);
                s.Parameters.AddWithValue("@eid", txtEquipmentName.Text);
                s.Parameters.AddWithValue("@vid", txtVendorName.Text);
                s.Parameters.AddWithValue("@dateplaced", dtDatePlaced.Value);
                s.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text));
                s.Parameters.AddWithValue("@cost", Convert.ToDecimal(txtCost.Text));
                s.Parameters.AddWithValue("@description", txtDescription.Text);
                s.Parameters.AddWithValue("@status", b);


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

        private void txtDepartmentname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbDisplayOrder_CheckedChanged(object sender, EventArgs e)
        {
            txtCost.Text = "";
            txtDepartmentname.Text = "";
            txtDescription.Text = "";
            txtEquipmentName.Text = "";
            txtOrderId.Text = "";
            txtQuantity.Text = "";
            txtStatus.Text = "";
            txtVendorName.Text = "";
            dtDatePlaced.Text = "";
            btnOptions.Text = "Display";
        }

        private void rbAddOrder_CheckedChanged(object sender, EventArgs e)
        {
            txtCost.Text = "";
            txtDepartmentname.Text = "";
            txtDescription.Text = "";
            txtEquipmentName.Text = "";
            txtOrderId.Text = "";
            txtQuantity.Text = "";
            txtStatus.Text = "";
            txtVendorName.Text = "";
            dtDatePlaced.Text = DateTime.Today.ToString();
            btnOptions.Text = "Add";
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
