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
    public partial class SignInSuccessfull : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");
        LogIn mainForm;
        string userName;
        public SignInSuccessfull(string username, LogIn loginForm)
        {
            InitializeComponent();
            userName = username;
            mainForm = loginForm;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void SignInSuccessfull_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT fName, lName, Email, Password, DOB, PhoneNo, Address, City FROM Patient where Email = @username", con);
            cmd1.Parameters.AddWithValue("@username",userName);
            con.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            dr.Read();
            lblFirstnameValue.Text = dr["fName"].ToString();
            lblLastnameValue.Text = dr["lName"].ToString();
            lblEmailValue.Text = dr["Email"].ToString();
            lblDOBValue.Text = dr["DOB"].ToString();
            lblPhonenoValue.Text = dr["PhoneNo"].ToString();
            lblAddressValue.Text = dr["Address"].ToString();
            lblCityValue.Text = dr["City"].ToString();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void showMedicalHistroyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMedicalHistory s = new ShowMedicalHistory(userName, this);
            this.Hide();
            s.Show();
            
        }

        private void clinicDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicDetails c = new ClinicDetails(this);
            this.Hide();
            c.Show();
        }

        private void doctorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorDetails d = new DoctorDetails(this);
            this.Hide();
            d.Show();

        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment(userName,this);
            this.Hide();
            a.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback(userName,this);
            this.Hide();
            f.Show();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment p = new Payment(userName,this);
            this.Hide();
            p.Show();
        }
    }
}
