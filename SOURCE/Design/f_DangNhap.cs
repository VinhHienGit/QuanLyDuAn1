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
    public partial class f_DangNhap : Form
    {
        public String user = "";
        public f_DangNhap()
        {
            InitializeComponent();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tbTaiKhoan.Text.Trim() != null && tbMatKhau.Text.Trim() != null)
                btDangNhap.Enabled = true;
            else
                btDangNhap.Enabled = false;

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if(AccountDAO.Instance.login(tbTaiKhoan.Text.Trim(), tbMatKhau.Text.Trim()))
            {
                user = tbTaiKhoan.Text;
                this.Hide();
                tbMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
                user = "";
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region function
        

        
        #endregion
    }
}
