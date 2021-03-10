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
    public partial class FillMedicalHistory : Form
    {
        SignUp signup;
        public FillMedicalHistory(SignUp form)
        {
            InitializeComponent();
            signup = form;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FillMedicalHistory_Load(object sender, EventArgs e)
        {

        }

        private void btHistorySubmit_Click(object sender, EventArgs e)
        {
            if (!chkAllergies1.Checked && !chkAsthma1.Checked && !chkDiabetes1.Checked && !chkHypertension1.Checked)
            {
                DialogResult d;
                d = MessageBox.Show("Please select atleast one checkbox", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!chkAllergies2.Checked && !chkAsthma2.Checked && !chkDiabetes2.Checked && !chkHypertension2.Checked)
            {
                DialogResult d;
                d = MessageBox.Show("Please select atleast one checkbox", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!rdYes.Checked && !rdNo.Checked && !rdNotsure.Checked)
            {
                DialogResult d;
                d = MessageBox.Show("Please select any one radiobutton", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                

                string previousDisease="";

                if (chkAllergies1.Checked)
                {
                    previousDisease += "Allergies,";
                }
                if (chkAsthma1.Checked)
                {
                    previousDisease += "Asthma,";
                }
                if (chkDiabetes1.Checked)
                {
                    previousDisease += "Diabetes,";
                }
                if (chkHypertension1.Checked)
                {
                    previousDisease += "Hypertension,";
                }

                string currentDisease = "";

                if (chkAllergies2.Checked)
                {
                    currentDisease += "Allergies,";
                }
                if (chkAsthma2.Checked)
                {
                    currentDisease += "Asthma,";
                }
                if (chkDiabetes2.Checked)
                {
                    currentDisease += "Diabetes,";
                }
                if (chkHypertension2.Checked)
                {
                    currentDisease += "Hypertension,";
                }

                string medication="";

                if (rdYes.Checked)
                {
                    medication += "Yes";
                }
                else if (rdNo.Checked)
                {
                    medication += "No";
                }
                else if (rdNotsure.Checked)
                {
                    medication += "NotSure";
                }

                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");
                SqlCommand cmd3 = new SqlCommand("INSERT INTO MedicalHistory(preAllergy,Allergy,Medication) VALUES(@previousDisease,@currentDisease,@medication)",con2);
                cmd3.Parameters.AddWithValue("@previousDisease",previousDisease);
                cmd3.Parameters.AddWithValue("@currentDisease", currentDisease);
                cmd3.Parameters.AddWithValue("@medication", medication);
                con2.Open();
                cmd3.ExecuteNonQuery();
                con2.Close();



                LogIn l = new LogIn();
                this.Close();
                l.Show();
            }
           
        }
    }
}
