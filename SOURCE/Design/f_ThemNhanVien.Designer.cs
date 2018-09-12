namespace Design
{
    partial class f_ThemNhanVien
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
            this.mnt = new System.Windows.Forms.MenuStrip();
            this.mntChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mntXemHSNS = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThemNS = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThemDSNS = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnMẫuThêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mẫuMặcĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntNhapTuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mntHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReSet = new System.Windows.Forms.Button();
            this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDanToc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrSLNSM = new System.Windows.Forms.NumericUpDown();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvThemNS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clNgaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clNgayVaolam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mnt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSLNSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNS)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnt
            // 
            this.mnt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntChucNang,
            this.mntHuongDan});
            this.mnt.Location = new System.Drawing.Point(0, 0);
            this.mnt.Name = "mnt";
            this.mnt.Size = new System.Drawing.Size(921, 24);
            this.mnt.TabIndex = 0;
            this.mnt.Text = "menuStrip1";
            // 
            // mntChucNang
            // 
            this.mntChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntXemHSNS,
            this.mntThemNS,
            this.mntThemDSNS,
            this.mntNhapTuFile,
            this.mntDong});
            this.mntChucNang.Name = "mntChucNang";
            this.mntChucNang.Size = new System.Drawing.Size(77, 20);
            this.mntChucNang.Text = "Chức năng";
            // 
            // mntXemHSNS
            // 
            this.mntXemHSNS.Name = "mntXemHSNS";
            this.mntXemHSNS.Size = new System.Drawing.Size(207, 22);
            this.mntXemHSNS.Text = "Xem hô sơ nhân sự";
            // 
            // mntThemNS
            // 
            this.mntThemNS.Name = "mntThemNS";
            this.mntThemNS.Size = new System.Drawing.Size(207, 22);
            this.mntThemNS.Text = "Thêm nhân sự";
            // 
            // mntThemDSNS
            // 
            this.mntThemDSNS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnMẫuThêmToolStripMenuItem,
            this.mẫuMặcĐịnhToolStripMenuItem});
            this.mntThemDSNS.Name = "mntThemDSNS";
            this.mntThemDSNS.Size = new System.Drawing.Size(207, 22);
            this.mntThemDSNS.Text = "Thêm danh sách nhân sự";
            // 
            // tùyChọnMẫuThêmToolStripMenuItem
            // 
            this.tùyChọnMẫuThêmToolStripMenuItem.Name = "tùyChọnMẫuThêmToolStripMenuItem";
            this.tùyChọnMẫuThêmToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tùyChọnMẫuThêmToolStripMenuItem.Text = "Tùy chọn mẫu Thêm";
            // 
            // mẫuMặcĐịnhToolStripMenuItem
            // 
            this.mẫuMặcĐịnhToolStripMenuItem.Name = "mẫuMặcĐịnhToolStripMenuItem";
            this.mẫuMặcĐịnhToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mẫuMặcĐịnhToolStripMenuItem.Text = "Mẫu mặc định";
            // 
            // mntNhapTuFile
            // 
            this.mntNhapTuFile.Name = "mntNhapTuFile";
            this.mntNhapTuFile.Size = new System.Drawing.Size(207, 22);
            this.mntNhapTuFile.Text = "Nhập liệu từ file";
            // 
            // mntDong
            // 
            this.mntDong.Name = "mntDong";
            this.mntDong.Size = new System.Drawing.Size(207, 22);
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
            this.groupBox1.Controls.Add(this.btReSet);
            this.groupBox1.Controls.Add(this.cbbTrinhDo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbDanToc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmrSLNSM);
            this.groupBox1.Controls.Add(this.btLuu);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtpNgayVaoLam);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 58);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng tùy chọn";
            // 
            // btReSet
            // 
            this.btReSet.Location = new System.Drawing.Point(835, 11);
            this.btReSet.Name = "btReSet";
            this.btReSet.Size = new System.Drawing.Size(56, 37);
            this.btReSet.TabIndex = 28;
            this.btReSet.Text = "Làm mới";
            this.btReSet.UseVisualStyleBackColor = true;
            this.btReSet.Click += new System.EventHandler(this.btReSet_Click);
            // 
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Location = new System.Drawing.Point(529, 28);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.Size = new System.Drawing.Size(104, 21);
            this.cbbTrinhDo.TabIndex = 27;
            this.cbbTrinhDo.Text = "Chọn trình độ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Trình độ";
            // 
            // cbbDanToc
            // 
            this.cbbDanToc.FormattingEnabled = true;
            this.cbbDanToc.Location = new System.Drawing.Point(419, 28);
            this.cbbDanToc.Name = "cbbDanToc";
            this.cbbDanToc.Size = new System.Drawing.Size(104, 21);
            this.cbbDanToc.TabIndex = 25;
            this.cbbDanToc.Text = "Chọn dân tộc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dân tộc ";
            // 
            // nmrSLNSM
            // 
            this.nmrSLNSM.Location = new System.Drawing.Point(639, 29);
            this.nmrSLNSM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrSLNSM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSLNSM.Name = "nmrSLNSM";
            this.nmrSLNSM.Size = new System.Drawing.Size(62, 20);
            this.nmrSLNSM.TabIndex = 23;
            this.nmrSLNSM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(780, 11);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(49, 37);
            this.btLuu.TabIndex = 22;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(707, 11);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(67, 37);
            this.btThem.TabIndex = 21;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(619, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "SL Nhân sự mới";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(309, 28);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(104, 21);
            this.cbbGioiTinh.TabIndex = 18;
            this.cbbGioiTinh.Text = "Chọn giới tính";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Giới tính";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(176, 28);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(126, 21);
            this.cbbChucVu.TabIndex = 16;
            this.cbbChucVu.Text = "Chọn chức vụ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Chức vụ";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(83, 16);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(84, 20);
            this.dtpNgayVaoLam.TabIndex = 12;
            this.dtpNgayVaoLam.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Ngày vào làm";
            // 
            // dgvThemNS
            // 
            this.dgvThemNS.AllowUserToOrderColumns = true;
            this.dgvThemNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemNS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaNV,
            this.clTenNV,
            this.clGioiTinh,
            this.clNgaySinhNV,
            this.clDiaChi,
            this.clSDT,
            this.clChucVu,
            this.clNgayVaolam});
            this.dgvThemNS.EnableHeadersVisualStyles = false;
            this.dgvThemNS.Location = new System.Drawing.Point(12, 115);
            this.dgvThemNS.Name = "dgvThemNS";
            this.dgvThemNS.RowHeadersVisible = false;
            this.dgvThemNS.Size = new System.Drawing.Size(897, 356);
            this.dgvThemNS.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(370, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hồ sơ nhân sự mới";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(921, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel1.Text = "SL: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel2.Text = "100";
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
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(288, 17);
            this.toolStripStatusLabel5.Text = "Tùy chọn thông tin mặc định và thêm nhân sự mới!";
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 40;
            // 
            // clMaNV
            // 
            this.clMaNV.HeaderText = "Mã NV";
            this.clMaNV.Name = "clMaNV";
            this.clMaNV.Width = 85;
            // 
            // clTenNV
            // 
            this.clTenNV.HeaderText = "Họ và tên";
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.Width = 160;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.HeaderText = "Giới tính";
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.Width = 70;
            // 
            // clNgaySinhNV
            // 
            this.clNgaySinhNV.HeaderText = "Ngày sinh";
            this.clNgaySinhNV.Name = "clNgaySinhNV";
            this.clNgaySinhNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clNgaySinhNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clDiaChi
            // 
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Width = 130;
            // 
            // clSDT
            // 
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            // 
            // clChucVu
            // 
            this.clChucVu.HeaderText = "Chức vụ";
            this.clChucVu.Name = "clChucVu";
            this.clChucVu.Width = 110;
            // 
            // clNgayVaolam
            // 
            this.clNgayVaolam.HeaderText = "Ngày vào làm";
            this.clNgayVaolam.Name = "clNgayVaolam";
            // 
            // f_ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(921, 496);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThemNS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnt);
            this.Name = "f_ThemNhanVien";
            this.Text = "Quản lý nhân sự - Thêm nhân sự";
            this.mnt.ResumeLayout(false);
            this.mnt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSLNSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNS)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnt;
        private System.Windows.Forms.ToolStripMenuItem mntChucNang;
        private System.Windows.Forms.ToolStripMenuItem mntThemNS;
        private System.Windows.Forms.ToolStripMenuItem mntThemDSNS;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnMẫuThêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mẫuMặcĐịnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mntNhapTuFile;
        private System.Windows.Forms.ToolStripMenuItem mntDong;
        private System.Windows.Forms.ToolStripMenuItem mntHuongDan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btReSet;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbDanToc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrSLNSM;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvThemNS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem mntXemHSNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewComboBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewComboBoxColumn clNgayVaolam;
    }
}