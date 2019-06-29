using QLGR.DAO;
using QLGR.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLGR.BUS
{
    class ThuTienBUS
    {
        private ThuTienDAO ttDao;
        public ThuTienBUS()
        {
            ttDao = new ThuTienDAO();
        }
        public bool them(ThuTienDTO tt)
        {
            bool re = ttDao.them(tt);
            return re;
        }

        public bool xoa(ThuTienDTO tt )
        {
            bool re = ttDao.xoa(tt);
            return re;
        }

        public bool sua(ThuTienDTO tt)
        {
            bool re = ttDao.sua(tt);
            return re;
        }

        public List<ThuTienDTO> select()
        {
            return ttDao.select();
        }
    }
}
