using GetTienCongDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
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
                query += "INSERT INTO [TienCong] (matiencong,tendichvu,tiencong) ";
                query += "VALUES (@matiencong,@tendichvu,@tiencong)";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@matiencong", tc.MaTienCong);
                        cmd.Parameters.AddWithValue("@tendichvu", tc.TenDichVu);
                       cmd.Parameters.AddWithValue("@tiencong", tc.TienCong);

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
                query += "DELETE FROM TienCong WHERE [matiencong] = @matiencong"; ;
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@matiencong", tc.MaTienCong);
                    
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
                query += "SELECT *from TienCong";
              

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
                                TienCongDTO tc = new TienCongDTO();
                                tc.MaTienCong = int.Parse(reader["matiencong"].ToString());
                                tc.TenDichVu = reader["tendichvu"].ToString();
                                tc.TienCong = float.Parse(reader["tiencong"].ToString());
                                lsTienCong.Add(tc);
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
            
        }

}
