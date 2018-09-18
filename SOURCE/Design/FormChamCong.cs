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
    public partial class FormChamCong : Form
    {
        List<ChucVu> lcv = new List<ChucVu>();
        ChucVu cvI = new ChucVu("CV000", "Tất cả", 0, 0);
        List<ChamCong> listCC = new List<ChamCong>();
        public FormChamCong()
        {
            InitializeComponent();
            load();
            dtmNgayVaoLam.MaxDate = DateTime.Now;
        }

        private void dtmNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {
            listCC = ChamCongBUS.Instance.loadDGVChamCong(dgvChamCong, dtmNgayVaoLam.Value, cvI);
            lblSL.Text = " " + listCC.Count.ToString();
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cvI = ChucVuDAO.Instance.getChucVuByName(cboChucVu.Text);
        }

        private void txtCCMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        void load()
        {
            string q = "SELECT DISTINCT * FROM ChucVu";
            DataTable t = DataProvider.Instance.ExecuteQuery(q);
            lcv.Clear();
            cboChucVu.Items.Clear();
            foreach (DataRow row in t.Rows)
            {
                ChucVu cv = new ChucVu(row);
                lcv.Add(cv);
            }
            foreach (ChucVu cv in lcv)
            {
                cboChucVu.Items.Add(cv.TenCV);
            }
            cboChucVu.Items.Add("tất cả");

            listCC = ChamCongBUS.Instance.loadDGVChamCong(dgvChamCong, dtmNgayVaoLam.Value, cvI);
            lblSL.Text = " " + listCC.Count.ToString();
        }

        private void dgvChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sdg = (DataGridView)sender;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvChamCong.Rows[e.RowIndex];
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
                if(sdg.Columns[clblTLuu.Name] is DataGridViewButtonColumn && e.RowIndex >= 0 && sdg.Columns[e.ColumnIndex] == sdg.Columns[clblTLuu.Name])
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
                            dgvChamCong.Rows.Remove(row);
                            lblTranhThai.ForeColor = Color.Aqua;
                            lblTranhThai.Text = "Chấm Công: " + m + "---> " + sl + "sp/" + tg + "giờ";
                        }
                        else
                        {
                            lblTranhThai.ForeColor = Color.Red;
                            lblTranhThai.Text = "Không thể chấm công lúc này! Vui lòng thử lại sau.";
                        }
                    }
                    else
                    {
                        lblTranhThai.ForeColor = Color.Red;
                        lblTranhThai.Text = "Không thể chấm công lúc này! Vui lòng thử lại sau.";
                    }
                }

                if (sdg.Columns[clXoa.Name] is DataGridViewButtonColumn && e.RowIndex >= 0 && sdg.Columns[e.ColumnIndex] == sdg.Columns[clXoa.Name])
                {
                    // xóa chấm công
                    listCC.Remove(cc);
                    dgvChamCong.Rows.Remove(row);
                }
            }
        }
    }
}
