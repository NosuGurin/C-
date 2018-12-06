using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_DAL
{
    public class CT_HDNhap_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();

        public int KiemTra(string mahdn, string maxe)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CT_HDNHAP WHERE Mahdnhap='"+mahdn+"' AND Maxe='"+maxe+"'"));
        }

        public void ThemDuLieu(CT_HDNhap et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO CT_HDNHAP(Mahdnhap, Maxe, Soluong, Dongia,Thanhtien)
VALUES ('" + et.Mahdn1 + "','" + et.Maxe1 + "','" + et.Soluong1 + "','" + et.Dongia1 + "','" +et.Thanhtien1+ "')");
        }

        public void SuaDuLieu(CT_HDNhap et)
        {
            cn.ThucThiCauLenhSql(@"UPDATE CT_HDNHAP
SET  Maxe ='" + et.Maxe1 + "', Soluong ='" + et.Soluong1 + "', Dongia ='" + et.Dongia1 + "', Thanhtien ='" + et.Thanhtien1 + "' where Mahdnhap='" + et.Mahdn1 + "'");
        }

        public void XoaDuLieu(CT_HDNhap et)
        {
            cn.ThucThiCauLenhSql("DELETE FROM CT_HDNHAP WHERE Mahdnhap='"+et.Mahdn1+"'");
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CT_HDNHAP "+DieuKien);
        }

        public DataTable LayThongTinHoaDonNhap(string DieuKien)
        {
            return cn.GetDataTable("SELECT Mahdnhap FROM HOADONNHAP " + DieuKien);
        }

        public DataTable LayThongTinXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT Maxe,Tenxe,Dongia FROM XE " + DieuKien);
        }

        public DataTable LayThongTinMaHDNhap(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CT_HDNHAP where Mahdnhap='" + DieuKien + "'");
        }
        public DataTable LayThongTinMaXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CT_HDNHAP where Maxe='" + DieuKien + "'");
        }

        public DataTable LayThongTinSoLuong(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CT_HDNHAP where Soluong='" + DieuKien + "'");
        }
        public DataTable LayThongTinDonGia(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CT_HDNHAP where DonGia='" + DieuKien + "'");
        }
        public DataTable LayThongTinThanhTien(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CT_HDNHAP where Thanhtien='" + DieuKien + "'");
        }

        public int KiemTraMaHDNhap(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CT_HDNHAP WHERE Mahdnhap='" + x + "'"));
        }
        public int KiemTraMaXe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CT_HDNHAP WHERE Maxe='" + x + "'"));
        }
        public int KiemTraSoLuong(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CT_HDNHAP WHERE Soluong='" + x + "'"));
        }
        public int KiemTraDonGia(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CT_HDNHAP WHERE Dongia='" + x + "'"));
        }
        public int KiemTraThanhTien(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CT_HDNHAP WHERE Thanhtien='" + x + "'"));
        }
    }
}
