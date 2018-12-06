using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class HoaDonBan_BUS
    {
        HoaDonBan_DAL cn = new HoaDonBan_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemHDB(x);
        }
        public void ThemDuLieu(HoaDonBan et)
        {
            cn.ThemDuLieu(et);
        }
        public void SuaDuLieu(HoaDonBan et)
        {
            cn.SuaDuLieu(et);
        }
        public void XoaDuLieu(HoaDonBan et)
        {
            cn.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }

        public DataTable LayThongTinKhachHang(string DieuKien)
        {
            return cn.LayThongTinKhachHang(DieuKien);
        }

        public DataTable LayThongTinNhanVien(string DieuKien)
        {
            return cn.LayThongTinNhanVien(DieuKien);
        }
        public DataTable LayThongTinXe(string DieuKien)
        {
            return cn.LayThongTinXe(DieuKien);
        }


        public DataTable LayThongTinMaHDBan(string DieuKien)
        {
            return cn.LayThongTinMaHDBan(DieuKien);
        }
        public DataTable LayThongTinMaNhaCungCap(string DieuKien)
        {
            return cn.LayThongTinMaNhaCungCap(DieuKien);
        }
        public DataTable LayThongTinMaNhanVien(string DieuKien)
        {
            return cn.LayThongTinMaNhanVien(DieuKien);
        }
        public DataTable LayThongTinNgayBan(string DieuKien)
        {
            return cn.LayThongTinNgayBan(DieuKien);
        }

        public int KiemTraMaHDBan(string x)
        {
            return cn.KiemTraMaHDBan(x);
        }
        public int KiemTraMaNhaCungCap(string x)
        {
            return cn.KiemTraMaNhaCungCap(x);
        }
        public int KiemTraMaNhanVien(string x)
        {
            return cn.KiemTraMaNhanVien(x);
        }
        public int KiemTraNgayBan(string x)
        {
            return cn.KiemTraNgayBan(x);
        }
    }
}
