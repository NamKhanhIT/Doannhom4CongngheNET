using System.Drawing;
using System.Windows.Forms;

namespace Doannhom4CongngheNET
{
    partial class FrmKiemTraThuePhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbCheckRoom = new System.Windows.Forms.Label();
            this.dgvYeuCauTP = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSoPhong = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpNgayYeuCau = new System.Windows.Forms.DateTimePicker();
            this.txtMaYeuCau = new System.Windows.Forms.TextBox();
            this.lbMoTa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.lbSinhVien = new System.Windows.Forms.Label();
            this.lbMaThuePhong = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chartYeuCau = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenSV = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCauTP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYeuCau)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCheckRoom
            // 
            this.lbCheckRoom.AutoSize = true;
            this.lbCheckRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckRoom.Location = new System.Drawing.Point(0, -3);
            this.lbCheckRoom.Name = "lbCheckRoom";
            this.lbCheckRoom.Size = new System.Drawing.Size(378, 29);
            this.lbCheckRoom.TabIndex = 0;
            this.lbCheckRoom.Text = "Kiểm tra yêu cầu đăng kí phòng";
            // 
            // dgvYeuCauTP
            // 
            this.dgvYeuCauTP.AllowUserToAddRows = false;
            this.dgvYeuCauTP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dgvYeuCauTP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvYeuCauTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYeuCauTP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYeuCauTP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvYeuCauTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYeuCauTP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvYeuCauTP.EnableHeadersVisualStyles = false;
            this.dgvYeuCauTP.GridColor = System.Drawing.Color.LightBlue;
            this.dgvYeuCauTP.Location = new System.Drawing.Point(5, 30);
            this.dgvYeuCauTP.MultiSelect = false;
            this.dgvYeuCauTP.Name = "dgvYeuCauTP";
            this.dgvYeuCauTP.ReadOnly = true;
            this.dgvYeuCauTP.RowHeadersWidth = 51;
            this.dgvYeuCauTP.RowTemplate.Height = 28;
            this.dgvYeuCauTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYeuCauTP.Size = new System.Drawing.Size(549, 192);
            this.dgvYeuCauTP.TabIndex = 1;
            this.dgvYeuCauTP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYeuCauTP_RowEnter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(831, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 37);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(831, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa đăng kí";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGhi.FlatAppearance.BorderSize = 0;
            this.btnGhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGhi.ForeColor = System.Drawing.Color.White;
            this.btnGhi.Location = new System.Drawing.Point(553, 410);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(117, 42);
            this.btnGhi.TabIndex = 2;
            this.btnGhi.Text = "Cập nhật";
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenSV);
            this.groupBox1.Controls.Add(this.cboSoPhong);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.dtpNgayYeuCau);
            this.groupBox1.Controls.Add(this.txtMaYeuCau);
            this.groupBox1.Controls.Add(this.lbMoTa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbSoPhong);
            this.groupBox1.Controls.Add(this.lbSinhVien);
            this.groupBox1.Controls.Add(this.lbMaThuePhong);
            this.groupBox1.Location = new System.Drawing.Point(553, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn yêu cầu";
            // 
            // cboSoPhong
            // 
            this.cboSoPhong.FormattingEnabled = true;
            this.cboSoPhong.Location = new System.Drawing.Point(148, 97);
            this.cboSoPhong.Name = "cboSoPhong";
            this.cboSoPhong.Size = new System.Drawing.Size(121, 24);
            this.cboSoPhong.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(148, 182);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(163, 50);
            this.txtMoTa.TabIndex = 5;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(148, 152);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cboTrangThai.TabIndex = 4;
            // 
            // dtpNgayYeuCau
            // 
            this.dtpNgayYeuCau.Location = new System.Drawing.Point(148, 122);
            this.dtpNgayYeuCau.Name = "dtpNgayYeuCau";
            this.dtpNgayYeuCau.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayYeuCau.TabIndex = 3;
            // 
            // txtMaYeuCau
            // 
            this.txtMaYeuCau.Location = new System.Drawing.Point(148, 32);
            this.txtMaYeuCau.Name = "txtMaYeuCau";
            this.txtMaYeuCau.Size = new System.Drawing.Size(125, 22);
            this.txtMaYeuCau.TabIndex = 2;
            // 
            // lbMoTa
            // 
            this.lbMoTa.AutoSize = true;
            this.lbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTa.Location = new System.Drawing.Point(15, 182);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(131, 20);
            this.lbMoTa.TabIndex = 1;
            this.lbMoTa.Text = "Mô tả trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Trạng thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày yêu cầu:";
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhong.Location = new System.Drawing.Point(15, 97);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(84, 20);
            this.lbSoPhong.TabIndex = 1;
            this.lbSoPhong.Text = "Số phòng:";
            // 
            // lbSinhVien
            // 
            this.lbSinhVien.AutoSize = true;
            this.lbSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSinhVien.Location = new System.Drawing.Point(15, 66);
            this.lbSinhVien.Name = "lbSinhVien";
            this.lbSinhVien.Size = new System.Drawing.Size(113, 20);
            this.lbSinhVien.TabIndex = 1;
            this.lbSinhVien.Text = "Tên sinh viên:";
            // 
            // lbMaThuePhong
            // 
            this.lbMaThuePhong.AutoSize = true;
            this.lbMaThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThuePhong.Location = new System.Drawing.Point(15, 32);
            this.lbMaThuePhong.Name = "lbMaThuePhong";
            this.lbMaThuePhong.Size = new System.Drawing.Size(100, 20);
            this.lbMaThuePhong.TabIndex = 0;
            this.lbMaThuePhong.Text = "Mã yêu cầu:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(692, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(553, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(692, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chartYeuCau
            // 
            chartArea2.Name = "ChartArea1";
            this.chartYeuCau.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartYeuCau.Legends.Add(legend2);
            this.chartYeuCau.Location = new System.Drawing.Point(5, 260);
            this.chartYeuCau.Name = "chartYeuCau";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartYeuCau.Series.Add(series2);
            this.chartYeuCau.Size = new System.Drawing.Size(542, 213);
            this.chartYeuCau.TabIndex = 4;
            this.chartYeuCau.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thống kê số lượng đơn đăng kí";
            // 
            // cboTenSV
            // 
            this.cboTenSV.FormattingEnabled = true;
            this.cboTenSV.Location = new System.Drawing.Point(148, 66);
            this.cboTenSV.Name = "cboTenSV";
            this.cboTenSV.Size = new System.Drawing.Size(121, 24);
            this.cboTenSV.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cboSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(553, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Theo ngày:";
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(87, 27);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 24);
            this.cboSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(214, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmKiemTraThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartYeuCau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvYeuCauTP);
            this.Controls.Add(this.lbCheckRoom);
            this.Name = "FrmKiemTraThuePhong";
            this.Text = "FrmCheckSignRoom";
            this.Load += new System.EventHandler(this.FrmKiemTraThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCauTP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYeuCau)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCheckRoom;
        private System.Windows.Forms.DataGridView dgvYeuCauTP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGhi;
        private GroupBox groupBox1;
        private Label lbSinhVien;
        private Label lbMaThuePhong;
        private TextBox txtMaYeuCau;
        private Label label5;
        private Label label4;
        private Label lbSoPhong;
        private DateTimePicker dtpNgayYeuCau;
        private TextBox txtMoTa;
        private ComboBox cboTrangThai;
        private Label lbMoTa;
        private ComboBox cboSoPhong;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnCancel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYeuCau;
        private Label label1;
        private ComboBox cboTenSV;
        private GroupBox groupBox2;
        private ComboBox cboSearch;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}