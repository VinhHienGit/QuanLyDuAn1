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
    public partial class f_ThemNhanVien : Form
    {
        List<NhanVien> list = new List<NhanVien>();
        NhanVien nvSelected = new NhanVien();
        string user = "";
        
        int xbt, ybt;
        public f_ThemNhanVien(string u)
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
        

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void btReSet_Click(object sender, EventArgs e)
        {

        }
    }
}
