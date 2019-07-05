using TenTienCongDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenTienCongDAO
{
    public class TienCongDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public TienCongDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(TienCongDTO tc)
        {
            string query = string.Empty;
            query += "INSERT INTO [TienCong] (tendichvu,matiencong,tiencong)";
            query += "VALUES (@tendichvu,@matiencong,@tiencong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tendichvu", tc.Tendichvu);
                    cmd.Parameters.AddWithValue("@matiencong", tc.Matiencong);
                    cmd.Parameters.AddWithValue("@tiencong", tc.Tiencong);                   
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
        public bool xoa(TienCongDTO tc)
        {
            string query = string.Empty;
            query += "DELETE FROM TienCong WHERE [matiencong] = @matiencong"; 
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@matiencong", tc.Matiencong);
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
        public List<TienCongDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [tendichvu], [tiencong], [matiencong]";
            query += "FROM [TienCong]";

            List<TienCongDTO> lsTienCong = new List<TienCongDTO>();

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
                                TienCongDTO pt = new TienCongDTO();
                                pt.Tendichvu = reader["tendichvu"].ToString();
                                pt.Matiencong = int.Parse(reader["matiencong"].ToString());                                
                                pt.Tiencong = Decimal.Parse(reader["tiencong"].ToString());
                                lsTienCong.Add(pt);
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
            return lsTienCong;
        }
        public List<TienCongDTO> selecttendichvu()
        {
            string query = string.Empty;
            query += "SELECT [tendichvu]";
            query += "FROM [TienCong]";

            List<TienCongDTO> lstendichvu = new List<TienCongDTO>();

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
                                TienCongDTO pt = new TienCongDTO();
                                pt.Tendichvu = reader["tendichvu"].ToString();
                                lstendichvu.Add(pt);
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
            return lstendichvu;
        }
        public List<TienCongDTO> TimKiem(string Key)
        {
            string query = string.Empty;
            query += "SELECT [tendichvu], [tiencong], [matiencong]";
            query += "FROM [TienCong]";
            query += " WHERE ([tendichvu] LIKE CONCAT('%',@Key,'%'))";
            query += " OR ([matiencong] LIKE CONCAT('%',@Key,'%'))";
            query += " OR ([tiencong] LIKE CONCAT('%',@Key,'%'))";
            

            List<TienCongDTO> lsTimKiem = new List<TienCongDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Key", Key);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TienCongDTO pt = new TienCongDTO();
                                pt.Tendichvu = reader["tendichvu"].ToString();
                                pt.Matiencong = int.Parse(reader["matiencong"].ToString());                              
                                pt.Tiencong = Decimal.Parse(reader["tiencong"].ToString());
                                lsTimKiem.Add(pt);
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
            return lsTimKiem;
        }
        public List<TienCongDTO> selectgia(string sKey)
        {
            string query = string.Empty;
            query += "SELECT [tiencong]";
            query += "FROM [TienCong]";
            query += " WHERE ([tendichvu] LIKE CONCAT('%',@sKey,'%'))";

            List<TienCongDTO> lstiencong = new List<TienCongDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKey", sKey);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TienCongDTO pt = new TienCongDTO();
                                pt.Tiencong = Decimal.Parse(reader["tiencong"].ToString());
                                lstiencong.Add(pt);
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
            return lstiencong;
        }
    }
}
