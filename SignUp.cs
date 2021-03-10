using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class SignUp : Form
    {
        LogIn mainForm;
        public SignUp(LogIn form)
        {
            InitializeComponent();
            mainForm = form;
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fName;
            string lName;
            string email;
            string password;
            string gender;
            DateTime dob;
            string phone;
            string address;
            string city;
            if (txtFirstName.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your first name", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtLastName.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your last name", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtFirstName.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your first name", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword.Text.Length<5)
            {
                DialogResult dr;
                dr = MessageBox.Show("Your Password must contain atleast 5 characters", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtConfirmPassword.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your password again to verify", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtConfirmPassword.Text!=txtPassword.Text)
            {
                DialogResult dr;
                dr = MessageBox.Show("Your Password does not match", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!rdFemale.Checked && !rdMale.Checked)
            {
                DialogResult dr;
                dr = MessageBox.Show("Please select your gender", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tpDOB.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your date-of-birth", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtFirstName.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your first name", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPhoneNumber.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your phone number", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPhoneNumber.Text.Length!=10)
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter 10 digits", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtAddress.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your address", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCity.Text.Equals(""))
            {
                DialogResult dr;
                dr = MessageBox.Show("Please enter your city", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               // MessageBox.Show("Here", "Here", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fName = txtFirstName.Text;
                lName = txtLastName.Text;
                email = txtEmail.Text;
                password = txtPassword.Text;
                if (rdMale.Checked)
                    gender = "Male";
                else
                    gender = "Female";
                dob = tpDOB.Value;
                phone = txtPhoneNumber.Text;
                address = txtAddress.Text;
                city = txtCity.Text;

                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand("INSERT INTO Patient(fName,lName,Email,Password,Gender,DOB,PhoneNo,Address,City) VALUES(@fName,@lName,@email,@password,@gender,@dob,@phone,@address,@city)", con1);
                cmd2.Parameters.AddWithValue("@fName", fName);
                cmd2.Parameters.AddWithValue("@lName", lName);
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@password", password);
                cmd2.Parameters.AddWithValue("@gender", gender);
                cmd2.Parameters.AddWithValue("@dob", dob);
                cmd2.Parameters.AddWithValue("@phone", phone);
                cmd2.Parameters.AddWithValue("@address", address);
                cmd2.Parameters.AddWithValue("@city", city);
                con1.Open();
                cmd2.ExecuteNonQuery();
                con1.Close();
                

                FillMedicalHistory f = new FillMedicalHistory(this);
                this.Hide();
                f.Show();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
