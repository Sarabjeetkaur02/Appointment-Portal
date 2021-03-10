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
    public partial class ClinicDetails : Form
    {
        SignInSuccessfull s1;
       
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");

        public ClinicDetails(SignInSuccessfull form)
        {
            InitializeComponent();
            s1 = form;

        }

        private void ClinicDetails_Load(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("SELECT ClinicName FROM ClinicDetails",con);
            con.Open();
            SqlDataReader dr2 = cmd4.ExecuteReader();
            while (dr2.Read())
            {
                cmbClinic.Items.Add(dr2["ClinicName"].ToString().Trim());
            }
            con.Close();
        }

        private void cmbClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("SELECT * FROM ClinicDetails WHERE ClinicName=@ClinicName", con);
            cmd4.Parameters.AddWithValue("@ClinicName", cmbClinic.SelectedItem.ToString());
            con.Open();
            SqlDataReader rd = cmd4.ExecuteReader();
            rd.Read();
            lblClinicNameValue.Text = rd["ClinicName"].ToString();
            lblClinicAddressValue.Text = rd["ClinicAddress"].ToString();
            lblCllinicContactValue.Text = rd["CLinicContact"].ToString();
            lblClinicRatingValue.Text = rd["ClinicRating"].ToString();
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            s1.Show();
        }
    }
}
