using TenPhuTungBUS;
using TenPhuTungDTO;
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
using System.Configuration;
using System.IO;

namespace Test
{
    public partial class LapPhieuSuaChua : Form
    {
        public LapPhieuSuaChua()
        {
            InitializeComponent();
        }
        private PhuTungBUS ptBus;
        private void loadData_Vao_lbDonGia(List<PhuTungDTO> ListDonGia)
        {
            

            if (ListDonGia == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            
            lbPhuTung.DataSource = null;            
            lbPhuTung.DataSource = ListDonGia;
            lbPhuTung.ValueMember = "dongia";
            lbPhuTung.DisplayMember = "dongia";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[lbPhuTung.DataSource];
            myCurrencyManager.Refresh();
           

        }
        private void LapPhieuSuaChua_Load(object sender, EventArgs e)
        {            
            PhuTungDTO pt = new PhuTungDTO();
            ptBus = new PhuTungBUS();
            List<PhuTungDTO> ListPhuTung = ptBus.select();
            if (ListPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ table PhuTung");
                return;
            }
            cbPhuTung.DataSource = ListPhuTung;
        }

        private void btLayGia_Click(object sender, EventArgs e)
        {
            string sKeyword = cbPhuTung.Text.Trim();
            List<PhuTungDTO> ListDonGia = ptBus.selectgia(sKeyword);           
            this.loadData_Vao_lbDonGia(ListDonGia);            
        }
    }
}
