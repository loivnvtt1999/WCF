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

    public partial class frmThongKeKhachHang : Form
    {
        List<eThongKeKhachMuaNhieu> listKH = new List<eThongKeKhachMuaNhieu>();
        QuanLyXeMayClient ql = new QuanLyXeMayClient();
        DataTable dts = new DataTable();
        int dem = 0;
        public frmThongKeKhachHang()
        {
            InitializeComponent();
        }
        void LoadDataDataGridView(DataGridView dgr, List<eThongKeKhachMuaNhieu> l)
        {

            dts = CreatData();
            dts.Clear();
            foreach (eThongKeKhachMuaNhieu tk in listKH)
            {
                dts.Rows.Add(tk.MaKH, tk.TenKH, tk.NgayMua.ToString("dd/MM/yyyy"), tk.Cmnd, tk.NgaySinh.ToString("dd/MM/yyyy"), tk.SDT, tk.Email, tk.TenXe, tk.SoLuong);
                dgr.DataSource = dts;
                dgr.RefreshEdit();
            }
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày mua");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Email");
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Số lượng");
            return dt;
        }
        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            listKH = ql.thongKeKhachMuaNhieu(dtpTuNgay.Value, dtpDenNgay.Value).ToList();
            LoadDataDataGridView(dgvThongKeKhachHang, listKH);
            dem = listKH.Count();
            tbxKhachHang.Text = dem.ToString();
        }
    }
}
