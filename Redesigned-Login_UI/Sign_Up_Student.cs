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
using System.Text.RegularExpressions;

namespace Redesigned_Login_UI
{
    public partial class Sign_Up_Student : MetroSet_UI.Forms.MetroSetForm
    {
        public Sign_Up_Student()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void Btn_CreateAccount_Click(object sender, EventArgs e)
        {
            var fname = TxtB_FName.Text;
            var lname = TxtB_LName.Text;
            var email = TxtB_Email.Text;
            var username = TxtB_Username.Text;
            var password = TxtB_Password.Text;
            var confirmPassword = TxtB_ConfirmPswd.Text;
            var dob = BIrthDatePicker.Value;

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

                else if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter your user name with characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (password != confirmPassword)
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
            cmd = new SqlCommand("Insert into Student values ('" + TxtB_FName.Text + "', '" + TxtB_LName.Text + "', '" + TxtB_Email.Text + "', '" + TxtB_Username.Text + "', '" + TxtB_Password.Text + "', '" + TxtB_ConfirmPswd.Text + "', '" + BIrthDatePicker.Value + "')", con);

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

        private void metroSetCheckBox1_CheckedChanged(object sender)
        {
            if (metroSetCheckBox1.Checked)
            {
                Btn_CreateAccount.Visible = true;
            }
            else
            {
                Btn_CreateAccount.Visible = false;
            }

            TxtB_FName.Enabled = !metroSetCheckBox1.Checked;
            TxtB_LName.Enabled = !metroSetCheckBox1.Checked;
            TxtB_Email.Enabled = !metroSetCheckBox1.Checked;
            TxtB_Username.Enabled = !metroSetCheckBox1.Checked;
            BIrthDatePicker.Enabled = !metroSetCheckBox1.Checked;
            TxtB_Password.Enabled = !metroSetCheckBox1.Checked;
            TxtB_ConfirmPswd.Enabled = !metroSetCheckBox1.Checked;
        }
    }
}
