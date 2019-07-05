using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguoidungDTO
{
    public class NguoiDungDTO
    {
        private string tenDangNhap;
        private string tenHienThi;
        private string passWord;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}
