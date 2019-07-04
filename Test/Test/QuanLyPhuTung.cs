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
    public partial class QuanLyPhuTung : Form
    {
        public QuanLyPhuTung()
        {
            InitializeComponent();
        }
        private PhuTungBUS ptBus;
        private void loadData_Vao_GridView()
        {
            List<PhuTungDTO> listPhuTung = ptBus.select();

            if (listPhuTung == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dtPhuTung.Columns.Clear();
            dtPhuTung.DataSource = null;

            dtPhuTung.AutoGenerateColumns = false;
            dtPhuTung.AllowUserToAddRows = false;
            dtPhuTung.DataSource = listPhuTung;

            DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
            clid.Name = "maphutung";
            clid.HeaderText = "ID";
            clid.DataPropertyName = "maphutung";
            clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPhuTung.Columns.Add(clid);

            DataGridViewTextBoxColumn clPhuTung = new DataGridViewTextBoxColumn();
            clPhuTung.Name = "tenphutung";
            clPhuTung.HeaderText = "Tên phụ tùng";
            clPhuTung.DataPropertyName = "tenphutung";
            clPhuTung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPhuTung.Columns.Add(clPhuTung);

            DataGridViewTextBoxColumn clDongia = new DataGridViewTextBoxColumn();
            clDongia.Name = "dongia";
            clDongia.HeaderText = "Giá phụ tùng";
            clDongia.DataPropertyName = "dongia";
            clDongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPhuTung.Columns.Add(clDongia);

            DataGridViewTextBoxColumn clTondau = new DataGridViewTextBoxColumn();
            clTondau.Name = "tondau";
            clTondau.HeaderText = "Số lượng nhập về";
            clTondau.DataPropertyName = "tondau";
            clTondau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPhuTung.Columns.Add(clTondau);

            DataGridViewTextBoxColumn clToncuoi = new DataGridViewTextBoxColumn();
            clToncuoi.Name = "toncuoi";
            clToncuoi.HeaderText = "Số lượng còn trong kho";
            clToncuoi.DataPropertyName = "toncuoi";
            clToncuoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPhuTung.Columns.Add(clToncuoi);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtPhuTung.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadData_Vao_GridView(List<PhuTungDTO> listTimKiem)
        {            
            if (listTimKiem == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dtTimKiem.Columns.Clear();
            dtTimKiem.DataSource = null;

            dtTimKiem.AutoGenerateColumns = false;
            dtTimKiem.AllowUserToAddRows = false;
            dtTimKiem.DataSource = listTimKiem;

            DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
            clid.Name = "maphutung";
            clid.HeaderText = "ID";
            clid.DataPropertyName = "maphutung";
            clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtTimKiem.Columns.Add(clid);

            DataGridViewTextBoxColumn clPhuTung = new DataGridViewTextBoxColumn();
            clPhuTung.Name = "tenphutung";
            clPhuTung.HeaderText = "Tên phụ tùng";
            clPhuTung.DataPropertyName = "tenphutung";
            clPhuTung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtTimKiem.Columns.Add(clPhuTung);

            DataGridViewTextBoxColumn clDongia = new DataGridViewTextBoxColumn();
            clDongia.Name = "dongia";
            clDongia.HeaderText = "Giá phụ tùng";
            clDongia.DataPropertyName = "dongia";
            clDongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtTimKiem.Columns.Add(clDongia);

            DataGridViewTextBoxColumn clTondau = new DataGridViewTextBoxColumn();
            clTondau.Name = "tondau";
            clTondau.HeaderText = "Số lượng nhập về";
            clTondau.DataPropertyName = "tondau";
            clTondau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtTimKiem.Columns.Add(clTondau);

            DataGridViewTextBoxColumn clToncuoi = new DataGridViewTextBoxColumn();
            clToncuoi.Name = "toncuoi";
            clToncuoi.HeaderText = "Số lượng còn trong kho";
            clToncuoi.DataPropertyName = "toncuoi";
            clToncuoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtTimKiem.Columns.Add(clToncuoi);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtTimKiem.DataSource];
            myCurrencyManager.Refresh();


        }
        private void btThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear(); 
            if (txttenphutung.Text == "")
            {
                errorProvider1.SetError(txttenphutung, "Tên phụ tùng không được để trống!");
            }
            else if (txtmaphutung.Text == "")
            {
                errorProvider2.SetError(txtmaphutung, "Mã phụ tùng không được để trống!");
            }
            if (txtdongia.Text == "")
            {
                errorProvider3.SetError(txtdongia, "Đơn giá không được để trống!");
            }
            else if (txttc.Text == "")
            {
                errorProvider5.SetError(txttc, "Số lượng tồn kho không được để trống!");
            }
            if (txttđ.Text == "")
            {
                errorProvider4.SetError(txttđ, "Số lượng nhập về không được để trống!");
            }
            else
            {
                PhuTungDTO pt = new PhuTungDTO();
                pt.Maphutung = int.Parse(txtmaphutung.Text);
                pt.Tenphutung = txttenphutung.Text;
                pt.Tondau = int.Parse(txttđ.Text);
                pt.Toncuoi = int.Parse(txttc.Text);
                pt.Dongia = Decimal.Parse(txtdongia.Text);
                bool kq = ptBus.them(pt);
                if (kq == false)
                    MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Thêm thông tin thành công");
                this.loadData_Vao_GridView();
                txttenphutung.Text = "";
                txtmaphutung.Text = "";
                txttc.Text = "";
                txttđ.Text = "";
                txtdongia.Text = "";

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            if (txttenphutung.Text == "")
            {
                errorProvider1.SetError(txttenphutung, "Tên phụ tùng không được để trống!");
            }
            else if (txtmaphutung.Text == "")
            {
                errorProvider2.SetError(txtmaphutung, "Mã phụ tùng không được để trống!");
            }
            if (txtdongia.Text == "")
            {
                errorProvider3.SetError(txtdongia, "Đơn giá không được để trống!");
            }
            else if (txttc.Text == "")
            {
                errorProvider5.SetError(txttc, "Số lượng tồn kho không được để trống!");
            }
            if (txttđ.Text == "")
            {
                errorProvider4.SetError(txttđ, "Số lượng nhập về không được để trống!");
            }
            else
            {
                PhuTungDTO pt = new PhuTungDTO();
                pt.Maphutung = int.Parse(txtmaphutung.Text);
                pt.Tenphutung = txttenphutung.Text;
                pt.Tondau = int.Parse(txttđ.Text);
                pt.Toncuoi = int.Parse(txttc.Text);
                pt.Dongia = Decimal.Parse(txtdongia.Text);
                bool kq1 = ptBus.sua(pt);
                if (kq1 == false)
                    MessageBox.Show("Sửa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Sửa thông tin thành công");
                this.loadData_Vao_GridView();
                txttenphutung.Text = "";
                txtmaphutung.Text = "";
                txttc.Text = "";
                txttđ.Text = "";
                txtdongia.Text = "";

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                PhuTungDTO pt = new PhuTungDTO();
                pt.Maphutung = int.Parse(txtmaphutung.Text);
                pt.Tenphutung = txttenphutung.Text;
                pt.Tondau = int.Parse(txttđ.Text);
                pt.Toncuoi = int.Parse(txttc.Text);
                pt.Dongia = Decimal.Parse(txtdongia.Text);
                bool kq1 = ptBus.xoa(pt);
                if (kq1 == false)
                    MessageBox.Show("Xóa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Xóa thông tin thành công");
                this.loadData_Vao_GridView();
                txttenphutung.Text = "";
                txtmaphutung.Text = "";
                txttc.Text = "";
                txttđ.Text = "";
                txtdongia.Text = "";
            }
        }

        private void dtPhuTung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtPhuTung.CurrentCell.RowIndex;
            txtmaphutung.Text = dtPhuTung.Rows[t].Cells[0].Value.ToString();
            txttenphutung.Text = dtPhuTung.Rows[t].Cells[1].Value.ToString();
            txtdongia.Text = dtPhuTung.Rows[t].Cells[2].Value.ToString();
            txttđ.Text = dtPhuTung.Rows[t].Cells[3].Value.ToString();
            txttc.Text = dtPhuTung.Rows[t].Cells[4].Value.ToString();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            this.loadData_Vao_GridView();
        }

        private void QuanLyPhuTung_Load(object sender, EventArgs e)
        {
            ptBus = new PhuTungBUS();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            string Keyword = txtTK.Text.Trim();
            if (Keyword == null || Keyword == string.Empty || Keyword.Length == 0) 
            {
                List<PhuTungDTO> listTimKiem = ptBus.select();
                this.loadData_Vao_GridView(listTimKiem);
            }
            else
            {
                List<PhuTungDTO> listTimKiem = ptBus.TimKiem(Keyword);
                this.loadData_Vao_GridView(listTimKiem);
            }
        }      
    }
}
