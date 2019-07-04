using TenHieuXeBUS;
using TenHieuXeDTO;
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
    public partial class QuanLyHieuXe : Form
    {
        public QuanLyHieuXe()
        {
            InitializeComponent();
        }       
        private HieuXeBUS hxBus;
        private void loadData_Vao_GridView()
        {
            List<HieuXeDTO> listHieuXe = hxBus.select();

            if (listHieuXe == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dtHieuXe.Columns.Clear();
            dtHieuXe.DataSource = null;

            dtHieuXe.AutoGenerateColumns = false;
            dtHieuXe.AllowUserToAddRows = false;
            dtHieuXe.DataSource = listHieuXe;

            DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
            clid.Name = "mahieuxe";
            clid.HeaderText = "ID";
            clid.DataPropertyName = "mahieuxe";
            clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtHieuXe.Columns.Add(clid);            

            DataGridViewTextBoxColumn clhieuxe = new DataGridViewTextBoxColumn();
            clhieuxe.Name = "hieuxe";
            clhieuxe.HeaderText = "Tên hiệu xe";
            clhieuxe.DataPropertyName = "hieuxe";
            clhieuxe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtHieuXe.Columns.Add(clhieuxe);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtHieuXe.DataSource];
            myCurrencyManager.Refresh();


        }
        private void btThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (txtHieuXe.Text == "")
            {
                errorProvider1.SetError(txtHieuXe, "Tên hiệu Xe không được để trống!");
            }
            else if (txtMahieuxe.Text == "")
            {
                errorProvider2.SetError(txtMahieuxe, "Mã hiệu xe không được để trống!");
            }            
            else
            {
                HieuXeDTO hx = new HieuXeDTO();
                hx.Mahieuxe = int.Parse(txtMahieuxe.Text);
                hx.HieuXe = txtHieuXe.Text;               
                bool kq = hxBus.them(hx);
                if (kq == false)
                    MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Thêm thông tin thành công");
                this.loadData_Vao_GridView();
                txtMahieuxe.Text = "";
                txtHieuXe.Text = "";                
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (txtHieuXe.Text == "")
            {
                errorProvider1.SetError(txtHieuXe, "HieuXe không được để trống!");
            }
            else if (txtMahieuxe.Text == "")
            {
                errorProvider2.SetError(txtMahieuxe, "Mã hiệu xe không được để trống!");
            }
            else
            {
                HieuXeDTO hx = new HieuXeDTO();
                hx.Mahieuxe = int.Parse(txtMahieuxe.Text);
                hx.HieuXe = txtHieuXe.Text;
                bool kq1 = hxBus.sua(hx);                
                if (kq1 == false)
                    MessageBox.Show("Sửa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Sửa thông tin thành công");
                this.loadData_Vao_GridView();
                txtMahieuxe.Text = "";
                txtHieuXe.Text = "";
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                HieuXeDTO hx = new HieuXeDTO();
                hx.Mahieuxe = int.Parse(txtMahieuxe.Text);
                hx.HieuXe = txtHieuXe.Text;
                bool kq2 = hxBus.xoa(hx);
                if (kq2 == false)
                    MessageBox.Show("Xóa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Xóa thông tin thành công");
                this.loadData_Vao_GridView();
                txtMahieuxe.Text = "";
                txtHieuXe.Text = "";
            }
        }

        private void QuanLyHieuXe_Load(object sender, EventArgs e)
        {
            hxBus = new HieuXeBUS();
        }

        private void dtHieuXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtHieuXe.CurrentCell.RowIndex;
            txtMahieuxe.Text = dtHieuXe.Rows[t].Cells[0].Value.ToString();
            txtHieuXe.Text = dtHieuXe.Rows[t].Cells[1].Value.ToString();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            this.loadData_Vao_GridView();
        }
    }
}
