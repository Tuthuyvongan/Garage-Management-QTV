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
            this.btXoa = new System.Windows.Forms.Button();
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
            this.txtHieuXe.Location = new System.Drawing.Point(115, 43);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(192, 22);
            this.txtHieuXe.TabIndex = 0;
            // 
            // lbHieuXe
            // 
            this.lbHieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHieuXe.Location = new System.Drawing.Point(0, 43);
            this.lbHieuXe.Name = "lbHieuXe";
            this.lbHieuXe.Size = new System.Drawing.Size(105, 22);
            this.lbHieuXe.TabIndex = 1;
            this.lbHieuXe.Text = "Tên hiệu xe";
            // 
            // grHieuXe
            // 
            this.grHieuXe.Controls.Add(this.btLoad);
            this.grHieuXe.Controls.Add(this.btXoa);
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
            this.btLoad.Location = new System.Drawing.Point(198, 111);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(109, 55);
            this.btLoad.TabIndex = 7;
            this.btLoad.Text = "Xem hiệu xe hiện có";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(51, 141);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(130, 48);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa hiệu xe";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(51, 87);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(130, 48);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grCHX;
        private System.Windows.Forms.DataGridView dtHieuXe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btLoad;
    }
}