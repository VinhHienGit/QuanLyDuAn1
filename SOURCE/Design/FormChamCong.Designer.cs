﻿namespace Design
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
            this.mntChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mntXemChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mntSuaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mntChamPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mntNghiphep = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mntHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ccbCCDonHang = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.txtCCMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtmNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntChucNang,
            this.mntHuongDan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntChucNang
            // 
            this.mntChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntXemChamCong,
            this.mntSuaCC,
            this.mntChamPhat,
            this.mntNghiphep,
            this.mntDong});
            this.mntChucNang.Name = "mntChucNang";
            this.mntChucNang.Size = new System.Drawing.Size(77, 20);
            this.mntChucNang.Text = "Chức năng";
            // 
            // mntXemChamCong
            // 
            this.mntXemChamCong.Name = "mntXemChamCong";
            this.mntXemChamCong.Size = new System.Drawing.Size(193, 22);
            this.mntXemChamCong.Text = "Xem chấm công";
            // 
            // mntSuaCC
            // 
            this.mntSuaCC.Name = "mntSuaCC";
            this.mntSuaCC.Size = new System.Drawing.Size(193, 22);
            this.mntSuaCC.Text = "Sửa chấm công(Amin)";
            // 
            // mntChamPhat
            // 
            this.mntChamPhat.Name = "mntChamPhat";
            this.mntChamPhat.Size = new System.Drawing.Size(193, 22);
            this.mntChamPhat.Text = "Chấm phạt";
            // 
            // mntNghiphep
            // 
            this.mntNghiphep.Name = "mntNghiphep";
            this.mntNghiphep.Size = new System.Drawing.Size(193, 22);
            this.mntNghiphep.Text = "Xét nghỉ phép";
            // 
            // mntDong
            // 
            this.mntDong.Name = "mntDong";
            this.mntDong.Size = new System.Drawing.Size(193, 22);
            this.mntDong.Text = "Đóng";
            // 
            // mntHuongDan
            // 
            this.mntHuongDan.Name = "mntHuongDan";
            this.mntHuongDan.Size = new System.Drawing.Size(79, 20);
            this.mntHuongDan.Text = "Hướng dẫn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ccbCCDonHang);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cboTimKiem);
            this.groupBox1.Controls.Add(this.txtCCMaSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboChucVu);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtmNgayVaoLam);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 58);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng tùy chọn";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Chuyền";
            // 
            // ccbCCDonHang
            // 
            this.ccbCCDonHang.Enabled = false;
            this.ccbCCDonHang.FormattingEnabled = true;
            this.ccbCCDonHang.Location = new System.Drawing.Point(245, 25);
            this.ccbCCDonHang.Name = "ccbCCDonHang";
            this.ccbCCDonHang.Size = new System.Drawing.Size(153, 21);
            this.ccbCCDonHang.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(242, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Đơn hàng(sản phẩm)";
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
            // txtCCMaSV
            // 
            this.txtCCMaSV.Location = new System.Drawing.Point(581, 30);
            this.txtCCMaSV.Name = "txtCCMaSV";
            this.txtCCMaSV.Size = new System.Drawing.Size(163, 20);
            this.txtCCMaSV.TabIndex = 30;
            this.txtCCMaSV.TextChanged += new System.EventHandler(this.txtCCMaSV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tìm kiếm";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Chức vụ";
            //p
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Ngày chấm công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(365, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Danh sách Nhân viên";
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
            // f_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_ChamCong";
            this.Text = "Quản lý nhân sự - Chấm Công";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntChucNang;
        private System.Windows.Forms.ToolStripMenuItem mntXemChamCong;
        private System.Windows.Forms.ToolStripMenuItem mntSuaCC;
        private System.Windows.Forms.ToolStripMenuItem mntChamPhat;
        private System.Windows.Forms.ToolStripMenuItem mntNghiphep;
        private System.Windows.Forms.ToolStripMenuItem mntDong;
        private System.Windows.Forms.ToolStripMenuItem mntHuongDan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtmNgayVaoLam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblTranhThai;
        private System.Windows.Forms.TextBox txtCCMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ccbCCDonHang;
        private System.Windows.Forms.Label label17;
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