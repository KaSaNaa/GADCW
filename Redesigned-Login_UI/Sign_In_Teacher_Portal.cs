using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redesigned_Login_UI
{
    public partial class Sign_In_Teacher_Portal : MetroSet_UI.Forms.MetroSetForm
    {
        public Sign_In_Teacher_Portal()
        {
            InitializeComponent();
        }

        private void Sign_In_Teacher_Portal_Load(object sender, EventArgs e)
        {
            TxtB_Password.UseSystemPasswordChar = true;
        }

        private void Link_ForgotPswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In_Teacher_Pwd obj = new Sign_In_Teacher_Pwd();
            obj.ShowDialog();
        }

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = TxtB_Username.Text;
                string password = TxtB_Password.Text;

                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-CTNVSJ1;Initial Catalog=Sign_Up_Details;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturer WHERE Lecturer_Username = '" + TxtB_Username.Text + "' AND Lecturer_Password = '" + TxtB_Password.Text + "'", con);

                SqlDataReader reader = cmd.ExecuteReader();

                // check if there is a matching record in the database
                if (reader.HasRows)
                {
                    //Lecturer_Main obj = new Lecturer_Main();
                    //obj.ShowDialog();
                    MessageBox.Show("Add the teacher dashboard interface");
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // close the reader and the connection
                reader.Close();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_CreateAcc_Click(object sender, EventArgs e)
        {
            var obj = new Sign_Up_Teacher();
            obj.ShowDialog();
        }

        private void Btn_GoBack_Click(object sender, EventArgs e)
        {
            UserType obj = new UserType();
            obj.ShowDialog();
        }
    }
}
