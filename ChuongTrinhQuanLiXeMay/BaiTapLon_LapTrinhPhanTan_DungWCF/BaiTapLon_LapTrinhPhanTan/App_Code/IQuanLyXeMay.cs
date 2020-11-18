using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;
using DAL;
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuanLyXeMay" in both code and config file together.
[ServiceContract]
public interface IQuanLyXeMay
{
    [OperationContract]
    List<eNhanVien> LayToanBoNhanVien();
    [OperationContract]
    int ThemNhanVien(eNhanVien nv);
    [OperationContract]
    bool KiemTraNhanVien(String ma);
    [OperationContract]
    int SuaNhanVien(eNhanVien nv);
    [OperationContract]
    int XoaNhanVien(eNhanVien nv);
    [OperationContract]
    List<eKhachHang> LayToanBoKhachHang();
    [OperationContract]
    int ThemKhachHang(eKhachHang kh);
    [OperationContract]
    int SuaKhachHang(eKhachHang kh);
    [OperationContract]
    int XoaKhachHang(eKhachHang kh);
    [OperationContract]
    bool KiemTraKhachHang(String ma);
    [OperationContract]
    List<eXeMay> LayToanBoXeMay();
    [OperationContract]
    List<eLoaiXe> LayToanBoLoaiXe();
    [OperationContract]
    eLoaiXe LayLoaiTheoMa(String ma);
    [OperationContract]
    int ThemXe(eXeMay xemaymoi);
    [OperationContract]
    bool KiemTraXeMay(String ma);
    [OperationContract]
    int XoaXe(eXeMay xe);
    [OperationContract]
    int SuaXeMay(eXeMay xe);
    [OperationContract]
    eLoaiXe LayLoaiXeTheoTenLoai(String tenLoai);
    [OperationContract]
    int CapNhatSoLuongXe(eXeMay xe,int soluong);
    [OperationContract]
    eNhanVien KiemTraDangNhap(String taiKhoan,String matKhau);
    [OperationContract]
    int themHoaDon(eHoaDon eHD);
    [OperationContract]
    List<eThongKeBanChay> thongKeBanChay(DateTime tuNgay, DateTime denNgay);
    [OperationContract]
    List<eThongKeKhachMuaNhieu> thongKeKhachMuaNhieu(DateTime tuNgay, DateTime denNgay);
    [OperationContract]
    List<eThongKeDoanhThu> thongKeDoanhThu(DateTime tuNgay, DateTime denNgay);
    [OperationContract]
    eKhachHang TimKhachHangTheoSDT(String sdt);
    [OperationContract]
    eKhachHang TimKhachHangTheoMa(String ma);
    [OperationContract]
    eKhachHang TimKhachHangTheoTen(String ten);
    [OperationContract]
    string PhatSinhMaKH();
    [OperationContract]
    string PhatSinhMaXe();
    [OperationContract]
    string PhatSinhMaNhanVien();
    [OperationContract]
    String PhatSinhMaHoaDon();
    [OperationContract]
    eXeMay TimXeTheoTen(String ten);
    [OperationContract]
    eXeMay TimXeTheoMa(String ma);
    [OperationContract]
    int ThemChiThiet(eChiTiet ct);
    [OperationContract]
    int GiamSoLuongXe(eXeMay xe ,int soluong);
    [OperationContract]
    List<eHoaDon> layToanBoHoaDon();
    [OperationContract]
    List<eChiTiet> layChiTietTheoMa(String maHD);
    [OperationContract]
    eNhanVien timNhanVienTheoMa(String maNV);
    [OperationContract]
    eNhanVien TimNhanVienTheoTen(String ten);
}
