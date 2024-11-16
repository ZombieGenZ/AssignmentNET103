using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assignment.View
{
    public partial class frmStudentProfile : Form
    {
        string connectionString = Properties.Settings.Default.connectionString;
        public frmStudentProfile(string maSV)
        {
            InitializeComponent();
            LoadData(maSV);
        }
        private void LoadData(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string querySinhVien = "SELECT MaSV, HoTen, Email, SoDT, GioiTinh, DiaChi, Hinh FROM SINHVIEN WHERE MaSV = @MaSV";
                using (SqlCommand cmd = new SqlCommand(querySinhVien, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Close();
                            return;
                        }

                        while (reader.Read())
                        {
                            lblMaSV.Text = reader[0].ToString();
                            lblTenSV.Text = reader[1].ToString();
                            lblEmail.Text = reader[2].ToString();
                            lblSoDT.Text = reader[3].ToString();
                            lblGioiTinh.Text = (bool)reader[4] == true ? "Nam" : "Nữ";
                            lblDiaChi.Text = reader[5].ToString();

                            dynamic imageData = reader[6];

                            if (imageData != null)
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

                            break;
                        }
                    }
                }

                string queryDiem = "SELECT TiengAnh, TinHoc, GDTC, ((TiengAnh + TinHoc + GDTC) / 3) AS TongDiem FROM GRADE WHERE MaSV = @MaSV";
                using (SqlCommand cmd = new SqlCommand(queryDiem, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            lblDiemTiengAnh.Text = "Chưa nhập";
                            lblDiemTinHoc.Text = "Chưa nhập";
                            lblDiemGDTC.Text = "Chưa nhập";
                            lblTongDiem.Text = "Chưa xét";
                            lblShowTrangThai.Text = "Đang học";
                            lblShowTrangThai.ForeColor = Color.Blue;
                            return;
                        }

                        while (reader.Read())
                        {
                            float diemTiengAnh = float.Parse(reader[0].ToString());
                            float diemTinHoc = float.Parse(reader[1].ToString());
                            float diemGDTC = float.Parse(reader[2].ToString());
                            float tongDiem = float.Parse(reader[3].ToString());
                            lblDiemTiengAnh.Text = diemTiengAnh.ToString("N1");
                            lblDiemTiengAnh.ForeColor = diemTiengAnh >= 5 ? Color.Green : Color.Red;
                            lblDiemTinHoc.Text = diemTinHoc.ToString("N1");
                            lblDiemTinHoc.ForeColor = diemTinHoc >= 5 ? Color.Green : Color.Red;
                            lblDiemGDTC.Text = diemGDTC.ToString("N1");
                            lblDiemGDTC.ForeColor = diemGDTC >= 5 ? Color.Green : Color.Red;
                            lblTongDiem.Text = tongDiem.ToString("N1");
                            if (tongDiem >= 5)
                            {
                                lblShowTrangThai.Text = "Đạt";
                                lblShowTrangThai.ForeColor = Color.Green;
                            }
                            else
                            {
                                lblShowTrangThai.Text = "Trượt";
                                lblShowTrangThai.ForeColor = Color.Red;
                            }
                            break;
                        }
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
