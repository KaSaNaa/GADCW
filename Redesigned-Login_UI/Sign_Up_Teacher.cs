using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redesigned_Login_UI
{
    public partial class Sign_Up_Teacher : MetroSet_UI.Forms.MetroSetForm
    {
        public Sign_Up_Teacher()
        {
            InitializeComponent();
        }
        
        private void Sign_Up_Teacher_Load(object sender, EventArgs e)
        {
            Btn_CreateAccount.Visible = false;
        }

        SqlConnection con;
        SqlCommand cmd;

        private void metroSetCheckBox1_CheckedChanged(object sender)
        {

        }

        private void Btn_CreateAccount_Click(object sender, EventArgs e)
        {
            string fname = TxtB_FName.Text;
            string lname = TxtB_LName.Text;
            string email = TxtB_Email.Text;
            string username = TxtB_Username.Text;
            string password = TxtB_Password.Text;
            string confirm_password = TxtB_ConfirmPswd.Text;
            DateTime dob = BIrthDatePicker.Value;

            try
            {
                if (string.IsNullOrEmpty(fname) || TxtB_FName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Please enter your first name which cannot have numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (string.IsNullOrEmpty(lname) || TxtB_FName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Please enter your last name which cannot have numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (TxtB_Email.Text.Length == 0)
                {
                    MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtB_Email.Focus();
                    return;
                }

                else if (!Regex.IsMatch(TxtB_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Please enter your valid email address. Eg:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtB_Email.Focus();
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
            cmd = new SqlCommand("Insert into Lecturer values ('" + TxtB_FName.Text + "', '" + TxtB_LName.Text + "', '" + TxtB_Email.Text + "', '" + TxtB_Username.Text + "', '" + TxtB_Password.Text + "', '" + TxtB_ConfirmPswd.Text + "', '" + BIrthDatePicker.Value + "')", con);

            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("Account is sucessfully created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please check again the fields and enter the valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        
    }
}
