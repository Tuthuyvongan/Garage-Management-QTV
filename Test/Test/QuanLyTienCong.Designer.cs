namespace Test
{
    partial class QuanLyTienCong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txttdv = new System.Windows.Forms.TextBox();
            this.txttmtc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTiencong = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtNTT = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNTT = new System.Windows.Forms.TextBox();
            this.btTK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiencong)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_xoa);
            this.panel1.Controls.Add(this.button_Sua);
            this.panel1.Controls.Add(this.button_them);
            this.panel1.Controls.Add(this.txttc);
            this.panel1.Controls.Add(this.txttdv);
            this.panel1.Controls.Add(this.txttmtc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 128);
            this.panel1.TabIndex = 0;
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(588, 31);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(92, 54);
            this.button_xoa.TabIndex = 8;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(458, 29);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(97, 56);
            this.button_Sua.TabIndex = 7;
            this.button_Sua.Text = "Xem thông tin";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(320, 30);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(101, 55);
            this.button_them.TabIndex = 6;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(136, 85);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(136, 22);
            this.txttc.TabIndex = 5;
            // 
            // txttdv
            // 
            this.txttdv.Location = new System.Drawing.Point(137, 50);
            this.txttdv.Name = "txttdv";
            this.txttdv.Size = new System.Drawing.Size(135, 22);
            this.txttdv.TabIndex = 4;
            // 
            // txttmtc
            // 
            this.txttmtc.Location = new System.Drawing.Point(137, 13);
            this.txttmtc.Name = "txttmtc";
            this.txttmtc.Size = new System.Drawing.Size(135, 22);
            this.txttmtc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền công:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại dịch vụ:";
            // 
            // dgvTiencong
            // 
            this.dgvTiencong.AllowUserToAddRows = false;
            this.dgvTiencong.AllowUserToDeleteRows = false;
            this.dgvTiencong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiencong.Location = new System.Drawing.Point(1, 137);
            this.dgvTiencong.Name = "dgvTiencong";
            this.dgvTiencong.ReadOnly = true;
            this.dgvTiencong.RowTemplate.Height = 24;
            this.dgvTiencong.Size = new System.Drawing.Size(693, 210);
            this.dgvTiencong.TabIndex = 1;
            this.dgvTiencong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiencong_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 380);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTiencong);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btTK);
            this.tabPage2.Controls.Add(this.txtNTT);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtNTT);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtNTT
            // 
            this.dtNTT.AllowUserToAddRows = false;
            this.dtNTT.AllowUserToDeleteRows = false;
            this.dtNTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNTT.Location = new System.Drawing.Point(0, 106);
            this.dtNTT.Name = "dtNTT";
            this.dtNTT.ReadOnly = true;
            this.dtNTT.RowTemplate.Height = 24;
            this.dtNTT.Size = new System.Drawing.Size(699, 245);
            this.dtNTT.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập thông tin dịch vụ cần tìm";
            // 
            // txtNTT
            // 
            this.txtNTT.Location = new System.Drawing.Point(216, 58);
            this.txtNTT.Name = "txtNTT";
            this.txtNTT.Size = new System.Drawing.Size(231, 22);
            this.txtNTT.TabIndex = 2;
            // 
            // btTK
            // 
            this.btTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTK.Location = new System.Drawing.Point(472, 51);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(101, 35);
            this.btTK.TabIndex = 3;
            this.btTK.Text = "Tìm Kiếm";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // QuanLyTienCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 375);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyTienCong";
            this.Text = "Quản lý tiền công";
            this.Load += new System.EventHandler(this.QuanLyTienCong_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiencong)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txttdv;
        private System.Windows.Forms.TextBox txttmtc;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.DataGridView dgvTiencong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.TextBox txtNTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtNTT;
    }
}