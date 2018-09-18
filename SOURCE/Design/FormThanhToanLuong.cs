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
    public partial class FormThanhToanLuong : Form
    {

        private List<NhanVien> listNV = ChamCongDAO.Instance.dsNhanVienCC();
        Luong lg = new Luong();
        public FormThanhToanLuong()
        {
            InitializeComponent();
            TinhLuongBUS.Instance.loadThanhToanLng(listView1,listNV,lblSL);
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
            txtChamCong.Text = lg.SlLng.ToString();
            txtCMND.Text = lg.NVTLng.CMND.ToString();
            txtHoten.Text = lg.NVTLng.TenNV.ToString();
            txtHSLng.Text = lg.NVTLng.ChucVuNV.HsLuong.ToString();
            txtChucVu.Text = lg.NVTLng.ChucVuNV.TenCV.ToString();
            txtMaNV.Text = lg.NVTLng.MaNV.ToString();
            txtSDT.Text = lg.NVTLng.SDT.ToString();
            txtslCC.Text = lg.SlLng.ToString();
            txtChamCong.Text = string.Format("{0:0.0}", tienCong) + " kVND";
            txttnienLuong.Text = string.Format("{0:0.0}", tienLuong) + " kVND";
            txttnongLng.Text = string.Format("{0:0.0}", tongLuong) + " kVND";
            txttnhucLanh.Text = string.Format("{0:0.0}", lg.TLng) + " kVND";
            dtmNgayBD.MaxDate = lg.NgayKT;
            dtmNgayBD.Value = lg.NgayBD;
            dtmNgayKT.MaxDate = lg.NgayKT;
            dtmNgayKT.Value = lg.NgayKT;
            dtmNgaySinh.Value = lg.NVTLng.NgaySinh;
            dtmNgaylanSau.Value = lg.NgayBD;

            //giới tính
            chkNam.Text = lg.NVTLng.GioiTinh.ToString();
            chkNam.Checked = true;


        }

        private void txttnimKiemTL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void nmrThucLanh_ValueChanged(object sender, EventArgs e)
        {
            loadThanhToan();
        }

        private void dtmNgayBD_ValueChanged(object sender, EventArgs e)
        {
            dtmNgayKT.MinDate = dtmNgayBD.Value;
        }

        private void dtmNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dtmNgayBD.MaxDate = dtmNgayKT.Value;
            
        }
    }
}
