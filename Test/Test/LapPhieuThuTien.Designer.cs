namespace Test
{
    partial class LapPhieuThuTien
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grTTKH = new System.Windows.Forms.GroupBox();
            this.load = new System.Windows.Forms.Button();
            this.lbStt = new System.Windows.Forms.Label();
            this.txtSotienthu = new System.Windows.Forms.TextBox();
            this.dtNgaythutien = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtBienso = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbĐT = new System.Windows.Forms.Label();
            this.lbNtt = new System.Windows.Forms.Label();
            this.lbBs = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.grLPTT = new System.Windows.Forms.GroupBox();
            this.dataLPTT = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grTTKH.SuspendLayout();
            this.grLPTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLPTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 66);
            this.label1.TabIndex = 9;
            this.label1.Text = "PHIẾU THU TIỀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grTTKH
            // 
            this.grTTKH.Controls.Add(this.load);
            this.grTTKH.Controls.Add(this.lbStt);
            this.grTTKH.Controls.Add(this.txtSotienthu);
            this.grTTKH.Controls.Add(this.dtNgaythutien);
            this.grTTKH.Controls.Add(this.btThem);
            this.grTTKH.Controls.Add(this.btSua);
            this.grTTKH.Controls.Add(this.btXoa);
            this.grTTKH.Controls.Add(this.txtEmail);
            this.grTTKH.Controls.Add(this.txtSdt);
            this.grTTKH.Controls.Add(this.txtBienso);
            this.grTTKH.Controls.Add(this.txtHT);
            this.grTTKH.Controls.Add(this.lbEmail);
            this.grTTKH.Controls.Add(this.lbĐT);
            this.grTTKH.Controls.Add(this.lbNtt);
            this.grTTKH.Controls.Add(this.lbBs);
            this.grTTKH.Controls.Add(this.lbHT);
            this.grTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTKH.Location = new System.Drawing.Point(14, 78);
            this.grTTKH.Name = "grTTKH";
            this.grTTKH.Size = new System.Drawing.Size(1133, 191);
            this.grTTKH.TabIndex = 8;
            this.grTTKH.TabStop = false;
            this.grTTKH.Text = "Thông tin phiếu thu tiền";
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
            // lbStt
            // 
            this.lbStt.Location = new System.Drawing.Point(586, 106);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(98, 24);
            this.lbStt.TabIndex = 24;
            this.lbStt.Text = "Số tiền thu";
            // 
            // txtSotienthu
            // 
            this.txtSotienthu.Location = new System.Drawing.Point(690, 98);
            this.txtSotienthu.Name = "txtSotienthu";
            this.txtSotienthu.Size = new System.Drawing.Size(423, 27);
            this.txtSotienthu.TabIndex = 23;
            // 
            // dtNgaythutien
            // 
            this.dtNgaythutien.CustomFormat = "";
            this.dtNgaythutien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaythutien.Location = new System.Drawing.Point(140, 98);
            this.dtNgaythutien.Name = "dtNgaythutien";
            this.dtNgaythutien.Size = new System.Drawing.Size(423, 27);
            this.dtNgaythutien.TabIndex = 22;
            this.dtNgaythutien.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(690, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(423, 27);
            this.txtEmail.TabIndex = 12;
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
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(587, 71);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(85, 24);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // lbĐT
            // 
            this.lbĐT.Location = new System.Drawing.Point(6, 68);
            this.lbĐT.Name = "lbĐT";
            this.lbĐT.Size = new System.Drawing.Size(117, 24);
            this.lbĐT.TabIndex = 5;
            this.lbĐT.Text = "Điện thoại";
            // 
            // lbNtt
            // 
            this.lbNtt.Location = new System.Drawing.Point(6, 103);
            this.lbNtt.Name = "lbNtt";
            this.lbNtt.Size = new System.Drawing.Size(110, 24);
            this.lbNtt.TabIndex = 3;
            this.lbNtt.Text = "Ngày thu tiền";
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
            // grLPTT
            // 
            this.grLPTT.Controls.Add(this.dataLPTT);
            this.grLPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLPTT.Location = new System.Drawing.Point(11, 279);
            this.grLPTT.Name = "grLPTT";
            this.grLPTT.Size = new System.Drawing.Size(1136, 286);
            this.grLPTT.TabIndex = 12;
            this.grLPTT.TabStop = false;
            this.grLPTT.Text = "Danh sách khách hàng";
            // 
            // dataLPTT
            // 
            this.dataLPTT.AllowUserToAddRows = false;
            this.dataLPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLPTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLPTT.Location = new System.Drawing.Point(3, 23);
            this.dataLPTT.Name = "dataLPTT";
            this.dataLPTT.ReadOnly = true;
            this.dataLPTT.RowTemplate.Height = 24;
            this.dataLPTT.Size = new System.Drawing.Size(1130, 260);
            this.dataLPTT.TabIndex = 0;
            this.dataLPTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLPTT_CellContentClick);
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
            // LapPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 577);
            this.Controls.Add(this.grLPTT);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grTTKH);
            this.Name = "LapPhieuThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Thu Tiền";
            this.Load += new System.EventHandler(this.LapPhieuThuTien_Load);
            this.grTTKH.ResumeLayout(false);
            this.grTTKH.PerformLayout();
            this.grLPTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLPTT)).EndInit();
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

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grTTKH;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.TextBox txtSotienthu;
        private System.Windows.Forms.DateTimePicker dtNgaythutien;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtBienso;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbĐT;
        private System.Windows.Forms.Label lbNtt;
        private System.Windows.Forms.Label lbBs;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.GroupBox grLPTT;
        private System.Windows.Forms.DataGridView dataLPTT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.Button load;
    }
}

