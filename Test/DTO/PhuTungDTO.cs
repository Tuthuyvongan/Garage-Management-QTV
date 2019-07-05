using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPhuTungDTO
{
    public class PhuTungDTO
    {
        public string Tenphutung
        {
            get { return tenphutung; }
            set { tenphutung = value; }
        }
        public Decimal Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }        
        public int Tondau
        {
            get { return tondau; }
            set { tondau = value; }
        }
        public int Toncuoi
        {
            get { return toncuoi; }
            set { toncuoi = value; }
        }
        public int Maphutung
        {
            get { return maphutung; }
            set { maphutung = value; }
        }
        private int maphutung;        
        private string tenphutung;
        private Decimal dongia;
        private int toncuoi;
        private int tondau;
    }
}
