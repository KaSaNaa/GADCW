using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : MetroForm
    {
        int userid = 0;
        private SqlConnection con;
        private byte[] imageBytes;

        public void SetFirstnameLabel(string fname)
        {
            txt_fname.Text = "Welcome, " + fname;
        }

        public void SetUserName(int username)
        {
            userid = username;
            txt_username.Text = Convert.ToString(username);
        }

        public void SetLastName(string lname)
        {
            txt_lname.Text = lname;
        }

        public void SetEmailAddress(string email)
        {
            txt_mail.Text = email;
        }

        public void SetUserType(string usertype)
        {
            txt_usertype.Text = usertype;
        }

        public Dashboard()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-LC7RQ4G;Initial Catalog=LearningPlatform;Integrated Security=True");
            LoadImage();
        }

        public string FirstName
        {
            get => txt_fname.Text;
            set => txt_fname.Text = value;
        }

        public string LastName
        {
            get => txt_lname.Text;
            set => txt_lname.Text = value;
        }

        public string Email
        {
            get => txt_mail.Text;
            set => txt_mail.Text = value;
        }

        public string Course
        {
            get => txt_course.Text;
            set => txt_course.Text = value;
        }

        public string Username
        {
            get => txt_username.Text;
            set => txt_username.Text = value;
        }

        public string Password
        {
            get => txt_pwd.Text;
            set => txt_pwd.Text = value;
        }

        private void studentDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learningPlatformDataSet.Users' table. You can move, or remove it, as needed. 
            tabDashboard.Focus();
            txt_fname.Visible = true;
            txt_course.Visible = false;
            txt_lname.Visible = false;
            txt_mail.Visible = false;
            txt_username.Visible = false;
            txt_pwd.Visible = false;
            txt_usertype.Visible = false;
            txt_pwd.Visible = false;
        }

        private void tabDashboard_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabSettings_Click(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                metroTextBox1.Text = openFileDialog.FileName;
                Image image = Image.FromFile(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e) // upload button
        {
            if (imageBytes == null)
            {
                MessageBox.Show("Please select an image file to upload.");
                return;
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UserProfilePic(UserID, ImageData) VALUES(@UserID, @ImageData)", con);
                cmd.Parameters.AddWithValue("@UserID", userid); //set your own UserID value
                cmd.Parameters.AddWithValue("@ImageData", imageBytes);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Successful", "Image uploaded successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Upload error!", "Something went wrong while uploading the file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadImage()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ImageData FROM UserProfilePic WHERE UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", userid); //set your own UserID value
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    byte[] imageBytes = (byte[])reader["ImageData"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image image = Image.FromStream(ms);
                    Bitmap roundedImage = RoundImage(image, pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = roundedImage;
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in LoadImage method");
            }
            finally
            {
                con.Close();
            }
        }

        private Bitmap RoundImage(Image image, int width, int height)
        {
            Bitmap roundedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(roundedImage))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(Color.Transparent);
                graphics.DrawEllipse(new Pen(Color.Gray, 10), new Rectangle(0, 0, width - 1, height - 1));
                graphics.SetClip(new Rectangle(0, 0, width, height));
                graphics.DrawImage(image, new Rectangle(0, 0, width, height));
            }
            return roundedImage;
        }
    }
}
