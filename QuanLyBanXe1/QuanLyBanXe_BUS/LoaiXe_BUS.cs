using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class LoaiXe_BUS
    {
        LoaiXe_DAL cn = new LoaiXe_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemLoaiXe(x);
        }
        public void ThemDuLieu(LoaiXe et)
        {
            cn.ThemDuLieu(et);
        }
        public void SuaDuLieu(LoaiXe et)
        {
            cn.SuaDuLieu(et);
        }
        public void XoaDuLieu(LoaiXe et)
        {
            cn.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }

        public DataTable LayThongTinLX(string DieuKien)
        {
            return cn.LayThongTinLoaiXe(DieuKien);
        }

        public DataTable LayThongTinMaLoaiXe(string DieuKien)
        {
            return cn.LayThongTinMaLoaiXe(DieuKien);
        }
        public DataTable LayThongTinTenLoaiXe(string DieuKien)
        {
            return cn.LayThongTinTenLoaiXe(DieuKien);
        }
        public DataTable LayThongTinDacDiem(string DieuKien)
        {
            return cn.LayThongTinDacDiem(DieuKien);
        }

        public int KiemTraMaLoaiXe(string x)
        {
            return cn.KiemTraMaLoaiXe(x);
        }
        public int KiemTraTenloaixe(string x)
        {
            return cn.KiemTraTenloaixe(x);
        }
        public int KiemTraDacDiem(string x)
        {
            return cn.KiemTraDacDiem(x);
        }
    }
}
