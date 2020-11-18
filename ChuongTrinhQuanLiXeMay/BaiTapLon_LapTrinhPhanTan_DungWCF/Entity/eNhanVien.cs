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
    public class eNhanVien
    {
        String maNhanVien, tenNhanVien, cmnd,soDienThoai, email, chucVu, matKhau,trangthaiNV;
        DateTime ngaySinh;
        [DataMember]
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        [DataMember]
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        [DataMember]
        public string Cmnd { get => cmnd; set => cmnd = value; }
        [DataMember]
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        [DataMember]
        public string Email { get => email; set => email = value; }
        [DataMember]
        public string ChucVu { get => chucVu; set => chucVu = value; }
        [DataMember]
        public string MatKhau { get => matKhau; set => matKhau = value; }
        [DataMember]
        public string TrangthaiNV { get => trangthaiNV; set => trangthaiNV = value; }
        [DataMember]
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public eNhanVien()
        {
            maNhanVien = "";
            tenNhanVien = "";
            cmnd = "";
            soDienThoai = "";
            email = "";
            chucVu = "";
            matKhau = "";
            trangthaiNV = "";
            ngaySinh = DateTime.Today;
        }
    }
}
