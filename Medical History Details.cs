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
    public partial class ShowMedicalHistory : Form
    {
        SignInSuccessfull s;
        string eMail;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");

        public ShowMedicalHistory(string email,SignInSuccessfull signin)
        {
            InitializeComponent();
            eMail = email;
            s = signin;
        }

        private void ShowMedicalHistory_Load(object sender, EventArgs e)
        {
            SqlCommand cm4 = new SqlCommand("SELECT preAllergy,Allergy,Medication FROM MedicalHistory WHERE Email=@email ",con);
            cm4.Parameters.AddWithValue("@email",eMail);
            con.Open();
            SqlDataReader dr = cm4.ExecuteReader();
            dr.Read();
            lblPreviousDetails.Text = dr["preAllergy"].ToString();
            lblCurrentDetails.Text = dr["Allergy"].ToString();
            lblMedicationDetails.Text = dr["Medication"].ToString();
            con.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            s.Show();
        }
    }
}
