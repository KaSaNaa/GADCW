﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Learning_Platform
{
    public partial class Sign_Up_Student : Form
    {
        public Sign_Up_Student()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        private void Sign_Up_Student_Load(object sender, EventArgs e)
        {
            btn_create.Visible = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            var fname = txt_fname.Text;
            var lname = txt_lname.Text;
            var email = txt_mail.Text;
            var username = txt_username.Text;
            var password = txt_pwd.Text;
            var confirm_password = txt_con_pwd.Text;
            var dob = dobPicker.Value;

            try
            {
                if (string.IsNullOrEmpty(fname) || txt_fname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Please enter your first name which cannot have numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (string.IsNullOrEmpty(lname) || txt_fname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Please enter your last name which cannot have numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if(txt_mail.Text.Length == 0)
                {
                    MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_mail.Focus();
                    return;
                }

                else if(!Regex.IsMatch(txt_mail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Please enter your valid email address. Eg:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_mail.Focus();
                }

                else if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter your user name with characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (password != confirm_password)
                {
                    MessageBox.Show("The password and confirm password fields do not match. Please re-enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = new SqlConnection("Data Source=DESKTOP-CTNVSJ1;Initial Catalog=Sign_Up_Details;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Insert into Student values ('"+txt_fname.Text+"', '"+txt_lname.Text+"', '"+txt_mail.Text+"', '"+txt_username.Text+"', '"+txt_pwd.Text+"', '"+txt_con_pwd.Text+"', '"+dobPicker.Value+"')", con);

            int i = cmd.ExecuteNonQuery();

            if(i == 1)
            {
                MessageBox.Show("Account is sucessfully created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please check again the fields and enter the valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }

        private void check_rules_CheckedChanged(object sender, EventArgs e)
        {
            if (check_norms.Checked)
            {
                btn_create.Visible = true;
            }
            else
            {
                btn_create.Visible = false;
            }

            txt_fname.Enabled = !check_norms.Checked;
            txt_lname.Enabled = !check_norms.Checked;
            txt_mail.Enabled = !check_norms.Checked;
            txt_username.Enabled = !check_norms.Checked;
            dobPicker.Enabled = !check_norms.Checked;
            txt_pwd.Enabled = !check_norms.Checked;
            txt_con_pwd.Enabled = !check_norms.Checked;

        }
    }
}