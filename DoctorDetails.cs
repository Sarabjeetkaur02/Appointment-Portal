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
    public partial class DoctorDetails : Form
    {
        SignInSuccessfull s;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");

        public DoctorDetails(SignInSuccessfull form)
        {
            InitializeComponent();
            s = form;
        }

        private void DoctorDetails_Load(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("SELECT DoctorName FROM Doctordetails", con);
            con.Open();
            SqlDataReader dr2 = cmd4.ExecuteReader();
            while (dr2.Read())
            {
                cmbDoctor.Items.Add(dr2["DoctorName"].ToString().Trim());
            }
            con.Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("SELECT * FROM DoctorDetails WHERE DoctorName=@DoctorName", con);
            cmd4.Parameters.AddWithValue("@DoctorName", cmbDoctor.SelectedItem.ToString());
            con.Open();
            SqlDataReader rd = cmd4.ExecuteReader();
            rd.Read();
            lblDoctorNameValue.Text = rd["DoctorName"].ToString();
            lblDoctorSpecialityValue.Text = rd["DoctorSpeciality"].ToString();
            lblDoctorContactValue.Text = rd["DoctorContact"].ToString();
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            s.Show();
        }
    }
}
