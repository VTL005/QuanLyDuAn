using System.Data.SqlClient;

namespace QuanLyDuAn.DB

{
    internal class DBConnect
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDuAnDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            // toi la vy the long adu
            // xin chao tat ca moi nguoi
            //hi
            // my bi phien
            return new SqlConnection(connectionString);
        }
    }
}