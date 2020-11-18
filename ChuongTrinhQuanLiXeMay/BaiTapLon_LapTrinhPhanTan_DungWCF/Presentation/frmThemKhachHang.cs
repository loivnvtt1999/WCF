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
    public partial class frmThemKhachHang : Form
    {
        KiemTraThongTinKhachHang kt;
        QuanLyXeMayClient qlxm;
        public eKhachHang Kh;
        public frmThemKhachHang()
        {
            InitializeComponent();
            qlxm = new QuanLyXeMayClient();
            Kh = new eKhachHang();
            kt = new KiemTraThongTinKhachHang();
        }
        public void TaoKhachHang(eKhachHang Kh)
        {
            Kh.MaKhachHang = tbxMaKhachHang.Text;
            Kh.TenKhachHang = tbxTenKhachHang.Text;
            Kh.SoDienThoai = tbxSoDienThoai.Text;
            Kh.Email = tbxEmail.Text;
            Kh.Cmnd = tbxCMND.Text;
            Kh.NgaySinh = DateTime.Parse(dPTNgaySinh.Text);
        }
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            tbxMaKhachHang.Select();
            tbxMaKhachHang.Text = qlxm.PhatSinhMaKH();
            tbxMaKhachHang.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
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
            TaoKhachHang(Kh);
            int kq = qlxm.ThemKhachHang(Kh);
            if (kq == 1)
            {
                MessageBox.Show("thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
