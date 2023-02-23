using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;

namespace WindowsFormsApp1
{
    public partial class UploadFilesForm : Form
    {
        public UploadFilesForm()
        {
            InitializeComponent();
        }

        Database _db = new Database();

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var browseDialog = new OpenFileDialog())
            {
                browseDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                browseDialog.Title = "Select file to be uploaded.";
                browseDialog.Filter = "";

                if (browseDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = browseDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Please upload a file.");
                }
            }
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select a file to upload!", "No file selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var fileName = Path.GetFileName(textBox1.Text);

            try
            {
                // Check if the file already exists in the database
                SqlCommand selectCommand =
                    new SqlCommand("SELECT COUNT(*) FROM documents WHERE document = @Name", _db.con);
                selectCommand.Parameters.AddWithValue("@Name", fileName);

                _db.OpenConnection();
                var count = (int)selectCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("The selected file already exists in the database. Please select a different file or rename it.",
                        "File already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert the file data into the database
                SqlCommand insertCommand = new SqlCommand("INSERT INTO documents (document) VALUES (@Name)", _db.con);
                insertCommand.Parameters.AddWithValue("@Name", fileName);

                var rowsAffected = insertCommand.ExecuteNonQuery();

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Data added successfully!", "Upload Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data was added. Please try again.", "Upload Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading file: " + ex.Message);
            }
            finally
            {
                _db.CloseConnection();
            }
        }
    }
}