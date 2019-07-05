using LapPhieuThuTienDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LapPhieuThuTienDAO
{
    public class ThuTienDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public ThuTienDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(ThuTienDTO tt)
        {
            string query = string.Empty;
            query += "INSERT INTO [PhieuThuTien] (ht, bienso, sdt, ngaythutien, sotienthu, email, id)";
            query += "VALUES (@ht,@bienso,@sdt,@ngaythutien,@sotienthu,@email,@id)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ht", tt.HT);
                    cmd.Parameters.AddWithValue("@bienso", tt.Bienso);
                    cmd.Parameters.AddWithValue("@sdt", tt.Sdt);
                    cmd.Parameters.AddWithValue("@ngaythutien", tt.Ngaythutien);
                    cmd.Parameters.AddWithValue("@sotienthu", tt.Sotienthu);
                    cmd.Parameters.AddWithValue("@email", tt.Email);
                    cmd.Parameters.AddWithValue("@id", tt.ID);
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
        public bool xoa(ThuTienDTO tt)
        {
            string query = string.Empty;
            query += "DELETE FROM PhieuThuTien WHERE [id] = @id"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", tt.ID);
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
        public bool sua(ThuTienDTO tt)
        {
            string query = string.Empty;
            query += "UPDATE PhieuThuTien SET [ht] = @ht, [bienso] = @bienso, [sdt] = @sdt, [ngaythutien] = @ngaythutien, [sotienthu] = @sotienthu, [email] = @email WHERE [id] = @id";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ht", tt.HT);
                    cmd.Parameters.AddWithValue("@bienso", tt.Bienso);
                    cmd.Parameters.AddWithValue("@sdt", tt.Sdt);
                    cmd.Parameters.AddWithValue("@ngaythutien", tt.Ngaythutien);
                    cmd.Parameters.AddWithValue("@sotienthu", tt.Sotienthu);
                    cmd.Parameters.AddWithValue("@email", tt.Email);
                    cmd.Parameters.AddWithValue("@id", tt.ID);
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
        public List<ThuTienDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [ht], [bienso], [sdt], [ngaythutien], [sotienthu], [email], [id]";
            query += "FROM [PhieuThuTien]";

            List<ThuTienDTO> lsThuTien = new List<ThuTienDTO>();

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
                                ThuTienDTO tt = new ThuTienDTO();
                                tt.HT = reader["ht"].ToString();
                                tt.Bienso = reader["bienso"].ToString();
                                tt.Sdt = reader["sdt"].ToString();
                                tt.Ngaythutien = reader["ngaythutien"].ToString();
                                tt.Sotienthu = Decimal.Parse(reader["sotienthu"].ToString());
                                tt.Email = reader["email"].ToString();
                                tt.ID = int.Parse(reader["id"].ToString());
                                lsThuTien.Add(tt);
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
            return lsThuTien;
        }
    }
}
