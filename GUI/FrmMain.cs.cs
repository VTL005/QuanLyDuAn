using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuAn.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void LoadForm(Form f)
        {
            pnContent.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnContent.Controls.Add(f);
            pnContent.Tag = f;
            f.Show();
        }

        private void ResetButtonColor()
        {
            btnDashboard.BackColor = Color.SteelBlue;
            btnProject.BackColor = Color.SteelBlue;
            btnNhanVien.BackColor = Color.SteelBlue;
            btnTask.BackColor = Color.SteelBlue;
            btnReport.BackColor = Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }

        private void HighlightButton(Button btn)
        {
            ResetButtonColor();
            btn.BackColor = Color.RoyalBlue;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FrmMain_Load chạy");
            LoadForm(new FrmDashboard());
            HighlightButton(btnDashboard);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmDashboard());
            HighlightButton(btnDashboard);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmProject());
            HighlightButton(btnProject);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmNhanVien());
            HighlightButton(btnNhanVien);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmTask());
            HighlightButton(btnTask);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmReport());
            HighlightButton(btnReport);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin f = new FrmLogin();
                f.Show();
            }
        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}