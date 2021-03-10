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
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                SqlCommand cmd1 = new SqlCommand("SELECT Count(*) as COUNT FROM Patient where Email=@username and Password=@password", con);
                cmd1.Parameters.AddWithValue("@username", username);
                cmd1.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();
                int count = Convert.ToInt32(dr["COUNT"]);
                dr.Close();
                con.Close();

                if(count != 1 )
                {
                    MessageBox.Show("Invalid Credentials");
                    lblError.Visible = true;
                }
                else
                {
                    SignInSuccessfull form = new SignInSuccessfull(username, this);
                    this.Hide();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp form2 = new SignUp(this);
            this.Hide();
            form2.Show();
        }
    }
}
