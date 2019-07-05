namespace Test
{
    partial class ChiTietPhieuSuaChua
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
            this.dtchitiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtchitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtchitiet
            // 
            this.dtchitiet.AllowUserToAddRows = false;
            this.dtchitiet.AllowUserToDeleteRows = false;
            this.dtchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtchitiet.Location = new System.Drawing.Point(0, 0);
            this.dtchitiet.Name = "dtchitiet";
            this.dtchitiet.ReadOnly = true;
            this.dtchitiet.RowTemplate.Height = 24;
            this.dtchitiet.Size = new System.Drawing.Size(801, 449);
            this.dtchitiet.TabIndex = 0;
            this.dtchitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtchitiet_CellContentClick);
            // 
            // ChiTietPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtchitiet);
            this.Name = "ChiTietPhieuSuaChua";
            this.Text = "ChiTietPhieuSuaChua";
            this.Load += new System.EventHandler(this.ChiTietPhieuSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtchitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtchitiet;
    }
}