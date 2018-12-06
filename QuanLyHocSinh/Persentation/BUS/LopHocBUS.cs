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
    public class LopHocBUS
    {
        LopHocDAO lopDAO = new LopHocDAO();
        public DataTable LoadDSLop()
        {
            
            DataTable dt = new DataTable();
            dt = lopDAO.LoadDSLop();
            return dt;
        }

        public void SuaLop(LopHocDTO lopDTO)
        {
            lopDAO.SuaLop(lopDTO);
        }

        public void XoaLop(int malop)
        {
            lopDAO.XoaLop(malop);
        }
    }
}
