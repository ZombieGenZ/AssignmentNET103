using Assignment.View;
using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmHome : Form
    {
        Form loginForm;
        string role;
        string username;
        public frmHome(Form loginForm, string role, string username)
        {
            this.loginForm = loginForm;
            this.role = role;
            this.username = username;
            InitializeComponent();
            LoadFunction();
            smiTaiKhoan.Text = username;
        }

        private void LoadFunction()
        {
            if (role == "ADMIN")
            {
                smiQuanLyDiem.Enabled = true;
                smiQuanLySV.Enabled = true;
            }
            else if (role == "GV")
            {
                smiQuanLyDiem.Enabled = true;
            }
            else if (role == "CBDT")
            {
                smiQuanLySV.Enabled = true;
            }
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void mniThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muống thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void smiQuanLySV_Click(object sender, EventArgs e)
        {
            frmQLSV frm = new frmQLSV(this);
            Hide();
            frm.ShowDialog();
        }

        private void smiQuanLyDiem_Click(object sender, EventArgs e)
        {
            Hide();
            frmQLDiem frm = new frmQLDiem(this);
            frm.ShowDialog();
        }

        private void smiDangXuat_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            Hide();
            loginForm.Show();
        }

        private void smiTaiKhoan_Click(object sender, EventArgs e)
        {
            frmUserProfile frm = new frmUserProfile(role, username);
            frm.ShowDialog();
        }
    }
}
