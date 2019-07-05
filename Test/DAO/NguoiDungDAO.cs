using nguoidungDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguoidungDAO
{
    public class NguoiDungDAO
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public NguoiDungDAO()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(NguoiDungDTO nd)
        {
            string query = string.Empty;
            query += "INSERT INTO [NguoiDung] (TenDangNhap,TenHienThi,PassWord) ";
            query += "VALUES (@tendangnhap,@tenhienthi,@password)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tendangnhap", nd.TenDangNhap);
                    cmd.Parameters.AddWithValue("@tenhienthi", nd.TenHienThi);
                    cmd.Parameters.AddWithValue("@password", nd.PassWord);
                   
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
       
        public bool sua(NguoiDungDTO nd)
        {
            string query = string.Empty;
            query += "UPDATE NguoiDung SET [PassWord] = @password WHERE [TenDangNhap] = @tendangnhap";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tendangnhap", nd.TenDangNhap);
                    cmd.Parameters.AddWithValue("@password", nd.PassWord);
                   
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
     

        public List<NguoiDungDTO> select(string tendangnhap,string password)
        {
            string query = string.Empty;
            query += "SELECT *from [NguoiDung]";
            query += "where tendangnhap = '" + tendangnhap + "'and Password = '" + password + "'";




            List<NguoiDungDTO> listNguoidungDTO = new List<NguoiDungDTO>();

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
                                NguoiDungDTO nc = new NguoiDungDTO();
                              
                                nc.TenDangNhap = reader["TenDangNhap"].ToString();
                                nc.PassWord = reader["PassWord"].ToString();
                                listNguoidungDTO.Add(nc);
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
            return listNguoidungDTO;
        }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public bool kiemtra(NguoiDungDTO nd, string tendangnhap, string password)
        {
            string query = string.Empty;

            query += "SELECT (TenDangNhap),(PassWord) from [NguoiDung]";
            query += "where [TenDangNhap] = N'" + @tendangnhap + "'and [PassWord] = N'" + @password + "'";

            DataTable resuft = ExcuteQuery(query);
            return resuft.Rows.Count > 0;

            //using (SqlConnection con = new SqlConnection(ConnectionString))
            //{
                
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        object[] parameter = null;
            //        cmd.Connection = con;
            //        cmd.CommandType = System.Data.CommandType.Text;
            //        cmd.CommandText = query;
                   
            //        if (parameter != null)
            //        {
            //            string[] listPara = query.Split(' ');
            //            int i = 0;
            //            foreach (string item in listPara)
            //            {
            //                if (item.Contains('@'))
            //                {
            //                    cmd.Parameters.AddWithValue(item, parameter[i]);
            //                    i++;
            //                }
            //            }
            //        }
            //        //cmd.Parameters.AddWithValue("TenDangNhap", nd.TenDangNhap);                   
            //        //cmd.Parameters.AddWithValue("PassWord", nd.PassWord);

            //        try
            //        {
            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            con.Close();
            //            con.Dispose();
            //        }
            //        catch (Exception ex)
            //        {
            //            con.Close();
            //            Console.WriteLine(ex);
            //            throw;
            //        }
            //    }
            //}
            //return true;
        }
    }
    
}

