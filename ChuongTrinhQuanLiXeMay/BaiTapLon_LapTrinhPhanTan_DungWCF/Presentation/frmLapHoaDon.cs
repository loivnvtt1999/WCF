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
    public partial class frmLapHoaDon : Form
    {
        float thanhtien = 0;
        eNhanVien nvDaDangNhap;
        List<eKhachHang> l1;
        List<eChiTiet> lCT;
        List<eXeMay> l2;
        QuanLyXeMayClient qlxm;
        DataTable dts;
        eHoaDon hdmoi;
        public frmLapHoaDon()
        {
            InitializeComponent();
        }
        public frmLapHoaDon(eNhanVien nv)
        {
            InitializeComponent();
            qlxm = new QuanLyXeMayClient();
            nvDaDangNhap = nv;
        }
        private void SetAutoComplete()
        {
            tbxMaKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxMaKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxTenKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxTenKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxSoDienThoai.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxSoDienThoai.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxMaXe.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxMaXe.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxTenXe.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxTenXe.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void XuLyHoTroCboSoDienThoaiKhachHang(List<eKhachHang> l)
        {
            tbxSoDienThoai.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxSoDienThoai.AutoCompleteCustomSource.Add(kh.SoDienThoai);
            }
        }
        void XuLyHoTroTbxTenKhachHang(List<eKhachHang> l)
        {
            tbxTenKhachHang.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxTenKhachHang.AutoCompleteCustomSource.Add(kh.TenKhachHang);
            }
        }
        void XuLyHoTroCboMaKhachHang(List<eKhachHang> l)
        {
            tbxMaKhachHang.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxMaKhachHang.AutoCompleteCustomSource.Add(kh.MaKhachHang);
            }
        }

        void XuLyHoTroCboMaXe(List<eXeMay> l)
        {
            tbxMaXe.AutoCompleteCustomSource.Clear();
            foreach (eXeMay xe in l)
            {
                tbxMaXe.AutoCompleteCustomSource.Add(xe.MaXe);
            }
        }

        void XuLyHoTroTbxTenXe(List<eXeMay> l)
        {
            tbxTenXe.AutoCompleteCustomSource.Clear();
            foreach (eXeMay xe in l)
            {
                tbxTenXe.AutoCompleteCustomSource.Add(xe.TenXe);
            }
        }
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            tbxMaHoaDon.Text = qlxm.PhatSinhMaHoaDon();
            tbxMaHoaDon.Enabled = false;
            tbxMaNhanVien.Text = nvDaDangNhap.MaNhanVien;
            tbxTenNhanVien.Text = nvDaDangNhap.TenNhanVien;
            tbxChucVu.Text = nvDaDangNhap.ChucVu;
            tbxMaNhanVien.Enabled = false;
            tbxTenNhanVien.Enabled = false;
            tbxChucVu.Enabled = false;
            SetAutoComplete();
            l1 = qlxm.LayToanBoKhachHang().ToList();
            XuLyHoTroCboMaKhachHang(l1);
            XuLyHoTroTbxTenKhachHang(l1);
            XuLyHoTroCboSoDienThoaiKhachHang(l1);
            cBoTrangThai.Items.Add("Tiền mặt");
            cBoTrangThai.Items.Add("Trả góp");
            l2 = qlxm.LayToanBoXeMay().ToList();
            XuLyHoTroCboMaXe(l2);
            XuLyHoTroTbxTenXe(l2);
            dts = CreatData();
            dataGridView1.DataSource = dts;
            formatDatagridview(dataGridView1);
            lCT = new List<eChiTiet>();
            tbxThanhTien.Text = thanhtien.ToString();
            tbxThanhTien.Enabled = false;
            tbxTenKhachHang.Enabled = false;
            tbxMaKhachHang.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void tbxTenKhachHang_Leave(object sender, EventArgs e)
        {
            eKhachHang khachhang = new eKhachHang();
            khachhang = qlxm.TimKhachHangTheoTen(tbxTenKhachHang.Text);
            if (khachhang == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                return;
            }
            else
            {
                tbxTenKhachHang.Text = khachhang.TenKhachHang;
                tbxMaKhachHang.Text = khachhang.MaKhachHang;
                tbxSoDienThoai.Text = khachhang.SoDienThoai;
            }
        }

        private void tbxMaKhachHang_Leave(object sender, EventArgs e)
        {
            eKhachHang khachhang = new eKhachHang();
            khachhang = qlxm.TimKhachHangTheoMa(tbxMaKhachHang.Text);
            if (khachhang == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                return;
            }
            tbxTenKhachHang.Text = khachhang.TenKhachHang;
            tbxMaKhachHang.Text = khachhang.MaKhachHang;
            tbxSoDienThoai.Text = khachhang.SoDienThoai;
        }

        private void tbxSoDienThoai_Leave(object sender, EventArgs e)
        {
            eKhachHang khachhang = new eKhachHang();
            khachhang = qlxm.TimKhachHangTheoSDT(tbxSoDienThoai.Text);
            if (khachhang == null)
            {
                MessageBox.Show("Số điện thoại khách hàng không có trong danh sách","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            tbxTenKhachHang.Text = khachhang.TenKhachHang;
            tbxMaKhachHang.Text = khachhang.MaKhachHang;
            tbxSoDienThoai.Text = khachhang.SoDienThoai;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang fthemkhach = new frmThemKhachHang();
            fthemkhach.ShowDialog();
            if (fthemkhach.DialogResult == DialogResult.OK)
            {
                eKhachHang kh = fthemkhach.Kh;
                tbxTenKhachHang.Text = kh.TenKhachHang;
                tbxMaKhachHang.Text = kh.MaKhachHang;
                tbxSoDienThoai.Text = kh.SoDienThoai;
            }
        }

        private void cBoTrangThai_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tbxTenXe_Leave(object sender, EventArgs e)
        {
            eXeMay xe = new eXeMay();
            xe = qlxm.TimXeTheoTen(tbxTenXe.Text);
            if (xe == null)
            {
                MessageBox.Show("Tên xe không có trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbxMaXe.Text = xe.MaXe;
            tbxGiaBan.Text = (xe.GiaThanh * 0.05 + xe.GiaThanh).ToString();
        }
        public System.Data.DataTable CreatData()
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
        public void TaoChiTietHoaDon(eChiTiet ct)
        {
            ct.MaHoaDon = tbxMaHoaDon.Text;
            ct.MaXe = tbxMaXe.Text;
            ct.GiaBan = float.Parse(tbxGiaBan.Text);
            ct.SoLuong = int.Parse(nUDSoLuongXe.Value.ToString());
            ct.Thue = float.Parse(tbxThue.Text);
        }
        void formatDatagridview(DataGridView dgr)
        {
            dgr.Columns["Mã xe"].Width = 150;
            dgr.Columns["Tên xe"].Width = 250;
            dgr.Columns["Màu sắc"].Width = 250;
            dgr.Columns["Giá bán"].Width = 250;
            dgr.Columns["Số lượng"].Width = 150;
            dgr.Columns["Thuế"].Width = 150;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            eChiTiet chiTiet = new eChiTiet();
            TaoChiTietHoaDon(chiTiet);
            eXeMay xetam = qlxm.TimXeTheoMa(chiTiet.MaXe);
            if (chiTiet.SoLuong > 0)
            {
                if(xetam.TrangThaiXe.Equals("Ngừng theo dõi"))
                {
                    MessageBox.Show("Xe bạn chọn đang ngưng cung cấp, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int i = 0; i < lCT.Count(); i++)
                {
                    if (lCT[i].MaXe.Equals(chiTiet.MaXe))
                    {
                        MessageBox.Show("Xe đã có trong danh sách, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                lCT.Add(chiTiet);
                dts.Rows.Add(xetam.MaXe, xetam.TenXe, xetam.MauSac, String.Format("{0:#,#.}", chiTiet.GiaBan), chiTiet.SoLuong, chiTiet.Thue);
                dataGridView1.DataSource = dts;
                formatDatagridview(dataGridView1);
                thanhtien = 0;
                for(int i = 0; i < lCT.Count(); i++)
                {
                    thanhtien += (lCT[i].GiaBan*lCT[i].SoLuong)+ (lCT[i].GiaBan * lCT[i].SoLuong)*lCT[i].Thue;
                }
                tbxThanhTien.Text = String.Format("{0:#,#.}", thanhtien);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn số lượng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nUDSoLuongXe.Focus();
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < lCT.Count(); i++)
                {
                    if (lCT[i].MaXe.Equals(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        lCT.Remove(lCT[i]);
                    }
                }
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                thanhtien = 0;
                for (int i = 0; i < lCT.Count(); i++)
                {
                    thanhtien += lCT[i].GiaBan * lCT[i].SoLuong;
                }
                tbxThanhTien.Text = String.Format("{0:#,#.}", thanhtien);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần hoàn tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void TaoHoaDon(eHoaDon hd)
        {
            hd.MaKhachHang = tbxMaKhachHang.Text;
            hd.MaNhanVien = tbxMaNhanVien.Text;
            hd.TrangThai = cBoTrangThai.Text;
            hd.MaHoaDon = tbxMaHoaDon.Text;
            hd.NgayLap = dateTimePicker1.Value;
        }
        public void TaoChiTietHoaDonChoLuuHD(DataGridView dgv, List<eChiTiet> lCT)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                eChiTiet ct = new eChiTiet();
                ct.MaHoaDon = tbxMaHoaDon.Text;
                ct.MaXe = dgv.Rows[i].Cells[0].Value.ToString();
                ct.GiaBan = float.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                ct.SoLuong = Convert.ToInt32(dgv.Rows[i].Cells[4].Value);
                ct.Thue = float.Parse(string.Format("{0:0.0}", dgv.Rows[i].Cells[5].Value.ToString()));
                lCT[i] = ct;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Text);
            if (lCT.Count > 0)
            {
                if (String.IsNullOrWhiteSpace(cBoTrangThai.Text))
                {
                    MessageBox.Show("Vui lòng chọn hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cBoTrangThai.Focus();
                    return;
                }
                hdmoi = new eHoaDon();
                hdmoi.MaHoaDon = tbxMaHoaDon.Text;
                hdmoi.MaNhanVien = tbxMaNhanVien.Text;
                hdmoi.MaKhachHang = tbxMaKhachHang.Text;
                hdmoi.NgayLap = dateTimePicker1.Value;
                hdmoi.TrangThai = cBoTrangThai.Text;
                int kq = qlxm.themHoaDon(hdmoi);
                int kiemtra = 0;
                eXeMay xetam= new eXeMay();
                for (int i = 0; i < lCT.Count; i++)
                {
                    int kq1 = qlxm.ThemChiThiet(lCT[i]);
                    xetam = qlxm.TimXeTheoMa(lCT[i].MaXe);
                    qlxm.GiamSoLuongXe(xetam, lCT[i].SoLuong);
                    kiemtra = 1;
                }
                if (kq == 1 && kiemtra == 1)
                {
                    MessageBox.Show("Hóa đơn lưu trữ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxSoDienThoai.Text = "";
                    tbxMaKhachHang.Text = "";
                    tbxTenKhachHang.Text = "";
                    tbxTenXe.Text = "";
                    tbxMaXe.Text = "";
                    tbxGiaBan.Text = "";
                    nUDSoLuongXe.Value = 0;
                    tbxMaHoaDon.Text = qlxm.PhatSinhMaHoaDon();
                    cBoTrangThai.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                    dts.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Hóa đơn lưu trữ thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn chưa có sản phẩm nào, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            float check;
            if (float.TryParse(textBox12.Text, out check) == false)
            {
                MessageBox.Show("Nhập sai đơn vị vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float tam = (float.Parse(textBox12.Text) - float.Parse(tbxThanhTien.Text));
            tbxTienThua.Text = (float.Parse(textBox12.Text) - float.Parse(tbxThanhTien.Text)).ToString();
            tbxTienThua.Text = String.Format("{0:#,#.}", tam);
        }
    }
}
