using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuAn.GUI
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            this.BackColor = Color.WhiteSmoke;

            Label lbl = new Label();
            lbl.Text = "Đây là trang Dashboard";
            lbl.Font = new Font("Arial", 20, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(100, 100);

            this.Controls.Add(lbl);
        }
    }
}