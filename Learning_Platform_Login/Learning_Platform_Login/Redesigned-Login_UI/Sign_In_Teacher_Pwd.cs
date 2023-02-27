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
    public partial class Sign_In_Teacher_Pwd : MetroSet_UI.Forms.MetroSetForm
    {
        public Sign_In_Teacher_Pwd()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            string username = TxtB_Username.Text;
            string password = TxtB_Password.Text;
            string confirm_password = TxtB_ConfirmPswd.Text;

            try
            {
                if (string.IsNullOrEmpty(username))
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
            cmd = new SqlCommand("UPDATE Lecturer SET Lecturer_Password = '" + TxtB_Password.Text + "', Lecturer_Confirm = '" + TxtB_ConfirmPswd.Text + "' WHERE Lecturer_Username = '" + TxtB_Username.Text + "'", con);

            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("New Password is created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please check again the fields and enter the valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}
