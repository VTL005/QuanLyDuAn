using System.Data.SqlClient;

namespace QuanLyDuAn.DB

{
    internal class DBConnect
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDuAnDB;Integrated Security=True";

        public SqlConnection GetConnection()
        {
<<<<<<< HEAD
            // toi la gai 2 mai hon dai am duong
=======
      
>>>>>>> aa69fa05b3f6f1e17ace431027458fcda0ba0976
            return new SqlConnection(connectionString);
        }
    }
}