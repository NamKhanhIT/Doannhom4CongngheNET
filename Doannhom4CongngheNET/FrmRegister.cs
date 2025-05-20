using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Doannhom4CongngheNET
{
    public partial class FrmRegister : Form
    {
        private DataServices myDataServices;
        public string MaNguoiDung { get; set; }
        public FrmRegister()
        {
            InitializeComponent();
            myDataServices = new DataServices();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FrmLogin fLogin = new FrmLogin();
            fLogin.Show();
            this.Hide();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            txtPassword.UseSystemPasswordChar = !cb.Checked;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private DataServices GetMyDataServices()
        {
            return myDataServices;
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra kết nối cơ sở dữ liệu
            if (!myDataServices.OpenDB())
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu!");
                return;
            }

            // Lấy dữ liệu từ TextBox
            string tenDangNhap = txtAccount.Text;
            string matKhau = txtPassword.Text;
            string email = txtEmail.Text;
            string vaiTro = txtVaitro.Text;
            string HoTen = txtUserName.Text;

            string checkSql = $"SELECT COUNT(*) AS Count FROM tblNguoiDung WHERE TenDangNhap = N'{tenDangNhap}'";
            DataTable resultTable = myDataServices.RunQuery(checkSql);
            int count = 0;
            if (resultTable.Rows.Count > 0)
            {
                count = Convert.ToInt32(resultTable.Rows[0]["Count"]);
            }

            if (count > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
                return;
            }

            // Kiểm tra độ dài tên đăng nhập
            if (tenDangNhap.Length < 4)
            {
                MessageBox.Show("Tên tài khoản phải có hơn 4 ký tự!");
                return;
            }

            // Kiểm tra tên đăng nhập theo vai trò
            if (vaiTro == "SinhVien" && !tenDangNhap.StartsWith("sv"))
            {
                MessageBox.Show("Tên đăng nhập cho Sinh viên phải bắt đầu bằng 'sv'!");
                return;
            }
            if (vaiTro == "NhanVien" && !tenDangNhap.StartsWith("nv"))
            {
                MessageBox.Show("Tên đăng nhập cho Nhân viên phải bắt đầu bằng 'nv'!");
                return;
            }

            // Kiểm tra độ dài mật khẩu
            if (matKhau.Length <= 8)
                        {
                            MessageBox.Show("Mật khẩu phải có hơn 8 ký tự!");
                            return;
                        }

            // Kiểm tra email

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            // Kiểm tra vai trò
            if (vaiTro != "NhanVien" && vaiTro != "SinhVien")
            {
                MessageBox.Show("Vai trò phải là 'NhanVien' hoặc 'SinhVien'!");
                return;
            }

            // Tạo lệnh SQL INSERT
            string sSql = $"INSERT INTO tblNguoiDung (TenDangNhap, HoTen, MatKhau, Email, VaiTro) " +
                          $"VALUES (N'{tenDangNhap}', N'{HoTen}', N'{matKhau}', N'{email}', N'{vaiTro}')";

            // Thực thi lệnh SQL và kiểm tra lỗi
            try
            {
                myDataServices.ExecuteNonQuery(sSql);
                MessageBox.Show("Đăng ký thành công!");
                FrmLogin fLogin = new FrmLogin();
                fLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
