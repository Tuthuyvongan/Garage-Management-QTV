using nguoidungDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nguoidungDAO;

namespace nguoidungBUS
{

    public class NguoiDungBUS
    {
        private NguoiDungDAO tnDAO;
        public NguoiDungBUS()
        {
            tnDAO = new NguoiDungDAO();
        }
        public bool them(NguoiDungDTO tn)
        {
            bool re = tnDAO.them(tn);
            return re;
        }

        public bool sua(NguoiDungDTO tn)
        {
            bool re = tnDAO.sua(tn);
            return re;
        }

        //public List<NguoiDungDTO> select(string tendangnhap,string password)
        //    {
        //        return tnDAO.select(tendangnhap,password);
        //    }
        //}
        public bool kiemtra(NguoiDungDTO tn, string tendangnhap, string password)
        {
            bool re = tnDAO.kiemtra(tn, tendangnhap, password);
            return re;
        }
    }
}
