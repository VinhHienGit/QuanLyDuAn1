using Design.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public void loadHSNS(ListView lv, List<NhanVien> list, ToolStripStatusLabel lb, Label name)
        {
            name.Text = "Danh Sách Nhân Sự";
            int sl = 0;
            lv.Clear();
            ColumnHeader h1 = new ColumnHeader();
            h1.Text = "STT";
            h1.Width = 50;
            lv.Columns.Add(h1);
            ColumnHeader h2 = new ColumnHeader();
            h2.Text = "Mã nhân viên";
            h2.Width = 80;
            lv.Columns.Add(h2);
            ColumnHeader h3 = new ColumnHeader();
            h3.Text = "Họ và tên";
            h3.Width = 143;
            lv.Columns.Add(h3);
            ColumnHeader h4 = new ColumnHeader();
            h4.Text = "Ngày sinh";
            h4.Width = 90;
            lv.Columns.Add(h4);
            ColumnHeader h5 = new ColumnHeader();
            h5.Text = "Chức vụ";
            h5.Width = 100;
            lv.Columns.Add(h5);
            ColumnHeader h6 = new ColumnHeader();
            h6.Text = "Ngày vào làm";
            h6.Width = 90;
            lv.Columns.Add(h6);
            ColumnHeader h7 = new ColumnHeader();
            h7.Text = "Số điện thoại";
            h7.Width = 97;
            lv.Columns.Add(h7);
            int i = 1;
            foreach (NhanVien nv in list)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(nv.MaNV.ToString());
                item.SubItems.Add(nv.TenNV.ToString());
                item.SubItems.Add(string.Format(" {0}/{1}/{2}", nv.NgaySinh.Day, nv.NgaySinh.Month, nv.NgaySinh.Year));
                item.SubItems.Add(nv.ChucVuNV.TenCV.ToString());
                item.SubItems.Add(string.Format(" {0}/{1}/{2}", nv.NgayVaoLam.Day, nv.NgayVaoLam.Month, nv.NgayVaoLam.Year));
                item.SubItems.Add(nv.SDT.ToString());
                lv.Items.Add(item);
                sl++;
            }
            lb.Text = " " + sl;
        }

        public List<NhanVien> checkedList(List<NhanVien> list, DateTime ngayMin , DateTime ngayMax, string chucVu, int tuoiMin, int tuoiMax)
        {
            List<NhanVien> ds = new List<NhanVien>();
            foreach(NhanVien nv in list)
            {
                int tuoi = DateTime.Now.Year - nv.NgaySinh.Year;
                if(DateTime.Compare(ngayMin, nv.NgayVaoLam) >= -1 && DateTime.Compare(ngayMax, nv.NgayVaoLam) <= 1 
                    && tuoi <= tuoiMax && tuoi >= tuoiMin)
                {
                    if (chucVu == "Tất cả")
                        ds.Add(nv);
                    else
                    {
                        if (nv.ChucVuNV.TenCV.Equals(chucVu))
                            ds.Add(nv);
                    }
                }
            }
            return ds;
        }
    }
}
