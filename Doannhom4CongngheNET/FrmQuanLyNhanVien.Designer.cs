namespace Doannhom4CongngheNET
{
    partial class FrmQuanLyNhanVien
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
            this.gbThongKe = new System.Windows.Forms.GroupBox();
            this.lbOldNV = new System.Windows.Forms.Label();
            this.lbNewNV = new System.Windows.Forms.Label();
            this.lbTongNV = new System.Windows.Forms.Label();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.cboChucVuFind = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbGioiTinhFind = new System.Windows.Forms.Label();
            this.cboToaNhaFind = new System.Windows.Forms.ComboBox();
            this.lbToaNha2 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cboToaNha = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbGioiTinh2 = new System.Windows.Forms.RadioButton();
            this.rbGioiTinh1 = new System.Windows.Forms.RadioButton();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.lbExcel = new System.Windows.Forms.Label();
            this.lbBaoCao = new System.Windows.Forms.Label();
            this.gbThongKe.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongKe
            // 
            this.gbThongKe.Controls.Add(this.lbOldNV);
            this.gbThongKe.Controls.Add(this.lbNewNV);
            this.gbThongKe.Controls.Add(this.lbTongNV);
            this.gbThongKe.Location = new System.Drawing.Point(12, 12);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Size = new System.Drawing.Size(248, 141);
            this.gbThongKe.TabIndex = 0;
            this.gbThongKe.TabStop = false;
            this.gbThongKe.Text = "Thống kê nhân viên";
            // 
            // lbOldNV
            // 
            this.lbOldNV.AutoSize = true;
            this.lbOldNV.Location = new System.Drawing.Point(16, 112);
            this.lbOldNV.Name = "lbOldNV";
            this.lbOldNV.Size = new System.Drawing.Size(44, 16);
            this.lbOldNV.TabIndex = 2;
            this.lbOldNV.Text = "label4";
            // 
            // lbNewNV
            // 
            this.lbNewNV.AutoSize = true;
            this.lbNewNV.Location = new System.Drawing.Point(16, 77);
            this.lbNewNV.Name = "lbNewNV";
            this.lbNewNV.Size = new System.Drawing.Size(44, 16);
            this.lbNewNV.TabIndex = 1;
            this.lbNewNV.Text = "label2";
            // 
            // lbTongNV
            // 
            this.lbTongNV.AutoSize = true;
            this.lbTongNV.Location = new System.Drawing.Point(16, 36);
            this.lbTongNV.Name = "lbTongNV";
            this.lbTongNV.Size = new System.Drawing.Size(44, 16);
            this.lbTongNV.TabIndex = 0;
            this.lbTongNV.Text = "label1";
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnSearch);
            this.gbTimKiem.Controls.Add(this.cboChucVuFind);
            this.gbTimKiem.Controls.Add(this.cboGioiTinh);
            this.gbTimKiem.Controls.Add(this.label12);
            this.gbTimKiem.Controls.Add(this.lbGioiTinhFind);
            this.gbTimKiem.Controls.Add(this.cboToaNhaFind);
            this.gbTimKiem.Controls.Add(this.lbToaNha2);
            this.gbTimKiem.Location = new System.Drawing.Point(283, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(623, 71);
            this.gbTimKiem.TabIndex = 1;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
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
            // cboChucVuFind
            // 
            this.cboChucVuFind.FormattingEnabled = true;
            this.cboChucVuFind.Location = new System.Drawing.Point(276, 29);
            this.cboChucVuFind.Name = "cboChucVuFind";
            this.cboChucVuFind.Size = new System.Drawing.Size(99, 24);
            this.cboChucVuFind.TabIndex = 1;
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
            this.label12.Location = new System.Drawing.Point(216, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Chức vụ:";
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
            // cboToaNhaFind
            // 
            this.cboToaNhaFind.FormattingEnabled = true;
            this.cboToaNhaFind.Location = new System.Drawing.Point(72, 29);
            this.cboToaNhaFind.Name = "cboToaNhaFind";
            this.cboToaNhaFind.Size = new System.Drawing.Size(118, 24);
            this.cboToaNhaFind.TabIndex = 1;
            // 
            // lbToaNha2
            // 
            this.lbToaNha2.AutoSize = true;
            this.lbToaNha2.Location = new System.Drawing.Point(6, 32);
            this.lbToaNha2.Name = "lbToaNha2";
            this.lbToaNha2.Size = new System.Drawing.Size(60, 16);
            this.lbToaNha2.TabIndex = 0;
            this.lbToaNha2.Text = "Tòa nhà:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(13, 158);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(470, 330);
            this.dgvNhanVien.TabIndex = 2;
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.cboToaNha);
            this.gbThongTin.Controls.Add(this.btnCancel);
            this.gbThongTin.Controls.Add(this.btnSave);
            this.gbThongTin.Controls.Add(this.btnUpdateNV);
            this.gbThongTin.Controls.Add(this.btnDeleteNV);
            this.gbThongTin.Controls.Add(this.btnAddNV);
            this.gbThongTin.Controls.Add(this.dtpNgaySinh);
            this.gbThongTin.Controls.Add(this.rbGioiTinh2);
            this.gbThongTin.Controls.Add(this.rbGioiTinh1);
            this.gbThongTin.Controls.Add(this.lbDiaChi);
            this.gbThongTin.Controls.Add(this.cboChucVu);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.lbChucVu);
            this.gbThongTin.Controls.Add(this.lbEmail);
            this.gbThongTin.Controls.Add(this.lbSDT);
            this.gbThongTin.Controls.Add(this.lbNgaySinh);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.lbHoTen);
            this.gbThongTin.Controls.Add(this.lbMaNV);
            this.gbThongTin.Controls.Add(this.txtDiaChi);
            this.gbThongTin.Controls.Add(this.txtEmail);
            this.gbThongTin.Controls.Add(this.txtSDT);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.txtMaNV);
            this.gbThongTin.Location = new System.Drawing.Point(488, 89);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(418, 399);
            this.gbThongTin.TabIndex = 3;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin nhân viên";
            // 
            // cboToaNha
            // 
            this.cboToaNha.FormattingEnabled = true;
            this.cboToaNha.Location = new System.Drawing.Point(211, 220);
            this.cboToaNha.Name = "cboToaNha";
            this.cboToaNha.Size = new System.Drawing.Size(121, 24);
            this.cboToaNha.TabIndex = 5;
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
            // btnUpdateNV
            // 
            this.btnUpdateNV.Location = new System.Drawing.Point(162, 295);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(83, 47);
            this.btnUpdateNV.TabIndex = 4;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(289, 295);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(83, 47);
            this.btnDeleteNV.TabIndex = 4;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Location = new System.Drawing.Point(37, 295);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(83, 47);
            this.btnAddNV.TabIndex = 4;
            this.btnAddNV.Text = "Thêm mới";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
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
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(132, 190);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(126, 24);
            this.cboChucVu.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tòa nhà được phân công: ";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(34, 195);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(60, 16);
            this.lbChucVu.TabIndex = 1;
            this.lbChucVu.Text = "Chức vụ: ";
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
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(34, 27);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(92, 16);
            this.lbMaNV.TabIndex = 1;
            this.lbMaNV.Text = "Mã Nhân viên:";
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
            this.txtSDT.Location = new System.Drawing.Point(132, 139);
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
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(191, 24);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(97, 22);
            this.txtMaNV.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(386, 113);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(87, 39);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(283, 113);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(86, 39);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // lbExcel
            // 
            this.lbExcel.AutoSize = true;
            this.lbExcel.Location = new System.Drawing.Point(383, 94);
            this.lbExcel.Name = "lbExcel";
            this.lbExcel.Size = new System.Drawing.Size(72, 16);
            this.lbExcel.TabIndex = 5;
            this.lbExcel.Text = "Xuất Excel:";
            // 
            // lbBaoCao
            // 
            this.lbBaoCao.AutoSize = true;
            this.lbBaoCao.Location = new System.Drawing.Point(280, 94);
            this.lbBaoCao.Name = "lbBaoCao";
            this.lbBaoCao.Size = new System.Drawing.Size(89, 16);
            this.lbBaoCao.TabIndex = 6;
            this.lbBaoCao.Text = "Xuất báo cáo:";
            // 
            // FrmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 500);
            this.Controls.Add(this.lbBaoCao);
            this.Controls.Add(this.lbExcel);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbThongKe);
            this.Name = "FrmQuanLyNhanVien";
            this.Text = "FrmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FrmQuanLyNhanVien_Load);
            this.gbThongKe.ResumeLayout(false);
            this.gbThongKe.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongKe;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cboChucVuFind;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbGioiTinhFind;
        private System.Windows.Forms.ComboBox cboToaNhaFind;
        private System.Windows.Forms.Label lbToaNha2;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton rbGioiTinh2;
        private System.Windows.Forms.RadioButton rbGioiTinh1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label lbExcel;
        private System.Windows.Forms.Label lbBaoCao;
        private System.Windows.Forms.Label lbOldNV;
        private System.Windows.Forms.Label lbNewNV;
        private System.Windows.Forms.Label lbTongNV;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ComboBox cboToaNha;
    }
}