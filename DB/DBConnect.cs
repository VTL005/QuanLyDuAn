using System.Data.SqlClient;

namespace QuanLyDuAn.vcll

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