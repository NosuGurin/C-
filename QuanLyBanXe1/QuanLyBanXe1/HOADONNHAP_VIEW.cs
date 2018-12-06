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
    public partial class HOADONNHAP_VIEW : Form
    {
        public HOADONNHAP_VIEW()
        {
            InitializeComponent();
        }

        HoaDonNhap_BUS hdnbus=new HoaDonNhap_BUS ();
        QuanLyBanXe_View qlbs = new QuanLyBanXe_View();
        HoaDonNhap hdn = new HoaDonNhap();


        bool themmoi;

        void MoDieuKhien()
        {
            txtmhdn.Enabled = true;
            cbmncc.Enabled = true;
            cbmnv.Enabled = true;
            dtnn.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
            bthuy.Enabled = true;
            btthoat.Enabled = true;

        }

        void DongDieuKhien()
        {
            txtmhdn.Enabled = false;
            cbmncc.Enabled = false;
            cbmnv.Enabled = false;
            dtnn.Enabled = false;


            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btthoat.Enabled = true;

        }

        void HienThi(string where)
        {
            dshdn.DataSource = hdnbus.TaoBang("");
        }

        void SetNull()
        {
            txtmhdn.Text = "";
            cbmncc.Text = "";
            cbmnv.Text = "";
        }

        private void HOADONNHAP_VIEW_Load(object sender, EventArgs e)
        {
            DongDieuKhien();
            HienThi("");

            cbmncc.DataSource = hdnbus.LayThongTinNhaCungCap("");
            cbmncc.ValueMember = "Mancungcap";
            cbmncc.DisplayMember = "Mancungcap";

            cbmnv.DataSource = hdnbus.LayThongTinNhanVien("");
            cbmnv.ValueMember = "Manv";
            cbmnv.DisplayMember = "Manv";
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
            cbmnv.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try{
                if(DialogResult.Yes==MessageBox.Show("Bạn có chắc muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    hdn.Mahdn1=txtmhdn.Text;
                    hdnbus.XoaDuLieu(hdn);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    DongDieuKhien();
                    HienThi("");
                }
            }
            catch{
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmhdn.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        hdn.Mahdn1 = txtmhdn.Text;
                        hdn.Mancc1 = cbmncc.Text;
                        hdn.Manv1 = cbmnv.Text;
                        hdn.Ngaynhap1 = dtnn.Value;
                        if(hdnbus.KiemTraThem(txtmhdn.Text)>0){
                            MessageBox.Show("Mã hóa đơn nhập không được trùng", "Thông báo");
                        }
                        else{
                            hdnbus.ThemDuLieu(hdn);
                            MessageBox.Show("Đã thêm thành công", "Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
                }
                else
                {
                    try
                    {
                        hdn.Mahdn1 = txtmhdn.Text;
                        hdn.Mancc1 = cbmncc.Text;
                        hdn.Manv1 = cbmnv.Text;
                        hdn.Ngaynhap1 = dtnn.Value;

                        hdnbus.SuaDuLieu(hdn);
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
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
                qlbs.Show();
            }
        }

        private void btload_Click(object sender, EventArgs e)
        {
            HienThi("");
        }

        private void dshdn_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DongDieuKhien();
            txtmhdn.Text = dshdn.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmncc.Text = dshdn.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbmnv.Text = dshdn.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtnn.Text = dshdn.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo");
            else
            {
                try
                {
                    if (rdbmahdn.Checked && hdnbus.KiemTraMaHDNhap(txttimkiem.Text) != 0)
                    {
                        dshdn.DataSource = hdnbus.LayThongTinMaHDNhap(txttimkiem.Text);

                    }
                    else if (rdbmahdn.Checked && hdnbus.KiemTraMaHDNhap(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbmancc.Checked && hdnbus.KiemTraMaNhaCungCap(txttimkiem.Text) != 0)
                    {
                        dshdn.DataSource = hdnbus.LayThongTinMaNhaCungCap(txttimkiem.Text);

                    }
                    else if (rdbmancc.Checked && hdnbus.KiemTraMaNhaCungCap(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbmanv.Checked && hdnbus.KiemTraMaNhanVien(txttimkiem.Text) != 0)
                    {
                        dshdn.DataSource = hdnbus.LayThongTinMaNhanVien(txttimkiem.Text);

                    }
                    else if (rdbmanv.Checked && hdnbus.KiemTraMaNhanVien(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    if (rdbnn.Checked && hdnbus.KiemTraNgayNhap(txttimkiem.Text) != 0)
                    {
                        dshdn.DataSource = hdnbus.LayThongTinNgayNhap(txttimkiem.Text);

                    }
                    else if (rdbnn.Checked && hdnbus.KiemTraNgayNhap(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");

                    
                }
                catch
                {

                }
            }
        }

        
        

        
    }
}
