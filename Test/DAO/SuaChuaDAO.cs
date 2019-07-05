using LapPhieuSuaChuaDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapPhieuSuaChuaDAO
{
    public class SuaChuaDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public SuaChuaDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(SuaChuaDTO sc)
        {
            string query = string.Empty;
            query += "INSERT INTO [PhieuSuaChua] (tendichvu, bienso, tiencong, ngaysuachua, tenphutung, dongia, soluong,thanhtien)";
            query += "VALUES (@tendichvu,@bienso,@tiencong,@ngaysuachua,@tenphutung,@dongia,@soluong,@thanhtien)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tendichvu", sc.Tendichvu);
                    cmd.Parameters.AddWithValue("@bienso", sc.Bienso);
                    cmd.Parameters.AddWithValue("@tiencong", sc.Tiencong);
                    cmd.Parameters.AddWithValue("@ngaysuachua", sc.Ngaysuachua);
                    cmd.Parameters.AddWithValue("@tenphutung", sc.Tenphutung);
                    cmd.Parameters.AddWithValue("@dongia", sc.Dongia);
                    cmd.Parameters.AddWithValue("@soluong", sc.Soluong);
                    cmd.Parameters.AddWithValue("@thanhtien", sc.Thanhtien);
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
        public bool xoa(SuaChuaDTO sc)
        {
            string query = string.Empty;
            query += "DELETE FROM PhieuSuaChua WHERE [bienso] = @bienso";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@bienso", sc.Bienso);
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
       
        public List<SuaChuaDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [tendichvu], [bienso], [tiencong], [ngaysuachua], [tenphutung], [dongia], [soluong], [thanhtien]";
            query += "FROM [PhieuSuaChua]";

            List<SuaChuaDTO> IsSuaChua = new List<SuaChuaDTO>();

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
                                SuaChuaDTO sc = new SuaChuaDTO();
                                sc.Tendichvu = reader["tendichvu"].ToString();
                                sc.Bienso = reader["bienso"].ToString();
                                sc.Tiencong = Decimal.Parse(reader["tiencong"].ToString());
                                sc.Ngaysuachua = reader["ngaysuachua"].ToString();
                                sc.Tenphutung = reader["tenphutung"].ToString();
                                sc.Dongia = Decimal.Parse(reader["dongia"].ToString());
                                sc.Soluong = int.Parse(reader["soluong"].ToString());
                                sc.Thanhtien= Decimal.Parse(reader["thanhtien"].ToString());
                                IsSuaChua.Add(sc);
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
            return IsSuaChua;
        }
        public List<SuaChuaDTO> Find(string K)
        {
            string query = string.Empty;
            query += "SELECT [tendichvu], [bienso], [tiencong], [ngaysuachua], [tenphutung], [dongia], [soluong], [thanhtien]";
            query += "FROM [PhieuSuaChua]";
            query += " WHERE ([bienso] LIKE CONCAT('%',@K,'%'))";                  

            List<SuaChuaDTO> IsFind = new List<SuaChuaDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@K", K);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                SuaChuaDTO sc = new SuaChuaDTO();
                                sc.Tendichvu = reader["tendichvu"].ToString();
                                sc.Bienso = reader["bienso"].ToString();
                                sc.Tiencong = Decimal.Parse(reader["tiencong"].ToString());
                                sc.Ngaysuachua = reader["ngaysuachua"].ToString();
                                sc.Tenphutung = reader["tenphutung"].ToString();
                                sc.Dongia = Decimal.Parse(reader["dongia"].ToString());
                                sc.Soluong = int.Parse(reader["soluong"].ToString());
                                sc.Thanhtien = Decimal.Parse(reader["thanhtien"].ToString());
                                IsFind.Add(sc);
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
            return IsFind;
        }
    }
}
