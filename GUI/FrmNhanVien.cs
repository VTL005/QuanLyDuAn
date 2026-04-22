using System;
using System.Windows.Forms;
using QuanLyDuAn.DAL;

namespace QuanLyDuAn.GUI
{
    public partial class FrmNhanVien : Form
    {
        NhanVienDAL dal = new NhanVienDAL();
        int maNV = -1;

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            dgvNhanVien.DataSource = dal.GetAllNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kq = dal.InsertNhanVien(
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value.ToString("yyyy-MM-dd"),
                cboGioiTinh.Text,
                txtSoDienThoai.Text.Trim(),
                txtEmail.Text.Trim(),
                txtChucVu.Text.Trim()
            );

            if (kq)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maNV == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa");
                return;
            }

            bool kq = dal.UpdateNhanVien(
                maNV,
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value.ToString("yyyy-MM-dd"),
                cboGioiTinh.Text,
                txtSoDienThoai.Text.Trim(),
                txtEmail.Text.Trim(),
                txtChucVu.Text.Trim()
            );

            if (kq)
            {
                MessageBox.Show("Sửa nhân viên thành công");
                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maNV == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool kq = dal.DeleteNhanVien(maNV);

                if (kq)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    LoadData();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            maNV = -1;
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtChucVu.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            txtHoTen.Focus();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            object val;

            val = row.Cells["MaNV"].Value;
            if (val != null && int.TryParse(val.ToString(), out int id))
                maNV = id;
            else
                maNV = -1;

            val = row.Cells["HoTen"].Value;
            txtHoTen.Text = val != null ? val.ToString() : string.Empty;

            val = row.Cells["NgaySinh"].Value;
            if (val != null && DateTime.TryParse(val.ToString(), out DateTime dt))
                dtpNgaySinh.Value = dt;
            else
                dtpNgaySinh.Value = DateTime.Now;

            val = row.Cells["GioiTinh"].Value;
            cboGioiTinh.Text = val != null ? val.ToString() : string.Empty;

            val = row.Cells["SoDienThoai"].Value;
            txtSoDienThoai.Text = val != null ? val.ToString() : string.Empty;

            val = row.Cells["Email"].Value;
            txtEmail.Text = val != null ? val.ToString() : string.Empty;

            val = row.Cells["ChucVu"].Value;
            txtChucVu.Text = val != null ? val.ToString() : string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // no-op: reserved for designer event
        }

        private void FrmNhanVien_Click(object sender, EventArgs e)
        {
            // no-op: reserved for designer event
        }
    }
}
