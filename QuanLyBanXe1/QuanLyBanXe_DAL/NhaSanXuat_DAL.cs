using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_DAL
{
    public class NhaSanXuat_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();

        public int KiemTraThemNSX(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHASANXUAT WHERE Mansanxuat ='" + x + "'"));
        }
        public void ThemDuLieu(NhaSanXuat et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO NHASANXUAT (Mansanxuat,Tennsanxuat, Quocgia, Dienthoai, Email )
VALUES     ('" + et.Mansx1 + "',N'" + et.Tennsx1 + "',N'" + et.Quocgia1 + "','" + et.Dienthoai1 + "','" + et.Email1 + "')");
        }
        public void SuaDuLieu(NhaSanXuat et)
        {
            cn.ThucThiCauLenhSql(@"UPDATE NHASANXUAT
SET Tennsanxuat =N'" + et.Tennsx1 + "', Quocgia =N'" + et.Quocgia1 + "', Dienthoai ='" + et.Dienthoai1 + "', Email ='" + et.Email1 + "' where Mansanxuat='"+et.Mansx1+"'");
        }
        public void XoaDuLieu(NhaSanXuat et)
        {
            cn.ThucThiCauLenhSql(@"DELETE FROM NHASANXUAT WHERE Mansanxuat='"+et.Mansx1+"'");
        }

        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHASANXUAT "+DieuKien);
        }

        public DataTable LayThongTinNhaSanXuat(string DieuKien)
        {
            return cn.GetDataTable("SELECT Mansanxuat,Tennsanxuat FROM NHASANXUAT " + DieuKien);
        }

        public int KiemTraMansanxuat(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHASANXUAT WHERE Mansanxuat='" + x + "'"));
        }
        public int KiemTraTennsanxuat(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHASANXUAT WHERE Tennsanxuat='" + x + "'"));
        }
        public int KiemTraQuocGia(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHASANXUAT WHERE Quocgia='" + x + "'"));
        }
        public int KiemTraDienthoai(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHASANXUAT WHERE Dienthoai='" + x + "'"));
        }
        public int KiemTraEmail(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHASANXUAT WHERE Email='" + x + "'"));
        }

        public DataTable LayThongTinMaNSanXuat(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHASANXUAT where Mansanxuat='" + DieuKien + "'");
        }
        public DataTable LayThongTinTenNSanXuat(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHASANXUAT where Tennsanxuat='" + DieuKien + "'");
        }

        public DataTable LayThongTinQuocgia(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHASANXUAT where Quocgia='" + DieuKien + "'");
        }
        public DataTable LayThongTinDienThoai(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHASANXUAT where Dienthoai='" + DieuKien + "'");
        }
        public DataTable LayThongTinEmail(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHASANXUAT where Email='" + DieuKien + "'");
        }
    }
}
