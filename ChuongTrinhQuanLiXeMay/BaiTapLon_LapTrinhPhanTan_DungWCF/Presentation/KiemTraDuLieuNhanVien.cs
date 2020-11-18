using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Presentation
{
    public class KiemTraDuLieuNhanVien
    {
        public KiemTraDuLieuNhanVien()
        {

        }
        public bool KiemTraEmail(String input)
        {
            return (new Regex(@"^\w+@\w+([.][A-Za-z0-9]{2,4}){2,3}$")).IsMatch(input);
        }
        public bool KiemTraSDT(String input)
        {
            return (new Regex(@"^\d{10}$")).IsMatch(input);
        }
        public bool KiemTraCMND(String input)
        {
            return (new Regex(@"^\d{9}|\d{12}$")).IsMatch(input);
        }
        public int TinhTuoi(DateTime ngaysinh, DateTime ngayhientai)
        {
            return ngayhientai.Year - ngaysinh.Year;
        }
    }
}
