using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Globalization;

namespace BLL
{
    public class ItemBLL
    {
        private ItemDAL itemDAL = new ItemDAL();
        private DataTable item = new DataTable();
        private DataTable category = new DataTable();

        public DataTable loadcategory()
        {
            category = itemDAL.loadcategory();
            DataRow row = category.NewRow();
            row[0] = "0";
            row[1] = "All";
            category.Rows.InsertAt(row, 0);
            return category;
        }

        public DataTable loaditem(string name, string category)
        {
            DataTable item = new DataTable();
            item = itemDAL.loadItem(name, category);
            item.Columns[0].ColumnName = "ID";
            item.Columns[1].ColumnName = "Name";
            item.Columns[2].ColumnName = "Category";
            item.Columns[3].ColumnName = "Quantity";
            item.Columns[4].ColumnName = "Import price";
            item.Columns[5].ColumnName = "Export price";
            return item;
        }

        public Boolean verifyitem(string iditem)
        {
            item = itemDAL.verifyitem(iditem);
            if (item.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void modifyquantity(string iditem, int quantity)
        {
            itemDAL.modifyquantity(iditem, quantity);
        }
        public float getprice()
        {
            return float.Parse(item.Rows[0]["exportprice"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
        }

        public string getname()
        {
            return item.Rows[0]["nameitem"].ToString();
        }

        public int getmaxquantity()
        {
            return Convert.ToInt32(item.Rows[0]["quantity"]);
        }
    }
}
