using BUS;
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
    public partial class QLGD : Form
    {
        public QLGD()
        {
            InitializeComponent();
        }

        Lop l = new Lop();
        MonHon mh = new MonHon();
        GiaoVien gv = new GiaoVien();
        CTGD ct = new CTGD();
        int selection = 0;
        public void SetNull()
        {
            txtTiet.Text = "";
            cboTenMon.Enabled = cboTenGV.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            SetNull();
            selection = 1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            cboTenMon.Enabled = cboTenGV.Enabled = true;
            selection = 2;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboTenMon.SelectedValue.ToString());
            ct.XoaCTGD(cboTenLop.ValueMember, cboTenMon.ValueMember);
            //dataGridView1.DataSource = ct.Show(cboTenMon.Text);
            MessageBox.Show("Xóa dữ liệu thành công");
        }
        private void CboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
