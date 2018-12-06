using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanXe_BUS;
using QuanLyBanXe_ENTITY;
using QuanLyBanXe_DAL;
using QuanLyBanXe1;

namespace QuanLyBanXe1
{
    public partial class ThuKho_View : Form
    {
        public ThuKho_View()
        {
            InitializeComponent();
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau_View dmk = new DoiMatKhau_View();
            dmk.Show();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xe_View xe = new Xe_View();
            xe.Show();

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiXe_View lsp = new LoaiXe_View();
            lsp.Show();
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btkh_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang_View kh = new KhachHang_View();
            kh.Show();
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaSanXuat_View nsx = new NhaSanXuat_View();
            nsx.Show();
        }

        private void btncc_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap_View ncc = new NhaCungCap_View();
            ncc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
           
        }
    }
}
