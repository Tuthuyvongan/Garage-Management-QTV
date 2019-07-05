using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapPhieuSuaChuaDTO
{
    public class SuaChuaDTO
    {
        public string Tendichvu
        {
            get { return tendichvu; }
            set { tendichvu = value; }
        }
        public Decimal Tiencong
        {
            get { return tiencong; }
            set { tiencong = value; }
        }
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
        public string Ngaysuachua
        {
            get { return ngaysuachua; }
            set { ngaysuachua = value; }
        }
        public string Bienso
        {
            get { return bienso; }
            set { bienso = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public Decimal Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        private Decimal thanhtien;
        private int soluong;
        private string bienso;
        private string ngaysuachua;
        private string tenphutung;
        private Decimal dongia;
        private string tendichvu;
        private Decimal tiencong;
    }
}
