using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class ChiTietChamCong
    {
        private string maCTCC;
        private string maCC;
        private DateTime ngayCC;
        private int slCC;
        private string ghiChu;

        public ChiTietChamCong() { }

        public ChiTietChamCong(string maCTCC, string maCC, DateTime ngayCC, int slCC, string ghiChu)
        {
            this.maCTCC = maCTCC;
            this.maCC = maCC;
            this.ngayCC = ngayCC;
            this.slCC = slCC;
            this.ghiChu = ghiChu;
        }

        public ChiTietChamCong(DataRow row)
        {
            this.maCTCC = row["maCTCC"].ToString();
            this.maCC = row["maCC"].ToString();
            this.ngayCC = (DateTime)row["ngayCC"];
            this.slCC = (int)row["slCC"];
            this.ghiChu = row["ghiChu"].ToString();
        }

        public string MaCTCC { get => maCTCC; set => maCTCC = value; }
        public string MaCC { get => maCC; set => maCC = value; }
        public DateTime NgayCC { get => ngayCC; set => ngayCC = value; }
        public int SlCC { get => slCC; set => slCC = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
