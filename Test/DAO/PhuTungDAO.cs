using TenPhuTungDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TenPhuTungDAO
{
    public class PhuTungDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public PhuTungDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(PhuTungDTO pt)
        {
            string query = string.Empty;
            query += "INSERT INTO [PhuTung] (tenphutung,maphutung,dongia,tondau,toncuoi) ";
            query += "VALUES (@tenphutung,@maphutung,@dongia,@tondau,@toncuoi)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenphutung", pt.Tenphutung);
                    cmd.Parameters.AddWithValue("@maphutung", pt.Maphutung);
                    cmd.Parameters.AddWithValue("@dongia", pt.Dongia);
                    cmd.Parameters.AddWithValue("@tondau", pt.Tondau);
                    cmd.Parameters.AddWithValue("@toncuoi", pt.Toncuoi);
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
        public bool xoa(PhuTungDTO pt)
        {
            string query = string.Empty;
            query += "DELETE FROM PhuTung WHERE [maphutung] = @maphutung"; ;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maphutung", pt.Maphutung);
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
        public bool sua(PhuTungDTO pt)
        {
            string query = string.Empty;
            query += "UPDATE PhuTung SET [tenphutung] = @tenphutung, [dongia] = @dongia, [tondau] = @tondau, [toncuoi] = @toncuoi  WHERE [maphutung] = @maphutung";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenphutung", pt.Tenphutung);
                    cmd.Parameters.AddWithValue("@maphutung", pt.Maphutung);
                    cmd.Parameters.AddWithValue("@dongia", pt.Dongia);
                    cmd.Parameters.AddWithValue("@tondau", pt.Tondau);
                    cmd.Parameters.AddWithValue("@toncuoi", pt.Toncuoi);
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
        public List<PhuTungDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [tenphutung], [dongia], [tondau], [toncuoi], [maphutung]";
            query += "FROM [PhuTung]";

            List<PhuTungDTO> lsTenPhuTung = new List<PhuTungDTO>();

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
                                PhuTungDTO pt = new PhuTungDTO();
                                pt.Tenphutung = reader["tenphutung"].ToString();
                                pt.Maphutung = int.Parse(reader["maphutung"].ToString());
                                pt.Toncuoi = int.Parse(reader["toncuoi"].ToString());
                                pt.Tondau = int.Parse(reader["tondau"].ToString());
                                pt.Dongia = Decimal.Parse(reader["dongia"].ToString());
                                lsTenPhuTung.Add(pt);
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
            return lsTenPhuTung;
        }
        public List<PhuTungDTO> selectTenPhuTung()
        {
            string query = string.Empty;
            query += "SELECT [tenphutung]";
            query += "FROM [PhuTung]";

            List<PhuTungDTO> lsTenPhuTung = new List<PhuTungDTO>();

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
                                PhuTungDTO pt = new PhuTungDTO();
                                pt.Tenphutung = reader["tenphutung"].ToString();
                                lsTenPhuTung.Add(pt);
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
            return lsTenPhuTung;
        }
        public List<PhuTungDTO> TimKiem(string Keyword)
        {
            string query = string.Empty;
            query += "SELECT [tenphutung], [dongia], [tondau], [toncuoi], [maphutung]";
            query += "FROM [PhuTung]";
            query += " WHERE ([tenphutung] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([maphutung] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([dongia] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([tondau] LIKE CONCAT('%',@Keyword,'%'))";
            query += " OR ([toncuoi] LIKE CONCAT('%',@Keyword,'%'))";

            List<PhuTungDTO> lsTimKiem = new List<PhuTungDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Keyword", Keyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                PhuTungDTO pt = new PhuTungDTO();
                                pt.Tenphutung = reader["tenphutung"].ToString();
                                pt.Maphutung = int.Parse(reader["maphutung"].ToString());
                                pt.Toncuoi = int.Parse(reader["toncuoi"].ToString());
                                pt.Tondau = int.Parse(reader["tondau"].ToString());
                                pt.Dongia = Decimal.Parse(reader["dongia"].ToString());
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
        public List<PhuTungDTO> selectgia(string sKeyword)
        {
            string query = string.Empty;            
            query += "SELECT [dongia]";
            query += "FROM [PhuTung]";
            query += " WHERE ([tenphutung] LIKE CONCAT('%',@sKeyword,'%'))";

            List<PhuTungDTO> lsDonGia = new List<PhuTungDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                PhuTungDTO pt = new PhuTungDTO();
                                pt.Dongia = Decimal.Parse(reader["dongia"].ToString());
                                lsDonGia.Add(pt);
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
            return lsDonGia;
        }
    }
}
