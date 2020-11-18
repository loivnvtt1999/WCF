using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.DungWCFQuanLyXeMay;
namespace Presentation
{
    public partial class frmQuanLyHoaDon : Form
    {
        QuanLyXeMayClient qlxm;
        List<eHoaDon> lHD;
        List<eChiTiet> lCT;
        DataTable dts;
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            qlxm = new QuanLyXeMayClient();
            lHD = new List<eHoaDon>();
            lCT = new List<eChiTiet>();
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày lập");
            dt.Columns.Add("Hình thức thanh toán");
            return dt;
        }
        public System.Data.DataTable CreatDataChiTiet()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã xe");
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Màu sắc");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thuế");
            return dt;
        }
        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            lHD = qlxm.layToanBoHoaDon().ToList();
            dts = CreatData();
            foreach (eHoaDon hd in lHD)
            {
                dts.Rows.Add(hd.MaHoaDon, qlxm.timNhanVienTheoMa(hd.MaNhanVien).TenNhanVien, qlxm.TimKhachHangTheoMa(hd.MaKhachHang).TenKhachHang, String.Format("{0:MM/dd/yyyy}", hd.NgayLap), hd.TrangThai);
                dataGridView1.DataSource = dts;
                dataGridView1.RefreshEdit();
            }
            formatdatagridview(dataGridView1);
            //formatdatagridview2(dataGridView2);
        }
        void formatdatagridview(DataGridView dgr)
        {
            dgr.Columns["Mã hóa đơn"].Width = 150;
            dgr.Columns["Tên nhân viên"].Width = 200;
            dgr.Columns["Tên khách hàng"].Width = 200;
            dgr.Columns["Ngày lập"].Width = 200;
            dgr.Columns["Hình thức thanh toán"].Width = 200;
        }
        void formatdatagridview2(DataGridView dgr)
        {
            dgr.Columns["Mã xe"].Width = 100;
            dgr.Columns["Tên xe"].Width = 200;
            dgr.Columns["Màu sắc"].Width = 200;
            dgr.Columns["Giá bán"].Width = 200;
            dgr.Columns["Số lượng"].Width = 100;
            dgr.Columns["Thuế"].Width = 100;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            String tam = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //tam = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (this.dataGridView1.SelectedRows[0].Cells[0].Value!=null)
                {
                    tam = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                }
                else
                {
                    return;
                }
                lCT = qlxm.layChiTietTheoMa(tam).ToList();
                dts = CreatDataChiTiet();
                foreach(eChiTiet ctt in lCT)
                {
                    eXeMay xetam = qlxm.TimXeTheoMa(ctt.MaXe);
                    dts.Rows.Add(xetam.MaXe, xetam.TenXe, xetam.MauSac, String.Format("{0:#,#.}", ctt.GiaBan), ctt.SoLuong, ctt.Thue);
                    dataGridView2.DataSource = dts;
                    dataGridView2.RefreshEdit();
                }
            }
        }

    }
}
