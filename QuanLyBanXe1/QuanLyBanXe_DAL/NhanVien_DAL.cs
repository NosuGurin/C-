using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanXe_ENTITY;
using System.Data;

namespace QuanLyBanXe_DAL
{
    public class NhanVien_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();

        public int KiemTraThemNhanVien(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Manv='" + x + "'"));
        }
        //Thêm
         public void ThemDuLieu(NhanVien et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO NHANVIEN
                      (Manv, Tennv, Ngaysinh, Diachi, Dienthoai, Gioitinh, Pass,Chucvu)
VALUES     ('" + et.Manv1 + "','" + et.Tennv1 + "','" + et.Ngaysinh1 + "','" + et.Diachi1 + "','" + et.Dienthoai1 + "','" + et.Gioitinh1 + "','" + et.Pass1 + "','" + et.Chucvu1 + "') ");
        }
        //Sửa
         public void SuaDuLieu(NhanVien et)
         {
             cn.ThucThiCauLenhSql(@"UPDATE    NHANVIEN
SET              Tennv ='" + et.Tennv1 + "', Ngaysinh ='" + et.Ngaysinh1 + "', Diachi ='" + et.Diachi1 + "', Dienthoai ='" + et.Dienthoai1 + "', Gioitinh ='" + et.Gioitinh1 + "', Pass ='" + et.Pass1 + "', Chucvu ='" + et.Chucvu1 + "' where Manv='" + et.Manv1 + "'");
         }
        //kiem tra pass ton tai
         public int KiemTraPass(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Pass='" + x + "'"));
         }
        //Sửa mật khẩu
         public void SuaMatKhau(string a,string b)
         {
             cn.ThucThiCauLenhSql(@"UPDATE    NHANVIEN
SET              Pass ='" + a + "' where Pass='" + b + "'");
         }
        //Xóa
         public void XoaDuLieu(NhanVien et)
         {
             cn.ThucThiCauLenhSql(@"DELETE FROM NHANVIEN WHERE Manv='"+et.Manv1+"'");
         }

        //Lấy
         public DataTable TaoBang(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN "+DieuKien);
         }

         public DataTable LayThongTinNV(string DieuKien)
         {
             return cn.GetDataTable("Select Manv,Tennv from NHANVIEN " + DieuKien);
         }
            
         public DataTable KiemTraDangNhap(string manv, string pass)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN WHERE Manv='" + manv + "' AND Pass='" + pass + "'");
         }

         public int KiemTraMaNhanVien(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Manv='" + x + "'"));
         }
         public int KiemTraTenNhanVien(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Tennv='" + x + "'"));
         }
         public int KiemTraNgaySinh(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Ngaysinh='" + x + "'"));
         }
         public int KiemTraDiaChi(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE DiaChi='" + x + "'"));
         }
         public int KiemTraDienthoai(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Dienthoai='" + x + "'"));
         }
         public int KiemTraGioiTinh(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Gioitinh='" + x + "'"));
         }
         public int KiemTraChucVu(string x)
         {
             return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHANVIEN WHERE Chucvu='" + x + "'"));
         }
         

         public DataTable LayThongTinMaNhanVien(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN where Manv='" + DieuKien + "'");
         }
         public DataTable LayThongTinTenNhanVien(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN where Tennv='" + DieuKien + "'");
         }

         public DataTable LayThongTinNgaySinh(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN where Ngaysinh='" + DieuKien + "'");
         }
         public DataTable LayThongTinDiaChi(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN where Diachi='" + DieuKien + "'");
         }
         public DataTable LayThongTinDienthoai(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN where Dienthoai='" + DieuKien + "'");
         }
         public DataTable LayThongTinGioiTinh(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN where Gioitinh='" + DieuKien + "'");
         }
         public DataTable LayThongTinPass(string DieuKien)
         {
             return cn.GetDataTable("SELECT * FROM NHANVIEN where Pass='" + DieuKien + "'");
         }
         public string LayThongTinChucVu(string DieuKien)
         {
             return cn.GetValue("SELECT Chucvu FROM NHANVIEN where Manv='" + DieuKien + "'");
         }
    }
}
