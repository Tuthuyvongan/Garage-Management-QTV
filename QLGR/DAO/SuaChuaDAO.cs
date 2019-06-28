using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGR.DAO
{
    class SuaChuaDAO
    {
        private static SuaChuaDAO instance;

        internal static SuaChuaDAO Instance
        {
            get { if (instance == null) instance = new SuaChuaDAO(); return SuaChuaDAO.instance; }
            private set { SuaChuaDAO.instance = value; }
        }
        
    }
}
