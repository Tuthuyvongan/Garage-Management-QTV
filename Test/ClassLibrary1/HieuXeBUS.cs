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
        
        public List<HieuXeDTO> select()
        {
            return hxDao.select();
        }
    }
}
