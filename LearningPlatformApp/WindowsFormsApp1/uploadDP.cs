using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp1
{
    public partial class uploadDP : MetroForm
    {
        private SqlConnection con;
        private byte[] imageBytes;
        public uploadDP()
        {
            InitializeComponent();
            con = new SqlConnection(
                "Data Source=DESKTOP-LC7RQ4G;Initial Catalog=LearningPlatform;Integrated Security=True");
        }

        private void metroButton1_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@UserID",1); //set your own UserID value
                cmd.Parameters.AddWithValue("@ImageData", imageBytes);
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Successful", "Image uploaded successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                metroTextBox1.Text = openFileDialog.FileName;
                Image image = Image.FromFile(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }
        }

        private void uploadDP_Load(object sender, EventArgs e)
        {
            
        }
    }
}
