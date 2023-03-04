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

namespace WindowsFormsApp1
{
    public partial class frmCreateAccount : MetroFramework.Forms.MetroForm
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            Btn_CreateAcc.Visible = false;
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
            BirthDatePicker.Enabled = !CheckBox_Terms.Checked;
            TxtB_Password.Enabled = !CheckBox_Terms.Checked;
            TxtB_ConfirmPswd.Enabled = !CheckBox_Terms.Checked;
        }

        private void Btn_CreateAcc_Click(object sender, EventArgs e)
        {
            var fname = TxtB_Fname.Text;
            var lname = TxtB_Lname.Text;
            var email = TxtB_Email.Text;
            var password = TxtB_Password.Text;
            var confirm_password = TxtB_ConfirmPswd.Text;
            var dob = BirthDatePicker.Value;
            var selectedValue = "";

            if (radioStudent.Checked)
            {
                selectedValue = "S";
            }
            else if (radioLecturer.Checked)
            {
                selectedValue = "L";
            }

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

            con = new SqlConnection("Data Source=DESKTOP-LC7RQ4G;Initial Catalog=LearningPlatform;Integrated Security=True");
            con.Open();

            long maxId, newId;

            string query = "SELECT MAX(UserID) FROM Users";
            cmd = new SqlCommand(query, con);
            object result = cmd.ExecuteScalar();

            if (Convert.IsDBNull(result))
            {
                maxId = 0;
                newId = maxId + 1;
            }
            else
            {
                maxId = Convert.ToInt64(result);
                newId = maxId + 1;
            }
            if (fname.Length > 100 || lname.Length > 100) // 100 is the maximum length allowed by the database column
            {
                fname = fname.Substring(0, 100); // truncate the string to the maximum length
                lname = lname.Substring(0, 100);
            }

            cmd = new SqlCommand("Insert into Users values (@newId, @fname, @lname, @email, @password, @selectedValue, @dob)", con);
            cmd.Parameters.AddWithValue("@newId", newId);
            cmd.Parameters.AddWithValue("@fname", TxtB_Fname.Text);
            cmd.Parameters.AddWithValue("@lname", TxtB_Lname.Text);
            cmd.Parameters.AddWithValue("@email", TxtB_Email.Text);
            cmd.Parameters.AddWithValue("@password", TxtB_Password.Text);
            cmd.Parameters.AddWithValue("@selectedValue", selectedValue);
            cmd.Parameters.AddWithValue("@dob", BirthDatePicker.Value);


            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                // If the insert was successful, retrieve the new user ID
                cmd = new SqlCommand("SELECT MAX(UserID) FROM Users", con);
                int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                // Display the new user ID to the user
                MessageBox.Show("Account is successfully created.\n\nYour User ID is " + newUserId.ToString() + ".\nRemember it!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please check again the fields and enter the valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void TxtB_Email_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtB_Lname_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TxtB_Fname_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
