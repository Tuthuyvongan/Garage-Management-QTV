using TenHieuXeDAO;
using TenHieuXeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenHieuXeBUS
{
    public class HieuXeBUS
    {
        private HieuXeDAO hxDao;
        public HieuXeBUS()
        {
            hxDao = new HieuXeDAO();
        }
        public bool them(HieuXeDTO hx)
        {
            bool re = hxDao.them(hx);
            return re;
        }

        public bool xoa(HieuXeDTO hx)
        {
            bool re = hxDao.xoa(hx);
            return re;
        }

        public bool sua(HieuXeDTO hx)
        {
            bool re = hxDao.sua(hx);
            return re;
        }

        public List<HieuXeDTO> select()
        {
            return hxDao.select();
        }
        public List<HieuXeDTO> selectTenHieuXe()
        {
            return hxDao.selectTenHieuXe();
        }
    }
}
