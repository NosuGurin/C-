using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class HoaDonNhap_BUS
    {
        HoaDonNhap_DAL cn = new HoaDonNhap_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemHDN(x);
        }
        public void ThemDuLieu(HoaDonNhap et)
        {
            cn.ThemDuLieu(et);
        }
        public void SuaDuLieu(HoaDonNhap et)
        {
            cn.SuaDuLieu(et);
        }
        public void XoaDuLieu(HoaDonNhap et)
        {
            cn.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }
        public DataTable LayThongTinNhaCungCap(string DieuKien)
        {
            return cn.LayThongTinNhaCungCap(DieuKien);
        }
        public DataTable LayThongTinNhanVien(string DieuKien)
        {
            return cn.LayThongTinNhanVien(DieuKien);
        }

        public DataTable LayThongTinMaHDNhap(string DieuKien)
        {
            return cn.LayThongTinMaHDNhap(DieuKien);
        }
        public DataTable LayThongTinMaNhaCungCap(string DieuKien)
        {
            return cn.LayThongTinMaNhaCungCap(DieuKien);
        }
        public DataTable LayThongTinMaNhanVien(string DieuKien)
        {
            return cn.LayThongTinMaNhanVien(DieuKien);
        }
        public DataTable LayThongTinNgayNhap(string DieuKien)
        {
            return cn.LayThongTinNgayNhap(DieuKien);
        }

        public int KiemTraMaHDNhap(string x)
        {
            return cn.KiemTraMaHDNhap(x);
        }
        public int KiemTraMaNhaCungCap(string x)
        {
            return cn.KiemTraMaNhaCungCap(x);
        }
        public int KiemTraMaNhanVien(string x)
        {
            return cn.KiemTraMaNhanVien(x);
        }
        public int KiemTraNgayNhap(string x)
        {
            return cn.KiemTraNgayNhap(x);
        }
    }
}
