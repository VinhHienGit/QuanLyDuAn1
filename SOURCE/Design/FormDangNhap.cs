using Design.DAO;
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
    public partial class FormDangNhap : Form
    {
        public String user = "";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() != null && txtMatKhau.Text.Trim() != null)
                btnnDangNhap.Enabled = true;
            else
                btnnDangNhap.Enabled = false;

        }

        private void btnnDangNhap_Click(object sender, EventArgs e)
        {
            if(AccountDAO.Instance.login(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim()))
            {
                user = txtTaiKhoan.Text;
                this.Hide();
                txtMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
                user = "";
            }
        }

        private void btnnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region function
        

        
        #endregion
    }
}
