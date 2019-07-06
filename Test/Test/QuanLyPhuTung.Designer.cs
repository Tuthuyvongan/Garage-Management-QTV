namespace Test
{
    partial class QuanLyPhuTung
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
            this.QLPT = new System.Windows.Forms.TabControl();
            this.tabQL = new System.Windows.Forms.TabPage();
            this.btLoad = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPhuTung = new System.Windows.Forms.DataGridView();
            this.txttđ = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txttenphutung = new System.Windows.Forms.TextBox();
            this.txtmaphutung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTK = new System.Windows.Forms.TabPage();
            this.btTK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtTimKiem = new System.Windows.Forms.DataGridView();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.QLPT.SuspendLayout();
            this.tabQL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhuTung)).BeginInit();
            this.tabTK.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // QLPT
            // 
            this.QLPT.Controls.Add(this.tabQL);
            this.QLPT.Controls.Add(this.tabTK);
            this.QLPT.Location = new System.Drawing.Point(0, -2);
            this.QLPT.Name = "QLPT";
            this.QLPT.SelectedIndex = 0;
            this.QLPT.Size = new System.Drawing.Size(798, 526);
            this.QLPT.TabIndex = 0;
            // 
            // tabQL
            // 
            this.tabQL.Controls.Add(this.btLoad);
            this.tabQL.Controls.Add(this.btXoa);
            this.tabQL.Controls.Add(this.btSua);
            this.tabQL.Controls.Add(this.btThem);
            this.tabQL.Controls.Add(this.groupBox1);
            this.tabQL.Controls.Add(this.txttđ);
            this.tabQL.Controls.Add(this.txttc);
            this.tabQL.Controls.Add(this.txtdongia);
            this.tabQL.Controls.Add(this.txttenphutung);
            this.tabQL.Controls.Add(this.txtmaphutung);
            this.tabQL.Controls.Add(this.label5);
            this.tabQL.Controls.Add(this.label4);
            this.tabQL.Controls.Add(this.label3);
            this.tabQL.Controls.Add(this.label2);
            this.tabQL.Controls.Add(this.label1);
            this.tabQL.Location = new System.Drawing.Point(4, 25);
            this.tabQL.Name = "tabQL";
            this.tabQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabQL.Size = new System.Drawing.Size(790, 497);
            this.tabQL.TabIndex = 0;
            this.tabQL.Text = "Quản lý phụ tùng";
            this.tabQL.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(686, 150);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 14;
            this.btLoad.Text = "Xem ";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(575, 150);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(466, 150);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 12;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(361, 149);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 24);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPhuTung);
            this.groupBox1.Location = new System.Drawing.Point(3, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 309);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phụ tùng";
            // 
            // dtPhuTung
            // 
            this.dtPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhuTung.Location = new System.Drawing.Point(0, 22);
            this.dtPhuTung.Name = "dtPhuTung";
            this.dtPhuTung.RowTemplate.Height = 24;
            this.dtPhuTung.Size = new System.Drawing.Size(784, 276);
            this.dtPhuTung.TabIndex = 0;
            this.dtPhuTung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPhuTung_CellContentClick);
            // 
            // txttđ
            // 
            this.txttđ.Location = new System.Drawing.Point(531, 48);
            this.txttđ.Name = "txttđ";
            this.txttđ.Size = new System.Drawing.Size(177, 22);
            this.txttđ.TabIndex = 9;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(531, 96);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(177, 22);
            this.txttc.TabIndex = 8;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(144, 150);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(162, 22);
            this.txtdongia.TabIndex = 7;
            // 
            // txttenphutung
            // 
            this.txttenphutung.Location = new System.Drawing.Point(144, 99);
            this.txttenphutung.Name = "txttenphutung";
            this.txttenphutung.Size = new System.Drawing.Size(162, 22);
            this.txttenphutung.TabIndex = 6;
            // 
            // txtmaphutung
            // 
            this.txtmaphutung.Location = new System.Drawing.Point(144, 48);
            this.txtmaphutung.Name = "txtmaphutung";
            this.txtmaphutung.Size = new System.Drawing.Size(162, 22);
            this.txtmaphutung.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(336, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng nhập về";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(336, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng còn tồn kho";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phụ tùng";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phụ tùng";
            // 
            // tabTK
            // 
            this.tabTK.Controls.Add(this.btTK);
            this.tabTK.Controls.Add(this.groupBox2);
            this.tabTK.Controls.Add(this.txtTK);
            this.tabTK.Controls.Add(this.label6);
            this.tabTK.Location = new System.Drawing.Point(4, 25);
            this.tabTK.Name = "tabTK";
            this.tabTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabTK.Size = new System.Drawing.Size(790, 497);
            this.tabTK.TabIndex = 1;
            this.tabTK.Text = "Tìm kiếm phụ tùng";
            this.tabTK.UseVisualStyleBackColor = true;
            // 
            // btTK
            // 
            this.btTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTK.Location = new System.Drawing.Point(535, 97);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(109, 34);
            this.btTK.TabIndex = 3;
            this.btTK.Text = "Tìm kiếm";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(5, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 345);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dtTimKiem
            // 
            this.dtTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTimKiem.Location = new System.Drawing.Point(-1, 22);
            this.dtTimKiem.Name = "dtTimKiem";
            this.dtTimKiem.RowTemplate.Height = 24;
            this.dtTimKiem.Size = new System.Drawing.Size(786, 324);
            this.dtTimKiem.TabIndex = 0;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(238, 103);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(250, 22);
            this.txtTK.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập dữ liệu về phụ tùng cần tìm";
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
            // QuanLyPhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.QLPT);
            this.Name = "QuanLyPhuTung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyPhuTung";
            this.Load += new System.EventHandler(this.QuanLyPhuTung_Load);
            this.QLPT.ResumeLayout(false);
            this.tabQL.ResumeLayout(false);
            this.tabQL.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPhuTung)).EndInit();
            this.tabTK.ResumeLayout(false);
            this.tabTK.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl QLPT;
        private System.Windows.Forms.TabPage tabQL;
        private System.Windows.Forms.TabPage tabTK;
        private System.Windows.Forms.TextBox txttđ;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txttenphutung;
        private System.Windows.Forms.TextBox txtmaphutung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtPhuTung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtTimKiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btTK;
    }
}