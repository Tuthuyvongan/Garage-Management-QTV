namespace Test
{
    partial class ManHinhDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.buttondangnhap = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(88, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // textBoxuser
            // 
            this.textBoxuser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxuser.Location = new System.Drawing.Point(202, 47);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(207, 22);
            this.textBoxuser.TabIndex = 2;
            // 
            // textBoxpass
            // 
            this.textBoxpass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxpass.Location = new System.Drawing.Point(202, 100);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(207, 22);
            this.textBoxpass.TabIndex = 3;
            this.textBoxpass.UseSystemPasswordChar = true;
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.BackColor = System.Drawing.SystemColors.Control;
            this.buttondangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttondangnhap.Location = new System.Drawing.Point(213, 160);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(121, 47);
            this.buttondangnhap.TabIndex = 4;
            this.buttondangnhap.Text = "Đăng nhập";
            this.buttondangnhap.UseVisualStyleBackColor = false;
            this.buttondangnhap.Click += new System.EventHandler(this.buttondangnhap_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonthoat.Location = new System.Drawing.Point(353, 160);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(109, 47);
            this.buttonthoat.TabIndex = 5;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // ManHinhDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.abstract_background_diagonal_blue_gradient_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 228);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttondangnhap);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManHinhDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManHinhDangNhap_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button buttondangnhap;
        private System.Windows.Forms.Button buttonthoat;
    }
}