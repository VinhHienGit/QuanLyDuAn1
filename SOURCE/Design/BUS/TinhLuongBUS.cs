using Design.DAO;
using Design.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.BUS
{
    public class TinhLuongBUS 
    {
        private static TinhLuongBUS instance;

        public static TinhLuongBUS Instance
        {
            get
            {
                if (instance == null) instance = new TinhLuongBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }



        public void loadLVTinhLuong(ListView lv, List<Luong> list, ToolStripStatusLabel lb, Label name)
        {
            name.Text = "Bảng Lương Nhân Viên";
            int sl = 0;
            lv.Clear();
            ColumnHeader h1 = new ColumnHeader();
            h1.Text = "STT";
            h1.Width = 40;
            lv.Columns.Add(h1);
            ColumnHeader h2 = new ColumnHeader();
            h2.Text = "Mã NV";
            h2.Width = 80;
            lv.Columns.Add(h2);
            ColumnHeader h3 = new ColumnHeader();
            h3.Text = "Họ và tên";
            h3.Width = 150;
            lv.Columns.Add(h3);
            ColumnHeader h4 = new ColumnHeader();
            h4.Text = "Ngày sinh";
            h4.Width = 90;
            lv.Columns.Add(h4);
            ColumnHeader h5 = new ColumnHeader();
            h5.Text = "Ngày BĐ";
            h5.Width = 100;
            lv.Columns.Add(h5);
            ColumnHeader h6 = new ColumnHeader();
            h6.Text = "Ngày KT";
            h6.Width = 90;
            lv.Columns.Add(h6);
            ColumnHeader h7 = new ColumnHeader();
            h7.Text = "Lương (kVND)";
            h7.Width = 110;
            lv.Columns.Add(h7);
            int i = 1;
            foreach (Luong lg in list)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(lg.NVTLng.MaNV.ToString());
                item.SubItems.Add(lg.NVTLng.TenNV.ToString());
                item.SubItems.Add(string.Format(" {0}/{1}/{2}", lg.NVTLng.NgaySinh.Day, lg.NVTLng.NgaySinh.Month, lg.NVTLng.NgaySinh.Year));
                item.SubItems.Add(string.Format(" {0}/{1}/{2}", lg.NgayBD.Day, lg.NgayBD.Month, lg.NgayBD.Year));
                item.SubItems.Add(string.Format(" {0}/{1}/{2}", lg.NgayKT.Day, lg.NgayKT.Month, lg.NgayKT.Year));
                item.SubItems.Add(lg.TLng.ToString());
                if (lg.TLng >= 5000.0F)
                    item.BackColor = Color.Aqua;
                else
                    item.BackColor = Color.DarkOrange;
                lv.Items.Add(item);
                sl++;
            }
            lb.Text = " " + sl;
        }

        public void loadThanhToanLng(ListView lv, List<NhanVien> list, ToolStripStatusLabel lb)
        {
            int sl = 0;
            lv.Clear();
            ColumnHeader h1 = new ColumnHeader();
            h1.Text = "STT";
            h1.Width = 40;
            lv.Columns.Add(h1);
            ColumnHeader h2 = new ColumnHeader();
            h2.Text = "Mã NV";
            h2.Width = 80;
            lv.Columns.Add(h2);
            ColumnHeader h3 = new ColumnHeader();
            h3.Text = "Họ và tên";
            h3.Width = 150;
            lv.Columns.Add(h3);
            int i = 1;
            foreach (NhanVien nv in list)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(nv.MaNV.ToString());
                item.SubItems.Add(nv.TenNV.ToString());
                lv.Items.Add(item);
                sl++;
            }
            lb.Text = " " + sl;
        }

        public string getMaLng()
        {
            string ml = "L";
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string qr = "SELECT COUNT(tl.maLng) AS sl FROM dbo.TinhLuong tl WHERE tl.maLng LIKE '" + ml + "%'";
            foreach(DataRow row in DataProvider.Instance.ExecuteQuery(qr).Rows)
            {
                string m = "L" + day + month + year.Substring(2);
                if((int)row["sl"] > 0)
                { 

                }
            }
            return ml;
        }
    }
}
