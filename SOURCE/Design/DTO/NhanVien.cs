using Design.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string sDT;
        private string cMND;
        private string danToc;
        private string trinhDo;
        private DateTime ngayVaoLam;
        private ChucVu chucVuNV;

        public NhanVien()
        {
            string maNV = "NV";
            string qr = "SELECT MAX(maNV) AS maNVMAX FROM dbo.NhanVien";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(qr).Rows)
            {
                int ma = 0;
                if (int.TryParse(row["maNVMAX"].ToString().Remove(0, 2), out ma) && ma++ < 100)
                {
                    maNV += "0" + ma;
                }
                else
                {
                    maNV += ma;
                }
            }
            this.maNV = maNV;
            this.tenNV = "";
            this.gioiTinh = "";
            this.ngaySinh = DateTime.Now;
            this.diaChi = "";
            this.sDT = "";
            this.cMND = "";
            this.danToc = "";
            this.trinhDo = "";
            this.ngayVaoLam = DateTime.Now;
            ChucVu cv = new ChucVu("kaka", "Chọn chức vụ", 0,0);
            this.chucVuNV = cv;
        }

        public NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh,string diaChi, string sdt, string cmnd, 
            string danToc, string trinhDo, DateTime ngayVaoLam, ChucVu chucVu)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.sDT = sdt;
            this.cMND = cmnd;
            this.danToc = danToc;
            this.trinhDo = trinhDo;
            this.ngayVaoLam = ngayVaoLam;
            this.chucVuNV = chucVu;
        }



        public NhanVien(DataRow row, ChucVu cv)
        {
            this.maNV = row["maNV"].ToString();
            this.tenNV = row["tenNV"].ToString();
            this.gioiTinh = (int)row["gioiTinh"] == 1? "Nam":"Nữ";
            this.ngaySinh = (DateTime)row["ngaySinh"];
            this.diaChi = row["diaChi"].ToString();
            this.sDT = row["soDT"].ToString();
            this.cMND = row["soCMND"].ToString();
            this.danToc = row["danToc"].ToString();
            this.trinhDo = row["trinhVH"].ToString();
            this.ngayVaoLam = (DateTime)row["ngayVaoLam"];
            this.chucVuNV = cv;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public ChucVu ChucVuNV { get => chucVuNV; set => chucVuNV = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string DanToc { get => danToc; set => danToc = value; }
    }
}
