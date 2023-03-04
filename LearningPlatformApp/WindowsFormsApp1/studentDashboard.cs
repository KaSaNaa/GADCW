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
        public studentDashboard()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return txt_fname.Text; }
            set { txt_fname.Text = value; }
        }

        public string LastName
        {
            get { return txt_lname.Text; }
            set { txt_lname.Text = value; }
        }

        public string Email
        {
            get { return txt_mail.Text; }
            set { txt_mail.Text = value; }
        }

        public string Course
        {
            get { return txt_course.Text; }
            set { txt_course.Text = value; }
        }

        public string Username
        {
            get { return txt_username.Text; }
            set { txt_username.Text = value; }
        }

        public string Password
        {
            get { return txt_pwd.Text; }
            set { txt_pwd.Text = value; }
        }


    }
}
