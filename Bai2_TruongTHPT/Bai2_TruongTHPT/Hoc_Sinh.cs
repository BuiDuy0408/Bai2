using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_TruongTHPT
{
    public partial class Hoc_Sinh : Form
    {
        public Hoc_Sinh()
        {
            InitializeComponent();
        }

        private void TxtMa_HS_TextChanged(object sender, EventArgs e)
        {

        }
        public void KhoiTao()
        {
            txtHoTen_HS.Enabled = txtPhuHuynh.Enabled = cbGT_HS.Enabled = cbLop.Enabled = dtpNgaySinh_HS.Enabled = txtDiaChi.Enabled = false;
            btnThem_HS.Enabled = btnSua_HS.Enabled = btnXoa_HS.Enabled = true;
            btnLuu_HS.Enabled = false;
        }
        public void Mo()
        {
            txtHoTen_HS.Enabled = txtPhuHuynh.Enabled = cbGT_HS.Enabled = cbLop.Enabled = dtpNgaySinh_HS.Enabled = txtDiaChi.Enabled = true;
            btnThem_HS.Enabled = btnSua_HS.Enabled = btnXoa_HS.Enabled = false;
            btnLuu_HS.Enabled = true;
        }

    }
}
