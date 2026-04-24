using System.Data.SqlClient;

namespace QuanLyDuAn.DB

{
    internal class DBConnect
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDuAnDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            // toi la lgbt
            return new SqlConnection(connectionString);
        }
    }
}