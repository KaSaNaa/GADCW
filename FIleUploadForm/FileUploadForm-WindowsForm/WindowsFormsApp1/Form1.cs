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
using System.IO;
using System.Linq.Expressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LC7RQ4G;Initial Catalog = LearningPlatform;Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

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
            if (textBox1.Text.Length != 0)
            {
                try
                {
                    // Insert the file data into the database
                    SqlCommand command = new SqlCommand("INSERT INTO documents (document) VALUES (@Name)", con);
                    command.Parameters.AddWithValue("@Name", Path.GetFileName(textBox1.Text));

                    con.Open();

                    int i = command.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Data added successfully!", "Upload Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading file: " + ex.Message);
                }
            }
            else MessageBox.Show("Please select a file to upload!", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}