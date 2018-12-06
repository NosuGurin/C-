using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class NhanVien_BUS
    {
        NhanVien_DAL cn = new NhanVien_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemNhanVien(x);
        }
        
        //Thêm
        public void ThemDuLieu(NhanVien et)
        {
            cn.ThemDuLieu(et);
        }
        //Sửa
        public void SuaDuLieu(NhanVien et)
        {
            cn.SuaDuLieu(et);
        }
        public void SuaMatKhau(string a,string b)
        {
            cn.SuaMatKhau(a,b);
        }
        //Xóa
        public void XoaDuLieu(NhanVien et)
        {
            cn.XoaDuLieu(et);
        }

        //Lấy
        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }

        public DataTable LayThongTinNhanVien(string DieuKien)
        {
            return cn.LayThongTinNV(DieuKien);
        }
        public DataTable KiemTraDN(string manv,string pass)
        {
            return cn.KiemTraDangNhap(manv, pass);
        }

        public DataTable LayThongTinMaNhanVien(string DieuKien)
        {
            return cn.LayThongTinMaNhanVien(DieuKien);
        }
        public DataTable LayThongTinTenNhanVien(string DieuKien)
        {
            return cn.LayThongTinTenNhanVien(DieuKien);
        }
        public DataTable LayThongTinNgaySinh(string DieuKien)
        {
            return cn.LayThongTinNgaySinh(DieuKien);
        }
        public DataTable LayThongTinDiaChi(string DieuKien)
        {
            return cn.LayThongTinDiaChi(DieuKien);
        }
        public DataTable LayThongTinDienthoai(string DieuKien)
        {
            return cn.LayThongTinDienthoai(DieuKien);
        }
        public DataTable LayThongTinGioiTinh(string DieuKien)
        {
            return cn.LayThongTinGioiTinh(DieuKien);
        }
        public DataTable LayThongTinPass(string DieuKien)
        {
            return cn.LayThongTinPass(DieuKien);
        }
        public string LayThongTinChucVu(string DieuKien)
        {
            return cn.LayThongTinChucVu(DieuKien);
        }
        public int KiemTraMaNhanVien(string x)
        {
            return cn.KiemTraMaNhanVien(x);
        }
        public int KiemTraTenNhanVien(string x)
        {
            return cn.KiemTraTenNhanVien(x);
        }
        public int KiemTraNgaySinh(string x)
        {
            return cn.KiemTraNgaySinh(x);
        }
        public int KiemTraDiaChi(string x)
        {
            return cn.KiemTraDiaChi(x);
        }
        public int KiemTraDienthoai(string x)
        {
            return cn.KiemTraDienthoai(x);
        }
        public int KiemTraGioiTinh(string x)
        {
            return cn.KiemTraGioiTinh(x);
        }
        public int KiemTraPass(string x)
        {
            return cn.KiemTraPass(x);
        }
        public int KiemTraChucVu(string x)
        {
            return cn.KiemTraChucVu(x);
        }

    }
}
