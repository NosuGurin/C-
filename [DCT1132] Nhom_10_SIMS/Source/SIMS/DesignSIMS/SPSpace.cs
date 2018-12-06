using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using BLL;
using System.Globalization;
using System.Reflection;

namespace DesignSIMS
{
    public partial class SPSpace : Form
    {
        private UserBLL userBLL;
        private ItemBLL itemBLL=new ItemBLL();
        private ReceiptBLL receiptBLL = new ReceiptBLL();
        private MailBLL mailBLL = new MailBLL();

        public SPSpace()
        {
            InitializeComponent();
            this.Load += SPSpace_Load;
        }
        public SPSpace(UserBLL userBLL)
        {
            InitializeComponent();
            this.userBLL = userBLL;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePassword formchangepassword = new ChangePassword(userBLL);
                formchangepassword.ShowDialog();
                userBLL.verifyuser(userBLL.getid());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void SPSpace_Load(object sender, EventArgs e)
        {
            try
            {
                cbxActionreceipt.SelectedIndex = 0;
                cbxTypereceipt.SelectedIndex = 0;
                txtNamereceipt.Text = userBLL.getname();
                LoadInventory();
                LoadUser();
                LoadTime();
                LoadReceiptType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void LoadReceiptType()
        {
            try
            {
                ReceiptBLL receiptBLL = new ReceiptBLL();
                cbxTypereceipt.DataSource = receiptBLL.loadreceipttype();
                cbxTypereceipt.DisplayMember = "nametype";
                cbxTypereceipt.ValueMember = "idtype";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

        }

        private void LoadTime()
        {
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            time();
        }

        private void time()
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lbltime.Text = date;
        }

        private void LoadUser()
        {
            try
            {
                cbxReceiver.DataSource = userBLL.loaduser();
                cbxReceiver.DisplayMember = "username";
                cbxReceiver.ValueMember = "iduser";
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"help.chm");
        }

        private void loadlistreceipt()
        {
            try
            {
                dgvReceipt.DataSource = receiptBLL.loadreceipt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvItem.DataSource = itemBLL.loaditem(txtItem.Text, cbxCategory.SelectedValue.ToString());
                foreach (DataGridViewColumn cols in dgvItem.Columns)
                {
                    cols.SortMode = DataGridViewColumnSortMode.NotSortable;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time();
        }

        private void btnShowallreceipt_Click(object sender, EventArgs e)
        {
            try
            {
                loadlistreceipt();
                foreach (DataGridViewColumn cols in dgvReceipt.Columns)
                {
                    cols.SortMode = DataGridViewColumnSortMode.NotSortable;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubject.Text.Trim() == "")
                {
                    MessageBox.Show("Subject is empty!", "ERROR");
                }
                else
                    if (txtContent.Text.Trim() == "")
                    {
                        MessageBox.Show("Content is empty!", "ERROR");
                    }
                    else
                    {
                        mailBLL.sendmail(userBLL.getid(), cbxReceiver.SelectedValue.ToString(), txtSubject.Text, txtContent.Text);
                        MessageBox.Show("Success", "NOTICE");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnConfirmreceipt_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxActionreceipt.SelectedIndex == 0)
                {
                    receiptBLL = new ReceiptBLL();
                    receiptBLL.createreceipt(userBLL.getid(), DateTime.ParseExact(lbltime.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), Convert.ToInt32(cbxTypereceipt.SelectedValue));
                    ReceiptDetail formreceiptdetail = new ReceiptDetail(receiptBLL);
                    formreceiptdetail.ShowDialog();
                    loadlistreceipt();
                }
                else
                {
                    if (dgvReceipt.CurrentCell != null)
                    {
                        DialogResult result = MessageBox.Show("Do you want to cancel this receipt?", "NOTICE", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DataTable dt = new DataTable();
                            int rownumber = dgvReceipt.CurrentCell.RowIndex;
                            dt = (DataTable)dgvReceipt.DataSource;
                            string idreceipt = dt.Rows[rownumber][0].ToString();
                            receiptBLL.cancelreceipt(idreceipt);
                            MessageBox.Show("Receipt " + idreceipt + " has been cancel", "NOTICE");
                            loadlistreceipt();
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no receipt to cancel!", "ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                string category = cbxCategory.SelectedValue.ToString();
                dgvItem.DataSource = itemBLL.loaditem("", category);
                foreach (DataGridViewColumn cols in dgvItem.Columns)
                {
                    cols.SortMode = DataGridViewColumnSortMode.NotSortable;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnResetinform_Click(object sender, EventArgs e)
        {
            resetinform();
        }

        private void resetinform()
        {
            txtSubject.Text = "";
            txtContent.Text = "";
        }

        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbxActionreceipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
