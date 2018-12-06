using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_DAL
{
    public class CT_HDBan_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa ();

        public int KiemTra(string mahdb, string maxe)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Mahdb='"+mahdb+"' AND Maxe='"+maxe+"'" ));
        }

        public void ThemDuLieu(CT_HDB et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO CTHDBAN
                      (Mahdban, Maxe, Soluong, Dongia, Tientra, Tienthua, Thanhtoan)
VALUES ('" + et.Mahdb1 + "','" + et.Maxe1 + "','" + et.Soluong1 + "','" + et.Dongia1 + "','" + et.Tientra1 + "','" + et.Tienthua1 + "','" + et.Thanhtoan1 + "')");
        }
        public void SuaDuLieu(CT_HDB et)
        {
            cn.ThucThiCauLenhSql(@" UPDATE    CTHDBAN
SET  Maxe ='" + et.Maxe1 + "', Soluong ='" + et.Soluong1 + "', Dongia ='" + et.Dongia1 + "', Tientra ='" + et.Tientra1 + "', Tienthua ='" + et.Tienthua1 + "', Thanhtoan ='" + et.Thanhtoan1 + "' WHERE Mahdban='" + et.Mahdb1 + "'");
        }
        public void XoaDuLieu(CT_HDB et)
        {
            cn.ThucThiCauLenhSql(@"DELETE FROM CTHDBAN WHERE Mahdban='"+et.Mahdb1+"'");
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN "+DieuKien);
        }
        public DataTable LayThongTinXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT Maxe,Tenxe,Dongia FROM XE " + DieuKien);
        }
        public DataTable LayThongTinHD(string DieuKien)
        {
            return cn.GetDataTable("SELECT Mahdban FROM HOADONBAN " + DieuKien);
        }

        public DataTable LayThongTinMaHDBan(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN where Mahdban='" + DieuKien + "'");
        }
        public DataTable LayThongTinMaXe(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN where Maxe='" + DieuKien + "'");
        }

        public DataTable LayThongTinSoLuong(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN where Soluong='" + DieuKien + "'");
        }
        public DataTable LayThongTinDonGia(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN where DonGia='" + DieuKien + "'");
        }
        public DataTable LayThongTinTienTra(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN where Tientra='" + DieuKien + "'");
        }
        public DataTable LayThongTinTienThua(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN where Tienthua='" + DieuKien + "'");
        }
        public DataTable LayThongTinThanhToan(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM CTHDBAN where Thanhtoan='" + DieuKien + "'");
        }

        public int KiemTraMaHDBan(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Mahdban='" + x + "'"));
        }
        public int KiemTraMaXe(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Maxe='" + x + "'"));
        }
        public int KiemTraSoLuong(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Soluong='" + x + "'"));
        }
        public int KiemTraDonGia(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Dongia='" + x + "'"));
        }
        public int KiemTraTienTra(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Tientra='" + x + "'"));
        }
        public int KiemTraTienThua(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Tienthua='" + x + "'"));
        }
        public int KiemTraThanhToan(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM CTHDBAN WHERE Thanhtoan='" + x + "'"));
        }

    }
}
