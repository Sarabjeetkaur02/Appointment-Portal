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
    public partial class Feedback : Form
    {
        SignInSuccessfull s;
        string userName;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");
        public Feedback(string username,SignInSuccessfull form)
        {
            InitializeComponent();
            userName = username;
            s = form;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            s.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string radioFeedback = "";
            if (rdExcellent.Checked)
            {
                radioFeedback += "Excellent";
            }
            else if (rdVeryGood.Checked)
            {
                radioFeedback += "Very Good";
            }
            else if (rdGood.Checked)
            {
                radioFeedback += "Good";
            }
            else if (rdAverage.Checked)
            {
                radioFeedback += "Average";
            }
            else if (rdPoor.Checked)
            {
                radioFeedback += "Poor";
            }

            string textFeedback = "";

            if (txtFeedbaack.Text != "")
            {
                textFeedback += txtFeedbaack.Text;
            }
           
            SqlCommand cmd3 = new SqlCommand("INSERT INTO Feedback(Patient,radioFeedback,textFeedback) VALUES(@userName,@radioFeedback,@textFeedback)", con);
            cmd3.Parameters.AddWithValue("@userName", userName);
            cmd3.Parameters.AddWithValue("@radioFeedback", radioFeedback);
            cmd3.Parameters.AddWithValue("@textFeedback", textFeedback);
            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Thankyou for your feedback","ThnankYou Message",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }
    }
}
