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

    public partial class frmThongKeDoanhThu : Form
    {
        List<eThongKeDoanhThu> listDT = new List<eThongKeDoanhThu>();
        QuanLyXeMayClient ql = new QuanLyXeMayClient();
        DataTable dts = new DataTable();
        double doanhthu;
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            listDT = ql.thongKeDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value).ToList();
            LoadDataDataGridView(dgvDoanhThu, listDT);
            doanhthu = 0;
            for(int i=0; i < listDT.Count(); i++)
            {
                doanhthu += listDT[i].GiaBan;
            }
            tbxDoanhThu.Text = String.Format("{0:#,#.}", doanhthu);
        }
        void LoadDataDataGridView(DataGridView dgr, List<eThongKeDoanhThu> l)
        {
            dts.Clear();
            dts = CreatData();
            foreach (eThongKeDoanhThu tk in listDT)
            {
                dts.Rows.Add(tk.TenXe, tk.TenLoai, tk.NgayLap.ToString("dd/MM/yyyy"), tk.SoLuong, tk.GiaBan.ToString("#,#"),tk.Thue.ToString("#%"));
               
            }
            dgr.DataSource = dts;
            dgr.RefreshEdit();
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Loại xe");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("số lượng");
            dt.Columns.Add("Giá bán (VNĐ)");
            dt.Columns.Add("Thuế");
            return dt;
        }
    }
}
