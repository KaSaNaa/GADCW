using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucStudentSignIn : MetroFramework.Controls.MetroUserControl
    {
        private SqlConnection con;
        public ucStudentSignIn()
        {
            InitializeComponent();
        }

        private void ucStudentSignIn_Load(object sender, EventArgs e)
        {
            TxtB_Password.UseSystemPasswordChar = true;
            con = new SqlConnection("Data Source=DESKTOP-LC7RQ4G;Initial Catalog=LearningPlatform;Integrated Security=True");
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var username = TxtB_Username.Text;
                var password = TxtB_Password.Text;
                var usertype = 'S';

                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserId AND Password = @Password AND Usertype = @UserType", con);
                
                cmd.Parameters.AddWithValue("@UserId", Convert.ToInt32(TxtB_Username.Text));
                cmd.Parameters.AddWithValue("@Password", TxtB_Password.Text);
                cmd.Parameters.AddWithValue("@UserType", usertype);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand("SELECT UserID, FirstName, LastName, Email FROM Users WHERE UserID = @UserId", con);
                    cmd1.Parameters.AddWithValue("@UserId", Convert.ToInt32(TxtB_Username.Text));
                    var firstnameReader = cmd1.ExecuteReader();
                    string firstname ="", userid, lname, email;

                    if (firstnameReader.Read())
                    {
                        userid = Convert.ToString(firstnameReader.GetString(0));
                        firstname = firstnameReader.GetString(1);
                        lname = firstnameReader.GetString(2);
                        email = firstnameReader.GetString(3);
                    }
                    firstnameReader.Close();
                    frmMain.Instance.Hide();
                    var obj = new studentDashboard();
                    obj.SetFirstnameLabel(firstname);

                    obj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_CreateAcc_Click_1(object sender, EventArgs e)
        {
            var form = new frmCreateAccount();
            form.ShowDialog();
        }

        private void Link_ForgotPswd_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}