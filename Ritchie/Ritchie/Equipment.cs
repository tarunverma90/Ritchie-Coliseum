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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            rbDisplayEquipment.Select();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbEquipmentName.Items.Clear();
            cbEquipmentName.Text = "";
            txtEquiomentID.Text="";
            txtEquipmentDescription.Text="";
            txtEquipmentQuantity.Text = "";
            txtEquipmentType.Text = "";
            txtminQuantity.Text = "";

            btnDisplay.Text = "Add";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LostFound m = new LostFound();
            m.Show();
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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Member m = new Member();
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();
            try
            { 
            if(rbDisplayEquipment.Checked)
            { 
            string txt = cbEquipmentName.Text;

            string query = "select * from equipment where equipmentdescription=@equip";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@equip", txt));

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtEquiomentID.Text = dr["equipmentid"].ToString();
                txtEquipmentDescription.Text = dr["equipmentdescription"].ToString();
                txtEquipmentQuantity.Text = dr["equipmentquantity"].ToString();
                txtEquipmentType.Text = dr["equipmenttype"].ToString();
                txtminQuantity.Text = dr["equipmentminquantity"].ToString();

            }
            dr.Close();
            dr.Dispose();
            }
            else
            {
                string sqlQuery = "INSERT into equipment values (@eid, @ename,@etype,@equantity,@edescription,@emin)";
                SqlCommand s = new SqlCommand(sqlQuery, con);
                s.Parameters.AddWithValue("@eid", txtEquiomentID.Text);
                s.Parameters.AddWithValue("@ename", cbEquipmentName.Text);
                s.Parameters.AddWithValue("@etype", txtEquipmentType.Text);
                s.Parameters.AddWithValue("@equantity", txtEquipmentQuantity.Text);
                s.Parameters.AddWithValue("@edescription", txtEquipmentDescription.Text);
                s.Parameters.AddWithValue("@emin", txtminQuantity.Text);
                
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

        private void rbDisplayEquipment_CheckedChanged(object sender, EventArgs e)
        {
            txtEquiomentID.Text = "";
            txtEquipmentDescription.Text = "";
            txtEquipmentQuantity.Text = "";
            txtEquipmentType.Text = "";
            txtminQuantity.Text = "";
            btnDisplay.Text = "Display";

            SqlDataAdapter da = new SqlDataAdapter("Select * from equipment", Properties.Settings.Default.connection);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbEquipmentName.Items.Add(dt.Rows[i]["EquipmentDescription"]);
            }
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();


            foreach (DataRow row in dt.Rows)
            {
                autoSourceCollection.Add(row["EquipmentDescription"].ToString()); //assuming required data is in first column 
            }

            cbEquipmentName.AutoCompleteCustomSource = autoSourceCollection;
            cbEquipmentName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEquipmentName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
        }

        
    }
}
