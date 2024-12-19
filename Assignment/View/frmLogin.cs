using Assignment.Controls;
using Assignment.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmLogin : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private bool showPassword = false;
        public frmLogin()
        {
            InitializeComponent();
            CheckSaveAccount();
        }

        private void CheckSaveAccount()
        {
            //chkNhoTaiKhoan.Text = "Lưu thông tin đăng nhập";

            chkNhoTaiKhoan.Text = "Duy trì đăng nhập";

            string username = Properties.Settings.Default.username;
            string password = Properties.Settings.Default.password;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {

                //txtUsername.Text = Security.Decrypt(username);
                //txtPassword.Text = Security.Decrypt(password);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT role FROM USERS WHERE username = @username AND password = CONVERT(VARBINARY(MAX), @password, 2) AND role IN ('ADMIN', 'CBDT', 'GV')";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", Security.Decrypt(username));
                        cmd.Parameters.AddWithValue("@password", Security.GetMd5Hash(Security.Decrypt(password)));

                        dynamic role = cmd.ExecuteScalar();

                        if (role == null)
                        {
                            return;
                        }

                        Hide();

                        frmHome frm = new frmHome(this, role, Security.Decrypt(username));
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    List<string> emptyList = new List<string>();
                    if (string.IsNullOrWhiteSpace(username))
                    {
                        emptyList.Add("tên người dùng");
                    }
                    if (string.IsNullOrWhiteSpace(username))
                    {
                        emptyList.Add("mật khẩu");
                    }

                    string emptyMessage = "Bạn cần điền ";
                    for (int i = 0; i < emptyList.Count; i++)
                    {
                        if (i == (emptyList.Count - 1))
                        {
                            emptyMessage += $"{emptyList[i]} để tiếp tục";
                        }
                        else
                        {
                            emptyMessage += $"{emptyList[i]}, ";
                        }
                    }

                    MessageBox.Show(emptyMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT role FROM USERS WHERE username = @username AND password = CONVERT(VARBINARY(MAX), @password, 2) AND role IN ('ADMIN', 'CBDT', 'GV')";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", Security.GetMd5Hash(password));

                        dynamic role = cmd.ExecuteScalar();

                        if (role == null)
                        {
                            MessageBox.Show($"Tài khoản hoặc mật khẩu không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (chkNhoTaiKhoan.Checked)
                        {
                            Properties.Settings.Default.username = Security.Encrypt(username);
                            Properties.Settings.Default.password = Security.Encrypt(password);
                            Properties.Settings.Default.Save();
                        }

                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        MessageBox.Show($"Đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Hide();

                        frmHome frm = new frmHome(this, role, username);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muống thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Image = Properties.Resources.hidden;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowPassword.Image = Properties.Resources.eye;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;

                frmAccountSuggestion frm = new frmAccountSuggestion(this);
                frm.ShowDialog();
            }
        }
    }
}
