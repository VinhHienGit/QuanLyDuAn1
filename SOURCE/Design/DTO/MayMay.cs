using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DTO
{
    public class MayMay
    {
        private string maMay;
        private string tenMay;
        private string mota;
        private int slMM;
        private string status;
        private float giaMM;

        public MayMay() { }

        public MayMay(string maMay, string tenMay, string mota, int slMM, string status, float giaMM)
        {
            this.maMay = maMay;
            this.tenMay = tenMay;
            this.mota = mota;
            this.slMM = slMM;
            this.status = status;
            this.giaMM = giaMM;
        }

        public MayMay(DataRow row)
        {
            this.maMay = row["maMay"].ToString();
            this.tenMay = row["tenMay"].ToString();
            this.mota = row["mota"].ToString();
            this.slMM = (int)row["slMM"];
            this.status = row["status"].ToString();
            this.giaMM = (float)Convert.ToDouble(row["giaMM"]);
        }

        public string MaMay { get => maMay; set => maMay = value; }
        public string TenMay { get => tenMay; set => tenMay = value; }
        public string Mota { get => mota; set => mota = value; }
        public int SlMM { get => slMM; set => slMM = value; }
        public string Status { get => status; set => status = value; }
        public float GiaMM { get => giaMM; set => giaMM = value; }
    }
}
