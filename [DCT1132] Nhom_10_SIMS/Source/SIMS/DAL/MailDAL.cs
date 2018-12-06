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
    public class MailDAL
    {
        SqlConnection con = new Connection().getConnection();
        public void sendmail(string idsend, string idreceive, string subject, string content)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_sendmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sender", SqlDbType.NVarChar).Value = idsend;
            cmd.Parameters.Add("@receiver", SqlDbType.NVarChar).Value = idreceive;
            cmd.Parameters.Add("@subject", SqlDbType.NVarChar).Value = subject;
            cmd.Parameters.Add("@content", SqlDbType.NVarChar).Value = content;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable loadlistmail(string iduser)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_loadlistmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@receiver", SqlDbType.NVarChar).Value = iduser;
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            DataTable dtlistmail = new DataTable();
            sqlap.Fill(dtlistmail);
            con.Close();
            return dtlistmail;
        }

        public void confirmmail(string idmail)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_confirmmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idmail", SqlDbType.NVarChar).Value = idmail;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
