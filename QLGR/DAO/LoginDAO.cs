using QLGR.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGR.LoginDAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string UserName, string PassWord)
        {
            string query = "SELECT *FROM dbo.NguoiDung where tendangnhap like  N'" + UserName + "' and password like N'" + PassWord +"'  ";
            DataTable resuft = DataProvider.Instance.ExcuteQuery(query);
            return resuft.Rows.Count>0;
        }
    }
}