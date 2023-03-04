using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp1
{
    public partial class studentDashboard : MetroForm
    {
        public void SetFirstnameLabel(string fname)
        {
            txt_username.Text = "Welcome, " + fname;
        }

        public void SetFirstName(string fname)
        {
            txt_fname.Text = fname;
        }

        public void SetLastName(string lname)
        {
            txt_lname.Text = lname;
        }

        public void SetEmailAddress(string email)
        {
            txt_mail.Text = email;
        }

        public studentDashboard()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get => txt_fname.Text;
            set => txt_fname.Text = value;
        }

        public string LastName
        {
            get => txt_lname.Text;
            set => txt_lname.Text = value;
        }

        public string Email
        {
            get => txt_mail.Text;
            set => txt_mail.Text = value;
        }

        public string Course
        {
            get => txt_course.Text;
            set => txt_course.Text = value;
        }

        public string Username
        {
            get => txt_username.Text;
            set => txt_username.Text = value;
        }

        public string Password
        {
            get => txt_pwd.Text;
            set => txt_pwd.Text = value;
        }

        private void studentDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learningPlatformDataSet.Users' table. You can move, or remove it, as needed. 
            tabDashboard.Focus();
            txt_fname.Visible = false;
            txt_course.Visible = false;
            txt_lname.Visible = false;
            txt_mail.Visible = false;
            txt_username.Visible = false;
        }

        private void tabDashboard_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            uploadDP dp = new uploadDP();
            dp.ShowDialog();
        }
    }
}
