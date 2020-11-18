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
    public class eLoaiXe
    {
        String maLoai, tenLoai;
        [DataMember]
        public string MaLoai { get => maLoai; set => maLoai = value; }
        [DataMember]
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public eLoaiXe()
        {
            maLoai = "";
            tenLoai = "";
        }
    }
}
