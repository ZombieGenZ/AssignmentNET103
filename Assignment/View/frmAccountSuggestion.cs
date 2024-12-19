using System;
using System.Windows.Forms;

namespace Assignment.View
{
    public partial class frmAccountSuggestion : Form
    {
        private frmLogin frmLogin;
        private bool adminShowPassword = false;
        private bool cbdtShowPassword = false;
        private bool gvShowPassword = false;
        public frmAccountSuggestion(frmLogin frm)
        {
            InitializeComponent();
            frmLogin = frm;
        }

        private void btnADMINShowPassword_Click(object sender, EventArgs e)
        {
            adminShowPassword = !adminShowPassword;

            if (adminShowPassword)
            {
                txtAdminPassword.PasswordChar = '\0';
                btnADMINShowPassword.Image = Properties.Resources.hidden;
            }
            else
            {
                txtAdminPassword.PasswordChar = '*';
                btnADMINShowPassword.Image = Properties.Resources.eye;
            }
        }

        private void btnCBDTShowPassword_Click(object sender, EventArgs e)
        {
            cbdtShowPassword = !cbdtShowPassword;

            if (cbdtShowPassword)
            {
                txtCBDTPassword.PasswordChar = '\0';
                btnCBDTShowPassword.Image = Properties.Resources.hidden;
            }
            else
            {
                txtCBDTPassword.PasswordChar = '*';
                btnCBDTShowPassword.Image = Properties.Resources.eye;
            }
        }

        private void btnGVShowPassword_Click(object sender, EventArgs e)
        {
            gvShowPassword = !gvShowPassword;

            if (gvShowPassword)
            {
                txtGVPassword.PasswordChar = '\0';
                btnGVShowPassword.Image = Properties.Resources.hidden;
            }
            else
            {
                txtGVPassword.PasswordChar = '*';
                btnGVShowPassword.Image = Properties.Resources.eye;
            }
        }

        private void btnAdminSelect_Click(object sender, EventArgs e)
        {
            frmLogin.txtUsername.Text = txtAdminUsername.Text;
            frmLogin.txtPassword.Text = txtAdminPassword.Text;

            Close();
        }

        private void btnCBDTSelect_Click(object sender, EventArgs e)
        {
            frmLogin.txtUsername.Text = txtCBDTUsername.Text;
            frmLogin.txtPassword.Text = txtCBDTPassword.Text;

            Close();
        }

        private void btnGVSelect_Click(object sender, EventArgs e)
        {
            frmLogin.txtUsername.Text = txtGVUsername.Text;
            frmLogin.txtPassword.Text = txtGVPassword.Text;

            Close();
        }
    }
}
