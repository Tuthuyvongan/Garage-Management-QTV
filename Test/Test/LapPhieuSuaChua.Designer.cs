﻿namespace Test
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
            this.cbPhuTung = new System.Windows.Forms.ComboBox();
            this.btLayGia = new System.Windows.Forms.Button();
            this.lbPhuTung = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbPhuTung
            // 
            this.cbPhuTung.DisplayMember = "tenphutung";
            this.cbPhuTung.FormattingEnabled = true;
            this.cbPhuTung.Location = new System.Drawing.Point(51, 37);
            this.cbPhuTung.Name = "cbPhuTung";
            this.cbPhuTung.Size = new System.Drawing.Size(130, 24);
            this.cbPhuTung.TabIndex = 0;
            this.cbPhuTung.ValueMember = "tenphutung";
            // 
            // btLayGia
            // 
            this.btLayGia.Location = new System.Drawing.Point(62, 128);
            this.btLayGia.Name = "btLayGia";
            this.btLayGia.Size = new System.Drawing.Size(75, 38);
            this.btLayGia.TabIndex = 2;
            this.btLayGia.Text = "Lấy giá";
            this.btLayGia.UseVisualStyleBackColor = true;
            this.btLayGia.Click += new System.EventHandler(this.btLayGia_Click);
            // 
            // lbPhuTung
            // 
            this.lbPhuTung.DisplayMember = "dongia";
            this.lbPhuTung.FormattingEnabled = true;
            this.lbPhuTung.ItemHeight = 16;
            this.lbPhuTung.Location = new System.Drawing.Point(202, 37);
            this.lbPhuTung.Name = "lbPhuTung";
            this.lbPhuTung.Size = new System.Drawing.Size(256, 36);
            this.lbPhuTung.TabIndex = 3;
            this.lbPhuTung.ValueMember = "dongia";
            // 
            // LapPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPhuTung);
            this.Controls.Add(this.btLayGia);
            this.Controls.Add(this.cbPhuTung);
            this.Name = "LapPhieuSuaChua";
            this.Text = "LapPhieuSuaChua";
            this.Load += new System.EventHandler(this.LapPhieuSuaChua_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPhuTung;
        private System.Windows.Forms.Button btLayGia;
        private System.Windows.Forms.ListBox lbPhuTung;
    }
}