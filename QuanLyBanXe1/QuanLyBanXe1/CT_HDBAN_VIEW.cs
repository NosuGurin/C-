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
    public partial class CT_HDBAN_VIEW : Form
    {
        public CT_HDBAN_VIEW()
        {
            InitializeComponent();
        }

        CT_HDBan_BUS cthdbbus = new CT_HDBan_BUS();
        CT_HDB cthdb = new CT_HDB();
        bool themmoi;
        QuanLyBanXe_View qlbx = new QuanLyBanXe_View();

        void MoDieuKhien()
        {
            cbmahdb.Enabled = true;
            cbmaxe.Enabled = true;
            txtsl.Enabled = true;
            txtdg.Enabled = true;
            txttientra.Enabled = true;
            txttiendu.Enabled = false;
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
            cbmahdb.Enabled = false;
            cbmaxe.Enabled = false;
            txtsl.Enabled = false;
            txtdg.Enabled = false;
            txttientra.Enabled = false;
            txttiendu.Enabled = false;
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
            dscthdb.DataSource = cthdbbus.TaoBang("");
        }

        void SetNull()
        {
            cbmahdb.Text = "";
            cbmaxe.Text = "";
            txtsl.Text = "";
            txtdg.Text = "";
            txttientra.Text = "";
            txttiendu.Text = "";
            txtthanhtien.Text = "";
        }

        private void CT_HDBAN_VIEW_Load(object sender, EventArgs e)
        {
            DongDieuKhien();
            HienThi("");

            cbmahdb.DataSource = cthdbbus.LayThongTinHD("");
            cbmahdb.ValueMember = "Mahdban";
            cbmahdb.DisplayMember = "Mahdban";

            cbmaxe.DataSource = cthdbbus.LayThongTinXe("");
            cbmaxe.ValueMember = "Maxe";
            cbmaxe.DisplayMember = "Maxe";
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
            cbmaxe.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    cthdb.Mahdb1 = cbmahdb.Text;
                    cthdbbus.XoaDuLieu(cthdb);
                    MessageBox.Show("Đã xóa thành công","Thông báo");
                    DongDieuKhien();
                    HienThi("");
                }
            }
            catch { MessageBox.Show("Lỗi", "Thông báo"); }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (cbmahdb.Text == "")
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
            
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        cthdb.Mahdb1 =cbmahdb.Text;
                        cthdb.Maxe1 = cbmaxe.Text;
                        cthdb.Soluong1 = double.Parse(txtsl.Text);
                        cthdb.Dongia1 = double.Parse(txtdg.Text);
                        cthdb.Tientra1 = double.Parse(txttientra.Text);
                        cthdb.Thanhtoan1 = double.Parse(txtsl.Text) * double.Parse(txtdg.Text);
                        cthdb.Tienthua1 = double.Parse(txttientra.Text) - double.Parse(txtthanhtien.Text);

                        cthdbbus.ThemDuLieu(cthdb);
                        MessageBox.Show("Đã thêm thành công", "Thông báo");
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        cthdb.Mahdb1 = cbmahdb.Text;
                        cthdb.Maxe1 = cbmaxe.Text;
                        cthdb.Soluong1 = double.Parse(txtsl.Text);
                        cthdb.Dongia1 = double.Parse(txtdg.Text);
                        cthdb.Tientra1 = double.Parse(txttientra.Text);
                        cthdb.Thanhtoan1 = double.Parse(txtsl.Text) * double.Parse(txtdg.Text);
                        cthdb.Tienthua1 = double.Parse(txttientra.Text) - double.Parse(txtthanhtien.Text);

                        cthdbbus.SuaDuLieu(cthdb);
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
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Hide();
                qlbx.Show();
            }
        }

        private void btload_Click(object sender, EventArgs e)
        {
            HienThi("");
        }

        private void dscthdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DongDieuKhien();
                cbmahdb.Text = dscthdb.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbmaxe.Text = dscthdb.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsl.Text = dscthdb.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdg.Text = dscthdb.Rows[e.RowIndex].Cells[3].Value.ToString();
                txttientra.Text = dscthdb.Rows[e.RowIndex].Cells[4].Value.ToString();
                txttiendu.Text = dscthdb.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtthanhtien.Text = dscthdb.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            txtthanhtien.Text = (double.Parse(txtsl.Text) * double.Parse(txtdg.Text)).ToString();
            if (double.Parse(txtthanhtien.Text) > double.Parse(txttientra.Text))
                MessageBox.Show("Tiển trả của bạn chưa đủ để thanh toán", "Thông báo");
            else
                txttiendu.Text = (double.Parse(txttientra.Text) - double.Parse(txtthanhtien.Text)).ToString();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo");
            else
            {
                try
                {
                    if (rdbmahdb.Checked && cthdbbus.KiemTraMaHDBan(txttimkiem.Text) != 0)
                    {
                        dscthdb.DataSource = cthdbbus.LayThongTinMaHDBan(txttimkiem.Text);

                    }
                    else if (rdbmahdb.Checked && cthdbbus.KiemTraMaHDBan(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbmaxe.Checked && cthdbbus.KiemTraMaXe(txttimkiem.Text) != 0)
                    {
                        dscthdb.DataSource = cthdbbus.LayThongTinMaXe(txttimkiem.Text);

                    }
                    else if (rdbmaxe.Checked && cthdbbus.KiemTraMaXe(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbsl.Checked && cthdbbus.KiemTraSoLuong(txttimkiem.Text) != 0)
                    {
                        dscthdb.DataSource = cthdbbus.LayThongTinSoLuong(txttimkiem.Text);

                    }
                    else if (rdbsl.Checked && cthdbbus.KiemTraSoLuong(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbdg.Checked && cthdbbus.KiemTraDonGia(txttimkiem.Text) != 0)
                    {
                        dscthdb.DataSource = cthdbbus.LayThongTinDonGia(txttimkiem.Text);

                    }
                    else if (rdbdg.Checked && cthdbbus.KiemTraDonGia(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtientra.Checked && cthdbbus.KiemTraTienTra(txttimkiem.Text) != 0)
                    {
                        dscthdb.DataSource = cthdbbus.LayThongTinTienTra(txttimkiem.Text);

                    }
                    else if (rdbtientra.Checked && cthdbbus.KiemTraTienTra(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtiendu.Checked && cthdbbus.KiemTraTienThua(txttimkiem.Text) != 0)
                    {
                        dscthdb.DataSource = cthdbbus.LayThongTinTienThua(txttimkiem.Text);

                    }
                    else if (rdbtiendu.Checked && cthdbbus.KiemTraTienThua(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbthanhtoan.Checked && cthdbbus.KiemTraThanhToan(txttimkiem.Text) != 0)
                    {
                        dscthdb.DataSource = cthdbbus.LayThongTinThanhToan(txttimkiem.Text);

                    }
                    else if (rdbthanhtoan.Checked && cthdbbus.KiemTraThanhToan(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");
                }
                catch
                {

                }
            }
        }
        
    }
}
