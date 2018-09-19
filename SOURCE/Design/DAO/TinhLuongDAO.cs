using Design.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DAO
{
    public class TinhLuongDAO
    {
        private static TinhLuongDAO instance;

        public static TinhLuongDAO Instance  // Loại bỏ trường hợp data null oop.
        {
            get
            {
                if (instance == null) instance = new TinhLuongDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<Luong> ListTinhLuong() // nhận bảng lương từ database
        {
            List<Luong> ds = new List<Luong>();
            string query = "SELECT * FROM dbo.TinhLuong";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                Luong lg = new Luong(item);
                ds.Add(lg);
            }
            return ds;
        }

        public bool ThemLuong(Luong lg) //Thêm vào 1 thanh toán luong
        {
            string query = "sp_ThemTinhLuong @maLng , @maNV , @ngayBD , @ngayKT , @tgTLng , @slTLng , @tongLng";
            Object[] ob = { lg.MaLng, lg.NVTLng.MaNV, lg.NgayBD, lg.NgayKT, lg.TgLng, lg.SlLng, lg.TLng};
            if (DataProvider.Instance.ExecuteNonQuery(query, ob) > 0)
                return true;
            return false;
        }

        public bool checkMaLuong(string malng) //kiểm tra mã lương
        {
            string query = "SELECT * FROM dbo.TinhLuong where maLng = '" + malng + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            if (table == null)
                return true;
            return false;
        }
    }
}
