namespace Doannhom4CongngheNET
{
    partial class FrmQuanLyPhong
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
            this.PanelCha = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.lbSvThuePhong = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.lbSucChua = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSoNguoiThue = new System.Windows.Forms.TextBox();
            this.lbSoNguoiThue = new System.Windows.Forms.Label();
            this.txtTinhTrangPhong = new System.Windows.Forms.TextBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.txtTienIch = new System.Windows.Forms.TextBox();
            this.lbTienIch = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.cboToaNha = new System.Windows.Forms.ComboBox();
            this.cboSoPhong = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddSinhVien = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSinhVien = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCha
            // 
            this.PanelCha.AutoScroll = true;
            this.PanelCha.BackColor = System.Drawing.Color.White;
            this.PanelCha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCha.Location = new System.Drawing.Point(12, 63);
            this.PanelCha.Name = "PanelCha";
            this.PanelCha.Size = new System.Drawing.Size(381, 461);
            this.PanelCha.TabIndex = 0;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoPhong.Location = new System.Drawing.Point(596, 63);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(172, 22);
            this.txtSoPhong.TabIndex = 1;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaiPhong.Location = new System.Drawing.Point(596, 106);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(172, 22);
            this.txtLoaiPhong.TabIndex = 1;
            // 
            // txtSucChua
            // 
            this.txtSucChua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSucChua.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSucChua.Location = new System.Drawing.Point(596, 143);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(172, 22);
            this.txtSucChua.TabIndex = 1;
            // 
            // lbSvThuePhong
            // 
            this.lbSvThuePhong.AutoSize = true;
            this.lbSvThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSvThuePhong.Location = new System.Drawing.Point(422, 182);
            this.lbSvThuePhong.Name = "lbSvThuePhong";
            this.lbSvThuePhong.Size = new System.Drawing.Size(145, 20);
            this.lbSvThuePhong.TabIndex = 2;
            this.lbSvThuePhong.Text = "Tên các sinh viên:";
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhong.Location = new System.Drawing.Point(483, 62);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(84, 20);
            this.lbSoPhong.TabIndex = 2;
            this.lbSoPhong.Text = "Số phòng:";
            // 
            // lbSucChua
            // 
            this.lbSucChua.AutoSize = true;
            this.lbSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucChua.Location = new System.Drawing.Point(483, 142);
            this.lbSucChua.Name = "lbSucChua";
            this.lbSucChua.Size = new System.Drawing.Size(84, 20);
            this.lbSucChua.TabIndex = 2;
            this.lbSucChua.Text = "Sức chứa:";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(471, 105);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(96, 20);
            this.lbLoaiPhong.TabIndex = 2;
            this.lbLoaiPhong.Text = "Loại phòng:";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(12, 18);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(82, 20);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Tìm kiếm:";
            // 
            // txtSoNguoiThue
            // 
            this.txtSoNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoNguoiThue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSoNguoiThue.Location = new System.Drawing.Point(596, 260);
            this.txtSoNguoiThue.Name = "txtSoNguoiThue";
            this.txtSoNguoiThue.Size = new System.Drawing.Size(172, 22);
            this.txtSoNguoiThue.TabIndex = 1;
            // 
            // lbSoNguoiThue
            // 
            this.lbSoNguoiThue.AutoSize = true;
            this.lbSoNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNguoiThue.Location = new System.Drawing.Point(428, 259);
            this.lbSoNguoiThue.Name = "lbSoNguoiThue";
            this.lbSoNguoiThue.Size = new System.Drawing.Size(139, 20);
            this.lbSoNguoiThue.TabIndex = 2;
            this.lbSoNguoiThue.Text = "Số người đã thuê:";
            // 
            // txtTinhTrangPhong
            // 
            this.txtTinhTrangPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTinhTrangPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTinhTrangPhong.Location = new System.Drawing.Point(596, 309);
            this.txtTinhTrangPhong.Name = "txtTinhTrangPhong";
            this.txtTinhTrangPhong.Size = new System.Drawing.Size(172, 22);
            this.txtTinhTrangPhong.TabIndex = 1;
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrang.Location = new System.Drawing.Point(428, 308);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(139, 20);
            this.lbTinhTrang.TabIndex = 2;
            this.lbTinhTrang.Text = "Tình trạng phòng:";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaThue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGiaThue.Location = new System.Drawing.Point(596, 407);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(172, 22);
            this.txtGiaThue.TabIndex = 1;
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTien.Location = new System.Drawing.Point(490, 406);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(77, 20);
            this.lbGiaTien.TabIndex = 2;
            this.lbGiaTien.Text = "Giá thuê:";
            // 
            // txtTienIch
            // 
            this.txtTienIch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienIch.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTienIch.Location = new System.Drawing.Point(596, 358);
            this.txtTienIch.Name = "txtTienIch";
            this.txtTienIch.Size = new System.Drawing.Size(172, 22);
            this.txtTienIch.TabIndex = 1;
            // 
            // lbTienIch
            // 
            this.lbTienIch.AutoSize = true;
            this.lbTienIch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienIch.Location = new System.Drawing.Point(494, 357);
            this.lbTienIch.Name = "lbTienIch";
            this.lbTienIch.Size = new System.Drawing.Size(73, 20);
            this.lbTienIch.TabIndex = 2;
            this.lbTienIch.Text = "Tiện ích:";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(494, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboToaNha
            // 
            this.cboToaNha.FormattingEnabled = true;
            this.cboToaNha.Location = new System.Drawing.Point(106, 18);
            this.cboToaNha.Name = "cboToaNha";
            this.cboToaNha.Size = new System.Drawing.Size(105, 24);
            this.cboToaNha.TabIndex = 4;
            this.cboToaNha.Text = "Tên tòa";
            // 
            // cboSoPhong
            // 
            this.cboSoPhong.FormattingEnabled = true;
            this.cboSoPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboSoPhong.Location = new System.Drawing.Point(240, 18);
            this.cboSoPhong.Name = "cboSoPhong";
            this.cboSoPhong.Size = new System.Drawing.Size(105, 24);
            this.cboSoPhong.TabIndex = 4;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboTinhTrang.Location = new System.Drawing.Point(371, 18);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(105, 24);
            this.cboTinhTrang.TabIndex = 4;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(399, 442);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 29);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboTinhTrang);
            this.panel1.Controls.Add(this.cboSoPhong);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cboToaNha);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddSinhVien);
            this.panel1.Controls.Add(this.lbLoaiPhong);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.lbSucChua);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lbSvThuePhong);
            this.panel1.Controls.Add(this.txtSinhVien);
            this.panel1.Controls.Add(this.lbSoPhong);
            this.panel1.Controls.Add(this.txtSucChua);
            this.panel1.Controls.Add(this.txtSoPhong);
            this.panel1.Controls.Add(this.txtLoaiPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 536);
            this.panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(399, 477);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(683, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAddSinhVien
            // 
            this.btnAddSinhVien.Location = new System.Drawing.Point(543, 442);
            this.btnAddSinhVien.Name = "btnAddSinhVien";
            this.btnAddSinhVien.Size = new System.Drawing.Size(120, 29);
            this.btnAddSinhVien.TabIndex = 5;
            this.btnAddSinhVien.Text = "Thêm sinh viên";
            this.btnAddSinhVien.UseVisualStyleBackColor = true;
            this.btnAddSinhVien.Click += new System.EventHandler(this.btnAddSinhVien_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(683, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(543, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSinhVien
            // 
            this.txtSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinhVien.Location = new System.Drawing.Point(596, 183);
            this.txtSinhVien.Multiline = true;
            this.txtSinhVien.Name = "txtSinhVien";
            this.txtSinhVien.Size = new System.Drawing.Size(172, 71);
            this.txtSinhVien.TabIndex = 1;
            // 
            // FrmSearchRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 536);
            this.Controls.Add(this.lbTienIch);
            this.Controls.Add(this.lbGiaTien);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbSoNguoiThue);
            this.Controls.Add(this.txtTienIch);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.txtTinhTrangPhong);
            this.Controls.Add(this.txtSoNguoiThue);
            this.Controls.Add(this.PanelCha);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu phòng";
            this.Load += new System.EventHandler(this.FrmSearchRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelCha;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Label lbSvThuePhong;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.Label lbSucChua;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSoNguoiThue;
        private System.Windows.Forms.Label lbSoNguoiThue;
        private System.Windows.Forms.TextBox txtTinhTrangPhong;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.TextBox txtTienIch;
        private System.Windows.Forms.Label lbTienIch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ComboBox cboToaNha;
        private System.Windows.Forms.ComboBox cboSoPhong;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddSinhVien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSinhVien;
    }
}