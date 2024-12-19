namespace Assignment
{
    partial class frmQLSV
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlDiaChi = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picStudentPicture = new System.Windows.Forms.PictureBox();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.lblPicture = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlSoDT = new System.Windows.Forms.Panel();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.pnlGioiTinh = new System.Windows.Forms.Panel();
            this.rbtGTNu = new System.Windows.Forms.RadioButton();
            this.rbtGTNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.pnlTenSV = new System.Windows.Forms.Panel();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlInformation.SuspendLayout();
            this.pnlDiaChi.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentPicture)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlSoDT.SuspendLayout();
            this.pnlGioiTinh.SuspendLayout();
            this.pnlTenSV.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(205, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Sinh Viên";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvData);
            this.pnlMain.Controls.Add(this.pnlInformation);
            this.pnlMain.Location = new System.Drawing.Point(26, 77);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(734, 647);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(3, 433);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(731, 205);
            this.dgvData.TabIndex = 1;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.pnlDiaChi);
            this.pnlInformation.Controls.Add(this.pnlButton);
            this.pnlInformation.Controls.Add(this.pnlImage);
            this.pnlInformation.Controls.Add(this.pnlInput);
            this.pnlInformation.Location = new System.Drawing.Point(98, 15);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(533, 412);
            this.pnlInformation.TabIndex = 0;
            // 
            // pnlDiaChi
            // 
            this.pnlDiaChi.Controls.Add(this.txtDiaChi);
            this.pnlDiaChi.Controls.Add(this.lblDiaChi);
            this.pnlDiaChi.Location = new System.Drawing.Point(3, 246);
            this.pnlDiaChi.Name = "pnlDiaChi";
            this.pnlDiaChi.Size = new System.Drawing.Size(336, 100);
            this.pnlDiaChi.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(109, 11);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiaChi.Size = new System.Drawing.Size(199, 73);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TabStop = false;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(31, 14);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnShow);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnUpdate);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Location = new System.Drawing.Point(348, 181);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(182, 224);
            this.pnlButton.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Image = global::Assignment.Properties.Resources.show;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(40, 180);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnShow.Size = new System.Drawing.Size(105, 30);
            this.btnShow.TabIndex = 5;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::Assignment.Properties.Resources.cross;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(40, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(105, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::Assignment.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(40, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Assignment.Properties.Resources.pencil;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(40, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUpdate.Size = new System.Drawing.Size(105, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Assignment.Properties.Resources.remove;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(40, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDelete.Size = new System.Drawing.Size(105, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Assignment.Properties.Resources.plus;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(40, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNew.Size = new System.Drawing.Size(105, 30);
            this.btnNew.TabIndex = 0;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.picStudentPicture);
            this.pnlImage.Location = new System.Drawing.Point(348, 3);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(185, 172);
            this.pnlImage.TabIndex = 1;
            // 
            // picStudentPicture
            // 
            this.picStudentPicture.Location = new System.Drawing.Point(13, 7);
            this.picStudentPicture.Name = "picStudentPicture";
            this.picStudentPicture.Size = new System.Drawing.Size(158, 162);
            this.picStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudentPicture.TabIndex = 0;
            this.picStudentPicture.TabStop = false;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.pnlPicture);
            this.pnlInput.Controls.Add(this.pnlEmail);
            this.pnlInput.Controls.Add(this.pnlSoDT);
            this.pnlInput.Controls.Add(this.pnlGioiTinh);
            this.pnlInput.Controls.Add(this.pnlTenSV);
            this.pnlInput.Controls.Add(this.panel3);
            this.pnlInput.Location = new System.Drawing.Point(3, 3);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(339, 402);
            this.pnlInput.TabIndex = 0;
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.btnUploadPicture);
            this.pnlPicture.Controls.Add(this.lblPicture);
            this.pnlPicture.Location = new System.Drawing.Point(3, 349);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(336, 42);
            this.pnlPicture.TabIndex = 4;
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Enabled = false;
            this.btnUploadPicture.Location = new System.Drawing.Point(106, 11);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(119, 23);
            this.btnUploadPicture.TabIndex = 1;
            this.btnUploadPicture.TabStop = false;
            this.btnUploadPicture.Text = "Chọn ảnh";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(31, 14);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(66, 16);
            this.lblPicture.TabIndex = 0;
            this.lblPicture.Text = "Chọn ảnh:";
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Location = new System.Drawing.Point(3, 99);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(336, 42);
            this.pnlEmail.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 11);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(199, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 14);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // pnlSoDT
            // 
            this.pnlSoDT.Controls.Add(this.txtSoDT);
            this.pnlSoDT.Controls.Add(this.lblSoDT);
            this.pnlSoDT.Location = new System.Drawing.Point(3, 147);
            this.pnlSoDT.Name = "pnlSoDT";
            this.pnlSoDT.Size = new System.Drawing.Size(336, 42);
            this.pnlSoDT.TabIndex = 3;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(109, 11);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.ReadOnly = true;
            this.txtSoDT.Size = new System.Drawing.Size(199, 22);
            this.txtSoDT.TabIndex = 1;
            this.txtSoDT.TabStop = false;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(31, 14);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(48, 16);
            this.lblSoDT.TabIndex = 0;
            this.lblSoDT.Text = "Số ĐT:";
            // 
            // pnlGioiTinh
            // 
            this.pnlGioiTinh.Controls.Add(this.rbtGTNu);
            this.pnlGioiTinh.Controls.Add(this.rbtGTNam);
            this.pnlGioiTinh.Controls.Add(this.lblGioiTinh);
            this.pnlGioiTinh.Location = new System.Drawing.Point(3, 195);
            this.pnlGioiTinh.Name = "pnlGioiTinh";
            this.pnlGioiTinh.Size = new System.Drawing.Size(336, 42);
            this.pnlGioiTinh.TabIndex = 3;
            // 
            // rbtGTNu
            // 
            this.rbtGTNu.AutoSize = true;
            this.rbtGTNu.Enabled = false;
            this.rbtGTNu.Location = new System.Drawing.Point(188, 12);
            this.rbtGTNu.Name = "rbtGTNu";
            this.rbtGTNu.Size = new System.Drawing.Size(45, 20);
            this.rbtGTNu.TabIndex = 2;
            this.rbtGTNu.Text = "Nữ";
            this.rbtGTNu.UseVisualStyleBackColor = true;
            // 
            // rbtGTNam
            // 
            this.rbtGTNam.AutoSize = true;
            this.rbtGTNam.Checked = true;
            this.rbtGTNam.Enabled = false;
            this.rbtGTNam.Location = new System.Drawing.Point(109, 12);
            this.rbtGTNam.Name = "rbtGTNam";
            this.rbtGTNam.Size = new System.Drawing.Size(57, 20);
            this.rbtGTNam.TabIndex = 1;
            this.rbtGTNam.TabStop = true;
            this.rbtGTNam.Text = "Nam";
            this.rbtGTNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(31, 14);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // pnlTenSV
            // 
            this.pnlTenSV.Controls.Add(this.txtTenSV);
            this.pnlTenSV.Controls.Add(this.lblTenSV);
            this.pnlTenSV.Location = new System.Drawing.Point(3, 51);
            this.pnlTenSV.Name = "pnlTenSV";
            this.pnlTenSV.Size = new System.Drawing.Size(336, 42);
            this.pnlTenSV.TabIndex = 2;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(109, 11);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(199, 22);
            this.txtTenSV.TabIndex = 1;
            this.txtTenSV.TabStop = false;
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(31, 14);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(55, 16);
            this.lblTenSV.TabIndex = 0;
            this.lblTenSV.Text = "Tên SV:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMaSV);
            this.panel3.Controls.Add(this.lblMaSV);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 42);
            this.panel3.TabIndex = 0;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(109, 11);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(199, 22);
            this.txtMaSV.TabIndex = 1;
            this.txtMaSV.TabStop = false;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(31, 17);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(50, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // frmQLSV
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmQLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQLSV_FormClosed);
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlInformation.ResumeLayout(false);
            this.pnlDiaChi.ResumeLayout(false);
            this.pnlDiaChi.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudentPicture)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlPicture.ResumeLayout(false);
            this.pnlPicture.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlSoDT.ResumeLayout(false);
            this.pnlSoDT.PerformLayout();
            this.pnlGioiTinh.ResumeLayout(false);
            this.pnlGioiTinh.PerformLayout();
            this.pnlTenSV.ResumeLayout(false);
            this.pnlTenSV.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Panel pnlTenSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlSoDT;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Panel pnlGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbtGTNu;
        private System.Windows.Forms.RadioButton rbtGTNam;
        private System.Windows.Forms.Panel pnlDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.PictureBox picStudentPicture;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Button btnShow;
    }
}