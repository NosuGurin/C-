using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Persentation;

namespace Persentation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        LopHocBUS lopBUS = new LopHocBUS();
        LopHocDTO lopDTO = new LopHocDTO();
        void HienThi()
        {
            dataGridView1.DataSource = lopBUS.LoadDSLop();
        }
        private void btload_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtmalop.Enabled = false;
            HienThi();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                
                lopDTO.Malop = int.Parse(txtmalop.Text);
                lopDTO.Tenlop = txttenlop.Text;
                lopDTO.Siso = int.Parse(txtsiso.Text);

                lopBUS.SuaLop(lopDTO);
                MessageBox.Show("Sửa thành công");
                HienThi();
            }
            catch
            {
                MessageBox.Show("Không thể sửa");
                return;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtmalop.Text);

                lopBUS.XoaLop(x);
                MessageBox.Show("Xóa thành công");
                HienThi();
            }
            catch
            {
                MessageBox.Show("Không thể xóa");
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtmalop.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenlop.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsiso.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void bthocsinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();

            }
        }
    }
}
