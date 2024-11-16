using System;
using System.Windows.Forms;

namespace Assignment.View
{
    public partial class frmUserProfile : Form
    {
        public frmUserProfile(string role, string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
            if (role == "CBDT")
            {
                txtRole.Text = "Cán bộ đào tạo";
            }
            else if (role == "GV")
            {
                txtRole.Text = "Giáo viên";
            }
            else
            {
                txtRole.Text = "Không xác định";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
