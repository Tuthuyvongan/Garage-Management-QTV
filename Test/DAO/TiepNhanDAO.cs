using LapPhieuTiepNhanDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapPhieuTiepNhanDAO
{
    public class TiepNhanDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public TiepNhanDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(TiepNhanDTO tn)
        {
            string query = string.Empty;
            query += "INSERT INTO [PhieuTiepNhan] (ht, bienso, sdt, ngaytiepnhan, diachi, hieuxe, matiepnhan)";
            query += "VALUES (@ht,@bienso,@sdt,@ngaytiepnhan,@diachi,@hieuxe,@matiepnhan)";           
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ht", tn.HT);
                    cmd.Parameters.AddWithValue("@bienso", tn.Bienso);
                    cmd.Parameters.AddWithValue("@sdt", tn.Sdt);
                    cmd.Parameters.AddWithValue("@ngaytiepnhan", tn.Ngaytiepnhan);
                    cmd.Parameters.AddWithValue("@diachi", tn.DiaChi);
                    cmd.Parameters.AddWithValue("@hieuxe", tn.HieuXe);
                    cmd.Parameters.AddWithValue("@matiepnhan", tn.MaTiepNhan);
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
        public bool xoa(TiepNhanDTO tn)
        {
            string query = string.Empty;
            query += "DELETE FROM PhieuTiepNhan WHERE [matiepnhan] = @matiepnhan";            
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@matiepnhan", tn.MaTiepNhan);
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
        public bool sua(TiepNhanDTO tn)
        {
            string query = string.Empty;
            query += "UPDATE PhieuTiepNhan SET [ht] = @ht, [bienso] = @bienso, [sdt] = @sdt, [ngaytiepnhan] = @ngaytiepnhan, [diachi] = @diachi, [hieuxe] = @hieuxe WHERE [matiepnhan] = @matiepnhan";           
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ht", tn.HT);
                    cmd.Parameters.AddWithValue("@bienso", tn.Bienso);
                    cmd.Parameters.AddWithValue("@sdt", tn.Sdt);
                    cmd.Parameters.AddWithValue("@ngaytiepnhan", tn.Ngaytiepnhan);
                    cmd.Parameters.AddWithValue("@diachi", tn.DiaChi);
                    cmd.Parameters.AddWithValue("@hieuxe", tn.HieuXe);
                    cmd.Parameters.AddWithValue("@matiepnhan", tn.MaTiepNhan);
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
        public List<TiepNhanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [ht], [bienso], [sdt], [ngaytiepnhan], [diachi], [hieuxe], [matiepnhan]";
            query += "FROM [PhieuTiepNhan]";            

            List<TiepNhanDTO> lsTiepNhan = new List<TiepNhanDTO>();

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
                                TiepNhanDTO tn = new TiepNhanDTO();
                                tn.HT = reader["ht"].ToString();
                                tn.Bienso = reader["bienso"].ToString();
                                tn.Sdt = reader["sdt"].ToString();
                                tn.Ngaytiepnhan = reader["ngaytiepnhan"].ToString();
                                tn.DiaChi= reader["diachi"].ToString();
                                tn.HieuXe = reader["hieuxe"].ToString();
                                tn.MaTiepNhan = int.Parse(reader["matiepnhan"].ToString());
                                lsTiepNhan.Add(tn);
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
            return lsTiepNhan;
        }
        public List<TiepNhanDTO> selectBS()
        {
            string query = string.Empty;
            query += "SELECT [bienso]";
            query += "FROM [PhieuTiepNhan]";

            List<TiepNhanDTO> IsBienSo = new List<TiepNhanDTO>();

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
                                TiepNhanDTO tn = new TiepNhanDTO();                               
                                tn.Bienso = reader["bienso"].ToString();                              
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
