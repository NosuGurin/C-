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
    public class HocSinhDAO
    {
        public void ThemHS(HocSinhDTO hsDTO)
        {
            SqlConnection cn = Connect.getConnection();
            SqlCommand cmd = new SqlCommand("InsertHocSinh", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tenhs", SqlDbType.NVarChar);
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime);
            cmd.Parameters.Add("@malop", SqlDbType.Int);
            cmd.Parameters.Add("@mahs", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@tenhs"].Value = hsDTO.Tenhs;
            cmd.Parameters["@diachi"].Value = hsDTO.Diachi;
            cmd.Parameters["@dienthoai"].Value = hsDTO.Dienthoai;
            cmd.Parameters["@ngaysinh"].Value = hsDTO.Ngaysinh;
            cmd.Parameters["@malop"].Value = hsDTO.Malop;

            cmd.ExecuteNonQuery();

            int maHS = Convert.ToInt32(cmd.Parameters["@mahs"].Value);
            hsDTO.Mahs = maHS;
            cn.Close();
        }

        public DataTable LoadDSHocSinh()
        {
            DataTable dtHocSinh = new DataTable();
            SqlConnection cn = Connect.getConnection();
            SqlCommand cmd = new SqlCommand("LoadDSHocSinh", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtHocSinh);
            cn.Close();
            return dtHocSinh;
        }

        public int IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return 0;
            }
            return 1;
        }
    }
}
