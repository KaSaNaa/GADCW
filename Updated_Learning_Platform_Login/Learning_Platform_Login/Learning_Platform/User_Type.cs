using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Learning_Platform
{
    public partial class User_Type : Form
    {
        private Panel panel1 = new Panel();
        public User_Type()
        {
            InitializeComponent();

            panel1.Size = new Size(900, 900);
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(0, 0);
            this.Controls.Add(panel1);

        }

        private void btn_std_login_Click(object sender, EventArgs e)
        {
            btn_std_login.Visible = false;
            btn_lec_login.Visible = false;

            Sign_In_Student childForm = new Sign_In_Student();
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            panel1.Controls.Add(childForm);
            childForm.Show();
        }

        private void btn_lec_login_Click(object sender, EventArgs e)
        {
            btn_std_login.Visible = false;
            btn_lec_login.Visible = false;

            Sign_In_Lecturer childForm = new Sign_In_Lecturer();
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            panel1.Controls.Add(childForm);
            childForm.Show();
        }

        private void User_Type_Load(object sender, EventArgs e)
        {
            // Set the BackColor property
        }
    }
}
