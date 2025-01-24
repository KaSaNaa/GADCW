using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace WindowsFormsApp1
{
    public partial class ViewFilesForm : MetroFramework.Forms.MetroForm
    {
        private readonly Timer _timer = new Timer(); //instantiated a timer 
        public ViewFilesForm()
        {
            InitializeComponent();
            _timer.Interval = 2000; // 2 seconds
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ReloadData();
        }

        readonly Database _db = new Database();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learningPlatformDataSet2.documents' table. You can move, or remove it, as needed.
            this.documentsTableAdapter.Fill(this.learningPlatformDataSet2.documents);
            ReloadData();
        }

        private void ReloadData()
        {
            _db.OpenConnection();
            try
            {
                // select all records from the documents table
                var query = "SELECT * FROM documents";
                var cmd = new SqlCommand(query, _db.con);

                // create a DataTable to hold the query results
                DataTable dataTable = new DataTable();

                // use a SqlAdapter to fill the data table
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                // set the data source property of the DataGridView control to the DataTable
                DocumentTableView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            _db.CloseConnection();
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