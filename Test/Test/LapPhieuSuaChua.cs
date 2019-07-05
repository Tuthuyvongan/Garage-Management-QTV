using TenPhuTungBUS;
using TenPhuTungDTO;
using TenTienCongBUS;
using TenTienCongDTO;
using LapPhieuTiepNhanBUS;
using LapPhieuTiepNhanDTO;
using LapPhieuSuaChuaBUS;
using LapPhieuSuaChuaDTO;
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
        private TienCongBUS tcBus;
        private TiepNhanBUS tnBus;
        private SuaChuaBUS scBus;
        Decimal thtien = 0;
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
        private void loadData_Vao_cbGTC(List<TienCongDTO> ListTienCong)
        {

            if (ListTienCong == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }

            cbGTC.DataSource = null;
            cbGTC.DataSource = ListTienCong;
            cbGTC.ValueMember = "tiencong";
            cbGTC.DisplayMember = "tiencong";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cbGTC.DataSource];
            myCurrencyManager.Refresh();

        }
        private void LapPhieuSuaChua_Load(object sender, EventArgs e)
        {            
            PhuTungDTO pt = new PhuTungDTO();
            ptBus = new PhuTungBUS();
            List<PhuTungDTO> ListTenPhuTung = ptBus.selectTenPhuTung();
            if (ListTenPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ table PhuTung");
                return;
            }
            cbPhuTung.DataSource = ListTenPhuTung;

            TienCongDTO tc = new TienCongDTO();
            tcBus = new TienCongBUS();
            List<TienCongDTO> Listtendichvu = tcBus.selecttendichvu();
            if (Listtendichvu == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ table TienCong");
                return;
            }
            cbDV.DataSource = Listtendichvu;

            TiepNhanDTO tn = new TiepNhanDTO();
            tnBus = new TiepNhanBUS();
            List<TiepNhanDTO> ListBienSo = tnBus.selectBS();
            if (ListBienSo == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ table PhieuSuaChua");
                return;
            }
            cbBS.DataSource = ListBienSo;
            ngaysuachua.Format = DateTimePickerFormat.Custom;
            ngaysuachua.CustomFormat = "yyyy/MM/dd";
            txtThanhtien.Enabled = false;         
        }
        int lbPhuTung_index_value = -1;
        private void cbPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sKeyword = cbPhuTung.Text.Trim();
            List<PhuTungDTO> ListDonGia = ptBus.selectgia(sKeyword);
            this.loadData_Vao_lbDonGia(ListDonGia);
        }

        private void btchitiet_Click(object sender, EventArgs e)
        {
            ChiTietPhieuSuaChua ct = new ChiTietPhieuSuaChua();
            string K = cbBS.Text.Trim();
            SuaChuaDTO sc = new SuaChuaDTO();
            scBus = new SuaChuaBUS();
            if (K == null || K == string.Empty || K.Length == 0)
            {
                ct.loadData_Vao_GridView();
            }
            else
            {
                List<SuaChuaDTO> ListFind = scBus.Find(K);
                ct.loadData_Vao_GridView(ListFind);
            }           
            ct.Show();          
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            ChiTietPhieuSuaChua ct = new ChiTietPhieuSuaChua();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                SuaChuaDTO sc = new SuaChuaDTO();
                sc.Bienso = cbBS.Text;
                bool kq2 = scBus.xoa(sc);
                if (kq2 == false)
                    MessageBox.Show("Xóa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Xóa thông tin thành công");
                ct.loadData_Vao_GridView();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
              ChiTietPhieuSuaChua ct = new ChiTietPhieuSuaChua();
              SuaChuaDTO sc = new SuaChuaDTO();
              scBus = new SuaChuaBUS();
              sc.Soluong = int.Parse(txtsoluong.Text);
              sc.Tendichvu = cbDV.Text;
              sc.Tiencong = Decimal.Parse(cbGTC.Text);             
              sc.Tenphutung = cbPhuTung.Text;
              sc.Dongia = Decimal.Parse(lbPhuTung.Text);                          
              txtThanhtien.Text = Convert.ToString(Decimal.Parse(cbGTC.Text) + Decimal.Parse(lbPhuTung.Text) * int.Parse(txtsoluong.Text));
              sc.Thanhtien = Decimal.Parse(txtThanhtien.Text);
              sc.Bienso = cbBS.Text;
              sc.Ngaysuachua = ngaysuachua.Text;
              bool kq = scBus.them(sc);
              if (kq == false)
                  MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
              else
                  MessageBox.Show("Thêm thông tin thành công");
              ct.loadData_Vao_GridView();         
        }
        
        private void cbDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sKey = cbDV.Text.Trim();
            List<TienCongDTO> ListTienCong = tcBus.selectgia(sKey);
            this.loadData_Vao_cbGTC(ListTienCong);
            

        }

        public void cbBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChiTietPhieuSuaChua ct = new ChiTietPhieuSuaChua();
            string K = cbBS.Text.Trim();            
            SuaChuaDTO sc = new SuaChuaDTO();
            scBus = new SuaChuaBUS();
            if (K == null || K == string.Empty || K.Length == 0)
            {
                ct.loadData_Vao_GridView();
            }
            else
            {
                List<SuaChuaDTO> ListFind = scBus.Find(K);
                ct.loadData_Vao_GridView(ListFind);
            }
        }

       
    }  
}
