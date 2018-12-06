using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    class Connection
    {
        public SqlConnection getConnection()
        {
            string constring = "Data Source=localhost;Initial Catalog=DesignSIMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            return con;
        }
    }
}
