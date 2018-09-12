using Design.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<NhanVien> loaddsNhanVien()
        {
            List<NhanVien> ds = new List<NhanVien>();
            string query = "select * from NhanVien ORDER BY maNV";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in table.Rows)
            {
                ChucVu cv = ChucVuDAO.Instance.getChucVuByid(item["maCV"].ToString());
                NhanVien nv = new NhanVien(item, cv);
                ds.Add(nv);
            }
            return ds;
        }

        public List<NhanVien> loaddsNVByNgayVaoLam(DateTime ngayMin, DateTime ngayMax, List<NhanVien> list)
        {
            List<NhanVien> ds = new List<NhanVien>();
            foreach (NhanVien nv in list)
            {
                if (DateTime.Compare(ngayMin, nv.NgayVaoLam) <= 0 && DateTime.Compare(ngayMax, nv.NgayVaoLam) >= 0)
                {
                    ds.Add(nv);
                }
            }
            return ds;
        }

        public List<NhanVien> loaddsNVByChucVu(string maCV,  List<NhanVien> list)
        {
            List<NhanVien> ds = new List<NhanVien>();
            foreach (NhanVien nv in list)
            {
                if (nv.ChucVuNV.MaCV == maCV)
                {
                    ds.Add(nv);
                }
            }
            return ds;
        }

        public List<NhanVien> loaddsNVByDoTuoi(int tuoiMin, int tuoiMax, List<NhanVien> list)
        {
            List<NhanVien> ds = new List<NhanVien>();
            foreach (NhanVien nv in list)
            {
                int tuoinv = DateTime.Today.Year - nv.NgaySinh.Year;
                if (tuoinv >= tuoiMin && tuoinv <= tuoiMax)
                {
                    ds.Add(nv);
                }
            }
            return ds;
        }

        public List<NhanVien> loaddsNVByMaNV(string maNV)
        {
            List<NhanVien> ds = new List<NhanVien>();
            string query = "select * from NhanVien where maNV = '" + maNV + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                ChucVu cv = ChucVuDAO.Instance.getChucVuByid(item["maCV"].ToString());
                NhanVien nv = new NhanVien(item, cv);
                ds.Add(nv);
            }
            return ds;
        }

        public List<NhanVien> loaddsNVByTenNV(string TenNV)
        {
            List<NhanVien> ds = new List<NhanVien>();
            string query = "select * from NhanVien where maNV = N'" + TenNV + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                ChucVu cv = ChucVuDAO.Instance.getChucVuByid(item["maCV"].ToString());
                NhanVien nv = new NhanVien(item, cv);
                ds.Add(nv);
            }
            return ds;
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            string query = "sp_ThemNhanVien @maNV , @tenNV , @gioiTinh , @ngaySinh , " +
                "@danToc , @soCMND , @diaChi , @soDT , @trinhVH , @ngayVaoLam , @maCV";
            Object[] ob = { nv.MaNV, nv.TenNV, nv.GioiTinh.Equals("Nam")? (int)1:(int)(-1), nv.NgaySinh, nv.DanToc, nv.CMND,
                    nv.DiaChi, nv.SDT, nv.TrinhDo, nv.NgayVaoLam, nv.ChucVuNV.MaCV};
            if (DataProvider.Instance.ExecuteNonQuery(query, ob) > 0)
                return true;
            return false;
        }

        public bool XoaNhanVien(NhanVien nv)
        {
            string query = "sp_XoaNhanVien @maNV , @tenNV , @gioiTinh , @ngaySinh , " +
                "@danToc , @soCMND , @diaChi , @soDT , @trinhVH , @ngayVaoLam , @maCV";
            Object[] ob = { nv.MaNV, nv.TenNV, nv.GioiTinh.Equals("Nam")? (int)1:(int)(-1), nv.NgaySinh, nv.DanToc, nv.CMND,
                    nv.DiaChi, nv.SDT, nv.TrinhDo, nv.NgayVaoLam, nv.ChucVuNV.MaCV};
            if (DataProvider.Instance.ExecuteNonQuery(query, ob) > 0)
                return true;
            return false;
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            string query = "sp_SuaNhanVien @maNV , @tenNV , @gioiTinh , @ngaySinh , " +
                "@danToc , @soCMND , @diaChi , @soDT , @trinhVH , @ngayVaoLam , @maCV";
            Object[] ob = { nv.MaNV, nv.TenNV, nv.GioiTinh.Equals("Nam")? (int)1:(int)(-1), nv.NgaySinh, nv.DanToc, nv.CMND,
                    nv.DiaChi, nv.SDT, nv.TrinhDo, nv.NgayVaoLam, nv.ChucVuNV.MaCV};
            if (DataProvider.Instance.ExecuteNonQuery(query, ob) > 0)
                return true;
            return false;
        }

    }
}
