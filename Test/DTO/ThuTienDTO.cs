using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class ThuTienDTO
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

        public string Ngaythutien
        {
            get { return ngaythutien; }
            set { ngaythutien = value; }
        }

        public Decimal Sotienthu
        {
            get { return sotienthu; }
            set { sotienthu = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int id;
        private string sdt;
        private string ht;
        private string bienso;
        private string ngaythutien;
        private Decimal sotienthu;
        private string email;
    }
}
