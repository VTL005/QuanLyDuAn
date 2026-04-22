using System.Data;
using System.Data.SqlClient;
using QuanLyDuAn.DB;

namespace QuanLyDuAn.DAL
{
    internal class NhanVienDAL
    {
        DBConnect db = new DBConnect();

        public DataTable GetAllNhanVien()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string sql = "SELECT * FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool InsertNhanVien(string hoTen, string ngaySinh, string gioiTinh, string soDienThoai, string email, string chucVu)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO NhanVien(HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, ChucVu)
                               VALUES(@HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @Email, @ChucVu)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateNhanVien(int maNV, string hoTen, string ngaySinh, string gioiTinh, string soDienThoai, string email, string chucVu)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE NhanVien
                               SET HoTen = @HoTen,
                                   NgaySinh = @NgaySinh,
                                   GioiTinh = @GioiTinh,
                                   SoDienThoai = @SoDienThoai,
                                   Email = @Email,
                                   ChucVu = @ChucVu
                               WHERE MaNV = @MaNV";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteNhanVien(int maNV)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}