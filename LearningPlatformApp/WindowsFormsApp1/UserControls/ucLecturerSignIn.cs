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
                string username = TxtB_Username.Text;
                string password = TxtB_Password.Text;
                char usertype = 'L';

                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = '" + TxtB_Username.Text + "' AND Password = '" + TxtB_Password.Text + "' AND Usertype = '"+ usertype +"'", con);

                SqlDataReader reader = cmd.ExecuteReader();

                // check if there is a matching record in the database
                if (reader.HasRows)
                {
                    frmMain.Instance.Hide();
                    var form = new studentDashboard();
                    form.Show();
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
