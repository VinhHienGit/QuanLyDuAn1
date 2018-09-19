using Design.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class ChamCong
    {
        private string maCC;
        private NhanVien nvCC;
        private DateTime ngayCC;
        private float tgCC;
        private int slCC;
        private float giaCC;
        private float thanhTienCC;

        public ChamCong() { this.MaCC = ""; } // khởi tạo chấm công mặt định.

        public ChamCong(string ma, NhanVien nv, DateTime ngay, float tg, int sl, float giaCC) // Khởi tạo một chấm công với data được input.
        {
            this.maCC = ma;
            this.nvCC = nv;
            this.ngayCC = ngay;
            this.tgCC = tg;
            this.slCC = sl;
            this.giaCC = giaCC;
            this.thanhTienCC = sl * giaCC;
        }

        public ChamCong(DataRow row) // khởi tạo chấm công với datarow
        {
            this.maCC = row["maCC"].ToString();
            this.nvCC = NhanVienDAO.Instance.loaddsNVByMaNV(row["maNV"].ToString()).First();
            this.ngayCC = (DateTime)row["ngayCC"];
            this.tgCC = (float)Convert.ToDouble(row["tgCC"]);
            this.slCC = (int)row["slCC"];
            this.giaCC = (float)Convert.ToDouble(row["giaCC"]);
            this.thanhTienCC = (float)Convert.ToDouble(row["thanhTien"]);
        }

        public string MaCC { get => maCC; set => maCC = value; }
        public NhanVien NvCC { get => nvCC; set => nvCC = value; }
        public DateTime NgayCC { get => ngayCC; set => ngayCC = value; }
        public float TgCC { get => tgCC; set => tgCC = value; }
        public int SlCC { get => slCC; set => slCC = value; }
        public float ThanhTienCC { get => thanhTienCC; set => thanhTienCC = value; }
        public float GiaCC { get => giaCC; set => giaCC = value; }
    }
}
