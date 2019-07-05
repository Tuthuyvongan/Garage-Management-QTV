using TenHieuXeDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TenHieuXeDAO
{
    public class HieuXeDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public HieuXeDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(HieuXeDTO hx)
        {
            string query = string.Empty;
            query += "INSERT INTO [HieuXe] (hieuxe) ";
            query += "VALUES (@hieuxe)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@hieuxe", hx.HieuXe);
                    
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
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
            return true;
        }
        public bool xoa(HieuXeDTO hx)
        {
            string query = string.Empty;
            query += "DELETE FROM HieuXe WHERE [hieuxe] = @hieuxe"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@hieuxe", hx.HieuXe);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
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
            return true;
        }
        
        public List<HieuXeDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [hieuxe]";
            query += "FROM [HieuXe]";

            List<HieuXeDTO> lsHieuXe = new List<HieuXeDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HieuXeDTO hx = new HieuXeDTO();                               
                                hx.HieuXe = reader["hieuxe"].ToString();     
                               
                                lsHieuXe.Add(hx);
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
            return lsHieuXe;
        }
        public List<HieuXeDTO> selectTenHieuXe()
        {
            string query = string.Empty;
            query += "SELECT [hieuxe]";
            query += "FROM [HieuXe]";

            List<HieuXeDTO> lsTenHieuXe = new List<HieuXeDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HieuXeDTO hx = new HieuXeDTO();
                                hx.HieuXe = reader["hieuxe"].ToString();
                                lsTenHieuXe.Add(hx);
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
            return lsTenHieuXe;
        }
    }
}
