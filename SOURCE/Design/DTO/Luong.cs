using Design.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class Luong
    {
        private string maLng;
        private NhanVien nVTLng;
        private DateTime ngayBD;
        private DateTime ngayKT;
        private float tgLng;
        private int slLng;
        private float tLng;

        public Luong() { }

        public Luong(NhanVien nv)
        {
            string ma = nv.MaNV + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            this.maLng = TinhLuongDAO.Instance.checkMaLuong(ma)? ma: ma+"f";
            this.nVTLng = nv;
            List<DateTime> listChamCong = ChamCongDAO.Instance.setNgayTinhLuong(nv);
            TimeSpan tp = new TimeSpan(0, 24, 0, 0);
            if (listChamCong.Count > 0)
            {
                this.ngayBD = listChamCong.Min();
                this.ngayKT = DateTime.Now;
            }
            else
            {
                this.ngayBD = DateTime.Now;
                this.ngayKT = DateTime.Now;
            }
            this.tgLng = 0;
            this.slLng = 0;
            this.tLng = nv.ChucVuNV.HsLuong * 1250.0F;
            foreach (ChamCong cc in ChamCongDAO.Instance.dsTinhLuongNV(nv.MaNV, this.ngayBD, this.ngayKT))
            {
                this.tgLng += cc.TgCC;
                this.slLng += cc.SlCC;
                this.tLng += cc.ThanhTienCC;
            }
        }

        public Luong(string ma, NhanVien nv, DateTime bd, DateTime kt)
        {
            this.maLng = ma;
            this.nVTLng = nv;
            this.ngayBD = bd;
            this.ngayKT = kt;
            this.tgLng = 0;
            this.slLng = 0;
            this.tLng = nv.ChucVuNV.HsLuong * 1250.0F;
            foreach (ChamCong cc in ChamCongDAO.Instance.dsTinhLuongNV(nv.MaNV, bd, kt))
            {
                this.tgLng += cc.TgCC;
                this.slLng += cc.SlCC;
                this.tLng += cc.ThanhTienCC;
            }
        }

        public Luong(DataRow row)
        {
            this.maLng = row["maLng"].ToString();
            this.nVTLng = NhanVienDAO.Instance.loaddsNVByMaNV(row["maNV"].ToString()).First();
            this.ngayBD = (DateTime)row["ngayBD"];
            this.ngayKT = (DateTime)row["ngayKT"];
            this.tgLng = (float)Convert.ToDouble(row["tgTLng"]);
            this.slLng = (int)row["slTLng"];
            this.tLng = (float)Convert.ToDouble(row["tongLng"]);
        }

        public string MaLng { get => maLng; set => maLng = value; }
        public NhanVien NVTLng { get => nVTLng; set => nVTLng = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
        public float TgLng { get => tgLng; set => tgLng = value; }
        public int SlLng { get => slLng; set => slLng = value; }
        public float TLng { get => tLng; set => tLng = value; }
    }
}
