using Assignment.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmQLSV : Form
    {
        private byte[] imageData;
        private int selectFunction = 0;
        private string connectionString = Properties.Settings.Default.connectionString;
        private Form frm;
        public frmQLSV(Form frm)
        {
            InitializeComponent();

            LoadStudnetData();
            this.frm = frm;
        }

        private void LoadStudnetData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT MaSV, HoTen, Email, SoDT, GioiTinh, DiaChi FROM SINHVIEN";
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Columns.Add(new DataColumn("MaSV"));
                                dt.Columns.Add(new DataColumn("HoTen"));
                                dt.Columns.Add(new DataColumn("Email"));
                                dt.Columns.Add(new DataColumn("SoDT"));
                                dt.Columns.Add(new DataColumn("GioiTinh"));
                                dt.Columns.Add(new DataColumn("DiaChi"));

                                while (reader.Read())
                                {
                                    DataRow row = dt.NewRow();
                                    row["MaSV"] = reader["MaSV"];
                                    row["HoTen"] = reader["HoTen"];
                                    row["Email"] = reader["Email"];
                                    row["SoDT"] = reader["SoDT"];
                                    row["GioiTinh"] = ((bool)reader["GioiTinh"]) ? "Nam" : "Nữ";
                                    row["DiaChi"] = reader["DiaChi"];
                                    dt.Rows.Add(row);
                                }

                            }

                            dgvData.DataSource = dt;

                            dgvData.Columns[0].HeaderText = "Mã SV";
                            dgvData.Columns[1].HeaderText = "Họ tên";
                            dgvData.Columns[3].HeaderText = "Số ĐT";
                            dgvData.Columns[4].HeaderText = "Giới tính";
                            dgvData.Columns[5].HeaderText = "Địa chỉ";
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFunction()
        {
            if (selectFunction == 1)
            {
                txtMaSV.ReadOnly = false;
                txtTenSV.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtSoDT.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                rbtGTNam.Enabled = true;
                rbtGTNu.Enabled = true;
                btnNew.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnUploadPicture.Enabled = true;
            }
            else if (selectFunction == 2)
            {
                if (dgvData.DataSource == null)
                {
                    selectFunction = 0;
                    LoadFunction();
                    MessageBox.Show("Hiện chưa có dử liệu để chỉnh sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvData.SelectedRows.Count < 0)
                {
                    selectFunction = 0;
                    LoadFunction();
                    MessageBox.Show("Vui lòng chọn sinh viên cần chỉnh sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    txtMaSV.ReadOnly = true;
                    txtTenSV.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtSoDT.ReadOnly = false;
                    txtDiaChi.ReadOnly = false;
                    rbtGTNam.Enabled = true;
                    rbtGTNu.Enabled = true;
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnUploadPicture.Enabled = true;

                    txtMaSV.Text = dgvData.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                    txtTenSV.Text = dgvData.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
                    txtEmail.Text = dgvData.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
                    txtSoDT.Text = dgvData.SelectedCells[0].OwningRow.Cells[3].Value.ToString();
                    txtDiaChi.Text = dgvData.SelectedCells[0].OwningRow.Cells[5].Value.ToString();
                    rbtGTNam.Checked = (dgvData.SelectedCells[0].OwningRow.Cells[4].Value.ToString() == "Nam");
                    rbtGTNu.Checked = !(dgvData.SelectedCells[0].OwningRow.Cells[4].Value.ToString() == "Nam");

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            string query = @"SELECT Hinh FROM SINHVIEN WHERE MaSV = @MaSV";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@MaSV", dgvData.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                                dynamic data = cmd.ExecuteScalar();

                                imageData = data;
                                LoadPictureBox();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch
                {
                    selectFunction = 0;
                    LoadFunction();
                    MessageBox.Show("Vui lòng chọn sinh viên cần chỉnh sửa");
                    return;
                }
            }
            else
            {
                txtMaSV.ReadOnly = true;
                txtTenSV.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtSoDT.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                rbtGTNam.Enabled = false;
                rbtGTNu.Enabled = false;
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnUploadPicture.Enabled = false;

                txtMaSV.Text = "";
                txtTenSV.Text = "";
                txtEmail.Text = "";
                txtSoDT.Text = "";
                txtDiaChi.Text = "";
                rbtGTNam.Checked = true;
                rbtGTNu.Checked = false;

                imageData = null;
                LoadPictureBox();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (selectFunction == 0)
            {
                selectFunction = 1;                
                LoadFunction();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectFunction == 0)
            {
                selectFunction = 2;
                LoadFunction();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectFunction != 0)
            {
                selectFunction = 0;
                LoadFunction();
            }
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog file = new OpenFileDialog())
                {
                    file.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                    file.RestoreDirectory = true;

                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        imageData = File.ReadAllBytes(file.FileName);

                        LoadPictureBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPictureBox()
        {
            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        if (picStudentPicture.Image != null)
                        {
                            picStudentPicture.Image.Dispose();
                        }

                        picStudentPicture.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (picStudentPicture.Image != null)
                {
                    picStudentPicture.Image.Dispose();
                    picStudentPicture.Image = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectFunction == 1)
            {
                try
                {
                    string maSV = txtMaSV.Text;
                    string tenSV = txtTenSV.Text;
                    string email = txtEmail.Text;
                    string soDT = txtSoDT.Text;
                    bool gioiTinh = rbtGTNam.Checked;
                    string diaChi = txtDiaChi.Text;

                    if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(soDT) || string.IsNullOrEmpty(diaChi) || imageData == null)
                    {
                        List<string> emptyList = new List<string>();
                        if (string.IsNullOrEmpty(maSV))
                        {
                            emptyList.Add("mã sinh viên");
                        }
                        if (string.IsNullOrEmpty(tenSV))
                        {
                            emptyList.Add("tên sinh viên");
                        }
                        if (string.IsNullOrEmpty(email))
                        {
                            emptyList.Add("email");
                        }
                        if (string.IsNullOrEmpty(soDT))
                        {
                            emptyList.Add("số điện thoại");
                        }
                        if (string.IsNullOrEmpty(diaChi))
                        {
                            emptyList.Add("địa chỉ");
                        }
                        if (imageData == null)
                        {
                            emptyList.Add("ảnh đại diện");
                        }

                        string emptyMessage = "Bạn cần thêm ";
                        for (int i = 0; i < emptyList.Count; i++)
                        {
                            if (i == (emptyList.Count - 1))
                            {
                                emptyMessage += $"{emptyList[i]} của sinh viên";
                            }
                            else
                            {
                                emptyMessage += $"{emptyList[i]}, ";
                            }
                        }
                        MessageBox.Show(emptyMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!CheckStudentID(maSV))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsValidEmail(email))
                    {
                        MessageBox.Show("Email không đúng định dạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsValidPhoneNumber(soDT))
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = @"INSERT INTO SINHVIEN VALUES (@MaSV, @TenSV, @Email, @SoDT, @GioiTinh, @DiaChi, @Hinh)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);
                            cmd.Parameters.AddWithValue("@TenSV", tenSV);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@SoDT", soDT);
                            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                            cmd.Parameters.AddWithValue("@Hinh", imageData);

                            int row = cmd.ExecuteNonQuery();

                            if (row < 0)
                            {
                                MessageBox.Show("Thêm thông tin sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            selectFunction = 0;
                            LoadFunction();
                            LoadStudnetData();
                            MessageBox.Show("Thêm thông tin sinh viên thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectFunction == 2)
            {
                try
                {
                    string maSV = dgvData.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                    string tenSV = txtTenSV.Text;
                    string email = txtEmail.Text;
                    string soDT = txtSoDT.Text;
                    bool gioiTinh = rbtGTNam.Checked;
                    string diaChi = txtDiaChi.Text;

                    if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(soDT) || string.IsNullOrEmpty(diaChi) || imageData == null)
                    {
                        List<string> emptyList = new List<string>();
                        if (string.IsNullOrEmpty(maSV))
                        {
                            emptyList.Add("mã sinh viên");
                        }
                        if (string.IsNullOrEmpty(tenSV))
                        {
                            emptyList.Add("tên sinh viên");
                        }
                        if (string.IsNullOrEmpty(email))
                        {
                            emptyList.Add("email");
                        }
                        if (string.IsNullOrEmpty(soDT))
                        {
                            emptyList.Add("số điện thoại");
                        }
                        if (string.IsNullOrEmpty(diaChi))
                        {
                            emptyList.Add("địa chỉ");
                        }
                        if (imageData == null)
                        {
                            emptyList.Add("ảnh đại diện");
                        }

                        string emptyMessage = "Bạn cần thêm ";
                        for (int i = 0; i < emptyList.Count; i++)
                        {
                            if (i == (emptyList.Count - 1))
                            {
                                emptyMessage += $"{emptyList[i]} của sinh viên";
                            }
                            else
                            {
                                emptyMessage += $"{emptyList[i]}, ";
                            }
                        }
                        MessageBox.Show(emptyMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsValidEmail(email))
                    {
                        MessageBox.Show("Email không đúng định dạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsValidPhoneNumber(soDT))
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = @"UPDATE SINHVIEN SET HoTen = @TenSV, Email = @Email, SoDT = @SoDT, GioiTinh = @GioiTinh, DiaChi = @DiaChi, Hinh = @Hinh WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);
                            cmd.Parameters.AddWithValue("@TenSV", tenSV);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@SoDT", soDT);
                            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                            cmd.Parameters.AddWithValue("@Hinh", imageData);

                            int row = cmd.ExecuteNonQuery();

                            if (row < 0)
                            {
                                MessageBox.Show("Cập nhật thông tin sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            selectFunction = 0;
                            LoadFunction();
                            LoadStudnetData();
                            MessageBox.Show("Cập nhật thông tin sinh viên thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckStudentID(string studentID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT MaSV FROM SINHVIEN WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", studentID);

                        dynamic exists = cmd.ExecuteScalar();
                        if (exists == null)
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = dgvData.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muống xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = @"DELETE FROM SINHVIEN WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);

                            int row = cmd.ExecuteNonQuery();

                            if (row < 0)
                            {
                                MessageBox.Show("Xóa thông tin sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            selectFunction = 0;
                            LoadFunction();
                            LoadStudnetData();
                            MessageBox.Show("Xóa thông tin sinh viên thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQLSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count < 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần hiển thị", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = dgvData.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần hiển thị", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmStudentProfile frm = new frmStudentProfile(maSV);
            frm.ShowDialog();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$");
        }
    }
}
