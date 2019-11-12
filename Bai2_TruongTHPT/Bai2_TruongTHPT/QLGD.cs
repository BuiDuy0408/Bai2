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
        Lop l = new Lop();
        MonHon mh = new MonHon();
        GiaoVien gv = new GiaoVien();
        CTGD ct = new CTGD();
        int selection = 0;
        public QLGD()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
