using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class Xe_BUS
    {
        Xe_DAL cn = new Xe_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemXe(x);
        }
        public void ThemDuLieu(Xe et)
        {
            cn.ThemDuLieu(et);
        }
        public void SuaDuLieu(Xe et)
        {
            cn.SuaDuLieu(et);

        }
        public void XoaDuLieu(Xe et)
        {
            cn.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }

        public DataTable LayThongTinLoaiXe(string DieuKien)
        {
            return cn.LayThongTinLoaiXe(DieuKien);
        }

        public DataTable LayThongTinNhaSanXuat(string DieuKien)
        {
            return cn.LayThongTinNhaSanXuat(DieuKien);
        }
        public DataTable LayThongTinNhaCungCap(string DieuKien)
        {
            return cn.LayThongTinNhaCungCap(DieuKien);
        }
        public DataTable LayThongTinMaxe(string DieuKien)
        {
            return cn.LayThongTinMaXe(DieuKien);
        }
        public DataTable LayThongTinTenxe(string DieuKien)
        {
            return cn.LayThongTinTenXe(DieuKien);
        }
        public DataTable LayThongTinSoluong(string DieuKien)
        {
            return cn.LayThongTinSoluongton(DieuKien);
        }
        public DataTable LayThongTinDongia(string DieuKien)
        {
            return cn.LayThongTinDongia(DieuKien);
        }

        public int KiemTraMaxe(string x)
        {
            return cn.KiemTraMaxe(x);
        }
        public int KiemTraTenxe(string x)
        {
            return cn.KiemTraTenxe(x);
        }
        public int KiemTraSoluong(string x)
        {
            return cn.KiemTraSoluong(x);
        }
        public int KiemTraMaloaixe(string x)
        {
            return cn.KiemTraMaloaixe(x);
        }
        public int KiemTraMansx(string x)
        {
            return cn.KiemTraMansx(x);
        }
        public int KiemTraMancc(string x)
        {
            return cn.KiemTraMancc(x);
        }
        public int KiemTraDongia(string x)
        {
            return cn.KiemTraDongia(x);
        }
    }
}
