using System.Data.SqlClient;

namespace QuanLyDuAn.DB

{
    internal class DBConnect
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDuAnDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {// toi la my an cut choa
            // toi la vy the long adu
            // xin chao tat ca moi nguoi
            return new SqlConnection(connectionString);
        }
    }
}