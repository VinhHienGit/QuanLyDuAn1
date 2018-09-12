using Design.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DAO
{
    public class ChamCongDAO
    {
        private static ChamCongDAO instance;

        public static ChamCongDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChamCongDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<ChamCong> loadDSChamCong()
        {
            string qr = "SELECT * FROM dbo.ChamCong";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(qr);
            List<ChamCong> ds = new List<ChamCong>();
            foreach (DataRow row in dataTable.Rows)
            {
                ChamCong cc = new ChamCong(row);
                ds.Add(cc);
            }
            return ds;
        }
        
        public List<ChamCong> dsChamCongByDay(DateTime max, DateTime min, List<ChamCong> list)
        {
            List<ChamCong> ds = new List<ChamCong>();
            foreach (ChamCong nv in list)
            {
                if (DateTime.Compare(min, nv.NgayCC) <= 0 && DateTime.Compare(max, nv.NgayCC) >= 0)
                {
                    ds.Add(nv);
                }
            }
            return ds;
        }

        public bool checkMaCC(string ma)
        {
            string qr = "SELECT * FROM dbo.ChamCong";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(qr);
            foreach (DataRow row in dataTable.Rows)
            {
                if (ma == row["maCC"].ToString())
                    return false;
            }
            return true; 
        }

        public List<ChamCong> dsTinhLuongNV(string maNV, DateTime ngayBD, DateTime ngayKT)
        {
            string qr = "SELECT * FROM dbo.ChamCong where maNV = '" + maNV + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(qr);
            List<ChamCong> ds = new List<ChamCong>();
            foreach (DataRow row in dataTable.Rows)
            {
                if (DateTime.Compare(ngayBD, (DateTime)row["ngayCC"]) <= 0 && DateTime.Compare(ngayKT, (DateTime)row["ngayCC"]) >= 0)
                {
                    ChamCong cc = new ChamCong(row);
                    ds.Add(cc);
                }
            }
            return ds;
        }

        public List<DateTime> setNgayTinhLuong(NhanVien nv)
        {
            List<DateTime> ds = new List<DateTime>();
            string qr = "SELECT * FROM dbo.ChamCong where maNV = '" + nv.MaNV + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(qr);
            string qrd = "SELECT MAX(ngayKT) AS ngayMAX FROM dbo.TinhLuong WHERE maNV = '" + nv.MaNV + "'";
            DateTime ngayMax = DateTime.Now;
            if (DataProvider.Instance.ExecuteQuery(qrd).Rows.Count > 0)
            {
                foreach (DataRow row in DataProvider.Instance.ExecuteQuery(qrd).Rows)
                {
                    ngayMax = row["ngayMAX"] == DBNull.Value? DateTime.Now: (DateTime)row["ngayMAX"];
                }
            }
            foreach(DataRow row in dataTable.Rows)
            {
                ChamCong cc = new ChamCong(row);
                if (ngayMax == DateTime.Now)
                {
                    ds.Add(cc.NgayCC);
                }
                else
                {
                    if (DateTime.Compare(ngayMax, cc.NgayCC) <= 0)
                        ds.Add(cc.NgayCC);
                }
            }
            return ds;
        }

        public List<NhanVien> dsNhanVienCC()
        {
            List<NhanVien> ds = new List<NhanVien>();
            string query = "select DISTINCT maNV from ChamCong ORDER BY maNV";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                NhanVien nv = NhanVienDAO.Instance.loaddsNVByMaNV(item["maNV"].ToString()).First();
                ds.Add(nv);
            }
            return ds;
        }

        public bool ThemChamCong(ChamCong cc)
        {
            string query = "sp_ThemChamCong @maCC , @maNV , @ngayCC , @tgCC , @slCC , @giaCC";
            Object[] ob = {cc.MaCC, cc.NvCC.MaNV, cc.NgayCC, cc.TgCC, cc.SlCC, cc.GiaCC};
            if (DataProvider.Instance.ExecuteNonQuery(query, ob) > 0)
                return true;
            return false;
        }
    }
}
