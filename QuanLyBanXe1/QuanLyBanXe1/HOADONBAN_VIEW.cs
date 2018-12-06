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
    public partial class HOADONBAN_VIEW : Form
    {
        public HOADONBAN_VIEW()
        {
            InitializeComponent();
        }

        HoaDonBan_BUS hdbbus = new HoaDonBan_BUS();
        
        KhachHang_BUS khbus = new KhachHang_BUS();
        NhanVien_BUS nvbus = new NhanVien_BUS();

        HoaDonBan hdb = new HoaDonBan();
       
        QuanLyBanXe_View qlbxv = new QuanLyBanXe_View();
        
        
        bool themmoi;

        void MoDieuKhien()
        {
            txtmhdb.Enabled = true;
            cbmkh.Enabled = true;
            cbmnv.Enabled = true;
            dtnb.Enabled = true;
            txtgc.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
            bthuy.Enabled = true;
            btthoat.Enabled = true;

        }

        void DongDieuKhien()
        {
            txtmhdb.Enabled = false;
            cbmkh.Enabled = false;
            cbmnv.Enabled = false;
            dtnb.Enabled = false;
            txtgc.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btthoat.Enabled = true;

        }

        void HienThi(string where)
        {
            dshdb.DataSource = hdbbus.TaoBang("");
        }

        void SetNull()
        {
            txtmhdb.Text = "";
            cbmkh.Text = "";
            cbmnv.Text = "";
            dtnb.Text = "";
            txtgc.Text = "";
        }
        
        private void HOADONBAN_VIEW_Load(object sender, EventArgs e)
        {


            DongDieuKhien();
            HienThi("");

            cbmnv.DataSource = nvbus.LayThongTinNhanVien("");
            cbmnv.ValueMember = "Manv";
            cbmnv.DisplayMember = "Manv";

            cbmkh.DataSource = khbus.LayThongTinKH("");
            cbmkh.ValueMember = "Makh";
            cbmkh.DisplayMember = "Makh";
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
           
            txtmhdb.Enabled = false;
            cbmnv.Enabled = false;
            cbmkh.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Bạn có chắc muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                try
                {
                    hdb.Mahdb1 = txtmhdb.Text;
                    hdbbus.XoaDuLieu(hdb);
                    MessageBox.Show("Đã xóa thành công","Thông báo");
                    DongDieuKhien();
                    HienThi("");
                }
                catch { MessageBox.Show("Lỗi", "Thông báo"); }
            }
        }

        private void btthoat_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Hide();
                qlbxv.Show();

            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmhdb.Text == "")
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
            else
            {
                if(themmoi==true)
                {
                    try
                    {
                        hdb.Mahdb1 = txtmhdb.Text;
                        hdb.Makh1 = cbmkh.Text;
                        hdb.Manv1 = cbmnv.Text;
                        hdb.Ngayban1 = dtnb.Value;
                        hdb.Ghichu1 = txtgc.Text;
                        if(hdbbus.KiemTraThem(txtmhdb.Text)>0){
                            MessageBox.Show("Mã hóa đơn bán không được trùng", "Thông báo");
                        }
                        else{
                            hdbbus.ThemDuLieu(hdb);
                            MessageBox.Show("Đã thêm thành công", "Thông báo");
                        }
                    }
                    catch { MessageBox.Show("Lỗi", "Thông báo"); }
                }
                else
                {
                    try
                    {
                        hdb.Mahdb1 = txtmhdb.Text;
                        hdb.Makh1 = cbmkh.Text;
                        hdb.Manv1 = cbmnv.Text;
                        hdb.Ngayban1 = dtnb.Value;
                        hdb.Ghichu1 = txtgc.Text;

                        hdbbus.SuaDuLieu(hdb);
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch { MessageBox.Show("Lỗi", "Thông báo"); }
                }
                DongDieuKhien();
                HienThi("");
            }

        }

        private void btload_Click(object sender, EventArgs e)
        {
            HienThi("");
        }

        private void dshdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DongDieuKhien();
                txtmhdb.Text = dshdb.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbmkh.Text = dshdb.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                cbmnv.Text = dshdb.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                dtnb.Text = dshdb.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
                txtgc.Text = dshdb.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            }
            catch { MessageBox.Show("Lỗi", "Thông báo"); }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo");
            else
            {
                try
                {
                    if (rdbmahdb.Checked && hdbbus.KiemTraMaHDBan(txttimkiem.Text) != 0)
                    {
                        dshdb.DataSource = hdbbus.LayThongTinMaHDBan(txttimkiem.Text);

                    }
                    else if (rdbmahdb.Checked && hdbbus.KiemTraMaHDBan(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbmakh.Checked && hdbbus.KiemTraMaNhaCungCap(txttimkiem.Text) != 0)
                    {
                        dshdb.DataSource = hdbbus.LayThongTinMaNhaCungCap(txttimkiem.Text);

                    }
                    else if (rdbmakh.Checked && hdbbus.KiemTraMaNhaCungCap(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbmanv.Checked && hdbbus.KiemTraMaNhanVien(txttimkiem.Text) != 0)
                    {
                        dshdb.DataSource = hdbbus.LayThongTinMaNhanVien(txttimkiem.Text);

                    }
                    else if (rdbmanv.Checked && hdbbus.KiemTraMaNhanVien(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbngayban.Checked && hdbbus.KiemTraNgayBan(txttimkiem.Text) != 0)
                    {
                        dshdb.DataSource = hdbbus.LayThongTinNgayBan(txttimkiem.Text);

                    }
                    else if (rdbngayban.Checked && hdbbus.KiemTraNgayBan(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                }
                catch
                {

                }
            }
        }

       

        

        
        

        
        

       

        
        }
}
