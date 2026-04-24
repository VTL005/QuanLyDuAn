namespace QuanLyDuAn.GUI
{
    partial class FrmReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiDoughnutChart1 = new Sunny.UI.UIDoughnutChart();
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(236, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo - Thống Kê";
            // 
            // uiDoughnutChart1
            // 
            this.uiDoughnutChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDoughnutChart1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiDoughnutChart1.Location = new System.Drawing.Point(95, 265);
            this.uiDoughnutChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDoughnutChart1.Name = "uiDoughnutChart1";
            this.uiDoughnutChart1.Size = new System.Drawing.Size(400, 300);
            this.uiDoughnutChart1.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiDoughnutChart1.TabIndex = 1;
            this.uiDoughnutChart1.Text = "uiDoughnutChart1";
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLineChart1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiLineChart1.Location = new System.Drawing.Point(782, 282);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.Size = new System.Drawing.Size(400, 300);
            this.uiLineChart1.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiLineChart1.TabIndex = 2;
            this.uiLineChart1.Text = "uiLineChart1";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 704);
            this.Controls.Add(this.uiLineChart1);
            this.Controls.Add(this.uiDoughnutChart1);
            this.Controls.Add(this.label1);
            this.Name = "FrmReport";
            this.Text = "Báo cáo thống kê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIDoughnutChart uiDoughnutChart1;
        private Sunny.UI.UILineChart uiLineChart1;
    }
}