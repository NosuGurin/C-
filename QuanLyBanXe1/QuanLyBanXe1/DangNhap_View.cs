using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanXe_BUS;
using QuanLyBanXe1;


namespace QuanLyBanXe1
{
    public partial class DangNhap_View : Form
    {
        public DangNhap_View()
        {
            InitializeComponent();
        }

        NhanVien_BUS nvbus = new NhanVien_BUS();
        QuanLyBanXe_View qlbxv = new QuanLyBanXe_View();

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
            lbstatus.ResetText();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tài khoản","Thông báo");

            }
            else if (txtmk.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mật khẩu", "Thông báo");
            }
            else
            {
                string a=txttk.Text;
                string b=txtmk.Text;

                DataTable dt = new DataTable();
                dt = nvbus.KiemTraDN(a,b);
                if (dt.Rows.Count > 0)
                {
                    lbstatus.ForeColor = Color.Red;
                    lbstatus.Text = "Đăng nhập thành công";
                    string cv = nvbus.LayThongTinChucVu(a);
                    if(cv == "thukho"){
                        this.Hide();
                        ThuKho_View tk = new ThuKho_View();
                        tk.Show();
                    }else if(cv == "banhang"){
                        this.Hide();
                        BanHang_View bh = new BanHang_View();
                        bh.Show();
                    }else if(cv == "nhaphang"){
                        this.Hide();
                        NhapHang_View nh = new NhapHang_View();
                        nh.Show();

                    }
                    else
                    {
                        this.Hide();
                        qlbxv.Show();
                    }
                    
                }
                else
                {
                    lbstatus.ForeColor = Color.Red;
                    lbstatus.Text = "Đăng nhập thất bại";
                    txttk.Text = "";
                    txtmk.Text = "";
                    
                }
            }
        }

        private void DangNhap_View_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        
    }
}
