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
    public partial class f_ChamCong : Form
    {
        List<ChucVu> lcv = new List<ChucVu>();
        ChucVu cvI = new ChucVu("CV000", "Tất cả", 0, 0);
        List<ChamCong> listCC = new List<ChamCong>();
        public f_ChamCong()
        {
            InitializeComponent();
            load();
            dtpNgayVaoLam.MaxDate = DateTime.Now;
        }

        private void dtpNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {
            listCC = ChamCongBUS.Instance.loadDGVChamCong(dataGridView1, dtpNgayVaoLam.Value, cvI);
            lbSL.Text = " " + listCC.Count.ToString();
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cvI = ChucVuDAO.Instance.getChucVuByName(cbbChucVu.Text);
        }

        private void txbCCMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        void load()
        {
            string q = "SELECT DISTINCT * FROM ChucVu";
            DataTable t = DataProvider.Instance.ExecuteQuery(q);
            lcv.Clear();
            cbbChucVu.Items.Clear();
            foreach (DataRow row in t.Rows)
            {
                ChucVu cv = new ChucVu(row);
                lcv.Add(cv);
            }
            foreach (ChucVu cv in lcv)
            {
                cbbChucVu.Items.Add(cv.TenCV);
            }
            cbbChucVu.Items.Add("tất cả");

            listCC = ChamCongBUS.Instance.loadDGVChamCong(dataGridView1, dtpNgayVaoLam.Value, cvI);
            lbSL.Text = " " + listCC.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sdg = (DataGridView)sender;
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            ChamCong cc = new ChamCong();
            foreach(ChamCong item in listCC)
            {
                if(item.NvCC.MaNV.Equals(row.Cells["clMaNV"].Value.ToString()))
                {
                    cc = item;
                    float a = 8;
                    int b = 100;
                    if(float.TryParse(row.Cells["clThoiGian"].Value.ToString(), result: out a) &&
                        int.TryParse(row.Cells["clSLg"].Value.ToString(), result: out b))
                    {
                        cc.TgCC = a;
                        cc.SlCC = b;
                    }
                    else
                    {
                        cc = new ChamCong();
                    }
                }
            }

            if (sdg.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // to do button click
                if(sdg.Columns[clBTLuu.Name] is DataGridViewButtonColumn && e.RowIndex >= 0 && sdg.Columns[e.ColumnIndex] == sdg.Columns[clBTLuu.Name])
                {
                    // thêm chấm công
                    if(cc.MaCC != "")
                    {
                        if (ChamCongDAO.Instance.ThemChamCong(cc))
                        {
                            string m = "";
                            string tg = "";
                            string sl = "";
                            m = cc.NvCC.TenNV;
                            tg = cc.TgCC.ToString();
                            sl = cc.SlCC.ToString();
                            listCC.Remove(cc);
                            dataGridView1.Rows.Remove(row);
                            lbTranhThai.ForeColor = Color.Aqua;
                            lbTranhThai.Text = "Chấm Công: " + m + "---> " + sl + "sp/" + tg + "giờ";
                        }
                        else
                        {
                            lbTranhThai.ForeColor = Color.Red;
                            lbTranhThai.Text = "Không thể chấm công lúc này! Vui lòng thử lại sau.";
                        }
                    }
                    else
                    {
                        lbTranhThai.ForeColor = Color.Red;
                        lbTranhThai.Text = "Không thể chấm công lúc này! Vui lòng thử lại sau.";
                    }
                }

                if (sdg.Columns[clXoa.Name] is DataGridViewButtonColumn && e.RowIndex >= 0 && sdg.Columns[e.ColumnIndex] == sdg.Columns[clXoa.Name])
                {
                    // xóa chấm công
                    listCC.Remove(cc);
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
