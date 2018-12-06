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
    public partial class ReceiptDetail : Form
    {
        private UserBLL userBLL;
        private ItemBLL itemBLL;
        private ReceiptBLL receiptBLL;
        private int grandtotal = 0;

        public ReceiptDetail()
        {
            InitializeComponent();
        }

        public ReceiptDetail(ReceiptBLL receiptBLL_)
        {
            InitializeComponent();
            receiptBLL = receiptBLL_;
        }

        private void ReceiptDetail_Load(object sender, EventArgs e)
        {
            cbxAction.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel this receipt?", "NOTICE", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (!receiptBLL.isreceiptdetailnull())
                {
                    MessageBox.Show("Details must not null!", "ERROR");
                }
                else
                {
                    receiptBLL.finishreceipt(float.Parse(txtTotal.Text));
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbxAction.SelectedIndex)
                {
                    case 0:
                        if (txtQuantity.Value == 0)
                        {
                            MessageBox.Show("Your quanity must be bigger than 0", "ERROR!");
                            txtQuantity.Focus();
                            txtQuantity.Select(0, 1);
                        }
                        else
                        {
                            string iditem = txtIditem.Text;
                            iditem = iditem.ToUpper().ToString();
                            DataTable dtdetail = receiptBLL.addreceiptdetail(iditem, itemBLL.getname(), Convert.ToInt16(txtQuantity.Value), itemBLL.getprice());
                            dgvReceiptDetail.DataSource = dtdetail;
                            txtTotal.Text = receiptBLL.getreceiptgrantotal().ToString();
                            startadd();
                        }
                        break;
                    case 1:
                        if (dgvReceiptDetail.CurrentCell != null)
                        {
                            if (txtQuantity.Value == 0)
                            {
                                MessageBox.Show("Your quanity must be bigger than 0", "ERROR!");
                                txtQuantity.Focus();
                                txtQuantity.Select(0, 1);
                            }
                            else
                            {
                                string iditem = txtIditem.Text;
                                iditem = iditem.ToUpper().ToString();
                                int rownum = dgvReceiptDetail.CurrentCell.RowIndex;
                                int quantity = (int)txtQuantity.Value;
                                itemBLL.verifyitem(iditem);
                                DataTable dtdetail = receiptBLL.mofidyreceiptdetail(rownum, quantity,itemBLL.getprice());
                                dgvReceiptDetail.DataSource = dtdetail;
                                txtTotal.Text = receiptBLL.getreceiptgrantotal().ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no detail to modify!", "ERROR");
                        }
                        break;
                    case 2:
                        if (dgvReceiptDetail.CurrentCell != null)
                        {
                            int rownum = dgvReceiptDetail.CurrentCell.RowIndex;
                            DataTable dtdetail = receiptBLL.deletereceiptdetail(rownum);
                            dgvReceiptDetail.DataSource = dtdetail;
                            txtTotal.Text = receiptBLL.getreceiptgrantotal().ToString();
                        }
                        else
                        {
                            MessageBox.Show("There is no detail to delete!", "ERROR");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void txtIditem_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                itemBLL = new ItemBLL();
                string iditem = txtIditem.Text;
                iditem = iditem.ToUpper().ToString();
                if (!itemBLL.verifyitem(iditem))
                {
                    MessageBox.Show(this, "Wrong item ID", "ERROR!");
                    txtIditem.Focus();
                    txtIditem.SelectAll();
                }
                else
                {
                    if (!receiptBLL.verifyreceiptdetail(iditem))
                    {
                        MessageBox.Show(this, "This item is already exists!", "ERROR!");
                        txtIditem.Focus();
                        txtIditem.SelectAll();
                    }
                    else
                    {
                        lbMaxquantity.Text = "/ " + itemBLL.getmaxquantity().ToString();
                        txtQuantity.Maximum = itemBLL.getmaxquantity();
                        enablequantity();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void enablequantity()
        {
            btnAdd.Enabled = false;
            txtQuantity.ReadOnly = false;
            txtIditem.ReadOnly = true;
            txtQuantity.Focus();
            txtQuantity.Select(0,1);
        }

        private void disableall()
        {
            txtQuantity.ReadOnly = true;
            txtIditem.ReadOnly = true;
            btnAdd.Enabled = false;
        }

        private void loaddetail()
        {
            try
            {
                if (dgvReceiptDetail.CurrentCell != null)
                {
                    int rownum = dgvReceiptDetail.CurrentCell.RowIndex;
                    txtIditem.Text = dgvReceiptDetail["Item ID", rownum].Value.ToString();
                    txtQuantity.Text = dgvReceiptDetail["Quantity", rownum].Value.ToString();
                }
                else
                {
                    txtIditem.Text = "";
                    txtQuantity.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void startadd()
        {
            btnAdd.Enabled = true;
            txtIditem.ReadOnly = false;
            txtQuantity.ReadOnly = true;
            txtQuantity.Value = 0;
            lbMaxquantity.Text = "";
            txtIditem.Text = "";
            txtIditem.Select();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            startadd();
        }

        private void cbxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbxAction.SelectedIndex)
                {
                    case 0:
                        startadd();
                        break;
                    case 1:
                        enablequantity();
                        lbMaxquantity.Text = "/ " + itemBLL.getmaxquantity().ToString();
                        txtQuantity.Maximum = itemBLL.getmaxquantity();
                        btnAdd.Enabled = false;
                        loaddetail();
                        break;
                    case 2:
                        disableall();
                        loaddetail();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void dgvReceiptDetail_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxAction.SelectedIndex == 1 || cbxAction.SelectedIndex == 2)
                {
                    loaddetail();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void dgvReceiptDetail_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvReceiptDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn cols in dgvReceiptDetail.Columns)
            {
                cols.SortMode = DataGridViewColumnSortMode.NotSortable;
            } 
        }


    }
}
