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
    public partial class NhaSanXuat_View : Form
    {
        public NhaSanXuat_View()
        {
            InitializeComponent();
        }

        NhaSanXuat nss = new NhaSanXuat();
        NhaSanXuat_BUS nsxbus = new NhaSanXuat_BUS();
        bool themmoi;

        void KhoaDieuKhien()
        {
            txtmansx.Enabled = false;
            txttennsx.Enabled = false;
            txtquocgia.Enabled = false;
            txtdienthoai.Enabled = false;
            txtemail.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btthoat.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtmansx.Enabled = true;
            txttennsx.Enabled = true;
            txtquocgia.Enabled = true;
            txtdienthoai.Enabled = true;
            txtemail.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
            bthuy.Enabled = true;
            btthoat.Enabled = true;
        }

        void HienThi(string where)
        {
            dsnsx.DataSource = nsxbus.TaoBang(where);
        }

        void SetNull()
        {
            txtmansx.Text = "";
            txttennsx.Text = "";
            txtquocgia.Text = "";
            txtdienthoai.Text = "";
            txtemail.Text = "";

        }


        private void NhaSanXuat_View_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");
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
            txtmansx.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    nss.Mansx1 = txtmansx.Text;
                    nsxbus.XoaDuLieu(nss);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo");
                    KhoaDieuKhien();
                    HienThi("");

                }
                catch
                {
                    MessageBox.Show("Lỗi!Không thể xóa", "Thông báo");
                }

            }

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmansx.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo");
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        nss.Mansx1 = txtmansx.Text;
                        nss.Tennsx1 = txttennsx.Text;
                        nss.Quocgia1 = txtquocgia.Text;
                        nss.Dienthoai1 = txtdienthoai.Text;
                        nss.Email1 = txtemail.Text;
                        if(nsxbus.KiemTraThem(txtmansx.Text) > 0){
                            MessageBox.Show("Mã nhà sản xuất không được trùng", "Thông báo");
                        }
                        else { 
                            nsxbus.ThemDuLieu(nss);

                            MessageBox.Show("Đã thêm thành công", "Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không thể thêm", "Thông báo");
                    }
                }
                else
                {
                    try
                    {
                        nss.Mansx1 = txtmansx.Text;
                        nss.Tennsx1 = txttennsx.Text;
                        nss.Quocgia1 = txtquocgia.Text;
                        nss.Dienthoai1 = txtdienthoai.Text;
                        nss.Email1 = txtemail.Text;

                        nsxbus.SuaDuLieu(nss);

                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không thể sửa", "Thông báo");
                    }
                }
                KhoaDieuKhien();
                HienThi("");
            }
        }

        private void dsnsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhoaDieuKhien();
                txtmansx.Text = dsnsx.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttennsx.Text = dsnsx.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtquocgia.Text = dsnsx.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdienthoai.Text = dsnsx.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = dsnsx.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBanXe_View qlbxv = new QuanLyBanXe_View();
            qlbxv.Show();
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
                    if (rdbmansx.Checked && nsxbus.KiemTraMaNSanXuat(txttimkiem.Text) != 0)
                    {
                        dsnsx.DataSource = nsxbus.LayThongTinMaNSanXuat(txttimkiem.Text);

                    }
                    else if (rdbmansx.Checked && nsxbus.KiemTraMaNSanXuat(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtennsx.Checked && nsxbus.KiemTraTenNSanXuat(txttimkiem.Text) != 0)
                    {
                        dsnsx.DataSource = nsxbus.LayThongTinTenNSanXuat(txttimkiem.Text);

                    }
                    else if (rdbtennsx.Checked && nsxbus.KiemTraTenNSanXuat(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbquocgia.Checked && nsxbus.KiemTraQuocgia(txttimkiem.Text) != 0)
                    {
                        dsnsx.DataSource = nsxbus.LayThongTinQuocGia(txttimkiem.Text);

                    }
                    else if (rdbquocgia.Checked && nsxbus.KiemTraQuocgia(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");
                    
                    if (rdbdienthoai.Checked && nsxbus.KiemTraDienThoai(txttimkiem.Text) != 0)
                    {
                        dsnsx.DataSource = nsxbus.LayThongTinDienThoai(txttimkiem.Text);

                    }
                    else if (rdbdienthoai.Checked && nsxbus.KiemTraDienThoai(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");
                    
                    if (rdbemail.Checked && nsxbus.KiemTraMaEmail(txttimkiem.Text) != 0)
                    {
                        dsnsx.DataSource = nsxbus.LayThongTinEmail(txttimkiem.Text);

                    }
                    else if (rdbemail.Checked && nsxbus.KiemTraMaEmail(txttimkiem.Text) == 0)
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
