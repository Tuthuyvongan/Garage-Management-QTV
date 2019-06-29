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
            dataLPTT.DataSource = listThuTien;
            dataLPTT.DataMember = "PhieuSuaChua";
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
                tt.Sotienthu = float.Parse(txtID.Text);
                tt.Email = txtEmail.Text;
                tt.Sdt = txtSdt.Text;
                tt.Bienso = txtBienso.Text;
                bool kq = ttBus.them(tt);
                if (kq == false)
                    MessageBox.Show("Thêm thông tin thất bại. Vui lòng kiểm tra lại dũ liệu");
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
                tt.Sotienthu = float.Parse(txtID.Text);
                tt.Email = txtEmail.Text;
                tt.Sdt = txtSdt.Text;
                tt.Bienso = txtBienso.Text;
                bool kq1 = ttBus.them(tt);
                if (kq1 == false)
                    MessageBox.Show("Sửa thông tin thất bại. Vui lòng kiểm tra lại dũ liệu");
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
                    MessageBox.Show("Xóa thông tin thất bại. Vui lòng kiểm tra lại dũ liệu");
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
            txtHT.Text = dataLPTT.Rows[t].Cells[0].Value.ToString();
            txtBienso.Text = dataLPTT.Rows[t].Cells[1].Value.ToString();
            txtSotienthu.Text = dataLPTT.Rows[t].Cells[2].Value.ToString();
            dtNgaythutien.Text = dataLPTT.Rows[t].Cells[3].Value.ToString();
            txtSdt.Text = dataLPTT.Rows[t].Cells[4].Value.ToString();
            txtEmail.Text = dataLPTT.Rows[t].Cells[5].Value.ToString();
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
            ttBus = new ThuTienBUS();
        }

    }
}
