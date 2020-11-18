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
     public class eKhachHang
    {
        String maKhachHang, tenKhachHang, cmnd, soDienThoai, email;
        DateTime ngaySinh;
        [DataMember]
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        [DataMember]
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        [DataMember]
        public string Cmnd { get => cmnd; set => cmnd = value; }
        [DataMember]
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        [DataMember]
        public string Email { get => email; set => email = value; }
        [DataMember]
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public eKhachHang()
        {
            maKhachHang = "";
            tenKhachHang = "";
            cmnd = "";
            soDienThoai = "";
            email = "";
            ngaySinh = DateTime.Today;
        }
    }
}
