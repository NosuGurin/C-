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
    public partial class LoaiXe_View : Form
    {
        public LoaiXe_View()
        {
            InitializeComponent();
        }

        LoaiXe lx = new LoaiXe();
        LoaiXe_BUS lxbus = new LoaiXe_BUS();
        bool themmoi;

        void KhoaDieuKhien()
        {
            txtmalx.Enabled = false;
            txttenlx.Enabled = false;
            txtdd.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            bthuy.Enabled = false;
            btluu.Enabled = false;
            btthoat.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtmalx.Enabled = true;
            txttenlx.Enabled =true;
            txtdd.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            bthuy.Enabled = true;
            btluu.Enabled = true;
            btthoat.Enabled = true;
        }

        void HienThi(string where)
        {
            dsx.DataSource = lxbus.TaoBang(where);
        }

        void SetNull()
        {
            txtmalx.Text = "";
            txttenlx.Text = "";
            txtdd.Text = "";
        }

        private void LoaiXe_View_Load(object sender, EventArgs e)
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
            txtmalx.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    lx.Maloaixe1 = txtmalx.Text;
                    lxbus.XoaDuLieu(lx);
                    MessageBox.Show("Đã xóa thành công","Thống báo");
                    KhoaDieuKhien();
                    HienThi("");
                }
                catch
                {
                    MessageBox.Show("Lỗi!Không thế xóa", "Thống báo");
                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmalx.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo");
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        lx.Maloaixe1 = txtmalx.Text;
                        lx.Tenloaixe1 = txttenlx.Text;
                        lx.Dacdiem1 = txtdd.Text;
                        if(lxbus.KiemTraThem(txtmalx.Text) > 0){
                            MessageBox.Show("Mã loại xe không được trùng", "Thông báo");
                        }
                        else{
                            lxbus.ThemDuLieu(lx);
                            MessageBox.Show("Đã thêm thành công","Thông báo");
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
                        lx.Maloaixe1 = txtmalx.Text;
                        lx.Tenloaixe1 = txttenlx.Text;
                        lx.Dacdiem1 = txtdd.Text;

                        lxbus.SuaDuLieu(lx);
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không thế sửa", "Thông báo");
                    }
                }
                KhoaDieuKhien();
                HienThi("");
            }
        }

        private void dsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KhoaDieuKhien();
                txtmalx.Text = dsx.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenlx.Text = dsx.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdd.Text = dsx.Rows[e.RowIndex].Cells[2].Value.ToString();

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
                    if (rdbmlx.Checked && lxbus.KiemTraMaLoaiXe(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = lxbus.LayThongTinMaLoaiXe(txttimkiem.Text);

                    }
                    else if (rdbmlx.Checked && lxbus.KiemTraMaLoaiXe(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbtlx.Checked && lxbus.KiemTraTenloaixe(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = lxbus.LayThongTinTenLoaiXe(txttimkiem.Text);

                    }
                    else if (rdbtlx.Checked && lxbus.KiemTraTenloaixe(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbdacdiem.Checked && lxbus.KiemTraDacDiem(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = lxbus.LayThongTinDacDiem(txttimkiem.Text);

                    }
                    else if (rdbdacdiem.Checked && lxbus.KiemTraDacDiem(txttimkiem.Text) == 0)
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
