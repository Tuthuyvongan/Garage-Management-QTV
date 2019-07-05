using KTDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KTDAO
{
    public class DemDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DemDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DemDTO> Demngay(string ngay)
        {
            string query = string.Empty;
            query += "SELECT count(DAY(ngaytiepnhan))";
            query += "FROM [PhieuTiepNhan]";
            query += "WHERE DAY(ngaytiepnhan) = @ngay";
            query += "Group by DAY(ngaytiepnhan)";

            List<DemDTO> IsBienSo = new List<DemDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ngay", ngay);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DemDTO tn = new DemDTO();
                                tn.Ngay = reader["ngay"].ToString();
                                IsBienSo.Add(tn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        Console.WriteLine(ex);
                        throw;
                    }
                }
            }
            return IsBienSo;
        }
    }
}
