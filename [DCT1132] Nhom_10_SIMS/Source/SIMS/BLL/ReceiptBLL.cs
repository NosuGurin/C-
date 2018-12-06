using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ReceiptBLL
    {
        private ReceiptDAL receiptDAL = new ReceiptDAL();
        private DataTable receipttype;
        private DataTable receiptdetail;
        private DataTable receipt;
        private int No=1;
        private string idreceipt,iduser;
        private int idtype;
        private DateTime date;
        private float grandtotal;

        public int getidtype()
        {
            return this.idtype;
        }

        public DataTable loadreceipt()
        {
            receipt = new DataTable();
            receipt = receiptDAL.loadreceipt();
            receipt.Columns[0].ColumnName = "ID";
            receipt.Columns[1].ColumnName = "Date";
            receipt.Columns[2].ColumnName = "Receipt Type";
            receipt.Columns[3].ColumnName = "Total";
            return receipt;
        }

        public DataTable loadreceipttype()
        {
            receipttype = new DataTable();
            receipttype = receiptDAL.loadreceipttype();
            return receipttype;
        }

        public void createreceipt(string iduser,DateTime date,int idtype)
        {
            this.iduser = iduser;
            this.date = date;
            this.idtype = idtype;
            createreceiptdetail();
        }

        private void createreceiptdetail()
        {
            receiptdetail = new DataTable();
            receiptdetail.Columns.Add("No.");
            receiptdetail.Columns.Add("Item ID");
            receiptdetail.Columns.Add("Item Name");
            receiptdetail.Columns.Add("Quantity");
            receiptdetail.Columns.Add("Subtotal");
        }

        public void finishreceipt(float total)
        {
            this.idreceipt=receiptDAL.addreceipt(this.iduser,this.date,this.idtype,total);
            foreach (DataRow row in receiptdetail.Rows)
            {
                receiptDAL.addreceiptdetail(this.idreceipt, row["No."].ToString(), row["Item ID"].ToString(), Convert.ToInt32(row["quantity"]), float.Parse(row["Subtotal"].ToString()));
            }
        }

        public Boolean verifyreceiptdetail(string iditem)
        {
            foreach (DataRow row in receiptdetail.Rows)
            {
                if (row["Item ID"].ToString() == iditem)
                {
                    return false;
                }
            }
            return true;
        }

        public DataTable addreceiptdetail(string iditem,string nameitem,int quantity,float exportprice)
        {
            DataRow row = receiptdetail.NewRow();
            row["No."] = No;
            No++;
            row["Item ID"] = iditem;
            row["Item Name"] = nameitem;
            row["Quantity"] = quantity;
            row["Subtotal"] = exportprice * quantity;
            receiptdetail.Rows.Add(row);
            return receiptdetail;
        }

        public void cancelreceipt(string idreceipt)
        {
            receiptDAL.cancelreceipt(idreceipt);
        }

        public DataTable deletereceiptdetail(int rownum)
        {
            receiptdetail.Rows.RemoveAt(rownum);
            this.No = 1;
            foreach (DataRow row in receiptdetail.Rows)
            {
                row["No."] = No;
                No++;
            }
            return receiptdetail;
        }

        public DataTable mofidyreceiptdetail(int rownum, int quantity, float exportprice)
        {
            receiptdetail.Rows[rownum]["Quantity"] = quantity;
            receiptdetail.Rows[rownum]["Subtotal"] = quantity * exportprice;
            return receiptdetail;
        }

        public float getreceiptgrantotal()
        {
            grandtotal = 0;
            foreach (DataRow row in receiptdetail.Rows)
            {
                float subtotal = float.Parse(row["Subtotal"].ToString());
                grandtotal += subtotal;
            }
            return grandtotal;
        }

        public Boolean isreceiptdetailnull()
        {
            if (receiptdetail.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
