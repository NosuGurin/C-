using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_DAL
{
    public class HoaDonBan_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();

        public int KiemTraThemHDB(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONBAN WHERE Mahdban='" + x + "'"));
        }
        public void ThemDuLieu(HoaDonBan et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO HOADONBAN (Mahdban, Makh, Ngayban, Manv, Ghichu)
VALUES ('" + et.Mahdb1 + "','" + et.Makh1 + "','" + et.Ngayban1 + "','" + et.Manv1 + "',N'" + et.Ghichu1 + "')");
        }
        public void SuaDuLieu(HoaDonBan et)
        {
            cn.ThucThiCauLenhSql(@"UPDATE    HOADONBAN
SET Makh ='" + et.Makh1 + "', Manv ='" + et.Manv1 + "', Ngayban ='" + et.Ngayban1 + "', Ghichu =N'" + et.Ghichu1 + "' WHERE Mahdban='" + et.Mahdb1 + "' ");
        }
        public void XoaDuLieu(HoaDonBan et)
        {
            cn.ThucThiCauLenhSql(@"DELETE FROM HOADONBAN WHERE Mahdban='"+et.Mahdb1+"'");
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM HOADONBAN " + DieuKien);
        }

        public DataTable LayThongTinKhachHang(string DieuKien)
        {
            return cn.GetDataTable("SELECT Makn,Tenkh FROM KHACHHANG " + DieuKien);
        }

        public DataTable LayThongTinNhanVien(string DieuKien)
        {
            return cn.GetDataTable("SELECT Manv,Tennv FROM NHANVIEN " + DieuKien);
        }
        public DataTable LayThongTinXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT Maxe,Tenxe FROM XE " + DieuKien);
        }

        public DataTable LayThongTinMaHDBan(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM HOADONBAN where Mahdban='" + DieuKien + "'");
        }
        public DataTable LayThongTinMaNhaCungCap(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM HOADONBAN where Makh='" + DieuKien + "'");
        }

        public DataTable LayThongTinMaNhanVien(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM HOADONBAN where Manv='" + DieuKien + "'");
        }
        public DataTable LayThongTinNgayBan(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM HOADONBAN where Ngayban='" + DieuKien + "'");
        }

        public int KiemTraMaHDBan(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONBAN WHERE Mahdban='" + x + "'"));
        }
        public int KiemTraMaNhaCungCap(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONBAN WHERE Makh='" + x + "'"));
        }
        public int KiemTraMaNhanVien(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONBAN WHERE Manv='" + x + "'"));
        }
        public int KiemTraNgayBan(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM HOADONBAN WHERE Ngayban='" + x + "'"));
        }
        
    }
}
