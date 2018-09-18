namespace Design
{
    partial class FormChamCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChamCong));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChamPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNghiphep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.grpHRRecords = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.cboCCDonHang = new System.Windows.Forms.ComboBox();
            this.lbl17 = new System.Windows.Forms.Label();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.txbCCMaSV = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lbl14 = new System.Windows.Forms.Label();
            this.dtmNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTranhThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clblTLuu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.grpHRRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang,
            this.mnuHuongDan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXemChamCong,
            this.mnuSuaCC,
            this.mnuChamPhat,
            this.mnuNghiphep,
            this.mnuDong});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(77, 20);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuXemChamCong
            // 
            this.mnuXemChamCong.Name = "mnuXemChamCong";
            this.mnuXemChamCong.Size = new System.Drawing.Size(193, 22);
            this.mnuXemChamCong.Text = "Xem chấm công";
            // 
            // mnuSuaCC
            // 
            this.mnuSuaCC.Name = "mnuSuaCC";
            this.mnuSuaCC.Size = new System.Drawing.Size(193, 22);
            this.mnuSuaCC.Text = "Sửa chấm công(Amin)";
            // 
            // mnuChamPhat
            // 
            this.mnuChamPhat.Name = "mnuChamPhat";
            this.mnuChamPhat.Size = new System.Drawing.Size(193, 22);
            this.mnuChamPhat.Text = "Chấm phạt";
            // 
            // mnuNghiphep
            // 
            this.mnuNghiphep.Name = "mnuNghiphep";
            this.mnuNghiphep.Size = new System.Drawing.Size(193, 22);
            this.mnuNghiphep.Text = "Xét nghỉ phép";
            // 
            // mnuDong
            // 
            this.mnuDong.Name = "mnuDong";
            this.mnuDong.Size = new System.Drawing.Size(193, 22);
            this.mnuDong.Text = "Đóng";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(79, 20);
            this.mnuHuongDan.Text = "Hướng dẫn";
            // 
            // grpHRRecords
            // 
            this.grpHRRecords.BackColor = System.Drawing.Color.Azure;
            this.grpHRRecords.Controls.Add(this.cboGioiTinh);
            this.grpHRRecords.Controls.Add(this.lbl13);
            this.grpHRRecords.Controls.Add(this.cboCCDonHang);
            this.grpHRRecords.Controls.Add(this.lbl17);
            this.grpHRRecords.Controls.Add(this.cboTimKiem);
            this.grpHRRecords.Controls.Add(this.txbCCMaSV);
            this.grpHRRecords.Controls.Add(this.lbl2);
            this.grpHRRecords.Controls.Add(this.cboChucVu);
            this.grpHRRecords.Controls.Add(this.lbl14);
            this.grpHRRecords.Controls.Add(this.dtmNgayVaoLam);
            this.grpHRRecords.Controls.Add(this.lbl16);
            this.grpHRRecords.Location = new System.Drawing.Point(12, 27);
            this.grpHRRecords.Name = "grpHRRecords";
            this.grpHRRecords.Size = new System.Drawing.Size(897, 58);
            this.grpHRRecords.TabIndex = 23;
            this.grpHRRecords.TabStop = false;
            this.grpHRRecords.Text = "Bảng tùy chọn";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Enabled = false;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(404, 25);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(104, 21);
            this.cboGioiTinh.TabIndex = 35;
            this.cboGioiTinh.Text = "tất cả";
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Location = new System.Drawing.Point(401, 8);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(43, 13);
            this.lbl13.TabIndex = 34;
            this.lbl13.Text = "Chuyền";
            // 
            // cboCCDonHang
            // 
            this.cboCCDonHang.Enabled = false;
            this.cboCCDonHang.FormattingEnabled = true;
            this.cboCCDonHang.Location = new System.Drawing.Point(245, 25);
            this.cboCCDonHang.Name = "cboCCDonHang";
            this.cboCCDonHang.Size = new System.Drawing.Size(153, 21);
            this.cboCCDonHang.TabIndex = 33;
            // 
            // lbl17
            // 
            this.lbl17.AutoSize = true;
            this.lbl17.Location = new System.Drawing.Point(242, 10);
            this.lbl17.Name = "lbl17";
            this.lbl17.Size = new System.Drawing.Size(106, 13);
            this.lbl17.TabIndex = 32;
            this.lbl17.Text = "Đơn hàng(sản phẩm)";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Location = new System.Drawing.Point(750, 30);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(141, 21);
            this.cboTimKiem.TabIndex = 31;
            this.cboTimKiem.Text = "Tên nhân viên";
            // 
            // txbCCMaSV
            // 
            this.txbCCMaSV.Location = new System.Drawing.Point(581, 30);
            this.txbCCMaSV.Name = "txbCCMaSV";
            this.txbCCMaSV.Size = new System.Drawing.Size(163, 20);
            this.txbCCMaSV.TabIndex = 30;
            this.txbCCMaSV.TextChanged += new System.EventHandler(this.txbCCMaSV_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(561, 13);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(49, 13);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "Tìm kiếm";
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(115, 27);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(126, 21);
            this.cboChucVu.TabIndex = 16;
            this.cboChucVu.Text = "tất cả";
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Location = new System.Drawing.Point(112, 10);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(47, 13);
            this.lbl14.TabIndex = 15;
            this.lbl14.Text = "Chức vụ";
            // 
            // dtmNgayVaoLam
            // 
            this.dtmNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayVaoLam.Location = new System.Drawing.Point(25, 32);
            this.dtmNgayVaoLam.Name = "dtmNgayVaoLam";
            this.dtmNgayVaoLam.Size = new System.Drawing.Size(84, 20);
            this.dtmNgayVaoLam.TabIndex = 12;
            this.dtmNgayVaoLam.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtmNgayVaoLam.ValueChanged += new System.EventHandler(this.dtmNgayVaoLam_ValueChanged);
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Location = new System.Drawing.Point(6, 16);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(88, 13);
            this.lbl16.TabIndex = 11;
            this.lbl16.Text = "Ngày chấm công";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl1.Location = new System.Drawing.Point(365, 88);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(198, 24);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "Danh sách Nhân viên";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.CausesValidation = false;
            this.dgvChamCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaNV,
            this.clTenNV,
            this.clNgaySinh,
            this.clNgayCC,
            this.clThoiGian,
            this.clSLg,
            this.clblTLuu,
            this.clXoa});
            this.dgvChamCong.EnableHeadersVisualStyles = false;
            this.dgvChamCong.Location = new System.Drawing.Point(12, 115);
            this.dgvChamCong.MultiSelect = false;
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.ShowRowErrors = false;
            this.dgvChamCong.Size = new System.Drawing.Size(894, 348);
            this.dgvChamCong.TabIndex = 27;
            this.dgvChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSL,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lblTranhThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel1.Text = "SL: ";
            // 
            // lblSL
            // 
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(25, 17);
            this.lblSL.Text = "100";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel3.Text = "||";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel4.Text = "Trạng Thái: ";
            // 
            // lblTranhThai
            // 
            this.lblTranhThai.Name = "lblTranhThai";
            this.lblTranhThai.Size = new System.Drawing.Size(55, 17);
            this.lblTranhThai.Text = "Chưa lưu";
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Width = 40;
            // 
            // clMaNV
            // 
            this.clMaNV.HeaderText = "Mã NV";
            this.clMaNV.Name = "clMaNV";
            this.clMaNV.Width = 90;
            // 
            // clTenNV
            // 
            this.clTenNV.HeaderText = "Họ và tên";
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.Width = 150;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Width = 90;
            // 
            // clNgayCC
            // 
            this.clNgayCC.HeaderText = "Ngày CC";
            this.clNgayCC.Name = "clNgayCC";
            this.clNgayCC.Width = 90;
            // 
            // clThoiGian
            // 
            this.clThoiGian.HeaderText = "Giờ CC(h)";
            this.clThoiGian.Name = "clThoiGian";
            // 
            // clSLg
            // 
            this.clSLg.HeaderText = "Số lượng(sp)";
            this.clSLg.Name = "clSLg";
            // 
            // clblTLuu
            // 
            this.clblTLuu.HeaderText = "Chấm công";
            this.clblTLuu.Name = "clblTLuu";
            this.clblTLuu.Text = "Lưu";
            this.clblTLuu.UseColumnTextForButtonValue = true;
            // 
            // clXoa
            // 
            this.clXoa.HeaderText = "Xóa CC";
            this.clXoa.Name = "clXoa";
            this.clXoa.Text = "Xóa";
            this.clXoa.UseColumnTextForButtonValue = true;
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.grpHRRecords);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChamCong";
            this.Text = "Quản lý nhân sự - Chấm Công";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpHRRecords.ResumeLayout(false);
            this.grpHRRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuXemChamCong;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaCC;
        private System.Windows.Forms.ToolStripMenuItem mnuChamPhat;
        private System.Windows.Forms.ToolStripMenuItem mnuNghiphep;
        private System.Windows.Forms.ToolStripMenuItem mnuDong;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.GroupBox grpHRRecords;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.DateTimePicker dtmNgayVaoLam;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblTranhThai;
        private System.Windows.Forms.TextBox txbCCMaSV;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.ComboBox cboCCDonHang;
        private System.Windows.Forms.Label lbl17;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLg;
        private System.Windows.Forms.DataGridViewButtonColumn clblTLuu;
        private System.Windows.Forms.DataGridViewButtonColumn clXoa;
        private System.Windows.Forms.DataGridView dgvChamCong;
    }
}