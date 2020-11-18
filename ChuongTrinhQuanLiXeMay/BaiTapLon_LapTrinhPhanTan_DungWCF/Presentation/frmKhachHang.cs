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
    public partial class frmKhachHang : Form
    {
        QuanLyXeMayClient qlxm;
        List<eKhachHang> lKH;
        DataTable dts;
        int flag = 0;
        KiemTraThongTinKhachHang kt;
        public frmKhachHang()
        {
            InitializeComponent();
            dts = new DataTable();
            qlxm = new QuanLyXeMayClient();
            lKH = new List<eKhachHang>();
            kt = new KiemTraThongTinKhachHang();
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Chứng minh thư");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Email");
            return dt;
        }
        void binding()
        {
            tbxMaKhachHang.DataBindings.Clear();
            tbxMaKhachHang.DataBindings.Add("Text", dataGridView1.DataSource, "Mã khách hàng");
            tbxTenKhachHang.DataBindings.Clear();
            tbxTenKhachHang.DataBindings.Add("Text", dataGridView1.DataSource, "Tên khách hàng");
            tbxCMND.DataBindings.Clear();
            tbxCMND.DataBindings.Add("Text", dataGridView1.DataSource, "Chứng minh thư");
            tbxEmail.DataBindings.Clear();
            tbxEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
            tbxSoDienThoai.DataBindings.Clear();
            tbxSoDienThoai.DataBindings.Add("Text", dataGridView1.DataSource, "Số điện thoại");
            dPTNgaySinh.DataBindings.Clear();
            dPTNgaySinh.DataBindings.Add("Text", dataGridView1.DataSource, "Ngày sinh");
        }
        void resetData()
        {

            tbxMaKhachHang.Text = qlxm.PhatSinhMaKH();
            tbxMaKhachHang.Enabled = false;
            tbxTenKhachHang.Text = "";
            tbxSoDienThoai.Text = "";
            tbxEmail.Text = "";
            tbxCMND.Text = "";
            dPTNgaySinh.Text = DateTime.Today.ToString();
        }
        void FormatDataGridView(DataGridView dgr)
        {
            dgr.Columns["Ngày sinh"].Width = 250;
            //dgr.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgr.Columns["Email"].Width = 350;
            dgr.Columns["Mã khách hàng"].Width = 100;
            dgr.Columns["Tên khách hàng"].Width = 250;
        }
        void LoadDataDataGridView(DataGridView dgr, List<eKhachHang> l)
        {

            dts = CreatData();
            dts.Clear();
            foreach (eKhachHang kh in l)
            {
                dts.Rows.Add(kh.MaKhachHang,kh.TenKhachHang,String.Format("{0:MM/dd/yyyy}",kh.NgaySinh),kh.Cmnd,kh.SoDienThoai,kh.Email);
                dgr.DataSource = dts;
                dgr.RefreshEdit();
            }
            FormatDataGridView(dgr);
            binding();
        }
        void dis_enable(bool e)
        {
            tbxMaKhachHang.Enabled = e;
            tbxTenKhachHang.Enabled = e;
            tbxSoDienThoai.Enabled = e;
            tbxEmail.Enabled = e;
            tbxCMND.Enabled = e;
            dPTNgaySinh.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            lKH = qlxm.LayToanBoKhachHang().ToList();
            LoadDataDataGridView(dataGridView1, lKH);
            dis_enable(false);
            SetAutoComplete();
            XuLyHoTroTbxTenKhachHang(lKH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_enable(true);
            resetData();
        }
        void TaoKhachHang(eKhachHang khmoi)
        {
            khmoi.MaKhachHang = tbxMaKhachHang.Text;
            khmoi.TenKhachHang = tbxTenKhachHang.Text;
            khmoi.Cmnd = tbxCMND.Text;
            khmoi.SoDienThoai = tbxSoDienThoai.Text;
            khmoi.Email = tbxEmail.Text;
            khmoi.NgaySinh = DateTime.Parse(dPTNgaySinh.Text);
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
                if (kt.TinhTuoi(dPTNgaySinh.Value, DateTime.Today) < 18)
                {
                    MessageBox.Show("khách hàng chưa đủ tuổi, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //them moi
                eKhachHang khmoi = new eKhachHang();
                TaoKhachHang(khmoi);
                int kq = qlxm.ThemKhachHang(khmoi);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lKH = qlxm.LayToanBoKhachHang().ToList();
                    LoadDataDataGridView(dataGridView1, lKH);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                eKhachHang khmoi = new eKhachHang();
                TaoKhachHang(khmoi);
                int kq = qlxm.SuaKhachHang(khmoi);
                if (kq == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lKH = qlxm.LayToanBoKhachHang().ToList();
                    LoadDataDataGridView(dataGridView1, lKH);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enable(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lKH = qlxm.LayToanBoKhachHang().ToList();
            LoadDataDataGridView(dataGridView1, lKH);
            dis_enable(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                eKhachHang khxoa = new eKhachHang();
                TaoKhachHang(khxoa);
                int kq = qlxm.XoaKhachHang(khxoa);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lKH = qlxm.LayToanBoKhachHang().ToList();
                    LoadDataDataGridView(dataGridView1, lKH);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
        private void SetAutoComplete()
        {
            
            tbxTimKiemKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxTimKiemKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void XuLyHoTroTbxTenKhachHang(List<eKhachHang> l)
        {
            tbxTimKiemKhachHang.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxTimKiemKhachHang.AutoCompleteCustomSource.Add(kh.TenKhachHang);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            eKhachHang khtim = new eKhachHang();
            if (!String.IsNullOrWhiteSpace(tbxTimKiemKhachHang.Text))
            {
                
                khtim = qlxm.TimKhachHangTheoTen(tbxTimKiemKhachHang.Text);
                if (khtim != null)
                {
                    dts = CreatData();
                    dts.Clear();
                    dts.Rows.Add(khtim.MaKhachHang, khtim.TenKhachHang, String.Format("{0:MM/dd/yyyy}", khtim.NgaySinh), khtim.Cmnd, khtim.SoDienThoai, khtim.Email);
                    dataGridView1.DataSource = dts;
                    dataGridView1.RefreshEdit();
                    FormatDataGridView(dataGridView1);
                    binding();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lKH = qlxm.LayToanBoKhachHang().ToList();
                LoadDataDataGridView(dataGridView1,lKH);
            }
        }
    }
}
