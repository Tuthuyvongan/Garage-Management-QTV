using KTDAO;
using KTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTBUS
{
    public class DemBUS
    {
        private DemDAO dDao;
        public DemBUS()
        {
            dDao = new DemDAO();
        }
        public List<DemDTO> Demngay(string ngay)
        {
            return dDao.Demngay(ngay);
        }
    }
}
