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
    public partial class FormThemNhanVien : Form
    {
        List<NhanVien> list = new List<NhanVien>();
        NhanVien nvSelected = new NhanVien();
        string user = "";
        
        int xbtn, ybtn;
        public FormThemNhanVien(string u)
        {
            InitializeComponent();
            user = u;
        }

        void load()
        {
            int i = 1;
            foreach(NhanVien nv in list)
            {
            }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnReSet_Click(object sender, EventArgs e)
        {

        }
    }
}
