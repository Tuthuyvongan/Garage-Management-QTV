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
    public partial class ThayDoiMatKhau : Form
    {
        public ThayDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguoiDungBUS ptBus = new NguoiDungBUS();
            NguoiDungDTO pt = new NguoiDungDTO();
            
            pt.TenDangNhap = textBox1.Text;
            pt.PassWord = textBox3.Text;           
            bool kq1 = ptBus.sua(pt);
            if (kq1 == false)
                MessageBox.Show("Sửa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
                MessageBox.Show("Sửa thông tin thành công");

            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }
    }
}
