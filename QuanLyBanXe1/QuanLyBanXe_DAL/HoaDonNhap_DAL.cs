using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_DAL
{
     public class HoaDonNhap_DAL
    {
         KetNoiDaTa cn = new KetNoiDaTa();

         public int KiemTraThemHDN(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONNHAP WHERE Mahdnhap='" + x + "'"));
         }
         public void ThemDuLieu(HoaDonNhap et)
         {
             cn.ThucThiCauLenhSql(@"INSERT INTO HOADONNHAP(Mahdnhap, Mancc, Manv, Ngaynhap)
VALUES('" + et.Mahdn1 + "','" + et.Mancc1 + "','" + et.Manv1 + "','" + et.Ngaynhap1 + "')");
         }
         public void SuaDuLieu(HoaDonNhap et)
         {
             cn.ThucThiCauLenhSql(@"UPDATE HOADONNHAP
SET Mancc ='" + et.Mancc1 + "', Manv ='" + et.Manv1 + "', Ngaynhap ='" + et.Ngaynhap1 + "' where Mahdnhap='" + et.Mahdn1 + "'");
         }
         public void XoaDuLieu(HoaDonNhap et)
         {
             cn.ThucThiCauLenhSql(@"DELETE FROM HOADONNHAP where Mahdnhap='" + et.Mahdn1 + "'");
         }

         public DataTable TaoBang(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM HOADONNHAP "+DieuKien);
         }
         public DataTable LayThongTinNhaCungCap(string DieuKien)
         {
             return cn.GetDataTable("SELECT Mancungcap FROM NHACUNGCAP " + DieuKien);
         }
         public DataTable LayThongTinNhanVien(string DieuKien)
         {
             return cn.GetDataTable("SELECT Manv,Tennv FROM NHANVIEN " + DieuKien);
         }
         public DataTable LayThongTinXe(string DieuKien)
         {
             return cn.GetDataTable("SELECT Maxe,Tenxe FROM XE " + DieuKien);
         }

         public DataTable LayThongTinMaHDNhap(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM HOADONNHAP where Mahdnhap='" + DieuKien + "'");
         }
         public DataTable LayThongTinMaNhaCungCap(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM HOADONNHAP where Mancc='" + DieuKien + "'");
         }

         public DataTable LayThongTinMaNhanVien(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM HOADONNHAP where Manv='" + DieuKien + "'");
         }
         public DataTable LayThongTinNgayNhap(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM HOADONNHAP where Ngaynhap='" + DieuKien + "'");
         }

         public int KiemTraMaHDNhap(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONNHAP WHERE Mahdnhap='" + x + "'"));
         }
         public int KiemTraMaNhaCungCap(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONNHAP WHERE Mancc='" + x + "'"));
         }
         public int KiemTraMaNhanVien(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONNHAP WHERE Manv='" + x + "'"));
         }
         public int KiemTraNgayNhap(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONNHAP WHERE Ngaynhap='" + x + "'"));
         }
    }
}
