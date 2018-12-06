using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanXe_ENTITY;

namespace QuanLyBanXe_DAL
{
    public class NhaCungCap_DAL
    {
        KetNoiDaTa cn = new KetNoiDaTa();

        public int KiemTraThemNhaCungCap(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHACUNGCAP WHERE Mancungcap='" + x + "'"));
        }
        //Them
        public void ThemDuLieu(NhaCungCap et)
        {
            cn.ThucThiCauLenhSql(@"INSERT INTO NHACUNGCAP (Mancungcap, Tenncungcap, Diachi, Dienthoai, Email)  VALUES ('" + et.Mancc1 + "','" + et.Tenncc1 + "','" + et.Diachi1 + "','" + et.Dienthoai1 + "','" + et.Email1 + "') ");
        }
        //Sua
        public void SuaDuLieu(NhaCungCap et)
        {
            cn.ThucThiCauLenhSql(@"UPDATE    NHACUNGCAP SET  Tenncungcap =N'" + et.Tenncc1 + "', Diachi =N'" + et.Diachi1 + "', Dienthoai ='" + et.Dienthoai1 + "', Email ='" + et.Email1 + "' where Mancungcap='"+et.Mancc1+"'");
        }
        //Xoa
        public void XoaDuLieu(NhaCungCap et)
        {
            cn.ThucThiCauLenhSql(@"DELETE FROM NHACUNGCAP WHERE Mancungcap='"+et.Mancc1+"'");
        }
        //Lay
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHACUNGCAP "+DieuKien);
        }

        public DataTable LayThonTinNCC(string DieuKien)
        {
            return cn.GetDataTable("SELECT Mancungcap,Tenncungcap FROM NHACUNGCAP " + DieuKien);
        }

        public int KiemTraManCungCap(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHACUNGCAP WHERE Mancungcap='" + x + "'"));
        }
        public int KiemTraTennCungCap(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHACUNGCAP WHERE Tenncungcap='" + x + "'"));
        }
        public int KiemTraDiaChi(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHACUNGCAP WHERE Diachi='" + x + "'"));
        }
        public int KiemTraDienThoai(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHACUNGCAP WHERE Dienthoai='" + x + "'"));
        }
        public int KiemTraEmail(string x)
        {
            return int.Parse(cn.GetValue("SELECT COUNT(*) FROM NHACUNGCAP WHERE Email='" + x + "'"));
        }

        public DataTable LayThongTinMaNCungCap(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHACUNGCAP where Mancungcap='" + DieuKien + "'");
        }
        public DataTable LayThongTinTenNCungCap(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHACUNGCAP where Tenncungcap='" + DieuKien + "'");
        }

        public DataTable LayThongTinDiaChi(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHACUNGCAP where Diachi='" + DieuKien + "'");
        }
        public DataTable LayThongTinDienThoai(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHACUNGCAP where Dienthoai='" + DieuKien + "'");
        }
        public DataTable LayThongTinEmail(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM NHACUNGCAP where Email='" + DieuKien + "'");
        }
    }
}
