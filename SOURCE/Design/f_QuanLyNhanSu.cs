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
    public partial class f_QuanLyNhanSu : Form   {
        String userQL = "";
        bool login = false;
        DateTime ngayMin;
        DateTime ngayMax;
        List<ChucVu> lcv = new List<ChucVu>();
        int tuoiMin;
        int tuoiMax;
        List<NhanVien> listLoad;
        f_DangNhap fdn = new f_DangNhap();
        public f_QuanLyNhanSu()
        {
            InitializeComponent();
            load();
            textboxEnab(false);
            buttonEnab(false);
        }

        #region loadData

        void load()
        {
            listLoad = NhanVienDAO.Instance.loaddsNhanVien();
            NhanVienBUS.Instance.loadHSNS(lvQLNS, listLoad, lbSLItemListView, lbQLNS);
            loaddataload();
            loadLocDanhSach(ngayMin, ngayMax, lcv, tuoiMin, tuoiMax);

            // Chấm công
            
        }

        void textboxEnab(bool en)
        {
            txbMaHSNS.Enabled = false;
            txbMaNV.Enabled = false;
            txbTenNV.Enabled = en;
            txbDantoc.Enabled = en;
            txbDiaChi.Enabled = en;
            txbSDT.Enabled = en;
            txbSoCMND.Enabled = en;
            dtpNgaySinh.Enabled = en;
            dtpNgayVaoLam.Enabled = en;
            cbbGioiTinh.Enabled = en;
            cbbChucVu.Enabled = en;
            txbTrinhVH.Enabled = en;
        }

        void buttonEnab(bool en)
        {
            btThemHSNS.Enabled = en;
            btCCcChamPhat.Enabled = en;
            btCCChamCong.Enabled = en;
            btCCNghiPhep.Enabled = en;
            btSuaHSNS.Enabled = en;
            btTDXoa.Enabled = en;
            btTLThanhToanLuong.Enabled = en;
            btXoaHSNS.Enabled = en;
            mntAdmin.Enabled = en;
            lvQLNS.Enabled = en;
            mntThongTinCaNhan.Enabled = en;
            mntDoiMatKhau.Enabled = en;
            mntDangXuat.Enabled = en;
        }

        void loadNV(NhanVien nv)
        {
            txbMaHSNS.Text = nv.MaNV;
            txbMaNV.Text = nv.MaNV;
            txbDantoc.Text = nv.DanToc;
            txbDiaChi.Text = nv.DiaChi;
            txbSDT.Text = nv.SDT;
            txbSoCMND.Text = nv.CMND;
            txbTenNV.Text = nv.TenNV;
            dtpNgaySinh.Value = nv.NgaySinh;
            dtpNgayVaoLam.Value = nv.NgayVaoLam;
            cbbChucVu.Text = nv.ChucVuNV.TenCV;
            cbbGioiTinh.Text = nv.GioiTinh;
            txbTrinhVH.Text = nv.TrinhDo;
        }

        void loadLocDanhSach(DateTime ngayMin, DateTime ngayMax, List<ChucVu> lcv, int tuoiMin, int tuoiMax)
        {
            cbbChucVuHSNS.Items.Clear();
            dtpHSNSngayMIN.Value = ngayMin;
            dtpHSNSngayMIN.MinDate = ngayMin;
            dtpHSNSngayMAX.MaxDate = ngayMax;
            dtpHSNSngayMAX.Value = ngayMax;
            dtpHSNSngayMAX.MaxDate = ngayMax;
            dtpHSNSngayMAX.MinDate = ngayMin;
            nuHSNSTuoiMAX.Value = tuoiMax;
            nuHSNSTuoiMAX.Maximum = tuoiMax;
            nuHSNSTuoiMAX.Minimum = tuoiMin;
            nuHSNStuoiMIN.Value = tuoiMin;
            nuHSNStuoiMIN.Maximum = tuoiMax;
            nuHSNStuoiMIN.Minimum = tuoiMin;
            foreach(ChucVu cv in lcv)
            {
                cbbChucVuHSNS.Items.Add(cv.TenCV);
            }
        }

        void loaddataload()
        {
            string qr = "SELECT  MAX(ngaySinh) as ngayMaxT, MIN(ngaySinh) AS ngayMinT," +
                " MAX(ngayVaoLam) as ngayMax, MIN(ngayVaoLam) AS ngayMin from dbo.NhanVien";
            DataTable tb = DataProvider.Instance.ExecuteQuery(qr);
            foreach(DataRow row in tb.Rows)
            {
                ngayMax = (DateTime)row["ngayMax"];
                ngayMin = (DateTime)row["ngayMin"];
                DateTime nsMax = (DateTime)row["ngayMaxT"];
                DateTime nsMin = (DateTime)row["ngayMinT"];
                tuoiMin = DateTime.Now.Year - nsMax.Year;
                tuoiMax = DateTime.Now.Year - nsMin.Year;
            }
            string q = "SELECT DISTINCT * FROM ChucVu";
            DataTable t = DataProvider.Instance.ExecuteQuery(q);
            lcv.Clear();
            foreach (DataRow row in t.Rows)
            {
                ChucVu cv = new ChucVu(row);
                lcv.Add(cv);
            }
        }


        #endregion


        #region mnt Tài khoảng

        private void mntDangNhap_Click(object sender, EventArgs e)
        {
            f_DangNhap fdn = new f_DangNhap();
            fdn.ShowDialog();
            userQL = fdn.user;
            if (userQL != "")
            {
                login = true;
                MessageBox.Show("Hi!" + userQL);
                lbTrangThai.Text = " " + userQL + ". Đang hoạt động!";
                usered(login);
                tabControl1.Enabled = true;
            }
            else
            {
                login = false;
                usered(login);
            }
        }

        void usered(bool usered)
        {
            mntAdmin.Enabled = usered;
            buttonEnab(usered);
        }

        

        private void mntThongTinCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void mntDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void mntDangXuat_Click(object sender, EventArgs e)
        {
            login = false;
            usered(login);
            userQL = "";
            lbTrangThai.Text = "Bạn chưa đăng nhập!";
            buttonEnab(false);
        }

        private void mntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        #region mnt Admin

        private void mntDangKyTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void mntQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {

        }
        

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region mnt giới thiệu hướng dẫn
        private void mntGioiThieuCTY_Click(object sender, EventArgs e)
        {

        }

        private void mntGioiThieuPhanMem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion


        #region Hồ sơ nhân sự
        private void btThemHSNS_Click(object sender, EventArgs e)
        {
            //f_ThemNhanVien f = new f_ThemNhanVien(userQL);
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
            lbTrangThai.Text = "Nhập thông tin nhân viên mới vào và Thêm!";
            textboxEnab(true);
            NhanVien nv = new NhanVien();
            loadNV(nv);
            btLuu.Enabled = true;
            btLuu.Text = "Thêm";
        }

        private void btXoaHSNS_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txbMaNV.Text, txbTenNV.Text, cbbGioiTinh.Text, dtpNgaySinh.Value, txbDiaChi.Text,
                txbSDT.Text, txbSoCMND.Text, txbDantoc.Text, txbTrinhVH.Text, dtpNgayVaoLam.Value, ChucVuDAO.Instance.getChucVuByName(cbbChucVu.Text));
            if (NhanVienDAO.Instance.XoaNhanVien(nv))
            {
                lbTrangThai.Text = "Xóa " + nv.MaNV + "thành công.";
                NhanVien n = new NhanVien();
                loadNV(n);
            }
        }

        private void btSuaHSNS_Click(object sender, EventArgs e)
        {
            textboxEnab(true);
            btLuu.Enabled = true;
            btLuu.Text = "Lưu";
        }

        private void lvQLNS_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dtpHSNSngayMAX_ValueChanged(object sender, EventArgs e)
        {
            dtpHSNSngayMIN.MaxDate = dtpHSNSngayMAX.Value;
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtpHSNSngayMIN.Value, dtpHSNSngayMAX.Value,
               cbbChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lbSLItemListView, lbQLNS);
        }

        private void dtpHSNSngayMIN_ValueChanged(object sender, EventArgs e)
        {
            dtpHSNSngayMAX.MinDate = dtpHSNSngayMIN.Value;
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtpHSNSngayMIN.Value, dtpHSNSngayMAX.Value,
               cbbChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lbSLItemListView, lbQLNS);
        }

        private void cbbChucVuHSNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtpHSNSngayMIN.Value, dtpHSNSngayMAX.Value,
                cbbChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lbSLItemListView, lbQLNS);
        }

        private void cbbChucVuHSNS_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtpHSNSngayMIN.Value, dtpHSNSngayMAX.Value,
                cbbChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lbSLItemListView, lbQLNS);
        }

        private void nuHSNStuoiMIN_ValueChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtpHSNSngayMIN.Value, dtpHSNSngayMAX.Value,
               cbbChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lbSLItemListView, lbQLNS);
        }
        
        private void nuHSNSTuoiMAX_ValueChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtpHSNSngayMIN.Value, dtpHSNSngayMAX.Value,
               cbbChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lbSLItemListView, lbQLNS);
        }

        private void btReSetHSNS_Click(object sender, EventArgs e)
        {
            load();
        }

        private void txbTimKiemHSNS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if(btLuu.Text.Equals("Thêm"))
            {
                NhanVien nv = new NhanVien(txbMaNV.Text, txbTenNV.Text, cbbGioiTinh.Text, dtpNgaySinh.Value, txbDiaChi.Text,
                txbSDT.Text, txbSoCMND.Text, txbDantoc.Text, txbTrinhVH.Text, dtpNgayVaoLam.Value, ChucVuDAO.Instance.getChucVuByName(cbbChucVu.Text));
                if (NhanVienDAO.Instance.ThemNhanVien(nv))
                {
                    lbTrangThai.Text = "Thêm " + nv.MaNV + "thành công.";
                    NhanVien n = new NhanVien();
                    loadNV(n);
                }
            }
            else
            {
                NhanVien nv = new NhanVien(txbMaNV.Text, txbTenNV.Text, cbbGioiTinh.Text, dtpNgaySinh.Value, txbDiaChi.Text,
                txbSDT.Text, txbSoCMND.Text, txbDantoc.Text, txbTrinhVH.Text, dtpNgayVaoLam.Value, ChucVuDAO.Instance.getChucVuByName(cbbChucVu.Text));
                if (NhanVienDAO.Instance.SuaNhanVien(nv))
                {
                    lbTrangThai.Text = "Sữa " + nv.MaNV + "thành công.";
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (login)
            {
                tabControl1.Enabled = true;
            }
            else
            {
                lbTrangThai.ForeColor = Color.Red;
                lbTrangThai.Text = "Yêu cầu đăng nhập!";
                tabControl1.Enabled = false;
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                loadDateCC();
                loadNgayCC();
            }
            if(tabControl1.SelectedTab == tabPage3)
            {
                loadLuong();
            }
        }

        private void lvQLNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQLNS.SelectedItems.Count == 0)
                lbTrangThai.Text = " " + userQL + ". Đang hoạt động!";
            else
            {
                btLuu.Enabled = false;
                NhanVien nv = new NhanVien();
                if (lvQLNS.SelectedItems.Count == 1)
                {
                    foreach (NhanVien item in listLoad)
                    {
                        if (item.MaNV == lvQLNS.SelectedItems[0].SubItems[1].Text)
                        {
                            nv = item;
                            loadNV(nv);
                        }
                    }
                }
                else
                {
                    lbTrangThai.Text = "Chọn 1 nhân viên trong danh sách!";
                }


            }
        }

        #endregion


        #region Chấm công
        private void btCCChamCong_Click(object sender, EventArgs e)
        {
            FormChamCong f = new FormChamCong();
            this.Hide();
            f.ShowDialog();
            load();
            this.Show();
        }

        private void btCCcChamPhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btCCNghiPhep_Click(object sender, EventArgs e)
        {

        }

        private void dtpCCMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbCCDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ccbCCChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btResetCC_Click(object sender, EventArgs e)
        {
            loadDateCC();
        }

        private void btCCDuyet_Click(object sender, EventArgs e)
        {
            loadNgayCC();
        }
    

        

        #region loadChamCong

        void loadDateCC()
        {
            DateTime min = DateTime.Now;
            DateTime max = DateTime.Now;
            DataTable dtb = DataProvider.Instance.ExecuteQuery("SELECT MAX(ngayCC) AS ngayMax, MIN(ngayCC) AS ngayMin FROM dbo.ChamCong");
            foreach (DataRow row in dtb.Rows)
            {
                min = (DateTime)row["ngayMin"];
                max = (DateTime)row["ngayMax"];
            }
            dtpCCMax.Value = max;
            dtpCCMin.Value = min;
            dtpCCMax.MaxDate = DateTime.Now;
            dtpCCMax.MinDate = min;
            dtpCCMin.MaxDate = DateTime.Now;
            dtpCCMin.MinDate = min;
        }
        

        void loadNgayCC()
        {
            ChamCongBUS.Instance.loadLVChamCong(lvQLNS, ChamCongDAO.Instance.dsChamCongByDay(dtpCCMax.Value,
               dtpCCMin.Value, ChamCongDAO.Instance.loadDSChamCong()),
                lbSLItemListView, lbQLNS);
        }

        void loadDonHang()
        {

        }

        void loadChuyen()
        {

        }
        #endregion

        #endregion


        #region Tính Lương

        void loadLuong()
        {
            //loadNgayTinhLuong
            string qr = "SELECT  MAX(ngaySinh) as ngayMaxT, MIN(ngaySinh) AS ngayMinT," +
                " MAX(ngayVaoLam) as ngayMax, MIN(ngayVaoLam) AS ngayMin from dbo.NhanVien";
            DataTable tb = DataProvider.Instance.ExecuteQuery(qr);
            foreach (DataRow row in tb.Rows)
            {
                ngayMax = (DateTime)row["ngayMax"];
                ngayMin = (DateTime)row["ngayMin"];
                DateTime nsMax = (DateTime)row["ngayMaxT"];
                DateTime nsMin = (DateTime)row["ngayMinT"];
                tuoiMin = DateTime.Now.Year - nsMax.Year;
                tuoiMax = DateTime.Now.Year - nsMin.Year;
            }
            // loadChucVu
            foreach (ChucVu cv in lcv)
            {
                cbbTLChucVu.Items.Add(cv.TenCV);
            }

            TinhLuongBUS.Instance.loadLVTinhLuong(lvQLNS, TinhLuongDAO.Instance.ListTinhLuong(), lbSLItemListView, lbQLNS);
            //loadChuyen


        }

        private void btTLThanhToanLuong_Click(object sender, EventArgs e)
        {
            FormThanhToanLuong f = new FormThanhToanLuong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btTLBangLuong_Click(object sender, EventArgs e)
        {
            TinhLuongBUS.Instance.loadLVTinhLuong(lvQLNS, TinhLuongDAO.Instance.ListTinhLuong(), lbSLItemListView, lbQLNS);
        }

        private void dtpTLMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbTLChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ccbTLChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btResetTinhLng_Click(object sender, EventArgs e)
        {

        }

        private void btTLDuyet_Click(object sender, EventArgs e)
        {

        }

        private void btTLTimKiem_Click(object sender, EventArgs e)
        {

        }

        

        #endregion


        #region Thống kê
        private void btTKXemTQ_Click(object sender, EventArgs e)
        {

        }

        private void btTKCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void dtpTKMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbTkChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmTKDoTuoiMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbTKBangLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btResetTK_Click(object sender, EventArgs e)
        {

        }

        private void rbtTKNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtTKNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btTKDuyet_Click(object sender, EventArgs e)
        {

        }



        #endregion


        #region Tuyển dụng

        private void btTDThem_Click(object sender, EventArgs e)
        {

        }

        private void btTDXoa_Click(object sender, EventArgs e)
        {

        }

        private void dtpTDMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbTDChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmTDoTuoiMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbTDDoUuTien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btResetTD_Click(object sender, EventArgs e)
        {

        }

        private void btTDDuyet_Click(object sender, EventArgs e)
        {

        }

        private void btTDTimKiem_Click(object sender, EventArgs e)
        {

        }





        #endregion

        private void btReport_Click(object sender, EventArgs e)
        {
            f_report f = new f_report();
            f.ShowDialog();
        }
    }
}
