using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DesignSIMS
{
    public partial class SMSpace : Form
    {
        private UserBLL userBLL = new UserBLL();
        private MailBLL mailBLL = new MailBLL();
        public SMSpace()
        {
            InitializeComponent();
        }

        public SMSpace(UserBLL userBLL_)
        {
            InitializeComponent();
            this.userBLL = userBLL_;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword formchangepassword = new ChangePassword(userBLL);
            formchangepassword.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formlogin = new Login();
            formlogin.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowallmail_Click(object sender, EventArgs e)
        {
            try
            {
                loadlistmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
        private void loadlistmail()
        {
            try
            {
                DataTable dtlistmail = new DataTable();
                string iduser = userBLL.getid();
                dtlistmail = mailBLL.loadlistmail(iduser);
                dgvlistmail.DataSource = dtlistmail;
                foreach (DataGridViewColumn cols in dgvlistmail.Columns)
                {
                    cols.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
        private void btnShowdetail_Click(object sender, EventArgs e)
        {
            int rownum = dgvlistmail.CurrentCell.RowIndex;
            DataTable dt = new DataTable();
            dt = (DataTable)dgvlistmail.DataSource;
            DataRow row = dt.NewRow();
            row = dt.Rows[rownum];
            MailDetail formmaildetail = new MailDetail(row);
            formmaildetail.ShowDialog();
            try
            {
                loadlistmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
    }
}
