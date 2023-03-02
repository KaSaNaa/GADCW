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

namespace Learning_Platform
{
    public partial class Sign_In_Student_Pwd : MetroFramework.Forms.MetroForm
    {
        public Sign_In_Student_Pwd()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        private void btn_confirm_Click(object sender, EventArgs e)
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
            cmd = new SqlCommand("UPDATE Student SET Student_Password = '"+TxtB_Password.Text+"', Student_Confirm = '"+TxtB_ConfirmPswd.Text+"' WHERE Student_Username = '"+TxtB_Username.Text+"'", con);

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
