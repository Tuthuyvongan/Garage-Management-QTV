using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapPhieuTiepNhanDTO
{
    public class TiepNhanDTO
    {
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string HT
        {
            get { return ht; }
            set { ht = value; }
        }

        public string Bienso
        {
            get { return bienso; }
            set { bienso = value; }
        }

        public string Ngaytiepnhan
        {
            get { return ngaytiepnhan; }
            set { ngaytiepnhan = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string HieuXe
        {
            get { return hieuxe; }
            set { hieuxe = value; }
        }
        public int MaTiepNhan
        {
            get { return matiepnhan; }
            set { matiepnhan = value; }
        }
        private int matiepnhan;
        private string sdt;
        private string ht;
        private string bienso;
        private string ngaytiepnhan;        
        private string hieuxe;
        private string diachi;
    }
}
