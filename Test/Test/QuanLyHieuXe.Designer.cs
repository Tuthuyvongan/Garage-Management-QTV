namespace Test
{
    partial class QuanLyHieuXe
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
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.lbHieuXe = new System.Windows.Forms.Label();
            this.grHieuXe = new System.Windows.Forms.GroupBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.txtMahieuxe = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.grCHX = new System.Windows.Forms.GroupBox();
            this.dtHieuXe = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grHieuXe.SuspendLayout();
            this.grCHX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHieuXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(115, 59);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(192, 22);
            this.txtHieuXe.TabIndex = 0;
            // 
            // lbHieuXe
            // 
            this.lbHieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHieuXe.Location = new System.Drawing.Point(4, 59);
            this.lbHieuXe.Name = "lbHieuXe";
            this.lbHieuXe.Size = new System.Drawing.Size(105, 22);
            this.lbHieuXe.TabIndex = 1;
            this.lbHieuXe.Text = "Tên hiệu xe";
            // 
            // grHieuXe
            // 
            this.grHieuXe.Controls.Add(this.btLoad);
            this.grHieuXe.Controls.Add(this.lbID);
            this.grHieuXe.Controls.Add(this.txtMahieuxe);
            this.grHieuXe.Controls.Add(this.btXoa);
            this.grHieuXe.Controls.Add(this.btSua);
            this.grHieuXe.Controls.Add(this.btThem);
            this.grHieuXe.Controls.Add(this.lbHieuXe);
            this.grHieuXe.Controls.Add(this.txtHieuXe);
            this.grHieuXe.Location = new System.Drawing.Point(12, 25);
            this.grHieuXe.Name = "grHieuXe";
            this.grHieuXe.Size = new System.Drawing.Size(356, 213);
            this.grHieuXe.TabIndex = 2;
            this.grHieuXe.TabStop = false;
            this.grHieuXe.Text = "Quản lý hiệu xe";
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(226, 112);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(92, 55);
            this.btLoad.TabIndex = 7;
            this.btLoad.Text = "Xem hiệu xe hiện có";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(8, 31);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(101, 22);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "Mã hiệu xe ";
            // 
            // txtMahieuxe
            // 
            this.txtMahieuxe.Location = new System.Drawing.Point(115, 31);
            this.txtMahieuxe.Name = "txtMahieuxe";
            this.txtMahieuxe.Size = new System.Drawing.Size(192, 22);
            this.txtMahieuxe.TabIndex = 5;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(69, 161);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(130, 31);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa hiệu xe";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(69, 124);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(130, 31);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa hiệu xe";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(69, 87);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(130, 31);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm hiệu xe";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // grCHX
            // 
            this.grCHX.Controls.Add(this.dtHieuXe);
            this.grCHX.Location = new System.Drawing.Point(389, 25);
            this.grCHX.Name = "grCHX";
            this.grCHX.Size = new System.Drawing.Size(387, 213);
            this.grCHX.TabIndex = 3;
            this.grCHX.TabStop = false;
            this.grCHX.Text = "Các hiệu xe hiện tại";
            // 
            // dtHieuXe
            // 
            this.dtHieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHieuXe.Location = new System.Drawing.Point(0, 22);
            this.dtHieuXe.Name = "dtHieuXe";
            this.dtHieuXe.RowTemplate.Height = 24;
            this.dtHieuXe.Size = new System.Drawing.Size(387, 191);
            this.dtHieuXe.TabIndex = 0;
            this.dtHieuXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHieuXe_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // QuanLyHieuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.grCHX);
            this.Controls.Add(this.grHieuXe);
            this.Name = "QuanLyHieuXe";
            this.Text = "QuanLyHieuXe";
            this.Load += new System.EventHandler(this.QuanLyHieuXe_Load);
            this.grHieuXe.ResumeLayout(false);
            this.grHieuXe.PerformLayout();
            this.grCHX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHieuXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHieuXe;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.GroupBox grHieuXe;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grCHX;
        private System.Windows.Forms.DataGridView dtHieuXe;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtMahieuxe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btLoad;
    }
}