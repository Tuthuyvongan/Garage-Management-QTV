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
    public partial class ChiTietPhieuSuaChua : Form
    {
        public ChiTietPhieuSuaChua()
        {
            InitializeComponent();
        }
        private SuaChuaBUS scBus;
        
        public void loadData_Vao_GridView()
        {
            scBus = new SuaChuaBUS();
            List<SuaChuaDTO> listSuaChua = scBus.select();

            if (listSuaChua == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dtchitiet.Columns.Clear();
            dtchitiet.DataSource = null;

            dtchitiet.AutoGenerateColumns = false;
            dtchitiet.AllowUserToAddRows = false;
            dtchitiet.DataSource = listSuaChua;

            DataGridViewTextBoxColumn clbienso = new DataGridViewTextBoxColumn();
            clbienso.Name = "bienso";
            clbienso.HeaderText = "Biển số";
            clbienso.DataPropertyName = "bienso";
            clbienso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clbienso);

            DataGridViewTextBoxColumn cltenphutung = new DataGridViewTextBoxColumn();
            cltenphutung.Name = "tenphutung";
            cltenphutung.HeaderText = "Tên phụ tùng";
            cltenphutung.DataPropertyName = "tenphutung";
            cltenphutung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cltenphutung);

            DataGridViewTextBoxColumn cldongia = new DataGridViewTextBoxColumn();
            cldongia.Name = "dongia";
            cldongia.HeaderText = "Giá phụ tùng";
            cldongia.DataPropertyName = "dongia";
            cldongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cldongia);

            DataGridViewTextBoxColumn clsl = new DataGridViewTextBoxColumn();
            clsl.Name = "soluong";
            clsl.HeaderText = "Số lượng";
            clsl.DataPropertyName = "soluong";
            clsl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clsl);                        

            DataGridViewTextBoxColumn clngaysuachua = new DataGridViewTextBoxColumn();
            clngaysuachua.Name = "ngaysuachua";
            clngaysuachua.HeaderText = "Ngày sửa chữa";
            clngaysuachua.DataPropertyName = "ngaysuachua";
            clngaysuachua.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clngaysuachua);            

            DataGridViewTextBoxColumn cltendichvu = new DataGridViewTextBoxColumn();
            cltendichvu.Name = "tendichvu";
            cltendichvu.HeaderText = "Tên dịch vụ";
            cltendichvu.DataPropertyName = "tendichvu";
            cltendichvu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cltendichvu);

            DataGridViewTextBoxColumn cltiencong = new DataGridViewTextBoxColumn();
            cltiencong.Name = "tiencong";
            cltiencong.HeaderText = "Tiền công";
            cltiencong.DataPropertyName = "tiencong";
            cltiencong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cltiencong);

            DataGridViewTextBoxColumn clthanhtien = new DataGridViewTextBoxColumn();
            clthanhtien.Name = "thanhtien";
            clthanhtien.HeaderText = "Thành tiền";
            clthanhtien.DataPropertyName = "thanhtien";
            clthanhtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clthanhtien);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtchitiet.DataSource];
            myCurrencyManager.Refresh();


        }
        public void loadData_Vao_GridView(List<SuaChuaDTO> listFind)
        {           

            if (listFind == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dtchitiet.Columns.Clear();
            dtchitiet.DataSource = null;

            dtchitiet.AutoGenerateColumns = false;
            dtchitiet.AllowUserToAddRows = false;
            dtchitiet.DataSource = listFind;

            DataGridViewTextBoxColumn clbienso = new DataGridViewTextBoxColumn();
            clbienso.Name = "bienso";
            clbienso.HeaderText = "Biển số";
            clbienso.DataPropertyName = "bienso";
            clbienso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clbienso);

            DataGridViewTextBoxColumn cltenphutung = new DataGridViewTextBoxColumn();
            cltenphutung.Name = "tenphutung";
            cltenphutung.HeaderText = "Tên phụ tùng";
            cltenphutung.DataPropertyName = "tenphutung";
            cltenphutung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cltenphutung);

            DataGridViewTextBoxColumn cldongia = new DataGridViewTextBoxColumn();
            cldongia.Name = "dongia";
            cldongia.HeaderText = "Giá phụ tùng";
            cldongia.DataPropertyName = "dongia";
            cldongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cldongia);

            DataGridViewTextBoxColumn clsl = new DataGridViewTextBoxColumn();
            clsl.Name = "soluong";
            clsl.HeaderText = "Số lượng";
            clsl.DataPropertyName = "soluong";
            clsl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clsl);

            DataGridViewTextBoxColumn clngaysuachua = new DataGridViewTextBoxColumn();
            clngaysuachua.Name = "ngaysuachua";
            clngaysuachua.HeaderText = "Ngày sửa chữa";
            clngaysuachua.DataPropertyName = "ngaysuachua";
            clngaysuachua.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clngaysuachua);

            DataGridViewTextBoxColumn cltendichvu = new DataGridViewTextBoxColumn();
            cltendichvu.Name = "tendichvu";
            cltendichvu.HeaderText = "Tên dịch vụ";
            cltendichvu.DataPropertyName = "tendichvu";
            cltendichvu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cltendichvu);

            DataGridViewTextBoxColumn cltiencong = new DataGridViewTextBoxColumn();
            cltiencong.Name = "tiencong";
            cltiencong.HeaderText = "Tiền công";
            cltiencong.DataPropertyName = "tiencong";
            cltiencong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(cltiencong);

            DataGridViewTextBoxColumn clthanhtien = new DataGridViewTextBoxColumn();
            clthanhtien.Name = "thanhtien";
            clthanhtien.HeaderText = "Thành tiền";
            clthanhtien.DataPropertyName = "thanhtien";
            clthanhtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtchitiet.Columns.Add(clthanhtien);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtchitiet.DataSource];
            myCurrencyManager.Refresh();


        }
        private void ChiTietPhieuSuaChua_Load(object sender, EventArgs e)
        {          
                   
        }
       

        private void dtchitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
