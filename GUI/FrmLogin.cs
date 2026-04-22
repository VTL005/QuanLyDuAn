using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            if (user == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                txtTenDangNhap.Focus();
                return;
            }

            if (pass == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }

            if (user == "admin" && pass == "123")
            {
                MessageBox.Show("Đăng nhập thành công!");

                FrmMain f = new FrmMain();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}
