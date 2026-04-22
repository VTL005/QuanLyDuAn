using System.Data.SqlClient;

namespace QuanLyDuAn.vcl

{
    internal class DBConnect
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDuAnDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}