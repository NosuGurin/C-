using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanXe1;
using QuanLyBanXe_BUS;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe1
{
    public partial class DoiMatKhau_View : Form
    {
        NhanVien_BUS nvbus = new NhanVien_BUS();
        NhanVien nv = new NhanVien();
        public DoiMatKhau_View()
        {
            InitializeComponent();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            txtmkcu.Text = "";
            txtmkmoi.Text = "";
            txtmkmoi1.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)){
                this.Hide();
                QuanLyBanXe_View qlbx = new QuanLyBanXe_View();
                qlbx.Show();
            }
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            string c, b;
            try
            {
                if (txtmkcu.Text == "")
            {
                lbstatus.ForeColor = Color.Red;
                lbstatus.Text = "Bạn chưa nhập mật khẩu cũ";
            }
            else if(txtmkmoi.Text == ""){
                lbstatus.ForeColor = Color.Red;
                lbstatus.Text = "Bạn chưa nhập mật khẩu mới";
            }
            else if (txtmkmoi1.Text == "")
            {
                lbstatus.ForeColor = Color.Red;
                lbstatus.Text = "Bạn chưa nhập lại mật khẩu mới";

            }
            else
            {
                int a = nvbus.KiemTraPass(txtmkcu.Text);
                if(a <=0 ){
                    MessageBox.Show("Mật khẩu cũ của bạn không đúng!","Thông báo");
                }
                else
                {
                    if (txtmkmoi.Text != txtmkmoi1.Text)
                    {
                        MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu mới không trùng nhau!", "Thông báo");

                    }
                    else
                    {
                        c = txtmkmoi.Text;
                        b = txtmkcu.Text;
                        nvbus.SuaMatKhau(c,b);
                        MessageBox.Show("Đỗi mật khẩu thành công!", "Thông báo");
                        this.Hide();
                        QuanLyBanXe_View qlbx = new QuanLyBanXe_View ();
                        qlbx.Show();
                    }
                }
            }
            }
            catch{
                MessageBox.Show("Không thế sửa", "Thông báo");
            }
        }
    }
}
