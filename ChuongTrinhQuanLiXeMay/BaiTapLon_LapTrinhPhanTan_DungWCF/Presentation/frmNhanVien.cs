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
    public partial class frmNhanVien : Form
    {
        KiemTraDuLieuNhanVien kt;
        QuanLyXeMayClient qlxm;
        List<eNhanVien> lNV;
        DataTable dts;
        int flag = 0;
        public frmNhanVien()
        {
            InitializeComponent();
            dts = new DataTable();
            qlxm = new QuanLyXeMayClient();
            lNV = new List<eNhanVien>();
            cBTrangThai.Enabled = true;
            kt = new KiemTraDuLieuNhanVien();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            lNV = qlxm.LayToanBoNhanVien().ToList();
            LoadDataDataGridView(dataGridView1, lNV);
            dis_enable(false);
            SetAutoComplete();
            XuLyHoTroTbxTenKhachHang(lNV);
            cBTrangThai.Items.Add("Đang theo dõi");
            cBTrangThai.Items.Add("Ngừng theo dõi");
        }
        void LoadDataDataGridView(DataGridView dgr, List<eNhanVien> l)
        {
            dts = CreatData();
            dts.Clear();
            foreach (eNhanVien nv in l)
            {
                dts.Rows.Add(nv.MaNhanVien, nv.TenNhanVien, nv.NgaySinh, nv.Cmnd, nv.SoDienThoai, nv.ChucVu, nv.Email,nv.TrangthaiNV);
                dgr.DataSource = dts;
                dgr.RefreshEdit();
            }
            FormatDataGridView(dgr);
            binding();
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Chứng minh thư");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Chức vụ");
            dt.Columns.Add("Email");
            dt.Columns.Add("Trạng thái");
            return dt;
        }
        void binding()
        {
            tbxMaNhanVien.DataBindings.Clear();
            tbxMaNhanVien.DataBindings.Add("Text", dataGridView1.DataSource, "Mã nhân viên");
            tbxTenNhanVien.DataBindings.Clear();
            tbxTenNhanVien.DataBindings.Add("Text", dataGridView1.DataSource, "Tên nhân viên");
            tbxCMND.DataBindings.Clear();
            tbxCMND.DataBindings.Add("Text", dataGridView1.DataSource, "Chứng minh thư");
            tbxEmail.DataBindings.Clear();
            tbxEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
            tbxSoDienThoai.DataBindings.Clear();
            tbxSoDienThoai.DataBindings.Add("Text", dataGridView1.DataSource, "Số điện thoại");
            cbChucVu.DataBindings.Clear();
            cbChucVu.DataBindings.Add("Text", dataGridView1.DataSource, "Chức vụ");
            dPTNgaySinh.DataBindings.Clear();
            dPTNgaySinh.DataBindings.Add("Text", dataGridView1.DataSource, "Ngày sinh");
            cBTrangThai.DataBindings.Clear();
            cBTrangThai.DataBindings.Add("Text", dataGridView1.DataSource, "Trạng thái");
        }
        void resetData()
        {

            tbxMaNhanVien.Text = qlxm.PhatSinhMaNhanVien();
            tbxMaNhanVien.Enabled = false;
            tbxTenNhanVien.Text = "";
            tbxSoDienThoai.Text = "";
            tbxEmail.Text = "";
            tbxCMND.Text = "";
            cbChucVu.Text = "";
            dPTNgaySinh.Text = DateTime.Today.ToString();
        }
        void FormatDataGridView(DataGridView dgr)
        {
            dgr.Columns["Ngày sinh"].Width = 250;
            dgr.Columns["Trạng thái"].Width= 150;
            dgr.Columns["Email"].Width = 250;
            dgr.Columns["Mã nhân viên"].Width = 100;
            dgr.Columns["Tên nhân viên"].Width = 150;
        }
        void dis_enable(bool e)
        {
            tbxMaNhanVien.Enabled = e;
            tbxTenNhanVien.Enabled = e;
            tbxSoDienThoai.Enabled = e;
            tbxEmail.Enabled = e;
            tbxCMND.Enabled = e;
            cbChucVu.Enabled = e;
            dPTNgaySinh.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void TaoNhanVien(eNhanVien nv)
        {
            nv.MaNhanVien = tbxMaNhanVien.Text;
            nv.TenNhanVien = tbxTenNhanVien.Text;
            nv.Cmnd = tbxCMND.Text;
            nv.SoDienThoai = tbxSoDienThoai.Text;
            nv.Email = tbxEmail.Text;
            nv.ChucVu = cbChucVu.Text;
            nv.NgaySinh = DateTime.Parse(dPTNgaySinh.Text);
            nv.TrangthaiNV = cBTrangThai.Text;
        }
        void SetDataCombobox()
        {
            cbChucVu.Items.Add("Quản lý");
            cbChucVu.Items.Add("Bán hàng");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_enable(true);
            SetDataCombobox();
            resetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enable(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (!kt.KiemTraCMND(tbxCMND.Text))
                {
                    MessageBox.Show("Sai chứng minh nhân dân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!kt.KiemTraEmail(tbxEmail.Text))
                {
                    MessageBox.Show("Sai email, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!kt.KiemTraSDT(tbxSoDienThoai.Text))
                {
                    MessageBox.Show("Sai số điện thoại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(cbChucVu.Text))
                {
                    MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(cBTrangThai.Text))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (kt.TinhTuoi(dPTNgaySinh.Value, DateTime.Today)<18)
                {
                    MessageBox.Show("Nhân viên chưa đủ tuổi, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //them moi
                eNhanVien nvThem = new eNhanVien();
                TaoNhanVien(nvThem);
                int kq = qlxm.ThemNhanVien(nvThem);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lNV = qlxm.LayToanBoNhanVien().ToList();
                    LoadDataDataGridView(dataGridView1, lNV);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //sua thong tin
                eNhanVien nvSua = new eNhanVien();
                TaoNhanVien(nvSua);
                int kq = qlxm.SuaNhanVien(nvSua);
                if (kq == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lNV = qlxm.LayToanBoNhanVien().ToList();
                    LoadDataDataGridView(dataGridView1, lNV);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn chắc chắn thay đổi hoạt động của nhân viên ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                cBTrangThai.Enabled = true;
                eNhanVien nvXoa = new eNhanVien();
                if (String.IsNullOrWhiteSpace(cBTrangThai.Text))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaoNhanVien(nvXoa);
                int kq = qlxm.XoaNhanVien(nvXoa);
                if (kq == 1)
                {
                    MessageBox.Show("Đã thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lNV = qlxm.LayToanBoNhanVien().ToList();
                    LoadDataDataGridView(dataGridView1, lNV);
                    cBTrangThai.Enabled = false;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dis_enable(false);
            lNV = qlxm.LayToanBoNhanVien().ToList();
            LoadDataDataGridView(dataGridView1, lNV);
        }

        private void cbChucVu_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cBTrangThai_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void SetAutoComplete()
        {

            tbxTimKiemNhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxTimKiemNhanVien.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void XuLyHoTroTbxTenKhachHang(List<eNhanVien> l)
        {
            tbxTimKiemNhanVien.AutoCompleteCustomSource.Clear();
            foreach (eNhanVien nv in l)
            {
               tbxTimKiemNhanVien.AutoCompleteCustomSource.Add(nv.TenNhanVien);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            eNhanVien nvtim = new eNhanVien();
            if (!String.IsNullOrWhiteSpace(tbxTimKiemNhanVien.Text))
            {
                nvtim = qlxm.TimNhanVienTheoTen(tbxTimKiemNhanVien.Text);
                if (nvtim != null)
                {
                    dts = CreatData();
                    dts.Clear();
                    dts.Rows.Add(nvtim.MaNhanVien, nvtim.TenNhanVien, nvtim.NgaySinh, nvtim.Cmnd, nvtim.SoDienThoai, nvtim.ChucVu, nvtim.Email, nvtim.TrangthaiNV);
                    dataGridView1.DataSource = dts;
                    dataGridView1.RefreshEdit();
                }

                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lNV = qlxm.LayToanBoNhanVien().ToList();
                LoadDataDataGridView(dataGridView1, lNV);
            }
        }
    }
}
