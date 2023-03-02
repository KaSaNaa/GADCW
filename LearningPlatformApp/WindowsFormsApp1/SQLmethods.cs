using System.Data.SqlClient;

namespace YourNamespace
{
    public class SqlHelper
    {
        private string connectionString; // the connection string to your database

        public SqlHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Executes a SQL query and returns a SqlDataReader
        public SqlDataReader ExecuteReader(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            return command.ExecuteReader();
        }

        // Executes a SQL query and returns the number of rows affected
        public int ExecuteNonQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            return command.ExecuteNonQuery();
        }

        // Executes a SQL query and returns the result as an object
        public object ExecuteScalar(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            return command.ExecuteScalar();
        }
    }
}