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
    public class eThongKeBanChay
    {
        string maXe, tenXe, mauSac, phanKhoi, loaiPhanh, loaiBanh, tenLoai;
        int soLuong;
        [DataMember]
        public string MaXe { get => maXe; set => maXe = value; }
        [DataMember]
        public string TenXe { get => tenXe; set => tenXe = value; }
        [DataMember]
        public string MauSac { get => mauSac; set => mauSac = value; }
        [DataMember]
        public string PhanKhoi { get => phanKhoi; set => phanKhoi = value; }
        [DataMember]
        public string LoaiPhanh { get => loaiPhanh; set => loaiPhanh = value; }
        [DataMember]
        public string LoaiBanh { get => loaiBanh; set => loaiBanh = value; }
        [DataMember]
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        [DataMember]
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
