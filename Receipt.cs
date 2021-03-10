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
    public partial class Receipt : Form
    {
        Payment p;
        string userName;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Database1.mdf"";Integrated Security=True");
        public Receipt(string username,Payment form)
        {
            InitializeComponent();
            p = form;
            userName = username;
           
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Patient,Date,Time,Clinic,Doctor FROM Appointment where Patient=@username",con);
            cmd.Parameters.AddWithValue("@username",userName);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            lblPatientValues.Text = rd["Patient"].ToString();
            lblAppointmentDateValue.Text = Convert.ToDateTime(rd["Date"].ToString()).ToString("dd-MM-yy");
            lblAppointmentTimeValue.Text = Convert.ToDateTime(rd["Time"].ToString()).ToString("HH:mm:ss");
            lblClinicName.Text = rd["Clinic"].ToString();
            lblDoctorName.Text = rd["Doctor"].ToString();
            rd.Close();

            SqlCommand cmd1 = new SqlCommand("SELECT ClinicAddress,ClinicContact FROM ClinicDetails where ClinicName=@Clinic",con);
            cmd1.Parameters.AddWithValue("@Clinic",lblClinicName.Text);
            SqlDataReader d = cmd1.ExecuteReader();
            d.Read();
            lblClinicAddress.Text = d["ClinicAddress"].ToString();
            lblClinicContact.Text = d["ClinicContact"].ToString();
            d.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT Doctorfees FROM DoctorDetails WHERE Doctorname=@Doctor",con);
            cmd2.Parameters.AddWithValue("@Doctor", lblDoctorName.Text);
            SqlDataReader r = cmd2.ExecuteReader();
            r.Read();
            lblAmountValue.Text = r["Doctorfees"].ToString();
            r.Close();
            con.Close();
        }
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        private void printdoc1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void Print(Panel pnl)
        {
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }
    }
}
