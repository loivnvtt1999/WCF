using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.DungWCFQuanLyXeMay;
namespace Presentation
{
    public partial class frmThongKeBanChay : Form
    {
        List<eThongKeBanChay> listXe = new List<eThongKeBanChay>();
        QuanLyXeMayClient ql = new QuanLyXeMayClient();
        DataTable dts = new DataTable();
        int dem = 0;
        public frmThongKeBanChay()
        {
            InitializeComponent();
        }

        private void frmThongKeBanChay_Load(object sender, EventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            listXe = ql.thongKeBanChay(dtpTuNgay.Value, dtpDenNgay.Value).ToList();
            LoadDataDataGridView(dgvThongKeBanChay, listXe);
            for(int i=0; i < listXe.Count; i++)
            {
                dem += listXe[i].SoLuong;
            }
            tbxXe.Text = dem.ToString();
        }
        void LoadDataDataGridView(DataGridView dgr, List<eThongKeBanChay> l)
        {

            dts = CreatData();
            dts.Clear();
            foreach (eThongKeBanChay tk in listXe)
            {
                dts.Rows.Add(tk.MaXe, tk.TenXe, tk.TenLoai, tk.SoLuong, tk.MauSac, tk.PhanKhoi, tk.LoaiPhanh, tk.LoaiBanh);
                dgr.DataSource = dts;
                dgr.RefreshEdit();
            }
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã xe");
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Tên loại");
            dt.Columns.Add("Số lượng bán");
            dt.Columns.Add("Màu sắc");
            dt.Columns.Add("Phân khối");
            dt.Columns.Add("Loại phanh");
            dt.Columns.Add("Loại bánh");
            return dt;
        }
    }
}
