using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanXe1
{
    public partial class BanHang_View : Form
    {
        public BanHang_View()
        {
            InitializeComponent();
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau_View dmk = new DoiMatKhau_View();
            dmk.Show();
        }

        private void btxe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xe_View x = new Xe_View();
            x.Show();
        }

        private void btncc_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap_View ncc = new NhaCungCap_View();
            ncc.Show();
        }

        private void bthdban_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOADONBAN_VIEW hdb = new HOADONBAN_VIEW();
            hdb.Show();
        }

        private void btloai_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiXe_View lx = new LoaiXe_View();
            lx.Show();
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaSanXuat_View nsx = new NhaSanXuat_View();
            nsx.Show();
        }

        private void btkh_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang_View kh = new KhachHang_View();
            kh.Show();
        }

        private void btcthdban_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_HDBAN_VIEW cthdb = new CT_HDBAN_VIEW();
            cthdb.Show();
        }
    }
}
