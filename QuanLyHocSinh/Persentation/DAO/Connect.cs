using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Connect
    {
        public static SqlConnection getConnection()
        {
            string constring = "Data Source=ADMINPC;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            return con;
        }
    }
}
