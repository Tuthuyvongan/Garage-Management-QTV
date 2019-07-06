namespace Test
{
    partial class LapPhieuSuaChua
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
            this.cbPhuTung = new System.Windows.Forms.ComboBox();
            this.lbPhuTung = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBS = new System.Windows.Forms.ComboBox();
            this.cbDV = new System.Windows.Forms.ComboBox();
            this.cbGTC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btchitiet = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ngaysuachua = new System.Windows.Forms.DateTimePicker();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPhuTung
            // 
            this.cbPhuTung.DisplayMember = "tenphutung";
            this.cbPhuTung.FormattingEnabled = true;
            this.cbPhuTung.Location = new System.Drawing.Point(145, 136);
            this.cbPhuTung.Name = "cbPhuTung";
            this.cbPhuTung.Size = new System.Drawing.Size(304, 24);
            this.cbPhuTung.TabIndex = 0;
            this.cbPhuTung.ValueMember = "tenphutung";
            this.cbPhuTung.SelectedIndexChanged += new System.EventHandler(this.cbPhuTung_SelectedIndexChanged);
            // 
            // lbPhuTung
            // 
            this.lbPhuTung.DisplayMember = "dongia";
            this.lbPhuTung.FormattingEnabled = true;
            this.lbPhuTung.Location = new System.Drawing.Point(145, 166);
            this.lbPhuTung.Name = "lbPhuTung";
            this.lbPhuTung.Size = new System.Drawing.Size(304, 24);
            this.lbPhuTung.TabIndex = 4;
            this.lbPhuTung.ValueMember = "dongia";
            this.lbPhuTung.SelectedIndexChanged += new System.EventHandler(this.lbPhuTung_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên phụ tùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biển số xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá phụ tùng";
            // 
            // cbBS
            // 
            this.cbBS.DisplayMember = "bienso";
            this.cbBS.FormattingEnabled = true;
            this.cbBS.Location = new System.Drawing.Point(221, 78);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(123, 24);
            this.cbBS.TabIndex = 8;
            this.cbBS.ValueMember = "bienso";
            this.cbBS.SelectedIndexChanged += new System.EventHandler(this.cbBS_SelectedIndexChanged);
            // 
            // cbDV
            // 
            this.cbDV.DisplayMember = "tendichvu";
            this.cbDV.FormattingEnabled = true;
            this.cbDV.Location = new System.Drawing.Point(650, 136);
            this.cbDV.Name = "cbDV";
            this.cbDV.Size = new System.Drawing.Size(304, 24);
            this.cbDV.TabIndex = 9;
            this.cbDV.ValueMember = "tendichvu";
            this.cbDV.SelectedIndexChanged += new System.EventHandler(this.cbDV_SelectedIndexChanged);
            // 
            // cbGTC
            // 
            this.cbGTC.DisplayMember = "tiencong";
            this.cbGTC.FormattingEnabled = true;
            this.cbGTC.Location = new System.Drawing.Point(650, 166);
            this.cbGTC.Name = "cbGTC";
            this.cbGTC.Size = new System.Drawing.Size(304, 24);
            this.cbGTC.TabIndex = 10;
            this.cbGTC.ValueMember = "tiencong";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(544, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên dịch vụ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(544, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tiền công";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(39, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(145, 196);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(304, 22);
            this.txtsoluong.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày sửa chữa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "PHIẾU SỬA CHỮA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Thành tiền";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(282, 239);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 34);
            this.btThem.TabIndex = 20;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(406, 239);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 34);
            this.btXoa.TabIndex = 21;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btchitiet
            // 
            this.btchitiet.Location = new System.Drawing.Point(626, 239);
            this.btchitiet.Name = "btchitiet";
            this.btchitiet.Size = new System.Drawing.Size(147, 34);
            this.btchitiet.TabIndex = 22;
            this.btchitiet.Text = "Chi tiết phiếu";
            this.btchitiet.UseVisualStyleBackColor = true;
            this.btchitiet.Click += new System.EventHandler(this.btchitiet_Click);
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
            // ngaysuachua
            // 
            this.ngaysuachua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysuachua.Location = new System.Drawing.Point(733, 80);
            this.ngaysuachua.Name = "ngaysuachua";
            this.ngaysuachua.Size = new System.Drawing.Size(200, 22);
            this.ngaysuachua.TabIndex = 15;
            this.ngaysuachua.Value = new System.DateTime(2019, 7, 5, 0, 0, 0, 0);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Enabled = false;
            this.txtThanhtien.Location = new System.Drawing.Point(650, 196);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(304, 22);
            this.txtThanhtien.TabIndex = 23;
            // 
            // LapPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 303);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.btchitiet);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ngaysuachua);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGTC);
            this.Controls.Add(this.cbDV);
            this.Controls.Add(this.cbBS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPhuTung);
            this.Controls.Add(this.cbPhuTung);
            this.Name = "LapPhieuSuaChua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapPhieuSuaChua";
            this.Load += new System.EventHandler(this.LapPhieuSuaChua_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btchitiet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        public System.Windows.Forms.ComboBox cbPhuTung;
        public System.Windows.Forms.ComboBox lbPhuTung;
        public System.Windows.Forms.ComboBox cbBS;
        public System.Windows.Forms.ComboBox cbDV;
        public System.Windows.Forms.ComboBox cbGTC;
        public System.Windows.Forms.TextBox txtsoluong;
        public System.Windows.Forms.DateTimePicker ngaysuachua;
        private System.Windows.Forms.TextBox txtThanhtien;
    }
}