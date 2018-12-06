using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_DAL;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_BUS
{
    public class KhachHang_BUS
    {
        KhachHang_DAL cn = new KhachHang_DAL();

        public int KiemTraThem(string x)
        {
            return cn.KiemTraThemKhachHang(x);
        }
        //Thêm dữ liệu 
        public void ThemDuLieu(KhachHang et)
        {
            cn.ThemDuLieu(et);
        }
        //Sửa dữ liệu
        public void SuaDuLieu(KhachHang et)
        {
            cn.SuaDuLieu(et);
        }
        //Xóa dữ liệu
        public void XoaDuLieu(KhachHang et)
        {
            cn.XoaDuLieu(et);
        }
        //Lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.TaoBang(DieuKien);
        }

        public DataTable LayThongTinKH(string DieuKien)
        {
            return cn.LayThongTinKH(DieuKien);
        }

        public DataTable LayThongTinMaKhacHang(string DieuKien)
        {
            return cn.LayThongTinMaKhacHang(DieuKien);
        }
        public DataTable LayThongTinTenKhachHang(string DieuKien)
        {
            return cn.LayThongTinTenKhachHang(DieuKien);
        }
        public DataTable LayThongTinDienthoai(string DieuKien)
        {
            return cn.LayThongTinDienthoai(DieuKien);
        }
        public DataTable LayThongTinDiachi(string DieuKien)
        {
            return cn.LayThongTinDiachi(DieuKien);
        }

        public int KiemTraMaKhachHang(string x)
        {
            return cn.KiemTraMaKhachHang(x);
        }
        public int KiemTraTenKhachHang(string x)
        {
            return cn.KiemTraTenKhachHang(x);
        }
        public int KiemTraDienThoai(string x)
        {
            return cn.KiemTraDienThoai(x);
        }
        public int KiemTraDiaChi(string x)
        {
            return cn.KiemTraDiaChi(x);
        }
    }
}
