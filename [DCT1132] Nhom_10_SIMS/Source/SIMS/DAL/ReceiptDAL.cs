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
    public class ReceiptDAL
    {
        SqlConnection con = new Connection().getConnection();

        public DataTable loadreceipt()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_loadreceipt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlap.Fill(dt);
            con.Close();
            return dt;
        }

        public string addreceipt(string iduser, DateTime date, int idtype, float total)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_addreceipt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idreceipt", SqlDbType.NVarChar,50).Value = "";
            cmd.Parameters.Add("@iduser", SqlDbType.NVarChar).Value = iduser;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@idtype", SqlDbType.Int).Value = idtype;
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = total;
            cmd.Parameters["@idreceipt"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string idreceipt = cmd.Parameters["@idreceipt"].Value.ToString();
            con.Close();
            return idreceipt;
        }

        public void addreceiptdetail(string idreceipt, string idreceiptdetail,string iditem, int quantity, float subtotal)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_addreceiptdetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idreceipt", SqlDbType.NVarChar).Value = idreceipt;
            cmd.Parameters.Add("@idreceiptdetail", SqlDbType.NVarChar).Value = idreceiptdetail;
            cmd.Parameters.Add("@iditem", SqlDbType.NVarChar).Value = iditem;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
            cmd.Parameters.Add("@subtotal", SqlDbType.Float).Value = subtotal;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void cancelreceipt(string idreceipt)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_cancelreceipt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idreceipt", SqlDbType.NVarChar).Value = idreceipt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable loadreceipttype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_loadreceipttype", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlap.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
