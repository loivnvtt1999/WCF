using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Entity
{
    [DataContract]
   public  class eHoaDon
    {
        String maHoaDon, maNhanVien, maKhachHang, trangThai;
        DateTime ngayLap;
        [DataMember]
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        [DataMember]
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        [DataMember]
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        [DataMember]
        public string TrangThai { get => trangThai; set => trangThai = value; }
        [DataMember]
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }

        public eHoaDon()
        {
            maHoaDon = "";
            maNhanVien = "";
            maKhachHang = "";
            trangThai = "";
            NgayLap = DateTime.Today;
        }
    }
}
