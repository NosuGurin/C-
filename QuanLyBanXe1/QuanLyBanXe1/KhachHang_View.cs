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
using QuanLyBanXe1;


namespace QuanLyBanXe1
{
    public partial class KhachHang_View : Form
    {
        public KhachHang_View()
        {
            InitializeComponent();
        }

        KhachHang kh = new KhachHang();
        KhachHang_BUS khbus = new KhachHang_BUS();
        bool themmoi;

        void KhoaDieuKhien()
        {
            txtmakh.Enabled = false;
            txttenkh.Enabled = false;
            txtdienthoai.Enabled = false;
            txtdiachi.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
            btthoat.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtmakh.Enabled = true;
            txttenkh.Enabled = true;
            txtdienthoai.Enabled = true;
            txtdiachi.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
            btthoat.Enabled = true;
        }

        void HienThi(string where)
        {
            dskh.DataSource = khbus.TaoBang(where);
        }

        void SetNull()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
        }

        private void KhachHang_View_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");

        }

       
        

        private void bttiemkiem_Click(object sender, EventArgs e)
        {
            HienThi("");
        }

        private void btthoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBanXe_View qlbxv = new QuanLyBanXe_View();
            qlbxv.Show();
        }

        private void btthem_Click_1(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            themmoi = true;
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtmakh.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    kh.Makh1 = txtmakh.Text;
                    khbus.XoaDuLieu(kh);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    KhoaDieuKhien();
                    HienThi("");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!Không xóa được", "Thông báo");
            }
        }

        private void btluu_Click_1(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo");
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        kh.Makh1 = txtmakh.Text;
                        kh.Tenkh1 = txttenkh.Text;
                        kh.Dienthoai1 = txtdienthoai.Text;
                        kh.Diachi1 = txtdiachi.Text;
                        if(khbus.KiemTraThem(txtmakh.Text) >0){
                            MessageBox.Show("Mã khách hàng không được trùng", "Thông báo");
                        }
                        else{
                            khbus.ThemDuLieu(kh);
                            MessageBox.Show("Đã thêm thành công", "Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không thêm được", "Thông báo");
                    }


                }
                else
                {
                    try
                    {
                        kh.Makh1 = txtmakh.Text;
                        kh.Tenkh1 = txttenkh.Text;
                        kh.Dienthoai1 = txtdienthoai.Text;
                        kh.Diachi1 = txtdiachi.Text;
                        khbus.SuaDuLieu(kh);
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không sửa được", "Thông báo");
                    }
                }
                KhoaDieuKhien();
                HienThi("");
            }
            

        }

        private void dskh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhoaDieuKhien();
                txtmakh.Text = dskh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenkh.Text = dskh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdienthoai.Text = dskh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdiachi.Text = dskh.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo");
            else
            {
                try
                {
                    if (rdbmakh.Checked && khbus.KiemTraMaKhachHang(txttimkiem.Text) != 0)
                    {
                        dskh.DataSource = khbus.LayThongTinMaKhacHang(txttimkiem.Text);

                    }
                    else if (rdbmakh.Checked && khbus.KiemTraMaKhachHang(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtenkh.Checked && khbus.KiemTraTenKhachHang(txttimkiem.Text) != 0)
                    {
                        dskh.DataSource = khbus.LayThongTinTenKhachHang(txttimkiem.Text);

                    }
                    else if (rdbtenkh.Checked && khbus.KiemTraTenKhachHang(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbdienthoai.Checked && khbus.KiemTraDienThoai(txttimkiem.Text) != 0)
                    {
                        dskh.DataSource = khbus.LayThongTinDienthoai(txttimkiem.Text);

                    }
                    else if (rdbdienthoai.Checked && khbus.KiemTraDienThoai(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbdiachi.Checked && khbus.KiemTraDiaChi(txttimkiem.Text) != 0)
                    {
                        dskh.DataSource = khbus.LayThongTinDiachi(txttimkiem.Text);

                    }
                    else if (rdbdiachi.Checked && khbus.KiemTraDiaChi(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                }
                catch
                {

                }
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
     
    }
}
