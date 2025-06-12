using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Doannhom4CongngheNET
{
    public partial class FrmMenu : Form
    {
        private bool dropdown;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static string MaNguoiDung { get; set; }
        public FrmMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(73, 95, 201);
            public static Color color2 = Color.FromArgb(22, 69, 184);
            public static Color color3 = Color.FromArgb(32, 60, 184);
            public static Color color4 = Color.FromArgb(44, 110, 143);
            public static Color color5 = Color.FromArgb(105, 231, 34);
            
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Các button của thanh menu
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(73, 195, 201);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Nút bên trái Panel
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon hiện tại
                iconCurentChildForm.IconChar = currentBtn.IconChar;
                iconCurentChildForm.IconColor = color;
            }

        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.LightSkyBlue;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = $"Xin chào, {FrmLogin.HoTen}!";
            lbWelcome.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lbWelcome.ForeColor = Color.Navy;
            lbWelcome.TextAlign = ContentAlignment.TopRight;
            lbWelcome.Dock = DockStyle.Right;
            lbWelcome.Height = 40;

            lbNgay.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            lbThu.Text =  DateTime.Now.ToString("dddd");

            
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbChildForm.Text = childForm.Text;

            // Ẩn lbWelcome khi mở form con
            lbWelcome.Visible = false;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);



        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmQuanLyPhong());

        }

        private void btnSignUpRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmKiemTraThuePhong());

        }

        private void btnFixingRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMenu());
            Reset();
            lbWelcome.Visible = true;

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurentChildForm.IconChar = IconChar.Home;
            iconCurentChildForm.IconColor = Color.Navy;
            lbChildForm.Text = "Home";
        }

        //Kéo thả
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelTiltleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            FrmLogin.MaNguoiDung = null;
            FrmLogin.HoTen = null;
            FrmLogin fLogin = new FrmLogin();
            fLogin.Show();
            this.Hide();



        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        
    }
}
