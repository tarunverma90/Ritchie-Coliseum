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
using System.IO;

namespace Ritchie
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            
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
            int flag = 0;
            SqlDataReader dr = null;

            if(txtName.Text !="" && txtMemberID.Text != "")
            {
                MessageBox.Show("Can search only on one criteria , select member name or member id; Press clear record");
                flag = 1;
            }
            if(flag==0)
            { 
            if (txtName.Text != "")
            {
                string txt = txtName.Text;

                string query = "select * from member where membername=@name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@name", txt));
                dr = cmd.ExecuteReader();
            }
            
            if(txtMemberID.Text != "")
            {
                string txt = txtMemberID.Text;

                string query = "select * from member where universityid=@uid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@uid", txt));
                dr = cmd.ExecuteReader();
            }
            while (dr.Read())
            {
                
                txtMemberID.Text = dr["universityid"].ToString();
                txtaddress.Text = dr["memberaddress"].ToString();
                txtComments.Text = dr["comments"].ToString();
                txtmemberphno.Text = dr["memberPhone"].ToString();
                if (dr.GetBoolean(8) == Convert.ToBoolean(1))
                    txtpremiumservice.Text = "Yes";
                else
                    txtpremiumservice.Text = "No";
                dtDOB.Text = dr["memberDOB"].ToString();
                dtexpirydate.Text = dr["membershipExpiryDate"].ToString();
                txtName.Text = dr["memberName"].ToString();
              
                byte[] barrImg = (byte[])dr["memberImage"];


                string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strfn,
                                  FileMode.CreateNew, FileAccess.Write);
                fs.Write(barrImg, 0, barrImg.Length);
                fs.Flush();
                fs.Close();
                pbImage.Image = Image.FromFile(strfn);
               }
            dr.Close();
            dr.Dispose();
            }
            }
            else if(rbAddMember.Checked)
            {

                Boolean b = new Boolean();

                if (txtpremiumservice.Text == "Yes")
                    b = Convert.ToBoolean(1);
                else
                    b = Convert.ToBoolean(0);

                if (txtImagePath.Text == "")
                {
                    string sqlQuery = "INSERT into member(universityID, memberName, memberDOB, memberPhone, memberAddress, membershipExpiryDate, Comments,premiumService) values (@uid, @mname,@mDOB,@mPhone,@mAddress,@memExpDate,@comment,@preser)";
                    SqlCommand s = new SqlCommand(sqlQuery, con);
                    s.Parameters.AddWithValue("@uid", txtMemberID.Text);
                    s.Parameters.AddWithValue("@mname", txtName.Text);
                    s.Parameters.AddWithValue("@mDOB", dtDOB.Value);
                    s.Parameters.AddWithValue("@mPhone", txtmemberphno.Text);
                    s.Parameters.AddWithValue("@mAddress", txtaddress.Text);
                    s.Parameters.AddWithValue("@memExpDate", dtexpirydate.Value);
                    s.Parameters.AddWithValue("@comment", txtComments.Text);
                    s.Parameters.AddWithValue("@preser", b);



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
                else
                {
                    FileInfo filImage = new FileInfo(txtImagePath.Text);
                    long m_lImageFileLength = filImage.Length;
                    FileStream fs = new FileStream(txtImagePath.Text, FileMode.Open,
                                      FileAccess.Read, FileShare.Read);
                    Byte[] m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
                    int iBytesRead = fs.Read(m_barrImg, 0,
                                     Convert.ToInt32(m_lImageFileLength));
                    fs.Close();

                    string sqlQuery = "INSERT into member values (@uid, @mname,@mDOB,@memberImage,@mPhone,@mAddress,@memExpDate,@comment,@preser)";
                    SqlCommand s = new SqlCommand(sqlQuery, con);
                    s.Parameters.AddWithValue("@uid", txtMemberID.Text);
                    s.Parameters.AddWithValue("@mname", txtName.Text);
                    s.Parameters.AddWithValue("@mDOB", dtDOB.Value);
                    s.Parameters.AddWithValue("@memberImage", m_barrImg);
                    s.Parameters.AddWithValue("@mPhone", txtmemberphno.Text);
                    s.Parameters.AddWithValue("@mAddress", txtaddress.Text);
                    s.Parameters.AddWithValue("@memExpDate", dtexpirydate.Value);
                    s.Parameters.AddWithValue("@comment", txtComments.Text);
                    s.Parameters.AddWithValue("@preser", b);



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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Employee m = new Employee();
            m.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Equipment m = new Equipment();
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
            LostFound m = new LostFound();
            m.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UsageTime m = new UsageTime();
            m.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnClearRecord_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtComments.Text = "";
            txtMemberID.Text = "";
            txtmemberphno.Text = "";
            txtName.Text = "";
            txtpremiumservice.Text = "";
            dtDOB.Value = DateTime.Today;
            dtexpirydate.Value = DateTime.Today;
            txtImagePath.Text = "";
            pbImage.Image = null;
        }

        private void rbDisplay_CheckedChanged(object sender, EventArgs e)
        {
            btnOptions.Text = "Display";
            btnOptions.Show();
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from member", Properties.Settings.Default.connection);

            DataTable dt = new DataTable();
            da.Fill(dt);

            AutoCompleteStringCollection autoSourceCollection1 = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                autoSourceCollection1.Add(row["universityid"].ToString()); //assuming required data is in first column 
            }

            txtMemberID.AutoCompleteCustomSource = autoSourceCollection1;
            txtMemberID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMemberID.AutoCompleteSource = AutoCompleteSource.CustomSource;


            AutoCompleteStringCollection autoSourceCollection2 = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                autoSourceCollection2.Add(row["memberName"].ToString()); //assuming required data is in first column 
            }

            txtName.AutoCompleteCustomSource = autoSourceCollection2;
            txtName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void rbAddMember_CheckedChanged(object sender, EventArgs e)
        {
            btnOptions.Text = "Add";
                    

        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnOptions.Text = "Update";
            label3.Show();
            txtImagePath.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.connection;
            con.Open();
            try
            { 
            FileInfo filImage = null;

            if (txtImagePath.Text == "")
            {
                MessageBox.Show("Enter image path");
                throw new FileNotFoundException();  
            }
          
            filImage = new FileInfo(txtImagePath.Text);
            long m_lImageFileLength = filImage.Length;
            FileStream fs = new FileStream(txtImagePath.Text, FileMode.Open,
                              FileAccess.Read, FileShare.Read);
            Byte[] m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
            int iBytesRead = fs.Read(m_barrImg, 0,
                             Convert.ToInt32(m_lImageFileLength));
            fs.Close();

            Boolean b = new Boolean();

            if (txtpremiumservice.Text == "Yes")
                b = Convert.ToBoolean(1);
            else
                b = Convert.ToBoolean(0);


            string sqlQuery = "Update member set membername=@mname,memberDOB=@mDOB,memberImage=@memberImage,memberPhone=@mPhone,memberAddress=@mAddress,membershipexpirydate=@memExpDate,comments=@comment,premiumservice=@preser where universityID=@uid";
            SqlCommand s = new SqlCommand(sqlQuery, con);
            s.Parameters.AddWithValue("@uid", txtMemberID.Text);
            s.Parameters.AddWithValue("@mname", txtName.Text);
            s.Parameters.AddWithValue("@mDOB", dtDOB.Value);
            s.Parameters.AddWithValue("@memberImage", m_barrImg);
            s.Parameters.AddWithValue("@mPhone", txtmemberphno.Text);
            s.Parameters.AddWithValue("@mAddress", txtaddress.Text);
            s.Parameters.AddWithValue("@memExpDate", dtexpirydate.Value);
            s.Parameters.AddWithValue("@comment", txtComments.Text);
            s.Parameters.AddWithValue("@preser", b);


            int i = s.ExecuteNonQuery();
            if (i >= 1)
            {
                MessageBox.Show("Record updated");
            }
            else
            {
                MessageBox.Show("May Be Some Problem Occured!");
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
    }
}
