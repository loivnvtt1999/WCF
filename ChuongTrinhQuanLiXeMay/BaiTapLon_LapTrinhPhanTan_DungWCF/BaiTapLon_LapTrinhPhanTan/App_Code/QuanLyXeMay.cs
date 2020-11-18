using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using Entity;
using DAL;
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QuanLyXeMay" in code, svc and config file together.
public class QuanLyXeMay : IQuanLyXeMay
{
    DataClasses1DataContext db;

    public QuanLyXeMay()
    {
        db = new DataClasses1DataContext();
    }

    public int CapNhatSoLuongXe(eXeMay xe,int soluong)
    {
        if (!KiemTraXeMay(xe.MaXe))
            return 0;
        Xe xecanthemsoluong = db.Xes.Where(x => x.maXe.Equals(xe.MaXe)).FirstOrDefault();
        xecanthemsoluong.soLuong = xecanthemsoluong.soLuong + soluong;
        db.SubmitChanges();
        return 1;
    }

    public int GiamSoLuongXe(eXeMay xe ,int soluong)
    {
        if (!KiemTraXeMay(xe.MaXe))
            return 0;
        Xe xecanthemsoluong = db.Xes.Where(x => x.maXe.Equals(xe.MaXe)).FirstOrDefault();
        xecanthemsoluong.soLuong = xecanthemsoluong.soLuong - soluong;
        db.SubmitChanges();
        return 1;
    }

    public eNhanVien KiemTraDangNhap(String taiKhoan, String matKhau)
    {
        NhanVien nv= db.NhanViens.Where(x => x.maNhanVien.Equals(taiKhoan)&&x.matKhau.Equals(matKhau)).FirstOrDefault();
        if (nv == null)
            return null;
        eNhanVien nvmoi = new eNhanVien();
        nvmoi.MaNhanVien = nv.maNhanVien;
        nvmoi.TenNhanVien = nv.tenNhanVien;
        nvmoi.Email = nv.email;
        nvmoi.SoDienThoai = nv.soDienThoaiNV;
        nvmoi.Cmnd = nv.cmnd;
        nvmoi.NgaySinh = DateTime.Parse(nv.ngaySinh.ToShortDateString());
        nvmoi.ChucVu = nv.chucVu;
        nvmoi.MatKhau = nv.matKhau;
        nvmoi.TrangthaiNV = nv.trangThaiNV;
        return nvmoi;
    }

    public bool KiemTraKhachHang(string ma)
    {
        KhachHang kh = db.KhachHangs.Where(x => x.maKhachHang.Equals(ma)).FirstOrDefault();
        if (kh != null)
            return true;
        return false;
    }

    public bool KiemTraNhanVien(String ma)
    {
        NhanVien nv = db.NhanViens.Where(x => x.maNhanVien.Equals(ma)).FirstOrDefault();
        if (nv != null)
            return true;
        return false;
    }

    public bool KiemTraXeMay(string ma)
    {
        Xe xe = db.Xes.Where(x => x.maXe.Equals(ma)).FirstOrDefault();
        if (xe != null)
            return true;
        return false;
    }

    public List<eChiTiet> layChiTietTheoMa(String maHD)
    {
        List<eChiTiet> l = new List<eChiTiet>();
        List<ChiTietHoaDon> lCT = db.ChiTietHoaDons.Where(x => x.maHoaDon.Equals(maHD)).ToList();
        foreach(ChiTietHoaDon chiTiet in lCT)
        {
            eChiTiet ctt = new eChiTiet();
            ctt.MaHoaDon = chiTiet.maHoaDon;
            ctt.GiaBan = float.Parse(chiTiet.giaBan.ToString());
            ctt.SoLuong = int.Parse(chiTiet.soLuong.ToString());
            ctt.Thue = float.Parse(chiTiet.thue.ToString());
            ctt.MaXe = chiTiet.maXe;
            l.Add(ctt);
        }
        return l;
    }

    public eLoaiXe LayLoaiTheoMa(string ma)
    {
        LoaiXe lx = db.LoaiXes.Where(x => x.maLoai.Equals(ma)).FirstOrDefault();
        eLoaiXe eLX = new eLoaiXe();
        eLX.MaLoai = lx.maLoai;
        eLX.TenLoai = lx.tenLoai;
        return eLX;
    }

    public eLoaiXe LayLoaiXeTheoTenLoai(String tenLoai)
    {
        LoaiXe lx = db.LoaiXes.Where(x => x.tenLoai.Equals(tenLoai)).FirstOrDefault();
        eLoaiXe eLX = new eLoaiXe();
        eLX.MaLoai = lx.maLoai;
        eLX.TenLoai = lx.tenLoai;
        return eLX;
    }

    public List<eHoaDon> layToanBoHoaDon()
    {
        List<eHoaDon> l = new List<eHoaDon>();
        foreach (HoaDon hd in db.HoaDons)
        {
            eHoaDon eHD = new eHoaDon();
            eHD.MaHoaDon = hd.maHoaDon;
            eHD.MaKhachHang = hd.maKhachHang;
            eHD.MaNhanVien = hd.maNhanVien;
            eHD.NgayLap = hd.ngayLap;
            eHD.TrangThai = hd.trangthai;
            l.Add(eHD);
        }
        return l;
    }

    public List<eKhachHang> LayToanBoKhachHang()
    {
        List<eKhachHang> l = new List<eKhachHang>();
        foreach (KhachHang kh in db.KhachHangs)
        {
            eKhachHang khmoi = new eKhachHang();
            khmoi.MaKhachHang = kh.maKhachHang;
            khmoi.TenKhachHang = kh.tenKhachHang;
            khmoi.Cmnd = kh.cmnd;
            khmoi.SoDienThoai = kh.soDienThoaiKH;
            khmoi.Email = kh.emailKH;
            khmoi.NgaySinh = kh.ngaySinh;
            l.Add(khmoi);
        }
        return l;
    }

    public List<eLoaiXe> LayToanBoLoaiXe()
    {
        List<eLoaiXe> l = new List<eLoaiXe>();
        foreach(LoaiXe lx in db.LoaiXes)
        {
            eLoaiXe eLX = new eLoaiXe();
            eLX.MaLoai = lx.maLoai;
            eLX.TenLoai = lx.tenLoai;
            l.Add(eLX);
        }
        return l;
    }

    public List<eNhanVien> LayToanBoNhanVien()
    {
        List<eNhanVien> l = new List<eNhanVien>();
        foreach (NhanVien nv in db.NhanViens)
        {
            eNhanVien nvmoi = new eNhanVien();
            nvmoi.MaNhanVien = nv.maNhanVien;
            nvmoi.TenNhanVien = nv.tenNhanVien;
            nvmoi.Email = nv.email;
            nvmoi.SoDienThoai = nv.soDienThoaiNV;
            nvmoi.Cmnd = nv.cmnd;
            nvmoi.NgaySinh = DateTime.Parse(nv.ngaySinh.ToShortDateString());
            nvmoi.ChucVu = nv.chucVu;
            nvmoi.MatKhau = nv.matKhau;
            nvmoi.TrangthaiNV = nv.trangThaiNV;
            l.Add(nvmoi);
        }
        return l;
    }

    public List<eXeMay> LayToanBoXeMay()
    {
        List<eXeMay> l = new List<eXeMay>();
        foreach(Xe x in db.Xes)
        {
            eXeMay xemay = new eXeMay();
            xemay.MaXe = x.maXe;
            xemay.TenXe = x.tenXe;
            xemay.LoaiPhanh = x.loaiPhanh;
            xemay.LoaiBanh = x.loaiBanh;
            xemay.SoLuong = x.soLuong;
            xemay.MauSac = x.mauSac;
            xemay.GiaThanh = float.Parse(x.giaThanh.ToString());
            xemay.PhanKhoi = x.phanKhoi;
            xemay.MaLoai = x.maLoai;
            xemay.TrangThaiXe = x.trangThaiXe;
            l.Add(xemay);
        }
        return l;
    }

    public string PhatSinhMaHoaDon()
    {
        int n = 0;
        string str = "HD";
        HoaDon hd = db.HoaDons.ToList().LastOrDefault();
        if (hd != null)
        {
            string str1 = hd.maHoaDon.Substring(2);
            n = int.Parse(str1) + 1;
        }
        if (n < 10)
        {
            str = str + "000" + n.ToString();
        }
        else if (n < 100)
        {
            str = str + "00" + n.ToString();
        }
        else if (n < 1000)
        {
            str = str + "0" + n.ToString();
        }
        else if (n < 10000)
        {
            str = str + n.ToString();
        }
        return str;
    }

    public string PhatSinhMaKH()
    {
        int n = 0;
        string str = "KH";
        KhachHang kh = db.KhachHangs.ToList().LastOrDefault();
        if (kh != null)
        {
            string str1 = kh.maKhachHang.Substring(2);
            n = int.Parse(str1) + 1;
        }
        if (n < 10)
        {
            str = str + "000" + n.ToString();
        }
        else if (n < 100)
        {
            str = str + "00" + n.ToString();
        }
        else if (n < 1000)
        {
            str = str + "0" + n.ToString();
        }
        else if (n < 10000)
        {
            str = str + n.ToString();
        }
        return str;
    }

    public string PhatSinhMaNhanVien()
    {
        int n = 0;
        string str = "NV";
        NhanVien nv = db.NhanViens.ToList().LastOrDefault();
        if (nv != null)
        {
            string str1 = nv.maNhanVien.Substring(2);
            n = int.Parse(str1) + 1;
        }
        if (n < 10)
        {
            str = str + "000" + n.ToString();
        }
        else if (n < 100)
        {
            str = str + "00" + n.ToString();
        }
        else if (n < 1000)
        {
            str = str + "0" + n.ToString();
        }
        else if (n < 10000)
        {
            str = str + n.ToString();
        }
        return str;
    }

    public string PhatSinhMaXe()
    {
        int n = 0;
        string str = "XE";
        Xe xe = db.Xes.ToList().LastOrDefault();
        if (xe != null)
        {
            string str1 = xe.maXe.Substring(2);
            n = int.Parse(str1) + 1;
        }
        if (n < 10)
        {
            str = str + "000" + n.ToString();
        }
        else if (n < 100)
        {
            str = str + "00" + n.ToString();
        }
        else if (n < 1000)
        {
            str = str + "0" + n.ToString();
        }
        else if (n < 10000)
        {
            str = str + n.ToString();
        }
        return str;
    }

    public int SuaKhachHang(eKhachHang kh)
    {
        if (!KiemTraKhachHang(kh.MaKhachHang))
            return 0;
        KhachHang khsua = db.KhachHangs.Where(x => x.maKhachHang.Equals(kh.MaKhachHang)).FirstOrDefault();
        khsua.tenKhachHang = kh.TenKhachHang;
        khsua.soDienThoaiKH = kh.SoDienThoai;
        khsua.emailKH = kh.Email;
        khsua.cmnd = kh.Cmnd;
        khsua.ngaySinh = kh.NgaySinh;
        db.SubmitChanges();
        return 1;
    }

    public int SuaNhanVien(eNhanVien nv)
    {
        if (!KiemTraNhanVien(nv.MaNhanVien))
            return 0;
        NhanVien nvmoi = db.NhanViens.Where(x=>x.maNhanVien.Equals(nv.MaNhanVien)).FirstOrDefault();
        nvmoi.tenNhanVien = nv.TenNhanVien;
        nvmoi.soDienThoaiNV = nv.SoDienThoai;
        nvmoi.email = nv.Email;
        nvmoi.cmnd = nv.Cmnd;
        nvmoi.chucVu = nv.ChucVu;
        nvmoi.ngaySinh = nv.NgaySinh;
        db.SubmitChanges();
        return 1;
    }

    public int SuaXeMay(eXeMay xe)
    {
        if (!KiemTraXeMay(xe.MaXe))
            return 0;
        Xe xsua = db.Xes.Where(x => x.maXe.Equals(xe.MaXe)).FirstOrDefault();
        xsua.tenXe = xe.TenXe;
        xsua.mauSac = xe.MauSac;
        xsua.loaiPhanh = xe.LoaiPhanh;
        xsua.loaiBanh = xe.LoaiBanh;
        xsua.maLoai = xe.MaLoai;
        xsua.giaThanh = xe.GiaThanh;
        xsua.soLuong = xe.SoLuong;
        xsua.phanKhoi = xe.PhanKhoi;
        db.SubmitChanges();
        return 1;
    }

    public int ThemChiThiet(eChiTiet ct)
    {
        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
        chiTietHoaDon.maHoaDon = ct.MaHoaDon;
        chiTietHoaDon.maXe = ct.MaXe;
        chiTietHoaDon.giaBan = ct.GiaBan;
        chiTietHoaDon.soLuong = ct.SoLuong;
        chiTietHoaDon.thue = ct.Thue;
        db.ChiTietHoaDons.InsertOnSubmit(chiTietHoaDon);
        db.SubmitChanges();
        return 1;
    }

    public int themHoaDon(eHoaDon eHD)
    {
        HoaDon hdon = new HoaDon();
        hdon.maHoaDon = eHD.MaHoaDon;
        hdon.maKhachHang = eHD.MaKhachHang;
        hdon.maNhanVien = eHD.MaNhanVien;
        hdon.trangthai = eHD.TrangThai;
        hdon.ngayLap = eHD.NgayLap;
        db.HoaDons.InsertOnSubmit(hdon);
        db.SubmitChanges();
        return 1;
    }

    public int ThemKhachHang(eKhachHang kh)
    {
        if (KiemTraKhachHang(kh.MaKhachHang))
            return 0;
        KhachHang khmoi = new KhachHang();
        khmoi.maKhachHang = kh.MaKhachHang;
        khmoi.tenKhachHang = kh.TenKhachHang;
        khmoi.ngaySinh = kh.NgaySinh;
        khmoi.cmnd = kh.Cmnd;
        khmoi.emailKH = kh.Email;
        khmoi.soDienThoaiKH = kh.SoDienThoai;
        db.KhachHangs.InsertOnSubmit(khmoi);
        db.SubmitChanges();
        return 1;
    }

    public int ThemNhanVien(eNhanVien nv)
    {
        if (KiemTraNhanVien(nv.MaNhanVien))
            return 0;
        NhanVien nvmoi = new NhanVien();
        nvmoi.maNhanVien = nv.MaNhanVien;
        nvmoi.tenNhanVien = nv.TenNhanVien;
        nvmoi.soDienThoaiNV = nv.SoDienThoai;
        nvmoi.email = nv.Email;
        nvmoi.cmnd = nv.Cmnd;
        nvmoi.chucVu = nv.ChucVu;
        nvmoi.ngaySinh = nv.NgaySinh;
        nvmoi.matKhau = "123";
        db.NhanViens.InsertOnSubmit(nvmoi);
        db.SubmitChanges();
        return 1;
    }

    public int ThemXe(eXeMay xemaymoi)
    {
        if (KiemTraXeMay(xemaymoi.MaXe))
            return 0;
        Xe xmoi = new Xe();
        xmoi.maXe = xemaymoi.MaXe;
        xmoi.tenXe = xemaymoi.TenXe;
        xmoi.mauSac = xemaymoi.MauSac;
        xmoi.phanKhoi = xemaymoi.PhanKhoi;
        xmoi.loaiBanh = xemaymoi.LoaiBanh;
        xmoi.loaiPhanh = xemaymoi.LoaiPhanh;
        xmoi.soLuong = xemaymoi.SoLuong;
        xmoi.giaThanh = float.Parse(xemaymoi.GiaThanh.ToString());
        xmoi.maLoai = xemaymoi.MaLoai;
        xmoi.trangThaiXe = xemaymoi.TrangThaiXe;
        db.Xes.InsertOnSubmit(xmoi);
        db.SubmitChanges();
        return 1;
    }

    public List<eThongKeBanChay> thongKeBanChay(DateTime tuNgay, DateTime denNgay)
    {
        var thongke = (from ct in db.ChiTietHoaDons
                       join xe in db.Xes on ct.maXe equals xe.maXe
                       join l in db.LoaiXes on xe.maLoai equals l.maLoai
                       join hd in db.HoaDons on ct.maHoaDon equals hd.maHoaDon
                       where tuNgay <= hd.ngayLap && denNgay >= hd.ngayLap
                       group xe by new
                       {
                           xe.maXe,
                           xe.tenXe,
                           xe.mauSac,
                           xe.phanKhoi,
                           xe.loaiPhanh,
                           xe.loaiBanh,
                           l.tenLoai,
                           soluong = db.ChiTietHoaDons.Where(a => a.maXe.Equals(xe.maXe)).Sum(b => b.soLuong)
                       } into g
                       orderby g.Key.soluong descending
                       select g.Key);
        List<eThongKeBanChay> listXe = new List<eThongKeBanChay>();
        foreach (var eXe in thongke)
        {
            eThongKeBanChay tam = new eThongKeBanChay();
            tam.MaXe = eXe.maXe;
            tam.TenXe = eXe.tenXe;
            tam.MauSac = eXe.mauSac;
            tam.PhanKhoi = eXe.phanKhoi;
            tam.LoaiPhanh = eXe.loaiPhanh;
            tam.LoaiBanh = eXe.loaiBanh;
            tam.TenLoai = eXe.tenLoai;
            tam.SoLuong = eXe.soluong;
            listXe.Add(tam);
        }
        return listXe;
    }

    public List<eThongKeDoanhThu> thongKeDoanhThu(DateTime tuNgay, DateTime denNgay)
    {
        var thongke = (from ct in db.ChiTietHoaDons
                       from hd in db.HoaDons
                       from xe in db.Xes
                       from l in db.LoaiXes
                       where ct.maHoaDon.Equals(hd.maHoaDon)
                       where xe.maXe.Equals(ct.maXe)
                       where xe.maLoai.Equals(l.maLoai)
                       where tuNgay <= hd.ngayLap && denNgay >= hd.ngayLap
                       select new
                       {
                           l.tenLoai,
                           ct.soLuong,
                           ct.giaBan,
                           ct.thue,
                           hd.ngayLap,
                           xe.tenXe
                       }).ToList();
        List<eThongKeDoanhThu> listDT = new List<eThongKeDoanhThu>();
        foreach (var eDT in thongke)
        {
            eThongKeDoanhThu tam = new eThongKeDoanhThu();
            tam.TenLoai = eDT.tenLoai;
            tam.TenXe = eDT.tenXe;
            tam.SoLuong = eDT.soLuong;
            tam.GiaBan = eDT.giaBan;
            tam.Thue = eDT.thue;
            tam.NgayLap = (DateTime)eDT.ngayLap;
            listDT.Add(tam);
        }
        return listDT;
    }

    public List<eThongKeKhachMuaNhieu> thongKeKhachMuaNhieu(DateTime tuNgay, DateTime denNgay)
    {
        var thongke = (from ct in db.ChiTietHoaDons
                       from hd in db.HoaDons
                       from xe in db.Xes
                       from kh in db.KhachHangs
                       where ct.maHoaDon.Equals(hd.maHoaDon)
                       where kh.maKhachHang.Equals(hd.maKhachHang)
                       where xe.maXe.Equals(ct.maXe)
                       where tuNgay <= hd.ngayLap && denNgay >= hd.ngayLap
                       select new
                       {
                           kh.maKhachHang,
                           kh.tenKhachHang,
                           kh.cmnd,
                           kh.ngaySinh,
                           kh.soDienThoaiKH,
                           kh.emailKH,
                           ct.soLuong,
                           hd.ngayLap,
                           xe.tenXe
                       }).ToList();
        List<eThongKeKhachMuaNhieu> listKH = new List<eThongKeKhachMuaNhieu>();
        foreach (var eKH in thongke)
        {
            eThongKeKhachMuaNhieu tam = new eThongKeKhachMuaNhieu();
            tam.MaKH = eKH.maKhachHang;
            tam.TenKH = eKH.tenKhachHang;
            tam.Cmnd = eKH.cmnd;
            tam.SDT = eKH.soDienThoaiKH;
            tam.Email = eKH.emailKH;
            tam.NgayMua = (DateTime)eKH.ngayLap;
            tam.NgaySinh = (DateTime)eKH.ngaySinh;
            tam.SoLuong = eKH.soLuong;
            tam.TenXe = eKH.tenXe;
            listKH.Add(tam);
        }
        return listKH;
    }

    public eKhachHang TimKhachHangTheoMa(string ma)
    {
        KhachHang kh = db.KhachHangs.Where(x => x.maKhachHang.Equals(ma)).FirstOrDefault();
        if (kh == null)
            return null;
        eKhachHang khlay = new eKhachHang();
        khlay.MaKhachHang = kh.maKhachHang;
        khlay.TenKhachHang = kh.tenKhachHang;
        khlay.Cmnd = kh.cmnd;
        khlay.SoDienThoai = kh.soDienThoaiKH;
        khlay.Email = kh.emailKH;
        khlay.NgaySinh = kh.ngaySinh;
        return khlay;
    }

    public eKhachHang TimKhachHangTheoSDT(string sdt)
    {
        KhachHang kh = db.KhachHangs.Where(x => x.soDienThoaiKH.Equals(sdt)).FirstOrDefault();
        if (kh == null)
            return null;
        eKhachHang khlay = new eKhachHang();
        khlay.MaKhachHang = kh.maKhachHang;
        khlay.TenKhachHang = kh.tenKhachHang;
        khlay.Cmnd = kh.cmnd;
        khlay.SoDienThoai = kh.soDienThoaiKH;
        khlay.Email = kh.emailKH;
        khlay.NgaySinh = kh.ngaySinh;
        return khlay;
    }

    public eKhachHang TimKhachHangTheoTen(string ten)
    {
        KhachHang kh = db.KhachHangs.Where(x => x.tenKhachHang.Equals(ten)).FirstOrDefault();
        if (kh == null)
            return null;
        eKhachHang khlay = new eKhachHang();
        khlay.MaKhachHang = kh.maKhachHang;
        khlay.TenKhachHang = kh.tenKhachHang;
        khlay.Cmnd = kh.cmnd;
        khlay.SoDienThoai = kh.soDienThoaiKH;
        khlay.Email = kh.emailKH;
        khlay.NgaySinh = kh.ngaySinh;
        return khlay;
    }

    public eNhanVien timNhanVienTheoMa(string maNV)
    {
        NhanVien nv = db.NhanViens.Where(x => x.maNhanVien.Equals(maNV)).FirstOrDefault();
        if (nv == null)
        {
            return null;
        }
        eNhanVien nvlay = new eNhanVien();
        nvlay.MaNhanVien = nv.maNhanVien;
        nvlay.TenNhanVien = nv.tenNhanVien;
        nvlay.SoDienThoai = nv.soDienThoaiNV;
        nvlay.Email = nv.email;
        nvlay.MatKhau = nv.matKhau;
        nvlay.Cmnd = nv.cmnd;
        nvlay.NgaySinh = nv.ngaySinh;
        nvlay.TrangthaiNV = nv.trangThaiNV;
        nvlay.ChucVu = nv.chucVu;
        return nvlay;
    }

    public eNhanVien TimNhanVienTheoTen(string ten)
    {
        NhanVien nv = db.NhanViens.Where(x => x.tenNhanVien.Equals(ten)).FirstOrDefault();
        if (nv == null)
        {
            return null;
        }
        eNhanVien nvlay = new eNhanVien();
        nvlay.MaNhanVien = nv.maNhanVien;
        nvlay.TenNhanVien = nv.tenNhanVien;
        nvlay.SoDienThoai = nv.soDienThoaiNV;
        nvlay.Email = nv.email;
        nvlay.MatKhau = nv.matKhau;
        nvlay.Cmnd = nv.cmnd;
        nvlay.NgaySinh = nv.ngaySinh;
        nvlay.TrangthaiNV = nv.trangThaiNV;
        nvlay.ChucVu = nv.chucVu;
        return nvlay;
    }

    public eXeMay TimXeTheoMa(string ma)
    {
        Xe x = db.Xes.Where(xe => xe.maXe.Equals(ma)).FirstOrDefault();
        if (x == null)
            return null;
        eXeMay xemay = new eXeMay();
        xemay.MaXe = x.maXe;
        xemay.TenXe = x.tenXe;
        xemay.LoaiPhanh = x.loaiPhanh;
        xemay.LoaiBanh = x.loaiBanh;
        xemay.SoLuong = x.soLuong;
        xemay.MauSac = x.mauSac;
        xemay.GiaThanh = float.Parse(x.giaThanh.ToString());
        xemay.PhanKhoi = x.phanKhoi;
        xemay.MaLoai = x.maLoai;
        xemay.TrangThaiXe = x.trangThaiXe;
        return xemay;
    }

    public eXeMay TimXeTheoTen(string ten)
    {
        Xe x = db.Xes.Where(xe => xe.tenXe.Equals(ten)).FirstOrDefault();
        if (x == null)
            return null;
        eXeMay xemay = new eXeMay();
        xemay.MaXe = x.maXe;
        xemay.TenXe = x.tenXe;
        xemay.LoaiPhanh = x.loaiPhanh;
        xemay.LoaiBanh = x.loaiBanh;
        xemay.SoLuong = x.soLuong;
        xemay.MauSac = x.mauSac;
        xemay.GiaThanh = float.Parse(x.giaThanh.ToString());
        xemay.PhanKhoi = x.phanKhoi;
        xemay.MaLoai = x.maLoai;
        xemay.TrangThaiXe = x.trangThaiXe;
        return xemay;
    }

    public int XoaKhachHang(eKhachHang kh)
    {
        if (!KiemTraKhachHang(kh.MaKhachHang))
            return 0;
        KhachHang khxoa = db.KhachHangs.Where(x => x.maKhachHang.Equals(kh.MaKhachHang)).FirstOrDefault();
        db.KhachHangs.DeleteOnSubmit(khxoa);
        db.SubmitChanges();
        return 1;
    }

    public int XoaNhanVien(eNhanVien nv)
    {
        if (!KiemTraNhanVien(nv.MaNhanVien))
            return 0;
        NhanVien nvmoi = db.NhanViens.Where(x => x.maNhanVien.Equals(nv.MaNhanVien)).FirstOrDefault();
        nvmoi.trangThaiNV = nv.TrangthaiNV;
        db.SubmitChanges();
        return 1;
    }

    public int XoaXe(eXeMay xe)
    {
        if (!KiemTraXeMay(xe.MaXe))
            return 0;
        Xe xexoa = db.Xes.Where(x => x.maXe.Equals(xe.MaXe)).FirstOrDefault();
        xexoa.trangThaiXe = xe.TrangThaiXe;
        db.SubmitChanges();
        return 1;
    }
}
