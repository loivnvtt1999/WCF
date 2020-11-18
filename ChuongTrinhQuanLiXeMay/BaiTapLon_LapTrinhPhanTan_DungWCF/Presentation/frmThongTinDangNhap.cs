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
    public partial class frmThongTinDangNhap : Form
    {
        eNhanVien nvDaDangNhap;
        Thread t1;
        object thisLock = new object();
        public frmThongTinDangNhap()
        {
            InitializeComponent();
        }
        public frmThongTinDangNhap(eNhanVien nv)
        {
            InitializeComponent();
            nvDaDangNhap = nv;
            DateTime date = DateTime.Now;
            lblClock.Text= date.ToString("hh:mm:ss");
            t1 = new Thread(start);
            t1.Start();
        }
        private void start()
        {
            Event clock = new Event();
            newdigital(clock);
            clock.Run();
        }
        private void newdigital(Event clock)
        {
            clock.OnSecondChange += new Event.SecondChangeHandler(Show);
        }
        private void Show(object obj, EventArgs arg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate () { Show(obj, arg); }));
            }
            else
            {
                DateTime date = DateTime.Now;
                lblClock.Text = date.ToString("hh:mm:ss");
            }
        }
        private void frmThongTinDangNhap_Load(object sender, EventArgs e)
        {
            tbxMaNhanVien.Text = nvDaDangNhap.MaNhanVien;
            tbxTenNhanVien.Text = nvDaDangNhap.TenNhanVien;
            tbxSoDienThoai.Text = nvDaDangNhap.SoDienThoai;
            tbxEmail.Text = nvDaDangNhap.Email;
            tbxCMND.Text = nvDaDangNhap.Cmnd;
            cbChucVu.Text = nvDaDangNhap.ChucVu;
            dPTNgaySinh.Text = nvDaDangNhap.NgaySinh.ToShortDateString();
        }
    }
}
