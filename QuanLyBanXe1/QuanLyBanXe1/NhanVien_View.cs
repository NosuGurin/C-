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
    public partial class NhanVien_View : Form
    {
        public NhanVien_View()
        {
            InitializeComponent();
        }

        NhanVien nv = new NhanVien();
        NhanVien_BUS nvbus = new NhanVien_BUS();
        bool themmoi;

        void KhoaDieuKhien()
        {
            txtmanv.Enabled = false;
            txttennv.Enabled = false;
            dtngaysinh.Enabled = false;
            txtdienthoai.Enabled = false;
            txtdiachi.Enabled = false;
            txtgioitinh.Enabled = false;
            txtmatkhau.Enabled = false;
            txtchucvu.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
            bthuy.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            dtngaysinh.Enabled = true;
            txtdienthoai.Enabled = true;
            txtdiachi.Enabled = true;
            txtgioitinh.Enabled = true;
            txtmatkhau.Enabled = true;
            txtchucvu.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
            bthuy.Enabled = true;
        }

        void HienThi(string where)
        {
            dsnv.DataSource = nvbus.TaoBang(where);
        }

        void SetNull()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            dtngaysinh.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
            txtgioitinh.Text = "";
            txtmatkhau.Text = "";
            txtchucvu.Text = "";
        }

        private void NhanVien_View_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");

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
            txtmanv.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                nv.Manv1 = txtmanv.Text;
                nvbus.XoaDuLieu(nv);
                MessageBox.Show("Đã xóa thành công", "Thông báo");
                KhoaDieuKhien();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Lỗi!Không xóa được", "Thông báo");
            }
        }

        private void btluu_Click_1(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo");
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        nv.Manv1 = txtmanv.Text;
                        nv.Tennv1 = txttennv.Text;
                        nv.Ngaysinh1 = dtngaysinh.Value;
                        nv.Dienthoai1 = txtdienthoai.Text;
                        nv.Diachi1 = txtdiachi.Text;
                        nv.Gioitinh1 = txtgioitinh.Text;
                        nv.Pass1 = txtmatkhau.Text;
                        nv.Chucvu1 = txtchucvu.Text;
                        if(nvbus.KiemTraThem(txtmanv.Text) > 0){
                            MessageBox.Show("Mã nhân viên không được trùng", "Thông báo");
                        }
                        else{
                            nvbus.ThemDuLieu(nv);
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
                        nv.Manv1 = txtmanv.Text;
                        nv.Tennv1 = txttennv.Text;
                        nv.Ngaysinh1 = dtngaysinh.Value;
                        nv.Dienthoai1 = txtdienthoai.Text;
                        nv.Diachi1 = txtdiachi.Text;
                        nv.Gioitinh1 = txtgioitinh.Text;
                        nv.Pass1 = txtmatkhau.Text;
                        nv.Chucvu1 = txtchucvu.Text;
                        nvbus.SuaDuLieu(nv);
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

        private void bthuy_Click_1(object sender, EventArgs e)
        {
            SetNull();

            txtmanv.Focus();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBanXe_View qlbxv = new QuanLyBanXe_View();
            qlbxv.Show();
        }

        private void dsnv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhoaDieuKhien();
                txtmanv.Text = dsnv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttennv.Text = dsnv.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtngaysinh.Text = dsnv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdiachi.Text = dsnv.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtdienthoai.Text = dsnv.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtgioitinh.Text = dsnv.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtmatkhau.Text = dsnv.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtchucvu.Text = dsnv.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void btload_Click(object sender, EventArgs e)
        {
            HienThi("");
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo");
            else
            {
                try
                {
                    if (rdbmanv.Checked && nvbus.KiemTraMaNhanVien(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinMaNhanVien(txttimkiem.Text);

                    }
                    else if (rdbmanv.Checked && nvbus.KiemTraMaNhanVien(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtennv.Checked && nvbus.KiemTraTenNhanVien(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinTenNhanVien(txttimkiem.Text);

                    }
                    else if (rdbtennv.Checked && nvbus.KiemTraTenNhanVien(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbngaysinh.Checked && nvbus.KiemTraNgaySinh(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinNhanVien(txttimkiem.Text);

                    }
                    else if (rdbngaysinh.Checked && nvbus.KiemTraNgaySinh(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbdiachi.Checked && nvbus.KiemTraDiaChi(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinDiaChi(txttimkiem.Text);

                    }
                    else if (rdbdiachi.Checked && nvbus.KiemTraDiaChi(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbdienthoai.Checked && nvbus.KiemTraDienthoai(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinDienthoai(txttimkiem.Text);

                    }
                    else if (rdbdienthoai.Checked && nvbus.KiemTraDienthoai(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbgioitinh.Checked && nvbus.KiemTraGioiTinh(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinGioiTinh(txttimkiem.Text);

                    }
                    else if (rdbgioitinh.Checked && nvbus.KiemTraGioiTinh(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbpass.Checked && nvbus.KiemTraPass(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinPass(txttimkiem.Text);

                    }
                    else if (rdbpass.Checked && nvbus.KiemTraPass(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");
                    if (rdbchucvu.Checked && nvbus.KiemTraChucVu(txttimkiem.Text) != 0)
                    {
                        dsnv.DataSource = nvbus.LayThongTinChucVu(txttimkiem.Text);

                    }
                    else if (rdbchucvu.Checked && nvbus.KiemTraChucVu(txttimkiem.Text) == 0)
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
    
