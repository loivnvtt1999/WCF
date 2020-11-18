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
    public partial class frmMainform : Form
    {
        QuanLyXeMayClient qlxm;
        public eNhanVien nvDangNhap;
        frmThongTinDangNhap f1;
        frmNhanVien f2;
        frmXeMay f3;
        frmKhachHang f4;
        frmLapHoaDon f5;
        frmThongKeBanChay f6;
        frmThongKeDoanhThu f7;
        frmThongKeKhachHang f8;
        frmQuanLyHoaDon f9;
        public frmMainform()
        {
            InitializeComponent();
            qlxm = new QuanLyXeMayClient();
        }
        public frmMainform(eNhanVien nhanvien)
        {
            InitializeComponent();
            nvDangNhap = nhanvien;
            f1 = new frmThongTinDangNhap(nvDangNhap);
            f2 = new frmNhanVien();
            f3 = new frmXeMay();
            f4 = new frmKhachHang();
            f5 = new frmLapHoaDon(nvDangNhap);
            f6 = new frmThongKeBanChay();
            f7 = new frmThongKeDoanhThu();
            f8 = new frmThongKeKhachHang();
            f9 = new frmQuanLyHoaDon();
        }
        private void frmMainform_Load(object sender, EventArgs e)
        {
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.ShowInTaskbar = false;
            f1.Show();
            f1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f1);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.ShowInTaskbar = false;
            f2.Show();
            f2.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f2);
        }

        private void quảnLýXeMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.ShowInTaskbar = false;
            f3.Show();
            f3.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f3);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f4.TopLevel = false;
            f4.FormBorderStyle = FormBorderStyle.None;
            f4.ShowInTaskbar = false;
            f4.Show();
            f4.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f4);
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f5.TopLevel = false;
            f5.FormBorderStyle = FormBorderStyle.None;
            f5.ShowInTaskbar = false;
            f5.Show();
            f5.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f5);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.ShowInTaskbar = false;
            f1.Show();
            f1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f1);
        }

        private void thốngKêBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f6.TopLevel = false;
            f6.FormBorderStyle = FormBorderStyle.None;
            f6.ShowInTaskbar = false;
            f6.Show();
            f6.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f6);
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f7.TopLevel = false;
            f7.FormBorderStyle = FormBorderStyle.None;
            f7.ShowInTaskbar = false;
            f7.Show();
            f7.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f7);
        }

        private void thốngKêKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f8.TopLevel = false;
            f8.FormBorderStyle = FormBorderStyle.None;
            f8.ShowInTaskbar = false;
            f8.Show();
            f8.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f8);
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            f9.TopLevel = false;
            f9.FormBorderStyle = FormBorderStyle.None;
            f9.ShowInTaskbar = false;
            f9.Show();
            f9.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f9);
        }
    }
}
