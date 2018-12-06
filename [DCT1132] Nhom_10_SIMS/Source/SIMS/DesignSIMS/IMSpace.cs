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
    public partial class IMSpace : Form
    {
        private UserBLL userBLL;
        private ItemBLL itemBLL = new ItemBLL();
        private MailBLL mailBLL = new MailBLL();
        public IMSpace()
        {
            InitializeComponent();
        }
        public IMSpace(UserBLL userBLL_)
        {
            InitializeComponent();
            this.userBLL = userBLL_;
        }

        private void IMSpace_Load(object sender, EventArgs e)
        {
            cbxAction.SelectedIndex = 0;
            LoadInventory();
            LoadInventoryReport();
            cbxMonthfrom.SelectedIndex = 0;
            cbxMonthto.SelectedIndex = 0;
            cbxYearfrom.SelectedIndex = 0;
            cbxYearto.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
        }

        private void LoadInventoryReport()
        {
            try
            {
                cbxCategoryreport.DataSource = itemBLL.loadcategory();
                cbxCategoryreport.DisplayMember = "namecategory";
                cbxCategoryreport.ValueMember = "idcategory";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void LoadInventory()
        {
            try
            {
                cbxCategory.DataSource = itemBLL.loadcategory();
                cbxCategory.DisplayMember = "namecategory";
                cbxCategory.ValueMember = "idcategory";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword formchangepassword = new ChangePassword(userBLL);
            formchangepassword.ShowDialog();
            try
            {
                userBLL.verifyuser(userBLL.getid());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
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

        private void cbxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxAction.SelectedIndex)
            {
                case 0:
                    txtQuantity.ReadOnly = true;
                    txtItem.ReadOnly = false;
                    break;
                case 1:
                    txtItem.ReadOnly = true;
                    txtQuantity.ReadOnly = false;
                    loaditemdetail();
                    break;
            }
        }

        private void loaditemdetail()
        {
            if (dgvlistitem.Rows.Count > 0)
            {
                int rownum = dgvlistitem.CurrentCell.RowIndex;
                txtItem.Text = dgvlistitem["Name", rownum].Value.ToString();
                txtQuantity.Value = (int)dgvlistitem["Quantity", rownum].Value;
            }
            else
            {
                MessageBox.Show("There is no item", "ERROR");
            }
        }

        private void btnExecuteinventory_Click(object sender, EventArgs e)
        {
            switch (cbxAction.SelectedIndex)
            {
                case 0:
                    try
                    {
                        dgvlistitem.DataSource = itemBLL.loaditem(txtItem.Text, cbxCategory.SelectedValue.ToString());
                        foreach (DataGridViewColumn cols in dgvlistitem.Columns)
                        {
                            cols.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR");
                    }
                    break;
                case 1:
                    try
                    {
                        if (dgvlistitem.Rows.Count > 0)
                        {
                            int rownum = dgvlistitem.CurrentCell.RowIndex;
                            string iditem = dgvlistitem["ID", rownum].Value.ToString();
                            int quantity = (int)txtQuantity.Value;
                            itemBLL.modifyquantity(iditem, quantity);
                            dgvlistitem["Quantity", rownum].Value = quantity;
                        }
                        else
                        {
                            MessageBox.Show("There is no item", "ERROR");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR");
                    }
                    break;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                string category = cbxCategory.SelectedValue.ToString();
                dgvlistitem.DataSource = itemBLL.loaditem("", category);
                foreach (DataGridViewColumn cols in dgvlistitem.Columns)
                {
                    cols.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void dgvlistitem_SelectionChanged(object sender, EventArgs e)
        {
            loaditemdetail();
        }

    }
}
