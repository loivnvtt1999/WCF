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
    public partial class frmDangNhap : Form
    {
        QuanLyXeMayClient qlxm;
        frmMainform fMain;
        public eNhanVien nvDangNhap;
        public frmDangNhap()
        {
            InitializeComponent();
            tbxMatKhau.PasswordChar = '*';
            qlxm = new QuanLyXeMayClient();
            nvDangNhap = new eNhanVien();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            tbxTaiKhoan.Select();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nvDangNhap = qlxm.KiemTraDangNhap(tbxTaiKhoan.Text, tbxMatKhau.Text);
            if (nvDangNhap != null)
            {
                if (nvDangNhap.TrangthaiNV.Equals("Đang theo dõi"))
                {
                    fMain = new frmMainform(nvDangNhap);
                    //this.Hide();
                    // this.Close();               
                    if (fMain.ShowDialog() == DialogResult.OK)
                        //this.Show();
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Nhân viên đã ngưng làm việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxTaiKhoan.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult rs = MessageBox.Show("Bạn có chắc thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
            else
                rs = DialogResult.Cancel;
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult rs = MessageBox.Show("Bạn có chắc thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (rs == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
            //else
            //    e.Cancel = false;
        }

        private void gbThongTinDangNhap_Enter(object sender, EventArgs e)
        {

        }
    }
}
