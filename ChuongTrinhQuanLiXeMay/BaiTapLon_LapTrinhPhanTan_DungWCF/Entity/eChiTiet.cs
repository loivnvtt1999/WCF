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
    public class eChiTiet
    {
        String maHoaDon, maXe;
        int soLuong;
        float giaBan;
        float thue;
        [DataMember]
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        [DataMember]
        public string MaXe { get => maXe; set => maXe = value; }
        [DataMember]
        public int SoLuong { get => soLuong; set => soLuong = value; }
        [DataMember]
        public float GiaBan { get => giaBan; set => giaBan = value; }
        [DataMember]
        public float Thue { get => thue; set => thue = value; }
        public eChiTiet()
        {
            maHoaDon = "";
            maXe = "";
            soLuong = 0;
            giaBan = 0;
            thue = 0;
        }
    }
}
