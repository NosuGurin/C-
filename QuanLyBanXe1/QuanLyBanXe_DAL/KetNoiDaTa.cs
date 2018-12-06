using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanXe_DAL
{
    public class KetNoiDaTa
    {
        public static SqlConnection connect;

        public  void MoKetNoi()
        {
             
            if (KetNoiDaTa.connect == null)
                KetNoiDaTa.connect = new SqlConnection("Data Source=ADMINPC;Initial Catalog=QuanLyBanXe6;Integrated Security=SSPI;");
            if (KetNoiDaTa.connect.State != ConnectionState.Open)
                KetNoiDaTa.connect.Open();

            
        }

       

        public  void DongKetNoi()
        {
            if (KetNoiDaTa.connect != null)
            {
                if (KetNoiDaTa.connect.State == ConnectionState.Open)
                    KetNoiDaTa.connect.Close();
            }
        }

        public void ThucThiCauLenhSql(string sql)
        {
            try
            {
                MoKetNoi();
               
                SqlCommand sqlcmd = new SqlCommand(sql,connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {
               
            }
        }

        public DataTable GetDataTable(string sql)
        {
            try
            {
                MoKetNoi();
                
                
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                
                return dt;
            }
            catch
            {
                return null;
            }
            
        }

        public string GetValue(string sql)
        {
            MoKetNoi();
            
            string tam = null;
            SqlCommand sqlcmd = new SqlCommand(sql,connect);
            SqlDataReader sqlrd = sqlcmd.ExecuteReader();
            while (sqlrd.Read())
                tam = sqlrd[0].ToString();
            DongKetNoi();
            return tam;
        }
    }
}
