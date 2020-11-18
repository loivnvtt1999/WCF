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
    public partial class frmXeMay : Form
    {
        QuanLyXeMayClient qlxm;
        List<eXeMay> lXM;
        List<eLoaiXe> lLX;
        DataTable dts;
        int flag = 0;
        public frmXeMay()
        {
            InitializeComponent();
            dts = new DataTable();
           
            lXM = new List<eXeMay>();
            lLX = new List<eLoaiXe>();
            SetDataCombobox();
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã xe");
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Màu sắc");
            dt.Columns.Add("Phân khối");
            dt.Columns.Add("Loại phanh");
            dt.Columns.Add("Loại bánh");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Giá thành");
            dt.Columns.Add("Loại xe");
            dt.Columns.Add("Trạng thái xe");
            return dt;
        }
        void dis_enable(bool e)
        {
            tbxMaXeMay.Enabled = e;
            tbxTenXeMay.Enabled = e;
            tbxMauSac.Enabled = e;
            tbxPhanKhoi.Enabled = e;
            tbxLoaiBanh.Enabled = e;
            tbxLoaiPhanh.Enabled = e;
            nUDsoLuong.Enabled = e;
            cbLoaiXe.Enabled = e;
            tbxGiaThanh.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnNhapHang.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void LoadDataDataGridView(DataGridView dgr, List<eXeMay> l)
        {
            dts = CreatData();
            foreach (eXeMay xm in l)
            {
                //String tam = xm.GiaThanh.ToString();
                dts.Rows.Add(xm.MaXe, xm.TenXe, xm.MauSac, xm.PhanKhoi, xm.LoaiPhanh, xm.LoaiBanh, xm.SoLuong, String.Format("{0:#,#.}", xm.GiaThanh), qlxm.LayLoaiTheoMa(xm.MaLoai).TenLoai,xm.TrangThaiXe);
                dgr.DataSource = dts;
                dgr.RefreshEdit();
            }
            binding();
            formatDataGridView(dgr);
        }
        private void frmXeMay_Load(object sender, EventArgs e)
        {
            qlxm = new QuanLyXeMayClient();
            lXM = qlxm.LayToanBoXeMay().ToList();
            LoadDataDataGridView(dataGridView1, lXM);
            SetAutoComplete();
            XuLyHoTroTbxTenKhachHang(lXM);
            dis_enable(false);
        }
        void SetDataCombobox()
        {
            cBTrangThai.Items.Add("Đang theo dõi");
            cBTrangThai.Items.Add("Ngừng theo dõi");
        }
        void TaoXeMay(eXeMay xemaymoi)
        {
            xemaymoi.TenXe = tbxTenXeMay.Text;
            xemaymoi.MaXe = tbxMaXeMay.Text;
            xemaymoi.MauSac = tbxMauSac.Text;
            xemaymoi.PhanKhoi = tbxPhanKhoi.Text;
            xemaymoi.LoaiBanh = tbxLoaiBanh.Text;
            xemaymoi.LoaiPhanh = tbxLoaiPhanh.Text;
            xemaymoi.SoLuong = int.Parse(nUDsoLuong.Value.ToString());
            xemaymoi.GiaThanh = float.Parse(tbxGiaThanh.Text);
            xemaymoi.MaLoai = qlxm.LayLoaiXeTheoTenLoai(cbLoaiXe.Text).MaLoai;
            xemaymoi.TrangThaiXe = cBTrangThai.Text;
        }
        void binding()
        {
            tbxMaXeMay.DataBindings.Clear();
            tbxMaXeMay.DataBindings.Add("Text", dataGridView1.DataSource, "Mã xe");
            tbxTenXeMay.DataBindings.Clear();
            tbxTenXeMay.DataBindings.Add("Text", dataGridView1.DataSource, "Tên xe");
            tbxMauSac.DataBindings.Clear();
            tbxMauSac.DataBindings.Add("Text", dataGridView1.DataSource, "Màu sắc");
            tbxPhanKhoi.DataBindings.Clear();
            tbxPhanKhoi.DataBindings.Add("Text", dataGridView1.DataSource, "Phân khối");
            tbxLoaiPhanh.DataBindings.Clear();
            tbxLoaiPhanh.DataBindings.Add("Text", dataGridView1.DataSource, "Loại phanh");
            tbxLoaiBanh.DataBindings.Clear();
            tbxLoaiBanh.DataBindings.Add("Text", dataGridView1.DataSource, "Loại bánh");
            nUDsoLuong.DataBindings.Clear();
            nUDsoLuong.DataBindings.Add("Text", dataGridView1.DataSource, "Số lượng");
            tbxGiaThanh.DataBindings.Clear();
            tbxGiaThanh.DataBindings.Add("Text", dataGridView1.DataSource, "Giá thành");
            cbLoaiXe.DataBindings.Clear();
            cbLoaiXe.DataBindings.Add("Text", dataGridView1.DataSource, "Loại xe");
            cBTrangThai.DataBindings.Clear();
            cBTrangThai.DataBindings.Add("Text", dataGridView1.DataSource, "Trạng thái xe");
        }
        void formatDataGridView(DataGridView dgr)
        {
            dgr.Columns["Tên xe"].Width = 250;
            dgr.Columns["Giá thành"].DefaultCellStyle.Format = "###,###";
            dgr.Columns["Trạng thái xe"].Width = 200;
        }
        void resetData()
        {
            tbxMaXeMay.Text = qlxm.PhatSinhMaXe();
            tbxMaXeMay.Enabled = false;
            tbxTenXeMay.Text = "";
            tbxMauSac.Text = "";
            tbxPhanKhoi.Text = "";
            tbxLoaiBanh.Text = "";
            tbxLoaiPhanh.Text = "";
            nUDsoLuong.Text = "";
            cbLoaiXe.Text = "";
            tbxGiaThanh.Text = "";
            cBTrangThai.Text = "";
        }
        void SetDataComBoBox()
        {
            lLX = qlxm.LayToanBoLoaiXe().ToList();
           foreach(eLoaiXe xe in lLX)
            {
                cbLoaiXe.Items.Add(xe.TenLoai);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_enable(true);
            resetData();
            SetDataComBoBox();
        }

        private void nUDsoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cbLoaiXe_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (String.IsNullOrWhiteSpace(tbxTenXeMay.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrWhiteSpace(tbxPhanKhoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập phân khối xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrWhiteSpace(tbxLoaiBanh.Text))
                {
                    MessageBox.Show("Vui lòng nhập loại bánh xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrWhiteSpace(tbxLoaiPhanh.Text))
                {
                    MessageBox.Show("Vui lòng nhập loại phanh xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrWhiteSpace(cbLoaiXe.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrWhiteSpace(tbxMauSac.Text))
                {
                    MessageBox.Show("Vui lòng nhập màu sắc xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrWhiteSpace(cBTrangThai.Text))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                float check;
                if(float.TryParse(tbxGiaThanh.Text, out check) == false)
                {
                    MessageBox.Show("Nhập sai đơn giá vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (nUDsoLuong.Value == 0 || String.IsNullOrWhiteSpace(nUDsoLuong.Value.ToString()))
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Them moi
                eXeMay xemoi = new eXeMay();
                TaoXeMay(xemoi);
                int kq = qlxm.ThemXe(xemoi);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lXM = qlxm.LayToanBoXeMay().ToList();
                    LoadDataDataGridView(dataGridView1, lXM);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(flag==1)
            {
                // Sua xe
                eXeMay xesua = new eXeMay();
                TaoXeMay(xesua);
                int kq = qlxm.SuaXeMay(xesua);
                if (kq == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lXM = qlxm.LayToanBoXeMay().ToList();
                    LoadDataDataGridView(dataGridView1, lXM);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                eXeMay xeNhapHang = new eXeMay();
                TaoXeMay(xeNhapHang);
                int kq = qlxm.CapNhatSoLuongXe(xeNhapHang, int.Parse(nUDsoLuong.Value.ToString()));
                if (kq == 1)
                {
                    MessageBox.Show("Nhập hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lXM = qlxm.LayToanBoXeMay().ToList();
                    LoadDataDataGridView(dataGridView1, lXM);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Nhập hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dis_enable(false);
            lXM = qlxm.LayToanBoXeMay().ToList();
            LoadDataDataGridView(dataGridView1, lXM);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enable(true);
            SetDataComBoBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn chắc chắn thay đổi trạng thái xe ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                eXeMay xexoa = new eXeMay();
                TaoXeMay(xexoa);
                int kq = qlxm.XoaXe(xexoa);
                if (kq == 1)
                {
                    MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lXM = qlxm.LayToanBoXeMay().ToList();
                    LoadDataDataGridView(dataGridView1, lXM);
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            nUDsoLuong.Enabled = true;
        }

        private void cBTrangThai_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void SetAutoComplete()
        {

            tbxTimKiemXeMay.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxTimKiemXeMay.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void XuLyHoTroTbxTenKhachHang(List<eXeMay> l)
        {
            tbxTimKiemXeMay.AutoCompleteCustomSource.Clear();
            foreach (eXeMay xe in l)
            {
                tbxTimKiemXeMay.AutoCompleteCustomSource.Add(xe.TenXe);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            eXeMay xetim = new eXeMay();
            if (!String.IsNullOrWhiteSpace(tbxTimKiemXeMay.Text))
            {
                xetim = qlxm.TimXeTheoTen(tbxTimKiemXeMay.Text);
                if (xetim != null)
                {
                    dts = CreatData();
                    dts.Clear();
                    dts.Rows.Add(xetim.MaXe, xetim.TenXe, xetim.MauSac, xetim.PhanKhoi, xetim.LoaiPhanh, xetim.LoaiBanh, xetim.SoLuong, String.Format("{0:#,#.}", xetim.GiaThanh), qlxm.LayLoaiTheoMa(xetim.MaLoai).TenLoai, xetim.TrangThaiXe);
                    dataGridView1.DataSource = dts;
                    dataGridView1.RefreshEdit();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lXM = qlxm.LayToanBoXeMay().ToList();
                LoadDataDataGridView(dataGridView1, lXM);
            }
        }
    }
}
