﻿using System;
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
        public void SetNull()
        {
            txtMa_HS.Text = txtHoTen_HS.Text = txtDiaChi.Text = txtPhuHuynh.Text = cbGT_HS.Text = cbLop.Text = cbTK_HS.Text = txtTK_HS.Text = "";
            dtpNgaySinh_HS.Text = DateTime.Now.ToShortDateString();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGT_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhuHuynh.Text = dgvHocSinh.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbLop.Text = dgvHocSinh.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            { }
        }
        private void btnSua_HS_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            txtMa_HS.Enabled = false;
            //chon = 1;
        }

        private void btnXoa_HS_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //hs.Xoa_HS(txtMa_HS.Text);
                MessageBox.Show("Xóa thành công!");
                //Hoc_Sinh_Load(sender, e);
                SetNull();
            }
        }
    }
}
