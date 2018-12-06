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
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        HocSinhDTO hsDTO = new HocSinhDTO();
        HocSinhBUS hsBUS = new HocSinhBUS();

        void HienThi()
        {
            dataGridView1.DataSource = hsBUS.LoadDSHocSinh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtmahs.Enabled = false;
            DataTable dt = new DataTable();
            LopHocBUS lopBUS = new LopHocBUS();
            dt = lopBUS.LoadDSLop();
            cblop.DataSource = dt;
            cblop.DisplayMember = "Tenlop";
            cblop.ValueMember = "Malop";
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txttenhs.Text == "" || txtdiachi.Text == "" )
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
                }
                else if(hsBUS.IsNumber(txtdienthoai.Text) == 0 || txtdienthoai.TextLength > 11 || txtdienthoai.TextLength < 10)
                {
                    MessageBox.Show("Bạn cần nhập số điện thoại chính xác");
                }
                else
                {
                    hsDTO.Tenhs = txttenhs.Text;
                    hsDTO.Dienthoai = txtdienthoai.Text;
                    hsDTO.Diachi = txtdiachi.Text;
                    hsDTO.Ngaysinh = dtngaysinh.Value;
                    hsDTO.Malop = int.Parse(cblop.SelectedValue.ToString());

                    hsBUS.ThemHs(hsDTO);
                    MessageBox.Show("Thêm thành công");
                    HienThi();
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmahs.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenhs.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdienthoai.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtngaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cblop.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btlop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();

            }
        }

        
    }
}
