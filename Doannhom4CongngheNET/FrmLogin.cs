using Doannhom4CongngheNET.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Doannhom4CongngheNET
{
    public partial class FrmLogin : Form
    {
        private DataServices MyDataServices;
        private QuanLyKTXEntities qlktx ;
        
        public static string MaNguoiDung { get; set; }
        public static string HoTen { get; set; }

        public FrmLogin()
        {

            InitializeComponent();
            MyDataServices = new DataServices();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimize_Click_1(object sender, EventArgs e)
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

        private void BtnMaximize_Click(object sender, EventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtAccount.Text) || string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MyDataServices = new DataServices();
            if (MyDataServices.OpenDB() == false)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            qlktx = new QuanLyKTXEntities();
            var user = qlktx.tblNguoiDungs
                            .Where(u => u.TenDangNhap == TxtAccount.Text && u.MatKhau == TxtPassword.Text)
                            .Select(u => new { u.MaNguoiDung, u.HoTen })
                            .FirstOrDefault();

            if (user != null)   
            {
                
                FrmLogin.MaNguoiDung = user.MaNguoiDung.ToString();
                FrmLogin.HoTen = user.HoTen;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMainMenu SVMenu = new FrmMainMenu();
                FrmMainMenu.MaNguoiDung = MaNguoiDung;
                SVMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không đúng tên truy nhập/mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAccount.Focus();
            }
        }
        private void CbPassword_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !CbPassword.Checked;

        }

        
    }
}
