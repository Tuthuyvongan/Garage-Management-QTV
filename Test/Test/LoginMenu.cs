using QLGR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGR
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo!",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserNam = textBox1.Text;
            string PassWord = textBox2.Text;
            if (Login(UserNam,PassWord))
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
        bool Login(string UserName, string PassWord)
        {
            return AccountDAO.Instance.Login(UserName, PassWord);
        }
    }
}
