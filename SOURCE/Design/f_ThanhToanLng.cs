using Design.BUS;
using Design.DAO;
using Design.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class f_ThanhToanLng : Form
    {

        private List<NhanVien> listNV = ChamCongDAO.Instance.dsNhanVienCC();
        Luong lg = new Luong();
        public f_ThanhToanLng()
        {
            InitializeComponent();
            TinhLuongBUS.Instance.loadThanhToanLng(listView1,listNV,lbSL);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                NhanVien nv = new NhanVien();
                foreach (NhanVien item in listNV)
                {
                    if (item.MaNV.Equals(listView1.SelectedItems[0].SubItems[1].Text))
                    {
                        nv = item;
                    }
                }
                lg = new Luong(nv);
                loadThanhToan();
            }
        }

        void loadThanhToan()
        {
            float tienLuong = (1250 * lg.NVTLng.ChucVuNV.HsLuong) * (lg.TgLng / 208);
            float tienCong = (float)((float)lg.SlLng * 2.5);
            float tongLuong = tienLuong + tienCong;
            lg.TLng = tongLuong * ((float)nmrThucLanh.Value/100);
            txbChamCong.Text = lg.SlLng.ToString();
            txbCMND.Text = lg.NVTLng.CMND.ToString();
            txbHoten.Text = lg.NVTLng.TenNV.ToString();
            txbHSLng.Text = lg.NVTLng.ChucVuNV.HsLuong.ToString();
            txbChucVu.Text = lg.NVTLng.ChucVuNV.TenCV.ToString();
            txbMaNV.Text = lg.NVTLng.MaNV.ToString();
            txbSDT.Text = lg.NVTLng.SDT.ToString();
            txbslCC.Text = lg.SlLng.ToString();
            txbChamCong.Text = string.Format("{0:0.0}", tienCong) + " kVND";
            txbTienLuong.Text = string.Format("{0:0.0}", tienLuong) + " kVND";
            txbTongLng.Text = string.Format("{0:0.0}", tongLuong) + " kVND";
            txbThucLanh.Text = string.Format("{0:0.0}", lg.TLng) + " kVND";
            dtpNgayBD.MaxDate = lg.NgayKT;
            dtpNgayBD.Value = lg.NgayBD;
            dtpNgayKT.MaxDate = lg.NgayKT;
            dtpNgayKT.Value = lg.NgayKT;
            dtpNgaySinh.Value = lg.NVTLng.NgaySinh;
            dtpNgaylanSau.Value = lg.NgayBD;

            //giới tính
            cbNam.Text = lg.NVTLng.GioiTinh.ToString();
            cbNam.Checked = true;


        }

        private void txbTimKiemTL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {

        }

        private void nmrThucLanh_ValueChanged(object sender, EventArgs e)
        {
            loadThanhToan();
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayKT.MinDate = dtpNgayBD.Value;
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayBD.MaxDate = dtpNgayKT.Value;
            
        }
    }
}
