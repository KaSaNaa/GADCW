﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Platform
{
    public partial class Sign_In_Lecturer : Form
    {
        public Sign_In_Lecturer()
        {
            InitializeComponent();
        }

        private void Sign_In_Lecturer_Load(object sender, EventArgs e)
        {
            txt_pwd.UseSystemPasswordChar = true;
        }

        private void link_forgot_pwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In_Lecturer_Pwd obj = new Sign_In_Lecturer_Pwd();
            obj.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_name.Text;
                string password = txt_pwd.Text;

                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-CTNVSJ1;Initial Catalog=Sign_Up_Details;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturer WHERE Lecturer_Username = '" + txt_name.Text + "' AND Lecturer_Password = '" + txt_pwd.Text + "'", con);

                SqlDataReader reader = cmd.ExecuteReader();

                // check if there is a matching record in the database
                if (reader.HasRows)
                {
                    Lecturer_Main obj = new Lecturer_Main();
                    obj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // close the reader and the connection
                reader.Close();
                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            Sign_Up_Lecturer obj = new Sign_Up_Lecturer();
            obj.ShowDialog();
        }

        private void btn_back_user_Click(object sender, EventArgs e)
        {
            User_Type obj = new User_Type();
            obj.ShowDialog();
        }
    }
}