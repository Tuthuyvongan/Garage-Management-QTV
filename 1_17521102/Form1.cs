using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace _1_17521102
{
    public partial class Form1 : Form
    {
        public static string chuoiketnoi = @"Data Source=DESKTOP-7UNO2O7\SQLEXPRESS;Initial Catalog=Khachhang;Integrated Security=True";
        public static SqlConnection cnn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public static void openketnoi()
        {
            cnn = new SqlConnection(chuoiketnoi);
            cnn.Open();
        }
        public static void dongketnoi()
        {
            cnn.Close();
        }
        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public Form1()
        {
            InitializeComponent();
        }

        public int n;
        public void btThem_Click(object sender, EventArgs e)
        {
            n = 0;
            txtHT.ReadOnly = false;
            txtĐc.ReadOnly = false;
            txtSđt.ReadOnly = false;
            txtEmail.ReadOnly = false;
            dataKhachhang.AllowUserToAddRows = true;
            txtHT.Text = "";
            txtĐc.Text = "";
            rNam.Checked = false;
            rNu.Checked = false;
            txtSđt.Text = "";
            txtEmail.Text = "";
            btLuu.Visible = true;
            btThem.Visible = false;
            btSua.Visible = false;
            btXoa.Visible = false;
        }
        public void FilldataKhachhang()
        {
           
            string select = "Select * from Khachhang  ";
            SqlCommand cmd = new SqlCommand(select, cnn);

           
            DataSet ds = new DataSet();

           
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

         
            adapter.Fill(ds, "Khachhang");

            
            dataKhachhang.DataSource = ds;
            dataKhachhang.DataMember = "Khachhang";
            cmd.Dispose();
        }

        public void btSua_Click(object sender, EventArgs e)
        {
            n = 1;
            txtHT.ReadOnly = false;
            txtĐc.ReadOnly = false;
            txtSđt.ReadOnly = false;
            txtEmail.ReadOnly = false;
            btLuu.Visible = true;
            btThem.Visible = false;
            btXoa.Visible = false;
            btSua.Visible = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtHT.ReadOnly = false;
            txtĐc.ReadOnly = false;
            txtSđt.ReadOnly = false;
            txtEmail.ReadOnly = false;
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                txtHT.ReadOnly = false;
                txtĐc.ReadOnly = false;
                txtSđt.ReadOnly = false;
                txtEmail.ReadOnly = false;
                SqlCommand cmd = new SqlCommand("delete from Khachhang where Sdt='" + txtSđt.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                
                cmd.Dispose();
               
                FilldataKhachhang();
            }
            else
            {
                txtHT.ReadOnly = true;
                txtĐc.ReadOnly = true;
                txtSđt.ReadOnly = true;
                txtEmail.ReadOnly = true;
            }
        }

        private void dataKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataKhachhang.CurrentCell.RowIndex;
            txtHT.Text = dataKhachhang.Rows[t].Cells[0].Value.ToString();
            txtĐc.Text = dataKhachhang.Rows[t].Cells[1].Value.ToString();
            dtNS.Text = dataKhachhang.Rows[t].Cells[2].Value.ToString();
            txtSđt.Text = dataKhachhang.Rows[t].Cells[4].Value.ToString();
            txtEmail.Text = dataKhachhang.Rows[t].Cells[5].Value.ToString();

            if (dataKhachhang.Rows[t].Cells[3].Value.ToString() == "Nam") 
            {
                rNam.Checked = true;
            }
            else if (dataKhachhang.Rows[t].Cells[3].Value.ToString() == "Nữ")
            {
                rNu.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHT.ReadOnly = true;
            txtĐc.ReadOnly = true;
            txtSđt.ReadOnly = true;
            txtEmail.ReadOnly = true;
            openketnoi();
            FilldataKhachhang();
        }
        
        public void btLuu_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                string email = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                Regex reg = new Regex(email);
                bool match = reg.IsMatch(this.txtEmail.Text);
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                if (txtHT.Text == "")
                {
                    errorProvider1.SetError(txtHT, "Tên khách hàng không được để trống!");
                }
                else if (txtĐc.Text == "")
                {
                    errorProvider2.SetError(txtĐc, "Địa chỉ không để trống!");
                }
                else if (rNam.Checked == false && rNu.Checked == false)
                {
                    errorProvider4.SetError(rNu, "Giới tính không được để trống!");
                }
                else if (txtSđt.Text == "")
                {
                    errorProvider5.SetError(txtSđt, "Số điện thoại không được để trống!");
                }
                else if (txtSđt.Text.Length > 11 || txtSđt.Text.Length < 9)
                {
                    errorProvider5.SetError(txtSđt, "Số điện thoại không hợp lệ!");
                }
                else if (txtEmail.Text == "")
                {
                    errorProvider6.SetError(txtEmail, "Email không được để trống!");
                }
                else if (match == false)
                {
                    errorProvider6.SetError(txtEmail, "Email có định dạng sai");
                }
                else
                {
                    string insert = "";
                    if (rNam.Checked == true)
                    {
                        insert = "Insert Into Khachhang(TenKH,Đc,Ngaysinh,Gioitinh,Sdt,Email)" +
                                 "Values(N'" + txtHT.Text + "',N'" + txtĐc.Text + "','" +
                                 dtNS.Text +
                                 "','" +
                                 rNam.Text + "','" + txtSđt.Text + "','" +
                                 txtEmail.Text + "')";
                    }
                    else if (rNu.Checked == true)
                    {
                        insert = "Insert Into Khachhang(TenKH,Đc,Ngaysinh,Gioitinh,Sdt,Email)" +
                                 "Values(N'" + txtHT.Text + "',N'" + txtĐc.Text + "','" +
                                 dtNS.Text +"',N'"+
                                 rNu.Text + "','" + txtSđt.Text + "','" +
                                 txtEmail.Text + "')";
                    }
                    try
                    {
                        SqlCommand cmd = new SqlCommand(insert, cnn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                    finally
                    {
                        if (cmd != null)
                        {
                            cmd.Dispose();
                        }
                    }


                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");

                    FilldataKhachhang();
                    btSua.Visible = true;
                    btXoa.Visible = true;
                    btThem.Visible = true;
                    btLuu.Visible = false;
                    txtHT.ReadOnly = true;
                    txtĐc.ReadOnly = true;
                    txtSđt.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                }
            }
            else
            {
                string email = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                Regex reg = new Regex(email);
                bool match = reg.IsMatch(this.txtEmail.Text);
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                if (txtHT.Text == "")
                {
                    errorProvider1.SetError(txtHT, "Tên khách hàng không được để trống!");
                }
                else if (txtĐc.Text == "")
                {
                    errorProvider2.SetError(txtĐc, "Địa chỉ không để trống!");
                }
                else if (rNam.Checked == false && rNu.Checked == false )
                {
                    errorProvider4.SetError(rNu, "Giới tính không được để trống!");
                }
                else if (txtSđt.Text == "")
                {
                    errorProvider5.SetError(txtSđt, "Số điện thoại không được để trống!");
                }
                else if (txtSđt.Text.Length > 11 || txtSđt.Text.Length < 9)
                {
                    errorProvider5.SetError(txtSđt, "Số điện thoại không hợp lệ!");
                }
                else if (txtEmail.Text == "")
                {
                    errorProvider6.SetError(txtEmail, "Email không được để trống!");
                }
                else if (match == false)
                {
                    errorProvider6.SetError(txtEmail, "Email có định dạng sai");
                }
                else
                {

                    string update = "";
                    if (rNam.Checked == true)
                    {
                        update = "Update Khachhang Set TenKH=N'" + txtHT.Text + "',Đc=N'" +
                                 txtĐc.Text + "',NgaySinh='" +
                                 dtNS.Text + "',GioiTinh=N'" + rNam.Text +
                                 "',Sdt='" + txtSđt.Text + "',email='" + txtEmail.Text + "'where Sdt='" + txtSđt.Text + "'";
                    }
                    else if (rNu.Checked == true)
                    {
                        update = "Update Khachhang Set TenKH=N'" + txtHT.Text + "',Đc=N'" +
                                txtĐc.Text + "',NgaySinh='" +
                                dtNS.Text + "',GioiTinh=N'" + rNu.Text +
                                "',Sdt='" + txtSđt.Text + "',email='" + txtEmail.Text + "'where Sdt='" + txtSđt.Text + "'";
                    }
                    try
                    {
                        SqlCommand cmd = new SqlCommand(update, cnn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                    finally
                    {
                        if (cmd != null)
                        {
                            cmd.Dispose();
                        }
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");

                    FilldataKhachhang();
                    btSua.Visible = true;
                    btXoa.Visible = true;
                    btThem.Visible = true;
                    btLuu.Visible = false;
                    txtHT.ReadOnly = true;
                    txtĐc.ReadOnly = true;
                    txtSđt.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                }
            }
        }
        
        private void txtSđt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            int ma_phim_nhap_vao = e.KeyChar;
            if (ma_phim_nhap_vao > 57 || (ma_phim_nhap_vao < 48 && ma_phim_nhap_vao >9 && ma_phim_nhap_vao < 7))
            {
                errorProvider5.SetError(txtSđt, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            txtHT.Text = textInfo.ToTitleCase(txtHT.Text);
            txtHT.SelectionStart = txtHT.Text.Length;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Form2 frm2 = new Form2();
                frm2.Visible = true;
            }
        }
    }
}
