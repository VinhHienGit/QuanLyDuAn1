using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class CongDoanMay
    {
        private string maCD;
        private string tenCD;
        private string mota;
        private float giaCD;
        private int loaiCD;
        private MayMay tenMM;
        private int nangSuat; // năng suất cái/ngày/người

        public CongDoanMay() { }

        public CongDoanMay(string maCD, string tenCD, string mota, float giaCD, int loaiCD, MayMay tenMM, int nangSuat)
        {
            this.maCD = maCD;
            this.tenCD = tenCD;
            this.mota = mota;
            this.giaCD = giaCD;
            this.loaiCD = loaiCD;
            this.tenMM = tenMM;
            this.nangSuat = nangSuat;
        }

        public CongDoanMay(DataRow row)
        {
            this.maCD = row["maCD"].ToString();
            this.tenCD = row["tenCD"].ToString();
            this.mota = row["mota"].ToString();
            this.giaCD = (float)Convert.ToDouble(row["giaCD"]);
            this.loaiCD = (int)row["loaiCD"];
            this.tenMM = (MayMay)row["tenMM"];
            this.nangSuat = (int)row["nangSuat"];
        }

        public string MaCD { get => maCD; set => maCD = value; }
        public string Mota { get => mota; set => mota = value; }
        public string TenCD { get => tenCD; set => tenCD = value; }
        public float GiaCD { get => giaCD; set => giaCD = value; }
        public MayMay TenMM { get => tenMM; set => tenMM = value; }
        public int NangSuat { get => nangSuat; set => nangSuat = value; }
    }
}
