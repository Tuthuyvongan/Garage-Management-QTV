using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTienCongDTO
{
    public class TienCongDTO
    {
        private int maTienCong;
        private string tenDichVu;
        private float tienCong;


        public int MaTienCong { get => maTienCong; set => maTienCong = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public float TienCong { get => tienCong; set => tienCong = value; }
    }
}
