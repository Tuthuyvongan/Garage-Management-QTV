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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void tạoTàiKhoảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoTaiKhoanMoi f = new TaoTaiKhoanMoi();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau f = new ThayDoiMatKhau();
            f.ShowDialog();
        }
    }
}
