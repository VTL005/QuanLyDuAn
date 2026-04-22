namespace QuanLyDuAn.GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.lblContentTitle = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.pnMenu.Controls.Add(this.btnDashboard);
            this.pnMenu.Controls.Add(this.btnProject);
            this.pnMenu.Controls.Add(this.btnNhanVien);
            this.pnMenu.Controls.Add(this.btnTask);
            this.pnMenu.Controls.Add(this.btnReport);
            this.pnMenu.Controls.Add(this.btnDangXuat);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.MaximumSize = new System.Drawing.Size(220, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(220, 450);
            this.pnMenu.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProject.Location = new System.Drawing.Point(3, 54);
            this.btnProject.Name = "btnProject";
            this.btnProject.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProject.Size = new System.Drawing.Size(200, 45);
            this.btnProject.TabIndex = 1;
            this.btnProject.Text = "Quản lý dự án";
            this.btnProject.UseVisualStyleBackColor = false;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 105);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(200, 45);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTask.Location = new System.Drawing.Point(3, 156);
            this.btnTask.Name = "btnTask";
            this.btnTask.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTask.Size = new System.Drawing.Size(200, 45);
            this.btnTask.TabIndex = 3;
            this.btnTask.Text = "Công việc";
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(3, 207);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 45);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 258);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(200, 45);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnContent.Controls.Add(this.lblContentTitle);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(220, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(694, 450);
            this.pnContent.TabIndex = 1;
            // 
            // lblContentTitle
            // 
            this.lblContentTitle.AutoSize = true;
            this.lblContentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblContentTitle.Location = new System.Drawing.Point(0, 0);
            this.lblContentTitle.Name = "lblContentTitle";
            this.lblContentTitle.Size = new System.Drawing.Size(164, 32);
            this.lblContentTitle.TabIndex = 0;
            this.lblContentTitle.Text = "Trang chính";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnMenu);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dự án";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblContentTitle;
    }
}

