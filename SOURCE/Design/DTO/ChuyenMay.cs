using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class ChuyenMay
    {
        private string maCM;
        private string tenCM;
        private NhanVien truongCM;
        private List<NhanVien> dsNhanVienCM;
        private DateTime ngayAddCM;
        private DateTime ngayKTCM;
        private string motaCVCM;
        private List<CongDoanMay> dsCongDoanMay;

        public ChuyenMay() { }
        
        public ChuyenMay(string maCM, string tenCM, NhanVien truongCM, List<NhanVien> dsNhanVienCM, DateTime ngayAddCM, DateTime ngayKTCM, string motaCVCM, List<CongDoanMay> dsCongDoanMay)
        {
            this.maCM = maCM;
            this.tenCM = tenCM;
            this.truongCM = truongCM;
            this.dsNhanVienCM = dsNhanVienCM;
            this.ngayAddCM = ngayAddCM;
            this.ngayKTCM = ngayKTCM;
            this.motaCVCM = motaCVCM;
            this.dsCongDoanMay = dsCongDoanMay;
        }

        public ChuyenMay(DataRow row)
        {
            this.maCM = row["maCM"].ToString();
            this.tenCM = row["tenCM"].ToString();
            this.truongCM = (NhanVien)row["truongCM"];
            //this.dsNhanVienCM = row[""].ToString()dsNhanVienCM;
            this.ngayAddCM = (DateTime)row["ngayAddCM"];
            this.ngayKTCM = (DateTime)row["ngayKTCM"];
            this.motaCVCM = row["motaCVCM"].ToString();
            //this.dsCongDoanMay = row[""].ToString()dsCongDoanMay;
        }

        public string MaCM { get => maCM; set => maCM = value; }
        public string TenCM { get => tenCM; set => tenCM = value; }
        public NhanVien TruongCM { get => truongCM; set => truongCM = value; }
        public List<NhanVien> DsNhanVienCM { get => dsNhanVienCM; set => dsNhanVienCM = value; }
        public DateTime NgayAddCM { get => ngayAddCM; set => ngayAddCM = value; }
        public string MotaCVCM { get => motaCVCM; set => motaCVCM = value; }
        public List<CongDoanMay> DsCongDoanMay { get => dsCongDoanMay; set => dsCongDoanMay = value; }
        public DateTime NgayKTCM { get => ngayKTCM; set => ngayKTCM = value; }
    }
}
