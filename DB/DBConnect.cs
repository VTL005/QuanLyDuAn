using System.Data.SqlClient;

namespace QuanLyDuAn.DB

{
    internal class DBConnect
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDuAnDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {// toi la my an cut cho
            // toi la vy the long adu
            return new SqlConnection(connectionString);
        }
    }
}