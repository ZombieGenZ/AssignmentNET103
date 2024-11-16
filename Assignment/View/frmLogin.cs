using Assignment.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmLogin : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        public frmLogin()
        {
            InitializeComponent();
            CheckSaveAccount();
        }

        private void CheckSaveAccount()
        {
            string username = Properties.Settings.Default.username;
            string password = Properties.Settings.Default.password;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT role FROM USERS WHERE username = @username AND password = @password AND role IN ('CBDT', 'GV')";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", Security.Decrypt(username));
                        cmd.Parameters.AddWithValue("@password", Security.Decrypt(password));

                        dynamic role = cmd.ExecuteScalar();

                        if (role == null)
                        {
                            Properties.Settings.Default.username = "";
                            Properties.Settings.Default.password = "";
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

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT role FROM USERS WHERE username = @username AND password = @password AND role IN ('CBDT', 'GV')";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

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
    }
}
