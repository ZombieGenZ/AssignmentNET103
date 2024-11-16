namespace Assignment.View
{
    partial class frmQLDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDiem));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnToStart = new System.Windows.Forms.Button();
            this.btnToEnd = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.pnlTiengAnh = new System.Windows.Forms.Panel();
            this.txtTiengAnh = new System.Windows.Forms.TextBox();
            this.lblTiengAnh = new System.Windows.Forms.Label();
            this.pnlMaSV = new System.Windows.Forms.Panel();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.pnlTenSV = new System.Windows.Forms.Panel();
            this.lblShowTenSV = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.pnlTongDiem = new System.Windows.Forms.Panel();
            this.lblShowTongDiem = new System.Windows.Forms.Label();
            this.lblTongDiem = new System.Windows.Forms.Label();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlGDTC = new System.Windows.Forms.Panel();
            this.txtGDTC = new System.Windows.Forms.TextBox();
            this.lblGDTC = new System.Windows.Forms.Label();
            this.pnlTinHoc = new System.Windows.Forms.Panel();
            this.txtTinHoc = new System.Windows.Forms.TextBox();
            this.lblTinHoc = new System.Windows.Forms.Label();
            this.grbTopSV = new System.Windows.Forms.GroupBox();
            this.dgvTOPSV = new System.Windows.Forms.DataGridView();
            this.grbTimKiem.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.pnlTiengAnh.SuspendLayout();
            this.pnlMaSV.SuspendLayout();
            this.pnlTenSV.SuspendLayout();
            this.pnlTongDiem.SuspendLayout();
            this.pnlInformation.SuspendLayout();
            this.pnlGDTC.SuspendLayout();
            this.pnlTinHoc.SuspendLayout();
            this.grbTopSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOPSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(157, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(412, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Điểm Sinh Viên";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.Controls.Add(this.lblTimKiem);
            this.grbTimKiem.Location = new System.Drawing.Point(99, 78);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTimKiem.Size = new System.Drawing.Size(575, 71);
            this.grbTimKiem.TabIndex = 1;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(379, 26);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(93, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(141, 26);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(63, 32);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(50, 16);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Mã SV:";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Controls.Add(this.pnlButton);
            this.pnlChucNang.Controls.Add(this.pnlFunction);
            this.pnlChucNang.Controls.Add(this.grbInput);
            this.pnlChucNang.Location = new System.Drawing.Point(99, 155);
            this.pnlChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(575, 407);
            this.pnlChucNang.TabIndex = 2;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnNext);
            this.pnlButton.Controls.Add(this.btnToStart);
            this.pnlButton.Controls.Add(this.btnToEnd);
            this.pnlButton.Controls.Add(this.btnPrev);
            this.pnlButton.Location = new System.Drawing.Point(3, 332);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(411, 66);
            this.pnlButton.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Assignment.Properties.Resources.right_arrow;
            this.btnNext.Location = new System.Drawing.Point(292, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 58);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnToStart
            // 
            this.btnToStart.Image = ((System.Drawing.Image)(resources.GetObject("btnToStart.Image")));
            this.btnToStart.Location = new System.Drawing.Point(211, 6);
            this.btnToStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToStart.Name = "btnToStart";
            this.btnToStart.Size = new System.Drawing.Size(75, 58);
            this.btnToStart.TabIndex = 2;
            this.btnToStart.UseVisualStyleBackColor = true;
            this.btnToStart.Click += new System.EventHandler(this.btnToStart_Click);
            // 
            // btnToEnd
            // 
            this.btnToEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnToEnd.Image")));
            this.btnToEnd.Location = new System.Drawing.Point(131, 6);
            this.btnToEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToEnd.Name = "btnToEnd";
            this.btnToEnd.Size = new System.Drawing.Size(75, 58);
            this.btnToEnd.TabIndex = 1;
            this.btnToEnd.UseVisualStyleBackColor = true;
            this.btnToEnd.Click += new System.EventHandler(this.btnToEnd_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = global::Assignment.Properties.Resources.left_arrow;
            this.btnPrev.Location = new System.Drawing.Point(49, 6);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 58);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pnlFunction
            // 
            this.pnlFunction.Controls.Add(this.btnShow);
            this.pnlFunction.Controls.Add(this.btnCancel);
            this.pnlFunction.Controls.Add(this.btnSave);
            this.pnlFunction.Controls.Add(this.btnNew);
            this.pnlFunction.Controls.Add(this.btnUpdate);
            this.pnlFunction.Controls.Add(this.btnDelete);
            this.pnlFunction.Location = new System.Drawing.Point(419, 2);
            this.pnlFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(153, 396);
            this.pnlFunction.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Image = global::Assignment.Properties.Resources.show;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(15, 289);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnShow.Size = new System.Drawing.Size(117, 34);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::Assignment.Properties.Resources.cross;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(15, 247);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnCancel.Size = new System.Drawing.Size(117, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::Assignment.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(15, 207);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnSave.Size = new System.Drawing.Size(117, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Image = global::Assignment.Properties.Resources.plus;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(15, 87);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnNew.Size = new System.Drawing.Size(117, 34);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = global::Assignment.Properties.Resources.pencil;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(15, 167);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnUpdate.Size = new System.Drawing.Size(117, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::Assignment.Properties.Resources.remove;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(15, 127);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.pnlTiengAnh);
            this.grbInput.Controls.Add(this.pnlMaSV);
            this.grbInput.Controls.Add(this.pnlTenSV);
            this.grbInput.Controls.Add(this.pnlTongDiem);
            this.grbInput.Controls.Add(this.pnlInformation);
            this.grbInput.Location = new System.Drawing.Point(3, 2);
            this.grbInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInput.Size = new System.Drawing.Size(411, 329);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            // 
            // pnlTiengAnh
            // 
            this.pnlTiengAnh.Controls.Add(this.txtTiengAnh);
            this.pnlTiengAnh.Controls.Add(this.lblTiengAnh);
            this.pnlTiengAnh.Location = new System.Drawing.Point(3, 142);
            this.pnlTiengAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTiengAnh.Name = "pnlTiengAnh";
            this.pnlTiengAnh.Size = new System.Drawing.Size(271, 53);
            this.pnlTiengAnh.TabIndex = 3;
            // 
            // txtTiengAnh
            // 
            this.txtTiengAnh.Location = new System.Drawing.Point(112, 17);
            this.txtTiengAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiengAnh.Name = "txtTiengAnh";
            this.txtTiengAnh.ReadOnly = true;
            this.txtTiengAnh.Size = new System.Drawing.Size(132, 22);
            this.txtTiengAnh.TabIndex = 1;
            // 
            // lblTiengAnh
            // 
            this.lblTiengAnh.AutoSize = true;
            this.lblTiengAnh.Location = new System.Drawing.Point(29, 20);
            this.lblTiengAnh.Name = "lblTiengAnh";
            this.lblTiengAnh.Size = new System.Drawing.Size(70, 16);
            this.lblTiengAnh.TabIndex = 0;
            this.lblTiengAnh.Text = "Tiếng anh:";
            // 
            // pnlMaSV
            // 
            this.pnlMaSV.Controls.Add(this.txtMaSV);
            this.pnlMaSV.Controls.Add(this.lblMaSV);
            this.pnlMaSV.Location = new System.Drawing.Point(3, 82);
            this.pnlMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMaSV.Name = "pnlMaSV";
            this.pnlMaSV.Size = new System.Drawing.Size(271, 53);
            this.pnlMaSV.TabIndex = 2;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(112, 17);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(132, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(29, 20);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(50, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // pnlTenSV
            // 
            this.pnlTenSV.Controls.Add(this.lblShowTenSV);
            this.pnlTenSV.Controls.Add(this.lblTenSV);
            this.pnlTenSV.Location = new System.Drawing.Point(5, 21);
            this.pnlTenSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTenSV.Name = "pnlTenSV";
            this.pnlTenSV.Size = new System.Drawing.Size(404, 53);
            this.pnlTenSV.TabIndex = 0;
            // 
            // lblShowTenSV
            // 
            this.lblShowTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblShowTenSV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblShowTenSV.Location = new System.Drawing.Point(107, 20);
            this.lblShowTenSV.Name = "lblShowTenSV";
            this.lblShowTenSV.Size = new System.Drawing.Size(292, 16);
            this.lblShowTenSV.TabIndex = 1;
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(29, 20);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(70, 16);
            this.lblTenSV.TabIndex = 0;
            this.lblTenSV.Text = "Họ tên SV:";
            // 
            // pnlTongDiem
            // 
            this.pnlTongDiem.Controls.Add(this.lblShowTongDiem);
            this.pnlTongDiem.Controls.Add(this.lblTongDiem);
            this.pnlTongDiem.Location = new System.Drawing.Point(285, 82);
            this.pnlTongDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTongDiem.Name = "pnlTongDiem";
            this.pnlTongDiem.Size = new System.Drawing.Size(124, 240);
            this.pnlTongDiem.TabIndex = 1;
            // 
            // lblShowTongDiem
            // 
            this.lblShowTongDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblShowTongDiem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblShowTongDiem.Location = new System.Drawing.Point(4, 63);
            this.lblShowTongDiem.Name = "lblShowTongDiem";
            this.lblShowTongDiem.Size = new System.Drawing.Size(115, 48);
            this.lblShowTongDiem.TabIndex = 1;
            this.lblShowTongDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongDiem
            // 
            this.lblTongDiem.AutoSize = true;
            this.lblTongDiem.Location = new System.Drawing.Point(21, 37);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new System.Drawing.Size(75, 16);
            this.lblTongDiem.TabIndex = 0;
            this.lblTongDiem.Text = "Tổng điểm:";
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.pnlGDTC);
            this.pnlInformation.Controls.Add(this.pnlTinHoc);
            this.pnlInformation.Location = new System.Drawing.Point(5, 82);
            this.pnlInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(268, 240);
            this.pnlInformation.TabIndex = 0;
            // 
            // pnlGDTC
            // 
            this.pnlGDTC.Controls.Add(this.txtGDTC);
            this.pnlGDTC.Controls.Add(this.lblGDTC);
            this.pnlGDTC.Location = new System.Drawing.Point(0, 177);
            this.pnlGDTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGDTC.Name = "pnlGDTC";
            this.pnlGDTC.Size = new System.Drawing.Size(271, 53);
            this.pnlGDTC.TabIndex = 4;
            // 
            // txtGDTC
            // 
            this.txtGDTC.Location = new System.Drawing.Point(109, 17);
            this.txtGDTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGDTC.Name = "txtGDTC";
            this.txtGDTC.ReadOnly = true;
            this.txtGDTC.Size = new System.Drawing.Size(132, 22);
            this.txtGDTC.TabIndex = 1;
            // 
            // lblGDTC
            // 
            this.lblGDTC.AutoSize = true;
            this.lblGDTC.Location = new System.Drawing.Point(29, 20);
            this.lblGDTC.Name = "lblGDTC";
            this.lblGDTC.Size = new System.Drawing.Size(45, 16);
            this.lblGDTC.TabIndex = 0;
            this.lblGDTC.Text = "GDTC";
            // 
            // pnlTinHoc
            // 
            this.pnlTinHoc.Controls.Add(this.txtTinHoc);
            this.pnlTinHoc.Controls.Add(this.lblTinHoc);
            this.pnlTinHoc.Location = new System.Drawing.Point(0, 118);
            this.pnlTinHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTinHoc.Name = "pnlTinHoc";
            this.pnlTinHoc.Size = new System.Drawing.Size(271, 53);
            this.pnlTinHoc.TabIndex = 3;
            // 
            // txtTinHoc
            // 
            this.txtTinHoc.Location = new System.Drawing.Point(109, 17);
            this.txtTinHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTinHoc.Name = "txtTinHoc";
            this.txtTinHoc.ReadOnly = true;
            this.txtTinHoc.Size = new System.Drawing.Size(132, 22);
            this.txtTinHoc.TabIndex = 1;
            // 
            // lblTinHoc
            // 
            this.lblTinHoc.AutoSize = true;
            this.lblTinHoc.Location = new System.Drawing.Point(29, 20);
            this.lblTinHoc.Name = "lblTinHoc";
            this.lblTinHoc.Size = new System.Drawing.Size(54, 16);
            this.lblTinHoc.TabIndex = 0;
            this.lblTinHoc.Text = "Tin học:";
            // 
            // grbTopSV
            // 
            this.grbTopSV.Controls.Add(this.dgvTOPSV);
            this.grbTopSV.Location = new System.Drawing.Point(1, 570);
            this.grbTopSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTopSV.Name = "grbTopSV";
            this.grbTopSV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTopSV.Size = new System.Drawing.Size(787, 154);
            this.grbTopSV.TabIndex = 3;
            this.grbTopSV.TabStop = false;
            this.grbTopSV.Text = "TOP 3 sinh viên có điểm cao nhất";
            // 
            // dgvTOPSV
            // 
            this.dgvTOPSV.AllowUserToAddRows = false;
            this.dgvTOPSV.AllowUserToDeleteRows = false;
            this.dgvTOPSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTOPSV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTOPSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTOPSV.Location = new System.Drawing.Point(11, 21);
            this.dgvTOPSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTOPSV.Name = "dgvTOPSV";
            this.dgvTOPSV.ReadOnly = true;
            this.dgvTOPSV.RowHeadersWidth = 51;
            this.dgvTOPSV.RowTemplate.Height = 24;
            this.dgvTOPSV.Size = new System.Drawing.Size(776, 121);
            this.dgvTOPSV.TabIndex = 0;
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.grbTopSV);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guản lý điểm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQLDiem_FormClosed);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlFunction.ResumeLayout(false);
            this.grbInput.ResumeLayout(false);
            this.pnlTiengAnh.ResumeLayout(false);
            this.pnlTiengAnh.PerformLayout();
            this.pnlMaSV.ResumeLayout(false);
            this.pnlMaSV.PerformLayout();
            this.pnlTenSV.ResumeLayout(false);
            this.pnlTenSV.PerformLayout();
            this.pnlTongDiem.ResumeLayout(false);
            this.pnlTongDiem.PerformLayout();
            this.pnlInformation.ResumeLayout(false);
            this.pnlGDTC.ResumeLayout(false);
            this.pnlGDTC.PerformLayout();
            this.pnlTinHoc.ResumeLayout(false);
            this.pnlTinHoc.PerformLayout();
            this.grbTopSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTOPSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlTongDiem;
        private System.Windows.Forms.Panel pnlTenSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblShowTenSV;
        private System.Windows.Forms.Panel pnlMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Panel pnlGDTC;
        private System.Windows.Forms.TextBox txtGDTC;
        private System.Windows.Forms.Label lblGDTC;
        private System.Windows.Forms.Panel pnlTiengAnh;
        private System.Windows.Forms.TextBox txtTiengAnh;
        private System.Windows.Forms.Label lblTiengAnh;
        private System.Windows.Forms.Panel pnlTinHoc;
        private System.Windows.Forms.TextBox txtTinHoc;
        private System.Windows.Forms.Label lblTinHoc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox grbTopSV;
        private System.Windows.Forms.DataGridView dgvTOPSV;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnToStart;
        private System.Windows.Forms.Button btnToEnd;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblTongDiem;
        private System.Windows.Forms.Label lblShowTongDiem;
        private System.Windows.Forms.Button btnShow;
    }
}