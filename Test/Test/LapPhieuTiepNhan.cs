using LapPhieuTiepNhanBUS;
using LapPhieuTiepNhanDTO;
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
    public partial class LapPhieuTiepNhan : Form
    {
        public LapPhieuTiepNhan()
        {
            InitializeComponent();
        }
        private TiepNhanBUS tnBus;
        private HieuXeBUS hxBus;
        
        private void loadData_Vao_GridView()
        {
            List<TiepNhanDTO> listTiepNhan = tnBus.select();

            if (listTiepNhan == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dataLPTN.Columns.Clear();
            dataLPTN.DataSource = null;

            dataLPTN.AutoGenerateColumns = false;
            dataLPTN.AllowUserToAddRows = false;
            dataLPTN.DataSource = listTiepNhan;

            DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
            clid.Name = "matiepnhan";
            clid.HeaderText = "Mã tiếp nhận";
            clid.DataPropertyName = "matiepnhan";
            clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTN.Columns.Add(clid);

            DataGridViewTextBoxColumn clht = new DataGridViewTextBoxColumn();
            clht.Name = "ht";
            clht.HeaderText = "Họ và tên";
            clht.DataPropertyName = "ht";
            clht.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTN.Columns.Add(clht);

            DataGridViewTextBoxColumn clbienso = new DataGridViewTextBoxColumn();
            clbienso.Name = "bienso";
            clbienso.HeaderText = "Biển số";
            clbienso.DataPropertyName = "bienso";
            clbienso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTN.Columns.Add(clbienso);

            DataGridViewTextBoxColumn cldiachi = new DataGridViewTextBoxColumn();
            cldiachi.Name = "diachi";
            cldiachi.HeaderText = "Địa chỉ";
            cldiachi.DataPropertyName = "diachi";
            cldiachi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTN.Columns.Add(cldiachi);

            DataGridViewTextBoxColumn clngaytiepnhan = new DataGridViewTextBoxColumn();
            clngaytiepnhan.Name = "ngaytiepnhan";
            clngaytiepnhan.HeaderText = "Ngày tiếp nhận";
            clngaytiepnhan.DataPropertyName = "ngaytiepnhan";
            clngaytiepnhan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTN.Columns.Add(clngaytiepnhan);
            dtNgaytiepnhan.Format = DateTimePickerFormat.Custom;
            dtNgaytiepnhan.CustomFormat = "dd/MM/yyyy";

            DataGridViewTextBoxColumn clsdt = new DataGridViewTextBoxColumn();
            clsdt.Name = "sdt";
            clsdt.HeaderText = "Số điện thoại";
            clsdt.DataPropertyName = "sdt";
            clsdt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTN.Columns.Add(clsdt);

            DataGridViewTextBoxColumn clhieuxe = new DataGridViewTextBoxColumn();
            clhieuxe.Name = "hieuxe";
            clhieuxe.HeaderText = "Tên hiệu xe";
            clhieuxe.DataPropertyName = "hieuxe";
            clhieuxe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTN.Columns.Add(clhieuxe);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLPTN.DataSource];
            myCurrencyManager.Refresh();


        }
        private void btThem_Click(object sender, EventArgs e)
        {
          
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            if (txtHT.Text == "")
            {
                errorProvider1.SetError(txtHT, "Tên khách hàng không được để trống!");
            }
            else if (txtBienso.Text == "")
            {
                errorProvider2.SetError(txtBienso, "Biển số xe không được để trống!");
            }
            else if (txtDiaChi.Text == "")
            {
                errorProvider3.SetError(txtDiaChi, "Địa chỉ không được để trống!");
            }
            else if (txtSdt.Text == "")
            {
                errorProvider4.SetError(txtSdt, "Số điện thoại không được để trống!");
            }
            else if (txtSdt.Text.Length > 11 || txtSdt.Text.Length < 9)
            {
                errorProvider5.SetError(txtSdt, "Số điện thoại không hợp lệ!");
            }
            else if (cbTenHieuXe.Text == "")
            {
                errorProvider6.SetError(cbTenHieuXe, "Tên hiệu xe không được để trống!");
            }
            else
            {
                TiepNhanDTO tn = new TiepNhanDTO();
                tn.MaTiepNhan = int.Parse(txtMaPTN.Text);
                tn.HT = txtHT.Text;
                tn.Ngaytiepnhan = dtNgaytiepnhan.Text;
                tn.DiaChi = txtDiaChi.Text;
                tn.HieuXe = cbTenHieuXe.Text;
                tn.Sdt = txtSdt.Text;
                tn.Bienso = txtBienso.Text;
                bool kq = tnBus.them(tn);
                if (kq == false)
                    MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Thêm thông tin thành công");
                this.loadData_Vao_GridView();
                txtBienso.Text = "";
                txtDiaChi.Text = "";
                txtHT.Text = "";
                txtSdt.Text = "";
                cbTenHieuXe.Text = "";
                txtMaPTN.Text = "";
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            if (txtHT.Text == "")
            {
                errorProvider1.SetError(txtHT, "Tên khách hàng không được để trống!");
            }
            else if (txtBienso.Text == "")
            {
                errorProvider2.SetError(txtBienso, "Biển số xe không được để trống!");
            }
            else if (txtDiaChi.Text == "")
            {
                errorProvider3.SetError(txtDiaChi, "Địa chỉ không được để trống!");
            }
            else if (txtSdt.Text == "")
            {
                errorProvider4.SetError(txtSdt, "Số điện thoại không được để trống!");
            }
            else if (txtSdt.Text.Length > 11 || txtSdt.Text.Length < 9)
            {
                errorProvider5.SetError(txtSdt, "Số điện thoại không hợp lệ!");
            }
            else if (cbTenHieuXe.Text == "")
            {
                errorProvider6.SetError(cbTenHieuXe, "Tên hiệu xe không được để trống!");
            }
            else
            {
                TiepNhanDTO tn = new TiepNhanDTO();
                tn.MaTiepNhan = int.Parse(txtMaPTN.Text);
                tn.HT = txtHT.Text;
                tn.Ngaytiepnhan = dtNgaytiepnhan.Text;
                tn.DiaChi = txtDiaChi.Text;
                tn.HieuXe = cbTenHieuXe.Text;
                tn.Sdt = txtSdt.Text;
                tn.Bienso = txtBienso.Text;
                bool kq1 = tnBus.sua(tn);
                if (kq1 == false)
                    MessageBox.Show("Sửa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Sửa thông tin thành công");
                this.loadData_Vao_GridView();
                txtBienso.Text = "";
                txtDiaChi.Text = "";
                txtHT.Text = "";
                txtSdt.Text = "";
                cbTenHieuXe.Text = "";
                txtMaPTN.Text = "";
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                TiepNhanDTO tn = new TiepNhanDTO();
                tn.MaTiepNhan = int.Parse(txtMaPTN.Text);
                bool kq2 = tnBus.xoa(tn);
                if (kq2 == false)
                    MessageBox.Show("Xóa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Xóa thông tin thành công");
                this.loadData_Vao_GridView();
                txtBienso.Text = "";
                txtDiaChi.Text = "";
                txtHT.Text = "";
                txtSdt.Text = "";
                cbTenHieuXe.Text = "";
                txtMaPTN.Text = "";
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            this.loadData_Vao_GridView();
        }

        private void dataLPTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataLPTN.CurrentCell.RowIndex;
            txtMaPTN.Text = dataLPTN.Rows[t].Cells[0].Value.ToString();
            txtHT.Text = dataLPTN.Rows[t].Cells[1].Value.ToString();
            txtBienso.Text = dataLPTN.Rows[t].Cells[2].Value.ToString();
            txtDiaChi.Text = dataLPTN.Rows[t].Cells[3].Value.ToString();
            dtNgaytiepnhan.Text = dataLPTN.Rows[t].Cells[4].Value.ToString();
            txtSdt.Text = dataLPTN.Rows[t].Cells[5].Value.ToString();
            cbTenHieuXe.Text = dataLPTN.Rows[t].Cells[6].Value.ToString();
        }

        private void txtHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            txtHT.Text = textInfo.ToTitleCase(txtHT.Text);
            txtHT.SelectionStart = txtHT.Text.Length;
        }
        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ma_phim_nhap_vao = e.KeyChar;
            if (ma_phim_nhap_vao > 57 || (ma_phim_nhap_vao < 48 && ma_phim_nhap_vao > 9 && ma_phim_nhap_vao < 7))
            {
                errorProvider5.SetError(txtSdt, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void LapPhieuTiepNhan_Load(object sender, EventArgs e)
        {
            dtNgaytiepnhan.Format = DateTimePickerFormat.Custom;
            dtNgaytiepnhan.CustomFormat = "yyyy/MM/dd";
            tnBus = new TiepNhanBUS();
            hxBus = new HieuXeBUS();
          
            List<HieuXeDTO> ListTenHieuXe = hxBus.selectTenHieuXe();

            if (ListTenHieuXe == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ table HieuXe");
                return;
            }
            cbTenHieuXe.DataSource = ListTenHieuXe;

        }
    }
}
