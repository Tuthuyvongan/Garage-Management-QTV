namespace Test
{
    partial class LapPhieuTiepNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grLPTT = new System.Windows.Forms.GroupBox();
            this.dataLPTN = new System.Windows.Forms.DataGridView();
            this.txtMaPTN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grTTKH = new System.Windows.Forms.GroupBox();
            this.cbTenHieuXe = new System.Windows.Forms.ComboBox();
            this.load = new System.Windows.Forms.Button();
            this.lbHx = new System.Windows.Forms.Label();
            this.dtNgaytiepnhan = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtBienso = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.lbĐiaChi = new System.Windows.Forms.Label();
            this.lbĐT = new System.Windows.Forms.Label();
            this.lbNtn = new System.Windows.Forms.Label();
            this.lbBs = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grLPTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLPTN)).BeginInit();
            this.grTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // grLPTT
            // 
            this.grLPTT.Controls.Add(this.dataLPTN);
            this.grLPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLPTT.Location = new System.Drawing.Point(13, 279);
            this.grLPTT.Name = "grLPTT";
            this.grLPTT.Size = new System.Drawing.Size(1136, 286);
            this.grLPTT.TabIndex = 17;
            this.grLPTT.TabStop = false;
            this.grLPTT.Text = "Danh sách khách hàng";
            // 
            // dataLPTN
            // 
            this.dataLPTN.AllowUserToAddRows = false;
            this.dataLPTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLPTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLPTN.Location = new System.Drawing.Point(3, 23);
            this.dataLPTN.Name = "dataLPTN";
            this.dataLPTN.ReadOnly = true;
            this.dataLPTN.RowTemplate.Height = 24;
            this.dataLPTN.Size = new System.Drawing.Size(1130, 260);
            this.dataLPTN.TabIndex = 0;
            this.dataLPTN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLPTN_CellContentClick);
            // 
            // txtMaPTN
            // 
            this.txtMaPTN.Location = new System.Drawing.Point(123, 33);
            this.txtMaPTN.Name = "txtMaPTN";
            this.txtMaPTN.Size = new System.Drawing.Size(100, 22);
            this.txtMaPTN.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 66);
            this.label1.TabIndex = 14;
            this.label1.Text = "PHIẾU TIẾP NHẬN BẢO TRÌ XE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grTTKH
            // 
            this.grTTKH.Controls.Add(this.cbTenHieuXe);
            this.grTTKH.Controls.Add(this.load);
            this.grTTKH.Controls.Add(this.lbHx);
            this.grTTKH.Controls.Add(this.dtNgaytiepnhan);
            this.grTTKH.Controls.Add(this.btThem);
            this.grTTKH.Controls.Add(this.btSua);
            this.grTTKH.Controls.Add(this.btXoa);
            this.grTTKH.Controls.Add(this.txtDiaChi);
            this.grTTKH.Controls.Add(this.txtSdt);
            this.grTTKH.Controls.Add(this.txtBienso);
            this.grTTKH.Controls.Add(this.txtHT);
            this.grTTKH.Controls.Add(this.lbĐiaChi);
            this.grTTKH.Controls.Add(this.lbĐT);
            this.grTTKH.Controls.Add(this.lbNtn);
            this.grTTKH.Controls.Add(this.lbBs);
            this.grTTKH.Controls.Add(this.lbHT);
            this.grTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTKH.Location = new System.Drawing.Point(16, 78);
            this.grTTKH.Name = "grTTKH";
            this.grTTKH.Size = new System.Drawing.Size(1133, 191);
            this.grTTKH.TabIndex = 13;
            this.grTTKH.TabStop = false;
            this.grTTKH.Text = "Thông tin phiếu thu tiền";
            // 
            // cbTenHieuXe
            // 
            this.cbTenHieuXe.DisplayMember = "hieuxe";
            this.cbTenHieuXe.FormattingEnabled = true;
            this.cbTenHieuXe.Location = new System.Drawing.Point(690, 100);
            this.cbTenHieuXe.Name = "cbTenHieuXe";
            this.cbTenHieuXe.Size = new System.Drawing.Size(423, 28);
            this.cbTenHieuXe.TabIndex = 26;
            this.cbTenHieuXe.ValueMember = "hieuxe";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(870, 146);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(80, 39);
            this.load.TabIndex = 25;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // lbHx
            // 
            this.lbHx.Location = new System.Drawing.Point(586, 106);
            this.lbHx.Name = "lbHx";
            this.lbHx.Size = new System.Drawing.Size(98, 24);
            this.lbHx.TabIndex = 24;
            this.lbHx.Text = "Hiệu Xe";
            // 
            // dtNgaytiepnhan
            // 
            this.dtNgaytiepnhan.CustomFormat = "";
            this.dtNgaytiepnhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaytiepnhan.Location = new System.Drawing.Point(140, 98);
            this.dtNgaytiepnhan.Name = "dtNgaytiepnhan";
            this.dtNgaytiepnhan.Size = new System.Drawing.Size(423, 27);
            this.dtNgaytiepnhan.TabIndex = 22;
            this.dtNgaytiepnhan.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(189, 146);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 39);
            this.btThem.TabIndex = 20;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(409, 146);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 39);
            this.btSua.TabIndex = 19;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(638, 146);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 39);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(690, 65);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(423, 27);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(140, 65);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(423, 27);
            this.txtSdt.TabIndex = 11;
            this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
            // 
            // txtBienso
            // 
            this.txtBienso.Location = new System.Drawing.Point(690, 32);
            this.txtBienso.Name = "txtBienso";
            this.txtBienso.Size = new System.Drawing.Size(423, 27);
            this.txtBienso.TabIndex = 8;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(140, 32);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(423, 27);
            this.txtHT.TabIndex = 7;
            this.txtHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHT_KeyPress);
            // 
            // lbĐiaChi
            // 
            this.lbĐiaChi.Location = new System.Drawing.Point(587, 71);
            this.lbĐiaChi.Name = "lbĐiaChi";
            this.lbĐiaChi.Size = new System.Drawing.Size(85, 24);
            this.lbĐiaChi.TabIndex = 6;
            this.lbĐiaChi.Text = "Địa chỉ";
            // 
            // lbĐT
            // 
            this.lbĐT.Location = new System.Drawing.Point(6, 68);
            this.lbĐT.Name = "lbĐT";
            this.lbĐT.Size = new System.Drawing.Size(117, 24);
            this.lbĐT.TabIndex = 5;
            this.lbĐT.Text = "Điện thoại";
            // 
            // lbNtn
            // 
            this.lbNtn.Location = new System.Drawing.Point(6, 103);
            this.lbNtn.Name = "lbNtn";
            this.lbNtn.Size = new System.Drawing.Size(128, 24);
            this.lbNtn.TabIndex = 3;
            this.lbNtn.Text = "Ngày tiếp nhận ";
            // 
            // lbBs
            // 
            this.lbBs.Location = new System.Drawing.Point(587, 35);
            this.lbBs.Name = "lbBs";
            this.lbBs.Size = new System.Drawing.Size(85, 24);
            this.lbBs.TabIndex = 1;
            this.lbBs.Text = "Biển số";
            // 
            // lbHT
            // 
            this.lbHT.Location = new System.Drawing.Point(6, 35);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(128, 24);
            this.lbHT.TabIndex = 0;
            this.lbHT.Text = "Họ tên chủ xe";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // LapPhieuTiepNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 577);
            this.Controls.Add(this.grLPTT);
            this.Controls.Add(this.txtMaPTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grTTKH);
            this.Name = "LapPhieuTiepNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TiepNhanXeSua";
            this.Load += new System.EventHandler(this.LapPhieuTiepNhan_Load);
            this.grLPTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLPTN)).EndInit();
            this.grTTKH.ResumeLayout(false);
            this.grTTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grLPTT;
        private System.Windows.Forms.DataGridView dataLPTN;
        private System.Windows.Forms.TextBox txtMaPTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grTTKH;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label lbHx;
        private System.Windows.Forms.DateTimePicker dtNgaytiepnhan;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label lbĐiaChi;
        private System.Windows.Forms.Label lbĐT;
        private System.Windows.Forms.Label lbNtn;
        private System.Windows.Forms.Label lbBs;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ComboBox cbTenHieuXe;
        private System.Windows.Forms.TextBox txtBienso;
    }
}