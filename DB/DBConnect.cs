using System.Data.SqlClient;

namespace QuanLyDuAn.vcll

{
    internal class DBConnect
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDuAnDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {// toi la my
            return new SqlConnection(connectionString);
        }
    }
}