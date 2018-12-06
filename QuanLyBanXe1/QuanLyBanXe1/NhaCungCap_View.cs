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
    public partial class NhaCungCap_View : Form
    {
        public NhaCungCap_View()
        {
            InitializeComponent();
        }

        NhaCungCap ncc = new NhaCungCap();
        NhaCungCap_BUS nccbus = new NhaCungCap_BUS();
        bool themmoi;

        void MoDieuKhien()
        {
            txtmancc.Enabled = true;
            txttenncc.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtemail.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            bthuy.Enabled = true;
            btluu.Enabled = true;
            btthoat.Enabled = true;
        }

        void DongDieuKhien()
        {
            txtmancc.Enabled = false;
            txttenncc.Enabled = false;
            txtdiachi.Enabled = false;
            txtdienthoai.Enabled = false;
            txtemail.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            bthuy.Enabled = false;
            btluu.Enabled = false;
            btthoat.Enabled = true;
        }

        void SetNull()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtemail.Text = "";
        }

        void HienThi(string where)
        {
            dsncc.DataSource = nccbus.TaoBang(where);
        }

        

        private void NhaCungCap_View_Load(object sender, EventArgs e)
        {
            DongDieuKhien();
            HienThi("");
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            SetNull();
            txtmancc.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ncc.Mancc1 = txtmancc.Text;
                nccbus.XoaDuLieu(ncc);
                MessageBox.Show("Đã xóa thành công","Thông báo");
                DongDieuKhien();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Lỗi!Không thế xóa", "Thông báo");
            }
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
            txtmancc.Enabled = false;
            themmoi = false;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo");
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        ncc.Mancc1 = txtmancc.Text;
                        ncc.Tenncc1 = txttenncc.Text;
                        ncc.Diachi1 = txtdiachi.Text;
                        ncc.Dienthoai1 = txtdienthoai.Text;
                        ncc.Email1 = txtemail.Text;
                        if (nccbus.KiemTraThem(txtmancc.Text) > 0)
                        {
                            MessageBox.Show("Mã nhà cung cấp không được trùng", "Thông báo");
                        }
                        else
                        {
                            nccbus.ThemDuLieu(ncc);
                            MessageBox.Show("Đã thêm thành công", "Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không thế thêm", "Thông báo");
                    }
                }
                else
                {
                    try
                    {
                        ncc.Mancc1 = txtmancc.Text;
                        ncc.Tenncc1 = txttenncc.Text;
                        ncc.Diachi1 = txtdiachi.Text;
                        ncc.Dienthoai1 = txtdienthoai.Text;
                        ncc.Email1 = txtemail.Text;

                        nccbus.SuaDuLieu(ncc);
                        MessageBox.Show("Đã sửa thành công", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không thế sửa", "Thông báo");
                    }
                }
                DongDieuKhien();
                HienThi("");

            }
        }

        private void dsncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DongDieuKhien();
                txtmancc.Text = dsncc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenncc.Text = dsncc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdiachi.Text = dsncc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdienthoai.Text = dsncc.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = dsncc.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Lỗi","Thông báo");
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
                    if (rdbmncc.Checked && nccbus.KiemTraManCungCap(txttimkiem.Text) != 0)
                    {
                        dsncc.DataSource = nccbus.LayThongTinMaNCungCap(txttimkiem.Text);

                    }
                    else if (rdbmncc.Checked && nccbus.KiemTraManCungCap(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtenncc.Checked && nccbus.KiemTraTennCungCap(txttimkiem.Text) != 0)
                    {
                        dsncc.DataSource = nccbus.LayThongTinTenNCungCap(txttimkiem.Text);

                    }
                    else if (rdbtenncc.Checked && nccbus.KiemTraTennCungCap(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbdiachi.Checked && nccbus.KiemTraDiaChi(txttimkiem.Text) != 0)
                    {
                        dsncc.DataSource = nccbus.LayThongTinDiaChi(txttimkiem.Text);

                    }
                    else if (rdbdiachi.Checked && nccbus.KiemTraDiaChi(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbdienthoai.Checked && nccbus.KiemTraDienThoai(txttimkiem.Text) != 0)
                    {
                        dsncc.DataSource = nccbus.LayThongTinDienThoai(txttimkiem.Text);

                    }
                    else if (rdbdienthoai.Checked && nccbus.KiemTraDienThoai(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbemail.Checked && nccbus.KiemTraMaEmail(txttimkiem.Text) != 0)
                    {
                        dsncc.DataSource = nccbus.LayThongTinEmail(txttimkiem.Text);

                    }
                    else if (rdbemail.Checked && nccbus.KiemTraMaEmail(txttimkiem.Text) == 0)
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
