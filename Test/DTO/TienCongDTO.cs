using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenTienCongDTO
{
    public class TienCongDTO
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
        public int Matiencong
        {
            get { return matiencong; }
            set { matiencong = value; }
        }
        private int matiencong;
        private string tendichvu;
        private Decimal tiencong;
      
    }
}
