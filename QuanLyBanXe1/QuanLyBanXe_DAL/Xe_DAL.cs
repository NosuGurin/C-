using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;
using System.Data.SqlClient;

namespace QuanLyBanXe_DAL
{
    public class Xe_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();
        
        public int KiemTraThemXe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Maxe='" + x + "'"));
        }
        public void ThemDuLieu(Xe et)
        {
            
            cn.ThucThiCauLenhSql(@"INSERT INTO XE(Maxe, Tenxe, Soluongton, Maloaixe, Mansx, Mancc, Dongia)
VALUES     ('" + et.Maxe1 + "','" + et.Tenxe1 + "','" + et.Soluongton1 + "','" + et.Maloaixe1 + "','" + et.Mansx1 + "','" + et.Mancc1 + "','" + et.Dongia1 + "')");
        }
        public void SuaDuLieu(Xe et)
        {
            cn.ThucThiCauLenhSql(@"UPDATE    XE
SET              Tenxe ='" + et.Tenxe1 + "', Soluongton ='" + et.Soluongton1 + "', Maloaixe ='" + et.Maloaixe1 + "', Mansx ='" + et.Mansx1 + "', Mancc ='" + et.Mancc1 + "', Dongia ='" + et.Dongia1 + "'  WHERE Maxe='" + et.Maxe1 + "'");

        }
        public void XoaDuLieu(Xe et)
        {
            cn.ThucThiCauLenhSql(@"DELETE FROM XE WHERE Maxe='"+et.Maxe1+"'");
        }
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE " + DieuKien);
        }

        public DataTable LayThongTinLoaiXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE where Maloaixe='" + DieuKien + "'");
        }

        public DataTable LayThongTinNhaSanXuat(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE where Mansx='" + DieuKien + "'");
        }
        public DataTable LayThongTinNhaCungCap(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE where Mancc='" + DieuKien + "'");
        }

        public DataTable LayThongTinMaXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE where Maxe='"+ DieuKien+"'" );
        }
        public DataTable LayThongTinTenXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE where Tenxe='" + DieuKien + "'");
        }
        public DataTable LayThongTinSoluongton(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE where Soluongton='" + DieuKien + "'");
        }
        public DataTable LayThongTinDongia(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM XE where Dongia='" + DieuKien + "'");
        }

        public int KiemTraMaxe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Maxe='"+ x + "'"));
        }
        public int KiemTraTenxe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Tenxe='" + x + "'"));
        }
        public int KiemTraSoluong(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Soluongton='" + x + "'"));
        }
        public int KiemTraMaloaixe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Maloaixe='" + x + "'"));
        }
        public int KiemTraMansx(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Mansx='" + x + "'"));
        }
        public int KiemTraMancc(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Mancc='" + x + "'"));
        }
        public int KiemTraDongia(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM XE WHERE Dongia='" + x + "'"));
        }

        
    }
}
