using TenPhuTungDAO;
using TenPhuTungDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPhuTungBUS
{
    public class PhuTungBUS
    {
        private PhuTungDAO ptDao;      
        public PhuTungBUS()
        {
            ptDao = new PhuTungDAO();
        }
        public bool them(PhuTungDTO pt)
        {
            bool re = ptDao.them(pt);
            return re;
        }

        public bool xoa(PhuTungDTO pt)
        {
            bool re = ptDao.xoa(pt);
            return re;
        }

        public bool sua(PhuTungDTO pt)
        {
            bool re = ptDao.sua(pt);
            return re;
        }

        public List<PhuTungDTO> select()
        {
            return ptDao.select();
        }      
        public List<PhuTungDTO> selectTenPhuTung()
        {
            return ptDao.selectTenPhuTung();
        }
        public List<PhuTungDTO> TimKiem(string Keyword)
        {
            return ptDao.TimKiem(Keyword);
        }
        public List<PhuTungDTO> selectgia(string sKeyword)
        {
            return ptDao.selectgia(sKeyword);
        }
    }
}
