using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LopHocDAO
    {
        public DataTable LoadDSLop()
        {
            DataTable dtLop = new DataTable();
            SqlConnection cn = Connect.getConnection();
            SqlCommand cmd = new SqlCommand("LoadDSLop",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtLop);
            cn.Close();
            return dtLop;
        }

        public void SuaLop(LopHocDTO lopDTO)
        {
            SqlConnection cn = Connect.getConnection();
            SqlCommand cmd = new SqlCommand("UpdateLop", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Int);
            cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar);
            cmd.Parameters.Add("@siso", SqlDbType.Int);

            cmd.Parameters["@malop"].Value = lopDTO.Malop;
            cmd.Parameters["@tenlop"].Value = lopDTO.Tenlop;
            cmd.Parameters["@siso"].Value = lopDTO.Siso;
            
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void XoaLop(int malop)
        {
            SqlConnection cn = Connect.getConnection();
            SqlCommand cmd = new SqlCommand("DeleteLop", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Int);

            cmd.Parameters["@malop"].Value = malop;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
