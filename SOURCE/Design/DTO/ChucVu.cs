using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class ChucVu
    {
        private string maCV;
        private string tenCV;
        private float hsLuong;
        private int slNhanVien;

        public ChucVu() { }

        public ChucVu(string maCV, string tenCV, float hsLuong, int sl)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
            this.HsLuong = hsLuong;
            this.slNhanVien = sl;
        }

        public ChucVu(DataRow row)
        {
            this.maCV = row["maCV"].ToString();
            this.tenCV = row["tenCV"].ToString();
            this.HsLuong = (float)Convert.ToDouble(row["heSoLng"]);
            this.slNhanVien = (int)row["slNV"];
        }

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public int SlNhanVien { get => slNhanVien; set => slNhanVien = value; }
        public float HsLuong { get => hsLuong; set => hsLuong = value; }
    }
}
