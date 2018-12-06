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
    public partial class QuanLyBanXe_View : Form
    {
        public QuanLyBanXe_View()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xe_View xv = new Xe_View();
            xv.Show();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiXe_View lxv = new LoaiXe_View();
            lxv.Show();
            
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaSanXuat_View nsxv = new NhaSanXuat_View();
            nsxv.Show();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap_View nccv = new NhaCungCap_View();
            nccv.Show();
        }

        

        private void bt6_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang_View khv = new KhachHang_View();
            khv.Show();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien_View nvv = new NhanVien_View();
            nvv.Show();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOADONBAN_VIEW hdbv = new HOADONBAN_VIEW();
            hdbv.Show();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOADONNHAP_VIEW hdnv = new HOADONNHAP_VIEW();
            hdnv.Show();
        }

        

        

        private void bt12_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Hide();
                DangNhap_View dn = new DangNhap_View();
                dn.Show();
            }
        }

        private void btcthdnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_HDNHAP_VIEW cthdn = new CT_HDNHAP_VIEW();
            cthdn.Show();
        }

        private void btcthdban_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_HDBAN_VIEW cthdb = new CT_HDBAN_VIEW();
            cthdb.Show();
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau_View doimk = new DoiMatKhau_View();
            doimk.Show();
        }

        private void btbaocaocthdb_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btbccthdn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        
        

        

        
    }
}
