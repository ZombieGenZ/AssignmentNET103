namespace Assignment.View
{
    partial class frmAccountSuggestion
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
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.btnAdminSelect = new System.Windows.Forms.Button();
            this.btnADMINShowPassword = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.grbCBDT = new System.Windows.Forms.GroupBox();
            this.btnCBDTSelect = new System.Windows.Forms.Button();
            this.btnCBDTShowPassword = new System.Windows.Forms.Button();
            this.txtCBDTPassword = new System.Windows.Forms.TextBox();
            this.txtCBDTUsername = new System.Windows.Forms.TextBox();
            this.lblCBDTPassword = new System.Windows.Forms.Label();
            this.lblCBDTUsername = new System.Windows.Forms.Label();
            this.grbGV = new System.Windows.Forms.GroupBox();
            this.btnGVSelect = new System.Windows.Forms.Button();
            this.btnGVShowPassword = new System.Windows.Forms.Button();
            this.txtGVPassword = new System.Windows.Forms.TextBox();
            this.txtGVUsername = new System.Windows.Forms.TextBox();
            this.lblGVPassword = new System.Windows.Forms.Label();
            this.lblGVUsername = new System.Windows.Forms.Label();
            this.grbAdmin.SuspendLayout();
            this.grbCBDT.SuspendLayout();
            this.grbGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btnAdminSelect);
            this.grbAdmin.Controls.Add(this.btnADMINShowPassword);
            this.grbAdmin.Controls.Add(this.txtAdminPassword);
            this.grbAdmin.Controls.Add(this.txtAdminUsername);
            this.grbAdmin.Controls.Add(this.lblAdminPassword);
            this.grbAdmin.Controls.Add(this.lblAdminUsername);
            this.grbAdmin.Location = new System.Drawing.Point(12, 12);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(347, 123);
            this.grbAdmin.TabIndex = 0;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Tài khoản ADMIN (Test only)";
            // 
            // btnAdminSelect
            // 
            this.btnAdminSelect.Location = new System.Drawing.Point(137, 88);
            this.btnAdminSelect.Name = "btnAdminSelect";
            this.btnAdminSelect.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSelect.TabIndex = 9;
            this.btnAdminSelect.Text = "Sử dụng";
            this.btnAdminSelect.UseVisualStyleBackColor = true;
            this.btnAdminSelect.Click += new System.EventHandler(this.btnAdminSelect_Click);
            // 
            // btnADMINShowPassword
            // 
            this.btnADMINShowPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnADMINShowPassword.FlatAppearance.BorderSize = 0;
            this.btnADMINShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADMINShowPassword.Image = global::Assignment.Properties.Resources.eye;
            this.btnADMINShowPassword.Location = new System.Drawing.Point(260, 60);
            this.btnADMINShowPassword.Name = "btnADMINShowPassword";
            this.btnADMINShowPassword.Size = new System.Drawing.Size(38, 22);
            this.btnADMINShowPassword.TabIndex = 8;
            this.btnADMINShowPassword.TabStop = false;
            this.btnADMINShowPassword.UseVisualStyleBackColor = false;
            this.btnADMINShowPassword.Click += new System.EventHandler(this.btnADMINShowPassword_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(98, 60);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.ReadOnly = true;
            this.txtAdminPassword.Size = new System.Drawing.Size(200, 22);
            this.txtAdminPassword.TabIndex = 3;
            this.txtAdminPassword.TabStop = false;
            this.txtAdminPassword.Text = "ADMIN@123";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(101, 30);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.ReadOnly = true;
            this.txtAdminUsername.Size = new System.Drawing.Size(197, 22);
            this.txtAdminUsername.TabIndex = 2;
            this.txtAdminUsername.TabStop = false;
            this.txtAdminUsername.Text = "ADMIN1";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Location = new System.Drawing.Point(22, 63);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(70, 16);
            this.lblAdminPassword.TabIndex = 1;
            this.lblAdminPassword.Text = "Password:";
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Location = new System.Drawing.Point(22, 30);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(73, 16);
            this.lblAdminUsername.TabIndex = 0;
            this.lblAdminUsername.Text = "Username:";
            // 
            // grbCBDT
            // 
            this.grbCBDT.Controls.Add(this.btnCBDTSelect);
            this.grbCBDT.Controls.Add(this.btnCBDTShowPassword);
            this.grbCBDT.Controls.Add(this.txtCBDTPassword);
            this.grbCBDT.Controls.Add(this.txtCBDTUsername);
            this.grbCBDT.Controls.Add(this.lblCBDTPassword);
            this.grbCBDT.Controls.Add(this.lblCBDTUsername);
            this.grbCBDT.Location = new System.Drawing.Point(12, 141);
            this.grbCBDT.Name = "grbCBDT";
            this.grbCBDT.Size = new System.Drawing.Size(347, 123);
            this.grbCBDT.TabIndex = 10;
            this.grbCBDT.TabStop = false;
            this.grbCBDT.Text = "Tài khoản CBĐT";
            // 
            // btnCBDTSelect
            // 
            this.btnCBDTSelect.Location = new System.Drawing.Point(137, 88);
            this.btnCBDTSelect.Name = "btnCBDTSelect";
            this.btnCBDTSelect.Size = new System.Drawing.Size(75, 23);
            this.btnCBDTSelect.TabIndex = 9;
            this.btnCBDTSelect.Text = "Sử dụng";
            this.btnCBDTSelect.UseVisualStyleBackColor = true;
            this.btnCBDTSelect.Click += new System.EventHandler(this.btnCBDTSelect_Click);
            // 
            // btnCBDTShowPassword
            // 
            this.btnCBDTShowPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCBDTShowPassword.FlatAppearance.BorderSize = 0;
            this.btnCBDTShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCBDTShowPassword.Image = global::Assignment.Properties.Resources.eye;
            this.btnCBDTShowPassword.Location = new System.Drawing.Point(260, 60);
            this.btnCBDTShowPassword.Name = "btnCBDTShowPassword";
            this.btnCBDTShowPassword.Size = new System.Drawing.Size(38, 22);
            this.btnCBDTShowPassword.TabIndex = 8;
            this.btnCBDTShowPassword.TabStop = false;
            this.btnCBDTShowPassword.UseVisualStyleBackColor = false;
            this.btnCBDTShowPassword.Click += new System.EventHandler(this.btnCBDTShowPassword_Click);
            // 
            // txtCBDTPassword
            // 
            this.txtCBDTPassword.Location = new System.Drawing.Point(98, 60);
            this.txtCBDTPassword.Name = "txtCBDTPassword";
            this.txtCBDTPassword.PasswordChar = '*';
            this.txtCBDTPassword.ReadOnly = true;
            this.txtCBDTPassword.Size = new System.Drawing.Size(200, 22);
            this.txtCBDTPassword.TabIndex = 3;
            this.txtCBDTPassword.TabStop = false;
            this.txtCBDTPassword.Text = "CBDT@123";
            // 
            // txtCBDTUsername
            // 
            this.txtCBDTUsername.Location = new System.Drawing.Point(101, 30);
            this.txtCBDTUsername.Name = "txtCBDTUsername";
            this.txtCBDTUsername.ReadOnly = true;
            this.txtCBDTUsername.Size = new System.Drawing.Size(197, 22);
            this.txtCBDTUsername.TabIndex = 2;
            this.txtCBDTUsername.TabStop = false;
            this.txtCBDTUsername.Text = "CBDT1";
            // 
            // lblCBDTPassword
            // 
            this.lblCBDTPassword.AutoSize = true;
            this.lblCBDTPassword.Location = new System.Drawing.Point(22, 63);
            this.lblCBDTPassword.Name = "lblCBDTPassword";
            this.lblCBDTPassword.Size = new System.Drawing.Size(70, 16);
            this.lblCBDTPassword.TabIndex = 1;
            this.lblCBDTPassword.Text = "Password:";
            // 
            // lblCBDTUsername
            // 
            this.lblCBDTUsername.AutoSize = true;
            this.lblCBDTUsername.Location = new System.Drawing.Point(22, 30);
            this.lblCBDTUsername.Name = "lblCBDTUsername";
            this.lblCBDTUsername.Size = new System.Drawing.Size(73, 16);
            this.lblCBDTUsername.TabIndex = 0;
            this.lblCBDTUsername.Text = "Username:";
            // 
            // grbGV
            // 
            this.grbGV.Controls.Add(this.btnGVSelect);
            this.grbGV.Controls.Add(this.btnGVShowPassword);
            this.grbGV.Controls.Add(this.txtGVPassword);
            this.grbGV.Controls.Add(this.txtGVUsername);
            this.grbGV.Controls.Add(this.lblGVPassword);
            this.grbGV.Controls.Add(this.lblGVUsername);
            this.grbGV.Location = new System.Drawing.Point(12, 280);
            this.grbGV.Name = "grbGV";
            this.grbGV.Size = new System.Drawing.Size(347, 123);
            this.grbGV.TabIndex = 11;
            this.grbGV.TabStop = false;
            this.grbGV.Text = "Tài khoản GV";
            // 
            // btnGVSelect
            // 
            this.btnGVSelect.Location = new System.Drawing.Point(137, 88);
            this.btnGVSelect.Name = "btnGVSelect";
            this.btnGVSelect.Size = new System.Drawing.Size(75, 23);
            this.btnGVSelect.TabIndex = 9;
            this.btnGVSelect.Text = "Sử dụng";
            this.btnGVSelect.UseVisualStyleBackColor = true;
            this.btnGVSelect.Click += new System.EventHandler(this.btnGVSelect_Click);
            // 
            // btnGVShowPassword
            // 
            this.btnGVShowPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGVShowPassword.FlatAppearance.BorderSize = 0;
            this.btnGVShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGVShowPassword.Image = global::Assignment.Properties.Resources.eye;
            this.btnGVShowPassword.Location = new System.Drawing.Point(260, 60);
            this.btnGVShowPassword.Name = "btnGVShowPassword";
            this.btnGVShowPassword.Size = new System.Drawing.Size(38, 22);
            this.btnGVShowPassword.TabIndex = 8;
            this.btnGVShowPassword.TabStop = false;
            this.btnGVShowPassword.UseVisualStyleBackColor = false;
            this.btnGVShowPassword.Click += new System.EventHandler(this.btnGVShowPassword_Click);
            // 
            // txtGVPassword
            // 
            this.txtGVPassword.Location = new System.Drawing.Point(98, 60);
            this.txtGVPassword.Name = "txtGVPassword";
            this.txtGVPassword.PasswordChar = '*';
            this.txtGVPassword.ReadOnly = true;
            this.txtGVPassword.Size = new System.Drawing.Size(200, 22);
            this.txtGVPassword.TabIndex = 3;
            this.txtGVPassword.TabStop = false;
            this.txtGVPassword.Text = "GV@123";
            // 
            // txtGVUsername
            // 
            this.txtGVUsername.Location = new System.Drawing.Point(101, 30);
            this.txtGVUsername.Name = "txtGVUsername";
            this.txtGVUsername.ReadOnly = true;
            this.txtGVUsername.Size = new System.Drawing.Size(197, 22);
            this.txtGVUsername.TabIndex = 2;
            this.txtGVUsername.TabStop = false;
            this.txtGVUsername.Text = "GV1";
            // 
            // lblGVPassword
            // 
            this.lblGVPassword.AutoSize = true;
            this.lblGVPassword.Location = new System.Drawing.Point(22, 63);
            this.lblGVPassword.Name = "lblGVPassword";
            this.lblGVPassword.Size = new System.Drawing.Size(70, 16);
            this.lblGVPassword.TabIndex = 1;
            this.lblGVPassword.Text = "Password:";
            // 
            // lblGVUsername
            // 
            this.lblGVUsername.AutoSize = true;
            this.lblGVUsername.Location = new System.Drawing.Point(22, 30);
            this.lblGVUsername.Name = "lblGVUsername";
            this.lblGVUsername.Size = new System.Drawing.Size(73, 16);
            this.lblGVUsername.TabIndex = 0;
            this.lblGVUsername.Text = "Username:";
            // 
            // frmAccountSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 411);
            this.Controls.Add(this.grbGV);
            this.Controls.Add(this.grbCBDT);
            this.Controls.Add(this.grbAdmin);
            this.Name = "frmAccountSuggestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gợi ý tài khoản";
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.grbCBDT.ResumeLayout(false);
            this.grbCBDT.PerformLayout();
            this.grbGV.ResumeLayout(false);
            this.grbGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.Button btnADMINShowPassword;
        private System.Windows.Forms.Button btnAdminSelect;
        private System.Windows.Forms.GroupBox grbCBDT;
        private System.Windows.Forms.Button btnCBDTSelect;
        private System.Windows.Forms.Button btnCBDTShowPassword;
        private System.Windows.Forms.TextBox txtCBDTPassword;
        private System.Windows.Forms.TextBox txtCBDTUsername;
        private System.Windows.Forms.Label lblCBDTPassword;
        private System.Windows.Forms.Label lblCBDTUsername;
        private System.Windows.Forms.GroupBox grbGV;
        private System.Windows.Forms.Button btnGVSelect;
        private System.Windows.Forms.Button btnGVShowPassword;
        private System.Windows.Forms.TextBox txtGVPassword;
        private System.Windows.Forms.TextBox txtGVUsername;
        private System.Windows.Forms.Label lblGVPassword;
        private System.Windows.Forms.Label lblGVUsername;
    }
}