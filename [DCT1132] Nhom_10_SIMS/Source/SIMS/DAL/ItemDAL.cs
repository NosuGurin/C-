using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class ItemDAL
    {
        private SqlConnection con = new Connection().getConnection();

        public DataTable loadItem(string nameItem, string idCategory)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_loaditem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nameitem", SqlDbType.NVarChar).Value = nameItem;
            cmd.Parameters.Add("@idcategory", SqlDbType.NVarChar).Value = idCategory;
            DataTable dt=new DataTable();
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            sqlap.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable verifyitem(string iditem)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_verifyitem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@iditem", SqlDbType.NVarChar).Value = iditem;
            DataTable dt = new DataTable();
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            sqlap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable loadcategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_loadcategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@idcategory", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlap.Fill(dt);
            con.Close();
            return dt;
        }

        public void modifyquantity(string iditem, int quantity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_modifyquantity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@iditem", SqlDbType.NVarChar).Value = iditem;
            cmd.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = quantity;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
