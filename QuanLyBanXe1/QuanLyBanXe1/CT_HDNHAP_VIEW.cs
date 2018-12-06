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
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe1
{
    public partial class CT_HDNHAP_VIEW : Form
    {
        public CT_HDNHAP_VIEW()
        {
            InitializeComponent();
        }

        CT_HDNhap_BUS cthdnbus = new CT_HDNhap_BUS();
        CT_HDNhap cthdn = new CT_HDNhap();

        QuanLyBanXe_View qlbx = new QuanLyBanXe_View();
        
        bool themmoi;

        void MoDieuKhien()
        {
            cbmahdn.Enabled = true;
            cbmaxe.Enabled = true;
            txtdg.Enabled = true;
            txtsl.Enabled = true;
            txtthanhtien.Enabled = false;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
            bthuy.Enabled = true;
            btthoat.Enabled = true;

        }

        void DongDieuKhien()
        {
            cbmahdn.Enabled = false;
            cbmaxe.Enabled = false;
            txtdg.Enabled = false;
            txtsl.Enabled = false;
            txtthanhtien.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btthoat.Enabled = true;

        }

        void HienThi(string where)
        {
            dscthdn.DataSource = cthdnbus.TaoBang("");
        }

        void SetNull()
        {
            cbmahdn.Text = "";
            cbmaxe.Text = "";
            txtdg.Text = "";
            txtsl.Text = "";
        }

        private void CT_HDNHAP_VIEW_Load(object sender, EventArgs e)
        {
            DongDieuKhien();
            HienThi("");
            cbmaxe.DataSource = cthdnbus.LayThongTinXe("");
            cbmaxe.ValueMember = "Maxe";
            cbmaxe.DisplayMember = "Maxe";

            cbmahdn.DataSource = cthdnbus.LayThongTinHoaDonNhap("");
            cbmahdn.ValueMember = "Mahdnhap";
            cbmahdn.DisplayMember = "Mahdnhap";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            themmoi = true;

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            cbmahdn.Enabled = false;
            cbmaxe.Enabled = false;
            themmoi = false;

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    cthdn.Mahdn1 = cbmahdn.Text;
                    cthdnbus.XoaDuLieu(cthdn);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    DongDieuKhien();
                    HienThi("");
                }
            }
            catch { }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (cbmahdn.Text == "" || cbmaxe.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                if(themmoi==true)
                {
                    try
                    {
                        cthdn.Mahdn1 = cbmahdn.Text;
                        cthdn.Maxe1 = cbmaxe.Text;
                        cthdn.Soluong1 = int.Parse(txtsl.Text);
                        cthdn.Dongia1 = int.Parse(txtdg.Text);
                        cthdn.Thanhtien1 = int.Parse(txtsl.Text) * int.Parse(txtdg.Text);

                        cthdnbus.ThemDuLieu(cthdn);
                        MessageBox.Show("Đã thêm thành công", "Thông báo");
                       
                      
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        cthdn.Mahdn1 = cbmahdn.Text;
                        cthdn.Maxe1 = cbmaxe.Text;
                        cthdn.Soluong1 = int.Parse(txtsl.Text);
                        cthdn.Dongia1 = int.Parse(txtdg.Text);
                        cthdn.Thanhtien1 = int.Parse(txtsl.Text) * int.Parse(txtdg.Text);

                        cthdnbus.SuaDuLieu(cthdn);
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch { }
                }
                DongDieuKhien();
                HienThi("");
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Bạn có chắc muốn thoát","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                this.Hide();
                qlbx.Show();
            }
        }

        private void btload_Click(object sender, EventArgs e)
        {
            HienThi("");
        }

        private void dscthdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DongDieuKhien();
            cbmahdn.Text = dscthdn.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmaxe.Text= dscthdn.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsl.Text = dscthdn.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdg.Text = dscthdn.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtthanhtien.Text = dscthdn.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo");
            else
            {
                try
                {
                    if (rdbmahdn.Checked && cthdnbus.KiemTraMaHDNhap(txttimkiem.Text) != 0)
                    {
                        dscthdn.DataSource = cthdnbus.LayThongTinMaHDNhap(txttimkiem.Text);

                    }
                    else if (rdbmahdn.Checked && cthdnbus.KiemTraMaHDNhap(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbmaxe.Checked && cthdnbus.KiemTraMaXe(txttimkiem.Text) != 0)
                    {
                        dscthdn.DataSource = cthdnbus.LayThongTinMaXe(txttimkiem.Text);

                    }
                    else if (rdbmaxe.Checked && cthdnbus.KiemTraMaXe(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbsl.Checked && cthdnbus.KiemTraSoLuong(txttimkiem.Text) != 0)
                    {
                        dscthdn.DataSource = cthdnbus.LayThongTinSoLuong(txttimkiem.Text);

                    }
                    else if (rdbsl.Checked && cthdnbus.KiemTraSoLuong(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbdg.Checked && cthdnbus.KiemTraDonGia(txttimkiem.Text) != 0)
                    {
                        dscthdn.DataSource = cthdnbus.LayThongTinDonGia(txttimkiem.Text);

                    }
                    else if (rdbdg.Checked && cthdnbus.KiemTraDonGia(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtt.Checked && cthdnbus.KiemTraThanhTien(txttimkiem.Text) != 0)
                    {
                        dscthdn.DataSource =cthdnbus.LayThongTinThanhTien(txttimkiem.Text);

                    }
                    else if (rdbtt.Checked && cthdnbus.KiemTraThanhTien(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");
                }
                catch
                {

                }
            }
        }
    }
}
