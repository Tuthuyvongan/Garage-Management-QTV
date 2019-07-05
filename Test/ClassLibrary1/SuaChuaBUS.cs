using LapPhieuSuaChuaDTO;
using LapPhieuSuaChuaDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapPhieuSuaChuaBUS
{
    public class SuaChuaBUS
    {

        private SuaChuaDAO scDAO;
        public SuaChuaBUS()
        {
            scDAO = new SuaChuaDAO();
        }
        public bool them(SuaChuaDTO sc)
        {
            bool re = scDAO.them(sc);
            return re;
        }

        public bool xoa(SuaChuaDTO sc)
        {
            bool re = scDAO.xoa(sc);
            return re;
        }

        public bool sua(SuaChuaDTO sc)
        {
            bool re = scDAO.sua(sc);
            return re;
        }

        public List<SuaChuaDTO> select()
        {
            return scDAO.select();
        }
        public List<SuaChuaDTO> Find(string K)
        {
            return scDAO.Find(K);
        }
    }
}
