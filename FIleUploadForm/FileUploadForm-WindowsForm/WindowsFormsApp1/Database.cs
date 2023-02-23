using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Database
    {
        internal SqlConnection con;
        private SqlCommand cmd;
        internal SqlDataAdapter da;

        public Database() // Default Constructor
        {
            con = new SqlConnection(
                "Data Source=DESKTOP-LC7RQ4G;Initial Catalog = LearningPlatform;Integrated Security = True");
        }

        public void OpenConnection()
        {
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public int SQLCommand(string query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, con);
            var i = cmd.ExecuteNonQuery();
            CloseConnection();
            return i;
        }

        public DataTable GetDataTable(string a)
        {
            OpenConnection();
            da = new SqlDataAdapter(a, con);
            var dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}