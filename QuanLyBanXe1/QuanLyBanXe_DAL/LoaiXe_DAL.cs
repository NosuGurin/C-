using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_DAL
{
    public class LoaiXe_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();

        public int KiemTraThemLoaiXe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM LOAIXE WHERE Maloaixe ='" + x + "'"));
        }
        public void ThemDuLieu(LoaiXe et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO LOAIXE (Maloaixe, Tenloaixe, Dacdiem)
VALUES     ('" + et.Maloaixe1 + "','" + et.Tenloaixe1 + "','" + et.Dacdiem1 + "')");
        }
        public void SuaDuLieu(LoaiXe et)
        {
            cn.ThucThiCauLenhSql(@"UPDATE    LOAIXE
SET  Tenloaixe ='" + et.Tenloaixe1 + "', Dacdiem ='" + et.Dacdiem1 + "'where Maloaixe='" + et.Maloaixe1 + "'");
        }
        public void XoaDuLieu(LoaiXe et)
        {
            cn.ThucThiCauLenhSql(@"DELETE FROM LOAIXE WHERE Maloaixe='"+et.Maloaixe1+"'");
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM LOAIXE "+DieuKien);
        }

        public DataTable LayThongTinLoaiXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT Maloaixe,Tenloaixe FROM LOAIXE " + DieuKien);
        }

        public int KiemTraMaLoaiXe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM LOAIXE WHERE Maloaixe='" + x + "'"));
        }
        public int KiemTraTenloaixe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM LOAIXE WHERE Tenloaixe='" + x + "'"));
        }
        public int KiemTraDacDiem(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM LOAIXE WHERE Dacdiem='" + x + "'"));
        }

        public DataTable LayThongTinMaLoaiXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM LOAIXE where Maloaixe='" + DieuKien + "'");
        }
        public DataTable LayThongTinTenLoaiXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM LOAIXE where Tenloaixe='" + DieuKien + "'");
        }

        public DataTable LayThongTinDacDiem(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM LOAIXE where Dacdiem='" + DieuKien + "'");
        }
    }
}
