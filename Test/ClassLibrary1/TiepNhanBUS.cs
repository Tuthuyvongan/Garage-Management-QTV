using LapPhieuTiepNhanDAO;
using LapPhieuTiepNhanDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LapPhieuTiepNhanBUS
{
    public class TiepNhanBUS
    {
        private TiepNhanDAO tnDAO;
        public TiepNhanBUS()
        {
            tnDAO = new TiepNhanDAO();
        }
        public bool them(TiepNhanDTO tn)
        {
            bool re = tnDAO.them(tn);
            return re;
        }

        public bool xoa(TiepNhanDTO tn)
        {
            bool re = tnDAO.xoa(tn);
            return re;
        }

        public bool sua(TiepNhanDTO tn)
        {
            bool re = tnDAO.sua(tn);
            return re;
        }

        public List<TiepNhanDTO> select()
        {
            return tnDAO.select();
        }
    }
}