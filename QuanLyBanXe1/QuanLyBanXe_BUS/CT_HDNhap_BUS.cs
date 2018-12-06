using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class CT_HDNhap_BUS
    {
        CT_HDNhap_DAL cn = new CT_HDNhap_DAL();

        public int KiemTra(string mahdn, string maxe)
        {
            return cn.KiemTra(mahdn, maxe); 
        }

        public void ThemDuLieu(CT_HDNhap et)
        {
            cn.ThemDuLieu(et);
        }

        public void SuaDuLieu(CT_HDNhap et)
        {
            cn.SuaDuLieu(et);
        }

        public void XoaDuLieu(CT_HDNhap et)
        {
            cn.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }

        public DataTable LayThongTinHoaDonNhap(string DieuKien)
        {
            return cn.LayThongTinHoaDonNhap(DieuKien);
        }

        public DataTable LayThongTinXe(string DieuKien)
        {
            return cn.LayThongTinXe(DieuKien);
        }

        public DataTable LayThongTinMaHDNhap(string DieuKien)
        {
            return cn.LayThongTinMaHDNhap(DieuKien);
        }
        public DataTable LayThongTinMaXe(string DieuKien)
        {
            return cn.LayThongTinMaXe(DieuKien);
        }
        public DataTable LayThongTinSoLuong(string DieuKien)
        {
            return cn.LayThongTinSoLuong(DieuKien);
        }
        public DataTable LayThongTinDonGia(string DieuKien)
        {
            return cn.LayThongTinDonGia(DieuKien);
        }
        public DataTable LayThongTinThanhTien(string DieuKien)
        {
            return cn.LayThongTinThanhTien(DieuKien);
        }

        public int KiemTraMaHDNhap(string x)
        {
            return cn.KiemTraMaHDNhap(x);
        }
        public int KiemTraMaXe(string x)
        {
            return cn.KiemTraMaXe(x);
        }
        public int KiemTraSoLuong(string x)
        {
            return cn.KiemTraSoLuong(x);
        }
        public int KiemTraDonGia(string x)
        {
            return cn.KiemTraDonGia(x);
        }
        public int KiemTraThanhTien(string x)
        {
            return cn.KiemTraThanhTien(x);
        }
    }
}
