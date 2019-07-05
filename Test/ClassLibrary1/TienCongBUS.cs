using TenTienCongDTO;
using TenTienCongDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenTienCongBUS
{
    public class TienCongBUS
    {
        private TienCongDAO tcDao;
        public TienCongBUS()
        {
            tcDao = new TienCongDAO();
        }
        public bool them(TienCongDTO tc)
        {
            bool re = tcDao.them(tc);
            return re;
        }

        public bool xoa(TienCongDTO tc)
        {
            bool re = tcDao.xoa(tc);
            return re;
        }
        public List<TienCongDTO> select()
        {
            return tcDao.select();
        }
        public List<TienCongDTO> selecttendichvu()
        {
            return tcDao.selecttendichvu();
        }
        public List<TienCongDTO> TimKiem(string Keyword)
        {
            return tcDao.TimKiem(Keyword);
        }
        public List<TienCongDTO> selectgia(string sKeyword)
        {
            return tcDao.selectgia(sKeyword);
        }
    }
}
