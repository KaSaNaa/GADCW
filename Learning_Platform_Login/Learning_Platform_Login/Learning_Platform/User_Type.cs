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
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Learning_Platform
{
    public partial class User_Type : MetroFramework.Forms.MetroForm
    {
        
        public User_Type()
        {
            InitializeComponent();
            metroPanel1.Location = new Point(0, 0);
            this.Controls.Add(metroPanel1);
            Btn_Close.BackColor = Color.Red;
        }

        private void btn_std_login_Click(object sender, EventArgs e)
        {
            btn_std_login.Visible = false;
            btn_lec_login.Visible = false;

            try
            {
                var childForm = new Sign_In_Student();
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Bottom;
                childForm.AutoScroll = true;
                childForm.ShadowType = MetroFormShadowType.None;
                metroPanel1.Controls.Add(childForm);
                childForm.Show();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_lec_login_Click(object sender, EventArgs e)
        {
            btn_std_login.Visible = false;
            btn_lec_login.Visible = false;

            try
            {
                var childForm = new Sign_In_Lecturer();
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Bottom;
                childForm.AutoScroll = true;
                childForm.ShadowType = MetroFormShadowType.None;
                metroPanel1.Controls.Add(childForm);
                childForm.Show();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Close_MouseHover(object sender, EventArgs e)
        {

        }
    }
}