using Doannhom4CongngheNET.QuanLyKTXDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doannhom4CongngheNET
{
    public partial class UserControl1 : UserControl
    {

        public string sophong;
        public string loaiphong;
        public string tensv;
        public string tinhtrang;
        public string succhua;
        public string giathue;
        public string songuoithue;
        public string tienich;

        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            lbSoPhong.Text = "Số phòng: " + sophong.ToString();
            lbLoaiPhong.Text = loaiphong.ToString();
            lbSucChua.Text = "Sức chứa: " + succhua.ToString();
            lbTinhTrang.Text = "Tình trạng: " + tinhtrang.ToString();
            if (tinhtrang == "Trống")
            {
                lbTinhTrang.ForeColor = Color.Green;
            }
            
            else if (tinhtrang == "Đang sử dụng")
            {
                lbTinhTrang.ForeColor = Color.DarkOrange;
            }
            else
            {
                lbTinhTrang.ForeColor = Color.Red;
            }
        }

        private void UserControl1_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White; 
        }

        //private void UserControl1_Click(object sender, EventArgs e)
        //{
        //    if (this.FindForm() is FrmSearchRoom formCha)
        //    {
        //        formCha.LayDuLieu(
        //            sophong,
        //            loaiphong,
        //            succhua,
        //            tensv,
        //            songuoithue,
        //            tinhtrang,
        //            tienich,
        //            giathue
        //        );
        //    }
        //}
    }
}
