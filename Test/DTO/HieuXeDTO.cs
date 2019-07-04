using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenHieuXeDTO
{
    public class HieuXeDTO
    {
        public string HieuXe
        {
            get { return hieuxe; }
            set { hieuxe = value; }
        }
        public int Mahieuxe
        {
            get { return mahieuxe; }
            set { mahieuxe = value; }
        }
        private int mahieuxe;
        private string hieuxe;
    }
}
