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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LapPhieuSuaChua f =new LapPhieuSuaChua();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDung f = new ThongTinNguoiDung();         
            f.ShowDialog();           
        }
    }
}
