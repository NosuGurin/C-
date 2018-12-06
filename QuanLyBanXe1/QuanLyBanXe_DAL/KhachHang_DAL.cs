using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanXe_ENTITY;
using System.Data;

namespace QuanLyBanXe_DAL
{
    public class KhachHang_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();

        public int KiemTraThemKhachHang(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM KHACHHANG WHERE Makh='" + x + "'"));
        }
        //Thêm dữ liệu 
        public void ThemDuLieu(KhachHang et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO KHACHHANG(Makh, Tenkh, Dienthoai, Diachi) 
            VALUES ('" + et.Makh1 + "',N'" + et.Tenkh1 + "',N'" + et.Diachi1 + "','" + et.Dienthoai1 + "')");
        }
        //Sửa dữ liệu
        public void SuaDuLieu(KhachHang et)
        {
            cn.ThucThiCauLenhSql("UPDATE KHACHHANG SET Tenkh =N'" + et.Tenkh1 + "' ,Dienthoai = '" + et.Dienthoai1 + "', Diachi =N'" + et.Diachi1 + "' where Makh='" + et.Makh1 + "'");
        }
        //Xóa dữ liệu
        public void XoaDuLieu(KhachHang et)
        {
            cn.ThucThiCauLenhSql("DELETE FROM KHACHHANG where Makh='"+et.Makh1+"'");
        }
        //Lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from KHACHHANG "+ DieuKien);
        }

        public DataTable LayThongTinKH(string DieuKien)
        {
            return cn.GetDataTable("Select Makh,Tenkh,Dienthoai,Diachi from KHACHHANG " + DieuKien);
        }

        public int KiemTraMaKhachHang(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM KHACHHANG WHERE Makh='" + x + "'"));
        }
        public int KiemTraTenKhachHang(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM KHACHHANG WHERE Tenkh='" + x + "'"));
        }
        public int KiemTraDienThoai(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM KHACHHANG WHERE Dienthoai ='" + x + "'"));
        }
        public int KiemTraDiaChi(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM KHACHHANG WHERE DiaChi='" + x + "'"));
        }

        public DataTable LayThongTinMaKhacHang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM KHACHHANG where Makh='" + DieuKien + "'");
        }
        public DataTable LayThongTinTenKhachHang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM KHACHHANG where Tenkh='" + DieuKien + "'");
        }
        public DataTable LayThongTinDienthoai(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM KHACHHANG where Dienthoai='" + DieuKien + "'");
        }

        public DataTable LayThongTinDiachi(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM KHACHHANG where Diachi='" + DieuKien + "'");
        }
    }
}
