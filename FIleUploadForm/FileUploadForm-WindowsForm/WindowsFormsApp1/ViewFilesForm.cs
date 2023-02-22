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
using Microsoft.SqlServer.Types;

namespace WindowsFormsApp1
{
    public partial class ViewFilesForm : Form
    {
        public ViewFilesForm()
        {
            InitializeComponent();
        }
        Database db = new Database();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            try
            {
                // Select all records from the documents table
                string query = "SELECT * FROM documents";
                SqlCommand command = new SqlCommand(query, db.con);

                // Create a DataTable to hold the query results
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Set the DataSource property of the DataGridView control to the DataTable
                DocumentTableView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            db.CloseConnection();
        }

        private void Btn_Uploadfile_Click(object sender, EventArgs e)
        {
            UploadFilesForm upBtnForm = new UploadFilesForm();
            upBtnForm.ShowDialog();
        }

        private void DocumentTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
