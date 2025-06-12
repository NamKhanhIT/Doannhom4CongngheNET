namespace Doannhom4CongngheNET
{
    partial class FrmQuanLySinhVien
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
            this.lbBaoCao = new System.Windows.Forms.Label();
            this.lbExcel = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtNamVaoHoc = new System.Windows.Forms.TextBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateSV = new System.Windows.Forms.Button();
            this.btnDeleteSV = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbGioiTinh2 = new System.Windows.Forms.RadioButton();
            this.rbGioiTinh1 = new System.Windows.Forms.RadioButton();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.cboNamHocFind = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbGioiTinhFind = new System.Windows.Forms.Label();
            this.cboKhoaFind = new System.Windows.Forms.ComboBox();
            this.lbKhoaHoc = new System.Windows.Forms.Label();
            this.gbThongKe = new System.Windows.Forms.GroupBox();
            this.lbOldSV = new System.Windows.Forms.Label();
            this.lbNewSV = new System.Windows.Forms.Label();
            this.lbTongSV = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            this.gbThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBaoCao
            // 
            this.lbBaoCao.AutoSize = true;
            this.lbBaoCao.Location = new System.Drawing.Point(279, 104);
            this.lbBaoCao.Name = "lbBaoCao";
            this.lbBaoCao.Size = new System.Drawing.Size(89, 16);
            this.lbBaoCao.TabIndex = 14;
            this.lbBaoCao.Text = "Xuất báo cáo:";
            // 
            // lbExcel
            // 
            this.lbExcel.AutoSize = true;
            this.lbExcel.Location = new System.Drawing.Point(382, 104);
            this.lbExcel.Name = "lbExcel";
            this.lbExcel.Size = new System.Drawing.Size(72, 16);
            this.lbExcel.TabIndex = 13;
            this.lbExcel.Text = "Xuất Excel:";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtNamVaoHoc);
            this.gbThongTin.Controls.Add(this.cboKhoa);
            this.gbThongTin.Controls.Add(this.btnCancel);
            this.gbThongTin.Controls.Add(this.btnSave);
            this.gbThongTin.Controls.Add(this.btnUpdateSV);
            this.gbThongTin.Controls.Add(this.btnDeleteSV);
            this.gbThongTin.Controls.Add(this.btnAddSV);
            this.gbThongTin.Controls.Add(this.dtpNgaySinh);
            this.gbThongTin.Controls.Add(this.rbGioiTinh2);
            this.gbThongTin.Controls.Add(this.rbGioiTinh1);
            this.gbThongTin.Controls.Add(this.lbDiaChi);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.lbChucVu);
            this.gbThongTin.Controls.Add(this.lbEmail);
            this.gbThongTin.Controls.Add(this.lbSDT);
            this.gbThongTin.Controls.Add(this.lbNgaySinh);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.lbHoTen);
            this.gbThongTin.Controls.Add(this.lbMaSV);
            this.gbThongTin.Controls.Add(this.txtDiaChi);
            this.gbThongTin.Controls.Add(this.txtEmail);
            this.gbThongTin.Controls.Add(this.txtSDT);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.txtMaSV);
            this.gbThongTin.Location = new System.Drawing.Point(487, 99);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(418, 399);
            this.gbThongTin.TabIndex = 10;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin sinh viên";
            // 
            // txtNamVaoHoc
            // 
            this.txtNamVaoHoc.Location = new System.Drawing.Point(142, 192);
            this.txtNamVaoHoc.Name = "txtNamVaoHoc";
            this.txtNamVaoHoc.Size = new System.Drawing.Size(126, 22);
            this.txtNamVaoHoc.TabIndex = 6;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(147, 220);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(121, 24);
            this.cboKhoa.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 47);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(37, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Xác nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdateSV
            // 
            this.btnUpdateSV.Location = new System.Drawing.Point(162, 295);
            this.btnUpdateSV.Name = "btnUpdateSV";
            this.btnUpdateSV.Size = new System.Drawing.Size(83, 47);
            this.btnUpdateSV.TabIndex = 4;
            this.btnUpdateSV.Text = "Sửa";
            this.btnUpdateSV.UseVisualStyleBackColor = true;
            this.btnUpdateSV.Click += new System.EventHandler(this.btnUpdateSV_Click);
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.Location = new System.Drawing.Point(289, 295);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.Size = new System.Drawing.Size(83, 47);
            this.btnDeleteSV.TabIndex = 4;
            this.btnDeleteSV.Text = "Xóa";
            this.btnDeleteSV.UseVisualStyleBackColor = true;
            this.btnDeleteSV.Click += new System.EventHandler(this.btnDeleteSV_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.Location = new System.Drawing.Point(37, 295);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(83, 47);
            this.btnAddSV.TabIndex = 4;
            this.btnAddSV.Text = "Thêm mới";
            this.btnAddSV.UseVisualStyleBackColor = true;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(132, 106);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // rbGioiTinh2
            // 
            this.rbGioiTinh2.AutoSize = true;
            this.rbGioiTinh2.Location = new System.Drawing.Point(264, 81);
            this.rbGioiTinh2.Name = "rbGioiTinh2";
            this.rbGioiTinh2.Size = new System.Drawing.Size(45, 20);
            this.rbGioiTinh2.TabIndex = 2;
            this.rbGioiTinh2.TabStop = true;
            this.rbGioiTinh2.Text = "Nữ";
            this.rbGioiTinh2.UseVisualStyleBackColor = true;
            // 
            // rbGioiTinh1
            // 
            this.rbGioiTinh1.AutoSize = true;
            this.rbGioiTinh1.Location = new System.Drawing.Point(132, 81);
            this.rbGioiTinh1.Name = "rbGioiTinh1";
            this.rbGioiTinh1.Size = new System.Drawing.Size(57, 20);
            this.rbGioiTinh1.TabIndex = 2;
            this.rbGioiTinh1.TabStop = true;
            this.rbGioiTinh1.Text = "Nam";
            this.rbGioiTinh1.UseVisualStyleBackColor = true;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(34, 251);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lbDiaChi.TabIndex = 1;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Học ở khoa:";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(34, 195);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(90, 16);
            this.lbChucVu.TabIndex = 1;
            this.lbChucVu.Text = "Năm vào học:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(34, 167);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(44, 16);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(34, 139);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(85, 16);
            this.lbSDT.TabIndex = 1;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(34, 111);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lbNgaySinh.TabIndex = 1;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(34, 55);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(67, 16);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên:";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(34, 27);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(86, 16);
            this.lbMaSV.TabIndex = 1;
            this.lbMaSV.Text = "Mã Sinh viên:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 248);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 36);
            this.txtDiaChi.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(132, 136);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(126, 22);
            this.txtSDT.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(132, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(191, 24);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(97, 22);
            this.txtMaSV.TabIndex = 0;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 168);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(470, 330);
            this.dgvSinhVien.TabIndex = 9;
            this.dgvSinhVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_RowEnter);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(282, 123);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(86, 39);
            this.btnBaoCao.TabIndex = 11;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(385, 123);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(87, 39);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnSearch);
            this.gbTimKiem.Controls.Add(this.cboNamHocFind);
            this.gbTimKiem.Controls.Add(this.cboGioiTinh);
            this.gbTimKiem.Controls.Add(this.label12);
            this.gbTimKiem.Controls.Add(this.lbGioiTinhFind);
            this.gbTimKiem.Controls.Add(this.cboKhoaFind);
            this.gbTimKiem.Controls.Add(this.lbKhoaHoc);
            this.gbTimKiem.Location = new System.Drawing.Point(282, 22);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(623, 71);
            this.gbTimKiem.TabIndex = 8;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // cboNamHocFind
            // 
            this.cboNamHocFind.FormattingEnabled = true;
            this.cboNamHocFind.Location = new System.Drawing.Point(302, 29);
            this.cboNamHocFind.Name = "cboNamHocFind";
            this.cboNamHocFind.Size = new System.Drawing.Size(99, 24);
            this.cboNamHocFind.TabIndex = 1;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(462, 29);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(75, 24);
            this.cboGioiTinh.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Năm vào học:";
            // 
            // lbGioiTinhFind
            // 
            this.lbGioiTinhFind.AutoSize = true;
            this.lbGioiTinhFind.Location = new System.Drawing.Point(405, 32);
            this.lbGioiTinhFind.Name = "lbGioiTinhFind";
            this.lbGioiTinhFind.Size = new System.Drawing.Size(57, 16);
            this.lbGioiTinhFind.TabIndex = 0;
            this.lbGioiTinhFind.Text = "Giới tính:";
            // 
            // cboKhoaFind
            // 
            this.cboKhoaFind.FormattingEnabled = true;
            this.cboKhoaFind.Location = new System.Drawing.Point(72, 29);
            this.cboKhoaFind.Name = "cboKhoaFind";
            this.cboKhoaFind.Size = new System.Drawing.Size(118, 24);
            this.cboKhoaFind.TabIndex = 1;
            // 
            // lbKhoaHoc
            // 
            this.lbKhoaHoc.AutoSize = true;
            this.lbKhoaHoc.Location = new System.Drawing.Point(16, 32);
            this.lbKhoaHoc.Name = "lbKhoaHoc";
            this.lbKhoaHoc.Size = new System.Drawing.Size(41, 16);
            this.lbKhoaHoc.TabIndex = 0;
            this.lbKhoaHoc.Text = "Khoa:";
            // 
            // gbThongKe
            // 
            this.gbThongKe.Controls.Add(this.lbOldSV);
            this.gbThongKe.Controls.Add(this.lbNewSV);
            this.gbThongKe.Controls.Add(this.lbTongSV);
            this.gbThongKe.Location = new System.Drawing.Point(11, 22);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Size = new System.Drawing.Size(248, 141);
            this.gbThongKe.TabIndex = 7;
            this.gbThongKe.TabStop = false;
            this.gbThongKe.Text = "Thống kê sinh viên";
            // 
            // lbOldSV
            // 
            this.lbOldSV.AutoSize = true;
            this.lbOldSV.Location = new System.Drawing.Point(16, 112);
            this.lbOldSV.Name = "lbOldSV";
            this.lbOldSV.Size = new System.Drawing.Size(44, 16);
            this.lbOldSV.TabIndex = 2;
            this.lbOldSV.Text = "label4";
            // 
            // lbNewSV
            // 
            this.lbNewSV.AutoSize = true;
            this.lbNewSV.Location = new System.Drawing.Point(16, 77);
            this.lbNewSV.Name = "lbNewSV";
            this.lbNewSV.Size = new System.Drawing.Size(44, 16);
            this.lbNewSV.TabIndex = 1;
            this.lbNewSV.Text = "label2";
            // 
            // lbTongSV
            // 
            this.lbTongSV.AutoSize = true;
            this.lbTongSV.Location = new System.Drawing.Point(16, 36);
            this.lbTongSV.Name = "lbTongSV";
            this.lbTongSV.Size = new System.Drawing.Size(44, 16);
            this.lbTongSV.TabIndex = 0;
            this.lbTongSV.Text = "label1";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(543, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 521);
            this.Controls.Add(this.lbBaoCao);
            this.Controls.Add(this.lbExcel);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbThongKe);
            this.Name = "FrmQuanLySinhVien";
            this.Text = "FrmQuanLySinhVien";
            this.Load += new System.EventHandler(this.FrmQuanLySinhVien_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbThongKe.ResumeLayout(false);
            this.gbThongKe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBaoCao;
        private System.Windows.Forms.Label lbExcel;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtNamVaoHoc;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdateSV;
        private System.Windows.Forms.Button btnDeleteSV;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbGioiTinh2;
        private System.Windows.Forms.RadioButton rbGioiTinh1;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ComboBox cboNamHocFind;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbGioiTinhFind;
        private System.Windows.Forms.ComboBox cboKhoaFind;
        private System.Windows.Forms.Label lbKhoaHoc;
        private System.Windows.Forms.GroupBox gbThongKe;
        private System.Windows.Forms.Label lbOldSV;
        private System.Windows.Forms.Label lbNewSV;
        private System.Windows.Forms.Label lbTongSV;
    }
}