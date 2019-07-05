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
    public partial class ManHinhDangNhap : Form
    {
        public ManHinhDangNhap()
        {
            InitializeComponent();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManHinhDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
       
        private void buttondangnhap_Click(object sender, EventArgs e)
        {
            NguoiDungBUS ndBUS = new NguoiDungBUS();

            NguoiDungDTO tn = new NguoiDungDTO();
            string tendangnhap = textBoxuser.Text;
            string password = textBoxpass.Text;


            if (ndBUS.kiemtra(tn,tendangnhap, password))
            {
                MainMenu f = new MainMenu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
    }
}

