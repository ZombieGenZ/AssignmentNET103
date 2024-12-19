using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment.View
{
    public partial class frmQLDiem : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private Form frm;
        private int selectFunction = 0;
        private int selectType = 0;
        private float tiengAnh = 0f;
        private float tinHoc = 0f;
        private float GDTC = 0f;
        private int studnetCount;
        private int currentStudent = 0;
        public frmQLDiem(Form frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmQLDiem_Load(object sender, EventArgs e)
        {
            LoadData();
            GetStudentCount();
            LoadSuggestTextBox();
        }

        private void LoadSuggestTextBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    string query = "SELECT MaSV FROM SINHVIEN";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

                            while (reader.Read())
                            {
                                source.Add(reader.GetString(0));
                            }

                            txtTimKiem.AutoCompleteCustomSource = source;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetStudentCount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(MaSV) FROM SINHVIEN";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        dynamic count = cmd.ExecuteScalar();

                        studnetCount = count;

                        if (studnetCount > 0)
                        {
                            btnNext.Enabled = true;
                            btnPrev.Enabled = true;
                            btnToStart.Enabled = true;
                            btnToEnd.Enabled = true;
                            LoadCurrentData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQLDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            frm.Show();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT TOP 3 SV.MaSV, SV.HoTen, FORMAT(GD.TiengAnh, 'N1'), FORMAT(GD.TinHoc, 'N1'), FORMAT(GD.GDTC, 'N1'), FORMAT(((GD.TiengAnh + TinHoc + GDTC) / 3), 'N2') FROM SINHVIEN SV JOIN GRADE GD ON SV.MaSV = GD.MaSV ORDER BY ((GD.TiengAnh + GD.TinHoc + GD.GDTC) / 3) DESC";
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    dgvTOPSV.DataSource = dt;

                    dgvTOPSV.Columns[0].HeaderText = "Mã SV";
                    dgvTOPSV.Columns[1].HeaderText = "Họ tên";
                    dgvTOPSV.Columns[2].HeaderText = "Tiếng anh";
                    dgvTOPSV.Columns[3].HeaderText = "Tin học";
                    dgvTOPSV.Columns[4].HeaderText = "GDTC";
                    dgvTOPSV.Columns[5].HeaderText = "Điểm TB";
                }
                else
                {
                    dgvTOPSV.DataSource = null;
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtTimKiem.Text;

                if (string.IsNullOrWhiteSpace(maSV))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string queryFindSinhVien = "SELECT MaSV, HoTen FROM SINHVIEN WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(queryFindSinhVien, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show($"Không tìm thấy sinh viên với mã sinh viên {maSV}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                selectType = 0;
                                return;
                            }

                            while (reader.Read())
                            {
                                lblShowTenSV.Text = reader[1].ToString();
                                txtMaSV.Text = reader[0].ToString();
                                selectFunction = 0;
                                btnShow.Enabled = true;
                                break;
                            }
                        }
                    }

                    string queryFindIndex = @"WITH OrderedData AS (SELECT MaSV, ROW_NUMBER() OVER (ORDER BY MaSV ASC) AS RowNumber FROM SINHVIEN) SELECT RowNumber - 1 FROM OrderedData WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(queryFindIndex, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);

                        currentStudent = int.Parse(cmd.ExecuteScalar().ToString());
                    }

                    string queryFindGrade = @"SELECT TiengAnh, TinHoc, GDTC, ((TiengAnh + TinHoc + GDTC) / 3) AS TongDiem FROM GRADE WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(queryFindGrade, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                txtTiengAnh.Text = "Chưa nhập";
                                txtTinHoc.Text = "Chưa nhập";
                                txtGDTC.Text = "Chưa nhập";
                                lblShowTongDiem.Text = "Chưa xét";
                                selectType = 1;
                                LoadFunction();
                                return;
                            }

                            while (reader.Read())
                            {
                                tiengAnh = float.Parse(reader[0].ToString());
                                txtTiengAnh.Text = tiengAnh.ToString("N1");
                                tinHoc = float.Parse(reader[1].ToString());
                                txtTinHoc.Text = tinHoc.ToString("N1");
                                GDTC = float.Parse(reader[2].ToString());
                                txtGDTC.Text = GDTC.ToString("N1");
                                lblShowTongDiem.Text = ((tiengAnh + tinHoc + GDTC) / 3).ToString("N1");
                                selectType = 2;
                                LoadFunction();
                                break;
                            }
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
            if (selectFunction == 0 && selectType == 1)
            {
                txtTiengAnh.ReadOnly = true;
                txtTinHoc.ReadOnly = true;
                txtGDTC.ReadOnly = true;

                lblShowTongDiem.Text = "Chưa xét";
                txtTiengAnh.Text = "Chưa nhập";
                txtTinHoc.Text = "Chưa nhập";
                txtGDTC.Text = "Chưa nhập";

                btnNew.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnShow.Enabled = true;
            }
            else if (selectFunction == 0 && selectType == 2)
            {
                txtTiengAnh.ReadOnly = true;
                txtTinHoc.ReadOnly = true;
                txtGDTC.ReadOnly = true;

                lblShowTongDiem.Text = ((tiengAnh + tinHoc + GDTC) / 3).ToString("N1");
                txtTiengAnh.Text = tiengAnh.ToString("N1");
                txtTinHoc.Text = tinHoc.ToString("N1");
                txtGDTC.Text = GDTC.ToString("N1");

                btnNew.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnShow.Enabled = true;
            }
            else if (selectFunction == 1 && selectType == 1)
            {
                txtTiengAnh.ReadOnly = false;
                txtTinHoc.ReadOnly = false;
                txtGDTC.ReadOnly = false;

                txtTiengAnh.Text = "";
                txtTinHoc.Text = "";
                txtGDTC.Text = "";

                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
                btnShow.Enabled = false;
            }
            else if (selectFunction == 2 && selectType == 2)
            {
                txtTiengAnh.ReadOnly = false;
                txtTinHoc.ReadOnly = false;
                txtGDTC.ReadOnly = false;

                lblShowTongDiem.Text = ((tiengAnh + tinHoc + GDTC) / 3).ToString("N1");
                txtTiengAnh.Text = tiengAnh.ToString();
                txtTinHoc.Text = tinHoc.ToString();
                txtGDTC.Text = GDTC.ToString();

                btnNew.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
                btnShow.Enabled = false;
            }
            else
            {
                txtMaSV.ReadOnly = true;
                txtTiengAnh.ReadOnly = true;
                txtTinHoc.ReadOnly = true;
                txtGDTC.ReadOnly = true;

                lblShowTenSV.Text = "";
                lblShowTongDiem.Text = "";
                txtMaSV.Text = "";
                txtTiengAnh.Text = "";
                txtTinHoc.Text = "";
                txtGDTC.Text = "";

                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnShow.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (selectFunction == 0 && selectType == 1)
            {
                selectFunction = 1;
                LoadFunction();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectFunction == 0 && selectType == 2)
            {
                try
                {
                    string maSV_Input = txtMaSV.Text;

                    if (string.IsNullOrWhiteSpace(maSV_Input))
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

                            string query = "DELETE FROM GRADE WHERE MaSV = @MaSV";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@MaSV", maSV_Input);

                                int row = cmd.ExecuteNonQuery();

                                if (row < 0)
                                {
                                    MessageBox.Show("Xóa điểm thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                tiengAnh = 0;
                                tinHoc = 0;
                                GDTC = 0;
                                selectType = 1;
                                selectFunction = 0;
                                LoadFunction();
                                LoadData();
                                MessageBox.Show("Xóa điểm thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectFunction == 0 && selectType == 2)
            {
                selectFunction = 2;
                LoadFunction();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectFunction == 1 && selectType == 1)
            {
                try
                {
                    string maSV_Input = txtMaSV.Text;
                    string tiengAnh_Input = txtTiengAnh.Text;
                    string tinHoc_Input = txtTinHoc.Text;
                    string gdtc_Input = txtGDTC.Text;

                    if (string.IsNullOrWhiteSpace(maSV_Input) || string.IsNullOrWhiteSpace(tiengAnh_Input) || string.IsNullOrWhiteSpace(tinHoc_Input) || string.IsNullOrWhiteSpace(gdtc_Input))
                    {
                        List<string> errorList = new List<string>();
                        if (string.IsNullOrWhiteSpace(maSV_Input))
                        {
                            errorList.Add("mã sinh viên");
                        }
                        if (string.IsNullOrWhiteSpace(tiengAnh_Input))
                        {
                            errorList.Add("điểm tiếng anh");
                        }
                        if (string.IsNullOrWhiteSpace(tinHoc_Input))
                        {
                            errorList.Add("điểm tin học");
                        }
                        if (string.IsNullOrWhiteSpace(gdtc_Input))
                        {
                            errorList.Add("điểm giáo dục thể chất");
                        }
                        string errorMessage = "Bạn không được để trống ";
                        for (int i = 0; i < errorList.Count; i++)
                        {
                            if (i == (errorList.Count - 1))
                            {
                                errorMessage += errorList[i];
                            }
                            else
                            {
                                errorMessage += $"{errorList[i]}, ";
                            }
                        }
                        MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    float tiengAnh_Output;
                    float tinHoc_Output;
                    float gdtc_Output;

                    if (!float.TryParse(tiengAnh_Input, out tiengAnh_Output) || !float.TryParse(tinHoc_Input, out tinHoc_Output) || !float.TryParse(gdtc_Input, out gdtc_Output))
                    {
                        List<string> errorList = new List<string>();
                        if (!float.TryParse(tiengAnh_Input, out tiengAnh_Output))
                        {
                            errorList.Add("điểm tiếng anh");
                        }
                        if (!float.TryParse(tinHoc_Input, out tinHoc_Output))
                        {
                            errorList.Add("điểm tin học");
                        }
                        if (!float.TryParse(gdtc_Input, out gdtc_Output))
                        {
                            errorList.Add("điểm giáo dục thể chất");
                        }
                        string errorMessage = "Bạn phải nhập ";
                        for (int i = 0; i < errorList.Count; i++)
                        {
                            if (i == (errorList.Count - 1))
                            {
                                errorMessage += errorList[i];
                            }
                            else
                            {
                                errorMessage += $"{errorList[i]}, ";
                            }
                        }
                        errorMessage += " là số";
                        MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (tiengAnh_Output < 0 || tiengAnh_Output > 10 || tinHoc_Output < 0 || tinHoc_Output > 10 || gdtc_Output < 0 || gdtc_Output > 10)
                    {
                        List<string> errorList = new List<string>();

                        if (tiengAnh_Output < 0 || tiengAnh_Output > 10)
                        {
                            errorList.Add("điểm tiếng anh");
                        }
                        if (tinHoc_Output < 0 || tinHoc_Output > 10)
                        {
                            errorList.Add("điểm tin học");
                        }
                        if (gdtc_Output < 0 || gdtc_Output > 10)
                        {
                            errorList.Add("điểm giáo dục quốc phòng");
                        }
                        string errorMessage = "Bạn phải nhập ";
                        for (int i = 0; i < errorList.Count; i++)
                        {
                            if (i == (errorList.Count - 1))
                            {
                                errorMessage += errorList[i];
                            }
                            else
                            {
                                errorMessage += $"{errorList[i]}, ";
                            }
                        }
                        errorMessage += " là số từ 0.0 đến 10.0";
                        MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "INSERT INTO GRADE (MaSV, TiengAnh, TinHoc, GDTC) VALUES (@MaSV, @TiengAnh, @TinHoc, @GDTC)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV_Input);
                            cmd.Parameters.AddWithValue("@TiengAnh", tiengAnh_Output);
                            cmd.Parameters.AddWithValue("@TinHoc", tinHoc_Output);
                            cmd.Parameters.AddWithValue("@GDTC", gdtc_Output);

                            int row = cmd.ExecuteNonQuery();

                            if (row < 0)
                            {
                                MessageBox.Show("Thêm điểm thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            tiengAnh = tiengAnh_Output;
                            tinHoc = tinHoc_Output;
                            GDTC = gdtc_Output;
                            selectType = 2;
                            selectFunction = 0;
                            LoadFunction();
                            LoadData();
                            MessageBox.Show("Thêm điểm thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectFunction == 2 && selectType == 2)
            {
                try
                {
                    string maSV_Input = txtMaSV.Text;
                    string tiengAnh_Input = txtTiengAnh.Text;
                    string tinHoc_Input = txtTinHoc.Text;
                    string gdtc_Input = txtGDTC.Text;

                    if (string.IsNullOrWhiteSpace(maSV_Input) || string.IsNullOrWhiteSpace(tiengAnh_Input) || string.IsNullOrWhiteSpace(tinHoc_Input) || string.IsNullOrWhiteSpace(gdtc_Input))
                    {
                        List<string> errorList = new List<string>();
                        if (string.IsNullOrWhiteSpace(maSV_Input))
                        {
                            errorList.Add("mã sinh viên");
                        }
                        if (string.IsNullOrWhiteSpace(tiengAnh_Input))
                        {
                            errorList.Add("điểm tiếng anh");
                        }
                        if (string.IsNullOrWhiteSpace(tinHoc_Input))
                        {
                            errorList.Add("điểm tin học");
                        }
                        if (string.IsNullOrWhiteSpace(gdtc_Input))
                        {
                            errorList.Add("điểm giáo dục thể chất");
                        }
                        string errorMessage = "Bạn không được để trống ";
                        for (int i = 0; i < errorList.Count; i++)
                        {
                            if (i == (errorList.Count - 1))
                            {
                                errorMessage += errorList[i];
                            }
                            else
                            {
                                errorMessage += $"{errorList[i]}, ";
                            }
                        }
                        MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    float tiengAnh_Output;
                    float tinHoc_Output;
                    float gdtc_Output;

                    if (!float.TryParse(tiengAnh_Input, out tiengAnh_Output) || !float.TryParse(tinHoc_Input, out tinHoc_Output) || !float.TryParse(gdtc_Input, out gdtc_Output))
                    {
                        List<string> errorList = new List<string>();
                        if (!float.TryParse(tiengAnh_Input, out tiengAnh_Output))
                        {
                            errorList.Add("điểm tiếng anh");
                        }
                        if (!float.TryParse(tinHoc_Input, out tinHoc_Output))
                        {
                            errorList.Add("điểm tin học");
                        }
                        if (!float.TryParse(gdtc_Input, out gdtc_Output))
                        {
                            errorList.Add("điểm giáo dục thể chất");
                        }
                        string errorMessage = "Bạn phải nhập ";
                        for (int i = 0; i < errorList.Count; i++)
                        {
                            if (i == (errorList.Count - 1))
                            {
                                errorMessage += errorList[i];
                            }
                            else
                            {
                                errorMessage += $"{errorList[i]}, ";
                            }
                        }
                        errorMessage += " là số";
                        MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (tiengAnh_Output < 0 || tiengAnh_Output > 10 || tinHoc_Output < 0 || tinHoc_Output > 10 || gdtc_Output < 0 || gdtc_Output > 10)
                    {
                        List<string> errorList = new List<string>();

                        if (tiengAnh_Output < 0 || tiengAnh_Output > 10)
                        {
                            errorList.Add("điểm tiếng anh");
                        }
                        if (tinHoc_Output < 0 || tinHoc_Output > 10)
                        {
                            errorList.Add("điểm tin học");
                        }
                        if (gdtc_Output < 0 || gdtc_Output > 10)
                        {
                            errorList.Add("điểm giáo dục quốc phòng");
                        }
                        string errorMessage = "Bạn phải nhập ";
                        for (int i = 0; i < errorList.Count; i++)
                        {
                            if (i == (errorList.Count - 1))
                            {
                                errorMessage += errorList[i];
                            }
                            else
                            {
                                errorMessage += $"{errorList[i]}, ";
                            }
                        }
                        errorMessage += " là số từ 0.0 đến 10.0";
                        MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "UPDATE GRADE SET TiengAnh = @TiengAnh, TinHoc = @TinHoc, GDTC = @GDTC WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV_Input);
                            cmd.Parameters.AddWithValue("@TiengAnh", tiengAnh_Output);
                            cmd.Parameters.AddWithValue("@TinHoc", tinHoc_Output);
                            cmd.Parameters.AddWithValue("@GDTC", gdtc_Output);

                            int row = cmd.ExecuteNonQuery();

                            if (row < 0)
                            {
                                MessageBox.Show("Cập nhật điểm thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            tiengAnh = tiengAnh_Output;
                            tinHoc = tinHoc_Output;
                            GDTC = gdtc_Output;
                            selectType = 2;
                            selectFunction = 0;
                            LoadFunction();
                            LoadData();
                            MessageBox.Show("Cập nhật điểm thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectFunction != 0 && selectType != 0)
            {
                //try
                //{
                //    string tiengAnh_Input = txtTiengAnh.Text;
                //    string tinHoc_Input = txtTinHoc.Text;
                //    string gdtc_Input = txtGDTC.Text;

                //    if (!string.IsNullOrWhiteSpace(tiengAnh_Input) || !string.IsNullOrWhiteSpace(tinHoc_Input) || !string.IsNullOrWhiteSpace(gdtc_Input))
                //    {
                //        DialogResult result = MessageBox.Show("Bạn có chắc chắn muống hũy? Dử liệu đang chỉnh sửa sẽ biến mất và không thể khôi phục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //        if (result != DialogResult.Yes)
                //        {
                //            return;
                //        }
                //    }

                //    selectFunction = 0;
                //    LoadFunction();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                selectFunction = 0;
                LoadFunction();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;

            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xem chi tiết", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmStudentProfile frm = new frmStudentProfile(maSV);
            frm.ShowDialog();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((currentStudent - 1) >= 0)
            {
                currentStudent--;
                LoadCurrentData();
            }
        }

        private void btnToEnd_Click(object sender, EventArgs e)
        {
            currentStudent = (studnetCount - 1);
            LoadCurrentData();
        }

        private void btnToStart_Click(object sender, EventArgs e)
        {
            currentStudent = 0;
            LoadCurrentData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((currentStudent + 1) < studnetCount)
            {
                currentStudent++;
                LoadCurrentData();
            }
        }

        private void LoadCurrentData()
        {
            if (currentStudent >= 0 && currentStudent < studnetCount)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                        string maSV = null;

                        string queryFindSinhVien = "SELECT MaSV, HoTen FROM SINHVIEN ORDER BY MaSV ASC OFFSET @Row ROWS FETCH NEXT 1 ROWS ONLY";
                        using (SqlCommand cmd = new SqlCommand(queryFindSinhVien, conn))
                        {
                            cmd.Parameters.AddWithValue("@Row", currentStudent);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    selectType = 0;
                                    return;
                                }

                                while (reader.Read())
                                {
                                    maSV = reader[0].ToString();
                                    lblShowTenSV.Text = reader[1].ToString();
                                    txtMaSV.Text = maSV;
                                    selectFunction = 0;
                                    btnShow.Enabled = true;
                                    break;
                                }
                            }
                        }

                        string queryFindGrade = @"SELECT TiengAnh, TinHoc, GDTC, ((TiengAnh + TinHoc + GDTC) / 3) AS TongDiem FROM GRADE WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(queryFindGrade, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    txtTiengAnh.Text = "Chưa nhập";
                                    txtTinHoc.Text = "Chưa nhập";
                                    txtGDTC.Text = "Chưa nhập";
                                    lblShowTongDiem.Text = "Chưa xét";
                                    selectType = 1;
                                    LoadFunction();
                                    return;
                                }

                                while (reader.Read())
                                {
                                    tiengAnh = float.Parse(reader[0].ToString());
                                    txtTiengAnh.Text = tiengAnh.ToString("N1");
                                    tinHoc = float.Parse(reader[1].ToString());
                                    txtTinHoc.Text = tinHoc.ToString("N1");
                                    GDTC = float.Parse(reader[2].ToString());
                                    txtGDTC.Text = GDTC.ToString("N1");
                                    lblShowTongDiem.Text = ((tiengAnh + tinHoc + GDTC) / 3).ToString("N1");
                                    selectType = 2;
                                    LoadFunction();
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTOPSV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTOPSV.SelectedRows.Count > 0)
            {
                try
                {
                    string maSV = dgvTOPSV.SelectedRows[0].Cells[0].Value.ToString();

                    if (string.IsNullOrWhiteSpace(maSV))
                    {
                        MessageBox.Show("Vui lòng chọn sinh viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string queryFindSinhVien = "SELECT MaSV, HoTen FROM SINHVIEN WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(queryFindSinhVien, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("Vui lòng chọn sinh viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    selectType = 0;
                                    return;
                                }

                                while (reader.Read())
                                {
                                    lblShowTenSV.Text = reader[1].ToString();
                                    txtMaSV.Text = reader[0].ToString();
                                    selectFunction = 0;
                                    btnShow.Enabled = true;
                                    break;
                                }
                            }
                        }

                        string queryFindIndex = @"WITH OrderedData AS (SELECT MaSV, ROW_NUMBER() OVER (ORDER BY MaSV ASC) AS RowNumber FROM SINHVIEN) SELECT RowNumber - 1 FROM OrderedData WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(queryFindIndex, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);

                            currentStudent = int.Parse(cmd.ExecuteScalar().ToString());
                        }

                        string queryFindGrade = @"SELECT TiengAnh, TinHoc, GDTC, ((TiengAnh + TinHoc + GDTC) / 3) AS TongDiem FROM GRADE WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(queryFindGrade, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    txtTiengAnh.Text = "Chưa nhập";
                                    txtTinHoc.Text = "Chưa nhập";
                                    txtGDTC.Text = "Chưa nhập";
                                    lblShowTongDiem.Text = "Chưa xét";
                                    selectType = 1;
                                    LoadFunction();
                                    return;
                                }

                                while (reader.Read())
                                {
                                    tiengAnh = float.Parse(reader[0].ToString());
                                    txtTiengAnh.Text = tiengAnh.ToString("N1");
                                    tinHoc = float.Parse(reader[1].ToString());
                                    txtTinHoc.Text = tinHoc.ToString("N1");
                                    GDTC = float.Parse(reader[2].ToString());
                                    txtGDTC.Text = GDTC.ToString("N1");
                                    lblShowTongDiem.Text = ((tiengAnh + tinHoc + GDTC) / 3).ToString("N1");
                                    selectType = 2;
                                    LoadFunction();
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void inputDiem_TextChanged(object sender, EventArgs e)
        {
            if ((selectFunction == 1 && selectType == 1) || (selectFunction == 2 && selectType == 2))
            {
                try
                {
                    float diemTiengAnh;
                    float diemTinHoc;
                    float diemGDTC;

                    if (string.IsNullOrWhiteSpace(txtTiengAnh.Text) || string.IsNullOrWhiteSpace(txtTinHoc.Text) || string.IsNullOrWhiteSpace(txtGDTC.Text))
                    {
                        lblShowTongDiem.Text = "Chưa xét";
                        return;
                    }

                    if (!float.TryParse(txtTiengAnh.Text, out diemTiengAnh) || !float.TryParse(txtTinHoc.Text, out diemTinHoc) || !float.TryParse(txtGDTC.Text, out diemGDTC))
                    {
                        lblShowTongDiem.Text = "Chưa xét";
                        return;
                    }

                    if (diemTiengAnh < 0 || diemTiengAnh > 10 || diemTinHoc < 0 || diemTinHoc > 10 || diemGDTC < 0 || diemGDTC > 10)
                    {
                        lblShowTongDiem.Text = "Chưa xét";
                        return;
                    }

                    float tongDiem = (diemTiengAnh + diemTinHoc + diemGDTC) / 3;
                    lblShowTongDiem.Text = tongDiem.ToString("N1");
                }
                catch
                {
                    lblShowTongDiem.Text = "Chưa xét";
                    return;
                }
            }
        }
    }
}
