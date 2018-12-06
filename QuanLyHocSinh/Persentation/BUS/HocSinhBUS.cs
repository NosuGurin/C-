using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class HocSinhBUS
    {
        HocSinhDAO hsDAO = new HocSinhDAO();
        public void ThemHs(HocSinhDTO hsDTO)
        {
           
            hsDAO.ThemHS(hsDTO);
        }

        public DataTable LoadDSHocSinh()
        {
            DataTable dt = new DataTable();
            dt = hsDAO.LoadDSHocSinh();
            return dt;
        }

        public int IsNumber(string x)
        {
           return  hsDAO.IsNumber(x);
        }
    }
}
