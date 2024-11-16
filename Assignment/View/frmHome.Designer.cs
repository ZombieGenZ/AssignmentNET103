namespace Assignment
{
    partial class frmHome
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.mniChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.smiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQuanLyDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQuanLySV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniChucNang,
            this.mniQuanLy});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(800, 28);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // mniChucNang
            // 
            this.mniChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiTaiKhoan,
            this.smiDangXuat,
            this.mniThoat});
            this.mniChucNang.Name = "mniChucNang";
            this.mniChucNang.Size = new System.Drawing.Size(93, 24);
            this.mniChucNang.Text = "Chức năng";
            // 
            // smiTaiKhoan
            // 
            this.smiTaiKhoan.Name = "smiTaiKhoan";
            this.smiTaiKhoan.Size = new System.Drawing.Size(224, 26);
            this.smiTaiKhoan.Text = "GHOST";
            this.smiTaiKhoan.Click += new System.EventHandler(this.smiTaiKhoan_Click);
            // 
            // mniThoat
            // 
            this.mniThoat.Name = "mniThoat";
            this.mniThoat.Size = new System.Drawing.Size(224, 26);
            this.mniThoat.Text = "Thoát";
            this.mniThoat.Click += new System.EventHandler(this.mniThoat_Click);
            // 
            // mniQuanLy
            // 
            this.mniQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiQuanLyDiem,
            this.smiQuanLySV});
            this.mniQuanLy.Name = "mniQuanLy";
            this.mniQuanLy.Size = new System.Drawing.Size(73, 24);
            this.mniQuanLy.Text = "Quản lý";
            // 
            // smiQuanLyDiem
            // 
            this.smiQuanLyDiem.Enabled = false;
            this.smiQuanLyDiem.Name = "smiQuanLyDiem";
            this.smiQuanLyDiem.Size = new System.Drawing.Size(203, 26);
            this.smiQuanLyDiem.Text = "Quản lý điểm";
            this.smiQuanLyDiem.Click += new System.EventHandler(this.smiQuanLyDiem_Click);
            // 
            // smiQuanLySV
            // 
            this.smiQuanLySV.Enabled = false;
            this.smiQuanLySV.Name = "smiQuanLySV";
            this.smiQuanLySV.Size = new System.Drawing.Size(203, 26);
            this.smiQuanLySV.Text = "Quản lý sinh viên";
            this.smiQuanLySV.Click += new System.EventHandler(this.smiQuanLySV_Click);
            // 
            // smiDangXuat
            // 
            this.smiDangXuat.Name = "smiDangXuat";
            this.smiDangXuat.Size = new System.Drawing.Size(224, 26);
            this.smiDangXuat.Text = "Đăng xuất";
            this.smiDangXuat.Click += new System.EventHandler(this.smiDangXuat_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn chức năng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem mniChucNang;
        private System.Windows.Forms.ToolStripMenuItem smiTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mniThoat;
        private System.Windows.Forms.ToolStripMenuItem mniQuanLy;
        private System.Windows.Forms.ToolStripMenuItem smiQuanLyDiem;
        private System.Windows.Forms.ToolStripMenuItem smiQuanLySV;
        private System.Windows.Forms.ToolStripMenuItem smiDangXuat;
    }
}