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
    public partial class NhapHang_View : Form
    {
        public NhapHang_View()
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

        private void bt9_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOADONNHAP_VIEW hdn = new HOADONNHAP_VIEW();
            hdn.Show();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiXe_View lx = new LoaiXe_View();
            lx.Show();
        }

        private void btcthdnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_HDNHAP_VIEW cthdn = new CT_HDNHAP_VIEW();
            cthdn.Show();

        }

        private void bt12_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
    }
}
