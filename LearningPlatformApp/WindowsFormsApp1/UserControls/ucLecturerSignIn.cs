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
    public partial class ucLecturerSignIn : MetroFramework.Controls.MetroUserControl
    {
        private SqlConnection con;
        public ucLecturerSignIn()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var username = TxtB_Username.Text;
                var password = TxtB_Password.Text;
                var usertype = 'L';

                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserId AND Password = @Password AND Usertype = @UserType", con);

                cmd.Parameters.AddWithValue("@UserId", TxtB_Username.Text);
                cmd.Parameters.AddWithValue("@Password", TxtB_Password.Text);
                cmd.Parameters.AddWithValue("@UserType", usertype);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand("SELECT FirstName FROM Users WHERE UserID = @UserId", con);
                    cmd1.Parameters.AddWithValue("@UserId", TxtB_Username.Text);
                    var firstnameReader = cmd1.ExecuteReader();
                    string firstname = "";
                    if (firstnameReader.Read())
                    {
                        firstname = firstnameReader.GetString(0);
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

        private void Btn_CreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateAccount form = new frmCreateAccount();
            form.ShowDialog();
        }

        private void Link_ForgotPswd_Click(object sender, EventArgs e)
        {
            
        }

        private void ucLecturerSignIn_Load(object sender, EventArgs e)
        {
            TxtB_Password.UseSystemPasswordChar = true;
            con = new SqlConnection("Data Source=DESKTOP-LC7RQ4G;Initial Catalog=LearningPlatform;Integrated Security=True");
        }
    }
}