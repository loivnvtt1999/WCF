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
    public class eXeMay
    {
        string maXe, tenXe, mauSac, phanKhoi, loaiPhanh, loaiBanh, maLoai, trangThaiXe;
        int soLuong;
        float giaThanh;
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
        public string MaLoai { get => maLoai; set => maLoai = value; }
        [DataMember]
        public string TrangThaiXe { get => trangThaiXe; set => trangThaiXe = value; }
        [DataMember]
        public int SoLuong { get => soLuong; set => soLuong = value; }
        [DataMember]
        public float GiaThanh { get => giaThanh; set => giaThanh = value; }
        public eXeMay()
        {
            maXe = "";
            tenXe = "";
            mauSac = "";
            phanKhoi = "";
            loaiPhanh = "";
            loaiBanh = "";
            maLoai = "";
            trangThaiXe = "";
            soLuong = 0;
            giaThanh = 0;
        }
    }
}
