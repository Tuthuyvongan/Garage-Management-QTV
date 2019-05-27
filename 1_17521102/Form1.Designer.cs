namespace _1_17521102
{
    partial class Form1
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
            this.grTTKH = new System.Windows.Forms.GroupBox();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.rNu = new System.Windows.Forms.RadioButton();
            this.rNam = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSđt = new System.Windows.Forms.TextBox();
            this.txtĐc = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbĐT = new System.Windows.Forms.Label();
            this.lbGT = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.lbĐc = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.grKH = new System.Windows.Forms.GroupBox();
            this.dataKhachhang = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Đc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grTTKH.SuspendLayout();
            this.grKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // grTTKH
            // 
            this.grTTKH.Controls.Add(this.dtNS);
            this.grTTKH.Controls.Add(this.btLuu);
            this.grTTKH.Controls.Add(this.btThem);
            this.grTTKH.Controls.Add(this.btSua);
            this.grTTKH.Controls.Add(this.btXoa);
            this.grTTKH.Controls.Add(this.rNu);
            this.grTTKH.Controls.Add(this.rNam);
            this.grTTKH.Controls.Add(this.txtEmail);
            this.grTTKH.Controls.Add(this.txtSđt);
            this.grTTKH.Controls.Add(this.txtĐc);
            this.grTTKH.Controls.Add(this.txtHT);
            this.grTTKH.Controls.Add(this.lbEmail);
            this.grTTKH.Controls.Add(this.lbĐT);
            this.grTTKH.Controls.Add(this.lbGT);
            this.grTTKH.Controls.Add(this.lbNS);
            this.grTTKH.Controls.Add(this.lbĐc);
            this.grTTKH.Controls.Add(this.lbHT);
            this.grTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTKH.Location = new System.Drawing.Point(13, 82);
            this.grTTKH.Name = "grTTKH";
            this.grTTKH.Size = new System.Drawing.Size(934, 191);
            this.grTTKH.TabIndex = 0;
            this.grTTKH.TabStop = false;
            this.grTTKH.Text = "Thông tin khách hàng";
            // 
            // dtNS
            // 
            this.dtNS.CustomFormat = "";
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNS.Location = new System.Drawing.Point(97, 98);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(341, 27);
            this.dtNS.TabIndex = 22;
            this.dtNS.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(571, 138);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(80, 29);
            this.btLuu.TabIndex = 21;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Visible = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(657, 138);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 29);
            this.btThem.TabIndex = 20;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(743, 138);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 29);
            this.btSua.TabIndex = 19;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(829, 138);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 29);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // rNu
            // 
            this.rNu.AutoSize = true;
            this.rNu.Location = new System.Drawing.Point(772, 39);
            this.rNu.Name = "rNu";
            this.rNu.Size = new System.Drawing.Size(51, 24);
            this.rNu.TabIndex = 14;
            this.rNu.TabStop = true;
            this.rNu.Text = "Nữ";
            this.rNu.UseVisualStyleBackColor = true;
            // 
            // rNam
            // 
            this.rNam.AutoSize = true;
            this.rNam.Location = new System.Drawing.Point(641, 39);
            this.rNam.Name = "rNam";
            this.rNam.Size = new System.Drawing.Size(65, 24);
            this.rNam.TabIndex = 13;
            this.rNam.TabStop = true;
            this.rNam.Text = "Nam";
            this.rNam.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(641, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // txtSđt
            // 
            this.txtSđt.Location = new System.Drawing.Point(641, 74);
            this.txtSđt.Name = "txtSđt";
            this.txtSđt.Size = new System.Drawing.Size(270, 27);
            this.txtSđt.TabIndex = 11;
            this.txtSđt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSđt_KeyPress_1);
            // 
            // txtĐc
            // 
            this.txtĐc.Location = new System.Drawing.Point(97, 65);
            this.txtĐc.Name = "txtĐc";
            this.txtĐc.Size = new System.Drawing.Size(341, 27);
            this.txtĐc.TabIndex = 8;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(97, 32);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(341, 27);
            this.txtHT.TabIndex = 7;
            this.txtHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHT_KeyPress);
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(529, 110);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(97, 25);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email:";
            // 
            // lbĐT
            // 
            this.lbĐT.Location = new System.Drawing.Point(529, 77);
            this.lbĐT.Name = "lbĐT";
            this.lbĐT.Size = new System.Drawing.Size(117, 28);
            this.lbĐT.TabIndex = 5;
            this.lbĐT.Text = "Điện thoại:";
            // 
            // lbGT
            // 
            this.lbGT.Location = new System.Drawing.Point(529, 41);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(97, 28);
            this.lbGT.TabIndex = 4;
            this.lbGT.Text = "Giới tính:";
            // 
            // lbNS
            // 
            this.lbNS.Location = new System.Drawing.Point(6, 103);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(92, 20);
            this.lbNS.TabIndex = 3;
            this.lbNS.Text = "Ngày sinh:";
            // 
            // lbĐc
            // 
            this.lbĐc.Location = new System.Drawing.Point(6, 71);
            this.lbĐc.Name = "lbĐc";
            this.lbĐc.Size = new System.Drawing.Size(85, 24);
            this.lbĐc.TabIndex = 1;
            this.lbĐc.Text = "Địa chỉ:";
            // 
            // lbHT
            // 
            this.lbHT.Location = new System.Drawing.Point(6, 39);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(85, 20);
            this.lbHT.TabIndex = 0;
            this.lbHT.Text = "Họ Tên:";
            // 
            // grKH
            // 
            this.grKH.Controls.Add(this.dataKhachhang);
            this.grKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKH.Location = new System.Drawing.Point(13, 279);
            this.grKH.Name = "grKH";
            this.grKH.Size = new System.Drawing.Size(934, 286);
            this.grKH.TabIndex = 1;
            this.grKH.TabStop = false;
            this.grKH.Text = "Danh sách khách hàng";
            // 
            // dataKhachhang
            // 
            this.dataKhachhang.AllowUserToAddRows = false;
            this.dataKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.Đc,
            this.Ngaysinh,
            this.Gioitinh,
            this.Sdt,
            this.Email});
            this.dataKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKhachhang.Location = new System.Drawing.Point(3, 23);
            this.dataKhachhang.Name = "dataKhachhang";
            this.dataKhachhang.ReadOnly = true;
            this.dataKhachhang.RowTemplate.Height = 24;
            this.dataKhachhang.Size = new System.Drawing.Size(928, 260);
            this.dataKhachhang.TabIndex = 0;
            this.dataKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKhachhang_CellContentClick);
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Họ tên";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // Đc
            // 
            this.Đc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Đc.DataPropertyName = "Đc";
            this.Đc.HeaderText = "Địa chỉ";
            this.Đc.Name = "Đc";
            this.Đc.ReadOnly = true;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            this.Ngaysinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Gioitinh
            // 
            this.Gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.ReadOnly = true;
            // 
            // Sdt
            // 
            this.Sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Điện thoại";
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRA CỨU XE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grKH);
            this.Controls.Add(this.grTTKH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grTTKH.ResumeLayout(false);
            this.grTTKH.PerformLayout();
            this.grKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTTKH;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbĐT;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label lbĐc;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.GroupBox grKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtĐc;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.RadioButton rNu;
        private System.Windows.Forms.RadioButton rNam;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSđt;
        private System.Windows.Forms.DataGridView dataKhachhang;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Đc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

