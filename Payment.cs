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

namespace Assignment
{
    public partial class Payment : Form
    {
        SignInSuccessfull s;
        string userName;
        int id = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");
        public Payment(string username,SignInSuccessfull form)
        {
            InitializeComponent();
            s = form;
            userName = username;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(Paid) AS count FROM Appointment where Patient = @username and Paid = 'No'", con);
            cmd3.Parameters.AddWithValue("@username", userName);
            con.Open();
            SqlDataReader dr2 = cmd3.ExecuteReader();
            dr2.Read();
            int unpaid = Convert.ToInt32(dr2["count"]);
            con.Close();
            if(unpaid > 0)
            {
                label5.Visible = false;
                panel1.Visible = true;
                SqlCommand cmd1 = new SqlCommand("SELECT Id, Patient, Doctor, CLinic, Date, Time, Paid FROM Appointment where Patient = @username and Paid = 'No'", con);
                cmd1.Parameters.AddWithValue("@username", userName);
                con.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();
                lblPatientValue.Text = dr["Patient"].ToString();
                lblClinicValue.Text = dr["Clinic"].ToString();
                lblDoctorValue.Text = dr["Doctor"].ToString();
                lblDateValue.Text = Convert.ToDateTime(dr["Date"].ToString()).ToString("yy-MM-dd");
                lblTimeValue.Text = Convert.ToDateTime(dr["Time"].ToString()).ToString("HH:mm:ss");
                id = Convert.ToInt32(dr["Id"]);
                dr.Close();

                SqlCommand cmd2 = new SqlCommand(@"SELECT DoctorFees From DoctorDetails where DoctorName=@Doctor", con);
                cmd2.Parameters.AddWithValue("@Doctor", lblDoctorValue.Text);
                SqlDataReader d = cmd2.ExecuteReader();
                d.Read();
                lblFeesValue.Text = d["DoctorFees"].ToString();
                con.Close();
            } 
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Appointment SET Paid='Yes' Where Id=" + id, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Receipt r = new Receipt(userName,this);
            this.Close();
            r.Show();
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.Show();
        }
    }
}
