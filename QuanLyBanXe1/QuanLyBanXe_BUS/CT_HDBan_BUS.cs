using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;
using QuanLyBanXe_DAL;

namespace QuanLyBanXe_BUS
{
    public class CT_HDBan_BUS
    {
        CT_HDBan_DAL cn = new CT_HDBan_DAL();

        public int KiemTra(string mahdb, string maxe)
        {
            return cn.KiemTra(mahdb,maxe);
        }

        public void ThemDuLieu(CT_HDB et)
        {
            cn.ThemDuLieu(et);
        }
        public void SuaDuLieu(CT_HDB et)
        {
            cn.SuaDuLieu(et);
        }
        public void XoaDuLieu(CT_HDB et)
        {
            cn.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }
        public DataTable LayThongTinXe(string DieuKien)
        {
            return cn.LayThongTinXe(DieuKien);
        }
        public DataTable LayThongTinHD(string DieuKien)
        {
            return cn.LayThongTinHD(DieuKien);
        }

        public DataTable LayThongTinMaHDBan(string DieuKien)
        {
            return cn.LayThongTinMaHDBan(DieuKien);
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
        public DataTable LayThongTinThanhToan(string DieuKien)
        {
            return cn.LayThongTinThanhToan(DieuKien);
        }
        public DataTable LayThongTinTienTra(string DieuKien)
        {
            return cn.LayThongTinTienTra(DieuKien);
        }
        public DataTable LayThongTinTienThua(string DieuKien)
        {
            return cn.LayThongTinTienThua(DieuKien);
        }

        public int KiemTraMaHDBan(string x)
        {
            return cn.KiemTraMaHDBan(x);
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
        public int KiemTraThanhToan(string x)
        {
            return cn.KiemTraThanhToan(x);
        }
        public int KiemTraTienTra(string x)
        {
            return cn.KiemTraTienTra(x);
        }
        public int KiemTraTienThua(string x)
        {
            return cn.KiemTraTienThua(x);
        }
    }
}
