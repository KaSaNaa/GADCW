using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Database
    {
        internal SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

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

        public int save_update_delete(string query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            CloseConnection();
            return i;
        }

        public DataTable GetData(string a)
        {
            OpenConnection();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}