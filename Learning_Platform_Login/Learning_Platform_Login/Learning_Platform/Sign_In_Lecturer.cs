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
using MetroFramework;

namespace Learning_Platform
{
    public partial class Sign_In_Lecturer : MetroFramework.Forms.MetroForm
    {
        public Sign_In_Lecturer()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void Sign_In_Lecturer_Load(object sender, EventArgs e)
        {
            TxtB_Password.UseSystemPasswordChar = true;
        }

        private void Link_BackButton_Click(object sender, EventArgs e)
        {
            User_Type obj = new User_Type();
            obj.ShowDialog();
        }

        private void Btn_Login_Click_1(object sender, EventArgs e)
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Link_ForgotPswd_Click(object sender, EventArgs e)
        {
            Sign_In_Lecturer_Pwd obj = new Sign_In_Lecturer_Pwd();
            obj.ShowDialog();
        }

        private void Btn_CreateAcc_Click(object sender, EventArgs e)
        {
            Sign_Up_Lecturer obj = new Sign_Up_Lecturer();
            obj.ShowDialog();
        }
    }
}
