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
using Microsoft.Win32;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Learning_Platform
{
    public partial class Sign_Up_Student : MetroFramework.Forms.MetroForm
    {
        public Sign_Up_Student()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        private void Sign_Up_Student_Load(object sender, EventArgs e)
        {
            Btn_CreateAcc.Visible = false;
        }

        private void TxtB_Fname_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CreateAcc_Click(object sender, EventArgs e)
        {
            var fname = TxtB_Fname.Text;
            var lname = TxtB_Lname.Text;
            var email = TxtB_Email.Text;
            var username = TxtB_Username.Text;
            var password = TxtB_Password.Text;
            var confirm_password = TxtB_ConfirmPswd.Text;
            var dob = BirthDatePicker.Value;

            try
            {
                if (string.IsNullOrEmpty(fname) || TxtB_Fname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Please enter your first name which cannot have numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (string.IsNullOrEmpty(lname) || TxtB_Fname.Text.Any(char.IsDigit))
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
            cmd = new SqlCommand("Insert into Student values ('" + TxtB_Fname.Text + "', '" + TxtB_Lname.Text + "', '" + TxtB_Email.Text + "', '" + TxtB_Username.Text + "', '" + TxtB_Password.Text + "', '" + TxtB_ConfirmPswd.Text + "', '" + BirthDatePicker.Value + "')", con);

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

        private void CheckBox_Terms_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Terms.Checked)
            {
                Btn_CreateAcc.Visible = true;
            }
            else
            {
                Btn_CreateAcc.Visible = false;
            }

            TxtB_Fname.Enabled = !CheckBox_Terms.Checked;
            TxtB_Lname.Enabled = !CheckBox_Terms.Checked;
            TxtB_Email.Enabled = !CheckBox_Terms.Checked;
            TxtB_Username.Enabled = !CheckBox_Terms.Checked;
            BirthDatePicker.Enabled = !CheckBox_Terms.Checked;
            TxtB_Password.Enabled = !CheckBox_Terms.Checked;
            TxtB_ConfirmPswd.Enabled = !CheckBox_Terms.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
