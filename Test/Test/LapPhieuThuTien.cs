using BUS;
using DTO;
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
    public partial class LapPhieuThuTien : Form
    {
        public LapPhieuThuTien()
        {
            InitializeComponent();
        }
        private ThuTienBUS ttBus;
        private void loadData_Vao_GridView()
        {
            List<ThuTienDTO> listThuTien = ttBus.select();

            if (listThuTien == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
                return;
            }
            dataLPTT.Columns.Clear();
            dataLPTT.DataSource = null;

            dataLPTT.AutoGenerateColumns = false;
            dataLPTT.AllowUserToAddRows = false;
            dataLPTT.DataSource = listThuTien;

            DataGridViewTextBoxColumn clid = new DataGridViewTextBoxColumn();
            clid.Name = "id";
            clid.HeaderText = "Mã số phiếu";
            clid.DataPropertyName = "id";
            clid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTT.Columns.Add(clid);

            DataGridViewTextBoxColumn clht = new DataGridViewTextBoxColumn();
            clht.Name = "ht";
            clht.HeaderText = "Họ và tên";
            clht.DataPropertyName = "ht";
            clht.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            dataLPTT.Columns.Add(clht);

            DataGridViewTextBoxColumn clbienso = new DataGridViewTextBoxColumn();
            clbienso.Name = "bienso";
            clbienso.HeaderText = "Biển số";
            clbienso.DataPropertyName = "bienso";
            clbienso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTT.Columns.Add(clbienso);

            DataGridViewTextBoxColumn clsotienthu = new DataGridViewTextBoxColumn();
            clsotienthu.Name = "sotienthu";
            clsotienthu.HeaderText = "Số tiền thu";
            clsotienthu.DataPropertyName = "sotienthu";
            clsotienthu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTT.Columns.Add(clsotienthu);

            DataGridViewTextBoxColumn clngaythutien = new DataGridViewTextBoxColumn();
            clngaythutien.Name = "ngaythutien";
            clngaythutien.HeaderText = "Ngày thu tiền";
            clngaythutien.DataPropertyName = "ngaythutien";
            clngaythutien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTT.Columns.Add(clngaythutien);
            dtNgaythutien.Format = DateTimePickerFormat.Custom;
            dtNgaythutien.CustomFormat = "dd/MM/yyyy";

            DataGridViewTextBoxColumn clsdt = new DataGridViewTextBoxColumn();
            clsdt.Name = "sdt";
            clsdt.HeaderText = "Số điện thoại";
            clsdt.DataPropertyName = "sdt";
            clsdt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTT.Columns.Add(clsdt);

            DataGridViewTextBoxColumn clemail = new DataGridViewTextBoxColumn();
            clemail.Name = "email";
            clemail.HeaderText = "Email";
            clemail.DataPropertyName = "email";
            clemail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLPTT.Columns.Add(clemail);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLPTT.DataSource];
            myCurrencyManager.Refresh();


        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string email = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(email);
            bool match = reg.IsMatch(this.txtEmail.Text);
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
            else if (txtSotienthu.Text == "")
            {
                errorProvider3.SetError(txtSotienthu, "Số tiền thu không được để trống!");
            }
            else if (txtSdt.Text == "")
            {
                errorProvider4.SetError(txtSdt, "Số điện thoại không được để trống!");
            }
            else if (txtSdt.Text.Length > 11 || txtSdt.Text.Length < 9)
            {
                errorProvider5.SetError(txtSdt, "Số điện thoại không hợp lệ!");
            }
            else if (txtEmail.Text == "")
            {
                errorProvider6.SetError(txtEmail, "Email không được để trống!");
            }
            else if (match == false)
            {
                errorProvider7.SetError(txtEmail, "Email có định dạng sai");
            }
            else
            {
                ThuTienDTO tt = new ThuTienDTO();
                tt.ID = int.Parse(txtID.Text);
                tt.HT = txtHT.Text;
                tt.Ngaythutien = dtNgaythutien.Text;
                tt.Sotienthu = Decimal.Parse(txtSotienthu.Text);
                tt.Email = txtEmail.Text;
                tt.Sdt = txtSdt.Text;
                tt.Bienso = txtBienso.Text;
                bool kq = ttBus.them(tt);
                if (kq == false)
                    MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Thêm thông tin thành công");
                this.loadData_Vao_GridView();
                txtBienso.Text = "";
                txtEmail.Text = "";
                txtHT.Text = "";
                txtSdt.Text = "";
                txtSotienthu.Text= "";
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string email = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(email);
            bool match = reg.IsMatch(this.txtEmail.Text);
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
            else if (txtSotienthu.Text == "")
            {
                errorProvider3.SetError(txtSotienthu, "Số tiền thu không được để trống!");
            }
            else if (txtSdt.Text == "")
            {
                errorProvider4.SetError(txtSdt, "Số điện thoại không được để trống!");
            }
            else if (txtSdt.Text.Length > 11 || txtSdt.Text.Length < 9)
            {
                errorProvider5.SetError(txtSdt, "Số điện thoại không hợp lệ!");
            }
            else if (txtEmail.Text == "")
            {
                errorProvider6.SetError(txtEmail, "Email không được để trống!");
            }
            else if (match == false)
            {
                errorProvider7.SetError(txtEmail, "Email có định dạng sai");
            }
            else
            {
                ThuTienDTO tt = new ThuTienDTO();
                tt.ID = int.Parse(txtID.Text);
                tt.HT = txtHT.Text;
                tt.Ngaythutien = dtNgaythutien.Text;
                tt.Sotienthu = Decimal.Parse(txtSotienthu.Text);
                tt.Email = txtEmail.Text;
                tt.Sdt = txtSdt.Text;
                tt.Bienso = txtBienso.Text;
                bool kq1 = ttBus.sua(tt);
                if (kq1 == false)
                    MessageBox.Show("Sửa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Sửa thông tin thành công");
                this.loadData_Vao_GridView();
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                ThuTienDTO tt = new ThuTienDTO();
                tt.ID = int.Parse(txtID.Text);
                bool kq2 = ttBus.xoa(tt);
                if (kq2 == false)
                    MessageBox.Show("Xóa thông tin thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                    MessageBox.Show("Xóa thông tin thành công");
                this.loadData_Vao_GridView();
                txtBienso.Text = "";
                txtEmail.Text = "";
                txtHT.Text = "";
                txtSdt.Text = "";
                txtSotienthu.Text = "";
            }
        }

        private void dataLPTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataLPTT.CurrentCell.RowIndex;
            txtID.Text = dataLPTT.Rows[t].Cells[0].Value.ToString();
            txtHT.Text = dataLPTT.Rows[t].Cells[1].Value.ToString();
            txtBienso.Text = dataLPTT.Rows[t].Cells[2].Value.ToString();
            txtSotienthu.Text = dataLPTT.Rows[t].Cells[3].Value.ToString();
            dtNgaythutien.Text = dataLPTT.Rows[t].Cells[4].Value.ToString();
            txtSdt.Text = dataLPTT.Rows[t].Cells[5].Value.ToString();
            txtEmail.Text = dataLPTT.Rows[t].Cells[6].Value.ToString();          
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

        private void txtHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            txtHT.Text = textInfo.ToTitleCase(txtHT.Text);
            txtHT.SelectionStart = txtHT.Text.Length;
        }

        private void LapPhieuThuTien_Load(object sender, EventArgs e)
        {
            dtNgaythutien.Format = DateTimePickerFormat.Custom;
            dtNgaythutien.CustomFormat = "dd/MM/yyyy";
            ttBus = new ThuTienBUS();            
        }

        private void load_Click(object sender, EventArgs e)
        {
            this.loadData_Vao_GridView();
        }

       
    }
}
