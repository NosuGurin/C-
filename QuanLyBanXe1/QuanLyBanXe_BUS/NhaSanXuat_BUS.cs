using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class NhaSanXuat_BUS
    {
        NhaSanXuat_DAL cn = new NhaSanXuat_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemNSX(x);
        }
        public void ThemDuLieu(NhaSanXuat et)
        {
            cn.ThemDuLieu(et);
        }
        public void SuaDuLieu(NhaSanXuat et)
        {
            cn.SuaDuLieu(et);
        }
        public void XoaDuLieu(NhaSanXuat et)
        {
            cn.XoaDuLieu(et);
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }

        public DataTable LayThongTinMaNSanXuat(string DieuKien)
        {
            return cn.LayThongTinNhaSanXuat(DieuKien);
        }
        public DataTable LayThongTinTenNSanXuat(string DieuKien)
        {
            return cn.LayThongTinTenNSanXuat(DieuKien);
        }
        public DataTable LayThongTinQuocGia(string DieuKien)
        {
            return cn.LayThongTinQuocgia(DieuKien);
        }
        public DataTable LayThongTinDienThoai(string DieuKien)
        {
            return cn.LayThongTinDienThoai(DieuKien);
        }
        public DataTable LayThongTinEmail(string DieuKien)
        {
            return cn.LayThongTinEmail(DieuKien);
        }

        public int KiemTraMaNSanXuat(string x)
        {
            return cn.KiemTraMansanxuat(x);
        }
        public int KiemTraTenNSanXuat(string x)
        {
            return cn.KiemTraTennsanxuat(x);
        }
        public int KiemTraQuocgia(string x)
        {
            return cn.KiemTraQuocGia(x);
        }
        public int KiemTraDienThoai(string x)
        {
            return cn.KiemTraDienthoai(x);
        }
        public int KiemTraMaEmail(string x)
        {
            return cn.KiemTraEmail(x);
        }
    }
}
