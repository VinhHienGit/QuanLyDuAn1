using Design.DAO;
using Design.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.BUS
{
    public class ChamCongBUS
    {
        private static ChamCongBUS instance;

        public static ChamCongBUS Instance
        {
            get
            {
                if (instance == null) instance = new ChamCongBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public void loadLVChamCong(ListView lv, List<ChamCong> list, ToolStripStatusLabel lb, Label name)
        {
            name.Text = "Bảng Chấm Công";
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
            h4.Text = "Ngày CC";
            h4.Width = 90;
            lv.Columns.Add(h4);
            ColumnHeader h5 = new ColumnHeader();
            h5.Text = "Thời gian(h)";
            h5.Width = 100;
            lv.Columns.Add(h5);
            ColumnHeader h6 = new ColumnHeader();
            h6.Text = "Slg CC";
            h6.Width = 90;
            lv.Columns.Add(h6);
            ColumnHeader h7 = new ColumnHeader();
            h7.Text = "Thành tiền";
            h7.Width = 110;
            lv.Columns.Add(h7);
            int i = 1;
            foreach (ChamCong cc in list)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(cc.NvCC.MaNV.ToString());
                item.SubItems.Add(cc.NvCC.TenNV.ToString());
                item.SubItems.Add(string.Format(" {0}/{1}/{2}", cc.NgayCC.Day, cc.NgayCC.Month, cc.NgayCC.Year));
                item.SubItems.Add(cc.TgCC.ToString());
                item.SubItems.Add(cc.SlCC.ToString());
                item.SubItems.Add(cc.ThanhTienCC.ToString() + " kVND");
                if (cc.SlCC / cc.TgCC >= 10)
                    item.BackColor = Color.Aqua;
                else
                    item.BackColor = Color.DarkOrange;
                lv.Items.Add(item);
                sl++;
            }
            lb.Text = " " + sl;
        }

        public List<ChamCong> loadDGVChamCong(DataGridView dgv, DateTime ngayCC, ChucVu cv)
        {
            dgv.Rows.Clear();
            List<ChamCong> dscc = new List<ChamCong>();
            List<NhanVien> list = NhanVienDAO.Instance.loaddsNhanVien();
            int i = 0;
            foreach(NhanVien nv in list)
            {
                i++;
                if (cv.TenCV.Equals("Tất cả"))
                {

                    string maCC = null;
                    maCC = ngayCC.Day.ToString();
                    maCC = maCC + nv.MaNV + i;
                    if (ChamCongDAO.Instance.checkMaCC(maCC))
                    {
                        ChamCong cc = new ChamCong(maCC, nv, ngayCC, 8.0F, 100, 2.5F);
                        dscc.Add(cc);
                    }
                    else
                    {
                        maCC = null;
                        maCC = ngayCC.Day.ToString();
                        maCC =maCC + nv.MaNV + (i+1);
                        ChamCong cc = new ChamCong(maCC, nv, ngayCC, 8.0F, 100, 2.5F);
                        dscc.Add(cc);
                    }

                }
                else
                {
                    if(nv.ChucVuNV.MaCV.Equals(cv.MaCV))
                    {
                        string maCC = null;
                        maCC = "" + ngayCC.Day.ToString();
                        maCC = maCC + nv.MaNV + i;
                        if (ChamCongDAO.Instance.checkMaCC(maCC))
                        {
                            ChamCong cc = new ChamCong(maCC, nv, ngayCC, 8.0F, 100, 2.5F);
                            dscc.Add(cc);
                        }
                        else
                        {
                            maCC = null;
                            maCC = "" + ngayCC.Day.ToString();
                            maCC = maCC + nv.MaNV + (i + 1);
                            ChamCong cc = new ChamCong(maCC, nv, ngayCC, 8.0F, 100, 2.5F);
                            dscc.Add(cc);
                        }
                    }
                }
            }
            int y = 1;
            foreach(ChamCong cc in dscc)
            {
                dgv.Rows.Add(y++, cc.NvCC.MaNV, cc.NvCC.TenNV, cc.NvCC.NgaySinh.ToString(),
                    cc.NgayCC, cc.TgCC.ToString(), cc.SlCC.ToString()
                    );
            }
            return dscc;
        }

        public bool addChamCong(ChamCong cc)
        {
            return ChamCongDAO.Instance.ThemChamCong(cc);
        }
    }
}
