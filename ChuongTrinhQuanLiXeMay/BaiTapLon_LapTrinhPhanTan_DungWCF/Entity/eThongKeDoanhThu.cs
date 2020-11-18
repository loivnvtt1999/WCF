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
    public class eThongKeDoanhThu
    {
        string tenXe, tenLoai;
        int soLuong;
        double giaBan, thue;
        DateTime ngayLap;
        [DataMember]
        public string TenXe { get => tenXe; set => tenXe = value; }
        [DataMember]
        public int SoLuong { get => soLuong; set => soLuong = value; }
        [DataMember]
        public double GiaBan { get => giaBan; set => giaBan = value; }
        [DataMember]
        public double Thue { get => thue; set => thue = value; }
        [DataMember]
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        [DataMember]
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
