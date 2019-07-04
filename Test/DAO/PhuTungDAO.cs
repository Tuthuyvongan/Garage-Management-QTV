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
        public List<PhuTungDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [tenphutung]";
            query += "FROM [PhuTung]";

            List<PhuTungDTO> lsPhuTung = new List<PhuTungDTO>();

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
                                lsPhuTung.Add(pt);
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
            return lsPhuTung;
        }
        public List<PhuTungDTO> select1(string sKeyword)
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
