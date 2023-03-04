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
                string username = TxtB_Username.Text;
                string password = TxtB_Password.Text;
                char usertype = 'S';

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


                SqlDataReader reader = cmd.ExecuteReader();
                

                // check if there is a matching record in the database
                if (reader.HasRows)
                {
                    frmMain.Instance.Hide();
                    studentDashboard obj = new studentDashboard();
                    obj.FirstName = reader.GetString(1);
                    obj.LastName = reader.GetString(2);
                    obj.Email = reader.GetString(3);
                    obj.Course = reader.GetString(4);
                    obj.Username = reader.GetString(5);
                    obj.Password = reader.GetString(6);
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_CreateAcc_Click_1(object sender, EventArgs e)
        {
            frmCreateAccount form = new frmCreateAccount();
            form.ShowDialog();
        }

        private void Link_ForgotPswd_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}