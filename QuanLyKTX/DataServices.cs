using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKTX
{
    public class DataServices
    {
        private SqlConnection conn;

        public DataServices()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-0DO0S0L\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        }

        public DataTable RunQuery(string maSV)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = @"SELECT YCTP.MaYeuCau, YCTP.NgayYeuCau, YCTP.TrangThai, 
                                P.MaPhong, P.TenPhong, P.LoaiPhong, P.GiaThue,
                                CASE 
                                    WHEN YCTP.TrangThai = 'Chờ duyệt' THEN 'Đang chờ quản lý xét duyệt'
                                    WHEN YCTP.TrangThai = 'Đã duyệt' THEN 'Yêu cầu của bạn đã được chấp nhận'
                                    WHEN YCTP.TrangThai = 'Từ chối' THEN 'Yêu cầu của bạn đã bị từ chối'
                                    WHEN YCTP.TrangThai = 'Huy' THEN 'Bạn đã hủy yêu cầu này'
                                    ELSE 'Không xác định'
                                END as MoTaTrangThai
                                FROM YeuCau YCTP
                                LEFT JOIN Phong P ON YCTP.MaPhong = P.MaPhong
                                WHERE YCTP.MaSV = @MaSV
                                ORDER BY YCTP.NgayYeuCau DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu yêu cầu thuê phòng: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return dt;
        }

        public void ExecuteNonQuery(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
} 