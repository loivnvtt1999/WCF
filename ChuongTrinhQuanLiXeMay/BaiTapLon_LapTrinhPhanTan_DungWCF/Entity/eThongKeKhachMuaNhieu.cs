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
    public class eThongKeKhachMuaNhieu
    {
        string maKH, tenKH, cmnd, sDT, email, tenXe;
        int soLuong;
        DateTime ngayMua, ngaySinh;
        [DataMember]
        public string MaKH { get => maKH; set => maKH = value; }
        [DataMember]
        public string TenKH { get => tenKH; set => tenKH = value; }
        [DataMember]
        public string Cmnd { get => cmnd; set => cmnd = value; }
        [DataMember]
        public string SDT { get => sDT; set => sDT = value; }
        [DataMember]
        public string Email { get => email; set => email = value; }
        [DataMember]
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        [DataMember]
        public string TenXe { get => tenXe; set => tenXe = value; }
        [DataMember]
        public int SoLuong { get => soLuong; set => soLuong = value; }
        [DataMember]
        public DateTime NgayMua { get => ngayMua; set => ngayMua = value; }
    }
}
