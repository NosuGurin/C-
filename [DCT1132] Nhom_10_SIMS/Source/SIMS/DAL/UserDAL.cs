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
    public class UserDAL
    {
        private SqlConnection con = new Connection().getConnection();
        public Boolean verifyUser(string iduser)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_verifyuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@iduser", SqlDbType.NVarChar).Value = iduser;
            cmd.Parameters.Add("@result", SqlDbType.SmallInt).Value = 0;
            cmd.Parameters["@result"].Direction=ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            con.Close();
            if (Convert.ToInt16(cmd.Parameters["@result"].Value) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable verifylogin(string iduser)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_verifylogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@iduser", SqlDbType.NVarChar).Value = iduser;
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            DataTable dtlogin=new DataTable();
            sqlap.Fill(dtlogin);
            con.Close();
            return dtlogin;
        }

        public void changepassword(string iduser,string newpassword)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_changepassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@iduser", SqlDbType.NVarChar).Value = iduser;
            cmd.Parameters.Add("@newpassword", SqlDbType.NVarChar).Value = newpassword;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable loaduser()
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("SP_loaduser",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlap.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
