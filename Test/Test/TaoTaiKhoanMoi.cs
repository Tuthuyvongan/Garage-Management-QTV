using TenTienCongBUS;
using nguoidungBUS;
using nguoidungDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class TaoTaiKhoanMoi : Form
    {
        public TaoTaiKhoanMoi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguoiDungBUS tcBus = new NguoiDungBUS();
            NguoiDungDTO tc = new NguoiDungDTO();
            tc.TenDangNhap = textBox1.Text;
            tc.TenHienThi = textBox2.Text;
            tc.PassWord = textBox3.Text;
            bool kq = tcBus.them(tc);
            if (kq == false)
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Thêm tài khoản thành công");            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
