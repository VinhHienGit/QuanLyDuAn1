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
    public partial class FormQuanLyNhanSu : Form   {
        String userQL = "";
        bool login = false;
        DateTime ngayMin;
        DateTime ngayMax;
        List<ChucVu> lcv = new List<ChucVu>();
        int tuoiMin;
        int tuoiMax;
        List<NhanVien> listLoad;
<<<<<<< HEAD:SOURCE/Design/FormQuanLyNhanSu.cs
        f_DangNhap fdn = new f_DangNhap();
=======
        FormDangNhap fdn = new FormDangNhap();
>>>>>>> feature/Edit_convention:SOURCE/Design/FormQuanLyNhanSu.cs
        public FormQuanLyNhanSu()
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
            NhanVienBUS.Instance.loadHSNS(lvQLNS, listLoad, lblSLItemListView, lblQLNS);
            loaddataload();
            loadLocDanhSach(ngayMin, ngayMax, lcv, tuoiMin, tuoiMax);

            // Chấm công
            
        }

        void textboxEnab(bool en)
        {
            txbMaHSNS.Enabled = false;
            txbMaNV.Enabled = false;
            txbtnenNV.Enabled = en;
            txbDantoc.Enabled = en;
            txbDiaChi.Enabled = en;
            txbSDT.Enabled = en;
            txbSoCMND.Enabled = en;
            dtmNgaySinh.Enabled = en;
            dtmNgayVaoLam.Enabled = en;
            cboGioiTinh.Enabled = en;
            cboChucVu.Enabled = en;
            txbtnrinhVH.Enabled = en;
        }

        void buttonEnab(bool en)
        {
<<<<<<< HEAD:SOURCE/Design/FormQuanLyNhanSu.cs
            btnThemHSNS.Enabled = en;
            btnCCcChamPhat.Enabled = en;
            btnCCChamCong.Enabled = en;
            btnCCNghiPhep.Enabled = en;
            btnSuaHSNS.Enabled = en;
            btnTDXoa.Enabled = en;
            btnTLThanhToanLuong.Enabled = en;
            btnXoaHSNS.Enabled = en;
=======
            btThemHSNS.Enabled = en;
            btCCcChamPhat.Enabled = en;
            btCCChamCong.Enabled = en;
            btCCNghiPhep.Enabled = en;
            btSuaHSNS.Enabled = en;
            btTDXoa.Enabled = en;
            btTLThanhToanLuong.Enabled = en;
            btXoaHSNS.Enabled = en;
>>>>>>> feature/Edit_convention:SOURCE/Design/FormQuanLyNhanSu.cs
            mnuAdmin.Enabled = en;
            lvQLNS.Enabled = en;
            mnuThongTinCaNhan.Enabled = en;
            mnuDoiMatKhau.Enabled = en;
            mnuDangXuat.Enabled = en;
        }

        void loadNV(NhanVien nv)
        {
            // Load data staff.
            txbMaHSNS.Text = nv.MaNV;
            txbMaNV.Text = nv.MaNV;
            txbDantoc.Text = nv.DanToc;
            txbDiaChi.Text = nv.DiaChi;
            txbSDT.Text = nv.SDT;
            txbSoCMND.Text = nv.CMND;
            txbtnenNV.Text = nv.TenNV;
            dtmNgaySinh.Value = nv.NgaySinh;
            dtmNgayVaoLam.Value = nv.NgayVaoLam;
            cboChucVu.Text = nv.ChucVuNV.TenCV;
            cboGioiTinh.Text = nv.GioiTinh;
            txbtnrinhVH.Text = nv.TrinhDo;
        }

        void loadLocDanhSach(DateTime ngayMin, DateTime ngayMax, List<ChucVu> lcv, int tuoiMin, int tuoiMax)
        {
            //Loa
            cboChucVuHSNS.Items.Clear();
            dtmHSNSngayMIN.Value = ngayMin;
            dtmHSNSngayMIN.MinDate = ngayMin;
            dtmHSNSngayMAX.MaxDate = ngayMax;
            dtmHSNSngayMAX.Value = ngayMax;
            dtmHSNSngayMAX.MaxDate = ngayMax;
            dtmHSNSngayMAX.MinDate = ngayMin;
            nuHSNSTuoiMAX.Value = tuoiMax;
            nuHSNSTuoiMAX.Maximum = tuoiMax;
            nuHSNSTuoiMAX.Minimum = tuoiMin;
            nuHSNStuoiMIN.Value = tuoiMin;
            nuHSNStuoiMIN.Maximum = tuoiMax;
            nuHSNStuoiMIN.Minimum = tuoiMin;
            foreach(ChucVu cv in lcv)
            {
                cboChucVuHSNS.Items.Add(cv.TenCV);
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


        #region mnu Tài khoảng

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap fdn = new FormDangNhap();
            fdn.ShowDialog();
            userQL = fdn.user;
            if (userQL != "")
            {
                login = true;
                MessageBox.Show("Hi!" + userQL);
                lbltnrangThai.Text = " " + userQL + ". Đang hoạt động!";
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
            mnuAdmin.Enabled = usered;
            buttonEnab(usered);
        }

        

        private void mnuThongTinCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            login = false;
            usered(login);
            userQL = "";
            lbltnrangThai.Text = "Bạn chưa đăng nhập!";
            buttonEnab(false);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        #region mnu Admin

        private void mnuDangKyTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {

        }
        

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region mnu giới thiệu hướng dẫn
        private void mnuGioiThieuCTY_Click(object sender, EventArgs e)
        {

        }

        private void mnuGioiThieuPhanMem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion


        #region Hồ sơ nhân sự
        private void btnThemHSNS_Click(object sender, EventArgs e)
        {
            //f_ThemNhanVien f = new f_ThemNhanVien(userQL);
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
            lbltnrangThai.Text = "Nhập thông tin nhân viên mới vào và Thêm!";
            textboxEnab(true);
            NhanVien nv = new NhanVien();
            loadNV(nv);
            btnLuu.Enabled = true;
            btnLuu.Text = "Thêm";
        }

        private void btnXoaHSNS_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txbMaNV.Text, txbtnenNV.Text, cboGioiTinh.Text, dtmNgaySinh.Value, txbDiaChi.Text,
                txbSDT.Text, txbSoCMND.Text, txbDantoc.Text, txbtnrinhVH.Text, dtmNgayVaoLam.Value, ChucVuDAO.Instance.getChucVuByName(cboChucVu.Text));
            if (NhanVienDAO.Instance.XoaNhanVien(nv))
            {
                lbltnrangThai.Text = "Xóa " + nv.MaNV + "thành công.";
                NhanVien n = new NhanVien();
                loadNV(n);
            }
        }

        private void btnSuaHSNS_Click(object sender, EventArgs e)
        {
            textboxEnab(true);
            btnLuu.Enabled = true;
            btnLuu.Text = "Lưu";
        }

        private void lvQLNS_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dtmHSNSngayMAX_ValueChanged(object sender, EventArgs e)
        {
            dtmHSNSngayMIN.MaxDate = dtmHSNSngayMAX.Value;
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtmHSNSngayMIN.Value, dtmHSNSngayMAX.Value,
               cboChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lblSLItemListView, lblQLNS);
        }

        private void dtmHSNSngayMIN_ValueChanged(object sender, EventArgs e)
        {
            dtmHSNSngayMAX.MinDate = dtmHSNSngayMIN.Value;
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtmHSNSngayMIN.Value, dtmHSNSngayMAX.Value,
               cboChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lblSLItemListView, lblQLNS);
        }

        private void cboChucVuHSNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtmHSNSngayMIN.Value, dtmHSNSngayMAX.Value,
                cboChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lblSLItemListView, lblQLNS);
        }

        private void cboChucVuHSNS_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtmHSNSngayMIN.Value, dtmHSNSngayMAX.Value,
                cboChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lblSLItemListView, lblQLNS);
        }

        private void nuHSNStuoiMIN_ValueChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtmHSNSngayMIN.Value, dtmHSNSngayMAX.Value,
               cboChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lblSLItemListView, lblQLNS);
        }
        
        private void nuHSNSTuoiMAX_ValueChanged(object sender, EventArgs e)
        {
            List<NhanVien> ds = NhanVienBUS.Instance.checkedList(listLoad, dtmHSNSngayMIN.Value, dtmHSNSngayMAX.Value,
               cboChucVuHSNS.Text, (int)nuHSNStuoiMIN.Value, (int)nuHSNSTuoiMAX.Value);
            NhanVienBUS.Instance.loadHSNS(lvQLNS, ds, lblSLItemListView, lblQLNS);
        }

        private void btnReSetHSNS_Click(object sender, EventArgs e)
        {
            load();
        }

        private void txbtnimKiemHSNS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnLuu.Text.Equals("Thêm"))
            {
                NhanVien nv = new NhanVien(txbMaNV.Text, txbtnenNV.Text, cboGioiTinh.Text, dtmNgaySinh.Value, txbDiaChi.Text,
                txbSDT.Text, txbSoCMND.Text, txbDantoc.Text, txbtnrinhVH.Text, dtmNgayVaoLam.Value, ChucVuDAO.Instance.getChucVuByName(cboChucVu.Text));
                if (NhanVienDAO.Instance.ThemNhanVien(nv))
                {
                    lbltnrangThai.Text = "Thêm " + nv.MaNV + "thành công.";
                    NhanVien n = new NhanVien();
                    loadNV(n);
                }
            }
            else
            {
                NhanVien nv = new NhanVien(txbMaNV.Text, txbtnenNV.Text, cboGioiTinh.Text, dtmNgaySinh.Value, txbDiaChi.Text,
                txbSDT.Text, txbSoCMND.Text, txbDantoc.Text, txbtnrinhVH.Text, dtmNgayVaoLam.Value, ChucVuDAO.Instance.getChucVuByName(cboChucVu.Text));
                if (NhanVienDAO.Instance.SuaNhanVien(nv))
                {
                    lbltnrangThai.Text = "Sữa " + nv.MaNV + "thành công.";
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
                lbltnrangThai.ForeColor = Color.Red;
                lbltnrangThai.Text = "Yêu cầu đăng nhập!";
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
                lbltnrangThai.Text = " " + userQL + ". Đang hoạt động!";
            else
            {
                btnLuu.Enabled = false;
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
                    lbltnrangThai.Text = "Chọn 1 nhân viên trong danh sách!";
                }


            }
        }

        #endregion


        #region Chấm công
        private void btnCCChamCong_Click(object sender, EventArgs e)
        {
            FormChamCong f = new FormChamCong();
            this.Hide();
            f.ShowDialog();
            load();
            this.Show();
        }

        private void btnCCcChamPhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCCNghiPhep_Click(object sender, EventArgs e)
        {

        }

        private void dtmCCMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbCCDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ccbCCChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetCC_Click(object sender, EventArgs e)
        {
            loadDateCC();
        }

        private void btnCCDuyet_Click(object sender, EventArgs e)
        {
            loadNgayCC();
        }
    

        

        #region loadChamCong

        void loadDateCC()
        {
            DateTime min = DateTime.Now;
            DateTime max = DateTime.Now;
            DataTable dtm = DataProvider.Instance.ExecuteQuery("SELECT MAX(ngayCC) AS ngayMax, MIN(ngayCC) AS ngayMin FROM dbo.ChamCong");
            foreach (DataRow row in dtm.Rows)
            {
                min = (DateTime)row["ngayMin"];
                max = (DateTime)row["ngayMax"];
            }
            dtmCCMax.Value = max;
            dtmCCMin.Value = min;
            dtmCCMax.MaxDate = DateTime.Now;
            dtmCCMax.MinDate = min;
            dtmCCMin.MaxDate = DateTime.Now;
            dtmCCMin.MinDate = min;
        }
        

        void loadNgayCC()
        {
            ChamCongBUS.Instance.loadLVChamCong(lvQLNS, ChamCongDAO.Instance.dsChamCongByDay(dtmCCMax.Value,
               dtmCCMin.Value, ChamCongDAO.Instance.loadDSChamCong()),
                lblSLItemListView, lblQLNS);
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
                cbotnLChucVu.Items.Add(cv.TenCV);
            }

            TinhLuongBUS.Instance.loadLVTinhLuong(lvQLNS, TinhLuongDAO.Instance.ListTinhLuong(), lblSLItemListView, lblQLNS);
            //loadChuyen


        }

        private void btnTLThanhToanLuong_Click(object sender, EventArgs e)
        {
            FormThanhToanLuong f = new FormThanhToanLuong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTlblangLuong_Click(object sender, EventArgs e)
        {
            TinhLuongBUS.Instance.loadLVTinhLuong(lvQLNS, TinhLuongDAO.Instance.ListTinhLuong(), lblSLItemListView, lblQLNS);
        }

        private void dtmTLMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbtnLChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ccbtnLChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetTinhLng_Click(object sender, EventArgs e)
        {

        }

        private void btnTLDuyet_Click(object sender, EventArgs e)
        {

        }

        private void btnTLTimKiem_Click(object sender, EventArgs e)
        {

        }

        

        #endregion


        #region Thống kê
        private void btnTKXemTQ_Click(object sender, EventArgs e)
        {

        }

        private void btnTKCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void dtmTKMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbtnkChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmTKDoTuoiMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbtnKBangLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetTK_Click(object sender, EventArgs e)
        {

        }

        private void rbtnTKNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnTKNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTKDuyet_Click(object sender, EventArgs e)
        {

        }



        #endregion


        #region Tuyển dụng

        private void btnTDThem_Click(object sender, EventArgs e)
        {

        }

        private void btnTDXoa_Click(object sender, EventArgs e)
        {

        }

        private void dtmTDMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbtnDChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmTDoTuoiMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ccbtnDDoUuTien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetTD_Click(object sender, EventArgs e)
        {

        }

        private void btnTDDuyet_Click(object sender, EventArgs e)
        {

        }

        private void btnTDTimKiem_Click(object sender, EventArgs e)
        {

        }





        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport();
            f.ShowDialog();
        }
    }
}
