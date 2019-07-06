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

        private void lậpPhiếuTiếpNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuTiepNhan f = new LapPhieuTiepNhan();
            f.ShowDialog();
        }

        private void lậpPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuThuTien f = new LapPhieuThuTien();
            f.ShowDialog();
        }

        private void lậpPhiếuSủaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuSuaChua f = new LapPhieuSuaChua();
            f.ShowDialog();
        }

        private void thayĐổiThôngTinHiệuXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHieuXe f = new QuanLyHieuXe();
            f.ShowDialog();
        }

        private void thayĐổiThôngTinPhụTùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhuTung f = new QuanLyPhuTung();
            f.ShowDialog();
        }

        private void thayĐổiThôngTinTiềnCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTienCong f = new QuanLyTienCong();
            f.ShowDialog();
        }
    }
}
