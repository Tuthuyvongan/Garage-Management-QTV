using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGR.DAO
{
    class SuaChua
    {
        public SuaChua(int id, string bienso, string datecheckin, string noidung, string tenphutung, int soluong, float tiencong)
        {
            this.Id = id;
            this.Bienso = bienso;
            this.Datecheckin = datecheckin;
            this.Noidung = noidung;
            this.Tenphutung = tenphutung;
            this.Soluong = soluong;
            this.Tiencong = tiencong;
        }

        public SuaChua(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Bienso = row["bienso"].ToString();
            this.Datecheckin = row["datecheckin"].ToString();
            this.Noidung = row["noidung"].ToString();
            this.Tenphutung = row["tenphutung"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Tiencong = (float)Convert.ToDouble(row["tiencong"].ToString());
        }


        public int Id { get => id; set => id = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public string Datecheckin { get => datecheckin; set => datecheckin = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Tenphutung { get => tenphutung; set => tenphutung = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Tiencong { get => tiencong; set => tiencong = value; }

        private int id;
        private string bienso;
        private string datecheckin;
        private string noidung;
        private string tenphutung;
        private int soluong;
        private float tiencong;
    }
}
