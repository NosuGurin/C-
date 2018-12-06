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
    public partial class Xe_View : Form
    {
        public Xe_View()
        {
            InitializeComponent();
        }

        Xe x = new Xe();
        Xe_BUS xbus = new Xe_BUS();
        LoaiXe_BUS lxbus = new LoaiXe_BUS();
        NhaCungCap_BUS nccbus = new NhaCungCap_BUS();
        NhaSanXuat_BUS nsxbus = new NhaSanXuat_BUS();
        bool themmoi;



        void DongDieuKhien()
        {
            txtmaxe.Enabled = false;
            txttenxe.Enabled = false;
            txtdg.Enabled = false;
            txtslt.Enabled = false;
            cbmlx.Enabled = false;
            cbmnsx.Enabled = false;
            cbmncc.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btthoat.Enabled = true;
        }

        void MoDieuKhien()
        {
            txtmaxe.Enabled = true;
            txttenxe.Enabled = true;
            txtdg.Enabled = true;
            txtslt.Enabled = true;
            cbmlx.Enabled = true;
            cbmnsx.Enabled = true;
            cbmncc.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
            bthuy.Enabled = true;
            btthoat.Enabled = true;
        }

        void SetNull()
        {
            txtmaxe.Text = "";
            txttenxe.Text = "";
            txtdg.Text = "";
            txtslt.Text = "";
            cbmlx.Text = "";
            cbmnsx.Text = "";
            cbmncc.Text = "";
        }

        void HienThi(string where)
        {
            dsx.DataSource = xbus.TaoBang(where);

        }


        private void Xe_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanXeDataSet.XE' table. You can move, or remove it, as needed.
           
            cbmlx.DataSource = lxbus.LayThongTinLX("");
            cbmlx.ValueMember = "Maloaixe";
            cbmlx.DisplayMember = "Maloaixe";

            cbmncc.DataSource = nccbus.LayThongTinNhaCC("");
            cbmncc.ValueMember = "Mancungcap";
            cbmncc.DisplayMember = "Mancungcap";

            cbmnsx.DataSource = nsxbus.LayThongTinMaNSanXuat("");
            cbmnsx.ValueMember = "Mansanxuat";
            cbmnsx.DisplayMember = "Mansanxuat";



            DongDieuKhien();
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
            txtmaxe.Enabled = false;
            themmoi = false;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    x.Maxe1 = txtmaxe.Text;
                    xbus.XoaDuLieu(x);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    DongDieuKhien();
                    HienThi("");

                }

            }
            catch
            {
                MessageBox.Show("Không thế xóa", "Thông báo");
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmaxe.Text == "")
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo");
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        x.Maxe1 = txtmaxe.Text;
                        x.Tenxe1 = txttenxe.Text;

                        x.Soluongton1 = int.Parse(txtslt.Text);
                        x.Maloaixe1 = cbmlx.Text;
                        x.Mansx1 = cbmnsx.Text;
                        x.Mancc1 = cbmncc.Text;
                        x.Dongia1 = int.Parse(txtdg.Text);
                        if (xbus.KiemTraThem(txtmaxe.Text) > 0)
                        {
                            MessageBox.Show("Mã xe không được trùng", "Thông báo");
                        }
                        else
                        {
                            xbus.ThemDuLieu(x);
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
                        x.Maxe1 = txtmaxe.Text;
                        x.Tenxe1 = txttenxe.Text;

                        x.Soluongton1 = int.Parse(txtslt.Text);
                        x.Maloaixe1 = cbmlx.Text;
                        x.Mansx1 = cbmnsx.Text;
                        x.Mancc1 = cbmncc.Text;
                        x.Dongia1 = int.Parse(txtdg.Text);
                        xbus.SuaDuLieu(x);
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!Không sửa được", "Thông báo");
                    }
                }
                DongDieuKhien();
                HienThi("");
            }


        }




        private void dsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DongDieuKhien();
                txtmaxe.Text = dsx.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenxe.Text = dsx.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtslt.Text = dsx.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbmlx.Text = dsx.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbmnsx.Text = dsx.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbmncc.Text = dsx.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtdg.Text = dsx.Rows[e.RowIndex].Cells[6].Value.ToString();

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




        private void bttimkiem_Click_1(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo");
            else
            {
                try
                {
                    if (rdbmaxe.Checked && xbus.KiemTraMaxe(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = xbus.LayThongTinMaxe(txttimkiem.Text);

                    }
                    else if (rdbmaxe.Checked && xbus.KiemTraMaxe(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbtenxe.Checked && xbus.KiemTraTenxe(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = xbus.LayThongTinTenxe(txttimkiem.Text);

                    }
                    else if (rdbtenxe.Checked && xbus.KiemTraTenxe(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbsl.Checked && xbus.KiemTraSoluong(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = xbus.LayThongTinSoluong(txttimkiem.Text);

                    }
                    else if (rdbsl.Checked && xbus.KiemTraSoluong(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbmalx.Checked && xbus.KiemTraMaloaixe(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = xbus.LayThongTinLoaiXe(txttimkiem.Text);

                    }
                    else if (rdbmalx.Checked && xbus.KiemTraMaloaixe(txttimkiem.Text) == 0)

                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbmansx.Checked && xbus.KiemTraMansx(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = xbus.LayThongTinNhaSanXuat(txttimkiem.Text);

                    }
                    else if (rdbmansx.Checked && xbus.KiemTraMansx(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbmancc.Checked && xbus.KiemTraMancc(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = xbus.LayThongTinNhaCungCap(txttimkiem.Text);

                    }
                    else if (rdbmancc.Checked && xbus.KiemTraMancc(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");


                    if (rdbdongia.Checked && xbus.KiemTraDongia(txttimkiem.Text) != 0)
                    {
                        dsx.DataSource = xbus.LayThongTinDongia(txttimkiem.Text);

                    }
                    else if (rdbdongia.Checked && xbus.KiemTraDongia(txttimkiem.Text) == 0)
                        MessageBox.Show("Bạn nhập sai thông tin", "Thông báo");
                }
                catch
                {

                }
            }
        }

        private void btload_Click(object sender, EventArgs e)
        {
            HienThi("");
        }

       

        private void btexcel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xe_RP_View xe_rp = new Xe_RP_View();
            xe_rp.Show();

        }

        

       

       
    }
}
