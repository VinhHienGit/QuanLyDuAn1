namespace Design
{
    partial class FormDangNhap
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
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbl32 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl39 = new System.Windows.Forms.Label();
            this.btnnDangNhap = new System.Windows.Forms.Button();
            this.btnnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(130, 58);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(178, 20);
            this.txtMatKhau.TabIndex = 64;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbl32
            // 
            this.lbl32.AutoSize = true;
            this.lbl32.Location = new System.Drawing.Point(63, 61);
            this.lbl32.Name = "lbl32";
            this.lbl32.Size = new System.Drawing.Size(52, 13);
            this.lbl32.TabIndex = 63;
            this.lbl32.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(130, 32);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(178, 20);
            this.txtTaiKhoan.TabIndex = 62;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbl39
            // 
            this.lbl39.AutoSize = true;
            this.lbl39.Location = new System.Drawing.Point(63, 35);
            this.lbl39.Name = "lbl39";
            this.lbl39.Size = new System.Drawing.Size(55, 13);
            this.lbl39.TabIndex = 61;
            this.lbl39.Text = "Tài khoản";
            // 
            // btnnDangNhap
            // 
            this.btnnDangNhap.Location = new System.Drawing.Point(172, 84);
            this.btnnDangNhap.Name = "btnnDangNhap";
            this.btnnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnnDangNhap.TabIndex = 66;
            this.btnnDangNhap.Text = "Đăng nhập";
            this.btnnDangNhap.UseVisualStyleBackColor = true;
            this.btnnDangNhap.Click += new System.EventHandler(this.btnnDangNhap_Click);
            // 
            // btnnThoat
            // 
            this.btnnThoat.Location = new System.Drawing.Point(275, 84);
            this.btnnThoat.Name = "btnnThoat";
            this.btnnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnnThoat.TabIndex = 67;
            this.btnnThoat.Text = "Thoát";
            this.btnnThoat.UseVisualStyleBackColor = true;
            this.btnnThoat.Click += new System.EventHandler(this.btnnThoat_Click);
            // 
            // f_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 117);
            this.ControlBox = false;
            this.Controls.Add(this.btnnThoat);
            this.Controls.Add(this.btnnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lbl32);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbl39);
            this.Name = "f_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự - Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbl32;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbl39;
        private System.Windows.Forms.Button btnnDangNhap;
        private System.Windows.Forms.Button btnnThoat;
    }
}