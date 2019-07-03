using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quản_lý_điểm_sinh_vien_CNTT
{
    public partial class ReportDSSV : Form
    {
        public ReportDSSV()
        {
            InitializeComponent();
        }

        private void ReportDSSV_Load(object sender, EventArgs e)
        {

            this.tblSINH_VIENTableAdapter.Fill(this.DataSetDSSV.tblSINH_VIEN);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
